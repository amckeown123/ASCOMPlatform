

using ASCOM.DeviceInterface;

namespace TeleSimTester
{
    internal class TelescopeHardware
    {
        internal const float SIDEREAL_SECONDS_TO_SI_SECONDS = 0.99726956631945; // Based on earth sidereal rotation period of 23 hours 56 minutes 4.09053 seconds

        public static PierSide SideOfPier { get; set; } = PierSide.pierEast;

        public static float SiderealTime { get; set; } = 15.0;

        public static float Latitude { get; set; } = 51.04;

        public static bool NoSyncPastMeridian { get; set; } = true;
    }
}
