<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class documents
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
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Document_nameLabel As System.Windows.Forms.Label
        Dim SerialLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblDocumentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDocumentsTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblDocumentsTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFilter = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RemarkTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.Document_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DocumentPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        RemarkLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Document_nameLabel = New System.Windows.Forms.Label()
        SerialLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDocumentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DocumentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.BackColor = System.Drawing.Color.Black
        RemarkLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        RemarkLabel.ForeColor = System.Drawing.Color.White
        RemarkLabel.Location = New System.Drawing.Point(120, 131)
        RemarkLabel.Margin = New System.Windows.Forms.Padding(3)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Padding = New System.Windows.Forms.Padding(4)
        RemarkLabel.Size = New System.Drawing.Size(75, 25)
        RemarkLabel.TabIndex = 28
        RemarkLabel.Text = "Remark:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.BackColor = System.Drawing.Color.Black
        DateLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        DateLabel.ForeColor = System.Drawing.Color.White
        DateLabel.Location = New System.Drawing.Point(140, 105)
        DateLabel.Margin = New System.Windows.Forms.Padding(3)
        DateLabel.Name = "DateLabel"
        DateLabel.Padding = New System.Windows.Forms.Padding(4)
        DateLabel.Size = New System.Drawing.Size(55, 25)
        DateLabel.TabIndex = 26
        DateLabel.Text = "Date:"
        '
        'Document_nameLabel
        '
        Document_nameLabel.AutoSize = True
        Document_nameLabel.BackColor = System.Drawing.Color.Black
        Document_nameLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Document_nameLabel.ForeColor = System.Drawing.Color.White
        Document_nameLabel.Location = New System.Drawing.Point(58, 53)
        Document_nameLabel.Margin = New System.Windows.Forms.Padding(3)
        Document_nameLabel.Name = "Document_nameLabel"
        Document_nameLabel.Padding = New System.Windows.Forms.Padding(4)
        Document_nameLabel.Size = New System.Drawing.Size(137, 25)
        Document_nameLabel.TabIndex = 21
        Document_nameLabel.Text = "Document name:"
        '
        'SerialLabel
        '
        SerialLabel.AutoSize = True
        SerialLabel.BackColor = System.Drawing.Color.Black
        SerialLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        SerialLabel.ForeColor = System.Drawing.Color.White
        SerialLabel.Location = New System.Drawing.Point(135, 27)
        SerialLabel.Margin = New System.Windows.Forms.Padding(3)
        SerialLabel.Name = "SerialLabel"
        SerialLabel.Padding = New System.Windows.Forms.Padding(4)
        SerialLabel.Size = New System.Drawing.Size(60, 25)
        SerialLabel.TabIndex = 24
        SerialLabel.Text = "Serial:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.BackColor = System.Drawing.Color.Black
        CategoryLabel.Font = New System.Drawing.Font("Verdana", 10.0!)
        CategoryLabel.ForeColor = System.Drawing.Color.White
        CategoryLabel.Location = New System.Drawing.Point(109, 79)
        CategoryLabel.Margin = New System.Windows.Forms.Padding(3)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Padding = New System.Windows.Forms.Padding(4)
        CategoryLabel.Size = New System.Drawing.Size(86, 25)
        CategoryLabel.TabIndex = 23
        CategoryLabel.Text = "Category:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Documents"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDocumentsBindingSource
        '
        Me.TblDocumentsBindingSource.DataMember = "tblDocuments"
        Me.TblDocumentsBindingSource.DataSource = Me.DataSet
        '
        'TblDocumentsTableAdapter
        '
        Me.TblDocumentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager.tblDocumentsTableAdapter = Me.TblDocumentsTableAdapter
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.DocumentPictureBox)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 533)
        Me.Panel1.TabIndex = 18
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.SteelBlue
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(789, 402)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 65)
        Me.Button7.TabIndex = 92
        Me.Button7.Text = ">"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.SteelBlue
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(603, 402)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 65)
        Me.Button6.TabIndex = 91
        Me.Button6.Text = "<"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.blue_delete_button_png_29
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Location = New System.Drawing.Point(751, 136)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 50)
        Me.Button5.TabIndex = 90
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.button_circle_add_512
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Location = New System.Drawing.Point(651, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 50)
        Me.Button4.TabIndex = 89
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtFilter)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(585, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 64)
        Me.Panel2.TabIndex = 36
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.FormattingEnabled = True
        Me.txtFilter.Items.AddRange(New Object() {"Product name", "Product code"})
        Me.txtFilter.Location = New System.Drawing.Point(106, 5)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(162, 24)
        Me.txtFilter.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(36, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(4)
        Me.Label5.Size = New System.Drawing.Size(64, 25)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(106, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(162, 24)
        Me.txtSearch.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(13, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(4)
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Search By"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(RemarkLabel)
        Me.GroupBox1.Controls.Add(Me.RemarkTextBox)
        Me.GroupBox1.Controls.Add(Me.CategoryComboBox)
        Me.GroupBox1.Controls.Add(DateLabel)
        Me.GroupBox1.Controls.Add(Me.DateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.SerialTextBox)
        Me.GroupBox1.Controls.Add(Document_nameLabel)
        Me.GroupBox1.Controls.Add(SerialLabel)
        Me.GroupBox1.Controls.Add(Me.Document_nameTextBox)
        Me.GroupBox1.Controls.Add(CategoryLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(486, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 204)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New document"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(201, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 35)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDocumentsBindingSource, "remark", True))
        Me.RemarkTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.RemarkTextBox.Location = New System.Drawing.Point(201, 127)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(220, 24)
        Me.RemarkTextBox.TabIndex = 30
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDocumentsBindingSource, "category", True))
        Me.CategoryComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(201, 77)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(220, 24)
        Me.CategoryComboBox.TabIndex = 29
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblDocumentsBindingSource, "date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(201, 102)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(220, 24)
        Me.DateDateTimePicker.TabIndex = 27
        '
        'SerialTextBox
        '
        Me.SerialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDocumentsBindingSource, "serial", True))
        Me.SerialTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SerialTextBox.Location = New System.Drawing.Point(201, 27)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(220, 24)
        Me.SerialTextBox.TabIndex = 25
        '
        'Document_nameTextBox
        '
        Me.Document_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDocumentsBindingSource, "document_name", True))
        Me.Document_nameTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Document_nameTextBox.Location = New System.Drawing.Point(201, 52)
        Me.Document_nameTextBox.Name = "Document_nameTextBox"
        Me.Document_nameTextBox.Size = New System.Drawing.Size(220, 24)
        Me.Document_nameTextBox.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.video_player_13_512
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(711, 402)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 65)
        Me.Button3.TabIndex = 88
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DocumentPictureBox
        '
        Me.DocumentPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblDocumentsBindingSource, "document", True))
        Me.DocumentPictureBox.Image = Global.Ice_cream_dealership_management.My.Resources.Resources.photo
        Me.DocumentPictureBox.Location = New System.Drawing.Point(3, 5)
        Me.DocumentPictureBox.Name = "DocumentPictureBox"
        Me.DocumentPictureBox.Size = New System.Drawing.Size(457, 521)
        Me.DocumentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DocumentPictureBox.TabIndex = 17
        Me.DocumentPictureBox.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.kisspng_computer_icons_editing_delete_button_5abced852e1b50_7972989815223310131889
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(701, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 87
        Me.Button2.UseVisualStyleBackColor = True
        '
        'documents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "documents"
        Me.Text = "documents"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDocumentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DocumentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblDocumentsBindingSource As BindingSource
    Friend WithEvents TblDocumentsTableAdapter As dataSetTableAdapters.tblDocumentsTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents DocumentPictureBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RemarkTextBox As TextBox
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents Document_nameTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtFilter As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
End Class
