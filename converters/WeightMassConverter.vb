Public Class WeightMassConverter
    Dim milli, centi, deci, cara, gra, deka, onc, hecto, pnd, kg, stn, ston, ton, lton As Double
#Region "Mai Converter Function"
    Public Sub massFunc()

        milli = centi * 10
        milligram.Text = milli

        centi = (milli / 10)
        centigram.Text = centi
        deci = centi / 10
        decigram.Text = deci
        cara = deci / 2
        carat.Text = cara
        gra = cara / 5
        gram.Text = gra
        deka = gra / 10
        dekagram.Text = deka
        onc = deka / 2.8349523125
        ounce.Text = onc
        hecto = onc / 3.5273961949580408
        hectogram.Text = hecto
        pnd = hecto / 4.5359237
        pound.Text = pnd
        kg = pnd / 2.2046226218487761
        kilogram.Text = kg
        stn = kg / 6.35029318
        stone.Text = stn
        ston = stn / 142.85714285714289
        shortTon.Text = ston
        ton = ston / 1.1023113109243881
        tonne.Text = ton
        lton = ton / 1.0160469088
        longTon.Text = lton

        milli = lton * 1016046908.8

    End Sub
#End Region


#Region "Milligram"
    Private Sub milliBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles milliBt.Click
        Try
            milli = CDbl(milligram.Text)

            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try
    End Sub

#End Region

#Region "Centigrams"
    Private Sub centiBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles centiBt.Click
        Try
            centi = CDbl(centigram.Text)
            'centi = milli / 10
            'centigram.Text = centi
            milli = centi * 10
            milligram.Text = milli
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try
    End Sub
#End Region

#Region "Decigrams"
    Private Sub deciBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deciBt.Click
        Try
            deci = CDbl(decigram.Text)
            'deci = centi / 10
            'decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try
    End Sub
#End Region

#Region "Carats"
    Private Sub caraBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caraBt.Click
        Try
            cara = CDbl(carat.Text)
            'cara = deci / 2
            'carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try

    End Sub
#End Region

#Region "Grams"
    Private Sub gramBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gramBt.Click
        Try
            gra = CDbl(gram.Text)
            'gra = cara / 5
            'gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try


    End Sub
#End Region

#Region "Dakagram"
    Private Sub dekaBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dekaBt.Click
        Try
            deka = CDbl(dekagram.Text)
            'deka = gra / 10
            'dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try


    End Sub
#End Region

#Region "Ounce"
    Private Sub oncBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oncBt.Click
        Try
            onc = CDbl(ounce.Text)
            'onc = deka / 2.8349523125
            'ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try


    End Sub

#End Region

#Region "Hectogram"
    Private Sub hectBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hectBt.Click
        Try
            hecto = CDbl(hectogram.Text)
            'hecto = onc / 3.5273961949580408
            'hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try

    End Sub
#End Region

#Region "Pounds"
    Private Sub pndBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pndBt.Click
        Try
            pnd = CDbl(pound.Text)
            'pnd = hecto / 4.5359237
            'pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try

    End Sub
#End Region

#Region "Kilogram"
    Private Sub kgBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kgBt.Click
        Try
            kg = CDbl(kilogram.Text)
            'kg = pnd / 2.2046226218487761
            'kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try


    End Sub
#End Region

#Region "Stones"
    Private Sub stnBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stnBt.Click
        Try
            stn = CDbl(stone.Text)
            'stn = kg / 6.35029318
            'stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try

    End Sub
#End Region

#Region "Short Tons"
    Private Sub stonBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stonBt.Click
        Try
            ston = CDbl(shortTon.Text)
            'ston = stn / 142.85714285714289
            'shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try



    End Sub
#End Region

#Region "Tonne"
    Private Sub tonBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tonBt.Click
        Try
            ton = CDbl(tonne.Text)
            'ton = ston / 1.1023113109243881
            'tonne.Text = ton
            lton = ton / 1.0160469088
            longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try


    End Sub
#End Region

#Region "Long Ton"
    Private Sub ltonBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltonBt.Click
        Try
            lton = CDbl(longTon.Text)
            'lton = ton / 1.0160469088
            'longTon.Text = lton

            milli = lton * 1016046908.8
            milligram.Text = milli
            centi = milli / 10
            centigram.Text = centi
            deci = centi / 10
            decigram.Text = deci
            cara = deci / 2
            carat.Text = cara
            gra = cara / 5
            gram.Text = gra
            deka = gra / 10
            dekagram.Text = deka
            onc = deka / 2.8349523125
            ounce.Text = onc
            hecto = onc / 3.5273961949580408
            hectogram.Text = hecto
            pnd = hecto / 4.5359237
            pound.Text = pnd
            kg = pnd / 2.2046226218487761
            kilogram.Text = kg
            stn = kg / 6.35029318
            stone.Text = stn
            ston = stn / 142.85714285714289
            shortTon.Text = ston
            ton = ston / 1.1023113109243881
            tonne.Text = ton

        Catch ex As Exception
            MessageBox.Show("Give a Valid Number")
        End Try


    End Sub
#End Region

#Region "Clear"
    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        milligram.Clear()
        centigram.Clear()
        decigram.Clear()
        carat.Clear()
        gram.Clear()
        dekagram.Clear()
        ounce.Clear()
        hectogram.Clear()
        pound.Clear()
        kilogram.Clear()
        shortTon.Clear()
        tonne.Clear()
        longTon.Clear()
        stone.Clear()



    End Sub
#End Region
End Class
