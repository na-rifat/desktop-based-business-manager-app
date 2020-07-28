Public Class addCustomer
    Private Sub TblCustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblCustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub addCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblCusomterAccounts' table. You can move, or remove it, as needed.
        Me.TblCusomterAccountsTableAdapter.Fill(Me.DataSet.tblCusomterAccounts)
        'TODO: This line of code loads data into the 'DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.DataSet.tblCustomers)
        center(Me, Panel1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'input for opening accounts
        If chk_add.Checked = True Then
            CustomerNameTextBox1.Text = ShopOrCompanyNameTextBox.Text
            CustomerIDTextBox1.Text = CustomerIDTextBox.Text
            DateTextBox.Text = Today
            If PaymentTextBox.Text = Nothing Then
                PaymentTextBox.Text = 0
            End If
            If PaidTextBox.Text = Nothing Then
                PaidTextBox.Text = 0
            End If
            If DueTextBox.Text = Nothing Then
                DueTextBox.Text = 0
            End If
            Validate()
            TblCusomterAccountsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
        End If

        all.newsale.ShopNameTextBox.AutoCompleteCustomSource.Clear()

        '
        up(54, 0)
        index(53)
        fll(53)
        ld(53)
        status("Customer updated.")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        printP0(Panel1, "Add customer")
    End Sub

    Private Sub PaidTextBox_TextChanged(sender As Object, e As EventArgs) Handles PaidTextBox.TextChanged
        Try
            If PaymentTextBox.Text = Nothing Then
                PaymentTextBox.Text = 0
            End If
            If Double.Parse(PaidTextBox.Text) > Double.Parse(PaymentTextBox.Text) Then
                PaidTextBox.Text = PaymentTextBox.Text
            End If
            If PaidTextBox.Text = Nothing Then
                DueTextBox.Text = 0
            End If
            DueTextBox.Text = Double.Parse(PaymentTextBox.Text) - Double.Parse(PaidTextBox.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DueTextBox_TextChanged(sender As Object, e As EventArgs) Handles DueTextBox.TextChanged

    End Sub

    Private Sub DueTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DueTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            'input for opening accounts
            If chk_add.Checked = True Then
                CustomerNameTextBox1.Text = ShopOrCompanyNameTextBox.Text
                CustomerIDTextBox1.Text = CustomerIDTextBox.Text
                DateTextBox.Text = Today
                If PaymentTextBox.Text = Nothing Then
                    PaymentTextBox.Text = 0
                End If
                If PaidTextBox.Text = Nothing Then
                    PaidTextBox.Text = 0
                End If
                If DueTextBox.Text = Nothing Then
                    DueTextBox.Text = 0
                End If
                Validate()
                TblCusomterAccountsBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If

            all.newsale.ShopNameTextBox.AutoCompleteCustomSource.Clear()

            '
            up(54, 0)
            index(53)
            fll(53)
            ld(53)
            status("Customer updated.")
        End If
    End Sub

    Private Sub addCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub chk_add_CheckedChanged(sender As Object, e As EventArgs) Handles chk_add.CheckedChanged

    End Sub

    Private Sub CustomerNoteTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerNoteTextBox.TextChanged

    End Sub

    Private Sub CustomerNoteTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomerNoteTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_add.Checked = True Then
                PaymentTextBox.Select()
            Else
                'input for opening accounts
                If chk_add.Checked = True Then
                    CustomerNameTextBox1.Text = ShopOrCompanyNameTextBox.Text
                    CustomerIDTextBox1.Text = CustomerIDTextBox.Text
                    DateTextBox.Text = Today
                    If PaymentTextBox.Text = Nothing Then
                        PaymentTextBox.Text = 0
                    End If
                    If PaidTextBox.Text = Nothing Then
                        PaidTextBox.Text = 0
                    End If
                    If DueTextBox.Text = Nothing Then
                        DueTextBox.Text = 0
                    End If
                    Validate()
                    TblCusomterAccountsBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)
                End If

                all.newsale.ShopNameTextBox.AutoCompleteCustomSource.Clear()

                '
                up(54, 0)
                index(53)
                fll(53)
                ld(53)
                status("Customer updated.")
            End If
        End If
    End Sub
End Class