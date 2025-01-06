Public Class AngleConverterForm
    Dim degreeText, gradianText, radianText As String
    Dim deg, gra, rad As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        degreeBox.Clear()
        gradianBox.Clear()
        radianBox.Clear()

    End Sub
    Public Sub errorCheck()
        degreeText = degreeBox.Text
        deg = Double.Parse(degreeText)

        If deg > 0 Then
            Button2.Visible = True
        Else
            Button2.Visible = False

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            degreeText = degreeBox.Text
            deg = Double.Parse(degreeText)
            gra = deg * 1.1111111111111109
            rad = deg * 0.0174532925199433

            gradianBox.Text = gra
            radianBox.Text = rad
        Catch ex As Exception
            MessageBox.Show("Enter Some Integer Value")
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            gradianText = gradianBox.Text
            gra = Double.Parse(gradianText)

            deg = gra * 0.9
            rad = gra * 0.015707963267949

            degreeBox.Text = deg
            radianBox.Text = rad
        Catch ex As Exception
            MessageBox.Show("Enter Some Integer Value")
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            radianText = radianBox.Text
            rad = Double.Parse(radianText)

            deg = rad * 57.29577951308233
            gra = rad * 63.66197723675814

            degreeBox.Text = deg
            gradianBox.Text = gra
        Catch ex As Exception
            MessageBox.Show("Enter Some Integer Value")
        End Try

    End Sub
End Class
