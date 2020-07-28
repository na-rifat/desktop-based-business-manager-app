Public Class supplierAccounts
    Private Sub TblSupplierAccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSupplierAccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub supplierAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblExpenses' table. You can move, or remove it, as needed.
        Me.TblExpensesTableAdapter.Fill(Me.DataSet.tblExpenses)
        'TODO: This line of code loads data into the 'DataSet.tblPurchaseInvoice' table. You can move, or remove it, as needed.
        Me.TblPurchaseInvoiceTableAdapter.Fill(Me.DataSet.tblPurchaseInvoice)
        'TODO: This line of code loads data into the 'DataSet.tblSupplierAccounts' table. You can move, or remove it, as needed.
        Me.TblSupplierAccountsTableAdapter.Fill(Me.DataSet.tblSupplierAccounts)
        cto(Me, Panel1)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        txtSearch.Clear()
        TblSupplierAccountsBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        rm(47, 0)
        up(47, 0)
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Try
            If txtFilter.SelectedIndex = 1 Then
                TblSupplierAccountsBindingSource.Filter = "supplierID =" & txtSearch.Text & " AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
            ElseIf txtFilter.SelectedIndex = 2 Then
                TblSupplierAccountsBindingSource.Filter = "purchaseInvoice =" & txtSearch.Text & " AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
            ElseIf txtFilter.SelectedIndex = 0 Then
                TblSupplierAccountsBindingSource.Filter = "supplierName LIKE '%" & txtSearch.Text & "%' AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
            End If
        Catch ex As Exception

        End Try
        If txtSearch.Text = Nothing Then
            TblSupplierAccountsBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        printFP(Panel1, "Company accounts")
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        due_pay(1, 1)
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblSupplierAccountsBindingSource.RemoveCurrent()
                Validate()
                TblSupplierAccountsBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class