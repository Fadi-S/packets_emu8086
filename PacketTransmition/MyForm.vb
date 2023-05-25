Public Class MyForm

    Private Sub MyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' do not allow more than one copy of this program to run simultaneously
        If PrevInstance() Then
            ShowPrevInstance()
            End
        End If
    End Sub

    Function PrevInstance() As Boolean
        Return UBound(Process.GetProcessesByName _
     (Process.GetCurrentProcess.ProcessName)) _
     > 0
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        NumOfTransmissions.Text = Hex(READ_IO_WORD(112)) & "h"
    End Sub

    Private Sub InputSize_TextChanged(sender As Object, e As EventArgs) Handles InputSize.TextChanged
        Dim input As String
        input = InputSize.Text

        input = Hex(Val(input))
        If input.Length > 4 Then
            input = input.Substring(input.Length - 4)
        End If

        input = Val("&h" & input)

        WRITE_IO_WORD(110, input)
    End Sub
End Class
