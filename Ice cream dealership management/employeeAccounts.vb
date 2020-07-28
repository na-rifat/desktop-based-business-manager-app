Public Class employeeAccounts
    Private Sub TblEmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub employeeAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblEmployeeAccounts' table. You can move, or remove it, as needed.
        Me.TblEmployeeAccountsTableAdapter.Fill(Me.DataSet.tblEmployeeAccounts)
        cto(Me, Panel1)

    End Sub

    Private Sub TblEmployeeAccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblEmployeeAccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        rm(14, 0)
        up(14, 0)
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        txtSearch.Clear()
        TblEmployeeAccountsBindingSource.RemoveFilter()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 1 Then
                TblEmployeeAccountsBindingSource.Filter = "employeeID =" & txtSearch.Text & " AND date <='" & toDt.Value.Date & "' AND date >='" & fromDt.Value.Date & "'"
            Else
                TblEmployeeAccountsBindingSource.Filter = "employeeName LIKE '%" & txtSearch.Text & "%' AND date <='" & toDt.Value.Date & "' AND date >='" & fromDt.Value.Date & "'"
            End If
        Catch ex As Exception

        End Try
        If txtSearch.Text = Nothing Then
            TblEmployeeAccountsBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        printP0(Panel1, "Employee accounts")
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblEmployeeAccountsBindingSource.RemoveCurrent()
                Validate()
                TblEmployeeAccountsBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TblEmployeeAccountsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblEmployeeAccountsDataGridView.CellContentClick

    End Sub
End Class