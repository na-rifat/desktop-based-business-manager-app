Public Class createUser
    Private Sub TblUserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub createUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center(Me, Panel1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ProductsTextBox.Text = ck(chkProducts, ProductsTextBox)
        SalesTextBox.Text = ck(chkSales, SalesTextBox)
        PurchaseTextBox.Text = ck(chkPurchase, SalesTextBox)

        BankTransactionTextBox.Text = ck(chkTransaction, BankTransactionTextBox)
        ExpensesTextBox.Text = ck(chkExpenses, ExpensesTextBox)
        IncomeTextBox.Text = ck(chkIncome, IncomeTextBox)

        ReportsNdateTextBox.Text = ck(chkReports, ReportsNdateTextBox)
        FridgeTextBox.Text = ck(chkFridge, FridgeTextBox)


        OthersTextBox.Text = ck(chkOthers, OthersTextBox)

        up(10, 0)
        index(49)
        fll(49)
        ld(49)

        status("User updated.")
    End Sub
    Function ck(c As CheckBox, t As TextBox)
        If c.Checked = True Then
            t.Text = 1
        Else
            c.Text = 0
        End If
        Validate()
        TblUserBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)

        Return 0
    End Function

    Private Sub FridgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles FridgeTextBox.TextChanged

    End Sub

    Private Sub IncomeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SuppliersLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BankTransactionLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BankTransactionTextBox_TextChanged(sender As Object, e As EventArgs) Handles BankTransactionTextBox.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkProducts_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkProducts_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkProducts.CheckedChanged
        ck(chkProducts, ProductsTextBox)
    End Sub

    Private Sub chkPurchase_CheckedChanged(sender As Object, e As EventArgs) Handles chkPurchase.CheckedChanged
        ck(chkPurchase, PurchaseTextBox)
    End Sub

    Private Sub chkSales_CheckedChanged(sender As Object, e As EventArgs) Handles chkSales.CheckedChanged
        ck(chkSales, SalesTextBox)
    End Sub

    Private Sub chkFridge_CheckedChanged(sender As Object, e As EventArgs) Handles chkFridge.CheckedChanged
        ck(chkFridge, FridgeTextBox)
    End Sub

    Private Sub chkIncome_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncome.CheckedChanged
        ck(chkIncome, IncomeTextBox)
    End Sub

    Private Sub chkExpenses_CheckedChanged(sender As Object, e As EventArgs) Handles chkExpenses.CheckedChanged
        ck(chkExpenses, ExpensesTextBox)
    End Sub

    Private Sub chkTransaction_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransaction.CheckedChanged
        ck(chkTransaction, BankTransactionTextBox)
    End Sub

    Private Sub chkReports_CheckedChanged(sender As Object, e As EventArgs) Handles chkReports.CheckedChanged
        ck(chkReports, ReportsNdateTextBox)
    End Sub

    Private Sub chkOthers_CheckedChanged(sender As Object, e As EventArgs) Handles chkOthers.CheckedChanged
        ck(chkOthers, OthersTextBox)
    End Sub

    Private Sub RoleTextBox_TextChanged(sender As Object, e As EventArgs) Handles RoleTextBox.TextChanged

    End Sub

    Private Sub RoleTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RoleTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ProductsTextBox.Text = ck(chkProducts, ProductsTextBox)
            SalesTextBox.Text = ck(chkSales, SalesTextBox)
            PurchaseTextBox.Text = ck(chkPurchase, SalesTextBox)

            BankTransactionTextBox.Text = ck(chkTransaction, BankTransactionTextBox)
            ExpensesTextBox.Text = ck(chkExpenses, ExpensesTextBox)
            IncomeTextBox.Text = ck(chkIncome, IncomeTextBox)

            ReportsNdateTextBox.Text = ck(chkReports, ReportsNdateTextBox)
            FridgeTextBox.Text = ck(chkFridge, FridgeTextBox)


            OthersTextBox.Text = ck(chkOthers, OthersTextBox)

            up(10, 0)
            index(49)
            fll(49)
            ld(49)

            status("User updated.")
        End If
    End Sub
End Class