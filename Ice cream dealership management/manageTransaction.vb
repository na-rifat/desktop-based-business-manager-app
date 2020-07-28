Public Class manageTransaction
    Private Sub TblTransactionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblTransactionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblIncome' table. You can move, or remove it, as needed.
        Me.TblIncomeTableAdapter.Fill(Me.DataSet.tblIncome)
        'TODO: This line of code loads data into the 'DataSet.tblExpenses' table. You can move, or remove it, as needed.
        Me.TblExpensesTableAdapter.Fill(Me.DataSet.tblExpenses)
        'TODO: This line of code loads data into the 'DataSet.tblBankAccounts' table. You can move, or remove it, as needed.
        Me.TblBankAccountsTableAdapter.Fill(Me.DataSet.tblBankAccounts)
        cto(Me, Panel1)
        KeyPreview = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        nw(33, 0)
        Panel2.Enabled = True
        TransactionIDTextBox.Select()
        DateTextBox.Text = Date.Today
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(33, 0)
        up(33, 0)
        Panel2.Enabled = False
        GroupBox1.Text = "New transaction"
        Button1.Text = "Add"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        ab(33, 0)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TblTransactionBindingSource.Filter = "transactionID =" & txtSearch.Text
            ElseIf txtFilter.SelectedIndex = 2 Then
                TblTransactionBindingSource.Filter = "date ='" & txtSearch.Text & "'"
            Else
                filter(33, txtFilter.SelectedIndex, 22, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblTransactionBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rdnD_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printD(TblTransactionDataGridView, "Bank transactions")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub AccNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles AccNoTextBox.TextChanged

    End Sub

    Private Sub AccNoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AccNoTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                If TblBankAccountsBindingSource.Count > 0 Then
                    AccNoTextBox.Text = AccountNumberTextBox.Text
                Else
                    AccNoTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click




        If rdnD.Checked = True Then
            TransactionTypeTextBox.Text = "Deposit"

        ElseIf rdnW.Checked = True Then
            TransactionTypeTextBox.Text = "Withdraw"
        End If

        If MsgBox("Confirm transaction?" & vbNewLine & vbNewLine &
                "Transaction ID : " & TransactionIDTextBox.Text & vbNewLine &
                "Account NO : " & AccNoTextBox.Text & vbNewLine &
                "Transaction type : " & TransactionTypeTextBox.Text & vbNewLine &
                "Amount : " & AmountTextBox.Text,
                  MsgBoxStyle.YesNo, "Bank transaction confirmation"
                  ) = MsgBoxResult.Yes Then

            'expense
            If chk_expense.Checked = True Then
                TblExpensesBindingSource.AddNew()
                ExpenseCategoryTextBox.Text = "Bank withdraw -expense"
                ExpenseNoteTextBox.Text = "Expense given to " & PersonOrsourceTextBox.Text
                AmountTextBox1.Text = 0
                DateTextBox1.Text = fromDt.Value.Date()
                PersonNameTextBox.Text = PersonOrsourceTextBox.Text
                ExpenseSubCategoryTextBox.Text = "None"
                AccNoTextBox1.Text = AccNoTextBox.Text
                BankamountTextBox.Text = AmountTextBox.Text
                PaymentMethodComboBox.SelectedIndex = 1
                Validate()
                TblExpensesBindingSource.EndEdit()
            End If
            'income
            If chk_income.Checked = True Then
                TblIncomeBindingSource.AddNew()
                IncomeCategoryTextBox.Text = "Bank deposit -income"
                IncomeNoteTextBox.Text = "Income receive from " & PersonOrsourceTextBox.Text
                AmountTextBox2.Text = 0
                DateTextBox2.Text = fromDt.Value.Date()
                IncomeSubcategoryTextBox.Text = "None"
                AccNoTextBox2.Text = AccNoTextBox.Text
                BankamountTextBox1.Text = AmountTextBox.Text
                PaymentmethodComboBox1.SelectedIndex = 1
                Validate()
                TblIncomeBindingSource.EndEdit()
            End If


            TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
            If TblBankAccountsBindingSource.Count > 0 Then
                If rdnD.Checked = True Then
                    TransactionTypeTextBox.Text = "Deposit"
                    OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) + Double.Parse(AmountTextBox.Text)
                ElseIf rdnW.Checked = True Then
                    TransactionTypeTextBox.Text = "Withdraw"
                    OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) - Double.Parse(AmountTextBox.Text)
                End If

                DateTextBox.Text = fromDt.Value.Date
                Validate()
                TblBankAccountsBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
                up(33, 0)
                Panel2.Enabled = False
            End If
        End If

    End Sub

    Private Sub manageTransaction_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            nw(33, 0)
            Panel2.Enabled = True
            TransactionIDTextBox.Select()
            DateTextBox.Text = Date.Today
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(33, 0)
            up(33, 0)
            Panel2.Enabled = False
            GroupBox1.Text = "New transaction"
            Button1.Text = "Add"
        End If
    End Sub

    Private Sub NoteTextBox_TextChanged(sender As Object, e As EventArgs) Handles NoteTextBox.TextChanged

    End Sub

    Private Sub NoteTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NoteTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rdnD.Checked = True Then
                TransactionTypeTextBox.Text = "Deposit"

            ElseIf rdnW.Checked = True Then
                TransactionTypeTextBox.Text = "Withdraw"
            End If

            If MsgBox("Confirm transaction?" & vbNewLine & vbNewLine &
                    "Transaction ID : " & TransactionIDTextBox.Text & vbNewLine &
                    "Account NO : " & AccNoTextBox.Text & vbNewLine &
                    "Transaction type : " & TransactionTypeTextBox.Text & vbNewLine &
                    "Amount : " & AmountTextBox.Text,
                      MsgBoxStyle.YesNo, "Bank transaction confirmation"
                      ) = MsgBoxResult.Yes Then
                TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                If TblBankAccountsBindingSource.Count > 0 Then
                    If rdnD.Checked = True Then
                        TransactionTypeTextBox.Text = "Deposit"
                        OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) + Double.Parse(AmountTextBox.Text)
                    ElseIf rdnW.Checked = True Then
                        TransactionTypeTextBox.Text = "Withdraw"
                        OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) - Double.Parse(AmountTextBox.Text)
                    End If

                    DateTextBox.Text = fromDt.Value.Date
                    Validate()
                    TblBankAccountsBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)
                    up(33, 0)
                    Panel2.Enabled = False
                End If
            End If
        End If
    End Sub
    Public Function transaction_count()
        Dim t As New Timer
        Dim withdraw As Double
        Dim deposit As Double
        AddHandler t.Tick, Function()
                               Try
                                   withdraw = 0
                                   deposit = 0
                                   For a As Integer = 0 To TblTransactionBindingSource.Count - 1
                                       If TblTransactionDataGridView.Rows(a).Cells(2).Value.ToString = "Deposit" Then
                                           deposit += Double.Parse(TblTransactionDataGridView.Rows(a).Cells(1).Value.ToString)
                                       ElseIf TblTransactionDataGridView.Rows(a).Cells(2).Value.ToString = "Withdraw" Then
                                           withdraw += Double.Parse(TblTransactionDataGridView.Rows(a).Cells(1).Value.ToString)
                                       End If
                                   Next
                                   tool.Items(0).Text = "মোট ডিপজিটঃ " & deposit & all.dashboard.CurrencyTextBox.Text
                                   tool.Items(2).Text = "মোট উইথ-ড্রঃ " & withdraw & all.dashboard.CurrencyTextBox.Text
                               Catch ex As Exception

                               End Try
                               Return 0
                           End Function
        t.Start()
        Return 0
    End Function
End Class