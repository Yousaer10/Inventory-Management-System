<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LblEmailNotifier = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblUsernameNotifier = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblPasswordNotifier = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblSurnameNotifier = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblFirstNameNotifier = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SurnameWarningIcon = New System.Windows.Forms.PictureBox()
        Me.FirstNameWarningIcon = New System.Windows.Forms.PictureBox()
        Me.TxtSurname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordWarningIcon = New System.Windows.Forms.PictureBox()
        Me.UsernameWarningIcon = New System.Windows.Forms.PictureBox()
        Me.TxtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.EmailWarningIcon = New System.Windows.Forms.PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CheckBoxShow = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnClear = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnRegister = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TxtStaffID = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.SurnameWarningIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstNameWarningIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordWarningIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernameWarningIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailWarningIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(303, 358)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(664, 473)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 25)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Confirm Password"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(300, 242)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 25)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(300, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Staff ID"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(303, 473)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(300, 414)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(303, 298)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Surname"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(520, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 44)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Register"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1000
        Me.ToolTip1.AutoPopDelay = 1000000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 20
        Me.ToolTip1.ShowAlways = True
        '
        'LblEmailNotifier
        '
        Me.LblEmailNotifier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblEmailNotifier.BackColor = System.Drawing.Color.Transparent
        Me.LblEmailNotifier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailNotifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblEmailNotifier.Location = New System.Drawing.Point(456, 386)
        Me.LblEmailNotifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblEmailNotifier.Name = "LblEmailNotifier"
        Me.LblEmailNotifier.Size = New System.Drawing.Size(136, 22)
        Me.LblEmailNotifier.TabIndex = 39
        Me.LblEmailNotifier.Text = "Email already exists"
        '
        'LblUsernameNotifier
        '
        Me.LblUsernameNotifier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblUsernameNotifier.BackColor = System.Drawing.Color.Transparent
        Me.LblUsernameNotifier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsernameNotifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblUsernameNotifier.Location = New System.Drawing.Point(456, 444)
        Me.LblUsernameNotifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblUsernameNotifier.Name = "LblUsernameNotifier"
        Me.LblUsernameNotifier.Size = New System.Drawing.Size(164, 22)
        Me.LblUsernameNotifier.TabIndex = 41
        Me.LblUsernameNotifier.Text = "Username not available"
        '
        'LblPasswordNotifier
        '
        Me.LblPasswordNotifier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblPasswordNotifier.BackColor = System.Drawing.Color.Transparent
        Me.LblPasswordNotifier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPasswordNotifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblPasswordNotifier.Location = New System.Drawing.Point(456, 501)
        Me.LblPasswordNotifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblPasswordNotifier.Name = "LblPasswordNotifier"
        Me.LblPasswordNotifier.Size = New System.Drawing.Size(271, 22)
        Me.LblPasswordNotifier.TabIndex = 43
        Me.LblPasswordNotifier.Text = "Both passwords don't match. Try again."
        '
        'LblSurnameNotifier
        '
        Me.LblSurnameNotifier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSurnameNotifier.BackColor = System.Drawing.Color.Transparent
        Me.LblSurnameNotifier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSurnameNotifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblSurnameNotifier.Location = New System.Drawing.Point(456, 325)
        Me.LblSurnameNotifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblSurnameNotifier.Name = "LblSurnameNotifier"
        Me.LblSurnameNotifier.Size = New System.Drawing.Size(163, 22)
        Me.LblSurnameNotifier.TabIndex = 50
        Me.LblSurnameNotifier.Text = "Please enter a Surname"
        '
        'LblFirstNameNotifier
        '
        Me.LblFirstNameNotifier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFirstNameNotifier.BackColor = System.Drawing.Color.Transparent
        Me.LblFirstNameNotifier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFirstNameNotifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblFirstNameNotifier.Location = New System.Drawing.Point(455, 266)
        Me.LblFirstNameNotifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblFirstNameNotifier.Name = "LblFirstNameNotifier"
        Me.LblFirstNameNotifier.Size = New System.Drawing.Size(176, 22)
        Me.LblFirstNameNotifier.TabIndex = 52
        Me.LblFirstNameNotifier.Text = "Please enter a First Name"
        '
        'SurnameWarningIcon
        '
        Me.SurnameWarningIcon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SurnameWarningIcon.BackColor = System.Drawing.Color.Transparent
        Me.SurnameWarningIcon.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.SurnameWarningIcon.Location = New System.Drawing.Point(428, 325)
        Me.SurnameWarningIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SurnameWarningIcon.Name = "SurnameWarningIcon"
        Me.SurnameWarningIcon.Size = New System.Drawing.Size(21, 20)
        Me.SurnameWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SurnameWarningIcon.TabIndex = 53
        Me.SurnameWarningIcon.TabStop = False
        '
        'FirstNameWarningIcon
        '
        Me.FirstNameWarningIcon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FirstNameWarningIcon.BackColor = System.Drawing.Color.Transparent
        Me.FirstNameWarningIcon.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.FirstNameWarningIcon.Location = New System.Drawing.Point(428, 266)
        Me.FirstNameWarningIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FirstNameWarningIcon.Name = "FirstNameWarningIcon"
        Me.FirstNameWarningIcon.Size = New System.Drawing.Size(21, 20)
        Me.FirstNameWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FirstNameWarningIcon.TabIndex = 51
        Me.FirstNameWarningIcon.TabStop = False
        '
        'TxtSurname
        '
        Me.TxtSurname.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.TxtSurname.Location = New System.Drawing.Point(428, 293)
        Me.TxtSurname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSurname.Name = "TxtSurname"
        Me.TxtSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSurname.PlaceholderText = "Surname"
        Me.TxtSurname.SelectedText = ""
        Me.TxtSurname.Size = New System.Drawing.Size(221, 30)
        Me.TxtSurname.TabIndex = 49
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.TxtFirstName.Location = New System.Drawing.Point(428, 233)
        Me.TxtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFirstName.PlaceholderText = "First Name"
        Me.TxtFirstName.SelectedText = ""
        Me.TxtFirstName.Size = New System.Drawing.Size(221, 30)
        Me.TxtFirstName.TabIndex = 48
        '
        'TxtUsername
        '
        Me.TxtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.TxtUsername.Location = New System.Drawing.Point(427, 414)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsername.PlaceholderText = "Username"
        Me.TxtUsername.SelectedText = ""
        Me.TxtUsername.Size = New System.Drawing.Size(221, 30)
        Me.TxtUsername.TabIndex = 45
        '
        'PasswordWarningIcon
        '
        Me.PasswordWarningIcon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordWarningIcon.BackColor = System.Drawing.Color.Transparent
        Me.PasswordWarningIcon.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.PasswordWarningIcon.Location = New System.Drawing.Point(428, 501)
        Me.PasswordWarningIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PasswordWarningIcon.Name = "PasswordWarningIcon"
        Me.PasswordWarningIcon.Size = New System.Drawing.Size(21, 20)
        Me.PasswordWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PasswordWarningIcon.TabIndex = 44
        Me.PasswordWarningIcon.TabStop = False
        '
        'UsernameWarningIcon
        '
        Me.UsernameWarningIcon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameWarningIcon.BackColor = System.Drawing.Color.Transparent
        Me.UsernameWarningIcon.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.UsernameWarningIcon.Location = New System.Drawing.Point(428, 444)
        Me.UsernameWarningIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UsernameWarningIcon.Name = "UsernameWarningIcon"
        Me.UsernameWarningIcon.Size = New System.Drawing.Size(21, 20)
        Me.UsernameWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UsernameWarningIcon.TabIndex = 42
        Me.UsernameWarningIcon.TabStop = False
        '
        'TxtEmail
        '
        Me.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.TxtEmail.Location = New System.Drawing.Point(428, 353)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEmail.PlaceholderText = "Email"
        Me.TxtEmail.SelectedText = ""
        Me.TxtEmail.Size = New System.Drawing.Size(221, 30)
        Me.TxtEmail.TabIndex = 38
        '
        'EmailWarningIcon
        '
        Me.EmailWarningIcon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmailWarningIcon.BackColor = System.Drawing.Color.Transparent
        Me.EmailWarningIcon.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.EmailWarningIcon.Location = New System.Drawing.Point(428, 386)
        Me.EmailWarningIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmailWarningIcon.Name = "EmailWarningIcon"
        Me.EmailWarningIcon.Size = New System.Drawing.Size(21, 20)
        Me.EmailWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmailWarningIcon.TabIndex = 40
        Me.EmailWarningIcon.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(515, 537)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(134, 27)
        Me.Guna2HtmlLabel1.TabIndex = 55
        Me.Guna2HtmlLabel1.Text = "Show Password"
        '
        'CheckBoxShow
        '
        Me.CheckBoxShow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxShow.Animated = True
        Me.CheckBoxShow.AutoRoundedCorners = True
        Me.CheckBoxShow.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxShow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBoxShow.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBoxShow.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.CheckBoxShow.CheckedState.InnerColor = System.Drawing.Color.White
        Me.CheckBoxShow.Location = New System.Drawing.Point(475, 543)
        Me.CheckBoxShow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxShow.Name = "CheckBoxShow"
        Me.CheckBoxShow.Size = New System.Drawing.Size(35, 20)
        Me.CheckBoxShow.TabIndex = 54
        Me.CheckBoxShow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckBoxShow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckBoxShow.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.CheckBoxShow.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TopGift.My.Resources.Resources.icons8_show_password_27
        Me.PictureBox1.Location = New System.Drawing.Point(427, 537)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPassword.DefaultText = ""
        Me.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPassword.IconLeft = Global.TopGift.My.Resources.Resources.icons8_password_501
        Me.TxtPassword.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtPassword.Location = New System.Drawing.Point(428, 470)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPassword.PlaceholderText = "Password"
        Me.TxtPassword.SelectedText = ""
        Me.TxtPassword.Size = New System.Drawing.Size(221, 30)
        Me.TxtPassword.TabIndex = 57
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtConfirmPassword.DefaultText = ""
        Me.TxtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtConfirmPassword.IconLeft = Global.TopGift.My.Resources.Resources.icons8_password_501
        Me.TxtConfirmPassword.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(868, 470)
        Me.TxtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtConfirmPassword.PlaceholderText = "Confirm Password"
        Me.TxtConfirmPassword.SelectedText = ""
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(221, 30)
        Me.TxtConfirmPassword.TabIndex = 58
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnClear.Animated = True
        Me.BtnClear.AutoRoundedCorners = True
        Me.BtnClear.BackColor = System.Drawing.Color.Transparent
        Me.BtnClear.BorderRadius = 13
        Me.BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnClear.FillColor = System.Drawing.Color.DarkTurquoise
        Me.BtnClear.FillColor2 = System.Drawing.Color.LightSlateGray
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(579, 594)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(81, 28)
        Me.BtnClear.TabIndex = 60
        Me.BtnClear.Text = "Clear"
        '
        'BtnRegister
        '
        Me.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRegister.Animated = True
        Me.BtnRegister.AutoRoundedCorners = True
        Me.BtnRegister.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.BorderRadius = 16
        Me.BtnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRegister.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnRegister.FillColor = System.Drawing.Color.Navy
        Me.BtnRegister.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnRegister.ForeColor = System.Drawing.Color.White
        Me.BtnRegister.Location = New System.Drawing.Point(456, 594)
        Me.BtnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(99, 34)
        Me.BtnRegister.TabIndex = 59
        Me.BtnRegister.Text = "Register"
        '
        'TxtStaffID
        '
        Me.TxtStaffID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtStaffID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtStaffID.DefaultText = ""
        Me.TxtStaffID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtStaffID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtStaffID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtStaffID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtStaffID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtStaffID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtStaffID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtStaffID.IconLeft = Global.TopGift.My.Resources.Resources.icons8_id_60
        Me.TxtStaffID.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtStaffID.Location = New System.Drawing.Point(427, 183)
        Me.TxtStaffID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtStaffID.Name = "TxtStaffID"
        Me.TxtStaffID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtStaffID.PlaceholderText = "Staff ID"
        Me.TxtStaffID.ReadOnly = True
        Me.TxtStaffID.SelectedText = ""
        Me.TxtStaffID.Size = New System.Drawing.Size(221, 30)
        Me.TxtStaffID.TabIndex = 61
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TopGift.My.Resources.Resources.Screenshot_2021_11_25_184631
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1197, 750)
        Me.Controls.Add(Me.TxtStaffID)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.TxtConfirmPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.CheckBoxShow)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblFirstNameNotifier)
        Me.Controls.Add(Me.SurnameWarningIcon)
        Me.Controls.Add(Me.LblSurnameNotifier)
        Me.Controls.Add(Me.FirstNameWarningIcon)
        Me.Controls.Add(Me.TxtSurname)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LblPasswordNotifier)
        Me.Controls.Add(Me.PasswordWarningIcon)
        Me.Controls.Add(Me.LblUsernameNotifier)
        Me.Controls.Add(Me.UsernameWarningIcon)
        Me.Controls.Add(Me.LblEmailNotifier)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmailWarningIcon)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1213, 785)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.SurnameWarningIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstNameWarningIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordWarningIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernameWarningIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailWarningIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TxtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblEmailNotifier As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents EmailWarningIcon As PictureBox
    Friend WithEvents LblUsernameNotifier As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UsernameWarningIcon As PictureBox
    Friend WithEvents LblPasswordNotifier As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PasswordWarningIcon As PictureBox
    Friend WithEvents TxtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtSurname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblSurnameNotifier As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FirstNameWarningIcon As PictureBox
    Friend WithEvents LblFirstNameNotifier As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents SurnameWarningIcon As PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CheckBoxShow As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnClear As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnRegister As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TxtStaffID As Guna.UI2.WinForms.Guna2TextBox
End Class
