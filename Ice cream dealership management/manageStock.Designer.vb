<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageStock
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AlertQuantityLabel1 = New System.Windows.Forms.Label()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.ProfitLabel1 = New System.Windows.Forms.Label()
        Me.SellPriceLabel1 = New System.Windows.Forms.Label()
        Me.PurchasePriceLabel1 = New System.Windows.Forms.Label()
        Me.ProductImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.TblProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlertQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.AvailableTextBox = New System.Windows.Forms.TextBox()
        Me.TblProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        PurchasePriceLabel = New System.Windows.Forms.Label()
        SellPriceLabel = New System.Windows.Forms.Label()
        ProfitLabel = New System.Windows.Forms.Label()
        AlertQuantityLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchasePriceLabel
        '
        PurchasePriceLabel.AutoSize = True
        PurchasePriceLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        PurchasePriceLabel.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        PurchasePriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        PurchasePriceLabel.Location = New System.Drawing.Point(14, 51)
        PurchasePriceLabel.Name = "PurchasePriceLabel"
        PurchasePriceLabel.Padding = New System.Windows.Forms.Padding(5)
        PurchasePriceLabel.Size = New System.Drawing.Size(216, 36)
        PurchasePriceLabel.TabIndex = 2
        PurchasePriceLabel.Text = "Purchase price:"
        '
        'SellPriceLabel
        '
        SellPriceLabel.AutoSize = True
        SellPriceLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        SellPriceLabel.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        SellPriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        SellPriceLabel.Location = New System.Drawing.Point(14, 95)
        SellPriceLabel.Name = "SellPriceLabel"
        SellPriceLabel.Padding = New System.Windows.Forms.Padding(5)
        SellPriceLabel.Size = New System.Drawing.Size(148, 36)
        SellPriceLabel.TabIndex = 4
        SellPriceLabel.Text = "Sell price:"
        '
        'ProfitLabel
        '
        ProfitLabel.AutoSize = True
        ProfitLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ProfitLabel.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        ProfitLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        ProfitLabel.Location = New System.Drawing.Point(14, 139)
        ProfitLabel.Name = "ProfitLabel"
        ProfitLabel.Padding = New System.Windows.Forms.Padding(5)
        ProfitLabel.Size = New System.Drawing.Size(100, 36)
        ProfitLabel.TabIndex = 6
        ProfitLabel.Text = "Profit:"
        '
        'AlertQuantityLabel
        '
        AlertQuantityLabel.AutoSize = True
        AlertQuantityLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        AlertQuantityLabel.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        AlertQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        AlertQuantityLabel.Location = New System.Drawing.Point(14, 183)
        AlertQuantityLabel.Name = "AlertQuantityLabel"
        AlertQuantityLabel.Padding = New System.Windows.Forms.Padding(5)
        AlertQuantityLabel.Size = New System.Drawing.Size(204, 36)
        AlertQuantityLabel.TabIndex = 8
        AlertQuantityLabel.Text = "Alert quantity:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 44)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 41)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton2.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.f51220af0a9d200aba4b1574f3f34830_reload_icon_by_vexels
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(189, 33)
        Me.ToolStripButton2.Text = "Restock/Purchase"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton6.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Margin = New System.Windows.Forms.Padding(4)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton6.Size = New System.Drawing.Size(80, 33)
        Me.ToolStripButton6.Text = "Print"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 44)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Manage stock"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.Panel1.Controls.Add(Me.TblProductsDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(107, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 531)
        Me.Panel1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(449, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(51, 36)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "%"
        '
        'AlertQuantityLabel1
        '
        Me.AlertQuantityLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AlertQuantityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "alertQuantity", True))
        Me.AlertQuantityLabel1.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        Me.AlertQuantityLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AlertQuantityLabel1.Location = New System.Drawing.Point(236, 183)
        Me.AlertQuantityLabel1.Name = "AlertQuantityLabel1"
        Me.AlertQuantityLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.AlertQuantityLabel1.Size = New System.Drawing.Size(265, 36)
        Me.AlertQuantityLabel1.TabIndex = 9
        Me.AlertQuantityLabel1.Text = "NaN"
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfitLabel1
        '
        Me.ProfitLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProfitLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "profit", True))
        Me.ProfitLabel1.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ProfitLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProfitLabel1.Location = New System.Drawing.Point(236, 139)
        Me.ProfitLabel1.Name = "ProfitLabel1"
        Me.ProfitLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.ProfitLabel1.Size = New System.Drawing.Size(207, 36)
        Me.ProfitLabel1.TabIndex = 7
        Me.ProfitLabel1.Text = "NaN"
        '
        'SellPriceLabel1
        '
        Me.SellPriceLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SellPriceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "sellPrice", True))
        Me.SellPriceLabel1.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        Me.SellPriceLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SellPriceLabel1.Location = New System.Drawing.Point(236, 95)
        Me.SellPriceLabel1.Name = "SellPriceLabel1"
        Me.SellPriceLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.SellPriceLabel1.Size = New System.Drawing.Size(265, 36)
        Me.SellPriceLabel1.TabIndex = 5
        Me.SellPriceLabel1.Text = "NaN"
        '
        'PurchasePriceLabel1
        '
        Me.PurchasePriceLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PurchasePriceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "purchasePrice", True))
        Me.PurchasePriceLabel1.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        Me.PurchasePriceLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PurchasePriceLabel1.Location = New System.Drawing.Point(236, 51)
        Me.PurchasePriceLabel1.Name = "PurchasePriceLabel1"
        Me.PurchasePriceLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.PurchasePriceLabel1.Size = New System.Drawing.Size(265, 36)
        Me.PurchasePriceLabel1.TabIndex = 3
        Me.PurchasePriceLabel1.Text = "NaN"
        '
        'ProductImagePictureBox
        '
        Me.ProductImagePictureBox.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.photo
        Me.ProductImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProductImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblProductsBindingSource, "productImage", True))
        Me.ProductImagePictureBox.Location = New System.Drawing.Point(507, 7)
        Me.ProductImagePictureBox.Name = "ProductImagePictureBox"
        Me.ProductImagePictureBox.Size = New System.Drawing.Size(254, 250)
        Me.ProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductImagePictureBox.TabIndex = 2
        Me.ProductImagePictureBox.TabStop = False
        '
        'TblProductsDataGridView
        '
        Me.TblProductsDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TblProductsDataGridView.AutoGenerateColumns = False
        Me.TblProductsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn10})
        Me.TblProductsDataGridView.DataSource = Me.TblProductsBindingSource
        Me.TblProductsDataGridView.Location = New System.Drawing.Point(11, 271)
        Me.TblProductsDataGridView.Name = "TblProductsDataGridView"
        Me.TblProductsDataGridView.Size = New System.Drawing.Size(750, 260)
        Me.TblProductsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "productName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "productCategory"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "productCode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Product code"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "supplier"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Company"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "available"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Available"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'AlertQuantityTextBox
        '
        Me.AlertQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "alertQuantity", True))
        Me.AlertQuantityTextBox.Location = New System.Drawing.Point(217, 12)
        Me.AlertQuantityTextBox.Name = "AlertQuantityTextBox"
        Me.AlertQuantityTextBox.Size = New System.Drawing.Size(100, 21)
        Me.AlertQuantityTextBox.TabIndex = 13
        '
        'AvailableTextBox
        '
        Me.AvailableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "available", True))
        Me.AvailableTextBox.Location = New System.Drawing.Point(217, 12)
        Me.AvailableTextBox.Name = "AvailableTextBox"
        Me.AvailableTextBox.Size = New System.Drawing.Size(100, 21)
        Me.AvailableTextBox.TabIndex = 11
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
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
        'manageStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AlertQuantityTextBox)
        Me.Controls.Add(Me.AvailableTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "manageStock"
        Me.Text = "manageStock"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As dataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblProductsDataGridView As DataGridView
    Friend WithEvents ProductImagePictureBox As PictureBox
    Friend WithEvents AlertQuantityLabel1 As Label
    Friend WithEvents ProfitLabel1 As Label
    Friend WithEvents SellPriceLabel1 As Label
    Friend WithEvents PurchasePriceLabel1 As Label
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents AlertQuantityTextBox As TextBox
    Friend WithEvents AvailableTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents Label2 As Label
End Class
