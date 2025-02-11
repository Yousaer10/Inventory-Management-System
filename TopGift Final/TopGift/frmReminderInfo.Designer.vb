<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReminderInfo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReminderInfo))
        Me.DgvCurrentReminders = New System.Windows.Forms.DataGridView()
        Me.DgvPastReminders = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.LblSystemDateTime = New System.Windows.Forms.Label()
        Me.PanelUsername = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblPublicUsername = New System.Windows.Forms.Label()
        Me.BtnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.ReminderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReminderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvCurrentReminders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPastReminders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelRepair.SuspendLayout()
        Me.PanelReminder.SuspendLayout()
        Me.PanelDateTime.SuspendLayout()
        Me.PanelUsername.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCurrentReminders
        '
        Me.DgvCurrentReminders.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvCurrentReminders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCurrentReminders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCurrentReminders.BackgroundColor = System.Drawing.Color.White
        Me.DgvCurrentReminders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCurrentReminders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvCurrentReminders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCurrentReminders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCurrentReminders.ColumnHeadersHeight = 30
        Me.DgvCurrentReminders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReminderID, Me.CustomerName, Me.DeviceInfo, Me.RepairPrice, Me.ReminderDate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCurrentReminders.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvCurrentReminders.EnableHeadersVisualStyles = False
        Me.DgvCurrentReminders.Location = New System.Drawing.Point(19, 81)
        Me.DgvCurrentReminders.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgvCurrentReminders.Name = "DgvCurrentReminders"
        Me.DgvCurrentReminders.ReadOnly = True
        Me.DgvCurrentReminders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCurrentReminders.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvCurrentReminders.RowHeadersWidth = 51
        Me.DgvCurrentReminders.RowTemplate.Height = 29
        Me.DgvCurrentReminders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCurrentReminders.Size = New System.Drawing.Size(1192, 160)
        Me.DgvCurrentReminders.TabIndex = 0
        '
        'DgvPastReminders
        '
        Me.DgvPastReminders.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvPastReminders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvPastReminders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPastReminders.BackgroundColor = System.Drawing.Color.White
        Me.DgvPastReminders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPastReminders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvPastReminders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPastReminders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvPastReminders.ColumnHeadersHeight = 30
        Me.DgvPastReminders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPastReminders.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvPastReminders.EnableHeadersVisualStyles = False
        Me.DgvPastReminders.Location = New System.Drawing.Point(19, 362)
        Me.DgvPastReminders.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgvPastReminders.Name = "DgvPastReminders"
        Me.DgvPastReminders.ReadOnly = True
        Me.DgvPastReminders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPastReminders.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvPastReminders.RowHeadersWidth = 51
        Me.DgvPastReminders.RowTemplate.Height = 29
        Me.DgvPastReminders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPastReminders.Size = New System.Drawing.Size(1192, 398)
        Me.DgvPastReminders.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "ReminderID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Device Information"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "Repair Price"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = "Reminder Date"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Active Reminders"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 291)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Past Reminders"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvPastReminders)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DgvCurrentReminders)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(192, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1251, 795)
        Me.Panel1.TabIndex = 50
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
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(192, 795)
        Me.PanelSideMenu.TabIndex = 51
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
        Me.BtnOpenAdmin.Location = New System.Drawing.Point(0, 468)
        Me.BtnOpenAdmin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnOpenAdmin.Name = "BtnOpenAdmin"
        Me.BtnOpenAdmin.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnOpenAdmin.Size = New System.Drawing.Size(192, 49)
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
        Me.PanelRepair.Location = New System.Drawing.Point(0, 370)
        Me.PanelRepair.Name = "PanelRepair"
        Me.PanelRepair.Size = New System.Drawing.Size(192, 98)
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
        Me.BtnOpenViewRepairs.Location = New System.Drawing.Point(0, 49)
        Me.BtnOpenViewRepairs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnOpenViewRepairs.Name = "BtnOpenViewRepairs"
        Me.BtnOpenViewRepairs.Size = New System.Drawing.Size(192, 49)
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
        Me.BtnOpenSetRepairs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnOpenSetRepairs.Name = "BtnOpenSetRepairs"
        Me.BtnOpenSetRepairs.Padding = New System.Windows.Forms.Padding(0, 0, 21, 0)
        Me.BtnOpenSetRepairs.Size = New System.Drawing.Size(192, 49)
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
        Me.BtnOpenRepair.Location = New System.Drawing.Point(0, 321)
        Me.BtnOpenRepair.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnOpenRepair.Name = "BtnOpenRepair"
        Me.BtnOpenRepair.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnOpenRepair.Size = New System.Drawing.Size(192, 49)
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
        Me.PanelReminder.Location = New System.Drawing.Point(0, 223)
        Me.PanelReminder.Name = "PanelReminder"
        Me.PanelReminder.Size = New System.Drawing.Size(192, 98)
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
        Me.BtnOpenViewReminders.Location = New System.Drawing.Point(0, 49)
        Me.BtnOpenViewReminders.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnOpenViewReminders.Name = "BtnOpenViewReminders"
        Me.BtnOpenViewReminders.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnOpenViewReminders.Size = New System.Drawing.Size(192, 49)
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
        Me.BtnOpenCreateReminder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnOpenCreateReminder.Name = "BtnOpenCreateReminder"
        Me.BtnOpenCreateReminder.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.BtnOpenCreateReminder.Size = New System.Drawing.Size(192, 49)
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
        Me.BtnOpenReminder.Location = New System.Drawing.Point(0, 174)
        Me.BtnOpenReminder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnOpenReminder.Name = "BtnOpenReminder"
        Me.BtnOpenReminder.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnOpenReminder.Size = New System.Drawing.Size(192, 49)
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
        Me.BtnOpenInventory.Location = New System.Drawing.Point(0, 125)
        Me.BtnOpenInventory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnOpenInventory.Name = "BtnOpenInventory"
        Me.BtnOpenInventory.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnOpenInventory.Size = New System.Drawing.Size(192, 49)
        Me.BtnOpenInventory.TabIndex = 50
        Me.BtnOpenInventory.Text = "Inventory"
        Me.BtnOpenInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnOpenInventory.UseTransparentBackground = True
        '
        'PanelDateTime
        '
        Me.PanelDateTime.Controls.Add(Me.LblSystemDateTime)
        Me.PanelDateTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDateTime.Location = New System.Drawing.Point(0, 84)
        Me.PanelDateTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelDateTime.Name = "PanelDateTime"
        Me.PanelDateTime.Size = New System.Drawing.Size(192, 41)
        Me.PanelDateTime.TabIndex = 39
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
        Me.LblSystemDateTime.Location = New System.Drawing.Point(26, 11)
        Me.LblSystemDateTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSystemDateTime.Name = "LblSystemDateTime"
        Me.LblSystemDateTime.Size = New System.Drawing.Size(151, 20)
        Me.LblSystemDateTime.TabIndex = 34
        Me.LblSystemDateTime.Text = "09:00    01/01/2022"
        '
        'PanelUsername
        '
        Me.PanelUsername.Controls.Add(Me.PictureBox1)
        Me.PanelUsername.Controls.Add(Me.LblPublicUsername)
        Me.PanelUsername.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelUsername.Location = New System.Drawing.Point(0, 0)
        Me.PanelUsername.Name = "PanelUsername"
        Me.PanelUsername.Size = New System.Drawing.Size(192, 84)
        Me.PanelUsername.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TopGift.My.Resources.Resources.icons8_user_55
        Me.PictureBox1.Location = New System.Drawing.Point(11, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 45)
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
        Me.LblPublicUsername.Location = New System.Drawing.Point(56, 30)
        Me.LblPublicUsername.Name = "LblPublicUsername"
        Me.LblPublicUsername.Size = New System.Drawing.Size(80, 20)
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
        Me.BtnLogout.Location = New System.Drawing.Point(0, 737)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnLogout.Size = New System.Drawing.Size(192, 58)
        Me.BtnLogout.TabIndex = 38
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogout.UseTransparentBackground = True
        '
        'Timer5
        '
        '
        'ReminderID
        '
        Me.ReminderID.HeaderText = "Reminder ID"
        Me.ReminderID.Name = "ReminderID"
        Me.ReminderID.ReadOnly = True
        '
        'CustomerName
        '
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.ReadOnly = True
        '
        'DeviceInfo
        '
        Me.DeviceInfo.HeaderText = "Device Information"
        Me.DeviceInfo.Name = "DeviceInfo"
        Me.DeviceInfo.ReadOnly = True
        '
        'RepairPrice
        '
        Me.RepairPrice.HeaderText = "Repair Price"
        Me.RepairPrice.Name = "RepairPrice"
        Me.RepairPrice.ReadOnly = True
        '
        'ReminderDate
        '
        Me.ReminderDate.HeaderText = "Reminder Date"
        Me.ReminderDate.Name = "ReminderDate"
        Me.ReminderDate.ReadOnly = True
        '
        'frmReminderInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1443, 795)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReminderInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reminder Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvCurrentReminders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPastReminders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelRepair.ResumeLayout(False)
        Me.PanelReminder.ResumeLayout(False)
        Me.PanelDateTime.ResumeLayout(False)
        Me.PanelDateTime.PerformLayout()
        Me.PanelUsername.ResumeLayout(False)
        Me.PanelUsername.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvCurrentReminders As DataGridView
    Friend WithEvents DgvPastReminders As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents BtnOpenAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelRepair As Panel
    Friend WithEvents BtnOpenViewRepairs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOpenSetRepairs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOpenRepair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelReminder As Panel
    Friend WithEvents BtnOpenViewReminders As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOpenCreateReminder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOpenReminder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOpenInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelDateTime As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblSystemDateTime As Label
    Friend WithEvents PanelUsername As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblPublicUsername As Label
    Friend WithEvents BtnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer5 As Timer
    Friend WithEvents ReminderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceInfo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RepairPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReminderDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
