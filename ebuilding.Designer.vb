<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ebuilding
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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.lblStatus = New System.Windows.Forms.Label
        Me.ihelper = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.return2spinner = New System.Windows.Forms.Button
        Me.go2pacman = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.logo2 = New System.Windows.Forms.PictureBox
        Me.PictureAnim = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureAnim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(140, 498)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(512, 15)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 35
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Green
        Me.lblStatus.Location = New System.Drawing.Point(389, 461)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 18)
        Me.lblStatus.TabIndex = 36
        '
        'ihelper
        '
        Me.ihelper.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ihelper.AutoSize = True
        Me.ihelper.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ihelper.ForeColor = System.Drawing.Color.White
        Me.ihelper.Location = New System.Drawing.Point(677, 526)
        Me.ihelper.Name = "ihelper"
        Me.ihelper.Size = New System.Drawing.Size(88, 29)
        Me.ihelper.TabIndex = 38
        Me.ihelper.Text = "ihelper"
        Me.ihelper.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ihelper.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(356, 532)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(1, 1)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(1, 1)
        Me.RichTextBox1.TabIndex = 80
        Me.RichTextBox1.TabStop = False
        Me.RichTextBox1.Text = ""
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(140, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(512, 453)
        Me.WebBrowser1.TabIndex = 84
        Me.WebBrowser1.Url = New System.Uri("file:///C:\meow.html", System.UriKind.Absolute)
        Me.WebBrowser1.Visible = False
        '
        'return2spinner
        '
        Me.return2spinner.BackColor = System.Drawing.Color.Silver
        Me.return2spinner.ForeColor = System.Drawing.Color.Black
        Me.return2spinner.Location = New System.Drawing.Point(549, 12)
        Me.return2spinner.Name = "return2spinner"
        Me.return2spinner.Size = New System.Drawing.Size(103, 23)
        Me.return2spinner.TabIndex = 85
        Me.return2spinner.Text = "Return to Spinner"
        Me.return2spinner.UseVisualStyleBackColor = False
        Me.return2spinner.Visible = False
        '
        'go2pacman
        '
        Me.go2pacman.BackColor = System.Drawing.Color.Silver
        Me.go2pacman.ForeColor = System.Drawing.Color.Black
        Me.go2pacman.Location = New System.Drawing.Point(549, 12)
        Me.go2pacman.Name = "go2pacman"
        Me.go2pacman.Size = New System.Drawing.Size(103, 23)
        Me.go2pacman.TabIndex = 86
        Me.go2pacman.Text = "Go to PacMan"
        Me.go2pacman.UseVisualStyleBackColor = False
        Me.go2pacman.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.sn0wbreeze.My.Resources.Resources.backg1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(111, 177)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 178)
        Me.Panel1.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(263, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "PacMan Requires: Adobe Flash for Internet Explorer"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(334, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(198, 33)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "No Thanks. I'll stick to the spinner."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(49, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 33)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "PacMan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 18)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "While waiting for the IPSW to finish being built, would you like to play PacMan?"
        '
        'logo2
        '
        Me.logo2.BackColor = System.Drawing.Color.Black
        Me.logo2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.logo2.Image = Global.sn0wbreeze.My.Resources.Resources.Flake
        Me.logo2.Location = New System.Drawing.Point(352, 39)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(87, 117)
        Me.logo2.TabIndex = 79
        Me.logo2.TabStop = False
        '
        'PictureAnim
        '
        Me.PictureAnim.Image = Global.sn0wbreeze.My.Resources.Resources.spinny
        Me.PictureAnim.InitialImage = Nothing
        Me.PictureAnim.Location = New System.Drawing.Point(231, 162)
        Me.PictureAnim.Name = "PictureAnim"
        Me.PictureAnim.Size = New System.Drawing.Size(357, 265)
        Me.PictureAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureAnim.TabIndex = 41
        Me.PictureAnim.TabStop = False
        Me.PictureAnim.Visible = False
        '
        'ebuilding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.go2pacman)
        Me.Controls.Add(Me.return2spinner)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.logo2)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PictureAnim)
        Me.Controls.Add(Me.ihelper)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ebuilding"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ebuilding"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureAnim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents PictureAnim As System.Windows.Forms.PictureBox
    Friend WithEvents ihelper As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents return2spinner As System.Windows.Forms.Button
    Friend WithEvents go2pacman As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
