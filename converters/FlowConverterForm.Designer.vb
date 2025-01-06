<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlowConverterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlowConverterForm))
        Me.FlowTabControl = New System.Windows.Forms.TabControl
        Me.liquidTab = New System.Windows.Forms.TabPage
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.yardcubePmin = New System.Windows.Forms.TextBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.barrelsPday = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.barrelsPhr = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.footcubePhr = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.footcubePmin = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.footcubePsec = New System.Windows.Forms.TextBox
        Me.mcPh = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.metercubePhr = New System.Windows.Forms.TextBox
        Me.gPm = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.gallonPmin = New System.Windows.Forms.TextBox
        Me.lPm = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.literPmin = New System.Windows.Forms.TextBox
        Me.lPs = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.literPsec = New System.Windows.Forms.TextBox
        Me.gasTab = New System.Windows.Forms.TabPage
        Me.clearButton10 = New System.Windows.Forms.Button
        Me.scfPmB = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.scfPmin = New System.Windows.Forms.TextBox
        Me.scfPhB = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.scfPhr = New System.Windows.Forms.TextBox
        Me.nmcPhB = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.nmcPhr = New System.Windows.Forms.TextBox
        Me.massTab = New System.Windows.Forms.TabPage
        Me.tPhB = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.tonPhour = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.kgPsB = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.kilogramPsecond = New System.Windows.Forms.TextBox
        Me.lbPhB = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.poundPhour = New System.Windows.Forms.TextBox
        Me.kgPhB = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.kilogramPhour = New System.Windows.Forms.TextBox
        Me.FlowTabControl.SuspendLayout()
        Me.liquidTab.SuspendLayout()
        Me.gasTab.SuspendLayout()
        Me.massTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowTabControl
        '
        Me.FlowTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.FlowTabControl.Controls.Add(Me.liquidTab)
        Me.FlowTabControl.Controls.Add(Me.gasTab)
        Me.FlowTabControl.Controls.Add(Me.massTab)
        Me.FlowTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FlowTabControl.ItemSize = New System.Drawing.Size(120, 21)
        Me.FlowTabControl.Location = New System.Drawing.Point(-4, 1)
        Me.FlowTabControl.Multiline = True
        Me.FlowTabControl.Name = "FlowTabControl"
        Me.FlowTabControl.SelectedIndex = 0
        Me.FlowTabControl.ShowToolTips = True
        Me.FlowTabControl.Size = New System.Drawing.Size(636, 567)
        Me.FlowTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlowTabControl.TabIndex = 0
        '
        'liquidTab
        '
        Me.liquidTab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.liquidTab.Controls.Add(Me.Button11)
        Me.liquidTab.Controls.Add(Me.Button9)
        Me.liquidTab.Controls.Add(Me.Label10)
        Me.liquidTab.Controls.Add(Me.yardcubePmin)
        Me.liquidTab.Controls.Add(Me.Button8)
        Me.liquidTab.Controls.Add(Me.Label9)
        Me.liquidTab.Controls.Add(Me.barrelsPday)
        Me.liquidTab.Controls.Add(Me.Button7)
        Me.liquidTab.Controls.Add(Me.Label8)
        Me.liquidTab.Controls.Add(Me.barrelsPhr)
        Me.liquidTab.Controls.Add(Me.Button6)
        Me.liquidTab.Controls.Add(Me.Label7)
        Me.liquidTab.Controls.Add(Me.footcubePhr)
        Me.liquidTab.Controls.Add(Me.Button5)
        Me.liquidTab.Controls.Add(Me.Label6)
        Me.liquidTab.Controls.Add(Me.footcubePmin)
        Me.liquidTab.Controls.Add(Me.Button4)
        Me.liquidTab.Controls.Add(Me.Label5)
        Me.liquidTab.Controls.Add(Me.footcubePsec)
        Me.liquidTab.Controls.Add(Me.mcPh)
        Me.liquidTab.Controls.Add(Me.Label4)
        Me.liquidTab.Controls.Add(Me.metercubePhr)
        Me.liquidTab.Controls.Add(Me.gPm)
        Me.liquidTab.Controls.Add(Me.Label3)
        Me.liquidTab.Controls.Add(Me.gallonPmin)
        Me.liquidTab.Controls.Add(Me.lPm)
        Me.liquidTab.Controls.Add(Me.Label2)
        Me.liquidTab.Controls.Add(Me.literPmin)
        Me.liquidTab.Controls.Add(Me.lPs)
        Me.liquidTab.Controls.Add(Me.Label1)
        Me.liquidTab.Controls.Add(Me.literPsec)
        Me.liquidTab.Location = New System.Drawing.Point(4, 25)
        Me.liquidTab.Name = "liquidTab"
        Me.liquidTab.Padding = New System.Windows.Forms.Padding(3)
        Me.liquidTab.Size = New System.Drawing.Size(628, 538)
        Me.liquidTab.TabIndex = 0
        Me.liquidTab.Text = "Liquid Flow"
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(403, 475)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(204, 37)
        Me.Button11.TabIndex = 75
        Me.Button11.Text = "Clear All Fields"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(561, 408)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(46, 37)
        Me.Button9.TabIndex = 71
        Me.Button9.Text = "Y/M"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 16)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Cubic Yard / Min yrd/m"
        '
        'yardcubePmin
        '
        Me.yardcubePmin.BackColor = System.Drawing.SystemColors.Window
        Me.yardcubePmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yardcubePmin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.yardcubePmin.Location = New System.Drawing.Point(210, 409)
        Me.yardcubePmin.Multiline = True
        Me.yardcubePmin.Name = "yardcubePmin"
        Me.yardcubePmin.Size = New System.Drawing.Size(339, 37)
        Me.yardcubePmin.TabIndex = 69
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(561, 365)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(46, 37)
        Me.Button8.TabIndex = 68
        Me.Button8.Text = "B/D"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 375)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 16)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "US Barrels / Day   bbl/day"
        '
        'barrelsPday
        '
        Me.barrelsPday.BackColor = System.Drawing.SystemColors.Window
        Me.barrelsPday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barrelsPday.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.barrelsPday.Location = New System.Drawing.Point(210, 366)
        Me.barrelsPday.Multiline = True
        Me.barrelsPday.Name = "barrelsPday"
        Me.barrelsPday.Size = New System.Drawing.Size(339, 37)
        Me.barrelsPday.TabIndex = 66
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(561, 322)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(46, 37)
        Me.Button7.TabIndex = 65
        Me.Button7.Text = "B/H"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 16)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "US BarrelsOil / Hour   bbl/h"
        '
        'barrelsPhr
        '
        Me.barrelsPhr.BackColor = System.Drawing.SystemColors.Window
        Me.barrelsPhr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barrelsPhr.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.barrelsPhr.Location = New System.Drawing.Point(210, 323)
        Me.barrelsPhr.Multiline = True
        Me.barrelsPhr.Name = "barrelsPhr"
        Me.barrelsPhr.Size = New System.Drawing.Size(339, 37)
        Me.barrelsPhr.TabIndex = 63
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(561, 279)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 37)
        Me.Button6.TabIndex = 62
        Me.Button6.Text = "FC/h"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 16)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "FootCube/Hour    F^3/h"
        '
        'footcubePhr
        '
        Me.footcubePhr.BackColor = System.Drawing.SystemColors.Window
        Me.footcubePhr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footcubePhr.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.footcubePhr.Location = New System.Drawing.Point(210, 280)
        Me.footcubePhr.Multiline = True
        Me.footcubePhr.Name = "footcubePhr"
        Me.footcubePhr.Size = New System.Drawing.Size(339, 37)
        Me.footcubePhr.TabIndex = 60
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(561, 236)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(46, 37)
        Me.Button5.TabIndex = 59
        Me.Button5.Text = "Fc/m"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 16)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "FootCube/Min      F^3/m"
        '
        'footcubePmin
        '
        Me.footcubePmin.BackColor = System.Drawing.SystemColors.Window
        Me.footcubePmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footcubePmin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.footcubePmin.Location = New System.Drawing.Point(210, 237)
        Me.footcubePmin.Multiline = True
        Me.footcubePmin.Name = "footcubePmin"
        Me.footcubePmin.Size = New System.Drawing.Size(339, 37)
        Me.footcubePmin.TabIndex = 57
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(561, 193)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 37)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = "FC/s"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 16)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Foot cube/sec       F^3/s"
        '
        'footcubePsec
        '
        Me.footcubePsec.BackColor = System.Drawing.SystemColors.Window
        Me.footcubePsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footcubePsec.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.footcubePsec.Location = New System.Drawing.Point(210, 194)
        Me.footcubePsec.Multiline = True
        Me.footcubePsec.Name = "footcubePsec"
        Me.footcubePsec.Size = New System.Drawing.Size(339, 37)
        Me.footcubePsec.TabIndex = 54
        '
        'mcPh
        '
        Me.mcPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcPh.ForeColor = System.Drawing.Color.White
        Me.mcPh.Location = New System.Drawing.Point(561, 150)
        Me.mcPh.Name = "mcPh"
        Me.mcPh.Size = New System.Drawing.Size(46, 37)
        Me.mcPh.TabIndex = 53
        Me.mcPh.Text = "MC/h"
        Me.mcPh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "MeterCube/Hour  M^3/S"
        '
        'metercubePhr
        '
        Me.metercubePhr.BackColor = System.Drawing.SystemColors.Window
        Me.metercubePhr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metercubePhr.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.metercubePhr.Location = New System.Drawing.Point(210, 151)
        Me.metercubePhr.Multiline = True
        Me.metercubePhr.Name = "metercubePhr"
        Me.metercubePhr.Size = New System.Drawing.Size(339, 37)
        Me.metercubePhr.TabIndex = 51
        '
        'gPm
        '
        Me.gPm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gPm.ForeColor = System.Drawing.Color.White
        Me.gPm.Location = New System.Drawing.Point(561, 107)
        Me.gPm.Name = "gPm"
        Me.gPm.Size = New System.Drawing.Size(46, 37)
        Me.gPm.TabIndex = 50
        Me.gPm.Text = "G/M"
        Me.gPm.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "US Gallons/Min        L/S"
        '
        'gallonPmin
        '
        Me.gallonPmin.BackColor = System.Drawing.SystemColors.Window
        Me.gallonPmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gallonPmin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.gallonPmin.Location = New System.Drawing.Point(210, 108)
        Me.gallonPmin.Multiline = True
        Me.gallonPmin.Name = "gallonPmin"
        Me.gallonPmin.Size = New System.Drawing.Size(339, 37)
        Me.gallonPmin.TabIndex = 48
        '
        'lPm
        '
        Me.lPm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPm.ForeColor = System.Drawing.Color.White
        Me.lPm.Location = New System.Drawing.Point(561, 64)
        Me.lPm.Name = "lPm"
        Me.lPm.Size = New System.Drawing.Size(46, 37)
        Me.lPm.TabIndex = 47
        Me.lPm.Text = "L/M"
        Me.lPm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 16)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Liter/Minute        L/M"
        '
        'literPmin
        '
        Me.literPmin.BackColor = System.Drawing.SystemColors.Window
        Me.literPmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.literPmin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.literPmin.Location = New System.Drawing.Point(210, 65)
        Me.literPmin.Multiline = True
        Me.literPmin.Name = "literPmin"
        Me.literPmin.Size = New System.Drawing.Size(339, 37)
        Me.literPmin.TabIndex = 45
        '
        'lPs
        '
        Me.lPs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPs.ForeColor = System.Drawing.Color.White
        Me.lPs.Location = New System.Drawing.Point(561, 21)
        Me.lPs.Name = "lPs"
        Me.lPs.Size = New System.Drawing.Size(46, 37)
        Me.lPs.TabIndex = 44
        Me.lPs.Text = "L/S"
        Me.lPs.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Liter/Second       L/S"
        '
        'literPsec
        '
        Me.literPsec.BackColor = System.Drawing.SystemColors.Window
        Me.literPsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.literPsec.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.literPsec.Location = New System.Drawing.Point(210, 22)
        Me.literPsec.Multiline = True
        Me.literPsec.Name = "literPsec"
        Me.literPsec.Size = New System.Drawing.Size(339, 37)
        Me.literPsec.TabIndex = 42
        '
        'gasTab
        '
        Me.gasTab.Controls.Add(Me.clearButton10)
        Me.gasTab.Controls.Add(Me.scfPmB)
        Me.gasTab.Controls.Add(Me.Label11)
        Me.gasTab.Controls.Add(Me.scfPmin)
        Me.gasTab.Controls.Add(Me.scfPhB)
        Me.gasTab.Controls.Add(Me.Label12)
        Me.gasTab.Controls.Add(Me.scfPhr)
        Me.gasTab.Controls.Add(Me.nmcPhB)
        Me.gasTab.Controls.Add(Me.Label13)
        Me.gasTab.Controls.Add(Me.nmcPhr)
        Me.gasTab.Location = New System.Drawing.Point(4, 25)
        Me.gasTab.Name = "gasTab"
        Me.gasTab.Padding = New System.Windows.Forms.Padding(3)
        Me.gasTab.Size = New System.Drawing.Size(628, 538)
        Me.gasTab.TabIndex = 1
        Me.gasTab.Text = "Gas Flow Conversion"
        Me.gasTab.UseVisualStyleBackColor = True
        '
        'clearButton10
        '
        Me.clearButton10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton10.ForeColor = System.Drawing.Color.White
        Me.clearButton10.Location = New System.Drawing.Point(358, 297)
        Me.clearButton10.Name = "clearButton10"
        Me.clearButton10.Size = New System.Drawing.Size(204, 37)
        Me.clearButton10.TabIndex = 76
        Me.clearButton10.Text = "Clear All Fields"
        Me.clearButton10.UseVisualStyleBackColor = True
        '
        'scfPmB
        '
        Me.scfPmB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scfPmB.ForeColor = System.Drawing.Color.White
        Me.scfPmB.Location = New System.Drawing.Point(478, 220)
        Me.scfPmB.Name = "scfPmB"
        Me.scfPmB.Size = New System.Drawing.Size(80, 37)
        Me.scfPmB.TabIndex = 59
        Me.scfPmB.Text = "SCF/M"
        Me.scfPmB.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(72, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(236, 16)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Standard cubic feet/minute   scfm"
        '
        'scfPmin
        '
        Me.scfPmin.BackColor = System.Drawing.Color.GhostWhite
        Me.scfPmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scfPmin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.scfPmin.Location = New System.Drawing.Point(133, 220)
        Me.scfPmin.Multiline = True
        Me.scfPmin.Name = "scfPmin"
        Me.scfPmin.Size = New System.Drawing.Size(339, 37)
        Me.scfPmin.TabIndex = 57
        '
        'scfPhB
        '
        Me.scfPhB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scfPhB.ForeColor = System.Drawing.Color.White
        Me.scfPhB.Location = New System.Drawing.Point(478, 134)
        Me.scfPhB.Name = "scfPhB"
        Me.scfPhB.Size = New System.Drawing.Size(80, 37)
        Me.scfPhB.TabIndex = 56
        Me.scfPhB.Text = "SCF/H"
        Me.scfPhB.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(72, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(217, 16)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Standard cubic feet/hour   scfh"
        '
        'scfPhr
        '
        Me.scfPhr.BackColor = System.Drawing.Color.GhostWhite
        Me.scfPhr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scfPhr.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.scfPhr.Location = New System.Drawing.Point(133, 134)
        Me.scfPhr.Multiline = True
        Me.scfPhr.Name = "scfPhr"
        Me.scfPhr.Size = New System.Drawing.Size(339, 37)
        Me.scfPhr.TabIndex = 54
        '
        'nmcPhB
        '
        Me.nmcPhB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmcPhB.ForeColor = System.Drawing.Color.White
        Me.nmcPhB.Location = New System.Drawing.Point(478, 48)
        Me.nmcPhB.Name = "nmcPhB"
        Me.nmcPhB.Size = New System.Drawing.Size(80, 37)
        Me.nmcPhB.TabIndex = 53
        Me.nmcPhB.Text = "NMC/H"
        Me.nmcPhB.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(72, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(231, 16)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Normal meter cube/hour  Nm3/hr"
        '
        'nmcPhr
        '
        Me.nmcPhr.BackColor = System.Drawing.Color.GhostWhite
        Me.nmcPhr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmcPhr.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.nmcPhr.Location = New System.Drawing.Point(133, 49)
        Me.nmcPhr.Multiline = True
        Me.nmcPhr.Name = "nmcPhr"
        Me.nmcPhr.Size = New System.Drawing.Size(339, 37)
        Me.nmcPhr.TabIndex = 51
        '
        'massTab
        '
        Me.massTab.Controls.Add(Me.tPhB)
        Me.massTab.Controls.Add(Me.Label17)
        Me.massTab.Controls.Add(Me.tonPhour)
        Me.massTab.Controls.Add(Me.Button1)
        Me.massTab.Controls.Add(Me.kgPsB)
        Me.massTab.Controls.Add(Me.Label14)
        Me.massTab.Controls.Add(Me.kilogramPsecond)
        Me.massTab.Controls.Add(Me.lbPhB)
        Me.massTab.Controls.Add(Me.Label15)
        Me.massTab.Controls.Add(Me.poundPhour)
        Me.massTab.Controls.Add(Me.kgPhB)
        Me.massTab.Controls.Add(Me.Label16)
        Me.massTab.Controls.Add(Me.kilogramPhour)
        Me.massTab.Location = New System.Drawing.Point(4, 25)
        Me.massTab.Name = "massTab"
        Me.massTab.Padding = New System.Windows.Forms.Padding(3)
        Me.massTab.Size = New System.Drawing.Size(628, 538)
        Me.massTab.TabIndex = 2
        Me.massTab.Text = "Mass Flow"
        Me.massTab.UseVisualStyleBackColor = True
        '
        'tPhB
        '
        Me.tPhB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPhB.ForeColor = System.Drawing.Color.White
        Me.tPhB.Location = New System.Drawing.Point(478, 302)
        Me.tPhB.Name = "tPhB"
        Me.tPhB.Size = New System.Drawing.Size(80, 37)
        Me.tPhB.TabIndex = 89
        Me.tPhB.Text = "Ton/hr"
        Me.tPhB.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(72, 283)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 16)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "Ton/hour    t/h"
        '
        'tonPhour
        '
        Me.tonPhour.BackColor = System.Drawing.Color.GhostWhite
        Me.tonPhour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tonPhour.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tonPhour.Location = New System.Drawing.Point(133, 302)
        Me.tonPhour.Multiline = True
        Me.tonPhour.Name = "tonPhour"
        Me.tonPhour.Size = New System.Drawing.Size(339, 37)
        Me.tonPhour.TabIndex = 87
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(354, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 37)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Clear All Fields"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'kgPsB
        '
        Me.kgPsB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kgPsB.ForeColor = System.Drawing.Color.White
        Me.kgPsB.Location = New System.Drawing.Point(478, 220)
        Me.kgPsB.Name = "kgPsB"
        Me.kgPsB.Size = New System.Drawing.Size(80, 37)
        Me.kgPsB.TabIndex = 85
        Me.kgPsB.Text = "Kg/se"
        Me.kgPsB.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(72, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(172, 16)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Kilogram/second    Kg/s"
        '
        'kilogramPsecond
        '
        Me.kilogramPsecond.BackColor = System.Drawing.Color.GhostWhite
        Me.kilogramPsecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilogramPsecond.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.kilogramPsecond.Location = New System.Drawing.Point(133, 220)
        Me.kilogramPsecond.Multiline = True
        Me.kilogramPsecond.Name = "kilogramPsecond"
        Me.kilogramPsecond.Size = New System.Drawing.Size(339, 37)
        Me.kilogramPsecond.TabIndex = 83
        '
        'lbPhB
        '
        Me.lbPhB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPhB.ForeColor = System.Drawing.Color.White
        Me.lbPhB.Location = New System.Drawing.Point(478, 134)
        Me.lbPhB.Name = "lbPhB"
        Me.lbPhB.Size = New System.Drawing.Size(80, 37)
        Me.lbPhB.TabIndex = 82
        Me.lbPhB.Text = "Pond/h"
        Me.lbPhB.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(72, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 16)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Pound/hour    lb/h"
        '
        'poundPhour
        '
        Me.poundPhour.BackColor = System.Drawing.Color.GhostWhite
        Me.poundPhour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poundPhour.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.poundPhour.Location = New System.Drawing.Point(133, 134)
        Me.poundPhour.Multiline = True
        Me.poundPhour.Name = "poundPhour"
        Me.poundPhour.Size = New System.Drawing.Size(339, 37)
        Me.poundPhour.TabIndex = 80
        '
        'kgPhB
        '
        Me.kgPhB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kgPhB.ForeColor = System.Drawing.Color.White
        Me.kgPhB.Location = New System.Drawing.Point(478, 48)
        Me.kgPhB.Name = "kgPhB"
        Me.kgPhB.Size = New System.Drawing.Size(80, 37)
        Me.kgPhB.TabIndex = 79
        Me.kgPhB.Text = "Kg/Hr"
        Me.kgPhB.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(72, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 16)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Kilogram/hour    Kg/h"
        '
        'kilogramPhour
        '
        Me.kilogramPhour.BackColor = System.Drawing.Color.GhostWhite
        Me.kilogramPhour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilogramPhour.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.kilogramPhour.Location = New System.Drawing.Point(133, 49)
        Me.kilogramPhour.Multiline = True
        Me.kilogramPhour.Name = "kilogramPhour"
        Me.kilogramPhour.Size = New System.Drawing.Size(339, 37)
        Me.kilogramPhour.TabIndex = 77
        '
        'FlowConverterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 562)
        Me.Controls.Add(Me.FlowTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FlowConverterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Volumetric Flow Conversion"
        Me.FlowTabControl.ResumeLayout(False)
        Me.liquidTab.ResumeLayout(False)
        Me.liquidTab.PerformLayout()
        Me.gasTab.ResumeLayout(False)
        Me.gasTab.PerformLayout()
        Me.massTab.ResumeLayout(False)
        Me.massTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowTabControl As System.Windows.Forms.TabControl
    Friend WithEvents liquidTab As System.Windows.Forms.TabPage
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents yardcubePmin As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents barrelsPday As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents barrelsPhr As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents footcubePhr As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents footcubePmin As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents footcubePsec As System.Windows.Forms.TextBox
    Friend WithEvents mcPh As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents metercubePhr As System.Windows.Forms.TextBox
    Friend WithEvents gPm As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gallonPmin As System.Windows.Forms.TextBox
    Friend WithEvents lPm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents literPmin As System.Windows.Forms.TextBox
    Friend WithEvents lPs As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents literPsec As System.Windows.Forms.TextBox
    Friend WithEvents gasTab As System.Windows.Forms.TabPage
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents scfPmB As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents scfPmin As System.Windows.Forms.TextBox
    Friend WithEvents scfPhB As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents scfPhr As System.Windows.Forms.TextBox
    Friend WithEvents nmcPhB As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents nmcPhr As System.Windows.Forms.TextBox
    Friend WithEvents clearButton10 As System.Windows.Forms.Button
    Friend WithEvents massTab As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents kgPsB As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents kilogramPsecond As System.Windows.Forms.TextBox
    Friend WithEvents lbPhB As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents poundPhour As System.Windows.Forms.TextBox
    Friend WithEvents kgPhB As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents kilogramPhour As System.Windows.Forms.TextBox
    Friend WithEvents tPhB As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tonPhour As System.Windows.Forms.TextBox

End Class
