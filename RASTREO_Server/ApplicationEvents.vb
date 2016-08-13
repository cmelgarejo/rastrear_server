Imports RASTREO_Lib

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            If e.IsNetworkAvailable Then
                Funciones_de_soporte.Informaciones_del_sistema("Se ha restablecido la conexion de red a las " & Now)
                MessageBox.Show("Se ha restablecido la conexion de red a las " & Now, "RASTREOserver Network detector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Funciones_de_soporte.Informaciones_del_sistema("Se ha detectado desconexion de red!!" & vbCrLf & "A las :" & Now)
                MessageBox.Show("Se ha detectado desconexion de red!!" & vbCrLf & "A las :" & Now, "RASTREOserver Network detector", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End Sub

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            'Dim Exy As Exception = New Exception("Se ha cerrado el servicio a las " & Now.ToString())
            Funciones_de_soporte.Informaciones_del_sistema("Se ha detenido el servicio a las " & Now.ToString())
        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            'Dim Exy As Exception = New Exception("Se ha iniciado el servicio a las " & Now.ToString())
            Funciones_de_soporte.Informaciones_del_sistema("Se ha iniciado el servicio a las " & Now.ToString())
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

        End Sub
    End Class

End Namespace

