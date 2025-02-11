'Represents an open connection to a data source
Imports System.Data.OleDb
'Represents an open internet connection
Imports System.Net
'Represents an open internet connection to email services
Imports System.Net.Mail

Public Class frmSendCode

    Private Sub frmSendCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Empties textboxes
        TxtEmail.Text = ""
        TxtCodeVerify.Text = ""
        'Disable verify button to avoid errors
        BtnVerify.Enabled = False
    End Sub

    Dim verified As Boolean = False
    Dim randomCode As String
    Public Shared toUser As String

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        'Calls procedure
        SendEmail()
    End Sub

    Private Sub BtnVerify_Click(sender As Object, e As EventArgs) Handles BtnVerify.Click
        'If security code is correct then show reset form
        If (TxtCodeVerify.Text.Equals(randomCode)) Then
            toUser = TxtEmail.Text
            frmReset.Show()
            'Send copy user's email to reset form
            frmReset.LblCurrentStaffEmail.Text = Me.TxtEmail.Text
            Me.Close()
        Else
            'Display error message
            MessageBox.Show("Code entered is invalid" & vbCrLf, "Verify Code", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub SendEmail()
        'If no email entered then
        If TxtEmail.Text = "" Then
            'Display error message
            MessageBox.Show("Please enter an Email!" & vbCrLf, "Verify Email", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            TxtEmail.Focus()
        Else
            'Calls procedure
            VerifyEmail()
            'If user is verified then check for internet connection
            If verified Then
                CheckNetworkConnection()
            Else
                'Display error message
                MessageBox.Show("Sorry, incorrect email entered." & vbCrLf, "Verify Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub CheckNetworkConnection()
        'If computer is has an internet connection then
        If My.Computer.Network.IsAvailable Then
            'Send Email procedure
            EmailProtocol()
        Else
            'Display error message
            MessageBox.Show("No internet connection! Please make sure you are connected to a network." & vbCrLf, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub EmailProtocol()
        'Display informational message
        MessageBox.Show("User has been Verified." & vbCrLf, "User Verified", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim from, pass, messageBody As String
        Dim rand As Random = New Random()
        'Generate random security code
        randomCode = (rand.Next(999999)).ToString()
        Dim message As MailMessage = New MailMessage()
        'Recpient's email
        toUser = TxtEmail.Text
        'Email is sent to user through the email below
        from = "automatedcode1@gmail.com"
        'This is the password that is used to login into the google account
        pass = "Qaz135wsx"
        'Content of the email
        messageBody = "Your reset code is : " + randomCode
        'Message is sent to the user's email
        message.To.Add(toUser)
        'From automatedcode1@gmail.com
        message.From = New MailAddress(from)
        'Contents of email are added
        message.Body = messageBody
        'Email subject
        message.Subject = "Password reset code"
        'Email is sent using SMTP protocol
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        'Encryption is enabled for secure sending
        smtp.EnableSsl = True
        'Gmail's SMTP port is 587
        smtp.Port = 587
        'Delivery method is through SMTP
        smtp.DeliveryMethod = smtp.DeliveryMethod.Network
        'Automatic login to gmail account mentioned above
        smtp.Credentials = New NetworkCredential(from, pass)
        'Tries sending email and notifies user
        Try
            smtp.Send(message)
            MessageBox.Show("Code Sent! Please check your Email Inbox & Spam Inbox!                    If you did not receive an email please check that the email that you entered is correct." & vbCrLf, "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'If error occurs then display error message
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        TxtCodeVerify.Focus()
        'Enabled verify button
        BtnVerify.Enabled = True
    End Sub

    Private Sub TxtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmail.KeyDown
        'If enter is clicked then email is sent
        If e.KeyCode = Keys.Enter Then
            BtnSend.PerformClick()
        End If
    End Sub

    Private Sub TxtVerify_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodeVerify.KeyDown
        'If enter is clicked then security verification takes place
        If e.KeyCode = Keys.Enter Then
            BtnVerify.PerformClick()
        End If
    End Sub

    Private Sub VerifyEmail()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStaff Where SEmail = @StaffEmail"
                .Parameters.AddWithValue("@StaffEmail", TxtEmail.Text)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'If record set is read then
                    If rs.Read Then
                        TxtCodeVerify.Focus()
                        'Enable send button
                        BtnSend.Enabled = True
                        'User has been verified
                        verified = True
                    Else
                        'User has not been verified and clear email textbox
                        TxtEmail.Text = ""
                        TxtEmail.Focus()
                        verified = False
                    End If
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Verification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub TxtVerify_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Then 'Checks if key pressed isn't a digit
            If Asc(e.KeyChar) <> Keys.Back Then 'Checks the key pressed wasn't Backspace
                e.Handled = True 'It doesn't take any further action
            End If
        End If
    End Sub

    Private Sub BtnBackToLogin_Click(sender As Object, e As EventArgs) Handles BtnBackToLogin.Click
        Me.Close()
        frmLogin.Show()
    End Sub

End Class

