Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Double
        Dim unit As String

        result = (CDbl(kHz.Text) * 1000) * (CDbl(bit.Text) / 8.0) * CDbl(seconds.Text) * CDbl(tracks.Text)
        unit = "bytes"
        If kb.Checked Then
            result /= 1024
            unit = "KB"
        ElseIf mb.Checked Then
            result /= 1024 ^ 2
            unit = "MB"
        ElseIf gb.Checked Then
            result /= 1024 ^ 3
            unit = "GB"
        End If

        size.Text = result.ToString("N2") + " " + unit
    End Sub

End Class
