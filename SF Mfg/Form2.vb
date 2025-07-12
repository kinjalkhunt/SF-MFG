Public Class Form2
    Private Sub FabricEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FabricEntryToolStripMenuItem.Click
        Dim frm3 As New Form3()
        frm3.StartPosition = FormStartPosition.CenterParent
        frm3.ShowDialog(Me)
    End Sub

    Private Sub PartyMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartyMasterToolStripMenuItem.Click
        Dim frm4 As New Form4()
        frm4.StartPosition = FormStartPosition.CenterParent
        frm4.ShowDialog(Me)
    End Sub
End Class