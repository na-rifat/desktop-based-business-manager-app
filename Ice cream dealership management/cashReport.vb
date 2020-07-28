Public Class cashReport
    Private Sub TblCashReportBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblCashReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub cashReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblCashReport' table. You can move, or remove it, as needed.
        Me.TblCashReportTableAdapter.Fill(Me.DataSet.tblCashReport)
        center(Me, Panel1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblCashReportBindingSource.Filter = "date <= '" & toDt.Value.Date.ToString & "' AND date >= '" & fromDt.Value.Date.ToString & "'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TblCashReportBindingSource.RemoveFilter()
        fromDt.ResetText()
        toDt.ResetText()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printP0(Panel1, "Cash report")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblCashReportBindingSource.RemoveCurrent()
                Validate()
                TblCashReportBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class