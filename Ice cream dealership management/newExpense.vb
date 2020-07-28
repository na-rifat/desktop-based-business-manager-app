Public Class newExpense
    Private Sub TblExpensesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblExpensesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub newExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblExpenseSubcategory' table. You can move, or remove it, as needed.
        Me.TblExpenseSubcategoryTableAdapter.Fill(Me.DataSet.tblExpenseSubcategory)
        'TODO: This line of code loads data into the 'DataSet.tblExpenseCategory' table. You can move, or remove it, as needed.
        Me.TblExpenseCategoryTableAdapter.Fill(Me.DataSet.tblExpenseCategory)
        'TODO: This line of code loads data into the 'DataSet.tblBankAccounts' table. You can move, or remove it, as needed.
        Me.TblBankAccountsTableAdapter.Fill(Me.DataSet.tblBankAccounts)
        'TODO: This line of code loads data into the 'DataSet.tblTransaction' table. You can move, or remove it, as needed.
        Me.TblTransactionTableAdapter.Fill(Me.DataSet.tblTransaction)
        'TODO: This line of code loads data into the 'DataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me.DataSet.tblEmployee)
        'TODO: This line of code loads data into the 'DataSet.tblEmployeeAccounts' table. You can move, or remove it, as needed.
        Me.TblEmployeeAccountsTableAdapter.Fill(Me.DataSet.tblEmployeeAccounts)
        center(Me, Panel1)
    End Sub

    Private Sub TblExpensesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblExpensesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub TblExpensesBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblExpensesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ExpenseCategoryComboBox.Text = Nothing Then
            status("Please select a category!")
        Else
            If ExpenseSubCategoryComboBox.Text = Nothing Then
                status("Please select a subcategory!")
            Else
                If PaymentMethodComboBox.SelectedIndex = 1 Or PaymentMethodComboBox.SelectedIndex = 2 Then
                    'bank balance calculation
                    TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                    OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                    If TblBankAccountsBindingSource.Count > 0 Then
                        TblTransactionBindingSource.AddNew()
                        AmountTextBox1.Text = BankamountTextBox.Text
                        TransactionTypeTextBox.Text = "Withdraw"
                        AccNoTextBox1.Text = AccNoTextBox.Text
                        DateTextBox2.Text = DateTimePicker1.Value.Date
                        PersonOrsourceTextBox.Text = "Withdraw for expense"
                        'balance calculation
                        TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                        OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                    Else
                        status("Bank account not found.")
                    End If

                End If

                If chkES.Checked = True Or chkEE.Checked = True Then

                    If ConfirmatoinTextBox.Text = "Yes" Then
                        TblEmployeeAccountsBindingSource.AddNew()
                        EmployeeNameTextBox.Text = txtEmployeeName.Text
                        EmployeeIDTextBox.Text = txtEmployeeID.Text
                        If PaymentMethodComboBox.SelectedIndex = 0 Then
                            PaymentTextBox.Text = Double.Parse(AmountTextBox.Text)
                        ElseIf PaymentMethodComboBox.SelectedIndex = 1 Then
                            PaymentTextBox.Text = Double.Parse(BankamountTextBox.Text)
                        ElseIf PaymentMethodComboBox.SelectedIndex = 2 Then
                            PaymentTextBox.Text = Double.Parse(AmountTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                        End If
                        DateTextBox.Text = DateTimePicker1.Value.Date
                        DateTextBox1.Text = DateTextBox.Text
                        Validate()
                        TblEmployeeAccountsBindingSource.EndEdit()
                        TableAdapterManager.UpdateAll(DataSet)

                        up(34, 0)
                        index(26)
                        fll(26)
                        ld(26)
                        status("Expense updated.")
                    Else
                        index(66)
                        'all.pinconfirmation.ShowDialog()
                        fll(66)
                        ld(66)
                        all.pinconfirmation.txtpin.Select()
                    End If
                Else
                    DateTextBox.Text = DateTimePicker1.Value.Date
                    up(34, 0)
                    index(26)
                    fll(26)
                    ld(26)
                    status("Expense updated.")
                End If
                Validate()
                TblTransactionBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        End If
    End Sub

    Private Sub ExpenseSubCategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExpenseSubCategoryComboBox.SelectedIndexChanged

    End Sub

    Private Sub ExpenseSubCategoryComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ExpenseSubCategoryComboBox.KeyPress

    End Sub

    Private Sub ExpenseSubCategoryComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ExpenseSubCategoryComboBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblExpenseSubcategoryBindingSource.Filter = "cName LIKE '%" & ExpenseSubCategoryComboBox.Text & "%'"
                ExpenseCategoryComboBox.Text = CTextBox.Text
                If TblExpenseSubcategoryBindingSource.Count > 0 AndAlso ExpenseCategoryComboBox.Text = CTextBox.Text Then
                    ExpenseSubCategoryComboBox.Text = CNameTextBox1.Text
                Else
                    ExpenseSubCategoryComboBox.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try

        If e.KeyCode = Keys.Enter Then
            AmountTextBox.Select()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        index(16)
        fll(16)
        ld(16)
    End Sub

    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles chkES.CheckedChanged
        If chkES.Checked = True Then
            chkEE.Checked = False
            ExpenseCategoryComboBox.Text = "Employee salary"
            ExpenseCategoryComboBox.Enabled = False
            ExpenseSubCategoryComboBox.Text = "Employee salary"
            ExpenseSubCategoryComboBox.Enabled = False
            txtEmployeeID.Enabled = True
            txtEmployeeName.Enabled = True
        End If
        If chkEE.Checked = False And chkES.Checked = False Then
            ExpenseCategoryComboBox.Enabled = True
            ExpenseSubCategoryComboBox.Enabled = True
            ExpenseSubCategoryComboBox.ResetText()
            ExpenseCategoryComboBox.Text = ""
            txtEmployeeName.Enabled = False
            txtEmployeeID.Enabled = False
        End If


        'If chkES.Checked = True Then

        'Else
        '    ExpenseCategoryComboBox.Text = ""
        '    ExpenseCategoryComboBox.Enabled = True
        '    ExpenseSubCategoryComboBox.Enabled = True
        '    txtEmployeeName.Enabled = False
        '    txtEmployeeID.Enabled = False
        'End If
        'If chkES.Checked = True Then
        '    chkEE.Checked = False
        'End If

    End Sub

    Private Sub txtEmployeeName_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeName.TextChanged
        PersonNameTextBox.Text = txtEmployeeName.Text
    End Sub

    Private Sub txtEmployeeName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmployeeName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TblEmployeeBindingSource.Filter = "employeeName LIKE '%" & txtEmployeeName.Text & "%'"
                If TblEmployeeBindingSource.Count > 0 Then
                    txtEmployeeName.Text = EmployeeNameTextBox1.Text
                    txtEmployeeID.Text = IdTextBox1.Text
                Else
                    txtEmployeeName.Clear()
                    txtEmployeeID.Clear()
                End If
                AmountTextBox.Select()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtEmployeeID_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeID.TextChanged

    End Sub

    Private Sub txtEmployeeID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmployeeID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TblEmployeeBindingSource.Filter = "Id =" & txtEmployeeID.Text
                If TblEmployeeBindingSource.Count > 0 Then
                    txtEmployeeName.Text = EmployeeNameTextBox1.Text
                    txtEmployeeID.Text = IdTextBox1.Text
                Else
                    txtEmployeeName.Clear()
                    txtEmployeeID.Clear()
                End If
                AmountTextBox.Select()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub chkEE_CheckedChanged(sender As Object, e As EventArgs) Handles chkEE.CheckedChanged
        If chkEE.Checked = True Then
            ExpenseCategoryComboBox.Enabled = False
            ExpenseSubCategoryComboBox.Enabled = False
            ExpenseCategoryComboBox.Text = "Employee expense"
            ExpenseSubCategoryComboBox.Text = "Employee expense"
            txtEmployeeID.Enabled = True
            txtEmployeeName.Enabled = True
            chkES.Checked = False
        End If

        If chkEE.Checked = False And chkES.Checked = False Then
            ExpenseCategoryComboBox.Enabled = True
            ExpenseSubCategoryComboBox.Enabled = True
            ExpenseSubCategoryComboBox.ResetText()
            ExpenseCategoryComboBox.Text = ""
            txtEmployeeName.Enabled = False
            txtEmployeeID.Enabled = False
        End If
    End Sub

    Private Sub ExpenseCategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExpenseCategoryComboBox.SelectedIndexChanged

    End Sub

    Private Sub ExpenseCategoryComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ExpenseCategoryComboBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblExpenseCategoryBindingSource.Filter = "cName LIKE '%" & ExpenseCategoryComboBox.Text & "%'"
                If TblExpenseCategoryBindingSource.Count > 0 Then
                    ExpenseCategoryComboBox.Text = CNameTextBox.Text
                Else
                    ExpenseCategoryComboBox.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printP0(Panel1, "New expense")
    End Sub

    Private Sub AmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles AmountTextBox.TextChanged

    End Sub

    Private Sub ExpenseNoteTextBox_TextChanged(sender As Object, e As EventArgs) Handles ExpenseNoteTextBox.TextChanged

    End Sub

    Private Sub ExpenseNoteTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ExpenseNoteTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ExpenseCategoryComboBox.Text = Nothing Then
                status("Please select a category!")
            Else
                If ExpenseSubCategoryComboBox.Text = Nothing Then
                    status("Please select a subcategory!")
                Else
                    If PaymentMethodComboBox.SelectedIndex = 1 Or PaymentMethodComboBox.SelectedIndex = 2 Then
                        'bank balance calculation
                        TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                        OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                        If TblBankAccountsBindingSource.Count > 0 Then
                            TblTransactionBindingSource.AddNew()
                            AmountTextBox1.Text = BankamountTextBox.Text
                            TransactionTypeTextBox.Text = "Withdraw"
                            AccNoTextBox1.Text = AccNoTextBox.Text
                            DateTextBox2.Text = DateTimePicker1.Value.Date
                            PersonOrsourceTextBox.Text = "Withdraw for expense"
                            'balance calculation
                            TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                            OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                        Else
                            status("Bank account not found.")
                        End If

                    End If

                    If chkES.Checked = True Or chkEE.Checked = True Then

                        If ConfirmatoinTextBox.Text = "Yes" Then
                            TblEmployeeAccountsBindingSource.AddNew()
                            EmployeeNameTextBox.Text = txtEmployeeName.Text
                            EmployeeIDTextBox.Text = txtEmployeeID.Text
                            If PaymentMethodComboBox.SelectedIndex = 0 Then
                                PaymentTextBox.Text = Double.Parse(AmountTextBox.Text)
                            ElseIf PaymentMethodComboBox.SelectedIndex = 1 Then
                                PaymentTextBox.Text = Double.Parse(BankamountTextBox.Text)
                            ElseIf PaymentMethodComboBox.SelectedIndex = 2 Then
                                PaymentTextBox.Text = Double.Parse(AmountTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                            End If
                            DateTextBox.Text = DateTimePicker1.Value.Date
                            DateTextBox1.Text = DateTextBox.Text
                            Validate()
                            TblEmployeeAccountsBindingSource.EndEdit()
                            TableAdapterManager.UpdateAll(DataSet)

                            up(34, 0)
                            index(26)
                            fll(26)
                            ld(26)
                            status("Expense updated.")
                        Else
                            index(66)
                            'all.pinconfirmation.ShowDialog()
                            fll(66)
                            ld(66)
                            all.pinconfirmation.txtpin.Select()
                        End If
                    Else
                        DateTextBox.Text = DateTimePicker1.Value.Date
                        up(34, 0)
                        index(26)
                        fll(26)
                        ld(26)
                        status("Expense updated.")
                    End If
                    Validate()
                    TblTransactionBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)
                End If
            End If
        End If
    End Sub
End Class