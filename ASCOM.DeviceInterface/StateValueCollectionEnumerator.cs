﻿using System;
using System.Runtime.InteropServices;
using System.Collections;
#if NETSTANDARD2_0
//using ASCOM.Tools;
#else
using ASCOM.Utilities;
#endif
namespace ASCOM.DeviceInterface
{
    /// <summary>
    /// 
    /// </summary>
    [Guid("792C4234-C136-4600-988B-A80D03608534")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class StateValueCollectionEnumerator : IEnumerator, IDisposable
    {
        private IStateValue[] stateValues;
        //private TraceLogger logger;
        private int index; // Index into the array of StateValue objects
        private bool disposedValue;

        #region Initialisers
        /// <summary>
        /// 
        /// </summary>
        public StateValueCollectionEnumerator()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stateValues"></param>
        /// <param name="logger"></param>
        //public StateValueCollectionEnumerator(IStateValue[] stateValues, TraceLogger logger)
        public StateValueCollectionEnumerator(IStateValue[] stateValues)
        {
            this.stateValues = stateValues;
            //this.logger = logger;
            index = -1;
        }

        #endregion

        #region IEnumerator implementation

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {

            // Increment the index pointer
            index++;

            // Test whether we are at the end of the collection
            if (index >= stateValues.Length) // We are at the end of the collection
            {
                //logger.LogMessage("MoveNext", $"Returning FALSE - Index: {index}, Count: {stateValues.Length}");
                // Cannot move further so return false
                return false;
            }
            else // We are not at the end of the collection
            {
                // Can move to the next value so increment the index and return true
                //logger.LogMessage("MoveNext", $"Returning TRUE - Index: {index}, Count: {stateValues.Length}");
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Reset()
        {
            // Reset the index to before the first element
            index = -1;
            //logger.LogMessage("Reset", $"Index: {index}, Count: {stateValues.Length}");
        }

        /// <summary>
        /// 
        /// </summary>
        public object Current
        {
            get
            {
                //logger.LogMessage("Current", $"Index: {index}, Count: {stateValues.Length}");

                // Validate the current index value
                if (index < 0)
                    throw new InvalidOperationException($"StateValueCollection.Current - No value has yet been selected.");

                if (index > stateValues.Length)
                    throw new InvalidOperationException($"StateValueCollection.Current - The requested index ({index}) is greater than the number of values in the collection ({stateValues.Length}).");

                //logger.LogMessage("Current", $"Returning: {stateValues[index].Name} = {stateValues[index].Value}");

                return stateValues[index];
            }
        }

        #endregion

        #region IDisposable implementation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //logger.LogMessage("Enumerator.Dispose", $"Ignoring Dispose() - Disposing: {disposing}");
                }

                disposedValue = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}