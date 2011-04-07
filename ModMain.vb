'Imports Ionic.Zip
Imports ICSharpCode.SharpZipLib.Core
Imports ICSharpCode.SharpZipLib.BZip2
Imports ICSharpCode.SharpZipLib.GZip
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Module ModMain
    'added by w3st05
    Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Public Const MAX_PATH As Int32 = 256
    Public Delegate Sub WaitCallBack(ByVal State As Object)

    Declare Auto Function GetWindowLong Lib "user32" (ByVal hWnd As System.IntPtr, ByVal nIndex As Int32) As Long
    Declare Auto Function SetWindowLong Lib "user32" (ByVal hWnd As System.IntPtr, ByVal nIndex As Int32, ByVal dwNewLong As Long) As Long
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200

    'progress form
    Public ProgressExit As Boolean = False
    Public iDevLoaded As Boolean = False
    Public ProgressTop As Int32
    Public ProgressLeft As Int32

    'for ipsw build
    Public ExitFlag As Boolean = False
    Public ipswBuilding As Boolean = False
    Public ipswFailed As Boolean = False
    Public iDidntCheck As Boolean = False

    'ipsw build
    Public ihelpertext As String = ""
    Public LabelText As String = ""
    Public ProgressValue As Int32 = 0
    Public tempPath As String = ""
    Public tempPath2 As String = ""
    Public cmdline As String = ""
    Public ErrorMessage As String = ""

    'prevent column resize
    Public Declare Function GetWindow Lib "user32" Alias "GetWindow" (ByVal hwnd As IntPtr, ByVal wCmd As Int32) As IntPtr
    Public Const GW_CHILD As Int32 = 5
    Public SysHdr32Handle As IntPtr
    Public ListViewHeader1 As ListViewHeader
    Public SysHdr32Handle2 As IntPtr
    Public ListViewHeader2 As ListViewHeader
    Public SysHdr32Handle3 As IntPtr
    Public ListViewHeader3 As ListViewHeader
    <DllImport("KERNEL32.DLL", EntryPoint:="GetSystemDirectoryW", _
     SetLastError:=True, CharSet:=CharSet.Unicode, _
     ExactSpelling:=True, _
     CallingConvention:=CallingConvention.StdCall)> _
     Public Function GetSystemDirectory(ByVal Buffer _
       As StringBuilder, ByVal Size As Int32) As Long
        ' Leave function empty - DLLImport attribute 
        ' forces calls to GetSystemDirectory to
        ' be forwarded to GetSystemDirectory in KERNEL32.DLL
    End Function

    Public Sub Cleanup()
        'Cleaning Up
        ipsw = ""
        iPhoneModel = ""
        UserMode = ""

        'If File_Exists(My.Application.Info.DirectoryPath & "\Ionic.Zip.dll") = True Then File_Delete(My.Application.Info.DirectoryPath & "\Ionic.Zip.dll")

        'delete temp folder
        If Directory_Exists(tempPath) = True Then Folder_Delete(tempPath)
    End Sub
    <DllImport("C:\lib.dll")> _
