Public Class ManualEstimationForm
    Dim unitx, unity, unitxValue, unityValue, newx, newy As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Try
                unitxValue = CDbl(unitxText.Text)
                unityValue = CDbl(unityText.Text)
                unitx = unityValue / unitxValue

                newx = CDbl(newXText.Text)

                newy = unitx * newx
                newyText.Text = newy
            Catch ex As Exception
                MessageBox.Show("Specify Both Fields / initialize new units ")
            End Try

        ElseIf RadioButton2.Checked = True Then
            Try
                unitxValue = CDbl(unitxText.Text)
                unityValue = CDbl(unityText.Text)
                unity = unitxValue / unityValue
                newy = CDbl(newyText.Text)

                newx = newy * unity
                newXText.Text = newx

            Catch ex As Exception
                MessageBox.Show("Specify Both Fields / initialize new units ")
            End Try

        End If
    End Sub



    Public Sub findX()
        newXText.Enabled = True
        newyText.Enabled = False
    End Sub
    Public Sub findY()
        newXText.Enabled = False
        newyText.Enabled = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        findX()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        findY()
    End Sub

  End Class
