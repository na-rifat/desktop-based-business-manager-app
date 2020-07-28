<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createUser
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
        Dim SalesLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim RoleLabel As System.Windows.Forms.Label
        Dim IncomeLabel As System.Windows.Forms.Label
        Dim FridgeLabel As System.Windows.Forms.Label
        Dim SuppliersLabel As System.Windows.Forms.Label
        Dim PurchaseLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim ProductsLabel As System.Windows.Forms.Label
        Dim ExpensesLabel As System.Windows.Forms.Label
        Dim BankTransactionLabel As System.Windows.Forms.Label
        Dim DamageProductsLabel As System.Windows.Forms.Label
        Dim ReportsNdateLabel As System.Windows.Forms.Label
        Dim DsahBoardLabel As System.Windows.Forms.Label
        Dim EmplpoyeeLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RoleTextBox = New System.Windows.Forms.TextBox()
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkOthers = New System.Windows.Forms.CheckBox()
        Me.chkFridge = New System.Windows.Forms.CheckBox()
        Me.chkReports = New System.Windows.Forms.CheckBox()
        Me.chkIncome = New System.Windows.Forms.CheckBox()
        Me.chkExpenses = New System.Windows.Forms.CheckBox()
        Me.chkTransaction = New System.Windows.Forms.CheckBox()
        Me.chkPurchase = New System.Windows.Forms.CheckBox()
        Me.chkSales = New System.Windows.Forms.CheckBox()
        Me.chkProducts = New System.Windows.Forms.CheckBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FridgeTextBox = New System.Windows.Forms.TextBox()
        Me.BankTransactionTextBox = New System.Windows.Forms.TextBox()
        Me.ExpensesTextBox = New System.Windows.Forms.TextBox()
        Me.SuppliersTextBox = New System.Windows.Forms.TextBox()
        Me.RemarkTextBox = New System.Windows.Forms.TextBox()
        Me.ReportsNdateTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaseTextBox = New System.Windows.Forms.TextBox()
        Me.ProductsTextBox = New System.Windows.Forms.TextBox()
        Me.DamageProductsTextBox = New System.Windows.Forms.TextBox()
        Me.DsahBoardTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTextBox = New System.Windows.Forms.TextBox()
        Me.EmplpoyeeTextBox = New System.Windows.Forms.TextBox()
        Me.OthersTextBox = New System.Windows.Forms.TextBox()
        Me.TblUserTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblUserTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        SalesLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        RoleLabel = New System.Windows.Forms.Label()
        IncomeLabel = New System.Windows.Forms.Label()
        FridgeLabel = New System.Windows.Forms.Label()
        SuppliersLabel = New System.Windows.Forms.Label()
        PurchaseLabel = New System.Windows.Forms.Label()
        RemarkLabel = New System.Windows.Forms.Label()
        ProductsLabel = New System.Windows.Forms.Label()
        ExpensesLabel = New System.Windows.Forms.Label()
        BankTransactionLabel = New System.Windows.Forms.Label()
        DamageProductsLabel = New System.Windows.Forms.Label()
        ReportsNdateLabel = New System.Windows.Forms.Label()
        DsahBoardLabel = New System.Windows.Forms.Label()
        EmplpoyeeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesLabel
        '
        SalesLabel.AutoSize = True
        SalesLabel.Location = New System.Drawing.Point(6, 14)
        SalesLabel.Name = "SalesLabel"
        SalesLabel.Size = New System.Drawing.Size(34, 13)
        SalesLabel.TabIndex = 24
        SalesLabel.Text = "sales:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.BackColor = System.Drawing.Color.Black
        UserNameLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        UserNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        UserNameLabel.Location = New System.Drawing.Point(6, 13)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Padding = New System.Windows.Forms.Padding(4)
        UserNameLabel.Size = New System.Drawing.Size(97, 25)
        UserNameLabel.TabIndex = 50
        UserNameLabel.Text = "User name:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.BackColor = System.Drawing.Color.Black
        UserIDLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        UserIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        UserIDLabel.Location = New System.Drawing.Point(28, 39)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Padding = New System.Windows.Forms.Padding(4)
        UserIDLabel.Size = New System.Drawing.Size(75, 25)
        UserIDLabel.TabIndex = 52
        UserIDLabel.Text = "User ID:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.Color.Black
        PasswordLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PasswordLabel.Location = New System.Drawing.Point(14, 65)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Padding = New System.Windows.Forms.Padding(4)
        PasswordLabel.Size = New System.Drawing.Size(89, 25)
        PasswordLabel.TabIndex = 54
        PasswordLabel.Text = "Password:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Black
        AddressLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        AddressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AddressLabel.Location = New System.Drawing.Point(23, 91)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Padding = New System.Windows.Forms.Padding(4)
        AddressLabel.Size = New System.Drawing.Size(80, 25)
        AddressLabel.TabIndex = 56
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.Black
        PhoneLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        PhoneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PhoneLabel.Location = New System.Drawing.Point(38, 117)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Padding = New System.Windows.Forms.Padding(4)
        PhoneLabel.Size = New System.Drawing.Size(65, 25)
        PhoneLabel.TabIndex = 58
        PhoneLabel.Text = "Phone:"
        '
        'RoleLabel
        '
        RoleLabel.AutoSize = True
        RoleLabel.BackColor = System.Drawing.Color.Black
        RoleLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        RoleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        RoleLabel.Location = New System.Drawing.Point(51, 143)
        RoleLabel.Name = "RoleLabel"
        RoleLabel.Padding = New System.Windows.Forms.Padding(4)
        RoleLabel.Size = New System.Drawing.Size(52, 25)
        RoleLabel.TabIndex = 60
        RoleLabel.Text = "Role:"
        '
        'IncomeLabel
        '
        IncomeLabel.AutoSize = True
        IncomeLabel.Location = New System.Drawing.Point(6, 14)
        IncomeLabel.Name = "IncomeLabel"
        IncomeLabel.Size = New System.Drawing.Size(44, 13)
        IncomeLabel.TabIndex = 61
        IncomeLabel.Text = "income:"
        AddHandler IncomeLabel.Click, AddressOf Me.IncomeLabel_Click
        '
        'FridgeLabel
        '
        FridgeLabel.AutoSize = True
        FridgeLabel.Location = New System.Drawing.Point(6, 14)
        FridgeLabel.Name = "FridgeLabel"
        FridgeLabel.Size = New System.Drawing.Size(36, 13)
        FridgeLabel.TabIndex = 67
        FridgeLabel.Text = "fridge:"
        '
        'SuppliersLabel
        '
        SuppliersLabel.AutoSize = True
        SuppliersLabel.Location = New System.Drawing.Point(6, 14)
        SuppliersLabel.Name = "SuppliersLabel"
        SuppliersLabel.Size = New System.Drawing.Size(51, 13)
        SuppliersLabel.TabIndex = 55
        SuppliersLabel.Text = "suppliers:"
        AddHandler SuppliersLabel.Click, AddressOf Me.SuppliersLabel_Click
        '
        'PurchaseLabel
        '
        PurchaseLabel.AutoSize = True
        PurchaseLabel.Location = New System.Drawing.Point(6, 14)
        PurchaseLabel.Name = "PurchaseLabel"
        PurchaseLabel.Size = New System.Drawing.Size(54, 13)
        PurchaseLabel.TabIndex = 53
        PurchaseLabel.Text = "purchase:"
        '
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.Location = New System.Drawing.Point(6, 14)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(42, 13)
        RemarkLabel.TabIndex = 73
        RemarkLabel.Text = "remark:"
        '
        'ProductsLabel
        '
        ProductsLabel.AutoSize = True
        ProductsLabel.Location = New System.Drawing.Point(6, 14)
        ProductsLabel.Name = "ProductsLabel"
        ProductsLabel.Size = New System.Drawing.Size(51, 13)
        ProductsLabel.TabIndex = 50
        ProductsLabel.Text = "products:"
        '
        'ExpensesLabel
        '
        ExpensesLabel.AutoSize = True
        ExpensesLabel.Location = New System.Drawing.Point(6, 14)
        ExpensesLabel.Name = "ExpensesLabel"
        ExpensesLabel.Size = New System.Drawing.Size(55, 13)
        ExpensesLabel.TabIndex = 59
        ExpensesLabel.Text = "expenses:"
        '
        'BankTransactionLabel
        '
        BankTransactionLabel.AutoSize = True
        BankTransactionLabel.Location = New System.Drawing.Point(6, 14)
        BankTransactionLabel.Name = "BankTransactionLabel"
        BankTransactionLabel.Size = New System.Drawing.Size(93, 13)
        BankTransactionLabel.TabIndex = 57
        BankTransactionLabel.Text = "bank Transaction:"
        AddHandler BankTransactionLabel.Click, AddressOf Me.BankTransactionLabel_Click
        '
        'DamageProductsLabel
        '
        DamageProductsLabel.AutoSize = True
        DamageProductsLabel.Location = New System.Drawing.Point(6, 14)
        DamageProductsLabel.Name = "DamageProductsLabel"
        DamageProductsLabel.Size = New System.Drawing.Size(93, 13)
        DamageProductsLabel.TabIndex = 69
        DamageProductsLabel.Text = "damage Products:"
        '
        'ReportsNdateLabel
        '
        ReportsNdateLabel.AutoSize = True
        ReportsNdateLabel.Location = New System.Drawing.Point(6, 14)
        ReportsNdateLabel.Name = "ReportsNdateLabel"
        ReportsNdateLabel.Size = New System.Drawing.Size(74, 13)
        ReportsNdateLabel.TabIndex = 65
        ReportsNdateLabel.Text = "reports Ndate:"
        '
        'DsahBoardLabel
        '
        DsahBoardLabel.AutoSize = True
        DsahBoardLabel.Location = New System.Drawing.Point(6, 14)
        DsahBoardLabel.Name = "DsahBoardLabel"
        DsahBoardLabel.Size = New System.Drawing.Size(64, 13)
        DsahBoardLabel.TabIndex = 71
        DsahBoardLabel.Text = "dsah Board:"
        '
        'EmplpoyeeLabel
        '
        EmplpoyeeLabel.AutoSize = True
        EmplpoyeeLabel.Location = New System.Drawing.Point(6, 14)
        EmplpoyeeLabel.Name = "EmplpoyeeLabel"
        EmplpoyeeLabel.Size = New System.Drawing.Size(61, 13)
        EmplpoyeeLabel.TabIndex = 63
        EmplpoyeeLabel.Text = "emplpoyee:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Create new user"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(RoleLabel)
        Me.Panel1.Controls.Add(Me.RoleTextBox)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(UserNameLabel)
        Me.Panel1.Controls.Add(Me.UserNameTextBox)
        Me.Panel1.Controls.Add(UserIDLabel)
        Me.Panel1.Controls.Add(Me.UserIDTextBox)
        Me.Panel1.Controls.Add(PasswordLabel)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(PhoneLabel)
        Me.Panel1.Controls.Add(Me.PhoneTextBox)
        Me.Panel1.Location = New System.Drawing.Point(139, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 211)
        Me.Panel1.TabIndex = 48
        '
        'RoleTextBox
        '
        Me.RoleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "role", True))
        Me.RoleTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RoleTextBox.Location = New System.Drawing.Point(109, 140)
        Me.RoleTextBox.Name = "RoleTextBox"
        Me.RoleTextBox.Size = New System.Drawing.Size(273, 24)
        Me.RoleTextBox.TabIndex = 61
        '
        'TblUserBindingSource
        '
        Me.TblUserBindingSource.DataMember = "tblUser"
        Me.TblUserBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(109, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 35)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkOthers)
        Me.GroupBox1.Controls.Add(Me.chkFridge)
        Me.GroupBox1.Controls.Add(Me.chkReports)
        Me.GroupBox1.Controls.Add(Me.chkIncome)
        Me.GroupBox1.Controls.Add(Me.chkExpenses)
        Me.GroupBox1.Controls.Add(Me.chkTransaction)
        Me.GroupBox1.Controls.Add(Me.chkPurchase)
        Me.GroupBox1.Controls.Add(Me.chkSales)
        Me.GroupBox1.Controls.Add(Me.chkProducts)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(388, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 190)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Access permission"
        '
        'chkOthers
        '
        Me.chkOthers.AutoSize = True
        Me.chkOthers.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkOthers.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkOthers.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkOthers.Location = New System.Drawing.Point(145, 120)
        Me.chkOthers.Name = "chkOthers"
        Me.chkOthers.Padding = New System.Windows.Forms.Padding(4)
        Me.chkOthers.Size = New System.Drawing.Size(83, 29)
        Me.chkOthers.TabIndex = 72
        Me.chkOthers.Text = "Others"
        Me.chkOthers.UseVisualStyleBackColor = False
        '
        'chkFridge
        '
        Me.chkFridge.AutoSize = True
        Me.chkFridge.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkFridge.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkFridge.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkFridge.Location = New System.Drawing.Point(22, 120)
        Me.chkFridge.Name = "chkFridge"
        Me.chkFridge.Padding = New System.Windows.Forms.Padding(4)
        Me.chkFridge.Size = New System.Drawing.Size(78, 29)
        Me.chkFridge.TabIndex = 69
        Me.chkFridge.Text = "Fridge"
        Me.chkFridge.UseVisualStyleBackColor = False
        '
        'chkReports
        '
        Me.chkReports.AutoSize = True
        Me.chkReports.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkReports.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkReports.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkReports.Location = New System.Drawing.Point(145, 90)
        Me.chkReports.Name = "chkReports"
        Me.chkReports.Padding = New System.Windows.Forms.Padding(4)
        Me.chkReports.Size = New System.Drawing.Size(158, 29)
        Me.chkReports.TabIndex = 68
        Me.chkReports.Text = "Reports and data"
        Me.chkReports.UseVisualStyleBackColor = False
        '
        'chkIncome
        '
        Me.chkIncome.AutoSize = True
        Me.chkIncome.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkIncome.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkIncome.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkIncome.Location = New System.Drawing.Point(22, 150)
        Me.chkIncome.Name = "chkIncome"
        Me.chkIncome.Padding = New System.Windows.Forms.Padding(4)
        Me.chkIncome.Size = New System.Drawing.Size(86, 29)
        Me.chkIncome.TabIndex = 66
        Me.chkIncome.Text = "Income"
        Me.chkIncome.UseVisualStyleBackColor = False
        '
        'chkExpenses
        '
        Me.chkExpenses.AutoSize = True
        Me.chkExpenses.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkExpenses.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkExpenses.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkExpenses.Location = New System.Drawing.Point(145, 30)
        Me.chkExpenses.Name = "chkExpenses"
        Me.chkExpenses.Padding = New System.Windows.Forms.Padding(4)
        Me.chkExpenses.Size = New System.Drawing.Size(103, 29)
        Me.chkExpenses.TabIndex = 65
        Me.chkExpenses.Text = "Expenses"
        Me.chkExpenses.UseVisualStyleBackColor = False
        '
        'chkTransaction
        '
        Me.chkTransaction.AutoSize = True
        Me.chkTransaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkTransaction.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkTransaction.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkTransaction.Location = New System.Drawing.Point(145, 60)
        Me.chkTransaction.Name = "chkTransaction"
        Me.chkTransaction.Padding = New System.Windows.Forms.Padding(4)
        Me.chkTransaction.Size = New System.Drawing.Size(154, 29)
        Me.chkTransaction.TabIndex = 64
        Me.chkTransaction.Text = "Bank transaction"
        Me.chkTransaction.UseVisualStyleBackColor = False
        '
        'chkPurchase
        '
        Me.chkPurchase.AutoSize = True
        Me.chkPurchase.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkPurchase.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkPurchase.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkPurchase.Location = New System.Drawing.Point(22, 60)
        Me.chkPurchase.Name = "chkPurchase"
        Me.chkPurchase.Padding = New System.Windows.Forms.Padding(4)
        Me.chkPurchase.Size = New System.Drawing.Size(98, 29)
        Me.chkPurchase.TabIndex = 62
        Me.chkPurchase.Text = "Purchase"
        Me.chkPurchase.UseVisualStyleBackColor = False
        '
        'chkSales
        '
        Me.chkSales.AutoSize = True
        Me.chkSales.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkSales.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkSales.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkSales.Location = New System.Drawing.Point(22, 90)
        Me.chkSales.Name = "chkSales"
        Me.chkSales.Padding = New System.Windows.Forms.Padding(4)
        Me.chkSales.Size = New System.Drawing.Size(72, 29)
        Me.chkSales.TabIndex = 61
        Me.chkSales.Text = "Sales"
        Me.chkSales.UseVisualStyleBackColor = False
        '
        'chkProducts
        '
        Me.chkProducts.AutoSize = True
        Me.chkProducts.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkProducts.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chkProducts.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkProducts.Location = New System.Drawing.Point(22, 30)
        Me.chkProducts.Name = "chkProducts"
        Me.chkProducts.Padding = New System.Windows.Forms.Padding(4)
        Me.chkProducts.Size = New System.Drawing.Size(97, 29)
        Me.chkProducts.TabIndex = 60
        Me.chkProducts.Text = "Products"
        Me.chkProducts.UseVisualStyleBackColor = False
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "userName", True))
        Me.UserNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.UserNameTextBox.Location = New System.Drawing.Point(109, 15)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(273, 24)
        Me.UserNameTextBox.TabIndex = 51
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "userID", True))
        Me.UserIDTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.UserIDTextBox.Location = New System.Drawing.Point(109, 40)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(273, 24)
        Me.UserIDTextBox.TabIndex = 53
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PasswordTextBox.Location = New System.Drawing.Point(109, 65)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(273, 24)
        Me.PasswordTextBox.TabIndex = 55
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(109, 90)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(273, 24)
        Me.AddressTextBox.TabIndex = 57
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PhoneTextBox.Location = New System.Drawing.Point(109, 115)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(273, 24)
        Me.PhoneTextBox.TabIndex = 59
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(6, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(110, 32)
        Me.Panel2.TabIndex = 75
        '
        'FridgeTextBox
        '
        Me.FridgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "fridge", True))
        Me.FridgeTextBox.Location = New System.Drawing.Point(6, 14)
        Me.FridgeTextBox.Name = "FridgeTextBox"
        Me.FridgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FridgeTextBox.TabIndex = 68
        '
        'BankTransactionTextBox
        '
        Me.BankTransactionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "bankTransaction", True))
        Me.BankTransactionTextBox.Location = New System.Drawing.Point(6, 14)
        Me.BankTransactionTextBox.Name = "BankTransactionTextBox"
        Me.BankTransactionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BankTransactionTextBox.TabIndex = 58
        '
        'ExpensesTextBox
        '
        Me.ExpensesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "expenses", True))
        Me.ExpensesTextBox.Location = New System.Drawing.Point(6, 14)
        Me.ExpensesTextBox.Name = "ExpensesTextBox"
        Me.ExpensesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExpensesTextBox.TabIndex = 60
        '
        'SuppliersTextBox
        '
        Me.SuppliersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "suppliers", True))
        Me.SuppliersTextBox.Location = New System.Drawing.Point(6, 14)
        Me.SuppliersTextBox.Name = "SuppliersTextBox"
        Me.SuppliersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SuppliersTextBox.TabIndex = 56
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "remark", True))
        Me.RemarkTextBox.Location = New System.Drawing.Point(6, 14)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RemarkTextBox.TabIndex = 74
        '
        'ReportsNdateTextBox
        '
        Me.ReportsNdateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "reportsNdate", True))
        Me.ReportsNdateTextBox.Location = New System.Drawing.Point(6, 14)
        Me.ReportsNdateTextBox.Name = "ReportsNdateTextBox"
        Me.ReportsNdateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReportsNdateTextBox.TabIndex = 66
        '
        'PurchaseTextBox
        '
        Me.PurchaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "purchase", True))
        Me.PurchaseTextBox.Location = New System.Drawing.Point(6, 14)
        Me.PurchaseTextBox.Name = "PurchaseTextBox"
        Me.PurchaseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PurchaseTextBox.TabIndex = 54
        '
        'ProductsTextBox
        '
        Me.ProductsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "products", True))
        Me.ProductsTextBox.Location = New System.Drawing.Point(6, 14)
        Me.ProductsTextBox.Name = "ProductsTextBox"
        Me.ProductsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProductsTextBox.TabIndex = 51
        '
        'DamageProductsTextBox
        '
        Me.DamageProductsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "damageProducts", True))
        Me.DamageProductsTextBox.Location = New System.Drawing.Point(6, 14)
        Me.DamageProductsTextBox.Name = "DamageProductsTextBox"
        Me.DamageProductsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DamageProductsTextBox.TabIndex = 70
        '
        'DsahBoardTextBox
        '
        Me.DsahBoardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "dsahBoard", True))
        Me.DsahBoardTextBox.Location = New System.Drawing.Point(6, 14)
        Me.DsahBoardTextBox.Name = "DsahBoardTextBox"
        Me.DsahBoardTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DsahBoardTextBox.TabIndex = 72
        '
        'IncomeTextBox
        '
        Me.IncomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "income", True))
        Me.IncomeTextBox.Location = New System.Drawing.Point(6, 14)
        Me.IncomeTextBox.Name = "IncomeTextBox"
        Me.IncomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IncomeTextBox.TabIndex = 62
        '
        'SalesTextBox
        '
        Me.SalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "sales", True))
        Me.SalesTextBox.Location = New System.Drawing.Point(6, 14)
        Me.SalesTextBox.Name = "SalesTextBox"
        Me.SalesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalesTextBox.TabIndex = 52
        '
        'EmplpoyeeTextBox
        '
        Me.EmplpoyeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "emplpoyee", True))
        Me.EmplpoyeeTextBox.Location = New System.Drawing.Point(6, 14)
        Me.EmplpoyeeTextBox.Name = "EmplpoyeeTextBox"
        Me.EmplpoyeeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmplpoyeeTextBox.TabIndex = 64
        '
        'OthersTextBox
        '
        Me.OthersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "others", True))
        Me.OthersTextBox.Location = New System.Drawing.Point(6, 14)
        Me.OthersTextBox.Name = "OthersTextBox"
        Me.OthersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OthersTextBox.TabIndex = 72
        '
        'TblUserTableAdapter
        '
        Me.TblUserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        'createUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FridgeTextBox)
        Me.Controls.Add(Me.OthersTextBox)
        Me.Controls.Add(Me.EmplpoyeeTextBox)
        Me.Controls.Add(DsahBoardLabel)
        Me.Controls.Add(Me.SalesTextBox)
        Me.Controls.Add(ReportsNdateLabel)
        Me.Controls.Add(EmplpoyeeLabel)
        Me.Controls.Add(Me.IncomeTextBox)
        Me.Controls.Add(Me.DsahBoardTextBox)
        Me.Controls.Add(IncomeLabel)
        Me.Controls.Add(Me.DamageProductsTextBox)
        Me.Controls.Add(FridgeLabel)
        Me.Controls.Add(Me.ProductsTextBox)
        Me.Controls.Add(Me.PurchaseTextBox)
        Me.Controls.Add(SuppliersLabel)
        Me.Controls.Add(SalesLabel)
        Me.Controls.Add(PurchaseLabel)
        Me.Controls.Add(Me.ReportsNdateTextBox)
        Me.Controls.Add(RemarkLabel)
        Me.Controls.Add(Me.RemarkTextBox)
        Me.Controls.Add(ProductsLabel)
        Me.Controls.Add(DamageProductsLabel)
        Me.Controls.Add(Me.BankTransactionTextBox)
        Me.Controls.Add(Me.SuppliersTextBox)
        Me.Controls.Add(ExpensesLabel)
        Me.Controls.Add(BankTransactionLabel)
        Me.Controls.Add(Me.ExpensesTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "createUser"
        Me.Text = "createUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblUserBindingSource As BindingSource
    Friend WithEvents TblUserTableAdapter As dataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents RoleTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FridgeTextBox As TextBox
    Friend WithEvents BankTransactionTextBox As TextBox
    Friend WithEvents ExpensesTextBox As TextBox
    Friend WithEvents SuppliersTextBox As TextBox
    Friend WithEvents RemarkTextBox As TextBox
    Friend WithEvents ReportsNdateTextBox As TextBox
    Friend WithEvents PurchaseTextBox As TextBox
    Friend WithEvents DamageProductsTextBox As TextBox
    Friend WithEvents IncomeTextBox As TextBox
    Friend WithEvents EmplpoyeeTextBox As TextBox
    Friend WithEvents SalesTextBox As TextBox
    Friend WithEvents DsahBoardTextBox As TextBox
    Friend WithEvents ProductsTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OthersTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkOthers As CheckBox
    Friend WithEvents chkFridge As CheckBox
    Friend WithEvents chkReports As CheckBox
    Friend WithEvents chkIncome As CheckBox
    Friend WithEvents chkExpenses As CheckBox
    Friend WithEvents chkTransaction As CheckBox
    Friend WithEvents chkPurchase As CheckBox
    Friend WithEvents chkSales As CheckBox
    Friend WithEvents chkProducts As CheckBox
End Class
