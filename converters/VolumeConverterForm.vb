Public Class VolumeConverterForm
    Dim cmc, ltr, meterc, inchc, footc, yardc, floz, flpt, flqt, usgal, impgal, usbrl As Double
#Region "centimeter cube"
    Private Sub cmB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmB.Click
        Try
            cmc = CDbl(centimetercube.Text)
            'cmc = 
            'centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub
#End Region

#Region "Litres"
    Private Sub ltrB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltrB.Click
        Try

            ltr = CDbl(litre.Text)
            cmc = ltr * 1000
            centimetercube.Text = cmc
            'ltr = cmc * 0.001
            'litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub
#End Region

#Region "Meter Cube"
    Private Sub mcB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcB.Click
        Try

            meterc = CDbl(metercube.Text)
            cmc = meterc * 1000000
            centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            'meterc = cmc * 0.000001
            'metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Inch Cube"
    Private Sub incB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles incB.Click
        Try

            inchc = CDbl(inchcube.Text)
            cmc = inchc * 16.39
            centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            'inchc = cmc * 0.061024
            'inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Foot Cube"
    Private Sub fcB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fcB.Click
        Try

            footc = CDbl(footcube.Text)
            cmc = footc * 28317
            centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            'footc = cmc * 0.000035
            'footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try



    End Sub
#End Region

#Region "yard cube"
    Private Sub ycB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ycB.Click
        Try

            yardc = CDbl(yardcube.Text)
            cmc = yardc * 765000
            centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            'yardc = cmc * 0.00000131
            'yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Fl Ounce"
    Private Sub floB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles floB.Click
        Try

            floz = CDbl(flounce.Text)
            cmc = floz * 29.57
            centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            'floz = cmc * 0.03381
            'flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Fl Pints"
    Private Sub flpB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flpB.Click
        Try

            flpt = CDbl(flpint.Text)
            cmc = flpt * 473.2
            centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            'flpt = cmc * 0.00211
            'flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Fl Quarters"
    Private Sub flqB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flqB.Click
        Try

            flqt = CDbl(flquarter.Text)
            cmc = flqt * 946.4
            centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            'flqt = cmc * 0.00106
            'flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "US Gallons"
    Private Sub usgB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usgB.Click
        Try

            usgal = CDbl(usgallons.Text)
            cmc = usgal * 3785
            centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            'usgal = cmc * 0.000264
            'usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Imperial Gallons"
    Private Sub impgB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles impgB.Click
        Try

            impgal = CDbl(impgallons.Text)
            cmc = impgal * 4545
            centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            'impgal = cmc * 0.00022
            'impgallons.Text = impgal
            usbrl = cmc * 0.000006
            usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "US Barrel"
    Private Sub usbB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usbB.Click
        Try

            usbrl = CDbl(usbarrel.Text)
            cmc = usbrl * 158970
            centimetercube.Text = cmc
            ltr = cmc * 0.001
            litre.Text = ltr
            meterc = cmc * 0.000001
            metercube.Text = meterc
            inchc = cmc * 0.061024
            inchcube.Text = inchc
            footc = cmc * 0.000035
            footcube.Text = footc
            yardc = cmc * 0.00000131
            yardcube.Text = yardc
            floz = cmc * 0.03381
            flounce.Text = floz
            flpt = cmc * 0.00211
            flpint.Text = flpt
            flqt = cmc * 0.00106
            flquarter.Text = flqt
            usgal = cmc * 0.000264
            usgallons.Text = usgal
            impgal = cmc * 0.00022
            impgallons.Text = impgal
            'usbrl = cmc * 0.000006
            'usbarrel.Text = usbrl
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Clear Button"
    Private Sub clearButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton11.Click
        centimetercube.Clear()
        litre.Clear()
        metercube.Clear()
        inchcube.Clear()
        footcube.Clear()
        yardcube.Clear()
        flounce.Clear()
        flpint.Clear()
        flquarter.Clear()
        usgallons.Clear()
        impgallons.Clear()
        usbarrel.Clear()

    End Sub
#End Region

End Class
