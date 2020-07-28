Public Class manageStock
    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cto(Me, Panel1)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        index(36)
        fll(36)
        ld(36)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printP0(Panel1, "Low stock products")
    End Sub

    Private Sub TblProductsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblProductsDataGridView.CellContentClick

    End Sub
End Class