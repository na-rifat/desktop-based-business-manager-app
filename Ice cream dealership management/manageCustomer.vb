Public Class manageCustomer
    Private Sub TblCustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblCustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.DataSet.tblCustomers)
        KeyPreview = True
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(53, 0)
        up(53, 0)
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(53, 0)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 3 Then
                TblCustomersBindingSource.Filter = "customerID =" & txtSearch.Text
            ElseIf txtFilter.SelectedIndex = 5 Then
                TblCustomersBindingSource.Filter = "shippingAddress LIKE '%" & txtSearch.Text & "%'"
            ElseIf txtFilter.SelectedIndex = 6 Then
                TblCustomersBindingSource.Filter = "billingAddress LIKE '%" & txtSearch.Text & "%'"
            Else
                filter(53, txtFilter.SelectedIndex, 4, 0, txtSearch.Text)
            End If
        Catch ex As Exception

        End Try
        If txtSearch.Text = Nothing Then
            TblCustomersBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        printD(TblCustomersDataGridView, "Customers")
    End Sub

    Private Sub manageCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            index(54)
            fll(54)
            nw(54, 0)
            nw(54, 1)
            ld(54)
            all.addcustomer.GroupBox1.Enabled = True
            If e.Control = True AndAlso e.KeyCode = Keys.Delete Then
                rm(53, 0)
                up(53, 0)
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MsgBox("Total customer: " & TblCustomersBindingSource.Count)
    End Sub
End Class