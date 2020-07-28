Public Class customerAccounts
    Private Sub customerAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblIncome' table. You can move, or remove it, as needed.
        Me.TblIncomeTableAdapter.Fill(Me.DataSet.tblIncome)
        'TODO: This line of code loads data into the 'DataSet.tblExpenses' table. You can move, or remove it, as needed.
        Me.TblExpensesTableAdapter.Fill(Me.DataSet.tblExpenses)
        'TODO: This line of code loads data into the 'DataSet.tblVehicleAccounts' table. You can move, or remove it, as needed.
        Me.TblVehicleAccountsTableAdapter.Fill(Me.DataSet.tblVehicleAccounts)
        'TODO: This line of code loads data into the 'DataSet.tblInvoice' table. You can move, or remove it, as needed.
        Me.TblInvoiceTableAdapter.Fill(Me.DataSet.tblInvoice)
        'TODO: This line of code loads data into the 'DataSet.tblCusomterAccounts' table. You can move, or remove it, as needed.
        Me.TblCusomterAccountsTableAdapter.Fill(Me.DataSet.tblCusomterAccounts)
        cto(Me, Panel1)
    End Sub

    Private Sub TblCusomterAccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblCusomterAccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Validate()
        TblCusomterAccountsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        txtSearch.Clear()
        TblCusomterAccountsBindingSource.RemoveFilter()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        rm(51, 0)
        up(51, 0)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TblCusomterAccountsBindingSource.Filter = "customerName LIKE '%" & txtSearch.Text & "%' AND date <= '" & toDt.Value.Date & "' AND date >= '" & fromDt.Value.Date & "'"
            ElseIf txtFilter.SelectedIndex = 1 Then
                TblCusomterAccountsBindingSource.Filter = "customerID =" & txtSearch.Text & " AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
            ElseIf txtFilter.SelectedIndex = 2 Then
                TblCusomterAccountsBindingSource.Filter = "saleInvoice =" & txtSearch.Text & " AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
            End If
        Catch ex As Exception

        End Try
        If txtSearch.Text = Nothing Then
            TblCusomterAccountsBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        printP0(Panel1, "Customer accounts")
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        due_pay(0, 0)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TblCusomterAccountsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblCusomterAccountsDataGridView.CellContentClick

    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblCusomterAccountsBindingSource.RemoveCurrent()
                Validate()
                TblCusomterAccountsBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If ToolStripButton5.Text = "Edit" Then
            TblCusomterAccountsDataGridView.ReadOnly = False
            ToolStripButton5.Text = "Update"
        Else
            Validate()
            TblCusomterAccountsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
            ToolStripButton5.Text = "Edit"
            TblCusomterAccountsDataGridView.ReadOnly = True
        End If

    End Sub
End Class
