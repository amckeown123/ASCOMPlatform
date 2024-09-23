

using Semver;

namespace PlatformUpdateChecker
{
    internal static class ExtensionMethods
    {
        internal static bool IsNewerThan(this SemVersion newVersion, SemVersion comparisonSemver)
        {
            return SemVersion.ComparePrecedence(newVersion, comparisonSemver) == 1;
        }
        internal static bool IsOlderThan(this SemVersion oldVersion, SemVersion comparisonSemver)
        {
            return SemVersion.ComparePrecedence(oldVersion, comparisonSemver) == -1;
        }
    }
}
