<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ecustomapps
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://apt.saurik.com/dists/tangelo/main/binary-iphoneos-arm")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://apt.bigboss.us.com/repofiles/cydia/dists/stable/main/binary-iphoneos-arm")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://apt.modmyi.com/dists/stable/main/binary-iphoneos-arm")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://cydia.zodttd.com/repo/cydia")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://repo666.ultrasn0w.com")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://cydia.ih8sn0w.com")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://repo.smxy.org/cydia/apt/dists/stable/main/binary-iphoneos-arm")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://iphone.hackndev.org/apt/dists/hnd/main/binary-iphoneos-arm")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://apt.pwncenter.com")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://cy.sosiphone.com")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("http://ispaziorepository.com")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ecustomapps))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabSelectPackages = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.lvSelectPackages = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.tabDownloadPackages = New System.Windows.Forms.TabPage
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtDownloadSearch = New System.Windows.Forms.TextBox
        Me.btnSelectSource = New System.Windows.Forms.Button
        Me.lvDownload = New System.Windows.Forms.ListView
        Me.ColumnName = New System.Windows.Forms.ColumnHeader
        Me.ColumnDescription = New System.Windows.Forms.ColumnHeader
        Me.ColumnVersion = New System.Windows.Forms.ColumnHeader
        Me.ColumnSize = New System.Windows.Forms.ColumnHeader
        Me.ColumnStatus = New System.Windows.Forms.ColumnHeader
        Me.ColumnFilename = New System.Windows.Forms.ColumnHeader
        Me.ColumnDepends = New System.Windows.Forms.ColumnHeader
        Me.ColumnPackage = New System.Windows.Forms.ColumnHeader
        Me.ComboSources = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.tabManageSources = New System.Windows.Forms.TabPage
        Me.btnDeleteRepo = New System.Windows.Forms.Button
        Me.txtSource = New System.Windows.Forms.TextBox
        Me.btnAddSource = New System.Windows.Forms.Button
        Me.lvManageSources = New System.Windows.Forms.ListView
        Me.ColumnSource = New System.Windows.Forms.ColumnHeader
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.logo2 = New System.Windows.Forms.PictureBox
        Me.arrow = New System.Windows.Forms.PictureBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabSelectPackages.SuspendLayout()
        Me.tabDownloadPackages.SuspendLayout()
        Me.tabManageSources.SuspendLayout()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabSelectPackages)
        Me.TabControl1.Controls.Add(Me.tabDownloadPackages)
        Me.TabControl1.Controls.Add(Me.tabManageSources)
        Me.TabControl1.Location = New System.Drawing.Point(15, 135)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(763, 350)
        Me.TabControl1.TabIndex = 81
        '
        'TabSelectPackages
        '
        Me.TabSelectPackages.BackColor = System.Drawing.Color.White
        Me.TabSelectPackages.Controls.Add(Me.Label3)
        Me.TabSelectPackages.Controls.Add(Me.Button3)
        Me.TabSelectPackages.Controls.Add(Me.lvSelectPackages)
        Me.TabSelectPackages.ForeColor = System.Drawing.Color.White
        Me.TabSelectPackages.Location = New System.Drawing.Point(4, 25)
        Me.TabSelectPackages.Name = "TabSelectPackages"
        Me.TabSelectPackages.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSelectPackages.Size = New System.Drawing.Size(755, 321)
        Me.TabSelectPackages.TabIndex = 0
        Me.TabSelectPackages.Text = "Select Packages"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(476, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Browse for a custom debian (.deb) file"
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(666, 293)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 23)
        Me.Button3.TabIndex = 80
        Me.Button3.Text = "&Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lvSelectPackages
        '
        Me.lvSelectPackages.AutoArrange = False
        Me.lvSelectPackages.CheckBoxes = True
        Me.lvSelectPackages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvSelectPackages.ForeColor = System.Drawing.Color.Black
        Me.lvSelectPackages.FullRowSelect = True
        Me.lvSelectPackages.GridLines = True
        Me.lvSelectPackages.Location = New System.Drawing.Point(6, 6)
        Me.lvSelectPackages.MultiSelect = False
        Me.lvSelectPackages.Name = "lvSelectPackages"
        Me.lvSelectPackages.Size = New System.Drawing.Size(743, 281)
        Me.lvSelectPackages.TabIndex = 79
        Me.lvSelectPackages.UseCompatibleStateImageBehavior = False
        Me.lvSelectPackages.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 136
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 437
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Version"
        Me.ColumnHeader3.Width = 84
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Size"
        Me.ColumnHeader4.Width = 64
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Filename"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Depends"
        Me.ColumnHeader6.Width = 0
        '
        'tabDownloadPackages
        '
        Me.tabDownloadPackages.BackColor = System.Drawing.Color.White
        Me.tabDownloadPackages.Controls.Add(Me.Button2)
        Me.tabDownloadPackages.Controls.Add(Me.txtDownloadSearch)
        Me.tabDownloadPackages.Controls.Add(Me.btnSelectSource)
        Me.tabDownloadPackages.Controls.Add(Me.lvDownload)
        Me.tabDownloadPackages.Controls.Add(Me.ComboSources)
        Me.tabDownloadPackages.Controls.Add(Me.Button1)
        Me.tabDownloadPackages.ForeColor = System.Drawing.Color.White
        Me.tabDownloadPackages.Location = New System.Drawing.Point(4, 25)
        Me.tabDownloadPackages.Name = "tabDownloadPackages"
        Me.tabDownloadPackages.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDownloadPackages.Size = New System.Drawing.Size(755, 321)
        Me.tabDownloadPackages.TabIndex = 1
        Me.tabDownloadPackages.Text = "Download Packages"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(230, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "&Search/Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDownloadSearch
        '
        Me.txtDownloadSearch.Location = New System.Drawing.Point(6, 294)
        Me.txtDownloadSearch.Name = "txtDownloadSearch"
        Me.txtDownloadSearch.Size = New System.Drawing.Size(217, 20)
        Me.txtDownloadSearch.TabIndex = 81
        '
        'btnSelectSource
        '
        Me.btnSelectSource.ForeColor = System.Drawing.Color.Black
        Me.btnSelectSource.Location = New System.Drawing.Point(666, 292)
        Me.btnSelectSource.Name = "btnSelectSource"
        Me.btnSelectSource.Size = New System.Drawing.Size(83, 23)
        Me.btnSelectSource.TabIndex = 80
        Me.btnSelectSource.Text = "&Download"
        Me.btnSelectSource.UseVisualStyleBackColor = True
        '
        'lvDownload
        '
        Me.lvDownload.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnName, Me.ColumnDescription, Me.ColumnVersion, Me.ColumnSize, Me.ColumnStatus, Me.ColumnFilename, Me.ColumnDepends, Me.ColumnPackage})
        Me.lvDownload.ForeColor = System.Drawing.Color.Black
        Me.lvDownload.FullRowSelect = True
        Me.lvDownload.GridLines = True
        Me.lvDownload.HideSelection = False
        Me.lvDownload.Location = New System.Drawing.Point(6, 35)
        Me.lvDownload.MultiSelect = False
        Me.lvDownload.Name = "lvDownload"
        Me.lvDownload.Size = New System.Drawing.Size(743, 251)
        Me.lvDownload.TabIndex = 78
        Me.lvDownload.UseCompatibleStateImageBehavior = False
        Me.lvDownload.View = System.Windows.Forms.View.Details
        '
        'ColumnName
        '
        Me.ColumnName.Text = "Name"
        Me.ColumnName.Width = 136
        '
        'ColumnDescription
        '
        Me.ColumnDescription.Text = "Description"
        Me.ColumnDescription.Width = 373
        '
        'ColumnVersion
        '
        Me.ColumnVersion.Text = "Version"
        Me.ColumnVersion.Width = 80
        '
        'ColumnSize
        '
        Me.ColumnSize.Text = "Size"
        Me.ColumnSize.Width = 66
        '
        'ColumnStatus
        '
        Me.ColumnStatus.Text = "Status"
        Me.ColumnStatus.Width = 66
        '
        'ColumnFilename
        '
        Me.ColumnFilename.Text = "Filename"
        Me.ColumnFilename.Width = 0
        '
        'ColumnDepends
        '
        Me.ColumnDepends.Text = "Depends"
        Me.ColumnDepends.Width = 0
        '
        'ColumnPackage
        '
        Me.ColumnPackage.Text = "Package"
        Me.ColumnPackage.Width = 0
        '
        'ComboSources
        '
        Me.ComboSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSources.FormattingEnabled = True
        Me.ComboSources.Location = New System.Drawing.Point(6, 6)
        Me.ComboSources.Name = "ComboSources"
        Me.ComboSources.Size = New System.Drawing.Size(683, 21)
        Me.ComboSources.TabIndex = 79
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(695, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tabManageSources
        '
        Me.tabManageSources.BackColor = System.Drawing.Color.White
        Me.tabManageSources.Controls.Add(Me.btnDeleteRepo)
        Me.tabManageSources.Controls.Add(Me.txtSource)
        Me.tabManageSources.Controls.Add(Me.btnAddSource)
        Me.tabManageSources.Controls.Add(Me.lvManageSources)
        Me.tabManageSources.Location = New System.Drawing.Point(4, 25)
        Me.tabManageSources.Name = "tabManageSources"
        Me.tabManageSources.Padding = New System.Windows.Forms.Padding(3)
        Me.tabManageSources.Size = New System.Drawing.Size(755, 321)
        Me.tabManageSources.TabIndex = 2
        Me.tabManageSources.Text = "Manage Sources"
        '
        'btnDeleteRepo
        '
        Me.btnDeleteRepo.Enabled = False
        Me.btnDeleteRepo.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteRepo.Location = New System.Drawing.Point(666, 292)
        Me.btnDeleteRepo.Name = "btnDeleteRepo"
        Me.btnDeleteRepo.Size = New System.Drawing.Size(83, 23)
        Me.btnDeleteRepo.TabIndex = 82
        Me.btnDeleteRepo.Text = "&Delete"
        Me.btnDeleteRepo.UseVisualStyleBackColor = True
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(7, 8)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(682, 20)
        Me.txtSource.TabIndex = 81
        Me.txtSource.Text = "http://"
        '
        'btnAddSource
        '
        Me.btnAddSource.ForeColor = System.Drawing.Color.Black
        Me.btnAddSource.Location = New System.Drawing.Point(695, 6)
        Me.btnAddSource.Name = "btnAddSource"
        Me.btnAddSource.Size = New System.Drawing.Size(54, 23)
        Me.btnAddSource.TabIndex = 80
        Me.btnAddSource.Text = "&Add"
        Me.btnAddSource.UseVisualStyleBackColor = True
        '
        'lvManageSources
        '
        Me.lvManageSources.AutoArrange = False
        Me.lvManageSources.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnSource})
        Me.lvManageSources.FullRowSelect = True
        Me.lvManageSources.GridLines = True
        Me.lvManageSources.HideSelection = False
        Me.lvManageSources.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11})
        Me.lvManageSources.Location = New System.Drawing.Point(6, 35)
        Me.lvManageSources.MultiSelect = False
        Me.lvManageSources.Name = "lvManageSources"
        Me.lvManageSources.Size = New System.Drawing.Size(743, 251)
        Me.lvManageSources.TabIndex = 79
        Me.lvManageSources.UseCompatibleStateImageBehavior = False
        Me.lvManageSources.View = System.Windows.Forms.View.Details
        '
        'ColumnSource
        '
        Me.ColumnSource.Text = "Source URL"
        Me.ColumnSource.Width = 720
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(105, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(151, 25)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Custom Apps"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 538)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(672, 20)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Once you have downloaded and selected any of the wanted applications, click next " & _
            "to continue"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(105, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(617, 25)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Download apps from you favorite repos, to include in your ipsw."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = " ""Debian files (*.deb)|*.deb"""
        Me.OpenFileDialog1.Multiselect = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.DetectUrls = False
        Me.RichTextBox1.Location = New System.Drawing.Point(1, 1)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1, 1)
        Me.RichTextBox1.TabIndex = 104
        Me.RichTextBox1.Text = ""
        '
        'logo2
        '
        Me.logo2.BackColor = System.Drawing.Color.Black
        Me.logo2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.logo2.Image = CType(resources.GetObject("logo2.Image"), System.Drawing.Image)
        Me.logo2.Location = New System.Drawing.Point(15, 12)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(87, 117)
        Me.logo2.TabIndex = 74
        Me.logo2.TabStop = False
        '
        'arrow
        '
        Me.arrow.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.arrow.Image = Global.sn0wbreeze.My.Resources.Resources.Arrow
        Me.arrow.Location = New System.Drawing.Point(710, 491)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(68, 67)
        Me.arrow.TabIndex = 76
        Me.arrow.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(275, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(493, 66)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "This needs to be redone. Anyone? =)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[The coding behind it]"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Visible = False
        '
        'ecustomapps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.logo2)
        Me.Controls.Add(Me.arrow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ecustomapps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sn0wbreeze Lite"
        Me.TabControl1.ResumeLayout(False)
        Me.TabSelectPackages.ResumeLayout(False)
        Me.TabSelectPackages.PerformLayout()
        Me.tabDownloadPackages.ResumeLayout(False)
        Me.tabDownloadPackages.PerformLayout()
        Me.tabManageSources.ResumeLayout(False)
        Me.tabManageSources.PerformLayout()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents arrow As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabSelectPackages As System.Windows.Forms.TabPage
    Friend WithEvents lvSelectPackages As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabDownloadPackages As System.Windows.Forms.TabPage
    Friend WithEvents btnSelectSource As System.Windows.Forms.Button
    Friend WithEvents lvDownload As System.Windows.Forms.ListView
    Friend WithEvents ColumnName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnVersion As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnFilename As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComboSources As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tabManageSources As System.Windows.Forms.TabPage
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents btnAddSource As System.Windows.Forms.Button
    Friend WithEvents ColumnSource As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDownloadSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColumnDepends As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnPackage As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDeleteRepo As System.Windows.Forms.Button
    Public WithEvents lvManageSources As System.Windows.Forms.ListView
    Public WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
