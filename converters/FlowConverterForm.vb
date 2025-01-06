Public Class FlowConverterForm
    Dim litPs, litPm, galPm, metercPh, footcPs, footcPm, footcPh, barrelPh, barrelPd, yardcPm As Double
    Dim nmch, scfh, scfm As Double
    Dim kgPhr, lbPhr, kgPse, tnPhr As Double

#Region "Liquid Flow Convert"

#Region "Liters Per Second"
    Private Sub wekB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lPs.Click
        Try
            litPs = CDbl(literPsec.Text)
            litPm = litPs * 60
            literPmin.Text = litPm
            galPm = litPs * 15.85
            gallonPmin.Text = galPm
            metercPh = litPs * 3.6
            metercubePhr.Text = metercPh
            footcPs = litPs * 0.002228
            footcubePsec.Text = footcPs
            footcPm = litPs * 2.119093
            footcubePmin.Text = footcPm
            footcPh = litPs * 127.1197
            footcubePhr.Text = footcPh
            barrelPh = litPs * 22.66
            barrelsPhr.Text = barrelPh
            barrelPd = litPs * 543.8
            barrelsPday.Text = barrelPd
            yardcPm = litPs / 12.74258
            yardcubePmin.Text = yardcPm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try
    End Sub
#End Region

#Region "Formulas Example"
    Public Sub Example()
        Try
            litPs = CDbl(literPsec.Text)
            litPm = litPs * 60
            literPmin.Text = litPm
            galPm = litPs * 15.85
            gallonPmin.Text = galPm
            metercPh = litPs * 3.6
            metercubePhr.Text = metercPh
            footcPs = litPs * 0.002228
            footcubePsec.Text = footcPs
            footcPm = litPs * 2.119093
            footcubePmin.Text = footcPm
            footcPh = litPs * 127.1197
            footcubePhr.Text = footcPh
            barrelPh = litPs * 22.66
            barrelsPhr.Text = barrelPh
            barrelPd = litPs * 543.8
            barrelsPday.Text = barrelPd
            yardcPm = litPs / 12.74258
            yardcubePmin.Text = yardcPm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try
    End Sub
#End Region

#Region "Liters Per Minute"
    Private Sub lPm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lPm.Click
        Try
            litPm = CDbl(literPmin.Text)
            'litPm = litPs * 60
            'literPmin.Text = litPm

            litPs = litPm * 0.016666
            literPsec.Text = litPs
            galPm = litPs * 15.85
            gallonPmin.Text = galPm
            metercPh = litPs * 3.6
            metercubePhr.Text = metercPh
            footcPs = litPs * 0.002228
            footcubePsec.Text = footcPs
            footcPm = litPs * 2.119093
            footcubePmin.Text = footcPm
            footcPh = litPs * 127.1197
            footcubePhr.Text = footcPh
            barrelPh = litPs * 22.66
            barrelsPhr.Text = barrelPh
            barrelPd = litPs * 543.8
            barrelsPday.Text = barrelPd
            yardcPm = litPs / 12.74258
            yardcubePmin.Text = yardcPm

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub
#End Region

