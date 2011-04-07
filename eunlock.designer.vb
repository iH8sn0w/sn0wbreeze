<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eunlock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eunlock))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.arrow = New System.Windows.Forms.PictureBox
        Me.logo2 = New System.Windows.Forms.PictureBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(333, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "iPhone 3GS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(105, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(583, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "_________________________________________________________________________________" & _
            "_______________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(108, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 25)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Unlocks"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(322, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(137, 20)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Your device is an :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'arrow
        '
        Me.arrow.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.arrow.Image = Global.sn0wbreeze.My.Resources.Resources.Arrow
        Me.arrow.Location = New System.Drawing.Point(710, 491)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(68, 67)
        Me.arrow.TabIndex = 54
        Me.arrow.TabStop = False
        '
        'logo2
        '
        Me.logo2.BackColor = System.Drawing.Color.Black
        Me.logo2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.logo2.Image = Global.sn0wbreeze.My.Resources.Resources.Flake
        Me.logo2.Location = New System.Drawing.Point(15, 12)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(87, 117)
        Me.logo2.TabIndex = 51
        Me.logo2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(124, 184)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(549, 43)
        Me.CheckBox1.TabIndex = 109
        Me.CheckBox1.Text = "Install 06.15.00 iPad baseband."
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(121, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 15)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "* Internet Connection required!"
        '
        'eunlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.arrow)
        Me.Controls.Add(Me.logo2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "eunlock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sn0wbreeze Lite"
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents arrow As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
