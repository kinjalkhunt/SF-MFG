Public Class Form3
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        CalculateAmount()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        CalculateAmount()
        CalculateDiscountValue()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        CalculateDiscountValue()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        CalculateDisAmount()
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        CalculateDisAmount()
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        CalculateCgstValue()
        CalculateSgstValue()
        CalculateTotal()
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        CalculateCgstValue()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        CalculateSgstValue()
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        CalculateTotal()
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        CalculateTotal()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Attach Enter/Leave/KeyDown handlers to all TextBoxes and ComboBoxes
        For Each ctrl As Control In Me.Controls
            AddHandlerToInputs(ctrl)
        Next

        ' Set current date and time in 12-hour format in TextBox3 and TextBox4
        TextBox3.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        TextBox4.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
    End Sub

    Private Sub AddHandlerToInputs(ctrl As Control)
        If TypeOf ctrl Is TextBox Then
            AddHandler ctrl.Enter, AddressOf TextBox_Enter
            AddHandler ctrl.Leave, AddressOf TextBox_Leave
            AddHandler CType(ctrl, TextBox).KeyDown, AddressOf Input_KeyDown
        ElseIf TypeOf ctrl Is ComboBox Then
            AddHandler CType(ctrl, ComboBox).KeyDown, AddressOf Input_KeyDown
        End If
        ' Recursively handle controls in containers (like GroupBox)
        For Each child As Control In ctrl.Controls
            AddHandlerToInputs(child)
        Next
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs)
        CType(sender, TextBox).BackColor = Color.LightGreen
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs)
        CType(sender, TextBox).BackColor = Color.White
    End Sub

    Private Sub Input_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent beep
            Me.SelectNextControl(CType(sender, Control), True, True, True, True)
        End If
    End Sub

    Private Sub CalculateAmount()
        Dim meter As Decimal
        Dim rate As Decimal

        Decimal.TryParse(TextBox5.Text, meter)
        Decimal.TryParse(TextBox6.Text, rate)

        TextBox9.Text = (meter * rate).ToString("0.##")
    End Sub

    Private Sub CalculateDiscountValue()
        Dim amount As Decimal
        Dim percent As Decimal

        Decimal.TryParse(TextBox9.Text, amount)
        Decimal.TryParse(TextBox10.Text, percent)

        Dim discountValue As Decimal = (percent / 100D) * amount
        TextBox11.Text = discountValue.ToString("0.##")
    End Sub

    Private Sub CalculateDisAmount()
        Dim amount As Decimal
        Dim Amt As Decimal

        Decimal.TryParse(TextBox9.Text, amount)
        Decimal.TryParse(TextBox11.Text, Amt)

        Dim disAmount As Decimal = amount - Amt
        TextBox8.Text = disAmount.ToString("0.##")
    End Sub

    Private Sub CalculateCgstValue()
        Dim DisAmount As Decimal
        Dim CGST As Decimal

        Decimal.TryParse(TextBox8.Text, DisAmount)
        Decimal.TryParse(TextBox12.Text, CGST)

        Dim cgstValue As Decimal = (CGST / 100D) * DisAmount
        TextBox13.Text = cgstValue.ToString("0.##")
    End Sub

    Private Sub CalculateSgstValue()
        Dim DisAmount As Decimal
        Dim SGST As Decimal

        Decimal.TryParse(TextBox8.Text, DisAmount)
        Decimal.TryParse(TextBox14.Text, SGST)

        Dim sgstValue As Decimal = (SGST / 100D) * DisAmount
        TextBox15.Text = sgstValue.ToString("0.##")
    End Sub

    Private Sub CalculateTotal()
        Dim val1 As Decimal
        Dim val2 As Decimal
        Dim val3 As Decimal

        Decimal.TryParse(TextBox8.Text, val1)
        Decimal.TryParse(TextBox13.Text, val2)
        Decimal.TryParse(TextBox15.Text, val3)

        Dim total As Decimal = val1 + val2 + val3
        TextBox7.Text = total.ToString("0.##")
    End Sub

End Class