Public Class Form1


    Dim matrix = New Integer(9, 3) {{1, 1, 0, 0}, {1, 0, 1, 0}, {0, 0, 1, 1}, {0, 0, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}}


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' i As Integer = 0 To 3
        Dim retVal As String = ""

            ' If matrix(0, i) = 1 Then
            'retVal = i
            calcolaCombinazione(retVal, matrix, 0)

        'End If

        'Next

    End Sub


    Private Sub calcolaCombinazione(ByVal retVal As String, ByVal matrix As Integer(,), ByVal row As Integer)
        If row < 9 Then
            '  Dim oldRetVal As String = retVal
            For column = 0 To 3

                If matrix(row, column) > 0 Then
                    Dim newRetVal = retVal & column
                    If matrix(row + 1, 0) = 0 And matrix(row + 1, 1) = 0 And matrix(row + 1, 2) = 0 And matrix(row + 1, 3) = 0 Then
                        Debug.Write(newRetVal & vbCrLf)
                    Else
                        ' Debug.Write(newRetVal & "->" & vbCrLf)
                        calcolaCombinazione(newRetVal, matrix, row + 1)

                    End If
                End If


            Next
        End If

    End Sub



End Class
