Public Class sold_products
    Private Sub TblSalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub sold_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tbldiscount' table. You can move, or remove it, as needed.
        Me.TbldiscountTableAdapter.Fill(Me.DataSet.tbldiscount)
        'TODO: This line of code loads data into the 'DataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.DataSet.tblProducts)
        'TODO: This line of code loads data into the 'DataSet.tblInvoice' table. You can move, or remove it, as needed.
        Me.TblInvoiceTableAdapter.Fill(Me.DataSet.tblInvoice)
        'TODO: This line of code loads data into the 'DataSet.tblSales' table. You can move, or remove it, as needed.
        Me.TblSalesTableAdapter.Fill(Me.DataSet.tblSales)
        CheckForIllegalCrossThreadCalls = False
        KeyPreview = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TblSalesBindingSource.Filter = "productName LIKE '%" & txtSearch.Text & "%' AND date <='" & fromDt.Value.Date.ToString & "' AND date >='" & toDt.Value.Date.ToString & "'"
            ElseIf txtFilter.SelectedIndex = 1 Then
                TblSalesBindingSource.Filter = "productCode =" & txtSearch.Text & " AND date >='" & fromDt.Value.Date.ToString & "' AND date <='" & toDt.Value.Date.ToString & "'"
            ElseIf txtFilter.SelectedIndex = 2 Then
                TblSalesBindingSource.Filter = "company LIKE '%" & txtSearch.Text & "%' AND date >='" & fromDt.Value.Date.ToString & "' AND date <='" & toDt.Value.Date.ToString & "'"
            ElseIf txtFilter.SelectedIndex = 3 Then
                TblSalesBindingSource.Filter = "company_id =" & txtSearch.Text & " AND date >='" & fromDt.Value.Date.ToString & "' AND date <='" & toDt.Value.Date.ToString & "'"
            ElseIf txtFilter.SelectedIndex = 4 Then
                TblSalesBindingSource.Filter = "customer LIKE '%" & txtSearch.Text & "%' AND date >='" & fromDt.Value.Date.ToString & "' AND date <='" & toDt.Value.Date.ToString & "'"
            ElseIf txtFilter.SelectedIndex = 5 Then
                TblSalesBindingSource.Filter = "customer_id =" & txtSearch.Text & " AND date >='" & fromDt.Value.Date.ToString & "' AND date <='" & toDt.Value.Date.ToString & "'"
            End If

            If txtSearch.Text = Nothing Then
                TblSalesBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        TblSalesBindingSource.RemoveFilter()
        txtSearch.Clear()

    End Sub

    Private Sub TblSalesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblSalesDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'TblInvoiceTableAdapter.Fill(DataSet.tblInvoice)
        'Dim count As Integer = TblSalesBindingSource.Count - 1

        'TblSalesBindingSource.MoveFirst()

        'For i As Integer = 0 To count
        '    If TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(14).Value.ToString = Nothing Then
        '        TblSalesBindingSource.RemoveCurrent()
        '        TblSalesBindingSource.MoveFirst()
        '        ' count -= 1
        '        i = 0
        '    Else
        '        TblInvoiceBindingSource.Filter = "invoiceNo =" & TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(14).Value.ToString
        '        If TblInvoiceBindingSource.Count = 0 Then
        '            MsgBox("Junk found")
        '            TblSalesBindingSource.RemoveCurrent()
        '            TblSalesBindingSource.MoveFirst()
        '            ' count -= 1
        '            i = 0
        '        End If
        '    End If
        '    TblSalesBindingSource.MoveNext()
        '    count = TblSalesBindingSource.Count
        'Next
        'Validate()
        'TblSalesBindingSource.EndEdit()
        'TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'TbldiscountTableAdapter.Fill(DataSet.tbldiscount)
        'Dim count As Integer = TbldiscountBindingSource.Count, i As Integer = 0
        'TbldiscountBindingSource.MoveFirst()
        'For i = 0 To count

        '    TblSalesBindingSource.Filter = "invoiceNo ='" & TbldiscountDataGridView.Rows(TbldiscountBindingSource.Position).Cells(0).Value.ToString & "' AND productCode ='" & TbldiscountDataGridView.Rows(TbldiscountBindingSource.Position).Cells(1).Value.ToString & "'"
        '    If TblSalesBindingSource.Count = 0 Then
        '        TbldiscountBindingSource.RemoveCurrent()
        '        TbldiscountBindingSource.MoveFirst()
        '        MsgBox("Junk found")
        '        ' count -= 1
        '        i = 0
        '    Else

        '    End If


        '    count = TbldiscountBindingSource.Count
        '    TbldiscountBindingSource.MoveNext()
        'Next


        'Validate()
        'TbldiscountBindingSource.EndEdit()
        'TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        'TblSalesBindingSource.MoveFirst()
        'For i As Integer = 0 To TblSalesBindingSource.Count - 1

        '    If TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(14).Value.ToString.Length > 0 Then


        '        If TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(15).Value.ToString = "1" Or Double.Parse(TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(5).Value.ToString) > 0 Then
        '            TbldiscountBindingSource.Filter = "invoice_no =" & TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(14).Value.ToString & " AND product_code =" & TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(1).Value.ToString
        '            If TbldiscountBindingSource.Count = 0 Then
        '                MsgBox("Blank found")
        '                TbldiscountBindingSource.AddNew()
        '                DateDateTimePicker.Value = DateDateTimePicker1.Value.Date
        '                Total_priceTextBox.Text = TotalPriceTextBox.Text
        '                Given_discountTextBox.Text = prc(TotalPriceTextBox.Text, DiscountTextBox1.Text)
        '                Unit_priceTextBox.Text = UnitPriceTextBox.Text
        '                Customer_nameTextBox.Text = CustomerTextBox.Text
        '                QuantityTextBox.Text = QuantityTextBox1.Text
        '                InvoiceNoTextBox.Text = Invoice_noTextBox.Text
        '                Company_idTextBox.Text = Company_idTextBox1.Text
        '                Customer_idTextBox.Text = Customer_idTextBox1.Text
        '                Net_priceTextBox.Text = NetPriceTextBox.Text
        '                Product_categoryTextBox.Text = Product_categoryTextBox1.Text
        '                If ConfirmationTextBox.Text = Nothing Then
        '                    ConfirmationTextBox.Text = "No"
        '                End If
        '                Product_codeTextBox.Text = ProductCodeTextBox.Text
        '                Product_nameTextBox.Text = ProductNameTextBox.Text
        '                CompanyTextBox.Text = CompanyTextBox1.Text
        '                DiscountTextBox.Text = DiscountTextBox1.Text
        '                Validate()
        '                TbldiscountBindingSource.EndEdit()
        '                TableAdapterManager.UpdateAll(DataSet)
        '                i = 0
        '            Else
        '                Customer_nameTextBox.Text = CustomerTextBox.Text
        '            End If
        '        Else
        '            'TblSalesDataGridView.Rows(TblSalesBindingSource.Position).Cells(14).Value.ToString()
        '        End If
        '    End If


        '    TblSalesBindingSource.MoveNext()
        'Next

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        TblSalesBindingSource.Filter = "is_dis LIKE '%1%'"
        TbldiscountBindingSource.RemoveFilter()
        MsgBox(TblSalesBindingSource.Count & vbNewLine & TbldiscountBindingSource.Count)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TblSalesBindingSource.Filter = "date >= '" & fromDt.Value.Date & "' AND date <= '" & toDt.Value.Date & "'"
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        TblSalesTableAdapter.Fill(DataSet.tblSales)
        Dim bgwk As New ComponentModel.BackgroundWorker
        AddHandler bgwk.DoWork, Function()
                                    Me.Invoke(New MethodInvoker(Function()

                                                                    Dim i As Integer = TblSalesBindingSource.Count - 1

                                                                    For a As Integer = 0 To i AndAlso a < i
                                                                        i = TblSalesBindingSource.Count - 1
                                                                        If TblSalesDataGridView.Rows(a).Cells(14).Value.ToString.Length = 0 Or TblSalesDataGridView.Rows(a).Cells(0).Value.ToString = Nothing Then
                                                                            TblSalesBindingSource.RemoveAt(a)
                                                                            a = 0

                                                                        End If
                                                                    Next

                                                                    ''''''''''
                                                                    For a As Integer = 0 To i
                                                                        i = TblSalesBindingSource.Count - 1
                                                                        If a < i AndAlso TblSalesDataGridView.Rows(a).Cells(14).Value.ToString.Length > 0 Then

                                                                            TblInvoiceBindingSource.Filter = "invoiceNo =" & TblSalesDataGridView.Rows(a).Cells(14).Value.ToString
                                                                            If TblInvoiceBindingSource.Count = 0 Then
                                                                                TblSalesBindingSource.RemoveAt(a)
                                                                                a = 0
                                                                            ElseIf TblSalesDataGridView.Rows(a).Cells(11).Value.ToString = Nothing Then
                                                                                '  MsgBox(Date.Parse(TblInvoiceDataGridView.Rows(0).Cells(0).Value.ToString))
                                                                                TblSalesDataGridView.Rows(a).Cells(11).Value = Date.Parse(TblInvoiceDataGridView.Rows(0).Cells(0).Value.ToString)
                                                                            End If
                                                                        End If

                                                                    Next
                                                                    Validate()
                                                                    TblSalesBindingSource.EndEdit()
                                                                    TableAdapterManager.UpdateAll(DataSet)
                                                                    '''''''''''''


                                                                    'For a As Integer = 0 To i
                                                                    '    ''''
                                                                    '    If a < i Then

                                                                    '        If TblSalesDataGridView.Rows(a).Cells(14).Value.ToString.Length > 0 Then
                                                                    '            TblInvoiceBindingSource.Filter = "invoiceNo =" & TblSalesDataGridView.Rows(a).Cells(14).Value.ToString
                                                                    '            ''''
                                                                    '            If TblInvoiceBindingSource.Count > 0 Then
                                                                    '                TblSalesDataGridView.Rows(a).Cells(11).Value = Date.Parse(TblInvoiceDataGridView.Rows(0).Cells(0).Value.ToString)
                                                                    '                Validate()
                                                                    '                TblSalesBindingSource.EndEdit()
                                                                    '                TableAdapterManager.UpdateAll(DataSet)
                                                                    '            Else
                                                                    '                ' MsgBox("Invoice not found!")
                                                                    '                TblSalesBindingSource.RemoveAt(a)
                                                                    '                Validate()
                                                                    '                TblSalesBindingSource.EndEdit()
                                                                    '                TableAdapterManager.UpdateAll(DataSet)
                                                                    '                a = 0
                                                                    '                i = TblSalesBindingSource.Count - 1
                                                                    '            End If
                                                                    '            ''''
                                                                    '        Else
                                                                    '            TblSalesBindingSource.RemoveAt(a)
                                                                    '            Validate()
                                                                    '            TblSalesBindingSource.EndEdit()
                                                                    '            TableAdapterManager.UpdateAll(DataSet)
                                                                    '            a = 0
                                                                    '            i = TblSalesBindingSource.Count - 1
                                                                    '        End If
                                                                    '        ''''
                                                                    '    Else

                                                                    '    End If
                                                                    'Next
                                                                    Return Nothing
                                                                End Function))
                                    Return Nothing
                                End Function
        bgwk.WorkerReportsProgress = True
        bgwk.RunWorkerAsync()

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        TblSalesTableAdapter.Fill(DataSet.tblSales)
        For a As Integer = 0 To TblSalesBindingSource.Count - 1
            TblInvoiceBindingSource.Filter = "invoiceNo =" & TblSalesDataGridView.Rows(a).Cells(14).Value.ToString
            If TblInvoiceBindingSource.Count = 0 Then
                If MsgBox("NON-invoice sale found, do you want to remove it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    TblSalesBindingSource.RemoveAt(a)
                    Validate()
                    TblSalesBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)
                End If
            End If
        Next
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim i As Integer = TblSalesBindingSource.Count - 1
        For a As Integer = 0 To i
            If a < i Then
                Try
                    If TblSalesDataGridView.Rows(a).Cells(0).Value.ToString = Nothing Then
                        TblSalesBindingSource.RemoveAt(a)
                        a = 0
                        i = TblSalesBindingSource.Count - 1
                        Validate()
                        TblSalesBindingSource.EndEdit()
                        TableAdapterManager.UpdateAll(DataSet)
                    End If
                Catch ex As Exception

                End Try
            Else
                Return
            End If
        Next
    End Sub

    Private Sub sold_products_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.O AndAlso e.Control AndAlso e.Alt AndAlso e.Shift = False Then
            If Panel2.Visible = False Then
                Panel2.Visible = True
            Else
                Panel2.Visible = False
            End If
        End If
    End Sub
End Class