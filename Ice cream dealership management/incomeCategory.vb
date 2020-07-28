Public Class incomeCategory
    Private Sub TblIncomeCategoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblIncomeCategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub incomeCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cto(Me, Panel1)
        KeyPreview = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Enabled = False
        up(20, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel3.Enabled = False
        up(20, 1)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Try
            If TblIncomeSubcategoryBindingSource.Count > 1 Then
                While TblIncomeSubcategoryBindingSource.Count <> 0
                    TblIncomeSubcategoryBindingSource.RemoveCurrent()
                End While
            End If

        Catch ex As Exception

        End Try
        rm(20, 0)
        up(20, 1)
        up(20, 0)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(20, 1)
        up(20, 1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Enabled = True
        nw(20, 0)
        CNameTextBox.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nw(20, 1)
        Panel3.Enabled = True
        CNameTextBox1.Select()
        auto(CTextBox, DataSet.tblIncomeCategory, "cName")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        ab(20, 0)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(20, 1)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try

            filter(20, 1, 12, 0, txtSearch.Text)
            If txtSearch.Text = Nothing Then
                TblIncomeCategoryBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printP0(Panel1, "Income category")
    End Sub

    Private Sub incomeCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Control = True Then
            Panel2.Enabled = True
            nw(20, 0)
            CNameTextBox.Select()
        ElseIf e.KeyCode = Keys.N AndAlso e.Alt = True Then
            If TblIncomeCategoryBindingSource.Count > 0 Then
                nw(20, 1)
                Panel3.Enabled = True
                CNameTextBox1.Select()
                auto(CTextBox, DataSet.tblIncomeCategory, "cName")
            End If
        End If
    End Sub

    Private Sub RemarkTextBox_TextChanged(sender As Object, e As EventArgs) Handles RemarkTextBox.TextChanged

    End Sub

    Private Sub RemarkTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RemarkTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Panel2.Enabled = False
            up(20, 0)
        End If
    End Sub

    Private Sub RemarkTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RemarkTextBox1.TextChanged

    End Sub

    Private Sub RemarkTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RemarkTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Panel3.Enabled = False
            up(20, 1)
        End If
    End Sub
End Class