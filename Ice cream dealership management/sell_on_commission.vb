Public Class sell_on_commission
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TblsellcommissionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblsellcommissionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub sell_on_commission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSuppliers' table. You can move, or remove it, as needed.
        Me.TblSuppliersTableAdapter.Fill(Me.DataSet.tblSuppliers)
        'TODO: This line of code loads data into the 'DataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.DataSet.tblProducts)

        'TODO: This line of code loads data into the 'DataSet.tblsellcommission' table. You can move, or remove it, as needed.
        Me.TblsellcommissionTableAdapter.Fill(Me.DataSet.tblsellcommission)
        center(Me, Panel1)
    End Sub

    Private Sub Company_idLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Company_nameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Customer_idLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Customer_nameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Invoice_noLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TblsellcommissionDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblsellcommissionDataGridView.CellContentClick

    End Sub











    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        If MsgBox("Confirm delte?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            TblsellcommissionBindingSource.RemoveCurrent()
            Validate()
            TblsellcommissionBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Confirm delte?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            TblsellcommissionBindingSource.RemoveCurrent()
            Validate()
            TblsellcommissionBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        TblsellcommissionBindingSource.RemoveFilter()
        fromDt.ResetText()
        toDt.ResetText()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If chk_company.Checked = False AndAlso chk_product.Checked = False Then
            TblsellcommissionBindingSource.Filter = "date <= '" & toDt.Value.Date() & "' AND date >= '" & fromDt.Value.Date() & "'"
        ElseIf chk_company.Checked = True AndAlso chk_product.Checked = False Then
            TblsellcommissionBindingSource.Filter = "date <= '" & toDt.Value.Date() & "' AND date >= '" & fromDt.Value.Date() & "' AND company_name LIKE '%" & txt_company.Text & "%' AND company_id ='" & txt_comany_id.Text & "'"
        ElseIf chk_company.Checked = True AndAlso chk_product.Checked = True Then
            TblsellcommissionBindingSource.Filter = "date <= '" & toDt.Value.Date() & "' AND date >= '" & fromDt.Value.Date() & "' AND company_name LIKE '%" & txt_company.Text & "%' AND company_id ='" & txt_comany_id.Text & "' AND product_name LIKE '%" & txt_product.Text & "%' AND product_id= '" & txt_product_id.Text & "'"
        Else
            TblsellcommissionBindingSource.Filter = "date <= '" & toDt.Value.Date() & "' AND date >= '" & fromDt.Value.Date() & "'"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox(
        "Starting season: " & fromDt.Value.Date() & vbNewLine &
        "Ending season: " & toDt.Value.Date() & vbNewLine &
        "Total commission(amount): " & dtsum(TblsellcommissionDataGridView, 5),
        MsgBoxStyle.YesNo,
        "Confirm commission?"
            )
        ) = MsgBoxResult.Yes Then
            For i As Integer = 0 To TblsellcommissionBindingSource.Count - 1
                TblsellcommissionDataGridView.Rows(i).Cells(6).Value() = "Yes"
                TblsellcommissionDataGridView.Rows(i).Cells(8).Value() = Today
            Next
            up(70, 0)
        End If
    End Sub

    Private Sub chk_company_CheckedChanged_1(sender As Object, e As EventArgs) Handles chk_company.CheckedChanged
        If chk_company.Checked = False Then
            txt_company.Clear()
            txt_comany_id.Clear()
        End If
    End Sub

    Private Sub chk_product_CheckedChanged_1(sender As Object, e As EventArgs) Handles chk_product.CheckedChanged
        If chk_product.Checked = False Then
            txt_product.Clear()
            txt_product_id.Clear()
        End If
    End Sub

    Private Sub txt_company_TextChanged_1(sender As Object, e As EventArgs) Handles txt_company.TextChanged

    End Sub

    Private Sub txt_company_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_company.KeyDown
        If e.KeyCode = Keys.Enter Then
            TblSuppliersBindingSource.Filter = "supplierName LIKE '%" & txt_company.Text & "%'"
            txt_company.Text = SupplierNameTextBox.Text
            txt_comany_id.Text = SupplierIDTextBox.Text
        End If
    End Sub

    Private Sub txt_comany_id_TextChanged_1(sender As Object, e As EventArgs) Handles txt_comany_id.TextChanged

    End Sub

    Private Sub txt_comany_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_comany_id.KeyDown
        If e.KeyCode = Keys.Enter Then
            TblSuppliersBindingSource.Filter = "supplierID ='" & txt_comany_id.Text & "'"
            txt_company.Text = SupplierNameTextBox.Text
            txt_comany_id.Text = SupplierIDTextBox.Text

        End If
    End Sub

    Private Sub txt_product_TextChanged_1(sender As Object, e As EventArgs) Handles txt_product.TextChanged

    End Sub

    Private Sub txt_product_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_product.KeyDown
        If e.KeyCode = Keys.Enter Then
            TblProductsBindingSource.Filter = "productName LIKE '%" & txt_product.Text & "%'"
            txt_product.Text = ProductNameTextBox.Text
            txt_product_id.Text = ProductCodeTextBox.Text
        End If
    End Sub



    Private Sub txt_product_id_TextChanged_1(sender As Object, e As EventArgs) Handles txt_product_id.TextChanged

    End Sub

    Private Sub txt_product_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_product_id.KeyDown
        If e.KeyCode = Keys.Enter Then
            TblProductsBindingSource.Filter = "productCode ='" & txt_product_id.Text & "'"
            txt_product.Text = ProductNameTextBox.Text
            txt_product_id.Text = ProductCodeTextBox.Text
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        printP0(Panel1, "Commissions")
    End Sub
End Class