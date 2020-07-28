Public Class newVehicle
    Private Sub TblVehicleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblVehicleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub newVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblVehicle' table. You can move, or remove it, as needed.
        Me.TblVehicleTableAdapter.Fill(Me.DataSet.tblVehicle)
        center(Me, Panel1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IssueDateTextBox.Text = DateTimePicker1.Value.Date
        If rdN.Checked = True Then
            VehicleConditionTextBox.Text = "New"
        ElseIf rdO.Checked = True Then
            VehicleConditionTextBox.Text = "Old"
        End If
        If chkbc.Checked = True Then
            BcTextBox.Text = "New"
        Else
            BcTextBox.Text = "Old"
        End If
        up(62, 0)
        index(63)
        fll(63)
        ld(63)
        status("Vehicle updated.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printP0(Panel1, "New vehicle")
    End Sub

    Private Sub NoteTextBox_TextChanged(sender As Object, e As EventArgs) Handles NoteTextBox.TextChanged

    End Sub

    Private Sub NoteTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NoteTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            IssueDateTextBox.Text = DateTimePicker1.Value.Date
            If rdN.Checked = True Then
                VehicleConditionTextBox.Text = "New"
            ElseIf rdO.Checked = True Then
                VehicleConditionTextBox.Text = "Old"
            End If
            If chkbc.Checked = True Then
                BcTextBox.Text = "New"
            Else
                BcTextBox.Text = "Old"
            End If
            up(62, 0)
            index(63)
            fll(63)
            ld(63)
            status("Vehicle updated.")
        End If
    End Sub
End Class