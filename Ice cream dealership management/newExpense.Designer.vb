<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newExpense
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
        Dim ExpenseCategoryLabel As System.Windows.Forms.Label
        Dim ExpenseNoteLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim PersonNameLabel As System.Windows.Forms.Label
        Dim ExpenseSubCategoryLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim EmployeeNameLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim PaymentLabel As System.Windows.Forms.Label
        Dim PaidLabel As System.Windows.Forms.Label
        Dim DueLabel As System.Windows.Forms.Label
        Dim DateLabel1 As System.Windows.Forms.Label
        Dim EmployeeNameLabel1 As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim AccNoLabel As System.Windows.Forms.Label
        Dim BankamountLabel As System.Windows.Forms.Label
        Dim PaymentMethodLabel As System.Windows.Forms.Label
        Dim IdLabel2 As System.Windows.Forms.Label
        Dim TransactionIDLabel As System.Windows.Forms.Label
        Dim AmountLabel1 As System.Windows.Forms.Label
        Dim TransactionTypeLabel As System.Windows.Forms.Label
        Dim AccNoLabel1 As System.Windows.Forms.Label
        Dim DateLabel2 As System.Windows.Forms.Label
        Dim PersonOrsourceLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim OpeningBalanceLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PaymentMethodComboBox = New System.Windows.Forms.ComboBox()
        Me.TblExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.BankamountTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.chkEE = New System.Windows.Forms.CheckBox()
        Me.chkES = New System.Windows.Forms.CheckBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ExpenseCategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.ExpenseNoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.PersonNameTextBox = New System.Windows.Forms.TextBox()
        Me.ExpenseSubCategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.CTextBox = New System.Windows.Forms.TextBox()
        Me.TblExpenseSubcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.CNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblExpenseCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ConfirmatoinTextBox = New System.Windows.Forms.TextBox()
        Me.TblEmployeeAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.PaidTextBox = New System.Windows.Forms.TextBox()
        Me.DueTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblExpensesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpensesTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblBankAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblBankAccountsTableAdapter()
        Me.TblEmployeeAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblEmployeeAccountsTableAdapter()
        Me.TblEmployeeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblEmployeeTableAdapter()
        Me.TblTransactionTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblTransactionTableAdapter()
        Me.TblTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox2 = New System.Windows.Forms.TextBox()
        Me.TransactionIDTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox1 = New System.Windows.Forms.TextBox()
        Me.TransactionTypeTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTextBox2 = New System.Windows.Forms.TextBox()
        Me.PersonOrsourceTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.TblBankAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpeningBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TblExpenseCategoryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpenseCategoryTableAdapter()
        Me.TblExpenseSubcategoryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblExpenseSubcategoryTableAdapter()
        ExpenseCategoryLabel = New System.Windows.Forms.Label()
        ExpenseNoteLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        PersonNameLabel = New System.Windows.Forms.Label()
        ExpenseSubCategoryLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        EmployeeNameLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        PaymentLabel = New System.Windows.Forms.Label()
        PaidLabel = New System.Windows.Forms.Label()
        DueLabel = New System.Windows.Forms.Label()
        DateLabel1 = New System.Windows.Forms.Label()
        EmployeeNameLabel1 = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        AccNoLabel = New System.Windows.Forms.Label()
        BankamountLabel = New System.Windows.Forms.Label()
        PaymentMethodLabel = New System.Windows.Forms.Label()
        IdLabel2 = New System.Windows.Forms.Label()
        TransactionIDLabel = New System.Windows.Forms.Label()
        AmountLabel1 = New System.Windows.Forms.Label()
        TransactionTypeLabel = New System.Windows.Forms.Label()
        AccNoLabel1 = New System.Windows.Forms.Label()
        DateLabel2 = New System.Windows.Forms.Label()
        PersonOrsourceLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        OpeningBalanceLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpenseSubcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpenseCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TblEmployeeAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExpenseCategoryLabel
        '
        ExpenseCategoryLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ExpenseCategoryLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ExpenseCategoryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ExpenseCategoryLabel.Location = New System.Drawing.Point(61, 8)
        ExpenseCategoryLabel.Name = "ExpenseCategoryLabel"
        ExpenseCategoryLabel.Size = New System.Drawing.Size(161, 25)
        ExpenseCategoryLabel.TabIndex = 22
        ExpenseCategoryLabel.Text = "ব্যয়ের ধরণঃ"
        ExpenseCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExpenseNoteLabel
        '
        ExpenseNoteLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ExpenseNoteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ExpenseNoteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ExpenseNoteLabel.Location = New System.Drawing.Point(61, 299)
        ExpenseNoteLabel.Name = "ExpenseNoteLabel"
        ExpenseNoteLabel.Size = New System.Drawing.Size(161, 25)
        ExpenseNoteLabel.TabIndex = 24
        ExpenseNoteLabel.Text = "মন্তব্যঃ"
        ExpenseNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AmountLabel
        '
        AmountLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        AmountLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AmountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AmountLabel.Location = New System.Drawing.Point(61, 169)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(161, 25)
        AmountLabel.TabIndex = 26
        AmountLabel.Text = "ক্যাশে পরিশোধঃ"
        AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        DateLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DateLabel.Location = New System.Drawing.Point(61, 247)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(161, 25)
        DateLabel.TabIndex = 28
        DateLabel.Text = "তারিখঃ"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PersonNameLabel
        '
        PersonNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        PersonNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PersonNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PersonNameLabel.Location = New System.Drawing.Point(61, 273)
        PersonNameLabel.Name = "PersonNameLabel"
        PersonNameLabel.Size = New System.Drawing.Size(161, 25)
        PersonNameLabel.TabIndex = 30
        PersonNameLabel.Text = "প্রাপকের নামঃ"
        PersonNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExpenseSubCategoryLabel
        '
        ExpenseSubCategoryLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ExpenseSubCategoryLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ExpenseSubCategoryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ExpenseSubCategoryLabel.Location = New System.Drawing.Point(61, 34)
        ExpenseSubCategoryLabel.Name = "ExpenseSubCategoryLabel"
        ExpenseSubCategoryLabel.Size = New System.Drawing.Size(161, 25)
        ExpenseSubCategoryLabel.TabIndex = 32
        ExpenseSubCategoryLabel.Text = "ব্যায়ের সহকারী-ধরনঃ"
        ExpenseSubCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(3, 5)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 17
        IdLabel.Text = "Id:"
        '
        'EmployeeNameLabel
        '
        EmployeeNameLabel.AutoSize = True
        EmployeeNameLabel.Location = New System.Drawing.Point(24, 0)
        EmployeeNameLabel.Name = "EmployeeNameLabel"
        EmployeeNameLabel.Size = New System.Drawing.Size(86, 13)
        EmployeeNameLabel.TabIndex = 19
        EmployeeNameLabel.Text = "employee Name:"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(24, 0)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(69, 13)
        EmployeeIDLabel.TabIndex = 21
        EmployeeIDLabel.Text = "employee ID:"
        '
        'PaymentLabel
        '
        PaymentLabel.AutoSize = True
        PaymentLabel.Location = New System.Drawing.Point(24, 0)
        PaymentLabel.Name = "PaymentLabel"
        PaymentLabel.Size = New System.Drawing.Size(50, 13)
        PaymentLabel.TabIndex = 23
        PaymentLabel.Text = "payment:"
        '
        'PaidLabel
        '
        PaidLabel.AutoSize = True
        PaidLabel.Location = New System.Drawing.Point(21, 10)
        PaidLabel.Name = "PaidLabel"
        PaidLabel.Size = New System.Drawing.Size(30, 13)
        PaidLabel.TabIndex = 25
        PaidLabel.Text = "paid:"
        '
        'DueLabel
        '
        DueLabel.AutoSize = True
        DueLabel.Location = New System.Drawing.Point(3, 5)
        DueLabel.Name = "DueLabel"
        DueLabel.Size = New System.Drawing.Size(28, 13)
        DueLabel.TabIndex = 27
        DueLabel.Text = "due:"
        '
        'DateLabel1
        '
        DateLabel1.AutoSize = True
        DateLabel1.Location = New System.Drawing.Point(3, 5)
        DateLabel1.Name = "DateLabel1"
        DateLabel1.Size = New System.Drawing.Size(31, 13)
        DateLabel1.TabIndex = 29
        DateLabel1.Text = "date:"
        '
        'EmployeeNameLabel1
        '
        EmployeeNameLabel1.AutoSize = True
        EmployeeNameLabel1.Location = New System.Drawing.Point(24, 0)
        EmployeeNameLabel1.Name = "EmployeeNameLabel1"
        EmployeeNameLabel1.Size = New System.Drawing.Size(86, 13)
        EmployeeNameLabel1.TabIndex = 30
        EmployeeNameLabel1.Text = "employee Name:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(3, 5)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(19, 13)
        IdLabel1.TabIndex = 31
        IdLabel1.Text = "Id:"
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(61, 117)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(161, 25)
        Label2.TabIndex = 51
        Label2.Text = "কর্মচারীর নামঃ"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AccNoLabel
        '
        AccNoLabel.BackColor = System.Drawing.Color.Black
        AccNoLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AccNoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AccNoLabel.Location = New System.Drawing.Point(61, 221)
        AccNoLabel.Name = "AccNoLabel"
        AccNoLabel.Size = New System.Drawing.Size(161, 25)
        AccNoLabel.TabIndex = 52
        AccNoLabel.Text = "ব্যাংক একাউন্ট নাম্বারঃ"
        AccNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BankamountLabel
        '
        BankamountLabel.BackColor = System.Drawing.Color.Black
        BankamountLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        BankamountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        BankamountLabel.Location = New System.Drawing.Point(61, 195)
        BankamountLabel.Name = "BankamountLabel"
        BankamountLabel.Size = New System.Drawing.Size(161, 25)
        BankamountLabel.TabIndex = 53
        BankamountLabel.Text = "ব্যাংকে পরিশোধঃ"
        BankamountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaymentMethodLabel
        '
        PaymentMethodLabel.BackColor = System.Drawing.Color.Black
        PaymentMethodLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PaymentMethodLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PaymentMethodLabel.Location = New System.Drawing.Point(61, 143)
        PaymentMethodLabel.Name = "PaymentMethodLabel"
        PaymentMethodLabel.Size = New System.Drawing.Size(161, 25)
        PaymentMethodLabel.TabIndex = 54
        PaymentMethodLabel.Text = "পেমেন্টের পদ্ধতিঃ"
        PaymentMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdLabel2
        '
        IdLabel2.AutoSize = True
        IdLabel2.Location = New System.Drawing.Point(3, 5)
        IdLabel2.Name = "IdLabel2"
        IdLabel2.Size = New System.Drawing.Size(19, 13)
        IdLabel2.TabIndex = 50
        IdLabel2.Text = "Id:"
        '
        'TransactionIDLabel
        '
        TransactionIDLabel.AutoSize = True
        TransactionIDLabel.Location = New System.Drawing.Point(24, 0)
        TransactionIDLabel.Name = "TransactionIDLabel"
        TransactionIDLabel.Size = New System.Drawing.Size(76, 13)
        TransactionIDLabel.TabIndex = 52
        TransactionIDLabel.Text = "transaction ID:"
        '
        'AmountLabel1
        '
        AmountLabel1.AutoSize = True
        AmountLabel1.Location = New System.Drawing.Point(24, 0)
        AmountLabel1.Name = "AmountLabel1"
        AmountLabel1.Size = New System.Drawing.Size(45, 13)
        AmountLabel1.TabIndex = 54
        AmountLabel1.Text = "amount:"
        '
        'TransactionTypeLabel
        '
        TransactionTypeLabel.AutoSize = True
        TransactionTypeLabel.Location = New System.Drawing.Point(24, 0)
        TransactionTypeLabel.Name = "TransactionTypeLabel"
        TransactionTypeLabel.Size = New System.Drawing.Size(89, 13)
        TransactionTypeLabel.TabIndex = 56
        TransactionTypeLabel.Text = "transaction Type:"
        '
        'AccNoLabel1
        '
        AccNoLabel1.AutoSize = True
        AccNoLabel1.Location = New System.Drawing.Point(24, 0)
        AccNoLabel1.Name = "AccNoLabel1"
        AccNoLabel1.Size = New System.Drawing.Size(45, 13)
        AccNoLabel1.TabIndex = 58
        AccNoLabel1.Text = "acc No:"
        '
        'DateLabel2
        '
        DateLabel2.AutoSize = True
        DateLabel2.Location = New System.Drawing.Point(3, 5)
        DateLabel2.Name = "DateLabel2"
        DateLabel2.Size = New System.Drawing.Size(31, 13)
        DateLabel2.TabIndex = 60
        DateLabel2.Text = "date:"
        '
        'PersonOrsourceLabel
        '
        PersonOrsourceLabel.AutoSize = True
        PersonOrsourceLabel.Location = New System.Drawing.Point(24, 0)
        PersonOrsourceLabel.Name = "PersonOrsourceLabel"
        PersonOrsourceLabel.Size = New System.Drawing.Size(88, 13)
        PersonOrsourceLabel.TabIndex = 62
        PersonOrsourceLabel.Text = "person Orsource:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(3, 5)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(31, 13)
        NoteLabel.TabIndex = 64
        NoteLabel.Text = "note:"
        '
        'OpeningBalanceLabel
        '
        OpeningBalanceLabel.AutoSize = True
        OpeningBalanceLabel.Location = New System.Drawing.Point(24, 0)
        OpeningBalanceLabel.Name = "OpeningBalanceLabel"
        OpeningBalanceLabel.Size = New System.Drawing.Size(90, 13)
        OpeningBalanceLabel.TabIndex = 65
        OpeningBalanceLabel.Text = "opening Balance:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(228, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "ব্যয় প্রদান  করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(PaymentMethodLabel)
        Me.Panel1.Controls.Add(Me.PaymentMethodComboBox)
        Me.Panel1.Controls.Add(BankamountLabel)
        Me.Panel1.Controls.Add(AccNoLabel)
        Me.Panel1.Controls.Add(Me.BankamountTextBox)
        Me.Panel1.Controls.Add(Me.AccNoTextBox)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.chkEE)
        Me.Panel1.Controls.Add(Me.chkES)
        Me.Panel1.Controls.Add(Me.txtEmployeeID)
        Me.Panel1.Controls.Add(Me.txtEmployeeName)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(ExpenseCategoryLabel)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ExpenseCategoryComboBox)
        Me.Panel1.Controls.Add(ExpenseNoteLabel)
        Me.Panel1.Controls.Add(Me.ExpenseNoteTextBox)
        Me.Panel1.Controls.Add(AmountLabel)
        Me.Panel1.Controls.Add(Me.AmountTextBox)
        Me.Panel1.Controls.Add(DateLabel)
        Me.Panel1.Controls.Add(PersonNameLabel)
        Me.Panel1.Controls.Add(Me.PersonNameTextBox)
        Me.Panel1.Controls.Add(ExpenseSubCategoryLabel)
        Me.Panel1.Controls.Add(Me.ExpenseSubCategoryComboBox)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(253, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 374)
        Me.Panel1.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(440, 325)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 68
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PaymentMethodComboBox
        '
        Me.PaymentMethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "paymentMethod", True))
        Me.PaymentMethodComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PaymentMethodComboBox.FormattingEnabled = True
        Me.PaymentMethodComboBox.Items.AddRange(New Object() {"Cash", "Bank", "Both"})
        Me.PaymentMethodComboBox.Location = New System.Drawing.Point(228, 145)
        Me.PaymentMethodComboBox.Name = "PaymentMethodComboBox"
        Me.PaymentMethodComboBox.Size = New System.Drawing.Size(156, 24)
        Me.PaymentMethodComboBox.TabIndex = 55
        '
        'TblExpensesBindingSource
        '
        Me.TblExpensesBindingSource.DataMember = "tblExpenses"
        Me.TblExpensesBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BankamountTextBox
        '
        Me.BankamountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "bankamount", True))
        Me.BankamountTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.BankamountTextBox.Location = New System.Drawing.Point(228, 195)
        Me.BankamountTextBox.Name = "BankamountTextBox"
        Me.BankamountTextBox.Size = New System.Drawing.Size(156, 24)
        Me.BankamountTextBox.TabIndex = 54
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "accNo", True))
        Me.AccNoTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AccNoTextBox.Location = New System.Drawing.Point(228, 220)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(156, 24)
        Me.AccNoTextBox.TabIndex = 53
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(228, 245)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(247, 24)
        Me.DateTimePicker1.TabIndex = 52
        '
        'chkEE
        '
        Me.chkEE.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkEE.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chkEE.Location = New System.Drawing.Point(229, 61)
        Me.chkEE.Name = "chkEE"
        Me.chkEE.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chkEE.Size = New System.Drawing.Size(155, 27)
        Me.chkEE.TabIndex = 50
        Me.chkEE.Text = "কর্মচারীর খরচ"
        Me.chkEE.UseVisualStyleBackColor = False
        '
        'chkES
        '
        Me.chkES.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chkES.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chkES.Location = New System.Drawing.Point(229, 91)
        Me.chkES.Name = "chkES"
        Me.chkES.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chkES.Size = New System.Drawing.Size(155, 27)
        Me.chkES.TabIndex = 49
        Me.chkES.Text = "কর্মচারীর বেতন"
        Me.chkES.UseVisualStyleBackColor = False
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtEmployeeID.Location = New System.Drawing.Point(390, 120)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(85, 24)
        Me.txtEmployeeID.TabIndex = 48
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtEmployeeName.Location = New System.Drawing.Point(228, 120)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(156, 24)
        Me.txtEmployeeName.TabIndex = 47
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.button_circle_add_512
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(435, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 25)
        Me.Button2.TabIndex = 46
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ExpenseCategoryComboBox
        '
        Me.ExpenseCategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseCategory", True))
        Me.ExpenseCategoryComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ExpenseCategoryComboBox.FormattingEnabled = True
        Me.ExpenseCategoryComboBox.Location = New System.Drawing.Point(228, 10)
        Me.ExpenseCategoryComboBox.Name = "ExpenseCategoryComboBox"
        Me.ExpenseCategoryComboBox.Size = New System.Drawing.Size(204, 24)
        Me.ExpenseCategoryComboBox.TabIndex = 23
        '
        'ExpenseNoteTextBox
        '
        Me.ExpenseNoteTextBox.BackColor = System.Drawing.Color.White
        Me.ExpenseNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseNote", True))
        Me.ExpenseNoteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ExpenseNoteTextBox.Location = New System.Drawing.Point(228, 295)
        Me.ExpenseNoteTextBox.Name = "ExpenseNoteTextBox"
        Me.ExpenseNoteTextBox.Size = New System.Drawing.Size(247, 24)
        Me.ExpenseNoteTextBox.TabIndex = 25
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AmountTextBox.Location = New System.Drawing.Point(228, 170)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(156, 24)
        Me.AmountTextBox.TabIndex = 27
        '
        'PersonNameTextBox
        '
        Me.PersonNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "personName", True))
        Me.PersonNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PersonNameTextBox.Location = New System.Drawing.Point(228, 270)
        Me.PersonNameTextBox.Name = "PersonNameTextBox"
        Me.PersonNameTextBox.Size = New System.Drawing.Size(247, 24)
        Me.PersonNameTextBox.TabIndex = 31
        '
        'ExpenseSubCategoryComboBox
        '
        Me.ExpenseSubCategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "expenseSubCategory", True))
        Me.ExpenseSubCategoryComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ExpenseSubCategoryComboBox.FormattingEnabled = True
        Me.ExpenseSubCategoryComboBox.Location = New System.Drawing.Point(228, 35)
        Me.ExpenseSubCategoryComboBox.Name = "ExpenseSubCategoryComboBox"
        Me.ExpenseSubCategoryComboBox.Size = New System.Drawing.Size(247, 24)
        Me.ExpenseSubCategoryComboBox.TabIndex = 33
        '
        'CTextBox
        '
        Me.CTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpenseSubcategoryBindingSource, "c", True))
        Me.CTextBox.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.CTextBox.Location = New System.Drawing.Point(6, -6)
        Me.CTextBox.Name = "CTextBox"
        Me.CTextBox.Size = New System.Drawing.Size(18, 30)
        Me.CTextBox.TabIndex = 70
        '
        'TblExpenseSubcategoryBindingSource
        '
        Me.TblExpenseSubcategoryBindingSource.DataMember = "tblExpenseSubcategory"
        Me.TblExpenseSubcategoryBindingSource.DataSource = Me.DataSet
        '
        'CNameTextBox1
        '
        Me.CNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpenseSubcategoryBindingSource, "cName", True))
        Me.CNameTextBox1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.CNameTextBox1.Location = New System.Drawing.Point(6, -6)
        Me.CNameTextBox1.Name = "CNameTextBox1"
        Me.CNameTextBox1.Size = New System.Drawing.Size(18, 30)
        Me.CNameTextBox1.TabIndex = 69
        '
        'CNameTextBox
        '
        Me.CNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpenseCategoryBindingSource, "cName", True))
        Me.CNameTextBox.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.CNameTextBox.Location = New System.Drawing.Point(6, -6)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.Size = New System.Drawing.Size(18, 30)
        Me.CNameTextBox.TabIndex = 68
        '
        'TblExpenseCategoryBindingSource
        '
        Me.TblExpenseCategoryBindingSource.DataMember = "tblExpenseCategory"
        Me.TblExpenseCategoryBindingSource.DataSource = Me.DataSet
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblExpensesBindingSource, "date", True))
        Me.DateTextBox.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTextBox.Location = New System.Drawing.Point(34, 62)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(38, 40)
        Me.DateTextBox.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DateTextBox)
        Me.Panel2.Controls.Add(Me.ConfirmatoinTextBox)
        Me.Panel2.Location = New System.Drawing.Point(24, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(89, 17)
        Me.Panel2.TabIndex = 50
        '
        'ConfirmatoinTextBox
        '
        Me.ConfirmatoinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeAccountsBindingSource, "confirmatoin", True))
        Me.ConfirmatoinTextBox.Location = New System.Drawing.Point(26, 62)
        Me.ConfirmatoinTextBox.Name = "ConfirmatoinTextBox"
        Me.ConfirmatoinTextBox.Size = New System.Drawing.Size(31, 20)
        Me.ConfirmatoinTextBox.TabIndex = 51
        '
        'TblEmployeeAccountsBindingSource
        '
        Me.TblEmployeeAccountsBindingSource.DataMember = "tblEmployeeAccounts"
        Me.TblEmployeeAccountsBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "Id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(24, 0)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(45, 20)
        Me.IdTextBox1.TabIndex = 32
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataMember = "tblEmployee"
        Me.TblEmployeeBindingSource.DataSource = Me.DataSet
        '
        'EmployeeNameTextBox1
        '
        Me.EmployeeNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "employeeName", True))
        Me.EmployeeNameTextBox1.Location = New System.Drawing.Point(24, 0)
        Me.EmployeeNameTextBox1.Name = "EmployeeNameTextBox1"
        Me.EmployeeNameTextBox1.Size = New System.Drawing.Size(45, 20)
        Me.EmployeeNameTextBox1.TabIndex = 31
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeAccountsBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(24, 0)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(45, 20)
        Me.IdTextBox.TabIndex = 18
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeAccountsBindingSource, "employeeName", True))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(24, 0)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(45, 20)
        Me.EmployeeNameTextBox.TabIndex = 20
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeAccountsBindingSource, "employeeID", True))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(24, 0)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(45, 20)
        Me.EmployeeIDTextBox.TabIndex = 22
        '
        'PaymentTextBox
        '
        Me.PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeAccountsBindingSource, "payment", True))
        Me.PaymentTextBox.Location = New System.Drawing.Point(24, 0)
        Me.PaymentTextBox.Name = "PaymentTextBox"
        Me.PaymentTextBox.Size = New System.Drawing.Size(45, 20)
        Me.PaymentTextBox.TabIndex = 24
        '
        'PaidTextBox
        '
        Me.PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeAccountsBindingSource, "paid", True))
        Me.PaidTextBox.Location = New System.Drawing.Point(24, 0)
        Me.PaidTextBox.Name = "PaidTextBox"
        Me.PaidTextBox.Size = New System.Drawing.Size(45, 20)
        Me.PaidTextBox.TabIndex = 26
        '
        'DueTextBox
        '
        Me.DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeAccountsBindingSource, "due", True))
        Me.DueTextBox.Location = New System.Drawing.Point(24, 0)
        Me.DueTextBox.Name = "DueTextBox"
        Me.DueTextBox.Size = New System.Drawing.Size(45, 20)
        Me.DueTextBox.TabIndex = 28
        '
        'DateTextBox1
        '
        Me.DateTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeAccountsBindingSource, "date", True))
        Me.DateTextBox1.Location = New System.Drawing.Point(24, 0)
        Me.DateTextBox1.Name = "DateTextBox1"
        Me.DateTextBox1.Size = New System.Drawing.Size(45, 20)
        Me.DateTextBox1.TabIndex = 30
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
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "নতুন ব্যয়/প্রদান"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblExpensesTableAdapter
        '
        Me.TblExpensesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblEmployeeAccountsTableAdapter = Me.TblEmployeeAccountsTableAdapter
        Me.TableAdapterManager.tblEmployeeTableAdapter = Me.TblEmployeeTableAdapter
        Me.TableAdapterManager.tblExpenseCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblExpenseReportTableAdapter = Nothing
        Me.TableAdapterManager.tblExpensesTableAdapter = Me.TblExpensesTableAdapter
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
        'TblEmployeeAccountsTableAdapter
        '
        Me.TblEmployeeAccountsTableAdapter.ClearBeforeFill = True
        '
        'TblEmployeeTableAdapter
        '
        Me.TblEmployeeTableAdapter.ClearBeforeFill = True
        '
        'TblTransactionTableAdapter
        '
        Me.TblTransactionTableAdapter.ClearBeforeFill = True
        '
        'TblTransactionBindingSource
        '
        Me.TblTransactionBindingSource.DataMember = "tblTransaction"
        Me.TblTransactionBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox2
        '
        Me.IdTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "Id", True))
        Me.IdTextBox2.Location = New System.Drawing.Point(24, 0)
        Me.IdTextBox2.Name = "IdTextBox2"
        Me.IdTextBox2.Size = New System.Drawing.Size(73, 20)
        Me.IdTextBox2.TabIndex = 51
        '
        'TransactionIDTextBox
        '
        Me.TransactionIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "transactionID", True))
        Me.TransactionIDTextBox.Location = New System.Drawing.Point(24, 0)
        Me.TransactionIDTextBox.Name = "TransactionIDTextBox"
        Me.TransactionIDTextBox.Size = New System.Drawing.Size(73, 20)
        Me.TransactionIDTextBox.TabIndex = 53
        '
        'AmountTextBox1
        '
        Me.AmountTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "amount", True))
        Me.AmountTextBox1.Location = New System.Drawing.Point(24, 0)
        Me.AmountTextBox1.Name = "AmountTextBox1"
        Me.AmountTextBox1.Size = New System.Drawing.Size(73, 20)
        Me.AmountTextBox1.TabIndex = 55
        '
        'TransactionTypeTextBox
        '
        Me.TransactionTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "transactionType", True))
        Me.TransactionTypeTextBox.Location = New System.Drawing.Point(24, 0)
        Me.TransactionTypeTextBox.Name = "TransactionTypeTextBox"
        Me.TransactionTypeTextBox.Size = New System.Drawing.Size(73, 20)
        Me.TransactionTypeTextBox.TabIndex = 57
        '
        'AccNoTextBox1
        '
        Me.AccNoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "accNo", True))
        Me.AccNoTextBox1.Location = New System.Drawing.Point(24, 0)
        Me.AccNoTextBox1.Name = "AccNoTextBox1"
        Me.AccNoTextBox1.Size = New System.Drawing.Size(73, 20)
        Me.AccNoTextBox1.TabIndex = 59
        '
        'DateTextBox2
        '
        Me.DateTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "date", True))
        Me.DateTextBox2.Location = New System.Drawing.Point(24, 0)
        Me.DateTextBox2.Name = "DateTextBox2"
        Me.DateTextBox2.Size = New System.Drawing.Size(73, 20)
        Me.DateTextBox2.TabIndex = 61
        '
        'PersonOrsourceTextBox
        '
        Me.PersonOrsourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "personOrsource", True))
        Me.PersonOrsourceTextBox.Location = New System.Drawing.Point(24, 0)
        Me.PersonOrsourceTextBox.Name = "PersonOrsourceTextBox"
        Me.PersonOrsourceTextBox.Size = New System.Drawing.Size(73, 20)
        Me.PersonOrsourceTextBox.TabIndex = 63
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(24, 0)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(73, 20)
        Me.NoteTextBox.TabIndex = 65
        '
        'TblBankAccountsBindingSource
        '
        Me.TblBankAccountsBindingSource.DataMember = "tblBankAccounts"
        Me.TblBankAccountsBindingSource.DataSource = Me.DataSet
        '
        'OpeningBalanceTextBox
        '
        Me.OpeningBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "openingBalance", True))
        Me.OpeningBalanceTextBox.Location = New System.Drawing.Point(24, 0)
        Me.OpeningBalanceTextBox.Name = "OpeningBalanceTextBox"
        Me.OpeningBalanceTextBox.Size = New System.Drawing.Size(73, 20)
        Me.OpeningBalanceTextBox.TabIndex = 66
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(IdLabel2)
        Me.Panel3.Controls.Add(IdLabel)
        Me.Panel3.Controls.Add(DueLabel)
        Me.Panel3.Controls.Add(DateLabel1)
        Me.Panel3.Controls.Add(IdLabel1)
        Me.Panel3.Controls.Add(NoteLabel)
        Me.Panel3.Controls.Add(DateLabel2)
        Me.Panel3.Location = New System.Drawing.Point(24, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(96, 16)
        Me.Panel3.TabIndex = 67
        '
        'TblExpenseCategoryTableAdapter
        '
        Me.TblExpenseCategoryTableAdapter.ClearBeforeFill = True
        '
        'TblExpenseSubcategoryTableAdapter
        '
        Me.TblExpenseSubcategoryTableAdapter.ClearBeforeFill = True
        '
        'newExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(OpeningBalanceLabel)
        Me.Controls.Add(Me.OpeningBalanceTextBox)
        Me.Controls.Add(Me.IdTextBox2)
        Me.Controls.Add(TransactionIDLabel)
        Me.Controls.Add(Me.TransactionIDTextBox)
        Me.Controls.Add(AmountLabel1)
        Me.Controls.Add(Me.AmountTextBox1)
        Me.Controls.Add(TransactionTypeLabel)
        Me.Controls.Add(Me.TransactionTypeTextBox)
        Me.Controls.Add(AccNoLabel1)
        Me.Controls.Add(Me.AccNoTextBox1)
        Me.Controls.Add(Me.DateTextBox2)
        Me.Controls.Add(PersonOrsourceLabel)
        Me.Controls.Add(Me.PersonOrsourceTextBox)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(Me.DateTextBox1)
        Me.Controls.Add(EmployeeNameLabel1)
        Me.Controls.Add(Me.DueTextBox)
        Me.Controls.Add(Me.EmployeeNameTextBox1)
        Me.Controls.Add(Me.PaidTextBox)
        Me.Controls.Add(Me.PaymentTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(PaymentLabel)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(EmployeeNameLabel)
        Me.Controls.Add(EmployeeIDLabel)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.Controls.Add(PaidLabel)
        Me.Controls.Add(Me.CTextBox)
        Me.Controls.Add(Me.CNameTextBox1)
        Me.Controls.Add(Me.CNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newExpense"
        Me.Text = "newExpense"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpenseSubcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpenseCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblEmployeeAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblExpensesBindingSource As BindingSource
    Friend WithEvents TblExpensesTableAdapter As dataSetTableAdapters.tblExpensesTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExpenseNoteTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents PersonNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ExpenseCategoryComboBox As ComboBox
    Friend WithEvents ExpenseSubCategoryComboBox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TblEmployeeAccountsBindingSource As BindingSource
    Friend WithEvents TblEmployeeAccountsTableAdapter As dataSetTableAdapters.tblEmployeeAccountsTableAdapter
    Friend WithEvents chkES As CheckBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents PaymentTextBox As TextBox
    Friend WithEvents PaidTextBox As TextBox
    Friend WithEvents DueTextBox As TextBox
    Friend WithEvents DateTextBox1 As TextBox
    Friend WithEvents TblEmployeeBindingSource As BindingSource
    Friend WithEvents TblEmployeeTableAdapter As dataSetTableAdapters.tblEmployeeTableAdapter
    Friend WithEvents EmployeeNameTextBox1 As TextBox
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkEE As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ConfirmatoinTextBox As TextBox
    Friend WithEvents PaymentMethodComboBox As ComboBox
    Friend WithEvents BankamountTextBox As TextBox
    Friend WithEvents AccNoTextBox As TextBox
    Friend WithEvents TblTransactionBindingSource As BindingSource
    Friend WithEvents TblTransactionTableAdapter As dataSetTableAdapters.tblTransactionTableAdapter
    Friend WithEvents IdTextBox2 As TextBox
    Friend WithEvents TransactionIDTextBox As TextBox
    Friend WithEvents AmountTextBox1 As TextBox
    Friend WithEvents TransactionTypeTextBox As TextBox
    Friend WithEvents AccNoTextBox1 As TextBox
    Friend WithEvents DateTextBox2 As TextBox
    Friend WithEvents PersonOrsourceTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents TblBankAccountsBindingSource As BindingSource
    Friend WithEvents TblBankAccountsTableAdapter As dataSetTableAdapters.tblBankAccountsTableAdapter
    Friend WithEvents OpeningBalanceTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TblExpenseCategoryBindingSource As BindingSource
    Friend WithEvents TblExpenseCategoryTableAdapter As dataSetTableAdapters.tblExpenseCategoryTableAdapter
    Friend WithEvents CNameTextBox As TextBox
    Friend WithEvents TblExpenseSubcategoryBindingSource As BindingSource
    Friend WithEvents TblExpenseSubcategoryTableAdapter As dataSetTableAdapters.tblExpenseSubcategoryTableAdapter
    Friend WithEvents CNameTextBox1 As TextBox
    Friend WithEvents CTextBox As TextBox
    Friend WithEvents Button3 As Button
End Class
