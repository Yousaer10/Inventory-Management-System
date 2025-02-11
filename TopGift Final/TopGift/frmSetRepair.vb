'Represents an open connection to a data source
Imports System.Data.OleDb

Public Class frmSetRepair

    'The repair ID is set to -1 to show it is a new repair and that we are not editing a repair
    Private CurrentRepairID As Integer = -1

    Private Sub frmSetRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubMenus()
        LoadComboBoxes()
        'Display username
        LblPublicUsername.Text = PublicUsername
        Timer6.Enabled = True
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

    Private Sub LoadComboBoxes()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select TblReminder.ReminderID " &
                "From (TblReminder " &
                "Left Join TblRepairs ON TblRepairs.ReminderID = TblReminder.ReminderID) " &
                "WHERE TblRepairs.ReminderID Is NULL And ReminderDate > @Date "
                .Parameters.Add("@Date", OleDbType.Date).Value = Now
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        'Add items to comboboxes
                        CmbSearchReminderID.Items.Add(rs(0).ToString)
                        CmbReminderID.Items.Add(rs(0).ToString)
                    End While
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Set Repair", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close databse connection
        cn.Close()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select CustomerName " &
                "From (TblReminder " &
                "Left Join TblRepairs ON TblRepairs.ReminderID = TblReminder.ReminderID) " &
                "WHERE TblRepairs.ReminderID Is NULL And ReminderDate > @Date "
                .Parameters.Add("@Date", OleDbType.Date).Value = Now
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        'Add items to comboboxes
                        CmbCustomerName.Items.Add(rs(0).ToString)
                    End While
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Set Repair", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select StaffID FROM TblStaff"
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        'Add items to comboboxes
                        CmbStaffID.Items.Add(rs(0).ToString)
                        CmbStaffIDSearch.Items.Add(rs(0).ToString)
                    End While
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Set Repair", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select SSurname FROM TblStaff"
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        'Add items to comboboxes
                        CmbStaffSurname.Items.Add(rs(0).ToString)
                    End While
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Set Repair", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub GetActiveReminders()
        'If connected to database
        If DbConnect() Then
            DgvActiveReminders.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select TblReminder.ReminderID, TblReminder.CustomerName, TblReminder.DeviceInfo, TblReminder.RepairPrice, TblReminder.ReminderDate " &
                "From (TblReminder " &
                "Left Join TblRepairs ON TblRepairs.ReminderID = TblReminder.ReminderID) " &
                "WHERE TblRepairs.ReminderID Is NULL And ReminderDate > @Date "
                .Parameters.Add("@Date", OleDbType.Date).Value = Now
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewReminderRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewReminderRow.CreateCells(DgvActiveReminders)
                        'Insert values from database into datagrid
                        NewReminderRow.SetValues({rs("ReminderID"), rs("CustomerName"), rs("DeviceInfo"), rs("RepairPrice"), rs("ReminderDate")})
                        NewReminderRow.Tag = rs("ReminderID")
                        'Create new rows
                        DgvActiveReminders.Rows.Add(NewReminderRow)
                    End While
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Set Repair", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub BtnReminderSearch_Click(sender As Object, e As EventArgs) Handles BtnReminderSearch.Click
        Dim ReminderIDIsSelected As Boolean = CmbSearchReminderID.SelectedIndex <> -1
        Dim CustomerNameIsSelected As Boolean = CmbCustomerName.SelectedIndex <> -1
        'If nothing selected from comboboxes then display error message
        If CmbSearchReminderID.SelectedIndex = -1 And CmbCustomerName.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Reminder ID or Customer Name to perform a search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If both items are selected from both comboboxes then display error message
        ElseIf ReminderIDIsSelected And CustomerNameIsSelected Then
            MessageBox.Show("Please only search by Reminder ID or Customer Name not Both" & vbCrLf, "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If reminder id is selected then call display procedure
        ElseIf ReminderIDIsSelected Then
            ReminderIDDisplay(CmbSearchReminderID.Text)
            'If customer name is selected then call display procedure
        ElseIf CustomerNameIsSelected Then
            CustomerNameDisplay(CmbCustomerName.Text)
        End If
    End Sub

    Private Sub ReminderIDDisplay(ReminderID As Integer)
        'If connected to database
        If DbConnect() Then
            DgvActiveReminders.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to search the following information
                .Connection = cn

                .CommandText = "Select * " &
                               "From TblReminder " &
                               "Where ReminderDate > @Date and ReminderID = @ReminderIDSearch"
                .Parameters.Add("@Date", OleDbType.Date).Value = Now
                .Parameters.AddWithValue("@ReminderIDSearch", ReminderID)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewReminderRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewReminderRow.CreateCells(DgvActiveReminders)
                        'Insert record set values into the following datagrid rows
                        NewReminderRow.SetValues({rs("ReminderID"), rs("CustomerName"), rs("DeviceInfo"), rs("RepairPrice"), rs("ReminderDate")})
                        NewReminderRow.Tag = rs("ReminderID")
                        'Create new rows
                        DgvActiveReminders.Rows.Add(NewReminderRow)
                    End While
                    'Record set is closed
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Set Repair", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub CustomerNameDisplay(CustomerName As String)
        'If connected to database
        If DbConnect() Then
            DgvActiveReminders.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to search the following information
                .Connection = cn
                .CommandText = "Select * " &
                               "From TblReminder " &
                               "Where ReminderDate > @Date and CustomerName = @CustomerSearch"
                .Parameters.Add("@Date", OleDbType.Date).Value = Now
                .Parameters.AddWithValue("@CustomerSearch", CustomerName)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewReminderRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewReminderRow.CreateCells(DgvActiveReminders)
                        'Insert values from database into datagrid
                        NewReminderRow.SetValues({rs("ReminderID"), rs("CustomerName"), rs("DeviceInfo"), rs("RepairPrice"), rs("ReminderDate")})
                        NewReminderRow.Tag = rs("ReminderID")
                        'Create new rows
                        DgvActiveReminders.Rows.Add(NewReminderRow)
                    End While
                    'Record set is closed
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Set Repair", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub BtnViewAll_Click(sender As Object, e As EventArgs) Handles BtnViewAllReminders.Click
        'Calls procedure
        GetActiveReminders()
    End Sub

    Private Sub BtnClearDisplaySearch_Click(sender As Object, e As EventArgs) Handles BtnClearReminderSearch.Click
        'Deselect both comboboxes and all datagrid clear rows 
        CmbSearchReminderID.SelectedIndex = -1
        CmbCustomerName.SelectedIndex = -1
        DgvActiveReminders.Rows.Clear()
    End Sub

    Private Sub DgvCurrentReminders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvActiveReminders.CellClick
        'Check if the user clicks on a valid row. ie: Not on the row header or column header
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Set the combobox text to the specified column's value
            CmbReminderID.Text = DgvActiveReminders.Rows(e.RowIndex).Cells(0).Value '1st column
            'Set the combobox selected item to the cell value the user just clicked on
        End If
    End Sub

    Private Sub BtnSetRepairClear_Click(sender As Object, e As EventArgs) Handles BtnSetRepairClear.Click
        'Deselect both comboboxes
        CmbStaffID.SelectedIndex = -1
        CmbReminderID.SelectedIndex = -1
        TxtRepairID.Text = "Automatically Generated"
    End Sub

    Private Sub BtnSetRepairTask_Click(sender As Object, e As EventArgs) Handles BtnSetRepairTask.Click
        'if nothing is selected then display error message
        If CmbStaffID.Text = "" Then
            MessageBox.Show("Please select a Staff ID." & vbCrLf, "Set Repair", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CmbReminderID.Text = "" Then
            MessageBox.Show("Please select a Reminder ID." & vbCrLf, "Set Repair", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If connected to database
        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            If CurrentRepairID = -1 Then
                'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
                With SQLCmd
                    'SQLCmd is uses the connection to save the following information
                    .Connection = cn
                    .CommandText = "Insert into TblRepairs (StaffID, ReminderID)"
                    .CommandText &= " Values (@StaffID, @ReminderID)"
                    .Parameters.AddWithValue("@StaffID", CmbStaffID.Text)
                    .Parameters.AddWithValue("@ReminderID", CmbReminderID.Text)
                    'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                    .ExecuteNonQuery()
                    'Now get the auto generated ID of this new Order
                    .CommandText = "Select @@Identity"
                    'ExecuteScalar - only 1 value back ie, create a new ID.
                    CurrentRepairID = .ExecuteScalar
                    TxtRepairID.Text = CurrentRepairID
                    'Notify user
                    MessageBox.Show("Repair set" & vbCrLf, "Set Repair", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End With
                'Close database connection
                cn.Close()
            End If
        End If
    End Sub

    Private Sub GetStaffInfo()
        'If connected to database
        If DbConnect() Then
            DgvStaffInfo.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "SELECT * FROM TblStaff"
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewStaffRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewStaffRow.CreateCells(DgvStaffInfo)
                        NewStaffRow.SetValues({rs("StaffID"), rs("SName"), rs("SSurname"), rs("SEmail"), rs("SUsername")})
                        NewStaffRow.Tag = rs("StaffID")
                        'New rows are created
                        DgvStaffInfo.Rows.Add(NewStaffRow)
                    End While
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Set Repair", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub BtnStaffSearch_Click(sender As Object, e As EventArgs) Handles BtnStaffSearch.Click
        Dim StaffIDIsSelected As Boolean = CmbStaffIDSearch.SelectedIndex <> -1
        Dim StaffSurnameIsSelected As Boolean = CmbStaffSurname.SelectedIndex <> -1
        'If nothing is selected from both comboboxes then
        If CmbStaffIDSearch.SelectedIndex = -1 And CmbStaffSurname.SelectedIndex = -1 Then
            'Dsiplay error message
            MessageBox.Show("Please select a Staff ID or Staff Surname to perform a search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If an item is selected from both comboboxes then
        ElseIf StaffIDIsSelected And StaffSurnameIsSelected Then
            'Display error message
            MessageBox.Show("Please only search by Staff ID or Surname not Both" & vbCrLf, "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If staff id is selected then
        ElseIf StaffIDIsSelected Then
            'Call procedure and send staff id along side
            StaffIDDisplay(CmbStaffIDSearch.Text)
            'If staff surname is selected then
        ElseIf StaffSurnameIsSelected Then
            'Calls procedure
            StaffSurnameDisplay()
        End If
    End Sub

    Private Sub StaffIDDisplay(StaffID As Integer)
        'If connected to database
        If DbConnect() Then
            DgvStaffInfo.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * " &
                               "From TblStaff " &
                               "Where StaffID = @StaffIDSearch"
                .Parameters.AddWithValue("@StaffIDSearch", StaffID)
                'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                Try
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewStaffRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewStaffRow.CreateCells(DgvStaffInfo)
                        NewStaffRow.SetValues({rs("StaffID"), rs("SName"), rs("SSurname"), rs("SEmail"), rs("SUsername")})
                        NewStaffRow.Tag = rs("StaffID")
                        'New rows are created
                        DgvStaffInfo.Rows.Add(NewStaffRow)
                    End While
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Set Repair", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub StaffSurnameDisplay()
        'If connected to database
        If DbConnect() Then
            DgvStaffInfo.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to search the following information
                .Connection = cn
                .CommandText = "Select * " &
                               "From TblStaff " &
                               "Where SSurname Like @StaffNameSearch"
                .Parameters.AddWithValue("@StaffNameSearch", "%" & CmbStaffSurname.Text & "%")
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewStaffRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewStaffRow.CreateCells(DgvStaffInfo)
                        NewStaffRow.SetValues({rs("StaffID"), rs("SName"), rs("SSurname"), rs("SEmail"), rs("SUsername")})
                        NewStaffRow.Tag = rs("StaffID")
                        'New rows are created
                        DgvStaffInfo.Rows.Add(NewStaffRow)
                    End While
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Set Repair", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub BtnStaffViewAll_Click(sender As Object, e As EventArgs) Handles BtnViewAllStaff.Click
        GetStaffInfo()
    End Sub

    Private Sub BtnStaffInfoClear_Click(sender As Object, e As EventArgs) Handles BtnClearStaffSearch.Click
        'Deselect both comboboxes
        CmbStaffIDSearch.SelectedIndex = -1
        CmbStaffSurname.SelectedIndex = -1
        DgvStaffInfo.Rows.Clear()
    End Sub

    Private Sub DgvStaffInfo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvStaffInfo.CellClick
        'Check if the user clicks on a valid row. ie: Not on the row header or column header
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Set the textbox text to the specified column's value
            CmbStaffID.Text = DgvStaffInfo.Rows(e.RowIndex).Cells(0).Value '1st column
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
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
        frmReminderInfo.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenRepair_Click(sender As Object, e As EventArgs) Handles BtnOpenRepair.Click
        ShowSubMenus(PanelRepair)
    End Sub

    Private Sub BtnOpenSetRepairs_Click(sender As Object, e As EventArgs) Handles BtnOpenSetRepairs.Click
        HideSubMenus()
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