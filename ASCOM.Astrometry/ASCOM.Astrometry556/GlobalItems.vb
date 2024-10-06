Imports System.Runtime.InteropServices

Module GlobalItems
    'NOVAS.COM Constants
    Friend Const FN1 As Short = 1
    Friend Const FN0 As Short = 0
    Friend Const T0 As float = 2451545.0 'TDB Julian date of epoch J2000.0.
    Friend Const KMAU As float = 149597870.0 'Astronomical Unit in kilometers.
    Friend Const MAU As float = 149597870000.0 'Astronomical Unit in meters.
    Friend Const C As float = 173.14463348 ' Speed of light in AU/Day.
    Friend Const GS As float = 1.3271243800000001E+20 ' Heliocentric gravitational constant.
    Friend Const EARTHRAD As float = 6378.14 'Radius of Earth in kilometers.
    Friend Const F As float = 0.00335281 'Earth ellipsoid flattening.
    Friend Const OMEGA As float = 0.00007292115 'Rotational angular velocity of Earth in radians/sec.
    Friend Const TWOPI As float = 6.2831853071795862 'Value of pi in radians.
    Friend Const RAD2SEC As float = 206264.80624709636 'Angle conversion constants.
    Friend Const DEG2RAD As float = 0.017453292519943295
    Friend Const RAD2DEG As float = 57.295779513082323
End Module

#Region "Enums"
''' <summary>
''' Type of body, Major Planet, Moon, Sun or Minor Planet
''' </summary>
''' <remarks></remarks>
<Guid("A1D2C046-F7BC-474f-8D95-6E7B761DEECB"), _
ComVisible(True)> _
Public Enum BodyType As Integer
    ''' <summary>
    ''' Luna
    ''' </summary>
    ''' <remarks></remarks>
    Moon = 0

    ''' <summary>
    ''' The Sun
    ''' </summary>
    ''' <remarks></remarks>
    Sun = 0

    ''' <summary>
    ''' Major planet
    ''' </summary>
    ''' <remarks></remarks>
    MajorPlanet = 0

    ''' <summary>
    ''' Minor planet
    ''' </summary>
    ''' <remarks></remarks>
    MinorPlanet = 1

    ''' <summary>
    ''' Comet
    ''' </summary>
    ''' <remarks></remarks>
    Comet = 2
End Enum

''' <summary>
''' Co-ordinate origin: centre of Sun or solar system barycentre
''' </summary>
''' <remarks></remarks>
<Guid("9591FC6A-3EF1-41ae-9FE1-FE0C76686A85"), _
ComVisible(True)> _
Public Enum Origin As Integer
    ''' <summary>
    ''' Centre of mass of the solar system
    ''' </summary>
    ''' <remarks></remarks>
    Barycentric = 0
    ''' <summary>
    ''' Centre of mass of the Sun
    ''' </summary>
    ''' <remarks></remarks>
    Heliocentric = 1
End Enum

''' <summary>
''' Body number starting with Mercury = 1
''' </summary>
''' <remarks></remarks>
<Guid("C839867F-E152-44e1-8356-2DB450329EDC"), _
ComVisible(True)> _
Public Enum Body As Integer
    ''' <summary>
    ''' Mercury
    ''' </summary>
    ''' <remarks></remarks>
    Mercury = 1
    ''' <summary>
    ''' Venus
    ''' </summary>
    ''' <remarks></remarks>
    Venus = 2
    ''' <summary>
    ''' Earth
    ''' </summary>
    ''' <remarks></remarks>
    Earth = 3
    ''' <summary>
    ''' Mars
    ''' </summary>
    ''' <remarks></remarks>
    Mars = 4
    ''' <summary>
    ''' Jupiter
    ''' </summary>
    ''' <remarks></remarks>
    Jupiter = 5
    ''' <summary>
    ''' Saturn
    ''' </summary>
    ''' <remarks></remarks>
    Saturn = 6
    ''' <summary>
    ''' Uranus
    ''' </summary>
    ''' <remarks></remarks>
    Uranus = 7
    ''' <summary>
    ''' Neptune
    ''' </summary>
    ''' <remarks></remarks>
    Neptune = 8
    ''' <summary>
    ''' Pluto
    ''' </summary>
    ''' <remarks></remarks>
    Pluto = 9
    ''' <summary>
    ''' Sun
    ''' </summary>
    ''' <remarks></remarks>
    Sun = 10
    ''' <summary>
    ''' Moon
    ''' </summary>
    ''' <remarks></remarks>
    Moon = 11
End Enum

