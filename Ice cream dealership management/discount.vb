Public Class discount
    Private Sub TbldiscountBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TbldiscountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tbldiscount' table. You can move, or remove it, as needed.
        Me.TbldiscountTableAdapter.Fill(Me.DataSet.tbldiscount)
        center(Me, Panel1)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TbldiscountBindingSource.Filter = "product_name LIKE '%" + txtSearch.Text + "%' AND date >= '" + fromDt.Value.Date + "' AND date <= '" + toDt.Value.Date + "'"
            ElseIf txtFilter.SelectedIndex = 1 Then
                TbldiscountBindingSource.Filter = "product_code ='" + txtSearch.Text + "' AND date >= '" + fromDt.Value.Date + "' AND date <= '" + toDt.Value.Date + "'"
            ElseIf txtFilter.SelectedIndex = 2 Then
                TbldiscountBindingSource.Filter = "product_category LIKE '%" + txtSearch.Text + "%' AND date >= '" + fromDt.Value.Date + "' AND date <= '" + toDt.Value.Date + "'"
            ElseIf txtFilter.SelectedIndex = 3 Then
                TbldiscountBindingSource.Filter = "company LIKE '%" + txtSearch.Text + "%' AND date >= '" + fromDt.Value.Date + "' AND date <= '" + toDt.Value.Date + "'"
            ElseIf txtFilter.SelectedIndex = 4 Then
                TbldiscountBindingSource.Filter = "company_id ='" + txtSearch.Text + "' AND date >= '" + fromDt.Value.Date + "' AND date <= '" + toDt.Value.Date + "'"
            ElseIf txtFilter.SelectedIndex = 5 Then
                TbldiscountBindingSource.Filter = "customer_name LIKE '%" + txtSearch.Text + "%' AND date >= '" + fromDt.Value.Date + "' AND date <= '" + toDt.Value.Date + "'"
            ElseIf txtFilter.SelectedIndex = 6 Then
                TbldiscountBindingSource.Filter = "customer_id ='" + txtSearch.Text + "' AND date >= '" + fromDt.Value.Date + "' AND date <= '" + toDt.Value.Date + "'"
            ElseIf txtFilter.SelectedIndex = 7 Then
                TbldiscountBindingSource.Filter = "invoice_no ='" + txtSearch.Text + "' AND date >= '" + fromDt.Value.Date + "' AND date <= '" + toDt.Value.Date + "'"
            End If
            If txtSearch.Text = Nothing Then
                TbldiscountBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        fromDt.ResetText()
        toDt.ResetText()
        TbldiscountBindingSource.RemoveFilter()
        txtFilter.SelectedIndex = 0
        txtSearch.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Starting season: " + fromDt.Value.Date + vbNewLine +
            "Ending season: " + toDt.Value.Date + vbNewLine +
            "Total discount(amount):" + dtsum(TbldiscountDataGridView, 5) + vbNewLine,
                  MsgBoxStyle.YesNo,
                  "Confirm discount?"
            ) = MsgBoxResult.Yes Then
            For a As Integer = 0 To TbldiscountBindingSource.Count - 1
                TbldiscountDataGridView.Rows(a).Cells(7).Value = "Yes"
                TbldiscountDataGridView.Rows(a).Cells(8).Value = Today
            Next
            Validate()
            TbldiscountBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
        End If



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            TbldiscountBindingSource.RemoveCurrent()
            Validate()
            TbldiscountBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        Validate()
        TbldiscountBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        printP0(Panel1, "Discounts")
    End Sub
End Class