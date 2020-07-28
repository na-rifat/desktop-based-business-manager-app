Public Class Form1
    Dim x As Integer
    Dim y As Integer
    Dim xy As System.Drawing.Point

    Private Sub TextToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NewPurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPurchaseToolStripMenuItem.Click
        index(36)
        fll(36)
        nw(36, 0)
        nw(36, 1)
        ld(36)
        all.newpurchase.mode = 0
    End Sub

    Private Sub ReportsDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsDataToolStripMenuItem.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        lod()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrBasic.Tick
        Try

            lblG.Text = "Logged in as:" & UserNameTextBox.Text

        Catch ex As Exception

        End Try
        Try
            'permission check
            If SalesTextBox.Text = "1" Then
                SalesToolStripMenuItem.Enabled = True
            Else
                SalesToolStripMenuItem.Enabled = False
            End If
            If ProductsTextBox.Text = "1" Then
                ProductsToolStripMenuItem.Enabled = True
            Else
                ProductsToolStripMenuItem.Enabled = False
            End If
            If PurchaseTextBox.Text = "1" Then
                PurchaseToolStripMenuItem.Enabled = True
            Else
                PurchaseToolStripMenuItem.Enabled = False
            End If
            If SuppliersTextBox.Text = "1" Then
                SuppliersToolStripMenuItem.Enabled = True
            Else
                SuppliersToolStripMenuItem.Enabled = False
            End If
            If BankTransactionTextBox.Text = "1" Then
                BankTransactionToolStripMenuItem.Enabled = True
            Else
                BankTransactionToolStripMenuItem.Enabled = False
            End If
            If ExpensesTextBox.Text = "1" Then
                ExpensesToolStripMenuItem.Enabled = True
            Else
                ExpensesToolStripMenuItem.Enabled = False
            End If
            If IncomeTextBox.Text = "1" Then
                IncomeToolStripMenuItem.Enabled = True
            Else
                IncomeToolStripMenuItem.Enabled = False
            End If
            'If EmplpoyeeTextBox.Text = "1" Then
            '    EmployeeToolStripMenuItem.Enabled = True
            'Else
            '    EmployeeToolStripMenuItem.Enabled = False
            'End If
            If OthersTextBox.Text = "1" Then
                OthersToolStripMenuItem.Enabled = True
            Else
                OthersToolStripMenuItem.Enabled = False
            End If
            If ReportsNdateTextBox.Text = "1" Then
                ReportsDataToolStripMenuItem.Enabled = True
            Else
                ReportsDataToolStripMenuItem.Enabled = False
            End If
            If FridgeTextBox.Text = "1" Then
                FridgeToolStripMenuItem.Enabled = True
            Else
                FridgeToolStripMenuItem.Enabled = False
            End If
            'If DamageProductsTextBox.Text = "1" Then
            '    DamageProductsToolStripMenuItem.Enabled = True
            'Else
            '    DamageProductsToolStripMenuItem.Enabled = False
            'End If
            'If DsahBoardTextBox.Text = "1" Then
            '    DashboardToolStripMenuItem.Enabled = True
            'Else
            '    DashboardToolStripMenuItem.Enabled = False
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'TODO: This line of code loads data into the 'DataSet.tblCompanySettings' table. You can move, or remove it, as needed.
        Me.TblCompanySettingsTableAdapter.Fill(Me.DataSet.tblCompanySettings)
            'TODO: This line of code loads data into the 'DataSet.tblUser' table. You can move, or remove it, as needed.
            Me.TblUserTableAdapter.Fill(Me.DataSet.tblUser)
            pnlMain.Select()
            index(50)
            fll(50)
            ld(50)
            tmr.Start()
            MenuStrip1.Enabled = False


        'checking for license
        'If Today.Day > My.Settings.license_day AndAlso Today.Month > My.Settings.license_month AndAlso Today.Year > My.Settings.license_year Then
        '    license.ShowDialog()
        'End If
        If License_periodTextBox.Text = Nothing Then
            license.ShowDialog()
        ElseIf Date.Parse(License_periodTextBox.Text) < Today Then
            license.ShowDialog()
        End If

        KeyPreview = True

        'bw_check(False)
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        index(12)
        fll(12)
        ld(12)
    End Sub

    Private Sub NewSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSaleToolStripMenuItem.Click
        index(37)
        fll(37)
        nw(37, 1)
        nw(37, 0)
        ld(37)
        all.newsale.mode = 0
    End Sub

    Private Sub ManageSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSalesToolStripMenuItem.Click
        index(21)
        fll(21)
        ld(21)
    End Sub

    Private Sub AddProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductsToolStripMenuItem.Click
        index(5)
        fll(5)
        nw(5, 0)
        ld(5)
    End Sub

    Private Sub ProductsCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsCategoryToolStripMenuItem.Click
        index(40)
        fll(40)
        ld(40)
    End Sub

    Private Sub ManageProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageProductsToolStripMenuItem.Click
        index(29)
        fll(29)
        ld(29)
    End Sub

    Private Sub ManageStockToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(31)
        fll(31)
        ld(31)
    End Sub

    Private Sub ManagePurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagePurchaseToolStripMenuItem.Click
        index(30)
        fll(30)
        ld(30)
    End Sub

    Private Sub AddSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(6)
        fll(6)
        nw(6, 0)
        ld(6)
    End Sub

    Private Sub ManageSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(32)
        fll(32)
        ld(32)
    End Sub

    Private Sub SupplierAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(47)
        fll(47)
        ld(47)
    End Sub

    Private Sub AddBankToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBankToolStripMenuItem.Click
        index(0)
        fll(0)
        nw(0, 0)
        ld(0)
    End Sub

    Private Sub ManageBankAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBankAccountsToolStripMenuItem.Click
        index(23)
        fll(23)
        ld(23)
    End Sub

    Private Sub ManageTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageTransactionToolStripMenuItem.Click
        index(33)
        fll(33)
        ld(33)
    End Sub

    Private Sub NewExpenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewExpenseToolStripMenuItem.Click
        index(34)
        fll(34)
        nw(34, 0)
        ld(34)
    End Sub

    Private Sub ExpenseCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpenseCategoryToolStripMenuItem.Click
        index(16)
        fll(16)
        ld(16)
    End Sub

    Private Sub ManageExpenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageExpenseToolStripMenuItem.Click
        index(26)
        fll(26)
        ld(26)
    End Sub

    Private Sub NewIncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewIncomeToolStripMenuItem.Click
        index(35)
        fll(35)
        nw(35, 0)
        ld(35)
    End Sub

    Private Sub IncomeCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncomeCategoryToolStripMenuItem.Click
        index(20)
        fll(20)
        ld(20)
    End Sub

    Private Sub ManageIncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageIncomeToolStripMenuItem.Click
        index(28)
        fll(28)
        ld(28)
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(2)
        fll(2)
        nw(2, 0)
        ld(2)
    End Sub

    Private Sub ManageEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(25)
        fll(25)
        ld(25)
    End Sub

    Private Sub EmployeeAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(14)
        fll(14)
        ld(14)
    End Sub

    Private Sub EmployeeAttendenceToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(15)
        fll(15)
        ld(15)
    End Sub

    Private Sub ProductDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductDeliveryToolStripMenuItem.Click
        index(39)
        fll(39)
        ld(39)
    End Sub

    Private Sub SignBoardToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(48)
        fll(48)
        ld(48)
    End Sub

    Private Sub ManageAssetToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNoteToolStripMenuItem.Click
        index(4)
        fll(4)
        nw(4, 0)
        ld(4)

    End Sub

    Private Sub ProductCommissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductCommissionToolStripMenuItem.Click

    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        index(46)
        fll(46)
        ld(46)
    End Sub

    Private Sub PurchaseReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseReportToolStripMenuItem.Click
        index(42)
        fll(42)
        ld(42)
    End Sub

    Private Sub ExpenseReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpenseReportToolStripMenuItem.Click
        index(17)
        fll(17)
        ld(17)
    End Sub

    Private Sub AttendenceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendenceReportToolStripMenuItem.Click
        index(8)
        fll(8)
        ld(8)
    End Sub

    Private Sub DueReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DueReportToolStripMenuItem.Click
        index(13)
        fll(13)
        ld(13)
    End Sub

    Private Sub AssetReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(7)
        fll(7)
        ld(7)
    End Sub

    Private Sub ProfitCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfitCalculatorToolStripMenuItem.Click
        index(41)
        fll(41)
        ld(41)
    End Sub

    Private Sub AddFridgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFridgeToolStripMenuItem.Click
        index(3)
        fll(3)
        nw(3, 0)
        ld(3)
    End Sub

    Private Sub RentFromSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(43)
        fll(43)
        ld(43)
    End Sub

    Private Sub RentToCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentToCustomerToolStripMenuItem.Click
        index(44)
        fll(44)
        ld(44)
    End Sub

    Private Sub ManageFridgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageFridgeToolStripMenuItem.Click
        index(27)
        fll(27)
        ld(27)
    End Sub

    Private Sub DamageFridgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamageFridgeToolStripMenuItem.Click
        index(11)
        fll(11)
        ld(11)
    End Sub

    Private Sub AddDamageProductsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(1)
        fll(1)
        nw(1, 0)
        ld(1)
    End Sub

    Private Sub ManageDamageProductsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(24)
        fll(24)
        ld(24)
    End Sub

    Private Sub ReturnDamageToolStripMenuItem_Click(sender As Object, e As EventArgs)
        index(45)
        fll(45)
        ld(45)
    End Sub

    Private Sub CompanySettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanySettingsToolStripMenuItem.Click
        admin_permission(9)
    End Sub

    Private Sub DateAndFormatToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CreateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateUserToolStripMenuItem.Click
        admin_permission(10)
        nw(10, 0)

    End Sub

    Private Sub UserRolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserRolesToolStripMenuItem.Click
        admin_permission(49)
    End Sub

    Private Sub ManageBanksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBanksToolStripMenuItem.Click
        index(19)
        fll(19)
        ld(19)
    End Sub

    Private Sub BankTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankTransactionToolStripMenuItem.Click

    End Sub

    Private Sub CustomerAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerAccountsToolStripMenuItem.Click
        index(51)
        fll(51)
        ld(51)

    End Sub

    Private Sub ManageCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCustomerToolStripMenuItem.Click
        index(53)
        fll(53)
        ld(53)

    End Sub

    Private Sub AddCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCustomerToolStripMenuItem.Click
        index(54)
        fll(54)
        nw(54, 0)
        nw(54, 1)
        ld(54)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click

    End Sub

    Private Sub TblUserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        Try
            lblTim.Text = Date.Today & "    ||    " & TimeOfDay
            lbladd.Text = CompanyAddressTextBox.Text & vbNewLine & CompanyPhoneNumberTextBox.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TransactionReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionReportToolStripMenuItem.Click
        index(52)
        fll(52)
        ld(52)
    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawToolStripMenuItem.Click
        index(60)
        fll(60)
        ld(60)
    End Sub

    Private Sub ManageAssetToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ManageAssetToolStripMenuItem.Click
        index(22)
        fll(22)
        ld(22)
    End Sub

    Private Sub MyAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyAccountToolStripMenuItem.Click
        index(61)
        fll(61)
        ld(61)
    End Sub

    Private Sub AddSupplierToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AddSupplierToolStripMenuItem.Click
        index(6)
        fll(6)
        ld(6)
        nw(6, 0)
        nw(6, 1)
        all.addsupplier.GroupBox1.Enabled = True
    End Sub

    Private Sub ManageSupplierToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ManageSupplierToolStripMenuItem.Click
        index(32)
        fll(32)
        ld(32)
    End Sub

    Private Sub SupplierAccountsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SupplierAccountsToolStripMenuItem.Click
        index(47)
        fll(47)
        ld(47)
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click

    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        index(2)
        fll(2)

        nw(2, 0)
        ld(2)
        id_maker_label(all.addemployee.IdLabel1)
    End Sub

    Private Sub ManageEmployeeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ManageEmployeeToolStripMenuItem.Click
        index(25)
        fll(25)
        ld(25)
    End Sub

    Private Sub EmployeeAccountsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EmployeeAccountsToolStripMenuItem.Click
        index(14)
        fll(14)
        ld(14)
    End Sub

    Private Sub EmployeeAttendenceToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EmployeeAttendenceToolStripMenuItem.Click
        index(15)
        fll(15)
        ld(15)
    End Sub

    Private Sub NewPurchaseSeasonToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        index(67)
        fll(67)
        ld(67)
        nw(67, 0)
    End Sub

    Private Sub NewSaleCommissionSeasonToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        index(68)
        fll(68)
        ld(68)
        nw(68, 0)
    End Sub

    Private Sub ManageProductCommissionToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        index(38)
        fll(38)
        ld(38)
    End Sub

    Public Function frm()
        Try
            TblCompanySettingsTableAdapter.Fill(DataSet.tblCompanySettings)
            fll(9)
            TblUserTableAdapter.Fill(DataSet.tblUser)
            tmrBasic.Start()
            MenuStrip1.Enabled = True

            'important notification
            Dim t As New Timer
            t.Interval = Integer.Parse(My.Settings.interval) * 60000
            AddHandler t.Tick, Function()
                                   important()
                                   Return 0
                               End Function
            If My.Settings.interval = 0 Then
                t.Stop()
            Else
                t.Start()
            End If
            lod()
        Catch ex As Exception

        End Try
        Return 0
    End Function

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        index(65)
        fll(65)
        ld(65)
    End Sub

    Private Sub NewVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewVehicleToolStripMenuItem.Click
        index(62)
        fll(62)
        ld(62)
        nw(62, 0)
    End Sub

    Private Sub ManageVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageVehicleToolStripMenuItem.Click
        index(63)
        fll(63)
        ld(63)
    End Sub

    Private Sub VehicleAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehicleAccountsToolStripMenuItem.Click
        index(64)
        fll(64)
        ld(64)
    End Sub

    Private Sub AddDamageProductsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AddDamageProductsToolStripMenuItem.Click
        index(1)
        fll(1)
        ld(1)
        nw(1, 0)
    End Sub

    Private Sub ManageDamageProductsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ManageDamageProductsToolStripMenuItem.Click
        index(24)
        fll(24)
        ld(24)
    End Sub

    Private Sub ReturnDamageToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        index(45)
        fll(45)
        ld(45)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblG_Click(sender As Object, e As EventArgs)
        MenuStrip1.Enabled = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        index(69)
        fll(69)
        ld(69)
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If MessageBox.Show("Are you sure you want to clear license?" & vbNewLine & "That will clear your license from this device and you have to re-license your product from Rifs Team.", "License clear confirmation") = DialogResult.Yes Then

        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'newsale
        If e.KeyCode = Keys.N AndAlso e.Shift = True AndAlso e.Control = True Then
            If (all.current_index = 50) = False AndAlso (all.current_index = 37) = False Then
                index(37)
                fll(37)
                nw(37, 1)
                nw(37, 0)
                ld(37)
            End If
            'manage sale
        ElseIf e.KeyCode = Keys.S AndAlso e.Shift = True AndAlso e.Control = True Then
            If (all.current_index = 50) = False AndAlso (all.current_index = 37) = False Then
                index(21)
                fll(21)
                ld(21)
            End If
            'new purchase
        ElseIf e.KeyCode = Keys.N AndAlso e.Alt = True AndAlso e.Control = True Then
            If (all.current_index = 50) = False AndAlso (all.current_index = 36) = False Then
                index(36)
                fll(36)
                nw(36, 0)
                nw(36, 1)
                ld(36)
            End If
            'manage pruchase
        ElseIf e.KeyCode = Keys.P AndAlso e.Shift = True AndAlso e.Control = True Then
            If (all.current_index = 50) = False Then
                index(30)
                fll(30)
                ld(30)
            End If
            'dashboard
        ElseIf e.KeyCode = Keys.D AndAlso e.Shift = True AndAlso e.Control = True Then
            If (all.current_index = 50) = False AndAlso (all.current_index = 37) = False Then
                index(12)
                fll(12)
                ld(12)
            End If
            'new income
        ElseIf e.KeyCode = Keys.I AndAlso e.Control = True AndAlso e.Shift = True Then
            If (all.current_index = 50) = False AndAlso (all.current_index = 35) = False Then
                index(35)
                fll(35)
                nw(35, 0)
                ld(35)
            End If
            'new expense
        ElseIf e.KeyCode = Keys.E AndAlso e.Control = True AndAlso e.Shift = True Then
            If (all.current_index = 50) = False AndAlso (all.current_index = 34) = False Then
                index(34)
                fll(34)
                nw(34, 0)
                ld(34)
            End If
            'manage income
        ElseIf e.KeyCode = Keys.I AndAlso e.Alt = True AndAlso e.Control = True Then
            If (all.current_index = 50) = False Then
                index(28)
                fll(28)
                ld(28)
            End If
            'manage expense
        ElseIf e.KeyCode = Keys.E AndAlso e.Alt = True AndAlso e.Control = True Then
            If (all.current_index = 50) Then
                index(26)
                fll(26)
                ld(26)
            End If
            'manage stock
        ElseIf e.KeyCode = Keys.S AndAlso e.Alt = True AndAlso e.Control = True Then
            If (all.current_index = 50) = False Then
                index(31)
                fll(31)
                ld(31)
            End If
            'sales report
        ElseIf e.KeyCode = Keys.S AndAlso e.Alt = True Then
            If (all.current_index = 50) = False Then
                index(46)
                fll(46)
                ld(46)
            End If
            'pruchase report
        ElseIf e.KeyCode = Keys.P AndAlso e.Alt = True Then
            If (all.current_index = 50) = False Then
                index(42)
                fll(42)
                ld(42)
            End If
            'expense report
        ElseIf e.KeyCode = Keys.E AndAlso e.Alt = True Then
            If (all.current_index = 50) = False Then
                index(17)
                fll(17)
                ld(17)
            End If
            'attendance report
        ElseIf e.KeyCode = Keys.A AndAlso e.Alt = True Then
            If (all.current_index = 50) = False Then
                index(8)
                fll(8)
                ld(8)
            End If
            'bank transaction report
        ElseIf e.KeyCode = Keys.B AndAlso e.Alt = True Then
            If (all.current_index = 50) = False Then
                index(52)
                fll(52)
                ld(52)
            End If
            'customer dues report
        ElseIf e.KeyCode = Keys.D AndAlso e.Control = True Then
            If (all.current_index = 50) = False AndAlso (all.current_index = 37) = False Then
                index(13)
                fll(13)
                ld(13)
            End If
            'cash report
        ElseIf e.KeyCode = Keys.C AndAlso e.Alt = True AndAlso e.Control = False Then
            If (all.current_index = 50) = False AndAlso (all.current_index = 37) = False Then
                index(69)
                fll(69)
                ld(69)
            End If
            'profit calculator
            'ElseIf e.KeyCode = Keys.C AndAlso e.Shift = True Then
            '    If (all.current_index = 50) = False AndAlso (all.current_index = 37) = False Then
            '        index(41)
            '        fll(41)
            '        ld(41)
            '    End If
            'date changer
        ElseIf e.KeyCode = Keys.X AndAlso e.Control = True Then
            If (all.current_index = 50) = False Then
                date_changer.ShowDialog()
            End If
            'calculator
        ElseIf e.KeyCode = Keys.C AndAlso e.Control = True AndAlso e.Alt = True Then
            cal.ShowDialog()
        End If

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub MenuStrip1_KeyDown(sender As Object, e As KeyEventArgs) Handles MenuStrip1.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Control = True AndAlso e.Shift = True Then
            If e.KeyCode = Keys.N AndAlso e.Control = True AndAlso e.Shift = True Then
                index(37)
                fll(37)
                nw(37, 1)
                nw(37, 0)
                ld(37)
            ElseIf e.KeyCode = Keys.N AndAlso e.Control = True Then
                If all.current_index = 37 Then
                    all.newsale.InvoiceNoTextBox1.Text = all.newsale.InvoiceNoTextBox.Text
                    all.newsale.Validate()
                    all.newsale.TblProductsBindingSource.EndEdit()
                    all.newsale.TblSalesBindingSource.EndEdit()
                    all.newsale.TableAdapterManager.UpdateAll(DataSet)
                    nw(37, 1)
                    all.newsale.ProductNameTextBox.Select()
                End If
            End If
        End If
    End Sub

    Private Sub tmr_short_Tick(sender As Object, e As EventArgs)
        MenuStrip1.Select()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_KeyDown(sender As Object, e As KeyEventArgs) Handles Panel1.KeyDown

    End Sub

    Private Sub MenuStrip1_MouseEnter(sender As Object, e As EventArgs) Handles MenuStrip1.MouseEnter

    End Sub

    Private Sub MenuStrip1_MouseLeave(sender As Object, e As EventArgs) Handles MenuStrip1.MouseLeave

    End Sub

    Private Sub Form1_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged

    End Sub

    Private Sub Form1_Enter(sender As Object, e As EventArgs) Handles Me.Enter

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        index(70)
        fll(70)
        ld(70)
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        index(72)
        fll(72)
        ld(72)
    End Sub

    Private Sub lblTim_Click(sender As Object, e As EventArgs) Handles lblTim.Click

    End Sub

    Private Sub lblTim_MouseEnter(sender As Object, e As EventArgs) Handles lblTim.MouseEnter

    End Sub

    Private Sub lblTim_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTim.MouseDown
        x = MousePosition.X - Me.Location.X
        y = MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub lblTim_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTim.MouseMove
        If e.Button = MouseButtons.Left Then
            xy = MousePosition
            xy.X = xy.X - x
            xy.Y = xy.Y - y
            Me.Location = xy
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        If MsgBox("This operation will create your all daily reports automatically. Are you sure to run this operation?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            lod()
        End If
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub ToolStripMenuItem8_Click_2(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        fll(80)
        index(80)
        ld(80)
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        index(81)
        fll(81)
        ld(81)

    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        index(82)
    End Sub

    Private Sub lbladd_Click(sender As Object, e As EventArgs) Handles lbladd.Click

    End Sub
End Class
