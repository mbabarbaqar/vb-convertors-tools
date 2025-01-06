Public Class PressureConverterForm
    Dim br, psi, kpa, mpa, kgf, mmhg, atm As Double
    Dim metw, ftw, cenm, inm, inw, pas As Double


#Region "High Pressure Converter"
    Private Sub lPs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lPs.Click
        Try
            br = CDbl(bar.Text)
            'br = 
            'bar.Text = br
            psi = br * 14.50326
            pound.Text = psi
            kpa = br * 100
            kilopound.Text = kpa
            mpa = br * 0.1
            megapascal.Text = mpa
            kgf = br * 1.01968
            kilogramforce.Text = kgf
            mmhg = br * 750.0188
            millimeterhg.Text = mmhg
            atm = br * 0.987167
            atmosphere.Text = atm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try

    End Sub

    Private Sub lPm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lPm.Click
        Try
            psi = CDbl(pound.Text)
            br = psi * 0.06895
            bar.Text = br
            'psi = br * 14.50326
            'pound.Text = psi
            kpa = br * 100
            kilopound.Text = kpa
            mpa = br * 0.1
            megapascal.Text = mpa
            kgf = br * 1.01968
            kilogramforce.Text = kgf
            mmhg = br * 750.0188
            millimeterhg.Text = mmhg
            atm = br * 0.987167
            atmosphere.Text = atm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub

    Private Sub gPm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gPm.Click
        Try
            kpa = CDbl(kilopound.Text)
            br = kpa * 0.01
            bar.Text = br
            psi = br * 14.50326
            pound.Text = psi
            'kpa = br * 100
            'kilopound.Text = kpa
            mpa = br * 0.1
            megapascal.Text = mpa
            kgf = br * 1.01968
            kilogramforce.Text = kgf
            mmhg = br * 750.0188
            millimeterhg.Text = mmhg
            atm = br * 0.987167
            atmosphere.Text = atm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub

    Private Sub mcPh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcPh.Click
        Try
            mpa = CDbl(megapascal.Text)
            br = mpa * 10
            bar.Text = br
            psi = br * 14.50326
            pound.Text = psi
            kpa = br * 100
            kilopound.Text = kpa
            'mpa = br * 0.1
            'megapascal.Text = mpa
            kgf = br * 1.01968
            kilogramforce.Text = kgf
            mmhg = br * 750.0188
            millimeterhg.Text = mmhg
            atm = br * 0.987167
            atmosphere.Text = atm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            kgf = CDbl(kilogramforce.Text)
            br = kgf * 0.9807
            bar.Text = br
            psi = br * 14.50326
            pound.Text = psi
            kpa = br * 100
            kilopound.Text = kpa
            mpa = br * 0.1
            megapascal.Text = mpa
            'kgf = br * 1.01968
            'kilogramforce.Text = kgf
            mmhg = br * 750.0188
            millimeterhg.Text = mmhg
            atm = br * 0.987167
            atmosphere.Text = atm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            mmhg = CDbl(millimeterhg.Text)
            br = mmhg * 0.001333
            bar.Text = br
            psi = br * 14.50326
            pound.Text = psi
            kpa = br * 100
            kilopound.Text = kpa
            mpa = br * 0.1
            megapascal.Text = mpa
            kgf = br * 1.01968
            kilogramforce.Text = kgf
            'mmhg = br * 750.0188
            'millimeterhg.Text = mmhg
            atm = br * 0.987167
            atmosphere.Text = atm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try



    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            atm = CDbl(atmosphere.Text)
            br = atm * 1.013
            bar.Text = br
            psi = br * 14.50326
            pound.Text = psi
            kpa = br * 100
            kilopound.Text = kpa
            mpa = br * 0.1
            megapascal.Text = mpa
            kgf = br * 1.01968
            kilogramforce.Text = kgf
            mmhg = br * 750.0188
            millimeterhg.Text = mmhg
            'atm = br * 0.987167
            'atmosphere.Text = atm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        bar.Clear()
        pound.Clear()
        kilopound.Clear()
        kilogramforce.Clear()
        megapascal.Clear()
        millimeterhg.Clear()
        atmosphere.Clear()

    End Sub
#End Region

#Region " Low Pressure"
    Private Sub mh2oB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mh2oB.Click
        Try
            metw = CDbl(meterofwater.Text)
            'metw = 
            'meterofwater.Text = metw\
            ftw = metw * 3.280696
            footofwater.Text = ftw
            cenm = ftw * 7.356339
            centimeterofmercury.Text = cenm
            inm = ftw * 2.896043
            inchesofmercury.Text = inm
            inw = ftw * 39.36572
            inchesofwater.Text = inw
            pas = ftw * 9806
            pascal.Text = pas
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try

    End Sub

    Private Sub fth2o_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fth2o.Click
        Try
            ftw = CDbl(footofwater.Text)
            metw = ftw * 0.304813
            meterofwater.Text = metw
            'ftw = metw * 3.280696
            'footofwater.Text = ftw
            cenm = ftw * 7.356339
            centimeterofmercury.Text = cenm
            inm = ftw * 2.896043
            inchesofmercury.Text = inm
            inw = ftw * 39.36572
            inchesofwater.Text = inw
            pas = ftw * 9806
            pascal.Text = pas
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try

    End Sub

    Private Sub cmHgB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmHgB.Click
        Try
            cenm = CDbl(centimeterofmercury.Text)
            metw = cenm * 0.135937
            meterofwater.Text = metw
            ftw = metw * 3.280696
            footofwater.Text = ftw
            'cenm = ftw * 7.356339
            'centimeterofmercury.Text = cenm
            inm = ftw * 2.896043
            inchesofmercury.Text = inm
            inw = ftw * 39.36572
            inchesofwater.Text = inw
            pas = ftw * 9806
            pascal.Text = pas
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub

    Private Sub inHgB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inHgB.Click
        Try
            inm = CDbl(inchesofmercury.Text)
            metw = inm * 0.345299
            meterofwater.Text = metw
            ftw = metw * 3.280696
            footofwater.Text = ftw
            cenm = ftw * 7.356339
            centimeterofmercury.Text = cenm
            'inm = ftw * 2.896043
            'inchesofmercury.Text = inm
            inw = ftw * 39.36572
            inchesofwater.Text = inw
            pas = ftw * 9806
            pascal.Text = pas
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub

    Private Sub inh2oB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inh2oB.Click
        Try
            inw = CDbl(inchesofwater.Text)
            metw = inw * 0.025403
            meterofwater.Text = metw
            ftw = metw * 3.280696
            footofwater.Text = ftw
            cenm = ftw * 7.356339
            centimeterofmercury.Text = cenm
            inm = ftw * 2.896043
            inchesofmercury.Text = inm
            'inw = ftw * 39.36572
            'inchesofwater.Text = inw
            pas = ftw * 9806
            pascal.Text = pas
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub

    Private Sub paB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paB.Click
        Try
            pas = CDbl(pascal.Text)
            metw = pas * 0.000102
            meterofwater.Text = metw
            ftw = metw * 3.280696
            footofwater.Text = ftw
            cenm = ftw * 7.356339
            centimeterofmercury.Text = cenm
            inm = ftw * 2.896043
            inchesofmercury.Text = inm
            inw = ftw * 39.36572
            inchesofwater.Text = inw
            'pas = ftw * 9806
            'pascal.Text = pas
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub

    Private Sub clearButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton2.Click
        meterofwater.Clear()
        footofwater.Clear()
        centimeterofmercury.Clear()
        inchesofmercury.Clear()
        inchesofwater.Clear()
        pascal.Clear()

    End Sub
#End Region

End Class
