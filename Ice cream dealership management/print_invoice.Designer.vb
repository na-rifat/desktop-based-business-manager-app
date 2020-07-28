<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_invoice
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_address_phone = New System.Windows.Forms.Label()
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.CompanyLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lbl_net_price = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.lbl_total_price = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_shop_name = New System.Windows.Forms.Label()
        Me.lbl_invoice_no = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtg_products = New System.Windows.Forms.DataGridView()
        Me.product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.net_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_email = New System.Windows.Forms.Button()
        Me.btn_seal = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.CompanyLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.lbl_net_price)
        Me.Panel1.Controls.Add(Me.lbl_discount)
        Me.Panel1.Controls.Add(Me.lbl_total_price)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.lbl_phone)
        Me.Panel1.Controls.Add(Me.lbl_address)
        Me.Panel1.Controls.Add(Me.lbl_shop_name)
        Me.Panel1.Controls.Add(Me.lbl_invoice_no)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.dtg_products)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(11, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 748)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbl_address_phone)
        Me.Panel5.Controls.Add(Me.lbl_header)
        Me.Panel5.Controls.Add(Me.CompanyLogoPictureBox)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(492, 47)
        Me.Panel5.TabIndex = 43
        '
        'lbl_address_phone
        '
        Me.lbl_address_phone.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_address_phone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_address_phone.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbl_address_phone.ForeColor = System.Drawing.Color.Black
        Me.lbl_address_phone.Location = New System.Drawing.Point(48, 28)
        Me.lbl_address_phone.Name = "lbl_address_phone"
        Me.lbl_address_phone.Size = New System.Drawing.Size(444, 19)
        Me.lbl_address_phone.TabIndex = 44
        Me.lbl_address_phone.Text = "Address, Phone"
        Me.lbl_address_phone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_header.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Underline)
        Me.lbl_header.ForeColor = System.Drawing.Color.Black
        Me.lbl_header.Location = New System.Drawing.Point(48, 0)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(444, 28)
        Me.lbl_header.TabIndex = 43
        Me.lbl_header.Text = "Sale invoice(Shop name)"
        Me.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompanyLogoPictureBox
        '
        Me.CompanyLogoPictureBox.BackColor = System.Drawing.Color.Gainsboro
        Me.CompanyLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CompanyLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.CompanyLogoPictureBox.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.photo
        Me.CompanyLogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.CompanyLogoPictureBox.Name = "CompanyLogoPictureBox"
        Me.CompanyLogoPictureBox.Size = New System.Drawing.Size(48, 47)
        Me.CompanyLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CompanyLogoPictureBox.TabIndex = 45
        Me.CompanyLogoPictureBox.TabStop = False
        '
        'lbl_net_price
        '
        Me.lbl_net_price.AutoSize = True
        Me.lbl_net_price.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbl_net_price.Location = New System.Drawing.Point(102, 604)
        Me.lbl_net_price.Name = "lbl_net_price"
        Me.lbl_net_price.Size = New System.Drawing.Size(36, 17)
        Me.lbl_net_price.TabIndex = 41
        Me.lbl_net_price.Text = "NaN"
        '
        'lbl_discount
        '
        Me.lbl_discount.AutoSize = True
        Me.lbl_discount.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbl_discount.Location = New System.Drawing.Point(102, 582)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(36, 17)
        Me.lbl_discount.TabIndex = 40
        Me.lbl_discount.Text = "NaN"
        '
        'lbl_total_price
        '
        Me.lbl_total_price.AutoSize = True
        Me.lbl_total_price.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbl_total_price.Location = New System.Drawing.Point(102, 560)
        Me.lbl_total_price.Name = "lbl_total_price"
        Me.lbl_total_price.Size = New System.Drawing.Size(36, 17)
        Me.lbl_total_price.TabIndex = 39
        Me.lbl_total_price.Text = "NaN"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_date.Location = New System.Drawing.Point(386, 60)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(39, 17)
        Me.lbl_date.TabIndex = 38
        Me.lbl_date.Text = "NaN"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbl_phone.Location = New System.Drawing.Point(130, 131)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(36, 17)
        Me.lbl_phone.TabIndex = 37
        Me.lbl_phone.Text = "NaN"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbl_address.Location = New System.Drawing.Point(130, 108)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(36, 17)
        Me.lbl_address.TabIndex = 36
        Me.lbl_address.Text = "NaN"
        '
        'lbl_shop_name
        '
        Me.lbl_shop_name.AutoSize = True
        Me.lbl_shop_name.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbl_shop_name.Location = New System.Drawing.Point(130, 85)
        Me.lbl_shop_name.Name = "lbl_shop_name"
        Me.lbl_shop_name.Size = New System.Drawing.Size(36, 17)
        Me.lbl_shop_name.TabIndex = 35
        Me.lbl_shop_name.Text = "NaN"
        '
        'lbl_invoice_no
        '
        Me.lbl_invoice_no.AutoSize = True
        Me.lbl_invoice_no.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_invoice_no.Location = New System.Drawing.Point(131, 60)
        Me.lbl_invoice_no.Name = "lbl_invoice_no"
        Me.lbl_invoice_no.Size = New System.Drawing.Size(39, 17)
        Me.lbl_invoice_no.TabIndex = 34
        Me.lbl_invoice_no.Text = "NaN"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(11, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 17)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "মোবাইলঃ"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(14, 602)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 18)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "নিট দামঃ"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(14, 580)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "ডিসকাউন্টঃ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(14, 558)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 18)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "মোট দামঃ"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(14, 635)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(464, 1)
        Me.Panel4.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(333, 724)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "সেলস ম্যানেজার"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(85, 724)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "গ্রাহক"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(272, 642)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 79)
        Me.Panel3.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(21, 642)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 79)
        Me.Panel2.TabIndex = 25
        '
        'dtg_products
        '
        Me.dtg_products.AllowUserToAddRows = False
        Me.dtg_products.BackgroundColor = System.Drawing.Color.White
        Me.dtg_products.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_products.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product_name, Me.unit_price, Me.quantity, Me.discount, Me.net_price})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_products.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_products.GridColor = System.Drawing.Color.White
        Me.dtg_products.Location = New System.Drawing.Point(0, 163)
        Me.dtg_products.MultiSelect = False
        Me.dtg_products.Name = "dtg_products"
        Me.dtg_products.ReadOnly = True
        Me.dtg_products.RowHeadersVisible = False
        Me.dtg_products.Size = New System.Drawing.Size(490, 374)
        Me.dtg_products.StandardTab = True
        Me.dtg_products.TabIndex = 24
        '
        'product_name
        '
        Me.product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.product_name.HeaderText = "পণ্যের নাম"
        Me.product_name.Name = "product_name"
        Me.product_name.ReadOnly = True
        '
        'unit_price
        '
        Me.unit_price.HeaderText = "দর"
        Me.unit_price.Name = "unit_price"
        Me.unit_price.ReadOnly = True
        Me.unit_price.Width = 90
        '
        'quantity
        '
        Me.quantity.HeaderText = "পরিমাণ"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 60
        '
        'discount
        '
        Me.discount.HeaderText = "ডিসকাউন্ট"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        Me.discount.Width = 72
        '
        'net_price
        '
        Me.net_price.HeaderText = "দাম"
        Me.net_price.Name = "net_price"
        Me.net_price.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(293, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 30)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "তারিখঃ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(38, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 30)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "রশিদ নং:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ঠিকানাঃ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "দোকানের নামঃ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(515, 32)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Print sale invoice"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Location = New System.Drawing.Point(148, 40)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(96, 43)
        Me.btn_print.TabIndex = 19
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(356, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 43)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_email
        '
        Me.btn_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_email.Location = New System.Drawing.Point(252, 40)
        Me.btn_email.Name = "btn_email"
        Me.btn_email.Size = New System.Drawing.Size(96, 43)
        Me.btn_email.TabIndex = 21
        Me.btn_email.Text = "Email"
        Me.btn_email.UseVisualStyleBackColor = False
        '
        'btn_seal
        '
        Me.btn_seal.BackColor = System.Drawing.Color.Transparent
        Me.btn_seal.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources._2103_512
        Me.btn_seal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_seal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seal.Location = New System.Drawing.Point(91, 40)
        Me.btn_seal.Name = "btn_seal"
        Me.btn_seal.Size = New System.Drawing.Size(47, 43)
        Me.btn_seal.TabIndex = 22
        Me.btn_seal.UseVisualStyleBackColor = False
        '
        'print_invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(532, 748)
        Me.Controls.Add(Me.btn_seal)
        Me.Controls.Add(Me.btn_email)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "print_invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "print_invoice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.CompanyLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtg_products As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_net_price As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents lbl_total_price As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_phone As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents lbl_shop_name As Label
    Friend WithEvents lbl_invoice_no As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_address_phone As Label
    Friend WithEvents lbl_header As Label
    Friend WithEvents CompanyLogoPictureBox As PictureBox
    Friend WithEvents btn_email As Button
    Friend WithEvents btn_seal As Button
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents unit_price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
    Friend WithEvents net_price As DataGridViewTextBoxColumn
End Class
