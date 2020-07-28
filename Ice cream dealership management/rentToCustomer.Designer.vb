<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rentToCustomer
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
        Dim FridgeIDLabel As System.Windows.Forms.Label
        Dim FridgeModelNoLabel As System.Windows.Forms.Label
        Dim SupplierNameLabel As System.Windows.Forms.Label
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim FridgeConditionLabel As System.Windows.Forms.Label
        Dim MonthlyRentLabel As System.Windows.Forms.Label
        Dim SecurityMoneyLabel As System.Windows.Forms.Label
        Dim RentedAtLabel As System.Windows.Forms.Label
        Dim RentTOLabel As System.Windows.Forms.Label
        Dim RentedLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim RentedToIDLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkS = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CID = New System.Windows.Forms.TextBox()
        Me.MonthlyRentTextBox = New System.Windows.Forms.TextBox()
        Me.TblFridgesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.SecurityMoneyTextBox = New System.Windows.Forms.TextBox()
        Me.RentTOTextBox = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.FridgeConditionLabel1 = New System.Windows.Forms.Label()
        Me.IssueDateLabel1 = New System.Windows.Forms.Label()
        Me.SupplierNameLabel1 = New System.Windows.Forms.Label()
        Me.FridgeModelNoLabel1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FridgeIDTextBox = New System.Windows.Forms.TextBox()
        Me.RentedToIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.RentedTextBox = New System.Windows.Forms.TextBox()
        Me.RentedAtTextBox = New System.Windows.Forms.TextBox()
        Me.TblFridgesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblFridgesTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblCustomersTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblCustomersTableAdapter()
        Me.ShopOrCompanyNameTextBox = New System.Windows.Forms.TextBox()
        FridgeIDLabel = New System.Windows.Forms.Label()
        FridgeModelNoLabel = New System.Windows.Forms.Label()
        SupplierNameLabel = New System.Windows.Forms.Label()
        IssueDateLabel = New System.Windows.Forms.Label()
        FridgeConditionLabel = New System.Windows.Forms.Label()
        MonthlyRentLabel = New System.Windows.Forms.Label()
        SecurityMoneyLabel = New System.Windows.Forms.Label()
        RentedAtLabel = New System.Windows.Forms.Label()
        RentTOLabel = New System.Windows.Forms.Label()
        RentedLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        RentedToIDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FridgeIDLabel
        '
        FridgeIDLabel.BackColor = System.Drawing.Color.Black
        FridgeIDLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        FridgeIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        FridgeIDLabel.Location = New System.Drawing.Point(22, 25)
        FridgeIDLabel.Name = "FridgeIDLabel"
        FridgeIDLabel.Size = New System.Drawing.Size(145, 25)
        FridgeIDLabel.TabIndex = 4
        FridgeIDLabel.Text = "ফ্রিজের আই.ডি.:"
        FridgeIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FridgeModelNoLabel
        '
        FridgeModelNoLabel.BackColor = System.Drawing.Color.Black
        FridgeModelNoLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        FridgeModelNoLabel.ForeColor = System.Drawing.Color.White
        FridgeModelNoLabel.Location = New System.Drawing.Point(22, 51)
        FridgeModelNoLabel.Name = "FridgeModelNoLabel"
        FridgeModelNoLabel.Size = New System.Drawing.Size(145, 25)
        FridgeModelNoLabel.TabIndex = 10
        FridgeModelNoLabel.Text = "ফ্রিজের মডেল নং:"
        FridgeModelNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierNameLabel
        '
        SupplierNameLabel.BackColor = System.Drawing.Color.Black
        SupplierNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SupplierNameLabel.ForeColor = System.Drawing.Color.White
        SupplierNameLabel.Location = New System.Drawing.Point(22, 77)
        SupplierNameLabel.Name = "SupplierNameLabel"
        SupplierNameLabel.Size = New System.Drawing.Size(145, 25)
        SupplierNameLabel.TabIndex = 12
        SupplierNameLabel.Text = "কোম্পানিঃ"
        SupplierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IssueDateLabel
        '
        IssueDateLabel.BackColor = System.Drawing.Color.Black
        IssueDateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        IssueDateLabel.ForeColor = System.Drawing.Color.White
        IssueDateLabel.Location = New System.Drawing.Point(22, 103)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(145, 25)
        IssueDateLabel.TabIndex = 14
        IssueDateLabel.Text = "ইস্যু/ক্রয়ের তারিখঃ"
        IssueDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FridgeConditionLabel
        '
        FridgeConditionLabel.BackColor = System.Drawing.Color.Black
        FridgeConditionLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        FridgeConditionLabel.ForeColor = System.Drawing.Color.White
        FridgeConditionLabel.Location = New System.Drawing.Point(22, 129)
        FridgeConditionLabel.Name = "FridgeConditionLabel"
        FridgeConditionLabel.Size = New System.Drawing.Size(145, 25)
        FridgeConditionLabel.TabIndex = 16
        FridgeConditionLabel.Text = "ফ্রিজের কন্ডিশন"
        FridgeConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MonthlyRentLabel
        '
        MonthlyRentLabel.BackColor = System.Drawing.Color.Black
        MonthlyRentLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        MonthlyRentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        MonthlyRentLabel.Location = New System.Drawing.Point(3, 95)
        MonthlyRentLabel.Name = "MonthlyRentLabel"
        MonthlyRentLabel.Size = New System.Drawing.Size(132, 25)
        MonthlyRentLabel.TabIndex = 16
        MonthlyRentLabel.Text = "মাসিক ভাড়াঃ"
        MonthlyRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SecurityMoneyLabel
        '
        SecurityMoneyLabel.BackColor = System.Drawing.Color.Black
        SecurityMoneyLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SecurityMoneyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SecurityMoneyLabel.Location = New System.Drawing.Point(3, 69)
        SecurityMoneyLabel.Name = "SecurityMoneyLabel"
        SecurityMoneyLabel.Size = New System.Drawing.Size(132, 25)
        SecurityMoneyLabel.TabIndex = 14
        SecurityMoneyLabel.Text = "জামানতঃ"
        SecurityMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RentedAtLabel
        '
        RentedAtLabel.BackColor = System.Drawing.Color.Black
        RentedAtLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        RentedAtLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        RentedAtLabel.Location = New System.Drawing.Point(3, 43)
        RentedAtLabel.Name = "RentedAtLabel"
        RentedAtLabel.Size = New System.Drawing.Size(132, 25)
        RentedAtLabel.TabIndex = 12
        RentedAtLabel.Text = "প্রদানের তারিখঃ"
        RentedAtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RentTOLabel
        '
        RentTOLabel.BackColor = System.Drawing.Color.Black
        RentTOLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        RentTOLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        RentTOLabel.Location = New System.Drawing.Point(3, 17)
        RentTOLabel.Name = "RentTOLabel"
        RentTOLabel.Size = New System.Drawing.Size(132, 25)
        RentTOLabel.TabIndex = 10
        RentTOLabel.Text = "দোকানের নামঃ"
        RentTOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RentedLabel
        '
        RentedLabel.AutoSize = True
        RentedLabel.Location = New System.Drawing.Point(12, 6)
        RentedLabel.Name = "RentedLabel"
        RentedLabel.Size = New System.Drawing.Size(49, 13)
        RentedLabel.TabIndex = 17
        RentedLabel.Text = "rented:"
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(12, 6)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(102, 13)
        CustomerNameLabel.TabIndex = 57
        CustomerNameLabel.Text = "customer Name:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(12, 6)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(83, 13)
        CustomerIDLabel.TabIndex = 58
        CustomerIDLabel.Text = "customer ID:"
        '
        'RentedToIDLabel
        '
        RentedToIDLabel.AutoSize = True
        RentedToIDLabel.Location = New System.Drawing.Point(12, 6)
        RentedToIDLabel.Name = "RentedToIDLabel"
        RentedToIDLabel.Size = New System.Drawing.Size(85, 13)
        RentedToIDLabel.TabIndex = 59
        RentedToIDLabel.Text = "rented To ID:"
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
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "গ্রাহককে ভাড়ায় ফ্রিজ প্রদান করুন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(FridgeConditionLabel)
        Me.Panel1.Controls.Add(Me.FridgeConditionLabel1)
        Me.Panel1.Controls.Add(IssueDateLabel)
        Me.Panel1.Controls.Add(Me.IssueDateLabel1)
        Me.Panel1.Controls.Add(SupplierNameLabel)
        Me.Panel1.Controls.Add(Me.SupplierNameLabel1)
        Me.Panel1.Controls.Add(FridgeModelNoLabel)
        Me.Panel1.Controls.Add(Me.FridgeModelNoLabel1)
        Me.Panel1.Controls.Add(FridgeIDLabel)
        Me.Panel1.Location = New System.Drawing.Point(216, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 358)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkS)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.CID)
        Me.Panel2.Controls.Add(MonthlyRentLabel)
        Me.Panel2.Controls.Add(Me.MonthlyRentTextBox)
        Me.Panel2.Controls.Add(SecurityMoneyLabel)
        Me.Panel2.Controls.Add(Me.SecurityMoneyTextBox)
        Me.Panel2.Controls.Add(RentedAtLabel)
        Me.Panel2.Controls.Add(RentTOLabel)
        Me.Panel2.Controls.Add(Me.RentTOTextBox)
        Me.Panel2.Location = New System.Drawing.Point(32, 168)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 170)
        Me.Panel2.TabIndex = 19
        '
        'chkS
        '
        Me.chkS.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkS.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chkS.Location = New System.Drawing.Point(388, 95)
        Me.chkS.Name = "chkS"
        Me.chkS.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        Me.chkS.Size = New System.Drawing.Size(123, 23)
        Me.chkS.TabIndex = 73
        Me.chkS.Text = "ফ্রি"
        Me.chkS.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(342, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 63
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(141, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(241, 24)
        Me.DateTimePicker1.TabIndex = 62
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(141, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 32)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "প্রদান করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CID
        '
        Me.CID.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CID.Location = New System.Drawing.Point(388, 19)
        Me.CID.Name = "CID"
        Me.CID.Size = New System.Drawing.Size(123, 24)
        Me.CID.TabIndex = 20
        '
        'MonthlyRentTextBox
        '
        Me.MonthlyRentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "monthlyRent", True))
        Me.MonthlyRentTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MonthlyRentTextBox.Location = New System.Drawing.Point(141, 94)
        Me.MonthlyRentTextBox.Name = "MonthlyRentTextBox"
        Me.MonthlyRentTextBox.Size = New System.Drawing.Size(241, 24)
        Me.MonthlyRentTextBox.TabIndex = 17
        '
        'TblFridgesBindingSource
        '
        Me.TblFridgesBindingSource.DataMember = "tblFridges"
        Me.TblFridgesBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SecurityMoneyTextBox
        '
        Me.SecurityMoneyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "securityMoney", True))
        Me.SecurityMoneyTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SecurityMoneyTextBox.Location = New System.Drawing.Point(141, 69)
        Me.SecurityMoneyTextBox.Name = "SecurityMoneyTextBox"
        Me.SecurityMoneyTextBox.Size = New System.Drawing.Size(370, 24)
        Me.SecurityMoneyTextBox.TabIndex = 15
        '
        'RentTOTextBox
        '
        Me.RentTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rentTO", True))
        Me.RentTOTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RentTOTextBox.Location = New System.Drawing.Point(141, 19)
        Me.RentTOTextBox.Name = "RentTOTextBox"
        Me.RentTOTextBox.Size = New System.Drawing.Size(241, 24)
        Me.RentTOTextBox.TabIndex = 11
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtID.Location = New System.Drawing.Point(173, 26)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(280, 24)
        Me.txtID.TabIndex = 18
        '
        'FridgeConditionLabel1
        '
        Me.FridgeConditionLabel1.BackColor = System.Drawing.Color.Black
        Me.FridgeConditionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeCondition", True))
        Me.FridgeConditionLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FridgeConditionLabel1.ForeColor = System.Drawing.Color.White
        Me.FridgeConditionLabel1.Location = New System.Drawing.Point(173, 129)
        Me.FridgeConditionLabel1.Name = "FridgeConditionLabel1"
        Me.FridgeConditionLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.FridgeConditionLabel1.Size = New System.Drawing.Size(280, 25)
        Me.FridgeConditionLabel1.TabIndex = 17
        Me.FridgeConditionLabel1.Text = "NaN"
        '
        'IssueDateLabel1
        '
        Me.IssueDateLabel1.BackColor = System.Drawing.Color.Black
        Me.IssueDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "issueDate", True))
        Me.IssueDateLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.IssueDateLabel1.ForeColor = System.Drawing.Color.White
        Me.IssueDateLabel1.Location = New System.Drawing.Point(173, 103)
        Me.IssueDateLabel1.Name = "IssueDateLabel1"
        Me.IssueDateLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.IssueDateLabel1.Size = New System.Drawing.Size(280, 25)
        Me.IssueDateLabel1.TabIndex = 15
        Me.IssueDateLabel1.Text = "NaN"
        '
        'SupplierNameLabel1
        '
        Me.SupplierNameLabel1.BackColor = System.Drawing.Color.Black
        Me.SupplierNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "supplierName", True))
        Me.SupplierNameLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SupplierNameLabel1.ForeColor = System.Drawing.Color.White
        Me.SupplierNameLabel1.Location = New System.Drawing.Point(173, 77)
        Me.SupplierNameLabel1.Name = "SupplierNameLabel1"
        Me.SupplierNameLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.SupplierNameLabel1.Size = New System.Drawing.Size(280, 25)
        Me.SupplierNameLabel1.TabIndex = 13
        Me.SupplierNameLabel1.Text = "NaN"
        '
        'FridgeModelNoLabel1
        '
        Me.FridgeModelNoLabel1.BackColor = System.Drawing.Color.Black
        Me.FridgeModelNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeModelNo", True))
        Me.FridgeModelNoLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FridgeModelNoLabel1.ForeColor = System.Drawing.Color.White
        Me.FridgeModelNoLabel1.Location = New System.Drawing.Point(173, 51)
        Me.FridgeModelNoLabel1.Name = "FridgeModelNoLabel1"
        Me.FridgeModelNoLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.FridgeModelNoLabel1.Size = New System.Drawing.Size(280, 25)
        Me.FridgeModelNoLabel1.TabIndex = 11
        Me.FridgeModelNoLabel1.Text = "NaN"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(12, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(25, 23)
        Me.Panel3.TabIndex = 61
        '
        'FridgeIDTextBox
        '
        Me.FridgeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeID", True))
        Me.FridgeIDTextBox.Location = New System.Drawing.Point(12, 6)
        Me.FridgeIDTextBox.Name = "FridgeIDTextBox"
        Me.FridgeIDTextBox.Size = New System.Drawing.Size(10, 21)
        Me.FridgeIDTextBox.TabIndex = 22
        '
        'RentedToIDTextBox
        '
        Me.RentedToIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rentedToID", True))
        Me.RentedToIDTextBox.Location = New System.Drawing.Point(12, 6)
        Me.RentedToIDTextBox.Name = "RentedToIDTextBox"
        Me.RentedToIDTextBox.Size = New System.Drawing.Size(10, 21)
        Me.RentedToIDTextBox.TabIndex = 60
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "customerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(12, 6)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(10, 21)
        Me.CustomerIDTextBox.TabIndex = 59
        '
        'TblCustomersBindingSource
        '
        Me.TblCustomersBindingSource.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource.DataSource = Me.DataSet
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(12, 6)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(10, 21)
        Me.CustomerNameTextBox.TabIndex = 58
        '
        'RentedTextBox
        '
        Me.RentedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rented", True))
        Me.RentedTextBox.Location = New System.Drawing.Point(12, 6)
        Me.RentedTextBox.Name = "RentedTextBox"
        Me.RentedTextBox.Size = New System.Drawing.Size(10, 21)
        Me.RentedTextBox.TabIndex = 18
        '
        'RentedAtTextBox
        '
        Me.RentedAtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rentedAt", True))
        Me.RentedAtTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RentedAtTextBox.Location = New System.Drawing.Point(12, 6)
        Me.RentedAtTextBox.Name = "RentedAtTextBox"
        Me.RentedAtTextBox.Size = New System.Drawing.Size(10, 24)
        Me.RentedAtTextBox.TabIndex = 13
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
        'TblCustomersTableAdapter
        '
        Me.TblCustomersTableAdapter.ClearBeforeFill = True
        '
        'ShopOrCompanyNameTextBox
        '
        Me.ShopOrCompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "shopOrCompanyName", True))
        Me.ShopOrCompanyNameTextBox.Location = New System.Drawing.Point(170, 8)
        Me.ShopOrCompanyNameTextBox.Name = "ShopOrCompanyNameTextBox"
        Me.ShopOrCompanyNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ShopOrCompanyNameTextBox.TabIndex = 22
        '
        'rentToCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShopOrCompanyNameTextBox)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FridgeIDTextBox)
        Me.Controls.Add(Me.RentedAtTextBox)
        Me.Controls.Add(RentedToIDLabel)
        Me.Controls.Add(Me.RentedTextBox)
        Me.Controls.Add(Me.RentedToIDTextBox)
        Me.Controls.Add(RentedLabel)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(CustomerNameLabel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rentToCustomer"
        Me.Text = "rentToCustomer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblFridgesBindingSource As BindingSource
    Friend WithEvents TblFridgesTableAdapter As dataSetTableAdapters.tblFridgesTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtID As TextBox
    Friend WithEvents FridgeConditionLabel1 As Label
    Friend WithEvents IssueDateLabel1 As Label
    Friend WithEvents SupplierNameLabel1 As Label
    Friend WithEvents FridgeModelNoLabel1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MonthlyRentTextBox As TextBox
    Friend WithEvents SecurityMoneyTextBox As TextBox
    Friend WithEvents RentedAtTextBox As TextBox
    Friend WithEvents RentTOTextBox As TextBox
    Friend WithEvents RentedTextBox As TextBox
    Friend WithEvents CID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TblCustomersBindingSource As BindingSource
    Friend WithEvents TblCustomersTableAdapter As dataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents RentedToIDTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FridgeIDTextBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents chkS As CheckBox
    Friend WithEvents ShopOrCompanyNameTextBox As TextBox
End Class
