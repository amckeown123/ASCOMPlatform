

using System.Collections.Generic;

namespace ASCOM.DynamicClients
{
    internal static class Extensions
    {
        internal static List<DeviceInterface.StateValue> ToPlatformStateValue(this List<Common.DeviceInterfaces.StateValue> obj)
        {
            List<DeviceInterface.StateValue> platformStateValues = new List<DeviceInterface.StateValue>();
            foreach (Common.DeviceInterfaces.StateValue stateValue in obj)
            {
                platformStateValues.Add(new DeviceInterface.StateValue(stateValue.Name, stateValue.Value));
            }

            return platformStateValues;
        }
    }
}
