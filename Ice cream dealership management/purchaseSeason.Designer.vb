<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class purchaseSeason
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
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim TargetQuantityLabel As System.Windows.Forms.Label
        Dim StartLabel As System.Windows.Forms.Label
        Dim EndLabel As System.Windows.Forms.Label
        Dim CashrewardLabel As System.Windows.Forms.Label
        Dim ProductrewardLabel As System.Windows.Forms.Label
        Dim ProductrewardQuantityLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProductCodeTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.dtpend = New System.Windows.Forms.DateTimePicker()
        Me.StartTextBox = New System.Windows.Forms.TextBox()
        Me.TblPCommissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpstart = New System.Windows.Forms.DateTimePicker()
        Me.EndTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.TargetQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.CashrewardTextBox = New System.Windows.Forms.TextBox()
        Me.ProductrewardTextBox = New System.Windows.Forms.TextBox()
        Me.ProductrewardCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ProductrewardQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.TblPCommissionTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblPCommissionTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductsTableAdapter()
        ProductNameLabel = New System.Windows.Forms.Label()
        TargetQuantityLabel = New System.Windows.Forms.Label()
        StartLabel = New System.Windows.Forms.Label()
        EndLabel = New System.Windows.Forms.Label()
        CashrewardLabel = New System.Windows.Forms.Label()
        ProductrewardLabel = New System.Windows.Forms.Label()
        ProductrewardQuantityLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPCommissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.BackColor = System.Drawing.Color.Black
        ProductNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ProductNameLabel.Location = New System.Drawing.Point(25, 83)
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
        TargetQuantityLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        TargetQuantityLabel.Location = New System.Drawing.Point(25, 124)
        TargetQuantityLabel.Name = "TargetQuantityLabel"
        TargetQuantityLabel.Padding = New System.Windows.Forms.Padding(4)
        TargetQuantityLabel.Size = New System.Drawing.Size(267, 40)
        TargetQuantityLabel.TabIndex = 6
        TargetQuantityLabel.Text = "Target quantity:"
        '
        'StartLabel
        '
        StartLabel.AutoSize = True
        StartLabel.BackColor = System.Drawing.Color.Black
        StartLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        StartLabel.Location = New System.Drawing.Point(25, 165)
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
        EndLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        EndLabel.Location = New System.Drawing.Point(25, 206)
        EndLabel.Name = "EndLabel"
        EndLabel.Padding = New System.Windows.Forms.Padding(4)
        EndLabel.Size = New System.Drawing.Size(263, 40)
        EndLabel.TabIndex = 12
        EndLabel.Text = "Season ends at:"
        '
        'CashrewardLabel
        '
        CashrewardLabel.AutoSize = True
        CashrewardLabel.BackColor = System.Drawing.Color.Black
        CashrewardLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CashrewardLabel.Location = New System.Drawing.Point(25, 247)
        CashrewardLabel.Name = "CashrewardLabel"
        CashrewardLabel.Padding = New System.Windows.Forms.Padding(4)
        CashrewardLabel.Size = New System.Drawing.Size(257, 40)
        CashrewardLabel.TabIndex = 14
        CashrewardLabel.Text = "Reward (cash):"
        '
        'ProductrewardLabel
        '
        ProductrewardLabel.AutoSize = True
        ProductrewardLabel.BackColor = System.Drawing.Color.Black
        ProductrewardLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ProductrewardLabel.Location = New System.Drawing.Point(25, 288)
        ProductrewardLabel.Name = "ProductrewardLabel"
        ProductrewardLabel.Padding = New System.Windows.Forms.Padding(4)
        ProductrewardLabel.Size = New System.Drawing.Size(305, 40)
        ProductrewardLabel.TabIndex = 16
        ProductrewardLabel.Text = "Reward (product):"
        '
        'ProductrewardQuantityLabel
        '
        ProductrewardQuantityLabel.AutoSize = True
        ProductrewardQuantityLabel.BackColor = System.Drawing.Color.Black
        ProductrewardQuantityLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ProductrewardQuantityLabel.Location = New System.Drawing.Point(25, 329)
        ProductrewardQuantityLabel.Name = "ProductrewardQuantityLabel"
        ProductrewardQuantityLabel.Padding = New System.Windows.Forms.Padding(4)
        ProductrewardQuantityLabel.Size = New System.Drawing.Size(403, 40)
        ProductrewardQuantityLabel.TabIndex = 20
        ProductrewardQuantityLabel.Text = "Product reward quantity:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1008, 44)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "New purchase commission season"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ProductCodeTextBox1)
        Me.Panel1.Controls.Add(Me.dtpend)
        Me.Panel1.Controls.Add(Me.StartTextBox)
        Me.Panel1.Controls.Add(Me.dtpstart)
        Me.Panel1.Controls.Add(Me.EndTextBox)
        Me.Panel1.Controls.Add(ProductNameLabel)
        Me.Panel1.Controls.Add(Me.ProductNameTextBox1)
        Me.Panel1.Controls.Add(Me.ProductNameTextBox)
        Me.Panel1.Controls.Add(Me.QuantityTextBox)
        Me.Panel1.Controls.Add(Me.ProductCodeTextBox)
        Me.Panel1.Controls.Add(Me.TargetQuantityTextBox)
        Me.Panel1.Controls.Add(ProductrewardQuantityLabel)
        Me.Panel1.Controls.Add(TargetQuantityLabel)
        Me.Panel1.Controls.Add(ProductrewardLabel)
        Me.Panel1.Controls.Add(CashrewardLabel)
        Me.Panel1.Controls.Add(EndLabel)
        Me.Panel1.Controls.Add(Me.CashrewardTextBox)
        Me.Panel1.Controls.Add(StartLabel)
        Me.Panel1.Controls.Add(Me.ProductrewardTextBox)
        Me.Panel1.Controls.Add(Me.ProductrewardCodeTextBox)
        Me.Panel1.Controls.Add(Me.ProductrewardQuantityTextBox)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(21, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 473)
        Me.Panel1.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LightGreen
        Me.Button2.Location = New System.Drawing.Point(431, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(236, 46)
        Me.Button2.TabIndex = 80
        Me.Button2.Text = "Start season"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ProductCodeTextBox1
        '
        Me.ProductCodeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productCode", True))
        Me.ProductCodeTextBox1.Location = New System.Drawing.Point(444, 379)
        Me.ProductCodeTextBox1.Name = "ProductCodeTextBox1"
        Me.ProductCodeTextBox1.Size = New System.Drawing.Size(19, 40)
        Me.ProductCodeTextBox1.TabIndex = 18
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpend
        '
        Me.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpend.Location = New System.Drawing.Point(431, 206)
        Me.dtpend.Name = "dtpend"
        Me.dtpend.Size = New System.Drawing.Size(236, 40)
        Me.dtpend.TabIndex = 23
        '
        'StartTextBox
        '
        Me.StartTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPCommissionBindingSource, "start", True))
        Me.StartTextBox.Location = New System.Drawing.Point(444, 379)
        Me.StartTextBox.Name = "StartTextBox"
        Me.StartTextBox.Size = New System.Drawing.Size(19, 40)
        Me.StartTextBox.TabIndex = 11
        '
        'TblPCommissionBindingSource
        '
        Me.TblPCommissionBindingSource.DataMember = "tblPCommission"
        Me.TblPCommissionBindingSource.DataSource = Me.DataSet
        '
        'dtpstart
        '
        Me.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstart.Location = New System.Drawing.Point(431, 165)
        Me.dtpstart.Name = "dtpstart"
        Me.dtpstart.Size = New System.Drawing.Size(236, 40)
        Me.dtpstart.TabIndex = 22
        '
        'EndTextBox
        '
        Me.EndTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPCommissionBindingSource, "end", True))
        Me.EndTextBox.Location = New System.Drawing.Point(444, 379)
        Me.EndTextBox.Name = "EndTextBox"
        Me.EndTextBox.Size = New System.Drawing.Size(19, 40)
        Me.EndTextBox.TabIndex = 13
        '
        'ProductNameTextBox1
        '
        Me.ProductNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "productName", True))
        Me.ProductNameTextBox1.Location = New System.Drawing.Point(444, 379)
        Me.ProductNameTextBox1.Name = "ProductNameTextBox1"
        Me.ProductNameTextBox1.Size = New System.Drawing.Size(19, 40)
        Me.ProductNameTextBox1.TabIndex = 17
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPCommissionBindingSource, "productName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(431, 83)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(236, 40)
        Me.ProductNameTextBox.TabIndex = 3
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPCommissionBindingSource, "quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(444, 379)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(19, 40)
        Me.QuantityTextBox.TabIndex = 9
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPCommissionBindingSource, "productCode", True))
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(673, 83)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(100, 40)
        Me.ProductCodeTextBox.TabIndex = 5
        '
        'TargetQuantityTextBox
        '
        Me.TargetQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPCommissionBindingSource, "targetQuantity", True))
        Me.TargetQuantityTextBox.Location = New System.Drawing.Point(431, 124)
        Me.TargetQuantityTextBox.Name = "TargetQuantityTextBox"
        Me.TargetQuantityTextBox.Size = New System.Drawing.Size(236, 40)
        Me.TargetQuantityTextBox.TabIndex = 7
        '
        'CashrewardTextBox
        '
        Me.CashrewardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPCommissionBindingSource, "cashreward", True))
        Me.CashrewardTextBox.Location = New System.Drawing.Point(431, 247)
        Me.CashrewardTextBox.Name = "CashrewardTextBox"
        Me.CashrewardTextBox.Size = New System.Drawing.Size(236, 40)
        Me.CashrewardTextBox.TabIndex = 15
        '
        'ProductrewardTextBox
        '
        Me.ProductrewardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPCommissionBindingSource, "productreward", True))
        Me.ProductrewardTextBox.Location = New System.Drawing.Point(431, 288)
        Me.ProductrewardTextBox.Name = "ProductrewardTextBox"
        Me.ProductrewardTextBox.Size = New System.Drawing.Size(236, 40)
        Me.ProductrewardTextBox.TabIndex = 17
        '
        'ProductrewardCodeTextBox
        '
        Me.ProductrewardCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPCommissionBindingSource, "productrewardCode", True))
        Me.ProductrewardCodeTextBox.Location = New System.Drawing.Point(673, 288)
        Me.ProductrewardCodeTextBox.Name = "ProductrewardCodeTextBox"
        Me.ProductrewardCodeTextBox.Size = New System.Drawing.Size(100, 40)
        Me.ProductrewardCodeTextBox.TabIndex = 19
        '
        'ProductrewardQuantityTextBox
        '
        Me.ProductrewardQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPCommissionBindingSource, "productrewardQuantity", True))
        Me.ProductrewardQuantityTextBox.Location = New System.Drawing.Point(431, 329)
        Me.ProductrewardQuantityTextBox.Name = "ProductrewardQuantityTextBox"
        Me.ProductrewardQuantityTextBox.Size = New System.Drawing.Size(236, 40)
        Me.ProductrewardQuantityTextBox.TabIndex = 21
        '
        'TblPCommissionTableAdapter
        '
        Me.TblPCommissionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblPCommissionTableAdapter = Me.TblPCommissionTableAdapter
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
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'purchaseSeason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "purchaseSeason"
        Me.Text = "purchaseSeason"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPCommissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblPCommissionBindingSource As BindingSource
    Friend WithEvents TblPCommissionTableAdapter As dataSetTableAdapters.tblPCommissionTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents TargetQuantityTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents StartTextBox As TextBox
    Friend WithEvents EndTextBox As TextBox
    Friend WithEvents CashrewardTextBox As TextBox
    Friend WithEvents ProductrewardTextBox As TextBox
    Friend WithEvents ProductrewardCodeTextBox As TextBox
    Friend WithEvents ProductrewardQuantityTextBox As TextBox
    Friend WithEvents dtpend As DateTimePicker
    Friend WithEvents dtpstart As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As dataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents ProductNameTextBox1 As TextBox
    Friend WithEvents ProductCodeTextBox1 As TextBox
End Class
