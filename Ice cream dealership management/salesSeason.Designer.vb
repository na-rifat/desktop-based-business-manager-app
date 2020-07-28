<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesSeason
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
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim TargetQuantityLabel As System.Windows.Forms.Label
        Dim StartLabel As System.Windows.Forms.Label
        Dim EndLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim SupplierLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CashrewardTextBox = New System.Windows.Forms.TextBox()
        Me.TblSCommissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.dtpend = New System.Windows.Forms.DateTimePicker()
        Me.dtpstart = New System.Windows.Forms.DateTimePicker()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.TargetQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.ProductCodeTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.EndTextBox = New System.Windows.Forms.TextBox()
        Me.StartTextBox = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductsTableAdapter()
        Me.SupplierTextBox = New System.Windows.Forms.TextBox()
        ProductNameLabel = New System.Windows.Forms.Label()
        TargetQuantityLabel = New System.Windows.Forms.Label()
        StartLabel = New System.Windows.Forms.Label()
        EndLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        SupplierLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblSCommissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.BackColor = System.Drawing.Color.Black
        ProductNameLabel.ForeColor = System.Drawing.Color.White
        ProductNameLabel.Location = New System.Drawing.Point(6, 11)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Padding = New System.Windows.Forms.Padding(4)
        ProductNameLabel.Size = New System.Drawing.Size(245, 40)
        ProductNameLabel.TabIndex = 2
        ProductNameLabel.Text = "Product name:"
        '
        'TargetQuantityLabel
        '
        TargetQuantityLabel.AutoSize = True
        TargetQuantityLabel.BackColor = System.Drawing.Color.Black
        TargetQuantityLabel.ForeColor = System.Drawing.Color.White
        TargetQuantityLabel.Location = New System.Drawing.Point(6, 97)
        TargetQuantityLabel.Name = "TargetQuantityLabel"
        TargetQuantityLabel.Padding = New System.Windows.Forms.Padding(4)
        TargetQuantityLabel.Size = New System.Drawing.Size(239, 40)
        TargetQuantityLabel.TabIndex = 6
        TargetQuantityLabel.Text = "Discount (%):"
        '
        'StartLabel
        '
        StartLabel.AutoSize = True
        StartLabel.BackColor = System.Drawing.Color.Black
        StartLabel.ForeColor = System.Drawing.Color.White
        StartLabel.Location = New System.Drawing.Point(6, 140)
        StartLabel.Name = "StartLabel"
        StartLabel.Padding = New System.Windows.Forms.Padding(4)
        StartLabel.Size = New System.Drawing.Size(304, 40)
        StartLabel.TabIndex = 10
        StartLabel.Text = "Season start from:"
        '
        'EndLabel
        '
        EndLabel.AutoSize = True
        EndLabel.BackColor = System.Drawing.Color.Black
        EndLabel.ForeColor = System.Drawing.Color.White
        EndLabel.Location = New System.Drawing.Point(6, 183)
        EndLabel.Name = "EndLabel"
        EndLabel.Padding = New System.Windows.Forms.Padding(4)
        EndLabel.Size = New System.Drawing.Size(263, 40)
        EndLabel.TabIndex = 12
        EndLabel.Text = "Season ends at:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Black
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(6, 54)
        Label2.Name = "Label2"
        Label2.Padding = New System.Windows.Forms.Padding(4)
        Label2.Size = New System.Drawing.Size(176, 40)
        Label2.TabIndex = 83
        Label2.Text = "Company:"
        '
        'SupplierLabel
        '
        SupplierLabel.AutoSize = True
        SupplierLabel.Location = New System.Drawing.Point(23, 15)
        SupplierLabel.Name = "SupplierLabel"
        SupplierLabel.Size = New System.Drawing.Size(57, 13)
        SupplierLabel.TabIndex = 17
        SupplierLabel.Text = "supplier:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 44)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "New sales commission season"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.CashrewardTextBox)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.StatusTextBox)
        Me.Panel1.Controls.Add(Me.dtpend)
        Me.Panel1.Controls.Add(Me.dtpstart)
        Me.Panel1.Controls.Add(ProductNameLabel)
        Me.Panel1.Controls.Add(Me.ProductNameTextBox)
        Me.Panel1.Controls.Add(Me.ProductCodeTextBox)
        Me.Panel1.Controls.Add(TargetQuantityLabel)
        Me.Panel1.Controls.Add(Me.TargetQuantityTextBox)
        Me.Panel1.Controls.Add(StartLabel)
        Me.Panel1.Controls.Add(EndLabel)
        Me.Panel1.Controls.Add(Me.ProductCodeTextBox1)
        Me.Panel1.Controls.Add(Me.ProductNameTextBox1)
        Me.Panel1.Controls.Add(Me.QuantityTextBox)
        Me.Panel1.Controls.Add(Me.EndTextBox)
        Me.Panel1.Controls.Add(Me.StartTextBox)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(166, 186)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 278)
        Me.Panel1.TabIndex = 17
        '
        'CashrewardTextBox
        '
        Me.CashrewardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSCommissionBindingSource, "cashreward", True))
        Me.CashrewardTextBox.Location = New System.Drawing.Point(320, 51)
        Me.CashrewardTextBox.Name = "CashrewardTextBox"
        Me.CashrewardTextBox.ReadOnly = True
        Me.CashrewardTextBox.Size = New System.Drawing.Size(236, 40)
        Me.CashrewardTextBox.TabIndex = 82
        '
        'TblSCommissionBindingSource
        '
        Me.TblSCommissionBindingSource.DataMember = "tblSCommission"
        Me.TblSCommissionBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LightGreen
        Me.Button2.Location = New System.Drawing.Point(320, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(236, 46)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Start season"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSCommissionBindingSource, "status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(335, 228)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 40)
        Me.StatusTextBox.TabIndex = 18
        '
        'dtpend
        '
        Me.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpend.Location = New System.Drawing.Point(320, 180)
        Me.dtpend.Name = "dtpend"
        Me.dtpend.Size = New System.Drawing.Size(236, 40)
        Me.dtpend.TabIndex = 23
        '
        'dtpstart
        '
        Me.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstart.Location = New System.Drawing.Point(320, 137)
        Me.dtpstart.Name = "dtpstart"
        Me.dtpstart.Size = New System.Drawing.Size(236, 40)
        Me.dtpstart.TabIndex = 22
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSCommissionBindingSource, "productName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(320, 8)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(236, 40)
        Me.ProductNameTextBox.TabIndex = 3
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSCommissionBindingSource, "productCode", True))
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(562, 8)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(100, 40)
        Me.ProductCodeTextBox.TabIndex = 5
        '
        'TargetQuantityTextBox
        '
        Me.TargetQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSCommissionBindingSource, "targetQuantity", True))
        Me.TargetQuantityTextBox.Location = New System.Drawing.Point(320, 94)
        Me.TargetQuantityTextBox.Name = "TargetQuantityTextBox"
        Me.TargetQuantityTextBox.Size = New System.Drawing.Size(236, 40)
        Me.TargetQuantityTextBox.TabIndex = 7
        '
        'ProductCodeTextBox1
        '
        Me.ProductCodeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productCode", True))
        Me.ProductCodeTextBox1.Location = New System.Drawing.Point(347, 229)
        Me.ProductCodeTextBox1.Name = "ProductCodeTextBox1"
        Me.ProductCodeTextBox1.Size = New System.Drawing.Size(21, 40)
        Me.ProductCodeTextBox1.TabIndex = 19
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.DataSet
        '
        'ProductNameTextBox1
        '
        Me.ProductNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productName", True))
        Me.ProductNameTextBox1.Location = New System.Drawing.Point(347, 229)
        Me.ProductNameTextBox1.Name = "ProductNameTextBox1"
        Me.ProductNameTextBox1.Size = New System.Drawing.Size(21, 40)
        Me.ProductNameTextBox1.TabIndex = 18
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSCommissionBindingSource, "quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(347, 229)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(21, 40)
        Me.QuantityTextBox.TabIndex = 9
        '
        'EndTextBox
        '
        Me.EndTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSCommissionBindingSource, "end", True))
        Me.EndTextBox.Location = New System.Drawing.Point(347, 229)
        Me.EndTextBox.Name = "EndTextBox"
        Me.EndTextBox.Size = New System.Drawing.Size(21, 40)
        Me.EndTextBox.TabIndex = 13
        '
        'StartTextBox
        '
        Me.StartTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSCommissionBindingSource, "start", True))
        Me.StartTextBox.Location = New System.Drawing.Point(347, 229)
        Me.StartTextBox.Name = "StartTextBox"
        Me.StartTextBox.Size = New System.Drawing.Size(21, 40)
        Me.StartTextBox.TabIndex = 11
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
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'SupplierTextBox
        '
        Me.SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "supplier", True))
        Me.SupplierTextBox.Location = New System.Drawing.Point(86, 12)
        Me.SupplierTextBox.Name = "SupplierTextBox"
        Me.SupplierTextBox.Size = New System.Drawing.Size(100, 21)
        Me.SupplierTextBox.TabIndex = 18
        '
        'salesSeason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(SupplierLabel)
        Me.Controls.Add(Me.SupplierTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "salesSeason"
        Me.Text = "salesSeason"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblSCommissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblSCommissionBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents dtpend As DateTimePicker
    Friend WithEvents dtpstart As DateTimePicker
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents TargetQuantityTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents StartTextBox As TextBox
    Friend WithEvents EndTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As dataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents ProductNameTextBox1 As TextBox
    Friend WithEvents ProductCodeTextBox1 As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents CashrewardTextBox As TextBox
    Friend WithEvents SupplierTextBox As TextBox
End Class
