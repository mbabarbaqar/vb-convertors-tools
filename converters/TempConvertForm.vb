Public Class TempConvertForm
    Dim dc, df, kl As Double

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        calsius.Clear()
        fahrenheit.Clear()
        kelvin.Clear()
    End Sub

    Public Sub dcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dcButton.Click
        Try
            dc = CDbl(calsius.Text)
            df = (9 / 5) * dc + 32
            fahrenheit.Text = df
            kl = dc + 273
            kelvin.Text = kl

            tempScale2()
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try
    End Sub

    Private Sub dfButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dfButton.Click
        Try
            df = CDbl(fahrenheit.Text)
            dc = (5 / 9) * (df - 32)
            calsius.Text = dc
            kl = (5 / 9) * (df + 460)
            kelvin.Text = kl
            tempScale2()

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try
    End Sub

    Private Sub klButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles klButton.Click
        Try
            kl = CDbl(kelvin.Text)
            dc = kl - 273
            calsius.Text = dc
            df = (9 / 5) * kl - 460
            fahrenheit.Text = df
            tempScale2()

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try
    End Sub

    Private Sub tempScale2()

        If dc < -1000 Then
            tempScale.Value = 0
        ElseIf dc <= -1000 Then
            tempScale.Value = 5
        ElseIf dc <= -500 Then
            tempScale.Value = 10
        ElseIf dc <= -200 Then
            tempScale.Value = 20
        ElseIf dc <= -100 Then
            tempScale.Value = 30
        ElseIf dc <= -50 Then
            tempScale.Value = 40
        ElseIf dc <= -10 Then
            tempScale.Value = 45
        ElseIf dc = 0 Then
            tempScale.Value = 50
        ElseIf dc <= 10 Then
            tempScale.Value = 55
        ElseIf dc <= 50 Then
            tempScale.Value = 60
        ElseIf dc <= 100 Then
            tempScale.Value = 70
        ElseIf dc <= 200 Then
            tempScale.Value = 80
        ElseIf dc <= 500 Then
            tempScale.Value = 90
        ElseIf dc <= 1000 Then
            tempScale.Value = 95
        ElseIf dc > 1000 Then
            tempScale.Value = 100
        Else
            tempScale.Value = 0
        End If
    End Sub
End Class
