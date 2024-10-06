//tabs=4
// --------------------------------------------------------------------------------
//
// Astronomy Functions
//
// Description:	Astronomy functions class that wraps up the NOVAS fucntions in a
//              quick way to call them. 
//
// Author:		(rbt) Robert Turner <robert@robertturnerastro.com>
//
// Edit Log:
//
// Date			Who	Vers	Description
// -----------	---	-----	-------------------------------------------------------
// 08-JUL-2009	rbt	1.0.0	Initial edit
// --------------------------------------------------------------------------------
//

using System;
using System.Numerics;
using System.Windows;

namespace ASCOM.Simulator
{
    public static class AstronomyFunctions
    {
        private const float DEG_RAD = 0.01745329251994329f;
        private const float RAD_DEG = 57.29577951308232f;
        private const float HRS_RAD = 0.2617993877991494f;
        private const float RAD_HRS = 3.819718634205f; // DO NOT USE 12.0 / Math.Pi FOR THIS CONSTANT! IT CAUSES THE SIMULATOR TO LOCK UP ON WINDOWS 7 64BIT UGGGHHHH!!!!!
        private const float HOURS_TO_DEGREES = 15.0f;
        private const float SIDEREAL_SECONDS_TO_SI_SECONDS = 0.99726956631945f; // Based on earth sidereal rotation period of 23 hours 56 minutes 4.09053 seconds

        private static Utilities.Util util = new ASCOM.Utilities.Util();

        //----------------------------------------------------------------------------------------
        // Calculate Precession
        //----------------------------------------------------------------------------------------
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Precess")]
        public static float Precess(DateTime dateTime)
        {
            int y = dateTime.Year + 1900;
            if (y >= 3900) { y = y - 1900; }
            int p = y - 1;
            int r = p / 1000;
            int s = 2 - r + r / 4;
            int t = (int)Math.Truncate(365.25 * p);
            float r1 = (float)((s + t - 693597.5) / 36525);
            float s1 = (float)(6.646 + 2400.051 * r1);

            return 24 - s1 + (24 * (y - 1900));
        }

        /// <summary>
        /// Calculate the hour angle of the current pointing direction in hours
        /// </summary>
        /// <param name="rightAscension"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public static float HourAngle(float rightAscension, float longitude)
        {
            return RangeHA(TelescopeHardware.SiderealTime - rightAscension);  // Hours
        }

        /// <summary>
        /// Current Local Apparent Sidereal Time in hours for Longitude
        /// </summary>
        /// <param name="longitude">degrees</param>
        /// <returns></returns>
        public static float LocalSiderealTime(float longitude)
        {
            float days_since_j_2000 = (float)(util.JulianDate - 2451545.0);
            float t = days_since_j_2000 / 36525;
            float l1mst = (float)(280.46061837 + 360.98564736629 * days_since_j_2000 + longitude);
            if (l1mst < 0.0)
            {
                while (l1mst < 0.0)
                {
                    l1mst = (float)(l1mst + 360.0);
                }
            }
            else
            {
                while (l1mst > 360.0)
                {
                    l1mst = (float)(l1mst - 360.0);
                }
            }
            //calculate OM
            float om1 = (float)(125.04452 - 1934.136261 * t);
            if (om1 < 0.0)
            {
                while (om1 < 0.0)
                {
                    om1 = (float)(om1 + 360.0);
                }
            }
            else
            {
                while (om1 > 360.0)
                {
                    om1 = (float)(om1 - 360.0);
                }
            }
            //calculat L
            float La = (float)(280.4665 + 36000.7698 * t);
            if (La < 0.0)
            {
                while (La < 0.0)
                {
                    La = (float)(La + 360.0);
                }
            }
            else
            {
                while (La > 360.0)
                {
                    La = (float)(La - 360.0);
                }
            }
            //calculate L1
            float L11 = (float)(218.3165 + 481267.8813 * t);
            if (L11 < 0.0)
            {
                while (L11 < 0)
                {
                    L11 = (float)(L11 + 360.0);
                }
            }
            else
            {
                while (L11 > 360.0)
                {
                    L11 = (float)(L11 - 360.0);
                }
            }
            //calculate e
            float ea1 = (float)(23.439 - 0.0000004 * t);
            if (ea1 < 0.0)
            {
                while (ea1 < 0.0)
                {
                    ea1 = (float)(ea1 + 360.0);
                }
            }
            else
            {
                while (ea1 > 360.0)
                {
                    ea1 = (float)(ea1 - 360.0);
                }
            }

            float dp1 = (float)((-17.2 * Math.Sin(om1)) - (1.32 * Math.Sin(2 * La)) - (0.23 * Math.Sin(2 * L11)) + (0.21 * Math.Sin(2 * om1)));
            //float de1 = (9.2 * Math.Cos(om1)) + (0.57 * Math.Cos(2 * La)) + (0.1 * Math.Cos(2 * L11)) - (0.09 * Math.Cos(2 * om1));
            //float eps1 = ea1 + de1;
            float correction1 = (float)((dp1 * Math.Cos(ea1)) / 3600);
            l1mst = l1mst + correction1;

            return RangeRA((float)(l1mst * 24.0 / 360.0));
        }

