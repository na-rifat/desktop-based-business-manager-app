<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addDamageProducts
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
        Dim Product_nameLabel As System.Windows.Forms.Label
        Dim Product_categoryLabel As System.Windows.Forms.Label
        Dim CompanyLabel As System.Windows.Forms.Label
        Dim Damage_dateLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Unit_priceLabel As System.Windows.Forms.Label
        Dim Total_priceLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Invoice_noTextBox = New System.Windows.Forms.TextBox()
        Me.TblDamageProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.Damage_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Product_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_priceTextBox = New System.Windows.Forms.TextBox()
        Me.Product_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Product_categoryTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Total_priceTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DamageDateTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Damage_idTextBox = New System.Windows.Forms.TextBox()
        Me.TblExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductCodeTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Company_idTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.ProductCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierTextBox1 = New System.Windows.Forms.TextBox()
        Me.AvailableTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseNoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PersonNameTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseSubCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.BankamountTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentMethodComboBox = New System.Windows.Forms.ComboBox()
        Me.Payment_remarkTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblDamageProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblDamageProductsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblExpensesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpensesTableAdapter()
        Me.TblProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductsTableAdapter()
        Product_nameLabel = New System.Windows.Forms.Label()
        Product_categoryLabel = New System.Windows.Forms.Label()
        CompanyLabel = New System.Windows.Forms.Label()
        Damage_dateLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Unit_priceLabel = New System.Windows.Forms.Label()
        Total_priceLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblDamageProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Product_nameLabel
        '
        Product_nameLabel.BackColor = System.Drawing.Color.Black
        Product_nameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Product_nameLabel.ForeColor = System.Drawing.Color.White
        Product_nameLabel.Location = New System.Drawing.Point(17, 14)
        Product_nameLabel.Name = "Product_nameLabel"
        Product_nameLabel.Size = New System.Drawing.Size(141, 25)
        Product_nameLabel.TabIndex = 30
        Product_nameLabel.Text = "পণ্যের নামঃ"
        Product_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Product_categoryLabel
        '
        Product_categoryLabel.BackColor = System.Drawing.Color.Black
        Product_categoryLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Product_categoryLabel.ForeColor = System.Drawing.Color.White
        Product_categoryLabel.Location = New System.Drawing.Point(17, 40)
        Product_categoryLabel.Name = "Product_categoryLabel"
        Product_categoryLabel.Size = New System.Drawing.Size(141, 25)
        Product_categoryLabel.TabIndex = 34
        Product_categoryLabel.Text = "পণ্যের ধরনঃ"
        Product_categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyLabel
        '
        CompanyLabel.BackColor = System.Drawing.Color.Black
        CompanyLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CompanyLabel.ForeColor = System.Drawing.Color.White
        CompanyLabel.Location = New System.Drawing.Point(17, 66)
        CompanyLabel.Name = "CompanyLabel"
        CompanyLabel.Size = New System.Drawing.Size(141, 25)
        CompanyLabel.TabIndex = 36
        CompanyLabel.Text = "কোম্পানিঃ"
        CompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Damage_dateLabel
        '
        Damage_dateLabel.BackColor = System.Drawing.Color.Black
        Damage_dateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Damage_dateLabel.ForeColor = System.Drawing.Color.White
        Damage_dateLabel.Location = New System.Drawing.Point(17, 92)
        Damage_dateLabel.Name = "Damage_dateLabel"
        Damage_dateLabel.Size = New System.Drawing.Size(141, 25)
        Damage_dateLabel.TabIndex = 42
        Damage_dateLabel.Text = "ড্যামেজের তারিখঃ"
        Damage_dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QuantityLabel
        '
        QuantityLabel.BackColor = System.Drawing.Color.Black
        QuantityLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        QuantityLabel.ForeColor = System.Drawing.Color.White
        QuantityLabel.Location = New System.Drawing.Point(17, 144)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(141, 25)
        QuantityLabel.TabIndex = 44
        QuantityLabel.Text = "পরিমাণঃ"
        QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Unit_priceLabel
        '
        Unit_priceLabel.BackColor = System.Drawing.Color.Black
        Unit_priceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Unit_priceLabel.ForeColor = System.Drawing.Color.White
        Unit_priceLabel.Location = New System.Drawing.Point(17, 196)
        Unit_priceLabel.Name = "Unit_priceLabel"
        Unit_priceLabel.Size = New System.Drawing.Size(141, 25)
        Unit_priceLabel.TabIndex = 46
        Unit_priceLabel.Text = "মন্তব্যঃ"
        Unit_priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Total_priceLabel
        '
        Total_priceLabel.BackColor = System.Drawing.Color.Black
        Total_priceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Total_priceLabel.ForeColor = System.Drawing.Color.White
        Total_priceLabel.Location = New System.Drawing.Point(17, 170)
        Total_priceLabel.Name = "Total_priceLabel"
        Total_priceLabel.Size = New System.Drawing.Size(141, 25)
        Total_priceLabel.TabIndex = 48
        Total_priceLabel.Text = "দামঃ"
        Total_priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Black
        Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(17, 118)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(141, 25)
        Label2.TabIndex = 50
        Label2.Text = "দরঃ"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ড্যামেজ প্রোডাক্ট যুক্ত করুন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.Invoice_noTextBox)
        Me.Panel1.Controls.Add(Me.Damage_dateDateTimePicker)
        Me.Panel1.Controls.Add(Product_nameLabel)
        Me.Panel1.Controls.Add(Me.Product_nameTextBox)
        Me.Panel1.Controls.Add(Me.Unit_priceTextBox)
        Me.Panel1.Controls.Add(Me.Product_codeTextBox)
        Me.Panel1.Controls.Add(Product_categoryLabel)
        Me.Panel1.Controls.Add(Me.Product_categoryTextBox)
        Me.Panel1.Controls.Add(CompanyLabel)
        Me.Panel1.Controls.Add(Me.CompanyTextBox)
        Me.Panel1.Controls.Add(Damage_dateLabel)
        Me.Panel1.Controls.Add(QuantityLabel)
        Me.Panel1.Controls.Add(Me.QuantityTextBox)
        Me.Panel1.Controls.Add(Unit_priceLabel)
        Me.Panel1.Controls.Add(Total_priceLabel)
        Me.Panel1.Controls.Add(Me.Total_priceTextBox)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(252, 206)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 269)
        Me.Panel1.TabIndex = 5
        '
        'Invoice_noTextBox
        '
        Me.Invoice_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "invoice_no", True))
        Me.Invoice_noTextBox.Location = New System.Drawing.Point(164, 191)
        Me.Invoice_noTextBox.Name = "Invoice_noTextBox"
        Me.Invoice_noTextBox.Size = New System.Drawing.Size(215, 21)
        Me.Invoice_noTextBox.TabIndex = 7
        '
        'TblDamageProductsBindingSource
        '
        Me.TblDamageProductsBindingSource.DataMember = "tblDamageProducts"
        Me.TblDamageProductsBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Damage_dateDateTimePicker
        '
        Me.Damage_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblDamageProductsBindingSource, "damage_date", True))
        Me.Damage_dateDateTimePicker.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Damage_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Damage_dateDateTimePicker.Location = New System.Drawing.Point(164, 91)
        Me.Damage_dateDateTimePicker.Name = "Damage_dateDateTimePicker"
        Me.Damage_dateDateTimePicker.Size = New System.Drawing.Size(147, 24)
        Me.Damage_dateDateTimePicker.TabIndex = 7
        '
        'Product_nameTextBox
        '
        Me.Product_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "product_name", True))
        Me.Product_nameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Product_nameTextBox.Location = New System.Drawing.Point(164, 16)
        Me.Product_nameTextBox.Name = "Product_nameTextBox"
        Me.Product_nameTextBox.Size = New System.Drawing.Size(135, 24)
        Me.Product_nameTextBox.TabIndex = 31
        '
        'Unit_priceTextBox
        '
        Me.Unit_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "unit_price", True))
        Me.Unit_priceTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Unit_priceTextBox.Location = New System.Drawing.Point(164, 116)
        Me.Unit_priceTextBox.Name = "Unit_priceTextBox"
        Me.Unit_priceTextBox.Size = New System.Drawing.Size(147, 24)
        Me.Unit_priceTextBox.TabIndex = 47
        '
        'Product_codeTextBox
        '
        Me.Product_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "product_code", True))
        Me.Product_codeTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Product_codeTextBox.Location = New System.Drawing.Point(304, 16)
        Me.Product_codeTextBox.Name = "Product_codeTextBox"
        Me.Product_codeTextBox.Size = New System.Drawing.Size(75, 24)
        Me.Product_codeTextBox.TabIndex = 33
        '
        'Product_categoryTextBox
        '
        Me.Product_categoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "product_category", True))
        Me.Product_categoryTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Product_categoryTextBox.Location = New System.Drawing.Point(164, 41)
        Me.Product_categoryTextBox.Name = "Product_categoryTextBox"
        Me.Product_categoryTextBox.ReadOnly = True
        Me.Product_categoryTextBox.Size = New System.Drawing.Size(215, 24)
        Me.Product_categoryTextBox.TabIndex = 35
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "company", True))
        Me.CompanyTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CompanyTextBox.Location = New System.Drawing.Point(164, 66)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.ReadOnly = True
        Me.CompanyTextBox.Size = New System.Drawing.Size(215, 24)
        Me.CompanyTextBox.TabIndex = 37
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.QuantityTextBox.Location = New System.Drawing.Point(164, 141)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(147, 24)
        Me.QuantityTextBox.TabIndex = 45
        '
        'Total_priceTextBox
        '
        Me.Total_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "total_price", True))
        Me.Total_priceTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Total_priceTextBox.Location = New System.Drawing.Point(164, 166)
        Me.Total_priceTextBox.Name = "Total_priceTextBox"
        Me.Total_priceTextBox.ReadOnly = True
        Me.Total_priceTextBox.Size = New System.Drawing.Size(147, 24)
        Me.Total_priceTextBox.TabIndex = 49
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(344, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 28
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(164, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DamageDateTextBox
        '
        Me.DamageDateTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DamageDateTextBox.Location = New System.Drawing.Point(2, 3)
        Me.DamageDateTextBox.Name = "DamageDateTextBox"
        Me.DamageDateTextBox.Size = New System.Drawing.Size(34, 24)
        Me.DamageDateTextBox.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Damage_idTextBox)
        Me.Panel2.Controls.Add(Me.ProductCodeTextBox1)
        Me.Panel2.Controls.Add(Me.Company_idTextBox)
        Me.Panel2.Controls.Add(Me.ProductNameTextBox1)
        Me.Panel2.Controls.Add(Me.ProductCategoryTextBox)
        Me.Panel2.Controls.Add(Me.SupplierTextBox1)
        Me.Panel2.Controls.Add(Me.DamageDateTextBox)
        Me.Panel2.Controls.Add(Me.AvailableTextBox)
        Me.Panel2.Location = New System.Drawing.Point(3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(42, 27)
        Me.Panel2.TabIndex = 6
        '
        'Damage_idTextBox
        '
        Me.Damage_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "damage_id", True))
        Me.Damage_idTextBox.Location = New System.Drawing.Point(10, 11)
        Me.Damage_idTextBox.Name = "Damage_idTextBox"
        Me.Damage_idTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Damage_idTextBox.TabIndex = 29
        '
        'TblExpensesBindingSource
        '
        Me.TblExpensesBindingSource.DataMember = "tblExpenses"
        Me.TblExpensesBindingSource.DataSource = Me.DataSet
        '
        'ProductCodeTextBox1
        '
        Me.ProductCodeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productCode", True))
        Me.ProductCodeTextBox1.Location = New System.Drawing.Point(44, 17)
        Me.ProductCodeTextBox1.Name = "ProductCodeTextBox1"
        Me.ProductCodeTextBox1.Size = New System.Drawing.Size(21, 21)
        Me.ProductCodeTextBox1.TabIndex = 10
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.DataSet
        '
        'Company_idTextBox
        '
        Me.Company_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "company_id", True))
        Me.Company_idTextBox.Location = New System.Drawing.Point(3, 0)
        Me.Company_idTextBox.Name = "Company_idTextBox"
        Me.Company_idTextBox.Size = New System.Drawing.Size(100, 21)
        Me.Company_idTextBox.TabIndex = 7
        '
        'ProductNameTextBox1
        '
        Me.ProductNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productName", True))
        Me.ProductNameTextBox1.Location = New System.Drawing.Point(10, 6)
        Me.ProductNameTextBox1.Name = "ProductNameTextBox1"
        Me.ProductNameTextBox1.Size = New System.Drawing.Size(10, 21)
        Me.ProductNameTextBox1.TabIndex = 6
        '
        'ProductCategoryTextBox
        '
        Me.ProductCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productCategory", True))
        Me.ProductCategoryTextBox.Location = New System.Drawing.Point(26, 6)
        Me.ProductCategoryTextBox.Name = "ProductCategoryTextBox"
        Me.ProductCategoryTextBox.Size = New System.Drawing.Size(10, 21)
        Me.ProductCategoryTextBox.TabIndex = 7
        '
        'SupplierTextBox1
        '
        Me.SupplierTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "supplier", True))
        Me.SupplierTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.SupplierTextBox1.Name = "SupplierTextBox1"
        Me.SupplierTextBox1.Size = New System.Drawing.Size(33, 21)
        Me.SupplierTextBox1.TabIndex = 8
        '
        'AvailableTextBox
        '
        Me.AvailableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "available", True))
        Me.AvailableTextBox.Location = New System.Drawing.Point(2, 3)
        Me.AvailableTextBox.Name = "AvailableTextBox"
        Me.AvailableTextBox.Size = New System.Drawing.Size(34, 21)
        Me.AvailableTextBox.TabIndex = 9
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(724, 3)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(40, 21)
        Me.IdTextBox.TabIndex = 7
        '
        'ExpenseCategoryTextBox
        '
        Me.ExpenseCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseCategory", True))
        Me.ExpenseCategoryTextBox.Location = New System.Drawing.Point(724, 3)
        Me.ExpenseCategoryTextBox.Name = "ExpenseCategoryTextBox"
        Me.ExpenseCategoryTextBox.Size = New System.Drawing.Size(40, 21)
        Me.ExpenseCategoryTextBox.TabIndex = 9
        '
        'ExpenseNoteTextBox
        '
        Me.ExpenseNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseNote", True))
        Me.ExpenseNoteTextBox.Location = New System.Drawing.Point(724, 3)
        Me.ExpenseNoteTextBox.Name = "ExpenseNoteTextBox"
        Me.ExpenseNoteTextBox.Size = New System.Drawing.Size(40, 21)
        Me.ExpenseNoteTextBox.TabIndex = 11
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(724, 3)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(40, 21)
        Me.AmountTextBox.TabIndex = 13
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblExpensesBindingSource, "date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(724, 3)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(40, 21)
        Me.DateDateTimePicker.TabIndex = 15
        '
        'PersonNameTextBox
        '
        Me.PersonNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "personName", True))
        Me.PersonNameTextBox.Location = New System.Drawing.Point(724, 3)
        Me.PersonNameTextBox.Name = "PersonNameTextBox"
        Me.PersonNameTextBox.Size = New System.Drawing.Size(40, 21)
        Me.PersonNameTextBox.TabIndex = 17
        '
        'ExpenseSubCategoryTextBox
        '
        Me.ExpenseSubCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseSubCategory", True))
        Me.ExpenseSubCategoryTextBox.Location = New System.Drawing.Point(724, 3)
        Me.ExpenseSubCategoryTextBox.Name = "ExpenseSubCategoryTextBox"
        Me.ExpenseSubCategoryTextBox.Size = New System.Drawing.Size(40, 21)
        Me.ExpenseSubCategoryTextBox.TabIndex = 19
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "accNo", True))
        Me.AccNoTextBox.Location = New System.Drawing.Point(724, 3)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(40, 21)
        Me.AccNoTextBox.TabIndex = 21
        '
        'BankamountTextBox
        '
        Me.BankamountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "bankamount", True))
        Me.BankamountTextBox.Location = New System.Drawing.Point(724, 3)
        Me.BankamountTextBox.Name = "BankamountTextBox"
        Me.BankamountTextBox.Size = New System.Drawing.Size(40, 21)
        Me.BankamountTextBox.TabIndex = 23
        '
        'PaymentMethodComboBox
        '
        Me.PaymentMethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "paymentMethod", True))
        Me.PaymentMethodComboBox.FormattingEnabled = True
        Me.PaymentMethodComboBox.Location = New System.Drawing.Point(724, 3)
        Me.PaymentMethodComboBox.Name = "PaymentMethodComboBox"
        Me.PaymentMethodComboBox.Size = New System.Drawing.Size(40, 21)
        Me.PaymentMethodComboBox.TabIndex = 25
        '
        'Payment_remarkTextBox
        '
        Me.Payment_remarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "payment_remark", True))
        Me.Payment_remarkTextBox.Location = New System.Drawing.Point(724, 3)
        Me.Payment_remarkTextBox.Name = "Payment_remarkTextBox"
        Me.Payment_remarkTextBox.Size = New System.Drawing.Size(40, 21)
        Me.Payment_remarkTextBox.TabIndex = 27
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "Id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(724, 3)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(40, 21)
        Me.IdTextBox1.TabIndex = 28
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
        'TblExpensesTableAdapter
        '
        Me.TblExpensesTableAdapter.ClearBeforeFill = True
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'addDamageProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.ExpenseCategoryTextBox)
        Me.Controls.Add(Me.ExpenseNoteTextBox)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.PersonNameTextBox)
        Me.Controls.Add(Me.ExpenseSubCategoryTextBox)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Controls.Add(Me.BankamountTextBox)
        Me.Controls.Add(Me.PaymentMethodComboBox)
        Me.Controls.Add(Me.Payment_remarkTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addDamageProducts"
        Me.Text = "addDamageProducts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblDamageProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblDamageProductsBindingSource As BindingSource
    Friend WithEvents TblDamageProductsTableAdapter As dataSetTableAdapters.tblDamageProductsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DamageDateTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As dataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents ProductNameTextBox1 As TextBox
    Friend WithEvents ProductCategoryTextBox As TextBox
    Friend WithEvents SupplierTextBox1 As TextBox
    Friend WithEvents AvailableTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents ProductCodeTextBox1 As TextBox
    Friend WithEvents Product_nameTextBox As TextBox
    Friend WithEvents Product_codeTextBox As TextBox
    Friend WithEvents Product_categoryTextBox As TextBox
    Friend WithEvents CompanyTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Unit_priceTextBox As TextBox
    Friend WithEvents Total_priceTextBox As TextBox
    Friend WithEvents Damage_dateDateTimePicker As DateTimePicker
    Friend WithEvents Invoice_noTextBox As TextBox
    Friend WithEvents Company_idTextBox As TextBox
    Friend WithEvents TblExpensesBindingSource As BindingSource
    Friend WithEvents TblExpensesTableAdapter As dataSetTableAdapters.tblExpensesTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ExpenseCategoryTextBox As TextBox
    Friend WithEvents ExpenseNoteTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents PersonNameTextBox As TextBox
    Friend WithEvents ExpenseSubCategoryTextBox As TextBox
    Friend WithEvents AccNoTextBox As TextBox
    Friend WithEvents BankamountTextBox As TextBox
    Friend WithEvents PaymentMethodComboBox As ComboBox
    Friend WithEvents Payment_remarkTextBox As TextBox
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents Damage_idTextBox As TextBox
End Class
