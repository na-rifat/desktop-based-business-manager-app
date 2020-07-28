<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addEmployee
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
        Dim MaritialStatusLabel As System.Windows.Forms.Label
        Dim BloodGroupLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim EmployeeNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim NIDNumberLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim EmployeeNoteLabel As System.Windows.Forms.Label
        Dim JoinDateLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim PaymentLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PinTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.MaritialStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.BloodGroupComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NIDNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ReligionTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeNoteTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateOfBirthTextBox = New System.Windows.Forms.TextBox()
        Me.JoinDateTextBox = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblEmployeeTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblEmployeeTableAdapter()
        MaritialStatusLabel = New System.Windows.Forms.Label()
        BloodGroupLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        EmployeeNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        NIDNumberLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        EmployeeNoteLabel = New System.Windows.Forms.Label()
        JoinDateLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        PaymentLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaritialStatusLabel
        '
        MaritialStatusLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        MaritialStatusLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        MaritialStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        MaritialStatusLabel.Location = New System.Drawing.Point(6, 86)
        MaritialStatusLabel.Margin = New System.Windows.Forms.Padding(0)
        MaritialStatusLabel.Name = "MaritialStatusLabel"
        MaritialStatusLabel.Size = New System.Drawing.Size(161, 25)
        MaritialStatusLabel.TabIndex = 57
        MaritialStatusLabel.Text = "বৈবাহিক অবস্থাঃ"
        MaritialStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BloodGroupLabel
        '
        BloodGroupLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        BloodGroupLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        BloodGroupLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        BloodGroupLabel.Location = New System.Drawing.Point(6, 112)
        BloodGroupLabel.Margin = New System.Windows.Forms.Padding(0)
        BloodGroupLabel.Name = "BloodGroupLabel"
        BloodGroupLabel.Size = New System.Drawing.Size(161, 25)
        BloodGroupLabel.TabIndex = 55
        BloodGroupLabel.Text = "রক্তের গ্রুপঃ"
        BloodGroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GenderLabel
        '
        GenderLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        GenderLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        GenderLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        GenderLabel.Location = New System.Drawing.Point(6, 190)
        GenderLabel.Margin = New System.Windows.Forms.Padding(0)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(161, 25)
        GenderLabel.TabIndex = 53
        GenderLabel.Text = "লিঙঃ"
        GenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmployeeNameLabel
        '
        EmployeeNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        EmployeeNameLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        EmployeeNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        EmployeeNameLabel.Location = New System.Drawing.Point(6, 8)
        EmployeeNameLabel.Margin = New System.Windows.Forms.Padding(0)
        EmployeeNameLabel.Name = "EmployeeNameLabel"
        EmployeeNameLabel.Size = New System.Drawing.Size(161, 25)
        EmployeeNameLabel.TabIndex = 36
        EmployeeNameLabel.Text = "নামঃ"
        EmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddressLabel
        '
        AddressLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        AddressLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        AddressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        AddressLabel.Location = New System.Drawing.Point(6, 34)
        AddressLabel.Margin = New System.Windows.Forms.Padding(0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(161, 25)
        AddressLabel.TabIndex = 38
        AddressLabel.Text = "ঠিকানাঃ"
        AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DateOfBirthLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateOfBirthLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DateOfBirthLabel.Location = New System.Drawing.Point(6, 60)
        DateOfBirthLabel.Margin = New System.Windows.Forms.Padding(0)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(161, 25)
        DateOfBirthLabel.TabIndex = 40
        DateOfBirthLabel.Text = "জন্ম তারিখঃ"
        DateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NIDNumberLabel
        '
        NIDNumberLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        NIDNumberLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        NIDNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        NIDNumberLabel.Location = New System.Drawing.Point(6, 138)
        NIDNumberLabel.Margin = New System.Windows.Forms.Padding(0)
        NIDNumberLabel.Name = "NIDNumberLabel"
        NIDNumberLabel.Size = New System.Drawing.Size(161, 25)
        NIDNumberLabel.TabIndex = 42
        NIDNumberLabel.Text = "এন আই ডি নাম্বারঃ"
        NIDNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ReligionLabel
        '
        ReligionLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ReligionLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ReligionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ReligionLabel.Location = New System.Drawing.Point(6, 164)
        ReligionLabel.Margin = New System.Windows.Forms.Padding(0)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(161, 25)
        ReligionLabel.TabIndex = 44
        ReligionLabel.Text = "ধর্মঃ"
        ReligionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ContactNumberLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        ContactNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ContactNumberLabel.Location = New System.Drawing.Point(6, 216)
        ContactNumberLabel.Margin = New System.Windows.Forms.Padding(0)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(161, 25)
        ContactNumberLabel.TabIndex = 46
        ContactNumberLabel.Text = "মোবাইলঃ"
        ContactNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmployeeNoteLabel
        '
        EmployeeNoteLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        EmployeeNoteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        EmployeeNoteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        EmployeeNoteLabel.Location = New System.Drawing.Point(6, 242)
        EmployeeNoteLabel.Margin = New System.Windows.Forms.Padding(0)
        EmployeeNoteLabel.Name = "EmployeeNoteLabel"
        EmployeeNoteLabel.Size = New System.Drawing.Size(161, 25)
        EmployeeNoteLabel.TabIndex = 48
        EmployeeNoteLabel.Text = "মন্তব্যঃ"
        EmployeeNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'JoinDateLabel
        '
        JoinDateLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        JoinDateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        JoinDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        JoinDateLabel.Location = New System.Drawing.Point(6, 268)
        JoinDateLabel.Margin = New System.Windows.Forms.Padding(0)
        JoinDateLabel.Name = "JoinDateLabel"
        JoinDateLabel.Size = New System.Drawing.Size(161, 25)
        JoinDateLabel.TabIndex = 50
        JoinDateLabel.Text = "নিয়োগের তারিখঃ"
        JoinDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdLabel
        '
        IdLabel.BackColor = System.Drawing.Color.Black
        IdLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        IdLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        IdLabel.Location = New System.Drawing.Point(6, 321)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(161, 25)
        IdLabel.TabIndex = 61
        IdLabel.Text = "কর্মচারির আইডিঃ"
        IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Black
        Label2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(6, 348)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(161, 25)
        Label2.TabIndex = 64
        Label2.Text = "পিন কোডঃ"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaymentLabel
        '
        PaymentLabel.BackColor = System.Drawing.Color.Black
        PaymentLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        PaymentLabel.ForeColor = System.Drawing.Color.White
        PaymentLabel.Location = New System.Drawing.Point(6, 294)
        PaymentLabel.Name = "PaymentLabel"
        PaymentLabel.Size = New System.Drawing.Size(161, 25)
        PaymentLabel.TabIndex = 65
        PaymentLabel.Text = "বেতনঃ"
        PaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "কর্মচারি নিয়োগ করুন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(PaymentLabel)
        Me.Panel1.Controls.Add(Me.PaymentTextBox)
        Me.Panel1.Controls.Add(Me.PinTextBox)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(IdLabel)
        Me.Panel1.Controls.Add(Me.IdLabel1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PicturePictureBox)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(MaritialStatusLabel)
        Me.Panel1.Controls.Add(Me.MaritialStatusComboBox)
        Me.Panel1.Controls.Add(BloodGroupLabel)
        Me.Panel1.Controls.Add(Me.BloodGroupComboBox)
        Me.Panel1.Controls.Add(GenderLabel)
        Me.Panel1.Controls.Add(Me.GenderComboBox)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(EmployeeNameLabel)
        Me.Panel1.Controls.Add(Me.EmployeeNameTextBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(DateOfBirthLabel)
        Me.Panel1.Controls.Add(NIDNumberLabel)
        Me.Panel1.Controls.Add(Me.NIDNumberTextBox)
        Me.Panel1.Controls.Add(ReligionLabel)
        Me.Panel1.Controls.Add(Me.ReligionTextBox)
        Me.Panel1.Controls.Add(ContactNumberLabel)
        Me.Panel1.Controls.Add(Me.ContactNumberTextBox)
        Me.Panel1.Controls.Add(EmployeeNoteLabel)
        Me.Panel1.Controls.Add(Me.EmployeeNoteTextBox)
        Me.Panel1.Controls.Add(JoinDateLabel)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(143, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(714, 421)
        Me.Panel1.TabIndex = 5
        '
        'PaymentTextBox
        '
        Me.PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "payment", True))
        Me.PaymentTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PaymentTextBox.Location = New System.Drawing.Point(174, 285)
        Me.PaymentTextBox.Name = "PaymentTextBox"
        Me.PaymentTextBox.Size = New System.Drawing.Size(252, 24)
        Me.PaymentTextBox.TabIndex = 66
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataMember = "tblEmployee"
        Me.TblEmployeeBindingSource.DataSource = Me.DataSet
        '
        'PinTextBox
        '
        Me.PinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "pin", True))
        Me.PinTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.PinTextBox.Location = New System.Drawing.Point(174, 343)
        Me.PinTextBox.MaxLength = 6
        Me.PinTextBox.Name = "PinTextBox"
        Me.PinTextBox.Size = New System.Drawing.Size(106, 24)
        Me.PinTextBox.TabIndex = 65
        Me.PinTextBox.UseSystemPasswordChar = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(391, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 63
        Me.Button3.UseVisualStyleBackColor = False
        '
        'IdLabel1
        '
        Me.IdLabel1.BackColor = System.Drawing.Color.Black
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "Id", True))
        Me.IdLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.IdLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IdLabel1.Location = New System.Drawing.Point(174, 315)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Padding = New System.Windows.Forms.Padding(4)
        Me.IdLabel1.Size = New System.Drawing.Size(106, 25)
        Me.IdLabel1.TabIndex = 62
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Location = New System.Drawing.Point(445, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(257, 35)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.photo
        Me.PicturePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblEmployeeBindingSource, "picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(445, 4)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(257, 258)
        Me.PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicturePictureBox.TabIndex = 60
        Me.PicturePictureBox.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(175, 60)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(250, 24)
        Me.DateTimePicker2.TabIndex = 59
        '
        'MaritialStatusComboBox
        '
        Me.MaritialStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "maritialStatus", True))
        Me.MaritialStatusComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MaritialStatusComboBox.FormattingEnabled = True
        Me.MaritialStatusComboBox.Items.AddRange(New Object() {"Married", "Non-married"})
        Me.MaritialStatusComboBox.Location = New System.Drawing.Point(175, 85)
        Me.MaritialStatusComboBox.Margin = New System.Windows.Forms.Padding(0)
        Me.MaritialStatusComboBox.Name = "MaritialStatusComboBox"
        Me.MaritialStatusComboBox.Size = New System.Drawing.Size(250, 24)
        Me.MaritialStatusComboBox.TabIndex = 58
        '
        'BloodGroupComboBox
        '
        Me.BloodGroupComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "bloodGroup", True))
        Me.BloodGroupComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.BloodGroupComboBox.FormattingEnabled = True
        Me.BloodGroupComboBox.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "O+", "AB+", "AB-"})
        Me.BloodGroupComboBox.Location = New System.Drawing.Point(175, 110)
        Me.BloodGroupComboBox.Margin = New System.Windows.Forms.Padding(0)
        Me.BloodGroupComboBox.Name = "BloodGroupComboBox"
        Me.BloodGroupComboBox.Size = New System.Drawing.Size(250, 24)
        Me.BloodGroupComboBox.TabIndex = 56
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "gender", True))
        Me.GenderComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(175, 185)
        Me.GenderComboBox.Margin = New System.Windows.Forms.Padding(0)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(251, 24)
        Me.GenderComboBox.TabIndex = 54
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(175, 260)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(251, 24)
        Me.DateTimePicker1.TabIndex = 52
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "employeeName", True))
        Me.EmployeeNameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(175, 10)
        Me.EmployeeNameTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(250, 24)
        Me.EmployeeNameTextBox.TabIndex = 37
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(175, 35)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(250, 24)
        Me.AddressTextBox.TabIndex = 39
        '
        'NIDNumberTextBox
        '
        Me.NIDNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "NIDNumber", True))
        Me.NIDNumberTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.NIDNumberTextBox.Location = New System.Drawing.Point(175, 135)
        Me.NIDNumberTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.NIDNumberTextBox.Name = "NIDNumberTextBox"
        Me.NIDNumberTextBox.Size = New System.Drawing.Size(250, 24)
        Me.NIDNumberTextBox.TabIndex = 43
        '
        'ReligionTextBox
        '
        Me.ReligionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "religion", True))
        Me.ReligionTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ReligionTextBox.Location = New System.Drawing.Point(174, 160)
        Me.ReligionTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.ReligionTextBox.Name = "ReligionTextBox"
        Me.ReligionTextBox.Size = New System.Drawing.Size(251, 24)
        Me.ReligionTextBox.TabIndex = 45
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "contactNumber", True))
        Me.ContactNumberTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(174, 210)
        Me.ContactNumberTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(251, 24)
        Me.ContactNumberTextBox.TabIndex = 47
        '
        'EmployeeNoteTextBox
        '
        Me.EmployeeNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "employeeNote", True))
        Me.EmployeeNoteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.EmployeeNoteTextBox.Location = New System.Drawing.Point(174, 235)
        Me.EmployeeNoteTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.EmployeeNoteTextBox.Name = "EmployeeNoteTextBox"
        Me.EmployeeNoteTextBox.Size = New System.Drawing.Size(251, 24)
        Me.EmployeeNoteTextBox.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(174, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 35)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "নিয়োগ করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateOfBirthTextBox
        '
        Me.DateOfBirthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "dateOfBirth", True))
        Me.DateOfBirthTextBox.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfBirthTextBox.Location = New System.Drawing.Point(9, -8)
        Me.DateOfBirthTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.DateOfBirthTextBox.Name = "DateOfBirthTextBox"
        Me.DateOfBirthTextBox.Size = New System.Drawing.Size(45, 40)
        Me.DateOfBirthTextBox.TabIndex = 41
        '
        'JoinDateTextBox
        '
        Me.JoinDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmployeeBindingSource, "joinDate", True))
        Me.JoinDateTextBox.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JoinDateTextBox.Location = New System.Drawing.Point(9, -8)
        Me.JoinDateTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.JoinDateTextBox.Name = "JoinDateTextBox"
        Me.JoinDateTextBox.Size = New System.Drawing.Size(45, 40)
        Me.JoinDateTextBox.TabIndex = 51
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
        Me.TableAdapterManager.tblEmployeeTableAdapter = Me.TblEmployeeTableAdapter
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
        'TblEmployeeTableAdapter
        '
        Me.TblEmployeeTableAdapter.ClearBeforeFill = True
        '
        'addEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateOfBirthTextBox)
        Me.Controls.Add(Me.JoinDateTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addEmployee"
        Me.Text = "addEmployee"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblEmployeeBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents MaritialStatusComboBox As ComboBox
    Friend WithEvents BloodGroupComboBox As ComboBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents DateOfBirthTextBox As TextBox
    Friend WithEvents NIDNumberTextBox As TextBox
    Friend WithEvents ReligionTextBox As TextBox
    Friend WithEvents ContactNumberTextBox As TextBox
    Friend WithEvents EmployeeNoteTextBox As TextBox
    Friend WithEvents JoinDateTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblEmployeeTableAdapter As dataSetTableAdapters.tblEmployeeTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents PicturePictureBox As PictureBox
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PinTextBox As TextBox
    Friend WithEvents PaymentTextBox As TextBox
End Class
