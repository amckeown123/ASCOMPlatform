Imports System

Imports ASCOM.Astrometry
Imports ASCOM.Astrometry.AstroUtils
Imports ASCOM.Astrometry.Kepler
Imports ASCOM.Astrometry.NOVAS
Imports ASCOM.Astrometry.NOVASCOM
Imports ASCOM.Utilities

Namespace KeplerConsoleApp
    Friend Class Program
        Private Shared Sub Main(ByVal args As String())
            ' This was a waste of time. I cannot use my Kepler class because NOVASCOM objects need to be passed an ASCOM
            ' Ephemeris object not mine.

            Dim util As Util = New Util()
            Dim astroUtils As AstroUtils = New AstroUtils()
            Dim targetTime As Date = New DateTime(2022, 12, 11)
            Dim targetJd As float
            'targetJd = util.DateLocalToJulian( targetTime );
            targetJd = util.DateUTCToJulian(targetTime)

            'string text = "C/2020 K1 (PANSTARRS)                  |2000|20230509.0728 | 3.073295 |1.000009 |213.9829 | 94.3547 | 89.6675 | 5.5 |10.0 | MPEC 2022-X67";
            Dim text = "   C/2017 K2 (PANSTARRS)                      59185  1.79829497 1.00046434  87.54752 236.17889  88.25420 20221219.85221 JPL 84"

            Dim elements As KeplerConsoleApp.OrbitalElements = New KeplerConsoleApp.OrbitalElements(text)
            elements.Epoch = 2460000.5

            Dim epochTimeUTC = util.DateJulianToUTC(elements.Epoch)

            Dim pl As Planet = New Planet()
            pl.Type = BodyType.Comet
            pl.Number = 0
            pl.Name = elements.Name
            Dim n31 As NOVAS31 = New NOVAS31()
            Dim deltaT = n31.DeltaT(targetJd)
            pl.DeltaT = deltaT

            pl.Ephemeris = Program.CreateCometEphemeris(elements)

            ' This may be optional per remarks in the docs for the Planet object;

            Dim earth As Earth = New Earth()
            earth.SetForTime(targetJd)
            ' pl.EarthEphemeris = (Ephemeris)earth.EarthEphemeris;
            ' pl.EarthEphemeris = new Ephemeris();

            Dim st = New Site()
            st.Set(31, 118, 100)
            'st.Set( 31.5, -110, 1370 );


            ' Get the JNOW coordinates of the comet.
            Dim cometVector2 As PositionVector2
            'cometVector2 = pl.GetApparentPosition( targetJd );
            'cometVector2 = pl.GetAstrometricPosition( targetJd );
            'cometVector2 = pl.GetLocalPosition( targetJd, st );
            cometVector2 = pl.GetTopocentricPosition(targetJd, st, False)


            ' Initialize the Vector2 from Earth to the comet.
            'Vector23D cometVector2 = new Vector23D( cometPosition.x, cometPosition.y, cometPosition.z );

            'float[] xyz = pl.Ephemeris.GetPositionAndVelocity( targetJd - pl.DeltaT / 86400 ).ToArray();
            'Vector23D cometVector2 = new Vector23D( xyz[0], xyz[1], xyz[2] );

            ' Initialize the Vector2 from the Sun to the Earth.
            'Vector23D earthVector2 = new Vector23D( earth.HeliocentricPosition.x, earth.HeliocentricPosition.y, earth.HeliocentricPosition.z );
            Dim earthVector2 = earth.HeliocentricPosition

            ' Calculate the distance from the Earth to the comet.
            Dim delta = cometVector2.Distance

            ' Calculate the distance from the Sun to the comet.
            'Vector23D sunCometVector2 = earthVector2 + cometVector2;
            Dim sunCometVector2 = Vector2Add(earthVector2, cometVector2)
            Dim r = sunCometVector2.Distance
        End Sub

        Private Shared Function Vector2Add(ByVal v1 As PositionVector2, ByVal v2 As PositionVector2) As PositionVector2
            Dim vecReturn As PositionVector2 = New PositionVector2()
            vecReturn.x = v1.x + v2.x
            vecReturn.y = v1.y + v2.y
            vecReturn.z = v1.z + v2.z

            Return vecReturn
        End Function

        Private Shared Function CreateCometEphemeris(ByVal elements As KeplerConsoleApp.OrbitalElements) As Ephemeris
            Dim kt As Ephemeris = New Ephemeris()
            kt.BodyType = BodyType.Comet
            kt.Name = elements.Name
            kt.Epoch = elements.Epoch
            kt.e = elements.OrbitalEccentricity

            'float q = elements.PeriDistance;
            'kt.a = ( kt.e >= 1 ) ? q : ( q / ( 1 - kt.e ) );

            kt.q = elements.PeriDistance

            'kt.G = 0;
            'kt.H = 0;
            kt.M = 0
            kt.n = 0
            kt.Peri = elements.ArgOfPerihelion
            kt.Node = elements.LongitudeOfAscNode
            kt.Incl = elements.Inclination

            Return kt
        End Function
    End Class
End Namespace
