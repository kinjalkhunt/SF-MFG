Public Class Form3
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        CalculateAmount()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        CalculateAmount()
        CalculateDiscountValue()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        CalculateDiscountValue()
    End Sub

    Private Sub CalculateAmount()
        Dim meter As Decimal
        Dim rate As Decimal

        Decimal.TryParse(TextBox8.Text, meter)
        Decimal.TryParse(TextBox9.Text, rate)

        TextBox7.Text = (meter * rate).ToString("0.##")
    End Sub

    Private Sub CalculateDiscountValue()
        Dim rate As Decimal
        Dim percent As Decimal

        Decimal.TryParse(TextBox9.Text, rate)
        Decimal.TryParse(TextBox10.Text, percent)

        Dim discountValue As Decimal = (rate * percent) / 100D
        TextBox11.Text = discountValue.ToString("0.##")
    End Sub
End Class