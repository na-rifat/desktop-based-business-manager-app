<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newVehicle
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
        Dim VehicleModelLabel As System.Windows.Forms.Label
        Dim VehicleNumberLabel As System.Windows.Forms.Label
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim BcLabel As System.Windows.Forms.Label
        Dim VehicleConditionLabel As System.Windows.Forms.Label
        Dim VehicleIDLabel As System.Windows.Forms.Label
        Dim DriverNameLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rdO = New System.Windows.Forms.RadioButton()
        Me.rdN = New System.Windows.Forms.RadioButton()
        Me.chkbc = New System.Windows.Forms.CheckBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.TblVehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.VehicleModelTextBox = New System.Windows.Forms.TextBox()
        Me.VehicleNumberTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.VehicleIDTextBox = New System.Windows.Forms.TextBox()
        Me.DriverNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BcTextBox = New System.Windows.Forms.TextBox()
        Me.VehicleConditionTextBox = New System.Windows.Forms.TextBox()
        Me.IssueDateTextBox = New System.Windows.Forms.TextBox()
        Me.TblVehicleTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblVehicleTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        VehicleModelLabel = New System.Windows.Forms.Label()
        VehicleNumberLabel = New System.Windows.Forms.Label()
        IssueDateLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        BcLabel = New System.Windows.Forms.Label()
        VehicleConditionLabel = New System.Windows.Forms.Label()
        VehicleIDLabel = New System.Windows.Forms.Label()
        DriverNameLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblVehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VehicleModelLabel
        '
        VehicleModelLabel.BackColor = System.Drawing.Color.Black
        VehicleModelLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        VehicleModelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        VehicleModelLabel.Location = New System.Drawing.Point(43, 6)
        VehicleModelLabel.Name = "VehicleModelLabel"
        VehicleModelLabel.Size = New System.Drawing.Size(133, 25)
        VehicleModelLabel.TabIndex = 2
        VehicleModelLabel.Text = "গাড়ীর মডেলঃ"
        VehicleModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VehicleNumberLabel
        '
        VehicleNumberLabel.BackColor = System.Drawing.Color.Black
        VehicleNumberLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        VehicleNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        VehicleNumberLabel.Location = New System.Drawing.Point(43, 32)
        VehicleNumberLabel.Name = "VehicleNumberLabel"
        VehicleNumberLabel.Size = New System.Drawing.Size(133, 25)
        VehicleNumberLabel.TabIndex = 4
        VehicleNumberLabel.Text = "লাইসেন্স নাম্বারঃ"
        VehicleNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IssueDateLabel
        '
        IssueDateLabel.BackColor = System.Drawing.Color.Black
        IssueDateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        IssueDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        IssueDateLabel.Location = New System.Drawing.Point(43, 58)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(133, 25)
        IssueDateLabel.TabIndex = 6
        IssueDateLabel.Text = "ইস্যু/ক্রয়ের তারিখঃ"
        IssueDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PriceLabel
        '
        PriceLabel.BackColor = System.Drawing.Color.Black
        PriceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PriceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PriceLabel.Location = New System.Drawing.Point(43, 84)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(133, 25)
        PriceLabel.TabIndex = 8
        PriceLabel.Text = "মূল্যঃ"
        PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BcLabel
        '
        BcLabel.AutoSize = True
        BcLabel.BackColor = System.Drawing.Color.Black
        BcLabel.Font = New System.Drawing.Font("Verdana", 8.25!)
        BcLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        BcLabel.Location = New System.Drawing.Point(35, 15)
        BcLabel.Name = "BcLabel"
        BcLabel.Padding = New System.Windows.Forms.Padding(5)
        BcLabel.Size = New System.Drawing.Size(35, 23)
        BcLabel.TabIndex = 10
        BcLabel.Text = "bc:"
        '
        'VehicleConditionLabel
        '
        VehicleConditionLabel.BackColor = System.Drawing.Color.Black
        VehicleConditionLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        VehicleConditionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        VehicleConditionLabel.Location = New System.Drawing.Point(43, 188)
        VehicleConditionLabel.Name = "VehicleConditionLabel"
        VehicleConditionLabel.Size = New System.Drawing.Size(133, 25)
        VehicleConditionLabel.TabIndex = 12
        VehicleConditionLabel.Text = "গাড়ীর কন্ডিশনঃ"
        VehicleConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VehicleIDLabel
        '
        VehicleIDLabel.BackColor = System.Drawing.Color.Black
        VehicleIDLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        VehicleIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        VehicleIDLabel.Location = New System.Drawing.Point(43, 110)
        VehicleIDLabel.Name = "VehicleIDLabel"
        VehicleIDLabel.Size = New System.Drawing.Size(133, 25)
        VehicleIDLabel.TabIndex = 14
        VehicleIDLabel.Text = "গাড়ীর আই.ডি.:"
        VehicleIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DriverNameLabel
        '
        DriverNameLabel.BackColor = System.Drawing.Color.Black
        DriverNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DriverNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DriverNameLabel.Location = New System.Drawing.Point(43, 136)
        DriverNameLabel.Name = "DriverNameLabel"
        DriverNameLabel.Size = New System.Drawing.Size(133, 25)
        DriverNameLabel.TabIndex = 16
        DriverNameLabel.Text = "ডেলিভারী ম্যানঃ"
        DriverNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NoteLabel
        '
        NoteLabel.BackColor = System.Drawing.Color.Black
        NoteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        NoteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        NoteLabel.Location = New System.Drawing.Point(43, 162)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(133, 25)
        NoteLabel.TabIndex = 17
        NoteLabel.Text = "মন্তব্যঃ"
        NoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "নতুন গাড়ী"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.rdO)
        Me.Panel1.Controls.Add(Me.rdN)
        Me.Panel1.Controls.Add(Me.chkbc)
        Me.Panel1.Controls.Add(NoteLabel)
        Me.Panel1.Controls.Add(Me.NoteTextBox)
        Me.Panel1.Controls.Add(VehicleModelLabel)
        Me.Panel1.Controls.Add(Me.VehicleModelTextBox)
        Me.Panel1.Controls.Add(VehicleNumberLabel)
        Me.Panel1.Controls.Add(Me.VehicleNumberTextBox)
        Me.Panel1.Controls.Add(IssueDateLabel)
        Me.Panel1.Controls.Add(PriceLabel)
        Me.Panel1.Controls.Add(Me.PriceTextBox)
        Me.Panel1.Controls.Add(VehicleConditionLabel)
        Me.Panel1.Controls.Add(VehicleIDLabel)
        Me.Panel1.Controls.Add(Me.VehicleIDTextBox)
        Me.Panel1.Controls.Add(DriverNameLabel)
        Me.Panel1.Controls.Add(Me.DriverNameTextBox)
        Me.Panel1.Location = New System.Drawing.Point(201, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 299)
        Me.Panel1.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(182, 59)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(207, 24)
        Me.DateTimePicker1.TabIndex = 68
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(354, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 66
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(182, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 35)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rdO
        '
        Me.rdO.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.rdO.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.rdO.Location = New System.Drawing.Point(286, 184)
        Me.rdO.Name = "rdO"
        Me.rdO.Padding = New System.Windows.Forms.Padding(30, 4, 4, 4)
        Me.rdO.Size = New System.Drawing.Size(103, 29)
        Me.rdO.TabIndex = 21
        Me.rdO.Text = "Old"
        Me.rdO.UseVisualStyleBackColor = False
        '
        'rdN
        '
        Me.rdN.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.rdN.Checked = True
        Me.rdN.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.rdN.Location = New System.Drawing.Point(182, 184)
        Me.rdN.Name = "rdN"
        Me.rdN.Padding = New System.Windows.Forms.Padding(30, 4, 4, 4)
        Me.rdN.Size = New System.Drawing.Size(103, 29)
        Me.rdN.TabIndex = 20
        Me.rdN.TabStop = True
        Me.rdN.Text = "New"
        Me.rdN.UseVisualStyleBackColor = False
        '
        'chkbc
        '
        Me.chkbc.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkbc.Checked = True
        Me.chkbc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbc.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chkbc.Location = New System.Drawing.Point(182, 214)
        Me.chkbc.Name = "chkbc"
        Me.chkbc.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.chkbc.Size = New System.Drawing.Size(207, 29)
        Me.chkbc.TabIndex = 19
        Me.chkbc.Text = "নতুন ক্রয়কৃত"
        Me.chkbc.UseVisualStyleBackColor = False
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "note", True))
        Me.NoteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.NoteTextBox.Location = New System.Drawing.Point(182, 159)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(207, 24)
        Me.NoteTextBox.TabIndex = 18
        '
        'TblVehicleBindingSource
        '
        Me.TblVehicleBindingSource.DataMember = "tblVehicle"
        Me.TblVehicleBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleModelTextBox
        '
        Me.VehicleModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "vehicleModel", True))
        Me.VehicleModelTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.VehicleModelTextBox.Location = New System.Drawing.Point(182, 9)
        Me.VehicleModelTextBox.Name = "VehicleModelTextBox"
        Me.VehicleModelTextBox.Size = New System.Drawing.Size(207, 24)
        Me.VehicleModelTextBox.TabIndex = 3
        '
        'VehicleNumberTextBox
        '
        Me.VehicleNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "vehicleNumber", True))
        Me.VehicleNumberTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.VehicleNumberTextBox.Location = New System.Drawing.Point(182, 34)
        Me.VehicleNumberTextBox.Name = "VehicleNumberTextBox"
        Me.VehicleNumberTextBox.Size = New System.Drawing.Size(207, 24)
        Me.VehicleNumberTextBox.TabIndex = 5
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "price", True))
        Me.PriceTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PriceTextBox.Location = New System.Drawing.Point(182, 84)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(207, 24)
        Me.PriceTextBox.TabIndex = 9
        '
        'VehicleIDTextBox
        '
        Me.VehicleIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "vehicleID", True))
        Me.VehicleIDTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.VehicleIDTextBox.Location = New System.Drawing.Point(182, 109)
        Me.VehicleIDTextBox.Name = "VehicleIDTextBox"
        Me.VehicleIDTextBox.ReadOnly = True
        Me.VehicleIDTextBox.Size = New System.Drawing.Size(207, 24)
        Me.VehicleIDTextBox.TabIndex = 15
        '
        'DriverNameTextBox
        '
        Me.DriverNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "driverName", True))
        Me.DriverNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DriverNameTextBox.Location = New System.Drawing.Point(182, 134)
        Me.DriverNameTextBox.Name = "DriverNameTextBox"
        Me.DriverNameTextBox.Size = New System.Drawing.Size(207, 24)
        Me.DriverNameTextBox.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 26)
        Me.Panel2.TabIndex = 67
        '
        'BcTextBox
        '
        Me.BcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "bc", True))
        Me.BcTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.BcTextBox.Location = New System.Drawing.Point(12, 12)
        Me.BcTextBox.Name = "BcTextBox"
        Me.BcTextBox.Size = New System.Drawing.Size(94, 21)
        Me.BcTextBox.TabIndex = 11
        '
        'VehicleConditionTextBox
        '
        Me.VehicleConditionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "vehicleCondition", True))
        Me.VehicleConditionTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.VehicleConditionTextBox.Location = New System.Drawing.Point(112, 17)
        Me.VehicleConditionTextBox.Name = "VehicleConditionTextBox"
        Me.VehicleConditionTextBox.Size = New System.Drawing.Size(51, 21)
        Me.VehicleConditionTextBox.TabIndex = 13
        '
        'IssueDateTextBox
        '
        Me.IssueDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "issueDate", True))
        Me.IssueDateTextBox.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.IssueDateTextBox.Location = New System.Drawing.Point(111, 12)
        Me.IssueDateTextBox.Name = "IssueDateTextBox"
        Me.IssueDateTextBox.Size = New System.Drawing.Size(51, 21)
        Me.IssueDateTextBox.TabIndex = 7
        '
        'TblVehicleTableAdapter
        '
        Me.TblVehicleTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblVehicleTableAdapter = Me.TblVehicleTableAdapter
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'newVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IssueDateTextBox)
        Me.Controls.Add(BcLabel)
        Me.Controls.Add(Me.BcTextBox)
        Me.Controls.Add(Me.VehicleConditionTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newVehicle"
        Me.Text = "newVehicle"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblVehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblVehicleBindingSource As BindingSource
    Friend WithEvents TblVehicleTableAdapter As dataSetTableAdapters.tblVehicleTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents VehicleModelTextBox As TextBox
    Friend WithEvents VehicleNumberTextBox As TextBox
    Friend WithEvents IssueDateTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents BcTextBox As TextBox
    Friend WithEvents VehicleConditionTextBox As TextBox
    Friend WithEvents VehicleIDTextBox As TextBox
    Friend WithEvents DriverNameTextBox As TextBox
    Friend WithEvents rdO As RadioButton
    Friend WithEvents rdN As RadioButton
    Friend WithEvents chkbc As CheckBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
