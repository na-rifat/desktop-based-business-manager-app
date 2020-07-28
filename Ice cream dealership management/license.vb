Public Class license
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub license_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblCompanySettings' table. You can move, or remove it, as needed.
        Me.TblCompanySettingsTableAdapter.Fill(Me.DataSet.tblCompanySettings)
        'selection
        txt_product_id.Select()
        slt(txt_product_id, txt_license_code)
        slt(txt_license_code, txt_admin_user_id)
        slt(txt_admin_user_id, txt_admin_user_password)
        radio_monthly.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'verification
        If (txt_product_id.Text = "01-01-07-01") = False Then
            MsgBox("Please enter a valid product ID, thank you.")
        ElseIf (txt_license_code.Text = "01-01-07-01-2019-8") = False Then
            MsgBox("Please enter a valid license code, thank you.")
        ElseIf (txt_admin_user_id.Text = "me.admin") = False Then
            MsgBox("Please enter a valid Admin ID, thank you.")
        ElseIf (txt_admin_user_password.Text = "rafalo.1") = False Then
            MsgBox("Please enter a valid Admin password, thank you.")
        Else
            Dim license_period As Date = Today
            If radio_monthly.Checked = True Then
                license_period = license_period.AddMonths(1)
            ElseIf radio_year.Checked = True Then
                license_period = license_period.AddYears(1)
            ElseIf radio_monthly.Checked = True Then
                license_period = license_period.AddYears(100)
            End If
            License_periodTextBox.Text = license_period
            Validate()
            TblCompanySettingsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
            Close()
        End If
    End Sub

    Private Sub TblCompanySettingsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblCompanySettingsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)
    End Sub
End Class