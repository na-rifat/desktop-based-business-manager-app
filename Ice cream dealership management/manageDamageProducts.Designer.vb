<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageDamageProducts
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblDamageProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDamageProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblDamageProductsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblIncomeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblIncomeTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TblDamageProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoice_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TblIncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.IncomeCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeNoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IncomeSubcategoryTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.BankamountTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentmethodComboBox = New System.Windows.Forms.ComboBox()
        Me.Payment_remarkTextBox = New System.Windows.Forms.TextBox()
        Me.Invoice_noTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDamageProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TblDamageProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(148, 63)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 12
        IdLabel.Text = "Id:"
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
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ড্যামেজ প্রোডাক্টসমূহ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDamageProductsBindingSource
        '
        Me.TblDamageProductsBindingSource.DataMember = "tblDamageProducts"
        Me.TblDamageProductsBindingSource.DataSource = Me.DataSet
        '
        'TblDamageProductsTableAdapter
        '
        Me.TblDamageProductsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblDamageProductsTableAdapter = Me.TblDamageProductsTableAdapter
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
        'TblIncomeTableAdapter
        '
        Me.TblIncomeTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton2, Me.ToolStripButton1, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 32)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
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
        Me.txtFilter.Items.AddRange(New Object() {"পণ্যের নাম", "কোড", "ধরণ", "কোম্পানি", "ড্যামেজের তারিখ"})
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
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton2.Size = New System.Drawing.Size(78, 28)
        Me.ToolStripButton2.Text = "ডিলিট"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton1.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.f51220af0a9d200aba4b1574f3f34830_reload_icon_by_vexels
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton1.Size = New System.Drawing.Size(74, 28)
        Me.ToolStripButton1.Text = "রিটার্ন"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton3.Size = New System.Drawing.Size(67, 28)
        Me.ToolStripButton3.Text = "প্রিন্ট"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(178, 60)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IdTextBox.TabIndex = 13
        '
        'TblDamageProductsDataGridView
        '
        Me.TblDamageProductsDataGridView.AutoGenerateColumns = False
        Me.TblDamageProductsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblDamageProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblDamageProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.unit_price, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn12, Me.invoice_no, Me.Id})
        Me.TblDamageProductsDataGridView.DataSource = Me.TblDamageProductsBindingSource
        Me.TblDamageProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblDamageProductsDataGridView.Location = New System.Drawing.Point(0, 64)
        Me.TblDamageProductsDataGridView.Name = "TblDamageProductsDataGridView"
        Me.TblDamageProductsDataGridView.Size = New System.Drawing.Size(1000, 578)
        Me.TblDamageProductsDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "product_name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "পণ্যের নাম"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "product_code"
        Me.DataGridViewTextBoxColumn7.HeaderText = "কোড"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "product_category"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ধরন"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "company"
        Me.DataGridViewTextBoxColumn9.HeaderText = "কোম্পানি"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'unit_price
        '
        Me.unit_price.DataPropertyName = "unit_price"
        Me.unit_price.HeaderText = "দর"
        Me.unit_price.Name = "unit_price"
        Me.unit_price.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn13.HeaderText = "পরিমাণ"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "total_price"
        Me.DataGridViewTextBoxColumn15.HeaderText = "দাম"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "damage_date"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ড্যামেজের তারিখ"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'invoice_no
        '
        Me.invoice_no.DataPropertyName = "invoice_no"
        Me.invoice_no.HeaderText = "মন্তব্য"
        Me.invoice_no.Name = "invoice_no"
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 642)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(1000, 28)
        Me.tool.TabIndex = 82
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Padding = New System.Windows.Forms.Padding(4)
        Me.ToolStripLabel3.Size = New System.Drawing.Size(229, 25)
        Me.ToolStripLabel3.Text = "Total damage products value: "
        '
        'TblIncomeBindingSource
        '
        Me.TblIncomeBindingSource.DataMember = "tblIncome"
        Me.TblIncomeBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "Id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(942, 8)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(58, 21)
        Me.IdTextBox1.TabIndex = 83
        '
        'IncomeCategoryTextBox
        '
        Me.IncomeCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeCategory", True))
        Me.IncomeCategoryTextBox.Location = New System.Drawing.Point(942, 8)
        Me.IncomeCategoryTextBox.Name = "IncomeCategoryTextBox"
        Me.IncomeCategoryTextBox.Size = New System.Drawing.Size(58, 21)
        Me.IncomeCategoryTextBox.TabIndex = 85
        '
        'IncomeNoteTextBox
        '
        Me.IncomeNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeNote", True))
        Me.IncomeNoteTextBox.Location = New System.Drawing.Point(942, 8)
        Me.IncomeNoteTextBox.Name = "IncomeNoteTextBox"
        Me.IncomeNoteTextBox.Size = New System.Drawing.Size(58, 21)
        Me.IncomeNoteTextBox.TabIndex = 87
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(942, 8)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(58, 21)
        Me.AmountTextBox.TabIndex = 89
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblIncomeBindingSource, "date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(942, 8)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(58, 21)
        Me.DateDateTimePicker.TabIndex = 91
        '
        'IncomeSubcategoryTextBox
        '
        Me.IncomeSubcategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeSubcategory", True))
        Me.IncomeSubcategoryTextBox.Location = New System.Drawing.Point(942, 8)
        Me.IncomeSubcategoryTextBox.Name = "IncomeSubcategoryTextBox"
        Me.IncomeSubcategoryTextBox.Size = New System.Drawing.Size(58, 21)
        Me.IncomeSubcategoryTextBox.TabIndex = 93
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "accNo", True))
        Me.AccNoTextBox.Location = New System.Drawing.Point(942, 8)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(58, 21)
        Me.AccNoTextBox.TabIndex = 95
        '
        'BankamountTextBox
        '
        Me.BankamountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "bankamount", True))
        Me.BankamountTextBox.Location = New System.Drawing.Point(942, 8)
        Me.BankamountTextBox.Name = "BankamountTextBox"
        Me.BankamountTextBox.Size = New System.Drawing.Size(58, 21)
        Me.BankamountTextBox.TabIndex = 97
        '
        'PaymentmethodComboBox
        '
        Me.PaymentmethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "paymentmethod", True))
        Me.PaymentmethodComboBox.FormattingEnabled = True
        Me.PaymentmethodComboBox.Location = New System.Drawing.Point(942, 8)
        Me.PaymentmethodComboBox.Name = "PaymentmethodComboBox"
        Me.PaymentmethodComboBox.Size = New System.Drawing.Size(58, 21)
        Me.PaymentmethodComboBox.TabIndex = 99
        '
        'Payment_remarkTextBox
        '
        Me.Payment_remarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "payment_remark", True))
        Me.Payment_remarkTextBox.Location = New System.Drawing.Point(942, 8)
        Me.Payment_remarkTextBox.Name = "Payment_remarkTextBox"
        Me.Payment_remarkTextBox.Size = New System.Drawing.Size(58, 21)
        Me.Payment_remarkTextBox.TabIndex = 101
        '
        'Invoice_noTextBox
        '
        Me.Invoice_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "invoice_no", True))
        Me.Invoice_noTextBox.Location = New System.Drawing.Point(942, 8)
        Me.Invoice_noTextBox.Name = "Invoice_noTextBox"
        Me.Invoice_noTextBox.Size = New System.Drawing.Size(58, 21)
        Me.Invoice_noTextBox.TabIndex = 103
        '
        'manageDamageProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 670)
        Me.Controls.Add(Me.TblDamageProductsDataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.tool)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(Me.IncomeCategoryTextBox)
        Me.Controls.Add(Me.IncomeNoteTextBox)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.IncomeSubcategoryTextBox)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Controls.Add(Me.BankamountTextBox)
        Me.Controls.Add(Me.PaymentmethodComboBox)
        Me.Controls.Add(Me.Payment_remarkTextBox)
        Me.Controls.Add(Me.Invoice_noTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageDamageProducts"
        Me.Text = "manageDamageProducts"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDamageProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TblDamageProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblDamageProductsBindingSource As BindingSource
    Friend WithEvents TblDamageProductsTableAdapter As dataSetTableAdapters.tblDamageProductsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents TblDamageProductsDataGridView As DataGridView
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TblIncomeBindingSource As BindingSource
    Friend WithEvents TblIncomeTableAdapter As dataSetTableAdapters.tblIncomeTableAdapter
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents IncomeCategoryTextBox As TextBox
    Friend WithEvents IncomeNoteTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents IncomeSubcategoryTextBox As TextBox
    Friend WithEvents AccNoTextBox As TextBox
    Friend WithEvents BankamountTextBox As TextBox
    Friend WithEvents PaymentmethodComboBox As ComboBox
    Friend WithEvents Payment_remarkTextBox As TextBox
    Friend WithEvents Invoice_noTextBox As TextBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents unit_price As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents invoice_no As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
End Class
