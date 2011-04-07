Public Class ListViewHeader

    Inherits System.Windows.Forms.NativeWindow
    Private ptrHWnd As IntPtr

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        'Debug.Print(m.Msg)
        Select Case m.Msg
            Case Is = &H20  ' WM_SETCURSOR
                m.Msg = 0
            Case Is = &H201  ' WM_LBUTTONDOWN
                'm.Msg = 0
            Case Is = &H203  ' WM_LBUTTONDBLCLK
                m.Msg = 0
            Case Is = &H200  ' MOUSEMOVE 
                m.Msg = 0
                'Debug.Print(m.Msg)
        End Select

        MyBase.WndProc(m)
    End Sub

    Protected Overrides Sub Finalize()
        Me.ReleaseHandle()
        MyBase.Finalize()
    End Sub

    Public Sub New(ByVal ControlHandle As IntPtr)
        ptrHWnd = ControlHandle
        Me.AssignHandle(ptrHWnd)
    End Sub


End Class





