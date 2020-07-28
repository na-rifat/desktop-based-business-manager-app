<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class discount
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
        Dim Customer_idLabel As System.Windows.Forms.Label
        Dim Customer_nameLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Invoice_noLabel As System.Windows.Forms.Label
        Dim Company_idLabel As System.Windows.Forms.Label
        Dim CompanyLabel As System.Windows.Forms.Label
        Dim Product_categoryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(discount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbldiscountDataGridView = New System.Windows.Forms.DataGridView()
        Me.TbldiscountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtFilter = New System.Windows.Forms.ComboBox()
        Me.Product_categoryLabel1 = New System.Windows.Forms.Label()
        Me.CompanyLabel1 = New System.Windows.Forms.Label()
        Me.Company_idLabel1 = New System.Windows.Forms.Label()
        Me.Invoice_noLabel1 = New System.Windows.Forms.Label()
        Me.DateLabel1 = New System.Windows.Forms.Label()
        Me.Customer_nameLabel1 = New System.Windows.Forms.Label()
        Me.Customer_idLabel1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fromDt = New System.Windows.Forms.DateTimePicker()
        Me.toDt = New System.Windows.Forms.DateTimePicker()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TbldiscountTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tbldiscountTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.given_discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.confirmation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.confirmation_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Customer_idLabel = New System.Windows.Forms.Label()
        Customer_nameLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Invoice_noLabel = New System.Windows.Forms.Label()
        Company_idLabel = New System.Windows.Forms.Label()
        CompanyLabel = New System.Windows.Forms.Label()
        Product_categoryLabel = New System.Windows.Forms.Label()
        CType(Me.TbldiscountDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldiscountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tool.SuspendLayout()
        Me.SuspendLayout()
        '
        'Customer_idLabel
        '
        Customer_idLabel.BackColor = System.Drawing.Color.Black
        Customer_idLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Customer_idLabel.ForeColor = System.Drawing.Color.White
        Customer_idLabel.Location = New System.Drawing.Point(46, 162)
        Customer_idLabel.Name = "Customer_idLabel"
        Customer_idLabel.Size = New System.Drawing.Size(228, 25)
        Customer_idLabel.TabIndex = 134
        Customer_idLabel.Text = "দোকানের আই.ডি.:"
        Customer_idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Customer_nameLabel
        '
        Customer_nameLabel.BackColor = System.Drawing.Color.Black
        Customer_nameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Customer_nameLabel.ForeColor = System.Drawing.Color.White
        Customer_nameLabel.Location = New System.Drawing.Point(46, 136)
        Customer_nameLabel.Name = "Customer_nameLabel"
        Customer_nameLabel.Size = New System.Drawing.Size(228, 25)
        Customer_nameLabel.TabIndex = 135
        Customer_nameLabel.Text = "দোকানের নামঃ"
        Customer_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        DateLabel.BackColor = System.Drawing.Color.Black
        DateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateLabel.ForeColor = System.Drawing.Color.White
        DateLabel.Location = New System.Drawing.Point(46, 32)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(228, 25)
        DateLabel.TabIndex = 136
        DateLabel.Text = "তারিখঃ"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Invoice_noLabel
        '
        Invoice_noLabel.BackColor = System.Drawing.Color.Black
        Invoice_noLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Invoice_noLabel.ForeColor = System.Drawing.Color.White
        Invoice_noLabel.Location = New System.Drawing.Point(46, 6)
        Invoice_noLabel.Name = "Invoice_noLabel"
        Invoice_noLabel.Size = New System.Drawing.Size(228, 25)
        Invoice_noLabel.TabIndex = 137
        Invoice_noLabel.Text = "রশিদ নংঃ"
        Invoice_noLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Company_idLabel
        '
        Company_idLabel.BackColor = System.Drawing.Color.Black
        Company_idLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Company_idLabel.ForeColor = System.Drawing.Color.White
        Company_idLabel.Location = New System.Drawing.Point(46, 110)
        Company_idLabel.Name = "Company_idLabel"
        Company_idLabel.Size = New System.Drawing.Size(228, 25)
        Company_idLabel.TabIndex = 138
        Company_idLabel.Text = "কোম্পানির আই.ডি.:"
        Company_idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyLabel
        '
        CompanyLabel.BackColor = System.Drawing.Color.Black
        CompanyLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CompanyLabel.ForeColor = System.Drawing.Color.White
        CompanyLabel.Location = New System.Drawing.Point(46, 84)
        CompanyLabel.Name = "CompanyLabel"
        CompanyLabel.Size = New System.Drawing.Size(228, 25)
        CompanyLabel.TabIndex = 139
        CompanyLabel.Text = "কোম্পানিঃ"
        CompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Product_categoryLabel
        '
        Product_categoryLabel.BackColor = System.Drawing.Color.Black
        Product_categoryLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Product_categoryLabel.ForeColor = System.Drawing.Color.White
        Product_categoryLabel.Location = New System.Drawing.Point(46, 58)
        Product_categoryLabel.Name = "Product_categoryLabel"
        Product_categoryLabel.Size = New System.Drawing.Size(228, 25)
        Product_categoryLabel.TabIndex = 140
        Product_categoryLabel.Text = "পণ্যের ধরণঃ"
        Product_categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ডিসকাউন্ট"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TbldiscountDataGridView
        '
        Me.TbldiscountDataGridView.AutoGenerateColumns = False
        Me.TbldiscountDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TbldiscountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbldiscountDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.given_discount, Me.DataGridViewTextBoxColumn11, Me.confirmation, Me.confirmation_date})
        Me.TbldiscountDataGridView.DataSource = Me.TbldiscountBindingSource
        Me.TbldiscountDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TbldiscountDataGridView.Location = New System.Drawing.Point(0, 191)
        Me.TbldiscountDataGridView.Name = "TbldiscountDataGridView"
        Me.TbldiscountDataGridView.Size = New System.Drawing.Size(994, 360)
        Me.TbldiscountDataGridView.TabIndex = 17
        '
        'TbldiscountBindingSource
        '
        Me.TbldiscountBindingSource.DataMember = "tbldiscount"
        Me.TbldiscountBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.txtFilter)
        Me.Panel1.Controls.Add(Product_categoryLabel)
        Me.Panel1.Controls.Add(Me.Product_categoryLabel1)
        Me.Panel1.Controls.Add(CompanyLabel)
        Me.Panel1.Controls.Add(Me.CompanyLabel1)
        Me.Panel1.Controls.Add(Company_idLabel)
        Me.Panel1.Controls.Add(Me.Company_idLabel1)
        Me.Panel1.Controls.Add(Invoice_noLabel)
        Me.Panel1.Controls.Add(Me.Invoice_noLabel1)
        Me.Panel1.Controls.Add(DateLabel)
        Me.Panel1.Controls.Add(Me.DateLabel1)
        Me.Panel1.Controls.Add(Customer_nameLabel)
        Me.Panel1.Controls.Add(Me.Customer_nameLabel1)
        Me.Panel1.Controls.Add(Customer_idLabel)
        Me.Panel1.Controls.Add(Me.Customer_idLabel1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.fromDt)
        Me.Panel1.Controls.Add(Me.toDt)
        Me.Panel1.Controls.Add(Me.TbldiscountDataGridView)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Location = New System.Drawing.Point(3, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(994, 576)
        Me.Panel1.TabIndex = 18
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button5.Location = New System.Drawing.Point(634, 135)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 50)
        Me.Button5.TabIndex = 147
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(684, 105)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(180, 24)
        Me.txtSearch.TabIndex = 144
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtFilter.FormattingEnabled = True
        Me.txtFilter.Items.AddRange(New Object() {"Product name", "Product code", "Product category", "Company", "Company ID", "Customer name", "Customer ID", "Invoice NO"})
        Me.txtFilter.Location = New System.Drawing.Point(684, 80)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(180, 24)
        Me.txtFilter.TabIndex = 143
        '
        'Product_categoryLabel1
        '
        Me.Product_categoryLabel1.BackColor = System.Drawing.Color.Black
        Me.Product_categoryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbldiscountBindingSource, "product_category", True))
        Me.Product_categoryLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Product_categoryLabel1.ForeColor = System.Drawing.Color.White
        Me.Product_categoryLabel1.Location = New System.Drawing.Point(278, 58)
        Me.Product_categoryLabel1.Name = "Product_categoryLabel1"
        Me.Product_categoryLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Product_categoryLabel1.Size = New System.Drawing.Size(266, 25)
        Me.Product_categoryLabel1.TabIndex = 141
        Me.Product_categoryLabel1.Text = "NaN"
        '
        'CompanyLabel1
        '
        Me.CompanyLabel1.BackColor = System.Drawing.Color.Black
        Me.CompanyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbldiscountBindingSource, "company", True))
        Me.CompanyLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CompanyLabel1.ForeColor = System.Drawing.Color.White
        Me.CompanyLabel1.Location = New System.Drawing.Point(278, 84)
        Me.CompanyLabel1.Name = "CompanyLabel1"
        Me.CompanyLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.CompanyLabel1.Size = New System.Drawing.Size(266, 25)
        Me.CompanyLabel1.TabIndex = 140
        Me.CompanyLabel1.Text = "NaN"
        '
        'Company_idLabel1
        '
        Me.Company_idLabel1.BackColor = System.Drawing.Color.Black
        Me.Company_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbldiscountBindingSource, "company_id", True))
        Me.Company_idLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Company_idLabel1.ForeColor = System.Drawing.Color.White
        Me.Company_idLabel1.Location = New System.Drawing.Point(278, 110)
        Me.Company_idLabel1.Name = "Company_idLabel1"
        Me.Company_idLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Company_idLabel1.Size = New System.Drawing.Size(266, 25)
        Me.Company_idLabel1.TabIndex = 139
        Me.Company_idLabel1.Text = "NaN"
        '
        'Invoice_noLabel1
        '
        Me.Invoice_noLabel1.BackColor = System.Drawing.Color.Black
        Me.Invoice_noLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbldiscountBindingSource, "invoice_no", True))
        Me.Invoice_noLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Invoice_noLabel1.ForeColor = System.Drawing.Color.White
        Me.Invoice_noLabel1.Location = New System.Drawing.Point(278, 6)
        Me.Invoice_noLabel1.Name = "Invoice_noLabel1"
        Me.Invoice_noLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Invoice_noLabel1.Size = New System.Drawing.Size(266, 25)
        Me.Invoice_noLabel1.TabIndex = 138
        Me.Invoice_noLabel1.Text = "NaN"
        '
        'DateLabel1
        '
        Me.DateLabel1.BackColor = System.Drawing.Color.Black
        Me.DateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbldiscountBindingSource, "date", True))
        Me.DateLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateLabel1.ForeColor = System.Drawing.Color.White
        Me.DateLabel1.Location = New System.Drawing.Point(278, 32)
        Me.DateLabel1.Name = "DateLabel1"
        Me.DateLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.DateLabel1.Size = New System.Drawing.Size(266, 25)
        Me.DateLabel1.TabIndex = 137
        Me.DateLabel1.Text = "NaN"
        '
        'Customer_nameLabel1
        '
        Me.Customer_nameLabel1.BackColor = System.Drawing.Color.Black
        Me.Customer_nameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbldiscountBindingSource, "customer_name", True))
        Me.Customer_nameLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Customer_nameLabel1.ForeColor = System.Drawing.Color.White
        Me.Customer_nameLabel1.Location = New System.Drawing.Point(278, 136)
        Me.Customer_nameLabel1.Name = "Customer_nameLabel1"
        Me.Customer_nameLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Customer_nameLabel1.Size = New System.Drawing.Size(266, 25)
        Me.Customer_nameLabel1.TabIndex = 136
        Me.Customer_nameLabel1.Text = "NaN"
        '
        'Customer_idLabel1
        '
        Me.Customer_idLabel1.BackColor = System.Drawing.Color.Black
        Me.Customer_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbldiscountBindingSource, "customer_id", True))
        Me.Customer_idLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Customer_idLabel1.ForeColor = System.Drawing.Color.White
        Me.Customer_idLabel1.Location = New System.Drawing.Point(278, 162)
        Me.Customer_idLabel1.Name = "Customer_idLabel1"
        Me.Customer_idLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Customer_idLabel1.Size = New System.Drawing.Size(266, 25)
        Me.Customer_idLabel1.TabIndex = 135
        Me.Customer_idLabel1.Text = "NaN"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(819, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 134
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(584, 135)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 131
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(684, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 50)
        Me.Button1.TabIndex = 130
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'fromDt
        '
        Me.fromDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.fromDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDt.Location = New System.Drawing.Point(684, 30)
        Me.fromDt.Name = "fromDt"
        Me.fromDt.Size = New System.Drawing.Size(122, 24)
        Me.fromDt.TabIndex = 120
        '
        'toDt
        '
        Me.toDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.toDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.toDt.Location = New System.Drawing.Point(684, 55)
        Me.toDt.Name = "toDt"
        Me.toDt.Size = New System.Drawing.Size(122, 24)
        Me.toDt.TabIndex = 121
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 551)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(994, 25)
        Me.tool.TabIndex = 142
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripLabel3.Text = "Total discount: "
        '
        'TbldiscountTableAdapter
        '
        Me.TbldiscountTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbldiscountTableAdapter = Me.TbldiscountTableAdapter
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "product_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "পণ্যের নাম"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "product_code"
        Me.DataGridViewTextBoxColumn3.HeaderText = "কোড"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "পরিমাণ"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "unit_price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "দর"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "total_price"
        Me.DataGridViewTextBoxColumn9.HeaderText = "দাম"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'given_discount
        '
        Me.given_discount.DataPropertyName = "given_discount"
        Me.given_discount.HeaderText = "ডিসকাউন্ট অর্থের পরিমাণ"
        Me.given_discount.Name = "given_discount"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "net_price"
        Me.DataGridViewTextBoxColumn11.HeaderText = "নিট দাম"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'confirmation
        '
        Me.confirmation.DataPropertyName = "confirmation"
        Me.confirmation.HeaderText = "কনফারমেশন"
        Me.confirmation.Name = "confirmation"
        '
        'confirmation_date
        '
        Me.confirmation_date.DataPropertyName = "confirmation_date"
        Me.confirmation_date.HeaderText = "confirmation_date"
        Me.confirmation_date.Name = "confirmation_date"
        Me.confirmation_date.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(812, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "পর্যন্ত"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(812, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "থেকে-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(596, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 25)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "সার্চ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(596, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "সার্চের ধরন"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "discount"
        Me.Text = "discount"
        CType(Me.TbldiscountDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldiscountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TbldiscountBindingSource As BindingSource
    Friend WithEvents TbldiscountTableAdapter As dataSetTableAdapters.tbldiscountTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbldiscountDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents fromDt As DateTimePicker
    Friend WithEvents toDt As DateTimePicker
    Friend WithEvents Product_categoryLabel1 As Label
    Friend WithEvents CompanyLabel1 As Label
    Friend WithEvents Company_idLabel1 As Label
    Friend WithEvents Invoice_noLabel1 As Label
    Friend WithEvents DateLabel1 As Label
    Friend WithEvents Customer_nameLabel1 As Label
    Friend WithEvents Customer_idLabel1 As Label
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtFilter As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents given_discount As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents confirmation As DataGridViewTextBoxColumn
    Friend WithEvents confirmation_date As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
