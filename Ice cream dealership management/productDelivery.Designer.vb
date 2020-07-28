<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productDelivery
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
        Dim SaleInvoiceLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim ShippingAddressLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim ConfirmationLabel As System.Windows.Forms.Label
        Dim DriverNameLabel As System.Windows.Forms.Label
        Dim VehicleIDLabel As System.Windows.Forms.Label
        Dim DeliveryChargeLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbldelivered = New System.Windows.Forms.Label()
        Me.lblpending = New System.Windows.Forms.Label()
        Me.chk_show_pending = New System.Windows.Forms.CheckBox()
        Me.TblDeliveryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deliveryCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.confirmation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblDeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DeliveryChargeTextBox = New System.Windows.Forms.TextBox()
        Me.VehicleIDTextBox = New System.Windows.Forms.TextBox()
        Me.DriverNameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SaleInvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.ShippingAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TimeTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmationTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShippingAddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.VehicleIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblVehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriverNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.TblDeliveryTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblDeliveryTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblCustomersTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblCustomersTableAdapter()
        Me.TblVehicleTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblVehicleTableAdapter()
        Me.TblInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInvoiceTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblInvoiceTableAdapter()
        Me.CustomerNameTextBox2 = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox2 = New System.Windows.Forms.TextBox()
        Me.DriverNameTextBox2 = New System.Windows.Forms.TextBox()
        Me.VehicleIDTextBox2 = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        SaleInvoiceLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        ShippingAddressLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        ConfirmationLabel = New System.Windows.Forms.Label()
        DriverNameLabel = New System.Windows.Forms.Label()
        VehicleIDLabel = New System.Windows.Forms.Label()
        DeliveryChargeLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblDeliveryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaleInvoiceLabel
        '
        SaleInvoiceLabel.BackColor = System.Drawing.Color.Black
        SaleInvoiceLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SaleInvoiceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SaleInvoiceLabel.Location = New System.Drawing.Point(0, 7)
        SaleInvoiceLabel.Name = "SaleInvoiceLabel"
        SaleInvoiceLabel.Size = New System.Drawing.Size(151, 25)
        SaleInvoiceLabel.TabIndex = 2
        SaleInvoiceLabel.Text = "বিক্রয় রশিদ নং:"
        SaleInvoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.BackColor = System.Drawing.Color.Black
        CustomerNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CustomerNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CustomerNameLabel.Location = New System.Drawing.Point(0, 33)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(151, 25)
        CustomerNameLabel.TabIndex = 4
        CustomerNameLabel.Text = "কাস্টমারের নামঃ"
        CustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShippingAddressLabel
        '
        ShippingAddressLabel.BackColor = System.Drawing.Color.Black
        ShippingAddressLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ShippingAddressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ShippingAddressLabel.Location = New System.Drawing.Point(0, 59)
        ShippingAddressLabel.Name = "ShippingAddressLabel"
        ShippingAddressLabel.Size = New System.Drawing.Size(151, 25)
        ShippingAddressLabel.TabIndex = 6
        ShippingAddressLabel.Text = "ঠিকানাঃ"
        ShippingAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.BackColor = System.Drawing.Color.Black
        ContactNumberLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ContactNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ContactNumberLabel.Location = New System.Drawing.Point(0, 85)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(151, 25)
        ContactNumberLabel.TabIndex = 8
        ContactNumberLabel.Text = "মোবাইলঃ"
        ContactNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        DateLabel.BackColor = System.Drawing.Color.Black
        DateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DateLabel.Location = New System.Drawing.Point(0, 163)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(151, 25)
        DateLabel.TabIndex = 10
        DateLabel.Text = "তারিখঃ"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ConfirmationLabel
        '
        ConfirmationLabel.AutoSize = True
        ConfirmationLabel.Location = New System.Drawing.Point(385, 347)
        ConfirmationLabel.Name = "ConfirmationLabel"
        ConfirmationLabel.Size = New System.Drawing.Size(83, 13)
        ConfirmationLabel.TabIndex = 13
        ConfirmationLabel.Text = "confirmation:"
        '
        'DriverNameLabel
        '
        DriverNameLabel.BackColor = System.Drawing.Color.Black
        DriverNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DriverNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DriverNameLabel.Location = New System.Drawing.Point(0, 111)
        DriverNameLabel.Name = "DriverNameLabel"
        DriverNameLabel.Size = New System.Drawing.Size(151, 25)
        DriverNameLabel.TabIndex = 78
        DriverNameLabel.Text = "ডেলিভারী ম্যানঃ"
        DriverNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VehicleIDLabel
        '
        VehicleIDLabel.AutoSize = True
        VehicleIDLabel.BackColor = System.Drawing.Color.Black
        VehicleIDLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        VehicleIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        VehicleIDLabel.Location = New System.Drawing.Point(276, 113)
        VehicleIDLabel.Name = "VehicleIDLabel"
        VehicleIDLabel.Size = New System.Drawing.Size(126, 23)
        VehicleIDLabel.TabIndex = 79
        VehicleIDLabel.Text = "গাড়ীর আই.ডি.:"
        '
        'DeliveryChargeLabel
        '
        DeliveryChargeLabel.BackColor = System.Drawing.Color.Black
        DeliveryChargeLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DeliveryChargeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DeliveryChargeLabel.Location = New System.Drawing.Point(0, 137)
        DeliveryChargeLabel.Name = "DeliveryChargeLabel"
        DeliveryChargeLabel.Size = New System.Drawing.Size(151, 25)
        DeliveryChargeLabel.TabIndex = 80
        DeliveryChargeLabel.Text = "খরচঃ"
        DeliveryChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Black
        Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(301, 161)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(53, 23)
        Label2.TabIndex = 82
        Label2.Text = "সময়ঃ"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "পণ্য ডেলিভারী"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lbldelivered)
        Me.Panel1.Controls.Add(Me.lblpending)
        Me.Panel1.Controls.Add(Me.chk_show_pending)
        Me.Panel1.Controls.Add(Me.TblDeliveryDataGridView)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TimeTextBox)
        Me.Panel1.Controls.Add(Me.DateTextBox)
        Me.Panel1.Controls.Add(ConfirmationLabel)
        Me.Panel1.Controls.Add(Me.ConfirmationTextBox)
        Me.Panel1.Location = New System.Drawing.Point(6, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 494)
        Me.Panel1.TabIndex = 14
        '
        'lbldelivered
        '
        Me.lbldelivered.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lbldelivered.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.lbldelivered.Location = New System.Drawing.Point(82, 194)
        Me.lbldelivered.Name = "lbldelivered"
        Me.lbldelivered.Padding = New System.Windows.Forms.Padding(6)
        Me.lbldelivered.Size = New System.Drawing.Size(321, 55)
        Me.lbldelivered.TabIndex = 17
        Me.lbldelivered.Text = "Todays delivered invoices: 0000"
        Me.lbldelivered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpending
        '
        Me.lblpending.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lblpending.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.lblpending.Location = New System.Drawing.Point(82, 136)
        Me.lblpending.Name = "lblpending"
        Me.lblpending.Padding = New System.Windows.Forms.Padding(6)
        Me.lblpending.Size = New System.Drawing.Size(321, 55)
        Me.lblpending.TabIndex = 16
        Me.lblpending.Text = "Total pending deliveries: 0000"
        Me.lblpending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_show_pending
        '
        Me.chk_show_pending.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.chk_show_pending.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.chk_show_pending.Location = New System.Drawing.Point(82, 48)
        Me.chk_show_pending.Name = "chk_show_pending"
        Me.chk_show_pending.Padding = New System.Windows.Forms.Padding(8)
        Me.chk_show_pending.Size = New System.Drawing.Size(321, 85)
        Me.chk_show_pending.TabIndex = 15
        Me.chk_show_pending.Text = "Show pending deliverys only"
        Me.chk_show_pending.UseVisualStyleBackColor = False
        '
        'TblDeliveryDataGridView
        '
        Me.TblDeliveryDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TblDeliveryDataGridView.AutoGenerateColumns = False
        Me.TblDeliveryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TblDeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblDeliveryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.deliveryCharge, Me.confirmation})
        Me.TblDeliveryDataGridView.DataSource = Me.TblDeliveryBindingSource
        Me.TblDeliveryDataGridView.Location = New System.Drawing.Point(3, 279)
        Me.TblDeliveryDataGridView.Name = "TblDeliveryDataGridView"
        Me.TblDeliveryDataGridView.Size = New System.Drawing.Size(982, 212)
        Me.TblDeliveryDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "saleInvoice"
        Me.DataGridViewTextBoxColumn2.HeaderText = "বিক্রয় রশিদ নং"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "customerName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "কাস্টমারের নাম"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "shippingAddress"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ঠিকানাঃ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "contactNumber"
        Me.DataGridViewTextBoxColumn5.HeaderText = "মোবাইল"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ডেলিভারীর তারিখ"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "time"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ডেলিভারীর সময়"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'deliveryCharge
        '
        Me.deliveryCharge.DataPropertyName = "deliveryCharge"
        Me.deliveryCharge.HeaderText = "খরচ"
        Me.deliveryCharge.Name = "deliveryCharge"
        '
        'confirmation
        '
        Me.confirmation.DataPropertyName = "confirmation"
        Me.confirmation.HeaderText = "কনফার্ম"
        Me.confirmation.Name = "confirmation"
        Me.confirmation.Width = 120
        '
        'TblDeliveryBindingSource
        '
        Me.TblDeliveryBindingSource.DataMember = "tblDelivery"
        Me.TblDeliveryBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(409, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 259)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "নতুন বিক্রয়ের ডেলিভারীঃ"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Controls.Add(DeliveryChargeLabel)
        Me.Panel2.Controls.Add(Me.DeliveryChargeTextBox)
        Me.Panel2.Controls.Add(VehicleIDLabel)
        Me.Panel2.Controls.Add(Me.VehicleIDTextBox)
        Me.Panel2.Controls.Add(DriverNameLabel)
        Me.Panel2.Controls.Add(Me.DriverNameTextBox)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(SaleInvoiceLabel)
        Me.Panel2.Controls.Add(Me.SaleInvoiceTextBox)
        Me.Panel2.Controls.Add(CustomerNameLabel)
        Me.Panel2.Controls.Add(Me.CustomerNameTextBox)
        Me.Panel2.Controls.Add(ShippingAddressLabel)
        Me.Panel2.Controls.Add(Me.ShippingAddressTextBox)
        Me.Panel2.Controls.Add(ContactNumberLabel)
        Me.Panel2.Controls.Add(Me.ContactNumberTextBox)
        Me.Panel2.Controls.Add(DateLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(492, 230)
        Me.Panel2.TabIndex = 0
        '
        'DeliveryChargeTextBox
        '
        Me.DeliveryChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDeliveryBindingSource, "deliveryCharge", True))
        Me.DeliveryChargeTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DeliveryChargeTextBox.Location = New System.Drawing.Point(157, 136)
        Me.DeliveryChargeTextBox.Name = "DeliveryChargeTextBox"
        Me.DeliveryChargeTextBox.Size = New System.Drawing.Size(112, 24)
        Me.DeliveryChargeTextBox.TabIndex = 81
        '
        'VehicleIDTextBox
        '
        Me.VehicleIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDeliveryBindingSource, "vehicleID", True))
        Me.VehicleIDTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.VehicleIDTextBox.Location = New System.Drawing.Point(380, 112)
        Me.VehicleIDTextBox.Name = "VehicleIDTextBox"
        Me.VehicleIDTextBox.ReadOnly = True
        Me.VehicleIDTextBox.Size = New System.Drawing.Size(100, 24)
        Me.VehicleIDTextBox.TabIndex = 80
        '
        'DriverNameTextBox
        '
        Me.DriverNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDeliveryBindingSource, "driverName", True))
        Me.DriverNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DriverNameTextBox.Location = New System.Drawing.Point(157, 111)
        Me.DriverNameTextBox.Name = "DriverNameTextBox"
        Me.DriverNameTextBox.ReadOnly = True
        Me.DriverNameTextBox.Size = New System.Drawing.Size(112, 24)
        Me.DriverNameTextBox.TabIndex = 79
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(157, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 35)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(346, 161)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(134, 24)
        Me.DateTimePicker2.TabIndex = 15
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(157, 161)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 24)
        Me.DateTimePicker1.TabIndex = 14
        '
        'SaleInvoiceTextBox
        '
        Me.SaleInvoiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDeliveryBindingSource, "saleInvoice", True))
        Me.SaleInvoiceTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SaleInvoiceTextBox.Location = New System.Drawing.Point(157, 11)
        Me.SaleInvoiceTextBox.Name = "SaleInvoiceTextBox"
        Me.SaleInvoiceTextBox.Size = New System.Drawing.Size(323, 24)
        Me.SaleInvoiceTextBox.TabIndex = 3
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDeliveryBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(157, 36)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.ReadOnly = True
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(323, 24)
        Me.CustomerNameTextBox.TabIndex = 5
        '
        'ShippingAddressTextBox
        '
        Me.ShippingAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDeliveryBindingSource, "shippingAddress", True))
        Me.ShippingAddressTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ShippingAddressTextBox.Location = New System.Drawing.Point(157, 61)
        Me.ShippingAddressTextBox.Name = "ShippingAddressTextBox"
        Me.ShippingAddressTextBox.ReadOnly = True
        Me.ShippingAddressTextBox.Size = New System.Drawing.Size(323, 24)
        Me.ShippingAddressTextBox.TabIndex = 7
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDeliveryBindingSource, "contactNumber", True))
        Me.ContactNumberTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(157, 86)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.ReadOnly = True
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(323, 24)
        Me.ContactNumberTextBox.TabIndex = 9
        '
        'TimeTextBox
        '
        Me.TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDeliveryBindingSource, "time", True))
        Me.TimeTextBox.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TimeTextBox.Location = New System.Drawing.Point(63, 332)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.Size = New System.Drawing.Size(119, 33)
        Me.TimeTextBox.TabIndex = 13
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDeliveryBindingSource, "date", True))
        Me.DateTextBox.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold)
        Me.DateTextBox.Location = New System.Drawing.Point(63, 329)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(119, 33)
        Me.DateTextBox.TabIndex = 11
        '
        'ConfirmationTextBox
        '
        Me.ConfirmationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDeliveryBindingSource, "confirmation", True))
        Me.ConfirmationTextBox.Location = New System.Drawing.Point(474, 344)
        Me.ConfirmationTextBox.Name = "ConfirmationTextBox"
        Me.ConfirmationTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ConfirmationTextBox.TabIndex = 14
        '
        'ContactNumberTextBox1
        '
        Me.ContactNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "contactNumber", True))
        Me.ContactNumberTextBox1.Location = New System.Drawing.Point(206, 12)
        Me.ContactNumberTextBox1.Name = "ContactNumberTextBox1"
        Me.ContactNumberTextBox1.Size = New System.Drawing.Size(23, 21)
        Me.ContactNumberTextBox1.TabIndex = 17
        '
        'TblCustomersBindingSource
        '
        Me.TblCustomersBindingSource.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource.DataSource = Me.DataSet
        '
        'ShippingAddressTextBox1
        '
        Me.ShippingAddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "shippingAddress", True))
        Me.ShippingAddressTextBox1.Location = New System.Drawing.Point(206, 12)
        Me.ShippingAddressTextBox1.Name = "ShippingAddressTextBox1"
        Me.ShippingAddressTextBox1.Size = New System.Drawing.Size(23, 21)
        Me.ShippingAddressTextBox1.TabIndex = 16
        '
        'CustomerNameTextBox1
        '
        Me.CustomerNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomersBindingSource, "customerName", True))
        Me.CustomerNameTextBox1.Location = New System.Drawing.Point(206, 12)
        Me.CustomerNameTextBox1.Name = "CustomerNameTextBox1"
        Me.CustomerNameTextBox1.Size = New System.Drawing.Size(23, 21)
        Me.CustomerNameTextBox1.TabIndex = 15
        '
        'VehicleIDTextBox1
        '
        Me.VehicleIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "vehicleID", True))
        Me.VehicleIDTextBox1.Location = New System.Drawing.Point(235, 12)
        Me.VehicleIDTextBox1.Name = "VehicleIDTextBox1"
        Me.VehicleIDTextBox1.Size = New System.Drawing.Size(31, 21)
        Me.VehicleIDTextBox1.TabIndex = 16
        '
        'TblVehicleBindingSource
        '
        Me.TblVehicleBindingSource.DataMember = "tblVehicle"
        Me.TblVehicleBindingSource.DataSource = Me.DataSet
        '
        'DriverNameTextBox1
        '
        Me.DriverNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVehicleBindingSource, "driverName", True))
        Me.DriverNameTextBox1.Location = New System.Drawing.Point(235, 12)
        Me.DriverNameTextBox1.Name = "DriverNameTextBox1"
        Me.DriverNameTextBox1.Size = New System.Drawing.Size(31, 21)
        Me.DriverNameTextBox1.TabIndex = 15
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel2, Me.txtFilter, Me.ToolStripLabel1, Me.ToolStripButton4, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton5, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 29)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(220, 29)
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
        Me.txtFilter.Items.AddRange(New Object() {"রশিদ নং", "দোকানের নাম", "ঠিকানা", "মোবাইল", "ডেলিভারির তারিখ"})
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
        Me.ToolStripButton4.Size = New System.Drawing.Size(138, 25)
        Me.ToolStripButton4.Text = "নতুন ডেলিভারী"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Green
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(114, 25)
        Me.ToolStripButton2.Text = "কনফার্ম করুন"
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
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton5.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(0, 1, 1, 3)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(74, 25)
        Me.ToolStripButton5.Text = "ডিলিট"
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
        Me.ToolStripButton6.Size = New System.Drawing.Size(63, 24)
        Me.ToolStripButton6.Text = "প্রিন্ট"
        '
        'TblDeliveryTableAdapter
        '
        Me.TblDeliveryTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblDeliveryTableAdapter = Me.TblDeliveryTableAdapter
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
        'TblCustomersTableAdapter
        '
        Me.TblCustomersTableAdapter.ClearBeforeFill = True
        '
        'TblVehicleTableAdapter
        '
        Me.TblVehicleTableAdapter.ClearBeforeFill = True
        '
        'TblInvoiceBindingSource
        '
        Me.TblInvoiceBindingSource.DataMember = "tblInvoice"
        Me.TblInvoiceBindingSource.DataSource = Me.DataSet
        '
        'TblInvoiceTableAdapter
        '
        Me.TblInvoiceTableAdapter.ClearBeforeFill = True
        '
        'CustomerNameTextBox2
        '
        Me.CustomerNameTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "customerName", True))
        Me.CustomerNameTextBox2.Location = New System.Drawing.Point(6, 12)
        Me.CustomerNameTextBox2.Name = "CustomerNameTextBox2"
        Me.CustomerNameTextBox2.Size = New System.Drawing.Size(29, 21)
        Me.CustomerNameTextBox2.TabIndex = 16
        '
        'ContactNumberTextBox2
        '
        Me.ContactNumberTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "contactNumber", True))
        Me.ContactNumberTextBox2.Location = New System.Drawing.Point(6, 12)
        Me.ContactNumberTextBox2.Name = "ContactNumberTextBox2"
        Me.ContactNumberTextBox2.Size = New System.Drawing.Size(29, 21)
        Me.ContactNumberTextBox2.TabIndex = 17
        '
        'DriverNameTextBox2
        '
        Me.DriverNameTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "driverName", True))
        Me.DriverNameTextBox2.Location = New System.Drawing.Point(6, 12)
        Me.DriverNameTextBox2.Name = "DriverNameTextBox2"
        Me.DriverNameTextBox2.Size = New System.Drawing.Size(29, 21)
        Me.DriverNameTextBox2.TabIndex = 18
        '
        'VehicleIDTextBox2
        '
        Me.VehicleIDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "vehicleID", True))
        Me.VehicleIDTextBox2.Location = New System.Drawing.Point(6, 12)
        Me.VehicleIDTextBox2.Name = "VehicleIDTextBox2"
        Me.VehicleIDTextBox2.Size = New System.Drawing.Size(29, 21)
        Me.VehicleIDTextBox2.TabIndex = 19
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoiceBindingSource, "customerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(6, 12)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(29, 21)
        Me.CustomerIDTextBox.TabIndex = 20
        '
        'productDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.VehicleIDTextBox2)
        Me.Controls.Add(Me.DriverNameTextBox2)
        Me.Controls.Add(Me.ContactNumberTextBox2)
        Me.Controls.Add(Me.CustomerNameTextBox2)
        Me.Controls.Add(Me.VehicleIDTextBox1)
        Me.Controls.Add(Me.DriverNameTextBox1)
        Me.Controls.Add(Me.CustomerNameTextBox1)
        Me.Controls.Add(Me.ShippingAddressTextBox1)
        Me.Controls.Add(Me.ContactNumberTextBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "productDelivery"
        Me.Text = "productDelivery"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblDeliveryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TblInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblDeliveryBindingSource As BindingSource
    Friend WithEvents TblDeliveryTableAdapter As dataSetTableAdapters.tblDeliveryTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblDeliveryDataGridView As DataGridView
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents SaleInvoiceTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents ShippingAddressTextBox As TextBox
    Friend WithEvents ContactNumberTextBox As TextBox
    Friend WithEvents TimeTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents ConfirmationTextBox As TextBox
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents DeliveryChargeTextBox As TextBox
    Friend WithEvents VehicleIDTextBox As TextBox
    Friend WithEvents DriverNameTextBox As TextBox
    Friend WithEvents TblCustomersBindingSource As BindingSource
    Friend WithEvents TblCustomersTableAdapter As dataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents ContactNumberTextBox1 As TextBox
    Friend WithEvents ShippingAddressTextBox1 As TextBox
    Friend WithEvents CustomerNameTextBox1 As TextBox
    Friend WithEvents TblVehicleBindingSource As BindingSource
    Friend WithEvents TblVehicleTableAdapter As dataSetTableAdapters.tblVehicleTableAdapter
    Friend WithEvents VehicleIDTextBox1 As TextBox
    Friend WithEvents DriverNameTextBox1 As TextBox
    Friend WithEvents TblInvoiceBindingSource As BindingSource
    Friend WithEvents TblInvoiceTableAdapter As dataSetTableAdapters.tblInvoiceTableAdapter
    Friend WithEvents CustomerNameTextBox2 As TextBox
    Friend WithEvents ContactNumberTextBox2 As TextBox
    Friend WithEvents DriverNameTextBox2 As TextBox
    Friend WithEvents VehicleIDTextBox2 As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents lbldelivered As Label
    Friend WithEvents lblpending As Label
    Friend WithEvents chk_show_pending As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents deliveryCharge As DataGridViewTextBoxColumn
    Friend WithEvents confirmation As DataGridViewTextBoxColumn
End Class
