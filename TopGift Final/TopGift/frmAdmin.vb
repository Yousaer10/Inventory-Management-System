'Represents an open connection to a data source
Imports System.Data.OleDb
'Represents specific character patterns
Imports System.Text.RegularExpressions

Public Class frmAdmin

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubMenus()
        InitialiseComponents()
        'Display username
        LblPublicUsername.Text = PublicUsername
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

    Dim StaffSelectedEmail As String
    Dim StaffSelectedUsername As String

    Private Sub InitialiseComponents()
        'Empties comboboxes
        CmbStaffIDSearch.Items.Clear()
        CmbStaffID.Items.Clear()
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
                        CmbStaffIDSearch.Items.Add(rs(0).ToString)
                        CmbStaffID.Items.Add(rs(0).ToString)
                    End While
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
        'Empties comboboxes
        CmbStaffSurname.Items.Clear()
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
                        CmbStaffSurname.Items.Add(rs(0).ToString)
                    End While
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
        BtnStaffDelete.Enabled = False
        BtnSave.Enabled = False
        Timer4.Enabled = True
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
                        'In datagrid, rows for values mentioned below are created3
                        NewStaffRow.CreateCells(DgvStaffInfo)
                        NewStaffRow.SetValues({rs("StaffID"), rs("SAccessLevel"), rs("SName"), rs("SSurname"), rs("SEmail"), rs("SUsername")})
                        NewStaffRow.Tag = rs("StaffID")
                        'New rows are created
                        DgvStaffInfo.Rows.Add(NewStaffRow)
                    End While
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
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

        If CmbStaffIDSearch.SelectedIndex = -1 And CmbStaffSurname.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Staff ID or Staff Surname to perform a search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf StaffIDIsSelected And StaffSurnameIsSelected Then
            MessageBox.Show("Please only search by Staff ID or Surname not Both" & vbCrLf, "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf StaffIDIsSelected Then
            StaffIDDisplay(CmbStaffIDSearch.Text)
        ElseIf StaffSurnameIsSelected Then
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
                'SQLCmd is uses the connection to read the following information
                .Connection = cn
                .CommandText = "Select * " &
                               "From TblStaff " &
                               "Where StaffID = @StaffIDSearch"
                .Parameters.AddWithValue("@StaffIDSearch", StaffID)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewStaffRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewStaffRow.CreateCells(DgvStaffInfo)
                        NewStaffRow.SetValues({rs("StaffID"), rs("SAccessLevel"), rs("SName"), rs("SSurname"), rs("SEmail"), rs("SUsername")})
                        NewStaffRow.Tag = rs("StaffID")
                        'New rows are created
                        DgvStaffInfo.Rows.Add(NewStaffRow)
                    End While
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
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
                        NewStaffRow.SetValues({rs("StaffID"), rs("SAccessLevel"), rs("SName"), rs("SSurname"), rs("SEmail"), rs("SUsername")})
                        NewStaffRow.Tag = rs("StaffID")
                        'New rows are created
                        DgvStaffInfo.Rows.Add(NewStaffRow)
                    End While
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
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
        DisplayStaffCellClick()
    End Sub

    Private Sub DisplayStaffCellClick()
        Dim i As Integer
        i = DgvStaffInfo.CurrentRow.Index
        CmbStaffID.Text = DgvStaffInfo.Item(0, i).Value
        CmbAccessLevel.Text = DgvStaffInfo.Item(1, i).Value
        TxtFirstName.Text = DgvStaffInfo.Item(2, i).Value
        TxtSurname.Text = DgvStaffInfo.Item(3, i).Value
        TxtEmail.Text = DgvStaffInfo.Item(4, i).Value
        TxtUsername.Text = DgvStaffInfo.Item(5, i).Value
        BtnStaffDelete.Enabled = True
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SaveCheckFirstName()
    End Sub

    Private Sub SaveStaffInfo()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Update TblStaff Set SAccessLevel = @AccessLevel, SName = @FirstName, SSurname = @Surname, SEmail = @Email, SUsername = @Username Where StaffID = @CurrentStaffID"
                .Parameters.AddWithValue("@AccessLevel", CmbAccessLevel.Text)
                .Parameters.AddWithValue("@FirstName", TxtFirstName.Text)
                .Parameters.AddWithValue("@Surname", TxtSurname.Text)
                .Parameters.AddWithValue("@Email", TxtEmail.Text)
                .Parameters.AddWithValue("@Username", TxtUsername.Text)
                .Parameters.AddWithValue("@CurrentStaffID", CmbStaffID.Text)
                'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                .ExecuteNonQuery()
                MessageBox.Show("Staff Information has been updated." & vbCrLf, "Update Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'The clearing event is separated from UI
        ClearEvent()
    End Sub

    Private Sub ClearEvent()
        'Deselect both comboboxes
        CmbStaffID.SelectedIndex = -1
        CmbAccessLevel.SelectedIndex = -1
        'Empties textboxes
        TxtFirstName.Text = ""
        TxtSurname.Text = ""
        TxtEmail.Text = ""
        TxtUsername.Text = ""
        'Disable buttons
        BtnSave.Enabled = False
        BtnStaffDelete.Enabled = False
        LblUsernameNotifier.Hide()
        UsernameWarningIcon.Hide()
        LblEmailNotifier.Hide()
        EmailWarningIcon.Hide()
        LblFirstNameNotifier.Hide()
        FirstNameWarningIcon.Hide()
        LblSurnameNotifier.Hide()
        SurnameWarningIcon.Hide()
        'Change textbox border colour to white
        TxtFirstName.BorderColor = Color.White
        TxtSurname.BorderColor = Color.White
        TxtUsername.BorderColor = Color.White
        TxtEmail.BorderColor = Color.White
    End Sub

    Private Sub BtnStaffDelete_Click(sender As Object, e As EventArgs) Handles BtnStaffDelete.Click
        If MessageBox.Show("Are you sure you want to delete this Staff Account?", "Delete Staff Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) = DialogResult.OK Then
            'If connected to database
            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
                With SQLCmd
                    'SQLCmd is uses the connection to save the following information
                    .Connection = cn
                    .CommandText = "Delete From TblStaff Where StaffID = @StaffDelete"
                    .Parameters.AddWithValue("@StaffDelete", CmbStaffID.Text)
                    'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                    .ExecuteNonQuery()
                    BtnClear.PerformClick()
                End With
                'Close database connection
                cn.Close()
                BtnClearStaffSearch.PerformClick()
                InitialiseComponents()
            End If
        End If
    End Sub

    Private Sub CmbStaffID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStaffID.SelectedIndexChanged
        DisplayStaff()
    End Sub

    Private Sub DisplayStaff()
        If CmbStaffID.SelectedIndex = -1 Then
            'If connected to database
        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff where StaffID = @SearchStaffID"
                .Parameters.AddWithValue("@SearchStaffID", CmbStaffID.SelectedItem)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    '----------------------------
                    'Display Staff Info
                    '----------------------------
                    If rs.Read Then
                        CmbAccessLevel.Text = rs("SAccessLevel")
                        StaffSelectedEmail = rs("SEmail")
                        StaffSelectedUsername = rs("SUsername")
                        TxtFirstName.Text = rs("SName")
                        TxtSurname.Text = rs("SSurname")
                        TxtEmail.Text = rs("SEmail")
                        TxtUsername.Text = rs("SUsername")
                        BtnStaffDelete.Enabled = True
                        BtnSave.Enabled = True
                    End If
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub SaveCheckFirstName()
        'If first name not entered then
        If TxtFirstName.Text.Length < 1 Then
            'Display error message
            LblFirstNameNotifier.Show()
            FirstNameWarningIcon.Show()
            'Change textbox border colour to red
            TxtFirstName.BorderColor = Color.Red
            'If first name entered then
        ElseIf TxtFirstName.Text.Length > 0 Then
            'Display error message
            LblFirstNameNotifier.Hide()
            FirstNameWarningIcon.Hide()
            'Change textbox border colour to green
            TxtFirstName.BorderColor = Color.Green
            'Calls procedure
            SaveCheckSurname()
        End If
    End Sub

    Private Sub CheckFirstName()
        'If first name not entered then
        If TxtFirstName.Text.Length < 1 Then
            'Display error message
            LblFirstNameNotifier.Show()
            FirstNameWarningIcon.Show()
            'Change textbox border colour to red
            TxtFirstName.BorderColor = Color.Red
            'If first name entered then
        ElseIf TxtFirstName.Text.Length > 0 Then
            LblFirstNameNotifier.Hide()
            FirstNameWarningIcon.Hide()
            'Change textbox border colour to green
            TxtFirstName.BorderColor = Color.Green
        End If
    End Sub

    Private Sub SaveCheckSurname()
        'If surname not entered then
        If TxtSurname.Text.Length < 1 Then
            'Display error message
            LblSurnameNotifier.Show()
            SurnameWarningIcon.Show()
            'Change textbox border colour to red
            TxtSurname.BorderColor = Color.Red
            'If surname entered then
        ElseIf TxtSurname.Text.Length > 0 Then
            LblSurnameNotifier.Hide()
            SurnameWarningIcon.Hide()
            'Change textbox border colour to green
            TxtSurname.BorderColor = Color.Green
            'Calls procedure
            SaveCheckEmail()
        End If
    End Sub

    Private Sub CheckSurname()
        'If surname not entered then
        If TxtSurname.Text.Length < 1 Then
            'Display error message
            LblSurnameNotifier.Show()
            SurnameWarningIcon.Show()
            'Change textbox border colour to red
            TxtSurname.BorderColor = Color.Red
            'If surname entered then
        ElseIf TxtSurname.Text.Length > 0 Then
            LblSurnameNotifier.Hide()
            SurnameWarningIcon.Hide()
            'Change textbox border colour to green
            TxtSurname.BorderColor = Color.Green
        End If
    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function

    Private Sub SaveCheckEmail()
        Dim ValidEmail As String
        ValidEmail = TxtEmail.Text
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SEmail = @StaffEmail AND SEmail <> @CurrentEmail"
                .Parameters.AddWithValue("@StaffEmail", TxtEmail.Text)
                .Parameters.AddWithValue("@CurrentEmail", StaffSelectedEmail)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If email not entered then
                    If TxtEmail.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtEmail.BorderColor = Color.Red
                        'Display error message
                        LblEmailNotifier.Text = "Please enter an email"
                        'Display error message
                        LblEmailNotifier.Show()
                        EmailWarningIcon.Show()
                        'If record set is read then
                    ElseIf rs.Read Then
                        'Display error message
                        LblEmailNotifier.Text = "Email already exists"
                        'Display error message
                        LblEmailNotifier.Show()
                        EmailWarningIcon.Show()
                        'Change textbox border colour to red
                        TxtEmail.BorderColor = Color.Red
                    ElseIf IsValidEmailFormat(ValidEmail) = False Then
                        'Display error message
                        LblEmailNotifier.Text = "Please enter the email in the correct format!(e.g. something123@gmail.com)"
                        'Display error message
                        LblEmailNotifier.Show()
                        EmailWarningIcon.Show()
                        'Change textbox border colour to red
                        TxtEmail.BorderColor = Color.Red
                    Else
                        'Change textbox border colour to green
                        TxtEmail.BorderColor = Color.Green
                        LblEmailNotifier.Hide()
                        EmailWarningIcon.Hide()
                        'Calls procedure
                        SaveCheckUsername()
                    End If
                    'If close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub CheckEmail()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SEmail = @StaffEmail AND SEmail <> @CurrentEmail"
                .Parameters.AddWithValue("@StaffEmail", TxtEmail.Text)
                .Parameters.AddWithValue("@CurrentEmail", StaffSelectedEmail)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If email not entered then
                    If TxtEmail.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtEmail.BorderColor = Color.Red
                        'Display error message
                        LblEmailNotifier.Text = "Please enter an email"
                        LblEmailNotifier.Show()
                        EmailWarningIcon.Show()
                        'If record set is read then
                    ElseIf rs.Read Then
                        'Display error message
                        LblEmailNotifier.Text = "Email already exists"
                        LblEmailNotifier.Show()
                        EmailWarningIcon.Show()
                        'Change textbox border colour to red
                        TxtEmail.BorderColor = Color.Red
                    Else
                        'Change textbox border colour to green
                        TxtEmail.BorderColor = Color.Green
                        LblEmailNotifier.Hide()
                        EmailWarningIcon.Hide()
                    End If
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub SaveCheckUsername()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SUsername = @Username AND SUsername <> @CurrentUsername "
                .Parameters.AddWithValue("@Username", TxtUsername.Text)
                .Parameters.AddWithValue("@CurrentUsername", StaffSelectedUsername)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If username not entered then
                    If TxtUsername.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtUsername.BorderColor = Color.Red
                        'Display error message
                        LblUsernameNotifier.Text = "Please enter a username"
                        LblUsernameNotifier.Show()
                        UsernameWarningIcon.Show()
                        'If record set is read then
                    ElseIf rs.Read Then
                        'Display error message
                        LblUsernameNotifier.Text = "Username not available"
                        LblUsernameNotifier.Show()
                        UsernameWarningIcon.Show()
                        'Change textbox border colour to red
                        TxtUsername.BorderColor = Color.Red
                    Else
                        'Change textbox border colour to green
                        TxtUsername.BorderColor = Color.Green
                        LblUsernameNotifier.Hide()
                        UsernameWarningIcon.Hide()
                        'Calls procedure
                        SaveStaffInfo()
                    End If
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub CheckUsername()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SUsername = @Username AND SUsername <> @CurrentUsername "
                .Parameters.AddWithValue("@Username", TxtUsername.Text)
                .Parameters.AddWithValue("@CurrentUsername", StaffSelectedUsername)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If username not entered then
                    If TxtUsername.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtUsername.BorderColor = Color.Red
                        'Display error message
                        LblUsernameNotifier.Text = "Please enter a username"
                        LblUsernameNotifier.Show()
                        UsernameWarningIcon.Show()
                        'If record set is read then
                    ElseIf rs.Read Then
                        'If username not entered then
                        LblUsernameNotifier.Text = "Username not available"
                        LblUsernameNotifier.Show()
                        UsernameWarningIcon.Show()
                        'Change textbox border colour to red
                        TxtUsername.BorderColor = Color.Red
                    Else
                        'Change textbox border colour to green
                        TxtUsername.BorderColor = Color.Green
                        LblUsernameNotifier.Hide()
                        UsernameWarningIcon.Hide()
                    End If
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub TxtFirstName_LostFocus(sender As Object, e As EventArgs) Handles TxtFirstName.LostFocus
        CheckFirstName()
    End Sub

    Private Sub TxtSurname_LostFocus(sender As Object, e As EventArgs) Handles TxtSurname.LostFocus
        CheckSurname()
    End Sub

    Private Sub TxtUsername_LostFocus(sender As Object, e As EventArgs) Handles TxtUsername.LostFocus
        CheckUsername()
    End Sub

    Private Sub TxtEmail_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail.LostFocus
        CheckEmail()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
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
        frmSetRepair.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenViewRepairs_Click(sender As Object, e As EventArgs) Handles BtnOpenViewRepairs.Click
        frmViewRepairs.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenAdmin_Click(sender As Object, e As EventArgs) Handles BtnOpenAdmin.Click
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        frmLogin.BtnClear.PerformClick()
        frmLogin.Show()
        Me.Close()
    End Sub

End Class