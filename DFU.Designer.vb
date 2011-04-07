<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DFU
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.quote = New System.Windows.Forms.Label
        Me.console = New System.Windows.Forms.RichTextBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ProgressBarL = New System.ComponentModel.BackgroundWorker
        Me.atv2 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        CType(Me.atv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(234, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DFU Pwner [greenpois0n]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(185, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(420, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Please connect your device, and click start when you are ready"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(706, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(264, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Please turn off your Device"
        '
        'quote
        '
        Me.quote.AutoSize = True
        Me.quote.Location = New System.Drawing.Point(703, 65)
        Me.quote.Name = "quote"
        Me.quote.Size = New System.Drawing.Size(12, 13)
        Me.quote.TabIndex = 40
        Me.quote.Text = """"
        Me.quote.Visible = False
        '
        'console
        '
        Me.console.BackColor = System.Drawing.Color.Black
        Me.console.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.console.Location = New System.Drawing.Point(647, 12)
        Me.console.Name = "console"
        Me.console.Size = New System.Drawing.Size(1, 1)
        Me.console.TabIndex = 41
        Me.console.Text = ""
        Me.console.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(353, 157)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 43
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 527)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(769, 30)
        Me.ProgressBar1.TabIndex = 45
        Me.ProgressBar1.Visible = False
        '
        'ProgressBarL
        '
        '
        'atv2
        '
        Me.atv2.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation
        Me.atv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.atv2.Image = Global.sn0wbreeze.My.Resources.Resources.connectatv2
        Me.atv2.Location = New System.Drawing.Point(251, 180)
        Me.atv2.Name = "atv2"
        Me.atv2.Size = New System.Drawing.Size(298, 326)
        Me.atv2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.atv2.TabIndex = 46
        Me.atv2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.sn0wbreeze.My.Resources.Resources.start_button_black
        Me.PictureBox4.Location = New System.Drawing.Point(305, 522)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(180, 35)
        Me.PictureBox4.TabIndex = 38
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = Global.sn0wbreeze.My.Resources.Resources.turn_off
        Me.PictureBox1.Location = New System.Drawing.Point(219, 136)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(389, 380)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(582, 136)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(214, 380)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 136)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(226, 380)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox5.Location = New System.Drawing.Point(219, 136)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(386, 380)
        Me.PictureBox5.TabIndex = 47
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox6.Image = Global.sn0wbreeze.My.Resources.Resources.remote_both
        Me.PictureBox6.Location = New System.Drawing.Point(305, 180)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(194, 322)
        Me.PictureBox6.TabIndex = 48
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'DFU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.atv2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.console)
        Me.Controls.Add(Me.quote)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DFU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DFU"
        CType(Me.atv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents quote As System.Windows.Forms.Label
    Friend WithEvents console As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Public WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBarL As System.ComponentModel.BackgroundWorker
    Friend WithEvents atv2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
End Class
