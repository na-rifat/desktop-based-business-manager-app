Public Class addProducts
    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub addProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSuppliers' table. You can move, or remove it, as needed.
        Me.TblSuppliersTableAdapter.Fill(Me.DataSet.tblSuppliers)
        'TODO: This line of code loads data into the 'DataSet.tblProductCategory' table. You can move, or remove it, as needed.
        Me.TblProductCategoryTableAdapter.Fill(Me.DataSet.tblProductCategory)
        center(Me, Panel1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If AvailableTextBox.Text = Nothing Then
            AvailableTextBox.Text = "0"
        End If
        all.newsale.ProductNameTextBox.AutoCompleteCustomSource.Clear()

        up(5, 0)
        index(29)
        fll(29)
        ld(29)
        status("Product updated")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        index(40)
    End Sub

    Private Sub ProfitTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProfitTextBox.TextChanged
        Try
            SellPriceTextBox.Text = prc(PurchasePriceTextBox.Text, ProfitTextBox.Text) + Double.Parse(PurchasePriceTextBox.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) 
        index(40)
        fll(40)
        ld(40)
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        index(40)
        fll(40)
        ld(40)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        upp(ProductImagePictureBox)
    End Sub

    Private Sub ProductCategoryTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductCategoryTextBox.TextChanged

    End Sub

    Private Sub ProductCategoryTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductCategoryTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            TblProductCategoryBindingSource.Filter = "cName LIKE '%" & ProductCategoryTextBox.Text & "%'"
            If TblProductCategoryBindingSource.Count > 0 Then
                If ProductCategoryTextBox.Text = CNameTextBox.Text Then
                    ProductCategoryTextBox.Text = ProductCategoryTextBox.Text
                End If
            Else
                ProductCategoryTextBox.Clear()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        printP0(Panel1, "Add product")
    End Sub

    Private Sub SupplierTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierTextBox.TextChanged

    End Sub

    Private Sub SupplierTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SupplierTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblSuppliersBindingSource.Filter = "supplierName LIKE '%" & SupplierTextBox.Text & "%'"
                If TblSuppliersBindingSource.Count > 0 Then
                    SupplierTextBox.Text = SupplierNameTextBox.Text
                Else
                    SupplierTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AvailableTextBox_TextChanged(sender As Object, e As EventArgs) Handles AvailableTextBox.TextChanged

    End Sub

    Private Sub AvailableTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AvailableTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If AvailableTextBox.Text = Nothing Then
                AvailableTextBox.Text = "0"
            End If
            all.newsale.ProductNameTextBox.AutoCompleteCustomSource.Clear()

            up(5, 0)
            index(29)
            fll(29)
            ld(29)
            status("Product updated")
        End If
    End Sub

    Private Sub chk_nondis_CheckedChanged(sender As Object, e As EventArgs) Handles chk_nondis.CheckedChanged
        If (Non_discountTextBox.Text = Nothing Or Non_discountTextBox.Text = "0") AndAlso chk_nondis.Checked = True Then
            Non_discountTextBox.Text = "1"
        ElseIf Non_discountTextBox.Text = "1" AndAlso chk_nondis.Checked = False Then
            Non_discountTextBox.Text = "0"
        End If
    End Sub

    Private Sub addProducts_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Non_discountTextBox.Text = "1" Then
            chk_nondis.Checked = True
        Else
            chk_nondis.Checked = False
        End If
    End Sub
End Class