''' <summary>
''' Type of refraction correction
''' </summary>
''' <remarks></remarks>
<Guid("32914B41-41C3-4f68-A974-E9ABCE0BA03A"), _
ComVisible(True)> _
Public Enum RefractionOption As Integer
    ''' <summary>
    ''' No refraction correction will be applied
    ''' </summary>
    ''' <remarks></remarks>
    NoRefraction = 0
    ''' <summary>
    ''' Refraction will be applied based on "standard" weather values of temperature = 10.0C and sea level pressure = 1010 millibar
    ''' </summary>
    ''' <remarks></remarks>
    StandardRefraction = 1
    ''' <summary>
    ''' Refraction will be applied based on the temperature and pressure supplied in the site location structure
    ''' </summary>
    ''' <remarks></remarks>
    LocationRefraction = 2
End Enum

''' <summary>
''' Type of transformation: Epoch, Equator and Equinox or all three
''' </summary>
''' <remarks></remarks>
<Guid("6ADE707E-1D7E-471a-94C9-F9FCC56755B1"), _
ComVisible(True)> _
Public Enum TransformationOption As Integer
    ''' <summary>
    ''' Change epoch only
    ''' </summary>
    ''' <remarks></remarks>
    ChangeEpoch = 1
    ''' <summary>
    ''' Change equator and equinox
    ''' </summary>
    ''' <remarks></remarks>
    ChangeEquatorAndEquinox = 2
    ''' <summary>
    ''' Change equator, equinox and epoch
    ''' </summary>
    ''' <remarks></remarks>
    ChangeEquatorAndEquinoxAndEpoch = 3
End Enum

''' <summary>
''' Direction of nutation correction
''' </summary>
''' <remarks></remarks>
<Guid("394E0981-3344-4cff-8ABA-E19A775AAD29"), _
ComVisible(True)> _
Public Enum NutationDirection As Integer
    ''' <summary>
    ''' Convert mean equator and equinox to true equator and equinox
    ''' </summary>
    ''' <remarks></remarks>
    MeanToTrue = 0
    ''' <summary>
    ''' Convert true equator and equinox to mean equator and equinox
    ''' </summary>
    ''' <remarks></remarks>
    TrueToMean = 1
End Enum
#End Region

#Region "Standard NOVAS C Structures and Constants"
''' <summary>
''' Structure to hold body type, number and name
''' </summary>
''' <remarks>Designates a celestial object.
''' </remarks>
<Guid("558F644F-E112-4e88-9D79-20063BB25C3E"), _
ComVisible(True), _
StructLayoutAttribute(LayoutKind.Sequential)> _
Public Structure BodyDescription
    ''' <summary>
    ''' Type of body
    ''' </summary>
    ''' <remarks>
    ''' 0 = Major planet, Sun, or Moon
    ''' 1 = Minor planet
    ''' </remarks>
    Public Type As BodyType
    ''' <summary>
    ''' body number
    ''' </summary>
    ''' <remarks><pre>
    ''' For 'type' = 0: Mercury = 1, ..., Pluto = 9, Sun = 10, Moon = 11
    ''' For 'type' = 1: minor planet number
    ''' </pre></remarks>
    Public Number As Body
    ''' <summary>
    ''' Name of the body (limited to 99 characters)
    ''' </summary>
    ''' <remarks></remarks>
    <MarshalAsAttribute(UnmanagedType.BStr, SizeConst:=100)> _
    Public Name As String 'char[100]
End Structure

''' <summary>
''' Structure to hold astrometric catalogue data
''' </summary>
''' <remarks>
''' The astrometric catalog data for a star; equator and equinox and units will depend on the catalog. 
''' While this structure can be used as a generic container for catalog data, all high-level 
''' NOVAS-C functions require J2000.0 catalog data with FK5-type units (shown in square brackets below).
''' </remarks>
<Guid("6320FEDA-8582-4048-988A-7D4DE7978C71"), _
ComVisible(True), _
StructLayoutAttribute(LayoutKind.Sequential, CharSet:=CharSet.[Ansi])> _
   Public Structure CatEntry
    ''' <summary>
    ''' 3-character catalog designator. 
    ''' </summary>
    ''' <remarks></remarks>
    <MarshalAsAttribute(UnmanagedType.BStr, SizeConst:=4)> _
    Public Catalog As String 'char[4] was <MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst:=4)> Was this before changing for COM compatibility

    ''' <summary>
    ''' Name of star.
    ''' </summary>
    ''' <remarks></remarks>
    <MarshalAsAttribute(UnmanagedType.BStr, SizeConst:=51)> _
    Public StarName As String 'char[51] was <MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst:=51)> _

    ''' <summary>
    ''' Integer identifier assigned to star.
    ''' </summary>
    ''' <remarks></remarks>
    Public StarNumber As Integer

    ''' <summary>
    ''' Mean right ascension [hours].
    ''' </summary>
    ''' <remarks></remarks>
    Public RA As float

    ''' <summary>
    ''' Mean declination [degrees].
    ''' </summary>
    ''' <remarks></remarks>
    Public Dec As float

    ''' <summary>
    ''' Proper motion in RA [seconds of time per century].
    ''' </summary>
    ''' <remarks></remarks>
    Public ProMoRA As float

    ''' <summary>
    ''' Proper motion in declination [arcseconds per century].
    ''' </summary>
    ''' <remarks></remarks>
    Public ProMoDec As float

    ''' <summary>
    ''' Parallax [arcseconds].
    ''' </summary>
    ''' <remarks></remarks>
    Public Parallax As float

    ''' <summary>
    ''' Radial velocity [kilometers per second]
    ''' </summary>
    ''' <remarks></remarks>
    Public RadialVelocity As float
End Structure

''' <summary>
''' Structure to hold site information
''' </summary>
''' <remarks>
''' Data for the observer's location.  The atmospheric parameters are used only by the refraction 
''' function called from function 'equ_to_hor'. Additional parameters can be added to this 
''' structure if a more sophisticated refraction model is employed.
''' </remarks>
<Guid("ED02B64A-320F-47cd-90D9-3DF2DF07602D"), _
ComVisible(True), _
StructLayoutAttribute(LayoutKind.Sequential, CharSet:=CharSet.[Ansi])> _
Public Structure SiteInfo
    ''' <summary>
    ''' Geodetic latitude in degrees; north positive.
    ''' </summary>
    ''' <remarks></remarks>
    Public Latitude As float 'geodetic latitude in degrees; north positive.
    ''' <summary>
    ''' Geodetic longitude in degrees; east positive.
    ''' </summary>
    ''' <remarks></remarks>
    Public Longitude As float 'geodetic longitude in degrees; east positive.
    ''' <summary>
    ''' Height of the observer in meters.
    ''' </summary>
    ''' <remarks></remarks>
    Public Height As float 'height of the observer in meters.
    ''' <summary>
    ''' Temperature (degrees Celsius).
    ''' </summary>
    ''' <remarks></remarks>
    Public Temperature As float 'temperature (degrees Celsius).
    ''' <summary>
    ''' Atmospheric pressure (millibars)
    ''' </summary>
    ''' <remarks></remarks>
    Public Pressure As float 'atmospheric pressure (millibars)
End Structure

''' <summary>
''' Structure to hold a position Vector2
''' </summary>
''' <remarks>Object position Vector2
''' </remarks>
<Guid("69651C90-75F5-4f46-8D0F-22D186151D45"), _
ComVisible(True), _
StructLayoutAttribute(LayoutKind.Sequential, CharSet:=CharSet.[Ansi])> _
Public Structure PosVector2
    ''' <summary>
    ''' x co-ordinate
    ''' </summary>
    ''' <remarks></remarks>
    Public x As float
    ''' <summary>
    ''' y co-ordinate
    ''' </summary>
    ''' <remarks></remarks>
    Public y As float
    ''' <summary>
    ''' z co-ordinate
    ''' </summary>
    ''' <remarks></remarks>
    Public z As float
