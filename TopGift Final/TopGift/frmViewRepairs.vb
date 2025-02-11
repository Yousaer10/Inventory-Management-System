'Represents an open connection to a data source
Imports System.Data.OleDb

Public Class frmViewRepairs

    Private Sub frmViewRepairs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubMenus()
        GetActiveRepairs()
        GetPastRepairs()
        'Display staff id and username
        LblStaffID.Text = PublicStaffID
        LblPublicUsername.Text = PublicUsername
        Timer7.Enabled = True
        CheckAccessLevel()
    End Sub

    Private Sub CheckAccessLevel()
        'If user has just registered then
        If PublicAccessLevel = 0 Then
            'Disable all buttons
            BtnOpenInventory.Enabled = False
            BtnOpenReminder.Enabled = False
            BtnOpenRepair.Enabled = False
            BtnOpenAdmin.Enabled = False
        ElseIf PublicAccessLevel = 1 Then
            'Enable view repairs button
            BtnOpenInventory.Enabled = False
            BtnOpenReminder.Enabled = False
            BtnOpenSetRepairs.Enabled = False
            BtnOpenAdmin.Enabled = False
        ElseIf PublicAccessLevel = 2 Then
            'Disable Admin button
            BtnOpenAdmin.Enabled = False
        End If
    End Sub

    Private Sub GetActiveRepairs()
        'If connected to database
        If DbConnect() Then
            DgvActiveRepairs.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select TblRepairs.RepairID, TblStaff.StaffID, TblReminder.CustomerName, TblReminder.DeviceInfo, TblReminder.RepairPrice, TblReminder.ReminderDate " &
                "From (TblRepairs " &
                "Inner Join TblStaff on TblRepairs.StaffID = TblStaff.StaffID) " &
                "Inner Join TblReminder on TblRepairs.ReminderID = TblReminder.ReminderID " &
                "Where ((TblStaff.StaffID) = @CurrentStaffID) And ((TblReminder.ReminderDate) >= @Date) "
                .Parameters.AddWithValue("@CurrentStaffID", PublicStaffID)
                .Parameters.Add("@Date", OleDbType.Date).Value = Now
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewRepairRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewRepairRow.CreateCells(DgvActiveRepairs)
                        'Insert values from database to datagrid
                        NewRepairRow.SetValues({rs("RepairID"), rs("StaffID"), rs("CustomerName"), rs("DeviceInfo"), rs("RepairPrice"), rs("ReminderDate")})
                        NewRepairRow.Tag = rs("RepairID")
                        'Create new rows
                        DgvActiveRepairs.Rows.Add(NewRepairRow)
                    End While
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "View Repairs", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub GetPastRepairs()
        'If connected to database
        If DbConnect() Then
            DgvPastRepairs.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select TblRepairs.RepairID, TblStaff.StaffID, TblReminder.CustomerName, TblReminder.DeviceInfo, TblReminder.RepairPrice, TblReminder.ReminderDate " &
                "From (TblRepairs " &
                "Inner Join TblStaff on TblRepairs.StaffID = TblStaff.StaffID) " &
                "Inner Join TblReminder on TblRepairs.ReminderID = TblReminder.ReminderID " &
                "Where ((TblStaff.StaffID) = @CurrentStaffID) And ((TblReminder.ReminderDate) < @Date) "
                .Parameters.AddWithValue("@CurrentStaffID", PublicStaffID)
                .Parameters.Add("@Date", OleDbType.Date).Value = Now
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewRepairRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewRepairRow.CreateCells(DgvPastRepairs)
                        'Insert values from database into datagrid
                        NewRepairRow.SetValues({rs("RepairID"), rs("StaffID"), rs("CustomerName"), rs("DeviceInfo"), rs("RepairPrice"), rs("ReminderDate")})
                        NewRepairRow.Tag = rs("RepairID")
                        'Create new rows
                        DgvPastRepairs.Rows.Add(NewRepairRow)
                    End While
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "View Repairs", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        'Display date and time
        LblSystemDateTime.Text = Date.Now.ToString("HH:mm    dd/MM/yyyy")
    End Sub

    Private Sub HideSubMenus()
        'Hide panels
        PanelReminder.Visible = False
        PanelRepair.Visible = False

    End Sub

    Private Sub ShowSubMenus(Submenu As Panel)
        If Submenu.Visible = False Then
            HideSubMenus()
            Submenu.Visible = True
        Else
            Submenu.Visible = False
        End If

    End Sub

    Private Sub BtnOpenInventory_Click(sender As Object, e As EventArgs) Handles BtnOpenInventory.Click
        frmInventory.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenReminder_Click(sender As Object, e As EventArgs) Handles BtnOpenReminder.Click
        ShowSubMenus(PanelReminder)
    End Sub

    Private Sub BtnOpenCreateReminder_Click(sender As Object, e As EventArgs) Handles BtnOpenCreateReminder.Click
        frmReminder.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenViewReminders_Click(sender As Object, e As EventArgs) Handles BtnOpenViewReminders.Click
        frmReminderInfo.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenRepair_Click(sender As Object, e As EventArgs) Handles BtnOpenRepair.Click
        ShowSubMenus(PanelRepair)
    End Sub

    Private Sub BtnOpenSetRepairs_Click(sender As Object, e As EventArgs) Handles BtnOpenSetRepairs.Click
        frmSetRepair.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenViewRepairs_Click(sender As Object, e As EventArgs) Handles BtnOpenViewRepairs.Click
        HideSubMenus()
    End Sub

    Private Sub BtnOpenAdmin_Click(sender As Object, e As EventArgs) Handles BtnOpenAdmin.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        frmLogin.BtnClear.PerformClick()
        frmLogin.Show()
        Me.Close()
    End Sub

End Class