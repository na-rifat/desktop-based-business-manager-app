<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim AlertQuantityLabel As System.Windows.Forms.Label
        Dim AvailableLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.prg = New CircularProgressBar.CircularProgressBar()
        Me.lblSold = New System.Windows.Forms.Label()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tbl_sales_targetDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_sales_targetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblInvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grandTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_profit = New System.Windows.Forms.Label()
        Me.AvailableTextBox = New System.Windows.Forms.TextBox()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlertQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_expense = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_income = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_totalsale = New System.Windows.Forms.Label()
        Me.TblNotesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblNotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtn = New System.Windows.Forms.DateTimePicker()
        Me.TblProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyTextBox = New System.Windows.Forms.TextBox()
        Me.TblCompanySettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInvoiceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblInvoiceTableAdapter()
        Me.TblNotesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblNotesTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblProductsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblProductsTableAdapter()
        Me.TblCompanySettingsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblCompanySettingsTableAdapter()
        Me.Tbl_sales_targetTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tbl_sales_targetTableAdapter()
        AlertQuantityLabel = New System.Windows.Forms.Label()
        AvailableLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_sales_targetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_sales_targetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.TblNotesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCompanySettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlertQuantityLabel
        '
        AlertQuantityLabel.AutoSize = True
        AlertQuantityLabel.Location = New System.Drawing.Point(-94, 72)
        AlertQuantityLabel.Name = "AlertQuantityLabel"
        AlertQuantityLabel.Size = New System.Drawing.Size(72, 13)
        AlertQuantityLabel.TabIndex = 22
        AlertQuantityLabel.Text = "alert Quantity:"
        '
        'AvailableLabel
        '
        AvailableLabel.AutoSize = True
        AvailableLabel.Location = New System.Drawing.Point(-74, 56)
        AvailableLabel.Name = "AvailableLabel"
        AvailableLabel.Size = New System.Drawing.Size(52, 13)
        AvailableLabel.TabIndex = 23
        AvailableLabel.Text = "available:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TblInvoiceDataGridView)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TblNotesDataGridView)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.dtn)
        Me.Panel1.Controls.Add(Me.TblProductsDataGridView)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 680)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(503, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(4)
        Me.Label2.Size = New System.Drawing.Size(484, 34)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "সাম্প্রতিক বিক্রি"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(503, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(4)
        Me.Label1.Size = New System.Drawing.Size(484, 34)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "লো-স্টক প্রোডাক্ট"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Button4.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources._13615
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(361, 524)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 136)
        Me.Button4.TabIndex = 64
        Me.Button4.Tag = "Current status"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.turn_notifications_on_button
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(361, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 136)
        Me.Button3.TabIndex = 63
        Me.Button3.Tag = "Current status"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.prg)
        Me.GroupBox1.Controls.Add(Me.lblSold)
        Me.GroupBox1.Controls.Add(Me.lblTarget)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Tbl_sales_targetDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 354)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 308)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "মাসিক বিক্রির টার্গেট"
        '
        'prg
        '
        Me.prg.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.prg.AnimationSpeed = 500
        Me.prg.BackColor = System.Drawing.Color.Transparent
        Me.prg.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.prg.ForeColor = System.Drawing.Color.Black
        Me.prg.InnerColor = System.Drawing.Color.White
        Me.prg.InnerMargin = 2
        Me.prg.InnerWidth = -1
        Me.prg.Location = New System.Drawing.Point(70, 98)
        Me.prg.MarqueeAnimationSpeed = 2000
        Me.prg.Name = "prg"
        Me.prg.OuterColor = System.Drawing.Color.Red
        Me.prg.OuterMargin = -26
        Me.prg.OuterWidth = 26
        Me.prg.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prg.ProgressWidth = 30
        Me.prg.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.prg.Size = New System.Drawing.Size(207, 207)
        Me.prg.StartAngle = 270
        Me.prg.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.prg.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.prg.SubscriptText = ""
        Me.prg.SuperscriptColor = System.Drawing.Color.Red
        Me.prg.SuperscriptMargin = New System.Windows.Forms.Padding(-50, 0, 0, 0)
        Me.prg.SuperscriptText = "Achivement"
        Me.prg.TabIndex = 31
        Me.prg.Text = "100%"
        Me.prg.TextMargin = New System.Windows.Forms.Padding(20, 10, 0, 0)
        Me.prg.Value = 68
        '
        'lblSold
        '
        Me.lblSold.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSold.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblSold.ForeColor = System.Drawing.Color.Honeydew
        Me.lblSold.Location = New System.Drawing.Point(114, 57)
        Me.lblSold.Name = "lblSold"
        Me.lblSold.Padding = New System.Windows.Forms.Padding(6)
        Me.lblSold.Size = New System.Drawing.Size(226, 29)
        Me.lblSold.TabIndex = 30
        Me.lblSold.Text = "0000"
        Me.lblSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTarget
        '
        Me.lblTarget.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTarget.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lblTarget.ForeColor = System.Drawing.Color.Honeydew
        Me.lblTarget.Location = New System.Drawing.Point(114, 25)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Padding = New System.Windows.Forms.Padding(6)
        Me.lblTarget.Size = New System.Drawing.Size(226, 29)
        Me.lblTarget.TabIndex = 29
        Me.lblTarget.Text = "0000"
        Me.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Honeydew
        Me.Label4.Location = New System.Drawing.Point(7, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(6)
        Me.Label4.Size = New System.Drawing.Size(101, 29)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Completed:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Honeydew
        Me.Label3.Location = New System.Drawing.Point(7, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(6)
        Me.Label3.Size = New System.Drawing.Size(101, 29)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Target:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbl_sales_targetDataGridView
        '
        Me.Tbl_sales_targetDataGridView.AutoGenerateColumns = False
        Me.Tbl_sales_targetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_sales_targetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.Tbl_sales_targetDataGridView.DataSource = Me.Tbl_sales_targetBindingSource
        Me.Tbl_sales_targetDataGridView.Location = New System.Drawing.Point(74, 103)
        Me.Tbl_sales_targetDataGridView.Name = "Tbl_sales_targetDataGridView"
        Me.Tbl_sales_targetDataGridView.Size = New System.Drawing.Size(50, 37)
        Me.Tbl_sales_targetDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "january"
        Me.DataGridViewTextBoxColumn6.HeaderText = "january"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "february"
        Me.DataGridViewTextBoxColumn7.HeaderText = "february"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "march"
        Me.DataGridViewTextBoxColumn8.HeaderText = "march"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "april"
        Me.DataGridViewTextBoxColumn9.HeaderText = "april"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "may"
        Me.DataGridViewTextBoxColumn10.HeaderText = "may"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "june"
        Me.DataGridViewTextBoxColumn11.HeaderText = "june"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "july"
        Me.DataGridViewTextBoxColumn13.HeaderText = "july"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "august"
        Me.DataGridViewTextBoxColumn15.HeaderText = "august"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "september"
        Me.DataGridViewTextBoxColumn16.HeaderText = "september"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "october"
        Me.DataGridViewTextBoxColumn17.HeaderText = "october"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "november"
        Me.DataGridViewTextBoxColumn18.HeaderText = "november"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "december"
        Me.DataGridViewTextBoxColumn19.HeaderText = "december"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'Tbl_sales_targetBindingSource
        '
        Me.Tbl_sales_targetBindingSource.DataMember = "tbl_sales_target"
        Me.Tbl_sales_targetBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInvoiceDataGridView
        '
        Me.TblInvoiceDataGridView.AutoGenerateColumns = False
        Me.TblInvoiceDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TblInvoiceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.customerName, Me.totalAmount, Me.grandTotal})
        Me.TblInvoiceDataGridView.DataSource = Me.TblInvoiceBindingSource
        Me.TblInvoiceDataGridView.Location = New System.Drawing.Point(503, 425)
        Me.TblInvoiceDataGridView.Name = "TblInvoiceDataGridView"
        Me.TblInvoiceDataGridView.Size = New System.Drawing.Size(484, 237)
        Me.TblInvoiceDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "invoiceNo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "রশিদ নং"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'customerName
        '
        Me.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.customerName.DataPropertyName = "shopName"
        Me.customerName.HeaderText = "দোকানের নাম"
        Me.customerName.Name = "customerName"
        '
        'totalAmount
        '
        Me.totalAmount.DataPropertyName = "totalAmount"
        Me.totalAmount.HeaderText = "মোট দাম"
        Me.totalAmount.Name = "totalAmount"
        '
        'grandTotal
        '
        Me.grandTotal.DataPropertyName = "grandTotal"
        Me.grandTotal.HeaderText = "নিট দাম"
        Me.grandTotal.Name = "grandTotal"
        Me.grandTotal.Visible = False
        '
        'TblInvoiceBindingSource
        '
        Me.TblInvoiceBindingSource.DataMember = "tblInvoice"
        Me.TblInvoiceBindingSource.DataSource = Me.DataSet
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Location = New System.Drawing.Point(3, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(494, 331)
        Me.Panel2.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(AvailableLabel)
        Me.Panel5.Controls.Add(Me.lbl_profit)
        Me.Panel5.Controls.Add(Me.AvailableTextBox)
        Me.Panel5.Controls.Add(Me.AlertQuantityTextBox)
        Me.Panel5.Controls.Add(AlertQuantityLabel)
        Me.Panel5.Location = New System.Drawing.Point(247, 170)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(241, 164)
        Me.Panel5.TabIndex = 6
        '
        'lbl_profit
        '
        Me.lbl_profit.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_profit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profit.ForeColor = System.Drawing.Color.Black
        Me.lbl_profit.Location = New System.Drawing.Point(0, 0)
        Me.lbl_profit.Name = "lbl_profit"
        Me.lbl_profit.Padding = New System.Windows.Forms.Padding(15)
        Me.lbl_profit.Size = New System.Drawing.Size(241, 164)
        Me.lbl_profit.TabIndex = 6
        Me.lbl_profit.Text = "ক্যাশ"
        Me.lbl_profit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AvailableTextBox
        '
        Me.AvailableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "available", True))
        Me.AvailableTextBox.Location = New System.Drawing.Point(-16, 53)
        Me.AvailableTextBox.Name = "AvailableTextBox"
        Me.AvailableTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AvailableTextBox.TabIndex = 24
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.DataSet
        '
        'AlertQuantityTextBox
        '
        Me.AlertQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProductsBindingSource, "alertQuantity", True))
        Me.AlertQuantityTextBox.Location = New System.Drawing.Point(-16, 69)
        Me.AlertQuantityTextBox.Name = "AlertQuantityTextBox"
        Me.AlertQuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlertQuantityTextBox.TabIndex = 23
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.lbl_expense)
        Me.Panel4.Location = New System.Drawing.Point(3, 170)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(241, 164)
        Me.Panel4.TabIndex = 6
        '
        'lbl_expense
        '
        Me.lbl_expense.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_expense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_expense.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_expense.ForeColor = System.Drawing.Color.Black
        Me.lbl_expense.Location = New System.Drawing.Point(0, 0)
        Me.lbl_expense.Name = "lbl_expense"
        Me.lbl_expense.Padding = New System.Windows.Forms.Padding(15)
        Me.lbl_expense.Size = New System.Drawing.Size(241, 164)
        Me.lbl_expense.TabIndex = 6
        Me.lbl_expense.Text = "ব্যয়/প্রদান"
        Me.lbl_expense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.lbl_income)
        Me.Panel3.Location = New System.Drawing.Point(247, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(241, 164)
        Me.Panel3.TabIndex = 6
        '
        'lbl_income
        '
        Me.lbl_income.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_income.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_income.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_income.ForeColor = System.Drawing.Color.Black
        Me.lbl_income.Location = New System.Drawing.Point(0, 0)
        Me.lbl_income.Name = "lbl_income"
        Me.lbl_income.Padding = New System.Windows.Forms.Padding(15)
        Me.lbl_income.Size = New System.Drawing.Size(241, 164)
        Me.lbl_income.TabIndex = 7
        Me.lbl_income.Text = "আয়/প্রাপ্তি"
        Me.lbl_income.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.lbl_totalsale)
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(241, 164)
        Me.Panel6.TabIndex = 5
        '
        'lbl_totalsale
        '
        Me.lbl_totalsale.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_totalsale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_totalsale.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalsale.ForeColor = System.Drawing.Color.Black
        Me.lbl_totalsale.Location = New System.Drawing.Point(0, 0)
        Me.lbl_totalsale.Name = "lbl_totalsale"
        Me.lbl_totalsale.Padding = New System.Windows.Forms.Padding(15)
        Me.lbl_totalsale.Size = New System.Drawing.Size(241, 164)
        Me.lbl_totalsale.TabIndex = 5
        Me.lbl_totalsale.Text = "মোট বিক্রি"
        Me.lbl_totalsale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblNotesDataGridView
        '
        Me.TblNotesDataGridView.AutoGenerateColumns = False
        Me.TblNotesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblNotesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblNotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblNotesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblNotesDataGridView.DataSource = Me.TblNotesBindingSource
        Me.TblNotesDataGridView.Location = New System.Drawing.Point(503, 80)
        Me.TblNotesDataGridView.Name = "TblNotesDataGridView"
        Me.TblNotesDataGridView.Size = New System.Drawing.Size(484, 112)
        Me.TblNotesDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "তারিখ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn4.HeaderText = "নোটিশ/শিডিউল"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TblNotesBindingSource
        '
        Me.TblNotesBindingSource.DataMember = "tblNotes"
        Me.TblNotesBindingSource.DataSource = Me.DataSet
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(503, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(4)
        Me.Label5.Size = New System.Drawing.Size(484, 34)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "নোটিশ বোর্ড/কাজের শিডিউল"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(934, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 27)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(878, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 27)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtn
        '
        Me.dtn.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dtn.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtn.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop
        Me.dtn.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.dtn.Location = New System.Drawing.Point(503, 47)
        Me.dtn.Name = "dtn"
        Me.dtn.Size = New System.Drawing.Size(369, 27)
        Me.dtn.TabIndex = 14
        '
        'TblProductsDataGridView
        '
        Me.TblProductsDataGridView.AutoGenerateColumns = False
        Me.TblProductsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TblProductsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn12})
        Me.TblProductsDataGridView.DataSource = Me.TblProductsBindingSource
        Me.TblProductsDataGridView.Location = New System.Drawing.Point(503, 234)
        Me.TblProductsDataGridView.Name = "TblProductsDataGridView"
        Me.TblProductsDataGridView.Size = New System.Drawing.Size(484, 149)
        Me.TblProductsDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "productName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "পণ্যের নাম"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "productCategory"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ধরন"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "available"
        Me.DataGridViewTextBoxColumn12.HeaderText = "স্টক"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'CurrencyTextBox
        '
        Me.CurrencyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "currency", True))
        Me.CurrencyTextBox.Location = New System.Drawing.Point(961, 3)
        Me.CurrencyTextBox.Name = "CurrencyTextBox"
        Me.CurrencyTextBox.Size = New System.Drawing.Size(29, 20)
        Me.CurrencyTextBox.TabIndex = 22
        '
        'TblCompanySettingsBindingSource
        '
        Me.TblCompanySettingsBindingSource.DataMember = "tblCompanySettings"
        Me.TblCompanySettingsBindingSource.DataSource = Me.DataSet
        '
        'TblInvoiceTableAdapter
        '
        Me.TblInvoiceTableAdapter.ClearBeforeFill = True
        '
        'TblNotesTableAdapter
        '
        Me.TblNotesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblInvoiceTableAdapter = Me.TblInvoiceTableAdapter
        Me.TableAdapterManager.tblNotesTableAdapter = Me.TblNotesTableAdapter
        Me.TableAdapterManager.tblNoticeTableAdapter = Nothing
        Me.TableAdapterManager.tblPCommissionTableAdapter = Nothing
        Me.TableAdapterManager.tblProductCategoryTableAdapter = Nothing
        Me.TableAdapterManager.tblProductsTableAdapter = Me.TblProductsTableAdapter
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
        'TblCompanySettingsTableAdapter
        '
        Me.TblCompanySettingsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_sales_targetTableAdapter
        '
        Me.Tbl_sales_targetTableAdapter.ClearBeforeFill = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1011, 682)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CurrencyTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Tbl_sales_targetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_sales_targetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.TblNotesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCompanySettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TblInvoiceDataGridView As DataGridView
    Friend WithEvents TblInvoiceBindingSource As BindingSource
    Friend WithEvents DataSet As dataSet
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_profit As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_totalsale As Label
    Friend WithEvents TblNotesDataGridView As DataGridView
    Friend WithEvents TblNotesBindingSource As BindingSource
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtn As DateTimePicker
    Friend WithEvents TblProductsDataGridView As DataGridView
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblInvoiceTableAdapter As dataSetTableAdapters.tblInvoiceTableAdapter
    Friend WithEvents TblNotesTableAdapter As dataSetTableAdapters.tblNotesTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblProductsTableAdapter As dataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents TblCompanySettingsBindingSource As BindingSource
    Friend WithEvents TblCompanySettingsTableAdapter As dataSetTableAdapters.tblCompanySettingsTableAdapter
    Friend WithEvents CurrencyTextBox As TextBox
    Friend WithEvents AvailableTextBox As TextBox
    Friend WithEvents AlertQuantityTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSold As Label
    Friend WithEvents lblTarget As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents prg As CircularProgressBar.CircularProgressBar
    Friend WithEvents Button4 As Button
    Friend WithEvents Tbl_sales_targetBindingSource As BindingSource
    Friend WithEvents Tbl_sales_targetTableAdapter As dataSetTableAdapters.tbl_sales_targetTableAdapter
    Friend WithEvents Tbl_sales_targetDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents customerName As DataGridViewTextBoxColumn
    Friend WithEvents totalAmount As DataGridViewTextBoxColumn
    Friend WithEvents grandTotal As DataGridViewTextBoxColumn
    Friend WithEvents lbl_expense As Label
    Friend WithEvents lbl_income As Label
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
