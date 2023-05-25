Option Explicit On

Imports System.Runtime.InteropServices

Public Module SingleInstanceModule
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function GetWindow(ByVal hwnd As IntPtr, ByVal wCmd As Integer) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function OpenIcon(ByVal hwnd As IntPtr) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function SetForegroundWindow(ByVal hwnd As IntPtr) As Integer
    End Function

    Public Const GW_HWNDPREV As Integer = 3

    Function ShowPrevInstance() As Boolean ' returns True on success.
        On Error GoTo err1

        Dim sOldTitle As String
        Dim lWindowHandle As IntPtr

        'saving the current title in OldTitle variable
        'and changing the application title
        sOldTitle = My.Application.Info.Title

        'finding the previous instance
        lWindowHandle = FindWindow("ThunderRT6Main", sOldTitle)

        'if there is no old instances of your application - exit.
        If lWindowHandle = IntPtr.Zero Then
            ShowPrevInstance = False
            Exit Function
        End If

        'Find the window we need to restore
        lWindowHandle = GetWindow(lWindowHandle, GW_HWNDPREV)

        'Now restore it
        OpenIcon(lWindowHandle)

        'And Bring it to the foreground
        SetForegroundWindow(lWindowHandle)

        ShowPrevInstance = True
        Exit Function
err1:
        Debug.Print("ShowPrevInstance: " & Err.Description)
        Resume Next
    End Function
End Module
