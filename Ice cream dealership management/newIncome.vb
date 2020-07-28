Public Class newIncome
    Private Sub TblIncomeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblIncomeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub TblIncomeBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblIncomeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub newIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblIncomeSubcategory' table. You can move, or remove it, as needed.
        Me.TblIncomeSubcategoryTableAdapter.Fill(Me.DataSet.tblIncomeSubcategory)
        'TODO: This line of code loads data into the 'DataSet.tblIncomeCategory' table. You can move, or remove it, as needed.
        Me.TblIncomeCategoryTableAdapter.Fill(Me.DataSet.tblIncomeCategory)
        'TODO: This line of code loads data into the 'DataSet.tblTransaction' table. You can move, or remove it, as needed.
        Me.TblTransactionTableAdapter.Fill(Me.DataSet.tblTransaction)
        'TODO: This line of code loads data into the 'DataSet.tblBankAccounts' table. You can move, or remove it, as needed.
        Me.TblBankAccountsTableAdapter.Fill(Me.DataSet.tblBankAccounts)
        center(Me, Panel1)
    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TblIncomeBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblIncomeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IncomeCategoryComboBox.Text = Nothing Then
            status("Please select a category!")
        Else
            If IncomeSubcategoryComboBox.Text = Nothing Then
                status("Please select a subcategory")
            Else
                DateTextBox.Text = datt.Value.Date

                If PaymentmethodComboBox.SelectedIndex = 1 Or PaymentmethodComboBox.SelectedIndex = 2 Then
                    TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                    If TblBankAccountsBindingSource.Count > 0 Then
                        TblTransactionBindingSource.AddNew()
                        AmountTextBox1.Text = BankamountTextBox.Text
                        TransactionTypeTextBox.Text = "Deposit"
                        AccNoTextBox1.Text = AccNoTextBox.Text
                        DateTextBox1.Text = datt.Value.Date
                        PersonOrsourceTextBox.Text = "Deposit from income"

                        'bank balance calculation
                        TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                        OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                    Else
                        status("Bank account not found.")
                    End If

                End If


                Validate()
                TblTransactionBindingSource.EndEdit()

                TableAdapterManager.UpdateAll(DataSet)

                up(35, 0)
                index(28)
                fll(28)
                ld(28)
                status("Income updated.")
            End If
        End If

    End Sub

    Private Sub IncomeSubcategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IncomeSubcategoryComboBox.SelectedIndexChanged

    End Sub

    Private Sub IncomeSubcategoryComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles IncomeSubcategoryComboBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblIncomeSubcategoryBindingSource.Filter = "cName LIKE '%" & IncomeSubcategoryComboBox.Text & "%'"
                If TblIncomeSubcategoryBindingSource.Count > 0 AndAlso IncomeCategoryComboBox.Text = CTextBox.Text Then
                    IncomeSubcategoryComboBox.Text = CNameTextBox1.Text
                Else
                    IncomeSubcategoryComboBox.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try

        If e.KeyCode = Keys.Enter Then
            AmountTextBox.Select()
        End If
    End Sub

    Private Sub IncomeNoteTextBox_TextChanged(sender As Object, e As EventArgs) Handles IncomeNoteTextBox.TextChanged

    End Sub

    Private Sub IncomeNoteTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles IncomeNoteTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IncomeCategoryComboBox.Text = Nothing Then
                status("Please select a category!")
            Else
                If IncomeSubcategoryComboBox.Text = Nothing Then
                    status("Please select a subcategory")
                Else
                    DateTextBox.Text = datt.Value.Date

                    If PaymentmethodComboBox.SelectedIndex = 1 Or PaymentmethodComboBox.SelectedIndex = 2 Then
                        TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                        If TblBankAccountsBindingSource.Count > 0 Then
                            TblTransactionBindingSource.AddNew()
                            AmountTextBox1.Text = BankamountTextBox.Text
                            TransactionTypeTextBox.Text = "Deposit"
                            AccNoTextBox1.Text = AccNoTextBox.Text
                            DateTextBox1.Text = datt.Value.Date
                            PersonOrsourceTextBox.Text = "Deposit from income"

                            'bank balance calculation
                            TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                            OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                        Else
                            status("Bank account not found.")
                        End If

                    End If


                    Validate()
                    TblTransactionBindingSource.EndEdit()

                    TableAdapterManager.UpdateAll(DataSet)

                    up(35, 0)
                    index(28)
                    fll(28)
                    ld(28)
                    status("Income updated.")
                End If
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        index(20)
        fll(20)
        ld(20)
    End Sub
End Class