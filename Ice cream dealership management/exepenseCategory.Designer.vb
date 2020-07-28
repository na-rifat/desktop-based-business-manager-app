<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class exepenseCategory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CNameLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim CNameLabel1 As System.Windows.Forms.Label
        Dim RemarkLabel1 As System.Windows.Forms.Label
        Dim CLabel As System.Windows.Forms.Label
        Dim CLabel1 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblExpenseCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblExpenseCategoryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpenseCategoryTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblExpenseSubcategoryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpenseSubcategoryTableAdapter()
        Me.TblExpenseSubcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.RemarkTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CNameTextBox = New System.Windows.Forms.TextBox()
        Me.RemarkTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TblExpenseSubcategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblExpenseCategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.delete_category = New System.Windows.Forms.ToolStripButton()
        Me.delete_subcategory = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        CNameLabel = New System.Windows.Forms.Label()
        RemarkLabel = New System.Windows.Forms.Label()
        CNameLabel1 = New System.Windows.Forms.Label()
        RemarkLabel1 = New System.Windows.Forms.Label()
        CLabel = New System.Windows.Forms.Label()
        CLabel1 = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpenseCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpenseSubcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblExpenseSubcategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpenseCategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CNameLabel
        '
        CNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        CNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CNameLabel.Location = New System.Drawing.Point(58, 5)
        CNameLabel.Name = "CNameLabel"
        CNameLabel.Size = New System.Drawing.Size(97, 24)
        CNameLabel.TabIndex = 53
        CNameLabel.Text = "ধরনের নামঃ"
        CNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RemarkLabel
        '
        RemarkLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        RemarkLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        RemarkLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        RemarkLabel.Location = New System.Drawing.Point(58, 30)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(97, 24)
        RemarkLabel.TabIndex = 55
        RemarkLabel.Text = "মন্তব্যঃ"
        RemarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CNameLabel1
        '
        CNameLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        CNameLabel1.Font = New System.Drawing.Font("Verdana", 14.0!)
        CNameLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        CNameLabel1.Location = New System.Drawing.Point(47, 6)
        CNameLabel1.Name = "CNameLabel1"
        CNameLabel1.Size = New System.Drawing.Size(145, 24)
        CNameLabel1.TabIndex = 54
        CNameLabel1.Text = "সহকারি-ধরনের নামঃ"
        CNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RemarkLabel1
        '
        RemarkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        RemarkLabel1.Font = New System.Drawing.Font("Verdana", 14.0!)
        RemarkLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        RemarkLabel1.Location = New System.Drawing.Point(47, 56)
        RemarkLabel1.Name = "RemarkLabel1"
        RemarkLabel1.Size = New System.Drawing.Size(145, 24)
        RemarkLabel1.TabIndex = 56
        RemarkLabel1.Text = "মন্তব্যঃ"
        RemarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CLabel
        '
        CLabel.BackColor = System.Drawing.Color.Black
        CLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CLabel.Location = New System.Drawing.Point(47, 31)
        CLabel.Name = "CLabel"
        CLabel.Size = New System.Drawing.Size(145, 24)
        CLabel.TabIndex = 58
        CLabel.Text = "ধরনঃ"
        CLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CLabel1
        '
        CLabel1.AutoSize = True
        CLabel1.Location = New System.Drawing.Point(666, 19)
        CLabel1.Name = "CLabel1"
        CLabel1.Size = New System.Drawing.Size(18, 13)
        CLabel1.TabIndex = 16
        CLabel1.Text = "c:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "খরচের ধরন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblExpenseCategoryBindingSource
        '
        Me.TblExpenseCategoryBindingSource.DataMember = "tblExpenseCategory"
        Me.TblExpenseCategoryBindingSource.DataSource = Me.DataSet
        '
        'TblExpenseCategoryTableAdapter
        '
        Me.TblExpenseCategoryTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblExpenseCategoryTableAdapter = Me.TblExpenseCategoryTableAdapter
        Me.TableAdapterManager.tblExpenseReportTableAdapter = Nothing
        Me.TableAdapterManager.tblExpensesTableAdapter = Nothing
        Me.TableAdapterManager.tblExpenseSubcategoryTableAdapter = Me.TblExpenseSubcategoryTableAdapter
        Me.TableAdapterManager.tblFridgesTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeSubcategoryTableAdapter = Nothing
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
        'TblExpenseSubcategoryTableAdapter
        '
        Me.TblExpenseSubcategoryTableAdapter.ClearBeforeFill = True
        '
        'TblExpenseSubcategoryBindingSource
        '
        Me.TblExpenseSubcategoryBindingSource.DataMember = "tblExpenseSubcategory"
        Me.TblExpenseSubcategoryBindingSource.DataSource = Me.DataSet
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TblExpenseSubcategoryDataGridView)
        Me.Panel1.Controls.Add(Me.TblExpenseCategoryDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(33, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 532)
        Me.Panel1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(465, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(450, 35)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "সহকারি ধরনসমূহ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(450, 35)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ধরনসমূহ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(465, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 222)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "খরচের নতুন সহকারি ধরন"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(CLabel)
        Me.Panel3.Controls.Add(Me.CTextBox)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(CNameLabel1)
        Me.Panel3.Controls.Add(Me.CNameTextBox1)
        Me.Panel3.Controls.Add(RemarkLabel1)
        Me.Panel3.Controls.Add(Me.RemarkTextBox1)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(7, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(443, 148)
        Me.Panel3.TabIndex = 52
        '
        'CTextBox
        '
        Me.CTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpenseSubcategoryBindingSource, "c", True))
        Me.CTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CTextBox.Location = New System.Drawing.Point(198, 31)
        Me.CTextBox.Name = "CTextBox"
        Me.CTextBox.Size = New System.Drawing.Size(215, 24)
        Me.CTextBox.TabIndex = 59
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(198, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 35)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "যুক্ত করুন"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CNameTextBox1
        '
        Me.CNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpenseSubcategoryBindingSource, "cName", True))
        Me.CNameTextBox1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CNameTextBox1.Location = New System.Drawing.Point(198, 6)
        Me.CNameTextBox1.Name = "CNameTextBox1"
        Me.CNameTextBox1.Size = New System.Drawing.Size(215, 24)
        Me.CNameTextBox1.TabIndex = 55
        '
        'RemarkTextBox1
        '
        Me.RemarkTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpenseSubcategoryBindingSource, "remark", True))
        Me.RemarkTextBox1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RemarkTextBox1.Location = New System.Drawing.Point(198, 56)
        Me.RemarkTextBox1.Name = "RemarkTextBox1"
        Me.RemarkTextBox1.Size = New System.Drawing.Size(215, 24)
        Me.RemarkTextBox1.TabIndex = 57
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(205, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 44)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 222)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "খরচের নতুন ধরন"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(CNameLabel)
        Me.Panel2.Controls.Add(Me.CNameTextBox)
        Me.Panel2.Controls.Add(RemarkLabel)
        Me.Panel2.Controls.Add(Me.RemarkTextBox)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(6, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 125)
        Me.Panel2.TabIndex = 51
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(161, 60)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 35)
        Me.Button4.TabIndex = 57
        Me.Button4.Text = "যুক্ত করুন"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CNameTextBox
        '
        Me.CNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpenseCategoryBindingSource, "cName", True))
        Me.CNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CNameTextBox.Location = New System.Drawing.Point(161, 5)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.Size = New System.Drawing.Size(250, 24)
        Me.CNameTextBox.TabIndex = 54
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpenseCategoryBindingSource, "remark", True))
        Me.RemarkTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RemarkTextBox.Location = New System.Drawing.Point(161, 30)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(250, 24)
        Me.RemarkTextBox.TabIndex = 56
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(167, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 44)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TblExpenseSubcategoryDataGridView
        '
        Me.TblExpenseSubcategoryDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TblExpenseSubcategoryDataGridView.AutoGenerateColumns = False
        Me.TblExpenseSubcategoryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblExpenseSubcategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblExpenseSubcategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.c})
        Me.TblExpenseSubcategoryDataGridView.DataSource = Me.TblExpenseSubcategoryBindingSource
        Me.TblExpenseSubcategoryDataGridView.Location = New System.Drawing.Point(465, 268)
        Me.TblExpenseSubcategoryDataGridView.Name = "TblExpenseSubcategoryDataGridView"
        Me.TblExpenseSubcategoryDataGridView.Size = New System.Drawing.Size(450, 248)
        Me.TblExpenseSubcategoryDataGridView.TabIndex = 9
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
        'c
        '
        Me.c.DataPropertyName = "c"
        Me.c.HeaderText = "c"
        Me.c.Name = "c"
        Me.c.Visible = False
        '
        'TblExpenseCategoryDataGridView
        '
        Me.TblExpenseCategoryDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TblExpenseCategoryDataGridView.AutoGenerateColumns = False
        Me.TblExpenseCategoryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblExpenseCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblExpenseCategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblExpenseCategoryDataGridView.DataSource = Me.TblExpenseCategoryBindingSource
        Me.TblExpenseCategoryDataGridView.Location = New System.Drawing.Point(9, 268)
        Me.TblExpenseCategoryDataGridView.Name = "TblExpenseCategoryDataGridView"
        Me.TblExpenseCategoryDataGridView.Size = New System.Drawing.Size(450, 248)
        Me.TblExpenseCategoryDataGridView.TabIndex = 10
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
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpenseCategoryBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(250, 12)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(41, 21)
        Me.IdTextBox.TabIndex = 52
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpenseSubcategoryBindingSource, "Id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(250, 12)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(41, 21)
        Me.IdTextBox1.TabIndex = 53
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton5, Me.ToolStripButton3, Me.delete_category, Me.delete_subcategory, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 32)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(175, 32)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 29)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtFilter.Items.AddRange(New Object() {"খরচের ধরন"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(100, 32)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 29)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripButton5.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton5.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(128, 28)
        Me.ToolStripButton5.Text = "ধরন সংশোধন"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.DarkGreen
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(188, 28)
        Me.ToolStripButton3.Text = "সহকারি ধরন সংশোধন"
        '
        'delete_category
        '
        Me.delete_category.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.delete_category.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.delete_category.ForeColor = System.Drawing.Color.Red
        Me.delete_category.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.delete_category.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.delete_category.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.delete_category.Name = "delete_category"
        Me.delete_category.Size = New System.Drawing.Size(111, 28)
        Me.delete_category.Text = "ধরন-ডিলিট"
        '
        'delete_subcategory
        '
        Me.delete_subcategory.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.delete_subcategory.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.delete_subcategory.ForeColor = System.Drawing.Color.Red
        Me.delete_subcategory.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.delete_subcategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.delete_subcategory.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.delete_subcategory.Name = "delete_subcategory"
        Me.delete_subcategory.Size = New System.Drawing.Size(171, 24)
        Me.delete_subcategory.Text = "সহকারি ধরন-ডিলিট"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton6.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton6.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton6.Size = New System.Drawing.Size(67, 28)
        Me.ToolStripButton6.Text = "প্রিন্ট"
        '
        'exepenseCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(CLabel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.SteelBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "exepenseCategory"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpenseCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpenseSubcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblExpenseSubcategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpenseCategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblExpenseCategoryBindingSource As BindingSource
    Friend WithEvents TblExpenseCategoryTableAdapter As dataSetTableAdapters.tblExpenseCategoryTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblExpenseSubcategoryTableAdapter As dataSetTableAdapters.tblExpenseSubcategoryTableAdapter
    Friend WithEvents TblExpenseSubcategoryBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TblExpenseSubcategoryDataGridView As DataGridView
    Friend WithEvents TblExpenseCategoryDataGridView As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents CNameTextBox As TextBox
    Friend WithEvents RemarkTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents CNameTextBox1 As TextBox
    Friend WithEvents RemarkTextBox1 As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents delete_category As ToolStripButton
    Friend WithEvents CTextBox As TextBox
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents delete_subcategory As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents c As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
