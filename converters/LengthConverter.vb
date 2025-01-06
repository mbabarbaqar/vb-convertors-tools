Public Class lengthConverterForm

    Dim ang, nano, mic, milli, centi, pic, inc, fet, spa, han, fath, lin, yar, cha, rod, met, kilo, mil, nmil As Double

#Region " Anstrons "
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Try
            ang = CDbl(angstron.Text)
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = ang / 42175176
            pica.Text = pic
            inc = centi / 2.54
            inch.Text = inc
            fet = inc / 12
            feet.Text = fet
            spa = inc / 9
            span.Text = spa
            han = inc / 4
            hand.Text = han
            fath = fet / 6
            fathon.Text = fath
            lin = han / 1.98
            link.Text = lin
            yar = fet / 3
            yard.Text = yar
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            met = milli / 1000
            meter.Text = met
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub
#End Region

#Region " Nanometer "
    Private Sub nanoRadio2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nanoRadio2.Click
        Try
            ang = nano / 0.1
            angstron.Text = ang
            'nano = ang / 10
            'nanometer.Text = nano
            nano = CDbl(nanometer.Text)
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = ang / 42175176
            pica.Text = pic
            inc = centi / 2.54
            inch.Text = inc
            fet = inc / 12
            feet.Text = fet
            spa = inc / 9
            span.Text = spa
            han = inc / 4
            hand.Text = han
            fath = fet / 6
            fathon.Text = fath
            lin = han / 1.98
            link.Text = lin
            yar = fet / 3
            yard.Text = yar
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            met = milli / 1000
            meter.Text = met
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub
#End Region

#Region " Microns"


    Private Sub micronsRadio3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles micronsRadio3.Click
        Try
            'mic = ang / 10000
            'microns.Text = mic
            mic = CDbl(microns.Text)
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = ang / 42175176
            pica.Text = pic
            inc = centi / 2.54
            inch.Text = inc
            fet = inc / 12
            feet.Text = fet
            spa = inc / 9
            span.Text = spa
            han = inc / 4
            hand.Text = han
            fath = fet / 6
            fathon.Text = fath
            lin = han / 1.98
            link.Text = lin
            yar = fet / 3
            yard.Text = yar
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            met = milli / 1000
            meter.Text = met
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Millimeters"
    Private Sub milliRadio4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles milliRadio4.Click
        Try
            'milli = mic / 1000
            'millimeters.Text = milli
            milli = CDbl(millimeters.Text)
            centi = milli / 10
            centimeters.Text = centi
            pic = milli / 4.2175176
            pica.Text = pic
            inc = centi / 2.54
            inch.Text = inc
            fet = inc / 12
            feet.Text = fet
            spa = inc / 9
            span.Text = spa
            han = inc / 4
            hand.Text = han
            fath = fet / 6
            fathon.Text = fath
            lin = han / 1.98
            link.Text = lin
            yar = fet / 3
            yard.Text = yar
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            met = milli / 1000
            meter.Text = met
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Centimeters"
    Private Sub centiRadio5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles centiRadio5.Click
        Try
            'centi = milli / 10
            'centimeters.Text = centi
            centi = CDbl(centimeters.Text)
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = centi / 2.54
            inch.Text = inc
            fet = inc / 12
            feet.Text = fet
            spa = inc / 9
            span.Text = spa
            han = inc / 4
            hand.Text = han
            fath = fet / 6
            fathon.Text = fath
            lin = han / 1.98
            link.Text = lin
            yar = fet / 3
            yard.Text = yar
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            met = centi / 100
            meter.Text = met
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub
#End Region

#Region "Pica"
    Private Sub picRadio6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRadio6.Click
        Try
            'pic = centi * 2.3710630158366142
            'pica.Text = pic
            pic = CDbl(pica.Text)
            inc = pic / 6.022500060225001
            inch.Text = inc
            fet = inc / 12
            feet.Text = fet
            spa = inc / 9
            span.Text = spa
            han = inc / 4
            hand.Text = han
            fath = fet / 6
            fathon.Text = fath
            lin = han / 1.98
            link.Text = lin
            yar = fet / 3
            yard.Text = yar
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            met = han / 9.84251968503937
            meter.Text = met
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Inch"
    Private Sub incRadio7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles incRadio7.Click
        Try
            'inc = pic / 6.022500060225001
            'inch.Text = inc
            inc = CDbl(inch.Text)
            fet = inc / 12
            feet.Text = fet
            spa = inc / 9
            span.Text = spa
            han = inc / 4
            hand.Text = han
            fath = fet / 6
            fathon.Text = fath
            lin = han / 1.98
            link.Text = lin
            yar = fet / 3
            yard.Text = yar
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            met = han / 9.84251968503937
            meter.Text = met
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub
#End Region

