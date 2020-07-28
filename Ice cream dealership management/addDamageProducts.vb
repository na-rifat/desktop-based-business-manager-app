Public Class addDamageProducts
    Private Sub BankAccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TblDamageProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblDamageProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub addDamageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblExpenses' table. You can move, or remove it, as needed.
        Me.TblExpensesTableAdapter.Fill(Me.DataSet.tblExpenses)
        'TODO: This line of code loads data into the 'DataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.DataSet.tblProducts)
        center(Me, Panel1)
    End Sub

    Private Sub ProductNameTextBox_TextChanged(sender As Object, e As EventArgs) 

    End Sub


    Private Sub ProdcutCategoryTextBox_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ProdcutCategoryTextBox_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub SupplierTextBox_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub SupplierTextBox_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub QuantityTextBox_KeyDown(sender As Object, e As KeyEventArgs) 
        If e.KeyCode = Keys.Enter Then
            DamageDateTextBox.Text = Date.Today
            DamageDateTextBox.Select()
        End If
    End Sub

    Private Sub DamageDateTextBox_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub DamageDateTextBox_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'expense
        TblExpensesBindingSource.AddNew()
        ExpenseCategoryTextBox.Text = "Damage product"
        ExpenseSubCategoryTextBox.Text = "Damage product"
        AmountTextBox.Text = Total_priceTextBox.Text
        DateDateTimePicker.Value = Damage_dateDateTimePicker.Value.Date
        PaymentMethodComboBox.Text = "Cash"
        Payment_remarkTextBox.Text = "Paid by cash"
        ExpenseNoteTextBox.Text = "Amount paid for damage product || Damage ID: " & IdTextBox1.Text
        Damage_idTextBox.Text = IdTextBox1.Text
        ''''''''''''''''

        Validate()
        TblDamageProductsBindingSource.EndEdit()
        TblExpensesBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
        index(24)
        fll(24)
        ld(24)
    End Sub

    Private Sub ProductNameTextBox_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProdcutCategoryTextBox_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        printP0(Panel1, "Damage products")
    End Sub

    Private Sub ProductNameTextBox_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub ProductCodeTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductCodeTextBox_KeyDown(sender As Object, e As KeyEventArgs)


    End Sub

    Private Sub QuantityTextBox_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Product_nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Product_nameTextBox.TextChanged

    End Sub

    Private Sub Product_nameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Product_nameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            TblProductsBindingSource.Filter = "productName LIKE '%" & Product_nameTextBox.Text & "%'"
            Product_nameTextBox.Text = ProductNameTextBox1.Text
            Product_codeTextBox.Text = ProductCodeTextBox1.Text
            Product_categoryTextBox.Text = ProductCategoryTextBox.Text
            CompanyTextBox.Text = SupplierTextBox1.Text
            Try
                all.managesupplier.TblSuppliersBindingSource.Filter = "supplierName LIKE '%" & CompanyTextBox.Text & "%'"
                Company_idTextBox.Text = all.managesupplier.TblSuppliersDataGridView.Rows(0).Cells(6).Value().ToString()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub QuantityTextBox_TextChanged_2(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged
        Try
            Total_priceTextBox.Text = Double.Parse(Unit_priceTextBox.Text) * Double.Parse(QuantityTextBox.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Invoice_noTextBox_TextChanged(sender As Object, e As EventArgs) Handles Invoice_noTextBox.TextChanged

    End Sub

    Private Sub Invoice_noTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Invoice_noTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            'expense
            TblExpensesBindingSource.AddNew()
            ExpenseCategoryTextBox.Text = "Damage product"
            ExpenseSubCategoryTextBox.Text = "Damage product"
            AmountTextBox.Text = Total_priceTextBox.Text
            DateDateTimePicker.Value = Damage_dateDateTimePicker.Value
            PaymentMethodComboBox.Text = "Cash"
            Payment_remarkTextBox.Text = "Paid by cash"
            ExpenseNoteTextBox.Text = "Amount paid for damage product || Damage ID: " & IdTextBox1.Text
            Damage_idTextBox.Text = IdTextBox1.Text
            ''''''''''''''''

            Validate()
            TblDamageProductsBindingSource.EndEdit()
            TblExpensesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
            index(24)
            fll(24)
            ld(24)
        End If
    End Sub
End Class