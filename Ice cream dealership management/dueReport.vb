Public Class dueReport
    Private Sub dueReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblInvoice' table. You can move, or remove it, as needed.
        Me.TblInvoiceTableAdapter.Fill(Me.DataSet.tblInvoice)
        'TODO: This line of code loads data into the 'DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.DataSet.tblCustomers)
        'TODO: This line of code loads data into the 'DataSet.tblCusomterAccounts' table. You can move, or remove it, as needed.
        Me.TblCusomterAccountsTableAdapter.Fill(Me.DataSet.tblCusomterAccounts)
        'TODO: This line of code loads data into the 'DataSet.tblDuesReport' table. You can move, or remove it, as needed.
        Me.TblDuesReportTableAdapter.Fill(Me.DataSet.tblDuesReport)
        cto(Me, Panel1)
    End Sub

    Private Sub TblDuesReportBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblDuesReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        TblDuesReportBindingSource.RemoveFilter()
        txtSearch.Clear()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TblDuesReportBindingSource.Filter = "customerName LIKE '%" & txtSearch.Text & "%' AND date <= '" & toDt.Value.Date & "' AND date >= '" & fromDt.Value.Date & "'"
            ElseIf txtFilter.SelectedIndex = 1 Then
                TblDuesReportBindingSource.Filter = "shopName LIKE '%" & txtSearch.Text & "%' AND date >= '" & fromDt.Value.Date & "' AND date <= '" & toDt.Value.Date & "'"
            End If
            If txtSearch.Text = Nothing Then
                TblDuesReportBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblDuesReportBindingSource.RemoveCurrent()
                Validate()
                TblDuesReportBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        TblDuesReportBindingSource.Filter = "date LIKE '%" & Today & "%'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        While TblDuesReportBindingSource.Count <> 0
            TblDuesReportBindingSource.RemoveCurrent()
        End While
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        TblCustomersBindingSource.RemoveFilter()
        TblCustomersBindingSource.MoveFirst()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        For a As Integer = 0 To TblCustomersBindingSource.Count - 1
            TblInvoiceBindingSource.Filter = "customerID =" & CustomerIDTextBox1.Text & " AND date LIKE '%" & Today & "%'"
            MsgBox(2)
            If TblInvoiceBindingSource.Count > 0 Then
                MsgBox(1)
                TblDuesReportBindingSource.AddNew()
                DateTextBox.Text = Today
                CustomerNameTextBox.Text = CustomerNameTextBox2.Text
                ShopNameTextBox.Text = ShopOrCompanyNameTextBox.Text
                AmountTextBox.Text = dtsum(TblInvoiceDataGridView, 0)
            End If
            TblCustomersBindingSource.MoveNext()
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        TblInvoiceBindingSource.RemoveFilter()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        TblInvoiceBindingSource.Filter = "customerID =" & CustomerIDTextBox1.Text & " AND date LIKE '%" & Today & "%'"
        MsgBox(CustomerIDTextBox1.Text & vbNewLine & TblInvoiceBindingSource.Count)

    End Sub
End Class