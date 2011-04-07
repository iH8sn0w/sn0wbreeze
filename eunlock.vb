Public Class eunlock
    Private Sub eunlock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = iPhoneModel
        Label3.Left = (Me.Width / 2) - (Label3.Width / 2)
        Label15.Text = "Your device is an: " & iPhoneModel
    End Sub
    Private Sub logo2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseEnter
        logo2.Image = My.Resources.Flakeselect
    End Sub

    Private Sub logo2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.MouseLeave
        logo2.Image = My.Resources.Flakeselect
    End Sub
    Private Sub Label15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.TextChanged
        Label15.Left = (Me.Width / 2) - (Label15.Width / 2)
    End Sub

    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        If This3GSisold = True Then
            ebootlogos.MdiParent = MDIMain
            ebootlogos.Show()
            Me.Hide()
        Else
            ecustomapps.MdiParent = MDIMain
            ecustomapps.Show()
            Me.Hide()
        End If
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
    Private Sub Label3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.TextChanged
        Label3.Left = (Me.Width / 2) - (Label3.Width / 2)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            MsgBox("NOTICE: By Upgrading to the iPad baseband, you will NOT be able to downgrade it back to a standard iPhone baseband and will have to continue on the custom firmware train!" & Chr(13) & Chr(13) & "You *may* also lose the GPS function of your phone!" & Chr(13) & Chr(13) & "You are voiding any Apple Warranties by doing this!", MsgBoxStyle.Critical)
            iWantziPadBB = True
        Else
            iWantziPadBB = False
        End If
    End Sub
End Class