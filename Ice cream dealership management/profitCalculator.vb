Public Class profitCalculator
    Private Sub profitCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSales' table. You can move, or remove it, as needed.
        Me.TblSalesTableAdapter.Fill(Me.DataSet.tblSales)
        'TODO: This line of code loads data into the 'DataSet.tblPurchaseInvoice' table. You can move, or remove it, as needed.
        Me.TblPurchaseInvoiceTableAdapter.Fill(Me.DataSet.tblPurchaseInvoice)
        'TODO: This line of code loads data into the 'DataSet.tblInvoice' table. You can move, or remove it, as needed.
        Me.TblInvoiceTableAdapter.Fill(Me.DataSet.tblInvoice)
        'TODO: This line of code loads data into the 'DataSet.tbldiscount' table. You can move, or remove it, as needed.
        Me.TbldiscountTableAdapter.Fill(Me.DataSet.tbldiscount)
        'TODO: This line of code loads data into the 'DataSet.tblsellcommission' table. You can move, or remove it, as needed.
        Me.TblsellcommissionTableAdapter.Fill(Me.DataSet.tblsellcommission)
        'TODO: This line of code loads data into the 'DataSet.tblVehicle' table. You can move, or remove it, as needed.
        Me.TblVehicleTableAdapter.Fill(Me.DataSet.tblVehicle)
        'TODO: This line of code loads data into the 'DataSet.tblExpenses' table. You can move, or remove it, as needed.
        Me.TblExpensesTableAdapter.Fill(Me.DataSet.tblExpenses)
        'TODO: This line of code loads data into the 'DataSet.tblDelivery' table. You can move, or remove it, as needed.
        Me.TblDeliveryTableAdapter.Fill(Me.DataSet.tblDelivery)
        'TODO: This line of code loads data into the 'DataSet.tblFridges' table. You can move, or remove it, as needed.
        Me.TblFridgesTableAdapter.Fill(Me.DataSet.tblFridges)
        'TODO: This line of code loads data into the 'DataSet.tblasset' table. You can move, or remove it, as needed.
        Me.TblassetTableAdapter.Fill(Me.DataSet.tblasset)
        'TODO: This line of code loads data into the 'DataSet.tblwithdraw' table. You can move, or remove it, as needed.
        Me.TblwithdrawTableAdapter.Fill(Me.DataSet.tblwithdraw)
        'TODO: This line of code loads data into the 'DataSet.tblBankAccounts' table. You can move, or remove it, as needed.
        Me.TblBankAccountsTableAdapter.Fill(Me.DataSet.tblBankAccounts)
        'TODO: This line of code loads data into the 'DataSet.tblSupplierAccounts' table. You can move, or remove it, as needed.
        Me.TblSupplierAccountsTableAdapter.Fill(Me.DataSet.tblSupplierAccounts)
        'TODO: This line of code loads data into the 'DataSet.tblRentS' table. You can move, or remove it, as needed.
        Me.TblRentSTableAdapter.Fill(Me.DataSet.tblRentS)
        'TODO: This line of code loads data into the 'DataSet.tblExpenseReport' table. You can move, or remove it, as needed.
        Me.TblExpenseReportTableAdapter.Fill(Me.DataSet.tblExpenseReport)
        'TODO: This line of code loads data into the 'DataSet.tblEmployeeAccounts' table. You can move, or remove it, as needed.
        Me.TblEmployeeAccountsTableAdapter.Fill(Me.DataSet.tblEmployeeAccounts)
        'TODO: This line of code loads data into the 'DataSet.tblTransaction' table. You can move, or remove it, as needed.
        Me.TblTransactionTableAdapter.Fill(Me.DataSet.tblTransaction)
        'TODO: This line of code loads data into the 'DataSet.tblRentC' table. You can move, or remove it, as needed.
        Me.TblRentCTableAdapter.Fill(Me.DataSet.tblRentC)
        'TODO: This line of code loads data into the 'DataSet.tblIncome' table. You can move, or remove it, as needed.
        Me.TblIncomeTableAdapter.Fill(Me.DataSet.tblIncome)
        'TODO: This line of code loads data into the 'DataSet.tblCusomterAccounts' table. You can move, or remove it, as needed.
        Me.TblCusomterAccountsTableAdapter.Fill(Me.DataSet.tblCusomterAccounts)
        'TODO: This line of code loads data into the 'DataSet.tblProfit' table. You can move, or remove it, as needed.
        Me.TblProfitTableAdapter.Fill(Me.DataSet.tblProfit)
        cto(Me, Panel1)
        KeyPreview = True
    End Sub

    Private Sub TblProfitBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblProfitBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        TblProfitBindingSource.RemoveFilter()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblProfitBindingSource.Filter = "date <='" & toDt.Value.Date & "' AND date >='" & fromDt.Value.Date & "'"
        profit_print()
        'printP0(Panel1, "Profit calculator")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblProfitBindingSource.Filter = "date <='" & toDt.Value.Date & "' AND date >='" & fromDt.Value.Date & "'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
            TblProfitBindingSource.RemoveCurrent()
            Validate()
            TblProfitBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
        End If

    End Sub

    Private Sub profitCalculator_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblProfitBindingSource.RemoveCurrent()
                Validate()
                TblProfitBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TblProfitDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblProfitDataGridView.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        create()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        TblExpensesBindingSource.Filter = "expenseCategory LIKE '%Damage product%'" ' AND date ='" & Today & "'"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        TblExpensesBindingSource.Filter = "expenseCategory LIKE '%Damage product%' AND date ='" & Today & "'"
    End Sub
End Class