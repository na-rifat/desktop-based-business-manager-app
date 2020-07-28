Public Class addBank
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim BankNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BankNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblBanksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TblBanksTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblBanksTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        BankNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        WebsiteLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblBanksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BankNameLabel
        '
        BankNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        BankNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        BankNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        BankNameLabel.Location = New System.Drawing.Point(3, 12)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(114, 25)
        BankNameLabel.TabIndex = 19
        BankNameLabel.Text = "ব্যাংকের নামঃ"
        BankNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddressLabel
        '
        AddressLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        AddressLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AddressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AddressLabel.Location = New System.Drawing.Point(3, 38)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(114, 25)
        AddressLabel.TabIndex = 21
        AddressLabel.Text = "ঠিকানাঃ"
        AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WebsiteLabel
        '
        WebsiteLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        WebsiteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        WebsiteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        WebsiteLabel.Location = New System.Drawing.Point(3, 64)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(114, 25)
        WebsiteLabel.TabIndex = 23
        WebsiteLabel.Text = "ওয়েবসাইটঃ"
        WebsiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneLabel
        '
        PhoneLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        PhoneLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PhoneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PhoneLabel.Location = New System.Drawing.Point(3, 90)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(114, 25)
        PhoneLabel.TabIndex = 25
        PhoneLabel.Text = "মোবাইলঃ"
        PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ব্যাংক যুক্ত করুন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(BankNameLabel)
        Me.Panel1.Controls.Add(Me.BankNameTextBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(WebsiteLabel)
        Me.Panel1.Controls.Add(Me.WebsiteTextBox)
        Me.Panel1.Controls.Add(PhoneLabel)
        Me.Panel1.Controls.Add(Me.PhoneTextBox)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(126, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 170)
        Me.Panel1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(319, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 27
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BankNameTextBox
        '
        Me.BankNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBanksBindingSource, "bankName", True))
        Me.BankNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.BankNameTextBox.Location = New System.Drawing.Point(123, 16)
        Me.BankNameTextBox.Name = "BankNameTextBox"
        Me.BankNameTextBox.Size = New System.Drawing.Size(433, 24)
        Me.BankNameTextBox.TabIndex = 20
        '
        'TblBanksBindingSource
        '
        Me.TblBanksBindingSource.DataMember = "tblBanks"
        Me.TblBanksBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBanksBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(123, 41)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(433, 24)
        Me.AddressTextBox.TabIndex = 22
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBanksBindingSource, "website", True))
        Me.WebsiteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.WebsiteTextBox.Location = New System.Drawing.Point(123, 66)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(233, 24)
        Me.WebsiteTextBox.TabIndex = 24
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBanksBindingSource, "phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PhoneTextBox.Location = New System.Drawing.Point(123, 91)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(233, 24)
        Me.PhoneTextBox.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(123, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TblBanksTableAdapter
        '
        Me.TblBanksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sales_targetTableAdapter = Nothing
        Me.TableAdapterManager.tblassetTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceReportTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceTableAdapter = Nothing
        Me.TableAdapterManager.tblBankAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblBanksTableAdapter = Me.TblBanksTableAdapter
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
        'addBank
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addBank"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblBanksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub TblBanksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblBanksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub TblBanksBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblBanksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub addBank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center(Me, Panel1)
        ld(0)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BankNameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub PhoneTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebsiteTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Me.Validate()
            Me.TblBanksBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSet)
            MessageBox.Show("New bank added succesfully!")

        Catch ex As Exception

        End Try
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        up(0, 1)
        index(19)
        fll(19)
        ld(19)
        status("Bank updated.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        index(0)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        printP0(Panel1, "Add bank")
    End Sub

    Private Sub PhoneTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles PhoneTextBox.TextChanged

    End Sub

    Private Sub PhoneTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PhoneTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            up(0, 1)
            index(19)
            fll(19)
            ld(19)
            status("Bank updated.")
        End If
    End Sub
End Class