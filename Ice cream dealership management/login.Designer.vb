<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim RoleLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUserRole = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.RoleTextBox = New System.Windows.Forms.TextBox()
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblUserTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblUserTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Process1 = New System.Diagnostics.Process()
        Me.TableAdapterManager1 = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        UserNameLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        RoleLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(77, -3)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(74, 13)
        UserNameLabel.TabIndex = 3
        UserNameLabel.Text = "user Name:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(96, -3)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(55, 13)
        UserIDLabel.TabIndex = 4
        UserIDLabel.Text = "user ID:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(85, -3)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(66, 13)
        PasswordLabel.TabIndex = 6
        PasswordLabel.Text = "password:"
        '
        'RoleLabel
        '
        RoleLabel.AutoSize = True
        RoleLabel.Location = New System.Drawing.Point(83, -3)
        RoleLabel.Name = "RoleLabel"
        RoleLabel.Size = New System.Drawing.Size(34, 13)
        RoleLabel.TabIndex = 8
        RoleLabel.Text = "role:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(180, 414)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(155, 44)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(16, 414)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(155, 44)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtUserRole)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.chkShow)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtUserPass)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtUserID)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(324, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 477)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(105, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'txtUserRole
        '
        Me.txtUserRole.BackColor = System.Drawing.Color.White
        Me.txtUserRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtUserRole.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.txtUserRole.ForeColor = System.Drawing.Color.Black
        Me.txtUserRole.FormattingEnabled = True
        Me.txtUserRole.Location = New System.Drawing.Point(16, 334)
        Me.txtUserRole.Name = "txtUserRole"
        Me.txtUserRole.Size = New System.Drawing.Size(319, 33)
        Me.txtUserRole.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.Label3.Size = New System.Drawing.Size(155, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Role"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkShow
        '
        Me.chkShow.BackColor = System.Drawing.Color.Gray
        Me.chkShow.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.chkShow.FlatAppearance.BorderSize = 0
        Me.chkShow.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.chkShow.ForeColor = System.Drawing.Color.Black
        Me.chkShow.Location = New System.Drawing.Point(16, 372)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Padding = New System.Windows.Forms.Padding(25, 5, 5, 5)
        Me.chkShow.Size = New System.Drawing.Size(319, 37)
        Me.chkShow.TabIndex = 6
        Me.chkShow.Text = "Show password"
        Me.chkShow.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.Label2.Size = New System.Drawing.Size(155, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUserPass
        '
        Me.txtUserPass.BackColor = System.Drawing.Color.White
        Me.txtUserPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserPass.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.txtUserPass.ForeColor = System.Drawing.Color.Black
        Me.txtUserPass.Location = New System.Drawing.Point(16, 259)
        Me.txtUserPass.Name = "txtUserPass"
        Me.txtUserPass.Size = New System.Drawing.Size(319, 33)
        Me.txtUserPass.TabIndex = 4
        Me.txtUserPass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 4, 4, 4)
        Me.Label1.Size = New System.Drawing.Size(155, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.White
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserID.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.txtUserID.ForeColor = System.Drawing.Color.Black
        Me.txtUserID.Location = New System.Drawing.Point(16, 184)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(319, 33)
        Me.txtUserID.TabIndex = 2
        '
        'RoleTextBox
        '
        Me.RoleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "role", True))
        Me.RoleTextBox.Location = New System.Drawing.Point(196, 0)
        Me.RoleTextBox.Name = "RoleTextBox"
        Me.RoleTextBox.Size = New System.Drawing.Size(10, 21)
        Me.RoleTextBox.TabIndex = 9
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
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(129, 0)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(22, 21)
        Me.PasswordTextBox.TabIndex = 7
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "userID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(129, 0)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(22, 21)
        Me.UserIDTextBox.TabIndex = 5
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "userName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(129, 0)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(22, 21)
        Me.UserNameTextBox.TabIndex = 4
        '
        'TblUserTableAdapter
        '
        Me.TblUserTableAdapter.ClearBeforeFill = True
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
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1000, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Login"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 32)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 618)
        Me.Splitter1.TabIndex = 9
        Me.Splitter1.TabStop = False
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tblassetTableAdapter = Nothing
        Me.TableAdapterManager1.tblAttendenceReportTableAdapter = Nothing
        Me.TableAdapterManager1.tblAttendenceTableAdapter = Nothing
        Me.TableAdapterManager1.tblBankAccountsTableAdapter = Nothing
        Me.TableAdapterManager1.tblBanksTableAdapter = Nothing
        Me.TableAdapterManager1.tblCashReportTableAdapter = Nothing
        Me.TableAdapterManager1.tblCompanySettingsTableAdapter = Nothing
        Me.TableAdapterManager1.tblCusomterAccountsTableAdapter = Nothing
        Me.TableAdapterManager1.tblCustomersTableAdapter = Nothing
        Me.TableAdapterManager1.tblDamageFridgeTableAdapter = Nothing
        Me.TableAdapterManager1.tblDamageProductsTableAdapter = Nothing
        Me.TableAdapterManager1.tblDeliveryTableAdapter = Nothing
        Me.TableAdapterManager1.tbldiscountTableAdapter = Nothing
        Me.TableAdapterManager1.tblDocumentsCategoryTableAdapter = Nothing
        Me.TableAdapterManager1.tblDocumentsTableAdapter = Nothing
        Me.TableAdapterManager1.tblDuesReportTableAdapter = Nothing
        Me.TableAdapterManager1.tblEmployeeAccountsTableAdapter = Nothing
        Me.TableAdapterManager1.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager1.tblExpenseCategoryTableAdapter = Nothing
        Me.TableAdapterManager1.tblExpenseReportTableAdapter = Nothing
        Me.TableAdapterManager1.tblExpensesTableAdapter = Nothing
        Me.TableAdapterManager1.tblExpenseSubcategoryTableAdapter = Nothing
        Me.TableAdapterManager1.tblFridgesTableAdapter = Nothing
        Me.TableAdapterManager1.tblIncomeCategoryTableAdapter = Nothing
        Me.TableAdapterManager1.tblIncomeSubcategoryTableAdapter = Nothing
        Me.TableAdapterManager1.tblIncomeTableAdapter = Nothing
        Me.TableAdapterManager1.tblInvoiceTableAdapter = Nothing
        Me.TableAdapterManager1.tblNotesTableAdapter = Nothing
        Me.TableAdapterManager1.tblNoticeTableAdapter = Nothing
        Me.TableAdapterManager1.tblPCommissionTableAdapter = Nothing
        Me.TableAdapterManager1.tblProductCategoryTableAdapter = Nothing
        Me.TableAdapterManager1.tblProductsTableAdapter = Nothing
        Me.TableAdapterManager1.tblProfitTableAdapter = Nothing
        Me.TableAdapterManager1.tblPurchaseInvoiceTableAdapter = Nothing
        Me.TableAdapterManager1.tblPurchaseReportTableAdapter = Nothing
        Me.TableAdapterManager1.tblPurchaseTableAdapter = Nothing
        Me.TableAdapterManager1.tblRentCSTableAdapter = Nothing
        Me.TableAdapterManager1.tblRentCTableAdapter = Nothing
        Me.TableAdapterManager1.tblRentSTableAdapter = Nothing
        Me.TableAdapterManager1.tblSalesreportTableAdapter = Nothing
        Me.TableAdapterManager1.tblSalesTableAdapter = Nothing
        Me.TableAdapterManager1.tblSCommissionTableAdapter = Nothing
        Me.TableAdapterManager1.tblsellcommissionTableAdapter = Nothing
        Me.TableAdapterManager1.tblSignboardTableAdapter = Nothing
        Me.TableAdapterManager1.tblSupplierAccountsTableAdapter = Nothing
        Me.TableAdapterManager1.tblSuppliersTableAdapter = Nothing
        Me.TableAdapterManager1.tblTransactionReportTableAdapter = Nothing
        Me.TableAdapterManager1.tblTransactionTableAdapter = Nothing
        Me.TableAdapterManager1.tblUserTableAdapter = Me.TblUserTableAdapter
        Me.TableAdapterManager1.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager1.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager1.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.RoleTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(RoleLabel)
        Me.Controls.Add(UserIDLabel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUserRole As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblUserBindingSource As BindingSource
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents RoleTextBox As TextBox
    Friend WithEvents TblUserTableAdapter As dataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label4 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Process1 As Process
    Friend WithEvents TableAdapterManager1 As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As PictureBox
End Class
