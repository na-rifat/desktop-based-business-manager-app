Public Class manageExepense
    Private Sub TblExpensesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblExpensesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageExepense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub TblExpensesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblExpensesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub TblExpensesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(26, 0)
        up(26, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(26, 0)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 3 Then
                TblExpensesBindingSource.Filter = "date ='" & txtSearch.Text & "'"
            Else
                filter(26, txtFilter.SelectedIndex, 8, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblExpensesBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        print_daily_expense()
        'printFP(Panel1, "Expenses")
    End Sub

    Private Sub TblExpensesDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles TblExpensesDataGridView.CellContentClick

    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub manageExepense_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            index(34)
            fll(34)
            nw(34, 0)
            ld(34)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(26, 0)
            up(26, 0)
        End If
    End Sub
End Class