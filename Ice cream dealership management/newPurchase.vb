Public Class newPurchase

    Public mode As Integer
    Private Sub TblPurchaseBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblPurchaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub newPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblExpenses' table. You can move, or remove it, as needed.
        Me.TblExpensesTableAdapter.Fill(Me.DataSet.tblExpenses)
        'TODO: This line of code loads data into the 'DataSet.tblPCommission' table. You can move, or remove it, as needed.
        Me.TblPCommissionTableAdapter.Fill(Me.DataSet.tblPCommission)



    End Sub
    Public Function purchase_mng()
        Dim t As New Timer
        t.Interval = 500
        AddHandler t.Tick, Function()
                               If InvoiceNoTextBox1.Text = Nothing Then
                                   InvoiceNoTextBox1.Text = InvoiceNoTextBox.Text
                               End If
                               SupplierTextBox3.Text = SupplierTextBox.Text
                               Validate()
                               TblPurchaseBindingSource.EndEdit()
                               TableAdapterManager.UpdateAll(DataSet)
                               Try
                                   For a As Integer = 0 To TblPurchaseBindingSource.Count - 1
                                       TblPurchaseDataGridView.Rows(a).Cells(2).Value() = Double.Parse(TblPurchaseDataGridView.Rows(a).Cells(1).Value().ToString()) * Double.Parse(TblPurchaseDataGridView.Rows(a).Cells(3).Value().ToString())
                                   Next
                                   TotalAmountTextBox.Text = dtsum(TblPurchaseDataGridView, 2)
                               Catch ex As Exception

                               End Try

                               Return 0
                               'due
                               'Try
                               '    If BankamountTextBox.Text.Length = 0 AndAlso PaidTextBox1.Text.Length > 0 Then
                               '        DueTextBox1.Text = Double.Parse(Net_amountTextBox.Text) - Double.Parse(PaidTextBox1.Text)
                               '    ElseIf BankamountTextBox.Text.Length > 0 AndAlso PaidTextBox1.Text.Length > 0 Then
                               '        DueTextBox1.Text = Double.Parse(Net_amountTextBox.Text) - (Double.Parse(PaidTextBox1.Text) + Double.Parse(BankamountTextBox.Text))
                               '    ElseIf (BankamountTextBox.Text.Length = 0 AndAlso PaidTextBox1.Text.Length = 0) Or (BankamountTextBox.Text = 0 AndAlso PaidTextBox1.Text = 0 Or (PaidTextBox1.Text = Nothing)) Then
                               '        DueTextBox1.Text = Net_amountTextBox.Text
                               '    Else
                               '        DueTextBox1.Text = Net_amountTextBox.Text
                               '    End If
                               'Catch ex As Exception
                               '    DueTextBox1.Text = Net_amountTextBox.Text
                               'End Try
                           End Function
        t.Start()
        Return 0
    End Function

    Private Sub TblPurchaseBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblPurchaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If SupplierTextBox.Text = Nothing Then
                status("Products must come from a company, please enter company name.")
            Else
                If TblPurchaseBindingSource.Count = 0 Then
                    status("Invoice must be included with some products.")
                Else
                    If MsgBox("Confirm invoice?" & vbNewLine & vbNewLine &
                           "Company : " & SupplierTextBox.Text & vbNewLine &
                           "Invoice NO : " & InvoiceNoTextBox.Text & vbNewLine &
                           "Reciept NO : " & CompanyInvoiceTextBox.Text & vbNewLine &
                           "Date : " & date_picker.Value.Date & vbNewLine & vbNewLine &
                           "Billing :-" & vbNewLine &
                           "Total amount : " & TotalAmountTextBox.Text & vbNewLine &
                           "Paid(cash) : " & PaidTextBox1.Text & vbNewLine &
                           "Paid(bank) : " & BankamountTextBox.Text & vbNewLine &
                           "Due : " & DueTextBox1.Text, MsgBoxStyle.YesNo, "Purchase invoice confirmation") =
                           MsgBoxResult.Yes Then

                        DateTextBox1.Text = date_picker.Value.Date

                        up(36, 1)


                        If mode = 0 Then
                            'stock calculation
                            TblProductsBindingSource.RemoveFilter()
                            all.newpurchase_timer.Stop()
                            TblProductsBindingSource.MoveFirst()
                            For a = 0 To TblPurchaseBindingSource.Count - 1
                                TblProductsBindingSource.Filter = "productCode =" & TblPurchaseDataGridView.Rows(a).Cells(4).Value().ToString()
                                AvailableTextBox.Text = Integer.Parse(AvailableTextBox.Text) + Integer.Parse(TblPurchaseDataGridView.Rows(a).Cells(1).Value().ToString())
                                Validate()
                                TblProductsBindingSource.EndEdit()
                                TableAdapterManager.UpdateAll(DataSet)
                                'TblPurchaseBindingSource.Filter = "productCode =" & ProductCodeTextBox1.Text & " AND invoiceNo =" & InvoiceNoTextBox.Text
                                'If TblPurchaseBindingSource.Count > 0 Then
                                '    Try
                                '        AvailableTextBox.Text = Integer.Parse(AvailableTextBox.Text) + Integer.Parse(dtsum(TblPurchaseDataGridView, 1))
                                '    Catch ex As Exception

                                '    End Try
                                'End If
                                TblProductsBindingSource.MoveNext()
                            Next
                            '''''''''''''''''
                            'bank trnasaction
                            If PaymentmethodComboBox.SelectedIndex = 1 Or PaymentmethodComboBox.SelectedIndex = 2 Then
                                TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                                If TblBankAccountsBindingSource.Count > 0 Then
                                    TblTransactionBindingSource.AddNew()
                                    AmountTextBox.Text = BankamountTextBox.Text
                                    TransactionTypeTextBox.Text = "Withdraw"
                                    AccNoTextBox1.Text = AccNoTextBox.Text
                                    DateTextBox4.Text = date_picker.Value.Date
                                    PersonOrsourceTextBox.Text = "Withdraw for purchase (Invoice NO: " & InvoiceNoTextBox.Text & ")"
                                    'bank balance calculation
                                    TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                                    OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) - Double.Parse(BankamountTextBox.Text)
                                Else
                                    status("Bank account not found.")
                                End If

                            End If
                            '''''''''''''''''''''''''
                            'supplier accounts
                            TblSupplierAccountsBindingSource.AddNew()
                            SupplierNameTextBox.Text = SupplierTextBox.Text
                            SupplierIDTextBox.Text = txtSupplierID.Text
                            PurchaseInvoiceTextBox.Text = InvoiceNoTextBox.Text
                            PaymentTextBox.Text = Net_amountTextBox.Text
                            If PaymentmethodComboBox.SelectedIndex = 0 Then
                                PaidTextBox.Text = PaidTextBox1.Text
                            ElseIf PaymentmethodComboBox.SelectedIndex = 1 Then
                                PaidTextBox.Text = BankamountTextBox.Text
                            ElseIf PaymentmethodComboBox.SelectedIndex = 2 Then
                                PaidTextBox.Text = Double.Parse(PaidTextBox1.Text) + Double.Parse(BankamountTextBox.Text)
                            End If

                            PaidTextBox.Text = PaidTextBox1.Text
                            DueTextBox.Text = DueTextBox1.Text
                            DateTextBox.Text = Date.Today
                            ''''''''''''''''''
                            'expense
                            TblExpensesBindingSource.AddNew()
                            ExpenseCategoryTextBox.Text = "Company payment"
                            ExpenseSubCategoryTextBox.Text = "Company payment"
                            ExpenseNoteTextBox.Text = "Expense for purchase from" + SupplierTextBox.Text + " || Invoice NO: " + InvoiceNoTextBox.Text
                            If PaymentmethodComboBox.SelectedIndex = 0 Then
                                AmountTextBox1.Text = PaidTextBox.Text
                            ElseIf PaymentmethodComboBox.SelectedIndex = 1 Then
                                BankamountTextBox1.Text = BankamountTextBox.Text
                                AccNoTextBox2.Text = AccNoTextBox.Text
                            ElseIf PaymentmethodComboBox.SelectedIndex = 2 Then
                                Try
                                    AmountTextBox1.Text = PaidTextBox.Text
                                    BankamountTextBox1.Text = BankamountTextBox.Text
                                    AccNoTextBox2.Text = AccNoTextBox.Text
                                Catch ex As Exception

                                End Try
                            End If
                            DateTextBox5.Text = date_picker.Value.Date()
                            PaymentMethodComboBox1.Text = PaymentmethodComboBox.Text
                            Payment_remarkTextBox.Text = "Payment paid for purchase by " + PaymentmethodComboBox.Text
                            Invoice_noTextBox.Text = InvoiceNoTextBox.Text
                            ''''''''''''''''''                
                        End If
                        Validate()
                        TblSupplierAccountsBindingSource.EndEdit()
                        TblTransactionBindingSource.EndEdit()
                        TblProductsBindingSource.EndEdit()
                        TblPurchaseBindingSource.EndEdit()
                        TblPurchaseInvoiceBindingSource.EndEdit()
                        TblPCommissionBindingSource.EndEdit()
                        TblExpensesBindingSource.EndEdit()
                        TblSupplierAccountsBindingSource.EndEdit()
                        TableAdapterManager.UpdateAll(DataSet)
                        up(36, 0)
                        index(30)
                        fll(30)
                        ld(30)

                        status("Purchase invoice updated")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'chk.Enabled = True
        'chk.Checked = False

        ProductNameTextBox.Select()
        If TotalAmountTextBox.Text = Nothing Then
            TotalAmountTextBox.Text = 0
        End If
        If PaidTextBox.Text = Nothing Then
            PaidTextBox.Text = 0
        End If
        If DueTextBox.Text = Nothing Then
            DueTextBox.Text = 0
        End If
        Validate()
        TblPurchaseBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
        nw(36, 1)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub SupplierTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierTextBox.TextChanged

    End Sub

    Private Sub txtSupplierID_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierID.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PaidTextBox1_TextChanged(sender As Object, e As EventArgs) Handles PaidTextBox1.TextChanged
        Try
            If Double.Parse(PaidTextBox1.Text) < 0 Then
                PaidTextBox1.Text = 0
            End If


            If PaymentmethodComboBox.SelectedIndex = 0 Then
                DueTextBox1.Text = Double.Parse(Net_amountTextBox.Text) - Double.Parse(PaidTextBox1.Text)
            ElseIf PaymentmethodComboBox.SelectedIndex = 1 Then
                DueTextBox1.Text = Double.Parse(Net_amountTextBox.Text) - Double.Parse(BankamountTextBox.Text)
            ElseIf PaymentmethodComboBox.SelectedIndex = 2 Then
                If PaidTextBox1.Text = Nothing Then
                    PaidTextBox1.Text = 0
                ElseIf BankamountTextBox.Text = Nothing Then
                    BankamountTextBox.Text = 0
                End If
                DueTextBox1.Text = Double.Parse(Net_amountTextBox.Text) - (Double.Parse(PaidTextBox1.Text) + Double.Parse(BankamountTextBox.Text))
            End If

            If PaymentmethodComboBox.SelectedIndex = 0 Then
                If Double.Parse(PaidTextBox1.Text) > Double.Parse(Net_amountTextBox.Text) Then
                    PaidTextBox1.Text = Net_amountTextBox.Text
                End If
            ElseIf PaymentmethodComboBox.SelectedIndex = 1 Then
                If Double.Parse(PaidTextBox1.Text) > Double.Parse(BankamountTextBox.Text) Then
                    BankamountTextBox.Text = Net_amountTextBox.Text
                End If
            ElseIf PaymentmethodComboBox.SelectedIndex = 2 Then
                If (Double.Parse(PaidTextBox1.Text) + Double.Parse(BankamountTextBox.Text)) > Net_amountTextBox.Text Then
                    PaidTextBox1.Text = Double.Parse(Net_amountTextBox.Text) - Double.Parse(BankamountTextBox.Text)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PaidTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles PaidTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If PaidTextBox1.Text = Nothing Then
                PaidTextBox1.Text = 0
            End If
        End If
    End Sub

    Private Sub UnitPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles UnitPriceTextBox.TextChanged
        'Try
        '    NetPriceTextBox.Text = CType(UnitPriceTextBox.Text, Double) * CType(QuantityTextBox.Text, Double)
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub SupplierTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SupplierTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TblSuppliersBindingSource.Filter = "supplierName Like '%" & SupplierTextBox.Text & "%'"
                txtSupplierID.Text = SupplierIDTextBox1.Text
                SupplierTextBox.Text = SupplierNameTextBox1.Text
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtSupplierID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSupplierID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TblSuppliersBindingSource.Filter = "supplierID like '%" & txtSupplierID.Text & "%'"
                SupplierTextBox.Text = SupplierNameTextBox1.Text
                txtSupplierID.Text = SupplierIDTextBox1.Text
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ProductNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductNameTextBox.TextChanged

    End Sub

    Private Sub ProductNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductNameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TblProductsBindingSource.Filter = "productName LIKE '%" & ProductNameTextBox.Text & "%'"
                If TblProductsBindingSource.Count > 0 AndAlso SupplierTextBox2.Text = SupplierTextBox.Text Then
                    ProductCodeTextBox.Text = ProductCodeTextBox1.Text
                    ProductNameTextBox.Text = ProductNameTextBox1.Text
                    UnitPriceTextBox.Text = SellPriceTextBox.Text
                    txt_category.Text = ProductCategoryTextBox.Text
                    'textboxes
                    If QuantityTextBox.Text = Nothing Then
                        QuantityTextBox.Text = 0
                    End If
                    If NetPriceTextBox.Text = Nothing Then
                        NetPriceTextBox.Text = 0
                    End If

                Else
                    ProductNameTextBox.Clear()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ProductCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductCodeTextBox.TextChanged

    End Sub

    Private Sub ProductCodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductCodeTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            TblProductsBindingSource.Filter = "productCode =" & ProductCodeTextBox.Text
            If TblProductsBindingSource.Count > 0 Then
                ProductCodeTextBox.Text = ProductCodeTextBox1.Text
                ProductNameTextBox.Text = ProductNameTextBox1.Text
                UnitPriceTextBox.Text = SellPriceTextBox.Text
                txt_category.Text = ProductCategoryTextBox.Text
                'textboxes
                If QuantityTextBox.Text = Nothing Then
                    QuantityTextBox.Text = 0
                End If
                If NetPriceTextBox.Text = Nothing Then
                    NetPriceTextBox.Text = 0
                End If

            Else
                ProductNameTextBox.Clear()
            End If
            QuantityTextBox.Select()
        End If
    End Sub

    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged
        'Try
        '    'ProductCodeTextBox.Text = ProductCodeTextBox1.Text
        '    If QuantityTextBox.Text.Length > 0 Then
        '        NetPriceTextBox.Text = Double.Parse(UnitPriceTextBox.Text) * Double.Parse(QuantityTextBox.Text)
        '    End If

        'Catch ex As Exception

        'End Try
        DateTextBox3.Text = date_picker.Value.Date
    End Sub

    Private Sub NetPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles NetPriceTextBox.TextChanged

    End Sub

    Private Sub CompanyInvoiceTextBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyInvoiceTextBox.TextChanged

    End Sub

    Private Sub NetPriceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NetPriceTextBox.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If NetPriceTextBox.Text.Length > 1 Then
        '        NetPriceTextBox.Text = Double.Parse(UnitPriceTextBox.Text) * Double.Parse(QuantityTextBox.Text)
        '    End If
        '    Try
        '        Validate()
        '        TblPurchaseBindingSource.EndEdit()
        '        TableAdapterManager.UpdateAll(DataSet)

        '    Catch ex As Exception

        '    End Try
        'End If


    End Sub

    Private Sub TotalAmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalAmountTextBox.TextChanged

    End Sub

    Private Sub AvailableLabel1_Click(sender As Object, e As EventArgs) Handles AvailableLabel1.Click

    End Sub

    Private Sub CompanyInvoiceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CompanyInvoiceTextBox.KeyDown

    End Sub

    Private Sub QuantityTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles QuantityTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If QuantityTextBox.Text = Nothing Then
                status("Please enter a quantity!")
                QuantityTextBox.Select()
            End If
            '  DueTextBox1.Text = dtsum(TblPurchaseDataGridView, 2)
        End If
    End Sub

    Private Sub InvoiceNoTextBox1_TextChanged(sender As Object, e As EventArgs) Handles InvoiceNoTextBox1.TextChanged

    End Sub

    Private Sub InvoiceNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles InvoiceNoTextBox.TextChanged

    End Sub

    Private Sub UnitPriceLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs)
        'Try
        '    If chk.Checked = True Then
        '        TblPCommissionBindingSource.Filter = "productCode =" & ProductCodeTextBox.Text
        '        If TblPCommissionBindingSource.Count > 0 Then
        '            For a = 0 To TblPCommissionBindingSource.Count - 1
        '                Dim startday As Integer = Date.Parse(StartTextBox.Text).Day
        '                Dim startmonth As Integer = Date.Parse(StartTextBox.Text).Month
        '                Dim startyear As Integer = Date.Parse(StartTextBox.Text).Year

        '                Dim endday As Integer = Date.Parse(EndTextBox.Text).Day
        '                Dim endmonth As Integer = Date.Parse(EndTextBox.Text).Month
        '                Dim endyear As Integer = Date.Parse(EndTextBox.Text).Year

        '                If startday >= Today.Day AndAlso startmonth >= Today.Month AndAlso startyear >= Today.Year AndAlso endday <= Today.Day AndAlso endmonth <= Today.Month AndAlso endyear <= Today.Year Then
        '                    If Integer.Parse(QuantityTextBox2.Text) < Integer.Parse(TargetQuantityTextBox.Text) AndAlso Integer.Parse(QuantityTextBox.Text) <= (Integer.Parse(TargetQuantityTextBox.Text) - Integer.Parse(QuantityTextBox2.Text)) Then
        '                        QuantityTextBox2.Text = Integer.Parse(QuantityTextBox2.Text) + Integer.Parse(QuantityTextBox.Text)
        '                        chk.Enabled = False
        '                    Else
        '                        status("This quantity isn't valid for commission purchase.")
        '                        chk.Checked = False
        '                    End If
        '                Else
        '                    status("No commission season was found")
        '                    chk.Checked = False
        '                End If
        '            Next
        '        End If
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TotalAmountTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TotalAmountTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PaymentmethodComboBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BankamountTextBox_TextChanged(sender As Object, e As EventArgs) Handles BankamountTextBox.TextChanged
        Try
            If Double.Parse(BankamountTextBox.Text) < 0 Then
                PaidTextBox1.Text = 0
            End If


            If PaymentmethodComboBox.SelectedIndex = 0 Then
                DueTextBox1.Text = Double.Parse(Net_amountTextBox.Text) - Double.Parse(PaidTextBox1.Text)
            ElseIf PaymentmethodComboBox.SelectedIndex = 1 Then
                DueTextBox1.Text = Double.Parse(Net_amountTextBox.Text) - Double.Parse(BankamountTextBox.Text)
            ElseIf PaymentmethodComboBox.SelectedIndex = 2 Then
                If PaidTextBox1.Text = Nothing Then
                    PaidTextBox1.Text = 0
                ElseIf BankamountTextBox.Text = Nothing Then
                    BankamountTextBox.Text = 0
                End If
                DueTextBox1.Text = Double.Parse(Net_amountTextBox.Text) - (Double.Parse(PaidTextBox1.Text) + Double.Parse(BankamountTextBox.Text))
            End If

            If PaymentmethodComboBox.SelectedIndex = 0 Then
                If Double.Parse(PaidTextBox1.Text) > Double.Parse(Net_amountTextBox.Text) Then
                    PaidTextBox1.Text = Net_amountTextBox.Text
                End If
            ElseIf PaymentmethodComboBox.SelectedIndex = 1 Then
                If Double.Parse(PaidTextBox1.Text) > Double.Parse(BankamountTextBox.Text) Then
                    BankamountTextBox.Text = Net_amountTextBox.Text
                End If
            ElseIf PaymentmethodComboBox.SelectedIndex = 2 Then
                If (Double.Parse(PaidTextBox1.Text) + Double.Parse(BankamountTextBox.Text)) > Net_amountTextBox.Text Then
                    PaidTextBox1.Text = Double.Parse(Net_amountTextBox.Text) - Double.Parse(BankamountTextBox.Text)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printFP(Panel1, Label1.Text)
    End Sub

    Private Sub SupplierLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles cart_remove_button.Click
        TblPurchaseBindingSource.RemoveCurrent()
    End Sub

    Private Sub TblPurchaseDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblPurchaseDataGridView.CellContentClick
        'TblProductsBindingSource.Filter = "productCode =" + ProductCodeTextBox.Text
        'txt_category.Text = ProductCategoryTextBox.Text
    End Sub

    Private Sub newPurchase_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Control = True AndAlso mode = 0 Then
            If NetPriceTextBox.Text.Length > 1 Then
                NetPriceTextBox.Text = Double.Parse(UnitPriceTextBox.Text) * Double.Parse(QuantityTextBox.Text)
            End If
            Try
                Validate()
                TblPurchaseBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
                TotalAmountTextBox.Text = dtsum(TblPurchaseDataGridView, 2)
                '  DueTextBox1.Text = dtsum(TblPurchaseDataGridView, 2)
            Catch ex As Exception

            End Try

            ProductNameTextBox.Select()
            If TotalAmountTextBox.Text = Nothing Then
                TotalAmountTextBox.Text = 0
            End If
            If PaidTextBox.Text = Nothing Then
                PaidTextBox.Text = 0
            End If
            If DueTextBox.Text = Nothing Then
                DueTextBox.Text = 0
            End If
            Validate()
            TblPurchaseBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
            nw(36, 1)

        End If

        'delete cart 
        If e.KeyCode = Keys.Delete AndAlso e.Control = True AndAlso mode = 0 Then
            TblPurchaseBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub DueTextBox1_TextChanged(sender As Object, e As EventArgs) Handles DueTextBox1.TextChanged

    End Sub

    Private Sub DueTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles DueTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                If SupplierTextBox.Text = Nothing Then
                    status("Products must come from a company, please enter company name.")
                Else
                    If TblPurchaseBindingSource.Count = 0 Then
                        status("Invoice must be included with some products.")
                    Else
                        If MsgBox("Confirm invoice?" & vbNewLine & vbNewLine &
                               "Company : " & SupplierTextBox.Text & vbNewLine &
                               "Invoice NO : " & InvoiceNoTextBox.Text & vbNewLine &
                               "Reciept NO : " & CompanyInvoiceTextBox.Text & vbNewLine &
                               "Date : " & date_picker.Value.Date & vbNewLine & vbNewLine &
                               "Billing :-" & vbNewLine &
                               "Total amount : " & TotalAmountTextBox.Text & vbNewLine &
                               "Paid(cash) : " & PaidTextBox1.Text & vbNewLine &
                               "Paid(bank) : " & BankamountTextBox.Text & vbNewLine &
                               "Due : " & DueTextBox1.Text, MsgBoxStyle.YesNo, "Purchase invoice confirmation") =
                               MsgBoxResult.Yes Then

                            DateTextBox1.Text = date_picker.Value.Date

                            up(36, 1)


                            If mode = 0 Then
                                'stock calculation
                                TblProductsBindingSource.RemoveFilter()
                                all.newpurchase_timer.Stop()
                                TblProductsBindingSource.MoveFirst()
                                For a = 0 To TblPurchaseBindingSource.Count - 1
                                    TblProductsBindingSource.Filter = "productCode =" & TblPurchaseDataGridView.Rows(a).Cells(4).Value().ToString()
                                    AvailableTextBox.Text = Integer.Parse(AvailableTextBox.Text) + Integer.Parse(TblPurchaseDataGridView.Rows(a).Cells(1).Value().ToString())
                                    Validate()
                                    TblProductsBindingSource.EndEdit()
                                    TableAdapterManager.UpdateAll(DataSet)
                                    'TblPurchaseBindingSource.Filter = "productCode =" & ProductCodeTextBox1.Text & " AND invoiceNo =" & InvoiceNoTextBox.Text
                                    'If TblPurchaseBindingSource.Count > 0 Then
                                    '    Try
                                    '        AvailableTextBox.Text = Integer.Parse(AvailableTextBox.Text) + Integer.Parse(dtsum(TblPurchaseDataGridView, 1))
                                    '    Catch ex As Exception

                                    '    End Try
                                    'End If
                                    TblProductsBindingSource.MoveNext()
                                Next
                                '''''''''''''''''
                                'bank trnasaction
                                If PaymentmethodComboBox.SelectedIndex = 1 Or PaymentmethodComboBox.SelectedIndex = 2 Then
                                    TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                                    If TblBankAccountsBindingSource.Count > 0 Then
                                        TblTransactionBindingSource.AddNew()
                                        AmountTextBox.Text = BankamountTextBox.Text
                                        TransactionTypeTextBox.Text = "Withdraw"
                                        AccNoTextBox1.Text = AccNoTextBox.Text
                                        DateTextBox4.Text = date_picker.Value.Date
                                        PersonOrsourceTextBox.Text = "Withdraw for purchase (Invoice NO: " & InvoiceNoTextBox.Text & ")"
                                        'bank balance calculation
                                        TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                                        OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) - Double.Parse(BankamountTextBox.Text)
                                    Else
                                        status("Bank account not found.")
                                    End If

                                End If
                                '''''''''''''''''''''''''
                                'supplier accounts
                                TblSupplierAccountsBindingSource.AddNew()
                                SupplierNameTextBox.Text = SupplierTextBox.Text
                                SupplierIDTextBox.Text = txtSupplierID.Text
                                PurchaseInvoiceTextBox.Text = InvoiceNoTextBox.Text
                                PaymentTextBox.Text = Net_amountTextBox.Text
                                If PaymentmethodComboBox.SelectedIndex = 0 Then
                                    PaidTextBox.Text = PaidTextBox1.Text
                                ElseIf PaymentmethodComboBox.SelectedIndex = 1 Then
                                    PaidTextBox.Text = BankamountTextBox.Text
                                ElseIf PaymentmethodComboBox.SelectedIndex = 2 Then
                                    PaidTextBox.Text = Double.Parse(PaidTextBox1.Text) + Double.Parse(BankamountTextBox.Text)
                                End If

                                PaidTextBox.Text = PaidTextBox1.Text
                                DueTextBox.Text = DueTextBox1.Text
                                DateTextBox.Text = Date.Today
                                ''''''''''''''''''
                                'expense
                                TblExpensesBindingSource.AddNew()
                                ExpenseCategoryTextBox.Text = "Company payment"
                                ExpenseSubCategoryTextBox.Text = "Company payment"
                                ExpenseNoteTextBox.Text = "Expense for purchase from" + SupplierTextBox.Text + " || Invoice NO: " + InvoiceNoTextBox.Text
                                If PaymentmethodComboBox.SelectedIndex = 0 Then
                                    AmountTextBox1.Text = PaidTextBox.Text
                                ElseIf PaymentmethodComboBox.SelectedIndex = 1 Then
                                    BankamountTextBox1.Text = BankamountTextBox.Text
                                    AccNoTextBox2.Text = AccNoTextBox.Text
                                ElseIf PaymentmethodComboBox.SelectedIndex = 2 Then
                                    Try
                                        AmountTextBox1.Text = PaidTextBox.Text
                                        BankamountTextBox1.Text = BankamountTextBox.Text
                                        AccNoTextBox2.Text = AccNoTextBox.Text
                                    Catch ex As Exception

                                    End Try
                                End If
                                DateTextBox5.Text = date_picker.Value.Date()
                                PaymentMethodComboBox1.Text = PaymentmethodComboBox.Text
                                Payment_remarkTextBox.Text = "Payment paid for purchase by " + PaymentmethodComboBox.Text
                                Invoice_noTextBox.Text = InvoiceNoTextBox.Text
                                ''''''''''''''''''                
                            End If
                            Validate()
                            TblSupplierAccountsBindingSource.EndEdit()
                            TblTransactionBindingSource.EndEdit()
                            TblProductsBindingSource.EndEdit()
                            TblPurchaseBindingSource.EndEdit()
                            TblPurchaseInvoiceBindingSource.EndEdit()
                            TblPCommissionBindingSource.EndEdit()
                            TblExpensesBindingSource.EndEdit()
                            TblSupplierAccountsBindingSource.EndEdit()
                            TableAdapterManager.UpdateAll(DataSet)
                            up(36, 0)
                            index(30)
                            fll(30)
                            ld(30)

                            status("Purchase invoice updated")
                        End If
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Discount_percentTextBox_TextChanged(sender As Object, e As EventArgs) Handles Discount_percentTextBox.TextChanged
        Try
            Dim non_discount_amount As Double = 0
            For a As Integer = 0 To TblPurchaseBindingSource.Count - 1
                TblProductsBindingSource.Filter = "productCode ='" & TblPurchaseDataGridView.Rows(a).Cells(4).Value.ToString & "'"
                If TblProductsDataGridView.Rows(0).Cells(0).Value.ToString = "1" Then
                    non_discount_amount += prc(TblPurchaseDataGridView.Rows(a).Cells(2).Value.ToString, Discount_percentTextBox.Text)
                End If
            Next
            Net_amountTextBox.Text = Double.Parse(TotalAmountTextBox.Text) - (prc(Double.Parse(TotalAmountTextBox.Text), Double.Parse(Discount_percentTextBox.Text)) - non_discount_amount)
            DiscountTextBox.Text = (prc(Double.Parse(TotalAmountTextBox.Text), Double.Parse(Discount_percentTextBox.Text)) - non_discount_amount)
        Catch ex As Exception
            Net_amountTextBox.Text = TotalAmountTextBox.Text
        End Try
    End Sub
End Class