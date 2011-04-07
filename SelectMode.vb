Public Class SelectMode
    Public Sub ExpertModeDescription()
        description.Text = "Expert Mode lets you have all customizing options at your disposal" & Chr(13) & "Such as custom boot logos, root partition size, installer options" & Chr(13) & "and unlocks."
    End Sub
    Public Sub SimpleModeDescription()
        description.Text = "Simple Mode - Recommended for people that dont know what to add." & Chr(13) & "Simple Mode adds Cydia, afc2, SSH for Apple TV, and other" & Chr(13) & "recommended stuff automatically."
    End Sub
    Public Sub BBModeDescription()
        description.Text = "This mode ONLY preserves the iPhone's baseband. It does not" & Chr(13) & "Jailbreak or Unlock the actual device. All other modes still" & Chr(13) & "do preserve the baseband."
    End Sub

    Private Sub SimpleMode_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleModebox.MouseLeave
        SimpleModebox.Image = My.Resources.Backing
        description.Text = ""
    End Sub
    Private Sub SimpleMode_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleModebox.MouseEnter
        SimpleModebox.Image = My.Resources.redhover
        Call SimpleModeDescription()
    End Sub

    Private Sub SimpleMode_x2click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleModetxt.DoubleClick
        UserMode = "Simple"
        InstallMS = True
        ebuilding.MdiParent = MDIMain
        ebuilding.Show()
        Me.Dispose()
    End Sub
    Private Sub SimpleModepic_x2click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleModebox.DoubleClick
        UserMode = "Simple"
        InstallMS = True
        ebuilding.MdiParent = MDIMain
        ebuilding.Show()
        Me.Dispose()
    End Sub

    Private Sub SimpleMode_Selected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleModebox.Click
        SimpleModeSelected()
    End Sub

    Private Sub SimpleModetxt_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleModetxt.MouseEnter
        SimpleModebox.Image = My.Resources.redhover
        Call SimpleModeDescription()
    End Sub
    Private Sub SimpleModetxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleModetxt.Click
        SimpleModeSelected()
    End Sub
    Private Sub SimpleModetxt_x2Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleModetxt.DoubleClick
        Expert.MdiParent = MDIMain
        UserMode = "Simple"
        InstallMS = True
        Expert.Show()
        Me.Dispose()
    End Sub

    Public Sub SimpleModeSelected()
        echeck.Visible = False
        bbcheck.Visible = False
        scheck.Visible = True
        Label2.Text = "Click the blue arrow to continue"
        arrow.Image = My.Resources.Arrow
        arrow.Enabled = True
        UserMode = "Simple"
        InstallMS = True
        JustPreserveBaseband = False
    End Sub

    Private Sub ExpertMode_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpertModebox.MouseLeave
        ExpertModebox.Image = My.Resources.Backing
        description.Text = ""
    End Sub
    Private Sub ExpertMode_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpertModebox.MouseEnter
        ExpertModebox.Image = My.Resources.redhover
        Call ExpertModeDescription()
    End Sub

    Private Sub ExpertModetxt_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpertModetxt.MouseEnter
        ExpertModebox.Image = My.Resources.redhover
        Call ExpertModeDescription()
    End Sub
    Private Sub ExpertMode_Selected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpertModebox.Click
        ExpertModeSelected()
    End Sub

    Private Sub ExpertModetxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpertModetxt.Click
        ExpertModeSelected()
    End Sub

    Private Sub ExpertModetxt_x2Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpertModetxt.DoubleClick
        Expert.MdiParent = MDIMain
        UserMode = "Expert"
        InstallMS = True
        Expert.Show()
        Me.Dispose()
    End Sub
    Private Sub ExpertMode_x2click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpertModebox.DoubleClick
        Expert.MdiParent = MDIMain
        UserMode = "Expert"
        InstallMS = True
        Expert.Show()
        Me.Dispose()
    End Sub

    Public Sub ExpertModeSelected()
        scheck.Visible = False
        bbcheck.Visible = False
        echeck.Visible = True
        Label2.Text = "Click the blue arrow to continue"
        arrow.Image = My.Resources.Arrow
        arrow.Enabled = True
        UserMode = "Expert"
        InstallMS = True
        JustPreserveBaseband = False
    End Sub

    Public Sub BBModeSelected()
        scheck.Visible = False
        bbcheck.Visible = True
        echeck.Visible = False
        Label2.Text = "Click the blue arrow to continue"
        arrow.Image = My.Resources.Arrow
        arrow.Enabled = True
        UserMode = "Baseband"
        JustPreserveBaseband = True
    End Sub

    Private Sub BBMode_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbmbox.MouseLeave
        bbmbox.Image = My.Resources.Backing
        description.Text = ""
    End Sub
    Private Sub BBMode_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbmbox.MouseEnter
        bbmbox.Image = My.Resources.redhover
        Call BBModeDescription()
    End Sub

    Private Sub bbmodetxt_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBmodetxt.MouseEnter
        bbmbox.Image = My.Resources.redhover
        Call BBModeDescription()
    End Sub

    Private Sub bbmbox_x2Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbmbox.DoubleClick
        UserMode = "Baseband"
        InstallMS = True
        ebuilding.MdiParent = MDIMain
        ebuilding.Show()
        Me.Dispose()
    End Sub
    Private Sub BBmodetxt_x2Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBmodetxt.DoubleClick
        UserMode = "Baseband"
        InstallMS = True
        ebuilding.MdiParent = MDIMain
        ebuilding.Show()
        Me.Dispose()
    End Sub

    Private Sub bbmbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbmbox.Click
        BBModeSelected()
    End Sub
    Private Sub BBmodetxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBmodetxt.Click
        BBModeSelected()
    End Sub
    Private Sub SelectMode_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseHover
        'This just fixes some GUI bugs.
        bbmbox.Image = My.Resources.Backing
        SimpleModebox.Image = My.Resources.Backing
        ExpertModebox.Image = My.Resources.Backing
    End Sub
    Private Sub SelectMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If iPhoneModel = "iPad" Or ModelVar = "n92ap" Then
            HideBBMode()
            Exit Sub
        End If
        If iPhoneModel.Substring(0, 6) = "iPhone" Then
            'Do Nothing
        Else
            HideBBMode()
        End If
    End Sub
    Public Sub HideBBMode()
        bbcheck.Visible = False
        amsptb.Visible = False
        bbmbox.Visible = False
        BBmodetxt.Visible = False
        bbmicon.Visible = False
    End Sub
    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        If echeck.Visible = True Then
            UserMode = "Expert"
            InstallMS = True
            Expert.MdiParent = MDIMain
            Expert.Show()
            Me.Dispose()
        End If
        If scheck.Visible = True Then
            UserMode = "Simple"
            InstallMS = True
            ebuilding.MdiParent = MDIMain
            ebuilding.Show()
            Me.Dispose()
        End If
        If bbcheck.Visible = True Then
            UserMode = "Baseband"
            ebuilding.MdiParent = MDIMain
            ebuilding.Show()
            Me.Dispose()
        End If
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
End Class