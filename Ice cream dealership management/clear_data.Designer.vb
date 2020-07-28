<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clear_data
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
        Me.docking_panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chk_sales_invoice = New System.Windows.Forms.CheckBox()
        Me.chk_purchase_invoice = New System.Windows.Forms.CheckBox()
        Me.chk_expenses = New System.Windows.Forms.CheckBox()
        Me.chk_incomes = New System.Windows.Forms.CheckBox()
        Me.chk_withdraws = New System.Windows.Forms.CheckBox()
        Me.chk_bank_transactions = New System.Windows.Forms.CheckBox()
        Me.chk_fridges = New System.Windows.Forms.CheckBox()
        Me.chk_assets = New System.Windows.Forms.CheckBox()
        Me.chk_reports = New System.Windows.Forms.CheckBox()
        Me.chk_customer_accounts = New System.Windows.Forms.CheckBox()
        Me.chk_company_accounts = New System.Windows.Forms.CheckBox()
        Me.chk_employee_accounts = New System.Windows.Forms.CheckBox()
        Me.prg = New CircularProgressBar.CircularProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_employee_attendance = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'docking_panel
        '
        Me.docking_panel.Location = New System.Drawing.Point(24, 12)
        Me.docking_panel.Name = "docking_panel"
        Me.docking_panel.Size = New System.Drawing.Size(43, 16)
        Me.docking_panel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Clear data tables"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.prg)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(128, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 512)
        Me.Panel1.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Green
        Me.Button3.Location = New System.Drawing.Point(312, 445)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(386, 36)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Input average 100 available products "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Green
        Me.Button2.Location = New System.Drawing.Point(312, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(386, 36)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Empty product stock"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_sales_invoice)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_purchase_invoice)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_expenses)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_incomes)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_withdraws)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_bank_transactions)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_fridges)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_assets)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_reports)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_customer_accounts)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_company_accounts)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_employee_accounts)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_employee_attendance)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(282, 512)
        Me.FlowLayoutPanel1.TabIndex = 21
        '
        'chk_sales_invoice
        '
        Me.chk_sales_invoice.AutoSize = True
        Me.chk_sales_invoice.Location = New System.Drawing.Point(23, 13)
        Me.chk_sales_invoice.Name = "chk_sales_invoice"
        Me.chk_sales_invoice.Size = New System.Drawing.Size(117, 21)
        Me.chk_sales_invoice.TabIndex = 22
        Me.chk_sales_invoice.Text = "Sales invoices"
        Me.chk_sales_invoice.UseVisualStyleBackColor = True
        '
        'chk_purchase_invoice
        '
        Me.chk_purchase_invoice.AutoSize = True
        Me.chk_purchase_invoice.Location = New System.Drawing.Point(23, 40)
        Me.chk_purchase_invoice.Name = "chk_purchase_invoice"
        Me.chk_purchase_invoice.Size = New System.Drawing.Size(142, 21)
        Me.chk_purchase_invoice.TabIndex = 23
        Me.chk_purchase_invoice.Text = "Purchase invoices"
        Me.chk_purchase_invoice.UseVisualStyleBackColor = True
        '
        'chk_expenses
        '
        Me.chk_expenses.AutoSize = True
        Me.chk_expenses.Location = New System.Drawing.Point(23, 67)
        Me.chk_expenses.Name = "chk_expenses"
        Me.chk_expenses.Size = New System.Drawing.Size(88, 21)
        Me.chk_expenses.TabIndex = 24
        Me.chk_expenses.Text = "Expenses"
        Me.chk_expenses.UseVisualStyleBackColor = True
        '
        'chk_incomes
        '
        Me.chk_incomes.AutoSize = True
        Me.chk_incomes.Location = New System.Drawing.Point(23, 94)
        Me.chk_incomes.Name = "chk_incomes"
        Me.chk_incomes.Size = New System.Drawing.Size(79, 21)
        Me.chk_incomes.TabIndex = 25
        Me.chk_incomes.Text = "Incomes"
        Me.chk_incomes.UseVisualStyleBackColor = True
        '
        'chk_withdraws
        '
        Me.chk_withdraws.AutoSize = True
        Me.chk_withdraws.Location = New System.Drawing.Point(23, 121)
        Me.chk_withdraws.Name = "chk_withdraws"
        Me.chk_withdraws.Size = New System.Drawing.Size(92, 21)
        Me.chk_withdraws.TabIndex = 26
        Me.chk_withdraws.Text = "Withdraws"
        Me.chk_withdraws.UseVisualStyleBackColor = True
        '
        'chk_bank_transactions
        '
        Me.chk_bank_transactions.AutoSize = True
        Me.chk_bank_transactions.Location = New System.Drawing.Point(23, 148)
        Me.chk_bank_transactions.Name = "chk_bank_transactions"
        Me.chk_bank_transactions.Size = New System.Drawing.Size(140, 21)
        Me.chk_bank_transactions.TabIndex = 27
        Me.chk_bank_transactions.Text = "Bank transactions"
        Me.chk_bank_transactions.UseVisualStyleBackColor = True
        '
        'chk_fridges
        '
        Me.chk_fridges.AutoSize = True
        Me.chk_fridges.Location = New System.Drawing.Point(23, 175)
        Me.chk_fridges.Name = "chk_fridges"
        Me.chk_fridges.Size = New System.Drawing.Size(74, 21)
        Me.chk_fridges.TabIndex = 28
        Me.chk_fridges.Text = "Fridges"
        Me.chk_fridges.UseVisualStyleBackColor = True
        '
        'chk_assets
        '
        Me.chk_assets.AutoSize = True
        Me.chk_assets.Location = New System.Drawing.Point(23, 202)
        Me.chk_assets.Name = "chk_assets"
        Me.chk_assets.Size = New System.Drawing.Size(69, 21)
        Me.chk_assets.TabIndex = 29
        Me.chk_assets.Text = "Assets"
        Me.chk_assets.UseVisualStyleBackColor = True
        '
        'chk_reports
        '
        Me.chk_reports.AutoSize = True
        Me.chk_reports.Location = New System.Drawing.Point(23, 229)
        Me.chk_reports.Name = "chk_reports"
        Me.chk_reports.Size = New System.Drawing.Size(77, 21)
        Me.chk_reports.TabIndex = 30
        Me.chk_reports.Text = "Reports"
        Me.chk_reports.UseVisualStyleBackColor = True
        '
        'chk_customer_accounts
        '
        Me.chk_customer_accounts.AutoSize = True
        Me.chk_customer_accounts.Location = New System.Drawing.Point(23, 256)
        Me.chk_customer_accounts.Name = "chk_customer_accounts"
        Me.chk_customer_accounts.Size = New System.Drawing.Size(148, 21)
        Me.chk_customer_accounts.TabIndex = 31
        Me.chk_customer_accounts.Text = "Customer accounts"
        Me.chk_customer_accounts.UseVisualStyleBackColor = True
        '
        'chk_company_accounts
        '
        Me.chk_company_accounts.AutoSize = True
        Me.chk_company_accounts.Location = New System.Drawing.Point(23, 283)
        Me.chk_company_accounts.Name = "chk_company_accounts"
        Me.chk_company_accounts.Size = New System.Drawing.Size(147, 21)
        Me.chk_company_accounts.TabIndex = 32
        Me.chk_company_accounts.Text = "Company accounts"
        Me.chk_company_accounts.UseVisualStyleBackColor = True
        '
        'chk_employee_accounts
        '
        Me.chk_employee_accounts.AutoSize = True
        Me.chk_employee_accounts.Location = New System.Drawing.Point(23, 310)
        Me.chk_employee_accounts.Name = "chk_employee_accounts"
        Me.chk_employee_accounts.Size = New System.Drawing.Size(150, 21)
        Me.chk_employee_accounts.TabIndex = 33
        Me.chk_employee_accounts.Text = "Employee accounts"
        Me.chk_employee_accounts.UseVisualStyleBackColor = True
        '
        'prg
        '
        Me.prg.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.prg.AnimationSpeed = 500
        Me.prg.BackColor = System.Drawing.Color.Transparent
        Me.prg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.prg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.prg.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.prg.InnerMargin = 2
        Me.prg.InnerWidth = -1
        Me.prg.Location = New System.Drawing.Point(378, 127)
        Me.prg.MarqueeAnimationSpeed = 2000
        Me.prg.Name = "prg"
        Me.prg.OuterColor = System.Drawing.Color.White
        Me.prg.OuterMargin = -50
        Me.prg.OuterWidth = 50
        Me.prg.ProgressColor = System.Drawing.Color.Red
        Me.prg.ProgressWidth = 50
        Me.prg.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.prg.Size = New System.Drawing.Size(255, 249)
        Me.prg.StartAngle = 270
        Me.prg.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.prg.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.prg.SubscriptText = ""
        Me.prg.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.prg.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.prg.SuperscriptText = ""
        Me.prg.TabIndex = 20
        Me.prg.Text = "Clearing"
        Me.prg.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.prg.Value = 68
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(312, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(386, 117)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Clear data tables"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.DataSet
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblProductsTableAdapter = Me.TblProductsTableAdapter
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
        'TblProductsDataGridView
        '
        Me.TblProductsDataGridView.AutoGenerateColumns = False
        Me.TblProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.TblProductsDataGridView.DataSource = Me.TblProductsBindingSource
        Me.TblProductsDataGridView.Location = New System.Drawing.Point(24, 6)
        Me.TblProductsDataGridView.Name = "TblProductsDataGridView"
        Me.TblProductsDataGridView.Size = New System.Drawing.Size(130, 22)
        Me.TblProductsDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "available"
        Me.DataGridViewTextBoxColumn10.HeaderText = "available"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "remark"
        Me.DataGridViewTextBoxColumn11.HeaderText = "remark"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "company_id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "company_id"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'chk_employee_attendance
        '
        Me.chk_employee_attendance.AutoSize = True
        Me.chk_employee_attendance.Location = New System.Drawing.Point(23, 337)
        Me.chk_employee_attendance.Name = "chk_employee_attendance"
        Me.chk_employee_attendance.Size = New System.Drawing.Size(150, 21)
        Me.chk_employee_attendance.TabIndex = 34
        Me.chk_employee_attendance.Text = "Employee accounts"
        Me.chk_employee_attendance.UseVisualStyleBackColor = True
        '
        'clear_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 614)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.docking_panel)
        Me.Controls.Add(Me.TblProductsDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "clear_data"
        Me.Text = "clear_data"
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents docking_panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents prg As CircularProgressBar.CircularProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents chk_sales_invoice As CheckBox
    Friend WithEvents chk_purchase_invoice As CheckBox
    Friend WithEvents chk_expenses As CheckBox
    Friend WithEvents chk_incomes As CheckBox
    Friend WithEvents chk_withdraws As CheckBox
    Friend WithEvents chk_bank_transactions As CheckBox
    Friend WithEvents chk_fridges As CheckBox
    Friend WithEvents chk_assets As CheckBox
    Friend WithEvents chk_reports As CheckBox
    Friend WithEvents chk_customer_accounts As CheckBox
    Friend WithEvents chk_company_accounts As CheckBox
    Friend WithEvents chk_employee_accounts As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As dataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblProductsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents chk_employee_attendance As CheckBox
End Class
