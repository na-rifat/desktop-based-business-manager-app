<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customerAccounts
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblCusomterAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toDt = New System.Windows.Forms.DateTimePicker()
        Me.fromDt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TblCusomterAccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TblExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpenseCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseNoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.PersonNameTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseSubCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.BankamountTextBox1 = New System.Windows.Forms.TextBox()
        Me.PaymentMethodComboBox = New System.Windows.Forms.ComboBox()
        Me.TblCusomterAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblCusomterAccountsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblIncomeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblIncomeTableAdapter()
        Me.TblInvoiceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblInvoiceTableAdapter()
        Me.TblVehicleAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblVehicleAccountsTableAdapter()
        Me.SaleInvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.PaidTextBox = New System.Windows.Forms.TextBox()
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PadiTextBox = New System.Windows.Forms.TextBox()
        Me.BankamountTextBox = New System.Windows.Forms.TextBox()
        Me.TblVehicleAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaidTextBox1 = New System.Windows.Forms.TextBox()
        Me.DueTextBox1 = New System.Windows.Forms.TextBox()
        Me.DueTextBox2 = New System.Windows.Forms.TextBox()
        Me.TblExpensesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpensesTableAdapter()
        Me.PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.TblIncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.IncomeCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeNoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTextBox1 = New System.Windows.Forms.TextBox()
        Me.IncomeSubcategoryTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox1 = New System.Windows.Forms.TextBox()
        Me.BankamountTextBox2 = New System.Windows.Forms.TextBox()
        Me.PaymentmethodComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Payment_remarkTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCusomterAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblCusomterAccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVehicleAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.txtFilter, Me.ToolStripLabel2, Me.ToolStripLabel1, Me.ToolStripButton4, Me.ToolStripButton2, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 37)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(291, 37)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(46, 34)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.AutoCompleteCustomSource.AddRange(New String() {"Customer name", "Customer ID", "Sale invoice", "Date"})
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"দোকানের নাম", "দোকানের আই.ডি.", "রশিদ নং"})
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(174, 29)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(112, 34)
        Me.ToolStripLabel1.Text = "সার্চের ধরন"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.SteelBlue
        Me.ToolStripButton4.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.money_sign_button1
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(139, 33)
        Me.ToolStripButton4.Text = "বাকি আদায়"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(88, 33)
        Me.ToolStripButton2.Text = "ডিলিট"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripButton5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton5.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(113, 33)
        Me.ToolStripButton5.Text = "সংশোধন"
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
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "কাস্টমারের হিসাব"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCusomterAccountsBindingSource
        '
        Me.TblCusomterAccountsBindingSource.DataMember = "tblCusomterAccounts"
        Me.TblCusomterAccountsBindingSource.DataSource = Me.DataSet
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.toDt)
        Me.Panel1.Controls.Add(Me.fromDt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TblCusomterAccountsDataGridView)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Location = New System.Drawing.Point(25, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(952, 519)
        Me.Panel1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(463, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "পর্যন্ত"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'toDt
        '
        Me.toDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.toDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.toDt.Location = New System.Drawing.Point(335, 30)
        Me.toDt.Name = "toDt"
        Me.toDt.Size = New System.Drawing.Size(127, 24)
        Me.toDt.TabIndex = 100
        '
        'fromDt
        '
        Me.fromDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.fromDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDt.Location = New System.Drawing.Point(335, 5)
        Me.fromDt.Name = "fromDt"
        Me.fromDt.Size = New System.Drawing.Size(127, 24)
        Me.fromDt.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(463, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "থেকে-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(567, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 80
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(516, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 70
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TblCusomterAccountsDataGridView
        '
        Me.TblCusomterAccountsDataGridView.AutoGenerateColumns = False
        Me.TblCusomterAccountsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblCusomterAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCusomterAccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblCusomterAccountsDataGridView.DataSource = Me.TblCusomterAccountsBindingSource
        Me.TblCusomterAccountsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblCusomterAccountsDataGridView.Location = New System.Drawing.Point(0, 60)
        Me.TblCusomterAccountsDataGridView.Name = "TblCusomterAccountsDataGridView"
        Me.TblCusomterAccountsDataGridView.Size = New System.Drawing.Size(952, 434)
        Me.TblCusomterAccountsDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "customerName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "দোকানের নাম"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "customerID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "আইডি"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "saleInvoice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "রশিদ নং"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "payment"
        Me.DataGridViewTextBoxColumn5.HeaderText = "পরিশোধের পরিমাণ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "paid"
        Me.DataGridViewTextBoxColumn6.HeaderText = "পরিশোধ"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "due"
        Me.DataGridViewTextBoxColumn7.HeaderText = "বাকি"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel5, Me.ToolStripSeparator1, Me.ToolStripLabel4, Me.ToolStripSeparator2, Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 494)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(952, 25)
        Me.tool.TabIndex = 77
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel5.Text = "Due:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel4.Text = "Paid:"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripLabel3.Text = "Total payment:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(892, 12)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IdTextBox.TabIndex = 101
        '
        'TblExpensesBindingSource
        '
        Me.TblExpensesBindingSource.DataMember = "tblExpenses"
        Me.TblExpensesBindingSource.DataSource = Me.DataSet
        '
        'ExpenseCategoryTextBox
        '
        Me.ExpenseCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseCategory", True))
        Me.ExpenseCategoryTextBox.Location = New System.Drawing.Point(892, 12)
        Me.ExpenseCategoryTextBox.Name = "ExpenseCategoryTextBox"
        Me.ExpenseCategoryTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ExpenseCategoryTextBox.TabIndex = 103
        '
        'ExpenseNoteTextBox
        '
        Me.ExpenseNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseNote", True))
        Me.ExpenseNoteTextBox.Location = New System.Drawing.Point(892, 12)
        Me.ExpenseNoteTextBox.Name = "ExpenseNoteTextBox"
        Me.ExpenseNoteTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ExpenseNoteTextBox.TabIndex = 105
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(892, 12)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 21)
        Me.AmountTextBox.TabIndex = 107
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(892, 12)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(100, 21)
        Me.DateTextBox.TabIndex = 109
        '
        'PersonNameTextBox
        '
        Me.PersonNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "personName", True))
        Me.PersonNameTextBox.Location = New System.Drawing.Point(892, 12)
        Me.PersonNameTextBox.Name = "PersonNameTextBox"
        Me.PersonNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.PersonNameTextBox.TabIndex = 111
        '
        'ExpenseSubCategoryTextBox
        '
        Me.ExpenseSubCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseSubCategory", True))
        Me.ExpenseSubCategoryTextBox.Location = New System.Drawing.Point(892, 12)
        Me.ExpenseSubCategoryTextBox.Name = "ExpenseSubCategoryTextBox"
        Me.ExpenseSubCategoryTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ExpenseSubCategoryTextBox.TabIndex = 113
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "accNo", True))
        Me.AccNoTextBox.Location = New System.Drawing.Point(892, 12)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(100, 21)
        Me.AccNoTextBox.TabIndex = 115
        '
        'BankamountTextBox1
        '
        Me.BankamountTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "bankamount", True))
        Me.BankamountTextBox1.Location = New System.Drawing.Point(892, 12)
        Me.BankamountTextBox1.Name = "BankamountTextBox1"
        Me.BankamountTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.BankamountTextBox1.TabIndex = 117
        '
        'PaymentMethodComboBox
        '
        Me.PaymentMethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "paymentMethod", True))
        Me.PaymentMethodComboBox.FormattingEnabled = True
        Me.PaymentMethodComboBox.Location = New System.Drawing.Point(892, 12)
        Me.PaymentMethodComboBox.Name = "PaymentMethodComboBox"
        Me.PaymentMethodComboBox.Size = New System.Drawing.Size(100, 21)
        Me.PaymentMethodComboBox.TabIndex = 119
        '
        'TblCusomterAccountsTableAdapter
        '
        Me.TblCusomterAccountsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblCusomterAccountsTableAdapter = Me.TblCusomterAccountsTableAdapter
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
        Me.TableAdapterManager.tblIncomeTableAdapter = Me.TblIncomeTableAdapter
        Me.TableAdapterManager.tblInvoiceTableAdapter = Me.TblInvoiceTableAdapter
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
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Me.TblVehicleAccountsTableAdapter
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblIncomeTableAdapter
        '
        Me.TblIncomeTableAdapter.ClearBeforeFill = True
        '
        'TblInvoiceTableAdapter
        '
        Me.TblInvoiceTableAdapter.ClearBeforeFill = True
        '
        'TblVehicleAccountsTableAdapter
        '
        Me.TblVehicleAccountsTableAdapter.ClearBeforeFill = True
        '
        'SaleInvoiceTextBox
        '
        Me.SaleInvoiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "saleInvoice", True))
        Me.SaleInvoiceTextBox.Location = New System.Drawing.Point(22, 12)
        Me.SaleInvoiceTextBox.Name = "SaleInvoiceTextBox"
        Me.SaleInvoiceTextBox.Size = New System.Drawing.Size(35, 21)
        Me.SaleInvoiceTextBox.TabIndex = 81
        '
        'PaidTextBox
        '
        Me.PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "paid", True))
        Me.PaidTextBox.Location = New System.Drawing.Point(63, 12)
        Me.PaidTextBox.Name = "PaidTextBox"
        Me.PaidTextBox.Size = New System.Drawing.Size(30, 21)
        Me.PaidTextBox.TabIndex = 81
        '
        'DueTextBox
        '
        Me.DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "due", True))
        Me.DueTextBox.Location = New System.Drawing.Point(99, 12)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DueTextBox.TabIndex = 81
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(140, 12)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(40, 21)
        Me.CustomerNameTextBox.TabIndex = 81
        '
        'TblInvoiceBindingSource
        '
        Me.TblInvoiceBindingSource.DataMember = "tblInvoice"
        Me.TblInvoiceBindingSource.DataSource = Me.DataSet
        '
        'PadiTextBox
        '
        Me.PadiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "padi", True))
        Me.PadiTextBox.Location = New System.Drawing.Point(229, 12)
        Me.PadiTextBox.Name = "PadiTextBox"
        Me.PadiTextBox.Size = New System.Drawing.Size(37, 21)
        Me.PadiTextBox.TabIndex = 81
        '
        'BankamountTextBox
        '
        Me.BankamountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "bankamount", True))
        Me.BankamountTextBox.Location = New System.Drawing.Point(186, 12)
        Me.BankamountTextBox.Name = "BankamountTextBox"
        Me.BankamountTextBox.Size = New System.Drawing.Size(37, 21)
        Me.BankamountTextBox.TabIndex = 82
        '
        'TblVehicleAccountsBindingSource
        '
        Me.TblVehicleAccountsBindingSource.DataMember = "tblVehicleAccounts"
        Me.TblVehicleAccountsBindingSource.DataSource = Me.DataSet
        '
        'PaidTextBox1
        '
        Me.PaidTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleAccountsBindingSource, "paid", True))
        Me.PaidTextBox1.Location = New System.Drawing.Point(272, 12)
        Me.PaidTextBox1.Name = "PaidTextBox1"
        Me.PaidTextBox1.Size = New System.Drawing.Size(37, 21)
        Me.PaidTextBox1.TabIndex = 83
        '
        'DueTextBox1
        '
        Me.DueTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "due", True))
        Me.DueTextBox1.Location = New System.Drawing.Point(172, 12)
        Me.DueTextBox1.Name = "DueTextBox1"
        Me.DueTextBox1.Size = New System.Drawing.Size(51, 21)
        Me.DueTextBox1.TabIndex = 81
        '
        'DueTextBox2
        '
        Me.DueTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleAccountsBindingSource, "due", True))
        Me.DueTextBox2.Location = New System.Drawing.Point(172, 12)
        Me.DueTextBox2.Name = "DueTextBox2"
        Me.DueTextBox2.Size = New System.Drawing.Size(51, 21)
        Me.DueTextBox2.TabIndex = 82
        '
        'TblExpensesTableAdapter
        '
        Me.TblExpensesTableAdapter.ClearBeforeFill = True
        '
        'PaymentTextBox
        '
        Me.PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "payment", True))
        Me.PaymentTextBox.Location = New System.Drawing.Point(892, 12)
        Me.PaymentTextBox.Name = "PaymentTextBox"
        Me.PaymentTextBox.Size = New System.Drawing.Size(100, 21)
        Me.PaymentTextBox.TabIndex = 120
        '
        'TblIncomeBindingSource
        '
        Me.TblIncomeBindingSource.DataMember = "tblIncome"
        Me.TblIncomeBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "Id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(840, 47)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(27, 21)
        Me.IdTextBox1.TabIndex = 121
        '
        'IncomeCategoryTextBox
        '
        Me.IncomeCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeCategory", True))
        Me.IncomeCategoryTextBox.Location = New System.Drawing.Point(840, 47)
        Me.IncomeCategoryTextBox.Name = "IncomeCategoryTextBox"
        Me.IncomeCategoryTextBox.Size = New System.Drawing.Size(27, 21)
        Me.IncomeCategoryTextBox.TabIndex = 123
        '
        'IncomeNoteTextBox
        '
        Me.IncomeNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeNote", True))
        Me.IncomeNoteTextBox.Location = New System.Drawing.Point(840, 47)
        Me.IncomeNoteTextBox.Name = "IncomeNoteTextBox"
        Me.IncomeNoteTextBox.Size = New System.Drawing.Size(27, 21)
        Me.IncomeNoteTextBox.TabIndex = 125
        '
        'AmountTextBox1
        '
        Me.AmountTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "amount", True))
        Me.AmountTextBox1.Location = New System.Drawing.Point(840, 47)
        Me.AmountTextBox1.Name = "AmountTextBox1"
        Me.AmountTextBox1.Size = New System.Drawing.Size(27, 21)
        Me.AmountTextBox1.TabIndex = 127
        '
        'DateTextBox1
        '
        Me.DateTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "date", True))
        Me.DateTextBox1.Location = New System.Drawing.Point(840, 47)
        Me.DateTextBox1.Name = "DateTextBox1"
        Me.DateTextBox1.Size = New System.Drawing.Size(27, 21)
        Me.DateTextBox1.TabIndex = 129
        '
        'IncomeSubcategoryTextBox
        '
        Me.IncomeSubcategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeSubcategory", True))
        Me.IncomeSubcategoryTextBox.Location = New System.Drawing.Point(840, 47)
        Me.IncomeSubcategoryTextBox.Name = "IncomeSubcategoryTextBox"
        Me.IncomeSubcategoryTextBox.Size = New System.Drawing.Size(27, 21)
        Me.IncomeSubcategoryTextBox.TabIndex = 131
        '
        'AccNoTextBox1
        '
        Me.AccNoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "accNo", True))
        Me.AccNoTextBox1.Location = New System.Drawing.Point(840, 47)
        Me.AccNoTextBox1.Name = "AccNoTextBox1"
        Me.AccNoTextBox1.Size = New System.Drawing.Size(27, 21)
        Me.AccNoTextBox1.TabIndex = 133
        '
        'BankamountTextBox2
        '
        Me.BankamountTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "bankamount", True))
        Me.BankamountTextBox2.Location = New System.Drawing.Point(840, 47)
        Me.BankamountTextBox2.Name = "BankamountTextBox2"
        Me.BankamountTextBox2.Size = New System.Drawing.Size(27, 21)
        Me.BankamountTextBox2.TabIndex = 135
        '
        'PaymentmethodComboBox1
        '
        Me.PaymentmethodComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "paymentmethod", True))
        Me.PaymentmethodComboBox1.FormattingEnabled = True
        Me.PaymentmethodComboBox1.Location = New System.Drawing.Point(840, 47)
        Me.PaymentmethodComboBox1.Name = "PaymentmethodComboBox1"
        Me.PaymentmethodComboBox1.Size = New System.Drawing.Size(27, 21)
        Me.PaymentmethodComboBox1.TabIndex = 137
        '
        'Payment_remarkTextBox
        '
        Me.Payment_remarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "payment_remark", True))
        Me.Payment_remarkTextBox.Location = New System.Drawing.Point(840, 47)
        Me.Payment_remarkTextBox.Name = "Payment_remarkTextBox"
        Me.Payment_remarkTextBox.Size = New System.Drawing.Size(27, 21)
        Me.Payment_remarkTextBox.TabIndex = 139
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "customerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(12, 12)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CustomerIDTextBox.TabIndex = 81
        '
        'CustomerNameTextBox1
        '
        Me.CustomerNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCusomterAccountsBindingSource, "customerName", True))
        Me.CustomerNameTextBox1.Location = New System.Drawing.Point(6, 12)
        Me.CustomerNameTextBox1.Name = "CustomerNameTextBox1"
        Me.CustomerNameTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.CustomerNameTextBox1.TabIndex = 81
        '
        'customerAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PaidTextBox1)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.PadiTextBox)
        Me.Controls.Add(Me.BankamountTextBox)
        Me.Controls.Add(Me.DueTextBox)
        Me.Controls.Add(Me.PaidTextBox)
        Me.Controls.Add(Me.SaleInvoiceTextBox)
        Me.Controls.Add(Me.DueTextBox2)
        Me.Controls.Add(Me.DueTextBox1)
        Me.Controls.Add(Me.PaymentTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.ExpenseCategoryTextBox)
        Me.Controls.Add(Me.ExpenseNoteTextBox)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.PersonNameTextBox)
        Me.Controls.Add(Me.ExpenseSubCategoryTextBox)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Controls.Add(Me.BankamountTextBox1)
        Me.Controls.Add(Me.PaymentMethodComboBox)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(Me.IncomeCategoryTextBox)
        Me.Controls.Add(Me.IncomeNoteTextBox)
        Me.Controls.Add(Me.AmountTextBox1)
        Me.Controls.Add(Me.DateTextBox1)
        Me.Controls.Add(Me.IncomeSubcategoryTextBox)
        Me.Controls.Add(Me.AccNoTextBox1)
        Me.Controls.Add(Me.BankamountTextBox2)
        Me.Controls.Add(Me.PaymentmethodComboBox1)
        Me.Controls.Add(Me.Payment_remarkTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox1)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customerAccounts"
        Me.Text = "customerAccounts"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCusomterAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblCusomterAccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVehicleAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblCusomterAccountsBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TblCusomterAccountsTableAdapter As dataSetTableAdapters.tblCusomterAccountsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As Button
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents SaleInvoiceTextBox As TextBox
    Friend WithEvents PaidTextBox As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents TblInvoiceBindingSource As BindingSource
    Friend WithEvents TblInvoiceTableAdapter As dataSetTableAdapters.tblInvoiceTableAdapter
    Friend WithEvents BankamountTextBox As TextBox
    Friend WithEvents PadiTextBox As TextBox
    Friend WithEvents TblVehicleAccountsBindingSource As BindingSource
    Friend WithEvents TblVehicleAccountsTableAdapter As dataSetTableAdapters.tblVehicleAccountsTableAdapter
    Friend WithEvents PaidTextBox1 As TextBox
    Friend WithEvents TblCusomterAccountsDataGridView As DataGridView
    Friend WithEvents DueTextBox2 As TextBox
    Friend WithEvents DueTextBox1 As TextBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents TblExpensesBindingSource As BindingSource
    Friend WithEvents TblExpensesTableAdapter As dataSetTableAdapters.tblExpensesTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ExpenseCategoryTextBox As TextBox
    Friend WithEvents ExpenseNoteTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents PersonNameTextBox As TextBox
    Friend WithEvents ExpenseSubCategoryTextBox As TextBox
    Friend WithEvents AccNoTextBox As TextBox
    Friend WithEvents BankamountTextBox1 As TextBox
    Friend WithEvents PaymentMethodComboBox As ComboBox
    Friend WithEvents PaymentTextBox As TextBox
    Friend WithEvents TblIncomeBindingSource As BindingSource
    Friend WithEvents TblIncomeTableAdapter As dataSetTableAdapters.tblIncomeTableAdapter
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents IncomeCategoryTextBox As TextBox
    Friend WithEvents IncomeNoteTextBox As TextBox
    Friend WithEvents AmountTextBox1 As TextBox
    Friend WithEvents DateTextBox1 As TextBox
    Friend WithEvents IncomeSubcategoryTextBox As TextBox
    Friend WithEvents AccNoTextBox1 As TextBox
    Friend WithEvents BankamountTextBox2 As TextBox
    Friend WithEvents PaymentmethodComboBox1 As ComboBox
    Friend WithEvents Payment_remarkTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents CustomerNameTextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents toDt As DateTimePicker
    Friend WithEvents fromDt As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
