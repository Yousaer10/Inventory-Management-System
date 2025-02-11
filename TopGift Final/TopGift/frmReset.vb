'Represents an open connection to a data source
Imports System.Data.OleDb

Public Class frmReset
    Dim strPwd As String

    Private Sub ClearPassword()
        'Empty password textbox
        TxtNewPassword.Text = ""
        TxtConfirmNewPassword.Text = ""
        LblPasswordNotifier1.Hide()
        PasswordWarningIcon1.Hide()
        LblPasswordNotifier2.Hide()
        PasswordWarningIcon2.Hide()
        'Change textbox border colour to white
        TxtNewPassword.BorderColor = Color.White
        TxtConfirmNewPassword.BorderColor = Color.White
        'Hide password
        CheckBoxShow.Checked = False
        TxtNewPassword.Focus()
    End Sub

    Private Sub UpdatePassword()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Update TblStaff Set SPassword = @Password where SEmail = @CurrentStaffEmail "
                .Parameters.AddWithValue("@Password", TxtNewPassword.Text)
                .Parameters.AddWithValue("@SEmail", LblCurrentStaffEmail.Text)
                'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                .ExecuteNonQuery()
                MessageBox.Show("Password has been Changed." & vbCrLf, "Check Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub TxtConfirmNewPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            BtnPasswordConfirm.PerformClick()
        End If
    End Sub

    Private Sub UpdateUsername()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Update TblStaff Set SUsername = @Username where SEmail = @CurrentStaffEmail "
                .Parameters.AddWithValue("@Username", TxtNewUsername.Text)
                .Parameters.AddWithValue("@SEmail", LblCurrentStaffEmail.Text)
                'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                .ExecuteNonQuery()
                MessageBox.Show("Username has been Changed." & vbCrLf, "Check Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub ClearUsername()
        'Empties username textboxes
        TxtNewUsername.Text = ""
        TxtConfirmNewUsername.Text = ""
        LblUsernameNotifier1.Hide()
        UsernameWarningIcon1.Hide()
        LblUsernameNotifier2.Hide()
        UsernameWarningIcon2.Hide()
        ''Change textbox border colour to white
        TxtNewUsername.BorderColor = Color.White
        TxtConfirmNewUsername.BorderColor = Color.White
        TxtNewUsername.Focus()
    End Sub

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

    'The 2 sub routines containing validation checks below and are triggered when a button is clicked
    Private Sub BtnPasswordConfirm_Click(sender As Object, e As EventArgs) Handles BtnPasswordConfirm.Click
        ConfirmCheckPassword()
    End Sub

    Private Sub BtnUsernameConfirm_Click(sender As Object, e As EventArgs) Handles BtnUsernameConfirm.Click
        ConfirmCheckUsername()
    End Sub

    'The 2 sub routines below call the clear procedures and are triggered when clear button is clicked
    Private Sub BtnPasswordClear_Click(sender As Object, e As EventArgs) Handles BtnPasswordClear.Click
        ClearPassword()
    End Sub

    Private Sub BtnUsernameClear_Click(sender As Object, e As EventArgs) Handles BtnUsernameClear.Click
        ClearUsername()
    End Sub

    Private Sub CheckBoxShow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShow.CheckedChanged
        'If checkbox is checked then hide passwords
        If CheckBoxShow.Checked = True Then
            TxtNewPassword.UseSystemPasswordChar = False
            TxtConfirmNewPassword.UseSystemPasswordChar = False
        Else
            'Show passwords if not checked
            TxtNewPassword.UseSystemPasswordChar = True
            TxtConfirmNewPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckPassword()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SPassword = @Password"
                .Parameters.AddWithValue("@Password", TxtNewPassword.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If password not entered then
                    If TxtNewPassword.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtNewPassword.BorderColor = Color.Red
                        'Display error message
                        LblPasswordNotifier1.Text = "Please create a password"
                        LblPasswordNotifier1.Show()
                        PasswordWarningIcon1.Show()
                        'If password is not confirmed then
                    ElseIf TxtConfirmNewPassword.Text.Length < 1 And TxtNewPassword.Text.Length > 1 Then
                        'Change textbox border colour to red
                        TxtConfirmNewPassword.BorderColor = Color.Red
                        'Display error message
                        LblPasswordNotifier2.Text = "Please confirm the password"
                        LblPasswordNotifier2.Show()
                        PasswordWarningIcon2.Show()
                        'Change textbox border colour to green
                        TxtNewPassword.BorderColor = Color.Green
                        LblPasswordNotifier1.Hide()
                        PasswordWarningIcon1.Hide()
                        'If record set is read then
                    ElseIf rs.Read Then
                        'Display error message
                        LblPasswordNotifier1.Text = "Password already taken"
                        LblPasswordNotifier1.Show()
                        PasswordWarningIcon1.Show()
                        LblPasswordNotifier2.Text = "Password already taken"
                        LblPasswordNotifier2.Show()
                        PasswordWarningIcon2.Show()
                        'Change textbox border colour to red
                        TxtNewPassword.BorderColor = Color.Red
                        TxtConfirmNewPassword.BorderColor = Color.Red
                    Else
                        'Change textbox border colour to green
                        TxtNewPassword.BorderColor = Color.Green
                        TxtConfirmNewPassword.BorderColor = Color.Green
                        LblPasswordNotifier1.Hide()
                        PasswordWarningIcon1.Hide()
                        LblPasswordNotifier2.Hide()
                        PasswordWarningIcon2.Hide()
                    End If
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub ConfirmCheckPassword()
        Dim strPwd As String
        strPwd = TxtNewPassword.Text 'textbox containing password
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SPassword = @Password"
                .Parameters.AddWithValue("@Password", TxtNewPassword.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If password not entered then
                    If TxtNewPassword.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtNewPassword.BorderColor = Color.Red
                        'Display error message
                        LblPasswordNotifier1.Text = "Please create a password"
                        LblPasswordNotifier1.Show()
                        PasswordWarningIcon1.Show()
                        'If password not entered then
                    ElseIf TxtConfirmNewPassword.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtConfirmNewPassword.BorderColor = Color.Red
                        'Display error message
                        LblPasswordNotifier2.Text = "Please confirm the password"
                        LblPasswordNotifier2.Show()
                        PasswordWarningIcon2.Show()
                        'If record set is read then
                    ElseIf rs.Read Then
                        'Display error message
                        LblPasswordNotifier1.Text = "Password already taken"
                        LblPasswordNotifier1.Show()
                        PasswordWarningIcon1.Show()
                        LblPasswordNotifier2.Text = "Password already taken"
                        LblPasswordNotifier2.Show()
                        PasswordWarningIcon2.Show()
                        'Change textbox border colour to red
                        TxtNewPassword.BorderColor = Color.Red
                        TxtConfirmNewPassword.BorderColor = Color.Red
                        'If password doesn't pass validation check then
                    ElseIf ValidatePassword(strPwd) = False Then
                        'Display error message
                        MessageBox.Show("Password must be at least 8 Characters long & must have at least 1 Uppercase Letter (A), 1 Lowercase Letter (a), 1 Special Character (@) & 1 Number." & vbCrLf, "Check Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        'Change textbox border colour to red
                        TxtNewPassword.BorderColor = Color.Red
                        TxtConfirmNewPassword.BorderColor = Color.Red
                        'If both passwords don't match then
                    ElseIf TxtNewPassword.Text <> TxtConfirmNewPassword.Text Then
                        'Change textbox border colour to red
                        TxtNewPassword.BorderColor = Color.Red
                        'Display error message
                        LblPasswordNotifier1.Text = "Both passwords do not match"
                        LblPasswordNotifier1.Show()
                        PasswordWarningIcon1.Show()
                        'Change textbox border colour to red
                        TxtConfirmNewPassword.BorderColor = Color.Red
                        'Display error message
                        LblPasswordNotifier2.Text = "Both passwords do not match"
                        LblPasswordNotifier2.Show()
                        PasswordWarningIcon2.Show()
                    Else
                        'Change textbox border colour to green
                        TxtNewPassword.BorderColor = Color.Green
                        TxtConfirmNewPassword.BorderColor = Color.Green
                        LblPasswordNotifier1.Hide()
                        PasswordWarningIcon1.Hide()
                        LblPasswordNotifier2.Hide()
                        PasswordWarningIcon2.Hide()
                        'Calls procedure
                        UpdatePassword()
                    End If
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
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
                .CommandText = "Select * From TblStaff Where SUsername = @Username"
                .Parameters.AddWithValue("@Username", TxtNewUsername.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If username not entered then
                    If TxtNewUsername.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtNewUsername.BorderColor = Color.Red
                        'Display error message
                        LblUsernameNotifier1.Text = "Please create a username"
                        LblUsernameNotifier1.Show()
                        UsernameWarningIcon1.Show()
                        'If username not confirmed entered then
                    ElseIf TxtConfirmNewUsername.Text.Length < 1 And TxtNewUsername.Text.Length > 1 Then
                        'Change textbox border colour to red
                        TxtConfirmNewUsername.BorderColor = Color.Red
                        'Display error message
                        LblUsernameNotifier2.Text = "Please confirm the username"
                        LblUsernameNotifier2.Show()
                        UsernameWarningIcon2.Show()
                        'Change textbox border colour to green
                        TxtNewUsername.BorderColor = Color.Green
                        LblUsernameNotifier1.Hide()
                        UsernameWarningIcon1.Hide()
                        'If record set is read then
                    ElseIf rs.Read Then
                        'Display error message
                        LblUsernameNotifier1.Text = "Username not available"
                        LblUsernameNotifier1.Show()
                        UsernameWarningIcon1.Show()
                        LblUsernameNotifier2.Text = "Username not available"
                        LblUsernameNotifier2.Show()
                        UsernameWarningIcon2.Show()
                        'Change textbox border colour to red
                        TxtNewUsername.BorderColor = Color.Red
                        TxtConfirmNewUsername.BorderColor = Color.Red
                    Else
                        'Change textbox border colour to green
                        TxtNewUsername.BorderColor = Color.Green
                        LblUsernameNotifier1.Hide()
                        UsernameWarningIcon1.Hide()
                        'Change textbox border colour to green
                        TxtConfirmNewUsername.BorderColor = Color.Green
                        LblUsernameNotifier2.Hide()
                        UsernameWarningIcon2.Hide()
                    End If
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub ConfirmCheckUsername()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SUsername = @Username"
                .Parameters.AddWithValue("@Username", TxtNewUsername.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If username not entered then
                    If TxtNewUsername.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtNewUsername.BorderColor = Color.Red
                        'Display error message
                        LblUsernameNotifier1.Text = "Please create a username"
                        LblUsernameNotifier1.Show()
                        UsernameWarningIcon1.Show()
                        'If username not confirmed then
                    ElseIf TxtConfirmNewUsername.Text.Length < 1 Then
                        'Change textbox border colour to red
                        TxtConfirmNewUsername.BorderColor = Color.Red
                        'Display error message
                        LblUsernameNotifier2.Text = "Please confirm the username"
                        LblUsernameNotifier2.Show()
                        UsernameWarningIcon2.Show()
                        'If record set is read then
                    ElseIf rs.Read Then
                        'Display error message
                        LblUsernameNotifier1.Text = "Username not available"
                        LblUsernameNotifier1.Show()
                        UsernameWarningIcon1.Show()
                        'Change textbox border colour to red
                        TxtNewUsername.BorderColor = Color.Red
                        'Display error message
                        LblUsernameNotifier2.Text = "Username not available"
                        LblUsernameNotifier2.Show()
                        UsernameWarningIcon2.Show()
                        'Change textbox border colour to red
                        TxtConfirmNewUsername.BorderColor = Color.Red
                        'If usernames don't match then
                    ElseIf TxtNewUsername.Text <> TxtConfirmNewUsername.Text Then
                        'Change textbox border colour to red
                        TxtNewUsername.BorderColor = Color.Red
                        'Display error message
                        LblUsernameNotifier1.Text = "Both usernames do not match"
                        LblUsernameNotifier1.Show()
                        UsernameWarningIcon1.Show()
                        'Change textbox border colour to red
                        TxtConfirmNewUsername.BorderColor = Color.Red
                        'Display error message
                        LblUsernameNotifier2.Text = "Both usernames do not match"
                        LblUsernameNotifier2.Show()
                        UsernameWarningIcon2.Show()
                    Else
                        'Change textbox border colour to green
                        TxtNewUsername.BorderColor = Color.Green
                        LblUsernameNotifier1.Hide()
                        UsernameWarningIcon1.Hide()
                        'Change textbox border colour to green
                        TxtConfirmNewUsername.BorderColor = Color.Green
                        LblUsernameNotifier2.Hide()
                        UsernameWarningIcon2.Hide()
                        'Calls procedure
                        UpdateUsername()
                    End If
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    'All sub routines containing validation checks below and are triggered when textboxes loose focus
    Private Sub TxtNewUsername_LostFocus(sender As Object, e As EventArgs) Handles TxtNewUsername.LostFocus
        CheckUsername()
    End Sub

    Private Sub TxtConfirmNewUsername_LostFocus(sender As Object, e As EventArgs) Handles TxtConfirmNewUsername.LostFocus
        CheckUsername()
    End Sub

    Private Sub TxtNewPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtNewPassword.LostFocus
        CheckPassword()
    End Sub

    Private Sub TxtConfirmNewPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtConfirmNewPassword.LostFocus
        CheckPassword()
    End Sub
End Class