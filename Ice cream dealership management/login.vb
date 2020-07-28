Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.DataSet.tblUser)
        center(Me, Panel1)
        'checking for license

    End Sub

    Private Sub TblUserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            TblUserBindingSource.Filter = "userID =" & txtUserID.Text
        Catch ex As Exception
        End Try
        If txtUserID.Text = UserIDTextBox.Text AndAlso txtUserPass.Text = PasswordTextBox.Text AndAlso txtUserRole.Text = RoleTextBox.Text AndAlso txtUserID.Text IsNot Nothing AndAlso txtUserPass.Text IsNot Nothing AndAlso txtUserRole.Text IsNot Nothing Then
            '   MsgBox("Required API(s) not found! Please configure your application with the following API(s): " & vbNewLine & "*Google drive data backup service API." & "*Google programatic email service API.")
            index(12)
            fll(12)
            ld(12)
            status("Logged in as " & RoleTextBox.Text)
            Form1.tmrBasic.Start()
            Form1.MenuStrip1.Enabled = True
            frm_back_color(0, 38, 51)
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = False
        Else
            status("Wrong login information! Please try again :-)")
        End If

    End Sub

    Public Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub txtUserRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtUserRole.SelectedIndexChanged

    End Sub

    Public Sub txtUserRole_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserRole.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TblUserBindingSource.Filter = "userID =" & txtUserID.Text
            Catch ex As Exception

            End Try
            If txtUserID.Text = UserIDTextBox.Text AndAlso txtUserPass.Text = PasswordTextBox.Text AndAlso txtUserRole.Text = RoleTextBox.Text AndAlso txtUserID.Text IsNot Nothing AndAlso txtUserPass.Text IsNot Nothing AndAlso txtUserRole.Text IsNot Nothing Then
                '  MsgBox("Required API(s) not found! Please configure your application with the following API(s): " & vbNewLine & "*Google drive data backup service API." & vbNewLine & "*Google programatic email service API.")
                index(12)
                fll(12)
                ld(12)
                status("Logged in as " & RoleTextBox.Text)
                Form1.tmrBasic.Start()
                Form1.MenuStrip1.Enabled = True
                frm_back_color(0, 38, 51)
                System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = False
            Else
                status("Wrong login information! Please try again :-)")
            End If
        End If
    End Sub

    Private Sub txtUserPass_TextChanged(sender As Object, e As EventArgs) Handles txtUserPass.TextChanged

    End Sub

    Private Sub txtUserPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserPass.KeyDown

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtUserPass.UseSystemPasswordChar = False
        Else
            txtUserPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

    End Sub

    Private Sub txtUserID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserID.KeyDown

    End Sub

    Private Sub Process1_Exited(sender As Object, e As EventArgs) Handles Process1.Exited

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class