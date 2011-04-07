<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iDetector
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
        Me.startbtn = New System.Windows.Forms.Button
        Me.title = New System.Windows.Forms.Label
        Me.info = New System.Windows.Forms.Label
        Me.Prepare = New System.Windows.Forms.Label
        Me.dfuinstructions = New System.Windows.Forms.Label
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.resetinstructions = New System.Windows.Forms.Button
        Me.juststop = New System.Windows.Forms.Button
        Me.results = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'startbtn
        '
        Me.startbtn.ForeColor = System.Drawing.Color.Black
        Me.startbtn.Location = New System.Drawing.Point(21, 110)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.Size = New System.Drawing.Size(149, 37)
        Me.startbtn.TabIndex = 0
        Me.startbtn.Text = "Start DFU Instructions"
        Me.startbtn.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.White
        Me.title.Location = New System.Drawing.Point(214, 11)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(133, 31)
        Me.title.TabIndex = 1
        Me.title.Text = "iDetector"
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.ForeColor = System.Drawing.Color.White
        Me.info.Location = New System.Drawing.Point(102, 48)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(347, 52)
        Me.info.TabIndex = 2
        Me.info.Text = "This utility will detect whether your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "iPhone 3GS or iPod Touch 2G contains a ne" & _
            "w bootrom or old bootrom." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Connect your device via USB and press ""Start DFU In" & _
            "structions"" below."
        Me.info.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Prepare
        '
        Me.Prepare.AutoSize = True
        Me.Prepare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Prepare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prepare.ForeColor = System.Drawing.Color.Red
        Me.Prepare.Location = New System.Drawing.Point(43, 48)
        Me.Prepare.Name = "Prepare"
        Me.Prepare.Size = New System.Drawing.Size(280, 20)
        Me.Prepare.TabIndex = 11
        Me.Prepare.Text = "Prepare to press Power + Home (5)"
        Me.Prepare.Visible = False
        '
        'dfuinstructions
        '
        Me.dfuinstructions.AutoSize = True
        Me.dfuinstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dfuinstructions.ForeColor = System.Drawing.Color.Lime
        Me.dfuinstructions.Location = New System.Drawing.Point(128, 70)
        Me.dfuinstructions.Name = "dfuinstructions"
        Me.dfuinstructions.Size = New System.Drawing.Size(195, 18)
        Me.dfuinstructions.TabIndex = 12
        Me.dfuinstructions.Text = "I'm the DFU instructions."
        Me.dfuinstructions.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(1, 1)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1, 1)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.TabStop = False
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'resetinstructions
        '
        Me.resetinstructions.ForeColor = System.Drawing.Color.Black
        Me.resetinstructions.Location = New System.Drawing.Point(21, 110)
        Me.resetinstructions.Name = "resetinstructions"
        Me.resetinstructions.Size = New System.Drawing.Size(149, 37)
        Me.resetinstructions.TabIndex = 14
        Me.resetinstructions.Text = "Reset DFU Instructions"
        Me.resetinstructions.UseVisualStyleBackColor = True
        Me.resetinstructions.Visible = False
        '
        'juststop
        '
        Me.juststop.BackColor = System.Drawing.Color.Silver
        Me.juststop.ForeColor = System.Drawing.Color.Black
        Me.juststop.Location = New System.Drawing.Point(412, 110)
        Me.juststop.Name = "juststop"
        Me.juststop.Size = New System.Drawing.Size(85, 37)
        Me.juststop.TabIndex = 15
        Me.juststop.Text = "Quit/Cancel"
        Me.juststop.UseVisualStyleBackColor = False
        '
        'results
        '
        Me.results.AutoSize = True
        Me.results.BackColor = System.Drawing.Color.Transparent
        Me.results.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.results.ForeColor = System.Drawing.Color.Cyan
        Me.results.Location = New System.Drawing.Point(13, 68)
        Me.results.Name = "results"
        Me.results.Size = New System.Drawing.Size(109, 16)
        Me.results.TabIndex = 16
        Me.results.Text = "-Status Label--"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(21, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 37)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Start Over"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'iDetector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.sn0wbreeze.My.Resources.Resources.mainbord
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(516, 159)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.results)
        Me.Controls.Add(Me.startbtn)
        Me.Controls.Add(Me.juststop)
        Me.Controls.Add(Me.resetinstructions)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Prepare)
        Me.Controls.Add(Me.dfuinstructions)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "iDetector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iDetector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startbtn As System.Windows.Forms.Button
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents Prepare As System.Windows.Forms.Label
    Friend WithEvents dfuinstructions As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents resetinstructions As System.Windows.Forms.Button
    Friend WithEvents juststop As System.Windows.Forms.Button
    Friend WithEvents results As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