#Region "Gallons Per Minute"
    Private Sub gPm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gPm.Click
        Try
            galPm = CDbl(gallonPmin.Text)

            litPs = galPm * 0.06309
            literPsec.Text = litPs
            litPm = litPs * 60
            literPmin.Text = litPm
            'galPm = litPs * 15.85
            'gallonPmin.Text = galPm
            metercPh = litPs * 3.6
            metercubePhr.Text = metercPh
            footcPs = litPs * 0.002228
            footcubePsec.Text = footcPs
            footcPm = litPs * 2.119093
            footcubePmin.Text = footcPm
            footcPh = litPs * 127.1197
            footcubePhr.Text = footcPh
            barrelPh = litPs * 22.66
            barrelsPhr.Text = barrelPh
            barrelPd = litPs * 543.8
            barrelsPday.Text = barrelPd
            yardcPm = litPs / 12.74258
            yardcubePmin.Text = yardcPm

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "MeterCube Per Hour"
    Private Sub mcPh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcPh.Click
        Try
            metercPh = CDbl(metercubePhr.Text)

            litPs = metercPh * 0.277778
            literPsec.Text = litPs
            litPm = litPs * 60
            literPmin.Text = litPm
            galPm = litPs * 15.85
            gallonPmin.Text = galPm
            'metercPh = litPs * 3.6
            'metercubePhr.Text = metercPh
            footcPs = litPs * 0.002228
            footcubePsec.Text = footcPs
            footcPm = litPs * 2.119093
            footcubePmin.Text = footcPm
            footcPh = litPs * 127.1197
            footcubePhr.Text = footcPh
            barrelPh = litPs * 22.66
            barrelsPhr.Text = barrelPh
            barrelPd = litPs * 543.8
            barrelsPday.Text = barrelPd
            yardcPm = litPs / 12.74258
            yardcubePmin.Text = yardcPm

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Foot Cube Per Seconds"
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            footcPs = CDbl(footcubePsec.Text)

            litPs = footcPs * 28.32
            literPsec.Text = litPs
            litPm = litPs * 60
            literPmin.Text = litPm
            galPm = litPs * 15.85
            gallonPmin.Text = galPm
            metercPh = litPs * 3.6
            metercubePhr.Text = metercPh
            'footcPs = litPs * 0.002228
            'footcubePsec.Text = footcPs
            footcPm = litPs * 2.119093
            footcubePmin.Text = footcPm
            footcPh = litPs * 127.1197
            footcubePhr.Text = footcPh
            barrelPh = litPs * 22.66
            barrelsPhr.Text = barrelPh
            barrelPd = litPs * 543.8
            barrelsPday.Text = barrelPd
            yardcPm = litPs / 12.74258
            yardcubePmin.Text = yardcPm

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "footCube Per Minutes"
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            footcPm = CDbl(footcubePmin.Text)

            litPs = footcPm * 0.4719
            literPsec.Text = litPs
            litPm = litPs * 60
            literPmin.Text = litPm
            galPm = litPs * 15.85
            gallonPmin.Text = galPm
            metercPh = litPs * 3.6
            metercubePhr.Text = metercPh
            footcPs = litPs * 0.002228
            footcubePsec.Text = footcPs
            'footcPm = litPs * 2.119093
            'footcubePmin.Text = footcPm
            footcPh = litPs * 127.1197
            footcubePhr.Text = footcPh
            barrelPh = litPs * 22.66
            barrelsPhr.Text = barrelPh
            barrelPd = litPs * 543.8
            barrelsPday.Text = barrelPd
            yardcPm = litPs / 12.74258
            yardcubePmin.Text = yardcPm

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "FootCube Per Hours"
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            footcPh = CDbl(footcubePhr.Text)

            litPs = footcPh * 0.007867
            literPsec.Text = litPs
            litPm = litPs * 60
            literPmin.Text = litPm
            galPm = litPs * 15.85
            gallonPmin.Text = galPm
            metercPh = litPs * 3.6
            metercubePhr.Text = metercPh
            footcPs = litPs * 0.002228
            footcubePsec.Text = footcPs
            footcPm = litPs * 2.119093
            footcubePmin.Text = footcPm
            'footcPh = litPs * 127.1197
            'footcubePhr.Text = footcPh
            barrelPh = litPs * 22.66
            barrelsPhr.Text = barrelPh
            barrelPd = litPs * 543.8
            barrelsPday.Text = barrelPd
            yardcPm = litPs / 12.74258
            yardcubePmin.Text = yardcPm

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "Barrels Per Hour"
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            barrelPh = CDbl(barrelsPhr.Text)

            litPs = barrelPh * 0.04415
            literPsec.Text = litPs
            litPm = litPs * 60
            literPmin.Text = litPm
            galPm = litPs * 15.85
            gallonPmin.Text = galPm
            metercPh = litPs * 3.6
            metercubePhr.Text = metercPh
            footcPs = litPs * 0.002228
            footcubePsec.Text = footcPs
            footcPm = litPs * 2.119093
            footcubePmin.Text = footcPm
            footcPh = litPs * 127.1197
            footcubePhr.Text = footcPh
            'barrelPh = litPs * 22.66
            'barrelsPhr.Text = barrelPh
            barrelPd = litPs * 543.8
            barrelsPday.Text = barrelPd
            yardcPm = litPs / 12.74258
            yardcubePmin.Text = yardcPm

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub
#End Region

#Region "Barrels Per Day"
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            barrelPd = CDbl(barrelsPday.Text)

            litPs = barrelPd * 0.00184
            literPsec.Text = litPs
            litPm = litPs * 60
            literPmin.Text = litPm
            galPm = litPs * 15.85
            gallonPmin.Text = galPm
            metercPh = litPs * 3.6
            metercubePhr.Text = metercPh
            footcPs = litPs * 0.002228
            footcubePsec.Text = footcPs
            footcPm = litPs * 2.119093
            footcubePmin.Text = footcPm
            footcPh = litPs * 127.1197
            footcubePhr.Text = footcPh
            barrelPh = litPs * 22.66
            barrelsPhr.Text = barrelPh
            'barrelPd = litPs * 543.8
            'barrelsPday.Text = barrelPd
            yardcPm = litPs / 12.74258
            yardcubePmin.Text = yardcPm

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub
#End Region

