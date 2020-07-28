<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class profitCalculator
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
        Dim IncomeLabel As System.Windows.Forms.Label
        Dim ExpenseLabel As System.Windows.Forms.Label
        Dim ProfitLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim DrdueLabel As System.Windows.Forms.Label
        Dim CrdueLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_sale = New System.Windows.Forms.Label()
        Me.lbl_purchase = New System.Windows.Forms.Label()
        Me.lbl_damageproduct = New System.Windows.Forms.Label()
        Me.lbl_bank_deposit = New System.Windows.Forms.Label()
        Me.lbl_income = New System.Windows.Forms.Label()
        Me.lbl_expense_without_purchase = New System.Windows.Forms.Label()
        Me.lbl_bank_withdraw = New System.Windows.Forms.Label()
        Me.lbl_expense = New System.Windows.Forms.Label()
        Me.lbl_cash_balance = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TblProfitDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bank_withdraw = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bank_deposit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cash_withdraw = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.damage_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_sale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_purchase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.available_products_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.available_product_market_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_given_discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.daily_debit_due = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.daily_credit_due = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.old_cash_balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.daily_revenue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.earned_commission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delivery_expense = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblProfitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.toDt = New System.Windows.Forms.DateTimePicker()
        Me.fromDt = New System.Windows.Forms.DateTimePicker()
        Me.TblExpensesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDeliveryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblDeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblFridgesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblFridgesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblassetDataGridView = New System.Windows.Forms.DataGridView()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssetConditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblassetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblwithdrawDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblwithdrawBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblBankAccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBankAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSupplierAccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSupplierAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRentSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblRentSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblExpenseReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblExpenseReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeeAccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblEmployeeAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTransactionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRentCDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblRentCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblIncomeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bankamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblIncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCusomterAccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.paid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleInvoiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCusomterAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseTextBox = New System.Windows.Forms.TextBox()
        Me.ProfitTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.BankBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.DrdueTextBox = New System.Windows.Forms.TextBox()
        Me.CrdueTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AssetTextBox = New System.Windows.Forms.TextBox()
        Me.TblVehicleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BcDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleConditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriverNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblVehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblsellcommissionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblsellcommissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbldiscountDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbldiscountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bank_withdrawTextBox = New System.Windows.Forms.TextBox()
        Me.Bank_depositTextBox = New System.Windows.Forms.TextBox()
        Me.Cash_withdrawTextBox = New System.Windows.Forms.TextBox()
        Me.Damage_productTextBox = New System.Windows.Forms.TextBox()
        Me.Total_saleTextBox = New System.Windows.Forms.TextBox()
        Me.Total_purchaseTextBox = New System.Windows.Forms.TextBox()
        Me.Available_products_valueTextBox = New System.Windows.Forms.TextBox()
        Me.Available_product_market_valueTextBox = New System.Windows.Forms.TextBox()
        Me.Total_given_discountTextBox = New System.Windows.Forms.TextBox()
        Me.Daily_debit_dueTextBox = New System.Windows.Forms.TextBox()
        Me.Daily_credit_dueTextBox = New System.Windows.Forms.TextBox()
        Me.Old_cash_balanceTextBox = New System.Windows.Forms.TextBox()
        Me.TblProfitTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProfitTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblassetTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblassetTableAdapter()
        Me.TblBankAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblBankAccountsTableAdapter()
        Me.TblCusomterAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblCusomterAccountsTableAdapter()
        Me.TblDeliveryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblDeliveryTableAdapter()
        Me.TbldiscountTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tbldiscountTableAdapter()
        Me.TblEmployeeAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblEmployeeAccountsTableAdapter()
        Me.TblExpenseReportTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpenseReportTableAdapter()
        Me.TblExpensesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpensesTableAdapter()
        Me.TblFridgesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblFridgesTableAdapter()
        Me.TblIncomeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblIncomeTableAdapter()
        Me.TblRentCTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblRentCTableAdapter()
        Me.TblRentSTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblRentSTableAdapter()
        Me.TblsellcommissionTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblsellcommissionTableAdapter()
        Me.TblTransactionTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblTransactionTableAdapter()
        Me.TblVehicleTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblVehicleTableAdapter()
        Me.TblwithdrawTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblwithdrawTableAdapter()
        Me.TblSupplierAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblSupplierAccountsTableAdapter()
        Me.TblSignboardTableAdapter1 = New Ice_cream_dealership_management.dataSetTableAdapters.tblSignboardTableAdapter()
        Me.Daily_revenueTextBox = New System.Windows.Forms.TextBox()
        Me.Earned_commissionTextBox = New System.Windows.Forms.TextBox()
        Me.Delivery_expenseTextBox = New System.Windows.Forms.TextBox()
        Me.TblInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInvoiceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblInvoiceTableAdapter()
        Me.TblInvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.padi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grandTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblPurchaseInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPurchaseInvoiceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblPurchaseInvoiceTableAdapter()
        Me.TblPurchaseInvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyInvoiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentmethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentremarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSalesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblSalesTableAdapter()
        Me.TblSalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        IncomeLabel = New System.Windows.Forms.Label()
        ExpenseLabel = New System.Windows.Forms.Label()
        ProfitLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        DrdueLabel = New System.Windows.Forms.Label()
        CrdueLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.TblProfitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProfitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpensesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDeliveryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFridgesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblassetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblassetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblwithdrawDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblwithdrawBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBankAccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSupplierAccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSupplierAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRentSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRentSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpenseReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpenseReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeAccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRentCDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRentCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncomeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCusomterAccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCusomterAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TblVehicleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsellcommissionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsellcommissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldiscountDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldiscountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPurchaseInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPurchaseInvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(12, 9)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 63
        IdLabel.Text = "Id:"
        IdLabel.Visible = False
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(12, 9)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(37, 13)
        DateLabel.TabIndex = 65
        DateLabel.Text = "date:"
        DateLabel.Visible = False
        '
        'IncomeLabel
        '
        IncomeLabel.AutoSize = True
        IncomeLabel.Location = New System.Drawing.Point(12, 9)
        IncomeLabel.Name = "IncomeLabel"
        IncomeLabel.Size = New System.Drawing.Size(53, 13)
        IncomeLabel.TabIndex = 67
        IncomeLabel.Text = "income:"
        IncomeLabel.Visible = False
        '
        'ExpenseLabel
        '
        ExpenseLabel.AutoSize = True
        ExpenseLabel.Location = New System.Drawing.Point(12, 9)
        ExpenseLabel.Name = "ExpenseLabel"
        ExpenseLabel.Size = New System.Drawing.Size(60, 13)
        ExpenseLabel.TabIndex = 69
        ExpenseLabel.Text = "expense:"
        ExpenseLabel.Visible = False
        '
        'ProfitLabel
        '
        ProfitLabel.AutoSize = True
        ProfitLabel.Location = New System.Drawing.Point(12, 9)
        ProfitLabel.Name = "ProfitLabel"
        ProfitLabel.Size = New System.Drawing.Size(42, 13)
        ProfitLabel.TabIndex = 71
        ProfitLabel.Text = "profit:"
        ProfitLabel.Visible = False
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(12, 9)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(56, 13)
        BalanceLabel.TabIndex = 73
        BalanceLabel.Text = "balance:"
        BalanceLabel.Visible = False
        '
        'DrdueLabel
        '
        DrdueLabel.AutoSize = True
        DrdueLabel.Location = New System.Drawing.Point(12, 9)
        DrdueLabel.Name = "DrdueLabel"
        DrdueLabel.Size = New System.Drawing.Size(45, 13)
        DrdueLabel.TabIndex = 77
        DrdueLabel.Text = "drdue:"
        DrdueLabel.Visible = False
        '
        'CrdueLabel
        '
        CrdueLabel.AutoSize = True
        CrdueLabel.Location = New System.Drawing.Point(12, 9)
        CrdueLabel.Name = "CrdueLabel"
        CrdueLabel.Size = New System.Drawing.Size(44, 13)
        CrdueLabel.TabIndex = 79
        CrdueLabel.Text = "crdue:"
        CrdueLabel.Visible = False
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
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ব্যালেন্স স্ট্যাটমেন্ট"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TblProfitDataGridView)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.toDt)
        Me.Panel1.Controls.Add(Me.fromDt)
        Me.Panel1.Location = New System.Drawing.Point(6, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 569)
        Me.Panel1.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(497, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "পর্যন্ত"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(332, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 24)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "থেকে-"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button5.Location = New System.Drawing.Point(756, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 50)
        Me.Button5.TabIndex = 86
        Me.Button5.Text = "R"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbl_sale)
        Me.Panel3.Controls.Add(Me.lbl_purchase)
        Me.Panel3.Controls.Add(Me.lbl_damageproduct)
        Me.Panel3.Controls.Add(Me.lbl_bank_deposit)
        Me.Panel3.Controls.Add(Me.lbl_income)
        Me.Panel3.Controls.Add(Me.lbl_expense_without_purchase)
        Me.Panel3.Controls.Add(Me.lbl_bank_withdraw)
        Me.Panel3.Controls.Add(Me.lbl_expense)
        Me.Panel3.Controls.Add(Me.lbl_cash_balance)
        Me.Panel3.Location = New System.Drawing.Point(60, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(862, 201)
        Me.Panel3.TabIndex = 85
        '
        'lbl_sale
        '
        Me.lbl_sale.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_sale.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lbl_sale.ForeColor = System.Drawing.Color.Snow
        Me.lbl_sale.Location = New System.Drawing.Point(682, 12)
        Me.lbl_sale.Name = "lbl_sale"
        Me.lbl_sale.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_sale.Size = New System.Drawing.Size(159, 85)
        Me.lbl_sale.TabIndex = 102
        Me.lbl_sale.Text = "Sale"
        Me.lbl_sale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_purchase
        '
        Me.lbl_purchase.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_purchase.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lbl_purchase.ForeColor = System.Drawing.Color.Snow
        Me.lbl_purchase.Location = New System.Drawing.Point(682, 104)
        Me.lbl_purchase.Name = "lbl_purchase"
        Me.lbl_purchase.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_purchase.Size = New System.Drawing.Size(159, 85)
        Me.lbl_purchase.TabIndex = 101
        Me.lbl_purchase.Text = "Purchase"
        Me.lbl_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_damageproduct
        '
        Me.lbl_damageproduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_damageproduct.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lbl_damageproduct.ForeColor = System.Drawing.Color.Snow
        Me.lbl_damageproduct.Location = New System.Drawing.Point(517, 12)
        Me.lbl_damageproduct.Name = "lbl_damageproduct"
        Me.lbl_damageproduct.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_damageproduct.Size = New System.Drawing.Size(159, 85)
        Me.lbl_damageproduct.TabIndex = 100
        Me.lbl_damageproduct.Text = "Damage product"
        Me.lbl_damageproduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_bank_deposit
        '
        Me.lbl_bank_deposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_bank_deposit.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lbl_bank_deposit.ForeColor = System.Drawing.Color.Snow
        Me.lbl_bank_deposit.Location = New System.Drawing.Point(352, 12)
        Me.lbl_bank_deposit.Name = "lbl_bank_deposit"
        Me.lbl_bank_deposit.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_bank_deposit.Size = New System.Drawing.Size(159, 85)
        Me.lbl_bank_deposit.TabIndex = 99
        Me.lbl_bank_deposit.Text = "Bank deposit"
        Me.lbl_bank_deposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_income
        '
        Me.lbl_income.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_income.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lbl_income.ForeColor = System.Drawing.Color.Snow
        Me.lbl_income.Location = New System.Drawing.Point(22, 12)
        Me.lbl_income.Name = "lbl_income"
        Me.lbl_income.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_income.Size = New System.Drawing.Size(159, 85)
        Me.lbl_income.TabIndex = 97
        Me.lbl_income.Text = "Income"
        Me.lbl_income.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_expense_without_purchase
        '
        Me.lbl_expense_without_purchase.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_expense_without_purchase.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lbl_expense_without_purchase.ForeColor = System.Drawing.Color.Snow
        Me.lbl_expense_without_purchase.Location = New System.Drawing.Point(517, 104)
        Me.lbl_expense_without_purchase.Name = "lbl_expense_without_purchase"
        Me.lbl_expense_without_purchase.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_expense_without_purchase.Size = New System.Drawing.Size(159, 85)
        Me.lbl_expense_without_purchase.TabIndex = 96
        Me.lbl_expense_without_purchase.Text = "Expense without purchase"
        Me.lbl_expense_without_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_bank_withdraw
        '
        Me.lbl_bank_withdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_bank_withdraw.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lbl_bank_withdraw.ForeColor = System.Drawing.Color.Snow
        Me.lbl_bank_withdraw.Location = New System.Drawing.Point(352, 104)
        Me.lbl_bank_withdraw.Name = "lbl_bank_withdraw"
        Me.lbl_bank_withdraw.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_bank_withdraw.Size = New System.Drawing.Size(159, 85)
        Me.lbl_bank_withdraw.TabIndex = 94
        Me.lbl_bank_withdraw.Text = "Bank withdraw"
        Me.lbl_bank_withdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_expense
        '
        Me.lbl_expense.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_expense.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lbl_expense.ForeColor = System.Drawing.Color.Snow
        Me.lbl_expense.Location = New System.Drawing.Point(22, 104)
        Me.lbl_expense.Name = "lbl_expense"
        Me.lbl_expense.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_expense.Size = New System.Drawing.Size(159, 85)
        Me.lbl_expense.TabIndex = 90
        Me.lbl_expense.Text = "Expense"
        Me.lbl_expense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_cash_balance
        '
        Me.lbl_cash_balance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_cash_balance.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.lbl_cash_balance.ForeColor = System.Drawing.Color.Snow
        Me.lbl_cash_balance.Location = New System.Drawing.Point(187, 104)
        Me.lbl_cash_balance.Name = "lbl_cash_balance"
        Me.lbl_cash_balance.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_cash_balance.Size = New System.Drawing.Size(159, 85)
        Me.lbl_cash_balance.TabIndex = 92
        Me.lbl_cash_balance.Text = "Cash balance"
        Me.lbl_cash_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(61, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 25)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "মোট হিসাব"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button4.Location = New System.Drawing.Point(705, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 50)
        Me.Button4.TabIndex = 82
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(655, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 81
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TblProfitDataGridView
        '
        Me.TblProfitDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TblProfitDataGridView.AutoGenerateColumns = False
        Me.TblProfitDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblProfitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProfitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.asset, Me.balance, Me.bank_withdraw, Me.bank_deposit, Me.cash_withdraw, Me.damage_product, Me.total_sale, Me.total_purchase, Me.available_products_value, Me.available_product_market_value, Me.total_given_discount, Me.daily_debit_due, Me.daily_credit_due, Me.old_cash_balance, Me.daily_revenue, Me.earned_commission, Me.delivery_expense})
        Me.TblProfitDataGridView.DataSource = Me.TblProfitBindingSource
        Me.TblProfitDataGridView.Location = New System.Drawing.Point(5, 266)
        Me.TblProfitDataGridView.Name = "TblProfitDataGridView"
        Me.TblProfitDataGridView.Size = New System.Drawing.Size(974, 297)
        Me.TblProfitDataGridView.TabIndex = 63
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "income"
        Me.DataGridViewTextBoxColumn3.HeaderText = "আয়"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "expense"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ব্যয়"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "profit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ক্যাশ"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "bankBalance"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ব্যাংক ব্যালেন্স"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "drdue"
        Me.DataGridViewTextBoxColumn8.HeaderText = "দেনাদার"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "crdue"
        Me.DataGridViewTextBoxColumn9.HeaderText = "পাওনাদার"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'asset
        '
        Me.asset.DataPropertyName = "asset"
        Me.asset.HeaderText = "সম্পদ"
        Me.asset.MinimumWidth = 100
        Me.asset.Name = "asset"
        '
        'balance
        '
        Me.balance.DataPropertyName = "balance"
        Me.balance.HeaderText = "Cash balance"
        Me.balance.MinimumWidth = 100
        Me.balance.Name = "balance"
        Me.balance.Visible = False
        '
        'bank_withdraw
        '
        Me.bank_withdraw.DataPropertyName = "bank_withdraw"
        Me.bank_withdraw.HeaderText = "bank_withdraw"
        Me.bank_withdraw.MinimumWidth = 100
        Me.bank_withdraw.Name = "bank_withdraw"
        Me.bank_withdraw.Visible = False
        '
        'bank_deposit
        '
        Me.bank_deposit.DataPropertyName = "bank_deposit"
        Me.bank_deposit.HeaderText = "bank_deposit"
        Me.bank_deposit.MinimumWidth = 100
        Me.bank_deposit.Name = "bank_deposit"
        Me.bank_deposit.Visible = False
        '
        'cash_withdraw
        '
        Me.cash_withdraw.DataPropertyName = "cash_withdraw"
        Me.cash_withdraw.HeaderText = "cash_withdraw"
        Me.cash_withdraw.MinimumWidth = 100
        Me.cash_withdraw.Name = "cash_withdraw"
        Me.cash_withdraw.Visible = False
        '
        'damage_product
        '
        Me.damage_product.DataPropertyName = "damage_product"
        Me.damage_product.HeaderText = "damage_product"
        Me.damage_product.MinimumWidth = 100
        Me.damage_product.Name = "damage_product"
        Me.damage_product.Visible = False
        '
        'total_sale
        '
        Me.total_sale.DataPropertyName = "total_sale"
        Me.total_sale.HeaderText = "মোট বিক্রয়"
        Me.total_sale.MinimumWidth = 100
        Me.total_sale.Name = "total_sale"
        '
        'total_purchase
        '
        Me.total_purchase.DataPropertyName = "total_purchase"
        Me.total_purchase.HeaderText = "মোট ক্রয়"
        Me.total_purchase.MinimumWidth = 100
        Me.total_purchase.Name = "total_purchase"
        '
        'available_products_value
        '
        Me.available_products_value.DataPropertyName = "available_products_value"
        Me.available_products_value.HeaderText = "বর্তমান স্টক পণ্যের মূল্য"
        Me.available_products_value.MinimumWidth = 100
        Me.available_products_value.Name = "available_products_value"
        Me.available_products_value.Visible = False
        '
        'available_product_market_value
        '
        Me.available_product_market_value.DataPropertyName = "available_product_market_value"
        Me.available_product_market_value.HeaderText = "বর্তমান স্টক পণ্যের বাজার মূল্য"
        Me.available_product_market_value.MinimumWidth = 100
        Me.available_product_market_value.Name = "available_product_market_value"
        Me.available_product_market_value.Visible = False
        '
        'total_given_discount
        '
        Me.total_given_discount.DataPropertyName = "total_given_discount"
        Me.total_given_discount.HeaderText = "ডিসকাউন্ট"
        Me.total_given_discount.MinimumWidth = 100
        Me.total_given_discount.Name = "total_given_discount"
        Me.total_given_discount.Visible = False
        '
        'daily_debit_due
        '
        Me.daily_debit_due.DataPropertyName = "daily_debit_due"
        Me.daily_debit_due.HeaderText = "daily_debit_due"
        Me.daily_debit_due.MinimumWidth = 100
        Me.daily_debit_due.Name = "daily_debit_due"
        Me.daily_debit_due.Visible = False
        '
        'daily_credit_due
        '
        Me.daily_credit_due.DataPropertyName = "daily_credit_due"
        Me.daily_credit_due.HeaderText = "daily_credit_due"
        Me.daily_credit_due.MinimumWidth = 100
        Me.daily_credit_due.Name = "daily_credit_due"
        Me.daily_credit_due.Visible = False
        '
        'old_cash_balance
        '
        Me.old_cash_balance.DataPropertyName = "old_cash_balance"
        Me.old_cash_balance.HeaderText = "old_cash_balance"
        Me.old_cash_balance.MinimumWidth = 100
        Me.old_cash_balance.Name = "old_cash_balance"
        Me.old_cash_balance.Visible = False
        '
        'daily_revenue
        '
        Me.daily_revenue.DataPropertyName = "daily_revenue"
        Me.daily_revenue.HeaderText = "দৈনিক লভ্যাংশ"
        Me.daily_revenue.MinimumWidth = 100
        Me.daily_revenue.Name = "daily_revenue"
        '
        'earned_commission
        '
        Me.earned_commission.DataPropertyName = "earned_commission"
        Me.earned_commission.HeaderText = "কমিশন"
        Me.earned_commission.MinimumWidth = 100
        Me.earned_commission.Name = "earned_commission"
        Me.earned_commission.Visible = False
        '
        'delivery_expense
        '
        Me.delivery_expense.DataPropertyName = "delivery_expense"
        Me.delivery_expense.HeaderText = "delivery_expense"
        Me.delivery_expense.Name = "delivery_expense"
        Me.delivery_expense.Visible = False
        '
        'TblProfitBindingSource
        '
        Me.TblProfitBindingSource.DataMember = "tblProfit"
        Me.TblProfitBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index11
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(555, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 63
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(605, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 62
        Me.Button2.UseVisualStyleBackColor = True
        '
        'toDt
        '
        Me.toDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.toDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.toDt.Location = New System.Drawing.Point(390, 13)
        Me.toDt.Name = "toDt"
        Me.toDt.Size = New System.Drawing.Size(101, 24)
        Me.toDt.TabIndex = 60
        '
        'fromDt
        '
        Me.fromDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.fromDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDt.Location = New System.Drawing.Point(225, 12)
        Me.fromDt.Name = "fromDt"
        Me.fromDt.Size = New System.Drawing.Size(101, 24)
        Me.fromDt.TabIndex = 59
        '
        'TblExpensesDataGridView
        '
        Me.TblExpensesDataGridView.AutoGenerateColumns = False
        Me.TblExpensesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblExpensesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn31})
        Me.TblExpensesDataGridView.DataSource = Me.TblExpensesBindingSource
        Me.TblExpensesDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.TblExpensesDataGridView.Name = "TblExpensesDataGridView"
        Me.TblExpensesDataGridView.Size = New System.Drawing.Size(38, 18)
        Me.TblExpensesDataGridView.TabIndex = 81
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn21.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "bankamount"
        Me.DataGridViewTextBoxColumn31.HeaderText = "bankamount"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'TblExpensesBindingSource
        '
        Me.TblExpensesBindingSource.DataMember = "tblExpenses"
        Me.TblExpensesBindingSource.DataSource = Me.DataSet
        '
        'TblDeliveryDataGridView
        '
        Me.TblDeliveryDataGridView.AutoGenerateColumns = False
        Me.TblDeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblDeliveryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn33})
        Me.TblDeliveryDataGridView.DataSource = Me.TblDeliveryBindingSource
        Me.TblDeliveryDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblDeliveryDataGridView.Name = "TblDeliveryDataGridView"
        Me.TblDeliveryDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblDeliveryDataGridView.TabIndex = 81
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "deliveryCharge"
        Me.DataGridViewTextBoxColumn33.HeaderText = "deliveryCharge"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'TblDeliveryBindingSource
        '
        Me.TblDeliveryBindingSource.DataMember = "tblDelivery"
        Me.TblDeliveryBindingSource.DataSource = Me.DataSet
        '
        'TblFridgesDataGridView
        '
        Me.TblFridgesDataGridView.AutoGenerateColumns = False
        Me.TblFridgesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblFridgesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn46})
        Me.TblFridgesDataGridView.DataSource = Me.TblFridgesBindingSource
        Me.TblFridgesDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblFridgesDataGridView.Name = "TblFridgesDataGridView"
        Me.TblFridgesDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblFridgesDataGridView.TabIndex = 80
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "securityMoney"
        Me.DataGridViewTextBoxColumn41.HeaderText = "securityMoney"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "companySecurityMoney"
        Me.DataGridViewTextBoxColumn46.HeaderText = "companySecurityMoney"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'TblFridgesBindingSource
        '
        Me.TblFridgesBindingSource.DataMember = "tblFridges"
        Me.TblFridgesBindingSource.DataSource = Me.DataSet
        '
        'TblassetDataGridView
        '
        Me.TblassetDataGridView.AutoGenerateColumns = False
        Me.TblassetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblassetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.price, Me.IdDataGridViewTextBoxColumn1, Me.AssetNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn, Me.BcDataGridViewTextBoxColumn, Me.AssetConditionDataGridViewTextBoxColumn})
        Me.TblassetDataGridView.DataSource = Me.TblassetBindingSource
        Me.TblassetDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblassetDataGridView.Name = "TblassetDataGridView"
        Me.TblassetDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblassetDataGridView.TabIndex = 80
        '
        'price
        '
        Me.price.DataPropertyName = "price"
        Me.price.HeaderText = "price"
        Me.price.Name = "price"
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        '
        'AssetNameDataGridViewTextBoxColumn
        '
        Me.AssetNameDataGridViewTextBoxColumn.DataPropertyName = "assetName"
        Me.AssetNameDataGridViewTextBoxColumn.HeaderText = "assetName"
        Me.AssetNameDataGridViewTextBoxColumn.Name = "AssetNameDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'IssueDateDataGridViewTextBoxColumn
        '
        Me.IssueDateDataGridViewTextBoxColumn.DataPropertyName = "issueDate"
        Me.IssueDateDataGridViewTextBoxColumn.HeaderText = "issueDate"
        Me.IssueDateDataGridViewTextBoxColumn.Name = "IssueDateDataGridViewTextBoxColumn"
        '
        'BcDataGridViewTextBoxColumn
        '
        Me.BcDataGridViewTextBoxColumn.DataPropertyName = "bc"
        Me.BcDataGridViewTextBoxColumn.HeaderText = "bc"
        Me.BcDataGridViewTextBoxColumn.Name = "BcDataGridViewTextBoxColumn"
        '
        'AssetConditionDataGridViewTextBoxColumn
        '
        Me.AssetConditionDataGridViewTextBoxColumn.DataPropertyName = "assetCondition"
        Me.AssetConditionDataGridViewTextBoxColumn.HeaderText = "assetCondition"
        Me.AssetConditionDataGridViewTextBoxColumn.Name = "AssetConditionDataGridViewTextBoxColumn"
        '
        'TblassetBindingSource
        '
        Me.TblassetBindingSource.DataMember = "tblasset"
        Me.TblassetBindingSource.DataSource = Me.DataSet
        '
        'TblwithdrawDataGridView
        '
        Me.TblwithdrawDataGridView.AutoGenerateColumns = False
        Me.TblwithdrawDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblwithdrawDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13})
        Me.TblwithdrawDataGridView.DataSource = Me.TblwithdrawBindingSource
        Me.TblwithdrawDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblwithdrawDataGridView.Name = "TblwithdrawDataGridView"
        Me.TblwithdrawDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblwithdrawDataGridView.TabIndex = 80
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn13.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'TblwithdrawBindingSource
        '
        Me.TblwithdrawBindingSource.DataMember = "tblwithdraw"
        Me.TblwithdrawBindingSource.DataSource = Me.DataSet
        '
        'TblBankAccountsDataGridView
        '
        Me.TblBankAccountsDataGridView.AutoGenerateColumns = False
        Me.TblBankAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblBankAccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26})
        Me.TblBankAccountsDataGridView.DataSource = Me.TblBankAccountsBindingSource
        Me.TblBankAccountsDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblBankAccountsDataGridView.Name = "TblBankAccountsDataGridView"
        Me.TblBankAccountsDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblBankAccountsDataGridView.TabIndex = 80
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "openingBalance"
        Me.DataGridViewTextBoxColumn26.HeaderText = "openingBalance"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'TblBankAccountsBindingSource
        '
        Me.TblBankAccountsBindingSource.DataMember = "tblBankAccounts"
        Me.TblBankAccountsBindingSource.DataSource = Me.DataSet
        '
        'TblSupplierAccountsDataGridView
        '
        Me.TblSupplierAccountsDataGridView.AutoGenerateColumns = False
        Me.TblSupplierAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSupplierAccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn25})
        Me.TblSupplierAccountsDataGridView.DataSource = Me.TblSupplierAccountsBindingSource
        Me.TblSupplierAccountsDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblSupplierAccountsDataGridView.Name = "TblSupplierAccountsDataGridView"
        Me.TblSupplierAccountsDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblSupplierAccountsDataGridView.TabIndex = 80
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "paid"
        Me.DataGridViewTextBoxColumn22.HeaderText = "paid"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn25.HeaderText = "due"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'TblSupplierAccountsBindingSource
        '
        Me.TblSupplierAccountsBindingSource.DataMember = "tblSupplierAccounts"
        Me.TblSupplierAccountsBindingSource.DataSource = Me.DataSet
        '
        'TblRentSDataGridView
        '
        Me.TblRentSDataGridView.AutoGenerateColumns = False
        Me.TblRentSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblRentSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.TblRentSDataGridView.DataSource = Me.TblRentSBindingSource
        Me.TblRentSDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblRentSDataGridView.Name = "TblRentSDataGridView"
        Me.TblRentSDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblRentSDataGridView.TabIndex = 80
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "rent"
        Me.DataGridViewTextBoxColumn23.HeaderText = "rent"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn24.HeaderText = "due"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'TblRentSBindingSource
        '
        Me.TblRentSBindingSource.DataMember = "tblRentS"
        Me.TblRentSBindingSource.DataSource = Me.DataSet
        '
        'TblExpenseReportDataGridView
        '
        Me.TblExpenseReportDataGridView.AutoGenerateColumns = False
        Me.TblExpenseReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblExpenseReportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15})
        Me.TblExpenseReportDataGridView.DataSource = Me.TblExpenseReportBindingSource
        Me.TblExpenseReportDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblExpenseReportDataGridView.Name = "TblExpenseReportDataGridView"
        Me.TblExpenseReportDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblExpenseReportDataGridView.TabIndex = 80
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn15.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'TblExpenseReportBindingSource
        '
        Me.TblExpenseReportBindingSource.DataMember = "tblExpenseReport"
        Me.TblExpenseReportBindingSource.DataSource = Me.DataSet
        '
        'TblEmployeeAccountsDataGridView
        '
        Me.TblEmployeeAccountsDataGridView.AutoGenerateColumns = False
        Me.TblEmployeeAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblEmployeeAccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn19})
        Me.TblEmployeeAccountsDataGridView.DataSource = Me.TblEmployeeAccountsBindingSource
        Me.TblEmployeeAccountsDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblEmployeeAccountsDataGridView.Name = "TblEmployeeAccountsDataGridView"
        Me.TblEmployeeAccountsDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblEmployeeAccountsDataGridView.TabIndex = 80
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "paid"
        Me.DataGridViewTextBoxColumn16.HeaderText = "paid"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn19.HeaderText = "due"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'TblEmployeeAccountsBindingSource
        '
        Me.TblEmployeeAccountsBindingSource.DataMember = "tblEmployeeAccounts"
        Me.TblEmployeeAccountsBindingSource.DataSource = Me.DataSet
        '
        'TblTransactionDataGridView
        '
        Me.TblTransactionDataGridView.AutoGenerateColumns = False
        Me.TblTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTransactionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11})
        Me.TblTransactionDataGridView.DataSource = Me.TblTransactionBindingSource
        Me.TblTransactionDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblTransactionDataGridView.Name = "TblTransactionDataGridView"
        Me.TblTransactionDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblTransactionDataGridView.TabIndex = 80
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn11.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'TblTransactionBindingSource
        '
        Me.TblTransactionBindingSource.DataMember = "tblTransaction"
        Me.TblTransactionBindingSource.DataSource = Me.DataSet
        '
        'TblRentCDataGridView
        '
        Me.TblRentCDataGridView.AutoGenerateColumns = False
        Me.TblRentCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblRentCDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.TblRentCDataGridView.DataSource = Me.TblRentCBindingSource
        Me.TblRentCDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblRentCDataGridView.Name = "TblRentCDataGridView"
        Me.TblRentCDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblRentCDataGridView.TabIndex = 80
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "rent"
        Me.DataGridViewTextBoxColumn17.HeaderText = "rent"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn18.HeaderText = "due"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'TblRentCBindingSource
        '
        Me.TblRentCBindingSource.DataMember = "tblRentC"
        Me.TblRentCBindingSource.DataSource = Me.DataSet
        '
        'TblIncomeDataGridView
        '
        Me.TblIncomeDataGridView.AutoGenerateColumns = False
        Me.TblIncomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblIncomeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.bankamount})
        Me.TblIncomeDataGridView.DataSource = Me.TblIncomeBindingSource
        Me.TblIncomeDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblIncomeDataGridView.Name = "TblIncomeDataGridView"
        Me.TblIncomeDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblIncomeDataGridView.TabIndex = 80
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn12.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'bankamount
        '
        Me.bankamount.DataPropertyName = "bankamount"
        Me.bankamount.HeaderText = "bankamount"
        Me.bankamount.Name = "bankamount"
        '
        'TblIncomeBindingSource
        '
        Me.TblIncomeBindingSource.DataMember = "tblIncome"
        Me.TblIncomeBindingSource.DataSource = Me.DataSet
        '
        'TblCusomterAccountsDataGridView
        '
        Me.TblCusomterAccountsDataGridView.AutoGenerateColumns = False
        Me.TblCusomterAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCusomterAccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.paid, Me.due, Me.IdDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.SaleInvoiceDataGridViewTextBoxColumn, Me.PaymentDataGridViewTextBoxColumn, Me.PaidDataGridViewTextBoxColumn, Me.DueDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.TblCusomterAccountsDataGridView.DataSource = Me.TblCusomterAccountsBindingSource
        Me.TblCusomterAccountsDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblCusomterAccountsDataGridView.Name = "TblCusomterAccountsDataGridView"
        Me.TblCusomterAccountsDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblCusomterAccountsDataGridView.TabIndex = 80
        '
        'paid
        '
        Me.paid.DataPropertyName = "paid"
        Me.paid.HeaderText = "paid"
        Me.paid.Name = "paid"
        '
        'due
        '
        Me.due.DataPropertyName = "due"
        Me.due.HeaderText = "due"
        Me.due.Name = "due"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "customerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'SaleInvoiceDataGridViewTextBoxColumn
        '
        Me.SaleInvoiceDataGridViewTextBoxColumn.DataPropertyName = "saleInvoice"
        Me.SaleInvoiceDataGridViewTextBoxColumn.HeaderText = "saleInvoice"
        Me.SaleInvoiceDataGridViewTextBoxColumn.Name = "SaleInvoiceDataGridViewTextBoxColumn"
        '
        'PaymentDataGridViewTextBoxColumn
        '
        Me.PaymentDataGridViewTextBoxColumn.DataPropertyName = "payment"
        Me.PaymentDataGridViewTextBoxColumn.HeaderText = "payment"
        Me.PaymentDataGridViewTextBoxColumn.Name = "PaymentDataGridViewTextBoxColumn"
        '
        'PaidDataGridViewTextBoxColumn
        '
        Me.PaidDataGridViewTextBoxColumn.DataPropertyName = "paid"
        Me.PaidDataGridViewTextBoxColumn.HeaderText = "paid"
        Me.PaidDataGridViewTextBoxColumn.Name = "PaidDataGridViewTextBoxColumn"
        '
        'DueDataGridViewTextBoxColumn
        '
        Me.DueDataGridViewTextBoxColumn.DataPropertyName = "due"
        Me.DueDataGridViewTextBoxColumn.HeaderText = "due"
        Me.DueDataGridViewTextBoxColumn.Name = "DueDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'TblCusomterAccountsBindingSource
        '
        Me.TblCusomterAccountsBindingSource.DataMember = "tblCusomterAccounts"
        Me.TblCusomterAccountsBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(12, 9)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(5, 21)
        Me.IdTextBox.TabIndex = 64
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(12, 9)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(5, 21)
        Me.DateTextBox.TabIndex = 66
        '
        'IncomeTextBox
        '
        Me.IncomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "income", True))
        Me.IncomeTextBox.Location = New System.Drawing.Point(12, 9)
        Me.IncomeTextBox.Name = "IncomeTextBox"
        Me.IncomeTextBox.Size = New System.Drawing.Size(5, 21)
        Me.IncomeTextBox.TabIndex = 68
        '
        'ExpenseTextBox
        '
        Me.ExpenseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "expense", True))
        Me.ExpenseTextBox.Location = New System.Drawing.Point(12, 9)
        Me.ExpenseTextBox.Name = "ExpenseTextBox"
        Me.ExpenseTextBox.Size = New System.Drawing.Size(5, 21)
        Me.ExpenseTextBox.TabIndex = 70
        '
        'ProfitTextBox
        '
        Me.ProfitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "profit", True))
        Me.ProfitTextBox.Location = New System.Drawing.Point(12, 9)
        Me.ProfitTextBox.Name = "ProfitTextBox"
        Me.ProfitTextBox.Size = New System.Drawing.Size(5, 21)
        Me.ProfitTextBox.TabIndex = 72
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(12, 9)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(5, 21)
        Me.BalanceTextBox.TabIndex = 74
        '
        'BankBalanceTextBox
        '
        Me.BankBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "bankBalance", True))
        Me.BankBalanceTextBox.Location = New System.Drawing.Point(12, 9)
        Me.BankBalanceTextBox.Name = "BankBalanceTextBox"
        Me.BankBalanceTextBox.Size = New System.Drawing.Size(5, 21)
        Me.BankBalanceTextBox.TabIndex = 76
        '
        'DrdueTextBox
        '
        Me.DrdueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "drdue", True))
        Me.DrdueTextBox.Location = New System.Drawing.Point(12, 9)
        Me.DrdueTextBox.Name = "DrdueTextBox"
        Me.DrdueTextBox.Size = New System.Drawing.Size(5, 21)
        Me.DrdueTextBox.TabIndex = 78
        '
        'CrdueTextBox
        '
        Me.CrdueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "crdue", True))
        Me.CrdueTextBox.Location = New System.Drawing.Point(12, 9)
        Me.CrdueTextBox.Name = "CrdueTextBox"
        Me.CrdueTextBox.Size = New System.Drawing.Size(5, 21)
        Me.CrdueTextBox.TabIndex = 80
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "paid"
        Me.DataGridViewTextBoxColumn14.HeaderText = "paid"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AssetTextBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 5)
        Me.Panel2.TabIndex = 82
        '
        'AssetTextBox
        '
        Me.AssetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "asset", True))
        Me.AssetTextBox.Location = New System.Drawing.Point(50, -26)
        Me.AssetTextBox.Name = "AssetTextBox"
        Me.AssetTextBox.Size = New System.Drawing.Size(12, 21)
        Me.AssetTextBox.TabIndex = 83
        '
        'TblVehicleDataGridView
        '
        Me.TblVehicleDataGridView.AutoGenerateColumns = False
        Me.TblVehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblVehicleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.IdDataGridViewTextBoxColumn2, Me.VehicleModelDataGridViewTextBoxColumn, Me.VehicleNumberDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn1, Me.PriceDataGridViewTextBoxColumn1, Me.BcDataGridViewTextBoxColumn1, Me.VehicleConditionDataGridViewTextBoxColumn, Me.VehicleIDDataGridViewTextBoxColumn, Me.DriverNameDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn})
        Me.TblVehicleDataGridView.DataSource = Me.TblVehicleBindingSource
        Me.TblVehicleDataGridView.Location = New System.Drawing.Point(12, 9)
        Me.TblVehicleDataGridView.Name = "TblVehicleDataGridView"
        Me.TblVehicleDataGridView.Size = New System.Drawing.Size(5, 5)
        Me.TblVehicleDataGridView.TabIndex = 82
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn1.HeaderText = "price"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        '
        'VehicleModelDataGridViewTextBoxColumn
        '
        Me.VehicleModelDataGridViewTextBoxColumn.DataPropertyName = "vehicleModel"
        Me.VehicleModelDataGridViewTextBoxColumn.HeaderText = "vehicleModel"
        Me.VehicleModelDataGridViewTextBoxColumn.Name = "VehicleModelDataGridViewTextBoxColumn"
        '
        'VehicleNumberDataGridViewTextBoxColumn
        '
        Me.VehicleNumberDataGridViewTextBoxColumn.DataPropertyName = "vehicleNumber"
        Me.VehicleNumberDataGridViewTextBoxColumn.HeaderText = "vehicleNumber"
        Me.VehicleNumberDataGridViewTextBoxColumn.Name = "VehicleNumberDataGridViewTextBoxColumn"
        '
        'IssueDateDataGridViewTextBoxColumn1
        '
        Me.IssueDateDataGridViewTextBoxColumn1.DataPropertyName = "issueDate"
        Me.IssueDateDataGridViewTextBoxColumn1.HeaderText = "issueDate"
        Me.IssueDateDataGridViewTextBoxColumn1.Name = "IssueDateDataGridViewTextBoxColumn1"
        '
        'PriceDataGridViewTextBoxColumn1
        '
        Me.PriceDataGridViewTextBoxColumn1.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn1.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn1.Name = "PriceDataGridViewTextBoxColumn1"
        '
        'BcDataGridViewTextBoxColumn1
        '
        Me.BcDataGridViewTextBoxColumn1.DataPropertyName = "bc"
        Me.BcDataGridViewTextBoxColumn1.HeaderText = "bc"
        Me.BcDataGridViewTextBoxColumn1.Name = "BcDataGridViewTextBoxColumn1"
        '
        'VehicleConditionDataGridViewTextBoxColumn
        '
        Me.VehicleConditionDataGridViewTextBoxColumn.DataPropertyName = "vehicleCondition"
        Me.VehicleConditionDataGridViewTextBoxColumn.HeaderText = "vehicleCondition"
        Me.VehicleConditionDataGridViewTextBoxColumn.Name = "VehicleConditionDataGridViewTextBoxColumn"
        '
        'VehicleIDDataGridViewTextBoxColumn
        '
        Me.VehicleIDDataGridViewTextBoxColumn.DataPropertyName = "vehicleID"
        Me.VehicleIDDataGridViewTextBoxColumn.HeaderText = "vehicleID"
        Me.VehicleIDDataGridViewTextBoxColumn.Name = "VehicleIDDataGridViewTextBoxColumn"
        '
        'DriverNameDataGridViewTextBoxColumn
        '
        Me.DriverNameDataGridViewTextBoxColumn.DataPropertyName = "driverName"
        Me.DriverNameDataGridViewTextBoxColumn.HeaderText = "driverName"
        Me.DriverNameDataGridViewTextBoxColumn.Name = "DriverNameDataGridViewTextBoxColumn"
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        '
        'TblVehicleBindingSource
        '
        Me.TblVehicleBindingSource.DataMember = "tblVehicle"
        Me.TblVehicleBindingSource.DataSource = Me.DataSet
        '
        'TblsellcommissionDataGridView
        '
        Me.TblsellcommissionDataGridView.AutoGenerateColumns = False
        Me.TblsellcommissionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblsellcommissionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn38})
        Me.TblsellcommissionDataGridView.DataSource = Me.TblsellcommissionBindingSource
        Me.TblsellcommissionDataGridView.Location = New System.Drawing.Point(60, 0)
        Me.TblsellcommissionDataGridView.Name = "TblsellcommissionDataGridView"
        Me.TblsellcommissionDataGridView.Size = New System.Drawing.Size(142, 31)
        Me.TblsellcommissionDataGridView.TabIndex = 82
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "earned_commission"
        Me.DataGridViewTextBoxColumn38.HeaderText = "earned_commission"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'TblsellcommissionBindingSource
        '
        Me.TblsellcommissionBindingSource.DataMember = "tblsellcommission"
        Me.TblsellcommissionBindingSource.DataSource = Me.DataSet
        '
        'TbldiscountDataGridView
        '
        Me.TbldiscountDataGridView.AutoGenerateColumns = False
        Me.TbldiscountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbldiscountDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn40})
        Me.TbldiscountDataGridView.DataSource = Me.TbldiscountBindingSource
        Me.TbldiscountDataGridView.Location = New System.Drawing.Point(949, 14)
        Me.TbldiscountDataGridView.Name = "TbldiscountDataGridView"
        Me.TbldiscountDataGridView.Size = New System.Drawing.Size(39, 17)
        Me.TbldiscountDataGridView.TabIndex = 82
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "given_discount"
        Me.DataGridViewTextBoxColumn40.HeaderText = "given_discount"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'TbldiscountBindingSource
        '
        Me.TbldiscountBindingSource.DataMember = "tbldiscount"
        Me.TbldiscountBindingSource.DataSource = Me.DataSet
        '
        'Bank_withdrawTextBox
        '
        Me.Bank_withdrawTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "bank_withdraw", True))
        Me.Bank_withdrawTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Bank_withdrawTextBox.Name = "Bank_withdrawTextBox"
        Me.Bank_withdrawTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Bank_withdrawTextBox.TabIndex = 103
        '
        'Bank_depositTextBox
        '
        Me.Bank_depositTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "bank_deposit", True))
        Me.Bank_depositTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Bank_depositTextBox.Name = "Bank_depositTextBox"
        Me.Bank_depositTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Bank_depositTextBox.TabIndex = 105
        '
        'Cash_withdrawTextBox
        '
        Me.Cash_withdrawTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "cash_withdraw", True))
        Me.Cash_withdrawTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Cash_withdrawTextBox.Name = "Cash_withdrawTextBox"
        Me.Cash_withdrawTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Cash_withdrawTextBox.TabIndex = 107
        '
        'Damage_productTextBox
        '
        Me.Damage_productTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "damage_product", True))
        Me.Damage_productTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Damage_productTextBox.Name = "Damage_productTextBox"
        Me.Damage_productTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Damage_productTextBox.TabIndex = 109
        '
        'Total_saleTextBox
        '
        Me.Total_saleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "total_sale", True))
        Me.Total_saleTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Total_saleTextBox.Name = "Total_saleTextBox"
        Me.Total_saleTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Total_saleTextBox.TabIndex = 111
        '
        'Total_purchaseTextBox
        '
        Me.Total_purchaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "total_purchase", True))
        Me.Total_purchaseTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Total_purchaseTextBox.Name = "Total_purchaseTextBox"
        Me.Total_purchaseTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Total_purchaseTextBox.TabIndex = 113
        '
        'Available_products_valueTextBox
        '
        Me.Available_products_valueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "available_products_value", True))
        Me.Available_products_valueTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Available_products_valueTextBox.Name = "Available_products_valueTextBox"
        Me.Available_products_valueTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Available_products_valueTextBox.TabIndex = 115
        '
        'Available_product_market_valueTextBox
        '
        Me.Available_product_market_valueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "available_product_market_value", True))
        Me.Available_product_market_valueTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Available_product_market_valueTextBox.Name = "Available_product_market_valueTextBox"
        Me.Available_product_market_valueTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Available_product_market_valueTextBox.TabIndex = 117
        '
        'Total_given_discountTextBox
        '
        Me.Total_given_discountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "total_given_discount", True))
        Me.Total_given_discountTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Total_given_discountTextBox.Name = "Total_given_discountTextBox"
        Me.Total_given_discountTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Total_given_discountTextBox.TabIndex = 119
        '
        'Daily_debit_dueTextBox
        '
        Me.Daily_debit_dueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "daily_debit_due", True))
        Me.Daily_debit_dueTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Daily_debit_dueTextBox.Name = "Daily_debit_dueTextBox"
        Me.Daily_debit_dueTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Daily_debit_dueTextBox.TabIndex = 121
        '
        'Daily_credit_dueTextBox
        '
        Me.Daily_credit_dueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "daily_credit_due", True))
        Me.Daily_credit_dueTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Daily_credit_dueTextBox.Name = "Daily_credit_dueTextBox"
        Me.Daily_credit_dueTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Daily_credit_dueTextBox.TabIndex = 123
        '
        'Old_cash_balanceTextBox
        '
        Me.Old_cash_balanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "old_cash_balance", True))
        Me.Old_cash_balanceTextBox.Location = New System.Drawing.Point(927, 1)
        Me.Old_cash_balanceTextBox.Name = "Old_cash_balanceTextBox"
        Me.Old_cash_balanceTextBox.Size = New System.Drawing.Size(31, 21)
        Me.Old_cash_balanceTextBox.TabIndex = 125
        '
        'TblProfitTableAdapter
        '
        Me.TblProfitTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sales_targetTableAdapter = Nothing
        Me.TableAdapterManager.tblassetTableAdapter = Me.TblassetTableAdapter
        Me.TableAdapterManager.tblAttendenceReportTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceTableAdapter = Nothing
        Me.TableAdapterManager.tblBankAccountsTableAdapter = Me.TblBankAccountsTableAdapter
        Me.TableAdapterManager.tblBanksTableAdapter = Nothing
        Me.TableAdapterManager.tblCashReportTableAdapter = Nothing
        Me.TableAdapterManager.tblCompanySettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblCusomterAccountsTableAdapter = Me.TblCusomterAccountsTableAdapter
        Me.TableAdapterManager.tblCustomersTableAdapter = Nothing
        Me.TableAdapterManager.tblDamageFridgeTableAdapter = Nothing
        Me.TableAdapterManager.tblDamageProductsTableAdapter = Nothing
        Me.TableAdapterManager.tblDeliveryTableAdapter = Me.TblDeliveryTableAdapter
        Me.TableAdapterManager.tbldiscountTableAdapter = Me.TbldiscountTableAdapter
        Me.TableAdapterManager.tblDocumentsCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblDocumentsTableAdapter = Nothing
        Me.TableAdapterManager.tblDuesReportTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeAccountsTableAdapter = Me.TblEmployeeAccountsTableAdapter
        Me.TableAdapterManager.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblExpenseCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblExpenseReportTableAdapter = Me.TblExpenseReportTableAdapter
        Me.TableAdapterManager.tblExpensesTableAdapter = Me.TblExpensesTableAdapter
        Me.TableAdapterManager.tblExpenseSubcategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblFridgesTableAdapter = Me.TblFridgesTableAdapter
        Me.TableAdapterManager.tblIncomeCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeSubcategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeTableAdapter = Me.TblIncomeTableAdapter
        Me.TableAdapterManager.tblInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblNotesTableAdapter = Nothing
        Me.TableAdapterManager.tblNoticeTableAdapter = Nothing
        Me.TableAdapterManager.tblPCommissionTableAdapter = Nothing
        Me.TableAdapterManager.tblProductCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblProductsTableAdapter = Nothing
        Me.TableAdapterManager.tblProfitTableAdapter = Me.TblProfitTableAdapter
        Me.TableAdapterManager.tblPurchaseInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseReportTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseTableAdapter = Nothing
        Me.TableAdapterManager.tblRentCSTableAdapter = Nothing
        Me.TableAdapterManager.tblRentCTableAdapter = Me.TblRentCTableAdapter
        Me.TableAdapterManager.tblRentSTableAdapter = Me.TblRentSTableAdapter
        Me.TableAdapterManager.tblSalesreportTableAdapter = Nothing
        Me.TableAdapterManager.tblSalesTableAdapter = Nothing
        Me.TableAdapterManager.tblSCommissionTableAdapter = Nothing
        Me.TableAdapterManager.tblsellcommissionTableAdapter = Me.TblsellcommissionTableAdapter
        Me.TableAdapterManager.tblSignboardTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblSuppliersTableAdapter = Nothing
        Me.TableAdapterManager.tblTransactionReportTableAdapter = Nothing
        Me.TableAdapterManager.tblTransactionTableAdapter = Me.TblTransactionTableAdapter
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Me.TblVehicleTableAdapter
        Me.TableAdapterManager.tblwithdrawTableAdapter = Me.TblwithdrawTableAdapter
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'TblassetTableAdapter
        '
        Me.TblassetTableAdapter.ClearBeforeFill = True
        '
        'TblBankAccountsTableAdapter
        '
        Me.TblBankAccountsTableAdapter.ClearBeforeFill = True
        '
        'TblCusomterAccountsTableAdapter
        '
        Me.TblCusomterAccountsTableAdapter.ClearBeforeFill = True
        '
        'TblDeliveryTableAdapter
        '
        Me.TblDeliveryTableAdapter.ClearBeforeFill = True
        '
        'TbldiscountTableAdapter
        '
        Me.TbldiscountTableAdapter.ClearBeforeFill = True
        '
        'TblEmployeeAccountsTableAdapter
        '
        Me.TblEmployeeAccountsTableAdapter.ClearBeforeFill = True
        '
        'TblExpenseReportTableAdapter
        '
        Me.TblExpenseReportTableAdapter.ClearBeforeFill = True
        '
        'TblExpensesTableAdapter
        '
        Me.TblExpensesTableAdapter.ClearBeforeFill = True
        '
        'TblFridgesTableAdapter
        '
        Me.TblFridgesTableAdapter.ClearBeforeFill = True
        '
        'TblIncomeTableAdapter
        '
        Me.TblIncomeTableAdapter.ClearBeforeFill = True
        '
        'TblRentCTableAdapter
        '
        Me.TblRentCTableAdapter.ClearBeforeFill = True
        '
        'TblRentSTableAdapter
        '
        Me.TblRentSTableAdapter.ClearBeforeFill = True
        '
        'TblsellcommissionTableAdapter
        '
        Me.TblsellcommissionTableAdapter.ClearBeforeFill = True
        '
        'TblTransactionTableAdapter
        '
        Me.TblTransactionTableAdapter.ClearBeforeFill = True
        '
        'TblVehicleTableAdapter
        '
        Me.TblVehicleTableAdapter.ClearBeforeFill = True
        '
        'TblwithdrawTableAdapter
        '
        Me.TblwithdrawTableAdapter.ClearBeforeFill = True
        '
        'TblSupplierAccountsTableAdapter
        '
        Me.TblSupplierAccountsTableAdapter.ClearBeforeFill = True
        '
        'TblSignboardTableAdapter1
        '
        Me.TblSignboardTableAdapter1.ClearBeforeFill = True
        '
        'Daily_revenueTextBox
        '
        Me.Daily_revenueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "daily_revenue", True))
        Me.Daily_revenueTextBox.Location = New System.Drawing.Point(17, 6)
        Me.Daily_revenueTextBox.Name = "Daily_revenueTextBox"
        Me.Daily_revenueTextBox.Size = New System.Drawing.Size(32, 21)
        Me.Daily_revenueTextBox.TabIndex = 86
        '
        'Earned_commissionTextBox
        '
        Me.Earned_commissionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "earned_commission", True))
        Me.Earned_commissionTextBox.Location = New System.Drawing.Point(17, 6)
        Me.Earned_commissionTextBox.Name = "Earned_commissionTextBox"
        Me.Earned_commissionTextBox.Size = New System.Drawing.Size(32, 21)
        Me.Earned_commissionTextBox.TabIndex = 87
        '
        'Delivery_expenseTextBox
        '
        Me.Delivery_expenseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProfitBindingSource, "delivery_expense", True))
        Me.Delivery_expenseTextBox.Location = New System.Drawing.Point(17, 6)
        Me.Delivery_expenseTextBox.Name = "Delivery_expenseTextBox"
        Me.Delivery_expenseTextBox.Size = New System.Drawing.Size(32, 21)
        Me.Delivery_expenseTextBox.TabIndex = 88
        '
        'TblInvoiceBindingSource
        '
        Me.TblInvoiceBindingSource.DataMember = "tblInvoice"
        Me.TblInvoiceBindingSource.DataSource = Me.DataSet
        '
        'TblInvoiceTableAdapter
        '
        Me.TblInvoiceTableAdapter.ClearBeforeFill = True
        '
        'TblInvoiceDataGridView
        '
        Me.TblInvoiceDataGridView.AutoGenerateColumns = False
        Me.TblInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn27, Me.padi, Me.DataGridViewTextBoxColumn35, Me.totalAmount, Me.grandTotal})
        Me.TblInvoiceDataGridView.DataSource = Me.TblInvoiceBindingSource
        Me.TblInvoiceDataGridView.Location = New System.Drawing.Point(66, 1)
        Me.TblInvoiceDataGridView.Name = "TblInvoiceDataGridView"
        Me.TblInvoiceDataGridView.Size = New System.Drawing.Size(57, 23)
        Me.TblInvoiceDataGridView.TabIndex = 125
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "bankamount"
        Me.DataGridViewTextBoxColumn27.HeaderText = "bankamount"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'padi
        '
        Me.padi.DataPropertyName = "padi"
        Me.padi.HeaderText = "padi"
        Me.padi.Name = "padi"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn35.HeaderText = "due"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'totalAmount
        '
        Me.totalAmount.DataPropertyName = "totalAmount"
        Me.totalAmount.HeaderText = "totalAmount"
        Me.totalAmount.Name = "totalAmount"
        '
        'grandTotal
        '
        Me.grandTotal.DataPropertyName = "grandTotal"
        Me.grandTotal.HeaderText = "grandTotal"
        Me.grandTotal.Name = "grandTotal"
        '
        'TblPurchaseInvoiceBindingSource
        '
        Me.TblPurchaseInvoiceBindingSource.DataMember = "tblPurchaseInvoice"
        Me.TblPurchaseInvoiceBindingSource.DataSource = Me.DataSet
        '
        'TblPurchaseInvoiceTableAdapter
        '
        Me.TblPurchaseInvoiceTableAdapter.ClearBeforeFill = True
        '
        'TblPurchaseInvoiceDataGridView
        '
        Me.TblPurchaseInvoiceDataGridView.AutoGenerateColumns = False
        Me.TblPurchaseInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPurchaseInvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn20, Me.IdDataGridViewTextBoxColumn3, Me.SupplierDataGridViewTextBoxColumn, Me.InvoiceNoDataGridViewTextBoxColumn, Me.CompanyInvoiceDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn1, Me.PaidDataGridViewTextBoxColumn1, Me.DueDataGridViewTextBoxColumn1, Me.AccNoDataGridViewTextBoxColumn, Me.BankamountDataGridViewTextBoxColumn, Me.PaymentmethodDataGridViewTextBoxColumn, Me.PaymentremarkDataGridViewTextBoxColumn})
        Me.TblPurchaseInvoiceDataGridView.DataSource = Me.TblPurchaseInvoiceBindingSource
        Me.TblPurchaseInvoiceDataGridView.Location = New System.Drawing.Point(66, 1)
        Me.TblPurchaseInvoiceDataGridView.Name = "TblPurchaseInvoiceDataGridView"
        Me.TblPurchaseInvoiceDataGridView.Size = New System.Drawing.Size(57, 23)
        Me.TblPurchaseInvoiceDataGridView.TabIndex = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "bankamount"
        Me.DataGridViewTextBoxColumn10.HeaderText = "bankamount"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "paid"
        Me.DataGridViewTextBoxColumn6.HeaderText = "paid"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn20.HeaderText = "due"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'IdDataGridViewTextBoxColumn3
        '
        Me.IdDataGridViewTextBoxColumn3.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn3.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn3.Name = "IdDataGridViewTextBoxColumn3"
        '
        'SupplierDataGridViewTextBoxColumn
        '
        Me.SupplierDataGridViewTextBoxColumn.DataPropertyName = "supplier"
        Me.SupplierDataGridViewTextBoxColumn.HeaderText = "supplier"
        Me.SupplierDataGridViewTextBoxColumn.Name = "SupplierDataGridViewTextBoxColumn"
        '
        'InvoiceNoDataGridViewTextBoxColumn
        '
        Me.InvoiceNoDataGridViewTextBoxColumn.DataPropertyName = "invoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn.HeaderText = "invoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn.Name = "InvoiceNoDataGridViewTextBoxColumn"
        '
        'CompanyInvoiceDataGridViewTextBoxColumn
        '
        Me.CompanyInvoiceDataGridViewTextBoxColumn.DataPropertyName = "companyInvoice"
        Me.CompanyInvoiceDataGridViewTextBoxColumn.HeaderText = "companyInvoice"
        Me.CompanyInvoiceDataGridViewTextBoxColumn.Name = "CompanyInvoiceDataGridViewTextBoxColumn"
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "totalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "totalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn1
        '
        Me.DateDataGridViewTextBoxColumn1.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn1.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn1.Name = "DateDataGridViewTextBoxColumn1"
        '
        'PaidDataGridViewTextBoxColumn1
        '
        Me.PaidDataGridViewTextBoxColumn1.DataPropertyName = "paid"
        Me.PaidDataGridViewTextBoxColumn1.HeaderText = "paid"
        Me.PaidDataGridViewTextBoxColumn1.Name = "PaidDataGridViewTextBoxColumn1"
        '
        'DueDataGridViewTextBoxColumn1
        '
        Me.DueDataGridViewTextBoxColumn1.DataPropertyName = "due"
        Me.DueDataGridViewTextBoxColumn1.HeaderText = "due"
        Me.DueDataGridViewTextBoxColumn1.Name = "DueDataGridViewTextBoxColumn1"
        '
        'AccNoDataGridViewTextBoxColumn
        '
        Me.AccNoDataGridViewTextBoxColumn.DataPropertyName = "accNo"
        Me.AccNoDataGridViewTextBoxColumn.HeaderText = "accNo"
        Me.AccNoDataGridViewTextBoxColumn.Name = "AccNoDataGridViewTextBoxColumn"
        '
        'BankamountDataGridViewTextBoxColumn
        '
        Me.BankamountDataGridViewTextBoxColumn.DataPropertyName = "bankamount"
        Me.BankamountDataGridViewTextBoxColumn.HeaderText = "bankamount"
        Me.BankamountDataGridViewTextBoxColumn.Name = "BankamountDataGridViewTextBoxColumn"
        '
        'PaymentmethodDataGridViewTextBoxColumn
        '
        Me.PaymentmethodDataGridViewTextBoxColumn.DataPropertyName = "paymentmethod"
        Me.PaymentmethodDataGridViewTextBoxColumn.HeaderText = "paymentmethod"
        Me.PaymentmethodDataGridViewTextBoxColumn.Name = "PaymentmethodDataGridViewTextBoxColumn"
        '
        'PaymentremarkDataGridViewTextBoxColumn
        '
        Me.PaymentremarkDataGridViewTextBoxColumn.DataPropertyName = "payment_remark"
        Me.PaymentremarkDataGridViewTextBoxColumn.HeaderText = "payment_remark"
        Me.PaymentremarkDataGridViewTextBoxColumn.Name = "PaymentremarkDataGridViewTextBoxColumn"
        '
        'TblSalesBindingSource
        '
        Me.TblSalesBindingSource.DataMember = "tblSales"
        Me.TblSalesBindingSource.DataSource = Me.DataSet
        '
        'TblSalesTableAdapter
        '
        Me.TblSalesTableAdapter.ClearBeforeFill = True
        '
        'TblSalesDataGridView
        '
        Me.TblSalesDataGridView.AutoGenerateColumns = False
        Me.TblSalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55})
        Me.TblSalesDataGridView.DataSource = Me.TblSalesBindingSource
        Me.TblSalesDataGridView.Location = New System.Drawing.Point(42, 0)
        Me.TblSalesDataGridView.Name = "TblSalesDataGridView"
        Me.TblSalesDataGridView.Size = New System.Drawing.Size(300, 19)
        Me.TblSalesDataGridView.TabIndex = 125
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn34.HeaderText = "quantity"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "purchase_price"
        Me.DataGridViewTextBoxColumn54.HeaderText = "purchase_price"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "profit"
        Me.DataGridViewTextBoxColumn55.HeaderText = "profit"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'profitCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblsellcommissionDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TblVehicleDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.CrdueTextBox)
        Me.Controls.Add(CrdueLabel)
        Me.Controls.Add(Me.DrdueTextBox)
        Me.Controls.Add(DrdueLabel)
        Me.Controls.Add(Me.BankBalanceTextBox)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(Me.TblDeliveryDataGridView)
        Me.Controls.Add(BalanceLabel)
        Me.Controls.Add(Me.TblFridgesDataGridView)
        Me.Controls.Add(Me.ProfitTextBox)
        Me.Controls.Add(Me.TblassetDataGridView)
        Me.Controls.Add(ProfitLabel)
        Me.Controls.Add(Me.TblwithdrawDataGridView)
        Me.Controls.Add(Me.ExpenseTextBox)
        Me.Controls.Add(Me.TblBankAccountsDataGridView)
        Me.Controls.Add(ExpenseLabel)
        Me.Controls.Add(Me.TblSupplierAccountsDataGridView)
        Me.Controls.Add(Me.IncomeTextBox)
        Me.Controls.Add(Me.TblRentSDataGridView)
        Me.Controls.Add(IncomeLabel)
        Me.Controls.Add(Me.TblExpenseReportDataGridView)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.TblEmployeeAccountsDataGridView)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.TblTransactionDataGridView)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.TblRentCDataGridView)
        Me.Controls.Add(Me.TblCusomterAccountsDataGridView)
        Me.Controls.Add(Me.TblIncomeDataGridView)
        Me.Controls.Add(Me.TbldiscountDataGridView)
        Me.Controls.Add(Me.Bank_withdrawTextBox)
        Me.Controls.Add(Me.Bank_depositTextBox)
        Me.Controls.Add(Me.Cash_withdrawTextBox)
        Me.Controls.Add(Me.Damage_productTextBox)
        Me.Controls.Add(Me.Total_saleTextBox)
        Me.Controls.Add(Me.Total_purchaseTextBox)
        Me.Controls.Add(Me.Available_products_valueTextBox)
        Me.Controls.Add(Me.Available_product_market_valueTextBox)
        Me.Controls.Add(Me.Total_given_discountTextBox)
        Me.Controls.Add(Me.Daily_debit_dueTextBox)
        Me.Controls.Add(Me.Daily_credit_dueTextBox)
        Me.Controls.Add(Me.Old_cash_balanceTextBox)
        Me.Controls.Add(Me.Delivery_expenseTextBox)
        Me.Controls.Add(Me.Earned_commissionTextBox)
        Me.Controls.Add(Me.Daily_revenueTextBox)
        Me.Controls.Add(Me.TblPurchaseInvoiceDataGridView)
        Me.Controls.Add(Me.TblInvoiceDataGridView)
        Me.Controls.Add(Me.TblSalesDataGridView)
        Me.Controls.Add(Me.TblExpensesDataGridView)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "profitCalculator"
        Me.Text = "profitCalculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.TblProfitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProfitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpensesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDeliveryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFridgesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblassetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblassetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblwithdrawDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblwithdrawBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBankAccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSupplierAccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSupplierAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRentSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRentSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpenseReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpenseReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeAccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRentCDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRentCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncomeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCusomterAccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCusomterAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblVehicleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsellcommissionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsellcommissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldiscountDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldiscountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPurchaseInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPurchaseInvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents toDt As DateTimePicker
    Friend WithEvents fromDt As DateTimePicker
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblProfitBindingSource As BindingSource
    Friend WithEvents TblProfitTableAdapter As dataSetTableAdapters.tblProfitTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents IncomeTextBox As TextBox
    Friend WithEvents ExpenseTextBox As TextBox
    Friend WithEvents ProfitTextBox As TextBox
    Friend WithEvents BalanceTextBox As TextBox
    Friend WithEvents BankBalanceTextBox As TextBox
    Friend WithEvents DrdueTextBox As TextBox
    Friend WithEvents CrdueTextBox As TextBox
    Friend WithEvents TblCusomterAccountsBindingSource As BindingSource
    Friend WithEvents TblCusomterAccountsTableAdapter As dataSetTableAdapters.tblCusomterAccountsTableAdapter
    Friend WithEvents TblCusomterAccountsDataGridView As DataGridView
    Friend WithEvents TblIncomeBindingSource As BindingSource
    Friend WithEvents TblIncomeTableAdapter As dataSetTableAdapters.tblIncomeTableAdapter
    Friend WithEvents TblIncomeDataGridView As DataGridView
    Friend WithEvents TblRentCBindingSource As BindingSource
    Friend WithEvents TblRentCTableAdapter As dataSetTableAdapters.tblRentCTableAdapter
    Friend WithEvents TblRentCDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents TblTransactionBindingSource As BindingSource
    Friend WithEvents TblTransactionTableAdapter As dataSetTableAdapters.tblTransactionTableAdapter
    Friend WithEvents TblTransactionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents TblEmployeeAccountsBindingSource As BindingSource
    Friend WithEvents TblEmployeeAccountsTableAdapter As dataSetTableAdapters.tblEmployeeAccountsTableAdapter
    Friend WithEvents TblEmployeeAccountsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents TblExpenseReportBindingSource As BindingSource
    Friend WithEvents TblExpenseReportTableAdapter As dataSetTableAdapters.tblExpenseReportTableAdapter
    Friend WithEvents TblExpenseReportDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents TblRentSBindingSource As BindingSource
    Friend WithEvents TblRentSTableAdapter As dataSetTableAdapters.tblRentSTableAdapter
    Friend WithEvents TblRentSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents TblSupplierAccountsBindingSource As BindingSource
    Friend WithEvents TblSupplierAccountsTableAdapter As dataSetTableAdapters.tblSupplierAccountsTableAdapter
    Friend WithEvents TblSupplierAccountsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents paid As DataGridViewTextBoxColumn
    Friend WithEvents due As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleInvoiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblBankAccountsBindingSource As BindingSource
    Friend WithEvents TblBankAccountsTableAdapter As dataSetTableAdapters.tblBankAccountsTableAdapter
    Friend WithEvents TblBankAccountsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents TblwithdrawBindingSource As BindingSource
    Friend WithEvents TblwithdrawTableAdapter As dataSetTableAdapters.tblwithdrawTableAdapter
    Friend WithEvents TblwithdrawDataGridView As DataGridView
    Friend WithEvents TblassetBindingSource As BindingSource
    Friend WithEvents TblassetTableAdapter As dataSetTableAdapters.tblassetTableAdapter
    Friend WithEvents TblassetDataGridView As DataGridView
    Friend WithEvents TblFridgesBindingSource As BindingSource
    Friend WithEvents TblFridgesTableAdapter As dataSetTableAdapters.tblFridgesTableAdapter
    Friend WithEvents TblFridgesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents TblDeliveryBindingSource As BindingSource
    Friend WithEvents TblDeliveryTableAdapter As dataSetTableAdapters.tblDeliveryTableAdapter
    Friend WithEvents TblDeliveryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents TblExpensesBindingSource As BindingSource
    Friend WithEvents TblExpensesTableAdapter As dataSetTableAdapters.tblExpensesTableAdapter
    Friend WithEvents TblExpensesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents bankamount As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AssetNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetConditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssetTextBox As TextBox
    Friend WithEvents TblVehicleBindingSource As BindingSource
    Friend WithEvents TblVehicleTableAdapter As dataSetTableAdapters.tblVehicleTableAdapter
    Friend WithEvents TblVehicleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents IdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents VehicleModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BcDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents VehicleConditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DriverNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblsellcommissionBindingSource As BindingSource
    Friend WithEvents TblsellcommissionTableAdapter As dataSetTableAdapters.tblsellcommissionTableAdapter
    Friend WithEvents TblsellcommissionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents TbldiscountBindingSource As BindingSource
    Friend WithEvents TbldiscountTableAdapter As dataSetTableAdapters.tbldiscountTableAdapter
    Friend WithEvents TbldiscountDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents TblProfitDataGridView As DataGridView
    Friend WithEvents TblSignboardTableAdapter1 As dataSetTableAdapters.tblSignboardTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_damageproduct As Label
    Friend WithEvents lbl_bank_deposit As Label
    Friend WithEvents lbl_income As Label
    Friend WithEvents lbl_expense_without_purchase As Label
    Friend WithEvents lbl_bank_withdraw As Label
    Friend WithEvents lbl_expense As Label
    Friend WithEvents lbl_cash_balance As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_sale As Label
    Friend WithEvents lbl_purchase As Label
    Friend WithEvents Bank_withdrawTextBox As TextBox
    Friend WithEvents Bank_depositTextBox As TextBox
    Friend WithEvents Cash_withdrawTextBox As TextBox
    Friend WithEvents Damage_productTextBox As TextBox
    Friend WithEvents Total_saleTextBox As TextBox
    Friend WithEvents Total_purchaseTextBox As TextBox
    Friend WithEvents Available_products_valueTextBox As TextBox
    Friend WithEvents Available_product_market_valueTextBox As TextBox
    Friend WithEvents Total_given_discountTextBox As TextBox
    Friend WithEvents Daily_debit_dueTextBox As TextBox
    Friend WithEvents Daily_credit_dueTextBox As TextBox
    Friend WithEvents Old_cash_balanceTextBox As TextBox
    Friend WithEvents Daily_revenueTextBox As TextBox
    Friend WithEvents Earned_commissionTextBox As TextBox
    Friend WithEvents Delivery_expenseTextBox As TextBox
    Friend WithEvents TblInvoiceBindingSource As BindingSource
    Friend WithEvents TblInvoiceTableAdapter As dataSetTableAdapters.tblInvoiceTableAdapter
    Friend WithEvents TblInvoiceDataGridView As DataGridView
    Friend WithEvents TblPurchaseInvoiceBindingSource As BindingSource
    Friend WithEvents TblPurchaseInvoiceTableAdapter As dataSetTableAdapters.tblPurchaseInvoiceTableAdapter
    Friend WithEvents TblPurchaseInvoiceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents TblSalesBindingSource As BindingSource
    Friend WithEvents TblSalesTableAdapter As dataSetTableAdapters.tblSalesTableAdapter
    Friend WithEvents TblSalesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents IdDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyInvoiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PaidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DueDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AccNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BankamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentmethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentremarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents padi As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents totalAmount As DataGridViewTextBoxColumn
    Friend WithEvents grandTotal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents asset As DataGridViewTextBoxColumn
    Friend WithEvents balance As DataGridViewTextBoxColumn
    Friend WithEvents bank_withdraw As DataGridViewTextBoxColumn
    Friend WithEvents bank_deposit As DataGridViewTextBoxColumn
    Friend WithEvents cash_withdraw As DataGridViewTextBoxColumn
    Friend WithEvents damage_product As DataGridViewTextBoxColumn
    Friend WithEvents total_sale As DataGridViewTextBoxColumn
    Friend WithEvents total_purchase As DataGridViewTextBoxColumn
    Friend WithEvents available_products_value As DataGridViewTextBoxColumn
    Friend WithEvents available_product_market_value As DataGridViewTextBoxColumn
    Friend WithEvents total_given_discount As DataGridViewTextBoxColumn
    Friend WithEvents daily_debit_due As DataGridViewTextBoxColumn
    Friend WithEvents daily_credit_due As DataGridViewTextBoxColumn
    Friend WithEvents old_cash_balance As DataGridViewTextBoxColumn
    Friend WithEvents daily_revenue As DataGridViewTextBoxColumn
    Friend WithEvents earned_commission As DataGridViewTextBoxColumn
    Friend WithEvents delivery_expense As DataGridViewTextBoxColumn
End Class
