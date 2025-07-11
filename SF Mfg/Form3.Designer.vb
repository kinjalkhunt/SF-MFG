<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        TextBox7 = New TextBox()
        Button1 = New Button()
        Label16 = New Label()
        TextBox15 = New TextBox()
        Label17 = New Label()
        TextBox14 = New TextBox()
        Label14 = New Label()
        TextBox12 = New TextBox()
        Label15 = New Label()
        TextBox13 = New TextBox()
        Label12 = New Label()
        TextBox10 = New TextBox()
        Label13 = New Label()
        TextBox11 = New TextBox()
        Label11 = New Label()
        TextBox6 = New TextBox()
        ComboBox2 = New ComboBox()
        TextBox8 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        TextBox9 = New TextBox()
        TextBox5 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        DataGridView1 = New DataGridView()
        mtr = New DataGridViewTextBoxColumn()
        Amount = New DataGridViewTextBoxColumn()
        Discount = New DataGridViewTextBoxColumn()
        CGST = New DataGridViewTextBoxColumn()
        SGST = New DataGridViewTextBoxColumn()
        Total = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(6, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 17)
        Label1.TabIndex = 0
        Label1.Text = "Trn No"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(145, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 17)
        Label2.TabIndex = 1
        Label2.Text = "Invoice No"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(314, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 17)
        Label3.TabIndex = 2
        Label3.Text = "Invoice Date"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(340, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 17)
        Label4.TabIndex = 3
        Label4.Text = "Trn Date"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label5.ForeColor = Color.MidnightBlue
        Label5.Location = New Point(6, 60)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 17)
        Label5.TabIndex = 4
        Label5.Text = "Party"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.Navy
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 94)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Party and Bill Detail"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        ComboBox1.ForeColor = Color.MidnightBlue
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(56, 59)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(237, 27)
        ComboBox1.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox4.ForeColor = Color.MidnightBlue
        TextBox4.Location = New Point(410, 48)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(253, 26)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.MidnightBlue
        TextBox2.Location = New Point(229, 18)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(68, 26)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox3.ForeColor = Color.MidnightBlue
        TextBox3.Location = New Point(410, 16)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(253, 26)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.MidnightBlue
        TextBox1.Location = New Point(65, 18)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(68, 26)
        TextBox1.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(TextBox15)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(TextBox14)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(TextBox12)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(TextBox13)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(TextBox10)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(TextBox11)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(ComboBox2)
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(TextBox9)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(14, 113)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(776, 133)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Fabric Detail"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label8.ForeColor = Color.MidnightBlue
        Label8.Location = New Point(219, 98)
        Label8.Name = "Label8"
        Label8.Size = New Size(92, 17)
        Label8.TabIndex = 23
        Label8.Text = "Final Amount"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox7.ForeColor = Color.MidnightBlue
        TextBox7.Location = New Point(331, 95)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(68, 26)
        TextBox7.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(633, 90)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 33)
        Button1.TabIndex = 18
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label16.ForeColor = Color.MidnightBlue
        Label16.Location = New Point(642, 60)
        Label16.Name = "Label16"
        Label16.Size = New Size(42, 17)
        Label16.TabIndex = 22
        Label16.Text = "Value"
        Label16.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox15
        ' 
        TextBox15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox15.ForeColor = Color.MidnightBlue
        TextBox15.Location = New Point(686, 57)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(68, 26)
        TextBox15.TabIndex = 15
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label17.ForeColor = Color.MidnightBlue
        Label17.Location = New Point(513, 60)
        Label17.Name = "Label17"
        Label17.Size = New Size(50, 17)
        Label17.TabIndex = 20
        Label17.Text = "SGST%"
        Label17.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox14
        ' 
        TextBox14.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox14.ForeColor = Color.MidnightBlue
        TextBox14.Location = New Point(569, 57)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(68, 26)
        TextBox14.TabIndex = 14
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label14.ForeColor = Color.MidnightBlue
        Label14.Location = New Point(132, 60)
        Label14.Name = "Label14"
        Label14.Size = New Size(34, 17)
        Label14.TabIndex = 18
        Label14.Text = "Amt"
        Label14.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox12
        ' 
        TextBox12.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox12.ForeColor = Color.MidnightBlue
        TextBox12.Location = New Point(321, 58)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(68, 26)
        TextBox12.TabIndex = 12
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label15.ForeColor = Color.MidnightBlue
        Label15.Location = New Point(394, 60)
        Label15.Name = "Label15"
        Label15.Size = New Size(42, 17)
        Label15.TabIndex = 16
        Label15.Text = "Value"
        Label15.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox13
        ' 
        TextBox13.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox13.ForeColor = Color.MidnightBlue
        TextBox13.Location = New Point(440, 57)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(68, 26)
        TextBox13.TabIndex = 13
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label12.ForeColor = Color.MidnightBlue
        Label12.Location = New Point(12, 60)
        Label12.Name = "Label12"
        Label12.Size = New Size(43, 17)
        Label12.TabIndex = 14
        Label12.Text = "Dis %"
        Label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox10.ForeColor = Color.MidnightBlue
        TextBox10.Location = New Point(59, 57)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(68, 26)
        TextBox10.TabIndex = 10
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label13.ForeColor = Color.MidnightBlue
        Label13.Location = New Point(258, 60)
        Label13.Name = "Label13"
        Label13.Size = New Size(51, 17)
        Label13.TabIndex = 12
        Label13.Text = "CGST%"
        Label13.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox11.ForeColor = Color.MidnightBlue
        TextBox11.Location = New Point(177, 57)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(68, 26)
        TextBox11.TabIndex = 11
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label11.ForeColor = Color.MidnightBlue
        Label11.Location = New Point(396, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(35, 17)
        Label11.TabIndex = 10
        Label11.Text = "Rate"
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox6.ForeColor = Color.MidnightBlue
        TextBox6.Location = New Point(443, 15)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(68, 26)
        TextBox6.TabIndex = 8
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        ComboBox2.ForeColor = Color.MidnightBlue
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(88, 15)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(134, 27)
        ComboBox2.TabIndex = 6
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox8.ForeColor = Color.MidnightBlue
        TextBox8.Location = New Point(115, 97)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(94, 26)
        TextBox8.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label6.ForeColor = Color.MidnightBlue
        Label6.Location = New Point(12, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 17)
        Label6.TabIndex = 1
        Label6.Text = "DisAmount"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label7.ForeColor = Color.MidnightBlue
        Label7.Location = New Point(528, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 17)
        Label7.TabIndex = 2
        Label7.Text = "Amount"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox9.ForeColor = Color.MidnightBlue
        TextBox9.Location = New Point(594, 15)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(68, 26)
        TextBox9.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox5.ForeColor = Color.MidnightBlue
        TextBox5.Location = New Point(312, 16)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(68, 26)
        TextBox5.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label9.ForeColor = Color.MidnightBlue
        Label9.Location = New Point(6, 16)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 17)
        Label9.TabIndex = 4
        Label9.Text = "Fabric For"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.MidnightBlue
        Label10.Location = New Point(262, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(44, 17)
        Label10.TabIndex = 0
        Label10.Text = "Meter"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {mtr, Amount, Discount, CGST, SGST, Total})
        DataGridView1.GridColor = SystemColors.InactiveCaption
        DataGridView1.Location = New Point(795, 12)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(541, 474)
        DataGridView1.TabIndex = 19
        ' 
        ' mtr
        ' 
        mtr.HeaderText = "Mtr"
        mtr.MinimumWidth = 6
        mtr.Name = "mtr"
        mtr.Width = 125
        ' 
        ' Amount
        ' 
        Amount.HeaderText = "Amount"
        Amount.MinimumWidth = 6
        Amount.Name = "Amount"
        Amount.Resizable = DataGridViewTriState.True
        Amount.SortMode = DataGridViewColumnSortMode.NotSortable
        Amount.Width = 125
        ' 
        ' Discount
        ' 
        Discount.HeaderText = "Discount"
        Discount.MinimumWidth = 6
        Discount.Name = "Discount"
        Discount.Width = 125
        ' 
        ' CGST
        ' 
        CGST.HeaderText = "CGST"
        CGST.MinimumWidth = 6
        CGST.Name = "CGST"
        CGST.Width = 125
        ' 
        ' SGST
        ' 
        SGST.HeaderText = "SGST"
        SGST.MinimumWidth = 6
        SGST.Name = "SGST"
        SGST.Width = 125
        ' 
        ' Total
        ' 
        Total.HeaderText = "Total Amt"
        Total.MinimumWidth = 6
        Total.Name = "Total"
        Total.Width = 125
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1347, 525)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        ForeColor = Color.MidnightBlue
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fabric Entry"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mtr As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents CGST As DataGridViewTextBoxColumn
    Friend WithEvents SGST As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
End Class
