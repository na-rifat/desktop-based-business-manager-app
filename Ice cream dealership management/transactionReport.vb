Public Class transactionReport
    Private Sub TblTransactionReportBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblTransactionReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub transactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblBankAccounts' table. You can move, or remove it, as needed.
        Me.TblBankAccountsTableAdapter.Fill(Me.DataSet.tblBankAccounts)
        'TODO: This line of code loads data into the 'DataSet.tblTransaction' table. You can move, or remove it, as needed.
        Me.TblTransactionTableAdapter.Fill(Me.DataSet.tblTransaction)
        'TODO: This line of code loads data into the 'DataSet.tblTransactionReport' table. You can move, or remove it, as needed.
        Me.TblTransactionReportTableAdapter.Fill(Me.DataSet.tblTransactionReport)
        cto(Me, Panel1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fromDt.ResetText()
        toDt.ResetText()
        txtSearch.Clear()
        TblTransactionReportBindingSource.RemoveFilter()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtFilter.SelectedIndex = 0 Then
            TblTransactionReportBindingSource.Filter = "accountNO LIKE '%" & txtSearch.Text & "%' AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
        End If
        If txtSearch.Text = Nothing Then
            TblTransactionReportBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        printFP(Panel1, "Transaction report")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        TblTransactionBindingSource.Filter = "accNo LIKE '%" & AccountNumberTextBox.Text & "%' AND date LIKE '%" & Today & "%'"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        ld(52)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        status(TblTransactionBindingSource.Count)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        TblTransactionBindingSource.Filter = "accNo LIKE '%" & AccountNumberTextBox.Text & "%' AND transactionType LIKE '%Withdraw%' AND date LIKE '%" & Date.Today & "%'"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        TblTransactionBindingSource.Filter = "accNo LIKE '%" & AccountNumberTextBox.Text & "%' AND transactionType LIKE '%Deposit%' AND date LIKE '%" & Date.Today & "%'"
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblTransactionReportBindingSource.RemoveCurrent()
                Validate()
                TblTransactionReportBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class