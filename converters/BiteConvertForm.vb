Public Class BiteConvertForm
    Dim ona, ex, pet, ter, gig, meg, kil, hect, dca, dci, cent, mill, mic, nan, pic, fem, att As Decimal
#Region "All Fields"

#Region "All Fields"
    Private Sub exB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exB.Click
        Try
            ex = CDec(exa.Text)
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region


#Region "All Fields"
    Private Sub peB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles peB.Click
        Try
            pet = CDec(peta.Text)

            ex = pet * 10 ^ 3
            exa.Text = ex
            'pet = ex / 10 ^ 3
            'peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try

    End Sub
#End Region


#Region "All Fields"
    Private Sub teB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teB.Click
        Try
            ter = CDec(tera.Text)

            ex = ter * 10 ^ 6
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            'ter = ex / 10 ^ 6
            'tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region

#Region "All Fields"
    Private Sub giB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles giB.Click
        Try
            gig = CDec(giga.Text)

            ex = gig * 10 ^ 9
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            'gig = ex / 10 ^ 9
            'giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region

#Region "All Fields"
    Private Sub meB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles meB.Click
        Try
            meg = CDec(mega.Text)

            ex = meg * 10 ^ 12
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            'meg = ex / 10 ^ 12
            'mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region

#Region "All Fields"
    Private Sub kiB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kiB.Click
        Try
            kil = CDec(kilo.Text)

            ex = kil * 10 ^ 15
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            'kil = ex / 10 ^ 15
            'kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region

#Region "All Fields"

    Private Sub heB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles heB.Click
        Try
            hect = CDec(hecto.Text)

            ex = hect * 10 ^ 16
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            'hect = ex / 10 ^ 16
            'hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region

#Region "All Fields"
    Private Sub deB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deB.Click
        Try
            dca = CDec(deca.Text)

            ex = dca * 10 ^ 17
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            'dca = ex / 10 ^ 17
            'deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region


#Region "All Fields"

    Private Sub oneB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oneB.Click
        Try
            ona = CDec(one.Text)

            ex = ona * 10 ^ 18
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            'ona = ex / 10 ^ 18
            'one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region


#Region "All Fields"

    Private Sub dcB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dcB.Click
        Try
            dci = CDec(deci.Text)

            ex = dci * 10 ^ 19
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            'dci = ex / 10 ^ 19
            'deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region

#Region "All Fields"

    Private Sub ceB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ceB.Click
        Try
            cent = CDec(centi.Text)

            ex = cent * 10 ^ 20
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            'cent = ex / 10 ^ 20
            'centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region


#Region "All Fields"
    Private Sub miB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miB.Click
        Try
            mill = CDec(milli.Text)

            ex = mill * 10 ^ 21
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            'mill = ex / 10 ^ 21
            'milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region


#Region "All Fields"

    Private Sub mcB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcB.Click
        Try
            mic = CDec(micro.Text)

            ex = mic * 10 ^ 24
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            'mic = ex / 10 ^ 24
            'micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region


#Region "All Fields"

    Private Sub naB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles naB.Click
        Try
            nan = CDec(nano.Text)

            ex = nan * 10 ^ 27
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            'nan = ex / 10 ^ 27
            'nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try



    End Sub
#End Region


#Region "All Fields"
    Private Sub piB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piB.Click
        Try
            pic = CDec(pico.Text)

            ex = pic * 10 ^ 30
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            'pic = ex / 10 ^ 30
            'pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region


#Region "All Fields"
    Private Sub feB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles feB.Click
        Try
            fem = CDec(femto.Text)

            ex = fem * 10 ^ 33
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            'fem = ex / 10 ^ 33
            'femto.Text = fem
            att = ex / 10 ^ 36
            atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region

#Region "All Fields"

    Private Sub atB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atB.Click
        Try
            att = CDec(atto.Text)

            ex = att * 10 ^ 36
            exa.Text = ex
            pet = ex / 10 ^ 3
            peta.Text = pet
            ter = ex / 10 ^ 6
            tera.Text = ter
            gig = ex / 10 ^ 9
            giga.Text = gig
            meg = ex / 10 ^ 12
            mega.Text = meg
            kil = ex / 10 ^ 15
            kilo.Text = kil
            hect = ex / 10 ^ 16
            hecto.Text = hect
            dca = ex / 10 ^ 17
            deca.Text = dca
            ona = ex / 10 ^ 18
            one.Text = ona

            dci = ex / 10 ^ 19
            deci.Text = dci
            cent = ex / 10 ^ 20
            centi.Text = cent
            mill = ex / 10 ^ 21
            milli.Text = mill
            mic = ex / 10 ^ 24
            micro.Text = mic
            nan = ex / 10 ^ 27
            nano.Text = nan
            pic = ex / 10 ^ 30
            pico.Text = pic
            fem = ex / 10 ^ 33
            femto.Text = fem
            'att = ex / 10 ^ 36
            'atto.Text = att
        Catch ex As Exception
            MessageBox.Show("Enter Some Valid Number")
        End Try


    End Sub
#End Region

#Region "All Fields"

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        exa.Clear()
        peta.Clear()
        tera.Clear()
        giga.Clear()
        mega.Clear()
        kilo.Clear()
        hecto.Clear()
        deca.Clear()
        deci.Clear()
        one.Clear()
        centi.Clear()
        milli.Clear()
        micro.Clear()
        nano.Clear()
        pico.Clear()
        femto.Clear()
        atto.Clear()


    End Sub
#End Region

#End Region

End Class
