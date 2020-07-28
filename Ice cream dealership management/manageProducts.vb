Public Class manageProducts
    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cto(Me, Panel1)
        KeyPreview = True
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(29, 0)
        up(29, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(29, 0)
        If addproduct.Non_discountTextBox.Text = "1" Then
            addproduct.chk_nondis.Checked = True
        Else
            addproduct.chk_nondis.Checked = False
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        a(txtSearch, DataSet.tblProducts, "ProductName")
    End Sub

    Function a(t As ToolStripTextBox, dt As DataTable, c As String)

        t.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        t.AutoCompleteSource = AutoCompleteSource.CustomSource
        For r As Integer = 0 To dt.Rows.Count - 1
            t.AutoCompleteCustomSource.Add(dt.Rows(r)(c).ToString())
        Next
        Return 0
    End Function

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try

            If txtFilter.SelectedIndex = 1 Then
                TblProductsBindingSource.Filter = "productCode =" & txtSearch.Text
            Else
                filter(29, txtFilter.SelectedIndex, 17, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblProductsBindingSource.RemoveFilter()
            End If
            'stock_search()
            'products_value()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        print_product_statement()
        'printP0(Panel1, "Manage products")
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        index(36)
        fll(36)
        nw(36, 0)
        nw(36, 1)
        ld(36)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        MsgBox("Total products: " & TblProductsBindingSource.Count)
    End Sub

    Private Sub manageProducts_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            index(5)
            fll(5)
            nw(5, 0)
            ld(5)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(29, 0)
            up(29, 0)
        End If
    End Sub
End Class