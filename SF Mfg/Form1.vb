Imports Microsoft.Data.SqlClient
Imports System.Data

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

        Dim connectionString As String = "Data Source=localhost\sqlexpress;Initial Catalog=swissfortdb;Integrated Security=True;TrustServerCertificate=True"
        Dim query As String = "SELECT COUNT(*) FROM [dbo].[LoginForm] WHERE [UserName]=@username AND [Password]=@password"

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                MessageBox.Show("Connection successful!")
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        Dim frm2 As New Form2()
                        frm2.ShowDialog(Me)
                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Connection failed: " & ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
