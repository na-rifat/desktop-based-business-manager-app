Public Class manageEmployee
    Private Sub TblEmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblEmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub TblEmployeeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblEmployeeDataGridView.CellContentClick

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(25, 0)
        up(25, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(25, 0)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TblEmployeeBindingSource.Filter = "Id =" & txtSearch.Text
            Else
                filter(25, txtFilter.SelectedIndex, 6, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblEmployeeBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        printFP(Panel1, "Employees")
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MsgBox("Total employee: " & TblEmployeeBindingSource.Count)
    End Sub

    Private Sub manageEmployee_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            index(2)
            fll(2)
            ld(2)
            nw(2, 0)
            ld(2)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(25, 0)
            up(25, 0)
        End If
    End Sub
End Class