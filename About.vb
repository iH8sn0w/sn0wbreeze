Public Class About
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Credits.MdiParent = MDIMain
        Credits.Show()
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Check4Updates.Show()
        Check4Updates.MdiParent = MDIMain
        Me.Dispose()
    End Sub

    Private Sub Startup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        MDIMain.MenuStrip1.Enabled = False
    End Sub
End Class