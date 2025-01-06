Public Class TimeConverterForm
    Dim cen, yr, mnth, wek, dy, hr, mnt, scnd, millis, mics As Double

    Public Sub MySampleFunc()

        cen = yr / 100
        yr = cen * 100
        mnth = yr * 12
        wek = mnth * 4.2857142857142856
        dy = wek * 7
        hr = dy * 24
        mnt = hr * 60
        scnd = mnt * 60
        millis = scnd * 1000
        mics = millis * 1000
    End Sub

#Region "Weeks"
    Private Sub wekB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wekB.Click
        Try
            wek = CDbl(week.Text)
            'wek = mnth * 4.2857142857142856
            'week.Text = wek
            dy = wek * 7
            days.Text = dy
            hr = dy * 24
            hours.Text = hr
            mnt = hr * 60
            minutes.Text = mnt
            scnd = mnt * 60
            seconds.Text = scnd
            millis = scnd * 1000
            milliseconds.Text = millis
            mics = millis * 1000
            microseconds.Text = mics

            mnth = wek / 4.2857142857142856
            months.Text = mnth
            yr = mnth / 12
            years.Text = yr
            cen = yr / 100
            centuries.Text = cen
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try
    End Sub
#End Region

#Region "Centuries"
    Private Sub cenB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cenB.Click
        Try
            cen = CDbl(centuries.Text)
            'cen = yr / 100
            yr = cen * 100
            years.Text = yr
            mnth = yr * 12
            months.Text = mnth
            wek = mnth * 4.2857142857142856
            week.Text = wek
            dy = wek * 7
            days.Text = dy
            hr = dy * 24
            hours.Text = hr
            mnt = hr * 60
            minutes.Text = mnt
            scnd = mnt * 60
            seconds.Text = scnd
            millis = scnd * 1000
            milliseconds.Text = millis
            mics = millis * 1000
            microseconds.Text = mics
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub
#End Region

#Region "Years"
    Private Sub yrB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yrB.Click
        Try
            yr = CDbl(years.Text)
            'yr = cen * 100
            'years.Text = yr
            mnth = yr * 12
            months.Text = mnth
            wek = mnth * 4.2857142857142856
            week.Text = wek
            dy = wek * 7
            days.Text = dy
            hr = dy * 24
            hours.Text = hr
            mnt = hr * 60
            minutes.Text = mnt
            scnd = mnt * 60
            seconds.Text = scnd
            millis = scnd * 1000
            milliseconds.Text = millis
            mics = millis * 1000
            microseconds.Text = mics

            cen = yr / 100
            centuries.Text = cen
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub
#End Region

#Region "Months"
    Private Sub mnthB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnthB.Click
        Try
            mnth = CDbl(months.Text)
            'mnth = yr * 12
            'months.Text = mnth
            wek = mnth * 4.2857142857142856
            week.Text = wek
            dy = wek * 7
            days.Text = dy
            hr = dy * 24
            hours.Text = hr
            mnt = hr * 60
            minutes.Text = mnt
            scnd = mnt * 60
            seconds.Text = scnd
            millis = scnd * 1000
            milliseconds.Text = millis
            mics = millis * 1000
            microseconds.Text = mics

            yr = mnth / 12
            years.Text = yr
            cen = yr / 100
            centuries.Text = cen
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub
#End Region

#Region "Days"
    Private Sub dyB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dyB.Click
        Try
            dy = CDbl(days.Text)
            'dy = wek * 7
            'days.Text = dy
            hr = dy * 24
            hours.Text = hr
            mnt = hr * 60
            minutes.Text = mnt
            scnd = mnt * 60
            seconds.Text = scnd
            millis = scnd * 1000
            milliseconds.Text = millis
            mics = millis * 1000
            microseconds.Text = mics

            wek = dy / 7
            week.Text = wek
            mnth = wek / 4.2857142857142856
            months.Text = mnth
            yr = mnth / 12
            years.Text = yr
            cen = yr / 100
            centuries.Text = cen
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub
#End Region

