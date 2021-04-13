<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msg_update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(msg_update))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vpnid = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.lblProgPerc = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(77, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Update Launcher Tersedia"
        '
        'vpnid
        '
        Me.vpnid.BackColor = System.Drawing.Color.Red
        Me.vpnid.FlatAppearance.BorderSize = 0
        Me.vpnid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vpnid.Font = New System.Drawing.Font("Masque", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vpnid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.vpnid.Location = New System.Drawing.Point(128, 126)
        Me.vpnid.Name = "vpnid"
        Me.vpnid.Size = New System.Drawing.Size(97, 35)
        Me.vpnid.TabIndex = 19
        Me.vpnid.Text = "download"
        Me.vpnid.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(311, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'pbStatus
        '
        Me.pbStatus.Location = New System.Drawing.Point(76, 78)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(199, 23)
        Me.pbStatus.TabIndex = 22
        '
        'lblProgPerc
        '
        Me.lblProgPerc.AutoSize = True
        Me.lblProgPerc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblProgPerc.Location = New System.Drawing.Point(166, 108)
        Me.lblProgPerc.Name = "lblProgPerc"
        Me.lblProgPerc.Size = New System.Drawing.Size(21, 13)
        Me.lblProgPerc.TabIndex = 23
        Me.lblProgPerc.Text = "0%"
        '
        'msg_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 185)
        Me.Controls.Add(Me.lblProgPerc)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.vpnid)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "msg_update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "msg_update"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents vpnid As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbStatus As ProgressBar
    Friend WithEvents lblProgPerc As Label
End Class
