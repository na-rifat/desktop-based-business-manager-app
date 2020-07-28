<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newIncome
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
        Dim IncomeCategoryLabel As System.Windows.Forms.Label
        Dim IncomeNoteLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim IncomeSubcategoryLabel As System.Windows.Forms.Label
        Dim PaymentmethodLabel As System.Windows.Forms.Label
        Dim BankamountLabel As System.Windows.Forms.Label
        Dim AccNoLabel As System.Windows.Forms.Label
        Dim OpeningBalanceLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim TransactionIDLabel As System.Windows.Forms.Label
        Dim AmountLabel1 As System.Windows.Forms.Label
        Dim TransactionTypeLabel As System.Windows.Forms.Label
        Dim AccNoLabel1 As System.Windows.Forms.Label
        Dim DateLabel1 As System.Windows.Forms.Label
        Dim PersonOrsourceLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.datt = New System.Windows.Forms.DateTimePicker()
        Me.PaymentmethodComboBox = New System.Windows.Forms.ComboBox()
        Me.TblIncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.BankamountTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IncomeCategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.IncomeNoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeSubcategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblIncomeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblIncomeTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblBankAccountsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblBankAccountsTableAdapter()
        Me.TblIncomeCategoryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblIncomeCategoryTableAdapter()
        Me.TblIncomeSubcategoryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblIncomeSubcategoryTableAdapter()
        Me.TblTransactionTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblTransactionTableAdapter()
        Me.TblBankAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpeningBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.TblTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionIDTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox1 = New System.Windows.Forms.TextBox()
        Me.TransactionTypeTextBox = New System.Windows.Forms.TextBox()
        Me.AccNoTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTextBox1 = New System.Windows.Forms.TextBox()
        Me.PersonOrsourceTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TblIncomeCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblIncomeSubcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.CTextBox = New System.Windows.Forms.TextBox()
        IncomeCategoryLabel = New System.Windows.Forms.Label()
        IncomeNoteLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        IncomeSubcategoryLabel = New System.Windows.Forms.Label()
        PaymentmethodLabel = New System.Windows.Forms.Label()
        BankamountLabel = New System.Windows.Forms.Label()
        AccNoLabel = New System.Windows.Forms.Label()
        OpeningBalanceLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        TransactionIDLabel = New System.Windows.Forms.Label()
        AmountLabel1 = New System.Windows.Forms.Label()
        TransactionTypeLabel = New System.Windows.Forms.Label()
        AccNoLabel1 = New System.Windows.Forms.Label()
        DateLabel1 = New System.Windows.Forms.Label()
        PersonOrsourceLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TblIncomeCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncomeSubcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IncomeCategoryLabel
        '
        IncomeCategoryLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        IncomeCategoryLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        IncomeCategoryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        IncomeCategoryLabel.Location = New System.Drawing.Point(3, 7)
        IncomeCategoryLabel.Name = "IncomeCategoryLabel"
        IncomeCategoryLabel.Size = New System.Drawing.Size(179, 24)
        IncomeCategoryLabel.TabIndex = 20
        IncomeCategoryLabel.Text = "আয়ের ধরনঃ"
        IncomeCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IncomeNoteLabel
        '
        IncomeNoteLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        IncomeNoteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        IncomeNoteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        IncomeNoteLabel.Location = New System.Drawing.Point(3, 189)
        IncomeNoteLabel.Name = "IncomeNoteLabel"
        IncomeNoteLabel.Size = New System.Drawing.Size(179, 24)
        IncomeNoteLabel.TabIndex = 22
        IncomeNoteLabel.Text = "মন্তব্যঃ"
        IncomeNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AmountLabel
        '
        AmountLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        AmountLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AmountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AmountLabel.Location = New System.Drawing.Point(3, 85)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(179, 24)
        AmountLabel.TabIndex = 24
        AmountLabel.Text = "ক্যাশে আদায়ঃ"
        AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        DateLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DateLabel.Location = New System.Drawing.Point(3, 163)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(179, 24)
        DateLabel.TabIndex = 26
        DateLabel.Text = "তারিখঃ"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IncomeSubcategoryLabel
        '
        IncomeSubcategoryLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        IncomeSubcategoryLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        IncomeSubcategoryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        IncomeSubcategoryLabel.Location = New System.Drawing.Point(3, 33)
        IncomeSubcategoryLabel.Name = "IncomeSubcategoryLabel"
        IncomeSubcategoryLabel.Size = New System.Drawing.Size(179, 24)
        IncomeSubcategoryLabel.TabIndex = 28
        IncomeSubcategoryLabel.Text = "আয়ের সহকারী ধরন"
        IncomeSubcategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaymentmethodLabel
        '
        PaymentmethodLabel.BackColor = System.Drawing.Color.Black
        PaymentmethodLabel.CausesValidation = False
        PaymentmethodLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PaymentmethodLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PaymentmethodLabel.Location = New System.Drawing.Point(3, 59)
        PaymentmethodLabel.Name = "PaymentmethodLabel"
        PaymentmethodLabel.Size = New System.Drawing.Size(179, 24)
        PaymentmethodLabel.TabIndex = 46
        PaymentmethodLabel.Text = "আদায়ের পদ্ধতিঃ"
        PaymentmethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BankamountLabel
        '
        BankamountLabel.BackColor = System.Drawing.Color.Black
        BankamountLabel.CausesValidation = False
        BankamountLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        BankamountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        BankamountLabel.Location = New System.Drawing.Point(3, 111)
        BankamountLabel.Name = "BankamountLabel"
        BankamountLabel.Size = New System.Drawing.Size(179, 24)
        BankamountLabel.TabIndex = 47
        BankamountLabel.Text = "ব্যাংকে আদায়ঃ"
        BankamountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AccNoLabel
        '
        AccNoLabel.BackColor = System.Drawing.Color.Black
        AccNoLabel.CausesValidation = False
        AccNoLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AccNoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AccNoLabel.Location = New System.Drawing.Point(3, 137)
        AccNoLabel.Name = "AccNoLabel"
        AccNoLabel.Size = New System.Drawing.Size(179, 24)
        AccNoLabel.TabIndex = 48
        AccNoLabel.Text = "ব্যাংক একাউন্ট নাম্বারঃ"
        AccNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpeningBalanceLabel
        '
        OpeningBalanceLabel.AutoSize = True
        OpeningBalanceLabel.Location = New System.Drawing.Point(-4, 3)
        OpeningBalanceLabel.Name = "OpeningBalanceLabel"
        OpeningBalanceLabel.Size = New System.Drawing.Size(90, 13)
        OpeningBalanceLabel.TabIndex = 17
        OpeningBalanceLabel.Text = "opening Balance:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(23, 7)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 18
        IdLabel.Text = "Id:"
        '
        'TransactionIDLabel
        '
        TransactionIDLabel.AutoSize = True
        TransactionIDLabel.Location = New System.Drawing.Point(-3, 3)
        TransactionIDLabel.Name = "TransactionIDLabel"
        TransactionIDLabel.Size = New System.Drawing.Size(76, 13)
        TransactionIDLabel.TabIndex = 20
        TransactionIDLabel.Text = "transaction ID:"
        '
        'AmountLabel1
        '
        AmountLabel1.AutoSize = True
        AmountLabel1.Location = New System.Drawing.Point(-3, 3)
        AmountLabel1.Name = "AmountLabel1"
        AmountLabel1.Size = New System.Drawing.Size(45, 13)
        AmountLabel1.TabIndex = 22
        AmountLabel1.Text = "amount:"
        '
        'TransactionTypeLabel
        '
        TransactionTypeLabel.AutoSize = True
        TransactionTypeLabel.Location = New System.Drawing.Point(-3, 3)
        TransactionTypeLabel.Name = "TransactionTypeLabel"
        TransactionTypeLabel.Size = New System.Drawing.Size(89, 13)
        TransactionTypeLabel.TabIndex = 24
        TransactionTypeLabel.Text = "transaction Type:"
        '
        'AccNoLabel1
        '
        AccNoLabel1.AutoSize = True
        AccNoLabel1.Location = New System.Drawing.Point(-3, 3)
        AccNoLabel1.Name = "AccNoLabel1"
        AccNoLabel1.Size = New System.Drawing.Size(45, 13)
        AccNoLabel1.TabIndex = 26
        AccNoLabel1.Text = "acc No:"
        '
        'DateLabel1
        '
        DateLabel1.AutoSize = True
        DateLabel1.Location = New System.Drawing.Point(-3, 3)
        DateLabel1.Name = "DateLabel1"
        DateLabel1.Size = New System.Drawing.Size(31, 13)
        DateLabel1.TabIndex = 28
        DateLabel1.Text = "date:"
        '
        'PersonOrsourceLabel
        '
        PersonOrsourceLabel.AutoSize = True
        PersonOrsourceLabel.Location = New System.Drawing.Point(-3, 3)
        PersonOrsourceLabel.Name = "PersonOrsourceLabel"
        PersonOrsourceLabel.Size = New System.Drawing.Size(88, 13)
        PersonOrsourceLabel.TabIndex = 30
        PersonOrsourceLabel.Text = "person Orsource:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(-3, 3)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(31, 13)
        NoteLabel.TabIndex = 32
        NoteLabel.Text = "note:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(188, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "যুক্ত করুন"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.datt)
        Me.Panel1.Controls.Add(AccNoLabel)
        Me.Panel1.Controls.Add(Me.PaymentmethodComboBox)
        Me.Panel1.Controls.Add(Me.BankamountTextBox)
        Me.Panel1.Controls.Add(BankamountLabel)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.IncomeCategoryComboBox)
        Me.Panel1.Controls.Add(DateLabel)
        Me.Panel1.Controls.Add(Me.IncomeNoteTextBox)
        Me.Panel1.Controls.Add(PaymentmethodLabel)
        Me.Panel1.Controls.Add(Me.AmountTextBox)
        Me.Panel1.Controls.Add(Me.IncomeSubcategoryComboBox)
        Me.Panel1.Controls.Add(IncomeNoteLabel)
        Me.Panel1.Controls.Add(Me.AccNoTextBox)
        Me.Panel1.Controls.Add(IncomeSubcategoryLabel)
        Me.Panel1.Controls.Add(IncomeCategoryLabel)
        Me.Panel1.Controls.Add(AmountLabel)
        Me.Panel1.Location = New System.Drawing.Point(269, 196)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 259)
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
        Me.Button3.Location = New System.Drawing.Point(391, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 50
        Me.Button3.UseVisualStyleBackColor = False
        '
        'datt
        '
        Me.datt.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.datt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datt.Location = New System.Drawing.Point(188, 160)
        Me.datt.Name = "datt"
        Me.datt.Size = New System.Drawing.Size(238, 24)
        Me.datt.TabIndex = 18
        '
        'PaymentmethodComboBox
        '
        Me.PaymentmethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "paymentmethod", True))
        Me.PaymentmethodComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PaymentmethodComboBox.FormattingEnabled = True
        Me.PaymentmethodComboBox.Items.AddRange(New Object() {"Cash", "Bank", "Both"})
        Me.PaymentmethodComboBox.Location = New System.Drawing.Point(188, 60)
        Me.PaymentmethodComboBox.Name = "PaymentmethodComboBox"
        Me.PaymentmethodComboBox.Size = New System.Drawing.Size(238, 24)
        Me.PaymentmethodComboBox.TabIndex = 47
        '
        'TblIncomeBindingSource
        '
        Me.TblIncomeBindingSource.DataMember = "tblIncome"
        Me.TblIncomeBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BankamountTextBox
        '
        Me.BankamountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "bankamount", True))
        Me.BankamountTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.BankamountTextBox.Location = New System.Drawing.Point(188, 110)
        Me.BankamountTextBox.Name = "BankamountTextBox"
        Me.BankamountTextBox.Size = New System.Drawing.Size(238, 24)
        Me.BankamountTextBox.TabIndex = 48
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.button_circle_add_512
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(432, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 24)
        Me.Button1.TabIndex = 46
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IncomeCategoryComboBox
        '
        Me.IncomeCategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeCategory", True))
        Me.IncomeCategoryComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.IncomeCategoryComboBox.FormattingEnabled = True
        Me.IncomeCategoryComboBox.Location = New System.Drawing.Point(188, 10)
        Me.IncomeCategoryComboBox.Name = "IncomeCategoryComboBox"
        Me.IncomeCategoryComboBox.Size = New System.Drawing.Size(238, 24)
        Me.IncomeCategoryComboBox.TabIndex = 21
        '
        'IncomeNoteTextBox
        '
        Me.IncomeNoteTextBox.BackColor = System.Drawing.Color.White
        Me.IncomeNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeNote", True))
        Me.IncomeNoteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.IncomeNoteTextBox.Location = New System.Drawing.Point(188, 185)
        Me.IncomeNoteTextBox.Name = "IncomeNoteTextBox"
        Me.IncomeNoteTextBox.Size = New System.Drawing.Size(238, 24)
        Me.IncomeNoteTextBox.TabIndex = 23
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AmountTextBox.Location = New System.Drawing.Point(188, 85)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(238, 24)
        Me.AmountTextBox.TabIndex = 25
        '
        'IncomeSubcategoryComboBox
        '
        Me.IncomeSubcategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "incomeSubcategory", True))
        Me.IncomeSubcategoryComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.IncomeSubcategoryComboBox.FormattingEnabled = True
        Me.IncomeSubcategoryComboBox.Location = New System.Drawing.Point(188, 35)
        Me.IncomeSubcategoryComboBox.Name = "IncomeSubcategoryComboBox"
        Me.IncomeSubcategoryComboBox.Size = New System.Drawing.Size(238, 24)
        Me.IncomeSubcategoryComboBox.TabIndex = 29
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "accNo", True))
        Me.AccNoTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AccNoTextBox.Location = New System.Drawing.Point(188, 135)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(238, 24)
        Me.AccNoTextBox.TabIndex = 49
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeBindingSource, "date", True))
        Me.DateTextBox.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.DateTextBox.Location = New System.Drawing.Point(12, -12)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(58, 33)
        Me.DateTextBox.TabIndex = 27
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
        Me.Label1.Text = "নতুন আয়/প্রাপ্তি"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblIncomeTableAdapter
        '
        Me.TblIncomeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblExpensesTableAdapter = Nothing
        Me.TableAdapterManager.tblExpenseSubcategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblFridgesTableAdapter = Nothing
        Me.TableAdapterManager.tblIncomeCategoryTableAdapter = Me.TblIncomeCategoryTableAdapter
        Me.TableAdapterManager.tblIncomeSubcategoryTableAdapter = Me.TblIncomeSubcategoryTableAdapter
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
        'TblIncomeCategoryTableAdapter
        '
        Me.TblIncomeCategoryTableAdapter.ClearBeforeFill = True
        '
        'TblIncomeSubcategoryTableAdapter
        '
        Me.TblIncomeSubcategoryTableAdapter.ClearBeforeFill = True
        '
        'TblTransactionTableAdapter
        '
        Me.TblTransactionTableAdapter.ClearBeforeFill = True
        '
        'TblBankAccountsBindingSource
        '
        Me.TblBankAccountsBindingSource.DataMember = "tblBankAccounts"
        Me.TblBankAccountsBindingSource.DataSource = Me.DataSet
        '
        'OpeningBalanceTextBox
        '
        Me.OpeningBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBankAccountsBindingSource, "openingBalance", True))
        Me.OpeningBalanceTextBox.Location = New System.Drawing.Point(0, 0)
        Me.OpeningBalanceTextBox.Name = "OpeningBalanceTextBox"
        Me.OpeningBalanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OpeningBalanceTextBox.TabIndex = 18
        '
        'TblTransactionBindingSource
        '
        Me.TblTransactionBindingSource.DataMember = "tblTransaction"
        Me.TblTransactionBindingSource.DataSource = Me.DataSet
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(9, 0)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 19
        '
        'TransactionIDTextBox
        '
        Me.TransactionIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "transactionID", True))
        Me.TransactionIDTextBox.Location = New System.Drawing.Point(0, 0)
        Me.TransactionIDTextBox.Name = "TransactionIDTextBox"
        Me.TransactionIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TransactionIDTextBox.TabIndex = 21
        '
        'AmountTextBox1
        '
        Me.AmountTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "amount", True))
        Me.AmountTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.AmountTextBox1.Name = "AmountTextBox1"
        Me.AmountTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox1.TabIndex = 23
        '
        'TransactionTypeTextBox
        '
        Me.TransactionTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "transactionType", True))
        Me.TransactionTypeTextBox.Location = New System.Drawing.Point(0, 0)
        Me.TransactionTypeTextBox.Name = "TransactionTypeTextBox"
        Me.TransactionTypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TransactionTypeTextBox.TabIndex = 25
        '
        'AccNoTextBox1
        '
        Me.AccNoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "accNo", True))
        Me.AccNoTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.AccNoTextBox1.Name = "AccNoTextBox1"
        Me.AccNoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.AccNoTextBox1.TabIndex = 27
        '
        'DateTextBox1
        '
        Me.DateTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "date", True))
        Me.DateTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.DateTextBox1.Name = "DateTextBox1"
        Me.DateTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.DateTextBox1.TabIndex = 29
        '
        'PersonOrsourceTextBox
        '
        Me.PersonOrsourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "personOrsource", True))
        Me.PersonOrsourceTextBox.Location = New System.Drawing.Point(0, 0)
        Me.PersonOrsourceTextBox.Name = "PersonOrsourceTextBox"
        Me.PersonOrsourceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PersonOrsourceTextBox.TabIndex = 31
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTransactionBindingSource, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(0, 0)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NoteTextBox.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.IdTextBox)
        Me.Panel2.Controls.Add(Me.OpeningBalanceTextBox)
        Me.Panel2.Controls.Add(OpeningBalanceLabel)
        Me.Panel2.Controls.Add(IdLabel)
        Me.Panel2.Controls.Add(Me.NoteTextBox)
        Me.Panel2.Controls.Add(NoteLabel)
        Me.Panel2.Controls.Add(TransactionIDLabel)
        Me.Panel2.Controls.Add(Me.PersonOrsourceTextBox)
        Me.Panel2.Controls.Add(PersonOrsourceLabel)
        Me.Panel2.Controls.Add(Me.TransactionIDTextBox)
        Me.Panel2.Controls.Add(Me.DateTextBox1)
        Me.Panel2.Controls.Add(AmountLabel1)
        Me.Panel2.Controls.Add(DateLabel1)
        Me.Panel2.Controls.Add(Me.AmountTextBox1)
        Me.Panel2.Controls.Add(Me.AccNoTextBox1)
        Me.Panel2.Controls.Add(AccNoLabel1)
        Me.Panel2.Controls.Add(TransactionTypeLabel)
        Me.Panel2.Controls.Add(Me.TransactionTypeTextBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(112, 22)
        Me.Panel2.TabIndex = 34
        '
        'TblIncomeCategoryBindingSource
        '
        Me.TblIncomeCategoryBindingSource.DataMember = "tblIncomeCategory"
        Me.TblIncomeCategoryBindingSource.DataSource = Me.DataSet
        '
        'CNameTextBox
        '
        Me.CNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeCategoryBindingSource, "cName", True))
        Me.CNameTextBox.Location = New System.Drawing.Point(12, -3)
        Me.CNameTextBox.Name = "CNameTextBox"
        Me.CNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CNameTextBox.TabIndex = 35
        '
        'TblIncomeSubcategoryBindingSource
        '
        Me.TblIncomeSubcategoryBindingSource.DataMember = "tblIncomeSubcategory"
        Me.TblIncomeSubcategoryBindingSource.DataSource = Me.DataSet
        '
        'CNameTextBox1
        '
        Me.CNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeSubcategoryBindingSource, "cName", True))
        Me.CNameTextBox1.Location = New System.Drawing.Point(12, 0)
        Me.CNameTextBox1.Name = "CNameTextBox1"
        Me.CNameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CNameTextBox1.TabIndex = 36
        '
        'CTextBox
        '
        Me.CTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblIncomeSubcategoryBindingSource, "c", True))
        Me.CTextBox.Location = New System.Drawing.Point(12, -3)
        Me.CTextBox.Name = "CTextBox"
        Me.CTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CTextBox.TabIndex = 37
        '
        'newIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CTextBox)
        Me.Controls.Add(Me.CNameTextBox)
        Me.Controls.Add(Me.CNameTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newIncome"
        Me.Text = "newIncome"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblIncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBankAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblIncomeCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncomeSubcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblIncomeBindingSource As BindingSource
    Friend WithEvents TblIncomeTableAdapter As dataSetTableAdapters.tblIncomeTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IncomeCategoryComboBox As ComboBox
    Friend WithEvents IncomeNoteTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents IncomeSubcategoryComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents AccNoTextBox As TextBox
    Friend WithEvents BankamountTextBox As TextBox
    Friend WithEvents PaymentmethodComboBox As ComboBox
    Friend WithEvents datt As DateTimePicker
    Friend WithEvents TblBankAccountsBindingSource As BindingSource
    Friend WithEvents TblBankAccountsTableAdapter As dataSetTableAdapters.tblBankAccountsTableAdapter
    Friend WithEvents OpeningBalanceTextBox As TextBox
    Friend WithEvents TblTransactionBindingSource As BindingSource
    Friend WithEvents TblTransactionTableAdapter As dataSetTableAdapters.tblTransactionTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents TransactionIDTextBox As TextBox
    Friend WithEvents AmountTextBox1 As TextBox
    Friend WithEvents TransactionTypeTextBox As TextBox
    Friend WithEvents AccNoTextBox1 As TextBox
    Friend WithEvents DateTextBox1 As TextBox
    Friend WithEvents PersonOrsourceTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TblIncomeCategoryBindingSource As BindingSource
    Friend WithEvents TblIncomeCategoryTableAdapter As dataSetTableAdapters.tblIncomeCategoryTableAdapter
    Friend WithEvents CNameTextBox As TextBox
    Friend WithEvents TblIncomeSubcategoryBindingSource As BindingSource
    Friend WithEvents TblIncomeSubcategoryTableAdapter As dataSetTableAdapters.tblIncomeSubcategoryTableAdapter
    Friend WithEvents CNameTextBox1 As TextBox
    Friend WithEvents CTextBox As TextBox
    Friend WithEvents Button3 As Button
End Class
