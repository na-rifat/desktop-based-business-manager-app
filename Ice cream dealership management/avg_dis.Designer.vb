<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class avg_dis
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.lbl_grand = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.Black
        Label4.Font = New System.Drawing.Font("Verdana", 12.0!)
        Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label4.Location = New System.Drawing.Point(67, 32)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(87, 25)
        Label4.TabIndex = 86
        Label4.Text = "ডিসকাউন্টঃ"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Black
        Label2.Font = New System.Drawing.Font("Verdana", 12.0!)
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(67, 58)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(87, 25)
        Label2.TabIndex = 87
        Label2.Text = "নিট দামঃ"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.TextBox1.Location = New System.Drawing.Point(12, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 33)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ডিসকাউন্টের শতকরা (%) হারঃ"
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(272, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 36)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(272, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 36)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(67, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 25)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "মোট দামঃ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.Black
        Me.lbl_total.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbl_total.ForeColor = System.Drawing.Color.White
        Me.lbl_total.Location = New System.Drawing.Point(156, 6)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_total.Size = New System.Drawing.Size(265, 25)
        Me.lbl_total.TabIndex = 88
        Me.lbl_total.Text = "0000"
        '
        'lbl_discount
        '
        Me.lbl_discount.BackColor = System.Drawing.Color.Black
        Me.lbl_discount.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbl_discount.ForeColor = System.Drawing.Color.White
        Me.lbl_discount.Location = New System.Drawing.Point(156, 32)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_discount.Size = New System.Drawing.Size(265, 25)
        Me.lbl_discount.TabIndex = 89
        Me.lbl_discount.Text = "0000"
        '
        'lbl_grand
        '
        Me.lbl_grand.BackColor = System.Drawing.Color.Black
        Me.lbl_grand.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.lbl_grand.ForeColor = System.Drawing.Color.White
        Me.lbl_grand.Location = New System.Drawing.Point(156, 58)
        Me.lbl_grand.Name = "lbl_grand"
        Me.lbl_grand.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_grand.Size = New System.Drawing.Size(265, 25)
        Me.lbl_grand.TabIndex = 90
        Me.lbl_grand.Text = "0000"
        '
        'avg_dis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(489, 184)
        Me.Controls.Add(Me.lbl_grand)
        Me.Controls.Add(Me.lbl_discount)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "avg_dis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "avg_dis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents lbl_grand As Label
End Class
