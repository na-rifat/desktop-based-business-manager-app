<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class transactionReport
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
        Dim AccountNumberLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim AccountNOLabel As System.Windows.Forms.Label
        Dim BankNameLabel As System.Windows.Forms.Label
        Dim BranchLabel As System.Windows.Forms.Label
        Dim DrAmountLabel As System.Windows.Forms.Label
        Dim CrAmountLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim BankLabel As System.Windows.Forms.Label
        Dim BranchLabel1 As System.Windows.Forms.Label
        Dim OpeningBalanceLabel As System.Windows.Forms.Label
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblTransactionReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTransactionReportTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblTransactionReportTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblBankAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblBankAccountsTableAdapter()
        Me.TblTransactionTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblTransactionTableAdapter()
        Me.TblTransactionReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.OpeningBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.TblBankAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTransactionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankTextBox = New System.Windows.Forms.TextBox()
        Me.AccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.AccountNOTextBox = New System.Windows.Forms.TextBox()
        Me.CrAmountTextBox = New System.Windows.Forms.TextBox()
        Me.BankNameTextBox = New System.Windows.Forms.TextBox()
        Me.DrAmountTextBox = New System.Windows.Forms.TextBox()
        Me.BranchTextBox = New System.Windows.Forms.TextBox()
        Me.BranchTextBox1 = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.toDt = New System.Windows.Forms.DateTimePicker()
        Me.txtFilter = New System.Windows.Forms.ComboBox()
        Me.fromDt = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        AccountNumberLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        AccountNOLabel = New System.Windows.Forms.Label()
        BankNameLabel = New System.Windows.Forms.Label()
        BranchLabel = New System.Windows.Forms.Label()
        DrAmountLabel = New System.Windows.Forms.Label()
        CrAmountLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        BankLabel = New System.Windows.Forms.Label()
        BranchLabel1 = New System.Windows.Forms.Label()
        OpeningBalanceLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tool.SuspendLayout()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountNumberLabel
        '
        AccountNumberLabel.AutoSize = True
        AccountNumberLabel.Location = New System.Drawing.Point(888, 0)
        AccountNumberLabel.Name = "AccountNumberLabel"
        AccountNumberLabel.Size = New System.Drawing.Size(105, 13)
        AccountNumberLabel.TabIndex = 32
        AccountNumberLabel.Text = "account Number:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(888, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(37, 13)
        DateLabel.TabIndex = 35
        DateLabel.Text = "date:"
        '
        'AccountNOLabel
        '
        AccountNOLabel.AutoSize = True
        AccountNOLabel.Location = New System.Drawing.Point(888, 0)
        AccountNOLabel.Name = "AccountNOLabel"
        AccountNOLabel.Size = New System.Drawing.Size(77, 13)
        AccountNOLabel.TabIndex = 37
        AccountNOLabel.Text = "account NO:"
        '
        'BankNameLabel
        '
        BankNameLabel.AutoSize = True
        BankNameLabel.Location = New System.Drawing.Point(888, 0)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(77, 13)
        BankNameLabel.TabIndex = 39
        BankNameLabel.Text = "bank Name:"
        '
        'BranchLabel
        '
        BranchLabel.AutoSize = True
        BranchLabel.Location = New System.Drawing.Point(888, 0)
        BranchLabel.Name = "BranchLabel"
        BranchLabel.Size = New System.Drawing.Size(51, 13)
        BranchLabel.TabIndex = 41
        BranchLabel.Text = "branch:"
        '
        'DrAmountLabel
        '
        DrAmountLabel.AutoSize = True
        DrAmountLabel.Location = New System.Drawing.Point(888, 0)
        DrAmountLabel.Name = "DrAmountLabel"
        DrAmountLabel.Size = New System.Drawing.Size(72, 13)
        DrAmountLabel.TabIndex = 43
        DrAmountLabel.Text = "dr Amount:"
        '
        'CrAmountLabel
        '
        CrAmountLabel.AutoSize = True
        CrAmountLabel.Location = New System.Drawing.Point(888, 0)
        CrAmountLabel.Name = "CrAmountLabel"
        CrAmountLabel.Size = New System.Drawing.Size(71, 13)
        CrAmountLabel.TabIndex = 45
        CrAmountLabel.Text = "cr Amount:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(888, 0)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(56, 13)
        BalanceLabel.TabIndex = 47
        BalanceLabel.Text = "balance:"
        '
        'BankLabel
        '
        BankLabel.AutoSize = True
        BankLabel.Location = New System.Drawing.Point(888, 0)
        BankLabel.Name = "BankLabel"
        BankLabel.Size = New System.Drawing.Size(40, 13)
        BankLabel.TabIndex = 48
        BankLabel.Text = "bank:"
        '
        'BranchLabel1
        '
        BranchLabel1.AutoSize = True
        BranchLabel1.Location = New System.Drawing.Point(888, 0)
        BranchLabel1.Name = "BranchLabel1"
        BranchLabel1.Size = New System.Drawing.Size(51, 13)
        BranchLabel1.TabIndex = 49
        BranchLabel1.Text = "branch:"
        '
        'OpeningBalanceLabel
        '
        OpeningBalanceLabel.AutoSize = True
        OpeningBalanceLabel.Location = New System.Drawing.Point(888, 0)
        OpeningBalanceLabel.Name = "OpeningBalanceLabel"
        OpeningBalanceLabel.Size = New System.Drawing.Size(106, 13)
        OpeningBalanceLabel.TabIndex = 32
        OpeningBalanceLabel.Text = "opening Balance:"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblTransactionReportBindingSource
        '
        Me.TblTransactionReportBindingSource.DataMember = "tblTransactionReport"
        Me.TblTransactionReportBindingSource.DataSource = Me.DataSet
        '
        'TblTransactionReportTableAdapter
        '
        Me.TblTransactionReportTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sales_targetTableAdapter = Nothing
        Me.TableAdapterManager.tblassetTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceReportTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceTableAdapter = Nothing
        Me.TableAdapterManager.tblBankAccountsTableAdapter = Me.TblBankAccountsTableAdapter
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
        Me.TableAdapterManager.tblTransactionReportTableAdapter = Me.TblTransactionReportTableAdapter
        Me.TableAdapterManager.tblTransactionTableAdapter = Me.TblTransactionTableAdapter
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblBankAccountsTableAdapter
        '
        Me.TblBankAccountsTableAdapter.ClearBeforeFill = True
        '
        'TblTransactionTableAdapter
        '
        Me.TblTransactionTableAdapter.ClearBeforeFill = True
        '
        'TblTransactionReportDataGridView
        '
        Me.TblTransactionReportDataGridView.AutoGenerateColumns = False
        Me.TblTransactionReportDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblTransactionReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTransactionReportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblTransactionReportDataGridView.DataSource = Me.TblTransactionReportBindingSource
        Me.TblTransactionReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblTransactionReportDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblTransactionReportDataGridView.Name = "TblTransactionReportDataGridView"
        Me.TblTransactionReportDataGridView.Size = New System.Drawing.Size(950, 475)
        Me.TblTransactionReportDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "accountNO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "একাউন্ট নাম্বার"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "bankName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ব্যাংক"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "branch"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ব্রাঞ্চ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "drAmount"
        Me.DataGridViewTextBoxColumn6.HeaderText = "উইথ-ড্র"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "crAmount"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ডিপোজিট"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "balance"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ব্যালেন্স"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TblTransactionReportDataGridView)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Location = New System.Drawing.Point(29, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 500)
        Me.Panel1.TabIndex = 7
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel4, Me.ToolStripSeparator2, Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 475)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(950, 25)
        Me.tool.TabIndex = 78
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(104, 22)
        Me.ToolStripLabel4.Text = "Total deposit:"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripLabel3.Text = "Total withdraw: "
        '
        'OpeningBalanceTextBox
        '
        Me.OpeningBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "openingBalance", True))
        Me.OpeningBalanceTextBox.Location = New System.Drawing.Point(888, 0)
        Me.OpeningBalanceTextBox.Name = "OpeningBalanceTextBox"
        Me.OpeningBalanceTextBox.Size = New System.Drawing.Size(100, 21)
        Me.OpeningBalanceTextBox.TabIndex = 33
        '
        'TblBankAccountsBindingSource
        '
        Me.TblBankAccountsBindingSource.DataMember = "tblBankAccounts"
        Me.TblBankAccountsBindingSource.DataSource = Me.DataSet
        '
        'TblTransactionDataGridView
        '
        Me.TblTransactionDataGridView.AutoGenerateColumns = False
        Me.TblTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTransactionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10})
        Me.TblTransactionDataGridView.DataSource = Me.TblTransactionBindingSource
        Me.TblTransactionDataGridView.Location = New System.Drawing.Point(888, 0)
        Me.TblTransactionDataGridView.Name = "TblTransactionDataGridView"
        Me.TblTransactionDataGridView.Size = New System.Drawing.Size(100, 21)
        Me.TblTransactionDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn10.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'TblTransactionBindingSource
        '
        Me.TblTransactionBindingSource.DataMember = "tblTransaction"
        Me.TblTransactionBindingSource.DataSource = Me.DataSet
        '
        'BankTextBox
        '
        Me.BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "bank", True))
        Me.BankTextBox.Location = New System.Drawing.Point(888, 0)
        Me.BankTextBox.Name = "BankTextBox"
        Me.BankTextBox.Size = New System.Drawing.Size(100, 21)
        Me.BankTextBox.TabIndex = 49
        '
        'AccountNumberTextBox
        '
        Me.AccountNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "accountNumber", True))
        Me.AccountNumberTextBox.Location = New System.Drawing.Point(888, 0)
        Me.AccountNumberTextBox.Name = "AccountNumberTextBox"
        Me.AccountNumberTextBox.Size = New System.Drawing.Size(100, 21)
        Me.AccountNumberTextBox.TabIndex = 33
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionReportBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(888, 0)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(100, 21)
        Me.DateTextBox.TabIndex = 36
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionReportBindingSource, "balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(888, 0)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(100, 21)
        Me.BalanceTextBox.TabIndex = 48
        '
        'AccountNOTextBox
        '
        Me.AccountNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionReportBindingSource, "accountNO", True))
        Me.AccountNOTextBox.Location = New System.Drawing.Point(888, 0)
        Me.AccountNOTextBox.Name = "AccountNOTextBox"
        Me.AccountNOTextBox.Size = New System.Drawing.Size(100, 21)
        Me.AccountNOTextBox.TabIndex = 38
        '
        'CrAmountTextBox
        '
        Me.CrAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionReportBindingSource, "crAmount", True))
        Me.CrAmountTextBox.Location = New System.Drawing.Point(888, 0)
        Me.CrAmountTextBox.Name = "CrAmountTextBox"
        Me.CrAmountTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CrAmountTextBox.TabIndex = 46
        '
        'BankNameTextBox
        '
        Me.BankNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionReportBindingSource, "bankName", True))
        Me.BankNameTextBox.Location = New System.Drawing.Point(888, 0)
        Me.BankNameTextBox.Name = "BankNameTextBox"
        Me.BankNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.BankNameTextBox.TabIndex = 40
        '
        'DrAmountTextBox
        '
        Me.DrAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionReportBindingSource, "drAmount", True))
        Me.DrAmountTextBox.Location = New System.Drawing.Point(888, 0)
        Me.DrAmountTextBox.Name = "DrAmountTextBox"
        Me.DrAmountTextBox.Size = New System.Drawing.Size(100, 21)
        Me.DrAmountTextBox.TabIndex = 44
        '
        'BranchTextBox
        '
        Me.BranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionReportBindingSource, "branch", True))
        Me.BranchTextBox.Location = New System.Drawing.Point(888, 0)
        Me.BranchTextBox.Name = "BranchTextBox"
        Me.BranchTextBox.Size = New System.Drawing.Size(100, 21)
        Me.BranchTextBox.TabIndex = 42
        '
        'BranchTextBox1
        '
        Me.BranchTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "branch", True))
        Me.BranchTextBox1.Location = New System.Drawing.Point(888, 0)
        Me.BranchTextBox1.Name = "BranchTextBox1"
        Me.BranchTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.BranchTextBox1.TabIndex = 50
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(814, 61)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(165, 24)
        Me.txtSearch.TabIndex = 26
        '
        'toDt
        '
        Me.toDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.toDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.toDt.Location = New System.Drawing.Point(30, 61)
        Me.toDt.Name = "toDt"
        Me.toDt.Size = New System.Drawing.Size(121, 24)
        Me.toDt.TabIndex = 28
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtFilter.FormattingEnabled = True
        Me.txtFilter.Items.AddRange(New Object() {"একাউন্ট নাম্বার"})
        Me.txtFilter.Location = New System.Drawing.Point(814, 36)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(165, 24)
        Me.txtFilter.TabIndex = 25
        '
        'fromDt
        '
        Me.fromDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.fromDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDt.Location = New System.Drawing.Point(30, 36)
        Me.fromDt.Name = "fromDt"
        Me.fromDt.Size = New System.Drawing.Size(121, 24)
        Me.fromDt.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(213, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 32
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(269, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 33
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(325, 35)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 40
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(155, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 24)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "পর্যন্ত"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(155, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 24)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "থেকে-"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(728, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 25)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "সার্চ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(728, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 25)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "সার্চের ধরন"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.Text = "ব্যাংক লেনদেনের রিপোর্ট"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'transactionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.toDt)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.fromDt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OpeningBalanceTextBox)
        Me.Controls.Add(BankLabel)
        Me.Controls.Add(Me.TblTransactionDataGridView)
        Me.Controls.Add(Me.BankTextBox)
        Me.Controls.Add(Me.AccountNumberTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(AccountNumberLabel)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(AccountNOLabel)
        Me.Controls.Add(BalanceLabel)
        Me.Controls.Add(Me.AccountNOTextBox)
        Me.Controls.Add(Me.CrAmountTextBox)
        Me.Controls.Add(BankNameLabel)
        Me.Controls.Add(OpeningBalanceLabel)
        Me.Controls.Add(CrAmountLabel)
        Me.Controls.Add(BranchLabel1)
        Me.Controls.Add(Me.BankNameTextBox)
        Me.Controls.Add(Me.BranchTextBox1)
        Me.Controls.Add(Me.DrAmountTextBox)
        Me.Controls.Add(Me.BranchTextBox)
        Me.Controls.Add(BranchLabel)
        Me.Controls.Add(DrAmountLabel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transactionReport"
        Me.Text = "transactionReport"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblTransactionReportBindingSource As BindingSource
    Friend WithEvents TblTransactionReportTableAdapter As dataSetTableAdapters.tblTransactionReportTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTransactionReportDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents toDt As DateTimePicker
    Friend WithEvents txtFilter As ComboBox
    Friend WithEvents fromDt As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents TblTransactionBindingSource As BindingSource
    Friend WithEvents TblTransactionTableAdapter As dataSetTableAdapters.tblTransactionTableAdapter
    Friend WithEvents TblTransactionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents TblBankAccountsBindingSource As BindingSource
    Friend WithEvents TblBankAccountsTableAdapter As dataSetTableAdapters.tblBankAccountsTableAdapter
    Friend WithEvents AccountNumberTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents AccountNOTextBox As TextBox
    Friend WithEvents BankNameTextBox As TextBox
    Friend WithEvents BranchTextBox As TextBox
    Friend WithEvents DrAmountTextBox As TextBox
    Friend WithEvents CrAmountTextBox As TextBox
    Friend WithEvents BalanceTextBox As TextBox
    Friend WithEvents BankTextBox As TextBox
    Friend WithEvents BranchTextBox1 As TextBox
    Friend WithEvents OpeningBalanceTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
End Class