#Region "YardCube Per Minute"
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            yardcPm = CDbl(yardcubePmin.Text)

            litPs = yardcPm * 12.74258
            literPsec.Text = litPs
            litPm = litPs * 60
            literPmin.Text = litPm
            galPm = litPs * 15.85
            gallonPmin.Text = galPm
            metercPh = litPs * 3.6
            metercubePhr.Text = metercPh
            footcPs = litPs * 0.002228
            footcubePsec.Text = footcPs
            footcPm = litPs * 2.119093
            footcubePmin.Text = footcPm
            footcPh = litPs * 127.1197
            footcubePhr.Text = footcPh
            barrelPh = litPs * 22.66
            barrelsPhr.Text = barrelPh
            barrelPd = litPs * 543.8
            barrelsPday.Text = barrelPd
            'yardcPm = litPs / 12.74258
            'yardcubePmin.Text = yardcPm

        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try



    End Sub
#End Region

#Region "Clear Button"
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        literPsec.Clear()
        literPmin.Clear()
        gallonPmin.Clear()
        metercubePhr.Clear()
        footcubePhr.Clear()
        footcubePmin.Clear()
        footcubePsec.Clear()
        barrelsPhr.Clear()
        barrelsPday.Clear()
        yardcubePmin.Clear()

    End Sub
#End Region

#End Region



#Region "Gas Flow Conversion"

    Private Sub nmcPhB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmcPhB.Click
        Try
            nmch = CDbl(nmcPhr.Text)

            scfh = nmch * 35.31073
            scfPhr.Text = scfh
            scfm = nmch * 0.588582
            scfPmin.Text = scfm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try
    End Sub

    Private Sub scfPhB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scfPhB.Click
        Try
            scfh = CDbl(scfPhr.Text)

            'scfh = nmch * 35.31073
            'scfPhr.Text = scfh
            nmch = scfh * 0.02832
            nmcPhr.Text = nmch
            scfm = nmch * 0.588582
            scfPmin.Text = scfm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try
    End Sub

    Private Sub scfPmB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scfPmB.Click
        Try
            scfm = CDbl(scfPmin.Text)

            nmch = scfm * 1.699
            nmcPhr.Text = nmch
            scfh = nmch * 35.31073
            scfPhr.Text = scfh
            'scfm = nmch * 0.588582
            'scfPmin.Text = scfm
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub

    Private Sub clearButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton10.Click
        nmcPhr.Clear()
        scfPhr.Clear()
        scfPmin.Clear()

    End Sub
#End Region


#Region "Mass Flow Conversion"

    Private Sub kgPhB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kgPhB.Click
        Try
            kgPhr = CDbl(kilogramPhour.Text)

            lbPhr = kgPhr * 2.204586
            poundPhour.Text = lbPhr
            kgPse = kgPhr * 0.000278
            kilogramPsecond.Text = kgPse
            tnPhr = kgPhr * 0.001
            tonPhour.Text = tnPhr
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try
    End Sub

    Private Sub lbPhB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbPhB.Click
        Try
            lbPhr = CDbl(poundPhour.Text)

            'lbPhr = kgPhr * 2.204586
            'poundPhour.Text = lbPhr
            kgPhr = lbPhr * 0.4536
            kilogramPhour.Text = kgPhr
            kgPse = kgPhr * 0.000278
            kilogramPsecond.Text = kgPse
            tnPhr = kgPhr * 0.001
            tonPhour.Text = tnPhr
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub

    Private Sub kgPsB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kgPsB.Click
        Try
            kgPse = CDbl(kilogramPsecond.Text)

            kgPhr = kgPse * 3600
            kilogramPhour.Text = kgPhr
            lbPhr = kgPhr * 2.204586
            poundPhour.Text = lbPhr
            'kgPse = kgPhr * 0.000278
            'kilogramPsecond.Text = kgPse
            tnPhr = kgPhr * 0.001
            tonPhour.Text = tnPhr
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try

    End Sub

    Private Sub tPhB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPhB.Click
        Try
            tnPhr = CDbl(tonPhour.Text)

            kgPhr = tnPhr * 1000
            kilogramPhour.Text = kgPhr
            lbPhr = kgPhr * 2.204586
            poundPhour.Text = lbPhr
            kgPse = kgPhr * 0.000278
            kilogramPsecond.Text = kgPse
            'tnPhr = kgPhr * 0.001
            'tonPhour.Text = tnPhr
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Value")
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kilogramPhour.Clear()
        poundPhour.Clear()
        kilogramPsecond.Clear()
        tonPhour.Clear()

    End Sub
#End Region

End Class
