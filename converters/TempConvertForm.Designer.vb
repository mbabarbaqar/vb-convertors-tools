<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TempConvertForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TempConvertForm))
        Me.dcButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.calsius = New System.Windows.Forms.TextBox
        Me.dfButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.fahrenheit = New System.Windows.Forms.TextBox
        Me.klButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.kelvin = New System.Windows.Forms.TextBox
        Me.tempScale = New System.Windows.Forms.ProgressBar
        Me.clearButton = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'dcButton
        '
        Me.dcButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dcButton.ForeColor = System.Drawing.Color.White
        Me.dcButton.Location = New System.Drawing.Point(351, 43)
        Me.dcButton.Name = "dcButton"
        Me.dcButton.Size = New System.Drawing.Size(44, 37)
        Me.dcButton.TabIndex = 5
        Me.dcButton.Text = "DC"
        Me.dcButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Degrees Calsius"
        '
        'calsius
        '
        Me.calsius.BackColor = System.Drawing.Color.GhostWhite
        Me.calsius.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calsius.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.calsius.Location = New System.Drawing.Point(21, 44)
        Me.calsius.Multiline = True
        Me.calsius.Name = "calsius"
        Me.calsius.Size = New System.Drawing.Size(324, 37)
        Me.calsius.TabIndex = 3
        '
        'dfButton
        '
        Me.dfButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dfButton.ForeColor = System.Drawing.Color.White
        Me.dfButton.Location = New System.Drawing.Point(351, 120)
        Me.dfButton.Name = "dfButton"
        Me.dfButton.Size = New System.Drawing.Size(44, 37)
        Me.dfButton.TabIndex = 8
        Me.dfButton.Text = "DF"
        Me.dfButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Degrees Fahrenheit"
        '
        'fahrenheit
        '
        Me.fahrenheit.BackColor = System.Drawing.Color.GhostWhite
        Me.fahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fahrenheit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.fahrenheit.Location = New System.Drawing.Point(21, 121)
        Me.fahrenheit.Multiline = True
        Me.fahrenheit.Name = "fahrenheit"
        Me.fahrenheit.Size = New System.Drawing.Size(324, 37)
        Me.fahrenheit.TabIndex = 6
        '
        'klButton
        '
        Me.klButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.klButton.ForeColor = System.Drawing.Color.White
        Me.klButton.Location = New System.Drawing.Point(351, 198)
        Me.klButton.Name = "klButton"
        Me.klButton.Size = New System.Drawing.Size(44, 37)
        Me.klButton.TabIndex = 11
        Me.klButton.Text = "KL"
        Me.klButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Kelvin"
        '
        'kelvin
        '
        Me.kelvin.BackColor = System.Drawing.Color.GhostWhite
        Me.kelvin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelvin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.kelvin.Location = New System.Drawing.Point(21, 199)
        Me.kelvin.Multiline = True
        Me.kelvin.Name = "kelvin"
        Me.kelvin.Size = New System.Drawing.Size(324, 37)
        Me.kelvin.TabIndex = 9
        '
        'tempScale
        '
        Me.tempScale.Location = New System.Drawing.Point(21, 266)
        Me.tempScale.Name = "tempScale"
        Me.tempScale.Size = New System.Drawing.Size(374, 10)
        Me.tempScale.TabIndex = 12
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(266, 317)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(129, 36)
        Me.clearButton.TabIndex = 13
        Me.clearButton.Text = "Clear All Fields"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "50"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "100"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(320, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "200"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(364, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "1000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(147, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "-50"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(98, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "-100"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(62, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "-200"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 279)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "-1000"
        '
        'TempConvertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 365)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.tempScale)
        Me.Controls.Add(Me.klButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kelvin)
        Me.Controls.Add(Me.dfButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fahrenheit)
        Me.Controls.Add(Me.dcButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calsius)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TempConvertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Temprature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dcButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents calsius As System.Windows.Forms.TextBox
    Friend WithEvents dfButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fahrenheit As System.Windows.Forms.TextBox
    Friend WithEvents klButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents kelvin As System.Windows.Forms.TextBox
    Friend WithEvents tempScale As System.Windows.Forms.ProgressBar
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
