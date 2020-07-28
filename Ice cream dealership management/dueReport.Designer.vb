<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dueReport
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim ShopNameLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel1 As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim SaleInvoiceLabel As System.Windows.Forms.Label
        Dim DueLabel As System.Windows.Forms.Label
        Dim DateLabel1 As System.Windows.Forms.Label
        Dim ShopOrCompanyNameLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel2 As System.Windows.Forms.Label
        Dim CustomerIDLabel1 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblDuesReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDuesReportTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblDuesReportTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblCusomterAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblCusomterAccountsTableAdapter()
        Me.TblCustomersTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblCustomersTableAdapter()
        Me.TblInvoiceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblInvoiceTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblDuesReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.CustomerIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox2 = New System.Windows.Forms.TextBox()
        Me.ShopNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblCusomterAccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCusomterAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.ShopOrCompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox1 = New System.Windows.Forms.TextBox()
        Me.SaleInvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.TblInvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtFilter = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toDt = New System.Windows.Forms.DateTimePicker()
        Me.fromDt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        ShopNameLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        CustomerNameLabel1 = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        SaleInvoiceLabel = New System.Windows.Forms.Label()
        DueLabel = New System.Windows.Forms.Label()
        DateLabel1 = New System.Windows.Forms.Label()
        ShopOrCompanyNameLabel = New System.Windows.Forms.Label()
        CustomerNameLabel2 = New System.Windows.Forms.Label()
        CustomerIDLabel1 = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDuesReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblDuesReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCusomterAccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCusomterAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(772, 9)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 33
        IdLabel.Text = "Id:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(772, 9)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(37, 13)
        DateLabel.TabIndex = 35
        DateLabel.Text = "date:"
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(772, 9)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(102, 13)
        CustomerNameLabel.TabIndex = 37
        CustomerNameLabel.Text = "customer Name:"
        '
        'ShopNameLabel
        '
        ShopNameLabel.AutoSize = True
        ShopNameLabel.Location = New System.Drawing.Point(772, 9)
        ShopNameLabel.Name = "ShopNameLabel"
        ShopNameLabel.Size = New System.Drawing.Size(76, 13)
        ShopNameLabel.TabIndex = 39
        ShopNameLabel.Text = "shop Name:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(772, 9)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(55, 13)
        AmountLabel.TabIndex = 41
        AmountLabel.Text = "amount:"
        '
        'CustomerNameLabel1
        '
        CustomerNameLabel1.AutoSize = True
        CustomerNameLabel1.Location = New System.Drawing.Point(772, 9)
        CustomerNameLabel1.Name = "CustomerNameLabel1"
        CustomerNameLabel1.Size = New System.Drawing.Size(102, 13)
        CustomerNameLabel1.TabIndex = 44
        CustomerNameLabel1.Text = "customer Name:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(772, 9)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(83, 13)
        CustomerIDLabel.TabIndex = 46
        CustomerIDLabel.Text = "customer ID:"
        '
        'SaleInvoiceLabel
        '
        SaleInvoiceLabel.AutoSize = True
        SaleInvoiceLabel.Location = New System.Drawing.Point(772, 9)
        SaleInvoiceLabel.Name = "SaleInvoiceLabel"
        SaleInvoiceLabel.Size = New System.Drawing.Size(81, 13)
        SaleInvoiceLabel.TabIndex = 48
        SaleInvoiceLabel.Text = "sale Invoice:"
        '
        'DueLabel
        '
        DueLabel.AutoSize = True
        DueLabel.Location = New System.Drawing.Point(772, 9)
        DueLabel.Name = "DueLabel"
        DueLabel.Size = New System.Drawing.Size(33, 13)
        DueLabel.TabIndex = 54
        DueLabel.Text = "due:"
        '
        'DateLabel1
        '
        DateLabel1.AutoSize = True
        DateLabel1.Location = New System.Drawing.Point(772, 9)
        DateLabel1.Name = "DateLabel1"
        DateLabel1.Size = New System.Drawing.Size(37, 13)
        DateLabel1.TabIndex = 56
        DateLabel1.Text = "date:"
        '
        'ShopOrCompanyNameLabel
        '
        ShopOrCompanyNameLabel.AutoSize = True
        ShopOrCompanyNameLabel.Location = New System.Drawing.Point(772, 9)
        ShopOrCompanyNameLabel.Name = "ShopOrCompanyNameLabel"
        ShopOrCompanyNameLabel.Size = New System.Drawing.Size(153, 13)
        ShopOrCompanyNameLabel.TabIndex = 57
        ShopOrCompanyNameLabel.Text = "shop Or Company Name:"
        '
        'CustomerNameLabel2
        '
        CustomerNameLabel2.AutoSize = True
        CustomerNameLabel2.Location = New System.Drawing.Point(772, 9)
        CustomerNameLabel2.Name = "CustomerNameLabel2"
        CustomerNameLabel2.Size = New System.Drawing.Size(102, 13)
        CustomerNameLabel2.TabIndex = 58
        CustomerNameLabel2.Text = "customer Name:"
        '
        'CustomerIDLabel1
        '
        CustomerIDLabel1.AutoSize = True
        CustomerIDLabel1.Location = New System.Drawing.Point(772, 9)
        CustomerIDLabel1.Name = "CustomerIDLabel1"
        CustomerIDLabel1.Size = New System.Drawing.Size(83, 13)
        CustomerIDLabel1.TabIndex = 59
        CustomerIDLabel1.Text = "customer ID:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "কাস্টমারবৃন্দের বাকির রিপোর্ট"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDuesReportBindingSource
        '
        Me.TblDuesReportBindingSource.DataMember = "tblDuesReport"
        Me.TblDuesReportBindingSource.DataSource = Me.DataSet
        '
        'TblDuesReportTableAdapter
        '
        Me.TblDuesReportTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblCusomterAccountsTableAdapter = Me.TblCusomterAccountsTableAdapter
        Me.TableAdapterManager.tblCustomersTableAdapter = Me.TblCustomersTableAdapter
        Me.TableAdapterManager.tblDamageFridgeTableAdapter = Nothing
        Me.TableAdapterManager.tblDamageProductsTableAdapter = Nothing
        Me.TableAdapterManager.tblDeliveryTableAdapter = Nothing
        Me.TableAdapterManager.tbldiscountTableAdapter = Nothing
        Me.TableAdapterManager.tblDocumentsCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblDocumentsTableAdapter = Nothing
        Me.TableAdapterManager.tblDuesReportTableAdapter = Me.TblDuesReportTableAdapter
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
        Me.TableAdapterManager.tblInvoiceTableAdapter = Me.TblInvoiceTableAdapter
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
        'TblCusomterAccountsTableAdapter
        '
        Me.TblCusomterAccountsTableAdapter.ClearBeforeFill = True
        '
        'TblCustomersTableAdapter
        '
        Me.TblCustomersTableAdapter.ClearBeforeFill = True
        '
        'TblInvoiceTableAdapter
        '
        Me.TblInvoiceTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TblDuesReportDataGridView)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Location = New System.Drawing.Point(11, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 514)
        Me.Panel1.TabIndex = 7
        '
        'TblDuesReportDataGridView
        '
        Me.TblDuesReportDataGridView.AutoGenerateColumns = False
        Me.TblDuesReportDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblDuesReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblDuesReportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblDuesReportDataGridView.DataSource = Me.TblDuesReportBindingSource
        Me.TblDuesReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblDuesReportDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblDuesReportDataGridView.Name = "TblDuesReportDataGridView"
        Me.TblDuesReportDataGridView.Size = New System.Drawing.Size(978, 489)
        Me.TblDuesReportDataGridView.TabIndex = 79
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "customerName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "স্বত্তাধিকারী"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "shopName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "দোকানের নাম"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "বাকির পরিমাণ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 489)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(978, 25)
        Me.tool.TabIndex = 78
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripLabel3.Text = "Total due: "
        '
        'CustomerIDTextBox1
        '
        Me.CustomerIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "customerID", True))
        Me.CustomerIDTextBox1.Location = New System.Drawing.Point(772, 9)
        Me.CustomerIDTextBox1.Name = "CustomerIDTextBox1"
        Me.CustomerIDTextBox1.Size = New System.Drawing.Size(23, 21)
        Me.CustomerIDTextBox1.TabIndex = 60
        '
        'TblCustomersBindingSource
        '
        Me.TblCustomersBindingSource.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource.DataSource = Me.DataSet
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesReportBindingSource, "amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(772, 9)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(23, 21)
        Me.AmountTextBox.TabIndex = 42
        '
        'CustomerNameTextBox2
        '
        Me.CustomerNameTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "customerName", True))
        Me.CustomerNameTextBox2.Location = New System.Drawing.Point(772, 9)
        Me.CustomerNameTextBox2.Name = "CustomerNameTextBox2"
        Me.CustomerNameTextBox2.Size = New System.Drawing.Size(23, 21)
        Me.CustomerNameTextBox2.TabIndex = 59
        '
        'ShopNameTextBox
        '
        Me.ShopNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesReportBindingSource, "shopName", True))
        Me.ShopNameTextBox.Location = New System.Drawing.Point(772, 9)
        Me.ShopNameTextBox.Name = "ShopNameTextBox"
        Me.ShopNameTextBox.Size = New System.Drawing.Size(23, 21)
        Me.ShopNameTextBox.TabIndex = 40
        '
        'TblCusomterAccountsDataGridView
        '
        Me.TblCusomterAccountsDataGridView.AutoGenerateColumns = False
        Me.TblCusomterAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCusomterAccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11})
        Me.TblCusomterAccountsDataGridView.DataSource = Me.TblCusomterAccountsBindingSource
        Me.TblCusomterAccountsDataGridView.Location = New System.Drawing.Point(772, 9)
        Me.TblCusomterAccountsDataGridView.Name = "TblCusomterAccountsDataGridView"
        Me.TblCusomterAccountsDataGridView.Size = New System.Drawing.Size(23, 10)
        Me.TblCusomterAccountsDataGridView.TabIndex = 58
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn11.HeaderText = "due"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'TblCusomterAccountsBindingSource
        '
        Me.TblCusomterAccountsBindingSource.DataMember = "tblCusomterAccounts"
        Me.TblCusomterAccountsBindingSource.DataSource = Me.DataSet
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesReportBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(772, 9)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(23, 21)
        Me.CustomerNameTextBox.TabIndex = 38
        '
        'ShopOrCompanyNameTextBox
        '
        Me.ShopOrCompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "shopOrCompanyName", True))
        Me.ShopOrCompanyNameTextBox.Location = New System.Drawing.Point(772, 9)
        Me.ShopOrCompanyNameTextBox.Name = "ShopOrCompanyNameTextBox"
        Me.ShopOrCompanyNameTextBox.Size = New System.Drawing.Size(23, 21)
        Me.ShopOrCompanyNameTextBox.TabIndex = 58
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesReportBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(772, 9)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(23, 21)
        Me.DateTextBox.TabIndex = 36
        '
        'CustomerNameTextBox1
        '
        Me.CustomerNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "customerName", True))
        Me.CustomerNameTextBox1.Location = New System.Drawing.Point(772, 9)
        Me.CustomerNameTextBox1.Name = "CustomerNameTextBox1"
        Me.CustomerNameTextBox1.Size = New System.Drawing.Size(23, 21)
        Me.CustomerNameTextBox1.TabIndex = 45
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesReportBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(772, 9)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(23, 21)
        Me.IdTextBox.TabIndex = 34
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "customerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(772, 9)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(23, 21)
        Me.CustomerIDTextBox.TabIndex = 47
        '
        'DateTextBox1
        '
        Me.DateTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "date", True))
        Me.DateTextBox1.Location = New System.Drawing.Point(772, 9)
        Me.DateTextBox1.Name = "DateTextBox1"
        Me.DateTextBox1.Size = New System.Drawing.Size(23, 21)
        Me.DateTextBox1.TabIndex = 57
        '
        'SaleInvoiceTextBox
        '
        Me.SaleInvoiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "saleInvoice", True))
        Me.SaleInvoiceTextBox.Location = New System.Drawing.Point(772, 9)
        Me.SaleInvoiceTextBox.Name = "SaleInvoiceTextBox"
        Me.SaleInvoiceTextBox.Size = New System.Drawing.Size(23, 21)
        Me.SaleInvoiceTextBox.TabIndex = 49
        '
        'DueTextBox
        '
        Me.DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "due", True))
        Me.DueTextBox.Location = New System.Drawing.Point(772, 9)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.Size = New System.Drawing.Size(23, 21)
        Me.DueTextBox.TabIndex = 55
        '
        'TblInvoiceDataGridView
        '
        Me.TblInvoiceDataGridView.AutoGenerateColumns = False
        Me.TblInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.customerID})
        Me.TblInvoiceDataGridView.DataSource = Me.TblInvoiceBindingSource
        Me.TblInvoiceDataGridView.Location = New System.Drawing.Point(734, 4)
        Me.TblInvoiceDataGridView.Name = "TblInvoiceDataGridView"
        Me.TblInvoiceDataGridView.Size = New System.Drawing.Size(50, 23)
        Me.TblInvoiceDataGridView.TabIndex = 60
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn15.HeaderText = "due"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'customerID
        '
        Me.customerID.DataPropertyName = "customerID"
        Me.customerID.HeaderText = "customerID"
        Me.customerID.Name = "customerID"
        '
        'TblInvoiceBindingSource
        '
        Me.TblInvoiceBindingSource.DataMember = "tblInvoice"
        Me.TblInvoiceBindingSource.DataSource = Me.DataSet
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(673, 67)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(165, 24)
        Me.txtSearch.TabIndex = 26
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtFilter.FormattingEnabled = True
        Me.txtFilter.Items.AddRange(New Object() {"Customer name", "Shop name"})
        Me.txtFilter.Location = New System.Drawing.Point(673, 42)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(165, 24)
        Me.txtFilter.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(467, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 61
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(225, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 62
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(412, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "পর্যন্ত"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'toDt
        '
        Me.toDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.toDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.toDt.Location = New System.Drawing.Point(281, 67)
        Me.toDt.Name = "toDt"
        Me.toDt.Size = New System.Drawing.Size(127, 24)
        Me.toDt.TabIndex = 104
        '
        'fromDt
        '
        Me.fromDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.fromDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDt.Location = New System.Drawing.Point(281, 42)
        Me.fromDt.Name = "fromDt"
        Me.fromDt.Size = New System.Drawing.Size(127, 24)
        Me.fromDt.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(412, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "থেকে-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(523, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 25)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "সার্চঃ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(523, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 25)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "সার্চের ধরনঃ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dueReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.toDt)
        Me.Controls.Add(Me.fromDt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CustomerIDLabel1)
        Me.Controls.Add(Me.CustomerIDTextBox1)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(CustomerNameLabel2)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.CustomerNameTextBox2)
        Me.Controls.Add(Me.ShopNameTextBox)
        Me.Controls.Add(Me.TblCusomterAccountsDataGridView)
        Me.Controls.Add(ShopNameLabel)
        Me.Controls.Add(ShopOrCompanyNameLabel)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.ShopOrCompanyNameTextBox)
        Me.Controls.Add(Me.DueTextBox)
        Me.Controls.Add(CustomerNameLabel)
        Me.Controls.Add(DueLabel)
        Me.Controls.Add(CustomerNameLabel1)
        Me.Controls.Add(DateLabel1)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.SaleInvoiceTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox1)
        Me.Controls.Add(Me.DateTextBox1)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(SaleInvoiceLabel)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.TblInvoiceDataGridView)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dueReport"
        Me.Text = "dueReport"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDuesReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblDuesReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCusomterAccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCusomterAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblDuesReportBindingSource As BindingSource
    Friend WithEvents TblDuesReportTableAdapter As dataSetTableAdapters.tblDuesReportTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtFilter As ComboBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents ShopNameTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents TblCusomterAccountsBindingSource As BindingSource
    Friend WithEvents TblCusomterAccountsTableAdapter As dataSetTableAdapters.tblCusomterAccountsTableAdapter
    Friend WithEvents CustomerNameTextBox1 As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents SaleInvoiceTextBox As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents DateTextBox1 As TextBox
    Friend WithEvents TblCustomersBindingSource As BindingSource
    Friend WithEvents TblCustomersTableAdapter As dataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents ShopOrCompanyNameTextBox As TextBox
    Friend WithEvents TblCusomterAccountsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameTextBox2 As TextBox
    Friend WithEvents CustomerIDTextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TblInvoiceBindingSource As BindingSource
    Friend WithEvents TblInvoiceTableAdapter As dataSetTableAdapters.tblInvoiceTableAdapter
    Friend WithEvents TblInvoiceDataGridView As DataGridView
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TblDuesReportDataGridView As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents customerID As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents toDt As DateTimePicker
    Friend WithEvents fromDt As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
