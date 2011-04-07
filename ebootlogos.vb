Public Class ebootlogos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Result
        BootLogo = FileOpenDialog("*.png", "Desktop")
        If BootLogo = "" Then Exit Sub

        'check folder exists
        If Directory_Exists(tempPath) = False Then Create_Directory(tempPath)

        'copy new file
        Result = File_Copy(BootLogo, tempPath & "\BootLogoCustom.png", True)

        If File_Exists(BootLogo) = True Then
            'get file size
            Dim Bmp As Bitmap = Bitmap.FromFile(BootLogo)
            If GetFileSize(BootLogo) > 100000 And Bmp.Width > 320 And Bmp.Height > 480 Then
                MsgBox("The Image's file size is too big, and the image size is larger than 320 x 480 pixels", MsgBoxStyle.Information)
                Exit Sub
            End If
            If GetFileSize(BootLogo) > 100000 Then
                MsgBox("Image File size is too large", MsgBoxStyle.Information)
                Exit Sub
            End If

            'get dimensions
            If Bmp.Width > 320 Or Bmp.Height > 480 Then
                MsgBox("Image must not be larger than 320 x 480 pixels", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Bmp.Height = 320 And Bmp.Height = 480 Then
                picBootLogo.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            If Bmp.Width < 320 And Bmp.Height < 480 Then
                picBootLogo.SizeMode = PictureBoxSizeMode.CenterImage
            End If
            If Bmp.Height > 463 Or Bmp.Width > 107 Then
                picBootLogo.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            Me.picBootLogo2.Visible = False
            Me.picBootLogo.ImageLocation = tempPath & "\BootLogoCustom.png"
            BootLogo = "BootLogoCustom.png"
        End If
    End Sub
    Private Function FileOpenDialog(ByVal strExtension As String, ByVal strInitDir As String) As String
        Dim oFileDialog As New System.Windows.Forms.OpenFileDialog()
        'Dim strfilter As String = BuildFilter(strExtension)

        FileOpenDialog = ""

        With oFileDialog
            .Filter = "PNG Image File (*.png) |*.png;"
            .DefaultExt = strExtension
            .InitialDirectory = strInitDir
            .ShowDialog()
            If Windows.Forms.DialogResult.OK Then
                FileOpenDialog = .FileName
            ElseIf Windows.Forms.DialogResult.Cancel Then
            End If
        End With

    End Function
    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click
        Expert.MdiParent = MDIMain
        Expert.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Result
        RecoveryLogo = FileOpenDialog("*.png", "Desktop")
        If RecoveryLogo = "" Then Exit Sub
        'check folder exists
        If Directory_Exists(tempPath) = False Then Create_Directory(tempPath)
        'copy new file
        Result = File_Copy(RecoveryLogo, tempPath & "\RecoveryLogoCustom.png", True)
        If File_Exists(RecoveryLogo) = True Then
            'get file size
            Dim Bmp As Bitmap = Bitmap.FromFile(RecoveryLogo)
            If GetFileSize(RecoveryLogo) > 100000 And Bmp.Width > 320 And Bmp.Height > 480 Then
                MsgBox("The Image's file size is too big, and the image size is larger than 320 x 480 pixels", MsgBoxStyle.Information)
                Exit Sub
            End If
            If GetFileSize(RecoveryLogo) > 102400 Then
                MsgBox("Image File size is too large", MsgBoxStyle.Information)
                Exit Sub
            End If
            'get dimensions
            If Bmp.Width > 320 Or Bmp.Height > 480 Then
                MsgBox("Image must not be larger than 320 x 480 pixels", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Bmp.Height = 320 And Bmp.Height = 480 Then
                picRecoveryLogo.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            If Bmp.Width < 320 And Bmp.Height < 480 Then
                picRecoveryLogo.SizeMode = PictureBoxSizeMode.CenterImage
            End If
            If Bmp.Height > 463 Or Bmp.Width > 107 Then
                picRecoveryLogo.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            '463, 107
            Me.picRecoveryLogo2.Visible = False
            Me.picRecoveryLogo.ImageLocation = tempPath & "\RecoveryLogoCustom.png"
            RecoveryLogo = "RecoveryLogoCustom.png"
            picRecoveryLogo2.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub ebootlogos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Expert.buildcheck.Hide()
        Expert.cpcheck.Hide()
        Expert.uncheck.Hide()
        Expert.generalcheck.Hide()
        Expert.logocheck.Hide()
        'load images if already selected
        If BootLogo = "BootLogoCustom.png" Then
            Me.picBootLogo2.Visible = False
            Me.picBootLogo.ImageLocation = tempPath & "\BootLogoCustom.png"
        End If

        If RecoveryLogo = "RecoveryLogoCustom.png" Then
            Me.picRecoveryLogo2.Visible = False
            Me.picRecoveryLogo.ImageLocation = tempPath & "\RecoveryLogoCustom.png"
        End If
        If iPhoneModel = "iPod Touch 3G" Or iPod2GModel = "MC" Or NORFlashDisabled = True Then
            picBootLogo.Visible = False
            picBootLogo2.Visible = False
            picRecoveryLogo.Visible = False
            picRecoveryLogo2.Visible = False
            UseCustomRecoveryLogo = False
            UseCustomBootLogo = False
            chkUseCustomBootLogo.Checked = False
            chkUseCustomRecoveryLogo.Checked = False
            Button2.Enabled = False
            Button1.Enabled = False
        Else
            picBootLogo.Visible = True
            picBootLogo2.Visible = True
            picRecoveryLogo.Visible = True
            picRecoveryLogo2.Visible = True
            UseCustomRecoveryLogo = True
            UseCustomBootLogo = True
            chkUseCustomBootLogo.Checked = True
            chkUseCustomRecoveryLogo.Checked = True
            Button2.Enabled = True
            Button1.Enabled = True
        End If
        If iBootyMethod = True Then
            Label1.Visible = False
            chkUseCustomRecoveryLogo.Checked = False
            chkUseCustomRecoveryLogo.Visible = False
            picRecoveryLogo2.Visible = False
            picRecoveryLogo.Visible = False
            Button2.Visible = False
        Else
            Label1.Visible = True
            Button2.Visible = True
            chkUseCustomRecoveryLogo.Checked = True
            chkUseCustomRecoveryLogo.Visible = True
            picRecoveryLogo2.Visible = True
            picRecoveryLogo.Visible = True
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

    Private Sub arrow_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseDown
        arrow.Image = My.Resources.arrowpress
    End Sub

    Private Sub arrow_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.MouseLeave
        arrow.Image = My.Resources.Arrow
    End Sub

    Private Sub arrow_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles arrow.MouseUp
        arrow.Image = My.Resources.Arrowhilite
    End Sub
    Private Sub chkUseCustomBootLogo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseCustomBootLogo.CheckedChanged
        If iPhoneModel = "iPod Touch 3G" Or iPod2GModel = "MC" Then
            chkUseCustomRecoveryLogo.Checked = False
            chkUseCustomBootLogo.Checked = False
            Button1.Enabled = False
            Button2.Enabled = False
        End If
        If chkUseCustomBootLogo.Checked = True Then
            picBootLogo2.Image = My.Resources.Flake
            UseCustomBootLogo = True
            Button1.Enabled = True
        Else
            UseCustomBootLogo = False
            Button1.Enabled = False
        End If
    End Sub
    Private Sub chkUseCustomRecoveryLogo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseCustomRecoveryLogo.CheckedChanged
        If iPhoneModel = "iPod Touch 3G" Or iPod2GModel = "MC" Then
            chkUseCustomRecoveryLogo.Checked = False
            chkUseCustomBootLogo.Checked = False
            Button1.Enabled = False
        End If
        If chkUseCustomRecoveryLogo.Checked = True Then
            UseCustomRecoveryLogo = True
        Else
            UseCustomRecoveryLogo = False
        End If
    End Sub
End Class