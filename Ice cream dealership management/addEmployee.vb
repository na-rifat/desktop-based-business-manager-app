Public Class addEmployee
    Private Sub TblEmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblEmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub addEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center(Me, Panel1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PinTextBox.Text = Nothing Then
            MsgBox("Please enter a PIN.")
        Else
            DateOfBirthTextBox.Text = DateTimePicker2.Value.Date
            JoinDateTextBox.Text = DateTimePicker1.Value.Date
            up(2, 0)
            index(25)
            fll(25)
            ld(25)
            status("Employee updated.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        upp(PicturePictureBox)
    End Sub

    Private Sub DateOfBirthTextBox_TextChanged(sender As Object, e As EventArgs) Handles DateOfBirthTextBox.TextChanged

    End Sub

    Private Sub DateOfBirthTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DateOfBirthTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            MaritialStatusComboBox.Select()
        End If
    End Sub

    Private Sub BloodGroupComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BloodGroupComboBox.SelectedIndexChanged

    End Sub

    Private Sub BloodGroupComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BloodGroupComboBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            NIDNumberTextBox.Select()
        End If
    End Sub

    Private Sub ReligionTextBox_TextChanged(sender As Object, e As EventArgs) Handles ReligionTextBox.TextChanged

    End Sub

    Private Sub ReligionTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ReligionTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            GenderComboBox.Select()
        End If
    End Sub

    Private Sub GenderComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenderComboBox.SelectedIndexChanged

    End Sub

    Private Sub GenderComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles GenderComboBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ContactNumberTextBox.Select()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        JoinDateTextBox.Text = DateTimePicker1.Value.Date
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateOfBirthTextBox.Text = DateTimePicker2.Value.Date
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printP(Panel1)
    End Sub
    Public Function employee()
        'selection
        EmployeeNameTextBox.Select()
        slt(EmployeeNameTextBox, AddressTextBox)
        sltb(AddressTextBox, MaritialStatusComboBox)
        sltc(MaritialStatusComboBox, BloodGroupComboBox)
        slta(BloodGroupComboBox, NIDNumberTextBox)
        slt(NIDNumberTextBox, ReligionTextBox)
        sltb(ReligionTextBox, GenderComboBox)
        slta(GenderComboBox, ContactNumberTextBox)
        slt(ContactNumberTextBox, EmployeeNoteTextBox)
        slt(EmployeeNoteTextBox, JoinDateTextBox)

        MaritialStatusComboBox.Items.Clear()
        BloodGroupComboBox.Items.Clear()
        GenderComboBox.Items.Clear()

        MaritialStatusComboBox.Items.Add("Married")
        MaritialStatusComboBox.Items.Add("Un-married")

        BloodGroupComboBox.Items.Add("A (+)")
        BloodGroupComboBox.Items.Add("A (-)")
        BloodGroupComboBox.Items.Add("B (+)")
        BloodGroupComboBox.Items.Add("B (-)")
        BloodGroupComboBox.Items.Add("AB (+)")
        BloodGroupComboBox.Items.Add("AB (-)")
        BloodGroupComboBox.Items.Add("O (+)")
        BloodGroupComboBox.Items.Add("O (-)")

        GenderComboBox.Items.Add("Male")
        GenderComboBox.Items.Add("Female")
        GenderComboBox.Items.Add("Others")

        MaritialStatusComboBox.SelectedIndex = 0
        BloodGroupComboBox.SelectedIndex = 0
        GenderComboBox.SelectedIndex = 0

        num(NIDNumberTextBox)
        num(PinTextBox)
        phn(ContactNumberTextBox)





        Panel1.Top = (ClientSize.Height / 2) - ((Panel1.Height / 2) - 30)
        Panel1.Left = (ClientSize.Width / 2) - (Panel1.Width / 2)
        Return 0
    End Function

    Private Sub PaymentTextBox_TextChanged(sender As Object, e As EventArgs) Handles PaymentTextBox.TextChanged

    End Sub

    Private Sub PaymentTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PaymentTextBox.KeyDown

    End Sub

    Private Sub PinTextBox_TextChanged(sender As Object, e As EventArgs) Handles PinTextBox.TextChanged

    End Sub

    Private Sub PinTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PinTextBox.KeyDown
        If PinTextBox.Text = Nothing Then
            MsgBox("Please enter a PIN.")
        Else
            DateOfBirthTextBox.Text = DateTimePicker2.Value.Date
            JoinDateTextBox.Text = DateTimePicker1.Value.Date
            up(2, 0)
            index(25)
            fll(25)
            ld(25)
            status("Employee updated.")
        End If
    End Sub
End Class