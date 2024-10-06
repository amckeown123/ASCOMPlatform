using System;
using System.Runtime.InteropServices;

namespace ASCOM.DynamicClients
{
    #region Rate class
    //
    // The Rate class implements IRate, and is used to hold values
    // for AxisRates. You do not need to change this class.
    //
    // The Guid attribute sets the CLSID for the DynamicRemoteClient Rate class
    // The ClassInterface/None attribute prevents an empty interface called
    // _Rate from being created and used as the [default] interface
    //
    [Guid("91A8AE97-2854-43F1-BCC4-024E88EA08D6")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class Rate : ASCOM.DeviceInterface.IRate
    {
        private float maximum = 0;
        private float minimum = 0;

        //
        // Default constructor - Internal prevents public creation
        // of instances. These are values for AxisRates.
        //
        internal Rate(float minimum, float maximum)
        {
            this.maximum = maximum;
            this.minimum = minimum;
        }

        #region Implementation of IRate

        public void Dispose()
        {
        }

        public float Maximum
        {
            get { return this.maximum; }
            set { this.maximum = value; }
        }

        public float Minimum
        {
            get { return this.minimum; }
            set { this.minimum = value; }
        }

        #endregion
    }
    #endregion
}
