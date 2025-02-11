<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewRepairs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewRepairs))
        Me.DgvActiveRepairs = New System.Windows.Forms.DataGridView()
        Me.RepairID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReminderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblStaffID = New System.Windows.Forms.Label()
        Me.DgvPastRepairs = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DgvActiveRepairs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPastRepairs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelRepair.SuspendLayout()
        Me.PanelReminder.SuspendLayout()
        Me.PanelDateTime.SuspendLayout()
        Me.PanelUsername.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvActiveRepairs
        '
        Me.DgvActiveRepairs.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvActiveRepairs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvActiveRepairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvActiveRepairs.BackgroundColor = System.Drawing.Color.White
        Me.DgvActiveRepairs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvActiveRepairs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvActiveRepairs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvActiveRepairs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvActiveRepairs.ColumnHeadersHeight = 30
        Me.DgvActiveRepairs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairID, Me.StaffID, Me.CustomerName, Me.DeviceInfo, Me.RepairPrice, Me.ReminderDate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvActiveRepairs.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvActiveRepairs.EnableHeadersVisualStyles = False
        Me.DgvActiveRepairs.Location = New System.Drawing.Point(87, 139)
        Me.DgvActiveRepairs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvActiveRepairs.Name = "DgvActiveRepairs"
        Me.DgvActiveRepairs.ReadOnly = True
        Me.DgvActiveRepairs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvActiveRepairs.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvActiveRepairs.RowHeadersWidth = 51
        Me.DgvActiveRepairs.RowTemplate.Height = 29
        Me.DgvActiveRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvActiveRepairs.Size = New System.Drawing.Size(1087, 197)
        Me.DgvActiveRepairs.TabIndex = 8
        '
        'RepairID
        '
        Me.RepairID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RepairID.HeaderText = "Repair ID"
        Me.RepairID.MinimumWidth = 6
        Me.RepairID.Name = "RepairID"
        Me.RepairID.ReadOnly = True
        '
        'StaffID
        '
        Me.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StaffID.HeaderText = "Staff ID"
        Me.StaffID.MinimumWidth = 6
        Me.StaffID.Name = "StaffID"
        Me.StaffID.ReadOnly = True
        '
        'CustomerName
        '
        Me.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.MinimumWidth = 6
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.ReadOnly = True
        '
        'DeviceInfo
        '
        Me.DeviceInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DeviceInfo.HeaderText = "Device Information"
        Me.DeviceInfo.MinimumWidth = 6
        Me.DeviceInfo.Name = "DeviceInfo"
        Me.DeviceInfo.ReadOnly = True
        '
        'RepairPrice
        '
        Me.RepairPrice.HeaderText = "Repair Price"
        Me.RepairPrice.MinimumWidth = 6
        Me.RepairPrice.Name = "RepairPrice"
        Me.RepairPrice.ReadOnly = True
        '
        'ReminderDate
        '
        Me.ReminderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReminderDate.HeaderText = "Date Due"
        Me.ReminderDate.MinimumWidth = 6
        Me.ReminderDate.Name = "ReminderDate"
        Me.ReminderDate.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(519, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Staff ID:"
        '
        'LblStaffID
        '
        Me.LblStaffID.AutoSize = True
        Me.LblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStaffID.ForeColor = System.Drawing.Color.White
        Me.LblStaffID.Location = New System.Drawing.Point(612, 34)
        Me.LblStaffID.Name = "LblStaffID"
        Me.LblStaffID.Size = New System.Drawing.Size(31, 25)
        Me.LblStaffID.TabIndex = 10
        Me.LblStaffID.Text = "ID"
        '
        'DgvPastRepairs
        '
        Me.DgvPastRepairs.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvPastRepairs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvPastRepairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPastRepairs.BackgroundColor = System.Drawing.Color.White
        Me.DgvPastRepairs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPastRepairs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvPastRepairs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPastRepairs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvPastRepairs.ColumnHeadersHeight = 30
        Me.DgvPastRepairs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPastRepairs.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvPastRepairs.EnableHeadersVisualStyles = False
        Me.DgvPastRepairs.Location = New System.Drawing.Point(87, 450)
        Me.DgvPastRepairs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvPastRepairs.Name = "DgvPastRepairs"
        Me.DgvPastRepairs.ReadOnly = True
        Me.DgvPastRepairs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPastRepairs.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvPastRepairs.RowHeadersWidth = 51
        Me.DgvPastRepairs.RowTemplate.Height = 29
        Me.DgvPastRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPastRepairs.Size = New System.Drawing.Size(1087, 197)
        Me.DgvPastRepairs.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Repair ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Staff ID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "Device Information"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Repair Price"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date Due"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 45)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Past Repairs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(79, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 45)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Active Repairs"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DgvActiveRepairs)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DgvPastRepairs)
        Me.Panel1.Controls.Add(Me.LblStaffID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(256, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1462, 801)
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
        Me.PanelSideMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(256, 801)
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
        Me.BtnLogout.Location = New System.Drawing.Point(0, 729)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnLogout.Size = New System.Drawing.Size(256, 72)
        Me.BtnLogout.TabIndex = 38
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogout.UseTransparentBackground = True
        '
        'Timer7
        '
        '
        'frmViewRepairs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1718, 801)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmViewRepairs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Repairs"
        CType(Me.DgvActiveRepairs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPastRepairs, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents DgvActiveRepairs As DataGridView
    Friend WithEvents RepairID As DataGridViewTextBoxColumn
    Friend WithEvents StaffID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents DeviceInfo As DataGridViewTextBoxColumn
    Friend WithEvents RepairPrice As DataGridViewTextBoxColumn
    Friend WithEvents ReminderDate As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents LblStaffID As Label
    Friend WithEvents DgvPastRepairs As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
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
    Friend WithEvents Timer7 As Timer
End Class
