Public Class salesReport
    Private Sub TblSalesreportBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSalesreportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub salesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblIncome' table. You can move, or remove it, as needed.
        Me.TblIncomeTableAdapter.Fill(Me.DataSet.tblIncome)

        'TODO: This line of code loads data into the 'DataSet.tblInvoice' table. You can move, or remove it, as needed.
        Me.TblInvoiceTableAdapter.Fill(Me.DataSet.tblInvoice)
        'TODO: This line of code loads data into the 'DataSet.tblSalesreport' table. You can move, or remove it, as needed.
        Me.TblSalesreportTableAdapter.Fill(Me.DataSet.tblSalesreport)
        cto(Me, Panel1)
        cto(Me, Panel2)
        KeyPreview = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        fromDt.ResetText()
        toDt.ResetText()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblSalesreportBindingSource.Filter = "date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        TblSalesreportBindingSource.RemoveFilter()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        printF(Me)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblSalesreportBindingSource.RemoveCurrent()
                Validate()
                TblSalesreportBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        TblSalesreportBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Validate()
        TblSalesreportBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub TblSalesreportDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblSalesreportDataGridView.CellContentClick

    End Sub

    Private Sub TblSalesreportDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblSalesreportDataGridView.CellClick

    End Sub

    Private Sub salesReport_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            Try
                If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                    TblSalesreportBindingSource.RemoveCurrent()
                    Validate()
                    TblSalesreportBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class