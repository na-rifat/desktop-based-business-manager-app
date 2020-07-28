Public Class damageFridge
    Private Sub TblDamageFridgeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblDamageFridgeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub damageFridge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblFridges' table. You can move, or remove it, as needed.
        Me.TblFridgesTableAdapter.Fill(Me.DataSet.tblFridges)
        'TODO: This line of code loads data into the 'DataSet.tblDamageFridge' table. You can move, or remove it, as needed.
        Me.TblDamageFridgeTableAdapter.Fill(Me.DataSet.tblDamageFridge)
        cto(Me, Panel1)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        nw(11, 0)
        Panel2.Enabled = True
        FridgeIDTextBox.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Confirm mark this fridge as damage?" &
            vbNewLine & vbNewLine &
            "Fridge ID: " & FridgeIDTextBox.Text &
            vbNewLine &
            "Model NO: " & ModelNOTextBox.Text &
            vbNewLine &
            "Damage date: " & IssueDateTextBox.Text &
            vbNewLine &
            "Company: " & SupplierTextBox.Text,
                  MsgBoxStyle.YesNo, "Damage fridge confirmation"
            ) = MsgBoxResult.Yes Then
            TblFridgesBindingSource.Filter = "fridgID =" & FridgeIDTextBox.Text
            If TblFridgesBindingSource.Count > 0 Then
                IssueDateTextBox.Text = dt.Value.Date
                up(11, 0)
                TblFridgesBindingSource.RemoveCurrent()
                Validate()
                TblFridgesBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
                Panel2.Enabled = False
            Else
                status("Invalid information.")
            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If MsgBox("Confirm return this damage fridge?" & vbNewLine & vbNewLine & "Fridge ID : " & FridgeIDTextBox.Text & vbNewLine & "Model : " & ModelNOTextBox.Text & vbNewLine & "Company : " & SupplierTextBox.Text & vbNewLine & "Issue date : " & IssueDateTextBox.Text, MsgBoxStyle.YesNo, "Damage fridge return confirmation") = MsgBoxResult.Yes Then
            rm(11, 0)
            up(11, 0)
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        ab(11, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 1 Then
                TblDamageFridgeBindingSource.Filter = "fridgeID =" & txtSearch.Text
            ElseIf txtFilter.SelectedIndex = 2 Then
                TblDamageFridgeBindingSource.Filter = "


'" & txtSearch.Text & "'"
            Else
                filter(11, txtFilter.SelectedIndex, 36, 0, txtSearch.Text)
            End If

        Catch ex As Exception

        End Try
        If txtSearch.Text = Nothing Then
            TblDamageFridgeBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub FridgeIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles FridgeIDTextBox.TextChanged

    End Sub

    Private Sub FridgeIDTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles FridgeIDTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblFridgesBindingSource.Filter = "fridgeID =" & FridgeIDTextBox.Text
                If TblFridgesBindingSource.Count > 0 Then
                    ModelNOTextBox.Text = FridgeModelNoTextBox.Text
                Else
                    ModelNOTextBox.Clear()
                    FridgeIDTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SupplierTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierTextBox.TextChanged

    End Sub

    Private Sub SupplierTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SupplierTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If MsgBox("Confirm mark this fridge as damage?" &
            vbNewLine & vbNewLine &
            "Fridge ID: " & FridgeIDTextBox.Text &
            vbNewLine &
            "Model NO: " & ModelNOTextBox.Text &
            vbNewLine &
            "Damage date: " & IssueDateTextBox.Text &
            vbNewLine &
            "Company: " & SupplierTextBox.Text,
                  MsgBoxStyle.YesNo, "Damage fridge confirmation"
            ) = MsgBoxResult.Yes Then
                TblFridgesBindingSource.Filter = "fridgID =" & FridgeIDTextBox.Text
                If TblFridgesBindingSource.Count > 0 Then
                    IssueDateTextBox.Text = dt.Value.Date
                    up(11, 0)
                    TblFridgesBindingSource.RemoveCurrent()
                    Validate()
                    TblFridgesBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)
                    Panel2.Enabled = False
                Else
                    status("Invalid information.")
                End If
            End If
        End If
    End Sub
End Class