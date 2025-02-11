'Represents an open connection to a data source
Imports System.Data.OleDb

Public Class frmLogin
    Dim Attempt As Integer = 4
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When form loads BtnClear is performed
        BtnClear.PerformClick()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'The clearing event is separated from UI
        CallClear()
    End Sub

    Private Sub CallClear()
        'This sub procedure makes sure that the form is ready for use
        txtUsername.Focus()
        PublicStaffID = ""
        PublicStaffName = ""
        PublicStaffSurname = ""
        PublicReminderID = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        PublicReminderID = ""
        frmInventory.Close()
        frmMainMenu.Close()
        CheckBoxShow.Checked = False
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        'Login event is seperated from UI
        CallLogin()
    End Sub

    Private Sub CallLogin()

        Dim str_user, str_pass As String
        'If connected to database
        If DbConnect() Then

            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLCcommand/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                'Adding a User...
                .CommandText = "Select * from Tblstaff Where (SUsername = @Staffusername) and (SPassword = @Staffpassword)"
                .Parameters.AddWithValue("@StaffUsername", txtUsername.Text)
                .Parameters.AddWithValue("@StaffPassword", txtPassword.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If record set is read then
                    If rs.Read Then
                        'Converts the password coming from the database to a string and stores it in a variable
                        str_pass = rs.Item("SPassword").ToString
                        'Converts the username coming from the database to a string and stores it in a variable
                        str_user = rs.Item("SUsername").ToString
                        'Stores the user's name in a public variable
                        PublicStaffName = rs("SName")
                        'Stores the user's staff id in a public variable
                        PublicStaffID = rs("StaffID")
                        'Stores the user's access level in a public variable
                        PublicAccessLevel = rs("SAccessLevel")
                        'Stores the user's username in a public variable
                        PublicUsername = rs("SUsername")
                    End If
                    'Stop reading record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
        'If username textbox is empty then displays an error message
        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter a username" & vbCrLf, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If password texbox is empty then displays an error message
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter a password" & vbCrLf, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If user has 3 failed attempts then disable login button
        ElseIf Attempt = 1 Then
            'Disable login button
            BtnLogin.Enabled = False
            Attempt = 3
            'Enable timer and start it
            LoginTimer.Enabled = True
            LoginTimer.Start()
            'Notify user
            MessageBox.Show("Login locked for 30 seconds. Please try again later." & vbCrLf, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'If usernme and password entered don't match to the ones stored in the variables thn display error message
        ElseIf (str_user <> txtUsername.Text) Or (str_pass <> txtPassword.Text) Then
            Attempt = Attempt - 1
            'Display error message
            MessageBox.Show("Sorry, incorrect log in details entered. Attempts left : " + Attempt.ToString & vbCrLf, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()

            'Username and password are caps lock sensitive
        ElseIf StrComp(txtUsername.Text, str_user, CompareMethod.Binary) Or StrComp(txtPassword.Text, str_pass, CompareMethod.Binary) Then
            Attempt = Attempt - 1
            'Display error message
            MessageBox.Show("Sorry, incorrect log in details entered. Attempts left : " + Attempt.ToString & vbCrLf, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            'Open menu form
            frmMainMenu.Show()
            'Minimises login form
            Me.Hide()
            Attempt = 3
        End If

    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        'When enter button is clicked BtnLogin is performed
        If e.KeyCode = Keys.Enter Then
            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub CheckBoxShow_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxShow.CheckedChanged
        'If checkbox is checked then hide password
        If CheckBoxShow.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            'Show password if not checked
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        'Open Verification form
        frmSendCode.Show()
        'Minimises login form
        Me.Hide()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        'Open register form
        frmRegister.Show()
        'Minimises login form
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'Close application
        Application.Exit()
    End Sub

    Private Sub LoginTimer_Tick(sender As Object, e As EventArgs) Handles LoginTimer.Tick
        BtnLogin.Enabled = True
        LoginTimer.Stop()
        LoginTimer.Enabled = False
    End Sub

End Class

