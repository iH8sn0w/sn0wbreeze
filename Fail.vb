Public Class Fail

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

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

    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        Form1.Enabled = True
        Form1.MdiParent = MDIMain
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Fail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIMain.MenuStrip1.Enabled = True
        ipswFailed = False
        ExitFlag = False
        ipswBuilding = False
        iPhoneModel = ""
        ipsw = ""
        lblError.Text = ErrorMessage
        ErrorMessage = ""
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = My.Resources.Flakeselect

    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.Flake

    End Sub
End Class