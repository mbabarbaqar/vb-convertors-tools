Public Class SpeedConverterForm
    Dim metPs, metPm, kmPh, ftPs, ftPm, miPh As Double

    Private Sub msB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msB.Click
        Try
            metPs = CDbl(meterPs.Text)
            'metPs = 
            'meterPs.Text = metPs
            metPm = metPs * 59.988
            MeterPm.Text = metPm
            kmPh = metPs * 3.599712
            kilometerPh.Text = kmPh
            ftPs = metPs * 3.28084
            footPs.Text = ftPs
            ftPm = metPs * 196.8504
            footPm.Text = ftPm
            miPh = metPs * 2.237136
            milesPh.Text = miPh
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub

    Private Sub mmB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmB.Click
        Try
            metPm = CDbl(MeterPm.Text)
            metPs = metPm * 0.01667
            meterPs.Text = metPs
            'metPm = metPs * 59.988
            'MeterPm.Text = metPm
            kmPh = metPs * 3.599712
            kilometerPh.Text = kmPh
            ftPs = metPs * 3.28084
            footPs.Text = ftPs
            ftPm = metPs * 196.8504
            footPm.Text = ftPm
            miPh = metPs * 2.237136
            milesPh.Text = miPh
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub

    Private Sub khB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles khB.Click
        Try
            kmPh = CDbl(kilometerPh.Text)
            metPs = kmPh * 0.01667
            meterPs.Text = metPs
            metPm = metPs * 0.2778
            MeterPm.Text = metPm
            'kmPh = metPs * 3.599712
            'kilometerPh.Text = kmPh
            ftPs = metPs * 3.28084
            footPs.Text = ftPs
            ftPm = metPs * 196.8504
            footPm.Text = ftPm
            miPh = metPs * 2.237136
            milesPh.Text = miPh
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub

    Private Sub fsB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fsB.Click
        Try
            ftPs = CDbl(footPs.Text)
            metPs = ftPs * 0.3048
            meterPs.Text = metPs
            metPm = metPs * 0.2778
            MeterPm.Text = metPm
            kmPh = metPs * 3.599712
            kilometerPh.Text = kmPh
            'ftPs = metPs * 3.28084
            'footPs.Text = ftPs
            ftPm = metPs * 196.8504
            footPm.Text = ftPm
            miPh = metPs * 2.237136
            milesPh.Text = miPh
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub

    Private Sub fmB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fmB.Click
        Try
            ftPm = CDbl(footPm.Text)
            metPs = ftPm * 0.00508
            meterPs.Text = metPs
            metPm = metPs * 0.2778
            MeterPm.Text = metPm
            kmPh = metPs * 3.599712
            kilometerPh.Text = kmPh
            ftPs = metPs * 3.28084
            footPs.Text = ftPs
            'ftPm = metPs * 196.8504
            'footPm.Text = ftPm
            miPh = metPs * 2.237136
            milesPh.Text = miPh
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub

    Private Sub mhB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mhB.Click
        Try
            miPh = CDbl(milesPh.Text)
            metPs = miPh * 0.447
            meterPs.Text = metPs
            metPm = metPs * 0.2778
            MeterPm.Text = metPm
            kmPh = metPs * 3.599712
            kilometerPh.Text = kmPh
            ftPs = metPs * 3.28084
            footPs.Text = ftPs
            ftPm = metPs * 196.8504
            footPm.Text = ftPm
            'miPh = metPs * 2.237136
            'milesPh.Text = miPh
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        meterPs.Clear()
        MeterPm.Clear()
        kilometerPh.Clear()
        footPs.Clear()
        footPm.Clear()
        milesPh.Clear()

    End Sub
End Class
