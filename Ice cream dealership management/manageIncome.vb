Public Class manageIncome
    Private Sub TblIncomeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblIncomeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(28, 0)
        up(28, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(28, 0)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 2 Then
                TblIncomeBindingSource.Filter = "date ='" & txtSearch.Text & "'"
            Else
                filter(28, txtFilter.SelectedIndex, 11, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblIncomeBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printFP(Panel1, "Income")
    End Sub

    Private Sub manageIncome_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            index(35)
            fll(35)
            nw(35, 0)
            ld(35)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(28, 0)
            up(28, 0)
        End If
    End Sub
End Class