<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employeeAttendence
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
        Dim EmployeeNameLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim EmployeeNameLabel1 As System.Windows.Forms.Label
        Dim AttendedLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel1 As System.Windows.Forms.Label
        Dim DateLabel1 As System.Windows.Forms.Label
        Dim EmployeeNameLabel2 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblAttendenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAttendenceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblAttendenceTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblEmployeeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblEmployeeTableAdapter()
        Me.TblAttendenceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk = New System.Windows.Forms.CheckBox()
        Me.EmployeeNameLabel3 = New System.Windows.Forms.Label()
        Me.DateLabel2 = New System.Windows.Forms.Label()
        Me.EmployeeIDLabel2 = New System.Windows.Forms.Label()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.AttendedTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        EmployeeNameLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        EmployeeNameLabel1 = New System.Windows.Forms.Label()
        AttendedLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel1 = New System.Windows.Forms.Label()
        DateLabel1 = New System.Windows.Forms.Label()
        EmployeeNameLabel2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAttendenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAttendenceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeNameLabel
        '
        EmployeeNameLabel.AutoSize = True
        EmployeeNameLabel.Location = New System.Drawing.Point(21, 8)
        EmployeeNameLabel.Name = "EmployeeNameLabel"
        EmployeeNameLabel.Size = New System.Drawing.Size(105, 13)
        EmployeeNameLabel.TabIndex = 20
        EmployeeNameLabel.Text = "employee Name:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(102, 8)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 21
        IdLabel.Text = "Id:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(-59, 150)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(24, 13)
        IdLabel1.TabIndex = 22
        IdLabel1.Text = "Id:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(27, 8)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(37, 13)
        DateLabel.TabIndex = 24
        DateLabel.Text = "date:"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(21, 8)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(86, 13)
        EmployeeIDLabel.TabIndex = 26
        EmployeeIDLabel.Text = "employee ID:"
        '
        'EmployeeNameLabel1
        '
        EmployeeNameLabel1.AutoSize = True
        EmployeeNameLabel1.Location = New System.Drawing.Point(21, 8)
        EmployeeNameLabel1.Name = "EmployeeNameLabel1"
        EmployeeNameLabel1.Size = New System.Drawing.Size(105, 13)
        EmployeeNameLabel1.TabIndex = 28
        EmployeeNameLabel1.Text = "employee Name:"
        '
        'AttendedLabel
        '
        AttendedLabel.AutoSize = True
        AttendedLabel.Location = New System.Drawing.Point(70, 8)
        AttendedLabel.Name = "AttendedLabel"
        AttendedLabel.Size = New System.Drawing.Size(62, 13)
        AttendedLabel.TabIndex = 30
        AttendedLabel.Text = "attended:"
        '
        'EmployeeIDLabel1
        '
        EmployeeIDLabel1.BackColor = System.Drawing.Color.Black
        EmployeeIDLabel1.Font = New System.Drawing.Font("Verdana", 14.0!)
        EmployeeIDLabel1.ForeColor = System.Drawing.Color.White
        EmployeeIDLabel1.Location = New System.Drawing.Point(327, 81)
        EmployeeIDLabel1.Name = "EmployeeIDLabel1"
        EmployeeIDLabel1.Size = New System.Drawing.Size(123, 25)
        EmployeeIDLabel1.TabIndex = 32
        EmployeeIDLabel1.Text = "আইডি"
        EmployeeIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel1
        '
        DateLabel1.BackColor = System.Drawing.Color.Black
        DateLabel1.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateLabel1.ForeColor = System.Drawing.Color.White
        DateLabel1.Location = New System.Drawing.Point(327, 55)
        DateLabel1.Name = "DateLabel1"
        DateLabel1.Size = New System.Drawing.Size(123, 25)
        DateLabel1.TabIndex = 33
        DateLabel1.Text = "তারিখ"
        DateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmployeeNameLabel2
        '
        EmployeeNameLabel2.BackColor = System.Drawing.Color.Black
        EmployeeNameLabel2.Font = New System.Drawing.Font("Verdana", 14.0!)
        EmployeeNameLabel2.ForeColor = System.Drawing.Color.White
        EmployeeNameLabel2.Location = New System.Drawing.Point(327, 107)
        EmployeeNameLabel2.Name = "EmployeeNameLabel2"
        EmployeeNameLabel2.Size = New System.Drawing.Size(123, 25)
        EmployeeNameLabel2.TabIndex = 34
        EmployeeNameLabel2.Text = "নামঃ"
        EmployeeNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "কর্মচারির উপস্থিতি"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 37)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(291, 29)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"তারিখ", "কর্মচারির আই.ডি.", "কর্মচারির নাম"})
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(174, 29)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(112, 37)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
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
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton3.Size = New System.Drawing.Size(78, 33)
        Me.ToolStripButton3.Text = "প্রিন্ট"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAttendenceBindingSource
        '
        Me.TblAttendenceBindingSource.DataMember = "tblAttendence"
        Me.TblAttendenceBindingSource.DataSource = Me.DataSet
        '
        'TblAttendenceTableAdapter
        '
        Me.TblAttendenceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sales_targetTableAdapter = Nothing
        Me.TableAdapterManager.tblassetTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceReportTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceTableAdapter = Me.TblAttendenceTableAdapter
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
        'TblEmployeeTableAdapter
        '
        Me.TblEmployeeTableAdapter.ClearBeforeFill = True
        '
        'TblAttendenceDataGridView
        '
        Me.TblAttendenceDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TblAttendenceDataGridView.AutoGenerateColumns = False
        Me.TblAttendenceDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblAttendenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblAttendenceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblAttendenceDataGridView.DataSource = Me.TblAttendenceBindingSource
        Me.TblAttendenceDataGridView.Location = New System.Drawing.Point(4, 210)
        Me.TblAttendenceDataGridView.Name = "TblAttendenceDataGridView"
        Me.TblAttendenceDataGridView.Size = New System.Drawing.Size(802, 294)
        Me.TblAttendenceDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "employeeID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "আইডি"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "employeeName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "কর্মচারির নাম"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "attended"
        Me.DataGridViewTextBoxColumn5.HeaderText = "উপস্থিতি"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.chk)
        Me.Panel1.Controls.Add(EmployeeNameLabel2)
        Me.Panel1.Controls.Add(Me.EmployeeNameLabel3)
        Me.Panel1.Controls.Add(DateLabel1)
        Me.Panel1.Controls.Add(Me.DateLabel2)
        Me.Panel1.Controls.Add(EmployeeIDLabel1)
        Me.Panel1.Controls.Add(Me.EmployeeIDLabel2)
        Me.Panel1.Controls.Add(Me.PicturePictureBox)
        Me.Panel1.Controls.Add(Me.TblAttendenceDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(95, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 513)
        Me.Panel1.TabIndex = 21
        '
        'chk
        '
        Me.chk.BackColor = System.Drawing.Color.Red
        Me.chk.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.chk.ForeColor = System.Drawing.Color.White
        Me.chk.Location = New System.Drawing.Point(327, 135)
        Me.chk.Name = "chk"
        Me.chk.Padding = New System.Windows.Forms.Padding(150, 0, 0, 0)
        Me.chk.Size = New System.Drawing.Size(371, 35)
        Me.chk.TabIndex = 36
        Me.chk.Text = "উপস্থিত"
        Me.chk.UseVisualStyleBackColor = False
        '
        'EmployeeNameLabel3
        '
        Me.EmployeeNameLabel3.BackColor = System.Drawing.Color.Black
        Me.EmployeeNameLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "employeeName", True))
        Me.EmployeeNameLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.EmployeeNameLabel3.ForeColor = System.Drawing.Color.White
        Me.EmployeeNameLabel3.Location = New System.Drawing.Point(456, 107)
        Me.EmployeeNameLabel3.Name = "EmployeeNameLabel3"
        Me.EmployeeNameLabel3.Padding = New System.Windows.Forms.Padding(4)
        Me.EmployeeNameLabel3.Size = New System.Drawing.Size(242, 25)
        Me.EmployeeNameLabel3.TabIndex = 35
        Me.EmployeeNameLabel3.Text = "NaN"
        '
        'DateLabel2
        '
        Me.DateLabel2.BackColor = System.Drawing.Color.Black
        Me.DateLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "date", True))
        Me.DateLabel2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateLabel2.ForeColor = System.Drawing.Color.White
        Me.DateLabel2.Location = New System.Drawing.Point(456, 55)
        Me.DateLabel2.Name = "DateLabel2"
        Me.DateLabel2.Padding = New System.Windows.Forms.Padding(4)
        Me.DateLabel2.Size = New System.Drawing.Size(242, 25)
        Me.DateLabel2.TabIndex = 34
        Me.DateLabel2.Text = "NaN"
        '
        'EmployeeIDLabel2
        '
        Me.EmployeeIDLabel2.BackColor = System.Drawing.Color.Black
        Me.EmployeeIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "employeeID", True))
        Me.EmployeeIDLabel2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.EmployeeIDLabel2.ForeColor = System.Drawing.Color.White
        Me.EmployeeIDLabel2.Location = New System.Drawing.Point(456, 81)
        Me.EmployeeIDLabel2.Name = "EmployeeIDLabel2"
        Me.EmployeeIDLabel2.Padding = New System.Windows.Forms.Padding(4)
        Me.EmployeeIDLabel2.Size = New System.Drawing.Size(242, 25)
        Me.EmployeeIDLabel2.TabIndex = 33
        Me.EmployeeIDLabel2.Text = "NaN"
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.photo
        Me.PicturePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblEmployeeBindingSource, "picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(62, 9)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(194, 198)
        Me.PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicturePictureBox.TabIndex = 32
        Me.PicturePictureBox.TabStop = False
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataMember = "tblEmployee"
        Me.TblEmployeeBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "Id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(67, 8)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(52, 21)
        Me.IdTextBox1.TabIndex = 23
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(80, 8)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(52, 21)
        Me.DateTextBox.TabIndex = 25
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "employeeID", True))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(67, 8)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(52, 21)
        Me.EmployeeIDTextBox.TabIndex = 27
        '
        'EmployeeNameTextBox1
        '
        Me.EmployeeNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "employeeName", True))
        Me.EmployeeNameTextBox1.Location = New System.Drawing.Point(67, 8)
        Me.EmployeeNameTextBox1.Name = "EmployeeNameTextBox1"
        Me.EmployeeNameTextBox1.Size = New System.Drawing.Size(52, 21)
        Me.EmployeeNameTextBox1.TabIndex = 29
        '
        'AttendedTextBox
        '
        Me.AttendedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "attended", True))
        Me.AttendedTextBox.Location = New System.Drawing.Point(67, 8)
        Me.AttendedTextBox.Name = "AttendedTextBox"
        Me.AttendedTextBox.Size = New System.Drawing.Size(52, 21)
        Me.AttendedTextBox.TabIndex = 31
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(67, 8)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(52, 21)
        Me.IdTextBox.TabIndex = 22
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "employeeName", True))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(67, 8)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(52, 21)
        Me.EmployeeNameTextBox.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(73, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(59, 19)
        Me.Panel2.TabIndex = 37
        '
        'employeeAttendence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(EmployeeNameLabel1)
        Me.Controls.Add(EmployeeNameLabel)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.EmployeeNameTextBox1)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(AttendedLabel)
        Me.Controls.Add(EmployeeIDLabel)
        Me.Controls.Add(Me.AttendedTextBox)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employeeAttendence"
        Me.Text = "employeeAttendence"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAttendenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAttendenceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblAttendenceBindingSource As BindingSource
    Friend WithEvents TblAttendenceTableAdapter As dataSetTableAdapters.tblAttendenceTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblAttendenceDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TblEmployeeTableAdapter As dataSetTableAdapters.tblEmployeeTableAdapter
    Friend WithEvents TblEmployeeBindingSource As BindingSource
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents EmployeeNameTextBox1 As TextBox
    Friend WithEvents AttendedTextBox As TextBox
    Friend WithEvents EmployeeNameLabel3 As Label
    Friend WithEvents DateLabel2 As Label
    Friend WithEvents EmployeeIDLabel2 As Label
    Friend WithEvents PicturePictureBox As PictureBox
    Friend WithEvents chk As CheckBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
