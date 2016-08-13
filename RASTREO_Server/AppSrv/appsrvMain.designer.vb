<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appMain_AppSrv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appMain_AppSrv))
        Me.btnStopService = New System.Windows.Forms.Button()
        Me.btnIniciarServicio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbGEOCProgress = New System.Windows.Forms.Label()
        Me.lbHRDProgress = New System.Windows.Forms.Label()
        Me.ni_appTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruServicios = New System.Windows.Forms.GroupBox()
        Me.GruPanico = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnApagarTodosLosEvento = New System.Windows.Forms.Button()
        Me.btnAtenderEvento = New System.Windows.Forms.Button()
        Me.listEventos = New System.Windows.Forms.DataGridView()
        Me.g_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GruServicios.SuspendLayout()
        Me.GruPanico.SuspendLayout()
        CType(Me.listEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStopService
        '
        Me.btnStopService.BackColor = System.Drawing.Color.DarkRed
        Me.btnStopService.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStopService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStopService.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStopService.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopService.ForeColor = System.Drawing.Color.White
        Me.btnStopService.Location = New System.Drawing.Point(6, 40)
        Me.btnStopService.Name = "btnStopService"
        Me.btnStopService.Size = New System.Drawing.Size(115, 24)
        Me.btnStopService.TabIndex = 0
        Me.btnStopService.Text = "Detener servicios"
        Me.btnStopService.UseVisualStyleBackColor = False
        '
        'btnIniciarServicio
        '
        Me.btnIniciarServicio.BackColor = System.Drawing.Color.DarkGreen
        Me.btnIniciarServicio.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnIniciarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIniciarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIniciarServicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarServicio.ForeColor = System.Drawing.Color.White
        Me.btnIniciarServicio.Location = New System.Drawing.Point(6, 13)
        Me.btnIniciarServicio.Name = "btnIniciarServicio"
        Me.btnIniciarServicio.Size = New System.Drawing.Size(115, 24)
        Me.btnIniciarServicio.TabIndex = 1
        Me.btnIniciarServicio.Text = "Iniciar servicios"
        Me.btnIniciarServicio.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Chequeo de geocercas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Chequeo de hojas de ruta: "
        '
        'lbGEOCProgress
        '
        Me.lbGEOCProgress.AutoSize = True
        Me.lbGEOCProgress.Location = New System.Drawing.Point(271, 19)
        Me.lbGEOCProgress.Name = "lbGEOCProgress"
        Me.lbGEOCProgress.Size = New System.Drawing.Size(15, 13)
        Me.lbGEOCProgress.TabIndex = 4
        Me.lbGEOCProgress.Text = "%"
        '
        'lbHRDProgress
        '
        Me.lbHRDProgress.AutoSize = True
        Me.lbHRDProgress.Location = New System.Drawing.Point(271, 46)
        Me.lbHRDProgress.Name = "lbHRDProgress"
        Me.lbHRDProgress.Size = New System.Drawing.Size(15, 13)
        Me.lbHRDProgress.TabIndex = 5
        Me.lbHRDProgress.Text = "%"
        '
        'ni_appTray
        '
        Me.ni_appTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ni_appTray.BalloonTipTitle = "Rastrear - Servicio de Aplicaciones"
        Me.ni_appTray.Icon = CType(resources.GetObject("ni_appTray.Icon"), System.Drawing.Icon)
        Me.ni_appTray.Text = "Servicio de aplicaciones - RASTREAR"
        Me.ni_appTray.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(130, 26)
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Image = CType(resources.GetObject("OpcionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'GruServicios
        '
        Me.GruServicios.Controls.Add(Me.btnIniciarServicio)
        Me.GruServicios.Controls.Add(Me.btnStopService)
        Me.GruServicios.Controls.Add(Me.Label2)
        Me.GruServicios.Controls.Add(Me.lbHRDProgress)
        Me.GruServicios.Controls.Add(Me.lbGEOCProgress)
        Me.GruServicios.Controls.Add(Me.Label1)
        Me.GruServicios.Dock = System.Windows.Forms.DockStyle.Top
        Me.GruServicios.Location = New System.Drawing.Point(0, 0)
        Me.GruServicios.Name = "GruServicios"
        Me.GruServicios.Size = New System.Drawing.Size(898, 72)
        Me.GruServicios.TabIndex = 7
        Me.GruServicios.TabStop = False
        Me.GruServicios.Text = "Servicios "
        '
        'GruPanico
        '
        Me.GruPanico.Controls.Add(Me.Button1)
        Me.GruPanico.Controls.Add(Me.btnConfig)
        Me.GruPanico.Controls.Add(Me.btnApagarTodosLosEvento)
        Me.GruPanico.Controls.Add(Me.btnAtenderEvento)
        Me.GruPanico.Controls.Add(Me.listEventos)
        Me.GruPanico.Dock = System.Windows.Forms.DockStyle.Top
        Me.GruPanico.Location = New System.Drawing.Point(0, 72)
        Me.GruPanico.Name = "GruPanico"
        Me.GruPanico.Size = New System.Drawing.Size(898, 298)
        Me.GruPanico.TabIndex = 8
        Me.GruPanico.TabStop = False
        Me.GruPanico.Text = "Eventos"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(718, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Enviar mail de prueba"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btnConfig
        '
        Me.btnConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfig.BackColor = System.Drawing.Color.SlateGray
        Me.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfig.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfig.ForeColor = System.Drawing.Color.White
        Me.btnConfig.Location = New System.Drawing.Point(2, 268)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(225, 24)
        Me.btnConfig.TabIndex = 6
        Me.btnConfig.Text = "Configuraciones de envio e-mail"
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'btnApagarTodosLosEvento
        '
        Me.btnApagarTodosLosEvento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnApagarTodosLosEvento.BackColor = System.Drawing.Color.Firebrick
        Me.btnApagarTodosLosEvento.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnApagarTodosLosEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnApagarTodosLosEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnApagarTodosLosEvento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApagarTodosLosEvento.ForeColor = System.Drawing.Color.White
        Me.btnApagarTodosLosEvento.Location = New System.Drawing.Point(356, 268)
        Me.btnApagarTodosLosEvento.Name = "btnApagarTodosLosEvento"
        Me.btnApagarTodosLosEvento.Size = New System.Drawing.Size(161, 24)
        Me.btnApagarTodosLosEvento.TabIndex = 3
        Me.btnApagarTodosLosEvento.Text = "Apagar todos los eventos"
        Me.btnApagarTodosLosEvento.UseVisualStyleBackColor = False
        '
        'btnAtenderEvento
        '
        Me.btnAtenderEvento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAtenderEvento.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAtenderEvento.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAtenderEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAtenderEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAtenderEvento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtenderEvento.ForeColor = System.Drawing.Color.White
        Me.btnAtenderEvento.Location = New System.Drawing.Point(235, 268)
        Me.btnAtenderEvento.Name = "btnAtenderEvento"
        Me.btnAtenderEvento.Size = New System.Drawing.Size(115, 24)
        Me.btnAtenderEvento.TabIndex = 2
        Me.btnAtenderEvento.Text = "Atender evento"
        Me.btnAtenderEvento.UseVisualStyleBackColor = False
        '
        'listEventos
        '
        Me.listEventos.AllowUserToAddRows = False
        Me.listEventos.AllowUserToDeleteRows = False
        Me.listEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listEventos.Dock = System.Windows.Forms.DockStyle.Top
        Me.listEventos.GridColor = System.Drawing.Color.Black
        Me.listEventos.Location = New System.Drawing.Point(3, 16)
        Me.listEventos.Name = "listEventos"
        Me.listEventos.ReadOnly = True
        Me.listEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listEventos.Size = New System.Drawing.Size(892, 246)
        Me.listEventos.TabIndex = 0
        '
        'g_ToolTip
        '
        Me.g_ToolTip.BackColor = System.Drawing.Color.SteelBlue
        Me.g_ToolTip.ForeColor = System.Drawing.Color.White
        Me.g_ToolTip.IsBalloon = True
        Me.g_ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.g_ToolTip.ToolTipTitle = "TOOLTIP!"
        '
        'appMain_AppSrv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 382)
        Me.Controls.Add(Me.GruPanico)
        Me.Controls.Add(Me.GruServicios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "appMain_AppSrv"
        Me.Text = "Servicio de aplicaciones - RASTREAR"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GruServicios.ResumeLayout(False)
        Me.GruServicios.PerformLayout()
        Me.GruPanico.ResumeLayout(False)
        CType(Me.listEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStopService As System.Windows.Forms.Button
    Friend WithEvents btnIniciarServicio As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbGEOCProgress As System.Windows.Forms.Label
    Friend WithEvents lbHRDProgress As System.Windows.Forms.Label
    Friend WithEvents ni_appTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruServicios As System.Windows.Forms.GroupBox
    Friend WithEvents GruPanico As System.Windows.Forms.GroupBox
    Friend WithEvents listEventos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAtenderEvento As System.Windows.Forms.Button
    Friend WithEvents g_ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnApagarTodosLosEvento As System.Windows.Forms.Button
    Friend WithEvents btnConfig As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
