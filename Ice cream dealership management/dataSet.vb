Partial Class dataSet
    Partial Public Class tblCompanySettingsDataTable
        Private Sub tblCompanySettingsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.currencyColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class tblTransactionDataTable
        Private Sub tblTransactionDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class tblCustomersDataTable
        Private Sub tblCustomersDataTable_tblCustomersRowChanging(sender As Object, e As tblCustomersRowChangeEvent) Handles Me.tblCustomersRowChanging

        End Sub

    End Class

    Partial Public Class tblEmployeeDataTable
        Private Sub tblEmployeeDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
