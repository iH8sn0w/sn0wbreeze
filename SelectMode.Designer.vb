<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectMode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectMode))
        Me.Label1 = New System.Windows.Forms.Label
        Me.description = New System.Windows.Forms.Label
        Me.ExpertModetxt = New System.Windows.Forms.Label
        Me.SimpleModetxt = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BBmodetxt = New System.Windows.Forms.Label
        Me.bbmicon = New System.Windows.Forms.PictureBox
        Me.bbcheck = New System.Windows.Forms.PictureBox
        Me.bbmbox = New System.Windows.Forms.PictureBox
        Me.ExpertIcon = New System.Windows.Forms.PictureBox
        Me.SimpleIcon = New System.Windows.Forms.PictureBox
        Me.echeck = New System.Windows.Forms.PictureBox
        Me.scheck = New System.Windows.Forms.PictureBox
        Me.SimpleModebox = New System.Windows.Forms.PictureBox
        Me.logo1 = New System.Windows.Forms.PictureBox
        Me.arrow = New System.Windows.Forms.PictureBox
        Me.ExpertModebox = New System.Windows.Forms.PictureBox
        Me.amsptb = New System.Windows.Forms.Label
        CType(Me.bbmicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bbcheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bbmbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpertIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.echeck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleModebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpertModebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(108, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(639, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Please select a mode, then click the arrow continue."
        '
        'description
        '
        Me.description.AutoSize = True
        Me.description.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.ForeColor = System.Drawing.Color.White
        Me.description.Location = New System.Drawing.Point(12, 402)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(0, 25)
        Me.description.TabIndex = 24
        '
        'ExpertModetxt
        '
        Me.ExpertModetxt.AutoSize = True
        Me.ExpertModetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpertModetxt.ForeColor = System.Drawing.Color.White
        Me.ExpertModetxt.Location = New System.Drawing.Point(297, 313)
        Me.ExpertModetxt.Name = "ExpertModetxt"
        Me.ExpertModetxt.Size = New System.Drawing.Size(190, 33)
        Me.ExpertModetxt.TabIndex = 34
        Me.ExpertModetxt.Text = "Expert Mode"
        '
        'SimpleModetxt
        '
        Me.SimpleModetxt.AutoSize = True
        Me.SimpleModetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleModetxt.ForeColor = System.Drawing.Color.White
        Me.SimpleModetxt.Location = New System.Drawing.Point(291, 247)
        Me.SimpleModetxt.Name = "SimpleModetxt"
        Me.SimpleModetxt.Size = New System.Drawing.Size(196, 33)
        Me.SimpleModetxt.TabIndex = 35
        Me.SimpleModetxt.Text = "Simple Mode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(385, 518)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 31
        '
        'BBmodetxt
        '
        Me.BBmodetxt.AutoSize = True
        Me.BBmodetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBmodetxt.ForeColor = System.Drawing.Color.White
        Me.BBmodetxt.Location = New System.Drawing.Point(192, 181)
        Me.BBmodetxt.Name = "BBmodetxt"
        Me.BBmodetxt.Size = New System.Drawing.Size(423, 33)
        Me.BBmodetxt.TabIndex = 39
        Me.BBmodetxt.Text = "Baseband Preservation Mode"
        '
        'bbmicon
        '
        Me.bbmicon.Image = Global.sn0wbreeze.My.Resources.Resources.basebandmode
        Me.bbmicon.Location = New System.Drawing.Point(112, 174)
        Me.bbmicon.Name = "bbmicon"
        Me.bbmicon.Size = New System.Drawing.Size(50, 46)
        Me.bbmicon.TabIndex = 41
        Me.bbmicon.TabStop = False
        '
        'bbcheck
        '
        Me.bbcheck.Image = CType(resources.GetObject("bbcheck.Image"), System.Drawing.Image)
        Me.bbcheck.Location = New System.Drawing.Point(17, 167)
        Me.bbcheck.Name = "bbcheck"
        Me.bbcheck.Size = New System.Drawing.Size(59, 60)
        Me.bbcheck.TabIndex = 40
        Me.bbcheck.TabStop = False
        Me.bbcheck.Visible = False
        '
        'bbmbox
        '
        Me.bbmbox.BackColor = System.Drawing.Color.Black
        Me.bbmbox.BackgroundImage = CType(resources.GetObject("bbmbox.BackgroundImage"), System.Drawing.Image)
        Me.bbmbox.Image = Global.sn0wbreeze.My.Resources.Resources.Backing
        Me.bbmbox.Location = New System.Drawing.Point(98, 167)
        Me.bbmbox.Name = "bbmbox"
        Me.bbmbox.Size = New System.Drawing.Size(602, 60)
        Me.bbmbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bbmbox.TabIndex = 38
        Me.bbmbox.TabStop = False
        '
        'ExpertIcon
        '
        Me.ExpertIcon.Image = Global.sn0wbreeze.My.Resources.Resources.expertm
        Me.ExpertIcon.Location = New System.Drawing.Point(112, 307)
        Me.ExpertIcon.Name = "ExpertIcon"
        Me.ExpertIcon.Size = New System.Drawing.Size(50, 46)
        Me.ExpertIcon.TabIndex = 37
        Me.ExpertIcon.TabStop = False
        '
        'SimpleIcon
        '
        Me.SimpleIcon.Image = Global.sn0wbreeze.My.Resources.Resources.simplem
        Me.SimpleIcon.Location = New System.Drawing.Point(112, 239)
        Me.SimpleIcon.Name = "SimpleIcon"
        Me.SimpleIcon.Size = New System.Drawing.Size(50, 46)
        Me.SimpleIcon.TabIndex = 36
        Me.SimpleIcon.TabStop = False
        '
        'echeck
        '
        Me.echeck.Image = CType(resources.GetObject("echeck.Image"), System.Drawing.Image)
        Me.echeck.Location = New System.Drawing.Point(17, 299)
        Me.echeck.Name = "echeck"
        Me.echeck.Size = New System.Drawing.Size(59, 60)
        Me.echeck.TabIndex = 30
        Me.echeck.TabStop = False
        Me.echeck.Visible = False
        '
        'scheck
        '
        Me.scheck.Image = CType(resources.GetObject("scheck.Image"), System.Drawing.Image)
        Me.scheck.Location = New System.Drawing.Point(17, 233)
        Me.scheck.Name = "scheck"
        Me.scheck.Size = New System.Drawing.Size(59, 60)
        Me.scheck.TabIndex = 29
        Me.scheck.TabStop = False
        Me.scheck.Visible = False
        '
        'SimpleModebox
        '
        Me.SimpleModebox.BackColor = System.Drawing.Color.Black
        Me.SimpleModebox.BackgroundImage = CType(resources.GetObject("SimpleModebox.BackgroundImage"), System.Drawing.Image)
        Me.SimpleModebox.Image = Global.sn0wbreeze.My.Resources.Resources.Backing
        Me.SimpleModebox.Location = New System.Drawing.Point(98, 233)
        Me.SimpleModebox.Name = "SimpleModebox"
        Me.SimpleModebox.Size = New System.Drawing.Size(602, 60)
        Me.SimpleModebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SimpleModebox.TabIndex = 22
        Me.SimpleModebox.TabStop = False
        '
        'logo1
        '
        Me.logo1.BackColor = System.Drawing.Color.Black
        Me.logo1.Image = CType(resources.GetObject("logo1.Image"), System.Drawing.Image)
        Me.logo1.Location = New System.Drawing.Point(15, 12)
        Me.logo1.Name = "logo1"
        Me.logo1.Size = New System.Drawing.Size(87, 117)
        Me.logo1.TabIndex = 12
        Me.logo1.TabStop = False
        '
        'arrow
        '
        Me.arrow.Enabled = False
        Me.arrow.Image = Global.sn0wbreeze.My.Resources.Resources.Arrowgray
        Me.arrow.Location = New System.Drawing.Point(710, 491)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(64, 63)
        Me.arrow.TabIndex = 32
        Me.arrow.TabStop = False
        '
        'ExpertModebox
        '
        Me.ExpertModebox.BackgroundImage = CType(resources.GetObject("ExpertModebox.BackgroundImage"), System.Drawing.Image)
        Me.ExpertModebox.Image = Global.sn0wbreeze.My.Resources.Resources.Backing
        Me.ExpertModebox.Location = New System.Drawing.Point(98, 299)
        Me.ExpertModebox.Name = "ExpertModebox"
        Me.ExpertModebox.Size = New System.Drawing.Size(602, 62)
        Me.ExpertModebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExpertModebox.TabIndex = 23
        Me.ExpertModebox.TabStop = False
        '
        'amsptb
        '
        Me.amsptb.AutoSize = True
        Me.amsptb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amsptb.ForeColor = System.Drawing.Color.Lime
        Me.amsptb.Location = New System.Drawing.Point(254, 144)
        Me.amsptb.Name = "amsptb"
        Me.amsptb.Size = New System.Drawing.Size(275, 20)
        Me.amsptb.TabIndex = 42
        Me.amsptb.Text = "All modes still preserve the baseband!"
        '
        'SelectMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.amsptb)
        Me.Controls.Add(Me.bbmicon)
        Me.Controls.Add(Me.bbcheck)
        Me.Controls.Add(Me.BBmodetxt)
        Me.Controls.Add(Me.bbmbox)
        Me.Controls.Add(Me.ExpertIcon)
        Me.Controls.Add(Me.SimpleIcon)
        Me.Controls.Add(Me.SimpleModetxt)
        Me.Controls.Add(Me.ExpertModetxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.echeck)
        Me.Controls.Add(Me.scheck)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.SimpleModebox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo1)
        Me.Controls.Add(Me.arrow)
        Me.Controls.Add(Me.ExpertModebox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SelectMode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "sn0wbreeze "
        CType(Me.bbmicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bbcheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bbmbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpertIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.echeck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleModebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpertModebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleModebox As System.Windows.Forms.PictureBox
    Friend WithEvents ExpertModebox As System.Windows.Forms.PictureBox
    Friend WithEvents description As System.Windows.Forms.Label
    Friend WithEvents echeck As System.Windows.Forms.PictureBox
    Friend WithEvents scheck As System.Windows.Forms.PictureBox
    Friend WithEvents arrow As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleModetxt As System.Windows.Forms.Label
    Friend WithEvents ExpertModetxt As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SimpleIcon As System.Windows.Forms.PictureBox
    Friend WithEvents ExpertIcon As System.Windows.Forms.PictureBox
    Friend WithEvents bbmbox As System.Windows.Forms.PictureBox
    Friend WithEvents BBmodetxt As System.Windows.Forms.Label
    Friend WithEvents bbcheck As System.Windows.Forms.PictureBox
    Friend WithEvents bbmicon As System.Windows.Forms.PictureBox
    Friend WithEvents amsptb As System.Windows.Forms.Label
End Class
