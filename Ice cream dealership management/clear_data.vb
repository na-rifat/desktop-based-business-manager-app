Public Class clear_data
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = False
        'Dim thd As New Threading.Thread(New Threading.ThreadStart(Sub()
        Dim t As New Timer
        t.Interval = 400
        AddHandler t.Tick, Sub()
                               animate_prg(prg)
                           End Sub
        t.Start()
        prg.Text = "Clearing"
        prg.ProgressColor = Color.Red
        If chk_sales_invoice.Checked = True Then
            dock_frm(all.managesale, 21)
            clear(all.managesale.TblInvoiceBindingSource, 21)
            clear(all.managesale.TblSalesBindingSource, 21)
            dock_frm(all.sell_on_commisssion, 70)
            clear(all.sell_on_commisssion.TblsellcommissionBindingSource, 70)
            dock_frm(all.discounts, 72)
            clear(all.discounts.TbldiscountBindingSource, 72)
        End If
        If chk_purchase_invoice.Checked = True Then
            dock_frm(all.managepurchase, 30)
            clear(all.managepurchase.TblPurchaseInvoiceBindingSource, 30)
            clear(all.managepurchase.TblPurchaseBindingSource, 30)
        End If
        If chk_expenses.Checked = True Then
            dock_frm(all.manageexpense, 26)
            clear(all.manageexpense.TblExpensesBindingSource, 26)
        End If
        If chk_incomes.Checked = True Then
            dock_frm(all.manageincome, 28)
            clear(all.manageincome.TblIncomeBindingSource, 28)
        End If
        If chk_withdraws.Checked = True Then
            dock_frm(all.withdraw, 60)
            clear(all.withdraw.TblwithdrawBindingSource, 60)
        End If
        If chk_bank_transactions.Checked = True Then
            dock_frm(all.managetransaction, 33)
            clear(all.managetransaction.TblTransactionBindingSource, 33)
        End If
        If chk_fridges.Checked = True Then
            dock_frm(all.managefridge, 27)
            clear(all.managefridge.TblFridgesBindingSource, 27)
            dock_frm(all.paycustomer, 56)
            clear(all.paycustomer.TblRentCBindingSource, 56)
            dock_frm(all.paysupplier, 55)
            clear(all.paysupplier.TblRentSBindingSource, 55)
        End If
        If chk_assets.Checked = True Then
            dock_frm(all.manageasset, 22)
            clear(all.manageasset.TblassetBindingSource, 22)
        End If
        If chk_reports.Checked = True Then
            dock_frm(all.salesreport, 46)
            clear(all.salesreport.TblSalesreportBindingSource, 46)
            dock_frm(all.purchasereport, 42)
            clear(all.purchasereport.TblPurchaseReportBindingSource, 42)
            dock_frm(all.expensereport, 17)
            clear(all.expensereport.TblExpenseReportBindingSource, 17)
            dock_frm(all.attendencereport, 8)
            clear(all.attendencereport.TblAttendenceReportBindingSource, 8)
            dock_frm(all.transactionreport, 52)
            clear(all.transactionreport.TblTransactionReportBindingSource, 52)
            dock_frm(all.duereport, 13)
            clear(all.duereport.TblDuesReportBindingSource, 13)
            dock_frm(all.cashreport, 69)
            clear(all.cashreport.TblCashReportBindingSource, 69)
            dock_frm(all.profitcalculator, 41)
            clear(all.profitcalculator.TblProfitBindingSource, 41)
        End If
        If chk_customer_accounts.Checked = True Then
            dock_frm(all.customeraccount, 51)
            clear(all.customeraccount.TblCusomterAccountsBindingSource, 51)
        End If
        If chk_company_accounts.Checked = True Then
            dock_frm(all.supplieraccount, 47)
            clear(all.supplieraccount.TblSupplierAccountsBindingSource, 47)
        End If
        If chk_employee_accounts.Checked = True Then
            dock_frm(all.employeeaccount, 14)
            clear(all.employeeaccount.TblEmployeeAccountsBindingSource, 14)
        End If
        If chk_employee_attendance.Checked = True Then
            dock_frm(all.employeeattendence, 15)
            clear(all.employeeattendence.TblAttendenceBindingSource, 15)
        End If
        t.Stop()
        prg.Text = "Completed"
        prg.Value = prg.Maximum
        prg.ProgressColor = Color.Green
        'End Sub))
        'thd.Start()
    End Sub

    Function dock_frm(frm As Form, i As Integer)
        frm.TopLevel = False
        frm.Show()
        'frm.Parent = docking_panel
        docking_panel.Invoke(New MethodInvoker(Sub()
                                                   docking_panel.Controls.Add(frm)
                                               End Sub))

        fll(i)
        ld(i)
        Return Nothing
    End Function
    Function clear(d As BindingSource, i As Integer)
        d.RemoveFilter()
        While d.Count <> 0
            d.RemoveCurrent()
        End While
        up(i, 0)
        up(i, 1)
        Return Nothing
    End Function

    Private Sub clear_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.DataSet.tblProducts)
        prg.Value = 0
        center(Me, Panel1)
    End Sub

    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TblProductsTableAdapter.Fill(DataSet.tblProducts)
        For a As Integer = 0 To TblProductsBindingSource.Count - 1
            TblProductsDataGridView.Rows(a).Cells(0).Value = 0
        Next
        Validate()
        TblProductsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblProductsTableAdapter.Fill(DataSet.tblProducts)
        For a As Integer = 0 To TblProductsBindingSource.Count - 1
            TblProductsDataGridView.Rows(a).Cells(0).Value = 100
        Next
        Validate()
        TblProductsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub
End Class