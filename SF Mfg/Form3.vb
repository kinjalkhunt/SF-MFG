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
End Class