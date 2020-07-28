Public Class expenseReport
    Private Sub TblExpenseReportBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblExpenseReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub expenseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblExpenseSubcategory' table. You can move, or remove it, as needed.
        Me.TblExpenseSubcategoryTableAdapter.Fill(Me.DataSet.tblExpenseSubcategory)
        'TODO: This line of code loads data into the 'DataSet.tblExpenseCategory' table. You can move, or remove it, as needed.
        Me.TblExpenseCategoryTableAdapter.Fill(Me.DataSet.tblExpenseCategory)
        'TODO: This line of code loads data into the 'DataSet.tblExpenses' table. You can move, or remove it, as needed.
        Me.TblExpensesTableAdapter.Fill(Me.DataSet.tblExpenses)
        'TODO: This line of code loads data into the 'DataSet.tblExpenseReport' table. You can move, or remove it, as needed.
        Me.TblExpenseReportTableAdapter.Fill(Me.DataSet.tblExpenseReport)

        cto(Me, Panel1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        txtSearch.Clear()
        TblExpenseReportBindingSource.RemoveFilter()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Try
            TblExpenseReportBindingSource.Filter = "expenseCategory LIKE '%" & txtSearch.Text & "%' AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"

        Catch ex As Exception

        End Try
        If txtSearch.Text = Nothing Then
            TblExpenseReportBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        printP0(Panel1, "Expense report")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = DialogResult.Yes Then
                TblExpenseReportBindingSource.RemoveCurrent()
                Validate()
                TblExpenseReportBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class