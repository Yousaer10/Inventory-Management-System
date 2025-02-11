'Represents an open connection to a data source
Imports System.Data.OleDb

Public Class frmReminderInfo

    Private Sub frmReminderInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubMenus()
        GetActiveReminders()
        GetPastReminders()
        'Display username and start timer
        LblPublicUsername.Text = PublicUsername
        Timer5.Enabled = True
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

    Private Sub GetActiveReminders()
        'If connected to database
        If DbConnect() Then
            DgvCurrentReminders.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "SELECT * FROM TblReminder Where ReminderDate > @Date"
                .Parameters.Add("@Date", OleDbType.Date).Value = Now
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewStockRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewStockRow.CreateCells(DgvCurrentReminders)
                        NewStockRow.SetValues({rs("ReminderID"), rs("CustomerName"), rs("DeviceInfo"), rs("RepairPrice"), rs("ReminderDate")})
                        NewStockRow.Tag = rs("ReminderID")
                        'New rows are created
                        DgvCurrentReminders.Rows.Add(NewStockRow)
                    End While
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "View Reminders", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        cn.Close()
    End Sub

    Private Sub GetPastReminders()
        'If connected to database
        If DbConnect() Then
            DgvPastReminders.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "SELECT * FROM TblReminder Where ReminderDate < @Date"
                .Parameters.Add("@Date", OleDbType.Date).Value = Now
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewStockRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewStockRow.CreateCells(DgvPastReminders)
                        NewStockRow.SetValues({rs("ReminderID"), rs("CustomerName"), rs("DeviceInfo"), rs("RepairPrice"), rs("ReminderDate")})
                        NewStockRow.Tag = rs("ReminderID")
                        DgvPastReminders.Rows.Add(NewStockRow)
                    End While
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "View Reminders", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        'Display date and time
        LblSystemDateTime.Text = Date.Now.ToString("HH:mm    dd/MM/yyyy")
    End Sub

    Private Sub HideSubMenus()

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
        HideSubMenus()
    End Sub

    Private Sub BtnOpenRepair_Click(sender As Object, e As EventArgs) Handles BtnOpenRepair.Click
        ShowSubMenus(PanelRepair)
    End Sub

    Private Sub BtnOpenSetRepairs_Click(sender As Object, e As EventArgs) Handles BtnOpenSetRepairs.Click
        frmSetRepair.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenViewRepairs_Click(sender As Object, e As EventArgs) Handles BtnOpenViewRepairs.Click
        frmViewRepairs.Show()
        Me.Close()
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