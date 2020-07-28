<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addNote
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
        Dim TimeLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim SubmittedByLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet = New Ice_cream_dealership_management.dataSet()
        Me.TblNotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblNotesTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblNotesTableAdapter()
        Me.TableAdapterManager = New Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager()
        Me.TblUserTableAdapter = New Ice_cream_dealership_management.dataSetTableAdapters.tblUserTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.dtTime = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.SubmittedByTextBox = New System.Windows.Forms.TextBox()
        Me.TimeTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        TimeLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        SubmittedByLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimeLabel
        '
        TimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        TimeLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        TimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        TimeLabel.Location = New System.Drawing.Point(15, 6)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New System.Drawing.Size(117, 25)
        TimeLabel.TabIndex = 17
        TimeLabel.Text = "সময়ঃ"
        TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateLabel
        '
        DateLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DateLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DateLabel.Location = New System.Drawing.Point(15, 32)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(117, 25)
        DateLabel.TabIndex = 19
        DateLabel.Text = "তারিখঃ"
        DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NoteLabel
        '
        NoteLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        NoteLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        NoteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        NoteLabel.Location = New System.Drawing.Point(15, 58)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(117, 25)
        NoteLabel.TabIndex = 21
        NoteLabel.Text = "নোটিশ/শিডিউলঃ"
        NoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SubmittedByLabel
        '
        SubmittedByLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        SubmittedByLabel.Font = New System.Drawing.Font("Verdana", 14.0!)
        SubmittedByLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        SubmittedByLabel.Location = New System.Drawing.Point(15, 84)
        SubmittedByLabel.Name = "SubmittedByLabel"
        SubmittedByLabel.Size = New System.Drawing.Size(117, 25)
        SubmittedByLabel.TabIndex = 23
        SubmittedByLabel.Text = "স্বাক্ষরঃ"
        SubmittedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.Text = "নোটিশ অথবা কাজের শিডিউল যুক্ত করুন"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "dataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblNotesBindingSource
        '
        Me.TblNotesBindingSource.DataMember = "tblNotes"
        Me.TblNotesBindingSource.DataSource = Me.DataSet
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
        Me.TableAdapterManager.tblInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tblNotesTableAdapter = Me.TblNotesTableAdapter
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
        Me.TableAdapterManager.tblUserTableAdapter = Me.TblUserTableAdapter
        Me.TableAdapterManager.tblVehicleAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tblVehicleTableAdapter = Nothing
        Me.TableAdapterManager.tblwithdrawTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ice_cream_dealership_management.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblUserTableAdapter
        '
        Me.TblUserTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtDate)
        Me.Panel1.Controls.Add(Me.dtTime)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(TimeLabel)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(DateLabel)
        Me.Panel1.Controls.Add(NoteLabel)
        Me.Panel1.Controls.Add(Me.NoteTextBox)
        Me.Panel1.Controls.Add(SubmittedByLabel)
        Me.Panel1.Controls.Add(Me.SubmittedByTextBox)
        Me.Panel1.Location = New System.Drawing.Point(240, 245)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 160)
        Me.Panel1.TabIndex = 5
        '
        'dtDate
        '
        Me.dtDate.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(138, 30)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(134, 24)
        Me.dtDate.TabIndex = 67
        '
        'dtTime
        '
        Me.dtTime.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtTime.Location = New System.Drawing.Point(138, 5)
        Me.dtTime.Name = "dtTime"
        Me.dtTime.Size = New System.Drawing.Size(134, 24)
        Me.dtTime.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.BackgroundImage = Global.Ice_cream_dealership_management.My.Resources.Resources.index2
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(365, 109)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 66
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(138, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(221, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "যুক্ত করুন"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NoteTextBox
        '
        Me.NoteTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblNotesBindingSource, "note", True))
        Me.NoteTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.NoteTextBox.ForeColor = System.Drawing.Color.Lime
        Me.NoteTextBox.Location = New System.Drawing.Point(138, 55)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(364, 24)
        Me.NoteTextBox.TabIndex = 22
        '
        'SubmittedByTextBox
        '
        Me.SubmittedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblNotesBindingSource, "submittedBy", True))
        Me.SubmittedByTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SubmittedByTextBox.Location = New System.Drawing.Point(138, 80)
        Me.SubmittedByTextBox.Name = "SubmittedByTextBox"
        Me.SubmittedByTextBox.Size = New System.Drawing.Size(364, 24)
        Me.SubmittedByTextBox.TabIndex = 24
        '
        'TimeTextBox
        '
        Me.TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblNotesBindingSource, "time", True))
        Me.TimeTextBox.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeTextBox.Location = New System.Drawing.Point(78, -20)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.Size = New System.Drawing.Size(35, 40)
        Me.TimeTextBox.TabIndex = 18
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblNotesBindingSource, "date", True))
        Me.DateTextBox.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTextBox.Location = New System.Drawing.Point(78, -20)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(35, 40)
        Me.DateTextBox.TabIndex = 20
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserBindingSource, "userName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(78, 12)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(23, 20)
        Me.UserNameTextBox.TabIndex = 6
        '
        'TblUserBindingSource
        '
        Me.TblUserBindingSource.DataMember = "tblUser"
        Me.TblUserBindingSource.DataSource = Me.DataSet
        '
        'addNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TimeTextBox)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.DateTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addNote"
        Me.Text = "*"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblNotesBindingSource As BindingSource
    Friend WithEvents TblNotesTableAdapter As dataSetTableAdapters.tblNotesTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TimeTextBox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents SubmittedByTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TblUserBindingSource As BindingSource
    Friend WithEvents TblUserTableAdapter As dataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents dtTime As DateTimePicker
End Class
