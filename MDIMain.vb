Imports System.Windows.Forms


Public Class MDIMain

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Int32

    Private Sub MDIMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub MDIMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
        Application.Exit()
        Cleanup()
    End Sub

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "sn0wbreeze " & Check4Updates.sn0wbreezeVersion & " -- The xpwn GUI for Windows"
        Call SetMdiClientBorder(False)

        'extract required dll's to app folder
        'If File_Exists(My.Application.Info.DirectoryPath & "\Ionic.Zip.dll") = False Then SaveToDisk("Ionic.Zip.dll", My.Application.Info.DirectoryPath & "\Ionic.Zip.dll")

        'create temp folders
        tempPath2 = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"
        tempPath2 = tempPath2 & "\sn0wbreeze-iREB"
        tempPath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"
        tempPath = tempPath & "\sn0wbreeze"
        Folder_Delete(tempPath)
        Folder_Delete(tempPath2)
        Create_Directory(tempPath)
        'Create_Directory(tempPath & "\debsCustom\private\var\root\Media\Cydia\AutoInstall")
        Create_Directory(tempPath & "\debsCustom")
        Create_Directory(tempPath & "\repos")
        Create_Directory(tempPath2)
        Form1.MdiParent = Me
        Credits.MdiParent = Me
        Form1.Show()
        About.MdiParent = Me
        About.Show()
        Form1.Enabled = False
        About.BringToFront()
        DFU.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Cleanup()
        End
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        If About.Visible = False Then
            About.MdiParent = Me
            About.Show()
        End If

    End Sub
    Private Sub CreditsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditsToolStripMenuItem.Click
        If Credits.Visible = False Then
            Credits.MdiParent = Me
            Credits.Show()
        End If
    End Sub
    Private Sub IRCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IRCToolStripMenuItem.Click
        Dim webAddress As String = "irc://irc.chronic-dev.org/ih8sn0w"
        Process.Start(webAddress)
    End Sub

    Private Sub TwitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwitterToolStripMenuItem.Click
        Dim webAddress As String = "http://twitter.com/ih8sn0w"
        Process.Start(webAddress)
    End Sub

    Private Sub ForumsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForumsToolStripMenuItem.Click
        Dim webAddress As String = "http://ih8sn0wforums.com"
        Process.Start(webAddress)
    End Sub
    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Check4Updates.Show()
        Check4Updates.MdiParent = Me
    End Sub

    Private Sub TempToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DFU.Show()
        DFU.MdiParent = Me
    End Sub
    Private Sub RunIREBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunIREBToolStripMenuItem.Click
        Dim Answer
        Answer = MsgBox("Do you want to run iREB for an Apple TV 2?", MsgBoxStyle.YesNo, "iREB")
        If Answer = vbYes Then
            PreviousModel = "Apple TV 2"
        Else
            PreviousModel = ""
        End If
        iPhoneModel = ""
        NORFlashDisabled = False
        Expert.Label2.Text = " "
        DFU.MdiParent = Me
        DFU.Show()
    End Sub
End Class
