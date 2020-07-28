<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addBank
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet As dataSet
    Friend WithEvents TblBanksBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BankNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents WebsiteTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TblBanksTableAdapter As dataSetTableAdapters.tblBanksTableAdapter
    Friend WithEvents TableAdapterManager As dataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As Button
End Class
