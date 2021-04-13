<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class msg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(msg))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vpnkonek = New System.Windows.Forms.Button()
        Me.box_vpn = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Masque", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(111, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Server VPN"
        '
        'vpnkonek
        '
        Me.vpnkonek.BackColor = System.Drawing.Color.Red
        Me.vpnkonek.FlatAppearance.BorderSize = 0
        Me.vpnkonek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vpnkonek.Font = New System.Drawing.Font("Masque", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vpnkonek.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.vpnkonek.Location = New System.Drawing.Point(131, 134)
        Me.vpnkonek.Name = "vpnkonek"
        Me.vpnkonek.Size = New System.Drawing.Size(97, 35)
        Me.vpnkonek.TabIndex = 18
        Me.vpnkonek.Text = "Connect"
        Me.vpnkonek.UseVisualStyleBackColor = False
        '
        'box_vpn
        '
        Me.box_vpn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.box_vpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_vpn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_vpn.FormattingEnabled = True
        Me.box_vpn.Location = New System.Drawing.Point(91, 71)
        Me.box_vpn.Name = "box_vpn"
        Me.box_vpn.Size = New System.Drawing.Size(182, 28)
        Me.box_vpn.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(320, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'msg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(363, 195)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.box_vpn)
        Me.Controls.Add(Me.vpnkonek)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.LauncherHF.My.MySettings.Default, "vpn", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "msg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = Global.LauncherHF.My.MySettings.Default.vpn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents vpnkonek As Button
    Friend WithEvents box_vpn As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
