'Represents an open connection to a data source
Imports System.Data.OleDb
'Represents specific character patterns
Imports System.Text.RegularExpressions

Public Class frmRegister
    'The staff ID is set to -1 to show it is a new staff and that we are not editing a staff
    Private CurrentStaffID As Integer = -1

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear event is separated from UI
        ClearEvent()
        ToolTip1.SetToolTip(TxtPassword, "Password must be at least 8 Characters long & must have at least 1 Uppercase Letter (A), 1 Lowercase Letter (a), 1 Special Character (@) & 1 Number.")
        ToolTip1.SetToolTip(TxtConfirmPassword, "Password must be at least 8 Characters long & must have at least 1 Uppercase Letter (A), 1 Lowercase Letter (a), 1 Special Character (@) & 1 Number.")
    End Sub

    Private Sub ClearEvent()
        'The staff ID is set to -1 so that a new user can register
        CurrentStaffID = -1
        'Changes palce holder text to one mentiones below
        TxtStaffID.PlaceholderText = "Automatically Generated"
        'Empties the follwing textboxes and variable names
        TxtStaffID.Text = ""
        TxtFirstName.Text = ""
        TxtSurname.Text = ""
        TxtEmail.Text = ""
        TxtUsername.Text = ""
        TxtPassword.Text = ""
        TxtConfirmPassword.Text = ""
        PublicStaffID = ""
        PublicStaffName = ""
        PublicStaffSurname = ""
        'Hides password 
        CheckBoxShow.Checked = False
        'Focuses the mouse click
        TxtFirstName.Select()
        'Hides the follwing labels and picture boxes
        LblPasswordNotifier.Hide()
        PasswordWarningIcon.Hide()
        LblUsernameNotifier.Hide()
        UsernameWarningIcon.Hide()
        LblEmailNotifier.Hide()
        EmailWarningIcon.Hide()
        LblFirstNameNotifier.Hide()
        FirstNameWarningIcon.Hide()
        LblSurnameNotifier.Hide()
        SurnameWarningIcon.Hide()
        'Sets the textbox border colour to white
        TxtFirstName.BorderColor = Color.White
        TxtSurname.BorderColor = Color.White
        TxtUsername.BorderColor = Color.White
        TxtEmail.BorderColor = Color.White
        TxtPassword.BorderColor = Color.White
        TxtConfirmPassword.BorderColor = Color.White
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        'Register procedure is separated from ui
        Register()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'ClearEvent procedure is separated from ui
        ClearEvent()
    End Sub

    Private Sub Register()
        'Starts the register validation checks
        RegisterCheckFirstName()

    End Sub

    Private Sub SaveRegister()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLCcommand/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                If CurrentStaffID = -1 Then
                    '----------------------
                    'Adding a New User
                    '----------------------
                    'SQLCmd is uses the connection to save the following information
                    .Connection = cn
                    .CommandText = "Insert into TblStaff (SName, SSurname, SEmail, SUsername, SPassword, SAccessLevel)"
                    .CommandText &= "Values (@FirstName, @Surname, @Email, @Username, @Password, @AccessLevel)"
                    .Parameters.AddWithValue("@FirstName", TxtFirstName.Text)
                    .Parameters.AddWithValue("@Surname", TxtSurname.Text)
                    .Parameters.AddWithValue("@Email", TxtEmail.Text)
                    .Parameters.AddWithValue("@Username", TxtUsername.Text)
                    .Parameters.AddWithValue("@Password", TxtPassword.Text)
                    .Parameters.AddWithValue("@AccessLevel", 0)
                    'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                    .ExecuteNonQuery()

                    'Now get the auto generated ID 
                    .CommandText = "Select @@Identity"
                    'ExecuteScalar - only 1 value back ie, create a new ID.
                    CurrentStaffID = .ExecuteScalar
                    'Empties the following textboxes and stores into variables
                    TxtStaffID.Text = ""
                    TxtStaffID.PlaceholderText = ""
                    TxtStaffID.Text = CurrentStaffID
                    'Display Messagebox
                    MessageBox.Show("You have been registered.                                                             Please note down your Email, it will be required if you forget your Username or Password. " & vbCrLf, "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Close database connection
                    cn.Close()
                End If
            End With
        End If
    End Sub

    Private Sub RegisterCheckEmail()
        Dim ValidEmail As String
        'Stores email in variable
        ValidEmail = TxtEmail.Text
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLCcommand/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SEmail = @StaffEmail"
                .Parameters.AddWithValue("@StaffEmail", TxtEmail.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If email textbox is empty then
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
                        'If email is not in correct format then
                    ElseIf IsValidEmailFormat(ValidEmail) = False Then
                        'Display error message
                        LblEmailNotifier.Text = "Please enter the email in the correct format!(e.g. something123@gmail.com)"
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
                        RegisterCheckUsername()
                    End If
                    'Stop reading record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
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
            'We can use the With SQLCcommand/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SEmail = @StaffEmail"
                .Parameters.AddWithValue("@StaffEmail", TxtEmail.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If email textbox is empty then
                    If TxtEmail.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtEmail.BorderColor = Color.Red
                        'Display error message
                        LblEmailNotifier.Text = "Please enter an email"
                        LblEmailNotifier.Show()
                        EmailWarningIcon.Show()
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
                    'Stop reading record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub RegisterCheckUsername()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLCcommand/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SUsername = @Username"
                .Parameters.AddWithValue("@Username", TxtUsername.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If no username is entered then
                    If TxtUsername.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtUsername.BorderColor = Color.Red
                        'Display warning message
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
                        RegisterCheckPassword()
                    End If
                    'Stop reading record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
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
            'We can use the With SQLCcommand/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SUsername = @Username"
                .Parameters.AddWithValue("@Username", TxtUsername.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If no username is entered then
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
                    End If
                    'Stop reading record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub RegisterCheckPassword()
        Dim strPwd As String
        strPwd = TxtPassword.Text 'textbox containing password

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLCcommand/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SPassword = @Password"
                .Parameters.AddWithValue("@Password", TxtPassword.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If both passwords not entered then
                    If TxtPassword.Text.Length < 1 Or TxtConfirmPassword.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtPassword.BorderColor = Color.Red
                        TxtConfirmPassword.BorderColor = Color.Red
                        'Display error message
                        LblPasswordNotifier.Text = "Please enter a password"
                        LblPasswordNotifier.Show()
                        PasswordWarningIcon.Show()
                    ElseIf rs.Read Then
                        'Display error message
                        LblPasswordNotifier.Text = "Password already taken"
                        LblPasswordNotifier.Show()
                        PasswordWarningIcon.Show()
                        'Change textbox border colour to red
                        TxtPassword.BorderColor = Color.Red
                        TxtConfirmPassword.BorderColor = Color.Red
                        'If password doesn't pass validation check then
                    ElseIf ValidatePassword(strPwd) = False Then
                        'Display error message
                        LblPasswordNotifier.Text = "Password is invalid. Please try again."
                        LblPasswordNotifier.Show()
                        PasswordWarningIcon.Show()
                        'Change textbox border colour to red
                        TxtPassword.BorderColor = Color.Red
                        TxtConfirmPassword.BorderColor = Color.Red

                    ElseIf TxtPassword.Text <> TxtConfirmPassword.Text Then
                        'Display error message
                        LblPasswordNotifier.Text = "Both passwords do not match"
                        LblPasswordNotifier.Show()
                        PasswordWarningIcon.Show()
                        'Change textbox border colour to red
                        TxtPassword.BorderColor = Color.Red
                        TxtConfirmPassword.BorderColor = Color.Red
                    Else
                        'Change textbox border colour to green
                        TxtPassword.BorderColor = Color.Green
                        TxtConfirmPassword.BorderColor = Color.Green
                        LblPasswordNotifier.Hide()
                        PasswordWarningIcon.Hide()
                        'Calls procedure
                        SaveRegister()
                    End If
                    'Stop reading record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub CheckPassword()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLCcommand/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SPassword = @Password"
                .Parameters.AddWithValue("@Password", TxtPassword.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If both passwords not entered then
                    If TxtPassword.Text.Length < 1 Or TxtConfirmPassword.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtPassword.BorderColor = Color.Red
                        TxtConfirmPassword.BorderColor = Color.Red
                        'Display error message
                        LblPasswordNotifier.Text = "Please enter a password"
                        LblPasswordNotifier.Show()
                        PasswordWarningIcon.Show()
                    ElseIf rs.Read Then
                        'Display error message
                        LblPasswordNotifier.Text = "Password already taken"
                        LblPasswordNotifier.Show()
                        PasswordWarningIcon.Show()
                        'Change textbox border colour to red
                        TxtPassword.BorderColor = Color.Red
                        TxtConfirmPassword.BorderColor = Color.Red
                    Else
                        'Change textbox border colour to green
                        TxtPassword.BorderColor = Color.Green
                        TxtConfirmPassword.BorderColor = Color.Green
                        LblPasswordNotifier.Hide()
                        PasswordWarningIcon.Hide()
                    End If
                    'Stop reading record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        'Check if email matches the standard pattern
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function

    Function ValidatePassword(ByVal pwd As String,
        Optional ByVal minLength As Integer = 8,
        Optional ByVal numUpper As Integer = 1,
        Optional ByVal numLower As Integer = 1,
        Optional ByVal numNumbers As Integer = 1,
        Optional ByVal numSpecial As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Private Sub TxtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFirstName.KeyPress, MyBase.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then 'Checks if key pressed isn't a digit
            If Asc(e.KeyChar) <> Keys.Back Then 'Checks the key pressed wasn't Backspace
                e.Handled = True 'It doesn't take any further action
            End If
        End If
    End Sub

    Private Sub TxtSurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSurname.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then 'Checks if key pressed isn't a digit
            If Asc(e.KeyChar) <> Keys.Back Then 'Checks the key pressed wasn't Backspace
                e.Handled = True 'It doesn't take any further action
            End If
        End If
    End Sub

    Private Sub CheckBoxShow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShow.CheckedChanged
        'If checkbox is checked then hide passwords
        If CheckBoxShow.Checked = True Then
            TxtPassword.UseSystemPasswordChar = False
            TxtConfirmPassword.UseSystemPasswordChar = False
        Else
            'Show passwords if not checked
            TxtPassword.UseSystemPasswordChar = True
            TxtConfirmPassword.UseSystemPasswordChar = True
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

    Private Sub RegisterCheckFirstName()
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
            'Calls procedure
            RegisterCheckSurname()
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

    Private Sub RegisterCheckSurname()
        'If surname not entered then
        If TxtSurname.Text.Length < 1 Then
            'Display error message
            LblSurnameNotifier.Show()
            SurnameWarningIcon.Show()
            TxtSurname.BorderColor = Color.Red
            'If surname entered then
        ElseIf TxtSurname.Text.Length > 0 Then
            LblSurnameNotifier.Hide()
            SurnameWarningIcon.Hide()
            'Change textbox border colour to green
            TxtSurname.BorderColor = Color.Green
            'Calls procedure
            RegisterCheckEmail()
        End If
    End Sub

    'All sub routines containing validation checks below and are triggered when textboxes loose focus
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

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        CheckPassword()
    End Sub

    Private Sub TxtConfirmPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtConfirmPassword.LostFocus
        CheckPassword()
    End Sub

End Class