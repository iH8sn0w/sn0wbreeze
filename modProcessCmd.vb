Option Strict Off
Option Explicit On
Module modProcessCmd


    'Constants
    Public Const NORMAL_PRIORITY_CLASS As Int32 = &H20
    Public Const HIGH_PRIORITY_CLASS As Int32 = &H80
    Public Const INFINITE As Short = -1
    Private Const STARTF_USESHOWWINDOW As Short = 1
    Private Const SW_HIDE As Short = 0

    'public Types
    Public Structure STARTUPINFO
        Dim cb As Int32
        Dim lpReserved As String
        Dim lpDesktop As String
        Dim lpTitle As String
        Dim dwX As Int32
        Dim dwY As Int32
        Dim dwXSize As Int32
        Dim dwYSize As Int32
        Dim dwXCountChars As Int32
        Dim dwYCountChars As Int32
        Dim dwFillAttribute As Int32
        Dim dwFlags As Int32
        Dim wShowWindow As Short
        Dim cbReserved2 As Short
        Dim lpReserved2 As Int32
        Dim hStdInput As Int32
        Dim hStdOutput As Int32
        Dim hStdError As Int32
    End Structure

    Public Structure PROCESS_INFORMATION
        Dim hProcess As Int32
        Dim hThread As Int32
        Dim dwProcessID As Int32
        Dim dwThreadID As Int32
    End Structure

    'API Declarations
    Public Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As Int32, ByVal dwMilliseconds As Int32) As Int32
    'UPGRADE_WARNING: Structure PROCESS_INFORMATION may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    'UPGRADE_WARNING: Structure STARTUPINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Public Declare Function CreateProcessA Lib "kernel32" (ByVal lpApplicationName As Int32, ByVal lpCommandLine As String, ByVal lpProcessAttributes As Int32, ByVal lpThreadAttributes As Int32, ByVal bInheritHandles As Int32, ByVal dwCreationFlags As Int32, ByVal lpEnvironment As Int32, ByVal lpCurrentDirectory As Int32, ByRef lpStartupInfo As STARTUPINFO, ByRef lpProcessInformation As PROCESS_INFORMATION) As Int32
    Public Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Int32) As Int32

    'example use
    'cmdline = "%comspec% /c """ & App.Path & "\7z.exe x -oIPSW ,original.ipsw"""
    'or
    'cmdline = "7z.exe x -oIPSW ,original.ipsw"
    'or
    'cmdline = "DEL fstab.original /f /q"

    'ExecCmd (cmdline, True) 'False = show windows



    Public Function ExecCmd(ByVal cmdline As String, Optional ByVal HideWindow As Boolean = False) As Int32
        Dim Proc As PROCESS_INFORMATION
        Dim start As STARTUPINFO = Nothing
        Dim ReturnValue As Short

        'Hide window?
        If (HideWindow) Then
            start.dwFlags = STARTF_USESHOWWINDOW
            start.wShowWindow = SW_HIDE
        End If


        'Initialize The STARTUPINFO Structure
        start.cb = Len(start)

        'Start The Shelled Application
        ReturnValue = CreateProcessA(0, cmdline, 0, 0, 1, HIGH_PRIORITY_CLASS, 0, 0, start, Proc)

        'Wait for The Shelled Application to Finish
        Do
            ReturnValue = WaitForSingleObject(Proc.hProcess, 0)
            System.Windows.Forms.Application.DoEvents()
            Sleep(10)
        Loop Until ReturnValue <> 258

        'Close Handle to Shelled Application
        ReturnValue = CloseHandle(Proc.hProcess)

    End Function


End Module
