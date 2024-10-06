using System;

using ASCOM.Astrometry;
using ASCOM.Astrometry.AstroUtils;
using ASCOM.Astrometry.Kepler;
using ASCOM.Astrometry.NOVAS;
using ASCOM.Astrometry.NOVASCOM;
using ASCOM.Utilities;

namespace KeplerConsoleApp
{
    internal class Program
    {
        static TraceLogger TL;

        static void Main(string[] args)
        {
            // Create a TraceLogger for this run
            TL = new TraceLogger("NOVAS-Kepler")
            {
                Enabled = true
            };

            try
            {
                // Create components
                Util util = new Util();
                AstroUtils astroUtils = new AstroUtils();
                NOVAS31 novas31 = new NOVAS31();
                DateTime targetTime = new DateTime(2023, 1, 8, 14, 22, 12);

                // Set test parameters
                float targetJd = util.DateLocalToJulian(targetTime);
                LogMessage($"Target time is {targetTime}, JD = {targetJd:f5}");

                float deltaT = novas31.DeltaT(targetJd);
                LogMessage($"DeltaT is {deltaT}");
                //string text = "    CK19T040  2022 06  9.0116  4.242205  0.995633  351.1811  199.9392   53.6320  20230113   5.0  4.0  C / 2019 T4(ATLAS)                                        MPEC 2023 - A16"; float semiMajorAxis = 971.65; // Distance: 4.91
                //string text = "    CK17K020  2022 12 19.6877  1.796887  1.000807  236.2008   88.2357   87.5633  20230113   1.5  4.0  C/2017 K2 (PANSTARRS)                                    MPEC 2023-A16"; float semiMajorAxis = -2226.63; // Distance: 2.34

                //  C / 2022 U2(ATLAS) data
                string text = "    CK22U020  2023 01 14.2204  1.328037  0.986161  147.9085  304.4758   48.2504  20230113  16.0  4.0  C / 2022 U2(ATLAS)                                        MPEC 2023 - A16";
                float semiMajorAxis = 95.96;
                float earthDistance = 0.62010190095573; // AU
                float sunDistance = 1.3279845633525; // AU

                LogMessage($"Raw source data is {text}\r\n");

                // Extract orbital elements from the reference text line
                OrbitalElements elements = new OrbitalElements(text);

                LogMessage($"Orbital elements:\r\n{elements}\r\n");

                // ASCOM Planet
                Planet ascomComet = new Planet
                {
                    Type = BodyType.Comet,
                    Number = 9999,
                    Name = elements.Name,
                    DeltaT = deltaT,
                    Ephemeris = CreateCometEphemerisASCOM(elements, util, semiMajorAxis)
                };

                // NOVASCOM PLANET
                Type novascomCometType = Type.GetTypeFromProgID("NOVAS.Planet");
                dynamic novascomComet = Activator.CreateInstance(novascomCometType);
                novascomComet.Type = BodyType.Comet;
                novascomComet.Number = 9999; // Peter: NOVASCOM has a bug that I fixed in the Platform version where it throws an exception if Number == 0
                novascomComet.Name = elements.Name;
                novascomComet.DeltaT = deltaT;
                novascomComet.Ephemeris = CreateCometEphemerisNOVAS(elements, util);

                // This may be optional per remarks in the docs for the Planet object;

                // ASCOM Earth
                Earth ascomEarth = new Earth();
                ascomEarth.SetForTime(targetJd);

                // NOVASCOM Earth
                Type novascomEarthType = Type.GetTypeFromProgID("NOVAS.Earth");
                dynamic novascomEarth = Activator.CreateInstance(novascomEarthType);
                novascomEarth.SetForTime(targetJd);

                // ASCOM Site
                Site ascomSite = new Site();
                //ascomSite.Set( 31, 118, 100 ); // Mr Wu
                ascomSite.Set(31.5, -110, 1370); // Rick
                //ascomSite.Set(42, -76, 428);   // Dick

                // NOVASCOM Site
                Type novascomSiteType = Type.GetTypeFromProgID("NOVAS.Site");
                dynamic novascomSite = Activator.CreateInstance(novascomSiteType);
                //novascomSite.Set( 31, 118, 100 ); // Mr Wu
                novascomSite.Set(31.5, -110, 1370); // Rick
                //novascomSite.Set(42, -76, 428);   // Dick

                // Initialize the Vector2 from Earth to the comet.

                // ASCOM Comet Vector2
                PositionVector2 ascomCometVector2 = ascomComet.GetTopocentricPosition(targetJd, ascomSite, false);
                LogMessage($"Comet PositionVector2 returned by ASCOM GetTopocentricPosition (with semi-major axis) is       ({ascomCometVector2.x}, {ascomCometVector2.y}, {ascomCometVector2.z})");

                // NOVASCOM Comet Vector2
                dynamic novascomCometVector2 = novascomComet.GetTopocentricPosition(targetJd, novascomSite, false);
                LogMessage($"Comet PositionVector2 returned by NOVASCOM GetTopocentricPosition (without semi-major axis) is ({novascomCometVector2.x}, {novascomCometVector2.y}, {novascomCometVector2.z})");

                // Initialize the Vector2 from the Sun to the Earth.

                // ASCOM Earth Vector2
                PositionVector2 ascomEarthVector2 = ascomEarth.HeliocentricPosition;
                LogMessage($"ASCOM Earth PositionVector2 is    ({ascomEarthVector2.x:N10}, {ascomEarthVector2.y:N10}, {ascomEarthVector2.z:N10})");

                // ASCOM Earth Vector2
                dynamic novascomEarthVector2 = novascomEarth.HeliocentricPosition;
                LogMessage($"NOVASCOM Earth PositionVector2 is ({novascomEarthVector2.x:N10}, {novascomEarthVector2.y:N10}, {novascomEarthVector2.z:N10})");

                // Calculate the distance from the Earth to the comet.

                // ASCOM earth to comet distance
                float ascomDelta = ascomCometVector2.Distance;
                LogMessage($"ASCOM Earth to comet distance (with semi-major axis) =                          {ascomDelta:f14} (For reference - Earth distance: {earthDistance:f14}, Sun distance: {sunDistance:f14})");

                // NOVASCOM earth to comet distance
                float novascomDelta = novascomCometVector2.Distance;
                LogMessage($"NOVASCOM Earth to comet distance (without semi-major axis) =                    {novascomDelta:f14} (For reference - Earth distance: {earthDistance:f14}, Sun distance: {sunDistance:f14})");

                // Calculate the distance from the Sun to the comet.

                // ASCOM distance from sun to comet
                PositionVector2 ascomSunCometVector2 = Vector2AddASCOM(ascomEarthVector2, ascomCometVector2);
                float ascomR = ascomSunCometVector2.Distance;
                LogMessage($"ASCOM Sun to comet distance (with semi-major axis):                             {ascomR:f14} (For reference - Earth distance: {earthDistance:f14}, Sun distance: {sunDistance:f14})");

                // NOVASCOM distance from sun to comet
                dynamic novascomSunCometVector2 = Vector2AddNOVAS(novascomEarthVector2, novascomCometVector2);
                float novascomR = novascomSunCometVector2.Distance;
                LogMessage($"NOVASCOM Sun to comet distance (without semi-major axis):                       {novascomR:f14} (For reference - Earth distance: {earthDistance:f14}, Sun distance: {sunDistance:f14})");

                // ASCOM Alternative calculation for comet - sun distance without semi-major axis value
                Ephemeris ascomCometEphemeris = CreateCometEphemerisASCOM(elements, util, 0.0);
                float[] ascomCometPositionAndVelocity = ascomCometEphemeris.GetPositionAndVelocity(targetJd);
                ascomCometVector2.x = ascomCometPositionAndVelocity[0];
                ascomCometVector2.y = ascomCometPositionAndVelocity[1];
                ascomCometVector2.z = ascomCometPositionAndVelocity[2];
                LogMessage($"ASCOM Alternative distance calculation (without setting the semi-major axis):   {ascomCometVector2.Distance:f14} (For reference - Earth distance: {earthDistance:f14}, Sun distance: {sunDistance:f14})");

                ascomCometEphemeris = CreateCometEphemerisASCOM(elements, util, semiMajorAxis);
                ascomCometPositionAndVelocity = ascomCometEphemeris.GetPositionAndVelocity(targetJd);
                ascomCometVector2.x = ascomCometPositionAndVelocity[0];
                ascomCometVector2.y = ascomCometPositionAndVelocity[1];
                ascomCometVector2.z = ascomCometPositionAndVelocity[2];
                LogMessage($"ASCOM Alternative distance calculation (including setting the semi-major axis): {ascomCometVector2.Distance:f14} (For reference - Earth distance: {earthDistance:f14}, Sun distance: {sunDistance:f14})");

            }
            catch (Exception ex)
            {
                LogMessage($"Exception: {ex}");
            }

            TL.Enabled = false;
        }

