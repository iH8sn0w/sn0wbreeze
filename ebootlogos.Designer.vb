<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ebootlogos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ebootlogos))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkUseCustomBootLogo = New System.Windows.Forms.CheckBox
        Me.chkUseCustomRecoveryLogo = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.picRecoveryLogo2 = New System.Windows.Forms.PictureBox
        Me.picBootLogo2 = New System.Windows.Forms.PictureBox
        Me.arrow = New System.Windows.Forms.PictureBox
        Me.picRecoveryLogo = New System.Windows.Forms.PictureBox
        Me.picBootLogo = New System.Windows.Forms.PictureBox
        Me.logo2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.picRecoveryLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBootLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRecoveryLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBootLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(180, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 35)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(173, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 25)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Boot logo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(476, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Recovery Logo"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(516, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 35)
        Me.Button2.TabIndex = 107
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(249, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(289, 31)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Custom Boot Logo(s)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(549, 60)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "* Only PNG files that are  320 x 480 Pixels and below are accepted. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Files are" & _
            " limited to 100kb per Boot Logo!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Must have at least one transparent pixel."
        '
        'chkUseCustomBootLogo
        '
        Me.chkUseCustomBootLogo.AutoSize = True
        Me.chkUseCustomBootLogo.Checked = True
        Me.chkUseCustomBootLogo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUseCustomBootLogo.ForeColor = System.Drawing.Color.White
        Me.chkUseCustomBootLogo.Location = New System.Drawing.Point(161, 84)
        Me.chkUseCustomBootLogo.Name = "chkUseCustomBootLogo"
        Me.chkUseCustomBootLogo.Size = New System.Drawing.Size(135, 17)
        Me.chkUseCustomBootLogo.TabIndex = 115
        Me.chkUseCustomBootLogo.Text = "Use Custom Boot Logo"
        Me.chkUseCustomBootLogo.UseVisualStyleBackColor = True
        '
        'chkUseCustomRecoveryLogo
        '
        Me.chkUseCustomRecoveryLogo.AutoSize = True
        Me.chkUseCustomRecoveryLogo.Checked = True
        Me.chkUseCustomRecoveryLogo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUseCustomRecoveryLogo.ForeColor = System.Drawing.Color.White
        Me.chkUseCustomRecoveryLogo.Location = New System.Drawing.Point(481, 84)
        Me.chkUseCustomRecoveryLogo.Name = "chkUseCustomRecoveryLogo"
        Me.chkUseCustomRecoveryLogo.Size = New System.Drawing.Size(159, 17)
        Me.chkUseCustomRecoveryLogo.TabIndex = 116
        Me.chkUseCustomRecoveryLogo.Text = "Use Custom Recovery Logo"
        Me.chkUseCustomRecoveryLogo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 527)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Label5"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 458)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 100)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requirements:"
        '
        'picRecoveryLogo2
        '
        Me.picRecoveryLogo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picRecoveryLogo2.ErrorImage = Nothing
        Me.picRecoveryLogo2.Image = Global.sn0wbreeze.My.Resources.Resources.RecoveryLogo
        Me.picRecoveryLogo2.Location = New System.Drawing.Point(463, 107)
        Me.picRecoveryLogo2.Name = "picRecoveryLogo2"
        Me.picRecoveryLogo2.Size = New System.Drawing.Size(200, 300)
        Me.picRecoveryLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRecoveryLogo2.TabIndex = 112
        Me.picRecoveryLogo2.TabStop = False
        '
        'picBootLogo2
        '
        Me.picBootLogo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBootLogo2.Image = Global.sn0wbreeze.My.Resources.Resources.Flake
        Me.picBootLogo2.InitialImage = Nothing
        Me.picBootLogo2.Location = New System.Drawing.Point(128, 107)
        Me.picBootLogo2.Name = "picBootLogo2"
        Me.picBootLogo2.Size = New System.Drawing.Size(200, 300)
        Me.picBootLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBootLogo2.TabIndex = 111
        Me.picBootLogo2.TabStop = False
        '
        'arrow
        '
        Me.arrow.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.arrow.Image = Global.sn0wbreeze.My.Resources.Resources.Arrow
        Me.arrow.Location = New System.Drawing.Point(710, 491)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(68, 67)
        Me.arrow.TabIndex = 110
        Me.arrow.TabStop = False
        '
        'picRecoveryLogo
        '
        Me.picRecoveryLogo.InitialImage = Nothing
        Me.picRecoveryLogo.Location = New System.Drawing.Point(463, 107)
        Me.picRecoveryLogo.Name = "picRecoveryLogo"
        Me.picRecoveryLogo.Size = New System.Drawing.Size(200, 300)
        Me.picRecoveryLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRecoveryLogo.TabIndex = 106
        Me.picRecoveryLogo.TabStop = False
        '
        'picBootLogo
        '
        Me.picBootLogo.InitialImage = Nothing
        Me.picBootLogo.Location = New System.Drawing.Point(128, 107)
        Me.picBootLogo.Name = "picBootLogo"
        Me.picBootLogo.Size = New System.Drawing.Size(200, 300)
        Me.picBootLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBootLogo.TabIndex = 101
        Me.picBootLogo.TabStop = False
        '
        'logo2
        '
        Me.logo2.BackColor = System.Drawing.Color.Black
        Me.logo2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.logo2.Image = Global.sn0wbreeze.My.Resources.Resources.Flake
        Me.logo2.Location = New System.Drawing.Point(15, 12)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(87, 117)
        Me.logo2.TabIndex = 78
        Me.logo2.TabStop = False
        '
        'ebootlogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.chkUseCustomRecoveryLogo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkUseCustomBootLogo)
        Me.Controls.Add(Me.picRecoveryLogo2)
        Me.Controls.Add(Me.picBootLogo2)
        Me.Controls.Add(Me.arrow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picRecoveryLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picBootLogo)
        Me.Controls.Add(Me.logo2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ebootlogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picRecoveryLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBootLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRecoveryLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBootLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBootLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picRecoveryLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents arrow As System.Windows.Forms.PictureBox
    Friend WithEvents picBootLogo2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRecoveryLogo2 As System.Windows.Forms.PictureBox
    Friend WithEvents chkUseCustomBootLogo As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseCustomRecoveryLogo As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
