<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        MenuStrip1 = New MenuStrip()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        PartyMasterToolStripMenuItem = New ToolStripMenuItem()
        EmployeeMasterToolStripMenuItem = New ToolStripMenuItem()
        TransactionToolStripMenuItem = New ToolStripMenuItem()
        FabricEntryToolStripMenuItem = New ToolStripMenuItem()
        CuttingEntryToolStripMenuItem = New ToolStripMenuItem()
        WorkEntryToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MasterToolStripMenuItem, TransactionToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(914, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PartyMasterToolStripMenuItem, EmployeeMasterToolStripMenuItem})
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(68, 24)
        MasterToolStripMenuItem.Text = "Master"
        ' 
        ' PartyMasterToolStripMenuItem
        ' 
        PartyMasterToolStripMenuItem.Name = "PartyMasterToolStripMenuItem"
        PartyMasterToolStripMenuItem.Size = New Size(207, 26)
        PartyMasterToolStripMenuItem.Text = "Party Master"
        ' 
        ' EmployeeMasterToolStripMenuItem
        ' 
        EmployeeMasterToolStripMenuItem.Name = "EmployeeMasterToolStripMenuItem"
        EmployeeMasterToolStripMenuItem.Size = New Size(207, 26)
        EmployeeMasterToolStripMenuItem.Text = "Employee Master"
        ' 
        ' TransactionToolStripMenuItem
        ' 
        TransactionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FabricEntryToolStripMenuItem, CuttingEntryToolStripMenuItem, WorkEntryToolStripMenuItem})
        TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        TransactionToolStripMenuItem.Size = New Size(98, 24)
        TransactionToolStripMenuItem.Text = "Transaction"
        ' 
        ' FabricEntryToolStripMenuItem
        ' 
        FabricEntryToolStripMenuItem.Name = "FabricEntryToolStripMenuItem"
        FabricEntryToolStripMenuItem.Size = New Size(224, 26)
        FabricEntryToolStripMenuItem.Text = "Fabric Entry"
        ' 
        ' CuttingEntryToolStripMenuItem
        ' 
        CuttingEntryToolStripMenuItem.Name = "CuttingEntryToolStripMenuItem"
        CuttingEntryToolStripMenuItem.Size = New Size(224, 26)
        CuttingEntryToolStripMenuItem.Text = "Cutting Entry"
        ' 
        ' WorkEntryToolStripMenuItem
        ' 
        WorkEntryToolStripMenuItem.Name = "WorkEntryToolStripMenuItem"
        WorkEntryToolStripMenuItem.Size = New Size(224, 26)
        WorkEntryToolStripMenuItem.Text = "Work Entry"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Swissfort Mfg."
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartyMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FabricEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuttingEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WorkEntryToolStripMenuItem As ToolStripMenuItem
End Class
