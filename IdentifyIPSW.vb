Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Management

Public Class IdentifyIPSW
    Public MD51 As Boolean = False
    Public ipswhash As String
    Private WithEvents get_MD5 As System.ComponentModel.BackgroundWorker
    Public Sub get_MD5_hash(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles get_MD5.DoWork

        'MD5 hash provider for computing the hash of the file
        Dim md5 As New MD5CryptoServiceProvider()

        'open the file
        Dim stream As New FileStream(ipsw, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        'calculate the files hash
        md5.ComputeHash(stream)

        'close our stream
        stream.Close()

        'byte array of files hash
        Dim hash As Byte() = md5.Hash

        'string builder to hold the results
        Dim sb As New StringBuilder()

        'loop through each byte in the byte array
        For Each b As Byte In hash
            'format each byte into the proper value and append
            'current value to return value
            sb.Append(String.Format("{0:X2}", b))
        Next

        'return the MD5 hash of the file
        ipswhash = sb.ToString.ToLower
    End Sub
    Private Sub get_md5_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles get_MD5.RunWorkerCompleted
        MDIMain.MenuStrip1.Enabled = True
        Back.Enabled = True
        If ipswhash = "7c1c714f24a89c2f2c71e26d37cde3f0" Then
            IPSWVersion = "4.3.2"
            IPSWvers.Text = "4.3.2 (8H7) IPSW Verified!"
            ihelper.Text = "iPhone 3GS"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPhone 3GS"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.iPhone3GS
            Usepod2gsAwesomeKernelExploit = False
            RootFSsize = 850
            iDevWarn.MdiParent = MDIMain
            iDevWarn.Show()
        ElseIf ipswhash = "8cb3a9964a2a99414030f662d3009deb" Then
            IPSWVersion = "4.3.2"
            IPSWvers.Text = "4.3.2 (8H7) IPSW Verified!"
            ihelper.Text = "iPhone 4"
            ModelVar = "n90ap"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPhone 4"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            iBootyMethod = True
            PictureBox1.Image = My.Resources.i4
            Usepod2gsAwesomeKernelExploit = False
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
            RootFSsize = 950
        ElseIf ipswhash = "30fc03783453d23aaa0d13f89fd36c28" Then
            IPSWVersion = "4.2.7"
            IPSWvers.Text = "4.2.7 (8E303) IPSW Verified!"
            ihelper.Text = "iPhone 4 (Verizon)"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPhone 4"
            ModelVar = "n92ap"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            iBootyMethod = True
            PictureBox1.Image = My.Resources.i4
            Usepod2gsAwesomeKernelExploit = False
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
            RootFSsize = 950
        ElseIf ipswhash = "7f831b30d33f80c7f92442cb041227ab" Then
            IPSWVersion = "4.3.2"
            IPSWvers.Text = "4.3.2 (8H7) IPSW Verified!"
            ihelper.Text = "iPod Touch 3G"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPod Touch 3G"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.ipt3
            Usepod2gsAwesomeKernelExploit = False
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
            RootFSsize = 850
        ElseIf ipswhash = "4a002a4596a681efd9cdbf6f2fd72e74" Then
            IPSWVersion = "4.3.2"
            IPSWvers.Text = "4.3.2 (8H7) IPSW Verified!"
            ihelper.Text = "iPod Touch 4"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPod Touch 4"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.ipt4
            Usepod2gsAwesomeKernelExploit = False
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
            RootFSsize = 930
        ElseIf ipswhash = "24027c4381a6cdfdd8a03a17177d1d6c" Then
            IPSWVersion = "4.3.2"
            IPSWvers.Text = "4.3.2 (8H7) IPSW Verified!"
            ihelper.Text = "iPad"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "iPad"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.ipad
            Usepod2gsAwesomeKernelExploit = False
            iBootyMethod = True
            RootFSsize = 1100
        ElseIf ipswhash = "893cdf844a49ae2f7368e781b1ccf6d1" Then
            IPSWVersion = "4.3"
            IPSWvers.Text = "4.3 (8F202) IPSW Verified!"
            ihelper.Text = "Apple TV 2"
            ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
            iPhoneModel = "Apple TV 2"
            Status.Show()
            Status.Image = My.Resources.reflectionImage2
            statuslabelgood.Show()
            Statuslabelbad.Hide()
            Button1.Enabled = False
            Button1.Text = "Done!"
            arrow.Image = My.Resources.Arrow
            arrow.Enabled = True
            PictureBox1.Image = My.Resources.atv2
            Usepod2gsAwesomeKernelExploit = False
            iBootyMethod = True
            RootFSsize = 800
            PartitionSize = 800
            'iDevWARN.Show()
            'iDevWARN.BringToFront()
        ElseIf ipswhash = "449dc57f61c44033695cd3ccfeef2b04" Then
            Status.Show()
            Status.Image = My.Resources.X
            Statuslabelbad.Show()
            statuslabelgood.Hide()
            Label3.Visible = True
            Label1.Visible = True
            ortxt.Visible = True
            PictureBox2.Visible = False
            dragtxt.Visible = True
            ListBox1.Visible = True
            MsgBox("Sorry, the iPad 2 is currently NOT supported.", MsgBoxStyle.Critical)
        ElseIf ipswhash = "dfdc5e4c5844d4d6c56e05c3ce4e7258" Then
            Status.Show()
            Status.Image = My.Resources.X
            Statuslabelbad.Show()
            statuslabelgood.Hide()
            Label3.Visible = True
            Label1.Visible = True
            ortxt.Visible = True
            PictureBox2.Visible = False
            dragtxt.Visible = True
            ListBox1.Visible = True
            MsgBox("Sorry, the iPad 2 is currently NOT supported.", MsgBoxStyle.Critical)
        ElseIf ipswhash = "b1bfc67402a6fcee09271d562666d7c4" Then
            Status.Show()
            Status.Image = My.Resources.X
            Statuslabelbad.Show()
            statuslabelgood.Hide()
            Label3.Visible = True
            Label1.Visible = True
            ortxt.Visible = True
            PictureBox2.Visible = False
            dragtxt.Visible = True
            ListBox1.Visible = True
            MsgBox("Sorry, the iPad 2 is currently NOT supported.", MsgBoxStyle.Critical)
        Else
            Status.Show()
            Status.Image = My.Resources.X
            Statuslabelbad.Show()
            statuslabelgood.Hide()
            Label3.Visible = True
            Label1.Visible = True
            ortxt.Visible = True
            PictureBox2.Visible = False
            dragtxt.Visible = True
            ListBox1.Visible = True
        End If
        Button1.Visible = True
        Label2.Visible = False
        PictureBox2.Visible = False
        If Button1.Text = "Done!" Then
            Button1.Visible = False
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Status.Hide()
            Statuslabelbad.Hide()
            iDevLoaded = False
            ipsw = ""
            ipsw = FileOpenDialog("*.ipsw", "Desktop")
            If ipsw <> "" Then

                'save form position for progress form
                '
                ProgressTop = MDIMain.Top
                ProgressLeft = MDIMain.Left

                Back.Enabled = False
                MDIMain.MenuStrip1.Enabled = False
                get_MD5 = New System.ComponentModel.BackgroundWorker
                get_MD5.WorkerReportsProgress = True
                get_MD5.WorkerSupportsCancellation = True
                get_MD5.RunWorkerAsync()
                dragtxt.Visible = False
                Label2.Visible = True
                Label3.Visible = False
                ortxt.Visible = False
                Label1.Visible = False
                Button1.Visible = False
                ListBox1.Visible = False
                PictureBox2.Visible = True
                'ipswhash = getFilesMD5Hash(ipsw)
            End If
        Catch Ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub ListBox1_DragEnter(ByVal sender As Object, ByVal e As  _
System.Windows.Forms.DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub ListBox1_DragDrop(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop
        Status.Hide()
        Statuslabelbad.Hide()
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            Dim i As Int32

            ' Assign the files to an array.
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            ' Loop through the array and add the files to the list.
            For i = 0 To MyFiles.Length - 1
                ListBox1.Items.Add(MyFiles(i))
            Next
            Call DragNDrop()
        End If

    End Sub
    Public Sub DragNDrop()
        If ListBox1.Items.Count = 1 Then
            ipsw = ""
            MDIMain.Activate()
            ipsw = ListBox1.Items.Item(0)
            Back.Enabled = False
            MDIMain.MenuStrip1.Enabled = False
            get_MD5 = New System.ComponentModel.BackgroundWorker
            get_MD5.WorkerReportsProgress = True
            get_MD5.WorkerSupportsCancellation = True
            get_MD5.RunWorkerAsync()
            Label2.Visible = True
            Label3.Visible = False
            Label1.Visible = False
            ortxt.Visible = False
            Button1.Visible = False
            ListBox1.Visible = False
            PictureBox2.Visible = True
            dragtxt.Visible = False
            ListBox1.Items.Clear()
        Else
            ListBox1.Items.Clear()
            MsgBox("Drag only one IPSW at a time!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub eForm4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIMain.MenuStrip1.Enabled = True
        PictureBox2.Visible = False
        Label2.Visible = False
        Button1.Visible = True
        Label1.Visible = True
        Label3.Visible = True
        This3GSisold = False
        iPhoneModel = ""
        IPSWvers.Text = ""
        Status.Hide()
        Statuslabelbad.Hide()
        statuslabelgood.Hide()
        ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
    End Sub
    Public Function getFilesMD5Hash(ByVal file As String) As String

        'MD5 hash provider for computing the hash of the file
        Dim md5 As New MD5CryptoServiceProvider()

        'open the file
        Dim stream As New FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        'calculate the files hash
        md5.ComputeHash(stream)

        'close our stream
        stream.Close()

        'byte array of files hash
        Dim hash As Byte() = md5.Hash

        'string builder to hold the results
        Dim sb As New StringBuilder()

        'loop through each byte in the byte array
        For Each b As Byte In hash
            'format each byte into the proper value and append
            'current value to return value
            sb.Append(String.Format("{0:X2}", b))
        Next

        'return the MD5 hash of the file
        Return sb.ToString.ToLower()
        iDevLoaded = True
    End Function


    Private Function FileOpenDialog(ByVal strExtension As String, ByVal strInitDir As String) As String

        Dim oFileDialog As New System.Windows.Forms.OpenFileDialog()
        Dim strfilter As String = BuildFilter(strExtension)

        FileOpenDialog = ""

        With oFileDialog
            .Filter = "iPhone/iPod Software File (*.ipsw) |*.ipsw;"
            .DefaultExt = strExtension
            .InitialDirectory = strInitDir
            .ShowDialog()
            If Windows.Forms.DialogResult.OK Then
                FileOpenDialog = .FileName
            ElseIf Windows.Forms.DialogResult.Cancel Then
            End If
        End With

    End Function

    Private Function BuildFilter(ByVal strExtension As String) As String

        BuildFilter = ""

        If strExtension.PadLeft(1) <> "." Then
            BuildFilter = "(*." & strExtension & ")|" & "*." & strExtension
        ElseIf strExtension.PadLeft(1) = "." Then
            BuildFilter = "(*" & strExtension & ")|" & "*" & strExtension
        End If

    End Function

    Private Sub logo2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.Image = My.Resources.Flakeselect
    End Sub

    Private Sub logo2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseLeave
        logo2.Image = My.Resources.Flake
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.ShowDialog()
    End Sub

    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Expert.MdiParent = MDIMain
        Expert.Show()
        Me.Close()
    End Sub
    Private Sub ihelper_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ihelper.TextChanged
        ihelper.Left = (Me.Width / 2) - (ihelper.Width / 2)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Expert.MdiParent = MDIMain
        Expert.Show()
        Me.Close()
    End Sub
    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Form1.MdiParent = MDIMain
        Form1.Show()
        Form1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub Back_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Back.MouseDown
        Back.Image = My.Resources.CancelClicked
    End Sub

    Private Sub Back_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Back.MouseEnter
        Back.Image = My.Resources.CancelClicked
    End Sub

    Private Sub Back_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Back.MouseLeave
        Back.Image = My.Resources.Cancel
    End Sub

    Private Sub Back_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Back.MouseUp
        Back.Image = My.Resources.Cancel
    End Sub

    Private Sub arrow_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        PartitionSize = RootFSsize
        If iPhoneModel = "Apple TV 2" Then
            ebuilding.MdiParent = MDIMain
            ebuilding.Show()
            Me.Dispose()
            Exit Sub
        End If
        SelectMode.MdiParent = MDIMain
        SelectMode.Show()
        Me.Dispose()
    End Sub

    Private Sub arrow_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseEnter
        arrow.Image = My.Resources.Arrowhilite
    End Sub

    Private Sub arrow_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseDown
        arrow.Image = My.Resources.arrowpress
    End Sub

    Private Sub arrow_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseLeave
        arrow.Image = My.Resources.Arrow
    End Sub

    Private Sub arrow_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseUp
        arrow.Image = My.Resources.Arrowhilite
    End Sub

    Private Sub dragtxt_DragEnter(ByVal sender As Object, ByVal e As  _
System.Windows.Forms.DragEventArgs) Handles dragtxt.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub dragtxt_DragDrop(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.DragEventArgs) Handles dragtxt.DragDrop
        Status.Hide()
        Statuslabelbad.Hide()
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            Dim i As Int32

            ' Assign the files to an array.
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            ' Loop through the array and add the files to the list.
            For i = 0 To MyFiles.Length - 1
                ListBox1.Items.Add(MyFiles(i))
            Next
            Call DragNDrop()
        End If

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Process.Start("http://felixbruns.de/iPod/firmware")
    End Sub
End Class
