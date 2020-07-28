<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock_statement
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.product_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.available = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_profitcanearn = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_products_maket_value = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_products_value = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_shop_name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CompanyLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_email = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dtg1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.docking_panel = New System.Windows.Forms.Panel()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CompanyLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dtg)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(5, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 980)
        Me.Panel1.TabIndex = 0
        '
        'dtg
        '
        Me.dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg.BackgroundColor = System.Drawing.Color.White
        Me.dtg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product_code, Me.product_name, Me.company, Me.available})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.GridColor = System.Drawing.Color.White
        Me.dtg.Location = New System.Drawing.Point(0, 152)
        Me.dtg.Name = "dtg"
        Me.dtg.RowHeadersVisible = False
        Me.dtg.RowHeadersWidth = 50
        Me.dtg.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dtg.Size = New System.Drawing.Size(760, 800)
        Me.dtg.TabIndex = 4
        '
        'product_code
        '
        Me.product_code.HeaderText = "কোড"
        Me.product_code.Name = "product_code"
        '
        'product_name
        '
        Me.product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.product_name.HeaderText = "পণ্যের নাম"
        Me.product_name.MinimumWidth = 200
        Me.product_name.Name = "product_name"
        '
        'company
        '
        Me.company.HeaderText = "কোম্পানি"
        Me.company.MinimumWidth = 300
        Me.company.Name = "company"
        Me.company.Width = 300
        '
        'available
        '
        Me.available.HeaderText = "মজুত"
        Me.available.Name = "available"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 952)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(760, 28)
        Me.Panel4.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(461, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(299, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Powered by Rafalo Technologies © 2019"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbl_date)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lbl_profitcanearn)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lbl_products_maket_value)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.lbl_products_value)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(760, 101)
        Me.Panel3.TabIndex = 2
        '
        'lbl_profitcanearn
        '
        Me.lbl_profitcanearn.AutoSize = True
        Me.lbl_profitcanearn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_profitcanearn.Location = New System.Drawing.Point(180, 71)
        Me.lbl_profitcanearn.Name = "lbl_profitcanearn"
        Me.lbl_profitcanearn.Size = New System.Drawing.Size(114, 20)
        Me.lbl_profitcanearn.TabIndex = 5
        Me.lbl_profitcanearn.Text = "---------------------"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(8, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "সম্ভাব্য লভ্যাংশঃ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_products_maket_value
        '
        Me.lbl_products_maket_value.AutoSize = True
        Me.lbl_products_maket_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_products_maket_value.Location = New System.Drawing.Point(180, 41)
        Me.lbl_products_maket_value.Name = "lbl_products_maket_value"
        Me.lbl_products_maket_value.Size = New System.Drawing.Size(114, 20)
        Me.lbl_products_maket_value.TabIndex = 3
        Me.lbl_products_maket_value.Text = "---------------------"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(8, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "মজুতপণ্যের বাজারমূল্যঃ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_products_value
        '
        Me.lbl_products_value.AutoSize = True
        Me.lbl_products_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_products_value.Location = New System.Drawing.Point(180, 11)
        Me.lbl_products_value.Name = "lbl_products_value"
        Me.lbl_products_value.Size = New System.Drawing.Size(114, 20)
        Me.lbl_products_value.TabIndex = 1
        Me.lbl_products_value.Text = "---------------------"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "মজুতপণ্যের মূল্যঃ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_shop_name)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CompanyLogoPictureBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 51)
        Me.Panel2.TabIndex = 1
        '
        'lbl_shop_name
        '
        Me.lbl_shop_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_shop_name.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_shop_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_shop_name.Location = New System.Drawing.Point(51, 29)
        Me.lbl_shop_name.Name = "lbl_shop_name"
        Me.lbl_shop_name.Size = New System.Drawing.Size(709, 22)
        Me.lbl_shop_name.TabIndex = 4
        Me.lbl_shop_name.Text = "Shop name, address, phone"
        Me.lbl_shop_name.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(51, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(709, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "মজুত পণ্যের বিবরণ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompanyLogoPictureBox
        '
        Me.CompanyLogoPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CompanyLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CompanyLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.CompanyLogoPictureBox.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.photo
        Me.CompanyLogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.CompanyLogoPictureBox.Name = "CompanyLogoPictureBox"
        Me.CompanyLogoPictureBox.Size = New System.Drawing.Size(51, 51)
        Me.CompanyLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CompanyLogoPictureBox.TabIndex = 46
        Me.CompanyLogoPictureBox.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(472, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 52)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_email
        '
        Me.btn_email.BackColor = System.Drawing.Color.Green
        Me.btn_email.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_email.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btn_email.Location = New System.Drawing.Point(325, 31)
        Me.btn_email.Name = "btn_email"
        Me.btn_email.Size = New System.Drawing.Size(141, 52)
        Me.btn_email.TabIndex = 3
        Me.btn_email.Text = "Email"
        Me.btn_email.UseVisualStyleBackColor = False
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_print.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btn_print.Location = New System.Drawing.Point(178, 31)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(141, 52)
        Me.btn_print.TabIndex = 4
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.dtg1)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Location = New System.Drawing.Point(773, 89)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(760, 980)
        Me.Panel5.TabIndex = 7
        '
        'dtg1
        '
        Me.dtg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg1.BackgroundColor = System.Drawing.Color.White
        Me.dtg1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg1.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg1.GridColor = System.Drawing.Color.White
        Me.dtg1.Location = New System.Drawing.Point(0, 29)
        Me.dtg1.Name = "dtg1"
        Me.dtg1.RowHeadersVisible = False
        Me.dtg1.RowHeadersWidth = 50
        Me.dtg1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dtg1.Size = New System.Drawing.Size(760, 923)
        Me.dtg1.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "কোড"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "পণ্যের নাম"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "কোম্পানি"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 300
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "মজুত"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 952)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(760, 28)
        Me.Panel6.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(461, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Powered by Rafalo Technologies © 2019"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label14)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(760, 29)
        Me.Panel8.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(760, 29)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "মজুত পণ্যের বিবরণ"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'docking_panel
        '
        Me.docking_panel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.docking_panel.Location = New System.Drawing.Point(188, 33)
        Me.docking_panel.Name = "docking_panel"
        Me.docking_panel.Size = New System.Drawing.Size(56, 34)
        Me.docking_panel.TabIndex = 8
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_date.Location = New System.Drawing.Point(621, 16)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(135, 20)
        Me.lbl_date.TabIndex = 7
        Me.lbl_date.Text = "---------------------"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(471, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "তারিখঃ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'stock_statement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1508, 819)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_email)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.docking_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stock_statement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stock_statement"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.CompanyLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_shop_name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CompanyLogoPictureBox As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_email As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents lbl_profitcanearn As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_products_maket_value As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_products_value As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents dtg As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents docking_panel As Panel
    Friend WithEvents product_code As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents company As DataGridViewTextBoxColumn
    Friend WithEvents available As DataGridViewTextBoxColumn
    Friend WithEvents dtg1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label6 As Label
End Class
