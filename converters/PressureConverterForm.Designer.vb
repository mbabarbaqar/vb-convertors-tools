<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PressureConverterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PressureConverterForm))
        Me.lowPressure = New System.Windows.Forms.TabPage
        Me.paB = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.pascal = New System.Windows.Forms.TextBox
        Me.inchesofwater = New System.Windows.Forms.TextBox
        Me.inchesofmercury = New System.Windows.Forms.TextBox
        Me.inh2oB = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.inHgB = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.clearButton2 = New System.Windows.Forms.Button
        Me.cmHgB = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.centimeterofmercury = New System.Windows.Forms.TextBox
        Me.footofwater = New System.Windows.Forms.TextBox
        Me.meterofwater = New System.Windows.Forms.TextBox
        Me.fth2o = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.mh2oB = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.highPressure = New System.Windows.Forms.TabPage
        Me.clearButton = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.atmosphere = New System.Windows.Forms.TextBox
        Me.millimeterhg = New System.Windows.Forms.TextBox
        Me.kilogramforce = New System.Windows.Forms.TextBox
        Me.megapascal = New System.Windows.Forms.TextBox
        Me.kilopound = New System.Windows.Forms.TextBox
        Me.pound = New System.Windows.Forms.TextBox
        Me.bar = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.mcPh = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.gPm = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.lPm = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lPs = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.pressureTabs = New System.Windows.Forms.TabControl
        Me.lowPressure.SuspendLayout()
        Me.highPressure.SuspendLayout()
        Me.pressureTabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'lowPressure
        '
        Me.lowPressure.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lowPressure.Controls.Add(Me.paB)
        Me.lowPressure.Controls.Add(Me.Label8)
        Me.lowPressure.Controls.Add(Me.pascal)
        Me.lowPressure.Controls.Add(Me.inchesofwater)
        Me.lowPressure.Controls.Add(Me.inchesofmercury)
        Me.lowPressure.Controls.Add(Me.inh2oB)
        Me.lowPressure.Controls.Add(Me.Label9)
        Me.lowPressure.Controls.Add(Me.inHgB)
        Me.lowPressure.Controls.Add(Me.Label10)
        Me.lowPressure.Controls.Add(Me.clearButton2)
        Me.lowPressure.Controls.Add(Me.cmHgB)
        Me.lowPressure.Controls.Add(Me.Label11)
        Me.lowPressure.Controls.Add(Me.centimeterofmercury)
        Me.lowPressure.Controls.Add(Me.footofwater)
        Me.lowPressure.Controls.Add(Me.meterofwater)
        Me.lowPressure.Controls.Add(Me.fth2o)
        Me.lowPressure.Controls.Add(Me.Label12)
        Me.lowPressure.Controls.Add(Me.mh2oB)
        Me.lowPressure.Controls.Add(Me.Label13)
        Me.lowPressure.Location = New System.Drawing.Point(4, 25)
        Me.lowPressure.Name = "lowPressure"
        Me.lowPressure.Padding = New System.Windows.Forms.Padding(3)
        Me.lowPressure.Size = New System.Drawing.Size(628, 433)
        Me.lowPressure.TabIndex = 1
        Me.lowPressure.Text = "Low Pressure"
        '
        'paB
        '
        Me.paB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paB.ForeColor = System.Drawing.Color.White
        Me.paB.Location = New System.Drawing.Point(466, 333)
        Me.paB.Name = "paB"
        Me.paB.Size = New System.Drawing.Size(80, 37)
        Me.paB.TabIndex = 85
        Me.paB.Text = "PSCL"
        Me.paB.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Pascal      Pa"
        '
        'pascal
        '
        Me.pascal.BackColor = System.Drawing.Color.GhostWhite
        Me.pascal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pascal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.pascal.Location = New System.Drawing.Point(121, 333)
        Me.pascal.Multiline = True
        Me.pascal.Name = "pascal"
        Me.pascal.Size = New System.Drawing.Size(339, 37)
        Me.pascal.TabIndex = 83
        '
        'inchesofwater
        '
        Me.inchesofwater.BackColor = System.Drawing.Color.GhostWhite
        Me.inchesofwater.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inchesofwater.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.inchesofwater.Location = New System.Drawing.Point(121, 274)
        Me.inchesofwater.Multiline = True
        Me.inchesofwater.Name = "inchesofwater"
        Me.inchesofwater.Size = New System.Drawing.Size(339, 37)
        Me.inchesofwater.TabIndex = 80
        '
        'inchesofmercury
        '
        Me.inchesofmercury.BackColor = System.Drawing.Color.GhostWhite
        Me.inchesofmercury.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inchesofmercury.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.inchesofmercury.Location = New System.Drawing.Point(121, 211)
        Me.inchesofmercury.Multiline = True
        Me.inchesofmercury.Name = "inchesofmercury"
        Me.inchesofmercury.Size = New System.Drawing.Size(339, 37)
        Me.inchesofmercury.TabIndex = 77
        '
        'inh2oB
        '
        Me.inh2oB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inh2oB.ForeColor = System.Drawing.Color.White
        Me.inh2oB.Location = New System.Drawing.Point(466, 274)
        Me.inh2oB.Name = "inh2oB"
        Me.inh2oB.Size = New System.Drawing.Size(80, 37)
        Me.inh2oB.TabIndex = 82
        Me.inh2oB.Text = "INoW"
        Me.inh2oB.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 16)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Inches of Water    inH2O"
        '
        'inHgB
        '
        Me.inHgB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inHgB.ForeColor = System.Drawing.Color.White
        Me.inHgB.Location = New System.Drawing.Point(466, 210)
        Me.inHgB.Name = "inHgB"
        Me.inHgB.Size = New System.Drawing.Size(80, 37)
        Me.inHgB.TabIndex = 79
        Me.inHgB.Text = "INoM"
        Me.inHgB.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(60, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 16)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Inches of Mercury    inHg"
        '
        'clearButton2
        '
        Me.clearButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton2.ForeColor = System.Drawing.Color.White
        Me.clearButton2.Location = New System.Drawing.Point(342, 385)
        Me.clearButton2.Name = "clearButton2"
        Me.clearButton2.Size = New System.Drawing.Size(204, 37)
        Me.clearButton2.TabIndex = 76
        Me.clearButton2.Text = "Clear All Fields"
        Me.clearButton2.UseVisualStyleBackColor = True
        '
        'cmHgB
        '
        Me.cmHgB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmHgB.ForeColor = System.Drawing.Color.White
        Me.cmHgB.Location = New System.Drawing.Point(466, 150)
        Me.cmHgB.Name = "cmHgB"
        Me.cmHgB.Size = New System.Drawing.Size(80, 37)
        Me.cmHgB.TabIndex = 59
        Me.cmHgB.Text = "CoM"
        Me.cmHgB.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(60, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(218, 16)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Centimeter of Mercury     cmHg"
        '
        'centimeterofmercury
        '
        Me.centimeterofmercury.BackColor = System.Drawing.Color.GhostWhite
        Me.centimeterofmercury.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.centimeterofmercury.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.centimeterofmercury.Location = New System.Drawing.Point(121, 150)
        Me.centimeterofmercury.Multiline = True
        Me.centimeterofmercury.Name = "centimeterofmercury"
        Me.centimeterofmercury.Size = New System.Drawing.Size(339, 37)
        Me.centimeterofmercury.TabIndex = 57
        '
        'footofwater
        '
        Me.footofwater.BackColor = System.Drawing.Color.GhostWhite
        Me.footofwater.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footofwater.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.footofwater.Location = New System.Drawing.Point(121, 91)
        Me.footofwater.Multiline = True
        Me.footofwater.Name = "footofwater"
        Me.footofwater.Size = New System.Drawing.Size(339, 37)
        Me.footofwater.TabIndex = 54
        '
        'meterofwater
        '
        Me.meterofwater.BackColor = System.Drawing.Color.GhostWhite
        Me.meterofwater.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meterofwater.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.meterofwater.Location = New System.Drawing.Point(121, 28)
        Me.meterofwater.Multiline = True
        Me.meterofwater.Name = "meterofwater"
        Me.meterofwater.Size = New System.Drawing.Size(339, 37)
        Me.meterofwater.TabIndex = 51
        '
        'fth2o
        '
        Me.fth2o.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fth2o.ForeColor = System.Drawing.Color.White
        Me.fth2o.Location = New System.Drawing.Point(466, 91)
        Me.fth2o.Name = "fth2o"
        Me.fth2o.Size = New System.Drawing.Size(80, 37)
        Me.fth2o.TabIndex = 56
        Me.fth2o.Text = "FoW"
        Me.fth2o.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(60, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 16)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Foot Of Water      ftH2O"
        '
        'mh2oB
        '
        Me.mh2oB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mh2oB.ForeColor = System.Drawing.Color.White
        Me.mh2oB.Location = New System.Drawing.Point(466, 27)
        Me.mh2oB.Name = "mh2oB"
        Me.mh2oB.Size = New System.Drawing.Size(80, 37)
        Me.mh2oB.TabIndex = 53
        Me.mh2oB.Text = "MoW"
        Me.mh2oB.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(60, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(175, 16)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Meter of Water      mH2O"
        '
        'highPressure
        '
        Me.highPressure.BackColor = System.Drawing.Color.WhiteSmoke
        Me.highPressure.Controls.Add(Me.clearButton)
        Me.highPressure.Controls.Add(Me.Button6)
        Me.highPressure.Controls.Add(Me.Label7)
        Me.highPressure.Controls.Add(Me.atmosphere)
        Me.highPressure.Controls.Add(Me.millimeterhg)
        Me.highPressure.Controls.Add(Me.kilogramforce)
        Me.highPressure.Controls.Add(Me.megapascal)
        Me.highPressure.Controls.Add(Me.kilopound)
        Me.highPressure.Controls.Add(Me.pound)
        Me.highPressure.Controls.Add(Me.bar)
        Me.highPressure.Controls.Add(Me.Button5)
        Me.highPressure.Controls.Add(Me.Label6)
        Me.highPressure.Controls.Add(Me.Button4)
        Me.highPressure.Controls.Add(Me.Label5)
        Me.highPressure.Controls.Add(Me.mcPh)
        Me.highPressure.Controls.Add(Me.Label4)
        Me.highPressure.Controls.Add(Me.gPm)
        Me.highPressure.Controls.Add(Me.Label3)
        Me.highPressure.Controls.Add(Me.lPm)
        Me.highPressure.Controls.Add(Me.Label2)
        Me.highPressure.Controls.Add(Me.lPs)
        Me.highPressure.Controls.Add(Me.Label1)
        Me.highPressure.Location = New System.Drawing.Point(4, 25)
        Me.highPressure.Name = "highPressure"
        Me.highPressure.Padding = New System.Windows.Forms.Padding(3)
        Me.highPressure.Size = New System.Drawing.Size(628, 433)
        Me.highPressure.TabIndex = 0
        Me.highPressure.Text = "High Pressure"
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.ForeColor = System.Drawing.Color.White
        Me.clearButton.Location = New System.Drawing.Point(403, 341)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(204, 37)
        Me.clearButton.TabIndex = 75
        Me.clearButton.Text = "Clear All Fields"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(561, 279)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 37)
        Me.Button6.TabIndex = 62
        Me.Button6.Text = "ATM"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Atmospheres     atm"
        '
        'atmosphere
        '
        Me.atmosphere.BackColor = System.Drawing.Color.GhostWhite
        Me.atmosphere.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atmosphere.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.atmosphere.Location = New System.Drawing.Point(214, 280)
        Me.atmosphere.Multiline = True
        Me.atmosphere.Name = "atmosphere"
        Me.atmosphere.Size = New System.Drawing.Size(339, 37)
        Me.atmosphere.TabIndex = 60
        '
        'millimeterhg
        '
        Me.millimeterhg.BackColor = System.Drawing.Color.GhostWhite
        Me.millimeterhg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.millimeterhg.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.millimeterhg.Location = New System.Drawing.Point(214, 237)
        Me.millimeterhg.Multiline = True
        Me.millimeterhg.Name = "millimeterhg"
        Me.millimeterhg.Size = New System.Drawing.Size(339, 37)
        Me.millimeterhg.TabIndex = 57
        '
        'kilogramforce
        '
        Me.kilogramforce.BackColor = System.Drawing.Color.GhostWhite
        Me.kilogramforce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilogramforce.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.kilogramforce.Location = New System.Drawing.Point(214, 194)
        Me.kilogramforce.Multiline = True
        Me.kilogramforce.Name = "kilogramforce"
        Me.kilogramforce.Size = New System.Drawing.Size(339, 37)
        Me.kilogramforce.TabIndex = 54
        '
        'megapascal
        '
        Me.megapascal.BackColor = System.Drawing.Color.GhostWhite
        Me.megapascal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.megapascal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.megapascal.Location = New System.Drawing.Point(214, 151)
        Me.megapascal.Multiline = True
        Me.megapascal.Name = "megapascal"
        Me.megapascal.Size = New System.Drawing.Size(339, 37)
        Me.megapascal.TabIndex = 51
        '
        'kilopound
        '
        Me.kilopound.BackColor = System.Drawing.Color.GhostWhite
        Me.kilopound.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilopound.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.kilopound.Location = New System.Drawing.Point(214, 108)
        Me.kilopound.Multiline = True
        Me.kilopound.Name = "kilopound"
        Me.kilopound.Size = New System.Drawing.Size(339, 37)
        Me.kilopound.TabIndex = 48
        '
        'pound
        '
        Me.pound.BackColor = System.Drawing.Color.GhostWhite
        Me.pound.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pound.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.pound.Location = New System.Drawing.Point(214, 65)
        Me.pound.Multiline = True
        Me.pound.Name = "pound"
        Me.pound.Size = New System.Drawing.Size(339, 37)
        Me.pound.TabIndex = 45
        '
        'bar
        '
        Me.bar.BackColor = System.Drawing.Color.GhostWhite
        Me.bar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.bar.Location = New System.Drawing.Point(214, 22)
        Me.bar.Multiline = True
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(339, 37)
        Me.bar.TabIndex = 42
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(561, 236)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(46, 37)
        Me.Button5.TabIndex = 59
        Me.Button5.Text = "MMH"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 16)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Millimeter of Mercury  mmhg"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(561, 193)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 37)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = "KGF"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 15)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Kilogram Force /cm    kgf/ cm^2"
        '
        'mcPh
        '
        Me.mcPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcPh.ForeColor = System.Drawing.Color.White
        Me.mcPh.Location = New System.Drawing.Point(561, 150)
        Me.mcPh.Name = "mcPh"
        Me.mcPh.Size = New System.Drawing.Size(46, 37)
        Me.mcPh.TabIndex = 53
        Me.mcPh.Text = "MPA"
        Me.mcPh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "MegaPascal      MPa"
        '
        'gPm
        '
        Me.gPm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gPm.ForeColor = System.Drawing.Color.White
        Me.gPm.Location = New System.Drawing.Point(561, 107)
        Me.gPm.Name = "gPm"
        Me.gPm.Size = New System.Drawing.Size(46, 37)
        Me.gPm.TabIndex = 50
        Me.gPm.Text = "KPA"
        Me.gPm.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Kilopound    kPa"
        '
        'lPm
        '
        Me.lPm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPm.ForeColor = System.Drawing.Color.White
        Me.lPm.Location = New System.Drawing.Point(561, 64)
        Me.lPm.Name = "lPm"
        Me.lPm.Size = New System.Drawing.Size(46, 37)
        Me.lPm.TabIndex = 47
        Me.lPm.Text = "PSI"
        Me.lPm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 16)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Pound / SquareInch     psi"
        '
        'lPs
        '
        Me.lPs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPs.ForeColor = System.Drawing.Color.White
        Me.lPs.Location = New System.Drawing.Point(561, 21)
        Me.lPs.Name = "lPs"
        Me.lPs.Size = New System.Drawing.Size(46, 37)
        Me.lPs.TabIndex = 44
        Me.lPs.Text = "BAR"
        Me.lPs.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Bar          bar"
        '
        'pressureTabs
        '
        Me.pressureTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.pressureTabs.Controls.Add(Me.highPressure)
        Me.pressureTabs.Controls.Add(Me.lowPressure)
        Me.pressureTabs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pressureTabs.ItemSize = New System.Drawing.Size(120, 21)
        Me.pressureTabs.Location = New System.Drawing.Point(-5, 0)
        Me.pressureTabs.Multiline = True
        Me.pressureTabs.Name = "pressureTabs"
        Me.pressureTabs.SelectedIndex = 0
        Me.pressureTabs.ShowToolTips = True
        Me.pressureTabs.Size = New System.Drawing.Size(636, 462)
        Me.pressureTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.pressureTabs.TabIndex = 1
        '
        'PressureConverterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 459)
        Me.Controls.Add(Me.pressureTabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(5, 5)
        Me.Name = "PressureConverterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pressure Converter"
        Me.lowPressure.ResumeLayout(False)
        Me.lowPressure.PerformLayout()
        Me.highPressure.ResumeLayout(False)
        Me.highPressure.PerformLayout()
        Me.pressureTabs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lowPressure As System.Windows.Forms.TabPage
    Friend WithEvents clearButton2 As System.Windows.Forms.Button
    Friend WithEvents cmHgB As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents centimeterofmercury As System.Windows.Forms.TextBox
    Friend WithEvents footofwater As System.Windows.Forms.TextBox
    Friend WithEvents meterofwater As System.Windows.Forms.TextBox
    Friend WithEvents fth2o As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mh2oB As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents highPressure As System.Windows.Forms.TabPage
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents atmosphere As System.Windows.Forms.TextBox
    Friend WithEvents millimeterhg As System.Windows.Forms.TextBox
    Friend WithEvents kilogramforce As System.Windows.Forms.TextBox
    Friend WithEvents megapascal As System.Windows.Forms.TextBox
    Friend WithEvents kilopound As System.Windows.Forms.TextBox
    Friend WithEvents pound As System.Windows.Forms.TextBox
    Friend WithEvents bar As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mcPh As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gPm As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lPm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lPs As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pressureTabs As System.Windows.Forms.TabControl
    Friend WithEvents paB As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pascal As System.Windows.Forms.TextBox
    Friend WithEvents inchesofwater As System.Windows.Forms.TextBox
    Friend WithEvents inchesofmercury As System.Windows.Forms.TextBox
    Friend WithEvents inh2oB As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents inHgB As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
