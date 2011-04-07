<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Expert))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.buildcheck = New System.Windows.Forms.PictureBox
        Me.logocheck = New System.Windows.Forms.PictureBox
        Me.logo2 = New System.Windows.Forms.PictureBox
        Me.arrowgray = New System.Windows.Forms.PictureBox
        Me.bootlogos = New System.Windows.Forms.PictureBox
        Me.build = New System.Windows.Forms.PictureBox
        Me.uncheck = New System.Windows.Forms.PictureBox
        Me.cpcheck = New System.Windows.Forms.PictureBox
        Me.generalcheck = New System.Windows.Forms.PictureBox
        Me.arrow = New System.Windows.Forms.PictureBox
        Me.unlocks = New System.Windows.Forms.PictureBox
        Me.cpackage = New System.Windows.Forms.PictureBox
        Me.General = New System.Windows.Forms.PictureBox
        CType(Me.buildcheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logocheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrowgray, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bootlogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.build, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uncheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpcheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.generalcheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unlocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpackage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.General, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(649, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Select any of the following options, then click the arrow to continue"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(108, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 29)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "iPhoneModel"
        '
        'buildcheck
        '
        Me.buildcheck.Image = CType(resources.GetObject("buildcheck.Image"), System.Drawing.Image)
        Me.buildcheck.Location = New System.Drawing.Point(560, 387)
        Me.buildcheck.Name = "buildcheck"
        Me.buildcheck.Size = New System.Drawing.Size(59, 60)
        Me.buildcheck.TabIndex = 48
        Me.buildcheck.TabStop = False
        '
        'logocheck
        '
        Me.logocheck.Image = CType(resources.GetObject("logocheck.Image"), System.Drawing.Image)
        Me.logocheck.Location = New System.Drawing.Point(8, 305)
        Me.logocheck.Name = "logocheck"
        Me.logocheck.Size = New System.Drawing.Size(59, 60)
        Me.logocheck.TabIndex = 47
        Me.logocheck.TabStop = False
        '
        'logo2
        '
        Me.logo2.BackColor = System.Drawing.Color.Black
        Me.logo2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.logo2.Image = Global.sn0wbreeze.My.Resources.Resources.Flake
        Me.logo2.Location = New System.Drawing.Point(15, 12)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(87, 117)
        Me.logo2.TabIndex = 46
        Me.logo2.TabStop = False
        '
        'arrowgray
        '
        Me.arrowgray.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.arrowgray.Image = Global.sn0wbreeze.My.Resources.Resources.Arrowgray
        Me.arrowgray.Location = New System.Drawing.Point(710, 491)
        Me.arrowgray.Name = "arrowgray"
        Me.arrowgray.Size = New System.Drawing.Size(68, 67)
        Me.arrowgray.TabIndex = 45
        Me.arrowgray.TabStop = False
        '
        'bootlogos
        '
        Me.bootlogos.Image = Global.sn0wbreeze.My.Resources.Resources.BootLogosNorm1
        Me.bootlogos.InitialImage = Global.sn0wbreeze.My.Resources.Resources.GeneralNorm
        Me.bootlogos.Location = New System.Drawing.Point(71, 289)
        Me.bootlogos.Name = "bootlogos"
        Me.bootlogos.Size = New System.Drawing.Size(320, 76)
        Me.bootlogos.TabIndex = 44
        Me.bootlogos.TabStop = False
        '
        'build
        '
        Me.build.Image = Global.sn0wbreeze.My.Resources.Resources.BuildNorm
        Me.build.InitialImage = Global.sn0wbreeze.My.Resources.Resources.GeneralNorm
        Me.build.Location = New System.Drawing.Point(234, 371)
        Me.build.Name = "build"
        Me.build.Size = New System.Drawing.Size(320, 76)
        Me.build.TabIndex = 43
        Me.build.TabStop = False
        '
        'uncheck
        '
        Me.uncheck.Image = CType(resources.GetObject("uncheck.Image"), System.Drawing.Image)
        Me.uncheck.Location = New System.Drawing.Point(723, 223)
        Me.uncheck.Name = "uncheck"
        Me.uncheck.Size = New System.Drawing.Size(59, 60)
        Me.uncheck.TabIndex = 42
        Me.uncheck.TabStop = False
        '
        'cpcheck
        '
        Me.cpcheck.Image = CType(resources.GetObject("cpcheck.Image"), System.Drawing.Image)
        Me.cpcheck.Location = New System.Drawing.Point(723, 305)
        Me.cpcheck.Name = "cpcheck"
        Me.cpcheck.Size = New System.Drawing.Size(59, 60)
        Me.cpcheck.TabIndex = 40
        Me.cpcheck.TabStop = False
        '
        'generalcheck
        '
        Me.generalcheck.Image = CType(resources.GetObject("generalcheck.Image"), System.Drawing.Image)
        Me.generalcheck.Location = New System.Drawing.Point(6, 223)
        Me.generalcheck.Name = "generalcheck"
        Me.generalcheck.Size = New System.Drawing.Size(59, 60)
        Me.generalcheck.TabIndex = 39
        Me.generalcheck.TabStop = False
        '
        'arrow
        '
        Me.arrow.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.arrow.Image = Global.sn0wbreeze.My.Resources.Resources.Arrow
        Me.arrow.Location = New System.Drawing.Point(710, 491)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(68, 67)
        Me.arrow.TabIndex = 38
        Me.arrow.TabStop = False
        '
        'unlocks
        '
        Me.unlocks.Enabled = False
        Me.unlocks.Image = Global.sn0wbreeze.My.Resources.Resources.UNLOCKNorm1
        Me.unlocks.InitialImage = Global.sn0wbreeze.My.Resources.Resources.GeneralNorm
        Me.unlocks.Location = New System.Drawing.Point(397, 207)
        Me.unlocks.Name = "unlocks"
        Me.unlocks.Size = New System.Drawing.Size(320, 76)
        Me.unlocks.TabIndex = 17
        Me.unlocks.TabStop = False
        '
        'cpackage
        '
        Me.cpackage.Image = Global.sn0wbreeze.My.Resources.Resources.CustomPKGNorm1
        Me.cpackage.InitialImage = Global.sn0wbreeze.My.Resources.Resources.GeneralNorm
        Me.cpackage.Location = New System.Drawing.Point(397, 289)
        Me.cpackage.Name = "cpackage"
        Me.cpackage.Size = New System.Drawing.Size(320, 76)
        Me.cpackage.TabIndex = 16
        Me.cpackage.TabStop = False
        '
        'General
        '
        Me.General.Image = Global.sn0wbreeze.My.Resources.Resources.GeneralNorm1
        Me.General.InitialImage = Global.sn0wbreeze.My.Resources.Resources.GeneralNorm
        Me.General.Location = New System.Drawing.Point(71, 207)
        Me.General.Name = "General"
        Me.General.Size = New System.Drawing.Size(320, 76)
        Me.General.TabIndex = 14
        Me.General.TabStop = False
        '
        'Expert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.buildcheck)
        Me.Controls.Add(Me.logocheck)
        Me.Controls.Add(Me.logo2)
        Me.Controls.Add(Me.arrowgray)
        Me.Controls.Add(Me.bootlogos)
        Me.Controls.Add(Me.build)
        Me.Controls.Add(Me.uncheck)
        Me.Controls.Add(Me.cpcheck)
        Me.Controls.Add(Me.generalcheck)
        Me.Controls.Add(Me.arrow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.unlocks)
        Me.Controls.Add(Me.cpackage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.General)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Expert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "sn0wbreeze"
        CType(Me.buildcheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logocheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrowgray, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bootlogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.build, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uncheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpcheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.generalcheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unlocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpackage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.General, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents General As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cpackage As System.Windows.Forms.PictureBox
    Friend WithEvents unlocks As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents arrow As System.Windows.Forms.PictureBox
    Friend WithEvents generalcheck As System.Windows.Forms.PictureBox
    Friend WithEvents cpcheck As System.Windows.Forms.PictureBox
    Friend WithEvents uncheck As System.Windows.Forms.PictureBox
    Friend WithEvents build As System.Windows.Forms.PictureBox
    Friend WithEvents bootlogos As System.Windows.Forms.PictureBox
    Friend WithEvents arrowgray As System.Windows.Forms.PictureBox
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents logocheck As System.Windows.Forms.PictureBox
    Friend WithEvents buildcheck As System.Windows.Forms.PictureBox
End Class
