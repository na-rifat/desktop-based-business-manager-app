<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managePurchase
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
        Dim ProductNameLabel2 As System.Windows.Forms.Label
        Dim InvoiceNoLabel As System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblPurchaseInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPurchaseInvoiceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblPurchaseInvoiceTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductsTableAdapter()
        Me.TblPurchaseTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblPurchaseTableAdapter()
        Me.TblPurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblPurchaseInvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paymentmethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bankamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TblPurchaseDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.netPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.InvoiceNoTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TblProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProductNameLabel2 = New System.Windows.Forms.Label()
        InvoiceNoLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPurchaseInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblPurchaseInvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPurchaseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductNameLabel2
        '
        ProductNameLabel2.AutoSize = True
        ProductNameLabel2.Location = New System.Drawing.Point(121, 407)
        ProductNameLabel2.Name = "ProductNameLabel2"
        ProductNameLabel2.Size = New System.Drawing.Size(92, 13)
        ProductNameLabel2.TabIndex = 29
        ProductNameLabel2.Text = "product Name:"
        '
        'InvoiceNoLabel
        '
        InvoiceNoLabel.AutoSize = True
        InvoiceNoLabel.Location = New System.Drawing.Point(81, 248)
        InvoiceNoLabel.Name = "InvoiceNoLabel"
        InvoiceNoLabel.Size = New System.Drawing.Size(71, 13)
        InvoiceNoLabel.TabIndex = 30
        InvoiceNoLabel.Text = "invoice No:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton4, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 32)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 32)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 29)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"রশিদ নং", "চালান নং", "কোম্পানি", "তারিখ"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(150, 32)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 29)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton4.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(74, 28)
        Me.ToolStripButton4.Text = "ডিলিট"
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
        Me.Label1.Text = "ক্রয় সমূহ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.tblIncomeTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblNotesTableAdapter = Nothing
        Me.TableAdapterManager.tblNoticeTableAdapter = Nothing
        Me.TableAdapterManager.tblPCommissionTableAdapter = Nothing
        Me.TableAdapterManager.tblProductCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblProductsTableAdapter = Me.TblProductsTableAdapter
        Me.TableAdapterManager.tblProfitTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseInvoiceTableAdapter = Me.TblPurchaseInvoiceTableAdapter
        Me.TableAdapterManager.tblPurchaseReportTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseTableAdapter = Me.TblPurchaseTableAdapter
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
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'TblPurchaseTableAdapter
        '
        Me.TblPurchaseTableAdapter.ClearBeforeFill = True
        '
        'TblPurchaseBindingSource
        '
        Me.TblPurchaseBindingSource.DataMember = "tblPurchase"
        Me.TblPurchaseBindingSource.DataSource = Me.DataSet
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.DataSet
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TblPurchaseInvoiceDataGridView)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TblPurchaseDataGridView)
        Me.Panel1.Controls.Add(ProductNameLabel2)
        Me.Panel1.Controls.Add(Me.ProductNameTextBox)
        Me.Panel1.Controls.Add(InvoiceNoLabel)
        Me.Panel1.Controls.Add(Me.InvoiceNoTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 529)
        Me.Panel1.TabIndex = 18
        '
        'TblPurchaseInvoiceDataGridView
        '
        Me.TblPurchaseInvoiceDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblPurchaseInvoiceDataGridView.AutoGenerateColumns = False
        Me.TblPurchaseInvoiceDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblPurchaseInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPurchaseInvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.paymentmethod, Me.paid, Me.bankamount, Me.due, Me.DataGridViewTextBoxColumn6})
        Me.TblPurchaseInvoiceDataGridView.DataSource = Me.TblPurchaseInvoiceBindingSource
        Me.TblPurchaseInvoiceDataGridView.Location = New System.Drawing.Point(7, 40)
        Me.TblPurchaseInvoiceDataGridView.Name = "TblPurchaseInvoiceDataGridView"
        Me.TblPurchaseInvoiceDataGridView.Size = New System.Drawing.Size(449, 486)
        Me.TblPurchaseInvoiceDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "supplier"
        Me.DataGridViewTextBoxColumn2.HeaderText = "কোম্পানি"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "invoiceNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "রশিদ নং"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "companyInvoice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "চালান নং"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "totalAmount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "নিট মূল্য"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'paymentmethod
        '
        Me.paymentmethod.DataPropertyName = "paymentmethod"
        Me.paymentmethod.HeaderText = "পেমেন্টের পদ্ধতি"
        Me.paymentmethod.Name = "paymentmethod"
        '
        'paid
        '
        Me.paid.DataPropertyName = "paid"
        Me.paid.HeaderText = "ক্যাশে পরিশোধ"
        Me.paid.Name = "paid"
        '
        'bankamount
        '
        Me.bankamount.DataPropertyName = "bankamount"
        Me.bankamount.HeaderText = "ব্যাংকে পরিশোধ"
        Me.bankamount.Name = "bankamount"
        '
        'due
        '
        Me.due.DataPropertyName = "due"
        Me.due.HeaderText = "বাকি"
        Me.due.Name = "due"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(461, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 30)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "ক্রয়কৃত পণ্য"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(448, 30)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ক্রয় রশিদ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblPurchaseDataGridView
        '
        Me.TblPurchaseDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblPurchaseDataGridView.AutoGenerateColumns = False
        Me.TblPurchaseDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblPurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPurchaseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.quantity, Me.unitPrice, Me.netPrice, Me.productCode})
        Me.TblPurchaseDataGridView.DataSource = Me.TblPurchaseBindingSource
        Me.TblPurchaseDataGridView.Location = New System.Drawing.Point(461, 40)
        Me.TblPurchaseDataGridView.Name = "TblPurchaseDataGridView"
        Me.TblPurchaseDataGridView.Size = New System.Drawing.Size(512, 486)
        Me.TblPurchaseDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "productName"
        Me.DataGridViewTextBoxColumn9.HeaderText = "পণ্যর নাম"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'quantity
        '
        Me.quantity.DataPropertyName = "quantity"
        Me.quantity.HeaderText = "পরিমাণ"
        Me.quantity.Name = "quantity"
        Me.quantity.Width = 80
        '
        'unitPrice
        '
        Me.unitPrice.DataPropertyName = "unitPrice"
        Me.unitPrice.HeaderText = "দর"
        Me.unitPrice.Name = "unitPrice"
        Me.unitPrice.Width = 80
        '
        'netPrice
        '
        Me.netPrice.DataPropertyName = "netPrice"
        Me.netPrice.HeaderText = "দাম"
        Me.netPrice.Name = "netPrice"
        Me.netPrice.Width = 80
        '
        'productCode
        '
        Me.productCode.DataPropertyName = "productCode"
        Me.productCode.HeaderText = "productCode"
        Me.productCode.Name = "productCode"
        Me.productCode.Visible = False
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPurchaseBindingSource, "productName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(219, 404)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ProductNameTextBox.TabIndex = 30
        '
        'InvoiceNoTextBox
        '
        Me.InvoiceNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPurchaseInvoiceBindingSource, "invoiceNo", True))
        Me.InvoiceNoTextBox.Location = New System.Drawing.Point(184, 147)
        Me.InvoiceNoTextBox.Name = "InvoiceNoTextBox"
        Me.InvoiceNoTextBox.Size = New System.Drawing.Size(100, 21)
        Me.InvoiceNoTextBox.TabIndex = 31
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPurchaseInvoiceBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(19, 0)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(25, 21)
        Me.IdTextBox.TabIndex = 19
        '
        'TblProductsDataGridView
        '
        Me.TblProductsDataGridView.AutoGenerateColumns = False
        Me.TblProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16})
        Me.TblProductsDataGridView.DataSource = Me.TblProductsBindingSource
        Me.TblProductsDataGridView.Location = New System.Drawing.Point(3, 8)
        Me.TblProductsDataGridView.Name = "TblProductsDataGridView"
        Me.TblProductsDataGridView.Size = New System.Drawing.Size(120, 21)
        Me.TblProductsDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "available"
        Me.DataGridViewTextBoxColumn16.HeaderText = "available"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'managePurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.TblProductsDataGridView)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "managePurchase"
        Me.Text = "managePurchase"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPurchaseInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPurchaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblPurchaseInvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPurchaseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblPurchaseInvoiceBindingSource As BindingSource
    Friend WithEvents TblPurchaseInvoiceTableAdapter As dataSetTableAdapters.tblPurchaseInvoiceTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblPurchaseTableAdapter As dataSetTableAdapters.tblPurchaseTableAdapter
    Friend WithEvents TblPurchaseBindingSource As BindingSource
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As dataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TblPurchaseDataGridView As DataGridView
    Friend WithEvents TblPurchaseInvoiceDataGridView As DataGridView
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents InvoiceNoTextBox As TextBox
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents TblProductsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents paymentmethod As DataGridViewTextBoxColumn
    Friend WithEvents paid As DataGridViewTextBoxColumn
    Friend WithEvents bankamount As DataGridViewTextBoxColumn
    Friend WithEvents due As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents unitPrice As DataGridViewTextBoxColumn
    Friend WithEvents netPrice As DataGridViewTextBoxColumn
    Friend WithEvents productCode As DataGridViewTextBoxColumn
End Class
