<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returnDamageFridge
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
        Dim ModelNOLabel As System.Windows.Forms.Label
        Dim FridgeIDLabel As System.Windows.Forms.Label
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim SupplierLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblDamageFridgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDamageFridgeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblDamageFridgeTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.ModelNOTextBox = New System.Windows.Forms.TextBox()
        Me.FridgeIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.IssueDateTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        ModelNOLabel = New System.Windows.Forms.Label()
        FridgeIDLabel = New System.Windows.Forms.Label()
        IssueDateLabel = New System.Windows.Forms.Label()
        SupplierLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDamageFridgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ModelNOLabel
        '
        ModelNOLabel.AutoSize = True
        ModelNOLabel.Location = New System.Drawing.Point(44, 105)
        ModelNOLabel.Name = "ModelNOLabel"
        ModelNOLabel.Size = New System.Drawing.Size(68, 13)
        ModelNOLabel.TabIndex = 53
        ModelNOLabel.Text = "model NO:"
        '
        'FridgeIDLabel
        '
        FridgeIDLabel.AutoSize = True
        FridgeIDLabel.BackColor = System.Drawing.Color.Black
        FridgeIDLabel.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        FridgeIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        FridgeIDLabel.Location = New System.Drawing.Point(15, 14)
        FridgeIDLabel.Name = "FridgeIDLabel"
        FridgeIDLabel.Padding = New System.Windows.Forms.Padding(5)
        FridgeIDLabel.Size = New System.Drawing.Size(178, 42)
        FridgeIDLabel.TabIndex = 63
        FridgeIDLabel.Text = "Fridge ID:"
        '
        'IssueDateLabel
        '
        IssueDateLabel.AutoSize = True
        IssueDateLabel.BackColor = System.Drawing.Color.Black
        IssueDateLabel.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        IssueDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        IssueDateLabel.Location = New System.Drawing.Point(15, 106)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Padding = New System.Windows.Forms.Padding(5)
        IssueDateLabel.Size = New System.Drawing.Size(196, 42)
        IssueDateLabel.TabIndex = 64
        IssueDateLabel.Text = "Issue date:"
        '
        'SupplierLabel
        '
        SupplierLabel.AutoSize = True
        SupplierLabel.BackColor = System.Drawing.Color.Black
        SupplierLabel.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        SupplierLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SupplierLabel.Location = New System.Drawing.Point(15, 60)
        SupplierLabel.Name = "SupplierLabel"
        SupplierLabel.Padding = New System.Windows.Forms.Padding(5)
        SupplierLabel.Size = New System.Drawing.Size(161, 42)
        SupplierLabel.TabIndex = 66
        SupplierLabel.Text = "Supplier:"
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
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Return damage fridge"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDamageFridgeBindingSource
        '
        Me.TblDamageFridgeBindingSource.DataMember = "tblDamageFridge"
        Me.TblDamageFridgeBindingSource.DataSource = Me.DataSet
        '
        'TblDamageFridgeTableAdapter
        '
        Me.TblDamageFridgeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblDamageFridgeTableAdapter = Me.TblDamageFridgeTableAdapter
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
        'ModelNOTextBox
        '
        Me.ModelNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageFridgeBindingSource, "modelNO", True))
        Me.ModelNOTextBox.Location = New System.Drawing.Point(56, 81)
        Me.ModelNOTextBox.Name = "ModelNOTextBox"
        Me.ModelNOTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ModelNOTextBox.TabIndex = 54
        '
        'FridgeIDTextBox
        '
        Me.FridgeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageFridgeBindingSource, "fridgeID", True))
        Me.FridgeIDTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.FridgeIDTextBox.Location = New System.Drawing.Point(56, 83)
        Me.FridgeIDTextBox.Name = "FridgeIDTextBox"
        Me.FridgeIDTextBox.Size = New System.Drawing.Size(166, 40)
        Me.FridgeIDTextBox.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(FridgeIDLabel)
        Me.Panel1.Controls.Add(IssueDateLabel)
        Me.Panel1.Controls.Add(Me.IssueDateTextBox)
        Me.Panel1.Controls.Add(SupplierLabel)
        Me.Panel1.Controls.Add(Me.SupplierTextBox)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(267, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 207)
        Me.Panel1.TabIndex = 57
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Verdana", 20.0!)
        Me.txtID.Location = New System.Drawing.Point(217, 14)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(268, 40)
        Me.txtID.TabIndex = 68
        '
        'IssueDateTextBox
        '
        Me.IssueDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageFridgeBindingSource, "issueDate", True))
        Me.IssueDateTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.IssueDateTextBox.Location = New System.Drawing.Point(217, 106)
        Me.IssueDateTextBox.Name = "IssueDateTextBox"
        Me.IssueDateTextBox.ReadOnly = True
        Me.IssueDateTextBox.Size = New System.Drawing.Size(268, 40)
        Me.IssueDateTextBox.TabIndex = 65
        '
        'SupplierTextBox
        '
        Me.SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDamageFridgeBindingSource, "supplier", True))
        Me.SupplierTextBox.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.SupplierTextBox.Location = New System.Drawing.Point(217, 60)
        Me.SupplierTextBox.Name = "SupplierTextBox"
        Me.SupplierTextBox.ReadOnly = True
        Me.SupplierTextBox.Size = New System.Drawing.Size(268, 40)
        Me.SupplierTextBox.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGreen
        Me.Button1.Location = New System.Drawing.Point(217, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(268, 46)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(47, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 58
        '
        'returnDamageFridge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(ModelNOLabel)
        Me.Controls.Add(Me.ModelNOTextBox)
        Me.Controls.Add(Me.FridgeIDTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "returnDamageFridge"
        Me.Text = "returnDamageFridge"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDamageFridgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblDamageFridgeBindingSource As BindingSource
    Friend WithEvents TblDamageFridgeTableAdapter As dataSetTableAdapters.tblDamageFridgeTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents ModelNOTextBox As TextBox
    Friend WithEvents FridgeIDTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents IssueDateTextBox As TextBox
    Friend WithEvents SupplierTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
