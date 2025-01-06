Public Class PowerConverterForm

    Private Sub wattButton_Click(sender As Object, e As EventArgs) Handles wattButton.Click
        Try
            Dim wattValue As Double = CDbl(wattBox.Text)
            kilowattBox.Text = wattValue / 1000
            calorieBox.Text = wattValue / 4.186
            HorsepowerBox.Text = wattValue / 745.7
            footPoundSecondBox.Text = wattValue / 1.356
            footPoundMinutBox.Text = wattValue * 44.25
            britishTSBox.Text = wattValue / 1055
            britishTHBox.Text = wattValue / 0.293
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub

    Private Sub killowattButton_Click(sender As Object, e As EventArgs) Handles killowattButton.Click
        Try
            Dim killowattValue As Double = CDbl(kilowattBox.Text)
            wattBox.Text = killowattValue * 1000
            calorieBox.Text = killowattValue * 238.9
            HorsepowerBox.Text = killowattValue * 1.341
            footPoundSecondBox.Text = killowattValue * 737.6
            footPoundMinutBox.Text = killowattValue * 44250
            britishTSBox.Text = killowattValue * 0.9481
            britishTHBox.Text = killowattValue * 3413
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub

    Private Sub calorieButton_Click(sender As Object, e As EventArgs) Handles calorieButton.Click
        Try
            Dim calorieValue As Double = CDbl(calorieBox.Text)
            wattBox.Text = calorieValue * 4.186
            kilowattBox.Text = calorieValue / 238.9
            HorsepowerBox.Text = calorieValue / 178.2
            footPoundSecondBox.Text = calorieValue / 0.3239
            footPoundMinutBox.Text = calorieValue / 0.005399
            britishTSBox.Text = calorieValue / 252.0
            britishTHBox.Text = calorieValue * 14.29
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub

    Private Sub horsepowerButton_Click(sender As Object, e As EventArgs) Handles horsepowerButton.Click
        Try
            Dim horspowerValue As Double = CDbl(HorsepowerBox.Text)
            wattBox.Text = horspowerValue * 745.7
            kilowattBox.Text = horspowerValue * 0.7457
            calorieBox.Text = horspowerValue * 178.2
            footPoundSecondBox.Text = horspowerValue * 550
            footPoundMinutBox.Text = horspowerValue * 33000
            britishTSBox.Text = horspowerValue * 0.7069
            britishTHBox.Text = horspowerValue * 2545
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub

    Private Sub footpoundSButton_Click(sender As Object, e As EventArgs) Handles footpoundSButton.Click
        Try
            Dim footpoundsValue As Double = CDbl(footPoundSecondBox.Text)
            wattBox.Text = footpoundsValue / 0.7376
            kilowattBox.Text = footpoundsValue / 737.6
            calorieBox.Text = footpoundsValue / 3.087
            HorsepowerBox.Text = footpoundsValue / 550
            footPoundMinutBox.Text = footpoundsValue * 60
            britishTSBox.Text = footpoundsValue / 777.9
            britishTHBox.Text = footpoundsValue / 0.2161
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub

    Private Sub footpoundMButton_Click(sender As Object, e As EventArgs) Handles footpoundMButton.Click
        Try
            Dim footpoundmValue = CDbl(footPoundMinutBox.Text)
            wattBox.Text = footpoundmValue / 44.25
            kilowattBox.Text = footpoundmValue / 44250
            calorieBox.Text = footpoundmValue / 185.2
            HorsepowerBox.Text = footpoundmValue / 33000
            footPoundSecondBox.Text = footpoundmValue / 60
            britishTSBox.Text = footpoundmValue / 46690
            britishTHBox.Text = footpoundmValue / 12.97
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub

    Private Sub britishTSButton_Click(sender As Object, e As EventArgs) Handles britishTSButton.Click
        Try
            Dim btsValue = CDbl(britishTSBox.Text)
            wattBox.Text = btsValue * 0.001055
            kilowattBox.Text = btsValue * 1.055
            calorieBox.Text = btsValue * 252.0
            HorsepowerBox.Text = btsValue * 1.414
            footPoundSecondBox.Text = btsValue * 777.9
            footPoundMinutBox.Text = btsValue * 46690
            britishTHBox.Text = btsValue * 3600
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub

    Private Sub britishTHButton_Click(sender As Object, e As EventArgs) Handles britishTHButton.Click
        Try
            Dim bthValue As Double = CDbl(britishTHBox.Text)
            wattBox.Text = bthValue / 3.413
            kilowattBox.Text = bthValue / 3413
            calorieBox.Text = bthValue / 14.29
            HorsepowerBox.Text = bthValue / 2545
            footPoundSecondBox.Text = bthValue / 4.628
            footPoundMinutBox.Text = bthValue * 12.97
            britishTSBox.Text = bthValue / 3600
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub


    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        wattBox.Clear()
        kilowattBox.Clear()
        calorieBox.Clear()
        HorsepowerBox.Clear()
        footPoundMinutBox.Clear()
        footPoundSecondBox.Clear()
        britishTSBox.Clear()
        britishTHBox.Clear()
    End Sub

End Class