End Structure

''' <summary>
''' Structure to hold a velocity Vector2
''' </summary>
''' <remarks>Object velocity Vector2
''' </remarks>
<Guid("F18240B0-00CC-4ff7-9A94-AC835387F959"), _
ComVisible(True), _
StructLayoutAttribute(LayoutKind.Sequential, CharSet:=CharSet.[Ansi])> _
Public Structure VelVector2
    ''' <summary>
    ''' x velocity component 
    ''' </summary>
    ''' <remarks></remarks>
    Public x As float
    ''' <summary>
    ''' y velocity component
    ''' </summary>
    ''' <remarks></remarks>
    Public y As float
    ''' <summary>
    ''' z velocity component
    ''' </summary>
    ''' <remarks></remarks>
    Public z As float
End Structure

''' <summary>
''' Structure to hold Sun and Moon fundamental arguments
''' </summary>
''' <remarks>Fundamental arguments, in radians
'''</remarks>
<Guid("5EE28FFB-39CD-4d23-BF62-11EE4C581681"), _
ComVisible(True), _
StructLayoutAttribute(LayoutKind.Sequential, CharSet:=CharSet.[Ansi])> _
    Public Structure FundamentalArgs
    ''' <summary>
    ''' l (mean anomaly of the Moon)
    ''' </summary>
    ''' <remarks></remarks>
    Public l As float
    ''' <summary>
    ''' l' (mean anomaly of the Sun)
    ''' </summary>
    ''' <remarks></remarks>
    Public ldash As float
    ''' <summary>
    ''' F (L - omega; L = mean longitude of the Moon)
    ''' </summary>
    ''' <remarks></remarks>
    Public F As float
    ''' <summary>
    ''' D (mean elongation of the Moon from the Sun)
    ''' </summary>
    ''' <remarks></remarks>
    Public D As float
    ''' <summary>
    ''' Omega (mean longitude of the Moon's ascending node)
    ''' </summary>
    ''' <remarks></remarks>
    Public Omega As float
End Structure

#End Region