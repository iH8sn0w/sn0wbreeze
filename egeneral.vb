Public Class egeneral
    Public Ignoreit As Boolean
    Private Sub CheckBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hacktivate.MouseEnter
        Try
            If iPhoneModel.Substring(0, 6) = "iPhone" Then
                Label2.Text = ("This option will activate your iPhone, if you are not on an official cell phone carrier")
            Else
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartitionsizeBar.Scroll
        Label3.Text = PartitionsizeBar.Value
        TextRoot.Text = PartitionsizeBar.Value
    End Sub
    Private Sub egeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iWantzAnimate = True
        InstallMS = True
        PartitionsizeBar.Minimum = RootFSsize.ToString
        PartitionsizeBar.Maximum = 7000
        Label3.Text = RootFSsize.ToString
        TextRoot.Text = RootFSsize
        If ModelVar = "n92ap" Then
            'Hide Enable Gestures...
            CheckBox1.Visible = False
        End If
        If iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Then
            Hacktivate.Checked = False
            ActivatePhone = False
            Hacktivate.ForeColor = Color.DimGray
            chkBatPercent.ForeColor = Color.DimGray
        Else
            Hacktivate.ForeColor = Color.White
            chkBatPercent.ForeColor = Color.White
        End If
        If iPhoneModel = "iPod Touch 3G" Then
            Hacktivate.Checked = False
            ActivatePhone = False
            Hacktivate.ForeColor = Color.DimGray
            chkBatPercent.ForeColor = Color.White
        ElseIf iPhoneModel = "iPod Touch 4" Then
            chkBatPercent.ForeColor = Color.White
        End If
        If iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPad" Then
            Hacktivate.ForeColor = Color.DimGray
            Hacktivate.Checked = False
            ActivatePhone = False
            BasebandWarning.Text = " "
        End If
        ActivatePhone = False
        Label3.Text = RootFSsize
        RootFSsize = TextRoot.Text
        ' Label3.Text = RootFSsize
        NOR = False
        If ModelVar = "n92ap" Then
            Hacktivate.ForeColor = Color.DimGray
            Hacktivate.Checked = False
            ActivatePhone = False
        End If
        If iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 4" Then
            chkBatPercent.Checked = True
            EnablePercentage = True
        End If
    End Sub
    Private Sub TextRoot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextRoot.KeyPress
        'Only accept numbers
        If Not Char.IsDigit(e.KeyChar.ToString) Then
            If Not e.KeyChar = vbBack Then e.Handled = True
        End If
    End Sub
    Private Sub TextRoot_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextRoot.Leave
        On Error Resume Next
        If CInt(TextRoot.Text) = "" Then
            'Put nothing here please
        End If
        If CInt(TextRoot.Text) < RootFSsize.ToString Then
            Label2.ForeColor = Color.Red
            Label2.Text = "The the value entered was not valid."
            TextRoot.Text = RootFSsize.ToString
            Timer1.Start()
        End If
    End Sub
    Private Sub TextRoot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextRoot.TextChanged
        If TextRoot.Text = "" Then
            'TextRoot.Text = "600"
        ElseIf TextRoot.Text > 7000 Then
            TextRoot.Text = "7000"
            PartitionSize = TextRoot.Text
        ElseIf TextRoot.Text >= RootFSsize And TextRoot.Text <= 7000 Then
            PartitionsizeBar.Value = TextRoot.Text
            Label2.ForeColor = Color.White
            Label2.Text = ""
            PartitionSize = TextRoot.Text
        Else
            PartitionSize = TextRoot.Text
        End If

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label2.ForeColor = Color.Red Then
            Label2.ForeColor = Color.White
            Label2.Text = ""
            Timer1.Stop()
        End If
    End Sub
    Private Sub egeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        On Error Resume Next
        If CInt(TextRoot.Text) = "" Then
            'Put nothing here please
        End If
        If CInt(TextRoot.Text) < RootFSsize.ToString Then
            Label2.ForeColor = Color.Red
            Label2.Text = "The the value entered was not valid."
            TextRoot.Text = RootFSsize.ToString
            Timer1.Start()
        End If
    End Sub
    Private Sub CheckBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hacktivate.MouseLeave
        Label2.Text = ""
    End Sub
    Private Sub logo2_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.Image = My.Resources.Flakeselect
    End Sub
    Private Sub logo2_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseLeave
        logo2.Image = My.Resources.Flake
    End Sub
    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        If iPhoneModel = "iPhone 3GS" Then
            eunlock.MdiParent = MDIMain
            eunlock.Show()
            Me.Hide()
        Else
            ecustomapps.MdiParent = MDIMain
            ecustomapps.Show()
            Me.Hide()
        End If
        'save to global variable in memory - check ModMain
    End Sub
    Private Sub arrow_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseEnter
        arrow.Image = My.Resources.Arrowhilite
    End Sub
    Private Sub arrow_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseLeave
        arrow.Image = My.Resources.Arrow
    End Sub
    Private Sub arrow_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseDown
        arrow.Image = My.Resources.arrowpress
    End Sub
    Private Sub arrow_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseUp
        arrow.Image = My.Resources.Arrowhilite
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hacktivate.CheckedChanged
        If iPhoneModel = "iPod Touch 1G" Or iPhoneModel = "iPod Touch 2G" Or iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 4" Or iPhoneModel = "iPad" Or iPhoneModel = "Apple TV 2" Or ModelVar = "n92ap" Then
            Hacktivate.Checked = False
            ActivatePhone = False
            Exit Sub
        End If
        If Hacktivate.Checked = True Then
            ActivatePhone = True
        Else
            ActivatePhone = False
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        MsgBox("Marking the IPSW as a NOR-Only IPSW has 1 major advantage. You can change your Boot Logo without wiping out ANYTHING on your Device, and iPhone Users can make iBoot boot in Verbose without a Restore.", MsgBoxStyle.Information)
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBatPercent.CheckedChanged
        If iPhoneModel = "iPod Touch 3G" Or iPhoneModel = "iPod Touch 4" Then
            chkBatPercent.Checked = True
            EnablePercentage = True
            Exit Sub
        End If
        If chkBatPercent.Checked = True And iPhoneModel = "Apple TV 2" Then
            chkBatPercent.Checked = False
            Exit Sub
        End If
        If chkBatPercent.Checked = True Then
            If iPhoneModel = "iPhone 3GS" Or iPhoneModel = "iPhone 4" Or iPhoneModel = "iPad" Then
                MsgBox("This option is already enabled by Apple.", MsgBoxStyle.Information)
                EnablePercentage = False
                chkBatPercent.Checked = False
            Else
                EnablePercentage = True
                chkBatPercent.Checked = True
            End If
        ElseIf chkBatPercent.Checked = False Then
            EnablePercentage = False
        End If
    End Sub
    Private Sub InstallSSH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInstallSSH.CheckedChanged
        If chkInstallSSH.Checked = True Then
            InstallSSH = True
            MsgBox("When enabling SSH on your device," & Chr(13) & "Please ensure that you change your password." & Chr(13) & Chr(13) & "You can do that by doing:" & Chr(13) & Chr(13) & "1) Login to SSH (User : root) (Pass : alpine)." & Chr(13) & "2) Type ""passwd"" (No Quotes)." & Chr(13) & "3) Type your new SSH Password.", MsgBoxStyle.Information)
        Else
            InstallSSH = False
        End If
    End Sub

    Private Sub animate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnimate.CheckedChanged
        If chkAnimate.Checked = True Then
            iWantzAnimate = True
        Else
            iWantzAnimate = False
        End If
    End Sub
End Class