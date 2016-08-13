<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RASTREO_dataconsole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RASTREO_dataconsole))
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkFILTER = New System.Windows.Forms.CheckBox()
        Me.txtFILTER = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtConsole
        '
        Me.txtConsole.BackColor = System.Drawing.Color.Black
        Me.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConsole.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtConsole.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsole.ForeColor = System.Drawing.Color.White
        Me.txtConsole.Location = New System.Drawing.Point(0, 0)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConsole.Size = New System.Drawing.Size(930, 423)
        Me.txtConsole.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(854, 461)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(64, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkFILTER
        '
        Me.chkFILTER.AutoSize = True
        Me.chkFILTER.Checked = True
        Me.chkFILTER.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFILTER.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFILTER.Location = New System.Drawing.Point(688, 460)
        Me.chkFILTER.Name = "chkFILTER"
        Me.chkFILTER.Size = New System.Drawing.Size(92, 17)
        Me.chkFILTER.TabIndex = 2
        Me.chkFILTER.Text = "Filtrar texto"
        Me.chkFILTER.UseVisualStyleBackColor = True
        '
        'txtFILTER
        '
        Me.txtFILTER.Location = New System.Drawing.Point(0, 458)
        Me.txtFILTER.Name = "txtFILTER"
        Me.txtFILTER.Size = New System.Drawing.Size(682, 20)
        Me.txtFILTER.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Limpiar pantalla"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RASTREO_dataconsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 490)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFILTER)
        Me.Controls.Add(Me.chkFILTER)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtConsole)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RASTREO_dataconsole"
        Me.Text = "RASTREO_dataconsole"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtConsole As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chkFILTER As System.Windows.Forms.CheckBox
    Friend WithEvents txtFILTER As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
