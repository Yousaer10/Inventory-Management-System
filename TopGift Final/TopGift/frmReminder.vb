'Represents an open connection to a data source
Imports System.Data.OleDb
'Represents timers
Imports System.Timers


Public Class frmReminder

    'The reminder ID is set to -1 to show it is a new reminder and that we are not editing a reminder
    Private CurrentReminderID As Integer = -1
    'Create new timer
    Private WithEvents time As New Timer

    Private Sub frmReminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnClear.PerformClick()
        Timer1.Enabled = True ' enable timer when form loads
        'Time interval is 1 second
        time.Interval = 1000
        'Start timer
        time.Start()
        'Display username
        LblPublicUsername.Text = PublicUsername
        HideSubMenus()
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

    Private Sub time_Elapsed(sender As Object, e As ElapsedEventArgs) Handles time.Elapsed
        'Calls procedure
        DateTimeVariable()
    End Sub

    Dim CurrentDateTime As Date
    Dim ReminderDateTime = New Date()

    Public Sub ShowNotification()
        'Display notification
        Notification.ShowBalloonTip(1000, "Reminder", "Customer Order Due!", ToolTipIcon.None)
    End Sub

    Private Sub DateTimeVariable()
        'Close database connection
        cn.Close()
        'Varibale is set to the systems current date and time
        CurrentDateTime = Date.Now
        'Format standard date and time
        CurrentDateTime = FormatDateTime(DateTime.Now, DateFormat.GeneralDate)
        ReminderDateTime = FormatDateTime(ReminderDateTime, DateFormat.GeneralDate)
        If CurrentDateTime = ReminderDateTime Then
            ShowNotification()

        Else
            'If connected to database
            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
                With SQLCmd
                    Try
                        'SQLCmd is uses the connection to save the following information
                        .Connection = cn
                        .CommandText = "SELECT ReminderDate FROM TblReminder"
                        'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                        Dim rs As OleDbDataReader = .ExecuteReader()
                        'Loops into reading a record set until it stops reading for a record so rs.Read = false
                        While rs.Read()
                            'Store latest reminder in variable
                            ReminderDateTime = rs(0)
                        End While
                        'Close database connection
                        cn.Close()
                    Catch ex As Exception
                        'Stops timer so try catch error doesn't loop
                        time.Stop()
                        'Display error message and close form if ok is clicked
                        If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) = DialogResult.OK Then
                            Me.Close()
                        End If
                    End Try
                End With
            End If
        End If

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'Empties textboxes
        LblReminderID.Text = ""
        TxtCustName.Text = ""
        TxtDeviceInfo.Text = ""
        TxtPrice.Text = ""
        DTPickerReminderDateTime.ResetText()
        'Set id = -1 sk a new reminder can be created
        CurrentReminderID = -1
    End Sub

    Private Sub BtnSetReminder_Click(sender As Object, e As EventArgs) Handles BtnSetReminder.Click
        Dim Price As Decimal
        'If nothing is entered then
        If TxtCustName.Text.Trim.Length = 0 Then
            'Display error message
            MessageBox.Show("Customer name is empty!" & vbCrLf, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCustName.Focus()
            'If nothing is entered then
        ElseIf TxtDeviceInfo.Text.Trim.Length = 0 Then
            'Display error message
            MessageBox.Show("Device Information is empty!" & vbCrLf, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtDeviceInfo.Focus()
            'If nothing is entered then
        ElseIf TxtPrice.Text.Trim.Length = 0 Then
            'Display error message
            MessageBox.Show("No price entered!" & vbCrLf, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPrice.Focus()
            'If nothing is entered then
        ElseIf Not Decimal.TryParse(TxtPrice.Text, Price) Then
            'Display error message
            MessageBox.Show("Please make sure the price is entered in the correct format. For example (10.00)" & vbCrLf, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPrice.Focus()
            'If current date and time is larger than the one in the date time picker then
        ElseIf DTPickerReminderDateTime.Text < Now Then
            'Display error message
            MessageBox.Show("Please select an appropiate date & time if it is not then the notification will not be displayed!" & vbCrLf, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If connected to database
        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            If CurrentReminderID = -1 Then
                'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
                With SQLCmd
                    'SQLCmd is uses the connection to save the following information
                    .Connection = cn
                    .CommandText = "Insert into TblReminder (CustomerName, DeviceInfo, RepairPrice, ReminderDate)"
                    .CommandText &= "Values (@CustomerName, @DeviceInfo, @RepairPrice, @ReminderDate)"
                    .Parameters.AddWithValue("@CustomerName", TxtCustName.Text)
                    .Parameters.AddWithValue("@DeviceInfo", TxtDeviceInfo.Text)
                    .Parameters.AddWithValue("@RepairPrice", TxtPrice.Text)
                    .Parameters.AddWithValue(" @ReminderDate", DTPickerReminderDateTime.Text)
                    'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                    .ExecuteNonQuery()

                    .CommandText = "Select @@Identity"
                    'ExecuteScalar - only 1 value back ie, create a new ID.
                    CurrentReminderID = .ExecuteScalar
                    LblReminderID.Text = CurrentReminderID
                    'Display informational message
                    MessageBox.Show("Reminder has been set." & vbCrLf, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Close database connection
                    cn.Close()
                End With
            End If
        End If
    End Sub

    Private Sub TxtCustName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCustName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then 'Checks if key pressed isn't a letter
            If Asc(e.KeyChar) <> Keys.Back Then 'Checks the key pressed wasn't Backspace
                e.Handled = True 'It doesn't take any further action
            End If
        End If
    End Sub

    Private Sub Notification_Click(sender As Object, e As EventArgs) Handles Notification.Click
        frmReminderInfo.Show()
    End Sub

    Private Sub Notification_BalloonTipClicked(sender As Object, e As EventArgs) Handles Notification.BalloonTipClicked
        frmReminderInfo.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Display date and time
        LblSystemDateTime.Text = Date.Now.ToString("HH:mm    dd/MM/yyyy")
    End Sub

    Private Sub HideSubMenus()
        'Hide panels
        PanelReminder.Visible = False
        PanelRepair.Visible = False

    End Sub

    Private Sub ShowSubMenus(Submenu As Panel)
        'Show panels 
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
        'Show reminder panel containing buttons for reminder forms
        ShowSubMenus(PanelReminder)
    End Sub

    Private Sub BtnOpenCreateReminder_Click(sender As Object, e As EventArgs) Handles BtnOpenCreateReminder.Click
        HideSubMenus()
    End Sub

    Private Sub BtnOpenViewReminders_Click(sender As Object, e As EventArgs) Handles BtnOpenViewReminders.Click
        frmReminderInfo.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenRepair_Click(sender As Object, e As EventArgs) Handles BtnOpenRepair.Click
        'Show repair panel containing buttons for repair forms
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
        'Closes current form and shows login form
        frmLogin.BtnClear.PerformClick()
        frmLogin.Show()
        Me.Close()
    End Sub

End Class