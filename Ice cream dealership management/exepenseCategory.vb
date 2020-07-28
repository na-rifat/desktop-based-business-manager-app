Public Class exepenseCategory
    Private Sub TblExpenseCategoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblExpenseCategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub TblExpenseCategoryBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblExpenseCategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub exepenseCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cto(Me, Panel1)
        KeyPreview = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Panel2.Enabled = False
            Validate()
            TblExpenseCategoryBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel3.Enabled = False
        Validate()
        TblExpenseSubcategoryBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles delete_category.Click
        If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
            Try
                If TblExpenseSubcategoryBindingSource.Count > 0 Then
                    Dim i As Integer = 0
                    While TblExpenseSubcategoryBindingSource.Count <> i
                        If TblExpenseCategoryDataGridView.Rows(TblExpenseCategoryBindingSource.Position).Cells(0).Value.ToString = TblExpenseSubcategoryDataGridView.Rows(TblExpenseSubcategoryBindingSource.Position).Cells(2).Value.ToString Then
                            TblExpenseSubcategoryBindingSource.RemoveCurrent()
                        Else
                            i += 1
                        End If
                    End While
                End If
            Catch ex As Exception

            End Try
            TblExpenseCategoryBindingSource.RemoveCurrent()
            up(16, 1)
            up(16, 0)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles delete_subcategory.Click
        rm(16, 1)
        up(16, 1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nw(16, 0)
        Panel2.Enabled = True
        CNameTextBox.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nw(16, 1)
        auto(CTextBox, DataSet.tblExpenseCategory, "cName")
        Panel3.Enabled = True
        CNameTextBox1.Select()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        ab(16, 0)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(16, 1)
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 1 Then
                filter(16, 1, 9, 0, txtSearch.Text)
            Else
                filter(16, 0, 9, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblExpenseCategoryBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printP0(Panel1, "Expense category")
    End Sub

    Private Sub exepenseCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Control = True AndAlso e.Shift = False Then
            nw(16, 0)
            Panel2.Enabled = True
            CNameTextBox.Select()
        ElseIf e.KeyCode = Keys.N AndAlso e.Control = True AndAlso e.Shift = True Then
            If TblExpenseCategoryBindingSource.Count > 0 Then
                nw(16, 1)
                auto(CTextBox, DataSet.tblExpenseCategory, "cName")
                Panel3.Enabled = True
                CNameTextBox1.Select()
            End If
        End If
    End Sub

    Private Sub exepenseCategory_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout

    End Sub

    Private Sub RemarkTextBox_TextChanged(sender As Object, e As EventArgs) Handles RemarkTextBox.TextChanged

    End Sub

    Private Sub RemarkTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RemarkTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Panel2.Enabled = False
                Validate()
                TblExpenseCategoryBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub RemarkTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RemarkTextBox1.TextChanged

    End Sub

    Private Sub RemarkTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RemarkTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Panel3.Enabled = False
            Validate()
            TblExpenseSubcategoryBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
        End If
    End Sub
End Class