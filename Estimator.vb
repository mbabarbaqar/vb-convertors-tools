Imports System.Drawing.Point
Public Class Estimator


    Private Sub ToolStripContainer1_RightToolStripPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mainForm.Show()
        mainForm.MdiParent = Me
        mainForm.BringToFront()
        'mainForm.StartPosition = FormStartPosition.CenterParent



    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ExitToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStrip.Click
        Beep()
        End
    End Sub

    Private Sub SimpleCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleCalculator.Click

        simpleCalc2.MdiParent = Me
        simpleCalc2.Show()
        simpleCalc2.BringToFront()
        mainForm.Close()
    End Sub

    Private Sub BinaryConverterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BinaryConverterToolStripMenuItem.Click
        Dim bc As New binaryConverter
        bc = New binaryConverter()

        bc.MdiParent = Me
        bc.Show()
        bc.BringToFront()
        mainForm.Close()

    End Sub

    Private Sub MinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinToolStripMenuItem.Click
        mainForm.Show()
        mainForm.MdiParent = Me
        mainForm.BringToFront()

    End Sub

    Private Sub LogCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogCalculator.Click
        logCalc.MdiParent = Me
        logCalc.Show()
        logCalc.BringToFront()
        mainForm.Close()

    End Sub

    Private Sub ScientificCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScientificCalculator.Click
        scCalculator.Show()
        scCalculator.MdiParent = Me
        scCalculator.BringToFront()
        mainForm.Close()

    End Sub

    Private Sub LengthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LengthToolStripMenuItem.Click
        lengthConverterForm.Show()
        lengthConverterForm.MdiParent = Me
        lengthConverterForm.BringToFront()
        mainForm.Close()

    End Sub

    Private Sub TempratureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TempratureToolStripMenuItem.Click
        TempConvertForm.Show()
        TempConvertForm.MdiParent = Me
        TempConvertForm.BringToFront()
        mainForm.Close()

    End Sub

    Private Sub WeightAndMassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeightAndMassToolStripMenuItem.Click
        WeightMassConverter.Show()
        WeightMassConverter.MdiParent = Me
        WeightMassConverter.BringToFront()
        mainForm.Close()

    End Sub

    Private Sub AngleConversionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AngleConversionToolStripMenuItem.Click
        AngleConverterForm.Show()
        AngleConverterForm.MdiParent = Me
        AngleConverterForm.BringToFront()
        mainForm.Close()

    End Sub

    Private Sub FlowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowToolStripMenuItem.Click
        FlowConverterForm.Show()
        FlowConverterForm.MdiParent = Me
        FlowConverterForm.BringToFront()
        mainForm.Close()

    End Sub

    Private Sub TimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeToolStripMenuItem.Click
        TimeConverterForm.Show()
        TimeConverterForm.MdiParent = Me
        TimeConverterForm.BringToFront()
        mainForm.Close()
    End Sub

    Private Sub VlumesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VlumesToolStripMenuItem.Click
        VolumeConverterForm.Show()
        VolumeConverterForm.MdiParent = Me
        VolumeConverterForm.BringToFront()
        mainForm.Close()

    End Sub

    Private Sub BiteConversionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiteConversionToolStripMenuItem.Click
        BiteConvertForm.Show()
        BiteConvertForm.MdiParent = Me
        BiteConvertForm.BringToFront()
        mainForm.Close()

    End Sub

    Private Sub MassFlowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MassFlowToolStripMenuItem.Click
        FlowConverterForm.massTab.Show()
        FlowConverterForm.Show()
        FlowConverterForm.MdiParent = Me
        FlowConverterForm.massTab.BringToFront()
        mainForm.Close()
    End Sub

    Private Sub LiquidFlowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidFlowToolStripMenuItem.Click
        FlowConverterForm.liquidTab.Show()
        FlowConverterForm.Show()
        FlowConverterForm.MdiParent = Me
        FlowConverterForm.massTab.BringToFront()
        mainForm.Close()
    End Sub

    Private Sub GasFlowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GasFlowToolStripMenuItem.Click
        FlowConverterForm.gasTab.Show()
        FlowConverterForm.Show()
        FlowConverterForm.MdiParent = Me
        FlowConverterForm.gasTab.BringToFront()
        mainForm.Close()
    End Sub
    Private Sub ThPowerCalculationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThPowerCalculationToolStripMenuItem.Click
        BiteConvertForm.Show()
        BiteConvertForm.MdiParent = Me
        BiteConvertForm.BringToFront()
        mainForm.Close()
    End Sub

    Private Sub SpeedUnitsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeedUnitsToolStripMenuItem.Click
        SpeedConverterForm.Show()
        SpeedConverterForm.MdiParent = Me
        SpeedConverterForm.BringToFront()
        mainForm.Close()
    End Sub

    Private Sub PressureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressureToolStripMenuItem.Click
        PressureConverterForm.Show()
        PressureConverterForm.MdiParent = Me
        mainForm.Close()
    End Sub

    Private Sub HighPressureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighPressureToolStripMenuItem.Click
        PressureConverterForm.Show()
        PressureConverterForm.MdiParent = Me
        mainForm.Close()

    End Sub

    Private Sub LowPressureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowPressureToolStripMenuItem.Click
        PressureConverterForm.lowPressure.Show()
        PressureConverterForm.lowPressure.BringToFront()

    End Sub

    Private Sub LongCalculations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LongCalculations.Click
        Form1.Show()
        Form1.MdiParent = Me
        mainForm.Close()

    End Sub

    Private Sub ManualEstimationUnitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualEstimationUnitToolStripMenuItem.Click
        ManualEstimationForm.Show()
        ManualEstimationForm.BringToFront()
        ManualEstimationForm.MdiParent = Me
        mainForm.Close()
    End Sub

    
End Class
