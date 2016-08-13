Imports System.Windows.Forms

Public Class Settings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        SaveSettings()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SaveSettings()
        My.Settings.mailFROM = txtMail.Text
        My.Settings.mailPASS = txtPass.Text
        My.Settings.mailPORT = Convert.ToInt32(txtPort.Text)
        My.Settings.mailSERVER = txtServ.Text
        My.Settings.mailUSER = txtUser.Text
        My.Settings.mailSSL = chkSSL.Checked
        My.Settings.g_EsperaSegundos = Convert.ToInt32(txtSgsProc.Text)
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub LoadSettings()
        txtMail.Text = My.Settings.mailFROM
        txtPass.Text = My.Settings.mailPASS
        txtPort.Text = My.Settings.mailPORT.ToString()
        txtServ.Text = My.Settings.mailSERVER
        txtUser.Text = My.Settings.mailUSER
        chkSSL.Checked = My.Settings.mailSSL
        txtSgsProc.Text = My.Settings.g_EsperaSegundos.ToString()
    End Sub

    Private Sub Settings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadSettings()
    End Sub
End Class