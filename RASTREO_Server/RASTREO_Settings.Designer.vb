<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RASTREO_Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RASTREO_Settings))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lbUDPPORTS = New System.Windows.Forms.ListBox()
        Me.lbTCPPORTS = New System.Windows.Forms.ListBox()
        Me.txTCPPORT = New System.Windows.Forms.MaskedTextBox()
        Me.txUDPPORT = New System.Windows.Forms.MaskedTextBox()
        Me.chkUDP_ON_OFF = New System.Windows.Forms.CheckBox()
        Me.chkTCP_ON_OFF = New System.Windows.Forms.CheckBox()
        Me.GBTCP_ = New System.Windows.Forms.GroupBox()
        Me.btnEliminarTCP = New System.Windows.Forms.Button()
        Me.btnAddTCP = New System.Windows.Forms.Button()
        Me.GBUDP_ = New System.Windows.Forms.GroupBox()
        Me.btnEiminarUDP = New System.Windows.Forms.Button()
        Me.btnAddUDP = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txSERVERDB = New System.Windows.Forms.TextBox()
        Me.txSERVERIP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txSERVERCNNSTR = New System.Windows.Forms.TextBox()
        Me.txSERVERPASSDB = New System.Windows.Forms.TextBox()
        Me.txSERVERUSERDB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txSERVERPORT = New System.Windows.Forms.MaskedTextBox()
        Me.chkReenvio = New System.Windows.Forms.CheckBox()
        Me.txtPortReenvio = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIPReenvio = New System.Windows.Forms.TextBox()
        Me.cmboPROTO = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMAPSERVERIP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMAPSERVERPORT = New System.Windows.Forms.MaskedTextBox()
        Me.txtMensaje_Inactivos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ckhTCPPatch = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GBTCP_.SuspendLayout()
        Me.GBUDP_.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.49367!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.50633!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(602, 175)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(175, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(98, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Guardar ajustes"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(107, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(65, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'lbUDPPORTS
        '
        Me.lbUDPPORTS.FormattingEnabled = True
        Me.lbUDPPORTS.Location = New System.Drawing.Point(6, 47)
        Me.lbUDPPORTS.Name = "lbUDPPORTS"
        Me.lbUDPPORTS.Size = New System.Drawing.Size(79, 56)
        Me.lbUDPPORTS.TabIndex = 1
        '
        'lbTCPPORTS
        '
        Me.lbTCPPORTS.FormattingEnabled = True
        Me.lbTCPPORTS.Location = New System.Drawing.Point(6, 45)
        Me.lbTCPPORTS.Name = "lbTCPPORTS"
        Me.lbTCPPORTS.Size = New System.Drawing.Size(83, 56)
        Me.lbTCPPORTS.TabIndex = 2
        '
        'txTCPPORT
        '
        Me.txTCPPORT.Location = New System.Drawing.Point(6, 19)
        Me.txTCPPORT.Mask = "99999"
        Me.txTCPPORT.Name = "txTCPPORT"
        Me.txTCPPORT.Size = New System.Drawing.Size(83, 20)
        Me.txTCPPORT.TabIndex = 3
        Me.txTCPPORT.ValidatingType = GetType(Integer)
        '
        'txUDPPORT
        '
        Me.txUDPPORT.Location = New System.Drawing.Point(6, 19)
        Me.txUDPPORT.Mask = "99999"
        Me.txUDPPORT.Name = "txUDPPORT"
        Me.txUDPPORT.Size = New System.Drawing.Size(79, 20)
        Me.txUDPPORT.TabIndex = 4
        Me.txUDPPORT.ValidatingType = GetType(Integer)
        '
        'chkUDP_ON_OFF
        '
        Me.chkUDP_ON_OFF.AutoSize = True
        Me.chkUDP_ON_OFF.Location = New System.Drawing.Point(7, 12)
        Me.chkUDP_ON_OFF.Name = "chkUDP_ON_OFF"
        Me.chkUDP_ON_OFF.Size = New System.Drawing.Size(85, 17)
        Me.chkUDP_ON_OFF.TabIndex = 5
        Me.chkUDP_ON_OFF.Text = "Activar UDP"
        Me.chkUDP_ON_OFF.UseVisualStyleBackColor = True
        '
        'chkTCP_ON_OFF
        '
        Me.chkTCP_ON_OFF.AutoSize = True
        Me.chkTCP_ON_OFF.Location = New System.Drawing.Point(216, 12)
        Me.chkTCP_ON_OFF.Name = "chkTCP_ON_OFF"
        Me.chkTCP_ON_OFF.Size = New System.Drawing.Size(83, 17)
        Me.chkTCP_ON_OFF.TabIndex = 6
        Me.chkTCP_ON_OFF.Text = "Activar TCP"
        Me.chkTCP_ON_OFF.UseVisualStyleBackColor = True
        '
        'GBTCP_
        '
        Me.GBTCP_.Controls.Add(Me.btnEliminarTCP)
        Me.GBTCP_.Controls.Add(Me.btnAddTCP)
        Me.GBTCP_.Controls.Add(Me.lbTCPPORTS)
        Me.GBTCP_.Controls.Add(Me.txTCPPORT)
        Me.GBTCP_.Location = New System.Drawing.Point(210, 35)
        Me.GBTCP_.Name = "GBTCP_"
        Me.GBTCP_.Size = New System.Drawing.Size(195, 106)
        Me.GBTCP_.TabIndex = 7
        Me.GBTCP_.TabStop = False
        Me.GBTCP_.Text = "Ajustes TCP"
        '
        'btnEliminarTCP
        '
        Me.btnEliminarTCP.Location = New System.Drawing.Point(95, 67)
        Me.btnEliminarTCP.Name = "btnEliminarTCP"
        Me.btnEliminarTCP.Size = New System.Drawing.Size(88, 34)
        Me.btnEliminarTCP.TabIndex = 8
        Me.btnEliminarTCP.Text = "Eliminar puerto"
        Me.btnEliminarTCP.UseVisualStyleBackColor = True
        '
        'btnAddTCP
        '
        Me.btnAddTCP.Location = New System.Drawing.Point(95, 17)
        Me.btnAddTCP.Name = "btnAddTCP"
        Me.btnAddTCP.Size = New System.Drawing.Size(88, 22)
        Me.btnAddTCP.TabIndex = 7
        Me.btnAddTCP.Text = "Agregar puerto"
        Me.btnAddTCP.UseVisualStyleBackColor = True
        '
        'GBUDP_
        '
        Me.GBUDP_.Controls.Add(Me.btnEiminarUDP)
        Me.GBUDP_.Controls.Add(Me.btnAddUDP)
        Me.GBUDP_.Controls.Add(Me.lbUDPPORTS)
        Me.GBUDP_.Controls.Add(Me.txUDPPORT)
        Me.GBUDP_.Location = New System.Drawing.Point(7, 35)
        Me.GBUDP_.Name = "GBUDP_"
        Me.GBUDP_.Size = New System.Drawing.Size(197, 106)
        Me.GBUDP_.TabIndex = 8
        Me.GBUDP_.TabStop = False
        Me.GBUDP_.Text = "Ajustes UDP"
        '
        'btnEiminarUDP
        '
        Me.btnEiminarUDP.Location = New System.Drawing.Point(97, 67)
        Me.btnEiminarUDP.Name = "btnEiminarUDP"
        Me.btnEiminarUDP.Size = New System.Drawing.Size(88, 34)
        Me.btnEiminarUDP.TabIndex = 6
        Me.btnEiminarUDP.Text = "Eliminar puerto"
        Me.btnEiminarUDP.UseVisualStyleBackColor = True
        '
        'btnAddUDP
        '
        Me.btnAddUDP.Location = New System.Drawing.Point(91, 17)
        Me.btnAddUDP.Name = "btnAddUDP"
        Me.btnAddUDP.Size = New System.Drawing.Size(94, 22)
        Me.btnAddUDP.TabIndex = 5
        Me.btnAddUDP.Text = "Agregar puerto"
        Me.btnAddUDP.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txSERVERDB)
        Me.GroupBox1.Controls.Add(Me.txSERVERIP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txSERVERCNNSTR)
        Me.GroupBox1.Controls.Add(Me.txSERVERPASSDB)
        Me.GroupBox1.Controls.Add(Me.txSERVERUSERDB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txSERVERPORT)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 169)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajustes del servidor de base de datos"
        Me.GroupBox1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Base de Datos del sistema"
        '
        'txSERVERDB
        '
        Me.txSERVERDB.Location = New System.Drawing.Point(191, 71)
        Me.txSERVERDB.Name = "txSERVERDB"
        Me.txSERVERDB.Size = New System.Drawing.Size(155, 20)
        Me.txSERVERDB.TabIndex = 12
        '
        'txSERVERIP
        '
        Me.txSERVERIP.Location = New System.Drawing.Point(101, 19)
        Me.txSERVERIP.Name = "txSERVERIP"
        Me.txSERVERIP.Size = New System.Drawing.Size(117, 20)
        Me.txSERVERIP.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cadena de conexion resultante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password DB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Usuario DB"
        '
        'txSERVERCNNSTR
        '
        Me.txSERVERCNNSTR.Location = New System.Drawing.Point(6, 117)
        Me.txSERVERCNNSTR.Multiline = True
        Me.txSERVERCNNSTR.Name = "txSERVERCNNSTR"
        Me.txSERVERCNNSTR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txSERVERCNNSTR.Size = New System.Drawing.Size(458, 46)
        Me.txSERVERCNNSTR.TabIndex = 7
        '
        'txSERVERPASSDB
        '
        Me.txSERVERPASSDB.Location = New System.Drawing.Point(308, 45)
        Me.txSERVERPASSDB.Name = "txSERVERPASSDB"
        Me.txSERVERPASSDB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txSERVERPASSDB.Size = New System.Drawing.Size(156, 20)
        Me.txSERVERPASSDB.TabIndex = 6
        '
        'txSERVERUSERDB
        '
        Me.txSERVERUSERDB.Location = New System.Drawing.Point(309, 19)
        Me.txSERVERUSERDB.Name = "txSERVERUSERDB"
        Me.txSERVERUSERDB.Size = New System.Drawing.Size(155, 20)
        Me.txSERVERUSERDB.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Puerto del Servidor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IP del Servidor"
        '
        'txSERVERPORT
        '
        Me.txSERVERPORT.Location = New System.Drawing.Point(101, 45)
        Me.txSERVERPORT.Mask = "99999"
        Me.txSERVERPORT.Name = "txSERVERPORT"
        Me.txSERVERPORT.Size = New System.Drawing.Size(37, 20)
        Me.txSERVERPORT.TabIndex = 0
        Me.txSERVERPORT.ValidatingType = GetType(Integer)
        '
        'chkReenvio
        '
        Me.chkReenvio.AutoSize = True
        Me.chkReenvio.Location = New System.Drawing.Point(425, 12)
        Me.chkReenvio.Name = "chkReenvio"
        Me.chkReenvio.Size = New System.Drawing.Size(66, 17)
        Me.chkReenvio.TabIndex = 10
        Me.chkReenvio.Text = "Reenvio"
        Me.chkReenvio.UseVisualStyleBackColor = True
        '
        'txtPortReenvio
        '
        Me.txtPortReenvio.Location = New System.Drawing.Point(512, 64)
        Me.txtPortReenvio.Mask = "99999"
        Me.txtPortReenvio.Name = "txtPortReenvio"
        Me.txtPortReenvio.Size = New System.Drawing.Size(83, 20)
        Me.txtPortReenvio.TabIndex = 11
        Me.txtPortReenvio.ValidatingType = GetType(Integer)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(418, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Puerto a reenviar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(418, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "IP a reenviar"
        '
        'txtIPReenvio
        '
        Me.txtIPReenvio.Location = New System.Drawing.Point(512, 35)
        Me.txtIPReenvio.Name = "txtIPReenvio"
        Me.txtIPReenvio.Size = New System.Drawing.Size(117, 20)
        Me.txtIPReenvio.TabIndex = 14
        '
        'cmboPROTO
        '
        Me.cmboPROTO.FormattingEnabled = True
        Me.cmboPROTO.Items.AddRange(New Object() {"TCP", "UDP"})
        Me.cmboPROTO.Location = New System.Drawing.Point(512, 91)
        Me.cmboPROTO.Name = "cmboPROTO"
        Me.cmboPROTO.Size = New System.Drawing.Size(83, 21)
        Me.cmboPROTO.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(418, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Protocolo"
        '
        'txtMAPSERVERIP
        '
        Me.txtMAPSERVERIP.Location = New System.Drawing.Point(650, 35)
        Me.txtMAPSERVERIP.Name = "txtMAPSERVERIP"
        Me.txtMAPSERVERIP.Size = New System.Drawing.Size(117, 20)
        Me.txtMAPSERVERIP.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(671, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Mapserver IP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(661, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Mapserver PORT"
        '
        'txtMAPSERVERPORT
        '
        Me.txtMAPSERVERPORT.Location = New System.Drawing.Point(668, 77)
        Me.txtMAPSERVERPORT.Mask = "99999"
        Me.txtMAPSERVERPORT.Name = "txtMAPSERVERPORT"
        Me.txtMAPSERVERPORT.Size = New System.Drawing.Size(83, 20)
        Me.txtMAPSERVERPORT.TabIndex = 19
        Me.txtMAPSERVERPORT.ValidatingType = GetType(Integer)
        '
        'txtMensaje_Inactivos
        '
        Me.txtMensaje_Inactivos.Location = New System.Drawing.Point(421, 132)
        Me.txtMensaje_Inactivos.Name = "txtMensaje_Inactivos"
        Me.txtMensaje_Inactivos.Size = New System.Drawing.Size(344, 20)
        Me.txtMensaje_Inactivos.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(418, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Mensaje de puertos inactivos"
        '
        'ckhTCPPatch
        '
        Me.ckhTCPPatch.AutoSize = True
        Me.ckhTCPPatch.Location = New System.Drawing.Point(305, 12)
        Me.ckhTCPPatch.Name = "ckhTCPPatch"
        Me.ckhTCPPatch.Size = New System.Drawing.Size(73, 17)
        Me.ckhTCPPatch.TabIndex = 23
        Me.ckhTCPPatch.Text = "TCP ""Fix"""
        Me.ckhTCPPatch.UseVisualStyleBackColor = True
        '
        'RASTREO_Settings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(777, 204)
        Me.Controls.Add(Me.ckhTCPPatch)
        Me.Controls.Add(Me.txtMensaje_Inactivos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMAPSERVERPORT)
        Me.Controls.Add(Me.txtMAPSERVERIP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmboPROTO)
        Me.Controls.Add(Me.txtIPReenvio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPortReenvio)
        Me.Controls.Add(Me.chkReenvio)
        Me.Controls.Add(Me.chkUDP_ON_OFF)
        Me.Controls.Add(Me.GBUDP_)
        Me.Controls.Add(Me.chkTCP_ON_OFF)
        Me.Controls.Add(Me.GBTCP_)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RASTREO_Settings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajustes del server"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GBTCP_.ResumeLayout(False)
        Me.GBTCP_.PerformLayout()
        Me.GBUDP_.ResumeLayout(False)
        Me.GBUDP_.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lbUDPPORTS As System.Windows.Forms.ListBox
    Friend WithEvents lbTCPPORTS As System.Windows.Forms.ListBox
    Friend WithEvents txTCPPORT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txUDPPORT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chkUDP_ON_OFF As System.Windows.Forms.CheckBox
    Friend WithEvents chkTCP_ON_OFF As System.Windows.Forms.CheckBox
    Friend WithEvents GBTCP_ As System.Windows.Forms.GroupBox
    Friend WithEvents GBUDP_ As System.Windows.Forms.GroupBox
    Friend WithEvents btnEiminarUDP As System.Windows.Forms.Button
    Friend WithEvents btnAddUDP As System.Windows.Forms.Button
    Friend WithEvents btnEliminarTCP As System.Windows.Forms.Button
    Friend WithEvents btnAddTCP As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txSERVERPORT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txSERVERCNNSTR As System.Windows.Forms.TextBox
    Friend WithEvents txSERVERPASSDB As System.Windows.Forms.TextBox
    Friend WithEvents txSERVERUSERDB As System.Windows.Forms.TextBox
    Friend WithEvents txSERVERIP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txSERVERDB As System.Windows.Forms.TextBox
    Friend WithEvents chkReenvio As System.Windows.Forms.CheckBox
    Friend WithEvents txtPortReenvio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIPReenvio As System.Windows.Forms.TextBox
    Friend WithEvents cmboPROTO As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMAPSERVERIP As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMAPSERVERPORT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMensaje_Inactivos As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ckhTCPPatch As System.Windows.Forms.CheckBox

End Class
