Public Class prntF
    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            pnlSign.Visible = True
        Else
            pnlSign.Visible = False
        End If
    End Sub
End Class