#Region "Hours"
    Private Sub hrB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hrB.Click
        Try
            hr = CDbl(hours.Text)
            'hr = dy * 24
            'hours.Text = hr
            mnt = hr * 60
            minutes.Text = mnt
            scnd = mnt * 60
            seconds.Text = scnd
            millis = scnd * 1000
            milliseconds.Text = millis
            mics = millis * 1000
            microseconds.Text = mics

            dy = hr / 24
            days.Text = dy
            wek = dy / 7
            week.Text = wek
            mnth = wek / 4.2857142857142856
            months.Text = mnth
            yr = mnth / 12
            years.Text = yr
            cen = yr / 100
            centuries.Text = cen
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Minutes"
    Private Sub mntB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mntB.Click
        Try
            mnt = CDbl(minutes.Text)
            'mnt = hr * 60
            'minutes.Text = mnt
            scnd = mnt * 60
            seconds.Text = scnd
            millis = scnd * 1000
            milliseconds.Text = millis
            mics = millis * 1000
            microseconds.Text = mics

            hr = mnt / 60
            hours.Text = hr
            dy = hr / 24
            days.Text = dy
            wek = dy / 7
            week.Text = wek
            mnth = wek / 4.2857142857142856
            months.Text = mnth
            yr = mnth / 12
            years.Text = yr
            cen = yr / 100
            centuries.Text = cen
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Seconds"
    Private Sub scndB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scndB.Click
        Try
            scnd = CDbl(seconds.Text)
            'scnd = mnt * 60
            'seconds.Text = scnd
            millis = scnd * 1000
            milliseconds.Text = millis
            mics = millis * 1000
            microseconds.Text = mics

            mnt = scnd / 60
            minutes.Text = mnt
            hr = mnt / 60
            hours.Text = hr
            dy = hr / 24
            days.Text = dy
            wek = dy / 7
            week.Text = wek
            mnth = wek / 4.2857142857142856
            months.Text = mnth
            yr = mnth / 12
            years.Text = yr
            cen = yr / 100
            centuries.Text = cen
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub
#End Region

#Region "MilliSeconds"
    Private Sub millisB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles millisB.Click
        Try
            millis = CDbl(milliseconds.Text)
            'millis = scnd * 1000
            'milliseconds.Text = millis
            mics = millis * 1000
            microseconds.Text = mics

            scnd = millis / 1000
            seconds.Text = scnd
            mnt = scnd / 60
            minutes.Text = mnt
            hr = mnt / 60
            hours.Text = hr
            dy = hr / 24
            days.Text = dy
            wek = dy / 7
            week.Text = wek
            mnth = wek / 4.2857142857142856
            months.Text = mnth
            yr = mnth / 12
            years.Text = yr
            cen = yr / 100
            centuries.Text = cen
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "MicroSeconds"
    Private Sub microsB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles microsB.Click
        Try
            mics = CDbl(microseconds.Text)
            'mics = millis * 1000
            'microseconds.Text = mics

            millis = scnd * 1000
            milliseconds.Text = millis
            scnd = millis / 1000
            seconds.Text = scnd
            mnt = scnd / 60
            minutes.Text = mnt
            hr = mnt / 60
            hours.Text = hr
            dy = hr / 24
            days.Text = dy
            wek = dy / 7
            week.Text = wek
            mnth = wek / 4.2857142857142856
            months.Text = mnth
            yr = mnth / 12
            years.Text = yr
            cen = yr / 100
            centuries.Text = cen
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        week.Clear()
        centuries.Clear()
        years.Clear()
        months.Clear()
        days.Clear()
        hours.Clear()
        minutes.Clear()
        seconds.Clear()
        milliseconds.Clear()
        microseconds.Clear()



    End Sub
End Class
