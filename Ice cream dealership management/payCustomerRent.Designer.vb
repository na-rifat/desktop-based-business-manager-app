<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payCustomerRent
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim MLabel As System.Windows.Forms.Label
        Dim YLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim FridgeIDLabel As System.Windows.Forms.Label
        Dim MonthLabel As System.Windows.Forms.Label
        Dim RentLabel As System.Windows.Forms.Label
        Dim DueLabel As System.Windows.Forms.Label
        Dim MonthlyRentLabel As System.Windows.Forms.Label
        Dim FridgeIDLabel1 As System.Windows.Forms.Label
        Dim RentedToIDLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblRentCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRentCTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblRentCTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtdue = New System.Windows.Forms.TextBox()
        Me.paidRent = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TblRentCDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeIDTextBox = New System.Windows.Forms.TextBox()
        Me.MonthTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RentedToIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblFridgesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.MTextBox = New System.Windows.Forms.TextBox()
        Me.YTextBox = New System.Windows.Forms.TextBox()
        Me.RentTextBox = New System.Windows.Forms.TextBox()
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.MonthlyRentTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblFridgesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblFridgesTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        MLabel = New System.Windows.Forms.Label()
        YLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        FridgeIDLabel = New System.Windows.Forms.Label()
        MonthLabel = New System.Windows.Forms.Label()
        RentLabel = New System.Windows.Forms.Label()
        DueLabel = New System.Windows.Forms.Label()
        MonthlyRentLabel = New System.Windows.Forms.Label()
        FridgeIDLabel1 = New System.Windows.Forms.Label()
        RentedToIDLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRentCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblRentCDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        IdLabel.Location = New System.Drawing.Point(881, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 37
        IdLabel.Text = "Id:"
        '
        'MLabel
        '
        MLabel.AutoSize = True
        MLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        MLabel.Location = New System.Drawing.Point(881, 0)
        MLabel.Name = "MLabel"
        MLabel.Size = New System.Drawing.Size(23, 13)
        MLabel.TabIndex = 39
        MLabel.Text = "m:"
        '
        'YLabel
        '
        YLabel.AutoSize = True
        YLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        YLabel.Location = New System.Drawing.Point(881, 0)
        YLabel.Name = "YLabel"
        YLabel.Size = New System.Drawing.Size(19, 13)
        YLabel.TabIndex = 41
        YLabel.Text = "y:"
        '
        'DateLabel
        '
        DateLabel.BackColor = System.Drawing.Color.Black
        DateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DateLabel.Location = New System.Drawing.Point(6, 43)
        DateLabel.Margin = New System.Windows.Forms.Padding(3)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(113, 25)
        DateLabel.TabIndex = 43
        DateLabel.Text = "তারিখঃ"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FridgeIDLabel
        '
        FridgeIDLabel.BackColor = System.Drawing.Color.Black
        FridgeIDLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        FridgeIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        FridgeIDLabel.Location = New System.Drawing.Point(6, 69)
        FridgeIDLabel.Margin = New System.Windows.Forms.Padding(3)
        FridgeIDLabel.Name = "FridgeIDLabel"
        FridgeIDLabel.Size = New System.Drawing.Size(113, 25)
        FridgeIDLabel.TabIndex = 45
        FridgeIDLabel.Text = "ফ্রিজের আই.ডি.:"
        FridgeIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MonthLabel
        '
        MonthLabel.BackColor = System.Drawing.Color.Black
        MonthLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        MonthLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        MonthLabel.Location = New System.Drawing.Point(6, 95)
        MonthLabel.Margin = New System.Windows.Forms.Padding(3)
        MonthLabel.Name = "MonthLabel"
        MonthLabel.Size = New System.Drawing.Size(113, 25)
        MonthLabel.TabIndex = 47
        MonthLabel.Text = "মাসঃ"
        MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RentLabel
        '
        RentLabel.BackColor = System.Drawing.Color.Black
        RentLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        RentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        RentLabel.Location = New System.Drawing.Point(6, 121)
        RentLabel.Margin = New System.Windows.Forms.Padding(3)
        RentLabel.Name = "RentLabel"
        RentLabel.Size = New System.Drawing.Size(113, 25)
        RentLabel.TabIndex = 49
        RentLabel.Text = "পরিশোধঃ"
        RentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DueLabel
        '
        DueLabel.BackColor = System.Drawing.Color.Black
        DueLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DueLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DueLabel.Location = New System.Drawing.Point(6, 147)
        DueLabel.Margin = New System.Windows.Forms.Padding(3)
        DueLabel.Name = "DueLabel"
        DueLabel.Size = New System.Drawing.Size(113, 25)
        DueLabel.TabIndex = 51
        DueLabel.Text = "বাকিঃ"
        DueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MonthlyRentLabel
        '
        MonthlyRentLabel.AutoSize = True
        MonthlyRentLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        MonthlyRentLabel.Location = New System.Drawing.Point(881, 0)
        MonthlyRentLabel.Name = "MonthlyRentLabel"
        MonthlyRentLabel.Size = New System.Drawing.Size(88, 13)
        MonthlyRentLabel.TabIndex = 54
        MonthlyRentLabel.Text = "monthly Rent:"
        '
        'FridgeIDLabel1
        '
        FridgeIDLabel1.AutoSize = True
        FridgeIDLabel1.Font = New System.Drawing.Font("Verdana", 8.25!)
        FridgeIDLabel1.Location = New System.Drawing.Point(881, 0)
        FridgeIDLabel1.Name = "FridgeIDLabel1"
        FridgeIDLabel1.Size = New System.Drawing.Size(63, 13)
        FridgeIDLabel1.TabIndex = 22
        FridgeIDLabel1.Text = "fridge ID:"
        '
        'RentedToIDLabel
        '
        RentedToIDLabel.AutoSize = True
        RentedToIDLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        RentedToIDLabel.Location = New System.Drawing.Point(881, 0)
        RentedToIDLabel.Name = "RentedToIDLabel"
        RentedToIDLabel.Size = New System.Drawing.Size(85, 13)
        RentedToIDLabel.TabIndex = 22
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
        Me.Label1.Text = "গ্রাহকের মাসিক ফ্রিজ ভাড়া আদায়"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRentCBindingSource
        '
        Me.TblRentCBindingSource.DataMember = "tblRentC"
        Me.TblRentCBindingSource.DataSource = Me.DataSet
        '
        'TblRentCTableAdapter
        '
        Me.TblRentCTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblProductsTableAdapter = Nothing
        Me.TableAdapterManager.tblProfitTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseReportTableAdapter = Nothing
        Me.TableAdapterManager.tblPurchaseTableAdapter = Nothing
        Me.TableAdapterManager.tblRentCSTableAdapter = Nothing
        Me.TableAdapterManager.tblRentCTableAdapter = Me.TblRentCTableAdapter
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
        Me.Panel1.Controls.Add(Me.txtdue)
        Me.Panel1.Controls.Add(Me.paidRent)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TblRentCDataGridView)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(DateLabel)
        Me.Panel1.Controls.Add(Me.DateTextBox)
        Me.Panel1.Controls.Add(FridgeIDLabel)
        Me.Panel1.Controls.Add(Me.FridgeIDTextBox)
        Me.Panel1.Controls.Add(MonthLabel)
        Me.Panel1.Controls.Add(Me.MonthTextBox)
        Me.Panel1.Controls.Add(RentLabel)
        Me.Panel1.Controls.Add(DueLabel)
        Me.Panel1.Location = New System.Drawing.Point(40, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 255)
        Me.Panel1.TabIndex = 22
        '
        'txtdue
        '
        Me.txtdue.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtdue.Location = New System.Drawing.Point(125, 146)
        Me.txtdue.Name = "txtdue"
        Me.txtdue.ReadOnly = True
        Me.txtdue.Size = New System.Drawing.Size(253, 24)
        Me.txtdue.TabIndex = 84
        '
        'paidRent
        '
        Me.paidRent.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.paidRent.Location = New System.Drawing.Point(125, 121)
        Me.paidRent.Name = "paidRent"
        Me.paidRent.Size = New System.Drawing.Size(253, 24)
        Me.paidRent.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(125, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 35)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Pay"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TblRentCDataGridView
        '
        Me.TblRentCDataGridView.AutoGenerateColumns = False
        Me.TblRentCDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblRentCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblRentCDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8})
        Me.TblRentCDataGridView.DataSource = Me.TblRentCBindingSource
        Me.TblRentCDataGridView.Location = New System.Drawing.Point(384, 41)
        Me.TblRentCDataGridView.Name = "TblRentCDataGridView"
        Me.TblRentCDataGridView.Size = New System.Drawing.Size(342, 206)
        Me.TblRentCDataGridView.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(384, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 30)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "বাকি"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentCBindingSource, "date", True))
        Me.DateTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTextBox.Location = New System.Drawing.Point(125, 46)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(253, 24)
        Me.DateTextBox.TabIndex = 44
        '
        'FridgeIDTextBox
        '
        Me.FridgeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentCBindingSource, "fridgeID", True))
        Me.FridgeIDTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FridgeIDTextBox.Location = New System.Drawing.Point(125, 71)
        Me.FridgeIDTextBox.Name = "FridgeIDTextBox"
        Me.FridgeIDTextBox.ReadOnly = True
        Me.FridgeIDTextBox.Size = New System.Drawing.Size(253, 24)
        Me.FridgeIDTextBox.TabIndex = 46
        '
        'MonthTextBox
        '
        Me.MonthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentCBindingSource, "month", True))
        Me.MonthTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MonthTextBox.Location = New System.Drawing.Point(125, 96)
        Me.MonthTextBox.Name = "MonthTextBox"
        Me.MonthTextBox.ReadOnly = True
        Me.MonthTextBox.Size = New System.Drawing.Size(253, 24)
        Me.MonthTextBox.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.TextBox1.Location = New System.Drawing.Point(881, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 85
        '
        'RentedToIDTextBox
        '
        Me.RentedToIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rentedToID", True))
        Me.RentedToIDTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.RentedToIDTextBox.Location = New System.Drawing.Point(881, 0)
        Me.RentedToIDTextBox.Name = "RentedToIDTextBox"
        Me.RentedToIDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.RentedToIDTextBox.TabIndex = 23
        '
        'TblFridgesBindingSource
        '
        Me.TblFridgesBindingSource.DataMember = "tblFridges"
        Me.TblFridgesBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentCBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.IdTextBox.Location = New System.Drawing.Point(881, 0)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(116, 21)
        Me.IdTextBox.TabIndex = 38
        '
        'MTextBox
        '
        Me.MTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentCBindingSource, "m", True))
        Me.MTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.MTextBox.Location = New System.Drawing.Point(881, 0)
        Me.MTextBox.Name = "MTextBox"
        Me.MTextBox.Size = New System.Drawing.Size(116, 21)
        Me.MTextBox.TabIndex = 40
        '
        'YTextBox
        '
        Me.YTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentCBindingSource, "y", True))
        Me.YTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.YTextBox.Location = New System.Drawing.Point(881, 0)
        Me.YTextBox.Name = "YTextBox"
        Me.YTextBox.Size = New System.Drawing.Size(116, 21)
        Me.YTextBox.TabIndex = 42
        '
        'RentTextBox
        '
        Me.RentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentCBindingSource, "rent", True))
        Me.RentTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.RentTextBox.Location = New System.Drawing.Point(881, 0)
        Me.RentTextBox.Name = "RentTextBox"
        Me.RentTextBox.Size = New System.Drawing.Size(30, 21)
        Me.RentTextBox.TabIndex = 50
        '
        'DueTextBox
        '
        Me.DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentCBindingSource, "due", True))
        Me.DueTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.DueTextBox.Location = New System.Drawing.Point(881, 0)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.Size = New System.Drawing.Size(56, 21)
        Me.DueTextBox.TabIndex = 52
        '
        'MonthlyRentTextBox
        '
        Me.MonthlyRentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "monthlyRent", True))
        Me.MonthlyRentTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.MonthlyRentTextBox.Location = New System.Drawing.Point(881, 0)
        Me.MonthlyRentTextBox.Name = "MonthlyRentTextBox"
        Me.MonthlyRentTextBox.Size = New System.Drawing.Size(100, 21)
        Me.MonthlyRentTextBox.TabIndex = 55
        '
        'FridgeIDTextBox1
        '
        Me.FridgeIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeID", True))
        Me.FridgeIDTextBox1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FridgeIDTextBox1.Location = New System.Drawing.Point(881, 0)
        Me.FridgeIDTextBox1.Name = "FridgeIDTextBox1"
        Me.FridgeIDTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.FridgeIDTextBox1.TabIndex = 23
        '
        'TblFridgesTableAdapter
        '
        Me.TblFridgesTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(3, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 35)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "← ফ্রিজের তালিকা"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "month"
        Me.DataGridViewTextBoxColumn6.HeaderText = "মাস"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn8.HeaderText = "বাকির পরিমাণ"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'payCustomerRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(RentedToIDLabel)
        Me.Controls.Add(Me.FridgeIDTextBox1)
        Me.Controls.Add(FridgeIDLabel1)
        Me.Controls.Add(Me.MonthlyRentTextBox)
        Me.Controls.Add(MonthlyRentLabel)
        Me.Controls.Add(Me.DueTextBox)
        Me.Controls.Add(Me.RentTextBox)
        Me.Controls.Add(Me.YTextBox)
        Me.Controls.Add(YLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MTextBox)
        Me.Controls.Add(Me.RentedToIDTextBox)
        Me.Controls.Add(MLabel)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "payCustomerRent"
        Me.Text = "  "
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRentCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblRentCDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblRentCBindingSource As BindingSource
    Friend WithEvents TblRentCTableAdapter As dataSetTableAdapters.tblRentCTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents MTextBox As TextBox
    Friend WithEvents YTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents FridgeIDTextBox As TextBox
    Friend WithEvents MonthTextBox As TextBox
    Friend WithEvents RentTextBox As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TblRentCDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TblFridgesBindingSource As BindingSource
    Friend WithEvents TblFridgesTableAdapter As dataSetTableAdapters.tblFridgesTableAdapter
    Friend WithEvents MonthlyRentTextBox As TextBox
    Friend WithEvents FridgeIDTextBox1 As TextBox
    Friend WithEvents paidRent As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtdue As TextBox
    Friend WithEvents RentedToIDTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
