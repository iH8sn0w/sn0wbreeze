Imports System
Imports System.Management
Imports System.Threading
Imports System.IO
Imports System.IO.Ports

Public Class DFU
    Dim TimeRemaining As Int32 = 0
    Dim ExitCountDown As Boolean = False

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MDIMain.MenuStrip1.Enabled = True
        Dim Killer As String
        Killer = "cmd /c taskkill /f /t /im iREB.exe"
        Shell(Killer)
        PictureBox4.Enabled = False
        BackgroundWorker1.CancelAsync()
        Call SetMdiClientBorder(False)

        'extract required dll's to app folder
        'If File_Exists(My.Application.Info.DirectoryPath & "\Ionic.Zip.dll") = False Then SaveToDisk("Ionic.Zip.dll", My.Application.Info.DirectoryPath & "\Ionic.Zip.dll")

        'create temp folders
        tempPath2 = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"
        tempPath2 = tempPath2 & "\sn0wbreeze-iREB"
        tempPath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"
        tempPath = tempPath & "\sn0wbreeze"
        Folder_Delete(tempPath)
        Folder_Delete(tempPath2)
        Create_Directory(tempPath)
        'Create_Directory(tempPath & "\debsCustom\private\var\root\Media\Cydia\AutoInstall")
        Create_Directory(tempPath & "\debsCustom")
        Create_Directory(tempPath & "\repos")
        Create_Directory(tempPath2)
        Form1.MdiParent = MDIMain
        Credits.MdiParent = MDIMain
        Form1.Show()
        About.MdiParent = MDIMain
        About.Show()
        Form1.Enabled = False
        About.BringToFront()
        Me.Dispose()

    End Sub
    Private Sub DFU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = MDIMain
        KilliTunes()
        ProgressBar1.Visible = False
        Label1.Text = "DFU Pwner [greenpois0n]"
        Label1.Left = (Me.Width / 2) - (Label1.Width / 2)
        Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
        If PreviousModel = "Apple TV 2" Then
            Call LoadATV2()
        Else
            atv2.Visible = False
        End If
    End Sub
    Public Sub LoadATV2()
        PictureBox1.Visible = False
        Label4.Text = "Plug in your Apple TV via USB"
        Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
    End Sub
    Public Sub KilliTunes()
        ' Shell("cmd /c taskkill /f /t /im iTunes.exe", AppWinStyle.Hide)
        ' Shell("cmd /c taskkill /f /t /im iTunesHelper.exe", AppWinStyle.Hide)
    End Sub
    Public Sub GoGoGadgetiREB()
        KilliTunes()
        PictureBox6.Visible = False
        ProgressBar1.Visible = True
        Button2.Enabled = False
        RichTextBox1.Visible = False
        Label4.Text = ""
        Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
        Label1.Text = "Running iREB..."
        Label1.Left = (Me.Width / 2) - (Label1.Width / 2)
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.runningireb
        'Shutting Down iTunes... - Start
        Dim Kill3 As String
        Kill3 = "cmd /c taskkill /f /t /im iREB.exe"

        'Shutting Down iTunes... - Done
        '
        'Calling upon the forces of iREB...
        Dim GoGoGadgetLoader As String


        SaveToDisk("s-irecovery.exe", tempPath2 & "\pois0n.exe")

        cmdline = Quotation & tempPath2 & "\pois0n.exe" & Quotation & " -e"
        ProgressBarL.RunWorkerAsync()
        ExecCmd(cmdline, True)
        MsgBox("Your device is now in a PWNED DFU state (black screen)." & Chr(13) & Chr(13) & "You may now launch iTunes and do SHIFT + Restore" & Chr(13) & "to the custom sn0wbreeze IPSW located on your desktop!" & Chr(13) & Chr(13) & "Note: If you get Error 2003 in iTunes after Extracting," & Chr(13) & "Just unplug/replug it in and do it again.", MsgBoxStyle.Information)
        ProgressBar1.Visible = False
        ProgressBar1.Value = 0

        PictureBox4.Enabled = False
        Call SetMdiClientBorder(False)

        'extract required dll's to app folder
        'If File_Exists(My.Application.Info.DirectoryPath & "\Ionic.Zip.dll") = False Then SaveToDisk("Ionic.Zip.dll", My.Application.Info.DirectoryPath & "\Ionic.Zip.dll")
        iPhoneModel = ""
        'create temp folders
        tempPath2 = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"
        tempPath2 = tempPath2 & "\sn0wbreeze-iREB"
        tempPath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"
        tempPath = tempPath & "\sn0wbreeze"
        Folder_Delete(tempPath)
        Folder_Delete(tempPath2)
        Create_Directory(tempPath)
        'Create_Directory(tempPath & "\debsCustom\private\var\root\Media\Cydia\AutoInstall")
        Create_Directory(tempPath & "\debsCustom")
        Create_Directory(tempPath & "\repos")
        Create_Directory(tempPath2)
        Form1.MdiParent = MDIMain
        Credits.MdiParent = MDIMain
        Form1.Show()
        About.MdiParent = MDIMain
        About.Show()
        Form1.Enabled = False
        About.BringToFront()
        Me.Dispose()

    End Sub
    Function HighlightWords(ByVal rtb As RichTextBox, ByVal sFindString As String, ByVal lColor As System.Drawing.Color) As Int32

        Dim iFoundPos As Int32 'Position of first character of match
        Dim iFindLength As Int32       'Length of string to find
        Dim iOriginalSelStart As Int32
        Dim iOriginalSelLength As Int32
        Dim iMatchCount As Int32      'Number of matches

        'Save the insertion points current location and length
        iOriginalSelStart = rtb.SelectionStart
        iOriginalSelLength = rtb.SelectionLength

        'Cache the length of the string to find
        iFindLength = Len(sFindString)

        'Attempt to find the first match
        iFoundPos = rtb.Find(sFindString, 0, RichTextBoxFinds.NoHighlight)
        While iFoundPos > 0
            iMatchCount = iMatchCount + 1
            iFoundPos = rtb.Find("THIS SHOULD NOT RETURN ANYTHIN---3$#@$#%@$#@!$@#$#@$@!#$!@#$!@$234-AND I MEAN IT!!!#@!$!%&*()(*&^%$#@!", iFoundPos + iFindLength, RichTextBoxFinds.NoHighlight)
        End While

        'Restore the insertion point to its original location and length
        rtb.SelectionStart = iOriginalSelStart
        rtb.SelectionLength = iOriginalSelLength

        'Return the number of matches
        HighlightWords = iMatchCount
    End Function
    Public Sub DoSearch2()
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
    End Sub
    Private Sub DFU_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        PictureBox4.Enabled = False
    End Sub
    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop

    End Sub
    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.start_button_over

    End Sub
    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.start_button_black
    End Sub
    Public Sub ATV2DFU()
        PictureBox1.Visible = False
        PictureBox6.Visible = True
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to Press Menu + Play/Pause (5)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to Press Menu + Play/Pause (4)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to Press Menu + Play/Pause (3)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to Press Menu + Play/Pause (2)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to Press Menu + Play/Pause (1)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Press && hold Menu + Play/Pause (7)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_both
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Press && hold Menu + Play/Pause (6)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_both
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Press && hold Menu + Play/Pause (5)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_both
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Press && hold Menu + Play/Pause (4)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_both
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to release (3)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_both
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to release (2)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_both
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to release (1)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_both
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Release both buttons! (10)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Release both buttons! (9)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Release both buttons! (8)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Release both buttons! (7)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Release both buttons! (6)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Release both buttons! (5)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Release both buttons! (4)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Release both buttons! (3)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Release both buttons! (2)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Release both buttons! (1)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox6.Image = My.Resources.remote_self
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox4.Enabled = True
            PictureBox6.Image = My.Resources.X
            PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
            Label4.Text = "DFU Was not detected! Try again."
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            MDIMain.MenuStrip1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        MDIMain.MenuStrip1.Enabled = False
        PictureBox1.Visible = False
        atv2.Visible = False
        SaveToDisk("wait.img3", tempPath2 & "\iPhone4.True")
        PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        Label1.Text = "DFU Pwner [greenpois0n]"
        Label1.Left = (Me.Width / 2) - (Label1.Width / 2)
        PictureBox4.Enabled = False
        Label2.Visible = False
        Label4.Visible = True
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        If PreviousModel = "Apple TV 2" Then
            Call ATV2DFU()
            Exit Sub
        End If
        PictureBox1.Visible = True
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to Press Home and Power (5)"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox1.Image = My.Resources.dfuPrepare
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to Press Home and Power (4)"
            PictureBox1.Image = My.Resources.dfuPrepare
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to Press Home and Power (3)"
            PictureBox1.Image = My.Resources.dfuPrepare
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to Press Home and Power (2)"
            PictureBox1.Image = My.Resources.dfuPrepare
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Prepare to Press Home and Power (1)"
            PictureBox1.Image = My.Resources.dfuPrepare
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Press and hold the Home and Power"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            PictureBox1.Image = My.Resources.dfuTwoButtons10
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuTwoButtons09
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuTwoButtons08
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuTwoButtons07
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuTwoButtons06
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuTwoButtons05
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuTwoButtons04
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuTwoButtons03
            Label4.Text = "Prepare to release the power button"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuTwoButtons02
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuTwoButtons01
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuRelease
            Label4.Text = "Release the Power button and hold the Home button"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            Delay(2)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            Label4.Text = "Keep Holding the home button"
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            RichTextBox1.Visible = True
            PictureBox1.Image = My.Resources.dfutwobuttons30
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons29
            Delay(1)

        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons28
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons27
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons26
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons25
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons24
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons23
            Delay(1)
        End If
        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons22
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons21
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons20
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons19
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons18
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons17
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons16
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons15
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons14
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons13
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons12
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfutwobuttons11
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            RichTextBox1.Visible = False
            PictureBox1.Image = My.Resources.dfuOneButton10
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuOneButton09
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuOneButton08
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuOneButton07
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuOneButton06
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuOneButton05
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuOneButton04
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuOneButton03
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuOneButton02
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox1.Image = My.Resources.dfuOneButton01
            Delay(1)
        End If

        If File_Exists(tempPath2 & "\DFU.True") = True Then
            Call GoGoGadgetiREB()
            Exit Sub
        Else
            PictureBox4.Enabled = True
            PictureBox1.Image = My.Resources.X
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Label4.Text = "DFU Was not detected! Try again."
            Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
            MDIMain.MenuStrip1.Enabled = True
        End If
    End Sub
    Public Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do Until File_Exists(tempPath2 & "\DFU.True")
            'Searching for DFU...
            console.Text = " "
            Dim searcher As New ManagementObjectSearcher( _
                      "root\CIMV2", _
                      "SELECT * FROM Win32_PnPEntity WHERE Description = 'Apple Recovery (DFU) USB Driver'")
            For Each queryObj As ManagementObject In searcher.Get()

                console.Text += (queryObj("Description"))
            Next
            If console.Text.Contains("DFU") Then
                SaveToDisk("sn0w.img3", tempPath2 & "\DFU.True")
            End If
        Loop
    End Sub

    Private Sub ProgressBarL_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ProgressBarL.DoWork
        Do Until ProgressBar1.Value = 99
            ProgressBar1.Invoke(CType(AddressOf Increase, MethodInvoker))
            Sleep(50)
        Loop
        ProgressBar1.Invoke(CType(AddressOf Meh, MethodInvoker))
    End Sub
    Public Sub Meh()
        ProgressBar1.Value = 100
    End Sub
    Public Sub Increase()
        If ProgressBar1.Value = 100 Then
            Exit Sub
        End If
        ProgressBar1.Value = ProgressBar1.Value + 3
    End Sub


End Class