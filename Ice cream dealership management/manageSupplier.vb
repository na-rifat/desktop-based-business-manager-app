Public Class manageSupplier
    Private Sub TblSuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblSuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(32, 0)
        up(32, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(32, 0)
        all.addsupplier.GroupBox1.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Try
            If txtFilter.SelectedIndex = 5 Then
                TblSuppliersBindingSource.Filter = "supplierID =" & txtSearch.Text
            Else
                filter(32, txtFilter.SelectedIndex, 21, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblSuppliersBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printD(TblSuppliersDataGridView, "Company")
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MsgBox("Total company: " & TblSuppliersBindingSource.Count)
    End Sub

    Private Sub manageSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            index(6)
            fll(6)
            ld(6)
            nw(6, 0)
            nw(6, 1)
            all.addsupplier.GroupBox1.Enabled = True
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(32, 0)
            up(32, 0)
        End If
    End Sub
End Class