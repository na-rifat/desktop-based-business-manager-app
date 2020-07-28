<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageProducts
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
        Dim PurchasePriceLabel As System.Windows.Forms.Label
        Dim SellPriceLabel As System.Windows.Forms.Label
        Dim ProfitLabel As System.Windows.Forms.Label
        Dim AlertQuantityLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sellPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purchasePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alertQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.RemarkLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AlertQuantityLabel1 = New System.Windows.Forms.Label()
        Me.ProfitLabel1 = New System.Windows.Forms.Label()
        Me.SellPriceLabel1 = New System.Windows.Forms.Label()
        Me.PurchasePriceLabel1 = New System.Windows.Forms.Label()
        Me.ProductImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.AvailableTextBox = New System.Windows.Forms.TextBox()
        Me.AlertQuantityTextBox = New System.Windows.Forms.TextBox()
        PurchasePriceLabel = New System.Windows.Forms.Label()
        SellPriceLabel = New System.Windows.Forms.Label()
        ProfitLabel = New System.Windows.Forms.Label()
        AlertQuantityLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        RemarkLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchasePriceLabel
        '
        PurchasePriceLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        PurchasePriceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PurchasePriceLabel.ForeColor = System.Drawing.Color.White
        PurchasePriceLabel.Location = New System.Drawing.Point(142, 9)
        PurchasePriceLabel.Name = "PurchasePriceLabel"
        PurchasePriceLabel.Size = New System.Drawing.Size(181, 25)
        PurchasePriceLabel.TabIndex = 18
        PurchasePriceLabel.Text = "ক্রয় মূল্যঃ"
        PurchasePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SellPriceLabel
        '
        SellPriceLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        SellPriceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SellPriceLabel.ForeColor = System.Drawing.Color.White
        SellPriceLabel.Location = New System.Drawing.Point(142, 35)
        SellPriceLabel.Name = "SellPriceLabel"
        SellPriceLabel.Size = New System.Drawing.Size(181, 25)
        SellPriceLabel.TabIndex = 19
        SellPriceLabel.Text = "বিক্রয় মূল্যঃ"
        SellPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProfitLabel
        '
        ProfitLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ProfitLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ProfitLabel.ForeColor = System.Drawing.Color.White
        ProfitLabel.Location = New System.Drawing.Point(142, 61)
        ProfitLabel.Name = "ProfitLabel"
        ProfitLabel.Size = New System.Drawing.Size(181, 25)
        ProfitLabel.TabIndex = 20
        ProfitLabel.Text = "লভ্যাংশঃ"
        ProfitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AlertQuantityLabel
        '
        AlertQuantityLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        AlertQuantityLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AlertQuantityLabel.ForeColor = System.Drawing.Color.White
        AlertQuantityLabel.Location = New System.Drawing.Point(142, 87)
        AlertQuantityLabel.Name = "AlertQuantityLabel"
        AlertQuantityLabel.Size = New System.Drawing.Size(181, 25)
        AlertQuantityLabel.TabIndex = 21
        AlertQuantityLabel.Text = "এলার্টের পরিমাণঃ"
        AlertQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(44, 22)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 16
        IdLabel.Text = "Id:"
        '
        'RemarkLabel
        '
        RemarkLabel.BackColor = System.Drawing.Color.Black
        RemarkLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        RemarkLabel.ForeColor = System.Drawing.Color.White
        RemarkLabel.Location = New System.Drawing.Point(142, 113)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(181, 25)
        RemarkLabel.TabIndex = 23
        RemarkLabel.Text = "মন্তব্য"
        RemarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton6, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 32)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 32)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 29)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"পণ্যের নাম", "কোড", "ধরণ", "কোম্পানি"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(150, 32)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 29)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripButton1.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.f51220af0a9d200aba4b1574f3f34830_reload_icon_by_vexels
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(174, 28)
        Me.ToolStripButton1.Text = "নতুন পণ্য ক্রয় করুন"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(93, 28)
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
        Me.ToolStripButton2.Size = New System.Drawing.Size(74, 28)
        Me.ToolStripButton2.Text = "ডিলিট"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton6.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton6.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton6.Size = New System.Drawing.Size(67, 28)
        Me.ToolStripButton6.Text = "প্রিন্ট"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton4.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton4.Size = New System.Drawing.Size(65, 28)
        Me.ToolStripButton4.Text = "কাউন্ট"
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
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "পণ্য ও মজুত ব্যবস্থাপনা"
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
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TblProductsDataGridView)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Controls.Add(RemarkLabel)
        Me.Panel1.Controls.Add(Me.RemarkLabel1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(AlertQuantityLabel)
        Me.Panel1.Controls.Add(Me.AlertQuantityLabel1)
        Me.Panel1.Controls.Add(ProfitLabel)
        Me.Panel1.Controls.Add(Me.ProfitLabel1)
        Me.Panel1.Controls.Add(SellPriceLabel)
        Me.Panel1.Controls.Add(Me.SellPriceLabel1)
        Me.Panel1.Controls.Add(PurchasePriceLabel)
        Me.Panel1.Controls.Add(Me.PurchasePriceLabel1)
        Me.Panel1.Controls.Add(Me.ProductImagePictureBox)
        Me.Panel1.Location = New System.Drawing.Point(6, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 523)
        Me.Panel1.TabIndex = 16
        '
        'TblProductsDataGridView
        '
        Me.TblProductsDataGridView.AutoGenerateColumns = False
        Me.TblProductsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.productCode, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn10, Me.sellPrice, Me.purchasePrice, Me.alertQuantity})
        Me.TblProductsDataGridView.DataSource = Me.TblProductsBindingSource
        Me.TblProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblProductsDataGridView.Location = New System.Drawing.Point(0, 190)
        Me.TblProductsDataGridView.Name = "TblProductsDataGridView"
        Me.TblProductsDataGridView.Size = New System.Drawing.Size(987, 304)
        Me.TblProductsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "productName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "পণ্যের নাম"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'productCode
        '
        Me.productCode.DataPropertyName = "productCode"
        Me.productCode.HeaderText = "কোড"
        Me.productCode.Name = "productCode"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "productCategory"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ধরন"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "supplier"
        Me.DataGridViewTextBoxColumn5.HeaderText = "কোম্পানি"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "available"
        Me.DataGridViewTextBoxColumn10.HeaderText = "মজুত"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'sellPrice
        '
        Me.sellPrice.DataPropertyName = "sellPrice"
        Me.sellPrice.HeaderText = "বিক্রয় মূল্য"
        Me.sellPrice.Name = "sellPrice"
        Me.sellPrice.Visible = False
        '
        'purchasePrice
        '
        Me.purchasePrice.DataPropertyName = "purchasePrice"
        Me.purchasePrice.HeaderText = "ক্রয় মূল্য"
        Me.purchasePrice.Name = "purchasePrice"
        Me.purchasePrice.Visible = False
        '
        'alertQuantity
        '
        Me.alertQuantity.DataPropertyName = "alertQuantity"
        Me.alertQuantity.HeaderText = "এলার্টের পরিমাণ"
        Me.alertQuantity.Name = "alertQuantity"
        Me.alertQuantity.Visible = False
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel5, Me.ToolStripSeparator2, Me.ToolStripLabel4, Me.ToolStripSeparator1, Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 494)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(987, 29)
        Me.tool.TabIndex = 82
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Padding = New System.Windows.Forms.Padding(4)
        Me.ToolStripLabel5.Size = New System.Drawing.Size(169, 26)
        Me.ToolStripLabel5.Text = "Profit can be earn:"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Padding = New System.Windows.Forms.Padding(4)
        Me.ToolStripLabel4.Size = New System.Drawing.Size(287, 26)
        Me.ToolStripLabel4.Text = "Available products market value:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Padding = New System.Windows.Forms.Padding(4)
        Me.ToolStripLabel3.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripLabel3.Text = "Available products value:"
        '
        'RemarkLabel1
        '
        Me.RemarkLabel1.BackColor = System.Drawing.Color.Black
        Me.RemarkLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "remark", True))
        Me.RemarkLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RemarkLabel1.ForeColor = System.Drawing.Color.White
        Me.RemarkLabel1.Location = New System.Drawing.Point(329, 113)
        Me.RemarkLabel1.Name = "RemarkLabel1"
        Me.RemarkLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.RemarkLabel1.Size = New System.Drawing.Size(273, 72)
        Me.RemarkLabel1.TabIndex = 24
        Me.RemarkLabel1.Text = "NaN"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(551, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(4)
        Me.Label2.Size = New System.Drawing.Size(51, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "%"
        '
        'AlertQuantityLabel1
        '
        Me.AlertQuantityLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AlertQuantityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "alertQuantity", True))
        Me.AlertQuantityLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AlertQuantityLabel1.ForeColor = System.Drawing.Color.White
        Me.AlertQuantityLabel1.Location = New System.Drawing.Point(329, 87)
        Me.AlertQuantityLabel1.Name = "AlertQuantityLabel1"
        Me.AlertQuantityLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.AlertQuantityLabel1.Size = New System.Drawing.Size(273, 25)
        Me.AlertQuantityLabel1.TabIndex = 22
        Me.AlertQuantityLabel1.Text = "0"
        '
        'ProfitLabel1
        '
        Me.ProfitLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProfitLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "profit", True))
        Me.ProfitLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ProfitLabel1.ForeColor = System.Drawing.Color.White
        Me.ProfitLabel1.Location = New System.Drawing.Point(329, 61)
        Me.ProfitLabel1.Name = "ProfitLabel1"
        Me.ProfitLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.ProfitLabel1.Size = New System.Drawing.Size(216, 25)
        Me.ProfitLabel1.TabIndex = 21
        Me.ProfitLabel1.Text = "0"
        '
        'SellPriceLabel1
        '
        Me.SellPriceLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SellPriceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "sellPrice", True))
        Me.SellPriceLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SellPriceLabel1.ForeColor = System.Drawing.Color.White
        Me.SellPriceLabel1.Location = New System.Drawing.Point(329, 35)
        Me.SellPriceLabel1.Name = "SellPriceLabel1"
        Me.SellPriceLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.SellPriceLabel1.Size = New System.Drawing.Size(273, 25)
        Me.SellPriceLabel1.TabIndex = 20
        Me.SellPriceLabel1.Text = "0"
        '
        'PurchasePriceLabel1
        '
        Me.PurchasePriceLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PurchasePriceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "purchasePrice", True))
        Me.PurchasePriceLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PurchasePriceLabel1.ForeColor = System.Drawing.Color.White
        Me.PurchasePriceLabel1.Location = New System.Drawing.Point(329, 9)
        Me.PurchasePriceLabel1.Name = "PurchasePriceLabel1"
        Me.PurchasePriceLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.PurchasePriceLabel1.Size = New System.Drawing.Size(273, 25)
        Me.PurchasePriceLabel1.TabIndex = 19
        Me.PurchasePriceLabel1.Text = "0"
        '
        'ProductImagePictureBox
        '
        Me.ProductImagePictureBox.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.photo
        Me.ProductImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProductImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblProductsBindingSource, "productImage", True))
        Me.ProductImagePictureBox.Location = New System.Drawing.Point(608, 7)
        Me.ProductImagePictureBox.Name = "ProductImagePictureBox"
        Me.ProductImagePictureBox.Size = New System.Drawing.Size(178, 178)
        Me.ProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductImagePictureBox.TabIndex = 18
        Me.ProductImagePictureBox.TabStop = False
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(74, 19)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IdTextBox.TabIndex = 17
        '
        'AvailableTextBox
        '
        Me.AvailableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "available", True))
        Me.AvailableTextBox.Location = New System.Drawing.Point(12, 12)
        Me.AvailableTextBox.Name = "AvailableTextBox"
        Me.AvailableTextBox.Size = New System.Drawing.Size(41, 21)
        Me.AvailableTextBox.TabIndex = 17
        '
        'AlertQuantityTextBox
        '
        Me.AlertQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "alertQuantity", True))
        Me.AlertQuantityTextBox.Location = New System.Drawing.Point(12, 12)
        Me.AlertQuantityTextBox.Name = "AlertQuantityTextBox"
        Me.AlertQuantityTextBox.Size = New System.Drawing.Size(41, 21)
        Me.AlertQuantityTextBox.TabIndex = 18
        '
        'manageProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AlertQuantityTextBox)
        Me.Controls.Add(Me.AvailableTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(IdLabel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageProducts"
        Me.Text = "manageProducts"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As dataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TblProductsDataGridView As DataGridView
    Friend WithEvents AlertQuantityLabel1 As Label
    Friend WithEvents ProfitLabel1 As Label
    Friend WithEvents SellPriceLabel1 As Label
    Friend WithEvents PurchasePriceLabel1 As Label
    Friend WithEvents ProductImagePictureBox As PictureBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents AvailableTextBox As TextBox
    Friend WithEvents AlertQuantityTextBox As TextBox
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents RemarkLabel1 As Label
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents productCode As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents sellPrice As DataGridViewTextBoxColumn
    Friend WithEvents purchasePrice As DataGridViewTextBoxColumn
    Friend WithEvents alertQuantity As DataGridViewTextBoxColumn
End Class
