<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userRoles
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
        Dim OthersLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUserTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblUserTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblUserDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkFridge = New System.Windows.Forms.CheckBox()
        Me.chkIncome = New System.Windows.Forms.CheckBox()
        Me.chkPurchase = New System.Windows.Forms.CheckBox()
        Me.chkSales = New System.Windows.Forms.CheckBox()
        Me.chkProducts = New System.Windows.Forms.CheckBox()
        Me.chkOthers = New System.Windows.Forms.CheckBox()
        Me.chkReports = New System.Windows.Forms.CheckBox()
        Me.chkExpenses = New System.Windows.Forms.CheckBox()
        Me.chkTransaction = New System.Windows.Forms.CheckBox()
        Me.chkEmployee = New System.Windows.Forms.CheckBox()
        Me.ProductsTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaseTextBox = New System.Windows.Forms.TextBox()
        Me.SuppliersTextBox = New System.Windows.Forms.TextBox()
        Me.BankTransactionTextBox = New System.Windows.Forms.TextBox()
        Me.ExpensesTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.EmplpoyeeTextBox = New System.Windows.Forms.TextBox()
        Me.ReportsNdateTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeTextBox = New System.Windows.Forms.TextBox()
        Me.DamageProductsTextBox = New System.Windows.Forms.TextBox()
        Me.DsahBoardTextBox = New System.Windows.Forms.TextBox()
        Me.chkSuppliers = New System.Windows.Forms.CheckBox()
        Me.OthersTextBox = New System.Windows.Forms.TextBox()
        OthersLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OthersLabel
        '
        OthersLabel.AutoSize = True
        OthersLabel.Location = New System.Drawing.Point(264, 463)
        OthersLabel.Name = "OthersLabel"
        OthersLabel.Size = New System.Drawing.Size(48, 13)
        OthersLabel.TabIndex = 75
        OthersLabel.Text = "others:"
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
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ইউজার একাউন্ট"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 28)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ডিলিট"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(291, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 25)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.AutoCompleteCustomSource.AddRange(New String() {"Supplier name", "Supplier ID", "Purchase invoice", "Date"})
        Me.txtFilter.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"User name", "User ID", "Address", "Phone"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(174, 28)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 25)
        Me.ToolStripLabel1.Text = "সার্চের ধরণ"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(75, 24)
        Me.ToolStripButton2.Text = "Delete"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblUserBindingSource
        '
        Me.TblUserBindingSource.DataMember = "tblUser"
        Me.TblUserBindingSource.DataSource = Me.DataSet
        '
        'TblUserTableAdapter
        '
        Me.TblUserTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblUserTableAdapter = Me.TblUserTableAdapter
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblUserDataGridView
        '
        Me.TblUserDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblUserDataGridView.AutoGenerateColumns = False
        Me.TblUserDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblUserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn20})
        Me.TblUserDataGridView.DataSource = Me.TblUserBindingSource
        Me.TblUserDataGridView.Location = New System.Drawing.Point(0, 290)
        Me.TblUserDataGridView.Name = "TblUserDataGridView"
        Me.TblUserDataGridView.Size = New System.Drawing.Size(1000, 360)
        Me.TblUserDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "userName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "User name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "userID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "role"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Role/Post"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "remark"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Remark"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkFridge)
        Me.GroupBox1.Controls.Add(Me.chkIncome)
        Me.GroupBox1.Controls.Add(Me.chkPurchase)
        Me.GroupBox1.Controls.Add(Me.chkSales)
        Me.GroupBox1.Controls.Add(Me.chkProducts)
        Me.GroupBox1.Controls.Add(Me.chkOthers)
        Me.GroupBox1.Controls.Add(Me.chkReports)
        Me.GroupBox1.Controls.Add(Me.chkExpenses)
        Me.GroupBox1.Controls.Add(Me.chkTransaction)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(275, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 200)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Access permission"
        '
        'chkFridge
        '
        Me.chkFridge.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkFridge.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkFridge.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkFridge.Location = New System.Drawing.Point(22, 122)
        Me.chkFridge.Name = "chkFridge"
        Me.chkFridge.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.chkFridge.Size = New System.Drawing.Size(200, 30)
        Me.chkFridge.TabIndex = 69
        Me.chkFridge.Text = "Fridge"
        Me.chkFridge.UseVisualStyleBackColor = False
        '
        'chkIncome
        '
        Me.chkIncome.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkIncome.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkIncome.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkIncome.Location = New System.Drawing.Point(22, 153)
        Me.chkIncome.Name = "chkIncome"
        Me.chkIncome.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.chkIncome.Size = New System.Drawing.Size(200, 30)
        Me.chkIncome.TabIndex = 66
        Me.chkIncome.Text = "Income"
        Me.chkIncome.UseVisualStyleBackColor = False
        '
        'chkPurchase
        '
        Me.chkPurchase.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkPurchase.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkPurchase.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkPurchase.Location = New System.Drawing.Point(22, 60)
        Me.chkPurchase.Name = "chkPurchase"
        Me.chkPurchase.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.chkPurchase.Size = New System.Drawing.Size(200, 30)
        Me.chkPurchase.TabIndex = 62
        Me.chkPurchase.Text = "Purchase"
        Me.chkPurchase.UseVisualStyleBackColor = False
        '
        'chkSales
        '
        Me.chkSales.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkSales.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkSales.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkSales.Location = New System.Drawing.Point(22, 91)
        Me.chkSales.Name = "chkSales"
        Me.chkSales.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.chkSales.Size = New System.Drawing.Size(200, 30)
        Me.chkSales.TabIndex = 61
        Me.chkSales.Text = "Sales"
        Me.chkSales.UseVisualStyleBackColor = False
        '
        'chkProducts
        '
        Me.chkProducts.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkProducts.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkProducts.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkProducts.Location = New System.Drawing.Point(22, 29)
        Me.chkProducts.Name = "chkProducts"
        Me.chkProducts.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.chkProducts.Size = New System.Drawing.Size(200, 30)
        Me.chkProducts.TabIndex = 60
        Me.chkProducts.Text = "Products"
        Me.chkProducts.UseVisualStyleBackColor = False
        '
        'chkOthers
        '
        Me.chkOthers.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkOthers.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkOthers.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkOthers.Location = New System.Drawing.Point(228, 122)
        Me.chkOthers.Name = "chkOthers"
        Me.chkOthers.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.chkOthers.Size = New System.Drawing.Size(200, 30)
        Me.chkOthers.TabIndex = 72
        Me.chkOthers.Text = "Others"
        Me.chkOthers.UseVisualStyleBackColor = False
        '
        'chkReports
        '
        Me.chkReports.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkReports.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkReports.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkReports.Location = New System.Drawing.Point(228, 91)
        Me.chkReports.Name = "chkReports"
        Me.chkReports.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.chkReports.Size = New System.Drawing.Size(200, 30)
        Me.chkReports.TabIndex = 68
        Me.chkReports.Text = "Reports and data"
        Me.chkReports.UseVisualStyleBackColor = False
        '
        'chkExpenses
        '
        Me.chkExpenses.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkExpenses.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkExpenses.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkExpenses.Location = New System.Drawing.Point(228, 29)
        Me.chkExpenses.Name = "chkExpenses"
        Me.chkExpenses.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.chkExpenses.Size = New System.Drawing.Size(200, 30)
        Me.chkExpenses.TabIndex = 65
        Me.chkExpenses.Text = "Expenses"
        Me.chkExpenses.UseVisualStyleBackColor = False
        '
        'chkTransaction
        '
        Me.chkTransaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkTransaction.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkTransaction.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkTransaction.Location = New System.Drawing.Point(228, 60)
        Me.chkTransaction.Name = "chkTransaction"
        Me.chkTransaction.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.chkTransaction.Size = New System.Drawing.Size(200, 30)
        Me.chkTransaction.TabIndex = 64
        Me.chkTransaction.Text = "Bank transaction"
        Me.chkTransaction.UseVisualStyleBackColor = False
        '
        'chkEmployee
        '
        Me.chkEmployee.AutoSize = True
        Me.chkEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkEmployee.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkEmployee.Location = New System.Drawing.Point(293, 378)
        Me.chkEmployee.Name = "chkEmployee"
        Me.chkEmployee.Padding = New System.Windows.Forms.Padding(5)
        Me.chkEmployee.Size = New System.Drawing.Size(143, 37)
        Me.chkEmployee.TabIndex = 67
        Me.chkEmployee.Text = "Employee"
        Me.chkEmployee.UseVisualStyleBackColor = False
        '
        'ProductsTextBox
        '
        Me.ProductsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "products", True))
        Me.ProductsTextBox.Location = New System.Drawing.Point(726, 483)
        Me.ProductsTextBox.Name = "ProductsTextBox"
        Me.ProductsTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ProductsTextBox.TabIndex = 64
        '
        'SalesTextBox
        '
        Me.SalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "sales", True))
        Me.SalesTextBox.Location = New System.Drawing.Point(726, 483)
        Me.SalesTextBox.Name = "SalesTextBox"
        Me.SalesTextBox.Size = New System.Drawing.Size(100, 21)
        Me.SalesTextBox.TabIndex = 65
        '
        'PurchaseTextBox
        '
        Me.PurchaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "purchase", True))
        Me.PurchaseTextBox.Location = New System.Drawing.Point(726, 483)
        Me.PurchaseTextBox.Name = "PurchaseTextBox"
        Me.PurchaseTextBox.Size = New System.Drawing.Size(100, 21)
        Me.PurchaseTextBox.TabIndex = 66
        '
        'SuppliersTextBox
        '
        Me.SuppliersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "suppliers", True))
        Me.SuppliersTextBox.Location = New System.Drawing.Point(726, 483)
        Me.SuppliersTextBox.Name = "SuppliersTextBox"
        Me.SuppliersTextBox.Size = New System.Drawing.Size(100, 21)
        Me.SuppliersTextBox.TabIndex = 67
        '
        'BankTransactionTextBox
        '
        Me.BankTransactionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "bankTransaction", True))
        Me.BankTransactionTextBox.Location = New System.Drawing.Point(726, 483)
        Me.BankTransactionTextBox.Name = "BankTransactionTextBox"
        Me.BankTransactionTextBox.Size = New System.Drawing.Size(100, 21)
        Me.BankTransactionTextBox.TabIndex = 68
        '
        'ExpensesTextBox
        '
        Me.ExpensesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "expenses", True))
        Me.ExpensesTextBox.Location = New System.Drawing.Point(726, 483)
        Me.ExpensesTextBox.Name = "ExpensesTextBox"
        Me.ExpensesTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ExpensesTextBox.TabIndex = 69
        '
        'IncomeTextBox
        '
        Me.IncomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "income", True))
        Me.IncomeTextBox.Location = New System.Drawing.Point(726, 483)
        Me.IncomeTextBox.Name = "IncomeTextBox"
        Me.IncomeTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IncomeTextBox.TabIndex = 70
        '
        'EmplpoyeeTextBox
        '
        Me.EmplpoyeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "emplpoyee", True))
        Me.EmplpoyeeTextBox.Location = New System.Drawing.Point(726, 483)
        Me.EmplpoyeeTextBox.Name = "EmplpoyeeTextBox"
        Me.EmplpoyeeTextBox.Size = New System.Drawing.Size(100, 21)
        Me.EmplpoyeeTextBox.TabIndex = 71
        '
        'ReportsNdateTextBox
        '
        Me.ReportsNdateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "reportsNdate", True))
        Me.ReportsNdateTextBox.Location = New System.Drawing.Point(726, 483)
        Me.ReportsNdateTextBox.Name = "ReportsNdateTextBox"
        Me.ReportsNdateTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ReportsNdateTextBox.TabIndex = 72
        '
        'FridgeTextBox
        '
        Me.FridgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "fridge", True))
        Me.FridgeTextBox.Location = New System.Drawing.Point(726, 483)
        Me.FridgeTextBox.Name = "FridgeTextBox"
        Me.FridgeTextBox.Size = New System.Drawing.Size(100, 21)
        Me.FridgeTextBox.TabIndex = 73
        '
        'DamageProductsTextBox
        '
        Me.DamageProductsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "damageProducts", True))
        Me.DamageProductsTextBox.Location = New System.Drawing.Point(726, 483)
        Me.DamageProductsTextBox.Name = "DamageProductsTextBox"
        Me.DamageProductsTextBox.Size = New System.Drawing.Size(100, 21)
        Me.DamageProductsTextBox.TabIndex = 74
        '
        'DsahBoardTextBox
        '
        Me.DsahBoardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "dsahBoard", True))
        Me.DsahBoardTextBox.Location = New System.Drawing.Point(726, 483)
        Me.DsahBoardTextBox.Name = "DsahBoardTextBox"
        Me.DsahBoardTextBox.Size = New System.Drawing.Size(100, 21)
        Me.DsahBoardTextBox.TabIndex = 75
        '
        'chkSuppliers
        '
        Me.chkSuppliers.AutoSize = True
        Me.chkSuppliers.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkSuppliers.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSuppliers.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkSuppliers.Location = New System.Drawing.Point(145, 400)
        Me.chkSuppliers.Name = "chkSuppliers"
        Me.chkSuppliers.Padding = New System.Windows.Forms.Padding(5)
        Me.chkSuppliers.Size = New System.Drawing.Size(147, 37)
        Me.chkSuppliers.TabIndex = 63
        Me.chkSuppliers.Text = "Supplliers"
        Me.chkSuppliers.UseVisualStyleBackColor = False
        '
        'OthersTextBox
        '
        Me.OthersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "others", True))
        Me.OthersTextBox.Location = New System.Drawing.Point(318, 460)
        Me.OthersTextBox.Name = "OthersTextBox"
        Me.OthersTextBox.Size = New System.Drawing.Size(100, 21)
        Me.OthersTextBox.TabIndex = 76
        '
        'userRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TblUserDataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DamageProductsTextBox)
        Me.Controls.Add(Me.chkEmployee)
        Me.Controls.Add(Me.DsahBoardTextBox)
        Me.Controls.Add(Me.FridgeTextBox)
        Me.Controls.Add(Me.ReportsNdateTextBox)
        Me.Controls.Add(Me.EmplpoyeeTextBox)
        Me.Controls.Add(Me.chkSuppliers)
        Me.Controls.Add(Me.IncomeTextBox)
        Me.Controls.Add(Me.ExpensesTextBox)
        Me.Controls.Add(Me.BankTransactionTextBox)
        Me.Controls.Add(Me.SuppliersTextBox)
        Me.Controls.Add(Me.PurchaseTextBox)
        Me.Controls.Add(Me.SalesTextBox)
        Me.Controls.Add(Me.ProductsTextBox)
        Me.Controls.Add(OthersLabel)
        Me.Controls.Add(Me.OthersTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userRoles"
        Me.Text = "userRoles"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblUserBindingSource As BindingSource
    Friend WithEvents TblUserTableAdapter As dataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblUserDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkFridge As CheckBox
    Friend WithEvents chkReports As CheckBox
    Friend WithEvents chkEmployee As CheckBox
    Friend WithEvents chkIncome As CheckBox
    Friend WithEvents chkExpenses As CheckBox
    Friend WithEvents chkTransaction As CheckBox
    Friend WithEvents chkPurchase As CheckBox
    Friend WithEvents chkSales As CheckBox
    Friend WithEvents chkProducts As CheckBox
    Friend WithEvents ProductsTextBox As TextBox
    Friend WithEvents SalesTextBox As TextBox
    Friend WithEvents PurchaseTextBox As TextBox
    Friend WithEvents SuppliersTextBox As TextBox
    Friend WithEvents BankTransactionTextBox As TextBox
    Friend WithEvents ExpensesTextBox As TextBox
    Friend WithEvents IncomeTextBox As TextBox
    Friend WithEvents EmplpoyeeTextBox As TextBox
    Friend WithEvents ReportsNdateTextBox As TextBox
    Friend WithEvents FridgeTextBox As TextBox
    Friend WithEvents DamageProductsTextBox As TextBox
    Friend WithEvents DsahBoardTextBox As TextBox
    Friend WithEvents chkOthers As CheckBox
    Friend WithEvents chkSuppliers As CheckBox
    Friend WithEvents OthersTextBox As TextBox
End Class
