<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBanks
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
        Me.DataSet1 = New Ice_cream_dealership_management.dataSet()
        Me.TblBanksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblBanksTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblBanksTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblBanksDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBanksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TblBanksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(306, 61)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 15
        IdLabel.Text = "Id:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "dataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBanksBindingSource
        '
        Me.TblBanksBindingSource.DataMember = "tblBanks"
        Me.TblBanksBindingSource.DataSource = Me.DataSet1
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ব্যাংকসমূহ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton4, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 37)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 37)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(34, 34)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"Bank name", "Address", "Phone"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(150, 37)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(79, 34)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton2.Size = New System.Drawing.Size(74, 33)
        Me.ToolStripButton2.Text = "ডিলিট"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton4.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton4.Size = New System.Drawing.Size(87, 33)
        Me.ToolStripButton4.Text = "সংশোধন"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton3.Size = New System.Drawing.Size(61, 33)
        Me.ToolStripButton3.Text = "প্রিন্ট"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBanksBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(336, 58)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IdTextBox.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TblBanksDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 581)
        Me.Panel1.TabIndex = 17
        '
        'TblBanksDataGridView
        '
        Me.TblBanksDataGridView.AutoGenerateColumns = False
        Me.TblBanksDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblBanksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblBanksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TblBanksDataGridView.DataSource = Me.TblBanksBindingSource
        Me.TblBanksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblBanksDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblBanksDataGridView.Name = "TblBanksDataGridView"
        Me.TblBanksDataGridView.Size = New System.Drawing.Size(1000, 581)
        Me.TblBanksDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "bankName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ব্যাংকের নাম"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ঠিকানা "
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "website"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ওয়েবসাইট"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn10.HeaderText = "মোবাইল"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'frmBanks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(IdLabel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBanks"
        Me.Text = "frmBanks"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBanksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TblBanksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As dataSet
    Friend WithEvents BanksBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataSet1 As dataSet
    Friend WithEvents TblBanksBindingSource As BindingSource
    Friend WithEvents TblBanksTableAdapter As dataSetTableAdapters.tblBanksTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TblBanksDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
