<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class myaccount
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
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim RoleLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.RoleTextBox = New System.Windows.Forms.TextBox()
        Me.TblUserTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblUserTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        UserNameLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        RoleLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.BackColor = System.Drawing.Color.Black
        UserNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        UserNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        UserNameLabel.Location = New System.Drawing.Point(3, 13)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(115, 25)
        UserNameLabel.TabIndex = 2
        UserNameLabel.Text = "নামঃ"
        UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UserIDLabel
        '
        UserIDLabel.BackColor = System.Drawing.Color.Black
        UserIDLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        UserIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        UserIDLabel.Location = New System.Drawing.Point(3, 39)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(115, 25)
        UserIDLabel.TabIndex = 4
        UserIDLabel.Text = "লগ-ইন আই.ডি"
        UserIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PasswordLabel
        '
        PasswordLabel.BackColor = System.Drawing.Color.Black
        PasswordLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PasswordLabel.Location = New System.Drawing.Point(3, 65)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(115, 25)
        PasswordLabel.TabIndex = 6
        PasswordLabel.Text = "পাসওয়ার্ডঃ"
        PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddressLabel
        '
        AddressLabel.BackColor = System.Drawing.Color.Black
        AddressLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AddressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AddressLabel.Location = New System.Drawing.Point(3, 91)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(115, 25)
        AddressLabel.TabIndex = 8
        AddressLabel.Text = "ঠিকানাঃ"
        AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneLabel
        '
        PhoneLabel.BackColor = System.Drawing.Color.Black
        PhoneLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PhoneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PhoneLabel.Location = New System.Drawing.Point(3, 117)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(115, 25)
        PhoneLabel.TabIndex = 10
        PhoneLabel.Text = "মোবাইলঃ"
        PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        AddHandler PhoneLabel.Click, AddressOf Me.PhoneLabel_Click
        '
        'RoleLabel
        '
        RoleLabel.BackColor = System.Drawing.Color.Black
        RoleLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        RoleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        RoleLabel.Location = New System.Drawing.Point(3, 143)
        RoleLabel.Name = "RoleLabel"
        RoleLabel.Size = New System.Drawing.Size(115, 25)
        RoleLabel.TabIndex = 12
        RoleLabel.Text = "পদঃ"
        RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.Text = "আমার একাউন্ট"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(210, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 250)
        Me.Panel1.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(142, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(247, 35)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(UserNameLabel)
        Me.Panel2.Controls.Add(Me.UserNameTextBox)
        Me.Panel2.Controls.Add(UserIDLabel)
        Me.Panel2.Controls.Add(Me.UserIDTextBox)
        Me.Panel2.Controls.Add(PasswordLabel)
        Me.Panel2.Controls.Add(Me.PasswordTextBox)
        Me.Panel2.Controls.Add(AddressLabel)
        Me.Panel2.Controls.Add(Me.AddressTextBox)
        Me.Panel2.Controls.Add(PhoneLabel)
        Me.Panel2.Controls.Add(Me.PhoneTextBox)
        Me.Panel2.Controls.Add(RoleLabel)
        Me.Panel2.Controls.Add(Me.RoleTextBox)
        Me.Panel2.Location = New System.Drawing.Point(18, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(429, 204)
        Me.Panel2.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(124, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 35)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "userName", True))
        Me.UserNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.UserNameTextBox.Location = New System.Drawing.Point(124, 16)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(299, 24)
        Me.UserNameTextBox.TabIndex = 3
        '
        'TblUserBindingSource
        '
        Me.TblUserBindingSource.DataMember = "tblUser"
        Me.TblUserBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "userID", True))
        Me.UserIDTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.UserIDTextBox.Location = New System.Drawing.Point(124, 41)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(299, 24)
        Me.UserIDTextBox.TabIndex = 5
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PasswordTextBox.Location = New System.Drawing.Point(124, 66)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(299, 24)
        Me.PasswordTextBox.TabIndex = 7
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(124, 91)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(299, 24)
        Me.AddressTextBox.TabIndex = 9
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PhoneTextBox.Location = New System.Drawing.Point(124, 116)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(299, 24)
        Me.PhoneTextBox.TabIndex = 11
        '
        'RoleTextBox
        '
        Me.RoleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "role", True))
        Me.RoleTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RoleTextBox.Location = New System.Drawing.Point(124, 141)
        Me.RoleTextBox.Name = "RoleTextBox"
        Me.RoleTextBox.Size = New System.Drawing.Size(299, 24)
        Me.RoleTextBox.TabIndex = 13
        '
        'TblUserTableAdapter
        '
        Me.TblUserTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblUserTableAdapter = Me.TblUserTableAdapter
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'myaccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "myaccount"
        Me.Text = "myaccount"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblUserBindingSource As BindingSource
    Friend WithEvents TblUserTableAdapter As dataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents RoleTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
