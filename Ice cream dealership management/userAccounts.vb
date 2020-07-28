Public Class userRoles
    Private Sub TblUserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub userRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.DataSet.tblUser)
    End Sub

    Private Sub chkProducts_CheckedChanged(sender As Object, e As EventArgs) Handles chkProducts.CheckedChanged
        ck(chkProducts, ProductsTextBox)
    End Sub
    Function ck(c As CheckBox, t As TextBox)
        If c.Checked = True Then
            t.Text = 1
        Else
            t.Text = 0
        End If
        Validate()
        TblUserBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
        Return 0
    End Function

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(49, 0)
        up(49, 0)
    End Sub

    Private Sub txtFilter_Click(sender As Object, e As EventArgs) Handles txtFilter.Click

    End Sub
    Function ckk()
        If ProductsTextBox.Text = 1 Then
            chkProducts.Checked = True
        Else
            chkProducts.Checked = False
        End If
        If SalesTextBox.Text = 1 Then
            chkSales.Checked = True
        Else
            chkSales.Checked = False
        End If
        If PurchaseTextBox.Text = 1 Then
            chkPurchase.Checked = True
        Else
            chkPurchase.Checked = False
        End If
        If SuppliersTextBox.Text = 1 Then
            chkSuppliers.Checked = True
        Else
            chkSuppliers.Checked = False
        End If
        If BankTransactionTextBox.Text = 1 Then
            chkTransaction.Checked = True
        Else
            chkTransaction.Checked = False
        End If
        If ExpensesTextBox.Text = 1 Then
            chkExpenses.Checked = True
        Else
            chkExpenses.Checked = False
        End If
        If IncomeTextBox.Text = 1 Then
            chkIncome.Checked = True
        Else
            chkIncome.Checked = False
        End If
        If EmplpoyeeTextBox.Text = 1 Then
            chkEmployee.Checked = True
        Else
            chkEmployee.Checked = False
        End If
        If ReportsNdateTextBox.Text = 1 Then
            chkReports.Checked = True
        Else
            chkReports.Checked = False
        End If
        If FridgeTextBox.Text = 1 Then
            chkFridge.Checked = True
        Else
            chkFridge.Checked = False
        End If


        Return 0
    End Function

    Private Sub chkSales_CheckedChanged(sender As Object, e As EventArgs) Handles chkSales.CheckedChanged
        ck(chkSales, SalesTextBox)
    End Sub

    Private Sub chkPurchase_CheckedChanged(sender As Object, e As EventArgs) Handles chkPurchase.CheckedChanged
        ck(chkPurchase, PurchaseTextBox)
    End Sub

    Private Sub chkSuppliers_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuppliers.CheckedChanged
        ck(chkSuppliers, SuppliersTextBox)
    End Sub

    Private Sub chkTransaction_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransaction.CheckedChanged
        ck(chkTransaction, BankTransactionTextBox)
    End Sub

    Private Sub chkExpenses_CheckedChanged(sender As Object, e As EventArgs) Handles chkExpenses.CheckedChanged
        ck(chkExpenses, ExpensesTextBox)
    End Sub

    Private Sub chkIncome_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncome.CheckedChanged
        ck(chkIncome, IncomeTextBox)
    End Sub

    Private Sub chkEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmployee.CheckedChanged
        ck(chkEmployee, EmplpoyeeTextBox)
    End Sub

    Private Sub chkReports_CheckedChanged(sender As Object, e As EventArgs) Handles chkReports.CheckedChanged
        ck(chkReports, ReportsNdateTextBox)
    End Sub

    Private Sub chkFridge_CheckedChanged(sender As Object, e As EventArgs) Handles chkFridge.CheckedChanged
        ck(chkFridge, FridgeTextBox)
    End Sub

    Private Sub chkDamage_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkDashboard_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            filter(49, txtFilter.SelectedIndex, 23, 0, txtSearch.Text)
            If txtSearch.Text = Nothing Then
                TblUserBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub chkOthers_CheckedChanged(sender As Object, e As EventArgs) Handles chkOthers.CheckedChanged
        ck(chkOthers, OthersTextBox)
    End Sub
End Class