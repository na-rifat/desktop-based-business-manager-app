Public Class productsCategory
    Private Sub TblProductCategoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblProductCategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub productsCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cto(Me, Panel1)
        KeyPreview = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Enabled = False
        up(40, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nw(40, 0)
        Panel2.Enabled = True
        CNameTextBox.Select()
    End Sub

    Private Sub txtsearch_Click(sender As Object, e As EventArgs) Handles txtsearch.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            filter(40, txtfilter.SelectedIndex, 16, 0, txtsearch.Text)
            If txtsearch.Text = Nothing Then
                TblProductCategoryBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        rm(40, 0)
        up(40, 0)
        GroupBox1.Text = "New product category"
        Panel2.Enabled = False
        Button1.Text = "Add"
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printP0(Panel1, "Products category")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ab(40, 0)
    End Sub

    Private Sub productsCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Control = True Then
            nw(40, 0)
            Panel2.Enabled = True
            CNameTextBox.Select()
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(40, 0)
            up(40, 0)
            GroupBox1.Text = "New product category"
            Panel2.Enabled = False
            Button1.Text = "Add"
        End If
    End Sub

    Private Sub RemarkTextBox_TextChanged(sender As Object, e As EventArgs) Handles RemarkTextBox.TextChanged

    End Sub

    Private Sub RemarkTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RemarkTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Panel2.Enabled = False
            up(40, 0)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class