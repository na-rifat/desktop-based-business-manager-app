Public Class purchaseReport
    Private Sub TblPurchaseReportBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblPurchaseReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub purchaseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.DataSet.tblProducts)
        'TODO: This line of code loads data into the 'DataSet.tblPurchase' table. You can move, or remove it, as needed.
        Me.TblPurchaseTableAdapter.Fill(Me.DataSet.tblPurchase)
        'TODO: This line of code loads data into the 'DataSet.tblPurchaseReport' table. You can move, or remove it, as needed.
        Me.TblPurchaseReportTableAdapter.Fill(Me.DataSet.tblPurchaseReport)
        cto(Me, Panel1)
        KeyPreview = True
    End Sub

    Private Sub toDt_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub toDt_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        txtSearch.Clear()
        TblPurchaseReportBindingSource.RemoveFilter()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtFilter.SelectedIndex = 0 Then
            TblPurchaseReportBindingSource.Filter = "productName LIKE '%" & txtSearch.Text & "%' AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
        ElseIf txtFilter.SelectedIndex = 1 Then
            TblPurchaseReportBindingSource.Filter = "productCode =" & txtSearch.Text & " AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
        End If
        If txtSearch.Text = Nothing Then
            TblPurchaseReportBindingSource.RemoveFilter()
        End If

    End Sub

    Private Sub ProductNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductNameTextBox.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printFP(Panel1, "Purchase report")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblPurchaseReportBindingSource.RemoveCurrent()
                Validate()
                TblPurchaseReportBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub purchaseReport_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            Try
                If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                    TblPurchaseReportBindingSource.RemoveCurrent()
                    Validate()
                    TblPurchaseReportBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class