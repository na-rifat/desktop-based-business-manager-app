<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class returnDamage
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
        Dim ProdcutCategoryLabel As System.Windows.Forms.Label
        Dim SupplierLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblDamageProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDamageProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblDamageProductsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProdcutCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        ProductNameLabel = New System.Windows.Forms.Label()
        ProdcutCategoryLabel = New System.Windows.Forms.Label()
        SupplierLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDamageProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.BackColor = System.Drawing.Color.Black
        ProductNameLabel.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        ProductNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ProductNameLabel.Location = New System.Drawing.Point(6, 49)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Padding = New System.Windows.Forms.Padding(5)
        ProductNameLabel.Size = New System.Drawing.Size(247, 42)
        ProductNameLabel.TabIndex = 32
        ProductNameLabel.Text = "Product name:"
        '
        'ProdcutCategoryLabel
        '
        ProdcutCategoryLabel.AutoSize = True
        ProdcutCategoryLabel.BackColor = System.Drawing.Color.Black
        ProdcutCategoryLabel.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        ProdcutCategoryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ProdcutCategoryLabel.Location = New System.Drawing.Point(6, 93)
        ProdcutCategoryLabel.Name = "ProdcutCategoryLabel"
        ProdcutCategoryLabel.Padding = New System.Windows.Forms.Padding(5)
        ProdcutCategoryLabel.Size = New System.Drawing.Size(296, 42)
        ProdcutCategoryLabel.TabIndex = 34
        ProdcutCategoryLabel.Text = "Product category:"
        '
        'SupplierLabel
        '
        SupplierLabel.AutoSize = True
        SupplierLabel.BackColor = System.Drawing.Color.Black
        SupplierLabel.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        SupplierLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SupplierLabel.Location = New System.Drawing.Point(6, 137)
        SupplierLabel.Name = "SupplierLabel"
        SupplierLabel.Padding = New System.Windows.Forms.Padding(5)
        SupplierLabel.Size = New System.Drawing.Size(178, 42)
        SupplierLabel.TabIndex = 36
        SupplierLabel.Text = "Company:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.BackColor = System.Drawing.Color.Black
        QuantityLabel.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        QuantityLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        QuantityLabel.Location = New System.Drawing.Point(6, 181)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Padding = New System.Windows.Forms.Padding(5)
        QuantityLabel.Size = New System.Drawing.Size(273, 42)
        QuantityLabel.TabIndex = 38
        QuantityLabel.Text = "Return quantity:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Black
        Label2.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(6, 5)
        Label2.Name = "Label2"
        Label2.Padding = New System.Windows.Forms.Padding(5)
        Label2.Size = New System.Drawing.Size(206, 42)
        Label2.TabIndex = 61
        Label2.Text = "Damage ID:"
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
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Return damage products"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDamageProductsBindingSource
        '
        Me.TblDamageProductsBindingSource.DataMember = "tblDamageProducts"
        Me.TblDamageProductsBindingSource.DataSource = Me.DataSet
        '
        'TblDamageProductsTableAdapter
        '
        Me.TblDamageProductsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblDamageProductsTableAdapter = Me.TblDamageProductsTableAdapter
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
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtF)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txt)
        Me.Panel1.Controls.Add(ProductNameLabel)
        Me.Panel1.Controls.Add(Me.ProductNameTextBox)
        Me.Panel1.Controls.Add(ProdcutCategoryLabel)
        Me.Panel1.Controls.Add(Me.ProdcutCategoryTextBox)
        Me.Panel1.Controls.Add(SupplierLabel)
        Me.Panel1.Controls.Add(Me.SupplierTextBox)
        Me.Panel1.Controls.Add(QuantityLabel)
        Me.Panel1.Controls.Add(Me.QuantityTextBox)
        Me.Panel1.Controls.Add(Me.ProductCodeTextBox)
        Me.Panel1.Location = New System.Drawing.Point(67, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 280)
        Me.Panel1.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.LightGreen
        Me.Button3.Location = New System.Drawing.Point(484, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 46)
        Me.Button3.TabIndex = 66
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index11
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(612, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 40)
        Me.Button2.TabIndex = 60
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtF
        '
        Me.txtF.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtF.Location = New System.Drawing.Point(304, 10)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(302, 40)
        Me.txtF.TabIndex = 59
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGreen
        Me.Button1.Location = New System.Drawing.Point(304, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 46)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt
        '
        Me.txt.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txt.Location = New System.Drawing.Point(304, 174)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(226, 40)
        Me.txt.TabIndex = 40
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "productName", True))
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.ProductNameTextBox.Location = New System.Drawing.Point(304, 51)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.ReadOnly = True
        Me.ProductNameTextBox.Size = New System.Drawing.Size(351, 40)
        Me.ProductNameTextBox.TabIndex = 33
        '
        'ProdcutCategoryTextBox
        '
        Me.ProdcutCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "prodcutCategory", True))
        Me.ProdcutCategoryTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.ProdcutCategoryTextBox.Location = New System.Drawing.Point(304, 92)
        Me.ProdcutCategoryTextBox.Name = "ProdcutCategoryTextBox"
        Me.ProdcutCategoryTextBox.ReadOnly = True
        Me.ProdcutCategoryTextBox.Size = New System.Drawing.Size(351, 40)
        Me.ProdcutCategoryTextBox.TabIndex = 35
        '
        'SupplierTextBox
        '
        Me.SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "supplier", True))
        Me.SupplierTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.SupplierTextBox.Location = New System.Drawing.Point(304, 133)
        Me.SupplierTextBox.Name = "SupplierTextBox"
        Me.SupplierTextBox.ReadOnly = True
        Me.SupplierTextBox.Size = New System.Drawing.Size(351, 40)
        Me.SupplierTextBox.TabIndex = 37
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.QuantityTextBox.Location = New System.Drawing.Point(304, 220)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(54, 40)
        Me.QuantityTextBox.TabIndex = 39
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageProductsBindingSource, "productCode", True))
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(337, 239)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(34, 21)
        Me.ProductCodeTextBox.TabIndex = 23
        '
        'returnDamage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "returnDamage"
        Me.Text = "returnDamage"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDamageProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblDamageProductsBindingSource As BindingSource
    Friend WithEvents TblDamageProductsTableAdapter As dataSetTableAdapters.tblDamageProductsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProdcutCategoryTextBox As TextBox
    Friend WithEvents SupplierTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtF As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ProductCodeTextBox As TextBox
End Class
