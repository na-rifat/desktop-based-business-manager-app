<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class paySupplierRent
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
        Dim MLabel As System.Windows.Forms.Label
        Dim YLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim FridgeIDLabel As System.Windows.Forms.Label
        Dim MonthLabel As System.Windows.Forms.Label
        Dim RentLabel As System.Windows.Forms.Label
        Dim DueLabel As System.Windows.Forms.Label
        Dim CompanyRentLabel As System.Windows.Forms.Label
        Dim FridgeIDLabel1 As System.Windows.Forms.Label
        Dim RentedToIDLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtdue = New System.Windows.Forms.TextBox()
        Me.paidRent = New System.Windows.Forms.TextBox()
        Me.TblRentSDataGridView = New System.Windows.Forms.DataGridView()
        Me.TblRentSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeIDTextBox = New System.Windows.Forms.TextBox()
        Me.MonthTextBox = New System.Windows.Forms.TextBox()
        Me.RentedToIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblFridgesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.MTextBox = New System.Windows.Forms.TextBox()
        Me.YTextBox = New System.Windows.Forms.TextBox()
        Me.RentTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.CompanyRentTextBox = New System.Windows.Forms.TextBox()
        Me.TblRentSTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblRentSTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
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
        CompanyRentLabel = New System.Windows.Forms.Label()
        FridgeIDLabel1 = New System.Windows.Forms.Label()
        RentedToIDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblRentSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRentSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(110, -8)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 61
        IdLabel.Text = "Id:"
        '
        'MLabel
        '
        MLabel.AutoSize = True
        MLabel.Location = New System.Drawing.Point(110, -8)
        MLabel.Name = "MLabel"
        MLabel.Size = New System.Drawing.Size(23, 13)
        MLabel.TabIndex = 63
        MLabel.Text = "m:"
        '
        'YLabel
        '
        YLabel.AutoSize = True
        YLabel.Location = New System.Drawing.Point(110, -8)
        YLabel.Name = "YLabel"
        YLabel.Size = New System.Drawing.Size(19, 13)
        YLabel.TabIndex = 65
        YLabel.Text = "y:"
        '
        'DateLabel
        '
        DateLabel.BackColor = System.Drawing.Color.Black
        DateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DateLabel.Location = New System.Drawing.Point(5, 49)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(93, 25)
        DateLabel.TabIndex = 67
        DateLabel.Text = "তারিখঃ"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FridgeIDLabel
        '
        FridgeIDLabel.BackColor = System.Drawing.Color.Black
        FridgeIDLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        FridgeIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        FridgeIDLabel.Location = New System.Drawing.Point(5, 75)
        FridgeIDLabel.Name = "FridgeIDLabel"
        FridgeIDLabel.Size = New System.Drawing.Size(93, 25)
        FridgeIDLabel.TabIndex = 69
        FridgeIDLabel.Text = "ফ্রিজের আই.ডি.:"
        FridgeIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MonthLabel
        '
        MonthLabel.BackColor = System.Drawing.Color.Black
        MonthLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        MonthLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        MonthLabel.Location = New System.Drawing.Point(5, 101)
        MonthLabel.Name = "MonthLabel"
        MonthLabel.Size = New System.Drawing.Size(93, 25)
        MonthLabel.TabIndex = 71
        MonthLabel.Text = "মাসঃ"
        MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RentLabel
        '
        RentLabel.BackColor = System.Drawing.Color.Black
        RentLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        RentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        RentLabel.Location = New System.Drawing.Point(5, 127)
        RentLabel.Name = "RentLabel"
        RentLabel.Size = New System.Drawing.Size(93, 25)
        RentLabel.TabIndex = 73
        RentLabel.Text = "পরিশোধঃ"
        RentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DueLabel
        '
        DueLabel.BackColor = System.Drawing.Color.Black
        DueLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DueLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DueLabel.Location = New System.Drawing.Point(5, 153)
        DueLabel.Name = "DueLabel"
        DueLabel.Size = New System.Drawing.Size(93, 25)
        DueLabel.TabIndex = 75
        DueLabel.Text = "বাকিঃ"
        DueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyRentLabel
        '
        CompanyRentLabel.AutoSize = True
        CompanyRentLabel.Location = New System.Drawing.Point(110, -8)
        CompanyRentLabel.Name = "CompanyRentLabel"
        CompanyRentLabel.Size = New System.Drawing.Size(94, 13)
        CompanyRentLabel.TabIndex = 21
        CompanyRentLabel.Text = "company Rent:"
        '
        'FridgeIDLabel1
        '
        FridgeIDLabel1.AutoSize = True
        FridgeIDLabel1.Location = New System.Drawing.Point(110, -8)
        FridgeIDLabel1.Name = "FridgeIDLabel1"
        FridgeIDLabel1.Size = New System.Drawing.Size(63, 13)
        FridgeIDLabel1.TabIndex = 80
        FridgeIDLabel1.Text = "fridge ID:"
        '
        'RentedToIDLabel
        '
        RentedToIDLabel.AutoSize = True
        RentedToIDLabel.Location = New System.Drawing.Point(110, -8)
        RentedToIDLabel.Name = "RentedToIDLabel"
        RentedToIDLabel.Size = New System.Drawing.Size(85, 13)
        RentedToIDLabel.TabIndex = 21
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
        Me.Label1.Text = "কোম্পানির মাসিক ফ্রিজ ভাড়া পরিশোধ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtdue)
        Me.Panel1.Controls.Add(Me.paidRent)
        Me.Panel1.Controls.Add(Me.TblRentSDataGridView)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(DateLabel)
        Me.Panel1.Controls.Add(Me.DateTextBox)
        Me.Panel1.Controls.Add(FridgeIDLabel)
        Me.Panel1.Controls.Add(Me.FridgeIDTextBox)
        Me.Panel1.Controls.Add(MonthLabel)
        Me.Panel1.Controls.Add(Me.MonthTextBox)
        Me.Panel1.Controls.Add(RentLabel)
        Me.Panel1.Controls.Add(DueLabel)
        Me.Panel1.Location = New System.Drawing.Point(99, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 263)
        Me.Panel1.TabIndex = 21
        '
        'txtdue
        '
        Me.txtdue.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtdue.Location = New System.Drawing.Point(102, 149)
        Me.txtdue.Name = "txtdue"
        Me.txtdue.ReadOnly = True
        Me.txtdue.Size = New System.Drawing.Size(277, 24)
        Me.txtdue.TabIndex = 23
        '
        'paidRent
        '
        Me.paidRent.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.paidRent.Location = New System.Drawing.Point(102, 124)
        Me.paidRent.Name = "paidRent"
        Me.paidRent.Size = New System.Drawing.Size(277, 24)
        Me.paidRent.TabIndex = 82
        '
        'TblRentSDataGridView
        '
        Me.TblRentSDataGridView.AutoGenerateColumns = False
        Me.TblRentSDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblRentSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblRentSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8})
        Me.TblRentSDataGridView.DataSource = Me.TblRentSBindingSource
        Me.TblRentSDataGridView.Location = New System.Drawing.Point(385, 42)
        Me.TblRentSDataGridView.Name = "TblRentSDataGridView"
        Me.TblRentSDataGridView.Size = New System.Drawing.Size(341, 206)
        Me.TblRentSDataGridView.TabIndex = 80
        '
        'TblRentSBindingSource
        '
        Me.TblRentSBindingSource.DataMember = "tblRentS"
        Me.TblRentSBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(385, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 30)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "বাকি"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(102, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(277, 35)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "পরিশোধ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentSBindingSource, "date", True))
        Me.DateTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTextBox.Location = New System.Drawing.Point(102, 49)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(277, 24)
        Me.DateTextBox.TabIndex = 68
        '
        'FridgeIDTextBox
        '
        Me.FridgeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentSBindingSource, "fridgeID", True))
        Me.FridgeIDTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FridgeIDTextBox.Location = New System.Drawing.Point(102, 74)
        Me.FridgeIDTextBox.Name = "FridgeIDTextBox"
        Me.FridgeIDTextBox.ReadOnly = True
        Me.FridgeIDTextBox.Size = New System.Drawing.Size(277, 24)
        Me.FridgeIDTextBox.TabIndex = 70
        '
        'MonthTextBox
        '
        Me.MonthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentSBindingSource, "month", True))
        Me.MonthTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MonthTextBox.Location = New System.Drawing.Point(102, 99)
        Me.MonthTextBox.Name = "MonthTextBox"
        Me.MonthTextBox.ReadOnly = True
        Me.MonthTextBox.Size = New System.Drawing.Size(277, 24)
        Me.MonthTextBox.TabIndex = 72
        '
        'RentedToIDTextBox
        '
        Me.RentedToIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "rentedToID", True))
        Me.RentedToIDTextBox.Location = New System.Drawing.Point(110, -8)
        Me.RentedToIDTextBox.Name = "RentedToIDTextBox"
        Me.RentedToIDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.RentedToIDTextBox.TabIndex = 22
        '
        'TblFridgesBindingSource
        '
        Me.TblFridgesBindingSource.DataMember = "tblFridges"
        Me.TblFridgesBindingSource.DataSource = Me.DataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, -8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 22
        '
        'DueTextBox
        '
        Me.DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentSBindingSource, "due", True))
        Me.DueTextBox.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DueTextBox.Location = New System.Drawing.Point(110, -8)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.ReadOnly = True
        Me.DueTextBox.Size = New System.Drawing.Size(66, 24)
        Me.DueTextBox.TabIndex = 76
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentSBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(110, -8)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(116, 21)
        Me.IdTextBox.TabIndex = 62
        '
        'MTextBox
        '
        Me.MTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentSBindingSource, "m", True))
        Me.MTextBox.Location = New System.Drawing.Point(110, -8)
        Me.MTextBox.Name = "MTextBox"
        Me.MTextBox.Size = New System.Drawing.Size(116, 21)
        Me.MTextBox.TabIndex = 64
        '
        'YTextBox
        '
        Me.YTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentSBindingSource, "y", True))
        Me.YTextBox.Location = New System.Drawing.Point(110, -8)
        Me.YTextBox.Name = "YTextBox"
        Me.YTextBox.Size = New System.Drawing.Size(116, 21)
        Me.YTextBox.TabIndex = 66
        '
        'RentTextBox
        '
        Me.RentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRentSBindingSource, "rent", True))
        Me.RentTextBox.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RentTextBox.Location = New System.Drawing.Point(110, -8)
        Me.RentTextBox.Name = "RentTextBox"
        Me.RentTextBox.Size = New System.Drawing.Size(63, 24)
        Me.RentTextBox.TabIndex = 74
        '
        'FridgeIDTextBox1
        '
        Me.FridgeIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeID", True))
        Me.FridgeIDTextBox1.Location = New System.Drawing.Point(110, -8)
        Me.FridgeIDTextBox1.Name = "FridgeIDTextBox1"
        Me.FridgeIDTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.FridgeIDTextBox1.TabIndex = 81
        '
        'CompanyRentTextBox
        '
        Me.CompanyRentTextBox.AcceptsReturn = True
        Me.CompanyRentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "companyRent", True))
        Me.CompanyRentTextBox.Location = New System.Drawing.Point(61, 8)
        Me.CompanyRentTextBox.Name = "CompanyRentTextBox"
        Me.CompanyRentTextBox.Size = New System.Drawing.Size(55, 21)
        Me.CompanyRentTextBox.TabIndex = 22
        '
        'TblRentSTableAdapter
        '
        Me.TblRentSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblFridgesTableAdapter = Me.TblFridgesTableAdapter
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
        Me.TableAdapterManager.tblRentSTableAdapter = Me.TblRentSTableAdapter
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
        Me.Button2.TabIndex = 83
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
        'paySupplierRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompanyRentTextBox)
        Me.Controls.Add(RentedToIDLabel)
        Me.Controls.Add(Me.FridgeIDTextBox1)
        Me.Controls.Add(FridgeIDLabel1)
        Me.Controls.Add(CompanyRentLabel)
        Me.Controls.Add(Me.RentTextBox)
        Me.Controls.Add(Me.YTextBox)
        Me.Controls.Add(YLabel)
        Me.Controls.Add(Me.MTextBox)
        Me.Controls.Add(MLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.RentedToIDTextBox)
        Me.Controls.Add(Me.DueTextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "paySupplierRent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblRentSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRentSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblRentSBindingSource As BindingSource
    Friend WithEvents TblRentSTableAdapter As dataSetTableAdapters.tblRentSTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents MTextBox As TextBox
    Friend WithEvents YTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents FridgeIDTextBox As TextBox
    Friend WithEvents MonthTextBox As TextBox
    Friend WithEvents RentTextBox As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TblRentSDataGridView As DataGridView
    Friend WithEvents TblFridgesBindingSource As BindingSource
    Friend WithEvents TblFridgesTableAdapter As dataSetTableAdapters.tblFridgesTableAdapter
    Friend WithEvents CompanyRentTextBox As TextBox
    Friend WithEvents FridgeIDTextBox1 As TextBox
    Friend WithEvents paidRent As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RentedToIDTextBox As TextBox
    Friend WithEvents txtdue As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