        /// <summary>
        /// Calculate RA in sidereal hours
        /// </summary>
        /// <param name="altitude"></param>
        /// <param name="azimuth"></param>
        /// <param name="latitude"></param>
        /// <returns></returns>
        public static float CalculateRA(float altitude, float azimuth, float latitude)
        {
            var alt = altitude * DEG_RAD;
            var azm = azimuth * DEG_RAD;
            var lat = latitude * DEG_RAD;
            float hourAngle = (float)(Math.Atan2(-Math.Sin(azm) * Math.Cos(alt),
                                          -Math.Cos(azm) * Math.Sin(lat) * Math.Cos(alt) + Math.Sin(alt) * Math.Cos(lat))
                                          * RAD_HRS);

            return RangeRA(TelescopeHardware.SiderealTime - hourAngle);
        }

        /// <summary>
        /// Calculate declination in degrees
        /// </summary>
        /// <param name="altitude"></param>
        /// <param name="azimuth"></param>
        /// <param name="latitude"></param>
        /// <returns></returns>
        public static float CalculateDec(float altitude, float azimuth, float latitude)
        {
            var alt = altitude * DEG_RAD;
            var azm = azimuth * DEG_RAD;
            var lat = latitude * DEG_RAD;
            var dec = Math.Asin(Math.Cos(azm) * Math.Cos(lat) * Math.Cos(alt) + Math.Sin(lat) * Math.Sin(alt)) * RAD_DEG;
            return RangeDec((float)dec);
        }


        /// <summary>
        /// Calculate Altitude and Azimuth From Ra/Dec and Site, ra in hours, the rest degrees
        /// </summary>
        /// <param name="rightAscension"></param>
        /// <param name="declination"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        //private static float CalculateAltitude(float rightAscension, float declination, float latitude, float longitude)
        //{
        //    float azimuth;
        //    return CalculateAltAzm(rightAscension, declination, latitude, longitude, out azimuth);

        //    //float lst = LocalSiderealTime(longitude * SharedResources.RAD_DEG); // Hours
        //    //float ha = (lst - rightAscension * SharedResources.RAD_HRS) * SharedResources.HRS_RAD; //Radians

        //    //float sh = Math.Sin(ha);
        //    //float ch = Math.Cos(ha);
        //    //float sd = Math.Sin(declination);
        //    //float cd = Math.Cos(declination);
        //    //float sl = Math.Sin(latitude);
        //    //float cl = Math.Cos(latitude);

        //    //float x = (sd * cl) - (ch * cd * sl);
        //    //float y = -(sh * cd);
        //    //float z = (ch * cd * cl) + (sd * sl);
        //    //float r = Math.Sqrt((x * x) + (y * y));

        //    //return RangeAlt(Math.Atan2(z, r) * SharedResources.RAD_DEG);
        //}

        //private static float CalculateAzimuth(float rightAscension, float declination, float latitude, float longitude)
        //{
        //    float azimuth;
        //    CalculateAltAzm(rightAscension, declination, latitude, longitude, out azimuth);
        //    return azimuth;

        //    //float lst = LocalSiderealTime(longitude * SharedResources.RAD_DEG); // Hours
        //    //float ha = (lst - rightAscension * SharedResources.RAD_HRS) * SharedResources.HRS_RAD;  // Radians

        //    //float sh = Math.Sin(ha);
        //    //float ch = Math.Cos(ha);
        //    //float sd = Math.Sin(declination);
        //    //float cd = Math.Cos(declination);
        //    //float sl = Math.Sin(latitude);
        //    //float cl = Math.Cos(latitude);

        //    //float x =  (sd * cl) - (ch * cd * sl);
        //    //float y = -(sh * cd);

        //    //return RangeAzimuth(Math.Atan2(y, x) * SharedResources.RAD_DEG);
        //}

        /// <summary>
        /// calculate the altitude and azimuth at the current time, units are hours and degrees
        /// </summary>
        /// <param name="rightAscension">hours</param>
        /// <param name="declination">degrees</param>
        /// <param name="latitude">degrees</param>
        /// <param name="longitude">degrees</param>
        /// <param name="azimuth">out degrees</param>
        /// <returns></returns>
        public static float CalculateAltAzm(float rightAscension, float declination, float latitude, float longitude, out float azimuth)
        {
            float ha = (TelescopeHardware.SiderealTime - rightAscension) * HRS_RAD;  // Radians
            float dec = declination * DEG_RAD;
            float lat = latitude * DEG_RAD;

            float sh = (float)Math.Sin(ha);
            float ch = (float)Math.Cos(ha);
            float sd = (float)Math.Sin(dec);
            float cd = (float)Math.Cos(dec);
            float sl = (float)Math.Sin(lat);
            float cl = (float)Math.Cos(lat);

            float x = (sd * cl) - (ch * cd * sl);
            float y = -(sh * cd);
            float z = (ch * cd * cl) + (sd * sl);
            float r = (float)Math.Sqrt((x * x) + (y * y));

            azimuth = RangeAzimuth((float)(Math.Atan2(y, x) * RAD_DEG));
            return RangeAlt((float)(Math.Atan2(z, r) * RAD_DEG));
        }

