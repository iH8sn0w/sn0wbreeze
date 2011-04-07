Module xpwn
    Public Quotation As String = """"
    Public Sub hfsplus_add(ByVal Volume As String, ByVal File2Add As String, ByVal Path As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " add " & Quotation & File2Add & Quotation & " " & Path
        ExecCmd(cmdline, True)
    End Sub
    Public Sub hfsplus_addall(ByVal Volume As String, ByVal Folder2Add As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " addall " & Quotation & Folder2Add & Quotation
        ExecCmd(cmdline, True)
    End Sub
    Public Sub hfsplus_chmod(ByVal Volume As String, ByVal File2Chmod As String, ByVal chmod As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " chmod " & chmod & " " & File2Chmod
        ExecCmd(cmdline, True)
    End Sub
    Public Sub hfsplus_chown(ByVal Volume As String, ByVal File2Chown As String, ByVal Owner As String, ByVal Group As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " chown " & Owner & " " & Group & " " & File2Chown
        ExecCmd(cmdline, True)
    End Sub
    Public Sub hfsplus_mv(ByVal Volume As String, ByVal File2Move As String, ByVal NewPath As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " mv " & File2Move & " " & NewPath
        ExecCmd(cmdline, True)
    End Sub
    Public Sub hfsplus_mkdir(ByVal Volume As String, ByVal DIRnameNpath As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " mkdir " & DIRnameNpath
        ExecCmd(cmdline, True)
    End Sub
    Public Sub hfsplus_rm(ByVal Volume As String, ByVal File2RemoveNpath As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " rm " & File2RemoveNpath
        ExecCmd(cmdline, True)
    End Sub
    Public Sub hfsplus_extract(ByVal Volume As String, ByVal File2ExtractNPath As String, ByVal LocalLocation As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " extract " & File2ExtractNPath & " " & Quotation & LocalLocation & Quotation
        ExecCmd(cmdline, True)
    End Sub
    Public Sub hfsplus_symlink(ByVal Volume As String, ByVal PlaceofSymlink As String, ByVal Location2symlink As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " symlink " & PlaceofSymlink & " " & Location2symlink
        ExecCmd(cmdline, True)
    End Sub
    Public Sub hfsplus_grow(ByVal Volume As String, ByVal SizeInBytes As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " grow " & SizeInBytes
        ExecCmd(cmdline, True)
    End Sub
    Public Sub hfsplus_untar(ByVal Volume As String, ByVal Tar As String)
        cmdline = Quotation & tempPath & "\hfsplus.exe" & Quotation & " " & Quotation & Volume & Quotation & " untar " & Quotation & Tar & Quotation
        ExecCmd(cmdline, True)
    End Sub
    Public Sub bspatch(ByVal oldfile As String, ByVal newfile As String, ByVal Patch As String)
        cmdline = Quotation & tempPath & "\bspatch.exe" & Quotation & " " & Quotation & oldfile & Quotation & " " & Quotation & newfile & Quotation & " " & Quotation & Patch & Quotation
        ExecCmd(cmdline, True)
    End Sub
    Public Sub dmg_decrypt(ByVal EncryptedVolume As String, ByVal DecryptedVolumePath As String, ByVal vfdecryptKey As String)
        cmdline = Quotation & tempPath & "\dmg.exe" & Quotation & " extract " & Quotation & EncryptedVolume & Quotation & " " & Quotation & DecryptedVolumePath & Quotation & " -k " & vfdecryptKey
        ExecCmd(cmdline, True)
    End Sub
    Public Sub dmg_rebuild(ByVal DecryptedVolume As String, ByVal RebuiltVolumePath As String)
        cmdline = Quotation & tempPath & "\dmg.exe" & Quotation & " build " & Quotation & DecryptedVolume & Quotation & " " & Quotation & RebuiltVolumePath & Quotation
        ExecCmd(cmdline, True)
    End Sub
    Public Sub Rename_File(ByVal OriginalFilePath As String, ByVal NewFileNAME As String)
        cmdline = "cmd /c rename " & Quotation & OriginalFilePath & Quotation & " " & Quotation & NewFileNAME & Quotation
        ExecCmd(cmdline, True)
    End Sub
    Public Sub Delete_File(ByVal FilePath As String)
        cmdline = "cmd /c DEL " & Quotation & FilePath & Quotation
        ExecCmd(cmdline, True)
    End Sub
    Public Sub Merge_File(ByVal FirstFile As String, ByVal SecondFile As String, ByVal FinalFile As String)
        cmdline = "cmd /c type " & Quotation & FirstFile & Quotation & " " & Quotation & SecondFile & Quotation & " >> " & Quotation & FinalFile & Quotation
        ExecCmd(cmdline, True)
    End Sub
    Public Sub xpwntool(ByVal infile As String, ByVal outfile As String, ByVal IVKey As String, ByVal Key As String)
        cmdline = Quotation & tempPath & "\xpwntool.exe" & Quotation & " " & Quotation & infile & Quotation & " " & Quotation & outfile & Quotation & " -iv " & IVKey & " -k " & Key
        ExecCmd(cmdline, True)
    End Sub
    Public Sub xpwntool_nokeys(ByVal infile As String, ByVal outfile As String)
        cmdline = Quotation & tempPath & "\xpwntool.exe" & Quotation & " " & Quotation & infile & Quotation & " " & Quotation & outfile & Quotation
        ExecCmd(cmdline, True)
    End Sub
    Public Sub xpwntool_template(ByVal infile As String, ByVal outfile As String, ByVal Template As String, ByVal IVKey As String, ByVal Key As String)
        cmdline = Quotation & tempPath & "\xpwntool.exe" & Quotation & " " & Quotation & infile & Quotation & " " & Quotation & outfile & Quotation & " -t " & Quotation & Template & Quotation & " -iv " & IVKey & " -k " & Key
        ExecCmd(cmdline, True)
    End Sub
    Public Sub xpwntool_template_nokeys(ByVal infile As String, ByVal outfile As String, ByVal Template As String)
        cmdline = Quotation & tempPath & "\xpwntool.exe" & Quotation & " " & Quotation & infile & Quotation & " " & Quotation & outfile & Quotation & " -t " & Quotation & Template & Quotation
        ExecCmd(cmdline, True)
    End Sub
    Public Sub vfdecrypt(ByVal EncryptedVolume As String, ByVal DecryptedVolumePath As String, ByVal vfdecryptkey As String)
        cmdline = Quotation & tempPath & "\vfdecrypt.exe" & Quotation & " -i " & Quotation & EncryptedVolume & Quotation & " -k " & vfdecryptkey & " -o " & Quotation & DecryptedVolumePath & Quotation
        ExecCmd(cmdline, True)
    End Sub
End Module

