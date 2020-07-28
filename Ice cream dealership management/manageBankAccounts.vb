Public Class manageBankAccounts
    Private Sub TblBankAccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblBankAccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageBankAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblTransaction' table. You can move, or remove it, as needed.
        Me.TblTransactionTableAdapter.Fill(Me.DataSet.tblTransaction)
        'TODO: This line of code loads data into the 'DataSet.tblBanks' table. You can move, or remove it, as needed.
        Me.TblBanksTableAdapter.Fill(Me.DataSet.tblBanks)
        'TODO: This line of code loads data into the 'DataSet.tblBankAccounts' table. You can move, or remove it, as needed.
        Me.TblBankAccountsTableAdapter.Fill(Me.DataSet.tblBankAccounts)
        cto(Me, Panel1)
        KeyPreview = True
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Panel2.Enabled = True
        GroupBox1.Enabled = True
        nw(23, 0)
        AccountHolderNameTextBox.Select()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(23, 0)
        up(23, 0)
        Panel2.Enabled = False
        Button1.Text = "Add"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        up(23, 0)
        GroupBox1.Enabled = False
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(23, 0)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If OpeningBalanceTextBox.Text = Nothing Then
            OpeningBalanceTextBox.Text = 0
        Else
            TblTransactionBindingSource.AddNew()
            AmountTextBox.Text = OpeningBalanceTextBox.Text
            TransactionTypeTextBox.Text = "Deposit"
            AccNoTextBox.Text = AccountNumberTextBox.Text
            DateDateTimePicker.Value = Today
            NoteTextBox.Text = "This isn't a bank transaction. This transaction created for add opening bank balance."
            Validate()
            TblTransactionBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
        End If
        up(23, 0)
        Panel2.Enabled = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            filter(23, txtFilter.SelectedIndex, 1, 0, txtSearch.Text)
            If txtSearch.Text = Nothing Then
                TblBankAccountsBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        printD(TblBankAccountsDataGridView, "Bank accounts")
    End Sub

    Private Sub BankTextBox_TextChanged(sender As Object, e As EventArgs) Handles BankTextBox.TextChanged

    End Sub

    Private Sub BankTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BankTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                TblBanksBindingSource.Filter = "bankName LIKE '%" & BankTextBox.Text & "%'"
                If TblBanksBindingSource.Count > 0 Then
                    BankTextBox.Text = BankNameTextBox.Text
                Else
                    BankTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub manageBankAccounts_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Control = True Then
            Panel2.Enabled = True
            GroupBox1.Enabled = True
            nw(23, 0)
            AccountHolderNameTextBox.Select()
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(23, 0)
            up(23, 0)
            Panel2.Enabled = False
            Button1.Text = "Add"
        End If
    End Sub

    Private Sub OpeningBalanceTextBox_TextChanged(sender As Object, e As EventArgs) Handles OpeningBalanceTextBox.TextChanged

    End Sub

    Private Sub OpeningBalanceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles OpeningBalanceTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If OpeningBalanceTextBox.Text = Nothing Then
                OpeningBalanceTextBox.Text = 0
            Else
                TblTransactionBindingSource.AddNew()
                AmountTextBox.Text = OpeningBalanceTextBox.Text
                TransactionTypeTextBox.Text = "Deposit"
                AccNoTextBox.Text = AccountNumberTextBox.Text
                DateDateTimePicker.Value = Today
                NoteTextBox.Text = "This isn't a bank transaction. This transaction created for add opening bank balance."
                Validate()
                TblTransactionBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
            up(23, 0)
            Panel2.Enabled = False
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        MsgBox("Total bank accounts: " & TblBankAccountsBindingSource.Count)
    End Sub
End Class