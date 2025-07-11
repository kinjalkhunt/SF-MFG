Public Class swissfort
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler TextBox1.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBox2.KeyDown, AddressOf TextBox_KeyDown
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(CType(sender, Control), True, True, True, True)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If username = "admin" AndAlso password = "1" Then
            Dim frm2 As New Form2()
            frm2.ShowDialog(Me)
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