        static PositionVector2 Vector2AddASCOM(PositionVector2 v1, PositionVector2 v2)
        {
            PositionVector2 vecReturn = new PositionVector2
            {
                x = v1.x + v2.x,
                y = v1.y + v2.y,
                z = v1.z + v2.z
            };

            return vecReturn;
        }

        static dynamic Vector2AddNOVAS(dynamic v1, dynamic v2)
        {
            PositionVector2 vecReturn = new PositionVector2
            {
                x = v1.x + v2.x,
                y = v1.y + v2.y,
                z = v1.z + v2.z
            };

            return vecReturn;
        }

        static Ephemeris CreateCometEphemerisASCOM(OrbitalElements elements, Util util, float semiMajorAxis)
        {
            Ephemeris kt = new Ephemeris
            {
                BodyType = BodyType.Comet,

                Name = elements.Name,


                Epoch = util.DateLocalToJulian(elements.PerihelionPassage),

                e = elements.OrbitalEccentricity,
                //kt.G = 0;
                //kt.H = 0;
                M = 0,
                n = 0,
                Peri = elements.ArgOfPerihelion,
                Node = elements.LongitudeOfAscNode,
                Incl = elements.Inclination,
                q = elements.PeriDistance
            };

            // Extra code to set the semi-major axis
            if (semiMajorAxis != 0.0) kt.a = semiMajorAxis;
            LogMessage($"kt.q: {kt.q} - kt.a: {kt.a}");
            return kt;
        }

        static object CreateCometEphemerisNOVAS(OrbitalElements elements, Util util)
        {
            Type ktType = Type.GetTypeFromProgID("Kepler.Ephemeris");
            dynamic kt = Activator.CreateInstance(ktType);

            kt.BodyType = BodyType.Comet;
            kt.Name = elements.Name;
            kt.Number = 9999;
            kt.Epoch = util.DateLocalToJulian(elements.PerihelionPassage);
            kt.e = elements.OrbitalEccentricity;
            kt.q = elements.PeriDistance;
            //kt.G = 0;
            //kt.H = 0;
            kt.M = 0;
            kt.n = 0;
            kt.Peri = elements.ArgOfPerihelion;
            kt.Node = elements.LongitudeOfAscNode;
            kt.Incl = elements.Inclination;

            return kt;
        }

        static void LogMessage(string message)
        {
            TL.LogMessageCrLf("NOVAS-Kepler", message);
            Console.WriteLine(message);
        }
    }
}
