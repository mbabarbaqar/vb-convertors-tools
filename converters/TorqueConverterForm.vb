Public Class TorqueConverterForm

    Private Sub NewtonButton_Click(sender As Object, e As EventArgs) Handles NewtonButton.Click
        Try
            Dim newtonmeterValue As Double = CDbl(NewtonmeterBox.Text)
            KilogramforcemeterBox.Text = newtonmeterValue / 9.80665
            FootpoundBox.Text = newtonmeterValue / 1.35582
            InchpoundBox.Text = newtonmeterValue / 0.112985
        Catch ex As Exception
            MessageBox.Show("Please Provide A Valid Number")
        End Try
    End Sub

    Private Sub KilogramforcemeterButton_Click(sender As Object, e As EventArgs) Handles KilogramforcemeterButton.Click
        Try
            Dim kgmValue As Double = CDbl(KilogramforcemeterBox.Text)
            NewtonmeterBox.Text = kgmValue / 0.101972
            FootpoundBox.Text = kgmValue / 0.138255
            InchpoundBox.Text = kgmValue / 0.011521

        Catch ex As Exception
            MessageBox.Show("Please Provide A Valid Number")
        End Try
    End Sub

    Private Sub FootpoundButton_Click(sender As Object, e As EventArgs) Handles FootpoundButton.Click
        Try
            Dim flbValue As Double = CDbl(FootpoundBox.Text)
            NewtonmeterBox.Text = flbValue / 0.737561
            KilogramforcemeterBox.Text = flbValue / 7.233003
            InchpoundBox.Text = flbValue / 0.083333
        Catch ex As Exception
            MessageBox.Show("Please Provide A Valid Number")
        End Try
    End Sub

    Private Sub InchpoundButton_Click(sender As Object, e As EventArgs) Handles InchpoundButton.Click
        Try
            Dim inlbValue As Double = CDbl(InchpoundBox.Text)
            NewtonmeterBox.Text = inlbValue / 8.850732
            KilogramforcemeterBox.Text = inlbValue / 86.79603
            FootpoundBox.Text = inlbValue / 12
        Catch ex As Exception
            MessageBox.Show("Please Provide A Valid Number")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewtonmeterBox.Clear()
        KilogramforcemeterBox.Clear()
        FootpoundBox.Clear()
        InchpoundBox.Clear()
    End Sub

    Private Sub NewtonmeterBox_TextChanged(sender As Object, e As EventArgs) Handles NewtonmeterBox.TextChanged
        NewtonButton.ForeColor = Color.DarkGreen
    End Sub

    Private Sub KilogramforcemeterBox_TextChanged(sender As Object, e As EventArgs) Handles KilogramforcemeterBox.TextChanged
        KilogramforcemeterButton.ForeColor = Color.DarkGreen
    End Sub

    Private Sub FootpoundBox_TextChanged(sender As Object, e As EventArgs) Handles FootpoundBox.TextChanged
        FootpoundButton.ForeColor = Color.DarkGreen
    End Sub

    Private Sub InchpoundBox_TextChanged(sender As Object, e As EventArgs) Handles InchpoundBox.TextChanged
        InchpoundButton.ForeColor = Color.DarkGreen
    End Sub
End Class