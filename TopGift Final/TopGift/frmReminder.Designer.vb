<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReminder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReminder))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.LblReminderID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.TxtDeviceInfo = New System.Windows.Forms.TextBox()
        Me.TxtCustName = New System.Windows.Forms.TextBox()
        Me.DTPickerReminderDateTime = New System.Windows.Forms.DateTimePicker()
        Me.BtnSetReminder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Notification = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblSystemDateTime = New System.Windows.Forms.Label()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.BtnOpenAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelRepair = New System.Windows.Forms.Panel()
        Me.BtnOpenViewRepairs = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnOpenSetRepairs = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnOpenRepair = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelReminder = New System.Windows.Forms.Panel()
        Me.BtnOpenViewReminders = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnOpenCreateReminder = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnOpenReminder = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnOpenInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelDateTime = New Guna.UI2.WinForms.Guna2Panel()
        Me.PanelUsername = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblPublicUsername = New System.Windows.Forms.Label()
        Me.BtnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelRepair.SuspendLayout()
        Me.PanelReminder.SuspendLayout()
        Me.PanelDateTime.SuspendLayout()
        Me.PanelUsername.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChildForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(349, 353)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 25)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "£"
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Black
        Me.BtnClear.Location = New System.Drawing.Point(395, 475)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(116, 31)
        Me.BtnClear.TabIndex = 30
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'LblReminderID
        '
        Me.LblReminderID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblReminderID.AutoSize = True
        Me.LblReminderID.BackColor = System.Drawing.Color.Transparent
        Me.LblReminderID.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReminderID.ForeColor = System.Drawing.Color.White
        Me.LblReminderID.Location = New System.Drawing.Point(340, 184)
        Me.LblReminderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblReminderID.Name = "LblReminderID"
        Me.LblReminderID.Size = New System.Drawing.Size(67, 25)
        Me.LblReminderID.TabIndex = 29
        Me.LblReminderID.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(188, 184)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Reminder ID:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(189, 353)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 25)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Price of Repair:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(189, 296)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Device Information:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(189, 239)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Customer Name:"
        '
        'TxtPrice
        '
        Me.TxtPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPrice.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrice.Location = New System.Drawing.Point(375, 353)
        Me.TxtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(132, 25)
        Me.TxtPrice.TabIndex = 24
        '
        'TxtDeviceInfo
        '
        Me.TxtDeviceInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDeviceInfo.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeviceInfo.Location = New System.Drawing.Point(375, 296)
        Me.TxtDeviceInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDeviceInfo.Name = "TxtDeviceInfo"
        Me.TxtDeviceInfo.Size = New System.Drawing.Size(233, 25)
        Me.TxtDeviceInfo.TabIndex = 23
        '
        'TxtCustName
        '
        Me.TxtCustName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCustName.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustName.Location = New System.Drawing.Point(375, 239)
        Me.TxtCustName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCustName.Name = "TxtCustName"
        Me.TxtCustName.Size = New System.Drawing.Size(132, 25)
        Me.TxtCustName.TabIndex = 22
        '
        'DTPickerReminderDateTime
        '
        Me.DTPickerReminderDateTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTPickerReminderDateTime.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DTPickerReminderDateTime.CalendarTitleForeColor = System.Drawing.Color.White
        Me.DTPickerReminderDateTime.CustomFormat = "dd/MM/yyyy      HH:mm"
        Me.DTPickerReminderDateTime.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerReminderDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPickerReminderDateTime.Location = New System.Drawing.Point(193, 411)
        Me.DTPickerReminderDateTime.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPickerReminderDateTime.Name = "DTPickerReminderDateTime"
        Me.DTPickerReminderDateTime.Size = New System.Drawing.Size(313, 25)
        Me.DTPickerReminderDateTime.TabIndex = 21
        Me.DTPickerReminderDateTime.Value = New Date(2021, 10, 2, 0, 0, 0, 0)
        '
        'BtnSetReminder
        '
        Me.BtnSetReminder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSetReminder.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetReminder.ForeColor = System.Drawing.Color.Black
        Me.BtnSetReminder.Location = New System.Drawing.Point(167, 472)
        Me.BtnSetReminder.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSetReminder.Name = "BtnSetReminder"
        Me.BtnSetReminder.Size = New System.Drawing.Size(152, 34)
        Me.BtnSetReminder.TabIndex = 20
        Me.BtnSetReminder.Text = "Set Reminder"
        Me.BtnSetReminder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(188, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 32)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Enter Reminder Information"
        '
        'Notification
        '
        Me.Notification.Icon = CType(resources.GetObject("Notification.Icon"), System.Drawing.Icon)
        Me.Notification.Text = "Notification"
        Me.Notification.Visible = True
        '
        'Timer1
        '
        '
        'LblSystemDateTime
        '
        Me.LblSystemDateTime.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSystemDateTime.AutoSize = True
        Me.LblSystemDateTime.BackColor = System.Drawing.Color.Transparent
        Me.LblSystemDateTime.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSystemDateTime.ForeColor = System.Drawing.Color.White
        Me.LblSystemDateTime.Location = New System.Drawing.Point(35, 14)
        Me.LblSystemDateTime.Name = "LblSystemDateTime"
        Me.LblSystemDateTime.Size = New System.Drawing.Size(185, 25)
        Me.LblSystemDateTime.TabIndex = 34
        Me.LblSystemDateTime.Text = "09:00    01/01/2022"
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.BtnOpenAdmin)
        Me.PanelSideMenu.Controls.Add(Me.PanelRepair)
        Me.PanelSideMenu.Controls.Add(Me.BtnOpenRepair)
        Me.PanelSideMenu.Controls.Add(Me.PanelReminder)
        Me.PanelSideMenu.Controls.Add(Me.BtnOpenReminder)
        Me.PanelSideMenu.Controls.Add(Me.BtnOpenInventory)
        Me.PanelSideMenu.Controls.Add(Me.PanelDateTime)
        Me.PanelSideMenu.Controls.Add(Me.PanelUsername)
        Me.PanelSideMenu.Controls.Add(Me.BtnLogout)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(256, 713)
        Me.PanelSideMenu.TabIndex = 38
        '
        'BtnOpenAdmin
        '
        Me.BtnOpenAdmin.Animated = True
        Me.BtnOpenAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpenAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnOpenAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnOpenAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOpenAdmin.FillColor = System.Drawing.Color.Transparent
        Me.BtnOpenAdmin.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenAdmin.ForeColor = System.Drawing.Color.White
        Me.BtnOpenAdmin.Image = Global.TopGift.My.Resources.Resources.icons8_admin_settings_male_64__1_
        Me.BtnOpenAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenAdmin.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnOpenAdmin.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnOpenAdmin.Location = New System.Drawing.Point(0, 573)
        Me.BtnOpenAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOpenAdmin.Name = "BtnOpenAdmin"
        Me.BtnOpenAdmin.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnOpenAdmin.Size = New System.Drawing.Size(256, 60)
        Me.BtnOpenAdmin.TabIndex = 55
        Me.BtnOpenAdmin.Text = "Admin"
        Me.BtnOpenAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenAdmin.UseTransparentBackground = True
        '
        'PanelRepair
        '
        Me.PanelRepair.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelRepair.Controls.Add(Me.BtnOpenViewRepairs)
        Me.PanelRepair.Controls.Add(Me.BtnOpenSetRepairs)
        Me.PanelRepair.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRepair.Location = New System.Drawing.Point(0, 453)
        Me.PanelRepair.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRepair.Name = "PanelRepair"
        Me.PanelRepair.Size = New System.Drawing.Size(256, 120)
        Me.PanelRepair.TabIndex = 54
        '
        'BtnOpenViewRepairs
        '
        Me.BtnOpenViewRepairs.Animated = True
        Me.BtnOpenViewRepairs.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpenViewRepairs.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenViewRepairs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenViewRepairs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnOpenViewRepairs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnOpenViewRepairs.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOpenViewRepairs.FillColor = System.Drawing.Color.Transparent
        Me.BtnOpenViewRepairs.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenViewRepairs.ForeColor = System.Drawing.Color.White
        Me.BtnOpenViewRepairs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenViewRepairs.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnOpenViewRepairs.Location = New System.Drawing.Point(0, 60)
        Me.BtnOpenViewRepairs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOpenViewRepairs.Name = "BtnOpenViewRepairs"
        Me.BtnOpenViewRepairs.Size = New System.Drawing.Size(256, 60)
        Me.BtnOpenViewRepairs.TabIndex = 40
        Me.BtnOpenViewRepairs.Text = "View Repairs"
        Me.BtnOpenViewRepairs.UseTransparentBackground = True
        '
        'BtnOpenSetRepairs
        '
        Me.BtnOpenSetRepairs.Animated = True
        Me.BtnOpenSetRepairs.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpenSetRepairs.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenSetRepairs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenSetRepairs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnOpenSetRepairs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnOpenSetRepairs.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOpenSetRepairs.FillColor = System.Drawing.Color.Transparent
        Me.BtnOpenSetRepairs.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenSetRepairs.ForeColor = System.Drawing.Color.White
        Me.BtnOpenSetRepairs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenSetRepairs.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnOpenSetRepairs.Location = New System.Drawing.Point(0, 0)
        Me.BtnOpenSetRepairs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOpenSetRepairs.Name = "BtnOpenSetRepairs"
        Me.BtnOpenSetRepairs.Padding = New System.Windows.Forms.Padding(0, 0, 28, 0)
        Me.BtnOpenSetRepairs.Size = New System.Drawing.Size(256, 60)
        Me.BtnOpenSetRepairs.TabIndex = 39
        Me.BtnOpenSetRepairs.Text = "Set Repair"
        Me.BtnOpenSetRepairs.UseTransparentBackground = True
        '
        'BtnOpenRepair
        '
        Me.BtnOpenRepair.Animated = True
        Me.BtnOpenRepair.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpenRepair.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenRepair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenRepair.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnOpenRepair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnOpenRepair.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOpenRepair.FillColor = System.Drawing.Color.Transparent
        Me.BtnOpenRepair.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenRepair.ForeColor = System.Drawing.Color.White
        Me.BtnOpenRepair.Image = Global.TopGift.My.Resources.Resources.icons8_repair_64__2_
        Me.BtnOpenRepair.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenRepair.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnOpenRepair.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnOpenRepair.Location = New System.Drawing.Point(0, 393)
        Me.BtnOpenRepair.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOpenRepair.Name = "BtnOpenRepair"
        Me.BtnOpenRepair.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnOpenRepair.Size = New System.Drawing.Size(256, 60)
        Me.BtnOpenRepair.TabIndex = 53
        Me.BtnOpenRepair.Text = "Repair"
        Me.BtnOpenRepair.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenRepair.UseTransparentBackground = True
        '
        'PanelReminder
        '
        Me.PanelReminder.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelReminder.Controls.Add(Me.BtnOpenViewReminders)
        Me.PanelReminder.Controls.Add(Me.BtnOpenCreateReminder)
        Me.PanelReminder.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelReminder.Location = New System.Drawing.Point(0, 273)
        Me.PanelReminder.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelReminder.Name = "PanelReminder"
        Me.PanelReminder.Size = New System.Drawing.Size(256, 120)
        Me.PanelReminder.TabIndex = 52
        '
        'BtnOpenViewReminders
        '
        Me.BtnOpenViewReminders.Animated = True
        Me.BtnOpenViewReminders.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpenViewReminders.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenViewReminders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenViewReminders.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnOpenViewReminders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnOpenViewReminders.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOpenViewReminders.FillColor = System.Drawing.Color.Transparent
        Me.BtnOpenViewReminders.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenViewReminders.ForeColor = System.Drawing.Color.White
        Me.BtnOpenViewReminders.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenViewReminders.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnOpenViewReminders.Location = New System.Drawing.Point(0, 60)
        Me.BtnOpenViewReminders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOpenViewReminders.Name = "BtnOpenViewReminders"
        Me.BtnOpenViewReminders.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.BtnOpenViewReminders.Size = New System.Drawing.Size(256, 60)
        Me.BtnOpenViewReminders.TabIndex = 40
        Me.BtnOpenViewReminders.Text = "View Reminders"
        Me.BtnOpenViewReminders.UseTransparentBackground = True
        '
        'BtnOpenCreateReminder
        '
        Me.BtnOpenCreateReminder.Animated = True
        Me.BtnOpenCreateReminder.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpenCreateReminder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenCreateReminder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenCreateReminder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnOpenCreateReminder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnOpenCreateReminder.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOpenCreateReminder.FillColor = System.Drawing.Color.Transparent
        Me.BtnOpenCreateReminder.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenCreateReminder.ForeColor = System.Drawing.Color.White
        Me.BtnOpenCreateReminder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenCreateReminder.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnOpenCreateReminder.Location = New System.Drawing.Point(0, 0)
        Me.BtnOpenCreateReminder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOpenCreateReminder.Name = "BtnOpenCreateReminder"
        Me.BtnOpenCreateReminder.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnOpenCreateReminder.Size = New System.Drawing.Size(256, 60)
        Me.BtnOpenCreateReminder.TabIndex = 39
        Me.BtnOpenCreateReminder.Text = "Create Reminder"
        Me.BtnOpenCreateReminder.UseTransparentBackground = True
        '
        'BtnOpenReminder
        '
        Me.BtnOpenReminder.Animated = True
        Me.BtnOpenReminder.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpenReminder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenReminder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenReminder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnOpenReminder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnOpenReminder.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOpenReminder.FillColor = System.Drawing.Color.Transparent
        Me.BtnOpenReminder.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenReminder.ForeColor = System.Drawing.Color.White
        Me.BtnOpenReminder.Image = Global.TopGift.My.Resources.Resources.icons8_reminders_64
        Me.BtnOpenReminder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenReminder.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnOpenReminder.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnOpenReminder.Location = New System.Drawing.Point(0, 213)
        Me.BtnOpenReminder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOpenReminder.Name = "BtnOpenReminder"
        Me.BtnOpenReminder.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnOpenReminder.Size = New System.Drawing.Size(256, 60)
        Me.BtnOpenReminder.TabIndex = 51
        Me.BtnOpenReminder.Text = "Reminder"
        Me.BtnOpenReminder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenReminder.UseTransparentBackground = True
        '
        'BtnOpenInventory
        '
        Me.BtnOpenInventory.Animated = True
        Me.BtnOpenInventory.BackColor = System.Drawing.Color.Transparent
        Me.BtnOpenInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnOpenInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnOpenInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnOpenInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOpenInventory.FillColor = System.Drawing.Color.Transparent
        Me.BtnOpenInventory.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenInventory.ForeColor = System.Drawing.Color.White
        Me.BtnOpenInventory.Image = Global.TopGift.My.Resources.Resources.icons8_inventory_64__2_
        Me.BtnOpenInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenInventory.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnOpenInventory.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnOpenInventory.Location = New System.Drawing.Point(0, 153)
        Me.BtnOpenInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOpenInventory.Name = "BtnOpenInventory"
        Me.BtnOpenInventory.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnOpenInventory.Size = New System.Drawing.Size(256, 60)
        Me.BtnOpenInventory.TabIndex = 50
        Me.BtnOpenInventory.Text = "Inventory"
        Me.BtnOpenInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenInventory.UseTransparentBackground = True
        '
        'PanelDateTime
        '
        Me.PanelDateTime.Controls.Add(Me.LblSystemDateTime)
        Me.PanelDateTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDateTime.Location = New System.Drawing.Point(0, 103)
        Me.PanelDateTime.Name = "PanelDateTime"
        Me.PanelDateTime.Size = New System.Drawing.Size(256, 50)
        Me.PanelDateTime.TabIndex = 39
        '
        'PanelUsername
        '
        Me.PanelUsername.Controls.Add(Me.PictureBox1)
        Me.PanelUsername.Controls.Add(Me.LblPublicUsername)
        Me.PanelUsername.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelUsername.Location = New System.Drawing.Point(0, 0)
        Me.PanelUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelUsername.Name = "PanelUsername"
        Me.PanelUsername.Size = New System.Drawing.Size(256, 103)
        Me.PanelUsername.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TopGift.My.Resources.Resources.icons8_user_55
        Me.PictureBox1.Location = New System.Drawing.Point(15, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'LblPublicUsername
        '
        Me.LblPublicUsername.AutoSize = True
        Me.LblPublicUsername.BackColor = System.Drawing.Color.Transparent
        Me.LblPublicUsername.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.LblPublicUsername.ForeColor = System.Drawing.SystemColors.Control
        Me.LblPublicUsername.Location = New System.Drawing.Point(75, 37)
        Me.LblPublicUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPublicUsername.Name = "LblPublicUsername"
        Me.LblPublicUsername.Size = New System.Drawing.Size(101, 25)
        Me.LblPublicUsername.TabIndex = 40
        Me.LblPublicUsername.Text = "Username"
        '
        'BtnLogout
        '
        Me.BtnLogout.Animated = True
        Me.BtnLogout.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLogout.FillColor = System.Drawing.Color.Transparent
        Me.BtnLogout.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Image = Global.TopGift.My.Resources.Resources.icons8_logout_64
        Me.BtnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogout.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnLogout.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnLogout.Location = New System.Drawing.Point(0, 641)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnLogout.Size = New System.Drawing.Size(256, 72)
        Me.BtnLogout.TabIndex = 38
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogout.UseTransparentBackground = True
        '
        'PanelChildForm
        '
        Me.PanelChildForm.AutoSize = True
        Me.PanelChildForm.Controls.Add(Me.Label1)
        Me.PanelChildForm.Controls.Add(Me.BtnSetReminder)
        Me.PanelChildForm.Controls.Add(Me.Label7)
        Me.PanelChildForm.Controls.Add(Me.DTPickerReminderDateTime)
        Me.PanelChildForm.Controls.Add(Me.BtnClear)
        Me.PanelChildForm.Controls.Add(Me.TxtCustName)
        Me.PanelChildForm.Controls.Add(Me.LblReminderID)
        Me.PanelChildForm.Controls.Add(Me.TxtDeviceInfo)
        Me.PanelChildForm.Controls.Add(Me.Label5)
        Me.PanelChildForm.Controls.Add(Me.TxtPrice)
        Me.PanelChildForm.Controls.Add(Me.Label4)
        Me.PanelChildForm.Controls.Add(Me.Label2)
        Me.PanelChildForm.Controls.Add(Me.Label3)
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(256, 0)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(696, 713)
        Me.PanelChildForm.TabIndex = 39
        '
        'frmReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(952, 713)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(970, 760)
        Me.Name = "frmReminder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Reminders"
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelRepair.ResumeLayout(False)
        Me.PanelReminder.ResumeLayout(False)
        Me.PanelDateTime.ResumeLayout(False)
        Me.PanelDateTime.PerformLayout()
        Me.PanelUsername.ResumeLayout(False)
        Me.PanelUsername.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChildForm.ResumeLayout(False)
        Me.PanelChildForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents LblReminderID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtDeviceInfo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustName As System.Windows.Forms.TextBox
    Friend WithEvents DTPickerReminderDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSetReminder As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Notification As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblSystemDateTime As Label
    Friend WithEvents PanelSideMenu As System.Windows.Forms.Panel
    Friend WithEvents BtnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelUsername As System.Windows.Forms.Panel
    Friend WithEvents LblPublicUsername As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents PanelDateTime As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnOpenInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOpenReminder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOpenCreateReminder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOpenViewReminders As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelReminder As Panel
    Friend WithEvents BtnOpenRepair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOpenSetRepairs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOpenViewRepairs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelRepair As Panel
    Friend WithEvents BtnOpenAdmin As Guna.UI2.WinForms.Guna2Button
End Class
