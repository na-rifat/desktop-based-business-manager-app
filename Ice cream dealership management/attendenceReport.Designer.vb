<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class attendenceReport
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
        Dim DateLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim EmployeeNameLabel As System.Windows.Forms.Label
        Dim AttendedLabel As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim EmployeeNameLabel1 As System.Windows.Forms.Label
        Dim EmployeeIDLabel1 As System.Windows.Forms.Label
        Dim AttendedLabel1 As System.Windows.Forms.Label
        Dim Date_Label As System.Windows.Forms.Label
        Dim EmployeeIDLabel2 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblAttendenceReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAttendenceReportTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblAttendenceReportTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblAttendenceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblAttendenceTableAdapter()
        Me.TblAttendenceReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeIDTextBox2 = New System.Windows.Forms.TextBox()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.AttendedTextBox = New System.Windows.Forms.TextBox()
        Me.TblAttendenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.AttendedTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Date_TextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtFilter = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toDt = New System.Windows.Forms.DateTimePicker()
        Me.fromDt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        EmployeeNameLabel = New System.Windows.Forms.Label()
        AttendedLabel = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        EmployeeNameLabel1 = New System.Windows.Forms.Label()
        EmployeeIDLabel1 = New System.Windows.Forms.Label()
        AttendedLabel1 = New System.Windows.Forms.Label()
        Date_Label = New System.Windows.Forms.Label()
        EmployeeIDLabel2 = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAttendenceReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAttendenceReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblAttendenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Verdana", 2.0!)
        IdLabel.Location = New System.Drawing.Point(12, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(7, 4)
        IdLabel.TabIndex = 33
        IdLabel.Text = "Id:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Verdana", 2.0!)
        DateLabel.Location = New System.Drawing.Point(12, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(11, 4)
        DateLabel.TabIndex = 35
        DateLabel.Text = "date:"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Font = New System.Drawing.Font("Verdana", 2.0!)
        EmployeeIDLabel.Location = New System.Drawing.Point(12, 0)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(24, 4)
        EmployeeIDLabel.TabIndex = 37
        EmployeeIDLabel.Text = "employee ID:"
        '
        'EmployeeNameLabel
        '
        EmployeeNameLabel.AutoSize = True
        EmployeeNameLabel.Font = New System.Drawing.Font("Verdana", 2.0!)
        EmployeeNameLabel.Location = New System.Drawing.Point(12, 0)
        EmployeeNameLabel.Name = "EmployeeNameLabel"
        EmployeeNameLabel.Size = New System.Drawing.Size(30, 4)
        EmployeeNameLabel.TabIndex = 39
        EmployeeNameLabel.Text = "employee Name:"
        '
        'AttendedLabel
        '
        AttendedLabel.AutoSize = True
        AttendedLabel.Font = New System.Drawing.Font("Verdana", 2.0!)
        AttendedLabel.Location = New System.Drawing.Point(42, 0)
        AttendedLabel.Name = "AttendedLabel"
        AttendedLabel.Size = New System.Drawing.Size(18, 4)
        AttendedLabel.TabIndex = 41
        AttendedLabel.Text = "attended:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Font = New System.Drawing.Font("Verdana", 2.0!)
        IdLabel1.Location = New System.Drawing.Point(12, 0)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(7, 4)
        IdLabel1.TabIndex = 42
        IdLabel1.Text = "Id:"
        '
        'EmployeeNameLabel1
        '
        EmployeeNameLabel1.AutoSize = True
        EmployeeNameLabel1.Font = New System.Drawing.Font("Verdana", 2.0!)
        EmployeeNameLabel1.Location = New System.Drawing.Point(12, 0)
        EmployeeNameLabel1.Name = "EmployeeNameLabel1"
        EmployeeNameLabel1.Size = New System.Drawing.Size(30, 4)
        EmployeeNameLabel1.TabIndex = 44
        EmployeeNameLabel1.Text = "employee Name:"
        '
        'EmployeeIDLabel1
        '
        EmployeeIDLabel1.AutoSize = True
        EmployeeIDLabel1.Font = New System.Drawing.Font("Verdana", 2.0!)
        EmployeeIDLabel1.Location = New System.Drawing.Point(12, 0)
        EmployeeIDLabel1.Name = "EmployeeIDLabel1"
        EmployeeIDLabel1.Size = New System.Drawing.Size(24, 4)
        EmployeeIDLabel1.TabIndex = 46
        EmployeeIDLabel1.Text = "employee ID:"
        '
        'AttendedLabel1
        '
        AttendedLabel1.AutoSize = True
        AttendedLabel1.Font = New System.Drawing.Font("Verdana", 2.0!)
        AttendedLabel1.Location = New System.Drawing.Point(24, 4)
        AttendedLabel1.Name = "AttendedLabel1"
        AttendedLabel1.Size = New System.Drawing.Size(18, 4)
        AttendedLabel1.TabIndex = 48
        AttendedLabel1.Text = "attended:"
        '
        'Date_Label
        '
        Date_Label.AutoSize = True
        Date_Label.Font = New System.Drawing.Font("Verdana", 2.0!)
        Date_Label.Location = New System.Drawing.Point(12, 0)
        Date_Label.Name = "Date_Label"
        Date_Label.Size = New System.Drawing.Size(12, 4)
        Date_Label.TabIndex = 50
        Date_Label.Text = "date :"
        '
        'EmployeeIDLabel2
        '
        EmployeeIDLabel2.AutoSize = True
        EmployeeIDLabel2.Font = New System.Drawing.Font("Verdana", 2.0!)
        EmployeeIDLabel2.Location = New System.Drawing.Point(12, 0)
        EmployeeIDLabel2.Name = "EmployeeIDLabel2"
        EmployeeIDLabel2.Size = New System.Drawing.Size(24, 4)
        EmployeeIDLabel2.TabIndex = 34
        EmployeeIDLabel2.Text = "employee ID:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "কর্মচারির উপস্থিতি রিপোর্ট"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAttendenceReportBindingSource
        '
        Me.TblAttendenceReportBindingSource.DataMember = "tblAttendenceReport"
        Me.TblAttendenceReportBindingSource.DataSource = Me.DataSet
        '
        'TblAttendenceReportTableAdapter
        '
        Me.TblAttendenceReportTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sales_targetTableAdapter = Nothing
        Me.TableAdapterManager.tblassetTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceReportTableAdapter = Me.TblAttendenceReportTableAdapter
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
        'TblAttendenceTableAdapter
        '
        Me.TblAttendenceTableAdapter.ClearBeforeFill = True
        '
        'TblAttendenceReportDataGridView
        '
        Me.TblAttendenceReportDataGridView.AutoGenerateColumns = False
        Me.TblAttendenceReportDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblAttendenceReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblAttendenceReportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblAttendenceReportDataGridView.DataSource = Me.TblAttendenceReportBindingSource
        Me.TblAttendenceReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblAttendenceReportDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblAttendenceReportDataGridView.Name = "TblAttendenceReportDataGridView"
        Me.TblAttendenceReportDataGridView.Size = New System.Drawing.Size(899, 513)
        Me.TblAttendenceReportDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "employeeName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "কর্মচারির নাম"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "employeeID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "আইডি"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "attended"
        Me.DataGridViewTextBoxColumn4.HeaderText = "উপস্থিতি"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "date "
        Me.DataGridViewTextBoxColumn5.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TblAttendenceReportDataGridView)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(69, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 513)
        Me.Panel1.TabIndex = 7
        '
        'EmployeeIDTextBox2
        '
        Me.EmployeeIDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceReportBindingSource, "employeeID", True))
        Me.EmployeeIDTextBox2.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.EmployeeIDTextBox2.Location = New System.Drawing.Point(12, 0)
        Me.EmployeeIDTextBox2.Name = "EmployeeIDTextBox2"
        Me.EmployeeIDTextBox2.Size = New System.Drawing.Size(100, 11)
        Me.EmployeeIDTextBox2.TabIndex = 35
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceReportBindingSource, "Id", True))
        Me.IdTextBox1.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.IdTextBox1.Location = New System.Drawing.Point(12, 0)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(100, 11)
        Me.IdTextBox1.TabIndex = 43
        '
        'AttendedTextBox
        '
        Me.AttendedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "attended", True))
        Me.AttendedTextBox.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.AttendedTextBox.Location = New System.Drawing.Point(48, 0)
        Me.AttendedTextBox.Name = "AttendedTextBox"
        Me.AttendedTextBox.Size = New System.Drawing.Size(100, 11)
        Me.AttendedTextBox.TabIndex = 42
        '
        'TblAttendenceBindingSource
        '
        Me.TblAttendenceBindingSource.DataMember = "tblAttendence"
        Me.TblAttendenceBindingSource.DataSource = Me.DataSet
        '
        'EmployeeNameTextBox1
        '
        Me.EmployeeNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceReportBindingSource, "employeeName", True))
        Me.EmployeeNameTextBox1.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.EmployeeNameTextBox1.Location = New System.Drawing.Point(12, 0)
        Me.EmployeeNameTextBox1.Name = "EmployeeNameTextBox1"
        Me.EmployeeNameTextBox1.Size = New System.Drawing.Size(100, 11)
        Me.EmployeeNameTextBox1.TabIndex = 45
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "employeeName", True))
        Me.EmployeeNameTextBox.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(12, 0)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(100, 11)
        Me.EmployeeNameTextBox.TabIndex = 40
        '
        'EmployeeIDTextBox1
        '
        Me.EmployeeIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceReportBindingSource, "employeeID", True))
        Me.EmployeeIDTextBox1.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.EmployeeIDTextBox1.Location = New System.Drawing.Point(12, 0)
        Me.EmployeeIDTextBox1.Name = "EmployeeIDTextBox1"
        Me.EmployeeIDTextBox1.Size = New System.Drawing.Size(100, 11)
        Me.EmployeeIDTextBox1.TabIndex = 47
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "employeeID", True))
        Me.EmployeeIDTextBox.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(12, 0)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(100, 11)
        Me.EmployeeIDTextBox.TabIndex = 38
        '
        'AttendedTextBox1
        '
        Me.AttendedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceReportBindingSource, "attended", True))
        Me.AttendedTextBox1.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.AttendedTextBox1.Location = New System.Drawing.Point(12, 0)
        Me.AttendedTextBox1.Name = "AttendedTextBox1"
        Me.AttendedTextBox1.Size = New System.Drawing.Size(100, 11)
        Me.AttendedTextBox1.TabIndex = 49
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "date", True))
        Me.DateTextBox.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.DateTextBox.Location = New System.Drawing.Point(12, 0)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(100, 11)
        Me.DateTextBox.TabIndex = 36
        '
        'Date_TextBox
        '
        Me.Date_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceReportBindingSource, "date ", True))
        Me.Date_TextBox.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.Date_TextBox.Location = New System.Drawing.Point(12, 0)
        Me.Date_TextBox.Name = "Date_TextBox"
        Me.Date_TextBox.Size = New System.Drawing.Size(100, 11)
        Me.Date_TextBox.TabIndex = 51
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAttendenceBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.IdTextBox.Location = New System.Drawing.Point(12, 0)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 11)
        Me.IdTextBox.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(637, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "সার্চঃ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(637, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "সার্চের ধরনঃ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(770, 61)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(165, 24)
        Me.txtSearch.TabIndex = 18
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtFilter.FormattingEnabled = True
        Me.txtFilter.Items.AddRange(New Object() {"কর্মচারির নাম", "কর্মচারির আই.ডি."})
        Me.txtFilter.Location = New System.Drawing.Point(770, 35)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(165, 24)
        Me.txtFilter.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(581, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 34
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(164, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(4)
        Me.Button1.Size = New System.Drawing.Size(228, 50)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "উপস্থিতি স্ট্যাটাস"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(113, 36)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 39
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(526, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "পর্যন্ত"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'toDt
        '
        Me.toDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.toDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.toDt.Location = New System.Drawing.Point(398, 62)
        Me.toDt.Name = "toDt"
        Me.toDt.Size = New System.Drawing.Size(127, 24)
        Me.toDt.TabIndex = 96
        '
        'fromDt
        '
        Me.fromDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.fromDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDt.Location = New System.Drawing.Point(398, 37)
        Me.fromDt.Name = "fromDt"
        Me.fromDt.Size = New System.Drawing.Size(127, 24)
        Me.fromDt.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(526, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "থেকে-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'attendenceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.toDt)
        Me.Controls.Add(Me.fromDt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(EmployeeIDLabel2)
        Me.Controls.Add(EmployeeIDLabel)
        Me.Controls.Add(IdLabel1)
        Me.Controls.Add(Date_Label)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(EmployeeNameLabel1)
        Me.Controls.Add(Me.EmployeeNameTextBox1)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(Me.EmployeeIDTextBox1)
        Me.Controls.Add(EmployeeNameLabel)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(Me.AttendedTextBox1)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.Date_TextBox)
        Me.Controls.Add(Me.EmployeeIDTextBox2)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(Me.AttendedTextBox)
        Me.Controls.Add(EmployeeIDLabel1)
        Me.Controls.Add(AttendedLabel1)
        Me.Controls.Add(AttendedLabel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "attendenceReport"
        Me.Text = "attendenceReport"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAttendenceReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAttendenceReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TblAttendenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblAttendenceReportBindingSource As BindingSource
    Friend WithEvents TblAttendenceReportTableAdapter As dataSetTableAdapters.tblAttendenceReportTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblAttendenceReportDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtFilter As ComboBox
    Friend WithEvents TblAttendenceBindingSource As BindingSource
    Friend WithEvents TblAttendenceTableAdapter As dataSetTableAdapters.tblAttendenceTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents AttendedTextBox As TextBox
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents EmployeeNameTextBox1 As TextBox
    Friend WithEvents EmployeeIDTextBox1 As TextBox
    Friend WithEvents AttendedTextBox1 As TextBox
    Friend WithEvents Date_TextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents EmployeeIDTextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents toDt As DateTimePicker
    Friend WithEvents fromDt As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
