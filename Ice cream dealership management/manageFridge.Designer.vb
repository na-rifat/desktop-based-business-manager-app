<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageFridge
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
        Dim SecurityMoneyLabel As System.Windows.Forms.Label
        Dim MonthlyRentLabel As System.Windows.Forms.Label
        Dim CompanyRentLabel As System.Windows.Forms.Label
        Dim CompanySecurityMoneyLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim FridgeIDLabel As System.Windows.Forms.Label
        Dim RentTOLabel As System.Windows.Forms.Label
        Dim FridgeModelNoLabel As System.Windows.Forms.Label
        Dim SupplierNameLabel As System.Windows.Forms.Label
        Dim RentTOLabel2 As System.Windows.Forms.Label
        Dim RentedToIDLabel As System.Windows.Forms.Label
        Dim RentedAtLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblFridgesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblFridgesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblFridgesTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblFridgesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RentTOLabel1 = New System.Windows.Forms.Label()
        Me.CompanySecurityMoneyLabel1 = New System.Windows.Forms.Label()
        Me.CompanyRentLabel1 = New System.Windows.Forms.Label()
        Me.MonthlyRentLabel1 = New System.Windows.Forms.Label()
        Me.SecurityMoneyLabel1 = New System.Windows.Forms.Label()
        Me.TblRentCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRentCTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblRentCTableAdapter()
        Me.TblRentSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRentSTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblRentSTableAdapter()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeIDTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeModelNoTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.RentTOTextBox = New System.Windows.Forms.TextBox()
        Me.RentedToIDTextBox = New System.Windows.Forms.TextBox()
        Me.RentedAtTextBox = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EditCompanyInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCustomerInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PayCompanyRentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayCustomerRentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RentedTextBox = New System.Windows.Forms.TextBox()
        SecurityMoneyLabel = New System.Windows.Forms.Label()
        MonthlyRentLabel = New System.Windows.Forms.Label()
        CompanyRentLabel = New System.Windows.Forms.Label()
        CompanySecurityMoneyLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        FridgeIDLabel = New System.Windows.Forms.Label()
        RentTOLabel = New System.Windows.Forms.Label()
        FridgeModelNoLabel = New System.Windows.Forms.Label()
        SupplierNameLabel = New System.Windows.Forms.Label()
        RentTOLabel2 = New System.Windows.Forms.Label()
        RentedToIDLabel = New System.Windows.Forms.Label()
        RentedAtLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFridgesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TblRentCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRentSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SecurityMoneyLabel
        '
        SecurityMoneyLabel.BackColor = System.Drawing.Color.Black
        SecurityMoneyLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SecurityMoneyLabel.ForeColor = System.Drawing.Color.White
        SecurityMoneyLabel.Location = New System.Drawing.Point(18, 34)
        SecurityMoneyLabel.Name = "SecurityMoneyLabel"
        SecurityMoneyLabel.Size = New System.Drawing.Size(190, 25)
        SecurityMoneyLabel.TabIndex = 0
        SecurityMoneyLabel.Text = "কাস্টমারের জামানতকৃত অর্থঃ"
        SecurityMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MonthlyRentLabel
        '
        MonthlyRentLabel.BackColor = System.Drawing.Color.Black
        MonthlyRentLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        MonthlyRentLabel.ForeColor = System.Drawing.Color.White
        MonthlyRentLabel.Location = New System.Drawing.Point(18, 60)
        MonthlyRentLabel.Name = "MonthlyRentLabel"
        MonthlyRentLabel.Size = New System.Drawing.Size(190, 25)
        MonthlyRentLabel.TabIndex = 2
        MonthlyRentLabel.Text = "কাস্টমারের মাসিক ভাড়া প্রদানঃ"
        MonthlyRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyRentLabel
        '
        CompanyRentLabel.BackColor = System.Drawing.Color.Black
        CompanyRentLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CompanyRentLabel.ForeColor = System.Drawing.Color.White
        CompanyRentLabel.Location = New System.Drawing.Point(18, 112)
        CompanyRentLabel.Name = "CompanyRentLabel"
        CompanyRentLabel.Size = New System.Drawing.Size(190, 25)
        CompanyRentLabel.TabIndex = 4
        CompanyRentLabel.Text = "কোম্পানির মাসিক ভাড়াঃ"
        CompanyRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanySecurityMoneyLabel
        '
        CompanySecurityMoneyLabel.BackColor = System.Drawing.Color.Black
        CompanySecurityMoneyLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CompanySecurityMoneyLabel.ForeColor = System.Drawing.Color.White
        CompanySecurityMoneyLabel.Location = New System.Drawing.Point(18, 86)
        CompanySecurityMoneyLabel.Name = "CompanySecurityMoneyLabel"
        CompanySecurityMoneyLabel.Size = New System.Drawing.Size(190, 25)
        CompanySecurityMoneyLabel.TabIndex = 8
        CompanySecurityMoneyLabel.Text = "কোম্পানির জামানতকৃত অর্থঃ"
        CompanySecurityMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(46, 404)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 23
        IdLabel.Text = "Id:"
        '
        'FridgeIDLabel
        '
        FridgeIDLabel.AutoSize = True
        FridgeIDLabel.Location = New System.Drawing.Point(38, 440)
        FridgeIDLabel.Name = "FridgeIDLabel"
        FridgeIDLabel.Size = New System.Drawing.Size(63, 13)
        FridgeIDLabel.TabIndex = 24
        FridgeIDLabel.Text = "fridge ID:"
        '
        'RentTOLabel
        '
        RentTOLabel.BackColor = System.Drawing.Color.Black
        RentTOLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        RentTOLabel.ForeColor = System.Drawing.Color.White
        RentTOLabel.Location = New System.Drawing.Point(18, 138)
        RentTOLabel.Name = "RentTOLabel"
        RentTOLabel.Size = New System.Drawing.Size(190, 25)
        RentTOLabel.TabIndex = 10
        RentTOLabel.Text = "বর্তমান কাস্টমারঃ"
        RentTOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FridgeModelNoLabel
        '
        FridgeModelNoLabel.AutoSize = True
        FridgeModelNoLabel.Location = New System.Drawing.Point(73, 531)
        FridgeModelNoLabel.Name = "FridgeModelNoLabel"
        FridgeModelNoLabel.Size = New System.Drawing.Size(101, 13)
        FridgeModelNoLabel.TabIndex = 25
        FridgeModelNoLabel.Text = "fridge Model No:"
        '
        'SupplierNameLabel
        '
        SupplierNameLabel.AutoSize = True
        SupplierNameLabel.Location = New System.Drawing.Point(69, 530)
        SupplierNameLabel.Name = "SupplierNameLabel"
        SupplierNameLabel.Size = New System.Drawing.Size(94, 13)
        SupplierNameLabel.TabIndex = 26
        SupplierNameLabel.Text = "supplier Name:"
        '
        'RentTOLabel2
        '
        RentTOLabel2.AutoSize = True
        RentTOLabel2.Location = New System.Drawing.Point(85, 524)
        RentTOLabel2.Name = "RentTOLabel2"
        RentTOLabel2.Size = New System.Drawing.Size(55, 13)
        RentTOLabel2.TabIndex = 27
        RentTOLabel2.Text = "rent TO:"
        '
        'RentedToIDLabel
        '
        RentedToIDLabel.AutoSize = True
        RentedToIDLabel.Location = New System.Drawing.Point(55, 388)
        RentedToIDLabel.Name = "RentedToIDLabel"
        RentedToIDLabel.Size = New System.Drawing.Size(84, 13)
        RentedToIDLabel.TabIndex = 28
        RentedToIDLabel.Text = "rented To ID:"
        '
        'RentedAtLabel
        '
        RentedAtLabel.AutoSize = True
        RentedAtLabel.Location = New System.Drawing.Point(56, 431)
        RentedAtLabel.Name = "RentedAtLabel"
        RentedAtLabel.Size = New System.Drawing.Size(65, 13)
        RentedAtLabel.TabIndex = 29
        RentedAtLabel.Text = "rented At:"
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
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ফ্রিজসমূহ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFridgesBindingSource
        '
        Me.TblFridgesBindingSource.DataMember = "tblFridges"
        Me.TblFridgesBindingSource.DataSource = Me.DataSet
        '
        'TblFridgesTableAdapter
        '
        Me.TblFridgesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblFridgesTableAdapter = Me.TblFridgesTableAdapter
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
        'TblFridgesDataGridView
        '
        Me.TblFridgesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblFridgesDataGridView.AutoGenerateColumns = False
        Me.TblFridgesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblFridgesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblFridgesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblFridgesDataGridView.DataSource = Me.TblFridgesBindingSource
        Me.TblFridgesDataGridView.Location = New System.Drawing.Point(8, 191)
        Me.TblFridgesDataGridView.Name = "TblFridgesDataGridView"
        Me.TblFridgesDataGridView.Size = New System.Drawing.Size(985, 358)
        Me.TblFridgesDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fridgeModelNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ফ্রিজের মডেল"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "supplierName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "কোম্পানি"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "issueDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "কোম্পানি থেকে ইস্যুর তারিখ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fridgeCondition"
        Me.DataGridViewTextBoxColumn5.HeaderText = "কন্ডিশন"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fridgeIssueType"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fridge issue type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fridgeID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ফ্রিজের আই ডি"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fridgeNote"
        Me.DataGridViewTextBoxColumn8.HeaderText = "মন্তব্য"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(RentTOLabel)
        Me.GroupBox2.Controls.Add(Me.RentTOLabel1)
        Me.GroupBox2.Controls.Add(CompanySecurityMoneyLabel)
        Me.GroupBox2.Controls.Add(Me.CompanySecurityMoneyLabel1)
        Me.GroupBox2.Controls.Add(CompanyRentLabel)
        Me.GroupBox2.Controls.Add(Me.CompanyRentLabel1)
        Me.GroupBox2.Controls.Add(MonthlyRentLabel)
        Me.GroupBox2.Controls.Add(Me.MonthlyRentLabel1)
        Me.GroupBox2.Controls.Add(SecurityMoneyLabel)
        Me.GroupBox2.Controls.Add(Me.SecurityMoneyLabel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(274, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 176)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ভাড়া সংক্রান্ত তথ্য"
        '
        'RentTOLabel1
        '
        Me.RentTOLabel1.BackColor = System.Drawing.Color.Black
        Me.RentTOLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rentTO", True))
        Me.RentTOLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RentTOLabel1.ForeColor = System.Drawing.Color.White
        Me.RentTOLabel1.Location = New System.Drawing.Point(214, 138)
        Me.RentTOLabel1.Name = "RentTOLabel1"
        Me.RentTOLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.RentTOLabel1.Size = New System.Drawing.Size(221, 25)
        Me.RentTOLabel1.TabIndex = 11
        Me.RentTOLabel1.Text = "NaN"
        Me.RentTOLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompanySecurityMoneyLabel1
        '
        Me.CompanySecurityMoneyLabel1.BackColor = System.Drawing.Color.Black
        Me.CompanySecurityMoneyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "companySecurityMoney", True))
        Me.CompanySecurityMoneyLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CompanySecurityMoneyLabel1.ForeColor = System.Drawing.Color.White
        Me.CompanySecurityMoneyLabel1.Location = New System.Drawing.Point(214, 86)
        Me.CompanySecurityMoneyLabel1.Name = "CompanySecurityMoneyLabel1"
        Me.CompanySecurityMoneyLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.CompanySecurityMoneyLabel1.Size = New System.Drawing.Size(221, 25)
        Me.CompanySecurityMoneyLabel1.TabIndex = 9
        Me.CompanySecurityMoneyLabel1.Text = "0000"
        '
        'CompanyRentLabel1
        '
        Me.CompanyRentLabel1.BackColor = System.Drawing.Color.Black
        Me.CompanyRentLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "companyRent", True))
        Me.CompanyRentLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CompanyRentLabel1.ForeColor = System.Drawing.Color.White
        Me.CompanyRentLabel1.Location = New System.Drawing.Point(214, 112)
        Me.CompanyRentLabel1.Name = "CompanyRentLabel1"
        Me.CompanyRentLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.CompanyRentLabel1.Size = New System.Drawing.Size(221, 25)
        Me.CompanyRentLabel1.TabIndex = 5
        Me.CompanyRentLabel1.Text = "0000"
        '
        'MonthlyRentLabel1
        '
        Me.MonthlyRentLabel1.BackColor = System.Drawing.Color.Black
        Me.MonthlyRentLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "monthlyRent", True))
        Me.MonthlyRentLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MonthlyRentLabel1.ForeColor = System.Drawing.Color.White
        Me.MonthlyRentLabel1.Location = New System.Drawing.Point(214, 60)
        Me.MonthlyRentLabel1.Name = "MonthlyRentLabel1"
        Me.MonthlyRentLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.MonthlyRentLabel1.Size = New System.Drawing.Size(221, 25)
        Me.MonthlyRentLabel1.TabIndex = 3
        Me.MonthlyRentLabel1.Text = "0000"
        '
        'SecurityMoneyLabel1
        '
        Me.SecurityMoneyLabel1.BackColor = System.Drawing.Color.Black
        Me.SecurityMoneyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "securityMoney", True))
        Me.SecurityMoneyLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SecurityMoneyLabel1.ForeColor = System.Drawing.Color.White
        Me.SecurityMoneyLabel1.Location = New System.Drawing.Point(214, 34)
        Me.SecurityMoneyLabel1.Name = "SecurityMoneyLabel1"
        Me.SecurityMoneyLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.SecurityMoneyLabel1.Size = New System.Drawing.Size(221, 25)
        Me.SecurityMoneyLabel1.TabIndex = 1
        Me.SecurityMoneyLabel1.Text = "0000"
        '
        'TblRentCBindingSource
        '
        Me.TblRentCBindingSource.DataMember = "tblRentC"
        Me.TblRentCBindingSource.DataSource = Me.DataSet
        '
        'TblRentCTableAdapter
        '
        Me.TblRentCTableAdapter.ClearBeforeFill = True
        '
        'TblRentSBindingSource
        '
        Me.TblRentSBindingSource.DataMember = "tblRentS"
        Me.TblRentSBindingSource.DataSource = Me.DataSet
        '
        'TblRentSTableAdapter
        '
        Me.TblRentSTableAdapter.ClearBeforeFill = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(76, 401)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IdTextBox.TabIndex = 24
        '
        'FridgeIDTextBox
        '
        Me.FridgeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeID", True))
        Me.FridgeIDTextBox.Location = New System.Drawing.Point(107, 437)
        Me.FridgeIDTextBox.Name = "FridgeIDTextBox"
        Me.FridgeIDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.FridgeIDTextBox.TabIndex = 25
        '
        'FridgeModelNoTextBox
        '
        Me.FridgeModelNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeModelNo", True))
        Me.FridgeModelNoTextBox.Location = New System.Drawing.Point(317, 58)
        Me.FridgeModelNoTextBox.Name = "FridgeModelNoTextBox"
        Me.FridgeModelNoTextBox.Size = New System.Drawing.Size(100, 21)
        Me.FridgeModelNoTextBox.TabIndex = 26
        '
        'SupplierNameTextBox
        '
        Me.SupplierNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "supplierName", True))
        Me.SupplierNameTextBox.Location = New System.Drawing.Point(169, 527)
        Me.SupplierNameTextBox.Name = "SupplierNameTextBox"
        Me.SupplierNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.SupplierNameTextBox.TabIndex = 27
        '
        'RentTOTextBox
        '
        Me.RentTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rentTO", True))
        Me.RentTOTextBox.Location = New System.Drawing.Point(146, 521)
        Me.RentTOTextBox.Name = "RentTOTextBox"
        Me.RentTOTextBox.Size = New System.Drawing.Size(100, 21)
        Me.RentTOTextBox.TabIndex = 28
        '
        'RentedToIDTextBox
        '
        Me.RentedToIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rentedToID", True))
        Me.RentedToIDTextBox.Location = New System.Drawing.Point(146, 385)
        Me.RentedToIDTextBox.Name = "RentedToIDTextBox"
        Me.RentedToIDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.RentedToIDTextBox.TabIndex = 29
        '
        'RentedAtTextBox
        '
        Me.RentedAtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rentedAt", True))
        Me.RentedAtTextBox.Location = New System.Drawing.Point(127, 428)
        Me.RentedAtTextBox.Name = "RentedAtTextBox"
        Me.RentedAtTextBox.Size = New System.Drawing.Size(100, 21)
        Me.RentedAtTextBox.TabIndex = 30
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 37)
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
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"ফ্রিজের মডেল নং", "কোম্পানি", "ইস্যুর তারিখ", "ফ্রিজ আই.ডি.", "ভাড়ায় প্রদানকৃত কাস্টমারের নাম"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(150, 37)
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
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(260, 24)
        Me.ToolStripButton4.Text = "কাস্টমার হতে ফ্রিজ উত্তোলন করুন"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton6.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton6.Size = New System.Drawing.Size(78, 33)
        Me.ToolStripButton6.Text = "প্রিন্ট"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripSplitButton1, Me.ToolStripButton2, Me.ToolStripButton5, Me.ToolStripButton4, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 37)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.BackColor = System.Drawing.Color.Black
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditCompanyInformationToolStripMenuItem, Me.EditCustomerInformationToolStripMenuItem})
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.Green
        Me.ToolStripSplitButton1.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(102, 33)
        Me.ToolStripSplitButton1.Text = "সংশোধন"
        '
        'EditCompanyInformationToolStripMenuItem
        '
        Me.EditCompanyInformationToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.EditCompanyInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditCompanyInformationToolStripMenuItem.Margin = New System.Windows.Forms.Padding(1)
        Me.EditCompanyInformationToolStripMenuItem.Name = "EditCompanyInformationToolStripMenuItem"
        Me.EditCompanyInformationToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.EditCompanyInformationToolStripMenuItem.Size = New System.Drawing.Size(275, 30)
        Me.EditCompanyInformationToolStripMenuItem.Text = "Edit company information"
        '
        'EditCustomerInformationToolStripMenuItem
        '
        Me.EditCustomerInformationToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.EditCustomerInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditCustomerInformationToolStripMenuItem.Margin = New System.Windows.Forms.Padding(1)
        Me.EditCustomerInformationToolStripMenuItem.Name = "EditCustomerInformationToolStripMenuItem"
        Me.EditCustomerInformationToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.EditCustomerInformationToolStripMenuItem.Size = New System.Drawing.Size(275, 30)
        Me.EditCustomerInformationToolStripMenuItem.Text = "Edit customer information"
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
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayCompanyRentToolStripMenuItem, Me.PayCustomerRentToolStripMenuItem})
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton5.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.money_sign_button1
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(169, 33)
        Me.ToolStripButton5.Text = "ভাড়া আদান-প্রদান"
        '
        'PayCompanyRentToolStripMenuItem
        '
        Me.PayCompanyRentToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.PayCompanyRentToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.PayCompanyRentToolStripMenuItem.Name = "PayCompanyRentToolStripMenuItem"
        Me.PayCompanyRentToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.PayCompanyRentToolStripMenuItem.Text = "Pay company rent"
        '
        'PayCustomerRentToolStripMenuItem
        '
        Me.PayCustomerRentToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.PayCustomerRentToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.PayCustomerRentToolStripMenuItem.Name = "PayCustomerRentToolStripMenuItem"
        Me.PayCustomerRentToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.PayCustomerRentToolStripMenuItem.Text = "Pay customer rent"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TblFridgesDataGridView)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 581)
        Me.Panel1.TabIndex = 31
        '
        'RentedTextBox
        '
        Me.RentedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rented", True))
        Me.RentedTextBox.Location = New System.Drawing.Point(152, 12)
        Me.RentedTextBox.Name = "RentedTextBox"
        Me.RentedTextBox.Size = New System.Drawing.Size(100, 21)
        Me.RentedTextBox.TabIndex = 24
        '
        'manageFridge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(FridgeIDLabel)
        Me.Controls.Add(Me.FridgeIDTextBox)
        Me.Controls.Add(RentTOLabel2)
        Me.Controls.Add(Me.RentTOTextBox)
        Me.Controls.Add(SupplierNameLabel)
        Me.Controls.Add(FridgeModelNoLabel)
        Me.Controls.Add(Me.SupplierNameTextBox)
        Me.Controls.Add(RentedToIDLabel)
        Me.Controls.Add(Me.RentedToIDTextBox)
        Me.Controls.Add(RentedAtLabel)
        Me.Controls.Add(Me.RentedAtTextBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FridgeModelNoTextBox)
        Me.Controls.Add(Me.RentedTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageFridge"
        Me.Text = "manageFridge"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFridgesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TblRentCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRentSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblFridgesBindingSource As BindingSource
    Friend WithEvents TblFridgesTableAdapter As dataSetTableAdapters.tblFridgesTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblFridgesDataGridView As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CompanySecurityMoneyLabel1 As Label
    Friend WithEvents CompanyRentLabel1 As Label
    Friend WithEvents MonthlyRentLabel1 As Label
    Friend WithEvents SecurityMoneyLabel1 As Label
    Friend WithEvents TblRentCBindingSource As BindingSource
    Friend WithEvents TblRentCTableAdapter As dataSetTableAdapters.tblRentCTableAdapter
    Friend WithEvents TblRentSBindingSource As BindingSource
    Friend WithEvents TblRentSTableAdapter As dataSetTableAdapters.tblRentSTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents FridgeIDTextBox As TextBox
    Friend WithEvents RentTOLabel1 As Label
    Friend WithEvents FridgeModelNoTextBox As TextBox
    Friend WithEvents SupplierNameTextBox As TextBox
    Friend WithEvents RentTOTextBox As TextBox
    Friend WithEvents RentedToIDTextBox As TextBox
    Friend WithEvents RentedAtTextBox As TextBox
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RentedTextBox As TextBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripDropDownButton
    Friend WithEvents PayCompanyRentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayCustomerRentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton1 As ToolStripDropDownButton
    Friend WithEvents EditCompanyInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCustomerInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
