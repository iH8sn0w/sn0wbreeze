Imports sn0wbreeze.MobileDevice
Imports sn0wbreeze.MobileDev1ce
Public Class Form1
    Private WithEvents downnao As System.ComponentModel.BackgroundWorker
    Private Sub arrowgray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        NORFlashDisabled = False
        IdentifyIPSW.MdiParent = MDIMain
        IdentifyIPSW.Show()
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub arrowgray_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseEnter
        arrow.Image = My.Resources.next_over1
    End Sub

    Private Sub arrowgray_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseLeave
        arrow.Image = My.Resources.next1
    End Sub

    Private Sub arrowgray_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseDown
        arrow.Image = My.Resources.next_press1
    End Sub

    Private Sub arrowgray_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseUp
        arrow.Image = My.Resources.next_over1
    End Sub

    Private Sub logo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.Click
        About.MdiParent = MDIMain
        About.Show()
        About.BringToFront()
        Me.Enabled = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.MdiParent = MDIMain
        About.Show()
        About.BringToFront()
        Me.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DFU.MdiParent = MDIMain
        DFU.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Credits.Show()
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.GPL_button_over
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.GPL_button_black
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Credits.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
