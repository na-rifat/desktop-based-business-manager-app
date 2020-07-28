Public Class addSupplier
    Private Sub addSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSupplierAccounts' table. You can move, or remove it, as needed.
        Me.TblSupplierAccountsTableAdapter.Fill(Me.DataSet.tblSupplierAccounts)
        center(Me, Panel1)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TblSuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblSuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If chk_add.Checked = True Then
            'opening account
            If PaymentTextBox.Text = Nothing Then
                PaymentTextBox.Text = 0
            End If
            If PaidTextBox.Text = Nothing Then
                PaidTextBox.Text = 0
            End If
            If DueTextBox.Text = Nothing Then
                DueTextBox.Text = 0
            End If
            SupplierNameTextBox1.Text = SupplierNameTextBox.Text
            SupplierIDTextBox1.Text = SupplierIDTextBox.Text
            DateTextBox.Text = Today
            Validate()
            TblSupplierAccountsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
            status("Company updated and added a new account.")
        Else
            status("Company updated.")
        End If

        up(6, 0)

        index(32)
        fll(32)
        ld(32)

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub AddressTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AddressTextBox.KeyPress

    End Sub

    Private Sub AddressTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AddressTextBox.KeyDown

    End Sub

    Private Sub SupplierNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierNameTextBox.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printP0(Panel1, "Company")
    End Sub

    Private Sub PaidTextBox_TextChanged(sender As Object, e As EventArgs) Handles PaidTextBox.TextChanged
        Try
            If PaymentTextBox.Text = Nothing Then
                PaymentTextBox.Text = 0
            End If
            If PaidTextBox.Text = Nothing Then
                DueTextBox.Text = 0
            End If
            Try
                DueTextBox.Text = Double.Parse(PaymentTextBox.Text) - Double.Parse(PaidTextBox.Text)
            Catch ex As Exception

            End Try
            If Double.Parse(PaidTextBox.Text) > Double.Parse(PaymentTextBox.Text) Then
                PaidTextBox.Text = PaymentTextBox.Text
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TblSupplierAccountsBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Validate()
        TblSupplierAccountsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub chk_add_CheckedChanged(sender As Object, e As EventArgs) Handles chk_add.CheckedChanged

    End Sub

    Private Sub DueTextBox_TextChanged(sender As Object, e As EventArgs) Handles DueTextBox.TextChanged

    End Sub

    Private Sub DueTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DueTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_add.Checked = True Then
                'opening account
                If PaymentTextBox.Text = Nothing Then
                    PaymentTextBox.Text = 0
                End If
                If PaidTextBox.Text = Nothing Then
                    PaidTextBox.Text = 0
                End If
                If DueTextBox.Text = Nothing Then
                    DueTextBox.Text = 0
                End If
                SupplierNameTextBox1.Text = SupplierNameTextBox.Text
                SupplierIDTextBox1.Text = SupplierIDTextBox.Text
                DateTextBox.Text = Today
                Validate()
                TblSupplierAccountsBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
                status("Company updated and added a new account.")
            Else
                status("Company updated.")
            End If

            up(6, 0)

            index(32)
            fll(32)
            ld(32)
        End If
    End Sub

    Private Sub SupplierNoteTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierNoteTextBox.TextChanged

    End Sub

    Private Sub SupplierNoteTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SupplierNoteTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_add.Checked = True Then
                PaymentTextBox.Select()
            Else
                If chk_add.Checked = True Then
                    'opening account
                    If PaymentTextBox.Text = Nothing Then
                        PaymentTextBox.Text = 0
                    End If
                    If PaidTextBox.Text = Nothing Then
                        PaidTextBox.Text = 0
                    End If
                    If DueTextBox.Text = Nothing Then
                        DueTextBox.Text = 0
                    End If
                    SupplierNameTextBox1.Text = SupplierNameTextBox.Text
                    SupplierIDTextBox1.Text = SupplierIDTextBox.Text
                    DateTextBox.Text = Today
                    Validate()
                    TblSupplierAccountsBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)
                    status("Company updated and added a new account.")
                Else
                    status("Company updated.")
                End If

                up(6, 0)

                index(32)
                fll(32)
                ld(32)
            End If
        End If
    End Sub

    Private Sub chk_nonprofit_CheckedChanged(sender As Object, e As EventArgs) Handles chk_nonprofit.CheckedChanged

        If Non_profitTextBox.Text = Nothing AndAlso chk_nonprofit.Checked = True Then
            Non_profitTextBox.Text = "1"
        ElseIf Non_profitTextBox.Text = "1" AndAlso chk_nonprofit.Checked = False Then
            Non_profitTextBox.Text = "0"
        ElseIf Non_profitTextBox.Text = "0" AndAlso chk_nonprofit.Checked = True Then
            Non_profitTextBox.Text = "1"
            End If

    End Sub
End Class