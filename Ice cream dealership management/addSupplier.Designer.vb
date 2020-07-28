<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addSupplier
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
        Dim SupplierNameLabel As System.Windows.Forms.Label
        Dim ContactPersonLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim SupplierNoteLabel As System.Windows.Forms.Label
        Dim DueLabel As System.Windows.Forms.Label
        Dim PaidLabel As System.Windows.Forms.Label
        Dim PaymentLabel As System.Windows.Forms.Label
        Dim SupplierNameLabel1 As System.Windows.Forms.Label
        Dim SupplierIDLabel1 As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblSuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSuppliersTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblSuppliersTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblSupplierAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblSupplierAccountsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_nonprofit = New System.Windows.Forms.CheckBox()
        Me.chk_add = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.TblSupplierAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaidTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContactPersonTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNoteTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.SupplierIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Non_profitTextBox = New System.Windows.Forms.TextBox()
        SupplierNameLabel = New System.Windows.Forms.Label()
        ContactPersonLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        WebsiteLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        SupplierNoteLabel = New System.Windows.Forms.Label()
        DueLabel = New System.Windows.Forms.Label()
        PaidLabel = New System.Windows.Forms.Label()
        PaymentLabel = New System.Windows.Forms.Label()
        SupplierNameLabel1 = New System.Windows.Forms.Label()
        SupplierIDLabel1 = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblSupplierAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierNameLabel
        '
        SupplierNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        SupplierNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SupplierNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SupplierNameLabel.Location = New System.Drawing.Point(20, 9)
        SupplierNameLabel.Name = "SupplierNameLabel"
        SupplierNameLabel.Size = New System.Drawing.Size(123, 24)
        SupplierNameLabel.TabIndex = 25
        SupplierNameLabel.Text = "কোম্পানির নামঃ"
        SupplierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactPersonLabel
        '
        ContactPersonLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ContactPersonLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ContactPersonLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ContactPersonLabel.Location = New System.Drawing.Point(20, 34)
        ContactPersonLabel.Name = "ContactPersonLabel"
        ContactPersonLabel.Size = New System.Drawing.Size(123, 24)
        ContactPersonLabel.TabIndex = 27
        ContactPersonLabel.Text = "সংশ্লিষ্ট ব্যক্তিঃ"
        ContactPersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddressLabel
        '
        AddressLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        AddressLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AddressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AddressLabel.Location = New System.Drawing.Point(20, 59)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(123, 24)
        AddressLabel.TabIndex = 29
        AddressLabel.Text = "ঠিকানাঃ"
        AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ContactNumberLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ContactNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ContactNumberLabel.Location = New System.Drawing.Point(20, 84)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(123, 24)
        ContactNumberLabel.TabIndex = 31
        ContactNumberLabel.Text = "মোবাইলঃ"
        ContactNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WebsiteLabel
        '
        WebsiteLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        WebsiteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        WebsiteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        WebsiteLabel.Location = New System.Drawing.Point(20, 109)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(123, 24)
        WebsiteLabel.TabIndex = 33
        WebsiteLabel.Text = "ওয়েবসাইটঃ"
        WebsiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailLabel
        '
        EmailLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        EmailLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        EmailLabel.Location = New System.Drawing.Point(20, 134)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(123, 24)
        EmailLabel.TabIndex = 35
        EmailLabel.Text = "ই-মেইলঃ"
        EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        SupplierIDLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SupplierIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SupplierIDLabel.Location = New System.Drawing.Point(20, 159)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(123, 24)
        SupplierIDLabel.TabIndex = 37
        SupplierIDLabel.Text = "কোম্পানির আইডিঃ"
        SupplierIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierNoteLabel
        '
        SupplierNoteLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        SupplierNoteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SupplierNoteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SupplierNoteLabel.Location = New System.Drawing.Point(20, 184)
        SupplierNoteLabel.Name = "SupplierNoteLabel"
        SupplierNoteLabel.Size = New System.Drawing.Size(123, 24)
        SupplierNoteLabel.TabIndex = 39
        SupplierNoteLabel.Text = "মন্তব্যঃ"
        SupplierNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DueLabel
        '
        DueLabel.BackColor = System.Drawing.Color.Black
        DueLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DueLabel.ForeColor = System.Drawing.Color.White
        DueLabel.Location = New System.Drawing.Point(41, 77)
        DueLabel.Name = "DueLabel"
        DueLabel.Size = New System.Drawing.Size(105, 24)
        DueLabel.TabIndex = 17
        DueLabel.Text = "বাকিঃ"
        DueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaidLabel
        '
        PaidLabel.BackColor = System.Drawing.Color.Black
        PaidLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PaidLabel.ForeColor = System.Drawing.Color.White
        PaidLabel.Location = New System.Drawing.Point(41, 52)
        PaidLabel.Name = "PaidLabel"
        PaidLabel.Size = New System.Drawing.Size(105, 24)
        PaidLabel.TabIndex = 18
        PaidLabel.Text = "পরিশোধঃ"
        PaidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaymentLabel
        '
        PaymentLabel.BackColor = System.Drawing.Color.Black
        PaymentLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PaymentLabel.ForeColor = System.Drawing.Color.White
        PaymentLabel.Location = New System.Drawing.Point(41, 27)
        PaymentLabel.Name = "PaymentLabel"
        PaymentLabel.Size = New System.Drawing.Size(105, 24)
        PaymentLabel.TabIndex = 19
        PaymentLabel.Text = "প্রদত্ত হিসাবঃ"
        PaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierNameLabel1
        '
        SupplierNameLabel1.AutoSize = True
        SupplierNameLabel1.Location = New System.Drawing.Point(683, 12)
        SupplierNameLabel1.Name = "SupplierNameLabel1"
        SupplierNameLabel1.Size = New System.Drawing.Size(77, 13)
        SupplierNameLabel1.TabIndex = 67
        SupplierNameLabel1.Text = "supplier Name:"
        '
        'SupplierIDLabel1
        '
        SupplierIDLabel1.AutoSize = True
        SupplierIDLabel1.Location = New System.Drawing.Point(683, 12)
        SupplierIDLabel1.Name = "SupplierIDLabel1"
        SupplierIDLabel1.Size = New System.Drawing.Size(60, 13)
        SupplierIDLabel1.TabIndex = 68
        SupplierIDLabel1.Text = "supplier ID:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(683, 12)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(31, 13)
        DateLabel.TabIndex = 72
        DateLabel.Text = "date:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "কোম্পানি যুক্ত করুন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSuppliersBindingSource
        '
        Me.TblSuppliersBindingSource.DataMember = "tblSuppliers"
        Me.TblSuppliersBindingSource.DataSource = Me.DataSet
        '
        'TblSuppliersTableAdapter
        '
        Me.TblSuppliersTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblSupplierAccountsTableAdapter = Me.TblSupplierAccountsTableAdapter
        Me.TableAdapterManager.tblSuppliersTableAdapter = Me.TblSuppliersTableAdapter
        Me.TableAdapterManager.tblTransactionReportTableAdapter = Nothing
        Me.TableAdapterManager.tblTransactionTableAdapter = Nothing
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSupplierAccountsTableAdapter
        '
        Me.TblSupplierAccountsTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chk_nonprofit)
        Me.Panel1.Controls.Add(Me.chk_add)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(SupplierNameLabel)
        Me.Panel1.Controls.Add(Me.SupplierNameTextBox)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(ContactPersonLabel)
        Me.Panel1.Controls.Add(Me.ContactPersonTextBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(ContactNumberLabel)
        Me.Panel1.Controls.Add(Me.ContactNumberTextBox)
        Me.Panel1.Controls.Add(WebsiteLabel)
        Me.Panel1.Controls.Add(Me.WebsiteTextBox)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(SupplierIDLabel)
        Me.Panel1.Controls.Add(Me.SupplierIDTextBox)
        Me.Panel1.Controls.Add(SupplierNoteLabel)
        Me.Panel1.Controls.Add(Me.SupplierNoteTextBox)
        Me.Panel1.Location = New System.Drawing.Point(263, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 458)
        Me.Panel1.TabIndex = 5
        '
        'chk_nonprofit
        '
        Me.chk_nonprofit.BackColor = System.Drawing.Color.Black
        Me.chk_nonprofit.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chk_nonprofit.ForeColor = System.Drawing.Color.White
        Me.chk_nonprofit.Location = New System.Drawing.Point(48, 215)
        Me.chk_nonprofit.Name = "chk_nonprofit"
        Me.chk_nonprofit.Padding = New System.Windows.Forms.Padding(50, 4, 4, 4)
        Me.chk_nonprofit.Size = New System.Drawing.Size(397, 42)
        Me.chk_nonprofit.TabIndex = 69
        Me.chk_nonprofit.Text = "মুনাফা বিহীন বিক্রয় পদ্ধতির অন্তর্ভুক্ত"
        Me.chk_nonprofit.UseVisualStyleBackColor = False
        '
        'chk_add
        '
        Me.chk_add.AutoSize = True
        Me.chk_add.BackColor = System.Drawing.Color.Black
        Me.chk_add.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chk_add.ForeColor = System.Drawing.Color.White
        Me.chk_add.Location = New System.Drawing.Point(155, 379)
        Me.chk_add.Name = "chk_add"
        Me.chk_add.Padding = New System.Windows.Forms.Padding(4)
        Me.chk_add.Size = New System.Drawing.Size(214, 35)
        Me.chk_add.TabIndex = 68
        Me.chk_add.Text = "বর্তমান হিসাব যুক্ত করুন"
        Me.chk_add.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(DueLabel)
        Me.GroupBox1.Controls.Add(PaidLabel)
        Me.GroupBox1.Controls.Add(PaymentLabel)
        Me.GroupBox1.Controls.Add(Me.DueTextBox)
        Me.GroupBox1.Controls.Add(Me.PaidTextBox)
        Me.GroupBox1.Controls.Add(Me.PaymentTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 113)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "বর্তমান হিসাব"
        '
        'DueTextBox
        '
        Me.DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "due", True))
        Me.DueTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DueTextBox.Location = New System.Drawing.Point(152, 77)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.Size = New System.Drawing.Size(290, 24)
        Me.DueTextBox.TabIndex = 72
        '
        'TblSupplierAccountsBindingSource
        '
        Me.TblSupplierAccountsBindingSource.DataMember = "tblSupplierAccounts"
        Me.TblSupplierAccountsBindingSource.DataSource = Me.DataSet
        '
        'PaidTextBox
        '
        Me.PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "paid", True))
        Me.PaidTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PaidTextBox.Location = New System.Drawing.Point(152, 52)
        Me.PaidTextBox.Name = "PaidTextBox"
        Me.PaidTextBox.Size = New System.Drawing.Size(290, 24)
        Me.PaidTextBox.TabIndex = 71
        '
        'PaymentTextBox
        '
        Me.PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "payment", True))
        Me.PaymentTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PaymentTextBox.Location = New System.Drawing.Point(152, 27)
        Me.PaymentTextBox.Name = "PaymentTextBox"
        Me.PaymentTextBox.Size = New System.Drawing.Size(290, 24)
        Me.PaymentTextBox.TabIndex = 70
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(391, 417)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 66
        Me.Button3.UseVisualStyleBackColor = False
        '
        'SupplierNameTextBox
        '
        Me.SupplierNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "supplierName", True))
        Me.SupplierNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SupplierNameTextBox.Location = New System.Drawing.Point(155, 10)
        Me.SupplierNameTextBox.Name = "SupplierNameTextBox"
        Me.SupplierNameTextBox.Size = New System.Drawing.Size(290, 24)
        Me.SupplierNameTextBox.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(155, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 35)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ContactPersonTextBox
        '
        Me.ContactPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "contactPerson", True))
        Me.ContactPersonTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ContactPersonTextBox.Location = New System.Drawing.Point(155, 35)
        Me.ContactPersonTextBox.Name = "ContactPersonTextBox"
        Me.ContactPersonTextBox.Size = New System.Drawing.Size(290, 24)
        Me.ContactPersonTextBox.TabIndex = 28
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(155, 60)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(290, 24)
        Me.AddressTextBox.TabIndex = 30
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "contactNumber", True))
        Me.ContactNumberTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(155, 85)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(290, 24)
        Me.ContactNumberTextBox.TabIndex = 32
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "website", True))
        Me.WebsiteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.WebsiteTextBox.Location = New System.Drawing.Point(155, 110)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(290, 24)
        Me.WebsiteTextBox.TabIndex = 34
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.EmailTextBox.Location = New System.Drawing.Point(155, 135)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(290, 24)
        Me.EmailTextBox.TabIndex = 36
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "supplierID", True))
        Me.SupplierIDTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(155, 160)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.ReadOnly = True
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(290, 24)
        Me.SupplierIDTextBox.TabIndex = 38
        '
        'SupplierNoteTextBox
        '
        Me.SupplierNoteTextBox.BackColor = System.Drawing.Color.White
        Me.SupplierNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "supplierNote", True))
        Me.SupplierNoteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SupplierNoteTextBox.Location = New System.Drawing.Point(155, 185)
        Me.SupplierNoteTextBox.Name = "SupplierNoteTextBox"
        Me.SupplierNoteTextBox.Size = New System.Drawing.Size(290, 24)
        Me.SupplierNoteTextBox.TabIndex = 40
        '
        'SupplierNameTextBox1
        '
        Me.SupplierNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "supplierName", True))
        Me.SupplierNameTextBox1.Location = New System.Drawing.Point(683, 12)
        Me.SupplierNameTextBox1.Name = "SupplierNameTextBox1"
        Me.SupplierNameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.SupplierNameTextBox1.TabIndex = 68
        '
        'SupplierIDTextBox1
        '
        Me.SupplierIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "supplierID", True))
        Me.SupplierIDTextBox1.Location = New System.Drawing.Point(683, 12)
        Me.SupplierIDTextBox1.Name = "SupplierIDTextBox1"
        Me.SupplierIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.SupplierIDTextBox1.TabIndex = 69
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSupplierAccountsBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(683, 12)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DateTextBox.TabIndex = 73
        '
        'Non_profitTextBox
        '
        Me.Non_profitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "non_profit", True))
        Me.Non_profitTextBox.Location = New System.Drawing.Point(25, 0)
        Me.Non_profitTextBox.Name = "Non_profitTextBox"
        Me.Non_profitTextBox.Size = New System.Drawing.Size(48, 20)
        Me.Non_profitTextBox.TabIndex = 74
        '
        'addSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(SupplierIDLabel1)
        Me.Controls.Add(Me.SupplierIDTextBox1)
        Me.Controls.Add(Me.SupplierNameTextBox1)
        Me.Controls.Add(SupplierNameLabel1)
        Me.Controls.Add(Me.Non_profitTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addSupplier"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblSupplierAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblSuppliersBindingSource As BindingSource
    Friend WithEvents TblSuppliersTableAdapter As dataSetTableAdapters.tblSuppliersTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SupplierNameTextBox As TextBox
    Friend WithEvents ContactPersonTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents ContactNumberTextBox As TextBox
    Friend WithEvents WebsiteTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents SupplierNoteTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TblSupplierAccountsBindingSource As BindingSource
    Friend WithEvents TblSupplierAccountsTableAdapter As dataSetTableAdapters.tblSupplierAccountsTableAdapter
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents SupplierIDTextBox1 As TextBox
    Friend WithEvents SupplierNameTextBox1 As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents PaidTextBox As TextBox
    Friend WithEvents PaymentTextBox As TextBox
    Friend WithEvents chk_add As CheckBox
    Friend WithEvents chk_nonprofit As CheckBox
    Friend WithEvents Non_profitTextBox As TextBox
End Class
