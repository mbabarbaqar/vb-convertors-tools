Public Class logCalc
    Private Sub btnFindLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindLog.Click
        Dim num As Double = Val(txtNumber.Text)
        Dim base As Double = Val(txtBase.Text)
        Dim result As Double = Math.Log(num) / Math.Log(base)
        txtResult.Text = result.ToString()
        txtVerify.Text = (base ^ result).ToString()
    End Sub

End Class