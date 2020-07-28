Public Class productCommission
    Private Sub TblSCommissionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSCommissionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub productCommission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSupplierAccounts' table. You can move, or remove it, as needed.
        Me.TblSupplierAccountsTableAdapter.Fill(Me.DataSet.tblSupplierAccounts)

        'TODO: This line of code loads data into the 'DataSet.tblSCommission' table. You can move, or remove it, as needed.
        Me.TblSCommissionTableAdapter.Fill(Me.DataSet.tblSCommission)
        KeyPreview = True
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        rm(68, 0)
        up(68, 0)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        rm(67, 0)
        up(67, 0)
    End Sub

    Private Sub txtfilter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Try
            If txtfilterp.SelectedIndex = 0 Then
                TblSupplierAccountsBindingSource.Filter = "supplierName LIKE '%" & txtSearchP.Text & "%' OR " & ft(fromDt.Value.Date, toDt.Value.Date)
            ElseIf txtfilterp.SelectedIndex = 1 Then
                TblSupplierAccountsBindingSource.Filter = "supplierID =" & txtSearchP.Text & " OR " & ft(fromDt.Value.Date, toDt.Value.Date)
            ElseIf txtfilterp.SelectedIndex = 2 Then
                TblSupplierAccountsBindingSource.Filter = "purchaseInvoice =" & txtSearchP.Text
            End If
            If txtSearchP.Text = Nothing Then
                TblSupplierAccountsBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        printP0(Panel1, "Purchase commission")
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printP0(Panel2, "Sales discount")
    End Sub

    Private Sub txtsearch_Click(sender As Object, e As EventArgs) Handles txtsearch.Click
        Try
            If txtfilterp.SelectedIndex = 0 Then
                TblSCommissionBindingSource.Filter = "productName LIKE '%" & txtsearch.Text & "%'"
            ElseIf txtfilterp.SelectedIndex = 1 Then
                TblSCommissionBindingSource.Filter = "productCode =" & txtsearch.Text
            ElseIf txtfilterp.SelectedIndex = 2 Then
                TblSCommissionBindingSource.Filter = "start LIKE '%" & txtsearch.Text & "%'"
            ElseIf txtfilterp.SelectedIndex = 3 Then
                TblSCommissionBindingSource.Filter = "end LIKE '%" & txtsearch.Text & "%'"
            End If
            If txtsearch.Text = Nothing Then
                TblSCommissionBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearchP_TextChanged(sender As Object, e As EventArgs) Handles txtSearchP.TextChanged
        Try
            If txtfilterp.SelectedIndex = 0 Then
                TblSupplierAccountsBindingSource.Filter = "supplierName LIKE '%" & txtSearchP.Text & "%' AND " & ft(fromDt.Value.Date, toDt.Value.Date)
            ElseIf txtfilterp.SelectedIndex = 1 Then
                TblSupplierAccountsBindingSource.Filter = "supplierID =" & txtSearchP.Text & " AND " & ft(fromDt.Value.Date, toDt.Value.Date)
            ElseIf txtfilterp.SelectedIndex = 2 Then
                TblSupplierAccountsBindingSource.Filter = "purchaseInvoice =" & txtSearchP.Text & " AND " & ft(fromDt.Value.Date, toDt.Value.Date)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub productCommission_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N AndAlso TabControl1.SelectedIndex = 0 Then
            index(68)
            fll(68)
            ld(68)
            nw(68, 0)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete AndAlso TabControl1.SelectedIndex = 0 Then
            rm(68, 0)
            up(68, 0)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.N AndAlso TabControl1.SelectedIndex = 1 Then
            index(67)
            fll(67)
            ld(67)
            nw(67, 0)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete AndAlso TabControl1.SelectedIndex = 1 Then

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblSupplierAccountsBindingSource.RemoveCurrent()
        Validate()
        TblSupplierAccountsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub
End Class