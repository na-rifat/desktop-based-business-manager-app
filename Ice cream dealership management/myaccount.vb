Public Class myaccount
    Private Sub TblUserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub myaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.DataSet.tblUser)
        center(Me, Panel1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Enabled = True
        Button2.Enabled = False
        UserNameTextBox.Select()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Enabled = False
        Button2.Enabled = True
        status("Self account settings updated.")
    End Sub

    Private Sub PhoneLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RoleTextBox_TextChanged(sender As Object, e As EventArgs) Handles RoleTextBox.TextChanged

    End Sub

    Private Sub RoleTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RoleTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Panel2.Enabled = False
            Button2.Enabled = True
            status("Self account settings updated.")
        End If
    End Sub
End Class