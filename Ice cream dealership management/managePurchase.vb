Public Class managePurchase
    Private Sub TblPurchaseInvoiceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblPurchaseInvoiceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub managePurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cto(Me, Panel1)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            delete_purchase_invoice()
            Try
                If TblPurchaseBindingSource.Count > 0 Then
                    While TblPurchaseBindingSource.Count <> 0
                        TblPurchaseBindingSource.RemoveCurrent()
                    End While
                End If
            Catch ex As Exception

            End Try
            up(30, 1)
            rm(30, 0)
            up(30, 0)
        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TblPurchaseInvoiceBindingSource.Filter = "invoiceNo =" & txtSearch.Text
            ElseIf txtFilter.SelectedIndex = 3 Then
                TblPurchaseBindingSource.Filter = "date ='" & txtSearch.Text & "'"
            Else
                filter(30, txtFilter.SelectedIndex, 18, 0, txtSearch.Text)
            End If

        Catch ex As Exception

        End Try
        If txtSearch.Text = Nothing Then
            TblProductsBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printP0(Panel1, "Manage purchase")
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) 
        ab(30, 0)
    End Sub
End Class