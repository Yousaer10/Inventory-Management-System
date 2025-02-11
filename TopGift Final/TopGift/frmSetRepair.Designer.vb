<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetRepair
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetRepair))
        Me.BtnSetRepairTask = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvActiveReminders = New System.Windows.Forms.DataGridView()
        Me.ReminderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReminderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnClearReminderSearch = New System.Windows.Forms.Button()
        Me.CmbCustomerName = New System.Windows.Forms.ComboBox()
        Me.CmbSearchReminderID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnViewAllReminders = New System.Windows.Forms.Button()
        Me.BtnReminderSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbStaffID = New System.Windows.Forms.ComboBox()
        Me.BtnSetRepairClear = New System.Windows.Forms.Button()
        Me.BtnClearStaffSearch = New System.Windows.Forms.Button()
        Me.CmbStaffSurname = New System.Windows.Forms.ComboBox()
        Me.CmbStaffIDSearch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnViewAllStaff = New System.Windows.Forms.Button()
        Me.BtnStaffSearch = New System.Windows.Forms.Button()
        Me.DgvStaffInfo = New System.Windows.Forms.DataGridView()
        Me.StaffID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbReminderID = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtRepairID = New System.Windows.Forms.Label()
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
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DgvActiveReminders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvStaffInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelRepair.SuspendLayout()
        Me.PanelReminder.SuspendLayout()
        Me.PanelDateTime.SuspendLayout()
        Me.PanelUsername.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSetRepairTask
        '
        Me.BtnSetRepairTask.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetRepairTask.Location = New System.Drawing.Point(173, 224)
        Me.BtnSetRepairTask.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSetRepairTask.Name = "BtnSetRepairTask"
        Me.BtnSetRepairTask.Size = New System.Drawing.Size(121, 28)
        Me.BtnSetRepairTask.TabIndex = 1
        Me.BtnSetRepairTask.Text = "Set Repair Task"
        Me.BtnSetRepairTask.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(61, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Repair ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(76, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Staff ID:"
        '
        'DgvActiveReminders
        '
        Me.DgvActiveReminders.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvActiveReminders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvActiveReminders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvActiveReminders.BackgroundColor = System.Drawing.Color.White
        Me.DgvActiveReminders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvActiveReminders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvActiveReminders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvActiveReminders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvActiveReminders.ColumnHeadersHeight = 30
        Me.DgvActiveReminders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReminderID, Me.CustomerName, Me.DeviceInfo, Me.RepairPrice, Me.ReminderDate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvActiveReminders.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvActiveReminders.EnableHeadersVisualStyles = False
        Me.DgvActiveReminders.Location = New System.Drawing.Point(476, 144)
        Me.DgvActiveReminders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvActiveReminders.Name = "DgvActiveReminders"
        Me.DgvActiveReminders.ReadOnly = True
        Me.DgvActiveReminders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvActiveReminders.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvActiveReminders.RowHeadersWidth = 51
        Me.DgvActiveReminders.RowTemplate.Height = 29
        Me.DgvActiveReminders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvActiveReminders.Size = New System.Drawing.Size(1141, 197)
        Me.DgvActiveReminders.TabIndex = 7
        '
        'ReminderID
        '
        Me.ReminderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReminderID.HeaderText = "ReminderID"
        Me.ReminderID.MinimumWidth = 6
        Me.ReminderID.Name = "ReminderID"
        Me.ReminderID.ReadOnly = True
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
        Me.RepairPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RepairPrice.HeaderText = "Repair Price"
        Me.RepairPrice.MinimumWidth = 6
        Me.RepairPrice.Name = "RepairPrice"
        Me.RepairPrice.ReadOnly = True
        '
        'ReminderDate
        '
        Me.ReminderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReminderDate.HeaderText = "Reminder Date"
        Me.ReminderDate.MinimumWidth = 6
        Me.ReminderDate.Name = "ReminderDate"
        Me.ReminderDate.ReadOnly = True
        '
        'BtnClearReminderSearch
        '
        Me.BtnClearReminderSearch.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearReminderSearch.Location = New System.Drawing.Point(1483, 46)
        Me.BtnClearReminderSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClearReminderSearch.Name = "BtnClearReminderSearch"
        Me.BtnClearReminderSearch.Size = New System.Drawing.Size(100, 28)
        Me.BtnClearReminderSearch.TabIndex = 85
        Me.BtnClearReminderSearch.Text = "Clear"
        Me.BtnClearReminderSearch.UseVisualStyleBackColor = True
        '
        'CmbCustomerName
        '
        Me.CmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCustomerName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCustomerName.FormattingEnabled = True
        Me.CmbCustomerName.Location = New System.Drawing.Point(966, 46)
        Me.CmbCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbCustomerName.Name = "CmbCustomerName"
        Me.CmbCustomerName.Size = New System.Drawing.Size(172, 31)
        Me.CmbCustomerName.Sorted = True
        Me.CmbCustomerName.TabIndex = 84
        '
        'CmbSearchReminderID
        '
        Me.CmbSearchReminderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSearchReminderID.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchReminderID.FormattingEnabled = True
        Me.CmbSearchReminderID.Location = New System.Drawing.Point(613, 46)
        Me.CmbSearchReminderID.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbSearchReminderID.Name = "CmbSearchReminderID"
        Me.CmbSearchReminderID.Size = New System.Drawing.Size(160, 31)
        Me.CmbSearchReminderID.Sorted = True
        Me.CmbSearchReminderID.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(795, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 23)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Customer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(473, 54)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 23)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Reminder ID"
        '
        'BtnViewAllReminders
        '
        Me.BtnViewAllReminders.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewAllReminders.Location = New System.Drawing.Point(1357, 46)
        Me.BtnViewAllReminders.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnViewAllReminders.Name = "BtnViewAllReminders"
        Me.BtnViewAllReminders.Size = New System.Drawing.Size(100, 28)
        Me.BtnViewAllReminders.TabIndex = 80
        Me.BtnViewAllReminders.Text = "View All"
        Me.BtnViewAllReminders.UseVisualStyleBackColor = True
        '
        'BtnReminderSearch
        '
        Me.BtnReminderSearch.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReminderSearch.Location = New System.Drawing.Point(1229, 46)
        Me.BtnReminderSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReminderSearch.Name = "BtnReminderSearch"
        Me.BtnReminderSearch.Size = New System.Drawing.Size(100, 28)
        Me.BtnReminderSearch.TabIndex = 79
        Me.BtnReminderSearch.Text = "Search"
        Me.BtnReminderSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(31, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 28)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Reminder ID:"
        '
        'CmbStaffID
        '
        Me.CmbStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStaffID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStaffID.FormattingEnabled = True
        Me.CmbStaffID.Location = New System.Drawing.Point(173, 120)
        Me.CmbStaffID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbStaffID.Name = "CmbStaffID"
        Me.CmbStaffID.Size = New System.Drawing.Size(121, 36)
        Me.CmbStaffID.Sorted = True
        Me.CmbStaffID.TabIndex = 0
        '
        'BtnSetRepairClear
        '
        Me.BtnSetRepairClear.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetRepairClear.Location = New System.Drawing.Point(173, 274)
        Me.BtnSetRepairClear.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSetRepairClear.Name = "BtnSetRepairClear"
        Me.BtnSetRepairClear.Size = New System.Drawing.Size(100, 28)
        Me.BtnSetRepairClear.TabIndex = 88
        Me.BtnSetRepairClear.Text = "Clear"
        Me.BtnSetRepairClear.UseVisualStyleBackColor = True
        '
        'BtnClearStaffSearch
        '
        Me.BtnClearStaffSearch.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearStaffSearch.Location = New System.Drawing.Point(1483, 426)
        Me.BtnClearStaffSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClearStaffSearch.Name = "BtnClearStaffSearch"
        Me.BtnClearStaffSearch.Size = New System.Drawing.Size(100, 28)
        Me.BtnClearStaffSearch.TabIndex = 96
        Me.BtnClearStaffSearch.Text = "Clear"
        Me.BtnClearStaffSearch.UseVisualStyleBackColor = True
        '
        'CmbStaffSurname
        '
        Me.CmbStaffSurname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStaffSurname.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStaffSurname.FormattingEnabled = True
        Me.CmbStaffSurname.Location = New System.Drawing.Point(966, 426)
        Me.CmbStaffSurname.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbStaffSurname.Name = "CmbStaffSurname"
        Me.CmbStaffSurname.Size = New System.Drawing.Size(172, 31)
        Me.CmbStaffSurname.Sorted = True
        Me.CmbStaffSurname.TabIndex = 95
        '
        'CmbStaffIDSearch
        '
        Me.CmbStaffIDSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStaffIDSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStaffIDSearch.FormattingEnabled = True
        Me.CmbStaffIDSearch.Location = New System.Drawing.Point(613, 426)
        Me.CmbStaffIDSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbStaffIDSearch.Name = "CmbStaffIDSearch"
        Me.CmbStaffIDSearch.Size = New System.Drawing.Size(160, 31)
        Me.CmbStaffIDSearch.Sorted = True
        Me.CmbStaffIDSearch.TabIndex = 94
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(795, 431)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 23)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Staff Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(473, 434)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 23)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Staff ID"
        '
        'BtnViewAllStaff
        '
        Me.BtnViewAllStaff.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewAllStaff.Location = New System.Drawing.Point(1357, 426)
        Me.BtnViewAllStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnViewAllStaff.Name = "BtnViewAllStaff"
        Me.BtnViewAllStaff.Size = New System.Drawing.Size(100, 28)
        Me.BtnViewAllStaff.TabIndex = 91
        Me.BtnViewAllStaff.Text = "View All"
        Me.BtnViewAllStaff.UseVisualStyleBackColor = True
        '
        'BtnStaffSearch
        '
        Me.BtnStaffSearch.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStaffSearch.Location = New System.Drawing.Point(1229, 426)
        Me.BtnStaffSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStaffSearch.Name = "BtnStaffSearch"
        Me.BtnStaffSearch.Size = New System.Drawing.Size(100, 28)
        Me.BtnStaffSearch.TabIndex = 90
        Me.BtnStaffSearch.Text = "Search"
        Me.BtnStaffSearch.UseVisualStyleBackColor = True
        '
        'DgvStaffInfo
        '
        Me.DgvStaffInfo.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvStaffInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvStaffInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvStaffInfo.BackgroundColor = System.Drawing.Color.White
        Me.DgvStaffInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvStaffInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvStaffInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvStaffInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvStaffInfo.ColumnHeadersHeight = 30
        Me.DgvStaffInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffID, Me.SName, Me.SSurname, Me.SEmail, Me.SUsername})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvStaffInfo.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvStaffInfo.EnableHeadersVisualStyles = False
        Me.DgvStaffInfo.Location = New System.Drawing.Point(476, 521)
        Me.DgvStaffInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvStaffInfo.Name = "DgvStaffInfo"
        Me.DgvStaffInfo.ReadOnly = True
        Me.DgvStaffInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvStaffInfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvStaffInfo.RowHeadersWidth = 51
        Me.DgvStaffInfo.RowTemplate.Height = 29
        Me.DgvStaffInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvStaffInfo.Size = New System.Drawing.Size(1141, 197)
        Me.DgvStaffInfo.TabIndex = 89
        '
        'StaffID
        '
        Me.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StaffID.HeaderText = "StaffID"
        Me.StaffID.MinimumWidth = 6
        Me.StaffID.Name = "StaffID"
        Me.StaffID.ReadOnly = True
        '
        'SName
        '
        Me.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SName.HeaderText = "Name"
        Me.SName.MinimumWidth = 6
        Me.SName.Name = "SName"
        Me.SName.ReadOnly = True
        '
        'SSurname
        '
        Me.SSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SSurname.HeaderText = "Surname"
        Me.SSurname.MinimumWidth = 6
        Me.SSurname.Name = "SSurname"
        Me.SSurname.ReadOnly = True
        '
        'SEmail
        '
        Me.SEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SEmail.HeaderText = "Email"
        Me.SEmail.MinimumWidth = 6
        Me.SEmail.Name = "SEmail"
        Me.SEmail.ReadOnly = True
        '
        'SUsername
        '
        Me.SUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SUsername.HeaderText = "Username"
        Me.SUsername.MinimumWidth = 6
        Me.SUsername.Name = "SUsername"
        Me.SUsername.ReadOnly = True
        '
        'CmbReminderID
        '
        Me.CmbReminderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbReminderID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbReminderID.FormattingEnabled = True
        Me.CmbReminderID.Location = New System.Drawing.Point(173, 171)
        Me.CmbReminderID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbReminderID.Name = "CmbReminderID"
        Me.CmbReminderID.Size = New System.Drawing.Size(121, 36)
        Me.CmbReminderID.Sorted = True
        Me.CmbReminderID.TabIndex = 97
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(471, 478)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(152, 32)
        Me.Label18.TabIndex = 98
        Me.Label18.Text = "Staff Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(471, 97)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 32)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Reminders Details"
        '
        'TxtRepairID
        '
        Me.TxtRepairID.AutoSize = True
        Me.TxtRepairID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRepairID.ForeColor = System.Drawing.Color.White
        Me.TxtRepairID.Location = New System.Drawing.Point(168, 76)
        Me.TxtRepairID.Name = "TxtRepairID"
        Me.TxtRepairID.Size = New System.Drawing.Size(249, 28)
        Me.TxtRepairID.TabIndex = 100
        Me.TxtRepairID.Text = "Automatically Generated"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtRepairID)
        Me.Panel1.Controls.Add(Me.CmbSearchReminderID)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CmbStaffID)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.BtnSetRepairTask)
        Me.Panel1.Controls.Add(Me.CmbReminderID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnClearStaffSearch)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CmbStaffSurname)
        Me.Panel1.Controls.Add(Me.DgvActiveReminders)
        Me.Panel1.Controls.Add(Me.CmbStaffIDSearch)
        Me.Panel1.Controls.Add(Me.BtnReminderSearch)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.BtnViewAllReminders)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BtnViewAllStaff)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnStaffSearch)
        Me.Panel1.Controls.Add(Me.CmbCustomerName)
        Me.Panel1.Controls.Add(Me.DgvStaffInfo)
        Me.Panel1.Controls.Add(Me.BtnClearReminderSearch)
        Me.Panel1.Controls.Add(Me.BtnSetRepairClear)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(256, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1668, 1055)
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
        Me.PanelSideMenu.Size = New System.Drawing.Size(256, 1055)
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
        Me.BtnLogout.Location = New System.Drawing.Point(0, 983)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnLogout.Size = New System.Drawing.Size(256, 72)
        Me.BtnLogout.TabIndex = 38
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogout.UseTransparentBackground = True
        '
        'Timer6
        '
        '
        'frmSetRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmSetRepair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Repairs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvActiveReminders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvStaffInfo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnSetRepairTask As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvActiveReminders As DataGridView
    Friend WithEvents ReminderID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents DeviceInfo As DataGridViewTextBoxColumn
    Friend WithEvents RepairPrice As DataGridViewTextBoxColumn
    Friend WithEvents ReminderDate As DataGridViewTextBoxColumn
    Friend WithEvents BtnClearReminderSearch As Button
    Friend WithEvents CmbCustomerName As ComboBox
    Friend WithEvents CmbSearchReminderID As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnViewAllReminders As Button
    Friend WithEvents BtnReminderSearch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbStaffID As ComboBox
    Friend WithEvents BtnSetRepairClear As Button
    Friend WithEvents BtnClearStaffSearch As Button
    Friend WithEvents CmbStaffSurname As ComboBox
    Friend WithEvents CmbStaffIDSearch As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnViewAllStaff As Button
    Friend WithEvents BtnStaffSearch As Button
    Friend WithEvents DgvStaffInfo As DataGridView
    Friend WithEvents StaffID As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents SSurname As DataGridViewTextBoxColumn
    Friend WithEvents SEmail As DataGridViewTextBoxColumn
    Friend WithEvents SUsername As DataGridViewTextBoxColumn
    Friend WithEvents CmbReminderID As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtRepairID As Label
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
    Friend WithEvents Timer6 As Timer
End Class
