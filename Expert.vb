Public Class Expert

    Private Sub General_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles General.Click
        buildcheck.Hide()
        arrowgray.Hide()
        generalcheck.Show()
        uncheck.Hide()
        cpcheck.Hide()
        logocheck.Hide()
    End Sub

    Private Sub General_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles General.MouseEnter
        General.Image = My.Resources.GeneralHighlight1
    End Sub

    Private Sub General_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles General.MouseLeave
        General.Image = My.Resources.GeneralNorm1
    End Sub

    Private Sub cpackage_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpackage.MouseEnter
        cpackage.Image = My.Resources.CustomPKGHighLight1
    End Sub

    Private Sub cpackage_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpackage.MouseLeave
        cpackage.Image = My.Resources.CustomPKGNorm1
    End Sub

    Private Sub unlocks_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlocks.MouseEnter
        unlocks.Image = My.Resources.UNLOCKHighLight1
    End Sub

    Private Sub unlocks_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlocks.MouseLeave
        unlocks.Image = My.Resources.UNLOCKNorm1
    End Sub

    Private Sub eForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = iPhoneModel & " -- " & IPSWVersion
        buildcheck.Hide()
        uncheck.Hide()
        cpcheck.Hide()
        logocheck.Hide()
        generalcheck.Hide()
        If iPhoneModel = "iPhone 3GS" Then
            unlocks.Enabled = True
        Else
            unlocks.Enabled = False
        End If
        bootlogos.Enabled = False
        bootlogos.Show()
        If This3GSisold = True Then
            bootlogos.Enabled = True
            bootlogos.Show()
        End If
    End Sub

    Private Sub cpackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpackage.Click
        cpackage.Image = My.Resources.CustomPKGHighLight1
        arrowgray.Hide()
        cpcheck.Show()
        uncheck.Hide()
        logocheck.Hide()
        generalcheck.Hide()
        buildcheck.Hide()
    End Sub

    Private Sub unlocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlocks.Click
        If iPhoneModel = "iPod Touch 2G" Then
            unlocks.Enabled = False
        End If
        unlocks.Image = My.Resources.UNLOCKHighLight1
        arrowgray.Hide()
        uncheck.Show()
        cpcheck.Hide()
        generalcheck.Hide()
        logocheck.Hide()
        buildcheck.Hide()
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bootlogos.MouseEnter
        bootlogos.Image = My.Resources.BootLogosHighLight1
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bootlogos.MouseLeave
        bootlogos.Image = My.Resources.BootLogosNorm1
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles build.MouseLeave
        build.Image = My.Resources.BuildNorm
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles build.MouseEnter
        build.Image = My.Resources.BuildHighlight
    End Sub

    Private Sub arrowgray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        If generalcheck.Visible = True Then
            egeneral.MdiParent = MDIMain
            egeneral.Show()
            Me.Hide()
        ElseIf cpcheck.Visible = True Then
            ecustomapps.MdiParent = MDIMain
            ecustomapps.Show()
            Me.Hide()
        ElseIf logocheck.Visible = True Then
            ebootlogos.MdiParent = MDIMain
            ebootlogos.Show()
            Me.Hide()
        ElseIf buildcheck.Visible = True Then
            ebuilding.MdiParent = MDIMain
            ebuilding.Show()
            Me.Hide()
        ElseIf uncheck.Visible = True Then
            eunlock.MdiParent = MDIMain
            eunlock.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub logo2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.Image = My.Resources.Flakeselect
    End Sub

    Private Sub logo2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseLeave
        logo2.Image = My.Resources.Flake
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

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bootlogos.Click
        bootlogos.Image = My.Resources.BootLogosNorm1
        arrowgray.Hide()
        uncheck.Hide()
        cpcheck.Hide()
        generalcheck.Hide()
        logocheck.Show()
        buildcheck.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles build.Click
        uncheck.Hide()
        arrowgray.Hide()
        cpcheck.Hide()
        generalcheck.Hide()
        logocheck.Hide()
        buildcheck.Show()
        build.Image = My.Resources.BuildHighlight

    End Sub

    Private Sub General_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles General.DoubleClick
        egeneral.MdiParent = MDIMain
        egeneral.Show()
        Me.Hide()
    End Sub
    Private Sub cpackage_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpackage.DoubleClick
        ecustomapps.MdiParent = MDIMain
        ecustomapps.Show()
        Me.Hide()
    End Sub

    Private Sub bootlogos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bootlogos.DoubleClick
        ebootlogos.MdiParent = MDIMain
        ebootlogos.Show()
        Me.Hide()
    End Sub

    Private Sub build_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles build.DoubleClick
        ebuilding.MdiParent = MDIMain
        ebuilding.Show()
        Me.Hide()
    End Sub
    Private Sub eunlocks_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlocks.DoubleClick
        eunlock.MdiParent = MDIMain
        eunlock.Show()
        Me.Hide()
    End Sub
End Class