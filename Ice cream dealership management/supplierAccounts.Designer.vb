<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class supplierAccounts
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblSupplierAccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSupplierAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.TblSupplierAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblSupplierAccountsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblExpensesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpensesTableAdapter()
        Me.TblPurchaseInvoiceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblPurchaseInvoiceTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TblPurchaseInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaidTextBox = New System.Windows.Forms.TextBox()
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.PaidTextBox1 = New System.Windows.Forms.TextBox()
        Me.DueTextBox1 = New System.Windows.Forms.TextBox()
        Me.PurchaseInvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.BankamountTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseNoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.PersonNameTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseSubCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.BankamountTextBox1 = New System.Windows.Forms.TextBox()
        Me.PaymentMethodComboBox = New System.Windows.Forms.ComboBox()
        Me.Payment_remarkTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toDt = New System.Windows.Forms.DateTimePicker()
        Me.fromDt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSupplierAccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSupplierAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tool.SuspendLayout()
        CType(Me.TblPurchaseInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton4, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 37)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(1, 4, 1, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(291, 29)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 34)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.AutoCompleteCustomSource.AddRange(New String() {"Supplier name", "Supplier ID", "Purchase invoice", "Date"})
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"কোম্পানির নাম", "আই.ডি.", "ক্রয়ের রশিদ নং"})
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(1, 4, 1, 4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(174, 29)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 34)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton4.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.SteelBlue
        Me.ToolStripButton4.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.money_sign_button1
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(121, 33)
        Me.ToolStripButton4.Text = "দায় পরিশোধ"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(74, 33)
        Me.ToolStripButton2.Text = "ডিলিট"
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
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "কোম্পানির হিসাব সমূহ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSupplierAccountsDataGridView
        '
        Me.TblSupplierAccountsDataGridView.AutoGenerateColumns = False
        Me.TblSupplierAccountsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblSupplierAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSupplierAccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblSupplierAccountsDataGridView.DataSource = Me.TblSupplierAccountsBindingSource
        Me.TblSupplierAccountsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblSupplierAccountsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblSupplierAccountsDataGridView.Name = "TblSupplierAccountsDataGridView"
        Me.TblSupplierAccountsDataGridView.Size = New System.Drawing.Size(924, 436)
        Me.TblSupplierAccountsDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "supplierName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "কোম্পানির নাম"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "supplierID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "আই.ডি."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "purchaseInvoice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ক্রয় রশিদ নং"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "payment"
        Me.DataGridViewTextBoxColumn5.HeaderText = "অর্থের পরিমাণ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "paid"
        Me.DataGridViewTextBoxColumn6.HeaderText = "পরিশোধ"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn7.HeaderText = "বাকি"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TblSupplierAccountsBindingSource
        '
        Me.TblSupplierAccountsBindingSource.DataMember = "tblSupplierAccounts"
        Me.TblSupplierAccountsBindingSource.DataSource = Me.DataSet
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TblSupplierAccountsDataGridView)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Location = New System.Drawing.Point(38, 141)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 461)
        Me.Panel1.TabIndex = 14
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator1, Me.ToolStripLabel4, Me.ToolStripSeparator2, Me.ToolStripLabel5})
        Me.tool.Location = New System.Drawing.Point(0, 436)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(924, 25)
        Me.tool.TabIndex = 80
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel3.Text = "Due: "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel4.Text = "Paid: "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripLabel5.Text = "Total payment: "
        '
        'TblSupplierAccountsTableAdapter
        '
        Me.TblSupplierAccountsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblExpensesTableAdapter = Me.TblExpensesTableAdapter
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
        Me.TableAdapterManager.tblPurchaseInvoiceTableAdapter = Me.TblPurchaseInvoiceTableAdapter
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
        Me.TableAdapterManager.tblSupplierAccountsTableAdapter = Me.TblSupplierAccountsTableAdapter
        Me.TableAdapterManager.tblSuppliersTableAdapter = Nothing
        Me.TableAdapterManager.tblTransactionReportTableAdapter = Nothing
        Me.TableAdapterManager.tblTransactionTableAdapter = Nothing
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblExpensesTableAdapter
        '
        Me.TblExpensesTableAdapter.ClearBeforeFill = True
        '
        'TblPurchaseInvoiceTableAdapter
        '
        Me.TblPurchaseInvoiceTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(225, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 61
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(280, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 62
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TblPurchaseInvoiceBindingSource
        '
        Me.TblPurchaseInvoiceBindingSource.DataMember = "tblPurchaseInvoice"
        Me.TblPurchaseInvoiceBindingSource.DataSource = Me.DataSet
        '
        'PaidTextBox
        '
        Me.PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPurchaseInvoiceBindingSource, "paid", True))
        Me.PaidTextBox.Location = New System.Drawing.Point(126, 12)
        Me.PaidTextBox.Name = "PaidTextBox"
        Me.PaidTextBox.Size = New System.Drawing.Size(33, 21)
        Me.PaidTextBox.TabIndex = 63
        '
        'DueTextBox
        '
        Me.DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPurchaseInvoiceBindingSource, "due", True))
        Me.DueTextBox.Location = New System.Drawing.Point(126, 12)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.Size = New System.Drawing.Size(33, 21)
        Me.DueTextBox.TabIndex = 64
        '
        'PaidTextBox1
        '
        Me.PaidTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "paid", True))
        Me.PaidTextBox1.Location = New System.Drawing.Point(126, 12)
        Me.PaidTextBox1.Name = "PaidTextBox1"
        Me.PaidTextBox1.Size = New System.Drawing.Size(33, 21)
        Me.PaidTextBox1.TabIndex = 65
        '
        'DueTextBox1
        '
        Me.DueTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "due", True))
        Me.DueTextBox1.Location = New System.Drawing.Point(126, 12)
        Me.DueTextBox1.Name = "DueTextBox1"
        Me.DueTextBox1.Size = New System.Drawing.Size(33, 21)
        Me.DueTextBox1.TabIndex = 66
        '
        'PurchaseInvoiceTextBox
        '
        Me.PurchaseInvoiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "purchaseInvoice", True))
        Me.PurchaseInvoiceTextBox.Location = New System.Drawing.Point(126, 12)
        Me.PurchaseInvoiceTextBox.Name = "PurchaseInvoiceTextBox"
        Me.PurchaseInvoiceTextBox.Size = New System.Drawing.Size(33, 21)
        Me.PurchaseInvoiceTextBox.TabIndex = 67
        '
        'BankamountTextBox
        '
        Me.BankamountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPurchaseInvoiceBindingSource, "bankamount", True))
        Me.BankamountTextBox.Location = New System.Drawing.Point(126, 12)
        Me.BankamountTextBox.Name = "BankamountTextBox"
        Me.BankamountTextBox.Size = New System.Drawing.Size(33, 21)
        Me.BankamountTextBox.TabIndex = 68
        '
        'SupplierNameTextBox
        '
        Me.SupplierNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "supplierName", True))
        Me.SupplierNameTextBox.Location = New System.Drawing.Point(126, 12)
        Me.SupplierNameTextBox.Name = "SupplierNameTextBox"
        Me.SupplierNameTextBox.Size = New System.Drawing.Size(33, 21)
        Me.SupplierNameTextBox.TabIndex = 69
        '
        'TblExpensesBindingSource
        '
        Me.TblExpensesBindingSource.DataMember = "tblExpenses"
        Me.TblExpensesBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(861, 12)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(14, 21)
        Me.IdTextBox.TabIndex = 70
        '
        'ExpenseCategoryTextBox
        '
        Me.ExpenseCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseCategory", True))
        Me.ExpenseCategoryTextBox.Location = New System.Drawing.Point(861, 12)
        Me.ExpenseCategoryTextBox.Name = "ExpenseCategoryTextBox"
        Me.ExpenseCategoryTextBox.Size = New System.Drawing.Size(14, 21)
        Me.ExpenseCategoryTextBox.TabIndex = 72
        '
        'ExpenseNoteTextBox
        '
        Me.ExpenseNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseNote", True))
        Me.ExpenseNoteTextBox.Location = New System.Drawing.Point(861, 12)
        Me.ExpenseNoteTextBox.Name = "ExpenseNoteTextBox"
        Me.ExpenseNoteTextBox.Size = New System.Drawing.Size(14, 21)
        Me.ExpenseNoteTextBox.TabIndex = 74
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(861, 12)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(14, 21)
        Me.AmountTextBox.TabIndex = 76
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(861, 12)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(14, 21)
        Me.DateTextBox.TabIndex = 78
        '
        'PersonNameTextBox
        '
        Me.PersonNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "personName", True))
        Me.PersonNameTextBox.Location = New System.Drawing.Point(861, 12)
        Me.PersonNameTextBox.Name = "PersonNameTextBox"
        Me.PersonNameTextBox.Size = New System.Drawing.Size(14, 21)
        Me.PersonNameTextBox.TabIndex = 80
        '
        'ExpenseSubCategoryTextBox
        '
        Me.ExpenseSubCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseSubCategory", True))
        Me.ExpenseSubCategoryTextBox.Location = New System.Drawing.Point(861, 12)
        Me.ExpenseSubCategoryTextBox.Name = "ExpenseSubCategoryTextBox"
        Me.ExpenseSubCategoryTextBox.Size = New System.Drawing.Size(14, 21)
        Me.ExpenseSubCategoryTextBox.TabIndex = 82
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "accNo", True))
        Me.AccNoTextBox.Location = New System.Drawing.Point(861, 12)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(14, 21)
        Me.AccNoTextBox.TabIndex = 84
        '
        'BankamountTextBox1
        '
        Me.BankamountTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "bankamount", True))
        Me.BankamountTextBox1.Location = New System.Drawing.Point(861, 12)
        Me.BankamountTextBox1.Name = "BankamountTextBox1"
        Me.BankamountTextBox1.Size = New System.Drawing.Size(14, 21)
        Me.BankamountTextBox1.TabIndex = 86
        '
        'PaymentMethodComboBox
        '
        Me.PaymentMethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "paymentMethod", True))
        Me.PaymentMethodComboBox.FormattingEnabled = True
        Me.PaymentMethodComboBox.Location = New System.Drawing.Point(861, 12)
        Me.PaymentMethodComboBox.Name = "PaymentMethodComboBox"
        Me.PaymentMethodComboBox.Size = New System.Drawing.Size(14, 21)
        Me.PaymentMethodComboBox.TabIndex = 88
        '
        'Payment_remarkTextBox
        '
        Me.Payment_remarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "payment_remark", True))
        Me.Payment_remarkTextBox.Location = New System.Drawing.Point(861, 12)
        Me.Payment_remarkTextBox.Name = "Payment_remarkTextBox"
        Me.Payment_remarkTextBox.Size = New System.Drawing.Size(14, 21)
        Me.Payment_remarkTextBox.TabIndex = 90
        '
        'SupplierNameTextBox1
        '
        Me.SupplierNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "supplierName", True))
        Me.SupplierNameTextBox1.Location = New System.Drawing.Point(0, 12)
        Me.SupplierNameTextBox1.Name = "SupplierNameTextBox1"
        Me.SupplierNameTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.SupplierNameTextBox1.TabIndex = 91
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "supplierID", True))
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(0, 12)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.SupplierIDTextBox.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(166, 111)
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
        Me.toDt.Location = New System.Drawing.Point(38, 111)
        Me.toDt.Name = "toDt"
        Me.toDt.Size = New System.Drawing.Size(127, 24)
        Me.toDt.TabIndex = 104
        '
        'fromDt
        '
        Me.fromDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.fromDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDt.Location = New System.Drawing.Point(38, 86)
        Me.fromDt.Name = "fromDt"
        Me.fromDt.Size = New System.Drawing.Size(127, 24)
        Me.fromDt.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(166, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "থেকে-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'supplierAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.toDt)
        Me.Controls.Add(Me.fromDt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SupplierNameTextBox)
        Me.Controls.Add(Me.BankamountTextBox)
        Me.Controls.Add(Me.PurchaseInvoiceTextBox)
        Me.Controls.Add(Me.DueTextBox1)
        Me.Controls.Add(Me.PaidTextBox1)
        Me.Controls.Add(Me.DueTextBox)
        Me.Controls.Add(Me.PaidTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.ExpenseCategoryTextBox)
        Me.Controls.Add(Me.ExpenseNoteTextBox)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.PersonNameTextBox)
        Me.Controls.Add(Me.ExpenseSubCategoryTextBox)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Controls.Add(Me.BankamountTextBox1)
        Me.Controls.Add(Me.PaymentMethodComboBox)
        Me.Controls.Add(Me.Payment_remarkTextBox)
        Me.Controls.Add(Me.SupplierIDTextBox)
        Me.Controls.Add(Me.SupplierNameTextBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "supplierAccounts"
        Me.Text = "p"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSupplierAccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSupplierAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        CType(Me.TblPurchaseInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TblSupplierAccountsBindingSource As BindingSource
    Friend WithEvents TblSupplierAccountsDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TblSupplierAccountsTableAdapter As dataSetTableAdapters.tblSupplierAccountsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As Button
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents TblPurchaseInvoiceBindingSource As BindingSource
    Friend WithEvents TblPurchaseInvoiceTableAdapter As dataSetTableAdapters.tblPurchaseInvoiceTableAdapter
    Friend WithEvents PaidTextBox As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents PaidTextBox1 As TextBox
    Friend WithEvents DueTextBox1 As TextBox
    Friend WithEvents PurchaseInvoiceTextBox As TextBox
    Friend WithEvents BankamountTextBox As TextBox
    Friend WithEvents SupplierNameTextBox As TextBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents TblExpensesBindingSource As BindingSource
    Friend WithEvents TblExpensesTableAdapter As dataSetTableAdapters.tblExpensesTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ExpenseCategoryTextBox As TextBox
    Friend WithEvents ExpenseNoteTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents PersonNameTextBox As TextBox
    Friend WithEvents ExpenseSubCategoryTextBox As TextBox
    Friend WithEvents AccNoTextBox As TextBox
    Friend WithEvents BankamountTextBox1 As TextBox
    Friend WithEvents PaymentMethodComboBox As ComboBox
    Friend WithEvents Payment_remarkTextBox As TextBox
    Friend WithEvents SupplierNameTextBox1 As TextBox
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents toDt As DateTimePicker
    Friend WithEvents fromDt As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
