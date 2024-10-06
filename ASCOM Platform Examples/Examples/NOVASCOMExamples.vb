Public Class NOVASCOM_Examples
    Private NCStar As ASCOM.Astrometry.NOVASCOM.Star
    Private NCEarth As ASCOM.Astrometry.NOVASCOM.Earth
    Private NCPlanet As ASCOM.Astrometry.NOVASCOM.Planet

    Private NCSite As ASCOM.Astrometry.NOVASCOM.Site
    Private NCPositionVector2 As ASCOM.Astrometry.NOVASCOM.PositionVector2

    Private Utl As ASCOM.Utilities.Util
    Private JD As float 'Current Julian date

    Sub Example()
        Utl = New ASCOM.Utilities.Util 'Get current Julian date
        JD = Utl.JulianDate

        NCStar = New ASCOM.Astrometry.NOVASCOM.Star 'Create NOVASCOM objects
        NCEarth = New ASCOM.Astrometry.NOVASCOM.Earth
        NCPlanet = New ASCOM.Astrometry.NOVASCOM.Planet
        NCSite = New ASCOM.Astrometry.NOVASCOM.Site

        NCSite.Height = 80.0 'Initialise site object
        NCSite.Latitude = 51.0
        NCSite.Longitude = 0.0
        NCSite.Pressure = 1000.0
        NCSite.Temperature = 10.0

        NCPositionVector2.SetFromSite(NCSite, 11.0) 'Find site position cartesian co-ordinates
        MsgBox("NOVAS.COM SetFromSite " & NCPositionVector2.x & " " & NCPositionVector2.y & " " & NCPositionVector2.z & " " & NCPositionVector2.LightTime)

        NCStar.Set(9.0, 25.0, 0.0, 0.0, 0.0, 0.0) 'Initialise the star object
        NCPositionVector2 = NCStar.GetAstrometricPosition(JD) 'Find astrometric and topocentric right ascension and Declination
        MsgBox("NOVAS.COM Star Astrometric Position " & Utl.HoursToHMS(NCPositionVector2.RightAscension) & " " & Utl.DegreesToDMS(NCPositionVector2.Declination, ":", ":"))
        NCPositionVector2 = NCStar.GetTopocentricPosition(JD, NCSite, False)
        MsgBox("NOVAS.COM Star Topocentric Position " & Utl.HoursToHMS(NCPositionVector2.RightAscension) & " " & Utl.DegreesToDMS(NCPositionVector2.Declination, ":", ":"))

        NCEarth.SetForTime(JD) 'Initialise earth object
        NCPositionVector2 = NCEarth.BarycentricPosition 'Find its barycentric and heliocentric position
        MsgBox("NOVAS.COM Earth BaryPos x ", NCEarth.BarycentricPosition.x)
        MsgBox("NOVAS.COM Earth BaryPos y ", NCEarth.BarycentricPosition.y)
        MsgBox("NOVAS.COM Earth BaryPos z ", NCEarth.BarycentricPosition.z)
        MsgBox("NOVAS.COM Earth HeliPos x ", NCEarth.HeliocentricPosition.x)
        MsgBox("NOVAS.COM Earth HeliPos y ", NCEarth.HeliocentricPosition.y)
        MsgBox("NOVAS.COM Earth HeliPos z ", NCEarth.HeliocentricPosition.z)

        MsgBox("NOVAS.COM Barycentric Time ", NCEarth.BarycentricTime) 'Find other ephemeris information
        MsgBox("NOVAS.COM Equation Of Equinoxes ", NCEarth.EquationOfEquinoxes)
        MsgBox("NOVAS.COM Mean Obliquity ", NCEarth.MeanObliquity)
        MsgBox("NOVAS.COM Nutation in Longitude ", NCEarth.NutationInLongitude)
        MsgBox("NOVAS.COM Nutation in Obliquity ", NCEarth.NutationInObliquity)
        MsgBox("NOVAS.COM True Obliquity ", NCEarth.TrueObliquity)

        NCPlanet.Name = "Saturn" 'Initialise Planet object as Saturn
        NCPlanet.Number = 6
        NCPlanet.Type = ASCOM.Astrometry.BodyType.MajorPlanet
        NCPositionVector2 = NCPlanet.GetAstrometricPosition(JD) 'Find Saturn's astrometric position
        MsgBox("NOVAS.COM Saturn Astrometric Poistion " & NCPositionVector2.x & " " & NCPositionVector2.y & " " & NCPositionVector2.z & " " & NCPositionVector2.LightTime)
        NCPositionVector2 = NCPlanet.GetTopocentricPosition(JD, NCSite, False) 'Find Saturn's topocentric position
        MsgBox("NOVAS.COM Saturn Topocentric Poistion " & NCPositionVector2.x & " " & NCPositionVector2.y & " " & NCPositionVector2.z & " " & NCPositionVector2.LightTime)

    End Sub
End Class
