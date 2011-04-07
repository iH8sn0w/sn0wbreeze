Imports System.Environment
Imports System.IO
Imports System.Windows.Forms.FileDialog
Imports System.Reflection


Module modFile

    Public Sub SaveToDisk(ByVal resourceName As String, ByVal fileName As String)
        ' Get a reference to the running application.
        Dim assy As [Assembly] = [Assembly].GetExecutingAssembly()

        ' Loop through each resource, looking for the image name (case-insensitive).
        For Each resource As String In assy.GetManifestResourceNames()
            If resource.ToLower().IndexOf(resourceName.ToLower) <> -1 Then
                ' Get the embedded file from the assembly as a MemoryStream.
                Using resourceStream As System.IO.Stream = assy.GetManifestResourceStream(resource)
                    If resourceStream IsNot Nothing Then
                        Using reader As New BinaryReader(resourceStream)
                            ' Read the bytes from the input stream.
                            Dim buffer() As Byte = reader.ReadBytes(CInt(resourceStream.Length))
                            Using outputStream As New FileStream(fileName, FileMode.Create)
                                Using writer As New BinaryWriter(outputStream)
                                    ' Write the bytes to the output stream.
                                    writer.Write(buffer)
                                End Using
                            End Using
                        End Using
                    End If
                End Using
                Exit For
            End If
        Next resource
    End Sub
    Public Function File_Copy(ByVal strSource As String, ByVal strDestination As String, ByVal bolOverwrite As Boolean, _
                           Optional ByRef strError As String = "") As Boolean

        If strDestination.Length And strSource.Length <> 0 Then
            Try
                File.Copy(strSource, strDestination, bolOverwrite)
                File_Copy = True
            Catch oExc As Exception
                strError = oExc.Message
                File_Copy = False
            End Try
        End If

    End Function

    Public Function File_Rename(ByVal strSource As String, ByVal strNewName As String, Optional ByRef strError As String = "") As Boolean

        If strNewName.Length And strSource.Length <> 0 Then
            Try
                File.Move(strSource, strNewName)
                File_Rename = True
            Catch oExc As Exception
                strError = oExc.Message
                File_Rename = False
            End Try
        End If

    End Function

    Public Function File_Move(ByVal strSource As String, ByVal strDestination As String, _
                           Optional ByRef strError As String = "") As Boolean

        If strDestination.Length And strSource.Length <> 0 Then
            Try
                File.Move(strSource, strDestination)
                File_Move = True
            Catch oExc As Exception
                strError = oExc.Message
                File_Move = False
            End Try
        End If

    End Function

    Public Function File_Exists(ByVal strFile As String) As Boolean

        If strFile.Length <> 0 Then
            Dim oFile As New FileInfo(strFile)
            If oFile.Exists = True Then
                File_Exists = True
            Else
                File_Exists = False
            End If
        End If

    End Function

    Public Function File_Delete(ByVal strFilename As String, Optional ByRef strError As String = "") As Boolean

        If strFilename.Length <> 0 Then
            Try
                System.IO.File.Delete(strFilename)
                File_Delete = True
            Catch oExc As Exception
                strError = oExc.Message
                File_Delete = False
            End Try
        End If

    End Function

    Public Function Directory_Exists(ByVal StrFolder As String) As Boolean

        If StrFolder.Length <> 0 Then
            Dim oDirectory As New DirectoryInfo(StrFolder)
            If oDirectory.Exists = True Then
                Directory_Exists = True
            Else
                Directory_Exists = False
            End If
        End If

    End Function

    Public Function Create_Directory(ByVal strDirectoryName As String, Optional ByRef strError As String = "") As Boolean

        Dim bolExitst As Boolean

        If strDirectoryName.Length <> 0 Then
            Try
                bolExitst = Directory_Exists(strDirectoryName)
                If Not bolExitst Then
                    Directory.CreateDirectory(strDirectoryName)
                    Create_Directory = True
                End If
            Catch oExc As Exception
                strError = oExc.Message
                Create_Directory = False
            End Try
        End If

    End Function

    Public Function Folder_Delete(ByVal strFolderame As String, Optional ByRef strError As String = "") As Boolean

        If strFolderame.Length <> 0 Then
            Try
                Dim Directory As New IO.DirectoryInfo(strFolderame)
                Directory.Delete(True)
                Folder_Delete = True
            Catch oExc As Exception
                strError = oExc.Message
                Folder_Delete = False
            End Try
        End If

    End Function



    Public Function GetFileSize(ByVal MyFilePath As String) As Long
        Dim MyFile As New FileInfo(MyFilePath)
        Dim FileSize As Long = MyFile.Length
        Return FileSize
    End Function

    Public Function NameOnlyFromFullPath(ByVal FileFullPath As String) As String

        'EXAMPLE: input ="C:\winnt\system32\kernel.dll, 
        'output = kernel.dll

        Dim intPos As Int32

        intPos = FileFullPath.LastIndexOfAny("\")
        intPos += 1

        Return FileFullPath.Substring(intPos, (Len(FileFullPath) - intPos))

    End Function

    Public Function NameOnlyFromFullPath2(ByVal FileFullPath As String) As String

        'EXAMPLE: input ="C:\winnt\system32\kernel.dll, 
        'output = kernel.dll

        Dim intPos As Int32

        intPos = FileFullPath.LastIndexOfAny("/")
        intPos += 1

        Return FileFullPath.Substring(intPos, (Len(FileFullPath) - intPos))

    End Function

    Public Function GetFileContents(ByVal FullPath As String, _
       Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String
        Dim objReader As StreamReader
        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
        Return ""
    End Function

    Public Function SaveTextToFile(ByVal strData As String, _
     ByVal FullPath As String, _
       Optional ByVal ErrInfo As String = "") As Boolean

        Dim Contents As String = ""
        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try


            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message

        End Try
        Return bAns
    End Function
End Module
