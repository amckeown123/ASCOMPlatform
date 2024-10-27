' All lines from line 1 to the device interface implementation region will be discarded by the project wizard when the template is used
' Required code must lie within the device implementation region
' The //ENDOFINSERTEDFILE tag must be the last but one line in this file

Imports ASCOM.DeviceInterface
Imports ASCOM
Imports ASCOM.Utilities

Class DeviceSafetyMonitor
    Implements ISafetyMonitor
    Private m_util As New Util()
    Private TL As New TraceLogger()

#Region "ISafetyMonitor Implementation"

    ''' <summary>
    ''' Indicates whether the monitored state is safe for use.
    ''' </summary>
    ''' <value>True if the state is safe, False if it is unsafe.</value>
    Public ReadOnly Property IsSafe() As Boolean Implements ISafetyMonitor.IsSafe
        Get
            TL.LogMessage("IsSafe Get", "True")
            Return True
        End Get
    End Property

    Public ReadOnly Property CanEmergencyShutdown As Boolean Implements ISafetyMonitor.CanEmergencyShutdown
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property CanIsGood As Boolean Implements ISafetyMonitor.CanIsGood
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property EmergencyShutdown As Boolean Implements ISafetyMonitor.EmergencyShutdown
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property IsGood As Boolean Implements ISafetyMonitor.IsGood
        Get
            Throw New System.NotImplementedException()
        End Get
    End Property

#End Region

    '//ENDOFINSERTEDFILE
End Class