Public Class binaryConverter

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'the integer can be changed to int64 
        ' int64 = bigger value than int32 or integer


        RadioButton1.Checked = False
        RadioButton1.Checked = True



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'convert to decimal
        If IsNumeric(TextBox1.Text) Then
            Dim result As Integer
            Dim binary As String = TextBox1.Text
            result = Convert.ToInt32(binary, 2)
            Label2.Text = result

            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Binary to Decimal " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")

            ListBox1.TopIndex = ListBox1.Items.Count - 1
        End If




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim num As Double = TextBox1.Text
        'And num < Integer.MaxValue

        'convert to binary
        If IsNumeric(TextBox1.Text) Then
            Dim decimal1 As Integer = TextBox1.Text
            Dim result As String = ""
            result = Convert.ToString(decimal1, 2)
            Label2.Text = result


            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Decimal To Binary " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")
            ListBox1.TopIndex = ListBox1.Items.Count - 1
        End If


    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Clear()
        Label2.Text = ""

        'textbox1 lenght limit
        TextBox1.MaxLength = 30

        If RadioButton1.Checked = True Then
            'Button2.Enabled = False
            'Button3.Enabled = False
            'Button4.Enabled = False

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button1" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl



        Else


            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button1" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl



        End If



        '   Button2.Enabled = True
        '  Button3.Enabled = True
        ' Button4.Enabled = True

        'End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Clear()
        Label2.Text = ""

        'length of textbox1
        TextBox1.MaxLength = 9


        If RadioButton2.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button2" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button2" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'only 0 and 1 allowed
        If RadioButton1.Checked = True And TextBox1.Text.Length > 0 Or RadioButton3.Checked = True And TextBox1.Text.Length > 0 Or RadioButton5.Checked = True And TextBox1.Text.Length > 0 Then

            Dim u As Integer = 0
            Dim p As Integer = TextBox1.Text.Length


            For u = 0 To p - 1
                If p > 0 Then

                    Dim a As String = TextBox1.Text.Substring(p - 1, 1)

                    ' MsgBox(a)
                    If a = "1" Or a = "0" Then
                    Else
                        Dim s As String = TextBox1.Text.Remove(p - 1, 1)
                        TextBox1.Text = s

                    End If
                    p = p - 1

                End If
            Next


        End If
        'decimal validation
        If RadioButton2.Checked = True And TextBox1.Text.Length > 0 Or RadioButton7.Checked = True And TextBox1.Text.Length > 0 Or RadioButton8.Checked = True And TextBox1.Text.Length > 0 Then
            Dim u As Integer = 0
            Dim p As Integer = TextBox1.Text.Length


            For u = 0 To p - 1
                If p > 0 Then

                    Dim a As String = TextBox1.Text.Substring(p - 1, 1)

                    ' MsgBox(a)
                    If IsNumeric(a) Then
                    Else
                        Dim s As String = TextBox1.Text.Remove(p - 1, 1)
                        TextBox1.Text = s

                    End If
                    p = p - 1

                End If
            Next


        End If

        'octal validation

        If RadioButton10.Checked = True And TextBox1.Text.Length > 0 Or RadioButton11.Checked = True And TextBox1.Text.Length > 0 Or RadioButton12.Checked = True And TextBox1.Text.Length > 0 Then
            Dim u As Integer = 0
            Dim p As Integer = TextBox1.Text.Length


            For u = 0 To p - 1
                If p > 0 Then

                    Dim a As String = TextBox1.Text.Substring(p - 1, 1)

                    ' MsgBox(a)
                    If a = "0" Or a = "1" Or a = "2" Or a = "3" Or a = "4" Or a = "5" Or _
