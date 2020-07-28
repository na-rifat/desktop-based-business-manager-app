<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageTransaction
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
        Dim OpeningBalanceLabel As System.Windows.Forms.Label
        Dim TransactionIDLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim TransactionTypeLabel As System.Windows.Forms.Label
        Dim AccNoLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim PersonOrsourceLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim ExpenseCategoryLabel As System.Windows.Forms.Label
        Dim ExpenseNoteLabel As System.Windows.Forms.Label
        Dim AmountLabel1 As System.Windows.Forms.Label
        Dim DateLabel1 As System.Windows.Forms.Label
        Dim PersonNameLabel As System.Windows.Forms.Label
        Dim ExpenseSubCategoryLabel As System.Windows.Forms.Label
        Dim AccNoLabel1 As System.Windows.Forms.Label
        Dim BankamountLabel As System.Windows.Forms.Label
        Dim PaymentMethodLabel As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim IncomeCategoryLabel As System.Windows.Forms.Label
        Dim IncomeNoteLabel As System.Windows.Forms.Label
        Dim AmountLabel2 As System.Windows.Forms.Label
        Dim DateLabel2 As System.Windows.Forms.Label
        Dim IncomeSubcategoryLabel As System.Windows.Forms.Label
        Dim AccNoLabel2 As System.Windows.Forms.Label
        Dim BankamountLabel1 As System.Windows.Forms.Label
        Dim PaymentmethodLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BankTextBox = New System.Windows.Forms.TextBox()
        Me.TblBankAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.TblTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonOrsourceTextBox = New System.Windows.Forms.TextBox()
        Me.fromDt = New System.Windows.Forms.DateTimePicker()
        Me.rdnW = New System.Windows.Forms.RadioButton()
        Me.rdnD = New System.Windows.Forms.RadioButton()
        Me.TransactionIDTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.TblTransactionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personOrsource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.chk_income = New System.Windows.Forms.CheckBox()
        Me.chk_expense = New System.Windows.Forms.CheckBox()
        Me.AccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionTypeTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.OpeningBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.TblTransactionTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblTransactionTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblBankAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblBankAccountsTableAdapter()
        Me.TblExpensesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpensesTableAdapter()
        Me.TblIncomeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblIncomeTableAdapter()
        Me.TblExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseNoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTextBox1 = New System.Windows.Forms.TextBox()
        Me.PersonNameTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseSubCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox1 = New System.Windows.Forms.TextBox()
        Me.BankamountTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentMethodComboBox = New System.Windows.Forms.ComboBox()
        Me.TblIncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.IncomeCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeNoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTextBox2 = New System.Windows.Forms.TextBox()
        Me.IncomeSubcategoryTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox2 = New System.Windows.Forms.TextBox()
        Me.BankamountTextBox1 = New System.Windows.Forms.TextBox()
        Me.PaymentmethodComboBox1 = New System.Windows.Forms.ComboBox()
        OpeningBalanceLabel = New System.Windows.Forms.Label()
        TransactionIDLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        TransactionTypeLabel = New System.Windows.Forms.Label()
        AccNoLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        PersonOrsourceLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        ExpenseCategoryLabel = New System.Windows.Forms.Label()
        ExpenseNoteLabel = New System.Windows.Forms.Label()
        AmountLabel1 = New System.Windows.Forms.Label()
        DateLabel1 = New System.Windows.Forms.Label()
        PersonNameLabel = New System.Windows.Forms.Label()
        ExpenseSubCategoryLabel = New System.Windows.Forms.Label()
        AccNoLabel1 = New System.Windows.Forms.Label()
        BankamountLabel = New System.Windows.Forms.Label()
        PaymentMethodLabel = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        IncomeCategoryLabel = New System.Windows.Forms.Label()
        IncomeNoteLabel = New System.Windows.Forms.Label()
        AmountLabel2 = New System.Windows.Forms.Label()
        DateLabel2 = New System.Windows.Forms.Label()
        IncomeSubcategoryLabel = New System.Windows.Forms.Label()
        AccNoLabel2 = New System.Windows.Forms.Label()
        BankamountLabel1 = New System.Windows.Forms.Label()
        PaymentmethodLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpeningBalanceLabel
        '
        OpeningBalanceLabel.AutoSize = True
        OpeningBalanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OpeningBalanceLabel.Location = New System.Drawing.Point(198, 16)
        OpeningBalanceLabel.Name = "OpeningBalanceLabel"
        OpeningBalanceLabel.Size = New System.Drawing.Size(90, 13)
        OpeningBalanceLabel.TabIndex = 13
        OpeningBalanceLabel.Text = "opening Balance:"
        '
        'TransactionIDLabel
        '
        TransactionIDLabel.BackColor = System.Drawing.Color.Black
        TransactionIDLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        TransactionIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        TransactionIDLabel.Location = New System.Drawing.Point(13, 15)
        TransactionIDLabel.Name = "TransactionIDLabel"
        TransactionIDLabel.Size = New System.Drawing.Size(141, 25)
        TransactionIDLabel.TabIndex = 13
        TransactionIDLabel.Text = "লেনদেন নং:"
        TransactionIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AmountLabel
        '
        AmountLabel.BackColor = System.Drawing.Color.Black
        AmountLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AmountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AmountLabel.Location = New System.Drawing.Point(13, 93)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(141, 25)
        AmountLabel.TabIndex = 15
        AmountLabel.Text = "অর্থের পরিমাণঃ"
        AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TransactionTypeLabel
        '
        TransactionTypeLabel.BackColor = System.Drawing.Color.Black
        TransactionTypeLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        TransactionTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        TransactionTypeLabel.Location = New System.Drawing.Point(13, 119)
        TransactionTypeLabel.Name = "TransactionTypeLabel"
        TransactionTypeLabel.Size = New System.Drawing.Size(141, 25)
        TransactionTypeLabel.TabIndex = 17
        TransactionTypeLabel.Text = "লেনদেনের ধরন"
        TransactionTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AccNoLabel
        '
        AccNoLabel.BackColor = System.Drawing.Color.Black
        AccNoLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AccNoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AccNoLabel.Location = New System.Drawing.Point(13, 41)
        AccNoLabel.Name = "AccNoLabel"
        AccNoLabel.Size = New System.Drawing.Size(141, 25)
        AccNoLabel.TabIndex = 19
        AccNoLabel.Text = "একাউন্ট নাম্বারঃ"
        AccNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        DateLabel.BackColor = System.Drawing.Color.Black
        DateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DateLabel.Location = New System.Drawing.Point(13, 145)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(141, 25)
        DateLabel.TabIndex = 21
        DateLabel.Text = "তারিখঃ"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PersonOrsourceLabel
        '
        PersonOrsourceLabel.BackColor = System.Drawing.Color.Black
        PersonOrsourceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PersonOrsourceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PersonOrsourceLabel.Location = New System.Drawing.Point(13, 171)
        PersonOrsourceLabel.Name = "PersonOrsourceLabel"
        PersonOrsourceLabel.Size = New System.Drawing.Size(141, 25)
        PersonOrsourceLabel.TabIndex = 63
        PersonOrsourceLabel.Text = "প্রাপক/প্রেরকঃ"
        PersonOrsourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NoteLabel
        '
        NoteLabel.BackColor = System.Drawing.Color.Black
        NoteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        NoteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        NoteLabel.Location = New System.Drawing.Point(13, 197)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(141, 25)
        NoteLabel.TabIndex = 64
        NoteLabel.Text = "মন্তব্যঃ"
        NoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(16, 8)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 22
        IdLabel.Text = "Id:"
        '
        'ExpenseCategoryLabel
        '
        ExpenseCategoryLabel.AutoSize = True
        ExpenseCategoryLabel.Location = New System.Drawing.Point(16, 8)
        ExpenseCategoryLabel.Name = "ExpenseCategoryLabel"
        ExpenseCategoryLabel.Size = New System.Drawing.Size(95, 13)
        ExpenseCategoryLabel.TabIndex = 24
        ExpenseCategoryLabel.Text = "expense Category:"
        '
        'ExpenseNoteLabel
        '
        ExpenseNoteLabel.AutoSize = True
        ExpenseNoteLabel.Location = New System.Drawing.Point(16, 8)
        ExpenseNoteLabel.Name = "ExpenseNoteLabel"
        ExpenseNoteLabel.Size = New System.Drawing.Size(76, 13)
        ExpenseNoteLabel.TabIndex = 26
        ExpenseNoteLabel.Text = "expense Note:"
        '
        'AmountLabel1
        '
        AmountLabel1.AutoSize = True
        AmountLabel1.Location = New System.Drawing.Point(16, 8)
        AmountLabel1.Name = "AmountLabel1"
        AmountLabel1.Size = New System.Drawing.Size(45, 13)
        AmountLabel1.TabIndex = 28
        AmountLabel1.Text = "amount:"
        '
        'DateLabel1
        '
        DateLabel1.AutoSize = True
        DateLabel1.Location = New System.Drawing.Point(16, 8)
        DateLabel1.Name = "DateLabel1"
        DateLabel1.Size = New System.Drawing.Size(31, 13)
        DateLabel1.TabIndex = 30
        DateLabel1.Text = "date:"
        '
        'PersonNameLabel
        '
        PersonNameLabel.AutoSize = True
        PersonNameLabel.Location = New System.Drawing.Point(16, 8)
        PersonNameLabel.Name = "PersonNameLabel"
        PersonNameLabel.Size = New System.Drawing.Size(73, 13)
        PersonNameLabel.TabIndex = 32
        PersonNameLabel.Text = "person Name:"
        '
        'ExpenseSubCategoryLabel
        '
        ExpenseSubCategoryLabel.AutoSize = True
        ExpenseSubCategoryLabel.Location = New System.Drawing.Point(16, 8)
        ExpenseSubCategoryLabel.Name = "ExpenseSubCategoryLabel"
        ExpenseSubCategoryLabel.Size = New System.Drawing.Size(117, 13)
        ExpenseSubCategoryLabel.TabIndex = 34
        ExpenseSubCategoryLabel.Text = "expense Sub Category:"
        '
        'AccNoLabel1
        '
        AccNoLabel1.AutoSize = True
        AccNoLabel1.Location = New System.Drawing.Point(16, 8)
        AccNoLabel1.Name = "AccNoLabel1"
        AccNoLabel1.Size = New System.Drawing.Size(45, 13)
        AccNoLabel1.TabIndex = 36
        AccNoLabel1.Text = "acc No:"
        '
        'BankamountLabel
        '
        BankamountLabel.AutoSize = True
        BankamountLabel.Location = New System.Drawing.Point(16, 8)
        BankamountLabel.Name = "BankamountLabel"
        BankamountLabel.Size = New System.Drawing.Size(69, 13)
        BankamountLabel.TabIndex = 38
        BankamountLabel.Text = "bankamount:"
        '
        'PaymentMethodLabel
        '
        PaymentMethodLabel.AutoSize = True
        PaymentMethodLabel.Location = New System.Drawing.Point(16, 8)
        PaymentMethodLabel.Name = "PaymentMethodLabel"
        PaymentMethodLabel.Size = New System.Drawing.Size(89, 13)
        PaymentMethodLabel.TabIndex = 40
        PaymentMethodLabel.Text = "payment Method:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(12, 9)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(19, 13)
        IdLabel1.TabIndex = 41
        IdLabel1.Text = "Id:"
        '
        'IncomeCategoryLabel
        '
        IncomeCategoryLabel.AutoSize = True
        IncomeCategoryLabel.Location = New System.Drawing.Point(12, 9)
        IncomeCategoryLabel.Name = "IncomeCategoryLabel"
        IncomeCategoryLabel.Size = New System.Drawing.Size(89, 13)
        IncomeCategoryLabel.TabIndex = 43
        IncomeCategoryLabel.Text = "income Category:"
        '
        'IncomeNoteLabel
        '
        IncomeNoteLabel.AutoSize = True
        IncomeNoteLabel.Location = New System.Drawing.Point(12, 9)
        IncomeNoteLabel.Name = "IncomeNoteLabel"
        IncomeNoteLabel.Size = New System.Drawing.Size(70, 13)
        IncomeNoteLabel.TabIndex = 45
        IncomeNoteLabel.Text = "income Note:"
        '
        'AmountLabel2
        '
        AmountLabel2.AutoSize = True
        AmountLabel2.Location = New System.Drawing.Point(12, 9)
        AmountLabel2.Name = "AmountLabel2"
        AmountLabel2.Size = New System.Drawing.Size(45, 13)
        AmountLabel2.TabIndex = 47
        AmountLabel2.Text = "amount:"
        '
        'DateLabel2
        '
        DateLabel2.AutoSize = True
        DateLabel2.Location = New System.Drawing.Point(12, 9)
        DateLabel2.Name = "DateLabel2"
        DateLabel2.Size = New System.Drawing.Size(31, 13)
        DateLabel2.TabIndex = 49
        DateLabel2.Text = "date:"
        '
        'IncomeSubcategoryLabel
        '
        IncomeSubcategoryLabel.AutoSize = True
        IncomeSubcategoryLabel.Location = New System.Drawing.Point(12, 9)
        IncomeSubcategoryLabel.Name = "IncomeSubcategoryLabel"
        IncomeSubcategoryLabel.Size = New System.Drawing.Size(107, 13)
        IncomeSubcategoryLabel.TabIndex = 51
        IncomeSubcategoryLabel.Text = "income Subcategory:"
        '
        'AccNoLabel2
        '
        AccNoLabel2.AutoSize = True
        AccNoLabel2.Location = New System.Drawing.Point(12, 9)
        AccNoLabel2.Name = "AccNoLabel2"
        AccNoLabel2.Size = New System.Drawing.Size(45, 13)
        AccNoLabel2.TabIndex = 53
        AccNoLabel2.Text = "acc No:"
        '
        'BankamountLabel1
        '
        BankamountLabel1.AutoSize = True
        BankamountLabel1.Location = New System.Drawing.Point(12, 9)
        BankamountLabel1.Name = "BankamountLabel1"
        BankamountLabel1.Size = New System.Drawing.Size(69, 13)
        BankamountLabel1.TabIndex = 55
        BankamountLabel1.Text = "bankamount:"
        '
        'PaymentmethodLabel1
        '
        PaymentmethodLabel1.AutoSize = True
        PaymentmethodLabel1.Location = New System.Drawing.Point(12, 9)
        PaymentmethodLabel1.Name = "PaymentmethodLabel1"
        PaymentmethodLabel1.Size = New System.Drawing.Size(85, 13)
        PaymentmethodLabel1.TabIndex = 57
        PaymentmethodLabel1.Text = "paymentmethod:"
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Black
        Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(13, 67)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(141, 25)
        Label2.TabIndex = 82
        Label2.Text = "ব্যাংকঃ"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 32)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 32)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 29)
        Me.ToolStripLabel2.Text = "সার্চ"
        '
        'txtFilter
        '
        Me.txtFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFilter.Items.AddRange(New Object() {"লেনদেন নং", "একাউন্ট নং", "তারিখ"})
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(150, 32)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 29)
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
        Me.ToolStripButton4.Size = New System.Drawing.Size(126, 28)
        Me.ToolStripButton4.Text = "নতুন লেনদেন"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton3.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(93, 28)
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
        Me.ToolStripButton2.Size = New System.Drawing.Size(74, 28)
        Me.ToolStripButton2.Text = "ডিলিট"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton6.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton6.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripButton6.Size = New System.Drawing.Size(67, 28)
        Me.ToolStripButton6.Text = "প্রিন্ট"
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
        Me.Label1.Text = "লেনদেনসমূহ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TblTransactionDataGridView)
        Me.Panel1.Controls.Add(Me.tool)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(18, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 527)
        Me.Panel1.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(233, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 284)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "নতুন লেনদেন"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Controls.Add(Me.BankTextBox)
        Me.Panel2.Controls.Add(NoteLabel)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.NoteTextBox)
        Me.Panel2.Controls.Add(PersonOrsourceLabel)
        Me.Panel2.Controls.Add(Me.PersonOrsourceTextBox)
        Me.Panel2.Controls.Add(Me.fromDt)
        Me.Panel2.Controls.Add(Me.rdnW)
        Me.Panel2.Controls.Add(Me.rdnD)
        Me.Panel2.Controls.Add(TransactionIDLabel)
        Me.Panel2.Controls.Add(Me.TransactionIDTextBox)
        Me.Panel2.Controls.Add(AmountLabel)
        Me.Panel2.Controls.Add(Me.AmountTextBox)
        Me.Panel2.Controls.Add(TransactionTypeLabel)
        Me.Panel2.Controls.Add(AccNoLabel)
        Me.Panel2.Controls.Add(Me.AccNoTextBox)
        Me.Panel2.Controls.Add(DateLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(3, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 258)
        Me.Panel2.TabIndex = 15
        '
        'BankTextBox
        '
        Me.BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "bank", True))
        Me.BankTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.BankTextBox.Location = New System.Drawing.Point(160, 65)
        Me.BankTextBox.Name = "BankTextBox"
        Me.BankTextBox.ReadOnly = True
        Me.BankTextBox.Size = New System.Drawing.Size(319, 24)
        Me.BankTextBox.TabIndex = 81
        '
        'TblBankAccountsBindingSource
        '
        Me.TblBankAccountsBindingSource.DataMember = "tblBankAccounts"
        Me.TblBankAccountsBindingSource.DataSource = Me.DataSet
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
        Me.Button1.Location = New System.Drawing.Point(160, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 32)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "note", True))
        Me.NoteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.NoteTextBox.Location = New System.Drawing.Point(160, 191)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(319, 24)
        Me.NoteTextBox.TabIndex = 65
        '
        'TblTransactionBindingSource
        '
        Me.TblTransactionBindingSource.DataMember = "tblTransaction"
        Me.TblTransactionBindingSource.DataSource = Me.DataSet
        '
        'PersonOrsourceTextBox
        '
        Me.PersonOrsourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "personOrsource", True))
        Me.PersonOrsourceTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PersonOrsourceTextBox.Location = New System.Drawing.Point(160, 166)
        Me.PersonOrsourceTextBox.Name = "PersonOrsourceTextBox"
        Me.PersonOrsourceTextBox.Size = New System.Drawing.Size(319, 24)
        Me.PersonOrsourceTextBox.TabIndex = 64
        '
        'fromDt
        '
        Me.fromDt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.fromDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDt.Location = New System.Drawing.Point(160, 141)
        Me.fromDt.Name = "fromDt"
        Me.fromDt.Size = New System.Drawing.Size(159, 24)
        Me.fromDt.TabIndex = 63
        '
        'rdnW
        '
        Me.rdnW.BackColor = System.Drawing.Color.White
        Me.rdnW.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.rdnW.ForeColor = System.Drawing.Color.Black
        Me.rdnW.Location = New System.Drawing.Point(320, 115)
        Me.rdnW.Name = "rdnW"
        Me.rdnW.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.rdnW.Size = New System.Drawing.Size(159, 25)
        Me.rdnW.TabIndex = 24
        Me.rdnW.Text = "Withdraw"
        Me.rdnW.UseVisualStyleBackColor = False
        '
        'rdnD
        '
        Me.rdnD.BackColor = System.Drawing.Color.White
        Me.rdnD.Checked = True
        Me.rdnD.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.rdnD.ForeColor = System.Drawing.Color.Black
        Me.rdnD.Location = New System.Drawing.Point(160, 115)
        Me.rdnD.Name = "rdnD"
        Me.rdnD.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.rdnD.Size = New System.Drawing.Size(159, 25)
        Me.rdnD.TabIndex = 23
        Me.rdnD.TabStop = True
        Me.rdnD.Text = "Deposit"
        Me.rdnD.UseVisualStyleBackColor = False
        '
        'TransactionIDTextBox
        '
        Me.TransactionIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "transactionID", True))
        Me.TransactionIDTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TransactionIDTextBox.Location = New System.Drawing.Point(160, 15)
        Me.TransactionIDTextBox.Name = "TransactionIDTextBox"
        Me.TransactionIDTextBox.Size = New System.Drawing.Size(319, 24)
        Me.TransactionIDTextBox.TabIndex = 14
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AmountTextBox.Location = New System.Drawing.Point(160, 90)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(319, 24)
        Me.AmountTextBox.TabIndex = 16
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "accNo", True))
        Me.AccNoTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AccNoTextBox.Location = New System.Drawing.Point(160, 40)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(319, 24)
        Me.AccNoTextBox.TabIndex = 20
        '
        'TblTransactionDataGridView
        '
        Me.TblTransactionDataGridView.AutoGenerateColumns = False
        Me.TblTransactionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTransactionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.personOrsource, Me.note})
        Me.TblTransactionDataGridView.DataSource = Me.TblTransactionBindingSource
        Me.TblTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblTransactionDataGridView.Location = New System.Drawing.Point(0, 293)
        Me.TblTransactionDataGridView.Name = "TblTransactionDataGridView"
        Me.TblTransactionDataGridView.Size = New System.Drawing.Size(965, 206)
        Me.TblTransactionDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "transactionID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "লেনদেন আই.ডি."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "অর্থের পরিমান"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "transactionType"
        Me.DataGridViewTextBoxColumn4.HeaderText = "লেনদেনের ধরন"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "accNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "একাউন্ট নাম্বার"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'personOrsource
        '
        Me.personOrsource.DataPropertyName = "personOrsource"
        Me.personOrsource.HeaderText = "প্রাপক/প্রেরক"
        Me.personOrsource.Name = "personOrsource"
        Me.personOrsource.Width = 120
        '
        'note
        '
        Me.note.DataPropertyName = "note"
        Me.note.HeaderText = "মন্তব্য"
        Me.note.Name = "note"
        '
        'tool
        '
        Me.tool.BackColor = System.Drawing.Color.White
        Me.tool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tool.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel4, Me.ToolStripSeparator1, Me.ToolStripLabel3})
        Me.tool.Location = New System.Drawing.Point(0, 499)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(965, 28)
        Me.tool.TabIndex = 80
        Me.tool.Text = "ToolStrip2"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Padding = New System.Windows.Forms.Padding(4)
        Me.ToolStripLabel4.Size = New System.Drawing.Size(112, 25)
        Me.ToolStripLabel4.Text = "Total deposit:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
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
        'chk_income
        '
        Me.chk_income.BackColor = System.Drawing.Color.White
        Me.chk_income.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chk_income.ForeColor = System.Drawing.Color.Black
        Me.chk_income.Location = New System.Drawing.Point(12, 3)
        Me.chk_income.Name = "chk_income"
        Me.chk_income.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.chk_income.Size = New System.Drawing.Size(159, 25)
        Me.chk_income.TabIndex = 67
        Me.chk_income.Text = "Income"
        Me.chk_income.UseVisualStyleBackColor = False
        '
        'chk_expense
        '
        Me.chk_expense.BackColor = System.Drawing.Color.White
        Me.chk_expense.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chk_expense.ForeColor = System.Drawing.Color.Black
        Me.chk_expense.Location = New System.Drawing.Point(12, 3)
        Me.chk_expense.Name = "chk_expense"
        Me.chk_expense.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.chk_expense.Size = New System.Drawing.Size(168, 25)
        Me.chk_expense.TabIndex = 66
        Me.chk_expense.Text = "Expense"
        Me.chk_expense.UseVisualStyleBackColor = False
        '
        'AccountNumberTextBox
        '
        Me.AccountNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "accountNumber", True))
        Me.AccountNumberTextBox.Location = New System.Drawing.Point(26, 4)
        Me.AccountNumberTextBox.Name = "AccountNumberTextBox"
        Me.AccountNumberTextBox.Size = New System.Drawing.Size(30, 20)
        Me.AccountNumberTextBox.TabIndex = 14
        '
        'TransactionTypeTextBox
        '
        Me.TransactionTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "transactionType", True))
        Me.TransactionTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionTypeTextBox.Location = New System.Drawing.Point(225, 12)
        Me.TransactionTypeTextBox.Name = "TransactionTypeTextBox"
        Me.TransactionTypeTextBox.Size = New System.Drawing.Size(36, 20)
        Me.TransactionTypeTextBox.TabIndex = 18
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "date", True))
        Me.DateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTextBox.Location = New System.Drawing.Point(225, 12)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(36, 20)
        Me.DateTextBox.TabIndex = 22
        '
        'OpeningBalanceTextBox
        '
        Me.OpeningBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "openingBalance", True))
        Me.OpeningBalanceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpeningBalanceTextBox.Location = New System.Drawing.Point(238, 12)
        Me.OpeningBalanceTextBox.Name = "OpeningBalanceTextBox"
        Me.OpeningBalanceTextBox.Size = New System.Drawing.Size(10, 20)
        Me.OpeningBalanceTextBox.TabIndex = 14
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
        Me.TableAdapterManager.tblExpensesTableAdapter = Me.TblExpensesTableAdapter
        Me.TableAdapterManager.tblExpenseSubcategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblFridgesTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeSubcategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeTableAdapter = Me.TblIncomeTableAdapter
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
        'TblExpensesTableAdapter
        '
        Me.TblExpensesTableAdapter.ClearBeforeFill = True
        '
        'TblIncomeTableAdapter
        '
        Me.TblIncomeTableAdapter.ClearBeforeFill = True
        '
        'TblExpensesBindingSource
        '
        Me.TblExpensesBindingSource.DataMember = "tblExpenses"
        Me.TblExpensesBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(16, 8)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IdTextBox.TabIndex = 23
        '
        'ExpenseCategoryTextBox
        '
        Me.ExpenseCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseCategory", True))
        Me.ExpenseCategoryTextBox.Location = New System.Drawing.Point(16, 8)
        Me.ExpenseCategoryTextBox.Name = "ExpenseCategoryTextBox"
        Me.ExpenseCategoryTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ExpenseCategoryTextBox.TabIndex = 25
        '
        'ExpenseNoteTextBox
        '
        Me.ExpenseNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseNote", True))
        Me.ExpenseNoteTextBox.Location = New System.Drawing.Point(16, 8)
        Me.ExpenseNoteTextBox.Name = "ExpenseNoteTextBox"
        Me.ExpenseNoteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ExpenseNoteTextBox.TabIndex = 27
        '
        'AmountTextBox1
        '
        Me.AmountTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "amount", True))
        Me.AmountTextBox1.Location = New System.Drawing.Point(16, 8)
        Me.AmountTextBox1.Name = "AmountTextBox1"
        Me.AmountTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.AmountTextBox1.TabIndex = 29
        '
        'DateTextBox1
        '
        Me.DateTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "date", True))
        Me.DateTextBox1.Location = New System.Drawing.Point(16, 8)
        Me.DateTextBox1.Name = "DateTextBox1"
        Me.DateTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.DateTextBox1.TabIndex = 31
        '
        'PersonNameTextBox
        '
        Me.PersonNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "personName", True))
        Me.PersonNameTextBox.Location = New System.Drawing.Point(16, 8)
        Me.PersonNameTextBox.Name = "PersonNameTextBox"
        Me.PersonNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PersonNameTextBox.TabIndex = 33
        '
        'ExpenseSubCategoryTextBox
        '
        Me.ExpenseSubCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseSubCategory", True))
        Me.ExpenseSubCategoryTextBox.Location = New System.Drawing.Point(16, 8)
        Me.ExpenseSubCategoryTextBox.Name = "ExpenseSubCategoryTextBox"
        Me.ExpenseSubCategoryTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ExpenseSubCategoryTextBox.TabIndex = 35
        '
        'AccNoTextBox1
        '
        Me.AccNoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "accNo", True))
        Me.AccNoTextBox1.Location = New System.Drawing.Point(16, 8)
        Me.AccNoTextBox1.Name = "AccNoTextBox1"
        Me.AccNoTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.AccNoTextBox1.TabIndex = 37
        '
        'BankamountTextBox
        '
        Me.BankamountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "bankamount", True))
        Me.BankamountTextBox.Location = New System.Drawing.Point(16, 8)
        Me.BankamountTextBox.Name = "BankamountTextBox"
        Me.BankamountTextBox.Size = New System.Drawing.Size(121, 20)
        Me.BankamountTextBox.TabIndex = 39
        '
        'PaymentMethodComboBox
        '
        Me.PaymentMethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "paymentMethod", True))
        Me.PaymentMethodComboBox.FormattingEnabled = True
        Me.PaymentMethodComboBox.Location = New System.Drawing.Point(16, 8)
        Me.PaymentMethodComboBox.Name = "PaymentMethodComboBox"
        Me.PaymentMethodComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PaymentMethodComboBox.TabIndex = 41
        '
        'TblIncomeBindingSource
        '
        Me.TblIncomeBindingSource.DataMember = "tblIncome"
        Me.TblIncomeBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "Id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(12, 9)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.IdTextBox1.TabIndex = 42
        '
        'IncomeCategoryTextBox
        '
        Me.IncomeCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeCategory", True))
        Me.IncomeCategoryTextBox.Location = New System.Drawing.Point(12, 9)
        Me.IncomeCategoryTextBox.Name = "IncomeCategoryTextBox"
        Me.IncomeCategoryTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IncomeCategoryTextBox.TabIndex = 44
        '
        'IncomeNoteTextBox
        '
        Me.IncomeNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeNote", True))
        Me.IncomeNoteTextBox.Location = New System.Drawing.Point(12, 9)
        Me.IncomeNoteTextBox.Name = "IncomeNoteTextBox"
        Me.IncomeNoteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IncomeNoteTextBox.TabIndex = 46
        '
        'AmountTextBox2
        '
        Me.AmountTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "amount", True))
        Me.AmountTextBox2.Location = New System.Drawing.Point(12, 9)
        Me.AmountTextBox2.Name = "AmountTextBox2"
        Me.AmountTextBox2.Size = New System.Drawing.Size(121, 20)
        Me.AmountTextBox2.TabIndex = 48
        '
        'DateTextBox2
        '
        Me.DateTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "date", True))
        Me.DateTextBox2.Location = New System.Drawing.Point(12, 9)
        Me.DateTextBox2.Name = "DateTextBox2"
        Me.DateTextBox2.Size = New System.Drawing.Size(121, 20)
        Me.DateTextBox2.TabIndex = 50
        '
        'IncomeSubcategoryTextBox
        '
        Me.IncomeSubcategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeSubcategory", True))
        Me.IncomeSubcategoryTextBox.Location = New System.Drawing.Point(12, 9)
        Me.IncomeSubcategoryTextBox.Name = "IncomeSubcategoryTextBox"
        Me.IncomeSubcategoryTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IncomeSubcategoryTextBox.TabIndex = 52
        '
        'AccNoTextBox2
        '
        Me.AccNoTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "accNo", True))
        Me.AccNoTextBox2.Location = New System.Drawing.Point(12, 9)
        Me.AccNoTextBox2.Name = "AccNoTextBox2"
        Me.AccNoTextBox2.Size = New System.Drawing.Size(121, 20)
        Me.AccNoTextBox2.TabIndex = 54
        '
        'BankamountTextBox1
        '
        Me.BankamountTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "bankamount", True))
        Me.BankamountTextBox1.Location = New System.Drawing.Point(12, 9)
        Me.BankamountTextBox1.Name = "BankamountTextBox1"
        Me.BankamountTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.BankamountTextBox1.TabIndex = 56
        '
        'PaymentmethodComboBox1
        '
        Me.PaymentmethodComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "paymentmethod", True))
        Me.PaymentmethodComboBox1.FormattingEnabled = True
        Me.PaymentmethodComboBox1.Location = New System.Drawing.Point(12, 9)
        Me.PaymentmethodComboBox1.Name = "PaymentmethodComboBox1"
        Me.PaymentmethodComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.PaymentmethodComboBox1.TabIndex = 58
        '
        'manageTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TransactionTypeTextBox)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(OpeningBalanceLabel)
        Me.Controls.Add(Me.OpeningBalanceTextBox)
        Me.Controls.Add(Me.AccountNumberTextBox)
        Me.Controls.Add(IdLabel1)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(IncomeCategoryLabel)
        Me.Controls.Add(Me.IncomeCategoryTextBox)
        Me.Controls.Add(IncomeNoteLabel)
        Me.Controls.Add(Me.IncomeNoteTextBox)
        Me.Controls.Add(AmountLabel2)
        Me.Controls.Add(Me.AmountTextBox2)
        Me.Controls.Add(DateLabel2)
        Me.Controls.Add(Me.DateTextBox2)
        Me.Controls.Add(IncomeSubcategoryLabel)
        Me.Controls.Add(Me.IncomeSubcategoryTextBox)
        Me.Controls.Add(AccNoLabel2)
        Me.Controls.Add(Me.AccNoTextBox2)
        Me.Controls.Add(BankamountLabel1)
        Me.Controls.Add(Me.BankamountTextBox1)
        Me.Controls.Add(PaymentmethodLabel1)
        Me.Controls.Add(Me.PaymentmethodComboBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(ExpenseCategoryLabel)
        Me.Controls.Add(Me.ExpenseCategoryTextBox)
        Me.Controls.Add(ExpenseNoteLabel)
        Me.Controls.Add(Me.ExpenseNoteTextBox)
        Me.Controls.Add(AmountLabel1)
        Me.Controls.Add(Me.AmountTextBox1)
        Me.Controls.Add(DateLabel1)
        Me.Controls.Add(Me.DateTextBox1)
        Me.Controls.Add(PersonNameLabel)
        Me.Controls.Add(Me.PersonNameTextBox)
        Me.Controls.Add(ExpenseSubCategoryLabel)
        Me.Controls.Add(Me.ExpenseSubCategoryTextBox)
        Me.Controls.Add(AccNoLabel1)
        Me.Controls.Add(Me.AccNoTextBox1)
        Me.Controls.Add(BankamountLabel)
        Me.Controls.Add(Me.BankamountTextBox)
        Me.Controls.Add(PaymentMethodLabel)
        Me.Controls.Add(Me.PaymentMethodComboBox)
        Me.Controls.Add(Me.chk_income)
        Me.Controls.Add(Me.chk_expense)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageTransaction"
        Me.Text = "manageTransaction"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblTransactionBindingSource As BindingSource
    Friend WithEvents TblTransactionTableAdapter As dataSetTableAdapters.tblTransactionTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTransactionDataGridView As DataGridView
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents TransactionTypeTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents TblBankAccountsBindingSource As BindingSource
    Friend WithEvents TblBankAccountsTableAdapter As dataSetTableAdapters.tblBankAccountsTableAdapter
    Friend WithEvents OpeningBalanceTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents fromDt As DateTimePicker
    Friend WithEvents rdnW As RadioButton
    Friend WithEvents rdnD As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents TransactionIDTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents AccNoTextBox As TextBox
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents PersonOrsourceTextBox As TextBox
    Friend WithEvents AccountNumberTextBox As TextBox
    Friend WithEvents chk_expense As CheckBox
    Friend WithEvents chk_income As CheckBox
    Friend WithEvents TblExpensesBindingSource As BindingSource
    Friend WithEvents TblExpensesTableAdapter As dataSetTableAdapters.tblExpensesTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ExpenseCategoryTextBox As TextBox
    Friend WithEvents ExpenseNoteTextBox As TextBox
    Friend WithEvents AmountTextBox1 As TextBox
    Friend WithEvents DateTextBox1 As TextBox
    Friend WithEvents PersonNameTextBox As TextBox
    Friend WithEvents ExpenseSubCategoryTextBox As TextBox
    Friend WithEvents AccNoTextBox1 As TextBox
    Friend WithEvents BankamountTextBox As TextBox
    Friend WithEvents PaymentMethodComboBox As ComboBox
    Friend WithEvents TblIncomeBindingSource As BindingSource
    Friend WithEvents TblIncomeTableAdapter As dataSetTableAdapters.tblIncomeTableAdapter
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents IncomeCategoryTextBox As TextBox
    Friend WithEvents IncomeNoteTextBox As TextBox
    Friend WithEvents AmountTextBox2 As TextBox
    Friend WithEvents DateTextBox2 As TextBox
    Friend WithEvents IncomeSubcategoryTextBox As TextBox
    Friend WithEvents AccNoTextBox2 As TextBox
    Friend WithEvents BankamountTextBox1 As TextBox
    Friend WithEvents PaymentmethodComboBox1 As ComboBox
    Friend WithEvents tool As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BankTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents personOrsource As DataGridViewTextBoxColumn
    Friend WithEvents note As DataGridViewTextBoxColumn
End Class
