<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardPanel
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
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        TextBox1 = New TextBox()
        Section4 = New ComboBox()
        Section3 = New ComboBox()
        Section2 = New ComboBox()
        Section1 = New ComboBox()
        Label12 = New Label()
        RoundCornerPanel9 = New RoundCornerPanel()
        Label5 = New Label()
        Label11 = New Label()
        RoundCornerPanel8 = New RoundCornerPanel()
        Label4 = New Label()
        Label10 = New Label()
        RoundCornerPanel7 = New RoundCornerPanel()
        Label3 = New Label()
        Label9 = New Label()
        RoundCornerPanel6 = New RoundCornerPanel()
        Label2 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        RoundCornerPanel9.SuspendLayout()
        RoundCornerPanel8.SuspendLayout()
        RoundCornerPanel7.SuspendLayout()
        RoundCornerPanel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.GridColor = Color.White
        DataGridView1.Location = New Point(7, 321)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(847, 322)
        DataGridView1.TabIndex = 28
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "STUDENT #"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "NAME"
        Column2.Name = "Column2"
        Column2.Width = 250
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "EMAIL"
        Column3.Name = "Column3"
        Column3.Width = 200
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "GENDER"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "VIEW"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "REMARKS"
        Column6.Name = "Column6"
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources.search__1_
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Location = New Point(558, 287)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(22, 28)
        Panel3.TabIndex = 27
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(583, 287)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "  Search Here..."
        TextBox1.Size = New Size(271, 28)
        TextBox1.TabIndex = 22
        ' 
        ' Section4
        ' 
        Section4.BackColor = Color.Red
        Section4.FlatStyle = FlatStyle.Flat
        Section4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Section4.ForeColor = Color.White
        Section4.FormattingEnabled = True
        Section4.Items.AddRange(New Object() {"1A", "1B", "2A", "2B", "3A", "3B", "4A", "4B"})
        Section4.Location = New Point(694, 226)
        Section4.Name = "Section4"
        Section4.Size = New Size(121, 23)
        Section4.TabIndex = 26
        Section4.Text = "Select Section..."
        ' 
        ' Section3
        ' 
        Section3.BackColor = Color.FromArgb(CByte(102), CByte(61), CByte(216))
        Section3.FlatStyle = FlatStyle.Flat
        Section3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Section3.ForeColor = Color.White
        Section3.FormattingEnabled = True
        Section3.Items.AddRange(New Object() {"1A", "1B", "2A", "2B", "3A", "3B", "4A", "4B"})
        Section3.Location = New Point(481, 226)
        Section3.Name = "Section3"
        Section3.Size = New Size(121, 23)
        Section3.TabIndex = 25
        Section3.Text = "Select Section..."
        ' 
        ' Section2
        ' 
        Section2.BackColor = Color.FromArgb(CByte(51), CByte(111), CByte(255))
        Section2.FlatStyle = FlatStyle.Flat
        Section2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Section2.ForeColor = Color.White
        Section2.FormattingEnabled = True
        Section2.Items.AddRange(New Object() {"1A", "1B", "2A", "2B", "3A", "3B", "4A", "4B"})
        Section2.Location = New Point(262, 226)
        Section2.Name = "Section2"
        Section2.Size = New Size(121, 23)
        Section2.TabIndex = 24
        Section2.Text = "Select Section..."
        ' 
        ' Section1
        ' 
        Section1.BackColor = Color.FromArgb(CByte(244), CByte(194), CByte(12))
        Section1.FlatStyle = FlatStyle.Flat
        Section1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Section1.ForeColor = Color.White
        Section1.FormattingEnabled = True
        Section1.Items.AddRange(New Object() {"1A", "1B", "2A", "2B", "3A", "3B", "4A", "4B"})
        Section1.Location = New Point(47, 228)
        Section1.Name = "Section1"
        Section1.Size = New Size(121, 23)
        Section1.TabIndex = 23
        Section1.Text = "Select Section..."
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label12.Location = New Point(7, 288)
        Label12.Name = "Label12"
        Label12.Size = New Size(143, 25)
        Label12.TabIndex = 21
        Label12.Text = "List of Students"
        ' 
        ' RoundCornerPanel9
        ' 
        RoundCornerPanel9.BackColor = Color.Red
        RoundCornerPanel9.Controls.Add(Label5)
        RoundCornerPanel9.Controls.Add(Label11)
        RoundCornerPanel9.Location = New Point(649, 91)
        RoundCornerPanel9.Name = "RoundCornerPanel9"
        RoundCornerPanel9.Size = New Size(205, 129)
        RoundCornerPanel9.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(13, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 20)
        Label5.TabIndex = 31
        Label5.Text = "TOTAL SECTION"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(13, 90)
        Label11.Name = "Label11"
        Label11.Size = New Size(93, 32)
        Label11.TabIndex = 10
        Label11.Text = "BSEMC"
        ' 
        ' RoundCornerPanel8
        ' 
        RoundCornerPanel8.BackColor = Color.FromArgb(CByte(102), CByte(61), CByte(216))
        RoundCornerPanel8.Controls.Add(Label4)
        RoundCornerPanel8.Controls.Add(Label10)
        RoundCornerPanel8.Location = New Point(435, 91)
        RoundCornerPanel8.Name = "RoundCornerPanel8"
        RoundCornerPanel8.Size = New Size(205, 129)
        RoundCornerPanel8.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(13, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 20)
        Label4.TabIndex = 32
        Label4.Text = "TOTAL SECTION"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(13, 90)
        Label10.Name = "Label10"
        Label10.Size = New Size(63, 32)
        Label10.TabIndex = 10
        Label10.Text = "BSIS"
        ' 
        ' RoundCornerPanel7
        ' 
        RoundCornerPanel7.BackColor = Color.FromArgb(CByte(51), CByte(111), CByte(255))
        RoundCornerPanel7.Controls.Add(Label3)
        RoundCornerPanel7.Controls.Add(Label9)
        RoundCornerPanel7.Location = New Point(221, 91)
        RoundCornerPanel7.Name = "RoundCornerPanel7"
        RoundCornerPanel7.Size = New Size(205, 129)
        RoundCornerPanel7.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(13, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 20)
        Label3.TabIndex = 31
        Label3.Text = "TOTAL SECTION"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(13, 90)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 32)
        Label9.TabIndex = 9
        Label9.Text = "BSIT"
        ' 
        ' RoundCornerPanel6
        ' 
        RoundCornerPanel6.BackColor = Color.FromArgb(CByte(244), CByte(194), CByte(12))
        RoundCornerPanel6.Controls.Add(Label2)
        RoundCornerPanel6.Controls.Add(Label8)
        RoundCornerPanel6.Location = New Point(7, 91)
        RoundCornerPanel6.Name = "RoundCornerPanel6"
        RoundCornerPanel6.Size = New Size(205, 129)
        RoundCornerPanel6.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(13, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 20)
        Label2.TabIndex = 30
        Label2.Text = "TOTAL SECTION"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(13, 90)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 32)
        Label8.TabIndex = 8
        Label8.Text = "BSCS"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label7.Location = New Point(4, 54)
        Label7.Name = "Label7"
        Label7.Size = New Size(306, 25)
        Label7.TabIndex = 16
        Label7.Text = "WELCOME, PROFESSOR BARRIOS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label6.Location = New Point(2, -44)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 32)
        Label6.TabIndex = 15
        Label6.Text = "DASHBOARD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label1.Location = New Point(4, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 32)
        Label1.TabIndex = 29
        Label1.Text = "DASHBOARD"
        ' 
        ' DashboardPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(861, 648)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Controls.Add(TextBox1)
        Controls.Add(Section4)
        Controls.Add(Section3)
        Controls.Add(Section2)
        Controls.Add(Section1)
        Controls.Add(Label12)
        Controls.Add(RoundCornerPanel9)
        Controls.Add(RoundCornerPanel8)
        Controls.Add(RoundCornerPanel7)
        Controls.Add(RoundCornerPanel6)
        Controls.Add(Label7)
        Controls.Add(Label6)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(861, 648)
        MinimumSize = New Size(861, 648)
        Name = "DashboardPanel"
        Text = "DashboardPanel"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        RoundCornerPanel9.ResumeLayout(False)
        RoundCornerPanel9.PerformLayout()
        RoundCornerPanel8.ResumeLayout(False)
        RoundCornerPanel8.PerformLayout()
        RoundCornerPanel7.ResumeLayout(False)
        RoundCornerPanel7.PerformLayout()
        RoundCornerPanel6.ResumeLayout(False)
        RoundCornerPanel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Section4 As ComboBox
    Friend WithEvents Section3 As ComboBox
    Friend WithEvents Section2 As ComboBox
    Friend WithEvents Section1 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents RoundCornerPanel9 As RoundCornerPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents RoundCornerPanel8 As RoundCornerPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents RoundCornerPanel7 As RoundCornerPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents RoundCornerPanel6 As RoundCornerPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
