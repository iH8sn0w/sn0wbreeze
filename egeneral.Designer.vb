<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class egeneral
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(egeneral))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HeaderGeneral = New System.Windows.Forms.Label
        Me.BasebandWarning = New System.Windows.Forms.Label
        Me.logo2 = New System.Windows.Forms.PictureBox
        Me.arrow = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DescriptionGeneral = New System.Windows.Forms.Label
        Me.chkBatPercent = New System.Windows.Forms.CheckBox
        Me.SBMods = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Hacktivate = New System.Windows.Forms.CheckBox
        Me.HacktivationMods = New System.Windows.Forms.GroupBox
        Me.chkAnimate = New System.Windows.Forms.CheckBox
        Me.chkInstallSSH = New System.Windows.Forms.CheckBox
        Me.PartitionsizeBar = New System.Windows.Forms.TrackBar
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextRoot = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.IPSWmods = New System.Windows.Forms.GroupBox
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SBMods.SuspendLayout()
        Me.HacktivationMods.SuspendLayout()
        CType(Me.PartitionsizeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IPSWmods.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 542)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 16
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'HeaderGeneral
        '
        Me.HeaderGeneral.AutoSize = True
        Me.HeaderGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderGeneral.ForeColor = System.Drawing.Color.White
        Me.HeaderGeneral.Location = New System.Drawing.Point(108, 72)
        Me.HeaderGeneral.Name = "HeaderGeneral"
        Me.HeaderGeneral.Size = New System.Drawing.Size(95, 25)
        Me.HeaderGeneral.TabIndex = 100
        Me.HeaderGeneral.Text = "General"
        '
        'BasebandWarning
        '
        Me.BasebandWarning.AutoSize = True
        Me.BasebandWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasebandWarning.ForeColor = System.Drawing.Color.Red
        Me.BasebandWarning.Location = New System.Drawing.Point(179, 425)
        Me.BasebandWarning.Name = "BasebandWarning"
        Me.BasebandWarning.Size = New System.Drawing.Size(435, 32)
        Me.BasebandWarning.TabIndex = 101
        Me.BasebandWarning.Text = "sn0wbreeze will NOT update the baseband, and it NEVER will!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'logo2
        '
        Me.logo2.BackColor = System.Drawing.Color.Black
        Me.logo2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.logo2.Image = CType(resources.GetObject("logo2.Image"), System.Drawing.Image)
        Me.logo2.Location = New System.Drawing.Point(15, 12)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(87, 117)
        Me.logo2.TabIndex = 50
        Me.logo2.TabStop = False
        '
        'arrow
        '
        Me.arrow.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.arrow.Image = CType(resources.GetObject("arrow.Image"), System.Drawing.Image)
        Me.arrow.Location = New System.Drawing.Point(710, 491)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(68, 67)
        Me.arrow.TabIndex = 39
        Me.arrow.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(110, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "600"
        Me.Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(431, 457)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "MB"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'DescriptionGeneral
        '
        Me.DescriptionGeneral.AutoSize = True
        Me.DescriptionGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionGeneral.ForeColor = System.Drawing.Color.White
        Me.DescriptionGeneral.Location = New System.Drawing.Point(73, 148)
        Me.DescriptionGeneral.Name = "DescriptionGeneral"
        Me.DescriptionGeneral.Size = New System.Drawing.Size(655, 20)
        Me.DescriptionGeneral.TabIndex = 46
        Me.DescriptionGeneral.Text = "Select any of the options below that you want to be applied to your custom IPSW"
        '
        'chkBatPercent
        '
        Me.chkBatPercent.AutoSize = True
        Me.chkBatPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBatPercent.ForeColor = System.Drawing.Color.White
        Me.chkBatPercent.Location = New System.Drawing.Point(6, 23)
        Me.chkBatPercent.Name = "chkBatPercent"
        Me.chkBatPercent.Size = New System.Drawing.Size(214, 20)
        Me.chkBatPercent.TabIndex = 107
        Me.chkBatPercent.TabStop = False
        Me.chkBatPercent.Text = "Enable Battery-Percentage"
        Me.chkBatPercent.UseVisualStyleBackColor = True
        '
        'SBMods
        '
        Me.SBMods.BackColor = System.Drawing.Color.Black
        Me.SBMods.Controls.Add(Me.CheckBox1)
        Me.SBMods.Controls.Add(Me.chkBatPercent)
        Me.SBMods.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SBMods.ForeColor = System.Drawing.Color.White
        Me.SBMods.Location = New System.Drawing.Point(134, 184)
        Me.SBMods.Name = "SBMods"
        Me.SBMods.Size = New System.Drawing.Size(247, 105)
        Me.SBMods.TabIndex = 114
        Me.SBMods.TabStop = False
        Me.SBMods.Text = "SpringBoard Modifications"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(6, 49)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(183, 20)
        Me.CheckBox1.TabIndex = 108
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Enable Gestures Menu"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Hacktivate
        '
        Me.Hacktivate.AutoSize = True
        Me.Hacktivate.BackColor = System.Drawing.Color.Transparent
        Me.Hacktivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hacktivate.ForeColor = System.Drawing.Color.White
        Me.Hacktivate.Location = New System.Drawing.Point(6, 23)
        Me.Hacktivate.Name = "Hacktivate"
        Me.Hacktivate.Size = New System.Drawing.Size(254, 20)
        Me.Hacktivate.TabIndex = 0
        Me.Hacktivate.TabStop = False
        Me.Hacktivate.Text = "Activate The iPhone [Hacktivate]"
        Me.Hacktivate.UseVisualStyleBackColor = False
        '
        'HacktivationMods
        '
        Me.HacktivationMods.BackColor = System.Drawing.Color.Black
        Me.HacktivationMods.Controls.Add(Me.chkAnimate)
        Me.HacktivationMods.Controls.Add(Me.chkInstallSSH)
        Me.HacktivationMods.Controls.Add(Me.Hacktivate)
        Me.HacktivationMods.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HacktivationMods.ForeColor = System.Drawing.Color.White
        Me.HacktivationMods.Location = New System.Drawing.Point(388, 184)
        Me.HacktivationMods.Name = "HacktivationMods"
        Me.HacktivationMods.Size = New System.Drawing.Size(273, 105)
        Me.HacktivationMods.TabIndex = 115
        Me.HacktivationMods.TabStop = False
        Me.HacktivationMods.Text = "Hacktivation/Other Modifications"
        '
        'chkAnimate
        '
        Me.chkAnimate.AutoSize = True
        Me.chkAnimate.BackColor = System.Drawing.Color.Transparent
        Me.chkAnimate.Checked = True
        Me.chkAnimate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAnimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkAnimate.ForeColor = System.Drawing.Color.White
        Me.chkAnimate.Location = New System.Drawing.Point(6, 49)
        Me.chkAnimate.Name = "chkAnimate"
        Me.chkAnimate.Size = New System.Drawing.Size(258, 20)
        Me.chkAnimate.TabIndex = 113
        Me.chkAnimate.TabStop = False
        Me.chkAnimate.Text = "Enable Animated Logo Capability"
        Me.chkAnimate.UseVisualStyleBackColor = False
        '
        'chkInstallSSH
        '
        Me.chkInstallSSH.AutoSize = True
        Me.chkInstallSSH.BackColor = System.Drawing.Color.Transparent
        Me.chkInstallSSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkInstallSSH.ForeColor = System.Drawing.Color.White
        Me.chkInstallSSH.Location = New System.Drawing.Point(6, 75)
        Me.chkInstallSSH.Name = "chkInstallSSH"
        Me.chkInstallSSH.Size = New System.Drawing.Size(103, 20)
        Me.chkInstallSSH.TabIndex = 112
        Me.chkInstallSSH.TabStop = False
        Me.chkInstallSSH.Text = "Install SSH"
        Me.chkInstallSSH.UseVisualStyleBackColor = False
        '
        'PartitionsizeBar
        '
        Me.PartitionsizeBar.Location = New System.Drawing.Point(13, 68)
        Me.PartitionsizeBar.Maximum = 7000
        Me.PartitionsizeBar.Minimum = 800
        Me.PartitionsizeBar.Name = "PartitionsizeBar"
        Me.PartitionsizeBar.Size = New System.Drawing.Size(500, 45)
        Me.PartitionsizeBar.TabIndex = 1
        Me.PartitionsizeBar.TabStop = False
        Me.PartitionsizeBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.PartitionsizeBar.Value = 800
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(277, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 18)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "MB"
        '
        'TextRoot
        '
        Me.TextRoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextRoot.Location = New System.Drawing.Point(243, 47)
        Me.TextRoot.MaxLength = 4
        Me.TextRoot.Name = "TextRoot"
        Me.TextRoot.Size = New System.Drawing.Size(31, 20)
        Me.TextRoot.TabIndex = 43
        Me.TextRoot.Text = "800"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(195, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Root Partition Size"
        '
        'IPSWmods
        '
        Me.IPSWmods.BackColor = System.Drawing.Color.Black
        Me.IPSWmods.Controls.Add(Me.Label7)
        Me.IPSWmods.Controls.Add(Me.TextRoot)
        Me.IPSWmods.Controls.Add(Me.Label8)
        Me.IPSWmods.Controls.Add(Me.PartitionsizeBar)
        Me.IPSWmods.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPSWmods.ForeColor = System.Drawing.Color.White
        Me.IPSWmods.Location = New System.Drawing.Point(134, 295)
        Me.IPSWmods.Name = "IPSWmods"
        Me.IPSWmods.Size = New System.Drawing.Size(527, 118)
        Me.IPSWmods.TabIndex = 116
        Me.IPSWmods.TabStop = False
        Me.IPSWmods.Text = "IPSW Options"
        '
        'egeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.IPSWmods)
        Me.Controls.Add(Me.HacktivationMods)
        Me.Controls.Add(Me.SBMods)
        Me.Controls.Add(Me.BasebandWarning)
        Me.Controls.Add(Me.HeaderGeneral)
        Me.Controls.Add(Me.logo2)
        Me.Controls.Add(Me.DescriptionGeneral)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.arrow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "egeneral"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sn0wbreeze"
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SBMods.ResumeLayout(False)
        Me.SBMods.PerformLayout()
        Me.HacktivationMods.ResumeLayout(False)
        Me.HacktivationMods.PerformLayout()
        CType(Me.PartitionsizeBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IPSWmods.ResumeLayout(False)
        Me.IPSWmods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents arrow As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents HeaderGeneral As System.Windows.Forms.Label
    Friend WithEvents BasebandWarning As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DescriptionGeneral As System.Windows.Forms.Label
    Friend WithEvents chkBatPercent As System.Windows.Forms.CheckBox
    Friend WithEvents SBMods As System.Windows.Forms.GroupBox
    Friend WithEvents Hacktivate As System.Windows.Forms.CheckBox
    Friend WithEvents HacktivationMods As System.Windows.Forms.GroupBox
    Friend WithEvents PartitionsizeBar As System.Windows.Forms.TrackBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextRoot As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IPSWmods As System.Windows.Forms.GroupBox
    Friend WithEvents chkInstallSSH As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnimate As System.Windows.Forms.CheckBox
End Class
