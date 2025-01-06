<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PowerConverterForm
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
        Me.wattBox = New System.Windows.Forms.TextBox()
        Me.wattButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kilowattBox = New System.Windows.Forms.TextBox()
        Me.killowattButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.calorieBox = New System.Windows.Forms.TextBox()
        Me.calorieButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HorsepowerBox = New System.Windows.Forms.TextBox()
        Me.horsepowerButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.footPoundSecondBox = New System.Windows.Forms.TextBox()
        Me.footpoundSButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.footPoundMinutBox = New System.Windows.Forms.TextBox()
        Me.footpoundMButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.britishTSBox = New System.Windows.Forms.TextBox()
        Me.britishTSButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.britishTHBox = New System.Windows.Forms.TextBox()
        Me.britishTHButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'wattBox
        '
        Me.wattBox.BackColor = System.Drawing.Color.GhostWhite
        Me.wattBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wattBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.wattBox.Location = New System.Drawing.Point(227, 28)
        Me.wattBox.Multiline = True
        Me.wattBox.Name = "wattBox"
        Me.wattBox.Size = New System.Drawing.Size(326, 37)
        Me.wattBox.TabIndex = 45
        '
        'wattButton
        '
        Me.wattButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wattButton.ForeColor = System.Drawing.Color.White
        Me.wattButton.Location = New System.Drawing.Point(567, 28)
        Me.wattButton.Name = "wattButton"
        Me.wattButton.Size = New System.Drawing.Size(53, 37)
        Me.wattButton.TabIndex = 47
        Me.wattButton.Text = "W"
        Me.wattButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Watt"
        '
        'kilowattBox
        '
        Me.kilowattBox.BackColor = System.Drawing.Color.GhostWhite
        Me.kilowattBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilowattBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.kilowattBox.Location = New System.Drawing.Point(227, 82)
        Me.kilowattBox.Multiline = True
        Me.kilowattBox.Name = "kilowattBox"
        Me.kilowattBox.Size = New System.Drawing.Size(326, 37)
        Me.kilowattBox.TabIndex = 48
        '
        'killowattButton
        '
        Me.killowattButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.killowattButton.ForeColor = System.Drawing.Color.White
        Me.killowattButton.Location = New System.Drawing.Point(567, 82)
        Me.killowattButton.Name = "killowattButton"
        Me.killowattButton.Size = New System.Drawing.Size(53, 37)
        Me.killowattButton.TabIndex = 50
        Me.killowattButton.Text = "KW"
        Me.killowattButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "kilowatt"
        '
        'calorieBox
        '
        Me.calorieBox.BackColor = System.Drawing.Color.GhostWhite
        Me.calorieBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calorieBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.calorieBox.Location = New System.Drawing.Point(227, 138)
        Me.calorieBox.Multiline = True
        Me.calorieBox.Name = "calorieBox"
        Me.calorieBox.Size = New System.Drawing.Size(326, 37)
        Me.calorieBox.TabIndex = 51
        '
        'calorieButton
        '
        Me.calorieButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calorieButton.ForeColor = System.Drawing.Color.White
        Me.calorieButton.Location = New System.Drawing.Point(567, 138)
        Me.calorieButton.Name = "calorieButton"
        Me.calorieButton.Size = New System.Drawing.Size(53, 37)
        Me.calorieButton.TabIndex = 53
        Me.calorieButton.Text = "CAL"
        Me.calorieButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Calorie / second "
        '
        'HorsepowerBox
        '
        Me.HorsepowerBox.BackColor = System.Drawing.Color.GhostWhite
        Me.HorsepowerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HorsepowerBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.HorsepowerBox.Location = New System.Drawing.Point(227, 196)
        Me.HorsepowerBox.Multiline = True
        Me.HorsepowerBox.Name = "HorsepowerBox"
        Me.HorsepowerBox.Size = New System.Drawing.Size(326, 37)
        Me.HorsepowerBox.TabIndex = 54
        '
        'horsepowerButton
        '
        Me.horsepowerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horsepowerButton.ForeColor = System.Drawing.Color.White
        Me.horsepowerButton.Location = New System.Drawing.Point(567, 196)
        Me.horsepowerButton.Name = "horsepowerButton"
        Me.horsepowerButton.Size = New System.Drawing.Size(53, 37)
        Me.horsepowerButton.TabIndex = 56
        Me.horsepowerButton.Text = "HP"
        Me.horsepowerButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Horsepower"
        '
        'footPoundSecondBox
        '
        Me.footPoundSecondBox.BackColor = System.Drawing.Color.GhostWhite
        Me.footPoundSecondBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footPoundSecondBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.footPoundSecondBox.Location = New System.Drawing.Point(227, 254)
        Me.footPoundSecondBox.Multiline = True
        Me.footPoundSecondBox.Name = "footPoundSecondBox"
        Me.footPoundSecondBox.Size = New System.Drawing.Size(326, 37)
        Me.footPoundSecondBox.TabIndex = 57
        '
        'footpoundSButton
        '
        Me.footpoundSButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footpoundSButton.ForeColor = System.Drawing.Color.White
        Me.footpoundSButton.Location = New System.Drawing.Point(567, 254)
        Me.footpoundSButton.Name = "footpoundSButton"
        Me.footpoundSButton.Size = New System.Drawing.Size(53, 37)
        Me.footpoundSButton.TabIndex = 59
        Me.footpoundSButton.Text = "FT-LB"
        Me.footpoundSButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Foot-pound / second"
        '
        'footPoundMinutBox
        '
        Me.footPoundMinutBox.BackColor = System.Drawing.Color.GhostWhite
        Me.footPoundMinutBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footPoundMinutBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.footPoundMinutBox.Location = New System.Drawing.Point(227, 311)
        Me.footPoundMinutBox.Multiline = True
        Me.footPoundMinutBox.Name = "footPoundMinutBox"
        Me.footPoundMinutBox.Size = New System.Drawing.Size(326, 37)
        Me.footPoundMinutBox.TabIndex = 60
        '
        'footpoundMButton
        '
        Me.footpoundMButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footpoundMButton.ForeColor = System.Drawing.Color.White
        Me.footpoundMButton.Location = New System.Drawing.Point(567, 311)
        Me.footpoundMButton.Name = "footpoundMButton"
        Me.footpoundMButton.Size = New System.Drawing.Size(53, 37)
        Me.footpoundMButton.TabIndex = 62
        Me.footpoundMButton.Text = "FT-LB"
        Me.footpoundMButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Foot-pound / minut"
        '
        'britishTSBox
        '
        Me.britishTSBox.BackColor = System.Drawing.Color.GhostWhite
        Me.britishTSBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.britishTSBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.britishTSBox.Location = New System.Drawing.Point(227, 370)
        Me.britishTSBox.Multiline = True
        Me.britishTSBox.Name = "britishTSBox"
        Me.britishTSBox.Size = New System.Drawing.Size(326, 37)
        Me.britishTSBox.TabIndex = 63
        '
        'britishTSButton
        '
        Me.britishTSButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.britishTSButton.ForeColor = System.Drawing.Color.White
        Me.britishTSButton.Location = New System.Drawing.Point(567, 370)
        Me.britishTSButton.Name = "britishTSButton"
        Me.britishTSButton.Size = New System.Drawing.Size(53, 37)
        Me.britishTSButton.TabIndex = 65
        Me.britishTSButton.Text = "BTUs"
        Me.britishTSButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 16)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "British Thermal / Second"
        '
        'britishTHBox
        '
        Me.britishTHBox.BackColor = System.Drawing.Color.GhostWhite
        Me.britishTHBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.britishTHBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.britishTHBox.Location = New System.Drawing.Point(227, 428)
        Me.britishTHBox.Multiline = True
        Me.britishTHBox.Name = "britishTHBox"
        Me.britishTHBox.Size = New System.Drawing.Size(326, 37)
        Me.britishTHBox.TabIndex = 66
        '
        'britishTHButton
        '
        Me.britishTHButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.britishTHButton.ForeColor = System.Drawing.Color.White
        Me.britishTHButton.Location = New System.Drawing.Point(567, 428)
        Me.britishTHButton.Name = "britishTHButton"
        Me.britishTHButton.Size = New System.Drawing.Size(53, 37)
        Me.britishTHButton.TabIndex = 68
        Me.britishTHButton.Text = "BTUh"
        Me.britishTHButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 437)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 16)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "British Thermal / Hour"
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.ForeColor = System.Drawing.Color.White
        Me.clearButton.Location = New System.Drawing.Point(474, 492)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(146, 37)
        Me.clearButton.TabIndex = 69
        Me.clearButton.Text = "CLEAR FIELDS"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'PowerConverterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 541)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.britishTHBox)
        Me.Controls.Add(Me.britishTHButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.britishTSBox)
        Me.Controls.Add(Me.britishTSButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.footPoundMinutBox)
        Me.Controls.Add(Me.footpoundMButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.footPoundSecondBox)
        Me.Controls.Add(Me.footpoundSButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HorsepowerBox)
        Me.Controls.Add(Me.horsepowerButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.calorieBox)
        Me.Controls.Add(Me.calorieButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kilowattBox)
        Me.Controls.Add(Me.killowattButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.wattBox)
        Me.Controls.Add(Me.wattButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PowerConverterForm"
        Me.Text = "PowerConverterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wattBox As System.Windows.Forms.TextBox
    Friend WithEvents wattButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kilowattBox As System.Windows.Forms.TextBox
    Friend WithEvents killowattButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents calorieBox As System.Windows.Forms.TextBox
    Friend WithEvents calorieButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HorsepowerBox As System.Windows.Forms.TextBox
    Friend WithEvents horsepowerButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents footPoundSecondBox As System.Windows.Forms.TextBox
    Friend WithEvents footpoundSButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents footPoundMinutBox As System.Windows.Forms.TextBox
    Friend WithEvents footpoundMButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents britishTSBox As System.Windows.Forms.TextBox
    Friend WithEvents britishTSButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents britishTHBox As System.Windows.Forms.TextBox
    Friend WithEvents britishTHButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents clearButton As System.Windows.Forms.Button
End Class
