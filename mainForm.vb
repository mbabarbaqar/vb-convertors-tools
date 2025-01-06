Public Class mainForm

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub calc1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles calc1.LinkClicked
        Form1.Show()
        Form1.BringToFront()
    End Sub

    Private Sub calc2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles calc2.LinkClicked
        simpleCalc2.Show()
        simpleCalc2.BringToFront()
    End Sub


    Private Sub logCalculator_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles logCalculator.LinkClicked
        logCalc.Show()
        logCalc.BringToFront()
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        binaryConverter.Show()
        binaryConverter.BringToFront()
    End Sub

    Private Sub scientificCalc_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles scientificCalc.LinkClicked
        scCalculator.Show()
        scCalculator.BringToFront()
    End Sub

    Private Sub LinkLabel12_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        TempConvertForm.Show()
        TempConvertForm.BringToFront()

    End Sub

    Private Sub LinkLabel17_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        lengthConverterForm.Show()
        lengthConverterForm.BringToFront()
    End Sub

    Private Sub LinkLabel18_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        WeightMassConverter.Show()
        WeightMassConverter.BringToFront()

    End Sub

    Private Sub LinkLabel35_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel35.LinkClicked
        AngleConverterForm.Show()
        AngleConverterForm.BringToFront()
    End Sub

    Private Sub LinkLabel15_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        FlowConverterForm.Show()
        FlowConverterForm.BringToFront()
    End Sub

    Private Sub LinkLabel13_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        TimeConverterForm.Show()
        TimeConverterForm.BringToFront()
    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        VolumeConverterForm.Show()
        VolumeConverterForm.BringToFront()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        BiteConvertForm.Show()
        BiteConvertForm.BringToFront()
    End Sub

    Private Sub LinkLabel31_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel31.LinkClicked
        SpeedConverterForm.Show()
        SpeedConverterForm.BringToFront()
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        BiteConvertForm.Show()
        BiteConvertForm.BringToFront()
    End Sub

    Private Sub pressureConvert_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles pressureConvert.LinkClicked
        PressureConverterForm.Show()
        PressureConverterForm.BringToFront()
    End Sub

    Private Sub LinkLabel29_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel29.LinkClicked
        ManualEstimationForm.Show()
        ManualEstimationForm.BringToFront()

    End Sub

    Private Sub LinkLabel16_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        PowerConverterForm.Show()
        PowerConverterForm.BringToFront()
    End Sub

    Private Sub LinkLabel30_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel30.LinkClicked
        TorqueConverterForm.Show()
        TorqueConverterForm.BringToFront()
    End Sub
End Class