#Region "Hand"

    Private Sub handRadio8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles handRadio8.Click
        Try
            'han = inc / 4
            'hand.Text = han
            han = CDbl(hand.Text)
            spa = han / 2.25
            span.Text = spa
            fet = spa / 1.333333333333333
            feet.Text = fet
            fath = fet / 6
            fathon.Text = fath
            lin = han / 1.98
            link.Text = lin
            yar = fet / 3
            yard.Text = yar
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            met = han / 9.84251968503937
            meter.Text = met
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Link"
    Private Sub linkRadio9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linkRadio9.Click
        Try
            'lin = han / 1.98
            'link.Text = lin
            lin = CDbl(link.Text)
            spa = lin / 1.136363636363636
            span.Text = spa
            fet = spa / 1.333333333333333
            feet.Text = fet
            fath = fet / 6
            fathon.Text = fath
            yar = fet / 3
            yard.Text = yar
            met = yar / 1.093613298337708
            meter.Text = met
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub
#End Region

#Region "Spans"
    Private Sub spaRadio10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spaRadio10.Click
        Try
            'spa = lin / 1.136363636363636
            'span.Text = spa
            spa = CDbl(span.Text)
            fet = spa / 1.333333333333333
            feet.Text = fet
            fath = fet / 6
            fathon.Text = fath
            yar = fet / 3
            yard.Text = yar
            met = yar / 1.093613298337708
            meter.Text = met
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
            lin = han / 1.98
            link.Text = lin
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Feet"
    Private Sub feetRadio11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles feetRadio11.Click
        Try
            'fet = spa / 1.333333333333333
            'feet.Text = fet
            fet = CDbl(feet.Text)
            fath = fet / 6
            fathon.Text = fath
            yar = fet / 3
            yard.Text = yar
            met = yar / 1.093613298337708
            meter.Text = met
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
            lin = han / 1.98
            link.Text = lin
            spa = lin / 1.136363636363636
            span.Text = spa

        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Yards"
    Private Sub yardRadio12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yardRadio12.Click
        Try
            yar = CDbl(yard.Text)
            fath = yar / 2
            fathon.Text = fath
            met = yar / 1.093613298337708
            meter.Text = met
            cha = yar / 22
            chain.Text = cha
            rod = yar / 5.5
            rods.Text = rod
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
            lin = han / 1.98
            link.Text = lin
            spa = lin / 1.136363636363636
            span.Text = spa
            fet = spa / 1.333333333333333
            feet.Text = fet
            'yar = fet / 3
            'yard.Text = yar

        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Meters"
    Private Sub meterRadio13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles meterRadio13.Click
        Try
            'met = yar / 1.093613298337708
            'meter.Text = met
            met = CDbl(meter.Text)
            fath = met / 1.8288
            fathon.Text = fath
            rod = fath / 2.75
            rods.Text = rod
            cha = rod / 4
            chain.Text = cha
            kilo = met / 1000
            kilometer.Text = kilo
            mil = cha / 80
            miles.Text = mil
            nmil = met / 1852
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
            lin = han / 1.98
            link.Text = lin
            spa = lin / 1.136363636363636
            span.Text = spa
            fet = spa / 1.333333333333333
            feet.Text = fet
            yar = fet / 3
            yard.Text = yar
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Fathom"
    Private Sub fathRadio14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fathRadio14.Click
        Try
            'fath = met / 1.8288
            'fathon.Text = fath
            fath = CDbl(fathon.Text)
            rod = fath / 2.75
            rods.Text = rod
            cha = rod / 4
            chain.Text = cha
            kilo = cha / 49.709695378986723
            kilometer.Text = kilo
            mil = kilo / 1.609344
            miles.Text = mil
            nmil = mil / 1.1507794480235429
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
            lin = han / 1.98
            link.Text = lin
            spa = lin / 1.136363636363636
            span.Text = spa
            fet = spa / 1.333333333333333
            feet.Text = fet
            yar = fet / 3
            yard.Text = yar
            met = yar / 1.093613298337708
            meter.Text = met
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Rods"
    Private Sub rodsRadio15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rodsRadio15.Click
        Try
            'rod = fath / 2.75
            'rods.Text = rod
            rod = CDbl(rods.Text)
            cha = rod / 4
            chain.Text = cha
            kilo = cha / 49.709695378986723
            kilometer.Text = kilo
            mil = kilo / 1.609344
            miles.Text = mil
            nmil = mil / 1.1507794480235429
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
            lin = han / 1.98
            link.Text = lin
            spa = lin / 1.136363636363636
            span.Text = spa
            fet = spa / 1.333333333333333
            feet.Text = fet
            yar = fet / 3
            yard.Text = yar
            met = yar / 1.093613298337708
            meter.Text = met
            fath = met / 1.8288
            fathon.Text = fath

        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try
    End Sub