a = "6" Or a = "7" Then
                    Else
                        Dim s As String = TextBox1.Text.Remove(p - 1, 1)
                        TextBox1.Text = s

                    End If
                    p = p - 1

                End If
            Next
        End If

        'hex validation
        If RadioButton6.Checked = True And TextBox1.Text.Length > 0 Or RadioButton4.Checked = True And TextBox1.Text.Length > 0 Or RadioButton9.Checked = True And TextBox1.Text.Length > 0 Then
            Dim u As Integer = 0
            Dim p As Integer = TextBox1.Text.Length


            For u = 0 To p - 1
                If p > 0 Then

                    Dim a As String = TextBox1.Text.Substring(p - 1, 1)

                    ' MsgBox(a)
                    If IsNumeric(a) Or a = "a" Or a = "b" Or a = "c" Or a = "d" Or a = "e" Or a = "f" _
                    Or a = "A" Or a = "B" Or a = "C" Or a = "D" Or a = "E" Or a = "F" Then
                    Else
                        Dim s As String = TextBox1.Text.Remove(p - 1, 1)
                        TextBox1.Text = s

                    End If
                    p = p - 1

                End If
            Next


        End If





    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'convert to decimal and after to hex
        If IsNumeric(TextBox1.Text) Then
            Dim result As Integer
            Dim binary As String = TextBox1.Text
            result = Convert.ToInt32(binary, 2)
            Label2.Text = Hex(result)

            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Binary to Hex " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")
            ListBox1.TopIndex = ListBox1.Items.Count - 1
        End If



    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Clear()
        Label2.Text = ""

        'textbox1 lenght limit
        TextBox1.MaxLength = 30


        If RadioButton3.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button3" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button3" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        ' int64 = bigger integer value

        ' MsgBox(System.Convert.ToInt32("100", 16))
        If TextBox1.Text.Length > 0 Then

            Dim hex As String = TextBox1.Text
            'decimal
            Dim dec As Int64 = System.Convert.ToInt64(hex, 16)

            'convert to binary
            If IsNumeric(dec) Then
                Dim decimal1 As Int64 = dec
                Dim result As String = ""
                result = Convert.ToString(decimal1, 2)
                Label2.Text = result


                'update calculation history
                ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Hex To Binary " + TextBox1.Text)
                ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
                ListBox1.Items.Add("")
                ListBox1.TopIndex = ListBox1.Items.Count - 1
            End If

        End If


    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        TextBox1.Clear()
        Label2.Text = ""

        'lenght of textbox1
        TextBox1.MaxLength = 10


        If RadioButton4.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button9" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button9" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'convert to decimal
        If IsNumeric(TextBox1.Text) Then
            Dim result As Integer
            Dim binary As String = TextBox1.Text
            result = Convert.ToInt32(binary, 2)

            Label2.Text = Oct(result)

            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Binary to Octal " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")
            ListBox1.TopIndex = ListBox1.Items.Count - 1

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click


        '0 to 7 numbers allowed for octal
        If IsNumeric(TextBox1.Text) Then
            'octal to decimal
            Dim strOctal As String
            strOctal = TextBox1.Text
            Dim lngValue As Integer = CLng("&O" & strOctal)
            'convert to binary
            Dim decimal1 As Integer = lngValue
            Dim result As String = ""
            result = Convert.ToString(decimal1, 2)
            Label2.Text = result


            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Octal To Binary " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")
            ListBox1.TopIndex = ListBox1.Items.Count - 1
        End If




    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click



        'convert to binary first
        If IsNumeric(TextBox1.Text) Then
            Dim decimal1 As Integer = TextBox1.Text
            Dim result As String = ""
            result = Convert.ToString(decimal1, 2)



            'convert to decimal and after to hex

            Dim result1 As Integer
            Dim binary As String = result
            result1 = Convert.ToInt32(binary, 2)
            Label2.Text = Hex(result1)



            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Decimal To Hex " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")
            ListBox1.TopIndex = ListBox1.Items.Count - 1


        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'convert to binary first
        If IsNumeric(TextBox1.Text) Then
            Dim result As Integer = TextBox1.Text

            Label2.Text = Oct(result)


            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Decimal To Octal " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")
            ListBox1.TopIndex = ListBox1.Items.Count - 1

        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        'lenght of textbox1
        TextBox1.MaxLength = 10
        'hex letters a-f 

        TextBox1.Clear()
        Label2.Text = ""

        If RadioButton6.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button4" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button4" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        If TextBox1.Text.Length > 0 Then

            Dim hex As String = TextBox1.Text
            'decimal
            Dim dec As Int64 = System.Convert.ToInt64(hex, 16)

            'octal
            Label2.Text = Oct(dec)

            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Hex To Octal " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")
            ListBox1.TopIndex = ListBox1.Items.Count - 1

        End If



    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        If TextBox1.Text.Length > 0 Then

            Dim hex As String = TextBox1.Text
            'decimal
            Dim dec As Int64 = System.Convert.ToInt64(hex, 16)
            Label2.Text = dec.ToString


            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Hex To Decimal " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")
            ListBox1.TopIndex = ListBox1.Items.Count - 1

        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        '0 to 7 numbers allowed for octal
        If IsNumeric(TextBox1.Text) Then
            'octal to decimal
            Dim strOctal As String
            strOctal = TextBox1.Text
            Dim lngValue As Integer


            lngValue = CLng("&O" & strOctal)
            Label2.Text = lngValue.ToString


            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Octal To Decimal " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")
            ListBox1.TopIndex = ListBox1.Items.Count - 1
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        '0 to 7 numbers allowed for octal
        If IsNumeric(TextBox1.Text) Then
            'octal to decimal
            Dim strOctal As String
            strOctal = TextBox1.Text
            Dim lngValue As Integer


            lngValue = CLng("&O" & strOctal)

            'decimal to hex
            Label2.Text = Hex(lngValue)


            'update calculation history
            ListBox1.Items.Add("Last Converted: " + Date.Now.ToLongTimeString.ToString + "  Octal To Hex " + TextBox1.Text)
            ListBox1.Items.Add("Last Answer:" + " " + Label2.Text)
            ListBox1.Items.Add("")
            ListBox1.TopIndex = ListBox1.Items.Count - 1

        End If
    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        TextBox1.Clear()
        Label2.Text = ""

        'textbox1 lenght limit
        TextBox1.MaxLength = 30


        If RadioButton5.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button5" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button5" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        'lenght of textbox1
        TextBox1.MaxLength = 10

        TextBox1.Clear()
        Label2.Text = ""

        If RadioButton9.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button10" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button10" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged

        'length of textbox1
        TextBox1.MaxLength = 9

        TextBox1.Clear()
        Label2.Text = ""

        If RadioButton7.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button7" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button7" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        'length of textbox1
        TextBox1.MaxLength = 9

        TextBox1.Clear()
        Label2.Text = ""

        If RadioButton8.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button8" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button8" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        TextBox1.Clear()
        Label2.Text = ""

        'lenght of textbox1
        TextBox1.MaxLength = 10

        If RadioButton10.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button6" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button6" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        TextBox1.Clear()
        Label2.Text = ""

        'lenght of textbox1
        TextBox1.MaxLength = 10

        If RadioButton12.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button11" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button11" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        TextBox1.Clear()
        Label2.Text = ""

        'lenght of textbox1
        TextBox1.MaxLength = 10

        If RadioButton11.Checked = True Then

            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button12" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = False
                    End If
                End If
            Next cControl

        Else
            Dim cControl As Control
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    'MsgBox(cControl.Name.ToString)
                    If Not cControl.Name.ToString = "Button12" And Not cControl.Name.ToString = "Button13" Then
                        cControl.Enabled = True
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ListBox1.Items.Clear()
    End Sub



    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetDataObject(Label2.Text, True)

    End Sub

    Private Sub Label2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(CType(sender, Control), e.Location)

        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Dim back As New Estimator
        back = New Estimator()
        Me.Close()
        back.Show()

    End Sub
End Class