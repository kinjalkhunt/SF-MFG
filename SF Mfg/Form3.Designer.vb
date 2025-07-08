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
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        Label16 = New Label()
        TextBox14 = New TextBox()
        Label17 = New Label()
        TextBox15 = New TextBox()
        Label14 = New Label()
        TextBox12 = New TextBox()
        Label15 = New Label()
        TextBox13 = New TextBox()
        Label12 = New Label()
        TextBox10 = New TextBox()
        Label13 = New Label()
        TextBox11 = New TextBox()
        Label11 = New Label()
        TextBox9 = New TextBox()
        ComboBox2 = New ComboBox()
        TextBox6 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
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
        Label1.Location = New Point(7, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 23)
        Label1.TabIndex = 0
        Label1.Text = "Trn No"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(166, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 23)
        Label2.TabIndex = 1
        Label2.Text = "Invoice No"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(359, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 23)
        Label3.TabIndex = 2
        Label3.Text = "Invoice Date"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(565, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 23)
        Label4.TabIndex = 3
        Label4.Text = "Trn Date"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label5.ForeColor = Color.MidnightBlue
        Label5.Location = New Point(7, 80)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 23)
        Label5.TabIndex = 4
        Label5.Text = "Party"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.Navy
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(887, 125)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Party and Bill Detail"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(64, 79)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(270, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(641, 24)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(77, 27)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(257, 24)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(77, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(463, 24)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(77, 27)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(64, 24)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(77, 27)
        TextBox1.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(TextBox14)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(TextBox15)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(TextBox12)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(TextBox13)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(TextBox10)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(TextBox11)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(TextBox9)
        GroupBox2.Controls.Add(ComboBox2)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(16, 151)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(887, 177)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Fabric Detail"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(298, 119)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 44)
        Button1.TabIndex = 17
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label16.ForeColor = Color.MidnightBlue
        Label16.Location = New Point(734, 80)
        Label16.Name = "Label16"
        Label16.Size = New Size(53, 23)
        Label16.TabIndex = 22
        Label16.Text = "Value"
        Label16.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(784, 76)
        TextBox14.Margin = New Padding(3, 4, 3, 4)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(77, 27)
        TextBox14.TabIndex = 15
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label17.ForeColor = Color.MidnightBlue
        Label17.Location = New Point(586, 80)
        Label17.Name = "Label17"
        Label17.Size = New Size(72, 23)
        Label17.TabIndex = 20
        Label17.Text = "SGST %"
        Label17.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox15
        ' 
        TextBox15.Location = New Point(650, 76)
        TextBox15.Margin = New Padding(3, 4, 3, 4)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(77, 27)
        TextBox15.TabIndex = 14
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label14.ForeColor = Color.MidnightBlue
        Label14.Location = New Point(151, 80)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 23)
        Label14.TabIndex = 18
        Label14.Text = "Amt"
        Label14.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(375, 78)
        TextBox12.Margin = New Padding(3, 4, 3, 4)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(77, 27)
        TextBox12.TabIndex = 11
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label15.ForeColor = Color.MidnightBlue
        Label15.Location = New Point(450, 80)
        Label15.Name = "Label15"
        Label15.Size = New Size(53, 23)
        Label15.TabIndex = 16
        Label15.Text = "Value"
        Label15.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(503, 76)
        TextBox13.Margin = New Padding(3, 4, 3, 4)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(77, 27)
        TextBox13.TabIndex = 13
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label12.ForeColor = Color.MidnightBlue
        Label12.Location = New Point(14, 80)
        Label12.Name = "Label12"
        Label12.Size = New Size(55, 23)
        Label12.TabIndex = 14
        Label12.Text = "Dis %"
        Label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(67, 76)
        TextBox10.Margin = New Padding(3, 4, 3, 4)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(77, 27)
        TextBox10.TabIndex = 10
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label13.ForeColor = Color.MidnightBlue
        Label13.Location = New Point(295, 80)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 23)
        Label13.TabIndex = 12
        Label13.Text = "CGST %"
        Label13.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(202, 76)
        TextBox11.Margin = New Padding(3, 4, 3, 4)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(77, 27)
        TextBox11.TabIndex = 12
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label11.ForeColor = Color.MidnightBlue
        Label11.Location = New Point(417, 25)
        Label11.Name = "Label11"
        Label11.Size = New Size(46, 23)
        Label11.TabIndex = 10
        Label11.Text = "Rate"
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(470, 20)
        TextBox9.Margin = New Padding(3, 4, 3, 4)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(77, 27)
        TextBox9.TabIndex = 8
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(90, 20)
        ComboBox2.Margin = New Padding(3, 4, 3, 4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(153, 28)
        ComboBox2.TabIndex = 6
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(123, 127)
        TextBox6.Margin = New Padding(3, 4, 3, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(107, 27)
        TextBox6.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label6.ForeColor = Color.MidnightBlue
        Label6.Location = New Point(14, 131)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 23)
        Label6.TabIndex = 1
        Label6.Text = "Final Amount"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label7.ForeColor = Color.MidnightBlue
        Label7.Location = New Point(567, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 23)
        Label7.TabIndex = 2
        Label7.Text = "Amount"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(643, 20)
        TextBox7.Margin = New Padding(3, 4, 3, 4)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(77, 27)
        TextBox7.TabIndex = 9
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(320, 21)
        TextBox8.Margin = New Padding(3, 4, 3, 4)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(77, 27)
        TextBox8.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label9.ForeColor = Color.MidnightBlue
        Label9.Location = New Point(7, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 23)
        Label9.TabIndex = 4
        Label9.Text = "Fabric For"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.MidnightBlue
        Label10.Location = New Point(263, 25)
        Label10.Name = "Label10"
        Label10.Size = New Size(58, 23)
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
        DataGridView1.Location = New Point(915, 21)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(836, 188)
        DataGridView1.TabIndex = 11
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
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1900, 700)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
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
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mtr As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents CGST As DataGridViewTextBoxColumn
    Friend WithEvents SGST As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