#End Region

#Region "Chains"
    Private Sub chainRadio16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chainRadio16.Click
        Try
            'cha = rod / 4
            'chain.Text = cha
            cha = CDbl(chain.Text)
            kilo = cha / 49.709695378986723
            kilometer.Text = kilo
            mil = kilo / 1.609344
            miles.Text = mil
            nmil = mil / 1.1507794480235429
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
            lin = han / 1.98
            link.Text = lin
            spa = lin / 1.136363636363636
            span.Text = spa
            fet = spa / 1.333333333333333
            feet.Text = fet
            yar = fet / 3
            yard.Text = yar
            met = yar / 1.093613298337708
            meter.Text = met
            fath = met / 1.8288
            fathon.Text = fath
            rod = fath / 2.75
            rods.Text = rod
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Kilometers"
    Private Sub kiloRadio17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kiloRadio17.Click
        Try
            'kilo = cha / 49.709695378986723
            'kilometer.Text = kilo
            kilo = CDbl(kilometer.Text)
            mil = kilo / 1.609344
            miles.Text = mil
            nmil = mil / 1.1507794480235429
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
            lin = han / 1.98
            link.Text = lin
            spa = lin / 1.136363636363636
            span.Text = spa
            fet = spa / 1.333333333333333
            feet.Text = fet
            yar = fet / 3
            yard.Text = yar
            met = yar / 1.093613298337708
            meter.Text = met
            fath = met / 1.8288
            fathon.Text = fath
            rod = fath / 2.75
            rods.Text = rod
            cha = rod / 4
            chain.Text = cha
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Miles"
    Private Sub mileRadio18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mileRadio18.Click
        Try
            'mil = kilo / 1.609344
            'miles.Text = mil
            mil = CDbl(miles.Text)
            nmil = mil / 1.1507794480235429
            naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
            lin = han / 1.98
            link.Text = lin
            spa = lin / 1.136363636363636
            span.Text = spa
            fet = spa / 1.333333333333333
            feet.Text = fet
            yar = fet / 3
            yard.Text = yar
            met = yar / 1.093613298337708
            meter.Text = met
            fath = met / 1.8288
            fathon.Text = fath
            rod = fath / 2.75
            rods.Text = rod
            cha = rod / 4
            chain.Text = cha
            kilo = cha / 49.709695378986723
            kilometer.Text = kilo
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Nautical Miles"
    Private Sub nmileRadio19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmileRadio19.Click
        Try
            nmil = CDbl(naucticalMile.Text)
            'nmil = mil / 1.1507794480235429
            'naucticalMile.Text = nmil

            ang = (nmil * 18520000000000)
            angstron.Text = ang
            nano = ang / 10
            nanometer.Text = nano
            mic = ang / 10000
            microns.Text = mic
            milli = mic / 1000
            millimeters.Text = milli
            centi = milli / 10
            centimeters.Text = centi
            pic = centi * 2.3710630158366142
            pica.Text = pic
            inc = pic / 6.022500060225001
            inch.Text = inc
            han = inc / 4
            hand.Text = han
            lin = han / 1.98
            link.Text = lin
            spa = lin / 1.136363636363636
            span.Text = spa
            fet = spa / 1.333333333333333
            feet.Text = fet
            yar = fet / 3
            yard.Text = yar
            met = yar / 1.093613298337708
            meter.Text = met
            fath = met / 1.8288
            fathon.Text = fath
            rod = fath / 2.75
            rods.Text = rod
            cha = rod / 4
            chain.Text = cha
            kilo = cha / 49.709695378986723
            kilometer.Text = kilo
            mil = kilo / 1.609344
            miles.Text = mil
        Catch ex As Exception
            MessageBox.Show("Give A Valid Number")
        End Try

    End Sub
#End Region

#Region "Clear"
    Private Sub lengthClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lengthClear.Click
        angstron.Clear()
        nanometer.Clear()
        microns.Clear()
        millimeters.Clear()
        centimeters.Clear()
        pica.Clear()
        inch.Clear()
        feet.Clear()
        span.Clear()
        hand.Clear()
        fathon.Clear()
        link.Clear()
        yard.Clear()
        chain.Clear()
        rods.Clear()
        meter.Clear()
        kilometer.Clear()
        miles.Clear()
        naucticalMile.Clear()
    End Sub
#End Region


End Class