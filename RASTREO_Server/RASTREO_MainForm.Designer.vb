<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RASTREO_MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RASTREO_MainForm))
        Me.CtxMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RASTREOServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.rastrear_AppSrv = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolaDeDatosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarEscuchaDePuertosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarVentanaPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OcultarVentanaPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerArchivosDeLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarServidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRASTREO = New System.Windows.Forms.MenuStrip()
        Me.ServidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerArchivosDeLOGToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstalarComoServicio_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirDirectorioDelAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolaDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OcultarVentnaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStartServer = New System.Windows.Forms.Button()
        Me.btnRestartServer = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnStopServer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbUDP = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbTCP = New System.Windows.Forms.ListBox()
        Me.Timer_ChkStats = New System.Windows.Forms.Timer(Me.components)
        Me.nfIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lbINFO = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbSTATUS = New System.Windows.Forms.ListBox()
        Me.CtxMenuStrip.SuspendLayout()
        Me.menuRASTREO.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CtxMenuStrip
        '
        Me.CtxMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RASTREOServerToolStripMenuItem, Me.ToolStripSeparator1, Me.rastrear_AppSrv, Me.ConsolaDeDatosToolStripMenuItem1, Me.ReiniciarEscuchaDePuertosToolStripMenuItem, Me.AjustesToolStripMenuItem, Me.MostrarVentanaPrincipalToolStripMenuItem, Me.OcultarVentanaPrincipalToolStripMenuItem, Me.VerArchivosDeLogToolStripMenuItem, Me.CerrarServidorToolStripMenuItem})
        Me.CtxMenuStrip.Name = "CtxMenuStrip"
        Me.CtxMenuStrip.Size = New System.Drawing.Size(241, 208)
        '
        'RASTREOServerToolStripMenuItem
        '
        Me.RASTREOServerToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RASTREOServerToolStripMenuItem.Checked = True
        Me.RASTREOServerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RASTREOServerToolStripMenuItem.DoubleClickEnabled = True
        Me.RASTREOServerToolStripMenuItem.Image = CType(resources.GetObject("RASTREOServerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RASTREOServerToolStripMenuItem.Name = "RASTREOServerToolStripMenuItem"
        Me.RASTREOServerToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.RASTREOServerToolStripMenuItem.Text = "RASTREO Server"
        Me.RASTREOServerToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(237, 6)
        '
        'rastrear_AppSrv
        '
        Me.rastrear_AppSrv.Image = CType(resources.GetObject("rastrear_AppSrv.Image"), System.Drawing.Image)
        Me.rastrear_AppSrv.Name = "rastrear_AppSrv"
        Me.rastrear_AppSrv.Size = New System.Drawing.Size(240, 22)
        Me.rastrear_AppSrv.Text = "Ventana de avisos del servidor"
        '
        'ConsolaDeDatosToolStripMenuItem1
        '
        Me.ConsolaDeDatosToolStripMenuItem1.Image = CType(resources.GetObject("ConsolaDeDatosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ConsolaDeDatosToolStripMenuItem1.Name = "ConsolaDeDatosToolStripMenuItem1"
        Me.ConsolaDeDatosToolStripMenuItem1.Size = New System.Drawing.Size(240, 22)
        Me.ConsolaDeDatosToolStripMenuItem1.Text = "Monitor de Datos"
        '
        'ReiniciarEscuchaDePuertosToolStripMenuItem
        '
        Me.ReiniciarEscuchaDePuertosToolStripMenuItem.Image = CType(resources.GetObject("ReiniciarEscuchaDePuertosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReiniciarEscuchaDePuertosToolStripMenuItem.Name = "ReiniciarEscuchaDePuertosToolStripMenuItem"
        Me.ReiniciarEscuchaDePuertosToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReiniciarEscuchaDePuertosToolStripMenuItem.Text = "Reiniciar Escucha de Puertos"
        '
        'AjustesToolStripMenuItem
        '
        Me.AjustesToolStripMenuItem.Image = CType(resources.GetObject("AjustesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjustesToolStripMenuItem.Name = "AjustesToolStripMenuItem"
        Me.AjustesToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.AjustesToolStripMenuItem.Text = "Ajustes"
        '
        'MostrarVentanaPrincipalToolStripMenuItem
        '
        Me.MostrarVentanaPrincipalToolStripMenuItem.Image = CType(resources.GetObject("MostrarVentanaPrincipalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MostrarVentanaPrincipalToolStripMenuItem.Name = "MostrarVentanaPrincipalToolStripMenuItem"
        Me.MostrarVentanaPrincipalToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.MostrarVentanaPrincipalToolStripMenuItem.Text = "Mostrar ventana principal"
        '
        'OcultarVentanaPrincipalToolStripMenuItem
        '
        Me.OcultarVentanaPrincipalToolStripMenuItem.Image = CType(resources.GetObject("OcultarVentanaPrincipalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OcultarVentanaPrincipalToolStripMenuItem.Name = "OcultarVentanaPrincipalToolStripMenuItem"
        Me.OcultarVentanaPrincipalToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.OcultarVentanaPrincipalToolStripMenuItem.Text = "Ocultar ventana principal"
        '
        'VerArchivosDeLogToolStripMenuItem
        '
        Me.VerArchivosDeLogToolStripMenuItem.Image = CType(resources.GetObject("VerArchivosDeLogToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerArchivosDeLogToolStripMenuItem.Name = "VerArchivosDeLogToolStripMenuItem"
        Me.VerArchivosDeLogToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.VerArchivosDeLogToolStripMenuItem.Text = "Ver archivos de LOG"
        '
        'CerrarServidorToolStripMenuItem
        '
        Me.CerrarServidorToolStripMenuItem.Image = CType(resources.GetObject("CerrarServidorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarServidorToolStripMenuItem.Name = "CerrarServidorToolStripMenuItem"
        Me.CerrarServidorToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.CerrarServidorToolStripMenuItem.Text = "Cerrar Servidor"
        '
        'menuRASTREO
        '
        Me.menuRASTREO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServidorToolStripMenuItem, Me.ConsolaDeDatosToolStripMenuItem, Me.OcultarVentnaToolStripMenuItem})
        Me.menuRASTREO.Location = New System.Drawing.Point(0, 0)
        Me.menuRASTREO.Name = "menuRASTREO"
        Me.menuRASTREO.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuRASTREO.Size = New System.Drawing.Size(814, 24)
        Me.menuRASTREO.TabIndex = 1
        Me.menuRASTREO.Text = "MenuStrip1"
        '
        'ServidorToolStripMenuItem
        '
        Me.ServidorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjustesToolStripMenuItem1, Me.VerArchivosDeLOGToolStripMenuItem1, Me.InstalarComoServicio_ToolStripMenuItem, Me.AbrirDirectorioDelAppToolStripMenuItem})
        Me.ServidorToolStripMenuItem.Name = "ServidorToolStripMenuItem"
        Me.ServidorToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ServidorToolStripMenuItem.Text = "Servidor"
        '
        'AjustesToolStripMenuItem1
        '
        Me.AjustesToolStripMenuItem1.Name = "AjustesToolStripMenuItem1"
        Me.AjustesToolStripMenuItem1.Size = New System.Drawing.Size(239, 22)
        Me.AjustesToolStripMenuItem1.Text = "Ajustes"
        '
        'VerArchivosDeLOGToolStripMenuItem1
        '
        Me.VerArchivosDeLOGToolStripMenuItem1.Name = "VerArchivosDeLOGToolStripMenuItem1"
        Me.VerArchivosDeLOGToolStripMenuItem1.Size = New System.Drawing.Size(239, 22)
        Me.VerArchivosDeLOGToolStripMenuItem1.Text = "Ver archivos de LOG"
        '
        'InstalarComoServicio_ToolStripMenuItem
        '
        Me.InstalarComoServicio_ToolStripMenuItem.Name = "InstalarComoServicio_ToolStripMenuItem"
        Me.InstalarComoServicio_ToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.InstalarComoServicio_ToolStripMenuItem.Text = "Instalar como servicio"
        '
        'AbrirDirectorioDelAppToolStripMenuItem
        '
        Me.AbrirDirectorioDelAppToolStripMenuItem.Name = "AbrirDirectorioDelAppToolStripMenuItem"
        Me.AbrirDirectorioDelAppToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.AbrirDirectorioDelAppToolStripMenuItem.Text = "Abrir directorio de la aplicacion"
        '
        'ConsolaDeDatosToolStripMenuItem
        '
        Me.ConsolaDeDatosToolStripMenuItem.Name = "ConsolaDeDatosToolStripMenuItem"
        Me.ConsolaDeDatosToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.ConsolaDeDatosToolStripMenuItem.Text = "Consola de Datos"
        '
        'OcultarVentnaToolStripMenuItem
        '
        Me.OcultarVentnaToolStripMenuItem.Name = "OcultarVentnaToolStripMenuItem"
        Me.OcultarVentnaToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.OcultarVentnaToolStripMenuItem.Text = "Ocultar Ventana"
        '
        'btnStartServer
        '
        Me.btnStartServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartServer.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnStartServer.Image = CType(resources.GetObject("btnStartServer.Image"), System.Drawing.Image)
        Me.btnStartServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStartServer.Location = New System.Drawing.Point(3, 3)
        Me.btnStartServer.Name = "btnStartServer"
        Me.btnStartServer.Size = New System.Drawing.Size(95, 26)
        Me.btnStartServer.TabIndex = 0
        Me.btnStartServer.Text = "INICIAR"
        Me.btnStartServer.UseVisualStyleBackColor = True
        '
        'btnRestartServer
        '
        Me.btnRestartServer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRestartServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestartServer.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnRestartServer.Image = CType(resources.GetObject("btnRestartServer.Image"), System.Drawing.Image)
        Me.btnRestartServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestartServer.Location = New System.Drawing.Point(211, 3)
        Me.btnRestartServer.Name = "btnRestartServer"
        Me.btnRestartServer.Size = New System.Drawing.Size(133, 26)
        Me.btnRestartServer.TabIndex = 4
        Me.btnRestartServer.Text = "REINICIAR"
        Me.btnRestartServer.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.7069!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.2931!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnStopServer, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStartServer, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRestartServer, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(238, 270)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(356, 32)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'btnStopServer
        '
        Me.btnStopServer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStopServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopServer.ForeColor = System.Drawing.Color.DarkRed
        Me.btnStopServer.Image = CType(resources.GetObject("btnStopServer.Image"), System.Drawing.Image)
        Me.btnStopServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStopServer.Location = New System.Drawing.Point(104, 3)
        Me.btnStopServer.Name = "btnStopServer"
        Me.btnStopServer.Size = New System.Drawing.Size(101, 26)
        Me.btnStopServer.TabIndex = 5
        Me.btnStopServer.Text = "DETENER"
        Me.btnStopServer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbUDP)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox2.Size = New System.Drawing.Size(402, 152)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Puertos UDP - Paquetes  recepcionados"
        '
        'lbUDP
        '
        Me.lbUDP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbUDP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbUDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUDP.ForeColor = System.Drawing.Color.CadetBlue
        Me.lbUDP.FormattingEnabled = True
        Me.lbUDP.HorizontalScrollbar = True
        Me.lbUDP.Location = New System.Drawing.Point(3, 14)
        Me.lbUDP.Name = "lbUDP"
        Me.lbUDP.Size = New System.Drawing.Size(396, 137)
        Me.lbUDP.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbTCP)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(411, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GroupBox1.Size = New System.Drawing.Size(402, 152)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Puertos TCP - Paquetes  recepcionados"
        '
        'lbTCP
        '
        Me.lbTCP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbTCP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbTCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTCP.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbTCP.FormattingEnabled = True
        Me.lbTCP.HorizontalScrollbar = True
        Me.lbTCP.Location = New System.Drawing.Point(3, 14)
        Me.lbTCP.Name = "lbTCP"
        Me.lbTCP.Size = New System.Drawing.Size(396, 137)
        Me.lbTCP.TabIndex = 0
        '
        'Timer_ChkStats
        '
        '
        'nfIcon
        '
        Me.nfIcon.ContextMenuStrip = Me.CtxMenuStrip
        Me.nfIcon.Icon = CType(resources.GetObject("nfIcon.Icon"), System.Drawing.Icon)
        Me.nfIcon.Text = "RASTREO Server"
        Me.nfIcon.Visible = True
        '
        'lbINFO
        '
        Me.lbINFO.BackColor = System.Drawing.Color.SlateGray
        Me.lbINFO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbINFO.ForeColor = System.Drawing.Color.White
        Me.lbINFO.FormattingEnabled = True
        Me.lbINFO.HorizontalScrollbar = True
        Me.lbINFO.ItemHeight = 15
        Me.lbINFO.Location = New System.Drawing.Point(6, 185)
        Me.lbINFO.Name = "lbINFO"
        Me.lbINFO.Size = New System.Drawing.Size(402, 79)
        Me.lbINFO.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(600, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Completar direcciones en Base de datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbSTATUS
        '
        Me.lbSTATUS.BackColor = System.Drawing.Color.SlateGray
        Me.lbSTATUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSTATUS.ForeColor = System.Drawing.Color.White
        Me.lbSTATUS.FormattingEnabled = True
        Me.lbSTATUS.HorizontalScrollbar = True
        Me.lbSTATUS.ItemHeight = 15
        Me.lbSTATUS.Location = New System.Drawing.Point(411, 185)
        Me.lbSTATUS.Name = "lbSTATUS"
        Me.lbSTATUS.Size = New System.Drawing.Size(396, 79)
        Me.lbSTATUS.TabIndex = 11
        '
        'RASTREO_MainForm
        '
        Me.AcceptButton = Me.btnStartServer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnRestartServer
        Me.ClientSize = New System.Drawing.Size(814, 301)
        Me.ContextMenuStrip = Me.CtxMenuStrip
        Me.Controls.Add(Me.menuRASTREO)
        Me.Controls.Add(Me.lbSTATUS)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbINFO)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuRASTREO
        Me.MaximizeBox = False
        Me.Name = "RASTREO_MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RASTREO Server"
        Me.CtxMenuStrip.ResumeLayout(False)
        Me.menuRASTREO.ResumeLayout(False)
        Me.menuRASTREO.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtxMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AjustesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuRASTREO As System.Windows.Forms.MenuStrip
    Friend WithEvents ServidorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjustesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsolaDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStartServer As System.Windows.Forms.Button
    Friend WithEvents btnRestartServer As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbTCP As System.Windows.Forms.ListBox
    Friend WithEvents lbUDP As System.Windows.Forms.ListBox
    Friend WithEvents Timer_ChkStats As System.Windows.Forms.Timer
    Friend WithEvents nfIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents MostrarVentanaPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerArchivosDeLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerArchivosDeLOGToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OcultarVentnaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReiniciarEscuchaDePuertosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStopServer As System.Windows.Forms.Button
    Friend WithEvents OcultarVentanaPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarServidorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RASTREOServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConsolaDeDatosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbINFO As System.Windows.Forms.ListBox
    Friend WithEvents rastrear_AppSrv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstalarComoServicio_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirDirectorioDelAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbSTATUS As System.Windows.Forms.ListBox

End Class
