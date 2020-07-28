<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sell_on_commission
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
        Dim Invoice_noLabel As System.Windows.Forms.Label
        Dim Customer_nameLabel As System.Windows.Forms.Label
        Dim Customer_idLabel As System.Windows.Forms.Label
        Dim Company_nameLabel As System.Windows.Forms.Label
        Dim Company_idLabel As System.Windows.Forms.Label
        Dim SupplierNameLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim ProductCodeLabel As System.Windows.Forms.Label
        Dim SupplierNameLabel1 As System.Windows.Forms.Label
        Dim SupplierIDLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sell_on_commission))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.chk_product = New System.Windows.Forms.CheckBox()
        Me.chk_company = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.txt_comany_id = New System.Windows.Forms.TextBox()
        Me.txt_product = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_company = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TblsellcommissionDataGridView = New System.Windows.Forms.DataGridView()
        Me.TblsellcommissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.Company_idLabel1 = New System.Windows.Forms.Label()
        Me.Company_nameLabel1 = New System.Windows.Forms.Label()
        Me.Customer_idLabel1 = New System.Windows.Forms.Label()
        Me.Customer_nameLabel1 = New System.Windows.Forms.Label()
        Me.Invoice_noLabel1 = New System.Windows.Forms.Label()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblSuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblsellcommissionTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblsellcommissionTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductsTableAdapter()
        Me.TblSuppliersTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblSuppliersTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toDt = New System.Windows.Forms.DateTimePicker()
        Me.fromDt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.confirmation_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Invoice_noLabel = New System.Windows.Forms.Label()
        Customer_nameLabel = New System.Windows.Forms.Label()
        Customer_idLabel = New System.Windows.Forms.Label()
        Company_nameLabel = New System.Windows.Forms.Label()
        Company_idLabel = New System.Windows.Forms.Label()
        SupplierNameLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        ProductCodeLabel = New System.Windows.Forms.Label()
        SupplierNameLabel1 = New System.Windows.Forms.Label()
        SupplierIDLabel1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblsellcommissionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsellcommissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Invoice_noLabel
        '
        Invoice_noLabel.BackColor = System.Drawing.Color.Black
        Invoice_noLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Invoice_noLabel.ForeColor = System.Drawing.Color.White
        Invoice_noLabel.Location = New System.Drawing.Point(114, 83)
        Invoice_noLabel.Name = "Invoice_noLabel"
        Invoice_noLabel.Size = New System.Drawing.Size(131, 25)
        Invoice_noLabel.TabIndex = 106
        Invoice_noLabel.Text = "বিক্রয় রশিদ নং:"
        Invoice_noLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler Invoice_noLabel.Click, AddressOf Me.Invoice_noLabel_Click
        '
        'Customer_nameLabel
        '
        Customer_nameLabel.BackColor = System.Drawing.Color.Black
        Customer_nameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Customer_nameLabel.ForeColor = System.Drawing.Color.White
        Customer_nameLabel.Location = New System.Drawing.Point(114, 109)
        Customer_nameLabel.Name = "Customer_nameLabel"
        Customer_nameLabel.Size = New System.Drawing.Size(131, 25)
        Customer_nameLabel.TabIndex = 108
        Customer_nameLabel.Text = "দোকানের নামঃ"
        Customer_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler Customer_nameLabel.Click, AddressOf Me.Customer_nameLabel_Click
        '
        'Customer_idLabel
        '
        Customer_idLabel.BackColor = System.Drawing.Color.Black
        Customer_idLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Customer_idLabel.ForeColor = System.Drawing.Color.White
        Customer_idLabel.Location = New System.Drawing.Point(114, 135)
        Customer_idLabel.Name = "Customer_idLabel"
        Customer_idLabel.Size = New System.Drawing.Size(131, 25)
        Customer_idLabel.TabIndex = 109
        Customer_idLabel.Text = "দোকানের আই.ডি.:"
        Customer_idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler Customer_idLabel.Click, AddressOf Me.Customer_idLabel_Click
        '
        'Company_nameLabel
        '
        Company_nameLabel.BackColor = System.Drawing.Color.Black
        Company_nameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Company_nameLabel.ForeColor = System.Drawing.Color.White
        Company_nameLabel.Location = New System.Drawing.Point(114, 161)
        Company_nameLabel.Name = "Company_nameLabel"
        Company_nameLabel.Size = New System.Drawing.Size(131, 25)
        Company_nameLabel.TabIndex = 110
        Company_nameLabel.Text = "কোম্পানিঃ"
        Company_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler Company_nameLabel.Click, AddressOf Me.Company_nameLabel_Click
        '
        'Company_idLabel
        '
        Company_idLabel.BackColor = System.Drawing.Color.Black
        Company_idLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Company_idLabel.ForeColor = System.Drawing.Color.White
        Company_idLabel.Location = New System.Drawing.Point(114, 187)
        Company_idLabel.Name = "Company_idLabel"
        Company_idLabel.Size = New System.Drawing.Size(131, 25)
        Company_idLabel.TabIndex = 111
        Company_idLabel.Text = "কোম্পানির আই.ডি.:"
        Company_idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler Company_idLabel.Click, AddressOf Me.Company_idLabel_Click
        '
        'SupplierNameLabel
        '
        SupplierNameLabel.AutoSize = True
        SupplierNameLabel.Location = New System.Drawing.Point(12, 9)
        SupplierNameLabel.Name = "SupplierNameLabel"
        SupplierNameLabel.Size = New System.Drawing.Size(77, 13)
        SupplierNameLabel.TabIndex = 117
        SupplierNameLabel.Text = "supplier Name:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(12, 9)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(60, 13)
        SupplierIDLabel.TabIndex = 118
        SupplierIDLabel.Text = "supplier ID:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(12, 9)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(77, 13)
        ProductNameLabel.TabIndex = 119
        ProductNameLabel.Text = "product Name:"
        '
        'ProductCodeLabel
        '
        ProductCodeLabel.AutoSize = True
        ProductCodeLabel.Location = New System.Drawing.Point(12, 9)
        ProductCodeLabel.Name = "ProductCodeLabel"
        ProductCodeLabel.Size = New System.Drawing.Size(74, 13)
        ProductCodeLabel.TabIndex = 120
        ProductCodeLabel.Text = "product Code:"
        '
        'SupplierNameLabel1
        '
        SupplierNameLabel1.AutoSize = True
        SupplierNameLabel1.Location = New System.Drawing.Point(15, 12)
        SupplierNameLabel1.Name = "SupplierNameLabel1"
        SupplierNameLabel1.Size = New System.Drawing.Size(77, 13)
        SupplierNameLabel1.TabIndex = 117
        SupplierNameLabel1.Text = "supplier Name:"
        '
        'SupplierIDLabel1
        '
        SupplierIDLabel1.AutoSize = True
        SupplierIDLabel1.Location = New System.Drawing.Point(15, 12)
        SupplierIDLabel1.Name = "SupplierIDLabel1"
        SupplierIDLabel1.Size = New System.Drawing.Size(60, 13)
        SupplierIDLabel1.TabIndex = 118
        SupplierIDLabel1.Text = "supplier ID:"
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
        Me.Label1.Text = "কমিশন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TblsellcommissionDataGridView)
        Me.Panel1.Controls.Add(Company_idLabel)
        Me.Panel1.Controls.Add(Me.Company_idLabel1)
        Me.Panel1.Controls.Add(Company_nameLabel)
        Me.Panel1.Controls.Add(Me.Company_nameLabel1)
        Me.Panel1.Controls.Add(Customer_idLabel)
        Me.Panel1.Controls.Add(Me.Customer_idLabel1)
        Me.Panel1.Controls.Add(Customer_nameLabel)
        Me.Panel1.Controls.Add(Me.Customer_nameLabel1)
        Me.Panel1.Controls.Add(Invoice_noLabel)
        Me.Panel1.Controls.Add(Me.Invoice_noLabel1)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Location = New System.Drawing.Point(6, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 541)
        Me.Panel1.TabIndex = 98
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.toDt)
        Me.GroupBox1.Controls.Add(Me.fromDt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.chk_product)
        Me.GroupBox1.Controls.Add(Me.chk_company)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_product_id)
        Me.GroupBox1.Controls.Add(Me.txt_comany_id)
        Me.GroupBox1.Controls.Add(Me.txt_product)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_company)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(462, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 240)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "অপশন"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Button5.Location = New System.Drawing.Point(64, 184)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 50)
        Me.Button5.TabIndex = 138
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Button3.Location = New System.Drawing.Point(292, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 137
        Me.Button3.UseVisualStyleBackColor = True
        '
        'chk_product
        '
        Me.chk_product.AutoSize = True
        Me.chk_product.BackColor = System.Drawing.Color.White
        Me.chk_product.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chk_product.Location = New System.Drawing.Point(146, 155)
        Me.chk_product.Name = "chk_product"
        Me.chk_product.Padding = New System.Windows.Forms.Padding(4)
        Me.chk_product.Size = New System.Drawing.Size(23, 22)
        Me.chk_product.TabIndex = 136
        Me.chk_product.UseVisualStyleBackColor = False
        '
        'chk_company
        '
        Me.chk_company.AutoSize = True
        Me.chk_company.BackColor = System.Drawing.Color.White
        Me.chk_company.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chk_company.Location = New System.Drawing.Point(146, 102)
        Me.chk_company.Name = "chk_company"
        Me.chk_company.Padding = New System.Windows.Forms.Padding(4)
        Me.chk_company.Size = New System.Drawing.Size(23, 22)
        Me.chk_company.TabIndex = 135
        Me.chk_company.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Button2.Location = New System.Drawing.Point(8, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 134
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(120, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 50)
        Me.Button1.TabIndex = 133
        Me.Button1.Text = "কমিশন কনফার্ম করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_product_id
        '
        Me.txt_product_id.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txt_product_id.Location = New System.Drawing.Point(332, 154)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.Size = New System.Drawing.Size(65, 24)
        Me.txt_product_id.TabIndex = 132
        '
        'txt_comany_id
        '
        Me.txt_comany_id.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txt_comany_id.Location = New System.Drawing.Point(332, 101)
        Me.txt_comany_id.Name = "txt_comany_id"
        Me.txt_comany_id.Size = New System.Drawing.Size(65, 24)
        Me.txt_comany_id.TabIndex = 131
        '
        'txt_product
        '
        Me.txt_product.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txt_product.Location = New System.Drawing.Point(171, 154)
        Me.txt_product.Name = "txt_product"
        Me.txt_product.Size = New System.Drawing.Size(155, 24)
        Me.txt_product.TabIndex = 129
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(147, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 25)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "পণ্যের নামঃ"
        '
        'txt_company
        '
        Me.txt_company.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txt_company.Location = New System.Drawing.Point(171, 101)
        Me.txt_company.Name = "txt_company"
        Me.txt_company.Size = New System.Drawing.Size(155, 24)
        Me.txt_company.TabIndex = 127
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(147, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 25)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "কোম্পানির নামঃ"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Button4.Location = New System.Drawing.Point(347, 184)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 50)
        Me.Button4.TabIndex = 126
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TblsellcommissionDataGridView
        '
        Me.TblsellcommissionDataGridView.AutoGenerateColumns = False
        Me.TblsellcommissionDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TblsellcommissionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblsellcommissionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn3, Me.confirmation_date})
        Me.TblsellcommissionDataGridView.DataSource = Me.TblsellcommissionBindingSource
        Me.TblsellcommissionDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblsellcommissionDataGridView.Location = New System.Drawing.Point(0, 250)
        Me.TblsellcommissionDataGridView.Name = "TblsellcommissionDataGridView"
        Me.TblsellcommissionDataGridView.Size = New System.Drawing.Size(982, 266)
        Me.TblsellcommissionDataGridView.TabIndex = 112
        '
        'TblsellcommissionBindingSource
        '
        Me.TblsellcommissionBindingSource.DataMember = "tblsellcommission"
        Me.TblsellcommissionBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Company_idLabel1
        '
        Me.Company_idLabel1.BackColor = System.Drawing.Color.Black
        Me.Company_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblsellcommissionBindingSource, "company_id", True))
        Me.Company_idLabel1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company_idLabel1.ForeColor = System.Drawing.Color.White
        Me.Company_idLabel1.Location = New System.Drawing.Point(251, 187)
        Me.Company_idLabel1.Name = "Company_idLabel1"
        Me.Company_idLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Company_idLabel1.Size = New System.Drawing.Size(205, 25)
        Me.Company_idLabel1.TabIndex = 112
        Me.Company_idLabel1.Text = "-------"
        '
        'Company_nameLabel1
        '
        Me.Company_nameLabel1.BackColor = System.Drawing.Color.Black
        Me.Company_nameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblsellcommissionBindingSource, "company_name", True))
        Me.Company_nameLabel1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company_nameLabel1.ForeColor = System.Drawing.Color.White
        Me.Company_nameLabel1.Location = New System.Drawing.Point(251, 161)
        Me.Company_nameLabel1.Name = "Company_nameLabel1"
        Me.Company_nameLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Company_nameLabel1.Size = New System.Drawing.Size(205, 25)
        Me.Company_nameLabel1.TabIndex = 111
        Me.Company_nameLabel1.Text = "-------"
        '
        'Customer_idLabel1
        '
        Me.Customer_idLabel1.BackColor = System.Drawing.Color.Black
        Me.Customer_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblsellcommissionBindingSource, "customer_id", True))
        Me.Customer_idLabel1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_idLabel1.ForeColor = System.Drawing.Color.White
        Me.Customer_idLabel1.Location = New System.Drawing.Point(251, 135)
        Me.Customer_idLabel1.Name = "Customer_idLabel1"
        Me.Customer_idLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Customer_idLabel1.Size = New System.Drawing.Size(205, 25)
        Me.Customer_idLabel1.TabIndex = 110
        Me.Customer_idLabel1.Text = "-------"
        '
        'Customer_nameLabel1
        '
        Me.Customer_nameLabel1.BackColor = System.Drawing.Color.Black
        Me.Customer_nameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblsellcommissionBindingSource, "customer_name", True))
        Me.Customer_nameLabel1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_nameLabel1.ForeColor = System.Drawing.Color.White
        Me.Customer_nameLabel1.Location = New System.Drawing.Point(251, 109)
        Me.Customer_nameLabel1.Name = "Customer_nameLabel1"
        Me.Customer_nameLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Customer_nameLabel1.Size = New System.Drawing.Size(205, 25)
        Me.Customer_nameLabel1.TabIndex = 109
        Me.Customer_nameLabel1.Text = "-------"
        '
        'Invoice_noLabel1
        '
        Me.Invoice_noLabel1.BackColor = System.Drawing.Color.Black
        Me.Invoice_noLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblsellcommissionBindingSource, "invoice_no", True))
        Me.Invoice_noLabel1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_noLabel1.ForeColor = System.Drawing.Color.White
        Me.Invoice_noLabel1.Location = New System.Drawing.Point(251, 83)
        Me.Invoice_noLabel1.Name = "Invoice_noLabel1"
        Me.Invoice_noLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Invoice_noLabel1.Size = New System.Drawing.Size(205, 25)
        Me.Invoice_noLabel1.TabIndex = 107
        Me.Invoice_noLabel1.Text = "-------"
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 516)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(982, 25)
        Me.tool.TabIndex = 120
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(141, 22)
        Me.ToolStripLabel3.Text = "Total commission: "
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(12, 9)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProductNameTextBox.TabIndex = 120
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.DataSet
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productCode", True))
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(12, 9)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProductCodeTextBox.TabIndex = 121
        '
        'SupplierNameTextBox
        '
        Me.SupplierNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "supplierName", True))
        Me.SupplierNameTextBox.Location = New System.Drawing.Point(15, 12)
        Me.SupplierNameTextBox.Name = "SupplierNameTextBox"
        Me.SupplierNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SupplierNameTextBox.TabIndex = 118
        '
        'TblSuppliersBindingSource
        '
        Me.TblSuppliersBindingSource.DataMember = "tblSuppliers"
        Me.TblSuppliersBindingSource.DataSource = Me.DataSet
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "supplierID", True))
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(15, 12)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SupplierIDTextBox.TabIndex = 119
        '
        'TblsellcommissionTableAdapter
        '
        Me.TblsellcommissionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblPurchaseInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseReportTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseTableAdapter = Nothing
        Me.TableAdapterManager.tblRentCSTableAdapter = Nothing
        Me.TableAdapterManager.tblRentCTableAdapter = Nothing
        Me.TableAdapterManager.tblRentSTableAdapter = Nothing
        Me.TableAdapterManager.tblSalesreportTableAdapter = Nothing
        Me.TableAdapterManager.tblSalesTableAdapter = Nothing
        Me.TableAdapterManager.tblSCommissionTableAdapter = Nothing
        Me.TableAdapterManager.tblsellcommissionTableAdapter = Me.TblsellcommissionTableAdapter
        Me.TableAdapterManager.tblSignboardTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblSuppliersTableAdapter = Me.TblSuppliersTableAdapter
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
        'TblSuppliersTableAdapter
        '
        Me.TblSuppliersTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(274, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "পর্যন্ত"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'toDt
        '
        Me.toDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.toDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.toDt.Location = New System.Drawing.Point(146, 46)
        Me.toDt.Name = "toDt"
        Me.toDt.Size = New System.Drawing.Size(127, 24)
        Me.toDt.TabIndex = 141
        '
        'fromDt
        '
        Me.fromDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.fromDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDt.Location = New System.Drawing.Point(146, 21)
        Me.fromDt.Name = "fromDt"
        Me.fromDt.Size = New System.Drawing.Size(127, 24)
        Me.fromDt.TabIndex = 140
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(274, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "থেকে-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "product_name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "পণ্যের নাম"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "product_id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "কোড"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "unit_price"
        Me.DataGridViewTextBoxColumn10.HeaderText = "দর"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "profit"
        Me.DataGridViewTextBoxColumn11.HeaderText = "লভ্যাংশ"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn12.HeaderText = "পরিমাণ"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "earned_commission"
        Me.DataGridViewTextBoxColumn13.HeaderText = "অর্জিত কমিশন"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "confirmation"
        Me.DataGridViewTextBoxColumn14.HeaderText = "কনফারমেশন"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'confirmation_date
        '
        Me.confirmation_date.DataPropertyName = "confirmation_date"
        Me.confirmation_date.HeaderText = "confirmation_date"
        Me.confirmation_date.Name = "confirmation_date"
        Me.confirmation_date.Visible = False
        '
        'sell_on_commission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ProductCodeLabel)
        Me.Controls.Add(Me.ProductCodeTextBox)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(SupplierNameLabel)
        Me.Controls.Add(SupplierIDLabel1)
        Me.Controls.Add(Me.SupplierIDTextBox)
        Me.Controls.Add(SupplierNameLabel1)
        Me.Controls.Add(Me.SupplierNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sell_on_commission"
        Me.Text = "sell_on_commission"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblsellcommissionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsellcommissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblsellcommissionBindingSource As BindingSource
    Friend WithEvents TblsellcommissionTableAdapter As dataSetTableAdapters.tblsellcommissionTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Company_idLabel1 As Label
    Friend WithEvents Company_nameLabel1 As Label
    Friend WithEvents Customer_idLabel1 As Label
    Friend WithEvents Customer_nameLabel1 As Label
    Friend WithEvents Invoice_noLabel1 As Label
    Friend WithEvents TblsellcommissionDataGridView As DataGridView
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As dataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents TblSuppliersBindingSource As BindingSource
    Friend WithEvents TblSuppliersTableAdapter As dataSetTableAdapters.tblSuppliersTableAdapter
    Friend WithEvents SupplierNameTextBox As TextBox
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents chk_product As CheckBox
    Friend WithEvents chk_company As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_product_id As TextBox
    Friend WithEvents txt_comany_id As TextBox
    Friend WithEvents txt_product As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_company As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents toDt As DateTimePicker
    Friend WithEvents fromDt As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents confirmation_date As DataGridViewTextBoxColumn
End Class
