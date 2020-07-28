<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addProducts
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
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim ProductCategoryLabel As System.Windows.Forms.Label
        Dim ProductCodeLabel As System.Windows.Forms.Label
        Dim SupplierLabel As System.Windows.Forms.Label
        Dim PurchasePriceLabel As System.Windows.Forms.Label
        Dim SellPriceLabel As System.Windows.Forms.Label
        Dim ProfitLabel As System.Windows.Forms.Label
        Dim AlertQuantityLabel As System.Windows.Forms.Label
        Dim AvailableLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.AvailableTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.AlertQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.ProductImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProfitTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProductCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.PurchasePriceTextBox = New System.Windows.Forms.TextBox()
        Me.SellPriceTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblSuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblProductCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductCategoryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductCategoryTableAdapter()
        Me.TblSuppliersTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblSuppliersTableAdapter()
        Me.chk_nondis = New System.Windows.Forms.CheckBox()
        Me.Non_discountTextBox = New System.Windows.Forms.TextBox()
        ProductNameLabel = New System.Windows.Forms.Label()
        ProductCategoryLabel = New System.Windows.Forms.Label()
        ProductCodeLabel = New System.Windows.Forms.Label()
        SupplierLabel = New System.Windows.Forms.Label()
        PurchasePriceLabel = New System.Windows.Forms.Label()
        SellPriceLabel = New System.Windows.Forms.Label()
        ProfitLabel = New System.Windows.Forms.Label()
        AlertQuantityLabel = New System.Windows.Forms.Label()
        AvailableLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        ProductNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ProductNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ProductNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ProductNameLabel.Location = New System.Drawing.Point(14, 2)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(166, 25)
        ProductNameLabel.TabIndex = 27
        ProductNameLabel.Text = "পণ্যের নামঃ"
        ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProductCategoryLabel
        '
        ProductCategoryLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ProductCategoryLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ProductCategoryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ProductCategoryLabel.Location = New System.Drawing.Point(14, 28)
        ProductCategoryLabel.Name = "ProductCategoryLabel"
        ProductCategoryLabel.Size = New System.Drawing.Size(166, 25)
        ProductCategoryLabel.TabIndex = 29
        ProductCategoryLabel.Text = "পণ্যের ধরণঃ"
        ProductCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProductCodeLabel
        '
        ProductCodeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ProductCodeLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ProductCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ProductCodeLabel.Location = New System.Drawing.Point(14, 54)
        ProductCodeLabel.Name = "ProductCodeLabel"
        ProductCodeLabel.Size = New System.Drawing.Size(166, 25)
        ProductCodeLabel.TabIndex = 31
        ProductCodeLabel.Text = "কোড নং:"
        ProductCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierLabel
        '
        SupplierLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        SupplierLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SupplierLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SupplierLabel.Location = New System.Drawing.Point(14, 80)
        SupplierLabel.Name = "SupplierLabel"
        SupplierLabel.Size = New System.Drawing.Size(166, 25)
        SupplierLabel.TabIndex = 33
        SupplierLabel.Text = "কোম্পানিঃ"
        SupplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PurchasePriceLabel
        '
        PurchasePriceLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        PurchasePriceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PurchasePriceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PurchasePriceLabel.Location = New System.Drawing.Point(14, 106)
        PurchasePriceLabel.Name = "PurchasePriceLabel"
        PurchasePriceLabel.Size = New System.Drawing.Size(166, 25)
        PurchasePriceLabel.TabIndex = 35
        PurchasePriceLabel.Text = "ক্রয় মূল্যঃ"
        PurchasePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SellPriceLabel
        '
        SellPriceLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        SellPriceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SellPriceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SellPriceLabel.Location = New System.Drawing.Point(14, 158)
        SellPriceLabel.Name = "SellPriceLabel"
        SellPriceLabel.Size = New System.Drawing.Size(166, 25)
        SellPriceLabel.TabIndex = 37
        SellPriceLabel.Text = "বিক্রয় মূল্যঃ"
        SellPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProfitLabel
        '
        ProfitLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ProfitLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ProfitLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ProfitLabel.Location = New System.Drawing.Point(14, 132)
        ProfitLabel.Name = "ProfitLabel"
        ProfitLabel.Size = New System.Drawing.Size(166, 25)
        ProfitLabel.TabIndex = 39
        ProfitLabel.Text = "লভ্যাংশ(%):"
        ProfitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AlertQuantityLabel
        '
        AlertQuantityLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        AlertQuantityLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AlertQuantityLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AlertQuantityLabel.Location = New System.Drawing.Point(14, 184)
        AlertQuantityLabel.Name = "AlertQuantityLabel"
        AlertQuantityLabel.Size = New System.Drawing.Size(166, 25)
        AlertQuantityLabel.TabIndex = 41
        AlertQuantityLabel.Text = "এলার্টের পরিমাণঃ"
        AlertQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AvailableLabel
        '
        AvailableLabel.BackColor = System.Drawing.Color.Black
        AvailableLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AvailableLabel.ForeColor = System.Drawing.Color.White
        AvailableLabel.Location = New System.Drawing.Point(14, 210)
        AvailableLabel.Name = "AvailableLabel"
        AvailableLabel.Size = New System.Drawing.Size(166, 25)
        AvailableLabel.TabIndex = 66
        AvailableLabel.Text = "বর্তমান স্টকঃ"
        AvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.Text = "পণ্য যুক্ত করুন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.DataSet
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
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
        'AvailableTextBox
        '
        Me.AvailableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "available", True))
        Me.AvailableTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AvailableTextBox.Location = New System.Drawing.Point(186, 203)
        Me.AvailableTextBox.Name = "AvailableTextBox"
        Me.AvailableTextBox.Size = New System.Drawing.Size(163, 24)
        Me.AvailableTextBox.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chk_nondis)
        Me.Panel1.Controls.Add(AvailableLabel)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.AlertQuantityTextBox)
        Me.Panel1.Controls.Add(Me.AvailableTextBox)
        Me.Panel1.Controls.Add(Me.ProductImagePictureBox)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(ProductNameLabel)
        Me.Panel1.Controls.Add(Me.ProductNameTextBox)
        Me.Panel1.Controls.Add(ProductCategoryLabel)
        Me.Panel1.Controls.Add(Me.ProfitTextBox)
        Me.Panel1.Controls.Add(ProfitLabel)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ProductCategoryTextBox)
        Me.Panel1.Controls.Add(ProductCodeLabel)
        Me.Panel1.Controls.Add(Me.ProductCodeTextBox)
        Me.Panel1.Controls.Add(SupplierLabel)
        Me.Panel1.Controls.Add(Me.SupplierTextBox)
        Me.Panel1.Controls.Add(PurchasePriceLabel)
        Me.Panel1.Controls.Add(Me.PurchasePriceTextBox)
        Me.Panel1.Controls.Add(SellPriceLabel)
        Me.Panel1.Controls.Add(Me.SellPriceTextBox)
        Me.Panel1.Controls.Add(AlertQuantityLabel)
        Me.Panel1.Location = New System.Drawing.Point(133, 163)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 330)
        Me.Panel1.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(455, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(263, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Upload"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(314, 286)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 66
        Me.Button4.UseVisualStyleBackColor = False
        '
        'AlertQuantityTextBox
        '
        Me.AlertQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "alertQuantity", True))
        Me.AlertQuantityTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AlertQuantityTextBox.Location = New System.Drawing.Point(186, 178)
        Me.AlertQuantityTextBox.Name = "AlertQuantityTextBox"
        Me.AlertQuantityTextBox.Size = New System.Drawing.Size(163, 24)
        Me.AlertQuantityTextBox.TabIndex = 42
        '
        'ProductImagePictureBox
        '
        Me.ProductImagePictureBox.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.photo
        Me.ProductImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProductImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblProductsBindingSource, "productImage", True))
        Me.ProductImagePictureBox.Location = New System.Drawing.Point(455, 3)
        Me.ProductImagePictureBox.Name = "ProductImagePictureBox"
        Me.ProductImagePictureBox.Size = New System.Drawing.Size(263, 250)
        Me.ProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductImagePictureBox.TabIndex = 46
        Me.ProductImagePictureBox.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.button_circle_add_512
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(418, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 24)
        Me.Button2.TabIndex = 45
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productName", True))
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ProductNameTextBox.Location = New System.Drawing.Point(186, 3)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(263, 24)
        Me.ProductNameTextBox.TabIndex = 28
        '
        'ProfitTextBox
        '
        Me.ProfitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "profit", True))
        Me.ProfitTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ProfitTextBox.Location = New System.Drawing.Point(186, 128)
        Me.ProfitTextBox.Name = "ProfitTextBox"
        Me.ProfitTextBox.Size = New System.Drawing.Size(163, 24)
        Me.ProfitTextBox.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(186, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 35)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProductCategoryTextBox
        '
        Me.ProductCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productCategory", True))
        Me.ProductCategoryTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ProductCategoryTextBox.Location = New System.Drawing.Point(186, 28)
        Me.ProductCategoryTextBox.Name = "ProductCategoryTextBox"
        Me.ProductCategoryTextBox.Size = New System.Drawing.Size(226, 24)
        Me.ProductCategoryTextBox.TabIndex = 30
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productCode", True))
        Me.ProductCodeTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(186, 53)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.ReadOnly = True
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(263, 24)
        Me.ProductCodeTextBox.TabIndex = 32
        '
        'SupplierTextBox
        '
        Me.SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "supplier", True))
        Me.SupplierTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SupplierTextBox.Location = New System.Drawing.Point(186, 78)
        Me.SupplierTextBox.Name = "SupplierTextBox"
        Me.SupplierTextBox.Size = New System.Drawing.Size(263, 24)
        Me.SupplierTextBox.TabIndex = 34
        '
        'PurchasePriceTextBox
        '
        Me.PurchasePriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "purchasePrice", True))
        Me.PurchasePriceTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PurchasePriceTextBox.Location = New System.Drawing.Point(186, 103)
        Me.PurchasePriceTextBox.Name = "PurchasePriceTextBox"
        Me.PurchasePriceTextBox.Size = New System.Drawing.Size(163, 24)
        Me.PurchasePriceTextBox.TabIndex = 36
        '
        'SellPriceTextBox
        '
        Me.SellPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "sellPrice", True))
        Me.SellPriceTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SellPriceTextBox.Location = New System.Drawing.Point(186, 153)
        Me.SellPriceTextBox.Name = "SellPriceTextBox"
        Me.SellPriceTextBox.ReadOnly = True
        Me.SellPriceTextBox.Size = New System.Drawing.Size(163, 24)
        Me.SellPriceTextBox.TabIndex = 38
        '
        'SupplierNameTextBox
        '
        Me.SupplierNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "supplierName", True))
        Me.SupplierNameTextBox.Location = New System.Drawing.Point(175, 12)
        Me.SupplierNameTextBox.Name = "SupplierNameTextBox"
        Me.SupplierNameTextBox.Size = New System.Drawing.Size(29, 20)
        Me.SupplierNameTextBox.TabIndex = 29
        '
        'TblSuppliersBindingSource
        '
        Me.TblSuppliersBindingSource.DataMember = "tblSuppliers"
        Me.TblSuppliersBindingSource.DataSource = Me.DataSet
        '
        'CNameTextBox
        '
        Me.CNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductCategoryBindingSource, "cName", True))
        Me.CNameTextBox.Location = New System.Drawing.Point(680, 8)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.Size = New System.Drawing.Size(27, 20)
        Me.CNameTextBox.TabIndex = 29
        '
        'TblProductCategoryBindingSource
        '
        Me.TblProductCategoryBindingSource.DataMember = "tblProductCategory"
        Me.TblProductCategoryBindingSource.DataSource = Me.DataSet
        '
        'TblProductCategoryTableAdapter
        '
        Me.TblProductCategoryTableAdapter.ClearBeforeFill = True
        '
        'TblSuppliersTableAdapter
        '
        Me.TblSuppliersTableAdapter.ClearBeforeFill = True
        '
        'chk_nondis
        '
        Me.chk_nondis.BackColor = System.Drawing.Color.Black
        Me.chk_nondis.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chk_nondis.ForeColor = System.Drawing.Color.White
        Me.chk_nondis.Location = New System.Drawing.Point(92, 238)
        Me.chk_nondis.Name = "chk_nondis"
        Me.chk_nondis.Padding = New System.Windows.Forms.Padding(50, 4, 4, 4)
        Me.chk_nondis.Size = New System.Drawing.Size(297, 42)
        Me.chk_nondis.TabIndex = 70
        Me.chk_nondis.Text = "ডিসকাউন্ট বহির্ভূত পণ্য"
        Me.chk_nondis.UseVisualStyleBackColor = False
        '
        'Non_discountTextBox
        '
        Me.Non_discountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "non_discount", True))
        Me.Non_discountTextBox.Location = New System.Drawing.Point(32, 0)
        Me.Non_discountTextBox.Name = "Non_discountTextBox"
        Me.Non_discountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Non_discountTextBox.TabIndex = 30
        '
        'addProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 656)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SupplierNameTextBox)
        Me.Controls.Add(Me.CNameTextBox)
        Me.Controls.Add(Me.Non_discountTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addProducts"
        Me.Text = "addProducts"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As dataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents AvailableTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductCategoryTextBox As TextBox
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents SupplierTextBox As TextBox
    Friend WithEvents PurchasePriceTextBox As TextBox
    Friend WithEvents SellPriceTextBox As TextBox
    Friend WithEvents ProfitTextBox As TextBox
    Friend WithEvents AlertQuantityTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ProductImagePictureBox As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TblProductCategoryBindingSource As BindingSource
    Friend WithEvents TblProductCategoryTableAdapter As dataSetTableAdapters.tblProductCategoryTableAdapter
    Friend WithEvents CNameTextBox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TblSuppliersBindingSource As BindingSource
    Friend WithEvents TblSuppliersTableAdapter As dataSetTableAdapters.tblSuppliersTableAdapter
    Friend WithEvents SupplierNameTextBox As TextBox
    Friend WithEvents chk_nondis As CheckBox
    Friend WithEvents Non_discountTextBox As TextBox
End Class
