<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class withdraw
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
        Dim WithdrawReasonLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim PersonLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PersonTextBox = New System.Windows.Forms.TextBox()
        Me.TblwithdrawBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WithdrawReasonTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblwithdrawDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.person = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TblwithdrawTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblwithdrawTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        WithdrawReasonLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        PersonLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblwithdrawBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblwithdrawDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WithdrawReasonLabel
        '
        WithdrawReasonLabel.BackColor = System.Drawing.Color.Black
        WithdrawReasonLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        WithdrawReasonLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        WithdrawReasonLabel.Location = New System.Drawing.Point(4, 26)
        WithdrawReasonLabel.Name = "WithdrawReasonLabel"
        WithdrawReasonLabel.Size = New System.Drawing.Size(146, 25)
        WithdrawReasonLabel.TabIndex = 2
        WithdrawReasonLabel.Text = "কারনঃ"
        WithdrawReasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AmountLabel
        '
        AmountLabel.BackColor = System.Drawing.Color.Black
        AmountLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AmountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AmountLabel.Location = New System.Drawing.Point(4, 52)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(146, 25)
        AmountLabel.TabIndex = 4
        AmountLabel.Text = "অর্থের পরিমাণঃ"
        AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        DateLabel.BackColor = System.Drawing.Color.Black
        DateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DateLabel.Location = New System.Drawing.Point(4, 104)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(146, 25)
        DateLabel.TabIndex = 6
        DateLabel.Text = "তারিখঃ"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PersonLabel
        '
        PersonLabel.BackColor = System.Drawing.Color.Black
        PersonLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PersonLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PersonLabel.Location = New System.Drawing.Point(4, 78)
        PersonLabel.Name = "PersonLabel"
        PersonLabel.Size = New System.Drawing.Size(146, 25)
        PersonLabel.TabIndex = 16
        PersonLabel.Text = "ব্যক্তির নামঃ"
        PersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "উত্তোলন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(152, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 202)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "নতুন উত্তোলন"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(PersonLabel)
        Me.Panel2.Controls.Add(Me.PersonTextBox)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(WithdrawReasonLabel)
        Me.Panel2.Controls.Add(Me.WithdrawReasonTextBox)
        Me.Panel2.Controls.Add(AmountLabel)
        Me.Panel2.Controls.Add(Me.AmountTextBox)
        Me.Panel2.Controls.Add(DateLabel)
        Me.Panel2.Location = New System.Drawing.Point(6, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 177)
        Me.Panel2.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(153, 103)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 24)
        Me.DateTimePicker1.TabIndex = 18
        '
        'PersonTextBox
        '
        Me.PersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblwithdrawBindingSource, "person", True))
        Me.PersonTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PersonTextBox.Location = New System.Drawing.Point(153, 78)
        Me.PersonTextBox.Name = "PersonTextBox"
        Me.PersonTextBox.Size = New System.Drawing.Size(298, 24)
        Me.PersonTextBox.TabIndex = 17
        '
        'TblwithdrawBindingSource
        '
        Me.TblwithdrawBindingSource.DataMember = "tblwithdraw"
        Me.TblwithdrawBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(153, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'WithdrawReasonTextBox
        '
        Me.WithdrawReasonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblwithdrawBindingSource, "withdrawReason", True))
        Me.WithdrawReasonTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.WithdrawReasonTextBox.Location = New System.Drawing.Point(153, 28)
        Me.WithdrawReasonTextBox.Name = "WithdrawReasonTextBox"
        Me.WithdrawReasonTextBox.Size = New System.Drawing.Size(298, 24)
        Me.WithdrawReasonTextBox.TabIndex = 3
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblwithdrawBindingSource, "amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AmountTextBox.Location = New System.Drawing.Point(153, 53)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(298, 24)
        Me.AmountTextBox.TabIndex = 5
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblwithdrawBindingSource, "date", True))
        Me.DateTextBox.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        Me.DateTextBox.Location = New System.Drawing.Point(12, 0)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(38, 33)
        Me.DateTextBox.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TblwithdrawDataGridView)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(59, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 484)
        Me.Panel1.TabIndex = 21
        '
        'TblwithdrawDataGridView
        '
        Me.TblwithdrawDataGridView.AutoGenerateColumns = False
        Me.TblwithdrawDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblwithdrawDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblwithdrawDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.person, Me.DataGridViewTextBoxColumn4})
        Me.TblwithdrawDataGridView.DataSource = Me.TblwithdrawBindingSource
        Me.TblwithdrawDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblwithdrawDataGridView.Location = New System.Drawing.Point(0, 217)
        Me.TblwithdrawDataGridView.Name = "TblwithdrawDataGridView"
        Me.TblwithdrawDataGridView.Size = New System.Drawing.Size(882, 239)
        Me.TblwithdrawDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "withdrawReason"
        Me.DataGridViewTextBoxColumn2.HeaderText = "কারণ"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "অর্থের পরিমাণ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'person
        '
        Me.person.DataPropertyName = "person"
        Me.person.HeaderText = "ব্যক্তির নাম"
        Me.person.Name = "person"
        Me.person.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 456)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(882, 28)
        Me.tool.TabIndex = 79
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Padding = New System.Windows.Forms.Padding(4)
        Me.ToolStripLabel3.Size = New System.Drawing.Size(123, 25)
        Me.ToolStripLabel3.Text = "Total withdraw:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 29)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 29)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 26)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"তারিখ"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(150, 29)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 26)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.SteelBlue
        Me.ToolStripButton4.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.button_circle_add_512
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(129, 25)
        Me.ToolStripButton4.Text = "নতুন উত্তোলন"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(93, 25)
        Me.ToolStripButton3.Text = "সংশোধন"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(74, 25)
        Me.ToolStripButton2.Text = "ডিলিট"
        '
        'TblwithdrawTableAdapter
        '
        Me.TblwithdrawTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Me.TblwithdrawTableAdapter
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'withdraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "withdraw"
        Me.Text = "withdraw"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblwithdrawBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblwithdrawDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblwithdrawBindingSource As BindingSource
    Friend WithEvents TblwithdrawTableAdapter As dataSetTableAdapters.tblwithdrawTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents WithdrawReasonTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents TblwithdrawDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PersonTextBox As TextBox
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents person As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
