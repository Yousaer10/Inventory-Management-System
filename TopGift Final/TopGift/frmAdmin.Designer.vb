<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnClearStaffSearch = New System.Windows.Forms.Button()
        Me.CmbStaffSurname = New System.Windows.Forms.ComboBox()
        Me.CmbStaffIDSearch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnViewAllStaff = New System.Windows.Forms.Button()
        Me.BtnStaffSearch = New System.Windows.Forms.Button()
        Me.DgvStaffInfo = New System.Windows.Forms.DataGridView()
        Me.StaffID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAccessLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbStaffID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblFirstNameNotifier = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblSurnameNotifier = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblUsernameNotifier = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblEmailNotifier = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbAccessLevel = New System.Windows.Forms.ComboBox()
        Me.BtnStaffDelete = New System.Windows.Forms.Button()
        Me.SurnameWarningIcon = New System.Windows.Forms.PictureBox()
        Me.FirstNameWarningIcon = New System.Windows.Forms.PictureBox()
        Me.TxtSurname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UsernameWarningIcon = New System.Windows.Forms.PictureBox()
        Me.TxtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.EmailWarningIcon = New System.Windows.Forms.PictureBox()
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
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DgvStaffInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SurnameWarningIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstNameWarningIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernameWarningIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailWarningIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelRepair.SuspendLayout()
        Me.PanelReminder.SuspendLayout()
        Me.PanelDateTime.SuspendLayout()
        Me.PanelUsername.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(266, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 38)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Admin"
        '
        'BtnClearStaffSearch
        '
        Me.BtnClearStaffSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearStaffSearch.Location = New System.Drawing.Point(1125, 559)
        Me.BtnClearStaffSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnClearStaffSearch.Name = "BtnClearStaffSearch"
        Me.BtnClearStaffSearch.Size = New System.Drawing.Size(100, 28)
        Me.BtnClearStaffSearch.TabIndex = 104
        Me.BtnClearStaffSearch.Text = "Clear"
        Me.BtnClearStaffSearch.UseVisualStyleBackColor = True
        '
        'CmbStaffSurname
        '
        Me.CmbStaffSurname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStaffSurname.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStaffSurname.FormattingEnabled = True
        Me.CmbStaffSurname.Location = New System.Drawing.Point(608, 559)
        Me.CmbStaffSurname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbStaffSurname.Name = "CmbStaffSurname"
        Me.CmbStaffSurname.Size = New System.Drawing.Size(172, 31)
        Me.CmbStaffSurname.Sorted = True
        Me.CmbStaffSurname.TabIndex = 103
        '
        'CmbStaffIDSearch
        '
        Me.CmbStaffIDSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStaffIDSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStaffIDSearch.FormattingEnabled = True
        Me.CmbStaffIDSearch.Location = New System.Drawing.Point(256, 559)
        Me.CmbStaffIDSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbStaffIDSearch.Name = "CmbStaffIDSearch"
        Me.CmbStaffIDSearch.Size = New System.Drawing.Size(160, 31)
        Me.CmbStaffIDSearch.Sorted = True
        Me.CmbStaffIDSearch.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(438, 563)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 28)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Staff Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-215, 156)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Staff ID"
        '
        'BtnViewAllStaff
        '
        Me.BtnViewAllStaff.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewAllStaff.Location = New System.Drawing.Point(1000, 559)
        Me.BtnViewAllStaff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnViewAllStaff.Name = "BtnViewAllStaff"
        Me.BtnViewAllStaff.Size = New System.Drawing.Size(100, 28)
        Me.BtnViewAllStaff.TabIndex = 99
        Me.BtnViewAllStaff.Text = "View All"
        Me.BtnViewAllStaff.UseVisualStyleBackColor = True
        '
        'BtnStaffSearch
        '
        Me.BtnStaffSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStaffSearch.Location = New System.Drawing.Point(872, 559)
        Me.BtnStaffSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnStaffSearch.Name = "BtnStaffSearch"
        Me.BtnStaffSearch.Size = New System.Drawing.Size(100, 28)
        Me.BtnStaffSearch.TabIndex = 98
        Me.BtnStaffSearch.Text = "Search"
        Me.BtnStaffSearch.UseVisualStyleBackColor = True
        '
        'DgvStaffInfo
        '
        Me.DgvStaffInfo.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvStaffInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvStaffInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvStaffInfo.BackgroundColor = System.Drawing.Color.White
        Me.DgvStaffInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvStaffInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvStaffInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvStaffInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvStaffInfo.ColumnHeadersHeight = 30
        Me.DgvStaffInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffID, Me.SAccessLevel, Me.SName, Me.SSurname, Me.SEmail, Me.SUsername})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvStaffInfo.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvStaffInfo.EnableHeadersVisualStyles = False
        Me.DgvStaffInfo.Location = New System.Drawing.Point(144, 639)
        Me.DgvStaffInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvStaffInfo.Name = "DgvStaffInfo"
        Me.DgvStaffInfo.ReadOnly = True
        Me.DgvStaffInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvStaffInfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvStaffInfo.RowHeadersWidth = 51
        Me.DgvStaffInfo.RowTemplate.Height = 29
        Me.DgvStaffInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvStaffInfo.Size = New System.Drawing.Size(1249, 197)
        Me.DgvStaffInfo.TabIndex = 97
        '
        'StaffID
        '
        Me.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StaffID.HeaderText = "StaffID"
        Me.StaffID.MinimumWidth = 6
        Me.StaffID.Name = "StaffID"
        Me.StaffID.ReadOnly = True
        '
        'SAccessLevel
        '
        Me.SAccessLevel.HeaderText = "Access Level"
        Me.SAccessLevel.MinimumWidth = 6
        Me.SAccessLevel.Name = "SAccessLevel"
        Me.SAccessLevel.ReadOnly = True
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
        'CmbStaffID
        '
        Me.CmbStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStaffID.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStaffID.FormattingEnabled = True
        Me.CmbStaffID.Location = New System.Drawing.Point(205, 89)
        Me.CmbStaffID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbStaffID.Name = "CmbStaffID"
        Me.CmbStaffID.Size = New System.Drawing.Size(121, 25)
        Me.CmbStaffID.Sorted = True
        Me.CmbStaffID.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(138, 563)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 28)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Staff ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(101, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 23)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Staff ID:"
        '
        'LblFirstNameNotifier
        '
        Me.LblFirstNameNotifier.BackColor = System.Drawing.Color.Transparent
        Me.LblFirstNameNotifier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFirstNameNotifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblFirstNameNotifier.Location = New System.Drawing.Point(233, 205)
        Me.LblFirstNameNotifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblFirstNameNotifier.Name = "LblFirstNameNotifier"
        Me.LblFirstNameNotifier.Size = New System.Drawing.Size(176, 22)
        Me.LblFirstNameNotifier.TabIndex = 123
        Me.LblFirstNameNotifier.Text = "Please enter a First Name"
        Me.LblFirstNameNotifier.Visible = False
        '
        'LblSurnameNotifier
        '
        Me.LblSurnameNotifier.BackColor = System.Drawing.Color.Transparent
        Me.LblSurnameNotifier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSurnameNotifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblSurnameNotifier.Location = New System.Drawing.Point(233, 264)
        Me.LblSurnameNotifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblSurnameNotifier.Name = "LblSurnameNotifier"
        Me.LblSurnameNotifier.Size = New System.Drawing.Size(163, 22)
        Me.LblSurnameNotifier.TabIndex = 121
        Me.LblSurnameNotifier.Text = "Please enter a Surname"
        Me.LblSurnameNotifier.Visible = False
        '
        'LblUsernameNotifier
        '
        Me.LblUsernameNotifier.BackColor = System.Drawing.Color.Transparent
        Me.LblUsernameNotifier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsernameNotifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblUsernameNotifier.Location = New System.Drawing.Point(233, 383)
        Me.LblUsernameNotifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblUsernameNotifier.Name = "LblUsernameNotifier"
        Me.LblUsernameNotifier.Size = New System.Drawing.Size(164, 22)
        Me.LblUsernameNotifier.TabIndex = 116
        Me.LblUsernameNotifier.Text = "Username not available"
        Me.LblUsernameNotifier.Visible = False
        '
        'LblEmailNotifier
        '
        Me.LblEmailNotifier.BackColor = System.Drawing.Color.Transparent
        Me.LblEmailNotifier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailNotifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblEmailNotifier.Location = New System.Drawing.Point(233, 322)
        Me.LblEmailNotifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblEmailNotifier.Name = "LblEmailNotifier"
        Me.LblEmailNotifier.Size = New System.Drawing.Size(136, 22)
        Me.LblEmailNotifier.TabIndex = 114
        Me.LblEmailNotifier.Text = "Email already exists"
        Me.LblEmailNotifier.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(115, 298)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 23)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Email:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(80, 180)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(85, 361)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 23)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Username:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(94, 239)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 23)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Surname:"
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(364, 442)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(116, 31)
        Me.BtnClear.TabIndex = 126
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(203, 442)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(116, 31)
        Me.BtnSave.TabIndex = 125
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(69, 130)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 23)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Access Level:"
        '
        'CmbAccessLevel
        '
        Me.CmbAccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAccessLevel.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAccessLevel.FormattingEnabled = True
        Me.CmbAccessLevel.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.CmbAccessLevel.Location = New System.Drawing.Point(205, 130)
        Me.CmbAccessLevel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbAccessLevel.Name = "CmbAccessLevel"
        Me.CmbAccessLevel.Size = New System.Drawing.Size(121, 25)
        Me.CmbAccessLevel.Sorted = True
        Me.CmbAccessLevel.TabIndex = 127
        '
        'BtnStaffDelete
        '
        Me.BtnStaffDelete.BackColor = System.Drawing.Color.Red
        Me.BtnStaffDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStaffDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnStaffDelete.Location = New System.Drawing.Point(395, 82)
        Me.BtnStaffDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStaffDelete.Name = "BtnStaffDelete"
        Me.BtnStaffDelete.Size = New System.Drawing.Size(85, 31)
        Me.BtnStaffDelete.TabIndex = 129
        Me.BtnStaffDelete.Text = "Delete"
        Me.BtnStaffDelete.UseVisualStyleBackColor = False
        '
        'SurnameWarningIcon
        '
        Me.SurnameWarningIcon.BackColor = System.Drawing.Color.Transparent
        Me.SurnameWarningIcon.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.SurnameWarningIcon.Location = New System.Drawing.Point(205, 264)
        Me.SurnameWarningIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SurnameWarningIcon.Name = "SurnameWarningIcon"
        Me.SurnameWarningIcon.Size = New System.Drawing.Size(21, 20)
        Me.SurnameWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SurnameWarningIcon.TabIndex = 124
        Me.SurnameWarningIcon.TabStop = False
        Me.SurnameWarningIcon.Visible = False
        '
        'FirstNameWarningIcon
        '
        Me.FirstNameWarningIcon.BackColor = System.Drawing.Color.Transparent
        Me.FirstNameWarningIcon.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.FirstNameWarningIcon.Location = New System.Drawing.Point(205, 205)
        Me.FirstNameWarningIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FirstNameWarningIcon.Name = "FirstNameWarningIcon"
        Me.FirstNameWarningIcon.Size = New System.Drawing.Size(21, 20)
        Me.FirstNameWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FirstNameWarningIcon.TabIndex = 122
        Me.FirstNameWarningIcon.TabStop = False
        Me.FirstNameWarningIcon.Visible = False
        '
        'TxtSurname
        '
        Me.TxtSurname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSurname.DefaultText = ""
        Me.TxtSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSurname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSurname.IconLeft = Global.TopGift.My.Resources.Resources.icons8_name_tag_241
        Me.TxtSurname.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtSurname.Location = New System.Drawing.Point(205, 232)
        Me.TxtSurname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSurname.Name = "TxtSurname"
        Me.TxtSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSurname.PlaceholderText = "Surname"
        Me.TxtSurname.SelectedText = ""
        Me.TxtSurname.Size = New System.Drawing.Size(211, 30)
        Me.TxtSurname.TabIndex = 120
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFirstName.DefaultText = ""
        Me.TxtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFirstName.IconLeft = Global.TopGift.My.Resources.Resources.icons8_name_tag_24
        Me.TxtFirstName.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtFirstName.Location = New System.Drawing.Point(205, 173)
        Me.TxtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFirstName.PlaceholderText = "First Name"
        Me.TxtFirstName.SelectedText = ""
        Me.TxtFirstName.Size = New System.Drawing.Size(211, 30)
        Me.TxtFirstName.TabIndex = 119
        '
        'TxtUsername
        '
        Me.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUsername.DefaultText = ""
        Me.TxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUsername.IconLeft = Global.TopGift.My.Resources.Resources.icons8_user_64
        Me.TxtUsername.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtUsername.Location = New System.Drawing.Point(203, 354)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsername.PlaceholderText = "Username:"
        Me.TxtUsername.SelectedText = ""
        Me.TxtUsername.Size = New System.Drawing.Size(207, 30)
        Me.TxtUsername.TabIndex = 118
        '
        'UsernameWarningIcon
        '
        Me.UsernameWarningIcon.BackColor = System.Drawing.Color.Transparent
        Me.UsernameWarningIcon.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.UsernameWarningIcon.Location = New System.Drawing.Point(205, 383)
        Me.UsernameWarningIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UsernameWarningIcon.Name = "UsernameWarningIcon"
        Me.UsernameWarningIcon.Size = New System.Drawing.Size(21, 20)
        Me.UsernameWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UsernameWarningIcon.TabIndex = 117
        Me.UsernameWarningIcon.TabStop = False
        Me.UsernameWarningIcon.Visible = False
        '
        'TxtEmail
        '
        Me.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEmail.DefaultText = ""
        Me.TxtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtEmail.IconLeft = Global.TopGift.My.Resources.Resources.icons8_email_64
        Me.TxtEmail.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtEmail.Location = New System.Drawing.Point(205, 291)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEmail.PlaceholderText = "Email"
        Me.TxtEmail.SelectedText = ""
        Me.TxtEmail.Size = New System.Drawing.Size(211, 30)
        Me.TxtEmail.TabIndex = 113
        '
        'EmailWarningIcon
        '
        Me.EmailWarningIcon.BackColor = System.Drawing.Color.Transparent
        Me.EmailWarningIcon.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.EmailWarningIcon.Location = New System.Drawing.Point(203, 322)
        Me.EmailWarningIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmailWarningIcon.Name = "EmailWarningIcon"
        Me.EmailWarningIcon.Size = New System.Drawing.Size(21, 20)
        Me.EmailWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmailWarningIcon.TabIndex = 115
        Me.EmailWarningIcon.TabStop = False
        Me.EmailWarningIcon.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtnStaffDelete)
        Me.Panel1.Controls.Add(Me.DgvStaffInfo)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.BtnStaffSearch)
        Me.Panel1.Controls.Add(Me.CmbAccessLevel)
        Me.Panel1.Controls.Add(Me.BtnViewAllStaff)
        Me.Panel1.Controls.Add(Me.BtnClear)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.CmbStaffIDSearch)
        Me.Panel1.Controls.Add(Me.LblFirstNameNotifier)
        Me.Panel1.Controls.Add(Me.CmbStaffSurname)
        Me.Panel1.Controls.Add(Me.SurnameWarningIcon)
        Me.Panel1.Controls.Add(Me.BtnClearStaffSearch)
        Me.Panel1.Controls.Add(Me.LblSurnameNotifier)
        Me.Panel1.Controls.Add(Me.CmbStaffID)
        Me.Panel1.Controls.Add(Me.FirstNameWarningIcon)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtSurname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtFirstName)
        Me.Panel1.Controls.Add(Me.EmailWarningIcon)
        Me.Panel1.Controls.Add(Me.TxtUsername)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LblUsernameNotifier)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.UsernameWarningIcon)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LblEmailNotifier)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtEmail)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(256, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1668, 862)
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
        Me.PanelSideMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(256, 862)
        Me.PanelSideMenu.TabIndex = 101
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
        Me.BtnOpenAdmin.Location = New System.Drawing.Point(0, 575)
        Me.BtnOpenAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOpenAdmin.Name = "BtnOpenAdmin"
        Me.BtnOpenAdmin.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
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
        Me.PanelRepair.Location = New System.Drawing.Point(0, 454)
        Me.PanelRepair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelRepair.Name = "PanelRepair"
        Me.PanelRepair.Size = New System.Drawing.Size(256, 121)
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
        Me.BtnOpenRepair.Location = New System.Drawing.Point(0, 394)
        Me.BtnOpenRepair.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOpenRepair.Name = "BtnOpenRepair"
        Me.BtnOpenRepair.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
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
        Me.PanelReminder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelReminder.Name = "PanelReminder"
        Me.PanelReminder.Size = New System.Drawing.Size(256, 121)
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
        Me.BtnOpenViewReminders.Padding = New System.Windows.Forms.Padding(27, 0, 0, 0)
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
        Me.BtnOpenCreateReminder.Padding = New System.Windows.Forms.Padding(29, 0, 0, 0)
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
        Me.BtnOpenReminder.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
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
        Me.BtnOpenInventory.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
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
        Me.PanelDateTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.PanelUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.BtnLogout.Location = New System.Drawing.Point(0, 791)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.BtnLogout.Size = New System.Drawing.Size(256, 71)
        Me.BtnLogout.TabIndex = 38
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogout.UseTransparentBackground = True
        '
        'Timer4
        '
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 862)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1918, 872)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        CType(Me.DgvStaffInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SurnameWarningIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstNameWarningIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernameWarningIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailWarningIcon, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnClearStaffSearch As System.Windows.Forms.Button
    Friend WithEvents CmbStaffSurname As System.Windows.Forms.ComboBox
    Friend WithEvents CmbStaffIDSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnViewAllStaff As System.Windows.Forms.Button
    Friend WithEvents BtnStaffSearch As System.Windows.Forms.Button
    Friend WithEvents DgvStaffInfo As System.Windows.Forms.DataGridView
    Friend WithEvents CmbStaffID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblFirstNameNotifier As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents SurnameWarningIcon As PictureBox
    Friend WithEvents LblSurnameNotifier As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FirstNameWarningIcon As PictureBox
    Friend WithEvents TxtSurname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblUsernameNotifier As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UsernameWarningIcon As PictureBox
    Friend WithEvents LblEmailNotifier As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EmailWarningIcon As PictureBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents CmbAccessLevel As ComboBox
    Friend WithEvents StaffID As DataGridViewTextBoxColumn
    Friend WithEvents SAccessLevel As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents SSurname As DataGridViewTextBoxColumn
    Friend WithEvents SEmail As DataGridViewTextBoxColumn
    Friend WithEvents SUsername As DataGridViewTextBoxColumn
    Friend WithEvents BtnStaffDelete As Button
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
    Friend WithEvents Timer4 As Timer
End Class
