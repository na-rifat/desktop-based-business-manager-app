<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageBankAccounts
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
        Dim AccountHolderNameLabel As System.Windows.Forms.Label
        Dim BankLabel As System.Windows.Forms.Label
        Dim BranchLabel As System.Windows.Forms.Label
        Dim AccountNumberLabel As System.Windows.Forms.Label
        Dim OpeningBalanceLabel As System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblBankAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblBankAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblBankAccountsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblBanksTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblBanksTableAdapter()
        Me.TblTransactionTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblTransactionTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblBankAccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AccountHolderNameTextBox = New System.Windows.Forms.TextBox()
        Me.BankTextBox = New System.Windows.Forms.TextBox()
        Me.BranchTextBox = New System.Windows.Forms.TextBox()
        Me.AccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.OpeningBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.BankNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblBanksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionIDTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionTypeTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PersonOrsourceTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        AccountHolderNameLabel = New System.Windows.Forms.Label()
        BankLabel = New System.Windows.Forms.Label()
        BranchLabel = New System.Windows.Forms.Label()
        AccountNumberLabel = New System.Windows.Forms.Label()
        OpeningBalanceLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblBankAccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblBanksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountHolderNameLabel
        '
        AccountHolderNameLabel.BackColor = System.Drawing.Color.Black
        AccountHolderNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AccountHolderNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AccountHolderNameLabel.Location = New System.Drawing.Point(28, 12)
        AccountHolderNameLabel.Name = "AccountHolderNameLabel"
        AccountHolderNameLabel.Size = New System.Drawing.Size(148, 25)
        AccountHolderNameLabel.TabIndex = 17
        AccountHolderNameLabel.Text = "একাউন্ট হোল্ডারের নামঃ"
        AccountHolderNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BankLabel
        '
        BankLabel.BackColor = System.Drawing.Color.Black
        BankLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        BankLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        BankLabel.Location = New System.Drawing.Point(28, 38)
        BankLabel.Name = "BankLabel"
        BankLabel.Size = New System.Drawing.Size(148, 25)
        BankLabel.TabIndex = 19
        BankLabel.Text = "ব্যাংকঃ"
        BankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BranchLabel
        '
        BranchLabel.BackColor = System.Drawing.Color.Black
        BranchLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        BranchLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        BranchLabel.Location = New System.Drawing.Point(28, 64)
        BranchLabel.Name = "BranchLabel"
        BranchLabel.Size = New System.Drawing.Size(148, 25)
        BranchLabel.TabIndex = 21
        BranchLabel.Text = "ব্র্যাঞ্চঃ"
        BranchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AccountNumberLabel
        '
        AccountNumberLabel.BackColor = System.Drawing.Color.Black
        AccountNumberLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AccountNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AccountNumberLabel.Location = New System.Drawing.Point(28, 90)
        AccountNumberLabel.Name = "AccountNumberLabel"
        AccountNumberLabel.Size = New System.Drawing.Size(148, 25)
        AccountNumberLabel.TabIndex = 23
        AccountNumberLabel.Text = "একাউন্ট নাম্বারঃ"
        AccountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpeningBalanceLabel
        '
        OpeningBalanceLabel.BackColor = System.Drawing.Color.Black
        OpeningBalanceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        OpeningBalanceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        OpeningBalanceLabel.Location = New System.Drawing.Point(28, 116)
        OpeningBalanceLabel.Name = "OpeningBalanceLabel"
        OpeningBalanceLabel.Size = New System.Drawing.Size(148, 25)
        OpeningBalanceLabel.TabIndex = 25
        OpeningBalanceLabel.Text = "বর্তমান ব্যালেন্সঃ"
        OpeningBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton1, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 37)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(291, 37)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(46, 34)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"একাউন্ট হোল্ডারের নাম", "একাউন্ট নাম্বার"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(174, 37)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(112, 34)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.SteelBlue
        Me.ToolStripButton4.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.button_circle_add_512
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(261, 33)
        Me.ToolStripButton4.Text = "ব্যাংক একাউন্ট যুক্ত করুন"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(113, 29)
        Me.ToolStripButton3.Text = "সংশোধন"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(88, 29)
        Me.ToolStripButton2.Text = "ডিলিট"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton1.Size = New System.Drawing.Size(78, 33)
        Me.ToolStripButton1.Text = "প্রিন্ট"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton5.Size = New System.Drawing.Size(80, 33)
        Me.ToolStripButton5.Text = "কাউন্ট"
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
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ব্যাংক একাউন্টসমূহ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBankAccountsBindingSource
        '
        Me.TblBankAccountsBindingSource.DataMember = "tblBankAccounts"
        Me.TblBankAccountsBindingSource.DataSource = Me.DataSet
        '
        'TblBankAccountsTableAdapter
        '
        Me.TblBankAccountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sales_targetTableAdapter = Nothing
        Me.TableAdapterManager.tblassetTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceReportTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceTableAdapter = Nothing
        Me.TableAdapterManager.tblBankAccountsTableAdapter = Me.TblBankAccountsTableAdapter
        Me.TableAdapterManager.tblBanksTableAdapter = Me.TblBanksTableAdapter
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
        Me.TableAdapterManager.tblTransactionTableAdapter = Me.TblTransactionTableAdapter
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblBanksTableAdapter
        '
        Me.TblBanksTableAdapter.ClearBeforeFill = True
        '
        'TblTransactionTableAdapter
        '
        Me.TblTransactionTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TblBankAccountsDataGridView)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BankNameTextBox)
        Me.Panel1.Location = New System.Drawing.Point(26, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(949, 508)
        Me.Panel1.TabIndex = 17
        '
        'TblBankAccountsDataGridView
        '
        Me.TblBankAccountsDataGridView.AutoGenerateColumns = False
        Me.TblBankAccountsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblBankAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblBankAccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TblBankAccountsDataGridView.DataSource = Me.TblBankAccountsBindingSource
        Me.TblBankAccountsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblBankAccountsDataGridView.Location = New System.Drawing.Point(0, 224)
        Me.TblBankAccountsDataGridView.Name = "TblBankAccountsDataGridView"
        Me.TblBankAccountsDataGridView.Size = New System.Drawing.Size(949, 256)
        Me.TblBankAccountsDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "accountHolderName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "একাউন্ট হোল্ডারের নাম"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "bank"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ব্যাংক"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "branch"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ব্রাঞ্চ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "accountNumber"
        Me.DataGridViewTextBoxColumn5.HeaderText = "একাউন্ট নাম্বার"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "openingBalance"
        Me.DataGridViewTextBoxColumn6.HeaderText = "বর্তমান ব্যালেন্স"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 480)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(949, 28)
        Me.tool.TabIndex = 80
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Padding = New System.Windows.Forms.Padding(4)
        Me.ToolStripLabel3.Size = New System.Drawing.Size(151, 25)
        Me.ToolStripLabel3.Text = "Total bank balance:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(247, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 215)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(AccountHolderNameLabel)
        Me.Panel2.Controls.Add(Me.AccountHolderNameTextBox)
        Me.Panel2.Controls.Add(BankLabel)
        Me.Panel2.Controls.Add(Me.BankTextBox)
        Me.Panel2.Controls.Add(BranchLabel)
        Me.Panel2.Controls.Add(Me.BranchTextBox)
        Me.Panel2.Controls.Add(AccountNumberLabel)
        Me.Panel2.Controls.Add(Me.AccountNumberTextBox)
        Me.Panel2.Controls.Add(OpeningBalanceLabel)
        Me.Panel2.Controls.Add(Me.OpeningBalanceTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(501, 195)
        Me.Panel2.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(182, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 35)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AccountHolderNameTextBox
        '
        Me.AccountHolderNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "accountHolderName", True))
        Me.AccountHolderNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AccountHolderNameTextBox.Location = New System.Drawing.Point(182, 12)
        Me.AccountHolderNameTextBox.Name = "AccountHolderNameTextBox"
        Me.AccountHolderNameTextBox.Size = New System.Drawing.Size(250, 24)
        Me.AccountHolderNameTextBox.TabIndex = 18
        '
        'BankTextBox
        '
        Me.BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "bank", True))
        Me.BankTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.BankTextBox.Location = New System.Drawing.Point(182, 38)
        Me.BankTextBox.Name = "BankTextBox"
        Me.BankTextBox.Size = New System.Drawing.Size(250, 24)
        Me.BankTextBox.TabIndex = 20
        '
        'BranchTextBox
        '
        Me.BranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "branch", True))
        Me.BranchTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.BranchTextBox.Location = New System.Drawing.Point(182, 64)
        Me.BranchTextBox.Name = "BranchTextBox"
        Me.BranchTextBox.Size = New System.Drawing.Size(250, 24)
        Me.BranchTextBox.TabIndex = 22
        '
        'AccountNumberTextBox
        '
        Me.AccountNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "accountNumber", True))
        Me.AccountNumberTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AccountNumberTextBox.Location = New System.Drawing.Point(182, 90)
        Me.AccountNumberTextBox.Name = "AccountNumberTextBox"
        Me.AccountNumberTextBox.Size = New System.Drawing.Size(250, 24)
        Me.AccountNumberTextBox.TabIndex = 24
        '
        'OpeningBalanceTextBox
        '
        Me.OpeningBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "openingBalance", True))
        Me.OpeningBalanceTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.OpeningBalanceTextBox.Location = New System.Drawing.Point(182, 116)
        Me.OpeningBalanceTextBox.Name = "OpeningBalanceTextBox"
        Me.OpeningBalanceTextBox.Size = New System.Drawing.Size(250, 24)
        Me.OpeningBalanceTextBox.TabIndex = 26
        '
        'BankNameTextBox
        '
        Me.BankNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBanksBindingSource, "bankName", True))
        Me.BankNameTextBox.Location = New System.Drawing.Point(1, -26)
        Me.BankNameTextBox.Name = "BankNameTextBox"
        Me.BankNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.BankNameTextBox.TabIndex = 21
        '
        'TblBanksBindingSource
        '
        Me.TblBanksBindingSource.DataMember = "tblBanks"
        Me.TblBanksBindingSource.DataSource = Me.DataSet
        '
        'TblTransactionBindingSource
        '
        Me.TblTransactionBindingSource.DataMember = "tblTransaction"
        Me.TblTransactionBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(24, 8)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(14, 21)
        Me.IdTextBox.TabIndex = 81
        '
        'TransactionIDTextBox
        '
        Me.TransactionIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "transactionID", True))
        Me.TransactionIDTextBox.Location = New System.Drawing.Point(24, 8)
        Me.TransactionIDTextBox.Name = "TransactionIDTextBox"
        Me.TransactionIDTextBox.Size = New System.Drawing.Size(14, 21)
        Me.TransactionIDTextBox.TabIndex = 83
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(24, 8)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(14, 21)
        Me.AmountTextBox.TabIndex = 85
        '
        'TransactionTypeTextBox
        '
        Me.TransactionTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "transactionType", True))
        Me.TransactionTypeTextBox.Location = New System.Drawing.Point(24, 8)
        Me.TransactionTypeTextBox.Name = "TransactionTypeTextBox"
        Me.TransactionTypeTextBox.Size = New System.Drawing.Size(14, 21)
        Me.TransactionTypeTextBox.TabIndex = 87
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "accNo", True))
        Me.AccNoTextBox.Location = New System.Drawing.Point(24, 8)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(14, 21)
        Me.AccNoTextBox.TabIndex = 89
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblTransactionBindingSource, "date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(24, 8)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(14, 21)
        Me.DateDateTimePicker.TabIndex = 91
        '
        'PersonOrsourceTextBox
        '
        Me.PersonOrsourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "personOrsource", True))
        Me.PersonOrsourceTextBox.Location = New System.Drawing.Point(24, 8)
        Me.PersonOrsourceTextBox.Name = "PersonOrsourceTextBox"
        Me.PersonOrsourceTextBox.Size = New System.Drawing.Size(14, 21)
        Me.PersonOrsourceTextBox.TabIndex = 93
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(24, 8)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(14, 21)
        Me.NoteTextBox.TabIndex = 95
        '
        'manageBankAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.TransactionIDTextBox)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.TransactionTypeTextBox)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.PersonOrsourceTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageBankAccounts"
        Me.Text = "manageBankAccounts"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblBankAccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblBanksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblBankAccountsBindingSource As BindingSource
    Friend WithEvents TblBankAccountsTableAdapter As dataSetTableAdapters.tblBankAccountsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TblBankAccountsDataGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents AccountHolderNameTextBox As TextBox
    Friend WithEvents BankTextBox As TextBox
    Friend WithEvents BranchTextBox As TextBox
    Friend WithEvents AccountNumberTextBox As TextBox
    Friend WithEvents OpeningBalanceTextBox As TextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TblBanksBindingSource As BindingSource
    Friend WithEvents TblBanksTableAdapter As dataSetTableAdapters.tblBanksTableAdapter
    Friend WithEvents BankNameTextBox As TextBox
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TblTransactionBindingSource As BindingSource
    Friend WithEvents TblTransactionTableAdapter As dataSetTableAdapters.tblTransactionTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents TransactionIDTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents TransactionTypeTextBox As TextBox
    Friend WithEvents AccNoTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents PersonOrsourceTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