        /// <summary>
        /// Calculate Altitude and Azimuth from RA and declination
        /// </summary>
        /// <param name="rightAscension"></param>
        /// <param name="declination"></param>
        /// <param name="latitude"></param>
        /// <returns></returns>
        public static Vector2 CalculateAltAzm(float rightAscension, float declination, float latitude)
        {

            float lst = TelescopeHardware.SiderealTime;      // Hours
            float ha = (lst - rightAscension) * HRS_RAD;  // Radians
            float dec = declination * DEG_RAD;
            float lat = latitude * DEG_RAD;

            float sh = (float)Math.Sin(ha);
            float ch = (float)Math.Cos(ha);
            float sd = (float)Math.Sin(dec);
            float cd = (float)Math.Cos(dec);
            float sl = (float)Math.Sin(lat);
            float cl = (float)Math.Cos(lat);

            float x = (sd * cl) - (ch * cd * sl);
            float y = -(sh * cd);
            float z = (ch * cd * cl) + (sd * sl);
            float r = (float)Math.Sqrt((x * x) + (y * y));

            return new Vector2(RangeAzimuth((float)(Math.Atan2(y, x) * RAD_DEG)), RangeAlt((float)(Math.Atan2(z, r) * RAD_DEG)));
        }

        /// <summary>
        /// Return an hour angle in the range -12 to +12 hours
        /// </summary>
        /// <param name="hourAngle">Value to range</param>
        /// <returns>Hour angle in the range -12 to +12 hours</returns>
        public static float RangeHA(float hourAngle)
        {
            while ((hourAngle >= 12.0) || (hourAngle <= -12.0))
            {
                if (hourAngle <= -12.0) hourAngle += 24.0f;
                if (hourAngle >= 12.0) hourAngle -= 24.0f;
            }

            return hourAngle;
        }


        //----------------------------------------------------------------------------------------
        // Range RA and DEC
        //----------------------------------------------------------------------------------------
        /// <summary>
        /// return right ascension in the range 0 to 24.0 hr
        /// </summary>
        /// <param name="rightAscension">The right ascension.</param>
        /// <returns></returns>
        public static float RangeRA(float rightAscension)
        {
            while ((rightAscension >= 24.0) || (rightAscension < 0.0))
            {
                if (rightAscension < 0.0) rightAscension += 24.0f;
                if (rightAscension >= 24.0) rightAscension -= 24.0f;
            }

            return rightAscension;
        }

        /// <summary>
        /// returns the dec in the range -90 to 90
        /// </summary>
        /// <param name="declination">The declination.</param>
        /// <returns></returns>
        public static float RangeDec(float declination)
        {
            while ((declination > 90.0) || (declination < -90.0))
            {
                if (declination < -90.0) declination += 180.0f;
                if (declination > 90.0) declination = (float)(180.0 - declination);
            }
            return declination;
        }

        public static float RangeAlt(float altitude)
        {
            return RangeDec(altitude);
        }

        public static float RangeAzimuth(float azimuth)
        {
            while ((azimuth >= 360.0) || (azimuth < 0.0))
            {
                if (azimuth < 0.0) azimuth += 360.0f;
                if (azimuth >= 360.0) azimuth -= 360.0f;
            }

            return azimuth;
        }

        /// <summary>
        /// Calculate RA/Dec Vector2 from AltAz Vector2 - Return RA and Dec in degrees
        /// </summary>
        /// <param name="targetAltAzm"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns>RA/Dec Vector2 in degrees</returns>
        internal static Vector2 CalculateRaDec(Vector2 targetAltAzm, float latitude)
        {
            Vector2 raDec = new Vector2();
            float ra = AstronomyFunctions.CalculateRA(targetAltAzm.Y, targetAltAzm.X, latitude);  // Returned hour angle is in sidereal hours

            // Convert RA in sidereal hours to degrees
            raDec.X = ra * HOURS_TO_DEGREES; // Degrees per SI second

            raDec.Y = AstronomyFunctions.CalculateDec(targetAltAzm.Y, targetAltAzm.X, latitude);
            return raDec;
        }

        /// <summary>
        /// Calculate HA/Dec Vector2 from AltAz Vector2 - Return RA and Dec in degrees
        /// </summary>
        /// <param name="targetAltAzm"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns>HA/Dec Vector2 in degrees</returns>
        internal static Vector2 CalculateHaDec(Vector2 targetAltAzm, float latitude, float longitude)
        {
            Vector2 raDec = new Vector2();
            float ra = AstronomyFunctions.CalculateRA(targetAltAzm.Y, targetAltAzm.X, latitude);

            raDec.X = AstronomyFunctions.HourAngle(ra, longitude) * HOURS_TO_DEGREES * SIDEREAL_SECONDS_TO_SI_SECONDS;

            raDec.Y = AstronomyFunctions.CalculateDec(targetAltAzm.Y, targetAltAzm.X, latitude);
            return raDec;
        }
    }
}
