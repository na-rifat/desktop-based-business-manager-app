<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageEmployee
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim EmployeeNameLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim MaritialStatusLabel As System.Windows.Forms.Label
        Dim BloodGroupLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim EmployeeNoteLabel As System.Windows.Forms.Label
        Dim PaymentLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblEmployeeTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblEmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNoteLabel1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PaymentLabel1 = New System.Windows.Forms.Label()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.EmployeeNameLabel1 = New System.Windows.Forms.Label()
        Me.DateOfBirthLabel1 = New System.Windows.Forms.Label()
        Me.MaritialStatusLabel1 = New System.Windows.Forms.Label()
        Me.BloodGroupLabel1 = New System.Windows.Forms.Label()
        Me.ReligionLabel1 = New System.Windows.Forms.Label()
        Me.GenderLabel1 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        EmployeeNameLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        MaritialStatusLabel = New System.Windows.Forms.Label()
        BloodGroupLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        EmployeeNoteLabel = New System.Windows.Forms.Label()
        PaymentLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(45, 504)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 18
        IdLabel.Text = "Id:"
        '
        'EmployeeNameLabel
        '
        EmployeeNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        EmployeeNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        EmployeeNameLabel.ForeColor = System.Drawing.Color.White
        EmployeeNameLabel.Location = New System.Drawing.Point(202, 6)
        EmployeeNameLabel.Name = "EmployeeNameLabel"
        EmployeeNameLabel.Size = New System.Drawing.Size(114, 25)
        EmployeeNameLabel.TabIndex = 23
        EmployeeNameLabel.Text = "কর্মচারীর নামঃ"
        EmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DateOfBirthLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateOfBirthLabel.ForeColor = System.Drawing.Color.White
        DateOfBirthLabel.Location = New System.Drawing.Point(202, 32)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(114, 25)
        DateOfBirthLabel.TabIndex = 22
        DateOfBirthLabel.Text = "জন্ম তারিখঃ"
        DateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaritialStatusLabel
        '
        MaritialStatusLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        MaritialStatusLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        MaritialStatusLabel.ForeColor = System.Drawing.Color.White
        MaritialStatusLabel.Location = New System.Drawing.Point(202, 58)
        MaritialStatusLabel.Name = "MaritialStatusLabel"
        MaritialStatusLabel.Size = New System.Drawing.Size(114, 25)
        MaritialStatusLabel.TabIndex = 21
        MaritialStatusLabel.Text = "বৈবাহিক অবস্থাঃ"
        MaritialStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BloodGroupLabel
        '
        BloodGroupLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        BloodGroupLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        BloodGroupLabel.ForeColor = System.Drawing.Color.White
        BloodGroupLabel.Location = New System.Drawing.Point(202, 84)
        BloodGroupLabel.Name = "BloodGroupLabel"
        BloodGroupLabel.Size = New System.Drawing.Size(114, 25)
        BloodGroupLabel.TabIndex = 20
        BloodGroupLabel.Text = "রক্তের গ্রুপঃ"
        BloodGroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ReligionLabel
        '
        ReligionLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ReligionLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ReligionLabel.ForeColor = System.Drawing.Color.White
        ReligionLabel.Location = New System.Drawing.Point(202, 110)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(114, 25)
        ReligionLabel.TabIndex = 19
        ReligionLabel.Text = "ধর্মঃ"
        ReligionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GenderLabel
        '
        GenderLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        GenderLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        GenderLabel.ForeColor = System.Drawing.Color.White
        GenderLabel.Location = New System.Drawing.Point(202, 136)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(114, 25)
        GenderLabel.TabIndex = 18
        GenderLabel.Text = "লিঙঃ"
        GenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmployeeNoteLabel
        '
        EmployeeNoteLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        EmployeeNoteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        EmployeeNoteLabel.ForeColor = System.Drawing.Color.White
        EmployeeNoteLabel.Location = New System.Drawing.Point(202, 162)
        EmployeeNoteLabel.Name = "EmployeeNoteLabel"
        EmployeeNoteLabel.Size = New System.Drawing.Size(114, 25)
        EmployeeNoteLabel.TabIndex = 17
        EmployeeNoteLabel.Text = "মন্তব্যঃ"
        EmployeeNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaymentLabel
        '
        PaymentLabel.BackColor = System.Drawing.Color.Black
        PaymentLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PaymentLabel.ForeColor = System.Drawing.Color.White
        PaymentLabel.Location = New System.Drawing.Point(202, 188)
        PaymentLabel.Name = "PaymentLabel"
        PaymentLabel.Size = New System.Drawing.Size(114, 25)
        PaymentLabel.TabIndex = 30
        PaymentLabel.Text = "বেতনঃ"
        PaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "কর্মচারীবৃন্দ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataMember = "tblEmployee"
        Me.TblEmployeeBindingSource.DataSource = Me.DataSet
        '
        'TblEmployeeTableAdapter
        '
        Me.TblEmployeeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblEmployeeTableAdapter = Me.TblEmployeeTableAdapter
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
        'TblEmployeeDataGridView
        '
        Me.TblEmployeeDataGridView.AllowUserToAddRows = False
        Me.TblEmployeeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblEmployeeDataGridView.AutoGenerateColumns = False
        Me.TblEmployeeDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblEmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblEmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12})
        Me.TblEmployeeDataGridView.DataSource = Me.TblEmployeeBindingSource
        Me.TblEmployeeDataGridView.Location = New System.Drawing.Point(0, 300)
        Me.TblEmployeeDataGridView.Name = "TblEmployeeDataGridView"
        Me.TblEmployeeDataGridView.ReadOnly = True
        Me.TblEmployeeDataGridView.Size = New System.Drawing.Size(1000, 350)
        Me.TblEmployeeDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "আই ডি"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "employeeName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "কর্মচারীর নাম"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ঠিকানা"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NIDNumber"
        Me.DataGridViewTextBoxColumn7.HeaderText = "এন আই ডি নাম্বার"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "contactNumber"
        Me.DataGridViewTextBoxColumn10.HeaderText = "মোবাইল"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "joinDate"
        Me.DataGridViewTextBoxColumn12.HeaderText = "যোগদানের তারিখ"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 120
        '
        'EmployeeNoteLabel1
        '
        Me.EmployeeNoteLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EmployeeNoteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "employeeNote", True))
        Me.EmployeeNoteLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.EmployeeNoteLabel1.ForeColor = System.Drawing.Color.White
        Me.EmployeeNoteLabel1.Location = New System.Drawing.Point(322, 162)
        Me.EmployeeNoteLabel1.Name = "EmployeeNoteLabel1"
        Me.EmployeeNoteLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.EmployeeNoteLabel1.Size = New System.Drawing.Size(284, 25)
        Me.EmployeeNoteLabel1.TabIndex = 10
        Me.EmployeeNoteLabel1.Text = "NaN"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton7, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 37)
        Me.ToolStrip1.TabIndex = 18
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
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 34)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"কর্মচারির আই.ডি.", "কর্মচারির নাম", "ঠিকানা", "রক্তের গ্রুপ", "এন.আই.ডি নাম্বার", "মোবাইল", "যোগদানের তারিখ"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(150, 37)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 34)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(93, 33)
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
        Me.ToolStripButton2.Size = New System.Drawing.Size(74, 33)
        Me.ToolStripButton2.Text = "ডিলিট"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton7.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton7.Size = New System.Drawing.Size(78, 33)
        Me.ToolStripButton7.Text = "প্রিন্ট"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton1.Size = New System.Drawing.Size(80, 33)
        Me.ToolStripButton1.Text = "কাউন্ট"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(75, 501)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IdTextBox.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(PaymentLabel)
        Me.Panel1.Controls.Add(Me.PaymentLabel1)
        Me.Panel1.Controls.Add(Me.PicturePictureBox)
        Me.Panel1.Controls.Add(Me.EmployeeNameLabel1)
        Me.Panel1.Controls.Add(Me.DateOfBirthLabel1)
        Me.Panel1.Controls.Add(Me.MaritialStatusLabel1)
        Me.Panel1.Controls.Add(Me.BloodGroupLabel1)
        Me.Panel1.Controls.Add(Me.ReligionLabel1)
        Me.Panel1.Controls.Add(Me.GenderLabel1)
        Me.Panel1.Controls.Add(EmployeeNameLabel)
        Me.Panel1.Controls.Add(DateOfBirthLabel)
        Me.Panel1.Controls.Add(MaritialStatusLabel)
        Me.Panel1.Controls.Add(BloodGroupLabel)
        Me.Panel1.Controls.Add(ReligionLabel)
        Me.Panel1.Controls.Add(GenderLabel)
        Me.Panel1.Controls.Add(EmployeeNoteLabel)
        Me.Panel1.Controls.Add(Me.EmployeeNoteLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 581)
        Me.Panel1.TabIndex = 20
        '
        'PaymentLabel1
        '
        Me.PaymentLabel1.BackColor = System.Drawing.Color.Black
        Me.PaymentLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "payment", True))
        Me.PaymentLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PaymentLabel1.ForeColor = System.Drawing.Color.White
        Me.PaymentLabel1.Location = New System.Drawing.Point(322, 188)
        Me.PaymentLabel1.Name = "PaymentLabel1"
        Me.PaymentLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.PaymentLabel1.Size = New System.Drawing.Size(284, 25)
        Me.PaymentLabel1.TabIndex = 31
        Me.PaymentLabel1.Text = "NaN"
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.photo
        Me.PicturePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblEmployeeBindingSource, "picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(612, 6)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(204, 207)
        Me.PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicturePictureBox.TabIndex = 30
        Me.PicturePictureBox.TabStop = False
        '
        'EmployeeNameLabel1
        '
        Me.EmployeeNameLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EmployeeNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "employeeName", True))
        Me.EmployeeNameLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.EmployeeNameLabel1.ForeColor = System.Drawing.Color.White
        Me.EmployeeNameLabel1.Location = New System.Drawing.Point(322, 6)
        Me.EmployeeNameLabel1.Name = "EmployeeNameLabel1"
        Me.EmployeeNameLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.EmployeeNameLabel1.Size = New System.Drawing.Size(284, 25)
        Me.EmployeeNameLabel1.TabIndex = 29
        Me.EmployeeNameLabel1.Text = "NaN"
        '
        'DateOfBirthLabel1
        '
        Me.DateOfBirthLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateOfBirthLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "dateOfBirth", True))
        Me.DateOfBirthLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateOfBirthLabel1.ForeColor = System.Drawing.Color.White
        Me.DateOfBirthLabel1.Location = New System.Drawing.Point(322, 32)
        Me.DateOfBirthLabel1.Name = "DateOfBirthLabel1"
        Me.DateOfBirthLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.DateOfBirthLabel1.Size = New System.Drawing.Size(284, 25)
        Me.DateOfBirthLabel1.TabIndex = 28
        Me.DateOfBirthLabel1.Text = "NaN"
        '
        'MaritialStatusLabel1
        '
        Me.MaritialStatusLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaritialStatusLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "maritialStatus", True))
        Me.MaritialStatusLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MaritialStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.MaritialStatusLabel1.Location = New System.Drawing.Point(322, 58)
        Me.MaritialStatusLabel1.Name = "MaritialStatusLabel1"
        Me.MaritialStatusLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.MaritialStatusLabel1.Size = New System.Drawing.Size(284, 25)
        Me.MaritialStatusLabel1.TabIndex = 27
        Me.MaritialStatusLabel1.Text = "NaN"
        '
        'BloodGroupLabel1
        '
        Me.BloodGroupLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BloodGroupLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "bloodGroup", True))
        Me.BloodGroupLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.BloodGroupLabel1.ForeColor = System.Drawing.Color.White
        Me.BloodGroupLabel1.Location = New System.Drawing.Point(322, 84)
        Me.BloodGroupLabel1.Name = "BloodGroupLabel1"
        Me.BloodGroupLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.BloodGroupLabel1.Size = New System.Drawing.Size(284, 25)
        Me.BloodGroupLabel1.TabIndex = 26
        Me.BloodGroupLabel1.Text = "NaN"
        '
        'ReligionLabel1
        '
        Me.ReligionLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ReligionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "religion", True))
        Me.ReligionLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ReligionLabel1.ForeColor = System.Drawing.Color.White
        Me.ReligionLabel1.Location = New System.Drawing.Point(322, 110)
        Me.ReligionLabel1.Name = "ReligionLabel1"
        Me.ReligionLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.ReligionLabel1.Size = New System.Drawing.Size(284, 25)
        Me.ReligionLabel1.TabIndex = 25
        Me.ReligionLabel1.Text = "NaN"
        '
        'GenderLabel1
        '
        Me.GenderLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenderLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "gender", True))
        Me.GenderLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.GenderLabel1.ForeColor = System.Drawing.Color.White
        Me.GenderLabel1.Location = New System.Drawing.Point(322, 136)
        Me.GenderLabel1.Name = "GenderLabel1"
        Me.GenderLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.GenderLabel1.Size = New System.Drawing.Size(284, 25)
        Me.GenderLabel1.TabIndex = 24
        Me.GenderLabel1.Text = "NaN"
        '
        'manageEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.TblEmployeeDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageEmployee"
        Me.Text = "manageEmployee"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblEmployeeBindingSource As BindingSource
    Friend WithEvents TblEmployeeTableAdapter As dataSetTableAdapters.tblEmployeeTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblEmployeeDataGridView As DataGridView
    Friend WithEvents EmployeeNoteLabel1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents PaymentLabel1 As Label
    Friend WithEvents PicturePictureBox As PictureBox
    Friend WithEvents EmployeeNameLabel1 As Label
    Friend WithEvents DateOfBirthLabel1 As Label
    Friend WithEvents MaritialStatusLabel1 As Label
    Friend WithEvents BloodGroupLabel1 As Label
    Friend WithEvents ReligionLabel1 As Label
    Friend WithEvents GenderLabel1 As Label
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
