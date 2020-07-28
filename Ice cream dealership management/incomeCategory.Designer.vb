<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incomeCategory
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
        Me.components = New System.ComponentModel.Container()
        Dim CNameLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim CNameLabel1 As System.Windows.Forms.Label
        Dim RemarkLabel1 As System.Windows.Forms.Label
        Dim CLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblIncomeSubcategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblIncomeSubcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblIncomeCategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblIncomeCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.RemarkTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CNameTextBox = New System.Windows.Forms.TextBox()
        Me.RemarkTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblIncomeCategoryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblIncomeCategoryTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblIncomeSubcategoryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblIncomeSubcategoryTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        CNameLabel = New System.Windows.Forms.Label()
        RemarkLabel = New System.Windows.Forms.Label()
        CNameLabel1 = New System.Windows.Forms.Label()
        RemarkLabel1 = New System.Windows.Forms.Label()
        CLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblIncomeSubcategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncomeSubcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncomeCategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncomeCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CNameLabel
        '
        CNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        CNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CNameLabel.Location = New System.Drawing.Point(48, 5)
        CNameLabel.Name = "CNameLabel"
        CNameLabel.Size = New System.Drawing.Size(90, 25)
        CNameLabel.TabIndex = 55
        CNameLabel.Text = "ধরনের নামঃ"
        CNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RemarkLabel
        '
        RemarkLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        RemarkLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        RemarkLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        RemarkLabel.Location = New System.Drawing.Point(48, 31)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(90, 25)
        RemarkLabel.TabIndex = 57
        RemarkLabel.Text = "মন্তব্যঃ"
        RemarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CNameLabel1
        '
        CNameLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        CNameLabel1.Font = New System.Drawing.Font("Verdana", 14.0!)
        CNameLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        CNameLabel1.Location = New System.Drawing.Point(57, 6)
        CNameLabel1.Name = "CNameLabel1"
        CNameLabel1.Size = New System.Drawing.Size(134, 25)
        CNameLabel1.TabIndex = 57
        CNameLabel1.Text = "সহকারি ধরনের নামঃ"
        CNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RemarkLabel1
        '
        RemarkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        RemarkLabel1.Font = New System.Drawing.Font("Verdana", 14.0!)
        RemarkLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        RemarkLabel1.Location = New System.Drawing.Point(57, 58)
        RemarkLabel1.Name = "RemarkLabel1"
        RemarkLabel1.Size = New System.Drawing.Size(134, 25)
        RemarkLabel1.TabIndex = 59
        RemarkLabel1.Text = "মন্তব্যঃ"
        RemarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CLabel
        '
        CLabel.BackColor = System.Drawing.Color.Black
        CLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CLabel.Location = New System.Drawing.Point(57, 32)
        CLabel.Name = "CLabel"
        CLabel.Size = New System.Drawing.Size(134, 25)
        CLabel.TabIndex = 61
        CLabel.Text = "ধরনঃ"
        CLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(141, 382)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 16
        IdLabel.Text = "Id:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(95, 386)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(24, 13)
        IdLabel1.TabIndex = 17
        IdLabel1.Text = "Id:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TblIncomeSubcategoryDataGridView)
        Me.Panel1.Controls.Add(Me.TblIncomeCategoryDataGridView)
        Me.Panel1.Controls.Add(IdLabel1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.IdTextBox1)
        Me.Panel1.Controls.Add(IdLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(12, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 556)
        Me.Panel1.TabIndex = 9
        '
        'TblIncomeSubcategoryDataGridView
        '
        Me.TblIncomeSubcategoryDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TblIncomeSubcategoryDataGridView.AutoGenerateColumns = False
        Me.TblIncomeSubcategoryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblIncomeSubcategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TblIncomeSubcategoryDataGridView.DataSource = Me.TblIncomeSubcategoryBindingSource
        Me.TblIncomeSubcategoryDataGridView.Location = New System.Drawing.Point(475, 278)
        Me.TblIncomeSubcategoryDataGridView.Name = "TblIncomeSubcategoryDataGridView"
        Me.TblIncomeSubcategoryDataGridView.Size = New System.Drawing.Size(450, 275)
        Me.TblIncomeSubcategoryDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "নাম"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "remark"
        Me.DataGridViewTextBoxColumn6.HeaderText = "মন্তব্য"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'TblIncomeSubcategoryBindingSource
        '
        Me.TblIncomeSubcategoryBindingSource.DataMember = "tblIncomeSubcategory"
        Me.TblIncomeSubcategoryBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblIncomeCategoryDataGridView
        '
        Me.TblIncomeCategoryDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TblIncomeCategoryDataGridView.AutoGenerateColumns = False
        Me.TblIncomeCategoryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblIncomeCategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblIncomeCategoryDataGridView.DataSource = Me.TblIncomeCategoryBindingSource
        Me.TblIncomeCategoryDataGridView.Location = New System.Drawing.Point(19, 278)
        Me.TblIncomeCategoryDataGridView.Name = "TblIncomeCategoryDataGridView"
        Me.TblIncomeCategoryDataGridView.Size = New System.Drawing.Size(450, 275)
        Me.TblIncomeCategoryDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "নাম"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "remark"
        Me.DataGridViewTextBoxColumn3.HeaderText = "মন্তব্য"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'TblIncomeCategoryBindingSource
        '
        Me.TblIncomeCategoryBindingSource.DataMember = "tblIncomeCategory"
        Me.TblIncomeCategoryBindingSource.DataSource = Me.DataSet
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(475, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(450, 35)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "সহকারি ধরনসমূহ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeSubcategoryBindingSource, "Id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(120, 383)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.IdTextBox1.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(450, 35)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ধরনসমূহ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeCategoryBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(144, 379)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IdTextBox.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(475, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 226)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "আয়ের নতুন সহকারি ধরন"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(CLabel)
        Me.Panel3.Controls.Add(Me.CTextBox)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(CNameLabel1)
        Me.Panel3.Controls.Add(Me.CNameTextBox1)
        Me.Panel3.Controls.Add(RemarkLabel1)
        Me.Panel3.Controls.Add(Me.RemarkTextBox1)
        Me.Panel3.Enabled = False
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Panel3.Location = New System.Drawing.Point(8, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(428, 137)
        Me.Panel3.TabIndex = 56
        '
        'CTextBox
        '
        Me.CTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeSubcategoryBindingSource, "c", True))
        Me.CTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CTextBox.Location = New System.Drawing.Point(197, 31)
        Me.CTextBox.Name = "CTextBox"
        Me.CTextBox.Size = New System.Drawing.Size(215, 24)
        Me.CTextBox.TabIndex = 62
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(197, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 35)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "যুক্ত করুন"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CNameTextBox1
        '
        Me.CNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeSubcategoryBindingSource, "cName", True))
        Me.CNameTextBox1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CNameTextBox1.Location = New System.Drawing.Point(197, 6)
        Me.CNameTextBox1.Name = "CNameTextBox1"
        Me.CNameTextBox1.Size = New System.Drawing.Size(215, 24)
        Me.CNameTextBox1.TabIndex = 58
        '
        'RemarkTextBox1
        '
        Me.RemarkTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeSubcategoryBindingSource, "remark", True))
        Me.RemarkTextBox1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RemarkTextBox1.Location = New System.Drawing.Point(197, 56)
        Me.RemarkTextBox1.Name = "RemarkTextBox1"
        Me.RemarkTextBox1.Size = New System.Drawing.Size(215, 24)
        Me.RemarkTextBox1.TabIndex = 60
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(205, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 44)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(19, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 226)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "আয়ের নতুন ধরন"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(CNameLabel)
        Me.Panel2.Controls.Add(Me.CNameTextBox)
        Me.Panel2.Controls.Add(RemarkLabel)
        Me.Panel2.Controls.Add(Me.RemarkTextBox)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(21, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(409, 126)
        Me.Panel2.TabIndex = 55
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(144, 61)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 35)
        Me.Button4.TabIndex = 59
        Me.Button4.Text = "যুক্ত করুন"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CNameTextBox
        '
        Me.CNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeCategoryBindingSource, "cName", True))
        Me.CNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CNameTextBox.Location = New System.Drawing.Point(144, 6)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.Size = New System.Drawing.Size(250, 24)
        Me.CNameTextBox.TabIndex = 56
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeCategoryBindingSource, "remark", True))
        Me.RemarkTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RemarkTextBox.Location = New System.Drawing.Point(144, 31)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(250, 24)
        Me.RemarkTextBox.TabIndex = 58
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(165, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 44)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "আয়ের ধরন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblIncomeCategoryTableAdapter
        '
        Me.TblIncomeCategoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sales_targetTableAdapter = Nothing
        Me.TableAdapterManager.tblassetTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceReportTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceTableAdapter = Nothing
        Me.TableAdapterManager.tblBankAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblBanksTableAdapter = Nothing
        Me.TableAdapterManager.tblCashReportTableAdapter = Nothing
        Me.TableAdapterManager.tblCompanySettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblCusomterAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomersTableAdapter = Nothing
        Me.TableAdapterManager.tblDamageFridgeTableAdapter = Nothing
        Me.TableAdapterManager.tblDamageProductsTableAdapter = Nothing
        Me.TableAdapterManager.tblDeliveryTableAdapter = Nothing
        Me.TableAdapterManager.tbldiscountTableAdapter = Nothing
        Me.TableAdapterManager.tblDocumentsCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblDocumentsTableAdapter = Nothing
        Me.TableAdapterManager.tblDuesReportTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblExpenseCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblExpenseReportTableAdapter = Nothing
        Me.TableAdapterManager.tblExpensesTableAdapter = Nothing
        Me.TableAdapterManager.tblExpenseSubcategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblFridgesTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeCategoryTableAdapter = Me.TblIncomeCategoryTableAdapter
        Me.TableAdapterManager.tblIncomeSubcategoryTableAdapter = Me.TblIncomeSubcategoryTableAdapter
        Me.TableAdapterManager.tblIncomeTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblNotesTableAdapter = Nothing
        Me.TableAdapterManager.tblNoticeTableAdapter = Nothing
        Me.TableAdapterManager.tblPCommissionTableAdapter = Nothing
        Me.TableAdapterManager.tblProductCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblProductsTableAdapter = Nothing
        Me.TableAdapterManager.tblProfitTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseReportTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseTableAdapter = Nothing
        Me.TableAdapterManager.tblRentCSTableAdapter = Nothing
        Me.TableAdapterManager.tblRentCTableAdapter = Nothing
        Me.TableAdapterManager.tblRentSTableAdapter = Nothing
        Me.TableAdapterManager.tblSalesreportTableAdapter = Nothing
        Me.TableAdapterManager.tblSalesTableAdapter = Nothing
        Me.TableAdapterManager.tblSCommissionTableAdapter = Nothing
        Me.TableAdapterManager.tblsellcommissionTableAdapter = Nothing
        Me.TableAdapterManager.tblSignboardTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblSuppliersTableAdapter = Nothing
        Me.TableAdapterManager.tblTransactionReportTableAdapter = Nothing
        Me.TableAdapterManager.tblTransactionTableAdapter = Nothing
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblIncomeSubcategoryTableAdapter
        '
        Me.TblIncomeSubcategoryTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton5, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton2, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 35)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(180, 35)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(46, 32)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"আয়ের ধরণ"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(100, 35)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(112, 32)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton5.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(160, 33)
        Me.ToolStripButton5.Text = "ধরন-সংশোধন"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.DarkGreen
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(236, 33)
        Me.ToolStripButton3.Text = "সহকারি ধরন-সংশোধন"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton4.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(135, 29)
        Me.ToolStripButton4.Text = "ধরন-ডিলিট"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(211, 29)
        Me.ToolStripButton2.Text = "সহকারি ধরন-ডিলিট"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton6.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton6.Size = New System.Drawing.Size(78, 33)
        Me.ToolStripButton6.Text = "প্রিন্ট"
        '
        'incomeCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 684)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "incomeCategory"
        Me.Text = "incomeCategory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblIncomeSubcategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncomeSubcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncomeCategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncomeCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblIncomeCategoryBindingSource As BindingSource
    Friend WithEvents TblIncomeCategoryTableAdapter As dataSetTableAdapters.tblIncomeCategoryTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblIncomeCategoryDataGridView As DataGridView
    Friend WithEvents TblIncomeSubcategoryTableAdapter As dataSetTableAdapters.tblIncomeSubcategoryTableAdapter
    Friend WithEvents TblIncomeSubcategoryBindingSource As BindingSource
    Friend WithEvents TblIncomeSubcategoryDataGridView As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents CNameTextBox1 As TextBox
    Friend WithEvents RemarkTextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents CNameTextBox As TextBox
    Friend WithEvents RemarkTextBox As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents CTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
