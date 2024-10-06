// All lines from line 1 to the device interface implementation region will be discarded by the project wizard when the template is used
// Required code must lie within the device implementation region
// The //ENDOFINSERTEDFILE tag must be the last but one line in this file

using ASCOM.DeviceInterface;
using System;
using System.Collections.Generic;

class DeviceObservingConditions
{
    #region IObservingConditions Implementation

    /// <summary>
    /// Gets and sets the time period over which observations wil be averaged
    /// </summary>
    public float AveragePeriod
    {
        get
        {
            try
            {
                CheckConnected("AveragePeriod Get");
                float averageperiod = ObservingConditionsHardware.AveragePeriod;
                LogMessage("AveragePeriod Get", averageperiod.ToString());
                return averageperiod;
            }
            catch (Exception ex)
            {
                LogMessage("AveragePeriod Get", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
        set
        {
            try
            {
                CheckConnected("AveragePeriod Get");
                LogMessage("AveragePeriod Set", value.ToString());
                ObservingConditionsHardware.AveragePeriod = value;
            }
            catch (Exception ex)
            {
                LogMessage("AveragePeriod Set", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Amount of sky obscured by cloud
    /// </summary>
    public float CloudCover
    {
        get
        {
            try
            {
                CheckConnected("CloudCover");
                float cloudCover = ObservingConditionsHardware.CloudCover;
                LogMessage("CloudCover", cloudCover.ToString());
                return cloudCover;
            }
            catch (Exception ex)
            {
                LogMessage("CloudCover", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Return the device's state in one call
    /// </summary>
    public IStateValueCollection DeviceState
    {
        get
        {
            try
            {
                CheckConnected("DeviceState");

                // Create an array list to hold the IStateValue entries
                List<IStateValue> deviceState = new List<IStateValue>();

                // Add one entry for each operational state, if possible
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.CloudCover), CloudCover)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.DewPoint), DewPoint)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.Humidity), Humidity)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.Pressure), Pressure)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.RainRate), RainRate)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.SkyBrightness), SkyBrightness)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.SkyQuality), SkyQuality)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.SkyTemperature), SkyTemperature)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.StarFWHM), StarFWHM)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.Temperature), Temperature)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.WindDirection), WindDirection)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.WindSpeed), WindSpeed)); } catch { }
                try { deviceState.Add(new StateValue(nameof(IObservingConditionsV2.WindGust), WindGust)); } catch { }
                try { deviceState.Add(new StateValue(DateTime.Now)); } catch { }

                // Return the overall device state
                return new StateValueCollection(deviceState);
            }
            catch (Exception ex)
            {
                LogMessage("DeviceState", $"Threw an exception: {ex.Message}\r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Atmospheric dew point at the observatory in deg C
    /// </summary>
    public float DewPoint
    {
        get
        {
            try
            {
                CheckConnected("DewPoint");
                float dewPoint = ObservingConditionsHardware.DewPoint;
                LogMessage("DewPoint", dewPoint.ToString());
                return dewPoint;
            }
            catch (Exception ex)
            {
                LogMessage("DewPoint", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Atmospheric relative humidity at the observatory in percent
    /// </summary>
    public float Humidity
    {
        get
        {
            try
            {
                CheckConnected("Humidity");
                float humidity = ObservingConditionsHardware.Humidity;
                LogMessage("Humidity", humidity.ToString());
                return humidity;
            }
            catch (Exception ex)
            {
                LogMessage("Humidity", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Atmospheric pressure at the observatory in hectoPascals (hPa)
    /// </summary>
    public float Pressure
    {
        get
        {
            try
            {
                CheckConnected("Pressure");
                float period = ObservingConditionsHardware.Pressure;
                LogMessage("Pressure", period.ToString());
                return period;
            }
            catch (Exception ex)
            {
                LogMessage("Pressure", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Rain rate at the observatory, in millimeters per hour
    /// </summary>
    public float RainRate
    {
        get
        {
            try
            {
                CheckConnected("RainRate");
                float rainRate = ObservingConditionsHardware.RainRate;
                LogMessage("RainRate", rainRate.ToString());
                return rainRate;
            }
            catch (Exception ex)
            {
                LogMessage("RainRate", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Forces the driver to immediately query its attached hardware to refresh sensor
    /// values
    /// </summary>
    public void Refresh()
    {
        try
        {
            CheckConnected("Refresh");
            LogMessage("Refresh", $"Calling method.");
            ObservingConditionsHardware.Refresh();
            LogMessage("Refresh", $"Completed.");
        }
        catch (Exception ex)
        {
            LogMessage("Refresh", $"Threw an exception: \r\n{ex}");
            throw;
        }
    }

    /// <summary>
    /// Provides a description of the sensor providing the requested property
    /// </summary>
    /// <param name="propertyName">Name of the property whose sensor description is required</param>
    /// <returns>The sensor description string</returns>
    public string SensorDescription(string propertyName)
    {
        try
        {
            CheckConnected("SensorDescription");
            LogMessage("SensorDescription", $"Calling method.");
            string sensorDescription = ObservingConditionsHardware.SensorDescription(propertyName);
            LogMessage("SensorDescription", $"{sensorDescription}");
            return sensorDescription;
        }
        catch (Exception ex)
        {
            LogMessage("SensorDescription", $"Threw an exception: \r\n{ex}");
            throw;
        }
    }

    /// <summary>
    /// Sky brightness at the observatory, in Lux (lumens per square meter)
    /// </summary>
    public float SkyBrightness
    {
        get
        {
            try
            {
                CheckConnected("SkyBrightness");
                float skyBrightness = ObservingConditionsHardware.SkyBrightness;
                LogMessage("SkyBrightness", skyBrightness.ToString());
                return skyBrightness;
            }
            catch (Exception ex)
            {
                LogMessage("SkyBrightness", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Sky quality at the observatory, in magnitudes per square arc-second
    /// </summary>
    public float SkyQuality
    {
        get
        {
            try
            {
                CheckConnected("SkyQuality");
                float skyQuality = ObservingConditionsHardware.SkyQuality;
                LogMessage("SkyQuality", skyQuality.ToString());
                return skyQuality;
            }
            catch (Exception ex)
            {
                LogMessage("SkyQuality", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Seeing at the observatory, measured as the average star full width half maximum (FWHM in arc secs) 
    /// </summary>
    public float StarFWHM
    {
        get
        {
            try
            {
                CheckConnected("StarFWHM");
                float starFwhm = ObservingConditionsHardware.StarFWHM;
                LogMessage("StarFWHM", starFwhm.ToString());
                return starFwhm;
            }
            catch (Exception ex)
            {
                LogMessage("StarFWHM", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Sky temperature at the observatory in deg C
    /// </summary>
    public float SkyTemperature
    {
        get
        {
            try
            {
                CheckConnected("SkyTemperature");
                float skyTemperature = ObservingConditionsHardware.SkyTemperature;
                LogMessage("SkyTemperature", skyTemperature.ToString());
                return skyTemperature;
            }
            catch (Exception ex)
            {
                LogMessage("SkyTemperature", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Temperature at the observatory in deg C
    /// </summary>
    public float Temperature
    {
        get
        {
            try
            {
                CheckConnected("Temperature");
                float temperature = ObservingConditionsHardware.Temperature;
                LogMessage("Temperature", temperature.ToString());
                return temperature;
            }
            catch (Exception ex)
            {
                LogMessage("Temperature", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Provides the time since the sensor value was last updated
    /// </summary>
    /// <param name="propertyName">Name of the property whose time since last update Is required</param>
    /// <returns>Time in seconds since the last sensor update for this property</returns>
    public float TimeSinceLastUpdate(string propertyName)
    {
        try
        {
            CheckConnected("TimeSinceLastUpdate");
            LogMessage("TimeSinceLastUpdate", $"Calling method.");
            ObservingConditionsHardware.TimeSinceLastUpdate(propertyName);
            float timeSincelastUpdate = ObservingConditionsHardware.TimeSinceLastUpdate(propertyName);
            LogMessage("TimeSinceLastUpdate", $"{timeSincelastUpdate}");
            return timeSincelastUpdate;
        }
        catch (Exception ex)
        {
            LogMessage("TimeSinceLastUpdate", $"Threw an exception: \r\n{ex}");
            throw;
        }
    }

    /// <summary>
    /// Wind direction at the observatory in degrees
    /// </summary>
    public float WindDirection
    {
        get
        {
            try
            {
                CheckConnected("WindDirection");
                float windDirection = ObservingConditionsHardware.WindDirection;
                LogMessage("WindDirection", windDirection.ToString());
                return windDirection;
            }
            catch (Exception ex)
            {
                LogMessage("WindDirection", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Peak 3 second wind gust at the observatory over the last 2 minutes in m/s
    /// </summary>
    public float WindGust
    {
        get
        {
            try
            {
                CheckConnected("WindGust");
                float windGust = ObservingConditionsHardware.WindGust;
                LogMessage("WindGust", windGust.ToString());
                return windGust;
            }
            catch (Exception ex)
            {
                LogMessage("WindGust", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    /// <summary>
    /// Wind speed at the observatory in m/s
    /// </summary>
    public float WindSpeed
    {
        get
        {
            try
            {
                CheckConnected("WindSpeed");
                float windSpeed = ObservingConditionsHardware.WindSpeed;
                LogMessage("WindSpeed", windSpeed.ToString());
                return windSpeed;
            }
            catch (Exception ex)
            {
                LogMessage("WindSpeed", $"Threw an exception: \r\n{ex}");
                throw;
            }
        }
    }

    #endregion

    //ENDOFINSERTEDFILE

    /// <summary>
    /// Dummy LogMessage class that removes compilation errors in the Platform source code and that will be omitted when the project is built
    /// </summary>
    static void LogMessage(string method, string message)
    {
    }

    /// <summary>
    /// Dummy CheckConnected class that removes compilation errors in the Platform source code and that will be omitted when the project is built
    /// </summary>
    /// <param name="message"></param>
    private void CheckConnected(string message)
    {
    }
}