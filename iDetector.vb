Imports System.Management
Public Class iDetector
    Public DFUConnected As Boolean = False
    Public ResetDFU As Boolean = False
    Private WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Private Sub iDetector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iDidntCheck = True
        startbtn.Left = (Me.Width / 2) - (startbtn.Width / 2)
        info.Left = (Me.Width / 2) - (info.Width / 2)
        title.Left = (Me.Width / 2) - (title.Width / 2)
        results.Visible = False
    End Sub
    Public Sub Search_DFU(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        DFUConnected = False
        Do Until DFUConnected = True
            'Searching for DFU...
            RichTextBox1.Text = " "
            Dim searcher As New ManagementObjectSearcher( _
                      "root\CIMV2", _
                      "SELECT * FROM Win32_PnPEntity WHERE Description = 'Apple Recovery (DFU) USB Driver'")
            For Each queryObj As ManagementObject In searcher.Get()
                RichTextBox1.Text += (queryObj("Description"))
            Next
            If RichTextBox1.Text.Contains("DFU") Then
                Shell("cmd /c taskkill /f /t /im iTunes.exe", AppWinStyle.Hide)
                Shell("cmd /c taskkill /f /t /im iTunesHelper.exe", AppWinStyle.Hide)
                'Cya iTunes...
                'MsgBox("In DFU!", MsgBoxStyle.Information)
                DFUConnected = True
            End If
        Loop
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
    Public Sub CleanupDFU()
        'Cleanup a bit + Run iDetector
        Prepare.Visible = False
        dfuinstructions.Visible = False
        resetinstructions.Visible = False
        results.Text = "Detecting Device..."
        results.Left = (Me.Width / 2) - (results.Width / 2)
        results.Visible = True
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_PnPEntity WHERE Caption = 'Apple Mobile Device USB Driver'")
            For Each queryObj As ManagementObject In searcher.Get()
                RichTextBox1.Text += ("DeviceID: {0}" & queryObj("DeviceID"))
            Next
            If RichTextBox1.Text.Contains("CPID:8720") = True Then
                'iPod Touch 2G
                If RichTextBox1.Text.Contains("[IBOOT-240.4]") = True Then
                    results.Text = "The iPod Touch 2G connected is old bootrom/MB model."
                    results.Left = (Me.Width / 2) - (results.Width / 2)
                Else
                    results.Text = "The iPod Touch 2G connected is new bootrom/MC model."
                    MsgBox("This iPod Touch 2G is new bootrom/MC model.", MsgBoxStyle.Information)
                End If
            ElseIf RichTextBox1.Text.Contains("CPID:8920") = True Then
                'iPhone 3GS
                If RichTextBox1.Text.Contains("[IBOOT-359.3]") = True Then
                    results.Text = "The iPhone 3GS connected is OLD bootrom."
                    results.Left = (Me.Width / 2) - (results.Width / 2)
                Else
                    results.Text = "The iPhone 3GS connected is NEW bootrom."
                    results.Left = (Me.Width / 2) - (results.Width / 2)
                End If
            Else
                results.Text = "Unknown Device."
                results.Left = (Me.Width / 2) - (results.Width / 2)
            End If
            Button1.Visible = True
            Button1.Left = (Me.Width / 2) - (Button1.Width / 2)
        Catch err As ManagementException
        End Try
    End Sub
    Public Sub GoGoGadgetCleanup_DFU2()
        dfuinstructions.Visible = False
        Prepare.Visible = False
        info.Visible = True
        title.Visible = True
        startbtn.Visible = True
        results.Visible = False
        resetinstructions.Visible = False
    End Sub
    Public Sub DoDFUIntructions()
        info.Visible = False
        dfuinstructions.Visible = False
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        Prepare.Visible = True
        Prepare.Text = "Prepare to press Power + Home (5)"
        Prepare.Left = (Me.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Prepare.Text = "Prepare to press Power + Home (4)"
        Prepare.Left = (Me.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Prepare.Text = "Prepare to press Power + Home (3)"
        Prepare.Left = (Me.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Prepare.Text = "Prepare to press Power + Home (2)"
        Prepare.Left = (Me.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Prepare.Text = "Prepare to press Power + Home (1)"
        Prepare.Left = (Me.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Prepare.Visible = False
        dfuinstructions.Visible = True
        dfuinstructions.Text = "Press the Power + Home Button! (10)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Press the Power + Home Button! (9)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Press the Power + Home Button! (8)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Press the Power + Home Button! (7)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Press the Power + Home Button! (6)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Prepare.Visible = True
        Prepare.Text = "Prepare to release the Power but keep holding Home. (5)"
        Prepare.Left = (Me.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Press the Power + Home Button! (5)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Prepare.Text = "Prepare to release the Power but keep holding Home. (4)"
        Prepare.Left = (Me.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Press the Power + Home Button! (4)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Prepare.Text = "Prepare to release the Power but keep holding Home. (3)"
        Prepare.Left = (Me.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Press the Power + Home Button! (3)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Prepare.Text = "Prepare to release the Power but keep holding Home. (2)"
        Prepare.Left = (Me.Width / 2) - (Prepare.Width / 2)
        dfuinstructions.Text = "Press the Power + Home Button! (2)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Press the Power + Home Button! (1)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Prepare.Text = "Prepare to release the Power but keep holding Home. (1)"
        Prepare.Left = (Me.Width / 2) - (Prepare.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Prepare.Visible = False
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (30)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (29)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (28)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (27)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (26)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (25)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (24)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (23)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (22)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (21)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (20)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (19)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (18)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (17)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (16)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (15)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (14)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (13)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (12)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (11)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (10)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (9)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (8)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (7)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (6)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (5)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (4)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (3)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (2)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        dfuinstructions.Text = "Release the Power Button, but keep holding home! (1)"
        dfuinstructions.Left = (Me.Width / 2) - (dfuinstructions.Width / 2)
        Delay(1)
        If ResetDFU = True Then
            ResetDFU = False
            Call DoDFUIntructions()
            Exit Sub
        End If
        Call GoGoGadgetCleanup_DFU2()
        dfuinstructions.Visible = False
        MsgBox("You failed to Enter DFU. Please Try again.", MsgBoxStyle.Critical)
    End Sub
    Private Sub startbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbtn.Click
        startbtn.Visible = False
        resetinstructions.Visible = True
        info.Visible = False
        Call DoDFUIntructions()
    End Sub
    Private Sub juststop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles juststop.Click
        iDevWarn.MdiParent = MDIMain
        iDevWarn.Show()
        Me.Dispose()
    End Sub
    Private Sub resetinstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetinstructions.Click
        ResetDFU = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Call GoGoGadgetCleanup_DFU2()
    End Sub
End Class