Public Class Form2
    Private Sub FabricEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FabricEntryToolStripMenuItem.Click
        Dim frm3 As New Form3()
        frm3.StartPosition = FormStartPosition.CenterParent
        frm3.ShowDialog(Me)
    End Sub
End Class