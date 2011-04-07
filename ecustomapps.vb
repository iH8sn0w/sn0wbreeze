Imports System.IO

Public Class ecustomapps
    Public lvi As ListViewItem
    Public lviIndex As Int32
    Public RepoNumber As Int32
    Public NumberDoneSoFar As Int32

    Private Sub FillSourcesCombo()
        ComboSources.Items.Clear()
        For Each item In lvManageSources.Items
            'Fill the combo
            ComboSources.Items.Add(item.text)
        Next
    End Sub

    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click

        CustomApps = ""
        For Each item In lvSelectPackages.Items
            If item.Checked = True Then CustomApps = CustomApps & item.SubItems(4).Text & "¬" 'MsgBox(item.SubItems(4).Text)
        Next

        'remove ¬ at end
        If CustomApps <> "" Then CustomApps = CustomApps.Substring(0, (Len(CustomApps) - 1))

        Expert.MdiParent = MDIMain
        Expert.Show()
        Me.Close()

    End Sub
    Private Sub ecustomapps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Select()
        'btnAddSource.Enabled = False
        lvSelectPackages.Items.Clear()

        'add saved used added repos
        If My.Settings.CustomRepos <> "" Then
            Dim arrRepos = Split(My.Settings.CustomRepos, ",")
            For Each Repo In arrRepos
                If Repo <> "" Then lvManageSources.Items.Add(Repo)
            Next
        End If

        FillSourcesCombo()
        ComboSources.SelectedIndex = 0

        'prevent column resize
        SysHdr32Handle = GetWindow(lvSelectPackages.Handle, GW_CHILD)
        ListViewHeader1 = New ListViewHeader(SysHdr32Handle)
        SysHdr32Handle2 = GetWindow(lvDownload.Handle, GW_CHILD)
        ListViewHeader2 = New ListViewHeader(SysHdr32Handle2)
        SysHdr32Handle3 = GetWindow(lvManageSources.Handle, GW_CHILD)
        ListViewHeader3 = New ListViewHeader(SysHdr32Handle3)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
    End Sub


    Private Sub btnSelectSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSource.Click
        Try
            If lvDownload.SelectedItems.Count = 0 Then Exit Sub

            Dim errMsg As String = ""

            Try
                'lvDownload.SelectedItems.Item(0).SubItems(4).Text = "Downloading..."
                Cursor = Cursors.WaitCursor

                Dim strFilename As String = lvDownload.SelectedItems.Item(0).SubItems(5).Text '.Substring(lvDownload.SelectedItems.Item(0).SubItems(5).Text.IndexOf("/") + 1)

                'trim from begining if exists
                Dim MyChar As Char() = {"/"}
                If strFilename.Substring(0, 3) = ".//" Then
                    strFilename = strFilename.TrimStart(".", "/")
                Else
                    'Dim MyChar As Char() = {".", "/"}
                    'Dim MyChar As Char() = {"/"}
                    strFilename = strFilename.TrimStart(MyChar)
                End If

                Dim strSource As String = ""
                'If strFilename.IndexOf(".") = 0 Then
                strSource = ComboSources.Text
                'Else
                'strSource = ComboSources.Text.Substring(0, ComboSources.Text.IndexOf("/Packages"))
                'End If


                Dim DownloadURL As String


                'fix for zodttd
                'If strSource = "http://cydia.zodttd.com/repo/cydia/dists/stable/main/binary-iphoneos-arm" Then
                'strSource = "http://cydia.zodttd.com/repo/cydia"
                'End If

                'fix for smxy
                If strSource = "http://repo.smxy.org/cydia/apt/dists/stable/main/binary-iphoneos-arm" Then
                    strSource = "http://repo.smxy.org/cydia/apt"
                End If

                'fix for hackndev
                If strSource = "http://iphone.hackndev.org/apt/dists/hnd/main/binary-iphoneos-arm" Then
                    strSource = "http://iphone.hackndev.org/apt"
                End If

                DownloadURL = strSource & "/" & strFilename

                'check folder exists
                If Directory_Exists(tempPath & "\debsCustom") = False Then Create_Directory(tempPath & "\debsCustom")

                Dim client = New System.Net.WebClient()
                client.Headers.Add("user-agent", "Telesphoreo APT-HTTP/1.0.592")
                'Dim Deb = client.DownloadString(DownloadURL)

                client.DownloadFile(DownloadURL, tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename))

                Dim lSingleItem As ListViewItem

                'Fill The list view
                lSingleItem = lvSelectPackages.Items.Add(lvDownload.SelectedItems.Item(0).Text)
                lSingleItem.Checked = True
                lSingleItem.SubItems.Add(lvDownload.SelectedItems.Item(0).SubItems(1).Text)
                lSingleItem.SubItems.Add(lvDownload.SelectedItems.Item(0).SubItems(2).Text)
                lSingleItem.SubItems.Add(lvDownload.SelectedItems.Item(0).SubItems(3).Text)
                lSingleItem.SubItems.Add(NameOnlyFromFullPath2(strFilename))
                'lSingleItem.SubItems.Add(lvDownload.SelectedItems.Item(0).SubItems(6).Text)


                'Download depends
                Dim strDepends As String = ""
                If lvDownload.SelectedItems.Item(0).SubItems(6).Text <> "" Then
                    Dim arrDepends
                    arrDepends = Split(lvDownload.SelectedItems.Item(0).SubItems(6).Text, ",")

                    'loop through depends
                    For Each item In arrDepends
                        'loop through apps to find it
                        For Each package In lvDownload.Items
                            Dim strItem
                            strItem = item.ToString.IndexOf("(")
                            If item.ToString.IndexOf("(") = -1 Then
                                strItem = LCase(Trim(item))
                            Else
                                strItem = LCase(Trim(item.ToString.Substring(0, item.ToString.IndexOf("(") - 1)))
                            End If

                            'match name then download
                            If LCase(Trim(lvDownload.Items(package.index).SubItems(7).Text)) = strItem Then
                                strFilename = lvDownload.Items(package.index).SubItems(5).Text
                                strFilename = strFilename.TrimStart(MyChar)
                                DownloadURL = strSource & "/" & strFilename
                                If File_Exists(tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename)) = False Then client.DownloadFile(DownloadURL, tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename))
                                'create list of depends
                                strDepends = strDepends & NameOnlyFromFullPath2(strFilename) & ","



                                'depend depends
                                If lvDownload.Items(package.index).SubItems(6).Text <> "" Then
                                    Dim arrDepends2
                                    arrDepends2 = Split(lvDownload.Items(package.index).SubItems(6).Text, ",")

                                    'loop through depends
                                    For Each item2 In arrDepends2
                                        'loop through apps to find it
                                        For Each package2 In lvDownload.Items
                                            Dim strItem2
                                            strItem2 = item2.ToString.IndexOf("(")
                                            If item2.ToString.IndexOf("(") = -1 Then
                                                strItem2 = LCase(Trim(item2))
                                            Else
                                                strItem2 = LCase(Trim(item2.ToString.Substring(0, item2.ToString.IndexOf("(") - 1)))
                                            End If

                                            'match name then download
                                            If LCase(Trim(lvDownload.Items(package2.index).SubItems(7).Text)) = strItem2 Then
                                                strFilename = lvDownload.Items(package2.index).SubItems(5).Text
                                                strFilename = strFilename.TrimStart(MyChar)
                                                DownloadURL = strSource & "/" & strFilename
                                                If File_Exists(tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename)) = False Then client.DownloadFile(DownloadURL, tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename))
                                                'create list of depends
                                                strDepends = strDepends & NameOnlyFromFullPath2(strFilename) & ","

                                                'depend depends depends
                                                If lvDownload.Items(package2.index).SubItems(6).Text <> "" Then
                                                    Dim arrDepends3
                                                    arrDepends3 = Split(lvDownload.Items(package2.index).SubItems(6).Text, ",")

                                                    'check if already included
                                                    For Each item3 In arrDepends3
                                                        'loop through apps to find it
                                                        For Each package3 In lvDownload.Items
                                                            Dim strItem3
                                                            strItem3 = item2.ToString.IndexOf("(")
                                                            If item3.ToString.IndexOf("(") = -1 Then
                                                                strItem3 = LCase(Trim(item3))
                                                            Else
                                                                strItem3 = LCase(Trim(item3.ToString.Substring(0, item3.ToString.IndexOf("(") - 1)))
                                                            End If

                                                            'match name then download
                                                            If LCase(Trim(lvDownload.Items(package3.index).SubItems(7).Text)) = strItem3 Then

                                                                'check if already downloaded
                                                                If strDepends.IndexOf(strItem3) <> -1 Then Exit For

                                                                strFilename = lvDownload.Items(package3.index).SubItems(5).Text
                                                                strFilename = strFilename.TrimStart(MyChar)
                                                                DownloadURL = strSource & "/" & strFilename
                                                                If File_Exists(tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename)) = False Then client.DownloadFile(DownloadURL, tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename))
                                                                'create list of depends
                                                                strDepends = strDepends & NameOnlyFromFullPath2(strFilename) & ","

                                                                'depend depends depends depends
                                                                If lvDownload.Items(package3.index).SubItems(6).Text <> "" Then
                                                                    Dim arrDepends4
                                                                    arrDepends4 = Split(lvDownload.Items(package3.index).SubItems(6).Text, ",")

                                                                    'check if already included
                                                                    For Each item4 In arrDepends4
                                                                        'loop through apps to find it
                                                                        For Each package4 In lvDownload.Items
                                                                            Dim strItem4
                                                                            strItem4 = item4.ToString.IndexOf("(")
                                                                            If item4.ToString.IndexOf("(") = -1 Then
                                                                                strItem4 = LCase(Trim(item4))
                                                                            Else
                                                                                strItem4 = LCase(Trim(item4.ToString.Substring(0, item4.ToString.IndexOf("(") - 1)))
                                                                            End If

                                                                            'match name then download
                                                                            If LCase(Trim(lvDownload.Items(package4.index).SubItems(7).Text)) = strItem4 Then

                                                                                'check if already downloaded
                                                                                If strDepends.IndexOf(strItem4) <> -1 Then Exit For

                                                                                strFilename = lvDownload.Items(package4.index).SubItems(5).Text
                                                                                strFilename = strFilename.TrimStart(MyChar)
                                                                                DownloadURL = strSource & "/" & strFilename
                                                                                If File_Exists(tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename)) = False Then client.DownloadFile(DownloadURL, tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename))
                                                                                'create list of depends
                                                                                strDepends = strDepends & NameOnlyFromFullPath2(strFilename) & ","

                                                                                'depend depends depends depends depends
                                                                                If lvDownload.Items(package4.index).SubItems(6).Text <> "" Then
                                                                                    Dim arrDepends5
                                                                                    arrDepends5 = Split(lvDownload.Items(package4.index).SubItems(6).Text, ",")

                                                                                    'check if already included
                                                                                    For Each item5 In arrDepends5
                                                                                        'loop through apps to find it
                                                                                        For Each package5 In lvDownload.Items
                                                                                            Dim strItem5
                                                                                            strItem5 = item5.ToString.IndexOf("(")
                                                                                            If item5.ToString.IndexOf("(") = -1 Then
                                                                                                strItem5 = LCase(Trim(item5))
                                                                                            Else
                                                                                                strItem5 = LCase(Trim(item5.ToString.Substring(0, item5.ToString.IndexOf("(") - 1)))
                                                                                            End If

                                                                                            'match name then download
                                                                                            If LCase(Trim(lvDownload.Items(package5.index).SubItems(7).Text)) = strItem5 Then

                                                                                                'check if already downloaded
                                                                                                If strDepends.IndexOf(strItem5) <> -1 Then Exit For

                                                                                                strFilename = lvDownload.Items(package5.index).SubItems(5).Text
                                                                                                strFilename = strFilename.TrimStart(MyChar)
                                                                                                DownloadURL = strSource & "/" & strFilename
                                                                                                If File_Exists(tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename)) = False Then client.DownloadFile(DownloadURL, tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename))
                                                                                                'create list of depends
                                                                                                strDepends = strDepends & NameOnlyFromFullPath2(strFilename) & ","

                                                                                                'depend depends depends depends depends depends
                                                                                                If lvDownload.Items(package5.index).SubItems(6).Text <> "" Then
                                                                                                    Dim arrDepends6
                                                                                                    arrDepends6 = Split(lvDownload.Items(package5.index).SubItems(6).Text, ",")

                                                                                                    'check if already included
                                                                                                    For Each item6 In arrDepends6
                                                                                                        'loop through apps to find it
                                                                                                        For Each package6 In lvDownload.Items
                                                                                                            Dim strItem6
                                                                                                            strItem6 = item6.ToString.IndexOf("(")
                                                                                                            If item6.ToString.IndexOf("(") = -1 Then
                                                                                                                strItem6 = LCase(Trim(item6))
                                                                                                            Else
                                                                                                                strItem6 = LCase(Trim(item6.ToString.Substring(0, item6.ToString.IndexOf("(") - 1)))
                                                                                                            End If

                                                                                                            'match name then download
                                                                                                            If LCase(Trim(lvDownload.Items(package6.index).SubItems(7).Text)) = strItem6 Then

                                                                                                                'check if already downloaded
                                                                                                                If strDepends.IndexOf(strItem6) <> -1 Then Exit For

                                                                                                                strFilename = lvDownload.Items(package6.index).SubItems(5).Text
                                                                                                                strFilename = strFilename.TrimStart(MyChar)
                                                                                                                DownloadURL = strSource & "/" & strFilename
                                                                                                                If File_Exists(tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename)) = False Then client.DownloadFile(DownloadURL, tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename))
                                                                                                                'create list of depends
                                                                                                                strDepends = strDepends & NameOnlyFromFullPath2(strFilename) & ","

                                                                                                                'depend depends depends depends depends depends depends
                                                                                                                If lvDownload.Items(package6.index).SubItems(6).Text <> "" Then
                                                                                                                    Dim arrDepends7
                                                                                                                    arrDepends7 = Split(lvDownload.Items(package6.index).SubItems(6).Text, ",")

                                                                                                                    'check if already included
                                                                                                                    For Each item7 In arrDepends7
                                                                                                                        'loop through apps to find it
                                                                                                                        For Each package7 In lvDownload.Items
                                                                                                                            Dim strItem7
                                                                                                                            strItem7 = item7.ToString.IndexOf("(")
                                                                                                                            If item7.ToString.IndexOf("(") = -1 Then
                                                                                                                                strItem7 = LCase(Trim(item7))
                                                                                                                            Else
                                                                                                                                strItem7 = LCase(Trim(item7.ToString.Substring(0, item7.ToString.IndexOf("(") - 1)))
                                                                                                                            End If

                                                                                                                            'match name then download
                                                                                                                            If LCase(Trim(lvDownload.Items(package7.index).SubItems(7).Text)) = strItem7 Then

                                                                                                                                'check if already downloaded
                                                                                                                                If strDepends.IndexOf(strItem7) <> -1 Then Exit For

                                                                                                                                strFilename = lvDownload.Items(package7.index).SubItems(5).Text
                                                                                                                                strFilename = strFilename.TrimStart(MyChar)
                                                                                                                                DownloadURL = strSource & "/" & strFilename
                                                                                                                                If File_Exists(tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename)) = False Then client.DownloadFile(DownloadURL, tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename))
                                                                                                                                'create list of depends
                                                                                                                                strDepends = strDepends & NameOnlyFromFullPath2(strFilename) & ","

                                                                                                                                'depend depends depends depends depends depends depends depends
                                                                                                                                If lvDownload.Items(package7.index).SubItems(6).Text <> "" Then
                                                                                                                                    'there is another depend but how far do we go???
                                                                                                                                    If errMsg = "" Then
                                                                                                                                        errMsg = lvDownload.Items(package7.index).Text
                                                                                                                                    Else
                                                                                                                                        'only add if not already in list
                                                                                                                                        If errMsg.IndexOf(lvDownload.Items(package7.index).Text) = -1 Then
                                                                                                                                            errMsg = errMsg & ", " & lvDownload.Items(package7.index).Text
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                    'MsgBox("Error adding depend - " & lvDownload.Items(package7.index).Text & vbNewLine & "Please download manually", MsgBoxStyle.Critical)
                                                                                                                                End If




                                                                                                                                Exit For
                                                                                                                            End If
                                                                                                                        Next
                                                                                                                    Next
                                                                                                                End If




                                                                                                                Exit For
                                                                                                            End If
                                                                                                        Next
                                                                                                    Next
                                                                                                End If




                                                                                                Exit For
                                                                                            End If
                                                                                        Next
                                                                                    Next
                                                                                End If




                                                                                Exit For
                                                                            End If
                                                                        Next
                                                                    Next
                                                                End If





                                                                Exit For
                                                            End If
                                                        Next
                                                    Next
                                                End If



                                                Exit For
                                            End If
                                        Next
                                    Next
                                End If



                                Exit For
                            End If
                        Next
                    Next

                End If

                'show errors
                If errMsg <> "" Then
                    'MsgBox("Error adding depends - " & errMsg & vbNewLine & "Please download manually", MsgBoxStyle.Critical)
                End If

                'remove , at end
                If strDepends <> "" Then strDepends = strDepends.Substring(0, Len(strDepends) - 1)
                lSingleItem.SubItems.Add(strDepends)

                lvDownload.SelectedItems.Item(0).SubItems(4).Text = "Complete"

                Cursor = Cursors.Default
            Catch ex As Exception
                Cursor = Cursors.Default
                lvDownload.SelectedItems.Item(0).SubItems(4).Text = "Error"
                MsgBox(Err.Description, MsgBoxStyle.Critical, "Fetch error")
            End Try
        Catch ex As Exception
            MsgBox("An unknown error has occured, please try again.", MsgBoxStyle.Exclamation, "Fetch Error")
        End Try
    End Sub

    Private Sub btnAddSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSource.Click
        If txtSource.Text <> "" Then
            Cursor = Cursors.WaitCursor

            If LCase(txtSource.Text.Substring(0, 7)) <> "http://" Then
                txtSource.Text = "http://" & txtSource.Text
            End If

            If CheckPackagesBz2URL(txtSource.Text, txtSource.Text.Substring(7, 8)) = True Then
                lvManageSources.Items.Add(txtSource.Text)
                FillSourcesCombo()
                If My.Settings.CustomRepos = "" Then
                    My.Settings.CustomRepos = txtSource.Text

                Else
                    My.Settings.CustomRepos = My.Settings.CustomRepos & "," & txtSource.Text
                End If
                My.Settings.Save()
                txtSource.Text = "http://"
            Else
                If CheckPackagesGzURL(txtSource.Text, ComboSources.Text.Substring(7, 8)) = True Then
                    lvManageSources.Items.Add(txtSource.Text)
                    FillSourcesCombo()
                    If My.Settings.CustomRepos = "" Then
                        My.Settings.CustomRepos = txtSource.Text
                    Else
                        My.Settings.CustomRepos = My.Settings.CustomRepos & "," & txtSource.Text
                    End If
                    My.Settings.Save()
                    txtSource.Text = "http://"
                Else
                    If CheckPackagesURL(txtSource.Text, txtSource.Text.Substring(7, 8)) = True Then
                        lvManageSources.Items.Add(txtSource.Text)
                        FillSourcesCombo()
                        If My.Settings.CustomRepos = "" Then
                            My.Settings.CustomRepos = txtSource.Text
                        Else
                            My.Settings.CustomRepos = My.Settings.CustomRepos & "," & txtSource.Text
                        End If
                        My.Settings.Save()
                        txtSource.Text = "http://"
                    Else
                        Cursor = Cursors.Default
                        MsgBox("Invalid URL, No packages found", MsgBoxStyle.Critical, "sn0wbreeze")
                    End If
                End If
            End If
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub lvSelectPackages_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvSelectPackages.ColumnClick
        SortListview(Me.lvSelectPackages, e)
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


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'If lviIndex = "" Then lviIndex = 0

        If lvDownload.View = View.Details AndAlso lvDownload.Items.Count > 0 Then

            lvDownload.SelectedItems.Clear()

            lvi = lvDownload.FindItemWithText(txtDownloadSearch.Text, True, lviIndex)
            If lvi IsNot Nothing Then
                lvDownload.Items(lvi.Index).Selected = True
                lvDownload.Items(lvi.Index).EnsureVisible()
                lviIndex = lvi.Index + 1
            End If

        End If

    End Sub

    Private Sub txtDownloadSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDownloadSearch.TextChanged

        If txtDownloadSearch.Text = "" Then lviIndex = 0

        If lvDownload.View = View.Details AndAlso lvDownload.Items.Count > 0 Then

            lvDownload.SelectedItems.Clear()

            lvi = lvDownload.FindItemWithText(txtDownloadSearch.Text, True, lviIndex)
            If lvi IsNot Nothing Then
                lvDownload.Items(lvi.Index).Selected = True
                lvDownload.Items(lvi.Index).EnsureVisible()
                'lviIndex = lvi.Index + 1
            End If

            'For ix As Int32 = 0 To lvDownload.Items.Count - 1
            'Dim ls As String = lvDownload.Items(ix).Text
            'If String.Compare(ls.Substring(0, txtDownloadSearch.Text.Length), txtDownloadSearch.Text, True) = 0 Then
            'If ls.Contains(txtDownloadSearch.Text) = True Then
            'lvDownload.Items(ix).Selected = True
            'lvDownload.Items(ix).EnsureVisible()
            'Exit For
            'End If
            'Next ix

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim debs
        Dim debFileName
        debs = FileOpenDialog("*.deb", "Desktop")

        If debs IsNot Nothing Then

            For Each deb In debs
                debFileName = NameOnlyFromFullPath(deb)

                File_Copy(deb, tempPath & "\debsCustom\" & debFileName, True)

                Dim lSingleItem As ListViewItem

                'Fill The list view
                lSingleItem = lvSelectPackages.Items.Add(debFileName.Substring(0, (Len(debFileName) - 4)))
                lSingleItem.SubItems.Add("")
                lSingleItem.SubItems.Add("")
                lSingleItem.SubItems.Add(FormatNumber((GetFileSize(tempPath & "\debsCustom\" & debFileName) / 1024) / 1024, 2) & " MB")
                lSingleItem.SubItems.Add(debFileName)
                lSingleItem.SubItems.Add("")
            Next
        End If
    End Sub

    Private Function FileOpenDialog(ByVal strExtension As String, ByVal strInitDir As String)

        Dim oFileDialog As New System.Windows.Forms.OpenFileDialog()
        'Dim strfilter As String = BuildFilter(strExtension)

        FileOpenDialog = Nothing

        With oFileDialog
            .Filter = "Debian files (*.deb)|*.deb;"
            .DefaultExt = strExtension
            .Multiselect = True
            .InitialDirectory = strInitDir
            .ShowDialog()
            If Windows.Forms.DialogResult.OK Then
                FileOpenDialog = .FileNames
            ElseIf Windows.Forms.DialogResult.Cancel Then
            End If
        End With

    End Function

    Private Sub lvManageSources_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvManageSources.ColumnClick
        SortListview(Me.lvManageSources, e)
    End Sub

    Private Sub lvManageSources_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvManageSources.SelectedIndexChanged
        On Error Resume Next
        Dim strRepo As String = lvManageSources.SelectedItems.Item(0).Text

        If My.Settings.CustomRepos.IndexOf(strRepo) = -1 Then
            btnDeleteRepo.Enabled = False
        Else
            btnDeleteRepo.Enabled = True
        End If
    End Sub

    Private Sub lvDownload_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvDownload.ColumnClick
        SortListview(Me.lvDownload, e)
    End Sub

    Private Sub txtDownloadSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDownloadSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.Select()
        End If
    End Sub

    Private Sub btnDeleteRepo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRepo.Click
        If lvManageSources.SelectedItems.Count = 0 Then Exit Sub

        Dim strRepo As String = lvManageSources.SelectedItems.Item(0).Text

        Dim Answer = MsgBox("Are you sure you want to delete " & strRepo, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "sn0wbreeze")

        If Answer = vbYes Then
            lvManageSources.Items(lvManageSources.SelectedItems.Item(0).Index).Remove()
            Dim arrCustomRepo = Split(My.Settings.CustomRepos, ",")
            Dim strCustomRepo As String = ""

            'remove repo from settings
            For Each repo In arrCustomRepo
                If Not repo = strRepo And repo = "" Then
                    If strCustomRepo = "" Then
                        strCustomRepo = repo
                    Else
                        strCustomRepo = strCustomRepo & "," & repo
                    End If
                End If
            Next

            My.Settings.CustomRepos = strCustomRepo
            My.Settings.Save()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim i As Int32 = 1
        Dim Section As String = ""
        Dim SectionData As String = ""
        Dim Location As String
        Dim Package As String = ""
        txtDownloadSearch.Text = ""
        Try
            Cursor = Cursors.WaitCursor

            Location = ComboSources.Text

            If File_Exists(tempPath & "\repos\" & ComboSources.Text.Substring(7, 8) & ".txt") = True Then
                'file exists so load from file
                Package = GetFileContents(tempPath & "\repos\" & ComboSources.Text.Substring(7, 8) & ".txt")

            Else
                'doesn't exist so download
                If CheckPackagesBz2URL(ComboSources.Text, ComboSources.Text.Substring(7, 8)) = True Then
                    Package = GetFileContents(tempPath & "\repos\" & ComboSources.Text.Substring(7, 8) & ".txt")
                Else
                    If CheckPackagesGzURL(ComboSources.Text, ComboSources.Text.Substring(7, 8)) = True Then
                        Package = GetFileContents(tempPath & "\repos\" & ComboSources.Text.Substring(7, 8) & ".txt")
                    Else
                        If CheckPackagesURL(ComboSources.Text, ComboSources.Text.Substring(7, 8)) = True Then
                            Package = GetFileContents(tempPath & "\repos\" & ComboSources.Text.Substring(7, 8) & ".txt")
                        Else
                            Cursor = Cursors.Default
                            MsgBox("Invalid URL, No packages found", MsgBoxStyle.Critical, "sn0wbreeze")
                        End If
                    End If
                End If

                'Dim client = New System.Net.WebClient()
                'client.Headers.Add("user-agent", "Telesphoreo APT-HTTP/1.0.592")
                'Package = client.DownloadString(Location)

            End If




            Dim Packages()
            Dim PackageDetails()

            Dim strPackage As String = ""
            Dim strVersion As String = ""
            Dim strArchitecture As String = ""
            Dim strEssential As String = ""
            Dim strMaintainer As String = ""
            Dim strInstalledSize As String = ""
            Dim strDepends As String = ""
            Dim strFilename As String = ""
            Dim strSize As Int32 = 0
            Dim strMD5sum As String = ""
            Dim strSection As String = ""
            Dim strPriority As String = ""
            Dim strHomepage As String = ""
            Dim strDescription As String = ""
            Dim strName As String = ""
            Dim strDepiction As String = ""
            Dim strTag As String = ""

            'split in to packages
            Packages = Split(Package, ChrW(10) & ChrW(10))

            lvDownload.Items.Clear()
            Dim lSingleItem As ListViewItem



            For Each item In Packages
                'On Error Resume Next

                'split package details
                PackageDetails = Split(item, ChrW(10))

                'get details of package
                For Each item2 In PackageDetails

                    If item2.IndexOf(": ") > 0 Then
                        Section = LCase(item2.Substring(0, item2.IndexOf(": ")))
                        'SectionData = Strings.Right(item2, Section.Length)
                        SectionData = item2
                        SectionData = item2.Substring(Section.Length + 2)

                        If Section = "package" Then strPackage = SectionData
                        If Section = "version" Then strVersion = SectionData
                        'If Section = "architecture" Then strArchitecture = SectionData
                        'If Section = "essential" Then strEssential = SectionData
                        'If Section = "maintainer" Then strMaintainer = SectionData
                        'If Section = "installed-size" Then strInstalledSize = SectionData
                        If Section = "depends" Then strDepends = SectionData
                        If Section = "filename" Then strFilename = SectionData
                        If Section = "size" Then strSize = SectionData
                        'If Section = "md5sum" Then strMD5sum = SectionData
                        'If Section = "section" Then strSection = SectionData
                        'If Section = "priority" Then strPriority = SectionData
                        'If Section = "homepage" Then strHomepage = SectionData
                        If Section = "description" Then strDescription = SectionData
                        If Section = "name" Then strName = SectionData
                        'If Section = "depiction" Then strDepiction = SectionData
                        'If Section = "tag" Then strTag = SectionData

                    End If

                    'Debug.Print(Section)
                Next

                If strName = "" Then strName = strPackage

                'Fill The list view
                lSingleItem = lvDownload.Items.Add(strName, i)
                lSingleItem.SubItems.Add(strDescription)
                lSingleItem.SubItems.Add(strVersion)
                lSingleItem.SubItems.Add(FormatNumber((strSize / 1024) / 1024, 2) & " MB")

                If File_Exists(tempPath & "\debsCustom\" & NameOnlyFromFullPath2(strFilename)) = True Then
                    lSingleItem.SubItems.Add("Complete")
                Else
                    lSingleItem.SubItems.Add("")
                End If

                lSingleItem.SubItems.Add(strFilename)
                lSingleItem.SubItems.Add(strDepends)
                lSingleItem.SubItems.Add(strPackage)

                strName = ""
                strDescription = ""
                strVersion = ""
                strSize = 0
                strFilename = ""

                i = i + 1
                'Debug.Print(line.Substring(0, line.IndexOf(":")))
                'Debug.Print(line)
            Next

            Cursor = Cursors.Default
        Catch ex As Exception
            'Cursor = Cursors.Default
            MsgBox(Err.Description)
        End Try
    End Sub
End Class