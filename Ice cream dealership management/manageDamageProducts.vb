Public Class manageDamageProducts
    Private Sub TblDamageProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblDamageProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageDamageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblIncome' table. You can move, or remove it, as needed.
        Me.TblIncomeTableAdapter.Fill(Me.DataSet.tblIncome)
        KeyPreview = True
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) 
        rm(24, 0)
        up(24, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtFilter_Click(sender As Object, e As EventArgs) Handles txtFilter.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        ab(24, 0)
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        printD(TblDamageProductsDataGridView, "Damage products")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TblDamageProductsBindingSource.Filter = "product_name LIKE '%" & txtSearch.Text & "%'"
            ElseIf txtFilter.SelectedIndex = 1 Then
                TblDamageProductsBindingSource.Filter = "product_code =" & txtSearch.Text
            ElseIf txtFilter.Selectedindex = 2 Then
                TblDamageProductsBindingSource.Filter = "product_category LIKE '%" & txtSearch.Text & "%'"
            ElseIf txtFilter.SelectedIndex = 3 Then
                TblDamageProductsBindingSource.Filter = "company LIKE '%" & txtSearch.Text & "%'"
            ElseIf txtFilter.SelectedIndex = 4 Then
                TblDamageProductsBindingSource.Filter = "damage_date ='" & txtSearch.Text & "'"
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub manageDamageProducts_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            index(1)
            fll(1)
            ld(1)
            nw(1, 0)
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MsgBox("Confirm return?" & vbNewLine &
                "Product name: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(0).Value().ToString() & vbNewLine &
                "Company: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(3).Value().ToString() & vbNewLine &
                "Quantity: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(5).Value().ToString() & vbNewLine &
                "Total amount: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(6).Value().ToString() & vbNewLine &
                "Damage date: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(7).Value().ToString(),
                  MsgBoxStyle.YesNo, "Confirmation"
                  ) = MsgBoxResult.Yes Then
            TblIncomeBindingSource.AddNew()
            IncomeCategoryTextBox.Text = "Damage product return"
            IncomeSubcategoryTextBox.Text = "Damage product return"
            AmountTextBox.Text = TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(6).Value.ToString()
            DateDateTimePicker.Value = Today
            PaymentmethodComboBox.Text = "Cash"
            Payment_remarkTextBox.Text = "Paid by cash"
            IncomeNoteTextBox.Text = "Damage return payment || Damage ID: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(9).Value().ToString()

            TblDamageProductsBindingSource.RemoveCurrent()


            Validate()
            TblDamageProductsBindingSource.EndEdit()
            TblIncomeBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)


        End If
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If MsgBox("Confirm delete?" & vbNewLine &
                "Product name: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(0).Value().ToString() & vbNewLine &
                "Company: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(3).Value().ToString() & vbNewLine &
                "Quantity: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(5).Value().ToString() & vbNewLine &
                "Total amount: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(6).Value().ToString() & vbNewLine &
                "Damage date: " & TblDamageProductsDataGridView.Rows(TblDamageProductsBindingSource.Position).Cells(7).Value().ToString(),
                  MsgBoxStyle.YesNo, "Confirmation"
                  ) = MsgBoxResult.Yes Then
            TblDamageProductsBindingSource.RemoveCurrent()
            Validate()
            TblDamageProductsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
            damage_return()

        End If
    End Sub
End Class