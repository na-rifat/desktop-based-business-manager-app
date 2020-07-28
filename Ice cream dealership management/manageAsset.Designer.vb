<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageAsset
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
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim AssetNameLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim UnitpriceLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.TblassetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.AssetConditionTextBox = New System.Windows.Forms.TextBox()
        Me.BcTextBox = New System.Windows.Forms.TextBox()
        Me.IssueDateTextBox = New System.Windows.Forms.TextBox()
        Me.TblassetTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblassetTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.UnitpriceTextBox = New System.Windows.Forms.TextBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkN = New System.Windows.Forms.CheckBox()
        Me.rdnO = New System.Windows.Forms.RadioButton()
        Me.rdnN = New System.Windows.Forms.RadioButton()
        Me.AssetNameTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.TblassetDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.issueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        IssueDateLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        AssetNameLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        UnitpriceLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TblassetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblassetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        Me.SuspendLayout()
        '
        'IssueDateLabel
        '
        IssueDateLabel.BackColor = System.Drawing.Color.Black
        IssueDateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        IssueDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        IssueDateLabel.Location = New System.Drawing.Point(3, 114)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(111, 25)
        IssueDateLabel.TabIndex = 6
        IssueDateLabel.Text = "ইস্যুর/ক্রয়ের তারিখঃ"
        IssueDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PriceLabel
        '
        PriceLabel.BackColor = System.Drawing.Color.Black
        PriceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PriceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PriceLabel.Location = New System.Drawing.Point(3, 88)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(111, 25)
        PriceLabel.TabIndex = 4
        PriceLabel.Text = "দামঃ"
        PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AssetNameLabel
        '
        AssetNameLabel.BackColor = System.Drawing.Color.Black
        AssetNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AssetNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AssetNameLabel.Location = New System.Drawing.Point(3, 10)
        AssetNameLabel.Name = "AssetNameLabel"
        AssetNameLabel.Size = New System.Drawing.Size(111, 25)
        AssetNameLabel.TabIndex = 2
        AssetNameLabel.Text = "সম্পদের নামঃ"
        AssetNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler AssetNameLabel.Click, AddressOf Me.AssetNameLabel_Click
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Black
        Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(3, 140)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(111, 25)
        Label2.TabIndex = 12
        Label2.Text = "কন্ডিশনঃ"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UnitpriceLabel
        '
        UnitpriceLabel.BackColor = System.Drawing.Color.Black
        UnitpriceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        UnitpriceLabel.ForeColor = System.Drawing.Color.White
        UnitpriceLabel.Location = New System.Drawing.Point(3, 62)
        UnitpriceLabel.Name = "UnitpriceLabel"
        UnitpriceLabel.Size = New System.Drawing.Size(111, 25)
        UnitpriceLabel.TabIndex = 30
        UnitpriceLabel.Text = "দরঃ"
        UnitpriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QuantityLabel
        '
        QuantityLabel.BackColor = System.Drawing.Color.Black
        QuantityLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        QuantityLabel.ForeColor = System.Drawing.Color.White
        QuantityLabel.Location = New System.Drawing.Point(3, 36)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(111, 25)
        QuantityLabel.TabIndex = 31
        QuantityLabel.Text = "পরিমাণঃ"
        QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "সম্পদ ব্যবস্থাপনা"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 37)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 37)
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
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"সম্পদের নাম", "ইস্যু/ক্রয়ের তারিখ"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(150, 37)
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
        Me.ToolStripButton4.Size = New System.Drawing.Size(180, 33)
        Me.ToolStripButton4.Text = "সম্পদ যুক্ত করুন"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(113, 33)
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
        Me.ToolStripButton2.Size = New System.Drawing.Size(88, 33)
        Me.ToolStripButton2.Text = "ডিলিট"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton5.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton5.Size = New System.Drawing.Size(78, 33)
        Me.ToolStripButton5.Text = "প্রিন্ট"
        '
        'TblassetBindingSource
        '
        Me.TblassetBindingSource.DataMember = "tblasset"
        Me.TblassetBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssetConditionTextBox
        '
        Me.AssetConditionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblassetBindingSource, "assetCondition", True))
        Me.AssetConditionTextBox.Location = New System.Drawing.Point(326, 10)
        Me.AssetConditionTextBox.Name = "AssetConditionTextBox"
        Me.AssetConditionTextBox.Size = New System.Drawing.Size(33, 21)
        Me.AssetConditionTextBox.TabIndex = 11
        '
        'BcTextBox
        '
        Me.BcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblassetBindingSource, "bc", True))
        Me.BcTextBox.Location = New System.Drawing.Point(326, 10)
        Me.BcTextBox.Name = "BcTextBox"
        Me.BcTextBox.Size = New System.Drawing.Size(33, 21)
        Me.BcTextBox.TabIndex = 9
        '
        'IssueDateTextBox
        '
        Me.IssueDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblassetBindingSource, "issueDate", True))
        Me.IssueDateTextBox.Location = New System.Drawing.Point(326, 10)
        Me.IssueDateTextBox.Name = "IssueDateTextBox"
        Me.IssueDateTextBox.Size = New System.Drawing.Size(34, 21)
        Me.IssueDateTextBox.TabIndex = 7
        '
        'TblassetTableAdapter
        '
        Me.TblassetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sales_targetTableAdapter = Nothing
        Me.TableAdapterManager.tblassetTableAdapter = Me.TblassetTableAdapter
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
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(133, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 286)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "নতুন সম্পদ"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(QuantityLabel)
        Me.Panel2.Controls.Add(Me.QuantityTextBox)
        Me.Panel2.Controls.Add(UnitpriceLabel)
        Me.Panel2.Controls.Add(Me.UnitpriceTextBox)
        Me.Panel2.Controls.Add(Me.dtp)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.chkN)
        Me.Panel2.Controls.Add(Me.rdnO)
        Me.Panel2.Controls.Add(Me.rdnN)
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Controls.Add(AssetNameLabel)
        Me.Panel2.Controls.Add(Me.AssetNameTextBox)
        Me.Panel2.Controls.Add(PriceLabel)
        Me.Panel2.Controls.Add(Me.PriceTextBox)
        Me.Panel2.Controls.Add(IssueDateLabel)
        Me.Panel2.Location = New System.Drawing.Point(14, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 252)
        Me.Panel2.TabIndex = 0
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblassetBindingSource, "quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.QuantityTextBox.Location = New System.Drawing.Point(120, 36)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(269, 24)
        Me.QuantityTextBox.TabIndex = 32
        '
        'UnitpriceTextBox
        '
        Me.UnitpriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblassetBindingSource, "unitprice", True))
        Me.UnitpriceTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.UnitpriceTextBox.Location = New System.Drawing.Point(120, 61)
        Me.UnitpriceTextBox.Name = "UnitpriceTextBox"
        Me.UnitpriceTextBox.Size = New System.Drawing.Size(269, 24)
        Me.UnitpriceTextBox.TabIndex = 31
        '
        'dtp
        '
        Me.dtp.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(120, 111)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(203, 24)
        Me.dtp.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(120, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 35)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'chkN
        '
        Me.chkN.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkN.Checked = True
        Me.chkN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkN.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chkN.ForeColor = System.Drawing.Color.Black
        Me.chkN.Location = New System.Drawing.Point(120, 166)
        Me.chkN.Name = "chkN"
        Me.chkN.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.chkN.Size = New System.Drawing.Size(203, 29)
        Me.chkN.TabIndex = 15
        Me.chkN.Text = "নতুন ক্রয়কৃত"
        Me.chkN.UseVisualStyleBackColor = False
        '
        'rdnO
        '
        Me.rdnO.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.rdnO.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.rdnO.ForeColor = System.Drawing.Color.Black
        Me.rdnO.Location = New System.Drawing.Point(205, 136)
        Me.rdnO.Name = "rdnO"
        Me.rdnO.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.rdnO.Size = New System.Drawing.Size(118, 29)
        Me.rdnO.TabIndex = 14
        Me.rdnO.Text = "ব্যবহৃত"
        Me.rdnO.UseVisualStyleBackColor = False
        '
        'rdnN
        '
        Me.rdnN.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.rdnN.Checked = True
        Me.rdnN.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.rdnN.ForeColor = System.Drawing.Color.Black
        Me.rdnN.Location = New System.Drawing.Point(120, 136)
        Me.rdnN.Name = "rdnN"
        Me.rdnN.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.rdnN.Size = New System.Drawing.Size(87, 29)
        Me.rdnN.TabIndex = 13
        Me.rdnN.TabStop = True
        Me.rdnN.Text = "নতুন"
        Me.rdnN.UseVisualStyleBackColor = False
        '
        'AssetNameTextBox
        '
        Me.AssetNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblassetBindingSource, "assetName", True))
        Me.AssetNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AssetNameTextBox.Location = New System.Drawing.Point(120, 11)
        Me.AssetNameTextBox.Name = "AssetNameTextBox"
        Me.AssetNameTextBox.Size = New System.Drawing.Size(269, 24)
        Me.AssetNameTextBox.TabIndex = 3
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblassetBindingSource, "price", True))
        Me.PriceTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PriceTextBox.Location = New System.Drawing.Point(120, 86)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(269, 24)
        Me.PriceTextBox.TabIndex = 5
        '
        'TblassetDataGridView
        '
        Me.TblassetDataGridView.AutoGenerateColumns = False
        Me.TblassetDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblassetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblassetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.quantity, Me.unitprice, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.issueDate})
        Me.TblassetDataGridView.DataSource = Me.TblassetBindingSource
        Me.TblassetDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblassetDataGridView.Location = New System.Drawing.Point(0, 304)
        Me.TblassetDataGridView.Name = "TblassetDataGridView"
        Me.TblassetDataGridView.Size = New System.Drawing.Size(982, 207)
        Me.TblassetDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "assetName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "সম্পদের নাম"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'quantity
        '
        Me.quantity.DataPropertyName = "quantity"
        Me.quantity.HeaderText = "পরিমাণ"
        Me.quantity.Name = "quantity"
        '
        'unitprice
        '
        Me.unitprice.DataPropertyName = "unitprice"
        Me.unitprice.HeaderText = "দর"
        Me.unitprice.Name = "unitprice"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "দাম"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "assetCondition"
        Me.DataGridViewTextBoxColumn6.HeaderText = "কন্ডিশন"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'issueDate
        '
        Me.issueDate.DataPropertyName = "issueDate"
        Me.issueDate.HeaderText = "ইস্যু/ক্রয়ের তারিখ"
        Me.issueDate.Name = "issueDate"
        Me.issueDate.Width = 150
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ImagePictureBox)
        Me.Panel1.Controls.Add(Me.TblassetDataGridView)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Location = New System.Drawing.Point(6, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 539)
        Me.Panel1.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(559, 261)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 30)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblassetBindingSource, "image", True))
        Me.ImagePictureBox.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.photo
        Me.ImagePictureBox.Location = New System.Drawing.Point(559, 15)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(255, 240)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagePictureBox.TabIndex = 25
        Me.ImagePictureBox.TabStop = False
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 511)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(982, 28)
        Me.tool.TabIndex = 79
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Padding = New System.Windows.Forms.Padding(4)
        Me.ToolStripLabel3.Size = New System.Drawing.Size(98, 25)
        Me.ToolStripLabel3.Text = "Total asset:"
        '
        'manageAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AssetConditionTextBox)
        Me.Controls.Add(Me.IssueDateTextBox)
        Me.Controls.Add(Me.BcTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageAsset"
        Me.Text = "manageAsset"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TblassetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblassetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblassetBindingSource As BindingSource
    Friend WithEvents TblassetTableAdapter As dataSetTableAdapters.tblassetTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents IssueDateTextBox As TextBox
    Friend WithEvents BcTextBox As TextBox
    Friend WithEvents AssetConditionTextBox As TextBox
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents chkN As CheckBox
    Friend WithEvents rdnO As RadioButton
    Friend WithEvents rdnN As RadioButton
    Friend WithEvents AssetNameTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents TblassetDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents UnitpriceTextBox As TextBox
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents unitprice As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents issueDate As DataGridViewTextBoxColumn
End Class
