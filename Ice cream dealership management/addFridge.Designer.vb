<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addFridge
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
        Dim FridgeModelNoLabel As System.Windows.Forms.Label
        Dim SupplierNameLabel As System.Windows.Forms.Label
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim FridgeConditionLabel As System.Windows.Forms.Label
        Dim FridgeIDLabel As System.Windows.Forms.Label
        Dim FridgeNoteLabel As System.Windows.Forms.Label
        Dim CompanyRentLabel As System.Windows.Forms.Label
        Dim CompanySecurityMoneyLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblFridgesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblFridgesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblFridgesTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.rdO = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rdN = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.chkS = New System.Windows.Forms.CheckBox()
        Me.FridgeModelNoTextBox = New System.Windows.Forms.TextBox()
        Me.CompanySecurityMoneyTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyRentTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeIDTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeNoteTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeConditionTextBox = New System.Windows.Forms.TextBox()
        Me.IssueDateTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblSuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSuppliersTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblSuppliersTableAdapter()
        FridgeModelNoLabel = New System.Windows.Forms.Label()
        SupplierNameLabel = New System.Windows.Forms.Label()
        IssueDateLabel = New System.Windows.Forms.Label()
        FridgeConditionLabel = New System.Windows.Forms.Label()
        FridgeIDLabel = New System.Windows.Forms.Label()
        FridgeNoteLabel = New System.Windows.Forms.Label()
        CompanyRentLabel = New System.Windows.Forms.Label()
        CompanySecurityMoneyLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblSuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FridgeModelNoLabel
        '
        FridgeModelNoLabel.BackColor = System.Drawing.Color.Black
        FridgeModelNoLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        FridgeModelNoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        FridgeModelNoLabel.Location = New System.Drawing.Point(12, 8)
        FridgeModelNoLabel.Name = "FridgeModelNoLabel"
        FridgeModelNoLabel.Size = New System.Drawing.Size(119, 25)
        FridgeModelNoLabel.TabIndex = 49
        FridgeModelNoLabel.Text = "মডেল নাম্বারঃ"
        FridgeModelNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SupplierNameLabel
        '
        SupplierNameLabel.BackColor = System.Drawing.Color.Black
        SupplierNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SupplierNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SupplierNameLabel.Location = New System.Drawing.Point(12, 34)
        SupplierNameLabel.Name = "SupplierNameLabel"
        SupplierNameLabel.Size = New System.Drawing.Size(119, 25)
        SupplierNameLabel.TabIndex = 51
        SupplierNameLabel.Text = "কোম্পানিঃ"
        SupplierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IssueDateLabel
        '
        IssueDateLabel.BackColor = System.Drawing.Color.Black
        IssueDateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        IssueDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        IssueDateLabel.Location = New System.Drawing.Point(12, 60)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(119, 25)
        IssueDateLabel.TabIndex = 53
        IssueDateLabel.Text = "ইস্যুর তারিখঃ"
        IssueDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FridgeConditionLabel
        '
        FridgeConditionLabel.BackColor = System.Drawing.Color.Black
        FridgeConditionLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        FridgeConditionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        FridgeConditionLabel.Location = New System.Drawing.Point(12, 86)
        FridgeConditionLabel.Name = "FridgeConditionLabel"
        FridgeConditionLabel.Size = New System.Drawing.Size(119, 25)
        FridgeConditionLabel.TabIndex = 55
        FridgeConditionLabel.Text = "ফ্রিজের কন্ডিশনঃ"
        FridgeConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FridgeIDLabel
        '
        FridgeIDLabel.BackColor = System.Drawing.Color.Black
        FridgeIDLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        FridgeIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        FridgeIDLabel.Location = New System.Drawing.Point(12, 112)
        FridgeIDLabel.Name = "FridgeIDLabel"
        FridgeIDLabel.Size = New System.Drawing.Size(119, 25)
        FridgeIDLabel.TabIndex = 59
        FridgeIDLabel.Text = "ফ্রিজের আইডিঃ"
        FridgeIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FridgeNoteLabel
        '
        FridgeNoteLabel.BackColor = System.Drawing.Color.Black
        FridgeNoteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        FridgeNoteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        FridgeNoteLabel.Location = New System.Drawing.Point(12, 138)
        FridgeNoteLabel.Name = "FridgeNoteLabel"
        FridgeNoteLabel.Size = New System.Drawing.Size(119, 25)
        FridgeNoteLabel.TabIndex = 61
        FridgeNoteLabel.Text = "মন্তব্যঃ"
        FridgeNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyRentLabel
        '
        CompanyRentLabel.BackColor = System.Drawing.Color.Black
        CompanyRentLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CompanyRentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CompanyRentLabel.Location = New System.Drawing.Point(12, 190)
        CompanyRentLabel.Name = "CompanyRentLabel"
        CompanyRentLabel.Size = New System.Drawing.Size(119, 25)
        CompanyRentLabel.TabIndex = 67
        CompanyRentLabel.Text = "মাসিক ভাড়াঃ"
        CompanyRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanySecurityMoneyLabel
        '
        CompanySecurityMoneyLabel.BackColor = System.Drawing.Color.Black
        CompanySecurityMoneyLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CompanySecurityMoneyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CompanySecurityMoneyLabel.Location = New System.Drawing.Point(12, 164)
        CompanySecurityMoneyLabel.Name = "CompanySecurityMoneyLabel"
        CompanySecurityMoneyLabel.Size = New System.Drawing.Size(119, 25)
        CompanySecurityMoneyLabel.TabIndex = 69
        CompanySecurityMoneyLabel.Text = "জামানতঃ"
        CompanySecurityMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler CompanySecurityMoneyLabel.Click, AddressOf Me.CompanySecurityMoneyLabel_Click
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
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "কোম্পানি থেকে ফ্রিজ আনুন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFridgesBindingSource
        '
        Me.TblFridgesBindingSource.DataMember = "tblFridges"
        Me.TblFridgesBindingSource.DataSource = Me.DataSet
        '
        'TblFridgesTableAdapter
        '
        Me.TblFridgesTableAdapter.ClearBeforeFill = True
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
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.rdO)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.rdN)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.chkS)
        Me.Panel1.Controls.Add(FridgeModelNoLabel)
        Me.Panel1.Controls.Add(CompanySecurityMoneyLabel)
        Me.Panel1.Controls.Add(Me.FridgeModelNoTextBox)
        Me.Panel1.Controls.Add(Me.CompanySecurityMoneyTextBox)
        Me.Panel1.Controls.Add(SupplierNameLabel)
        Me.Panel1.Controls.Add(Me.CompanyRentTextBox)
        Me.Panel1.Controls.Add(CompanyRentLabel)
        Me.Panel1.Controls.Add(Me.SupplierNameTextBox)
        Me.Panel1.Controls.Add(IssueDateLabel)
        Me.Panel1.Controls.Add(FridgeConditionLabel)
        Me.Panel1.Controls.Add(FridgeIDLabel)
        Me.Panel1.Controls.Add(Me.FridgeIDTextBox)
        Me.Panel1.Controls.Add(FridgeNoteLabel)
        Me.Panel1.Controls.Add(Me.FridgeNoteTextBox)
        Me.Panel1.Location = New System.Drawing.Point(259, 187)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 275)
        Me.Panel1.TabIndex = 19
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(137, 60)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(133, 24)
        Me.DateTimePicker2.TabIndex = 60
        '
        'rdO
        '
        Me.rdO.AutoSize = True
        Me.rdO.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.rdO.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.rdO.Location = New System.Drawing.Point(193, 85)
        Me.rdO.Name = "rdO"
        Me.rdO.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.rdO.Size = New System.Drawing.Size(91, 27)
        Me.rdO.TabIndex = 75
        Me.rdO.Text = "ব্যবহৃত"
        Me.rdO.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(137, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 35)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "আনুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rdN
        '
        Me.rdN.AutoSize = True
        Me.rdN.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.rdN.Checked = True
        Me.rdN.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.rdN.Location = New System.Drawing.Point(137, 85)
        Me.rdN.Name = "rdN"
        Me.rdN.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.rdN.Size = New System.Drawing.Size(75, 27)
        Me.rdN.TabIndex = 74
        Me.rdN.TabStop = True
        Me.rdN.Text = "নতুন"
        Me.rdN.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(317, 218)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 73
        Me.Button3.UseVisualStyleBackColor = False
        '
        'chkS
        '
        Me.chkS.AutoSize = True
        Me.chkS.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkS.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chkS.Location = New System.Drawing.Point(269, 184)
        Me.chkS.Name = "chkS"
        Me.chkS.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chkS.Size = New System.Drawing.Size(59, 27)
        Me.chkS.TabIndex = 72
        Me.chkS.Text = "ফ্রি"
        Me.chkS.UseVisualStyleBackColor = False
        '
        'FridgeModelNoTextBox
        '
        Me.FridgeModelNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeModelNo", True))
        Me.FridgeModelNoTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FridgeModelNoTextBox.Location = New System.Drawing.Point(137, 10)
        Me.FridgeModelNoTextBox.Name = "FridgeModelNoTextBox"
        Me.FridgeModelNoTextBox.Size = New System.Drawing.Size(226, 24)
        Me.FridgeModelNoTextBox.TabIndex = 50
        '
        'CompanySecurityMoneyTextBox
        '
        Me.CompanySecurityMoneyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "companySecurityMoney", True))
        Me.CompanySecurityMoneyTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CompanySecurityMoneyTextBox.Location = New System.Drawing.Point(137, 163)
        Me.CompanySecurityMoneyTextBox.Name = "CompanySecurityMoneyTextBox"
        Me.CompanySecurityMoneyTextBox.Size = New System.Drawing.Size(126, 24)
        Me.CompanySecurityMoneyTextBox.TabIndex = 70
        '
        'CompanyRentTextBox
        '
        Me.CompanyRentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "companyRent", True))
        Me.CompanyRentTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CompanyRentTextBox.Location = New System.Drawing.Point(137, 188)
        Me.CompanyRentTextBox.Name = "CompanyRentTextBox"
        Me.CompanyRentTextBox.Size = New System.Drawing.Size(126, 24)
        Me.CompanyRentTextBox.TabIndex = 68
        '
        'SupplierNameTextBox
        '
        Me.SupplierNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "supplierName", True))
        Me.SupplierNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SupplierNameTextBox.Location = New System.Drawing.Point(137, 35)
        Me.SupplierNameTextBox.Name = "SupplierNameTextBox"
        Me.SupplierNameTextBox.Size = New System.Drawing.Size(226, 24)
        Me.SupplierNameTextBox.TabIndex = 52
        '
        'FridgeIDTextBox
        '
        Me.FridgeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeID", True))
        Me.FridgeIDTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FridgeIDTextBox.Location = New System.Drawing.Point(137, 113)
        Me.FridgeIDTextBox.Name = "FridgeIDTextBox"
        Me.FridgeIDTextBox.ReadOnly = True
        Me.FridgeIDTextBox.Size = New System.Drawing.Size(226, 24)
        Me.FridgeIDTextBox.TabIndex = 60
        '
        'FridgeNoteTextBox
        '
        Me.FridgeNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeNote", True))
        Me.FridgeNoteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.FridgeNoteTextBox.Location = New System.Drawing.Point(137, 138)
        Me.FridgeNoteTextBox.Name = "FridgeNoteTextBox"
        Me.FridgeNoteTextBox.Size = New System.Drawing.Size(226, 24)
        Me.FridgeNoteTextBox.TabIndex = 62
        '
        'FridgeConditionTextBox
        '
        Me.FridgeConditionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "fridgeCondition", True))
        Me.FridgeConditionTextBox.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        Me.FridgeConditionTextBox.Location = New System.Drawing.Point(125, -21)
        Me.FridgeConditionTextBox.Name = "FridgeConditionTextBox"
        Me.FridgeConditionTextBox.Size = New System.Drawing.Size(27, 33)
        Me.FridgeConditionTextBox.TabIndex = 56
        '
        'IssueDateTextBox
        '
        Me.IssueDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFridgesBindingSource, "issueDate", True))
        Me.IssueDateTextBox.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        Me.IssueDateTextBox.Location = New System.Drawing.Point(125, -10)
        Me.IssueDateTextBox.Name = "IssueDateTextBox"
        Me.IssueDateTextBox.Size = New System.Drawing.Size(14, 33)
        Me.IssueDateTextBox.TabIndex = 54
        '
        'SupplierNameTextBox1
        '
        Me.SupplierNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSuppliersBindingSource, "supplierName", True))
        Me.SupplierNameTextBox1.Location = New System.Drawing.Point(125, 0)
        Me.SupplierNameTextBox1.Name = "SupplierNameTextBox1"
        Me.SupplierNameTextBox1.Size = New System.Drawing.Size(18, 21)
        Me.SupplierNameTextBox1.TabIndex = 20
        '
        'TblSuppliersBindingSource
        '
        Me.TblSuppliersBindingSource.DataMember = "tblSuppliers"
        Me.TblSuppliersBindingSource.DataSource = Me.DataSet
        '
        'TblSuppliersTableAdapter
        '
        Me.TblSuppliersTableAdapter.ClearBeforeFill = True
        '
        'addFridge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FridgeConditionTextBox)
        Me.Controls.Add(Me.SupplierNameTextBox1)
        Me.Controls.Add(Me.IssueDateTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addFridge"
        Me.Text = "addFridge"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFridgesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblSuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblFridgesBindingSource As BindingSource
    Friend WithEvents TblFridgesTableAdapter As dataSetTableAdapters.tblFridgesTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FridgeModelNoTextBox As TextBox
    Friend WithEvents SupplierNameTextBox As TextBox
    Friend WithEvents IssueDateTextBox As TextBox
    Friend WithEvents FridgeConditionTextBox As TextBox
    Friend WithEvents FridgeIDTextBox As TextBox
    Friend WithEvents FridgeNoteTextBox As TextBox
    Friend WithEvents CompanyRentTextBox As TextBox
    Friend WithEvents CompanySecurityMoneyTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents chkS As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents rdO As RadioButton
    Friend WithEvents rdN As RadioButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TblSuppliersBindingSource As BindingSource
    Friend WithEvents TblSuppliersTableAdapter As dataSetTableAdapters.tblSuppliersTableAdapter
    Friend WithEvents SupplierNameTextBox1 As TextBox
End Class
