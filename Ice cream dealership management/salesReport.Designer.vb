<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class salesReport
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
        Dim DateLabel As System.Windows.Forms.Label
        Dim SalesLabel As System.Windows.Forms.Label
        Dim PendingAmountLabel As System.Windows.Forms.Label
        Dim UnpaidInvoiceLabel As System.Windows.Forms.Label
        Dim GrandTotalLabel As System.Windows.Forms.Label
        Dim DueLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblSalesreportDataGridView = New System.Windows.Forms.DataGridView()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalsaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetsaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSalesreportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTextBox = New System.Windows.Forms.TextBox()
        Me.TblInvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.totalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.padi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnpaidInvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.PendingAmountTextBox = New System.Windows.Forms.TextBox()
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.GrandTotalTextBox = New System.Windows.Forms.TextBox()
        Me.PadiTextBox = New System.Windows.Forms.TextBox()
        Me.TblSalesreportTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblSalesreportTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblIncomeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblIncomeTableAdapter()
        Me.TblInvoiceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblInvoiceTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toDt = New System.Windows.Forms.DateTimePicker()
        Me.fromDt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TblIncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblIncomeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Total_saleTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.Net_saleTextBox = New System.Windows.Forms.TextBox()
        Me.Paid_amountTextBox = New System.Windows.Forms.TextBox()
        Me.DueTextBox1 = New System.Windows.Forms.TextBox()
        DateLabel = New System.Windows.Forms.Label()
        SalesLabel = New System.Windows.Forms.Label()
        PendingAmountLabel = New System.Windows.Forms.Label()
        UnpaidInvoiceLabel = New System.Windows.Forms.Label()
        GrandTotalLabel = New System.Windows.Forms.Label()
        DueLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblSalesreportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalesreportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        CType(Me.TblInvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncomeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(12, 12)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(37, 13)
        DateLabel.TabIndex = 35
        DateLabel.Text = "date:"
        '
        'SalesLabel
        '
        SalesLabel.AutoSize = True
        SalesLabel.Location = New System.Drawing.Point(12, 8)
        SalesLabel.Name = "SalesLabel"
        SalesLabel.Size = New System.Drawing.Size(41, 13)
        SalesLabel.TabIndex = 37
        SalesLabel.Text = "sales:"
        '
        'PendingAmountLabel
        '
        PendingAmountLabel.AutoSize = True
        PendingAmountLabel.Location = New System.Drawing.Point(12, 8)
        PendingAmountLabel.Name = "PendingAmountLabel"
        PendingAmountLabel.Size = New System.Drawing.Size(105, 13)
        PendingAmountLabel.TabIndex = 39
        PendingAmountLabel.Text = "pending Amount:"
        '
        'UnpaidInvoiceLabel
        '
        UnpaidInvoiceLabel.AutoSize = True
        UnpaidInvoiceLabel.Location = New System.Drawing.Point(12, 8)
        UnpaidInvoiceLabel.Name = "UnpaidInvoiceLabel"
        UnpaidInvoiceLabel.Size = New System.Drawing.Size(96, 13)
        UnpaidInvoiceLabel.TabIndex = 41
        UnpaidInvoiceLabel.Text = "unpaid Invoice:"
        '
        'GrandTotalLabel
        '
        GrandTotalLabel.AutoSize = True
        GrandTotalLabel.Location = New System.Drawing.Point(12, 8)
        GrandTotalLabel.Name = "GrandTotalLabel"
        GrandTotalLabel.Size = New System.Drawing.Size(76, 13)
        GrandTotalLabel.TabIndex = 42
        GrandTotalLabel.Text = "grand Total:"
        '
        'DueLabel
        '
        DueLabel.AutoSize = True
        DueLabel.Location = New System.Drawing.Point(12, 12)
        DueLabel.Name = "DueLabel"
        DueLabel.Size = New System.Drawing.Size(33, 13)
        DueLabel.TabIndex = 43
        DueLabel.Text = "due:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1008, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "বিক্রয় রিপোর্ট"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TblSalesreportDataGridView)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Location = New System.Drawing.Point(25, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(963, 521)
        Me.Panel1.TabIndex = 6
        '
        'TblSalesreportDataGridView
        '
        Me.TblSalesreportDataGridView.AutoGenerateColumns = False
        Me.TblSalesreportDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblSalesreportDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TblSalesreportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSalesreportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.TotalsaleDataGridViewTextBoxColumn, Me.DiscountDataGridViewTextBoxColumn, Me.NetsaleDataGridViewTextBoxColumn, Me.PaidamountDataGridViewTextBoxColumn, Me.DueDataGridViewTextBoxColumn})
        Me.TblSalesreportDataGridView.DataSource = Me.TblSalesreportBindingSource
        Me.TblSalesreportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblSalesreportDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblSalesreportDataGridView.Name = "TblSalesreportDataGridView"
        Me.TblSalesreportDataGridView.Size = New System.Drawing.Size(963, 496)
        Me.TblSalesreportDataGridView.TabIndex = 80
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "তারিখ"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'TotalsaleDataGridViewTextBoxColumn
        '
        Me.TotalsaleDataGridViewTextBoxColumn.DataPropertyName = "total_sale"
        Me.TotalsaleDataGridViewTextBoxColumn.HeaderText = "মোট বিক্রয়"
        Me.TotalsaleDataGridViewTextBoxColumn.Name = "TotalsaleDataGridViewTextBoxColumn"
        Me.TotalsaleDataGridViewTextBoxColumn.Width = 150
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "ডিসকাউন্ট"
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        Me.DiscountDataGridViewTextBoxColumn.Width = 150
        '
        'NetsaleDataGridViewTextBoxColumn
        '
        Me.NetsaleDataGridViewTextBoxColumn.DataPropertyName = "net_sale"
        Me.NetsaleDataGridViewTextBoxColumn.HeaderText = "নিট বিক্রয়"
        Me.NetsaleDataGridViewTextBoxColumn.Name = "NetsaleDataGridViewTextBoxColumn"
        Me.NetsaleDataGridViewTextBoxColumn.Width = 150
        '
        'PaidamountDataGridViewTextBoxColumn
        '
        Me.PaidamountDataGridViewTextBoxColumn.DataPropertyName = "paid_amount"
        Me.PaidamountDataGridViewTextBoxColumn.HeaderText = "আদায়"
        Me.PaidamountDataGridViewTextBoxColumn.Name = "PaidamountDataGridViewTextBoxColumn"
        Me.PaidamountDataGridViewTextBoxColumn.Width = 150
        '
        'DueDataGridViewTextBoxColumn
        '
        Me.DueDataGridViewTextBoxColumn.DataPropertyName = "due"
        Me.DueDataGridViewTextBoxColumn.HeaderText = "বাকি"
        Me.DueDataGridViewTextBoxColumn.Name = "DueDataGridViewTextBoxColumn"
        Me.DueDataGridViewTextBoxColumn.Width = 150
        '
        'TblSalesreportBindingSource
        '
        Me.TblSalesreportBindingSource.DataMember = "tblSalesreport"
        Me.TblSalesreportBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.ToolStripSeparator3, Me.ToolStripLabel5, Me.ToolStripSeparator4, Me.ToolStripLabel4})
        Me.tool.Location = New System.Drawing.Point(0, 496)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(963, 25)
        Me.tool.TabIndex = 79
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Due:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(101, 22)
        Me.ToolStripLabel2.Text = "Paid amount:"
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
        Me.ToolStripLabel3.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripLabel3.Text = "Net sale:"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel5.Text = "Discount:"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripLabel4.Text = "Total sale: "
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalesreportBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(12, 8)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(100, 21)
        Me.DateTextBox.TabIndex = 36
        '
        'SalesTextBox
        '
        Me.SalesTextBox.Location = New System.Drawing.Point(12, 8)
        Me.SalesTextBox.Name = "SalesTextBox"
        Me.SalesTextBox.Size = New System.Drawing.Size(100, 21)
        Me.SalesTextBox.TabIndex = 38
        '
        'TblInvoiceDataGridView
        '
        Me.TblInvoiceDataGridView.AutoGenerateColumns = False
        Me.TblInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.totalAmount, Me.discount, Me.DataGridViewTextBoxColumn11, Me.padi, Me.DataGridViewTextBoxColumn14})
        Me.TblInvoiceDataGridView.DataSource = Me.TblInvoiceBindingSource
        Me.TblInvoiceDataGridView.Location = New System.Drawing.Point(25, 8)
        Me.TblInvoiceDataGridView.Name = "TblInvoiceDataGridView"
        Me.TblInvoiceDataGridView.Size = New System.Drawing.Size(64, 15)
        Me.TblInvoiceDataGridView.TabIndex = 33
        '
        'totalAmount
        '
        Me.totalAmount.DataPropertyName = "totalAmount"
        Me.totalAmount.HeaderText = "totalAmount"
        Me.totalAmount.Name = "totalAmount"
        '
        'discount
        '
        Me.discount.DataPropertyName = "discount"
        Me.discount.HeaderText = "discount"
        Me.discount.Name = "discount"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "grandTotal"
        Me.DataGridViewTextBoxColumn11.HeaderText = "grandTotal"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'padi
        '
        Me.padi.DataPropertyName = "padi"
        Me.padi.HeaderText = "padi"
        Me.padi.Name = "padi"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn14.HeaderText = "due"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'TblInvoiceBindingSource
        '
        Me.TblInvoiceBindingSource.DataMember = "tblInvoice"
        Me.TblInvoiceBindingSource.DataSource = Me.DataSet
        '
        'UnpaidInvoiceTextBox
        '
        Me.UnpaidInvoiceTextBox.Location = New System.Drawing.Point(12, 8)
        Me.UnpaidInvoiceTextBox.Name = "UnpaidInvoiceTextBox"
        Me.UnpaidInvoiceTextBox.Size = New System.Drawing.Size(100, 21)
        Me.UnpaidInvoiceTextBox.TabIndex = 42
        '
        'PendingAmountTextBox
        '
        Me.PendingAmountTextBox.Location = New System.Drawing.Point(12, 8)
        Me.PendingAmountTextBox.Name = "PendingAmountTextBox"
        Me.PendingAmountTextBox.Size = New System.Drawing.Size(100, 21)
        Me.PendingAmountTextBox.TabIndex = 40
        '
        'DueTextBox
        '
        Me.DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "due", True))
        Me.DueTextBox.Location = New System.Drawing.Point(12, 8)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.Size = New System.Drawing.Size(100, 21)
        Me.DueTextBox.TabIndex = 44
        '
        'GrandTotalTextBox
        '
        Me.GrandTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "grandTotal", True))
        Me.GrandTotalTextBox.Location = New System.Drawing.Point(12, 8)
        Me.GrandTotalTextBox.Name = "GrandTotalTextBox"
        Me.GrandTotalTextBox.Size = New System.Drawing.Size(100, 21)
        Me.GrandTotalTextBox.TabIndex = 43
        '
        'PadiTextBox
        '
        Me.PadiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "padi", True))
        Me.PadiTextBox.Location = New System.Drawing.Point(12, 8)
        Me.PadiTextBox.Name = "PadiTextBox"
        Me.PadiTextBox.Size = New System.Drawing.Size(100, 21)
        Me.PadiTextBox.TabIndex = 45
        '
        'TblSalesreportTableAdapter
        '
        Me.TblSalesreportTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblIncomeCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeSubcategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeTableAdapter = Me.TblIncomeTableAdapter
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
        Me.TableAdapterManager.tblSalesreportTableAdapter = Me.TblSalesreportTableAdapter
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
        'TblIncomeTableAdapter
        '
        Me.TblIncomeTableAdapter.ClearBeforeFill = True
        '
        'TblInvoiceTableAdapter
        '
        Me.TblInvoiceTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.toDt)
        Me.Panel2.Controls.Add(Me.fromDt)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(308, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 55)
        Me.Panel2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(129, 27)
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
        Me.toDt.Location = New System.Drawing.Point(1, 27)
        Me.toDt.Name = "toDt"
        Me.toDt.Size = New System.Drawing.Size(127, 24)
        Me.toDt.TabIndex = 104
        '
        'fromDt
        '
        Me.fromDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.fromDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDt.Location = New System.Drawing.Point(1, 2)
        Me.fromDt.Name = "fromDt"
        Me.fromDt.Size = New System.Drawing.Size(127, 24)
        Me.fromDt.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(129, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "থেকে-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index11
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Location = New System.Drawing.Point(182, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 50)
        Me.Button4.TabIndex = 92
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(332, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 91
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(282, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 90
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(232, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 89
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TblIncomeBindingSource
        '
        Me.TblIncomeBindingSource.DataMember = "tblIncome"
        Me.TblIncomeBindingSource.DataSource = Me.DataSet
        '
        'TblIncomeDataGridView
        '
        Me.TblIncomeDataGridView.AutoGenerateColumns = False
        Me.TblIncomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblIncomeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn13})
        Me.TblIncomeDataGridView.DataSource = Me.TblIncomeBindingSource
        Me.TblIncomeDataGridView.Location = New System.Drawing.Point(15, 4)
        Me.TblIncomeDataGridView.Name = "TblIncomeDataGridView"
        Me.TblIncomeDataGridView.Size = New System.Drawing.Size(71, 17)
        Me.TblIncomeDataGridView.TabIndex = 45
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn8.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "bankamount"
        Me.DataGridViewTextBoxColumn13.HeaderText = "bankamount"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalesreportBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(15, 0)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(62, 21)
        Me.IdTextBox.TabIndex = 46
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblSalesreportBindingSource, "date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(15, 0)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(62, 21)
        Me.DateDateTimePicker.TabIndex = 48
        '
        'Total_saleTextBox
        '
        Me.Total_saleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalesreportBindingSource, "total_sale", True))
        Me.Total_saleTextBox.Location = New System.Drawing.Point(15, 0)
        Me.Total_saleTextBox.Name = "Total_saleTextBox"
        Me.Total_saleTextBox.Size = New System.Drawing.Size(62, 21)
        Me.Total_saleTextBox.TabIndex = 50
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalesreportBindingSource, "discount", True))
        Me.DiscountTextBox.Location = New System.Drawing.Point(15, 0)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(62, 21)
        Me.DiscountTextBox.TabIndex = 52
        '
        'Net_saleTextBox
        '
        Me.Net_saleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalesreportBindingSource, "net_sale", True))
        Me.Net_saleTextBox.Location = New System.Drawing.Point(15, 0)
        Me.Net_saleTextBox.Name = "Net_saleTextBox"
        Me.Net_saleTextBox.Size = New System.Drawing.Size(62, 21)
        Me.Net_saleTextBox.TabIndex = 54
        '
        'Paid_amountTextBox
        '
        Me.Paid_amountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalesreportBindingSource, "paid_amount", True))
        Me.Paid_amountTextBox.Location = New System.Drawing.Point(15, 0)
        Me.Paid_amountTextBox.Name = "Paid_amountTextBox"
        Me.Paid_amountTextBox.Size = New System.Drawing.Size(62, 21)
        Me.Paid_amountTextBox.TabIndex = 56
        '
        'DueTextBox1
        '
        Me.DueTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSalesreportBindingSource, "due", True))
        Me.DueTextBox1.Location = New System.Drawing.Point(15, 0)
        Me.DueTextBox1.Name = "DueTextBox1"
        Me.DueTextBox1.Size = New System.Drawing.Size(62, 21)
        Me.DueTextBox1.TabIndex = 58
        '
        'salesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 650)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.SalesTextBox)
        Me.Controls.Add(SalesLabel)
        Me.Controls.Add(Me.UnpaidInvoiceTextBox)
        Me.Controls.Add(Me.PadiTextBox)
        Me.Controls.Add(PendingAmountLabel)
        Me.Controls.Add(Me.GrandTotalTextBox)
        Me.Controls.Add(UnpaidInvoiceLabel)
        Me.Controls.Add(GrandTotalLabel)
        Me.Controls.Add(Me.PendingAmountTextBox)
        Me.Controls.Add(Me.DueTextBox)
        Me.Controls.Add(Me.TblInvoiceDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(DueLabel)
        Me.Controls.Add(Me.TblIncomeDataGridView)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.Total_saleTextBox)
        Me.Controls.Add(Me.DiscountTextBox)
        Me.Controls.Add(Me.Net_saleTextBox)
        Me.Controls.Add(Me.Paid_amountTextBox)
        Me.Controls.Add(Me.DueTextBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "salesReport"
        Me.Text = "salesReport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblSalesreportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalesreportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        CType(Me.TblInvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncomeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblSalesreportBindingSource As BindingSource
    Friend WithEvents TblSalesreportTableAdapter As dataSetTableAdapters.tblSalesreportTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblInvoiceBindingSource As BindingSource
    Friend WithEvents TblInvoiceTableAdapter As dataSetTableAdapters.tblInvoiceTableAdapter
    Friend WithEvents TblInvoiceDataGridView As DataGridView
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents SalesTextBox As TextBox
    Friend WithEvents PendingAmountTextBox As TextBox
    Friend WithEvents UnpaidInvoiceTextBox As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents GrandTotalTextBox As TextBox
    Friend WithEvents PadiTextBox As TextBox
    Friend WithEvents TblSalesreportDataGridView As DataGridView
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TblIncomeBindingSource As BindingSource
    Friend WithEvents TblIncomeTableAdapter As dataSetTableAdapters.tblIncomeTableAdapter
    Friend WithEvents TblIncomeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents Total_saleTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents Net_saleTextBox As TextBox
    Friend WithEvents Paid_amountTextBox As TextBox
    Friend WithEvents DueTextBox1 As TextBox
    Friend WithEvents totalAmount As DataGridViewTextBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents padi As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalsaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetsaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaidamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents toDt As DateTimePicker
    Friend WithEvents fromDt As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
