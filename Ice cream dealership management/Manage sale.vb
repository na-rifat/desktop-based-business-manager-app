Public Class Manage_sale
    Private Sub TblSalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblSalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Manage_sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub TblSalesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub TblSalesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim current As Integer = TblInvoiceBindingSource.Position
        If MsgBox("Confirm delete this invoice?" & vbNewLine &
                  "Invoice NO: " & TblInvoiceDataGridView.Rows(current).Cells(0).Value() & vbNewLine &
                  "Shop name: " & TblInvoiceDataGridView.Rows(current).Cells(1).Value() & vbNewLine &
                  "Date: " & TblInvoiceDataGridView.Rows(current).Cells(10).Value(), MsgBoxStyle.YesNo,
                  "Confirmation"
            ) = MsgBoxResult.Yes Then
            delete_invoice()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        rm(21, 1)
        up(21, 1)
    End Sub

    Private Sub TblInvoiceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TblInvoiceBindingSource.Filter = "invoiceNo =" & txtSearch.Text
            ElseIf txtFilter.SelectedIndex = 3 Then
                TblInvoiceBindingSource.Filter = "date ='" & txtSearch.Text & "'"
            ElseIf txtFilter.SelectedIndex = 1 Then
                TblInvoiceBindingSource.Filter = "shopName LIKE '%" & txtSearch.Text & "%'"
            Else
                filter(21, txtFilter.SelectedIndex, 14, 0, txtSearch.Text)
            End If

        Catch ex As Exception

        End Try
        If txtSearch.Text = Nothing Then
            TblInvoiceBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub TblInvoiceDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        print_sale_invoice()
        ' printFP(Panel1, "Sales")
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) 
        ab(21, 0)
    End Sub

    Private Sub txtFilter_Click(sender As Object, e As EventArgs) Handles txtFilter.Click

    End Sub

    Private Sub Manage_sale_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            Try
                If TblSalesBindingSource.Count > 0 Then
                    While TblSalesBindingSource.Count <> 0
                        TblSalesBindingSource.RemoveCurrent()
                    End While
                End If
            Catch ex As Exception

            End Try
            up(21, 1)
            rm(21, 0)
            up(21, 0)
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs)
        Validate()
        TblInvoiceBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub
End Class