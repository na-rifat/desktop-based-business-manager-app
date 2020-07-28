<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class email_sender
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_to = New System.Windows.Forms.TextBox()
        Me.txt_from = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_sub = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_save = New System.Windows.Forms.CheckBox()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.atc_panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(479, 32)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Send email"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(84, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "To:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_to
        '
        Me.txt_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_to.Location = New System.Drawing.Point(119, 51)
        Me.txt_to.Name = "txt_to"
        Me.txt_to.Size = New System.Drawing.Size(337, 23)
        Me.txt_to.TabIndex = 17
        '
        'txt_from
        '
        Me.txt_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_from.Location = New System.Drawing.Point(119, 80)
        Me.txt_from.Name = "txt_from"
        Me.txt_from.Size = New System.Drawing.Size(337, 23)
        Me.txt_from.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(69, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "From:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(119, 109)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(337, 23)
        Me.txt_password.TabIndex = 21
        Me.txt_password.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Password:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_sub
        '
        Me.txt_sub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sub.Location = New System.Drawing.Point(119, 165)
        Me.txt_sub.Name = "txt_sub"
        Me.txt_sub.Size = New System.Drawing.Size(337, 23)
        Me.txt_sub.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(54, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Subject:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chk_save
        '
        Me.chk_save.AutoSize = True
        Me.chk_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_save.ForeColor = System.Drawing.Color.White
        Me.chk_save.Location = New System.Drawing.Point(119, 138)
        Me.chk_save.Name = "chk_save"
        Me.chk_save.Size = New System.Drawing.Size(222, 21)
        Me.chk_save.TabIndex = 24
        Me.chk_save.Text = "Save user name and password"
        Me.chk_save.UseVisualStyleBackColor = True
        '
        'txt_note
        '
        Me.txt_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_note.Location = New System.Drawing.Point(119, 194)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(337, 261)
        Me.txt_note.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(71, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Note:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(23, 462)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Attachments:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_send
        '
        Me.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send.ForeColor = System.Drawing.Color.White
        Me.btn_send.Location = New System.Drawing.Point(119, 563)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(229, 49)
        Me.btn_send.TabIndex = 29
        Me.btn_send.Text = "Send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(354, 563)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 49)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'atc_panel
        '
        Me.atc_panel.Location = New System.Drawing.Point(119, 462)
        Me.atc_panel.Name = "atc_panel"
        Me.atc_panel.Size = New System.Drawing.Size(337, 95)
        Me.atc_panel.TabIndex = 31
        '
        'email_sender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 622)
        Me.Controls.Add(Me.atc_panel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chk_save)
        Me.Controls.Add(Me.txt_sub)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_from)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_to)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "email_sender"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "email_sender"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_to As TextBox
    Friend WithEvents txt_from As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_sub As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_save As CheckBox
    Friend WithEvents txt_note As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_send As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents atc_panel As FlowLayoutPanel
End Class
