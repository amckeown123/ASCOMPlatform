using ASCOM.DeviceInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ASCOM.DynamicClients
{
    internal static class Extensions
    {
        internal static List<DeviceInterface.StateValue> ToPlatformStateValue(this List<StateValue> obj)
        {
            List<DeviceInterface.StateValue> platformStateValues = new List<DeviceInterface.StateValue>();
            foreach (StateValue stateValue in obj)
            {
                platformStateValues.Add(new DeviceInterface.StateValue(stateValue.Name, stateValue.Value));
            }

            return platformStateValues;
        }
    }
}
