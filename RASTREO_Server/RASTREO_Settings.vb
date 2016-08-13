Imports System.Windows.Forms
Imports System.Collections.Specialized
Imports RASTREO_Lib

Public Class RASTREO_Settings

    Private lista_TCP As New StringCollection()
    Private lista_UDP As New StringCollection()

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        SaveSettings()
        'MessageBox.Show("Debe reiniciar (detener/iniciar) el programa servidor paa que los cambios surgan efecto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub chkTCP_ON_OFF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTCP_ON_OFF.CheckedChanged
        GBTCP_.Enabled = chkTCP_ON_OFF.Checked
    End Sub

    Private Sub chkUDP_ON_OFF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUDP_ON_OFF.CheckedChanged
        GBUDP_.Enabled = chkUDP_ON_OFF.Checked
    End Sub

    Private Sub RASTREO_Settings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case CType(Keys.ControlKey + Keys.G, Keys)
                SaveSettings()
                Me.Close()
            Case CType(Keys.ControlKey + Keys.S, Keys)
                SaveSettings()
                Me.Close()
        End Select
    End Sub

    Private Function LoadSettings() As Boolean
        Try
            With My.Settings
                .Reload()
                ckhTCPPatch.Checked = .TCPPatch
                txtMensaje_Inactivos.Text = .g_Mensaje_Inactivos
                txtMAPSERVERPORT.Text = .g_MapServerPORT
                txtMAPSERVERIP.Text = .g_MapServerIP
                cmboPROTO.SelectedItem = Nothing
                cmboPROTO.SelectedIndex = cmboPROTO.FindStringExact(.RS_Server_ProtocoloIP)
                chkReenvio.Checked = .RS_Server_reenvio
                txtIPReenvio.Text = .RS_Server_IPReenvio
                txtPortReenvio.Text = .RS_Server_PortReenvio
                lista_TCP = .RS_PuertosTCP
                lista_UDP = .RS_PuertosUDP
                txSERVERDB.Text = .RS_Server_DB
                txSERVERCNNSTR.Text = .RS_ServerCNNSTR
                txSERVERIP.Text = .RS_ServerIP
                txSERVERPASSDB.Text = .RS_ServerPASSDB
                txSERVERPORT.Text = .RS_ServerPORT
                txSERVERUSERDB.Text = .RS_ServerUSERDB
                chkTCP_ON_OFF.Checked = .RS_Server_useTCP
                chkUDP_ON_OFF.Checked = .RS_Server_useUDP
                chkTCP_ON_OFF_CheckedChanged(sender:=New Object, e:=New System.EventArgs)
                chkUDP_ON_OFF_CheckedChanged(sender:=New Object, e:=New System.EventArgs)
                lbTCPPORTS.Items.Clear()
                lbUDPPORTS.Items.Clear()
                For Each P As String In .RS_PuertosTCP
                    lbTCPPORTS.Items.Add(P)
                Next
                For Each P As String In .RS_PuertosUDP
                    lbUDPPORTS.Items.Add(P)
                Next
            End With
            Return True
        Catch eXc As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(eXc)
            Return False
        End Try
    End Function

    Private Function SaveSettings() As Boolean
        Try
            With My.Settings
                .TCPPatch = ckhTCPPatch.Checked
                .RS_Server_ProtocoloIP = cmboPROTO.SelectedItem.ToString()
                .RS_Server_reenvio = chkReenvio.Checked
                .RS_Server_IPReenvio = txtIPReenvio.Text
                .RS_Server_PortReenvio = txtPortReenvio.Text
                .RS_ServerCNNSTR = txSERVERCNNSTR.Text
                .RS_ServerIP = txSERVERIP.Text
                .RS_ServerPORT = txSERVERPORT.Text
                .RS_ServerUSERDB = txSERVERUSERDB.Text
                .RS_ServerPASSDB = txSERVERPASSDB.Text
                .RS_Server_useTCP = chkTCP_ON_OFF.Checked
                .RS_Server_useUDP = chkUDP_ON_OFF.Checked
                .RS_Server_DB = txSERVERDB.Text
                .RS_PuertosTCP.Clear()
                .RS_PuertosUDP.Clear()
                .g_MapServerIP = txtMAPSERVERIP.Text
                .g_MapServerPORT = txtMAPSERVERPORT.Text
                .g_Mensaje_Inactivos = txtMensaje_Inactivos.Text.Trim()
                For Each P As String In lbTCPPORTS.Items
                    .RS_PuertosTCP.Add(P)
                Next
                For Each P As String In lbUDPPORTS.Items
                    .RS_PuertosUDP.Add(P)
                Next
                .Save()
            End With
            Return True
        Catch eXc As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(eXc)
            Return False
        End Try
    End Function

    Private Sub RASTREO_Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub txSERVERIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txSERVERIP.TextChanged
        MakeCNNSTR()
    End Sub

    Private Function MakeCNNSTR() As Boolean
        Try
            'cnnstring para postgres
            'Server=localhost;Port=5432;User Id=pgsql;Password=pgsql;Database=rastreo_system;
            txSERVERCNNSTR.Text = _
                "Server=" + txSERVERIP.Text + ";" + _
                "Port=" + txSERVERPORT.Text + ";" + _
                "User Id=" + txSERVERUSERDB.Text + ";" + _
                "Password=" + txSERVERPASSDB.Text + ";" + _
                "Database=" + txSERVERDB.Text
        Catch eXc As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(eXc)
            Return False
        End Try
    End Function

    Private Sub txSERVERUSERDB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txSERVERUSERDB.TextChanged
        MakeCNNSTR()
    End Sub

    Private Sub txSERVERPORT_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txSERVERPORT.TextChanged
        MakeCNNSTR()
    End Sub

    Private Sub txSERVERPASSDB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txSERVERPASSDB.TextChanged
        MakeCNNSTR()
    End Sub

    Private Sub txSERVERDB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txSERVERDB.TextChanged
        MakeCNNSTR()
    End Sub

    Private Sub btnAddUDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUDP.Click
        Dim toAdd As String = txUDPPORT.Text.Trim
        With lbUDPPORTS
            If toAdd <> String.Empty Then
                If Not .Items.Contains(toAdd) Then
                    .Items.Add(toAdd)
                End If
            End If
        End With
    End Sub

    Private Sub btnEiminarUDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEiminarUDP.Click
        With lbUDPPORTS
            If Not .SelectedItem Is Nothing Then
                Dim toDel As String = Convert.ToString(.SelectedItem)
                txUDPPORT.Text = toDel
                .Items.Remove(toDel)
            End If
        End With
    End Sub

    Private Sub btnAddTCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTCP.Click
        Dim toAdd As String = txTCPPORT.Text.Trim
        With lbTCPPORTS
            If toAdd <> String.Empty Then
                If Not .Items.Contains(toAdd) Then
                    .Items.Add(toAdd)
                End If
            End If
        End With
    End Sub

    Private Sub btnEliminarTCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarTCP.Click
        With lbTCPPORTS
            If Not .SelectedItem Is Nothing Then
                Dim toDel As String = Convert.ToString(.SelectedItem)
                txTCPPORT.Text = toDel
                .Items.Remove(toDel)
            End If
        End With
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub
End Class
