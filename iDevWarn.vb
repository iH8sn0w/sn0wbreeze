Public Class iDevWarn
    Private Sub iDevWarn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IdentifyIPSW.Enabled = False
        MDIMain.MenuStrip1.Enabled = False
        If iPhoneModel = "iPhone 3GS" Then
            Button1.Text = "Old-bootrom"
            Button2.Text = "New-Bootrom/I don't know"
            iPhone3GS.Visible = True
        ElseIf iPhoneModel = "iPod Touch 2G" Then
            Button1.Text = "MB"
            Button2.Text = "MC"
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If iPhoneModel = "iPhone 3GS" Then
            This3GSisold = False
        ElseIf iPhoneModel = "iPod Touch 2G" Then
            ThisiPodisMB = False
        End If
        Restore()
    End Sub
    Public Sub Restore()
        MDIMain.MenuStrip1.Enabled = True
        IdentifyIPSW.Enabled = True
        Me.Dispose()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If iPhoneModel = "iPhone 3GS" Then
            This3GSisold = True
        ElseIf iPhoneModel = "iPod Touch 2G" Then
            ThisiPodisMB = True
        End If
        Restore()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        iDetector.MdiParent = MDIMain
        iDetector.Show()
        Me.Hide()
    End Sub
End Class