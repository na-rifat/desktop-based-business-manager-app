<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class companySettings
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim CompanyAddressLabel As System.Windows.Forms.Label
        Dim CompanyPhoneNumberLabel As System.Windows.Forms.Label
        Dim CurrencyLabel As System.Windows.Forms.Label
        Dim Owner_nameLabel As System.Windows.Forms.Label
        Dim Trader_license_noLabel As System.Windows.Forms.Label
        Dim License_periodLabel As System.Windows.Forms.Label
        Dim DefaultVatLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.License_periodTextBox = New System.Windows.Forms.TextBox()
        Me.TblCompanySettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DefaultVatTextBox = New System.Windows.Forms.TextBox()
        Me.Trader_license_noTextBox = New System.Windows.Forms.TextBox()
        Me.nmInterval = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Owner_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CompanyLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyPhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CurrencyTextBox = New System.Windows.Forms.TextBox()
        Me.Noti_soundTextBox = New System.Windows.Forms.TextBox()
        Me.IniTextBox = New System.Windows.Forms.TextBox()
        Me.Is_noti_soundTextBox = New System.Windows.Forms.TextBox()
        Me.TblCompanySettingsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblCompanySettingsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        CompanyAddressLabel = New System.Windows.Forms.Label()
        CompanyPhoneNumberLabel = New System.Windows.Forms.Label()
        CurrencyLabel = New System.Windows.Forms.Label()
        Owner_nameLabel = New System.Windows.Forms.Label()
        Trader_license_noLabel = New System.Windows.Forms.Label()
        License_periodLabel = New System.Windows.Forms.Label()
        DefaultVatLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblCompanySettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Yellow
        Label4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(7, 281)
        Label4.Name = "Label4"
        Label4.Padding = New System.Windows.Forms.Padding(5)
        Label4.Size = New System.Drawing.Size(227, 27)
        Label4.TabIndex = 71
        Label4.Text = "Important notification interval"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Yellow
        Label3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Label3.ForeColor = System.Drawing.Color.Black
        Label3.Location = New System.Drawing.Point(89, 251)
        Label3.Name = "Label3"
        Label3.Padding = New System.Windows.Forms.Padding(5)
        Label3.Size = New System.Drawing.Size(145, 27)
        Label3.TabIndex = 69
        Label3.Text = "Notification sound"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        CompanyNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CompanyNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CompanyNameLabel.Location = New System.Drawing.Point(38, 25)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(196, 24)
        CompanyNameLabel.TabIndex = 58
        CompanyNameLabel.Text = "প্রতিষ্ঠানের নামঃ"
        CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyAddressLabel
        '
        CompanyAddressLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        CompanyAddressLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CompanyAddressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CompanyAddressLabel.Location = New System.Drawing.Point(38, 51)
        CompanyAddressLabel.Name = "CompanyAddressLabel"
        CompanyAddressLabel.Size = New System.Drawing.Size(196, 24)
        CompanyAddressLabel.TabIndex = 60
        CompanyAddressLabel.Text = "ঠিকানাঃ"
        CompanyAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CompanyPhoneNumberLabel
        '
        CompanyPhoneNumberLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        CompanyPhoneNumberLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CompanyPhoneNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CompanyPhoneNumberLabel.Location = New System.Drawing.Point(38, 77)
        CompanyPhoneNumberLabel.Name = "CompanyPhoneNumberLabel"
        CompanyPhoneNumberLabel.Size = New System.Drawing.Size(196, 24)
        CompanyPhoneNumberLabel.TabIndex = 62
        CompanyPhoneNumberLabel.Text = "মোবাইলঃ"
        CompanyPhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CurrencyLabel
        '
        CurrencyLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        CurrencyLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        CurrencyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CurrencyLabel.Location = New System.Drawing.Point(38, 103)
        CurrencyLabel.Name = "CurrencyLabel"
        CurrencyLabel.Size = New System.Drawing.Size(196, 24)
        CurrencyLabel.TabIndex = 64
        CurrencyLabel.Text = "মুদ্রাঃ"
        CurrencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Owner_nameLabel
        '
        Owner_nameLabel.BackColor = System.Drawing.Color.Black
        Owner_nameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Owner_nameLabel.ForeColor = System.Drawing.Color.White
        Owner_nameLabel.Location = New System.Drawing.Point(38, 155)
        Owner_nameLabel.Name = "Owner_nameLabel"
        Owner_nameLabel.Size = New System.Drawing.Size(196, 24)
        Owner_nameLabel.TabIndex = 9
        Owner_nameLabel.Text = "স্বত্তাধকারীঃ"
        Owner_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Trader_license_noLabel
        '
        Trader_license_noLabel.BackColor = System.Drawing.Color.Black
        Trader_license_noLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        Trader_license_noLabel.ForeColor = System.Drawing.Color.White
        Trader_license_noLabel.Location = New System.Drawing.Point(38, 181)
        Trader_license_noLabel.Name = "Trader_license_noLabel"
        Trader_license_noLabel.Size = New System.Drawing.Size(196, 24)
        Trader_license_noLabel.TabIndex = 10
        Trader_license_noLabel.Text = "ট্রেড লাইসেন্স নং:"
        Trader_license_noLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'License_periodLabel
        '
        License_periodLabel.BackColor = System.Drawing.Color.Black
        License_periodLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        License_periodLabel.ForeColor = System.Drawing.Color.White
        License_periodLabel.Location = New System.Drawing.Point(38, 207)
        License_periodLabel.Name = "License_periodLabel"
        License_periodLabel.Size = New System.Drawing.Size(196, 24)
        License_periodLabel.TabIndex = 11
        License_periodLabel.Text = "সফটওয়্যার লাইসেন্সের মেয়াদঃ"
        License_periodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefaultVatLabel
        '
        DefaultVatLabel.BackColor = System.Drawing.Color.Black
        DefaultVatLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DefaultVatLabel.ForeColor = System.Drawing.Color.White
        DefaultVatLabel.Location = New System.Drawing.Point(38, 129)
        DefaultVatLabel.Name = "DefaultVatLabel"
        DefaultVatLabel.Size = New System.Drawing.Size(196, 24)
        DefaultVatLabel.TabIndex = 12
        DefaultVatLabel.Text = "ভ্যাট+ট্যাক্সঃ"
        DefaultVatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1004, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "জেনারেল সেটিংস ও প্রাতিষ্ঠানিক তথ্য"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(97, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 481)
        Me.Panel1.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(270, 443)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(300, 35)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "সংশোধন করুন"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TrackBar1)
        Me.Panel2.Controls.Add(License_periodLabel)
        Me.Panel2.Controls.Add(DefaultVatLabel)
        Me.Panel2.Controls.Add(Me.License_periodTextBox)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Trader_license_noLabel)
        Me.Panel2.Controls.Add(Me.DefaultVatTextBox)
        Me.Panel2.Controls.Add(Me.Trader_license_noTextBox)
        Me.Panel2.Controls.Add(Me.nmInterval)
        Me.Panel2.Controls.Add(Owner_nameLabel)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Owner_nameTextBox)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.CompanyLogoPictureBox)
        Me.Panel2.Controls.Add(CompanyNameLabel)
        Me.Panel2.Controls.Add(Me.CompanyNameTextBox)
        Me.Panel2.Controls.Add(CompanyAddressLabel)
        Me.Panel2.Controls.Add(Me.CompanyAddressTextBox)
        Me.Panel2.Controls.Add(CompanyPhoneNumberLabel)
        Me.Panel2.Controls.Add(Me.CompanyPhoneNumberTextBox)
        Me.Panel2.Controls.Add(CurrencyLabel)
        Me.Panel2.Controls.Add(Me.CurrencyTextBox)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Panel2.Location = New System.Drawing.Point(29, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(766, 392)
        Me.Panel2.TabIndex = 36
        '
        'License_periodTextBox
        '
        Me.License_periodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "license_period", True))
        Me.License_periodTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.License_periodTextBox.Location = New System.Drawing.Point(240, 206)
        Me.License_periodTextBox.Name = "License_periodTextBox"
        Me.License_periodTextBox.Size = New System.Drawing.Size(300, 24)
        Me.License_periodTextBox.TabIndex = 12
        '
        'TblCompanySettingsBindingSource
        '
        Me.TblCompanySettingsBindingSource.DataMember = "tblCompanySettings"
        Me.TblCompanySettingsBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Yellow
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(250, 312)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Size = New System.Drawing.Size(208, 25)
        Me.CheckBox1.TabIndex = 77
        Me.CheckBox1.Text = "Enable notification sound"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'DefaultVatTextBox
        '
        Me.DefaultVatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "defaultVat", True))
        Me.DefaultVatTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DefaultVatTextBox.Location = New System.Drawing.Point(240, 128)
        Me.DefaultVatTextBox.Name = "DefaultVatTextBox"
        Me.DefaultVatTextBox.Size = New System.Drawing.Size(300, 24)
        Me.DefaultVatTextBox.TabIndex = 13
        '
        'Trader_license_noTextBox
        '
        Me.Trader_license_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "trader_license_no", True))
        Me.Trader_license_noTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Trader_license_noTextBox.Location = New System.Drawing.Point(240, 180)
        Me.Trader_license_noTextBox.Name = "Trader_license_noTextBox"
        Me.Trader_license_noTextBox.Size = New System.Drawing.Size(300, 24)
        Me.Trader_license_noTextBox.TabIndex = 11
        '
        'nmInterval
        '
        Me.nmInterval.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.nmInterval.Location = New System.Drawing.Point(250, 281)
        Me.nmInterval.Name = "nmInterval"
        Me.nmInterval.Size = New System.Drawing.Size(120, 24)
        Me.nmInterval.TabIndex = 74
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(240, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(300, 35)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "সেভ করুন"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Owner_nameTextBox
        '
        Me.Owner_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "owner_name", True))
        Me.Owner_nameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Owner_nameTextBox.Location = New System.Drawing.Point(240, 154)
        Me.Owner_nameTextBox.Name = "Owner_nameTextBox"
        Me.Owner_nameTextBox.Size = New System.Drawing.Size(300, 24)
        Me.Owner_nameTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(376, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(64, 27)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Minute"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(446, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(42, 27)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "0%"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(546, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 35)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CompanyLogoPictureBox
        '
        Me.CompanyLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CompanyLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompanyLogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblCompanySettingsBindingSource, "companyLogo", True))
        Me.CompanyLogoPictureBox.Location = New System.Drawing.Point(546, 11)
        Me.CompanyLogoPictureBox.Name = "CompanyLogoPictureBox"
        Me.CompanyLogoPictureBox.Size = New System.Drawing.Size(201, 180)
        Me.CompanyLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CompanyLogoPictureBox.TabIndex = 66
        Me.CompanyLogoPictureBox.TabStop = False
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "companyName", True))
        Me.CompanyNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(240, 24)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(300, 24)
        Me.CompanyNameTextBox.TabIndex = 59
        '
        'CompanyAddressTextBox
        '
        Me.CompanyAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "companyAddress", True))
        Me.CompanyAddressTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CompanyAddressTextBox.Location = New System.Drawing.Point(240, 50)
        Me.CompanyAddressTextBox.Name = "CompanyAddressTextBox"
        Me.CompanyAddressTextBox.Size = New System.Drawing.Size(300, 24)
        Me.CompanyAddressTextBox.TabIndex = 61
        '
        'CompanyPhoneNumberTextBox
        '
        Me.CompanyPhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "companyPhoneNumber", True))
        Me.CompanyPhoneNumberTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CompanyPhoneNumberTextBox.Location = New System.Drawing.Point(240, 76)
        Me.CompanyPhoneNumberTextBox.Name = "CompanyPhoneNumberTextBox"
        Me.CompanyPhoneNumberTextBox.Size = New System.Drawing.Size(300, 24)
        Me.CompanyPhoneNumberTextBox.TabIndex = 63
        '
        'CurrencyTextBox
        '
        Me.CurrencyTextBox.AutoCompleteCustomSource.AddRange(New String() {"BDT", "USD", "EUR", "RUPEE"})
        Me.CurrencyTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CurrencyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "currency", True))
        Me.CurrencyTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CurrencyTextBox.Location = New System.Drawing.Point(240, 102)
        Me.CurrencyTextBox.Name = "CurrencyTextBox"
        Me.CurrencyTextBox.Size = New System.Drawing.Size(300, 24)
        Me.CurrencyTextBox.TabIndex = 65
        '
        'Noti_soundTextBox
        '
        Me.Noti_soundTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "noti_sound", True))
        Me.Noti_soundTextBox.Location = New System.Drawing.Point(12, 8)
        Me.Noti_soundTextBox.Name = "Noti_soundTextBox"
        Me.Noti_soundTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Noti_soundTextBox.TabIndex = 7
        '
        'IniTextBox
        '
        Me.IniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "ini", True))
        Me.IniTextBox.Location = New System.Drawing.Point(12, 8)
        Me.IniTextBox.Name = "IniTextBox"
        Me.IniTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IniTextBox.TabIndex = 8
        '
        'Is_noti_soundTextBox
        '
        Me.Is_noti_soundTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCompanySettingsBindingSource, "is_noti_sound", True))
        Me.Is_noti_soundTextBox.Location = New System.Drawing.Point(12, 8)
        Me.Is_noti_soundTextBox.Name = "Is_noti_soundTextBox"
        Me.Is_noti_soundTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Is_noti_soundTextBox.TabIndex = 9
        '
        'TblCompanySettingsTableAdapter
        '
        Me.TblCompanySettingsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblCompanySettingsTableAdapter = Me.TblCompanySettingsTableAdapter
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
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(250, 249)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(190, 26)
        Me.TrackBar1.TabIndex = 78
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'companySettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 664)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Is_noti_soundTextBox)
        Me.Controls.Add(Me.IniTextBox)
        Me.Controls.Add(Me.Noti_soundTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "companySettings"
        Me.Text = "companySettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblCompanySettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblCompanySettingsBindingSource As BindingSource
    Friend WithEvents TblCompanySettingsTableAdapter As dataSetTableAdapters.tblCompanySettingsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents nmInterval As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CompanyLogoPictureBox As PictureBox
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents CompanyAddressTextBox As TextBox
    Friend WithEvents CompanyPhoneNumberTextBox As TextBox
    Friend WithEvents CurrencyTextBox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Noti_soundTextBox As TextBox
    Friend WithEvents IniTextBox As TextBox
    Friend WithEvents Is_noti_soundTextBox As TextBox
    Friend WithEvents License_periodTextBox As TextBox
    Friend WithEvents DefaultVatTextBox As TextBox
    Friend WithEvents Trader_license_noTextBox As TextBox
    Friend WithEvents Owner_nameTextBox As TextBox
    Friend WithEvents TrackBar1 As TrackBar
End Class