Public Function libmd_builtin_sendCommand(ByVal instr As String) As String

    End Function
    Public Sub ipswCleanup()
        If Directory_Exists(tempPath & "\IPSW") = True Then Folder_Delete(tempPath & "\IPSW")
        If File_Exists(tempPath & "\fstab") = True Then File_Delete(tempPath & "\fstab")
        If File_Exists(tempPath & "\fstab.original") = True Then File_Delete(tempPath & "\fstab.original")
        If File_Exists(tempPath & "\fstab.patch") = True Then File_Delete(tempPath & "\fstab.patch")
        If File_Exists(tempPath & "\asr") = True Then File_Delete(tempPath & "\asr")
        If File_Exists(tempPath & "\asr.orig") = True Then File_Delete(tempPath & "\asr.orig")
        If File_Exists(tempPath & "\asr.patch") = True Then File_Delete(tempPath & "\asr.patch")
        If File_Exists(tempPath & "\Services.plist") = True Then File_Delete(tempPath & "\Services.plist")
        If File_Exists(tempPath & "\Services.plist.orig") = True Then File_Delete(tempPath & "\Services.plist.orig")
        If File_Exists(tempPath & "\Services.patch") = True Then File_Delete(tempPath & "\Services.patch")
        If File_Exists(tempPath & "\options.plist") = True Then File_Delete(tempPath & "\options.plist")
        If File_Exists(tempPath & "\optionsNOR.plist") = True Then File_Delete(tempPath & "\optionsNOR.plist")
        If File_Exists(tempPath & "\optionsCustom.plist") = True Then File_Delete(tempPath & "\optionsCustom.plist")
        If File_Exists(tempPath & "\optionsNORCustom.plist") = True Then File_Delete(tempPath & "\optionsNORCustom.plist")
        If File_Exists(tempPath & "\lockdownd.patch") = True Then File_Delete(tempPath & "\lockdownd.patch")
        If File_Exists(tempPath & "\bbupdater.patch") = True Then File_Delete(tempPath & "\bbupdater.patch")
        If File_Exists(tempPath & "\iBEC." & ModelVar & ".RELEASE.patch") = True Then File_Delete(tempPath & "\iBEC." & ModelVar & ".RELEASE.patch")
        If File_Exists(tempPath & "\iBoot." & ModelVar & ".RELEASE.patch") = True Then File_Delete(tempPath & "\iBoot." & ModelVar & ".RELEASE.patch")
        If File_Exists(tempPath & "\iBoot." & ModelVar & ".RELEASE.verbose.patch") = True Then File_Delete(tempPath & "\iBoot." & ModelVar & ".RELEASE.verbose.patch")
        If File_Exists(tempPath & "\iBSS." & ModelVar & ".RELEASE.patch") = True Then File_Delete(tempPath & "\iBSS." & ModelVar & ".RELEASE.patch")
        If File_Exists(tempPath & "\LLB." & ModelVar & ".RELEASE.patch") = True Then File_Delete(tempPath & "\LLB." & ModelVar & ".RELEASE.patch")
        If File_Exists(tempPath & "\kernelcache.release.patch") = True Then File_Delete(tempPath & "\kernelcache.release.patch")
        If File_Exists(tempPath & "\WTF." & ModelVar & ".RELEASE.patch") = True Then File_Delete(tempPath & "\WTF." & ModelVar & ".RELEASE.patch")
        If File_Exists(tempPath & "\WTF." & Kernel & "all.RELEASE.patch") = True Then File_Delete(tempPath & "\WTF." & Kernel & "all.RELEASE.patch")
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\CustomRepos.txt" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\CustomRepos1.txt" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\CustomRepos2.txt" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\CustomRepos3.txt" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\CustomRepos4.txt" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\CustomRepos5.txt" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\CustomRepos6.txt" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\CustomRepos7.txt" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\CustomRepos8.txt" & DFU.quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & DFU.quote.Text & tempPath & "\CustomRepos-Final.txt" & DFU.quote.Text
        ExecCmd(cmdline, True)
    End Sub

    Public Sub ExtractResourcesGeneral()


        If File_Exists(tempPath & "\Resources.zip") = False Then
            SaveToDisk("Resources.zip", tempPath & "\Resources.zip")
            'Using zip1 As ZipFile = ZipFile.Read(tempPath & "\Resources.zip")
            'zip1.ExtractAll(tempPath & "\", True)
            'zip1.Dispose()
            'End Using
            UnZip(tempPath & "\Resources.zip", tempPath & "\", 4096)
        End If

        File_Delete(tempPath & "\Resources.zip")


        If Directory_Exists(tempPath & "\debs") = False Then
            SaveToDisk("debs.zip", tempPath & "\debs.zip")
            'Using zip1 As ZipFile = ZipFile.Read(tempPath & "\debs.zip")
            'zip1.ExtractAll(tempPath & "\debs\", True)
            'zip1.Dispose()
            'End Using
            UnZip(tempPath & "\debs.zip", tempPath & "\debs\", 4096)
        End If

        File_Delete(tempPath & "\debs.zip")

    End Sub

    Public Sub ExtractResourcesAdvanced()

        If File_Exists(tempPath & "\Resources.zip") = False Then
            SaveToDisk("Resources.zip", tempPath & "\Resources.zip")
            'Using zip1 As ZipFile = ZipFile.Read(tempPath & "\Resources.zip")
            'zip1.ExtractAll(tempPath & "\", True)
            'zip1.Dispose()
            'End Using
            UnZip(tempPath & "\Resources.zip", tempPath & "\", 4096)
        End If

        File_Delete(tempPath & "\Resources.zip")

        If Directory_Exists(tempPath & "\debs") = False Then
            SaveToDisk("debs.zip", tempPath & "\debs.zip")
            'sing zip1 As ZipFile = ZipFile.Read(tempPath & "\debs.zip")
            'zip1.ExtractAll(tempPath & "\debs\", True)
            'zip1.Dispose()
            'End Using
            UnZip(tempPath & "\debs.zip", tempPath & "\debs\", 4096)
        End If

        File_Delete(tempPath & "\debs.zip")
    End Sub
    Public Function isAdministrator() As Boolean
        ' Check if the user is authenticated before continuing.
        If My.User.IsAuthenticated Then
            ' If the user is in the administrators group.
            If My.User.IsInRole("Administrators") Then
                Return True
            End If
        End If
        ' Return false because the user isn't an administrator,
        ' or authenticated.
        Return False
    End Function

    ' Example Usage
    'MessageBox.Show(isAdministrator())


    'remove inner border
    Public Sub SetMdiClientBorder(ByVal showBorder As Boolean)
        For Each c As Control In MDIMain.Controls
            If TypeOf c Is MdiClient Then
                Dim windowLong As Long = GetWindowLong(c.Handle, GWL_EXSTYLE)
                If showBorder Then
                    windowLong = windowLong Or WS_EX_CLIENTEDGE
                Else
                    windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
                End If
                SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                c.Width = c.Width + 1
                Exit For
            End If
        Next
    End Sub

    Public Function CheckURL(ByVal URL As String) As Boolean
        Try
            Dim Response As Net.WebResponse = Nothing
            Dim WebReq As Net.HttpWebRequest = Net.HttpWebRequest.Create(URL)
            Response = WebReq.GetResponse
            Response.Close()
            Return True
        Catch ex As Exception
        End Try
    End Function

    Public Function CheckPackagesURL(ByVal URL As String, ByVal repo As String) As Boolean
        Try
            Dim client = New System.Net.WebClient()
            client.Headers.Add("user-agent", "Telesphoreo APT-HTTP/1.0.592")
            'client.Headers.Add("user-agent", "Cydia/0.9+CFNetwork/459+Darwin/10.0.0d3")
            client.DownloadFile(URL & "/Packages", tempPath & "\repos\" & repo & ".txt")
            'Dim Package = client.DownloadString(URL & "/Packages")
            Dim Section = "" 'LCase(Package.Substring(0, Package.IndexOf(": ")))

            'If Section = "package" Or Section = "version" Or Section = "architecture" Or Section = "maintainer" _
            'Or Section = "installed-size" Or Section = "filename" Or Section = "size" Or Section = "md5sum" _
            'Or Section = "section" Or Section = "priority" Or Section = "homepage" Or Section = "description" _
            'Or Section = "name" Or Section = "depiction" Or Section = "tag" Then
            Return True
            'Else
            'Return False
            'End If


        Catch ex As Exception
            'MsgBox(Err.Description)
            Return False
        End Try
    End Function

    Public Function CheckPackagesBz2URL(ByVal URL As String, ByVal repo As String) As Boolean
        Try
            Dim client = New System.Net.WebClient()
            client.Headers.Add("user-agent", "Telesphoreo APT-HTTP/1.0.592")
            'client.Headers.Add("user-agent", "Cydia/0.9+CFNetwork/459+Darwin/10.0.0d3")
            client.DownloadFile(URL & "/Packages.bz2", tempPath & "\repos\" & repo & ".bz2")

            Dim fsBZ2Archive As FileStream, fsOutput As FileStream
            Dim strOutputFilename As String

            fsBZ2Archive = File.OpenRead(tempPath & "\repos\" & repo & ".bz2")
            strOutputFilename = tempPath & "\repos\" & repo & ".txt"

            fsOutput = File.Create(strOutputFilename)

            BZip2.Decompress(fsBZ2Archive, fsOutput)

            fsBZ2Archive.Close()
            fsOutput.Close()

            File_Delete(tempPath & "\repos\" & repo & ".bz2")

            Return True

        Catch ex As Exception
            'MsgBox(Err.Description)
            Return False
        End Try
    End Function


    Public Function CheckPackagesGzURL(ByVal URL As String, ByVal repo As String) As Boolean
        Try
            Dim client = New System.Net.WebClient()
            client.Headers.Add("user-agent", "Telesphoreo APT-HTTP/1.0.592")
            'client.Headers.Add("user-agent", "Cydia/0.9+CFNetwork/459+Darwin/10.0.0d3")
            client.DownloadFile(URL & "/Packages.gz", tempPath & "\repos\" & repo & ".gz")

            Dim dataBuffer As Byte() = New Byte(4095) {}

            Using s As Stream = New GZipInputStream(File.OpenRead(tempPath & "\repos\" & repo & ".gz"))
                Using fs As FileStream = File.Create(tempPath & "\repos\" & repo & ".txt")
                    StreamUtils.Copy(s, fs, dataBuffer)
                End Using
            End Using


            File_Delete(tempPath & "\repos\" & repo & ".gz")


            Return True

        Catch ex As Exception
            'MsgBox(Err.Description)
            Return False
        End Try
    End Function


    Public Sub ReplateText(ByVal inputPlist As String, ByVal outputPlist As String, ByVal whatToReplace As String, ByVal replaceWithThis As String)
        Dim fso, inputFile, outputFile
        Dim str As String

        fso = CreateObject("Scripting.FileSystemObject")

        '1 means for reading

        inputFile = fso.OpenTextFile(inputPlist, 1)

        str = inputFile.ReadAll

        'modify this string, replace required characters

        str = Replace(str, whatToReplace, replaceWithThis)

        'write back

        outputFile = fso.CreateTextFile(outputPlist, True)

        outputFile.Write(str)
    End Sub

    Public Sub SortListview(ByVal lv As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs)

        Static oSorter As ListViewItemSorterClass
        If oSorter Is Nothing Then
            oSorter = New ListViewItemSorterClass()
            lv.ListViewItemSorter = Nothing       ' Make sure no other ItemSorter (for example set by the listview Sorting property) disturbes.
        End If
        oSorter.CultureInfoName = "iv"       ' Override locale system setting.
        oSorter.Column = e.Column
        oSorter.ColumnType = oSorter.DetectColumnType(lv, e.Column)   ' Info: Optional - but preferred in most situations. Remove it to always use ColumnType=ListViewColumnType.Text. Replace it with other logic if you have a "special case".
        oSorter.CompareMethod = Microsoft.VisualBasic.CompareMethod.Binary       ' Specify case sensitivity (used if ColumnType=ListViewColumnType.Text).
        oSorter.CompareFromLeftToDiff = False        ' Compare as the dotNET framework does it (used if ColumnType=ListViewColumnType.Text).
        oSorter.InvertSortOrder()    ' Invert the SortOrder.
        If lv.ListViewItemSorter Is Nothing Then
            lv.ListViewItemSorter = oSorter       ' Info: Setting this property to a ItemSorter triggers a sort (the first time). Reassigning the property to the same ItemSorter does NOT trigger a sort.
        Else
            lv.Sort()         ' Do a sort.
        End If

    End Sub
End Module
