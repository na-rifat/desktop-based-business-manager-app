Public Class companySettings
    Private Sub TblCompanySettingsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblCompanySettingsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub companySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center(Me, Panel1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'My.Settings.saletarget = txtSaletarget.Text
        Noti_soundTextBox.Text = TrackBar1.Value.ToString
        IniTextBox.Text = nmInterval.Value
        If CheckBox1.Checked = True Then
            Is_noti_soundTextBox.Text = 1
        Else
            Is_noti_soundTextBox.Text = 0
        End If

        Panel2.Enabled = False
        Validate()
        TblCompanySettingsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)

        status("Shop settings changed.")

        Form1.frm()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub companySettings_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Panel2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        upp(CompanyLogoPictureBox)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)

        Label2.Text = TrackBar1.Value & "%"
        If TrackBar1.Value < 0 Then
            TrackBar1.Value = 0
        ElseIf TrackBar1.Value > 100 Then
            TrackBar1.Value = 100

        End If
    End Sub

    Private Sub lbl_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        ld(9)
    End Sub

    Public Function csettings()
        TblCompanySettingsTableAdapter.Fill(DataSet.tblCompanySettings)
        'selection 
        CompanyNameTextBox.Select()
        slt(CompanyNameTextBox, CompanyAddressTextBox)
        slt(CompanyAddressTextBox, CompanyPhoneNumberTextBox)
        slt(CompanyPhoneNumberTextBox, CurrencyTextBox)


        If TblCompanySettingsBindingSource.Count = 0 Then
            TblCompanySettingsBindingSource.AddNew()
        ElseIf TblCompanySettingsBindingSource.Count > 1 Then
            While TblCompanySettingsBindingSource.Count <> 1
                TblCompanySettingsBindingSource.RemoveCurrent()
            End While

        End If

        Panel2.Enabled = False
        TrackBar1.Value = Decimal.Parse(Noti_soundTextBox.Text)
        nmInterval.Value = Decimal.Parse(IniTextBox.Text)
        'txtSaletarget.Text = My.Settings.saletarget
        If Noti_soundTextBox.Text = 1 Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If

        phn(CompanyPhoneNumberTextBox)



        Validate()
        TblCompanySettingsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
        Form1.TblCompanySettingsTableAdapter.Fill(Form1.DataSet.tblCompanySettings)
        Return 0
    End Function

    Private Sub TrackBar1_Scroll_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) 
        Label2.Text = TrackBar1.Value & "%"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        upp(CompanyLogoPictureBox)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        MsgBox(TblCompanySettingsBindingSource.Count)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        TblCompanySettingsBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        TblCompanySettingsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        TblCompanySettingsTableAdapter.Fill(DataSet.tblCompanySettings)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Validate()
        TblCompanySettingsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub
End Class