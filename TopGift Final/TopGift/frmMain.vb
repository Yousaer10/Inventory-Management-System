Public Class frmMainMenu

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When form loads it checks the user access levels
        CheckAccessLevel()
    End Sub

    Private Sub CheckAccessLevel()
        'If access level is 0 then disable the follwing buttons
        If PublicAccessLevel = 0 Then
            BtnReminders.Enabled = False
            BtnViewReminders.Enabled = False
            BtnInventory.Enabled = False
            BtnSetRepairs.Enabled = False
            BtnViewRepairs.Enabled = False
            BtnAdmin.Enabled = False
            'If access level is 1 then disable the follwing buttons
        ElseIf PublicAccessLevel = 1 Then
            BtnReminders.Enabled = False
            BtnViewReminders.Enabled = False
            BtnInventory.Enabled = False
            BtnSetRepairs.Enabled = False
            BtnViewRepairs.Enabled = True
            BtnAdmin.Enabled = False
            'If access level is 2 then disable the follwing buttons
        ElseIf PublicAccessLevel = 2 Then
            BtnReminders.Enabled = True
            BtnInventory.Enabled = True
            BtnSetRepairs.Enabled = True
            BtnViewRepairs.Enabled = True
            BtnAdmin.Enabled = False
            'If access level is 3 then disable the follwing buttons
        ElseIf PublicAccessLevel = 3 Then
            BtnReminders.Enabled = True
            BtnInventory.Enabled = True
            BtnSetRepairs.Enabled = True
            BtnViewRepairs.Enabled = True
            BtnAdmin.Enabled = True
        End If
    End Sub

    Private Sub BtnReminders_Click(sender As Object, e As EventArgs) Handles BtnReminders.Click
        'Show reminder form
        frmReminder.Show()
        'Close menu form
        Me.Close()
    End Sub

    Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles BtnInventory.Click
        'Show inventory form
        frmInventory.Show()
        'Close menu form
        Me.Close()
    End Sub

    Private Sub BtnSetRepairs_Click(sender As Object, e As EventArgs) Handles BtnSetRepairs.Click
        'Show set repairs inventory form
        frmSetRepair.Show()
        'Close menu form
        Me.Close()
    End Sub

    Private Sub BtnViewRepairs_Click(sender As Object, e As EventArgs) Handles BtnViewRepairs.Click
        'Show view repairs form
        frmViewRepairs.Show()
        'Close menu form
        Me.Close()
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        'Show admin form
        frmAdmin.Show()
        'Close menu form
        Me.Close()
    End Sub

    Private Sub BtnViewReminders_Click(sender As Object, e As EventArgs) Handles BtnViewReminders.Click
        'Show view reminder form
        frmReminderInfo.Show()
        'Close menu form
        Me.Close()
    End Sub

End Class