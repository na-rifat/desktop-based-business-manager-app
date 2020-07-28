<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addCustomer
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
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim BillingAddressLabel As System.Windows.Forms.Label
        Dim ShippingAddressLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim ShopOrCompanyNameLabel As System.Windows.Forms.Label
        Dim CustomerNoteLabel As System.Windows.Forms.Label
        Dim DueLabel As System.Windows.Forms.Label
        Dim PaidLabel As System.Windows.Forms.Label
        Dim PaymentLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel1 As System.Windows.Forms.Label
        Dim CustomerNameLabel1 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCustomersTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblCustomersTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblCusomterAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblCusomterAccountsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_add = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PaidTextBox = New System.Windows.Forms.TextBox()
        Me.TblCusomterAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShopOrCompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.BillingAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ShippingAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNoteTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox1 = New System.Windows.Forms.TextBox()
        CustomerNameLabel = New System.Windows.Forms.Label()
        BillingAddressLabel = New System.Windows.Forms.Label()
        ShippingAddressLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        ShopOrCompanyNameLabel = New System.Windows.Forms.Label()
        CustomerNoteLabel = New System.Windows.Forms.Label()
        DueLabel = New System.Windows.Forms.Label()
        PaidLabel = New System.Windows.Forms.Label()
        PaymentLabel = New System.Windows.Forms.Label()
        CustomerIDLabel1 = New System.Windows.Forms.Label()
        CustomerNameLabel1 = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblCusomterAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.BackColor = System.Drawing.Color.Black
        CustomerNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CustomerNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CustomerNameLabel.Location = New System.Drawing.Point(15, 167)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(128, 25)
        CustomerNameLabel.TabIndex = 40
        CustomerNameLabel.Text = "স্বত্তাধিকারীঃ"
        CustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BillingAddressLabel
        '
        BillingAddressLabel.BackColor = System.Drawing.Color.Black
        BillingAddressLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        BillingAddressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        BillingAddressLabel.Location = New System.Drawing.Point(15, 37)
        BillingAddressLabel.Name = "BillingAddressLabel"
        BillingAddressLabel.Size = New System.Drawing.Size(128, 25)
        BillingAddressLabel.TabIndex = 42
        BillingAddressLabel.Text = "কাস্টমার গ্রুপঃ"
        BillingAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShippingAddressLabel
        '
        ShippingAddressLabel.BackColor = System.Drawing.Color.Black
        ShippingAddressLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ShippingAddressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ShippingAddressLabel.Location = New System.Drawing.Point(15, 63)
        ShippingAddressLabel.Name = "ShippingAddressLabel"
        ShippingAddressLabel.Size = New System.Drawing.Size(128, 25)
        ShippingAddressLabel.TabIndex = 44
        ShippingAddressLabel.Text = "ঠিকানাঃ"
        ShippingAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.BackColor = System.Drawing.Color.Black
        ContactNumberLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ContactNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ContactNumberLabel.Location = New System.Drawing.Point(15, 89)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(128, 25)
        ContactNumberLabel.TabIndex = 46
        ContactNumberLabel.Text = "মোবাইলঃ"
        ContactNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailLabel
        '
        EmailLabel.BackColor = System.Drawing.Color.Black
        EmailLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        EmailLabel.Location = New System.Drawing.Point(15, 115)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(128, 25)
        EmailLabel.TabIndex = 48
        EmailLabel.Text = "ই-মেইলঃ"
        EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.BackColor = System.Drawing.Color.Black
        CustomerIDLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CustomerIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CustomerIDLabel.Location = New System.Drawing.Point(15, 141)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(128, 25)
        CustomerIDLabel.TabIndex = 50
        CustomerIDLabel.Text = "কাস্টমার আইডিঃ"
        CustomerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShopOrCompanyNameLabel
        '
        ShopOrCompanyNameLabel.BackColor = System.Drawing.Color.Black
        ShopOrCompanyNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ShopOrCompanyNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ShopOrCompanyNameLabel.Location = New System.Drawing.Point(15, 11)
        ShopOrCompanyNameLabel.Name = "ShopOrCompanyNameLabel"
        ShopOrCompanyNameLabel.Size = New System.Drawing.Size(128, 25)
        ShopOrCompanyNameLabel.TabIndex = 52
        ShopOrCompanyNameLabel.Text = "দোকানের নামঃ"
        ShopOrCompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerNoteLabel
        '
        CustomerNoteLabel.BackColor = System.Drawing.Color.Black
        CustomerNoteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CustomerNoteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CustomerNoteLabel.Location = New System.Drawing.Point(15, 193)
        CustomerNoteLabel.Name = "CustomerNoteLabel"
        CustomerNoteLabel.Size = New System.Drawing.Size(128, 25)
        CustomerNoteLabel.TabIndex = 54
        CustomerNoteLabel.Text = "মন্তব্যঃ"
        CustomerNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DueLabel
        '
        DueLabel.BackColor = System.Drawing.Color.Black
        DueLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DueLabel.ForeColor = System.Drawing.Color.White
        DueLabel.Location = New System.Drawing.Point(26, 79)
        DueLabel.Name = "DueLabel"
        DueLabel.Size = New System.Drawing.Size(94, 25)
        DueLabel.TabIndex = 17
        DueLabel.Text = "বাকিঃ"
        DueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaidLabel
        '
        PaidLabel.BackColor = System.Drawing.Color.Black
        PaidLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PaidLabel.ForeColor = System.Drawing.Color.White
        PaidLabel.Location = New System.Drawing.Point(26, 53)
        PaidLabel.Name = "PaidLabel"
        PaidLabel.Size = New System.Drawing.Size(94, 25)
        PaidLabel.TabIndex = 18
        PaidLabel.Text = "পরিশোধঃ"
        PaidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaymentLabel
        '
        PaymentLabel.BackColor = System.Drawing.Color.Black
        PaymentLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PaymentLabel.ForeColor = System.Drawing.Color.White
        PaymentLabel.Location = New System.Drawing.Point(26, 27)
        PaymentLabel.Name = "PaymentLabel"
        PaymentLabel.Size = New System.Drawing.Size(94, 25)
        PaymentLabel.TabIndex = 19
        PaymentLabel.Text = "প্রাপ্য হিসাবঃ"
        PaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerIDLabel1
        '
        CustomerIDLabel1.AutoSize = True
        CustomerIDLabel1.Location = New System.Drawing.Point(934, 9)
        CustomerIDLabel1.Name = "CustomerIDLabel1"
        CustomerIDLabel1.Size = New System.Drawing.Size(83, 13)
        CustomerIDLabel1.TabIndex = 20
        CustomerIDLabel1.Text = "customer ID:"
        '
        'CustomerNameLabel1
        '
        CustomerNameLabel1.AutoSize = True
        CustomerNameLabel1.Location = New System.Drawing.Point(934, 9)
        CustomerNameLabel1.Name = "CustomerNameLabel1"
        CustomerNameLabel1.Size = New System.Drawing.Size(102, 13)
        CustomerNameLabel1.TabIndex = 21
        CustomerNameLabel1.Text = "customer Name:"
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
        Me.Label1.Text = "কাস্টমার যুক্ত করুন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCustomersBindingSource
        '
        Me.TblCustomersBindingSource.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource.DataSource = Me.DataSet
        '
        'TblCustomersTableAdapter
        '
        Me.TblCustomersTableAdapter.ClearBeforeFill = True
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chk_add)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(CustomerNameLabel)
        Me.Panel1.Controls.Add(Me.ShopOrCompanyNameTextBox)
        Me.Panel1.Controls.Add(Me.CustomerNameTextBox)
        Me.Panel1.Controls.Add(ShopOrCompanyNameLabel)
        Me.Panel1.Controls.Add(BillingAddressLabel)
        Me.Panel1.Controls.Add(Me.BillingAddressTextBox)
        Me.Panel1.Controls.Add(ShippingAddressLabel)
        Me.Panel1.Controls.Add(Me.ShippingAddressTextBox)
        Me.Panel1.Controls.Add(ContactNumberLabel)
        Me.Panel1.Controls.Add(Me.ContactNumberTextBox)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(CustomerIDLabel)
        Me.Panel1.Controls.Add(Me.CustomerIDTextBox)
        Me.Panel1.Controls.Add(CustomerNoteLabel)
        Me.Panel1.Controls.Add(Me.CustomerNoteTextBox)
        Me.Panel1.Location = New System.Drawing.Point(282, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 435)
        Me.Panel1.TabIndex = 16
        '
        'chk_add
        '
        Me.chk_add.BackColor = System.Drawing.Color.Black
        Me.chk_add.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chk_add.ForeColor = System.Drawing.Color.White
        Me.chk_add.Location = New System.Drawing.Point(144, 350)
        Me.chk_add.Name = "chk_add"
        Me.chk_add.Padding = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.chk_add.Size = New System.Drawing.Size(194, 34)
        Me.chk_add.TabIndex = 59
        Me.chk_add.Text = "বর্তমান হিসাব যুক্ত করুন"
        Me.chk_add.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PaidTextBox)
        Me.GroupBox1.Controls.Add(DueLabel)
        Me.GroupBox1.Controls.Add(PaidLabel)
        Me.GroupBox1.Controls.Add(Me.DueTextBox)
        Me.GroupBox1.Controls.Add(Me.PaymentTextBox)
        Me.GroupBox1.Controls.Add(PaymentLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 225)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 118)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "বর্তমান হিসাব"
        '
        'PaidTextBox
        '
        Me.PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "paid", True))
        Me.PaidTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PaidTextBox.Location = New System.Drawing.Point(126, 54)
        Me.PaidTextBox.Name = "PaidTextBox"
        Me.PaidTextBox.Size = New System.Drawing.Size(194, 24)
        Me.PaidTextBox.TabIndex = 19
        '
        'TblCusomterAccountsBindingSource
        '
        Me.TblCusomterAccountsBindingSource.DataMember = "tblCusomterAccounts"
        Me.TblCusomterAccountsBindingSource.DataSource = Me.DataSet
        '
        'DueTextBox
        '
        Me.DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "due", True))
        Me.DueTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DueTextBox.Location = New System.Drawing.Point(126, 79)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.ReadOnly = True
        Me.DueTextBox.Size = New System.Drawing.Size(194, 24)
        Me.DueTextBox.TabIndex = 18
        '
        'PaymentTextBox
        '
        Me.PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "payment", True))
        Me.PaymentTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PaymentTextBox.Location = New System.Drawing.Point(126, 29)
        Me.PaymentTextBox.Name = "PaymentTextBox"
        Me.PaymentTextBox.Size = New System.Drawing.Size(194, 24)
        Me.PaymentTextBox.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LightGreen
        Me.Button2.Location = New System.Drawing.Point(602, 461)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 46)
        Me.Button2.TabIndex = 57
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(144, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 35)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ShopOrCompanyNameTextBox
        '
        Me.ShopOrCompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "shopOrCompanyName", True))
        Me.ShopOrCompanyNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ShopOrCompanyNameTextBox.Location = New System.Drawing.Point(149, 17)
        Me.ShopOrCompanyNameTextBox.Name = "ShopOrCompanyNameTextBox"
        Me.ShopOrCompanyNameTextBox.Size = New System.Drawing.Size(264, 24)
        Me.ShopOrCompanyNameTextBox.TabIndex = 53
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(149, 167)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(264, 24)
        Me.CustomerNameTextBox.TabIndex = 41
        '
        'BillingAddressTextBox
        '
        Me.BillingAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "billingAddress", True))
        Me.BillingAddressTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.BillingAddressTextBox.Location = New System.Drawing.Point(149, 42)
        Me.BillingAddressTextBox.Name = "BillingAddressTextBox"
        Me.BillingAddressTextBox.Size = New System.Drawing.Size(264, 24)
        Me.BillingAddressTextBox.TabIndex = 43
        '
        'ShippingAddressTextBox
        '
        Me.ShippingAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "shippingAddress", True))
        Me.ShippingAddressTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ShippingAddressTextBox.Location = New System.Drawing.Point(149, 67)
        Me.ShippingAddressTextBox.Name = "ShippingAddressTextBox"
        Me.ShippingAddressTextBox.Size = New System.Drawing.Size(264, 24)
        Me.ShippingAddressTextBox.TabIndex = 45
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "contactNumber", True))
        Me.ContactNumberTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(149, 92)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(264, 24)
        Me.ContactNumberTextBox.TabIndex = 47
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.EmailTextBox.Location = New System.Drawing.Point(149, 117)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(264, 24)
        Me.EmailTextBox.TabIndex = 49
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "customerID", True))
        Me.CustomerIDTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(149, 142)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.ReadOnly = True
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(264, 24)
        Me.CustomerIDTextBox.TabIndex = 51
        '
        'CustomerNoteTextBox
        '
        Me.CustomerNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "customerNote", True))
        Me.CustomerNoteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CustomerNoteTextBox.Location = New System.Drawing.Point(149, 192)
        Me.CustomerNoteTextBox.Name = "CustomerNoteTextBox"
        Me.CustomerNoteTextBox.Size = New System.Drawing.Size(264, 24)
        Me.CustomerNoteTextBox.TabIndex = 55
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "date", True))
        Me.DateTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DateTextBox.Location = New System.Drawing.Point(934, 9)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(74, 22)
        Me.DateTextBox.TabIndex = 17
        '
        'CustomerIDTextBox1
        '
        Me.CustomerIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "customerID", True))
        Me.CustomerIDTextBox1.Location = New System.Drawing.Point(934, 9)
        Me.CustomerIDTextBox1.Name = "CustomerIDTextBox1"
        Me.CustomerIDTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.CustomerIDTextBox1.TabIndex = 21
        '
        'CustomerNameTextBox1
        '
        Me.CustomerNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "customerName", True))
        Me.CustomerNameTextBox1.Location = New System.Drawing.Point(934, 9)
        Me.CustomerNameTextBox1.Name = "CustomerNameTextBox1"
        Me.CustomerNameTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.CustomerNameTextBox1.TabIndex = 22
        '
        'addCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(CustomerNameLabel1)
        Me.Controls.Add(Me.CustomerNameTextBox1)
        Me.Controls.Add(CustomerIDLabel1)
        Me.Controls.Add(Me.CustomerIDTextBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addCustomer"
        Me.Text = "."
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblCusomterAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblCustomersBindingSource As BindingSource
    Friend WithEvents TblCustomersTableAdapter As dataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents BillingAddressTextBox As TextBox
    Friend WithEvents ShippingAddressTextBox As TextBox
    Friend WithEvents ContactNumberTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents ShopOrCompanyNameTextBox As TextBox
    Friend WithEvents CustomerNoteTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TblCusomterAccountsBindingSource As BindingSource
    Friend WithEvents TblCusomterAccountsTableAdapter As dataSetTableAdapters.tblCusomterAccountsTableAdapter
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents PaidTextBox As TextBox
    Friend WithEvents PaymentTextBox As TextBox
    Friend WithEvents CustomerIDTextBox1 As TextBox
    Friend WithEvents CustomerNameTextBox1 As TextBox
    Friend WithEvents chk_add As CheckBox
End Class
