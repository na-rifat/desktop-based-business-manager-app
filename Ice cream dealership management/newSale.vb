Public Class newSale
    Public tata As New Timer
    Dim t As New Timer
    Public mode As Integer
    Private Sub TblSalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub newSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'DataSet.tblIncome' table. You can move, or remove it, as needed.
        'Me.TblIncomeTableAdapter.Fill(Me.DataSet.tblIncome)
        ''TODO: This line of code loads data into the 'DataSet.tbldiscount' table. You can move, or remove it, as needed.
        'Me.TbldiscountTableAdapter.Fill(Me.DataSet.tbldiscount)
        ''TODO: This line of code loads data into the 'DataSet.tblSuppliers' table. You can move, or remove it, as needed.
        'Me.TblSuppliersTableAdapter.Fill(Me.DataSet.tblSuppliers)
        ''TODO: This line of code loads data into the 'DataSet.tblsellcommission' table. You can move, or remove it, as needed.
        'Me.TblsellcommissionTableAdapter.Fill(Me.DataSet.tblsellcommission)
        ''TODO: This line of code loads data into the 'DataSet.tblBankAccounts' table. You can move, or remove it, as needed.
        'Me.TblBankAccountsTableAdapter.Fill(Me.DataSet.tblBankAccounts)
        ''TODO: This line of code loads data into the 'DataSet.tblTransaction' table. You can move, or remove it, as needed.
        'Me.TblTransactionTableAdapter.Fill(Me.DataSet.tblTransaction)
        ''TODO: This line of code loads data into the 'DataSet.tblVehicleAccounts' table. You can move, or remove it, as needed.
        'Me.TblVehicleAccountsTableAdapter.Fill(Me.DataSet.tblVehicleAccounts)
        ''TODO: This line of code loads data into the 'DataSet.tblVehicle' table. You can move, or remove it, as needed.
        'Me.TblVehicleTableAdapter.Fill(Me.DataSet.tblVehicle)
        ''TODO: This line of code loads data into the 'DataSet.tblProducts' table. You can move, or remove it, as needed.
        'Me.TblProductsTableAdapter.Fill(Me.DataSet.tblProducts)
        ''TODO: This line of code loads data into the 'DataSet.tblCustomers' table. You can move, or remove it, as needed.
        'Me.TblCustomersTableAdapter.Fill(Me.DataSet.tblCustomers)
        ''TODO: This line of code loads data into the 'DataSet.tblCusomterAccounts' table. You can move, or remove it, as needed.
        'Me.TblCusomterAccountsTableAdapter.Fill(Me.DataSet.tblCusomterAccounts)      
        tata.Interval = 500
        AddHandler tata.Tick, Function()

                                  Try
                                      TblSalesBindingSource.Filter = "invoiceNo ='" & InvoiceNoTextBox.Text & "'"
                                      'payment method
                                      If cmbmethod.SelectedIndex = 0 Then
                                          PadiTextBox.ReadOnly = False
                                          BankamountTextBox.ReadOnly = True
                                          AccNoTextBox.ReadOnly = True
                                          BankamountTextBox.Text = 0
                                      ElseIf cmbmethod.SelectedIndex = 1 Then
                                          PadiTextBox.ReadOnly = True
                                          BankamountTextBox.ReadOnly = False
                                          AccNoTextBox.ReadOnly = False
                                          PadiTextBox.Text = 0
                                      ElseIf cmbmethod.SelectedIndex = 2 Then
                                          PadiTextBox.ReadOnly = False
                                          BankamountTextBox.ReadOnly = False
                                          AccNoTextBox.ReadOnly = False
                                      Else
                                          PadiTextBox.ReadOnly = True
                                          BankamountTextBox.ReadOnly = True
                                          AccNoTextBox.ReadOnly = True
                                          PadiTextBox.Text = 0
                                          BankamountTextBox.Text = 0
                                      End If

                                      'cart rmv button
                                      If TblSalesBindingSource.Count > 0 Then
                                          cart_remove_button.Enabled = True
                                      Else
                                          cart_remove_button.Enabled = False
                                      End If
                                      'date sale value
                                      If mode = 0 Then
                                          DateDateTimePicker.Value = datt.Value.Date
                                      End If
                                  Catch ex As Exception
                                  End Try


                                  If InvoiceNoTextBox1.Text = Nothing Then
                                      InvoiceNoTextBox1.Text = InvoiceNoTextBox.Text
                                  End If
                                  Validate()
                                  TbldiscountBindingSource.EndEdit()
                                  TblSalesBindingSource.EndEdit()
                                  TblsellcommissionBindingSource.EndEdit()
                                  ' TableAdapterManager.UpdateAll(DataSet)
                                  'loop started
                                  For i As Integer = 0 To TblSalesBindingSource.Count - 1
                                      Try
                                          TblSalesDataGridView.Rows(i).Cells(4).Value() = Double.Parse(TblSalesDataGridView.Rows(i).Cells(1).Value().ToString()) * Double.Parse(TblSalesDataGridView.Rows(i).Cells(6).Value.ToString())
                                      Catch ex As Exception

                                      End Try
                                      Try
                                          TblSalesDataGridView.Rows(i).Cells(2).Value() = Double.Parse(TblSalesDataGridView.Rows(i).Cells(4).Value().ToString()) - prc(Double.Parse(TblSalesDataGridView.Rows(i).Cells(4).Value().ToString()), Double.Parse(TblSalesDataGridView.Rows(i).Cells(3).Value().ToString()))
                                      Catch ex As Exception

                                      End Try
                                      If TblSalesDataGridView.Rows(i).Cells(10).Value.ToString = "1" Then
                                          TbldiscountBindingSource.Filter = "invoice_no ='" & InvoiceNoTextBox.Text & "' AND product_code ='" & TblSalesDataGridView.Rows(i).Cells(5).Value.ToString & "'"
                                          DiscountTextBox2.Text = TblSalesDataGridView.Rows(i).Cells(3).Value.ToString
                                          Given_discountTextBox.Text = prc(TblSalesDataGridView.Rows(i).Cells(4).Value.ToString, TblSalesDataGridView.Rows(i).Cells(3).Value.ToString)
                                          Net_priceTextBox.Text = TblSalesDataGridView.Rows(i).Cells(2).Value.ToString()
                                      End If
                                  Next

                                  '''''''''''''''
                                  Try
                                      TotalAmountTextBox.Text = dtsum(TblSalesDataGridView, 4)
                                      DiscountTextBox.Text = dtsum(TblSalesDataGridView, 4) - dtsum(TblSalesDataGridView, 2)
                                      dsct.Text = dtsum(TblSalesDataGridView, 4) - dtsum(TblSalesDataGridView, 2)
                                      GrandTotalTextBox.Text = Double.Parse(TotalAmountTextBox.Text) - Double.Parse(dsct.Text)
                                  Catch ex As Exception

                                  End Try

                                  Return 0
                              End Function



    End Sub

    Private Sub InvoiceNoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CustomeNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContactNumberLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AvailableLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QuantityLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UnitPriceLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TotalPriceLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DiscountLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NetPriceLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TaxLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GrandTotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaidLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DueLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaymentMethodLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TblSalesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub TblSalesBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub



    Private Sub CustomerNameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CustomerNameTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    Try
        '        TblCustomersBindingSource.Filter = "customerName LIKE '%" & CustomerNameTextBox.Text & "%'"
        '        If TblCustomersBindingSource.Count > 0 Then
        '            txtCustomerID.Text = CustomerIDTextBox1.Text
        '            CustomerNameTextBox.Text = CustomerNameTextBox2.Text
        '            ContactNumberTextBox.Text = ContactNumberTextBox1.Text
        '            ShopNameTextBox.Text = ShopOrCompanyNameTextBox.Text
        '        Else
        '            txtCustomerID.Clear()
        '            CustomerNameTextBox.Clear()
        '            ContactNumberTextBox.Clear()
        '            ShopNameTextBox.Clear()
        '        End If
        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub



    'Private Sub txtCustomerID_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        Try
    '            TblCustomersBindingSource.Filter = "customerID =" & txtCustomerID.Text
    '            If TblCustomersBindingSource.Count > 0 Then
    '                txtCustomerID.Text = CustomerIDTextBox1.Text
    '                CustomerNameTextBox.Text = ShippingAddressTextBox.Text
    '                ContactNumberTextBox.Text = ContactNumberTextBox1.Text
    '                ShopNameTextBox.Text = ShopOrCompanyNameTextBox.Text
    '            Else
    '                txtCustomerID.Clear()
    '                CustomerNameTextBox.Clear()
    '                ContactNumberTextBox.Clear()
    '                ShopNameTextBox.Clear()
    '            End If
    '            CustomerNameTextBox.Select()
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chk_sell_on.Checked = False
        chk_discount.Checked = False
        chk_discount.Enabled = True
        InvoiceNoTextBox1.Text = InvoiceNoTextBox.Text
        txt_category.Clear()


        nw(37, 1)
        ProductNameTextBox.Select()
    End Sub



    Private Sub UnitPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles UnitPriceTextBox.TextChanged
        Try
            'NetPriceTextBox.Text = CType(QuantityTextBox.Text, Double) * CType(UnitPriceTextBox.Text, Double)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductNameTextBox.TextChanged

    End Sub

    Private Sub ProductNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductNameTextBox.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try

                TblProductsBindingSource.Filter = "productName LIKE '%" & ProductNameTextBox.Text & "%'"
                ProductNameTextBox.Text = ProductNameTextBox1.Text
                txtProductID.Text = ProductCodeTextBox.Text
                SupplierTextBox.Text = SupplierTextBox1.Text
                txt_category.Text = ProductCategoryTextBox1.Text
                '
                '  DateDateTimePicker.Value = datt.Value.Date
                CompanyTextBox2.Text = SupplierTextBox1.Text
                Company_idTextBox2.Text = Company_idTextBox3.Text
                CustomerTextBox.Text = ShopNameTextBox.Text
                Customer_idTextBox2.Text = txtCustomerID.Text
                Purchase_priceTextBox.Text = PurchasePriceTextBox.Text
                ProfitTextBox2.Text = ProfitTextBox1.Text

                'commission
                TblSuppliersBindingSource.Filter = "supplierID ='" & Company_idTextBox2.Text & "'"
                '  MsgBox(Company_idTextBox2.Text & vbNewLine & TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(12).Value.ToString)
                If Non_profitTextBox.Text = "1" Then
                    UnitPriceTextBox.Text = PurchasePriceTextBox.Text
                Else
                    UnitPriceTextBox.Text = SellPriceTextBox.Text
                End If


                'textboxes
                If TotalPriceTextBox.Text = Nothing Then
                    TotalPriceTextBox.Text = 0
                End If
                If QuantityTextBox.Text = Nothing Then
                    QuantityTextBox.Text = 0
                End If
                If NetPriceTextBox.Text = Nothing Then
                    NetPriceTextBox.Text = 0
                End If
                If DiscountTextBox1.Text = Nothing Then
                    DiscountTextBox1.Text = 0
                End If
                DateTextBox8.Text = datt.Value.Date
                InvoiceNoTextBox1.Text = InvoiceNoTextBox.Text
                Validate()
                TblSalesBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtProductID.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductID.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                TblProductsBindingSource.Filter = "productCode =" & txtProductID.Text
                ProductNameTextBox.Text = ProductNameTextBox1.Text
                txtProductID.Text = ProductCodeTextBox.Text
                SupplierTextBox.Text = SupplierTextBox1.Text
                txt_category.Text = ProductCategoryTextBox1.Text
                '
                '  DateDateTimePicker.Value = datt.Value.Date
                CompanyTextBox2.Text = SupplierTextBox1.Text
                Company_idTextBox2.Text = Company_idTextBox3.Text
                CustomerTextBox.Text = ShopNameTextBox.Text
                Customer_idTextBox2.Text = txtCustomerID.Text
                Purchase_priceTextBox.Text = PurchasePriceTextBox.Text
                ProfitTextBox2.Text = ProfitTextBox1.Text

                'commission
                TblSuppliersBindingSource.Filter = "supplierID ='" & Company_idTextBox2.Text & "'"
                '  MsgBox(Company_idTextBox2.Text & vbNewLine & TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(12).Value.ToString)
                If Non_profitTextBox.Text = "1" Then
                    UnitPriceTextBox.Text = PurchasePriceTextBox.Text
                Else
                    UnitPriceTextBox.Text = SellPriceTextBox.Text
                End If


                'textboxes
                If TotalPriceTextBox.Text = Nothing Then
                    TotalPriceTextBox.Text = 0
                End If
                If QuantityTextBox.Text = Nothing Then
                    QuantityTextBox.Text = 0
                End If
                If NetPriceTextBox.Text = Nothing Then
                    NetPriceTextBox.Text = 0
                End If
                If DiscountTextBox1.Text = Nothing Then
                    DiscountTextBox1.Text = 0
                End If
                DateTextBox8.Text = datt.Value.Date
                InvoiceNoTextBox1.Text = InvoiceNoTextBox.Text
                Validate()
                TblSalesBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged


        Try
            InvoiceNoTextBox1.Text = InvoiceNoTextBox.Text
            'TblProductsBindingSource.Filter = "productCode =" & txtProductID.Text
            'If Is_comTextBox.Text = "1" Then
            '    UnitPriceTextBox.Text = PurchasePriceTextBox.Text
            'Else
            '    UnitPriceTextBox.Text = SellPriceTextBox.Text
            'End If
            'Dim current As Integer = TblSalesBindingSource.Position

            If Integer.Parse(QuantityTextBox.Text) > Integer.Parse(AvailableTextBox1.Text) Then
                status("Quantity:-" & QuantityTextBox.Text & "isn't available.")
                QuantityTextBox.Text = AvailableTextBox1.Text
            Else
                Try
                    'TotalPriceTextBox.Text = Double.Parse(QuantityTextBox.Text) * Double.Parse(UnitPriceTextBox.Text)
                    ' TotalPriceTextBox.Text = Double.Parse(TblSalesDataGridView.Rows(current).Cells(1).Value().ToString()) * Double.Parse(TblSalesDataGridView.Rows(current).Cells(6).Value().ToString())
                Catch ex As Exception
                    'MsgBox("Total")
                End Try
                Try
                    'NetPriceTextBox.Text = Double.Parse(TotalPriceTextBox.Text) - prc(Double.Parse(TotalPriceTextBox.Text), Double.Parse(DiscountTextBox1.Text))
                    ' NetPriceTextBox.Text = Double.Parse(TblSalesDataGridView.Rows(current).Cells(4).Value().ToString()) - Double.Parse(prc(Double.Parse(TblSalesDataGridView.Rows(current).Cells(4).Value.ToString()), Double.Parse(TblSalesDataGridView.Rows(current).Cells(3).Value().ToString())))
                Catch ex As Exception
                    'MsgBox("Net")
                End Try
                'QuantityTextBox.Text = QuantityTextBox.Text
                'Validate()
                'TblSalesBindingSource.EndEdit()
                'TableAdapterManager.UpdateAll(DataSet)

            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try



        'MsgBox(txtProductID.Text & vbNewLine & UnitPriceTextBox.Text & vbNewLine & TotalPriceTextBox.Text)


    End Sub

    Private Sub PaymentMethodTextBox_TextChanged(sender As Object, e As EventArgs) Handles PaymentMethodTextBox.TextChanged

    End Sub

    Private Sub PaymentMethodTextBox_GotFocus(sender As Object, e As EventArgs) Handles PaymentMethodTextBox.GotFocus

    End Sub

    Private Sub SupplierTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierTextBox.TextChanged

    End Sub

    Private Sub ContactNumberTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContactNumberTextBox_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub



    'Private Sub TotalAmountTextBox_KeyDown(sender As Object, e As KeyEventArgs)

    'End Sub

    Private Sub DiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountTextBox.TextChanged

    End Sub

    Private Sub SupplierTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SupplierTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NetPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles NetPriceTextBox.TextChanged
        ProductCodeTextBox2.Text = txtProductID.Text
        InvoiceNoTextBox1.Text = InvoiceNoTextBox.Text
    End Sub

    Private Sub NetPriceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NetPriceTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Validate()
            'TblSalesBindingSource.EndEdit()
            'TblsellcommissionBindingSource.EndEdit()
            'TbldiscountBindingSource.EndEdit()
            'TableAdapterManager.UpdateAll(DataSet)

            'TblSalesBindingSource.MoveFirst()
            'For a As Integer = 0 To TblSalesBindingSource.Count - 1
            '    Try
            '        TblProductsBindingSource.Filter = "productCode = " & txtProductID.Text
            '        'TblsellcommissionBindingSource.Filter = "invoice_no =" + InvoiceNoTextBox.Text + " AND product_id =" + txtProductID.Text
            '        If Is_comTextBox.Text = "1" Then
            '            UnitPriceTextBox.Text = PurchasePriceTextBox.Text
            '        Else
            '            UnitPriceTextBox.Text = SellPriceTextBox.Text
            '        End If
            '        TotalPriceTextBox.Text = Double.Parse(QuantityTextBox.Text) * Double.Parse(UnitPriceTextBox.Text)
            '        NetPriceTextBox.Text = Double.Parse(TotalPriceTextBox.Text) - Double.Parse(prc(TotalPriceTextBox.Text, DiscountTextBox1.Text))
            '    Catch ex As Exception

            '    End Try
            '    TblSalesBindingSource.MoveNext()
            'Next

            'Try
            '    TotalAmountTextBox.Text = dtsum(TblSalesDataGridView, 4)
            '    DiscountTextBox.Text = dtsum(TblSalesDataGridView, 4) - dtsum(TblSalesDataGridView, 2)
            '    dsct.Text = dtsum(TblSalesDataGridView, 4) - dtsum(TblSalesDataGridView, 2)
            '    GrandTotalTextBox.Text = Double.Parse(TotalAmountTextBox.Text) - Double.Parse(dsct.Text)
            'Catch ex As Exception

            'End Try
        End If
        'shorcut key


    End Sub



    Private Sub InvoiceNoTextBox_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub chkP_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_discount.CheckedChanged
        Try
            Dim current_p As Integer = TblSalesBindingSource.Position
            If chk_discount.Checked = True Then
                TbldiscountBindingSource.Filter = "invoice_no ='" & TblSalesDataGridView.Rows(current_p).Cells(7).Value.ToString & "' AND product_code ='" & TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString & "'"
                If TbldiscountBindingSource.Count = 0 Then
                    TbldiscountBindingSource.AddNew()
                    Product_nameTextBox1.Text = TblSalesDataGridView.Rows(current_p).Cells(0).Value.ToString
                    Product_codeTextBox.Text = TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString
                    Product_categoryTextBox.Text = TblSalesDataGridView.Rows(current_p).Cells(9).Value.ToString
                    CompanyTextBox1.Text = TblSalesDataGridView.Rows(current_p).Cells(8).Value.ToString
                    TblSuppliersBindingSource.Filter = "supplierName LIKE '%" & TblSalesDataGridView.Rows(current_p).Cells(8).Value.ToString & "%'"
                    Company_idTextBox1.Text = SupplierIDTextBox.Text
                    QuantityTextBox5.Text = TblSalesDataGridView.Rows(current_p).Cells(1).Value.ToString
                    Unit_priceTextBox1.Text = TblSalesDataGridView.Rows(current_p).Cells(6).Value.ToString
                    Total_priceTextBox.Text = TblSalesDataGridView.Rows(current_p).Cells(4).Value.ToString
                    'If TblSalesDataGridView.Rows(current_p).Cells(10).Value.ToString = Nothing Then
                    '    TblSalesDataGridView.Rows(current_p).Cells(10).Value = 0
                    'End If


                    Try
                        DiscountTextBox2.Text = TblSalesDataGridView.Rows(current_p).Cells(3).Value.ToString
                        Given_discountTextBox.Text = prc(TblSalesDataGridView.Rows(current_p).Cells(4).Value.ToString, TblSalesDataGridView.Rows(current_p).Cells(3).Value.ToString)
                    Catch ex As Exception

                    End Try
                    Try
                        Net_priceTextBox.Text = TblSalesDataGridView.Rows(current_p).Cells(4).Value.ToString - prc(TblSalesDataGridView.Rows(current_p).Cells(4).Value.ToString, TblSalesDataGridView.Rows(current_p).Cells(3).Value.ToString)
                    Catch ex As Exception

                    End Try



                    Invoice_noTextBox1.Text = InvoiceNoTextBox.Text
                    DateTextBox6.Text = datt.Value.Date
                    Customer_nameTextBox.Text = ShopNameTextBox.Text
                    Customer_idTextBox1.Text = txtCustomerID.Text
                    If ConfirmationTextBox1.Text = Nothing Then
                        ConfirmationTextBox1.Text = "No"
                    End If
                    'input
                    TblSalesDataGridView.Rows(current_p).Cells(10).Value = "1"
                    'readonly
                    DiscountTextBox1.ReadOnly = False
                    DiscountTextBox1.Select()
                    'Validate()
                    'TbldiscountBindingSource.EndEdit()
                    'TableAdapterManager.UpdateAll(DataSet)
                    status("Please enter discount value in (%).")
                Else

                    ' chk_discount.Checked = False
                End If
            Else
                'readonly       
                DiscountTextBox1.ReadOnly = True
                DiscountTextBox1.Text = 0
                TbldiscountBindingSource.Filter = "invoice_no ='" & TblSalesDataGridView.Rows(current_p).Cells(7).Value.ToString & "' AND product_code ='" & TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString & "'"
                If TbldiscountBindingSource.Count > 0 Then
                    While TbldiscountBindingSource.Count <> 0
                        TbldiscountBindingSource.RemoveCurrent()
                    End While
                End If

            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub DriverNameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub VehicleIDTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub



    'Private Sub dsct_TextChanged(sender As Object, e As EventArgs)
    '    'Try
    '    '    If chkP.Checked = True Then
    '    '        GrandTotalTextBox.Text = Double.Parse(TotalAmountTextBox.Text) - prc(Double.Parse(TotalAmountTextBox.Text), Double.Parse(dsct.Text))
    '    '        DiscountTextBox.Text = prc(Double.Parse(TotalAmountTextBox.Text), Double.Parse(dsct.Text))
    '    '    Else
    '    '        GrandTotalTextBox.Text = Double.Parse(TotalAmountTextBox.Text) - Double.Parse(dsct.Text)
    '    '        DiscountTextBox.Text = Double.Parse(dsct.Text)
    '    '    End If
    '    '    DueTextBox.Text = GrandTotalTextBox.Text
    '    'Catch ex As Exception

    '    'End Try
    'End Sub

    Private Sub QuantityTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles QuantityTextBox.KeyDown
        PadiTextBox.Text = GrandTotalTextBox.Text
    End Sub

    Private Sub BankamountTextBox_TextChanged(sender As Object, e As EventArgs)
        Try
            If Double.Parse(BankamountTextBox.Text) < 0 Then
                BankamountTextBox.Text = 0
            End If

            If cmbmethod.SelectedIndex = 0 Then
                DueTextBox.Text = Double.Parse(GrandTotalTextBox.Text) - Double.Parse(PadiTextBox.Text)
                If Double.Parse(PadiTextBox.Text) > Double.Parse(GrandTotalTextBox.Text) Then
                    PadiTextBox.Text = GrandTotalTextBox.Text
                End If
            ElseIf cmbmethod.SelectedIndex = 1 Then
                DueTextBox.Text = Double.Parse(GrandTotalTextBox.Text) - Double.Parse(BankamountTextBox.Text)
                If Double.Parse(BankamountTextBox.Text) > Double.Parse(GrandTotalTextBox.Text) Then
                    BankamountTextBox.Text = GrandTotalTextBox.Text
                End If
            ElseIf cmbmethod.SelectedIndex = 2 Then
                If PadiTextBox.Text = Nothing Then
                    PadiTextBox.Text = 0
                ElseIf BankamountTextBox.Text = Nothing Then
                    BankamountTextBox.Text = 0
                End If

                DueTextBox.Text = Double.Parse(GrandTotalTextBox.Text) - (Double.Parse(PadiTextBox.Text) + Double.Parse(BankamountTextBox.Text))
                If (Double.Parse(PadiTextBox.Text) + Double.Parse(BankamountTextBox.Text)) > Double.Parse(GrandTotalTextBox.Text) Then
                    BankamountTextBox.Text = Double.Parse(GrandTotalTextBox.Text) - Double.Parse(PadiTextBox.Text)
                End If
            End If

        Catch ex As Exception


        End Try
    End Sub

    Private Sub pnl_Paint(sender As Object, e As PaintEventArgs) Handles pnl.Paint

    End Sub



    Private Sub TotalPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalPriceTextBox.TextChanged

    End Sub

    Private Sub dsct_KeyDown(sender As Object, e As KeyEventArgs)
        Try
            If dsct.Text = Nothing Then
                dsct.Text = 0
            End If
            GrandTotalTextBox.Text = Double.Parse(TotalAmountTextBox.Text) - Double.Parse(dsct.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub UnitPriceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UnitPriceTextBox.KeyDown

    End Sub





    Private Sub TblSalesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblSalesDataGridView.CellContentClick

    End Sub



    Private Sub TblSalesDataGridView_MouseMove(sender As Object, e As MouseEventArgs) Handles TblSalesDataGridView.MouseMove

    End Sub

    Private Sub TblSalesDataGridView_MouseClick(sender As Object, e As MouseEventArgs) Handles TblSalesDataGridView.MouseClick

    End Sub



    Private Sub TblSalesDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles TblSalesDataGridView.KeyDown

    End Sub

    Private Sub DueTextBox_KeyUp(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub newSale_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'adding new product
        If e.KeyCode = Keys.N AndAlso e.Control = True AndAlso mode = 0 AndAlso e.Shift = False AndAlso e.Alt = False Then
            'first step
            Validate()
            TblSalesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
            chk_sell_on.Checked = False
            chk_discount.Checked = False

            Validate()
            TblProductsBindingSource.EndEdit()
            TblSalesBindingSource.EndEdit()
            TblsellcommissionBindingSource.EndEdit()
            TbldiscountBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
            nw(37, 1)
            ProductNameTextBox.Select()
            txt_category.Clear()
        End If

        'remove cart
        If e.Control = True AndAlso e.KeyCode = Keys.Delete AndAlso e.Alt = False AndAlso e.Shift = False Then
            Dim current_p As Integer = TblSalesBindingSource.Position

            Try
                'commission
                TblsellcommissionBindingSource.Filter = "invoice_no ='" & InvoiceNoTextBox.Text & "' AND product_id ='" & TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString & "'"
                If TblsellcommissionBindingSource.Count > 0 Then
                    TblsellcommissionBindingSource.RemoveCurrent()
                End If
                'discount
                TbldiscountBindingSource.Filter = "invoice_no ='" & InvoiceNoTextBox.Text & "' AND product_code ='" & TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString & "'"
                If TbldiscountBindingSource.Count > 0 Then
                    TbldiscountBindingSource.RemoveCurrent()
                End If
                TblSalesBindingSource.RemoveCurrent()
            Catch ex As Exception

            End Try
            chk_sell_on.Checked = False
            chk_discount.Checked = False
        End If
        'discount
        If e.Control = True AndAlso e.KeyCode = Keys.D AndAlso e.Shift = False AndAlso e.Alt = False Then
            chk_discount.Checked = True
        End If
        'commission
        'If e.Control AndAlso e.Shift = True AndAlso e.KeyCode = Keys.C AndAlso e.Alt = False Then
        '    chk_sell_on.Checked = True
        '    Me.NetPriceTextBox.Select()
        'End If
        'average commission wise sale
        'If e.Control = True AndAlso e.Shift = True AndAlso e.KeyCode = Keys.A AndAlso e.Alt = False Then
        '    If MsgBox("Confrirm ACWS?" & vbNewLine & "(Average commission wise sale).", MsgBoxStyle.YesNo,
        '          "Confirmation") = MsgBoxResult.Yes Then
        '        TblSalesBindingSource.MoveLast()
        '        For a As Integer = 0 To TblSalesBindingSource.Count - 1
        '            Try
        '                chk_sell_on.Checked = False
        '                TblProductsBindingSource.Filter = "productCode =" & TblSalesDataGridView.Rows(0).Cells(5).Value.ToString
        '                TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(6).Value = PurchasePriceTextBox.Text
        '                chk_sell_on.Checked = True
        '                TblSalesBindingSource.MovePrevious()
        '            Catch ex As Exception

        '            End Try
        '        Next
        '    End If
        'End If
        ''''''''''''
        'average discount
        If e.Control = True AndAlso e.Shift = True AndAlso e.KeyCode = Keys.S AndAlso e.Alt = False Then
            avg_dis.ShowDialog()
        End If
        'full paid
        If e.Control = True AndAlso e.KeyCode = Keys.P AndAlso e.Alt = False AndAlso e.Shift = False Then
            DueTextBox.Text = GrandTotalTextBox.Text
            PadiTextBox.Text = "0"
        End If
    End Sub

    Private Sub txt_category_TextChanged(sender As Object, e As EventArgs) Handles txt_category.TextChanged

    End Sub

    Private Sub chk_sell_on_CheckedChanged(sender As Object, e As EventArgs) Handles chk_sell_on.CheckedChanged
        Try
            'If DiscountTextBox1.Text = Nothing Then
            '    DiscountTextBox1.Text = 0
            'End If
            'started
            If chk_sell_on.Checked = True Then
                Dim current_p As Integer = TblSalesBindingSource.Position
                'if true
                TblProductsBindingSource.Filter = "productCode =" & TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString
                'data
                TblsellcommissionBindingSource.AddNew()
                Invoice_noTextBox.Text = InvoiceNoTextBox.Text
                DateTextBox5.Text = datt.Value.Date()
                Customer_nameTextBox.Text = ShopNameTextBox.Text
                Customer_idTextBox.Text = txtCustomerID.Text
                Company_nameTextBox.Text = SupplierTextBox.Text
                TblSuppliersBindingSource.Filter = "supplierName LIKE '%" & SupplierTextBox.Text & "%'"
                Company_idTextBox.Text = SupplierIDTextBox.Text
                ''


                TblSalesDataGridView.Rows(current_p).Cells(6).Value = PurchasePriceTextBox.Text
                Product_nameTextBox.Text = TblSalesDataGridView.Rows(current_p).Cells(0).Value.ToString
                Product_idTextBox.Text = TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString
                Unit_priceTextBox.Text = TblSalesDataGridView.Rows(current_p).Cells(6).Value.ToString
                ProfitTextBox.Text = ProfitTextBox1.Text
                QuantityTextBox4.Text = TblSalesDataGridView.Rows(current_p).Cells(1).Value.ToString
                Try
                    Earned_commissionTextBox.Text = prc(Unit_priceTextBox.Text, ProfitTextBox.Text) * Integer.Parse(TblSalesDataGridView.Rows(current_p).Cells(1).Value.ToString)
                Catch ex As Exception

                End Try
                ConfirmationTextBox.Text = "No"
                chk_sell_on.Enabled = False
                'input
                TblSalesDataGridView.Rows(current_p).Cells(11).Value = "1"

                'Try
                'TblProductsBindingSource.Filter = "productCode = " & txtProductID.Text
                'TblsellcommissionBindingSource.Filter = "invoice_no =" + InvoiceNoTextBox.Text + " AND product_id =" + txtProductID.Text
                'If Is_comTextBox.Text = "1" Then
                '     UnitPriceTextBox.Text = PurchasePriceTextBox.Text
                'Else
                '    UnitPriceTextBox.Text = SellPriceTextBox.Text
                'End If
                'TotalPriceTextBox.Text = Double.Parse(QuantityTextBox.Text) * Double.Parse(UnitPriceTextBox.Text)
                'NetPriceTextBox.Text = Double.Parse(TotalPriceTextBox.Text) - Double.Parse(prc(TotalPriceTextBox.Text, DiscountTextBox1.Text))
                'Catch ex As Exception

                'End Try
                Validate()
                TblsellcommissionBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            Else
                chk_sell_on.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TotalPriceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TotalPriceTextBox.KeyDown

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs)
        chk_sell_on.Checked = False
        chk_sell_on.Enabled = True
    End Sub





    Private Sub DiscountTextBox1_TextChanged(sender As Object, e As EventArgs) Handles DiscountTextBox1.TextChanged

    End Sub



    Private Sub newSale_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged

    End Sub



    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Confrirm ACWS?" & vbNewLine & "(Average commission wise sale).", MsgBoxStyle.YesNo,
                  "Confirmation") = MsgBoxResult.Yes Then
            TblSalesBindingSource.MoveLast()
            For a As Integer = 0 To TblSalesBindingSource.Count - 1
                Try
                    chk_sell_on.Checked = False
                    TblProductsBindingSource.Filter = "productCode =" & TblSalesDataGridView.Rows(0).Cells(5).Value.ToString
                    TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(6).Value = PurchasePriceTextBox.Text
                    chk_sell_on.Checked = True
                    TblSalesBindingSource.MovePrevious()
                Catch ex As Exception

                End Try
            Next
        End If
    End Sub




    Private Sub TblSalesDataGridView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TblSalesDataGridView.KeyPress

    End Sub

    Private Sub TblSalesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TblSalesBindingSource.CurrentChanged
        Try
            'MsgBox(1)
            Dim current_p As Integer = TblSalesBindingSource.Position

            If TblSalesDataGridView.Rows(current_p).Cells(10).Value.ToString = "1" Then
                chk_discount.Checked = True
            Else
                chk_discount.Checked = False
            End If
        Catch ex As Exception
            chk_discount.Checked = False
        End Try
    End Sub



    Private Sub cmbmethod_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs)
        TblsellcommissionBindingSource.Filter = "invoice_no ='" + InvoiceNoTextBox1.Text + "' AND product_id ='" + txtProductID.Text & "'"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        TbldiscountBindingSource.Filter = "invoice_no ='" + InvoiceNoTextBox1.Text + "' AND product_code ='" + txtProductID.Text & "'"
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs)
        Dim current_p As Integer = TblSalesBindingSource.Position
        MsgBox(TblSalesDataGridView.Rows(current_p).Cells(3).Value.ToString)


    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs)
        Dim current_p As Integer = TblSalesBindingSource.Position
        MsgBox(prc(TblSalesDataGridView.Rows(current_p).Cells(4).Value.ToString, TblSalesDataGridView.Rows(current_p).Cells(3).Value.ToString) * Integer.Parse(TblSalesDataGridView.Rows(current_p).Cells(1).Value.ToString))

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Dim current_p As Integer = TblSalesBindingSource.Position
        MsgBox(TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(2).Value.ToString())


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Dim current_p As Integer = TblSalesBindingSource.Position
        TbldiscountBindingSource.Filter = "invoice_no ='" & InvoiceNoTextBox.Text & "' AND product_code ='" & TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString & "'"
    End Sub

    Private Sub Button10_Click_2(sender As Object, e As EventArgs)
        Dim current_p As Integer = TblSalesBindingSource.Position
        TblsellcommissionBindingSource.Filter = "invoice_no ='" & InvoiceNoTextBox.Text & "' AND product_id ='" & TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString & "'"
    End Sub

    Private Sub Button9_Click_2(sender As Object, e As EventArgs)
        Dim current_p As Integer = TblSalesBindingSource.Position
        TbldiscountBindingSource.Filter = "invoice_no ='" & InvoiceNoTextBox.Text & "' AND product_code ='" & TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString & "'"
    End Sub



    Private Sub pnlSale_Paint(sender As Object, e As PaintEventArgs) Handles pnlSale.Paint

    End Sub

    Private Sub InvoiceNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles InvoiceNoTextBox.TextChanged

    End Sub

    Private Sub datt_ValueChanged(sender As Object, e As EventArgs) Handles datt.ValueChanged

    End Sub

    Private Sub ShopNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ShopNameTextBox.TextChanged

    End Sub

    Private Sub ShopNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ShopNameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TblCustomersBindingSource.Filter = "shopOrCompanyName LIKE '%" & ShopNameTextBox.Text & "%'"
                If TblCustomersBindingSource.Count > 0 Then
                    txtCustomerID.Text = CustomerIDTextBox1.Text
                    CustomerNameTextBox.Text = ShippingAddressTextBox.Text
                    ContactNumberTextBox.Text = ContactNumberTextBox1.Text
                    ShopNameTextBox.Text = ShopOrCompanyNameTextBox.Text
                Else
                    txtCustomerID.Clear()
                    CustomerNameTextBox.Clear()
                    ContactNumberTextBox.Clear()
                    ShopNameTextBox.Clear()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtCustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerID.TextChanged

    End Sub

    Private Sub txtCustomerID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomerID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TblCustomersBindingSource.Filter = "customerID ='" & txtCustomerID.Text & "'"
                If TblCustomersBindingSource.Count > 0 Then
                    txtCustomerID.Text = CustomerIDTextBox1.Text
                    CustomerNameTextBox.Text = ShippingAddressTextBox.Text
                    ContactNumberTextBox.Text = ContactNumberTextBox1.Text
                    ShopNameTextBox.Text = ShopOrCompanyNameTextBox.Text
                Else
                    txtCustomerID.Clear()
                    CustomerNameTextBox.Clear()
                    ContactNumberTextBox.Clear()
                    ShopNameTextBox.Clear()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DriverNameTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles DriverNameTextBox.TextChanged

    End Sub

    Private Sub DriverNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DriverNameTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblVehicleBindingSource.Filter = "driverName LIKE '%" & DriverNameTextBox.Text & "%'"
                If TblVehicleBindingSource.Count > 0 Then
                    DriverNameTextBox.Text = DriverNameTextBox1.Text
                    VehicleIDTextBox.Text = VehicleIDTextBox1.Text
                Else
                    DriverNameTextBox.Clear()
                    VehicleIDTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VehicleIDTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles VehicleIDTextBox.TextChanged

    End Sub

    Private Sub VehicleIDTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles VehicleIDTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblVehicleBindingSource.Filter = "vehicleID =" & VehicleIDTextBox.Text
                If TblVehicleBindingSource.Count > 0 Then
                    DriverNameTextBox.Text = DriverNameTextBox1.Text
                    VehicleIDTextBox.Text = VehicleIDTextBox1.Text
                Else
                    DriverNameTextBox.Clear()
                    VehicleIDTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            InvoiceNoTextBox.Text = Integer.Parse(InvoiceNoTextBox.Text) - 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            InvoiceNoTextBox.Text = Integer.Parse(InvoiceNoTextBox.Text) + 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelivery.CheckedChanged

    End Sub

    Private Sub TotalAmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalAmountTextBox.TextChanged

    End Sub

    Private Sub PadiTextBox_TextChanged(sender As Object, e As EventArgs) Handles PadiTextBox.TextChanged
        Try
            If Double.Parse(PadiTextBox.Text) < 0 Then
                PadiTextBox.Text = 0
            End If

            If cmbmethod.SelectedIndex = 0 Then
                DueTextBox.Text = Double.Parse(GrandTotalTextBox.Text) - Double.Parse(PadiTextBox.Text)
                If Double.Parse(PadiTextBox.Text) > Double.Parse(GrandTotalTextBox.Text) Then
                    PadiTextBox.Text = GrandTotalTextBox.Text
                End If
            ElseIf cmbmethod.SelectedIndex = 1 Then
                DueTextBox.Text = Double.Parse(GrandTotalTextBox.Text) - Double.Parse(BankamountTextBox.Text)
                If Double.Parse(BankamountTextBox.Text) > Double.Parse(GrandTotalTextBox.Text) Then
                    BankamountTextBox.Text = GrandTotalTextBox.Text
                End If
            ElseIf cmbmethod.SelectedIndex = 2 Then
                If PadiTextBox.Text = Nothing Then
                    PadiTextBox.Text = 0
                ElseIf BankamountTextBox.Text = Nothing Then
                    BankamountTextBox.Text = 0
                End If


                DueTextBox.Text = Double.Parse(GrandTotalTextBox.Text) - (Double.Parse(PadiTextBox.Text) + Double.Parse(BankamountTextBox.Text))
                If (Double.Parse(PadiTextBox.Text) + Double.Parse(BankamountTextBox.Text)) > Double.Parse(GrandTotalTextBox.Text) Then
                    PadiTextBox.Text = Double.Parse(GrandTotalTextBox.Text) - Double.Parse(BankamountTextBox.Text)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AccNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles AccNoTextBox.TextChanged

    End Sub

    Private Sub AccNoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AccNoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
            If TblBankAccountsBindingSource.Count = 0 Then
                MsgBox("Account not found!")
            Else
                AccNoTextBox.Text = AccountNumberTextBox.Text
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printFP(pnlSale, Label1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PaymentMethodTextBox.Text = cmbmethod.Text
            DateTextBox.Text = datt.Value.Date()
            DateTextBox1.Text = datt.Value.Date()
            CustomerIDTextBox3.Text = txtCustomerID.Text
            If MsgBox("Confirm this invoice?" & vbNewLine & vbNewLine &
                      "Invoice No : " & InvoiceNoTextBox.Text & vbNewLine &
                      "Address : " & CustomerNameTextBox.Text & vbNewLine & vbNewLine &
                      "Payment:-" & vbNewLine &
                      "Grand total : " & GrandTotalTextBox.Text & vbNewLine &
                      "Paid : " & PadiTextBox.Text & vbNewLine &
                      "Due : " & DueTextBox.Text & vbNewLine &
                      "Date : " & DateTextBox.Text,
                      MsgBoxStyle.YesNo,
                      "Sale invoice confirmation") = MsgBoxResult.Yes Then
                up(37, 0)





                If mode = 0 Then
                    'stock calculation
                    TblSalesBindingSource.MoveFirst()
                    For a As Integer = 0 To TblSalesBindingSource.Count - 1
                        TblProductsBindingSource.Filter = "productCode =" & Integer.Parse(TblSalesDataGridView.Rows(a).Cells(5).Value().ToString())
                        AvailableTextBox1.Text = Integer.Parse(AvailableTextBox1.Text) - Integer.Parse(TblSalesDataGridView.Rows(a).Cells(1).Value().ToString())
                        Validate()
                        TblProductsBindingSource.EndEdit()
                        TableAdapterManager.UpdateAll(DataSet)
                        TblSalesBindingSource.MoveNext()
                    Next

                    'stock calculation
                    'TblProductsBindingSource.RemoveFilter()
                    'all.newsale_timer.Stop()
                    'TblProductsBindingSource.MoveFirst()
                    'For a = 0 To TblProductsBindingSource.Count - 1
                    '    TblSalesBindingSource.Filter = "productCode =" & ProductCodeTextBox.Text & " AND invoiceNo =" & InvoiceNoTextBox.Text
                    '    If TblSalesBindingSource.Count > 0 Then
                    '        Try
                    '            AvailableTextBox1.Text = Integer.Parse(AvailableTextBox1.Text) - dtsum(TblSalesDataGridView, 1)
                    '        Catch ex As Exception

                    '        End Try

                    '    End If
                    '    TblProductsBindingSource.MoveNext()
                    'Next
                    ''''''''''''''''''
                    'input for bank
                    If cmbmethod.SelectedIndex = 1 Or cmbmethod.SelectedIndex = 2 Then
                        TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                        If TblBankAccountsBindingSource.Count > 0 Then
                            TblTransactionBindingSource.AddNew()
                            AmountTextBox.Text = BankamountTextBox.Text
                            TransactionTypeTextBox.Text = "Withdraw"
                            AccNoTextBox1.Text = AccNoTextBox.Text
                            DateTextBox4.Text = datt.Value.Date
                            PersonOrsourceTextBox.Text = "Withdraw for sale (Invoice NO: " & InvoiceNoTextBox.Text & ")"

                            'account balance calculation
                            TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                            OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) - Double.Parse(BankamountTextBox.Text)
                        Else
                            status("Bank account not found.")
                        End If
                    End If
                    '''''''''''''''''
                    'input customer accounts
                    TblCusomterAccountsBindingSource.AddNew()
                    CustomerNameTextBox1.Text = ShopOrCompanyNameTextBox.Text
                    CustomerIDTextBox.Text = txtCustomerID.Text
                    SaleInvoiceTextBox.Text = InvoiceNoTextBox.Text
                    PaymentTextBox.Text = GrandTotalTextBox.Text

                    If cmbmethod.SelectedIndex = 0 Then
                        PaidTextBox.Text = PadiTextBox.Text
                    ElseIf cmbmethod.SelectedIndex = 1 Then
                        PaidTextBox.Text = BankamountTextBox.Text
                    ElseIf cmbmethod.SelectedIndex = 2 Then
                        PaidTextBox.Text = Double.Parse(PadiTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                    End If
                    DateTextBox1.Text = datt.Value.Date()
                    DueTextBox1.Text = DueTextBox.Text

                    Validate()
                    TblCusomterAccountsBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)
                    ''''''''''''''''''''''
                    'input vehicle accounts
                    TblVehicleAccountsBindingSource.AddNew()
                    CustomerNameTextBox3.Text = ShopOrCompanyNameTextBox.Text
                    CustomerIDTextBox2.Text = CustomerIDTextBox.Text
                    SaleInvoiceTextBox2.Text = InvoiceNoTextBox.Text
                    VehicleIDTextBox2.Text = VehicleIDTextBox.Text
                    DriverNameTextBox2.Text = DriverNameTextBox.Text
                    TotalAmountTextBox1.Text = GrandTotalTextBox.Text
                    If cmbmethod.SelectedIndex = 0 Then
                        PaidTextBox1.Text = PadiTextBox.Text
                    ElseIf cmbmethod.SelectedIndex = 1 Then
                        PaidTextBox1.Text = BankamountTextBox.Text
                    ElseIf cmbmethod.SelectedIndex = 2 Then
                        PaidTextBox1.Text = Double.Parse(PadiTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                    End If
                    DueTextBox2.Text = DueTextBox.Text
                    DateTextBox3.Text = datt.Value.Date()
                    '''''''''''''''
                    'income
                    TblIncomeBindingSource.AddNew()
                    IncomeCategoryTextBox.Text = "Customer payment"
                    IncomeSubcategoryTextBox.Text = "Customer payment"
                    IncomeNoteTextBox.Text = "Income from sale || Invoice NO: " + InvoiceNoTextBox.Text
                    DateTextBox7.Text = datt.Value.Date()
                    If cmbmethod.SelectedIndex = 0 Then
                        AmountTextBox1.Text = PadiTextBox.Text
                    ElseIf cmbmethod.SelectedIndex = 1 Then
                        BankamountTextBox1.Text = BankamountTextBox.Text
                        AccNoTextBox2.Text = AccNoTextBox.Text
                    ElseIf cmbmethod.SelectedIndex = 2 Then
                        AmountTextBox1.Text = PadiTextBox.Text
                        BankamountTextBox1.Text = BankamountTextBox.Text
                        AccNoTextBox2.Text = AccNoTextBox.Text
                    End If
                    PaymentmethodComboBox.Text = cmbmethod.Text
                    Payment_remarkTextBox.Text = "Payment received from sale by " + cmbmethod.Text
                    Invoice_noTextBox2.Text = InvoiceNoTextBox.Text
                    '''''''''''''''
                End If


                up(37, 1)
                Validate()
                TblIncomeBindingSource.EndEdit()
                TblCustomersBindingSource.EndEdit()
                TblVehicleAccountsBindingSource.EndEdit()
                TblTransactionBindingSource.EndEdit()
                TblSCommissionBindingSource.EndEdit()
                TblsellcommissionBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)


                index(21)
                fll(21)
                ld(21)
                If chkDelivery.Checked = True AndAlso mode = 0 Then
                    delivery(InvoiceNoTextBox.Text, txtCustomerID.Text, VehicleIDTextBox.Text)
                End If
                status("Sale updated.")
            ElseIf mode = 1 Then
                'jodi edit er mode a thake tobe eta


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cart_remove_button_Click(sender As Object, e As EventArgs) Handles cart_remove_button.Click
        tata.Stop()
        Dim current_p As Integer = TblSalesBindingSource.Position
        Try
            'commission
            TblsellcommissionBindingSource.Filter = "invoice_no ='" & InvoiceNoTextBox.Text & "' AND product_id ='" & TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString & "'"
            If TblsellcommissionBindingSource.Count > 0 Then
                TblsellcommissionBindingSource.RemoveCurrent()
            End If
            'discount
            TbldiscountBindingSource.Filter = "invoice_no ='" & InvoiceNoTextBox.Text & "' AND product_code ='" & TblSalesDataGridView.Rows(current_p).Cells(5).Value.ToString & "'"
            If TbldiscountBindingSource.Count > 0 Then
                TbldiscountBindingSource.RemoveCurrent()
            End If
            TblSalesBindingSource.RemoveCurrent()
        Catch ex As Exception

        End Try
        chk_sell_on.Checked = False
        chk_discount.Checked = False
        tata.Start()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DueTextBox.Text = GrandTotalTextBox.Text
        PadiTextBox.Text = "0"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        avg_dis.ShowDialog()
    End Sub

    Private Sub TotalAmountTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TotalAmountTextBox.KeyDown

    End Sub

    Private Sub dsct_TextChanged(sender As Object, e As EventArgs) Handles dsct.TextChanged

    End Sub

    Private Sub GrandTotalTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GrandTotalTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles GrandTotalTextBox.TextChanged
        PadiTextBox.Text = GrandTotalTextBox.Text
    End Sub

    Private Sub DueTextBox_TextChanged(sender As Object, e As EventArgs) Handles DueTextBox.TextChanged

    End Sub



    Private Sub DueTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DueTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                PaymentMethodTextBox.Text = cmbmethod.Text
                DateTextBox.Text = datt.Value.Date
                DateTextBox1.Text = datt.Value.Date
                CustomerIDTextBox3.Text = txtCustomerID.Text
                If MsgBox("Confirm this invoice?" & vbNewLine & vbNewLine &
                      "Invoice No : " & InvoiceNoTextBox.Text & vbNewLine &
                      "Address : " & CustomerNameTextBox.Text & vbNewLine & vbNewLine &
                      "Payment:-" & vbNewLine &
                      "Grand total : " & GrandTotalTextBox.Text & vbNewLine &
                      "Paid : " & PadiTextBox.Text & vbNewLine &
                      "Due : " & DueTextBox.Text & vbNewLine &
                      "Date : " & DateTextBox.Text,
                      MsgBoxStyle.YesNo,
                      "Sale invoice confirmation") = MsgBoxResult.Yes Then
                    up(37, 0)





                    If mode = 0 Then
                        'stock calculation
                        TblSalesBindingSource.MoveFirst()
                        For a As Integer = 0 To TblSalesBindingSource.Count - 1
                            TblProductsBindingSource.Filter = "productCode =" & Integer.Parse(TblSalesDataGridView.Rows(a).Cells(5).Value().ToString())
                            AvailableTextBox1.Text = Integer.Parse(AvailableTextBox1.Text) - Integer.Parse(TblSalesDataGridView.Rows(a).Cells(1).Value().ToString())
                            Validate()
                            TblProductsBindingSource.EndEdit()
                            TableAdapterManager.UpdateAll(DataSet)
                            TblSalesBindingSource.MoveNext()
                        Next

                        'stock calculation
                        'TblProductsBindingSource.RemoveFilter()
                        'all.newsale_timer.Stop()
                        'TblProductsBindingSource.MoveFirst()
                        'For a = 0 To TblProductsBindingSource.Count - 1
                        '    TblSalesBindingSource.Filter = "productCode =" & ProductCodeTextBox.Text & " AND invoiceNo =" & InvoiceNoTextBox.Text
                        '    If TblSalesBindingSource.Count > 0 Then
                        '        Try
                        '            AvailableTextBox1.Text = Integer.Parse(AvailableTextBox1.Text) - dtsum(TblSalesDataGridView, 1)
                        '        Catch ex As Exception

                        '        End Try

                        '    End If
                        '    TblProductsBindingSource.MoveNext()
                        'Next
                        ''''''''''''''''''
                        'input for bank
                        If cmbmethod.SelectedIndex = 1 Or cmbmethod.SelectedIndex = 2 Then
                            TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                            If TblBankAccountsBindingSource.Count > 0 Then
                                TblTransactionBindingSource.AddNew()
                                AmountTextBox.Text = BankamountTextBox.Text
                                TransactionTypeTextBox.Text = "Withdraw"
                                AccNoTextBox1.Text = AccNoTextBox.Text
                                DateTextBox4.Text = datt.Value.Date
                                PersonOrsourceTextBox.Text = "Withdraw for sale (Invoice NO: " & InvoiceNoTextBox.Text & ")"

                                'account balance calculation
                                TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & AccNoTextBox.Text & "%'"
                                OpeningBalanceTextBox.Text = Double.Parse(OpeningBalanceTextBox.Text) - Double.Parse(BankamountTextBox.Text)
                            Else
                                status("Bank account not found.")
                            End If
                        End If
                        '''''''''''''''''
                        'input customer accounts
                        TblCusomterAccountsBindingSource.AddNew()
                        CustomerNameTextBox1.Text = ShopOrCompanyNameTextBox.Text
                        CustomerIDTextBox.Text = txtCustomerID.Text
                        SaleInvoiceTextBox.Text = InvoiceNoTextBox.Text
                        PaymentTextBox.Text = GrandTotalTextBox.Text

                        If cmbmethod.SelectedIndex = 0 Then
                            PaidTextBox.Text = PadiTextBox.Text
                        ElseIf cmbmethod.SelectedIndex = 1 Then
                            PaidTextBox.Text = BankamountTextBox.Text
                        ElseIf cmbmethod.SelectedIndex = 2 Then
                            PaidTextBox.Text = Double.Parse(PadiTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                        End If
                        DateTextBox1.Text = datt.Value.Date()
                        DueTextBox1.Text = DueTextBox.Text

                        Validate()
                        TblCusomterAccountsBindingSource.EndEdit()
                        TableAdapterManager.UpdateAll(DataSet)
                        ''''''''''''''''''''''
                        'input vehicle accounts
                        TblVehicleAccountsBindingSource.AddNew()
                        CustomerNameTextBox3.Text = ShopOrCompanyNameTextBox.Text
                        CustomerIDTextBox2.Text = CustomerIDTextBox.Text
                        SaleInvoiceTextBox2.Text = InvoiceNoTextBox.Text
                        VehicleIDTextBox2.Text = VehicleIDTextBox.Text
                        DriverNameTextBox2.Text = DriverNameTextBox.Text
                        TotalAmountTextBox1.Text = GrandTotalTextBox.Text
                        If cmbmethod.SelectedIndex = 0 Then
                            PaidTextBox1.Text = PadiTextBox.Text
                        ElseIf cmbmethod.SelectedIndex = 1 Then
                            PaidTextBox1.Text = BankamountTextBox.Text
                        ElseIf cmbmethod.SelectedIndex = 2 Then
                            PaidTextBox1.Text = Double.Parse(PadiTextBox.Text) + Double.Parse(BankamountTextBox.Text)
                        End If
                        DueTextBox2.Text = DueTextBox.Text
                        DateTextBox3.Text = datt.Value.Date
                        '''''''''''''''
                        'income
                        TblIncomeBindingSource.AddNew()
                        IncomeCategoryTextBox.Text = "Customer payment"
                        IncomeSubcategoryTextBox.Text = "Customer payment"
                        IncomeNoteTextBox.Text = "Income from sale || Invoice NO: " + InvoiceNoTextBox.Text
                        DateTextBox7.Text = datt.Value.Date()
                        If cmbmethod.SelectedIndex = 0 Then
                            AmountTextBox1.Text = PadiTextBox.Text
                        ElseIf cmbmethod.SelectedIndex = 1 Then
                            BankamountTextBox1.Text = BankamountTextBox.Text
                            AccNoTextBox2.Text = AccNoTextBox.Text
                        ElseIf cmbmethod.SelectedIndex = 2 Then
                            AmountTextBox1.Text = PadiTextBox.Text
                            BankamountTextBox1.Text = BankamountTextBox.Text
                            AccNoTextBox2.Text = AccNoTextBox.Text
                        End If
                        PaymentmethodComboBox.Text = cmbmethod.Text
                        Payment_remarkTextBox.Text = "Payment received from sale by " + cmbmethod.Text
                        Invoice_noTextBox2.Text = InvoiceNoTextBox.Text
                        '''''''''''''''
                    End If


                    up(37, 1)
                    Validate()
                    TblIncomeBindingSource.EndEdit()
                    TblCustomersBindingSource.EndEdit()
                    TblVehicleAccountsBindingSource.EndEdit()
                    TblTransactionBindingSource.EndEdit()
                    TblSCommissionBindingSource.EndEdit()
                    TblsellcommissionBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)


                    index(21)
                    fll(21)
                    ld(21)
                    If chkDelivery.Checked = True AndAlso mode = 0 Then
                        delivery(InvoiceNoTextBox.Text, txtCustomerID.Text, VehicleIDTextBox.Text)
                    End If
                    status("Sale updated.")
                ElseIf mode = 1 Then
                    'jodi edit er mode a thake tobe eta


                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub newSale_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TblSuppliersTableAdapter.Fill(DataSet.tblSuppliers)
    End Sub
End Class