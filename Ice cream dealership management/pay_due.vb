Public Class pay_due
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub pay_button_Click(sender As Object, e As EventArgs) Handles pay_button.Click

    End Sub

    Private Sub TblTransactionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblTransactionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub TblTransactionBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblTransactionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub pay_due_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblBankAccounts' table. You can move, or remove it, as needed.
        Me.TblBankAccountsTableAdapter.Fill(Me.DataSet.tblBankAccounts)
        'TODO: This line of code loads data into the 'DataSet.tblTransaction' table. You can move, or remove it, as needed.
        Me.TblTransactionTableAdapter.Fill(Me.DataSet.tblTransaction)



    End Sub

    Private Sub txtaccountNumber_TextChanged(sender As Object, e As EventArgs) Handles txtaccountNumber.TextChanged

    End Sub

    Private Sub txtaccountNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtaccountNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & txtaccountNumber.Text & "%'"
            If TblBankAccountsBindingSource.Count = 0 Then
                txtaccountNumber.Clear()
            End If
        End If
    End Sub
End Class