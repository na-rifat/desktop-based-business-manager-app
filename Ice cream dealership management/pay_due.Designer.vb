<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pay_due
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
        Dim TransactionIDLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim TransactionTypeLabel As System.Windows.Forms.Label
        Dim AccNoLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim PersonOrsourceLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim OpeningBalanceLabel As System.Windows.Forms.Label
        Dim AccountNumberLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pay_button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pay_text = New System.Windows.Forms.TextBox()
        Me.chkbank = New System.Windows.Forms.CheckBox()
        Me.txtaccountNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTransactionTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblTransactionTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblBankAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblBankAccountsTableAdapter()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionIDTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionTypeTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.PersonOrsourceTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.TblBankAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpeningBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.AccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.BankTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        TransactionIDLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        TransactionTypeLabel = New System.Windows.Forms.Label()
        AccNoLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        PersonOrsourceLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        OpeningBalanceLabel = New System.Windows.Forms.Label()
        AccountNumberLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(37, 325)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 8
        IdLabel.Text = "Id:"
        '
        'TransactionIDLabel
        '
        TransactionIDLabel.AutoSize = True
        TransactionIDLabel.Location = New System.Drawing.Point(37, 351)
        TransactionIDLabel.Name = "TransactionIDLabel"
        TransactionIDLabel.Size = New System.Drawing.Size(76, 13)
        TransactionIDLabel.TabIndex = 10
        TransactionIDLabel.Text = "transaction ID:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(37, 377)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(45, 13)
        AmountLabel.TabIndex = 12
        AmountLabel.Text = "amount:"
        '
        'TransactionTypeLabel
        '
        TransactionTypeLabel.AutoSize = True
        TransactionTypeLabel.Location = New System.Drawing.Point(37, 403)
        TransactionTypeLabel.Name = "TransactionTypeLabel"
        TransactionTypeLabel.Size = New System.Drawing.Size(89, 13)
        TransactionTypeLabel.TabIndex = 14
        TransactionTypeLabel.Text = "transaction Type:"
        '
        'AccNoLabel
        '
        AccNoLabel.AutoSize = True
        AccNoLabel.Location = New System.Drawing.Point(37, 429)
        AccNoLabel.Name = "AccNoLabel"
        AccNoLabel.Size = New System.Drawing.Size(45, 13)
        AccNoLabel.TabIndex = 16
        AccNoLabel.Text = "acc No:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(37, 455)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(31, 13)
        DateLabel.TabIndex = 18
        DateLabel.Text = "date:"
        '
        'PersonOrsourceLabel
        '
        PersonOrsourceLabel.AutoSize = True
        PersonOrsourceLabel.Location = New System.Drawing.Point(37, 481)
        PersonOrsourceLabel.Name = "PersonOrsourceLabel"
        PersonOrsourceLabel.Size = New System.Drawing.Size(88, 13)
        PersonOrsourceLabel.TabIndex = 20
        PersonOrsourceLabel.Text = "person Orsource:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(37, 507)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(31, 13)
        NoteLabel.TabIndex = 22
        NoteLabel.Text = "note:"
        '
        'OpeningBalanceLabel
        '
        OpeningBalanceLabel.AutoSize = True
        OpeningBalanceLabel.Location = New System.Drawing.Point(360, 392)
        OpeningBalanceLabel.Name = "OpeningBalanceLabel"
        OpeningBalanceLabel.Size = New System.Drawing.Size(90, 13)
        OpeningBalanceLabel.TabIndex = 23
        OpeningBalanceLabel.Text = "opening Balance:"
        '
        'AccountNumberLabel
        '
        AccountNumberLabel.AutoSize = True
        AccountNumberLabel.Location = New System.Drawing.Point(361, 418)
        AccountNumberLabel.Name = "AccountNumberLabel"
        AccountNumberLabel.Size = New System.Drawing.Size(89, 13)
        AccountNumberLabel.TabIndex = 25
        AccountNumberLabel.Text = "account Number:"
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.Black
        Label4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label4.Location = New System.Drawing.Point(39, 125)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(149, 25)
        Label4.TabIndex = 84
        Label4.Text = "ব্যাংকঃ"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.pay_button)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 45)
        Me.Panel1.TabIndex = 0
        '
        'pay_button
        '
        Me.pay_button.BackColor = System.Drawing.Color.White
        Me.pay_button.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.pay_button.Location = New System.Drawing.Point(256, 6)
        Me.pay_button.Name = "pay_button"
        Me.pay_button.Size = New System.Drawing.Size(162, 32)
        Me.pay_button.TabIndex = 1
        Me.pay_button.Text = "Pay"
        Me.pay_button.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(88, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.lbltitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(507, 32)
        Me.Panel2.TabIndex = 1
        '
        'lbltitle
        '
        Me.lbltitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbltitle.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.lbltitle.Location = New System.Drawing.Point(0, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(507, 32)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "বাকি আদায়/পরিশোধ"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "অর্থের পরিমাণঃ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pay_text
        '
        Me.pay_text.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.pay_text.Location = New System.Drawing.Point(204, 47)
        Me.pay_text.Name = "pay_text"
        Me.pay_text.Size = New System.Drawing.Size(274, 24)
        Me.pay_text.TabIndex = 3
        '
        'chkbank
        '
        Me.chkbank.BackColor = System.Drawing.Color.White
        Me.chkbank.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chkbank.Location = New System.Drawing.Point(204, 72)
        Me.chkbank.Name = "chkbank"
        Me.chkbank.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.chkbank.Size = New System.Drawing.Size(273, 24)
        Me.chkbank.TabIndex = 4
        Me.chkbank.Text = "ব্যাংকের মাধ্যমে আদায়/পরিশোধ"
        Me.chkbank.UseVisualStyleBackColor = False
        '
        'txtaccountNumber
        '
        Me.txtaccountNumber.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtaccountNumber.Location = New System.Drawing.Point(204, 97)
        Me.txtaccountNumber.Name = "txtaccountNumber"
        Me.txtaccountNumber.Size = New System.Drawing.Size(274, 24)
        Me.txtaccountNumber.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ব্যাংক একাউন্ট নাম্বারঃ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblTransactionBindingSource
        '
        Me.TblTransactionBindingSource.DataMember = "tblTransaction"
        Me.TblTransactionBindingSource.DataSource = Me.DataSet
        '
        'TblTransactionTableAdapter
        '
        Me.TblTransactionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sales_targetTableAdapter = Nothing
        Me.TableAdapterManager.tblassetTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceReportTableAdapter = Nothing
        Me.TableAdapterManager.tblAttendenceTableAdapter = Nothing
        Me.TableAdapterManager.tblBankAccountsTableAdapter = Me.TblBankAccountsTableAdapter
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
        Me.TableAdapterManager.tblTransactionTableAdapter = Me.TblTransactionTableAdapter
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblBankAccountsTableAdapter
        '
        Me.TblBankAccountsTableAdapter.ClearBeforeFill = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(132, 322)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 9
        '
        'TransactionIDTextBox
        '
        Me.TransactionIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "transactionID", True))
        Me.TransactionIDTextBox.Location = New System.Drawing.Point(132, 348)
        Me.TransactionIDTextBox.Name = "TransactionIDTextBox"
        Me.TransactionIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TransactionIDTextBox.TabIndex = 11
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(132, 374)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 13
        '
        'TransactionTypeTextBox
        '
        Me.TransactionTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "transactionType", True))
        Me.TransactionTypeTextBox.Location = New System.Drawing.Point(132, 400)
        Me.TransactionTypeTextBox.Name = "TransactionTypeTextBox"
        Me.TransactionTypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TransactionTypeTextBox.TabIndex = 15
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "accNo", True))
        Me.AccNoTextBox.Location = New System.Drawing.Point(132, 426)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccNoTextBox.TabIndex = 17
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(132, 452)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DateTextBox.TabIndex = 19
        '
        'PersonOrsourceTextBox
        '
        Me.PersonOrsourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "personOrsource", True))
        Me.PersonOrsourceTextBox.Location = New System.Drawing.Point(132, 478)
        Me.PersonOrsourceTextBox.Name = "PersonOrsourceTextBox"
        Me.PersonOrsourceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PersonOrsourceTextBox.TabIndex = 21
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(132, 504)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NoteTextBox.TabIndex = 23
        '
        'TblBankAccountsBindingSource
        '
        Me.TblBankAccountsBindingSource.DataMember = "tblBankAccounts"
        Me.TblBankAccountsBindingSource.DataSource = Me.DataSet
        '
        'OpeningBalanceTextBox
        '
        Me.OpeningBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "openingBalance", True))
        Me.OpeningBalanceTextBox.Location = New System.Drawing.Point(456, 389)
        Me.OpeningBalanceTextBox.Name = "OpeningBalanceTextBox"
        Me.OpeningBalanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OpeningBalanceTextBox.TabIndex = 24
        '
        'AccountNumberTextBox
        '
        Me.AccountNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "accountNumber", True))
        Me.AccountNumberTextBox.Location = New System.Drawing.Point(456, 415)
        Me.AccountNumberTextBox.Name = "AccountNumberTextBox"
        Me.AccountNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccountNumberTextBox.TabIndex = 26
        '
        'BankTextBox
        '
        Me.BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "bank", True))
        Me.BankTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.BankTextBox.Location = New System.Drawing.Point(204, 122)
        Me.BankTextBox.Name = "BankTextBox"
        Me.BankTextBox.ReadOnly = True
        Me.BankTextBox.Size = New System.Drawing.Size(274, 24)
        Me.BankTextBox.TabIndex = 83
        '
        'pay_due
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(507, 201)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.BankTextBox)
        Me.Controls.Add(AccountNumberLabel)
        Me.Controls.Add(Me.AccountNumberTextBox)
        Me.Controls.Add(OpeningBalanceLabel)
        Me.Controls.Add(Me.OpeningBalanceTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(TransactionIDLabel)
        Me.Controls.Add(Me.TransactionIDTextBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(TransactionTypeLabel)
        Me.Controls.Add(Me.TransactionTypeTextBox)
        Me.Controls.Add(AccNoLabel)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(PersonOrsourceLabel)
        Me.Controls.Add(Me.PersonOrsourceTextBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.txtaccountNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkbank)
        Me.Controls.Add(Me.pay_text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pay_due"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pay_due"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pay_button As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pay_text As TextBox
    Friend WithEvents chkbank As CheckBox
    Friend WithEvents txtaccountNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblTransactionBindingSource As BindingSource
    Friend WithEvents TblTransactionTableAdapter As dataSetTableAdapters.tblTransactionTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblBankAccountsTableAdapter As dataSetTableAdapters.tblBankAccountsTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents TransactionIDTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents TransactionTypeTextBox As TextBox
    Friend WithEvents AccNoTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents PersonOrsourceTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents TblBankAccountsBindingSource As BindingSource
    Friend WithEvents OpeningBalanceTextBox As TextBox
    Friend WithEvents AccountNumberTextBox As TextBox
    Friend WithEvents BankTextBox As TextBox
End Class
