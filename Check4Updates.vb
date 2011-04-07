Public Class Check4Updates
    Public SiteVersion As String = ""
    Public sn0wbreezeVersion As String = "2.5.1"
    Private Sub Check4Updates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        PictureBox2.Visible = False
        Label1.Text = "Current running sn0wbreeze version : " & sn0wbreezeVersion
        CheckNet()
    End Sub

    Public Sub GoGoGadgetUpdater()
        File_Delete(tempPath & "\version.xml")
        Try
            Dim Check As String
            Check = "http://sbupdate.ih8sn0w.com/index.php"
            Dim clientCheck = New System.Net.WebClient()
            clientCheck.DownloadFile(Check, tempPath & "\version.xml")
        Catch ex As Exception
            Status.Text = "FAILED Contacting sn0wbreeze's Server"
            Status.Left = (Me.Width / 2) - (Status.Width / 2)
            MsgBox("Error 3 : We have failed trying to connect to sn0wbreeze's server!", MsgBoxStyle.Critical)
            Me.Close()
            Form1.Enabled = True
            Me.Dispose()
            Exit Sub
        End Try
        Dim LoadFile As String
        LoadFile = tempPath & "\version.xml"
        RichTextBox1.LoadFile(LoadFile, _
RichTextBoxStreamType.PlainText)
        SiteVersion = RichTextBox1.Text
        GoGoGadgetChess()
    End Sub
    Public Sub GoGoGadgetChess()
        'Logic fun
        PictureBox1.Visible = False
        Status.Text = "Update Results :"
        Status.Left = (Me.Width / 2) - (Status.Width / 2)
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label2.Text = "Latest sn0wbreeze available : " & SiteVersion
        If SiteVersion = sn0wbreezeVersion Then
            Label3.Text = "* You are running the latest sn0wbreeze."
            Label3.ForeColor = Color.Lime
            PictureBox2.Visible = True
            PictureBox2.Image = My.Resources.reflectionImage2
        Else
            Label3.Text = "* A newer sn0wbreeze is available."
            Label3.ForeColor = Color.Red
            PictureBox2.Visible = True
            PictureBox2.Image = My.Resources.X
            Dim Answer
            Answer = MsgBox("sn0wbreeze " & SiteVersion & " is available for download." & Chr(13) & Chr(13) & "Would you like to download it?", MsgBoxStyle.YesNo, "New sn0wbreeze is available!")
            If Answer = vbYes Then Call GoGoGadgetDownloader()
        End If
    End Sub
    Public Sub GoGoGadgetDownloader()
        Process.Start("http://sn0wbreeze.ih8sn0w.com")
        Application.Exit()
        Me.Dispose()
        Exit Sub
    End Sub
    Public Sub CheckNet()
        Status.Text = "Contacting sn0wbreeze Server..."
        Status.Left = (Me.Width / 2) - (Status.Width / 2)
        GoGoGadgetUpdater()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        MDIMain.MenuStrip1.Enabled = True
        Form1.Enabled = True
        Me.Dispose()
    End Sub

End Class