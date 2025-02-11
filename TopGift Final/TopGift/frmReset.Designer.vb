<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReset))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblCurrentStaffEmail = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnPasswordClear = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnPasswordConfirm = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnUsernameClear = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnUsernameConfirm = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CheckBoxShow = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtNewUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblUsernameNotifier1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.UsernameWarningIcon1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtConfirmNewUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblUsernameNotifier2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.UsernameWarningIcon2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtConfirmNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblPasswordNotifier1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PasswordWarningIcon1 = New System.Windows.Forms.PictureBox()
        Me.LblPasswordNotifier2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PasswordWarningIcon2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernameWarningIcon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernameWarningIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordWarningIcon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordWarningIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(561, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 35)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Reset Password:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(552, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Staff Email:"
        '
        'LblCurrentStaffEmail
        '
        Me.LblCurrentStaffEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblCurrentStaffEmail.AutoSize = True
        Me.LblCurrentStaffEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblCurrentStaffEmail.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentStaffEmail.ForeColor = System.Drawing.Color.Transparent
        Me.LblCurrentStaffEmail.Location = New System.Drawing.Point(658, 78)
        Me.LblCurrentStaffEmail.Name = "LblCurrentStaffEmail"
        Me.LblCurrentStaffEmail.Size = New System.Drawing.Size(59, 25)
        Me.LblCurrentStaffEmail.TabIndex = 35
        Me.LblCurrentStaffEmail.Text = "Email"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(561, 447)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 35)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Reset Username:"
        '
        'BtnPasswordClear
        '
        Me.BtnPasswordClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPasswordClear.Animated = True
        Me.BtnPasswordClear.AutoRoundedCorners = True
        Me.BtnPasswordClear.BackColor = System.Drawing.Color.Transparent
        Me.BtnPasswordClear.BorderRadius = 13
        Me.BtnPasswordClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPasswordClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPasswordClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPasswordClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPasswordClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPasswordClear.FillColor = System.Drawing.Color.DarkTurquoise
        Me.BtnPasswordClear.FillColor2 = System.Drawing.Color.LightSlateGray
        Me.BtnPasswordClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPasswordClear.ForeColor = System.Drawing.Color.White
        Me.BtnPasswordClear.Location = New System.Drawing.Point(685, 388)
        Me.BtnPasswordClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPasswordClear.Name = "BtnPasswordClear"
        Me.BtnPasswordClear.Size = New System.Drawing.Size(81, 28)
        Me.BtnPasswordClear.TabIndex = 43
        Me.BtnPasswordClear.Text = "Clear"
        '
        'BtnPasswordConfirm
        '
        Me.BtnPasswordConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPasswordConfirm.Animated = True
        Me.BtnPasswordConfirm.AutoRoundedCorners = True
        Me.BtnPasswordConfirm.BackColor = System.Drawing.Color.Transparent
        Me.BtnPasswordConfirm.BorderRadius = 16
        Me.BtnPasswordConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPasswordConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPasswordConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPasswordConfirm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPasswordConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPasswordConfirm.FillColor = System.Drawing.Color.Navy
        Me.BtnPasswordConfirm.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPasswordConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPasswordConfirm.ForeColor = System.Drawing.Color.White
        Me.BtnPasswordConfirm.Location = New System.Drawing.Point(563, 388)
        Me.BtnPasswordConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPasswordConfirm.Name = "BtnPasswordConfirm"
        Me.BtnPasswordConfirm.Size = New System.Drawing.Size(99, 34)
        Me.BtnPasswordConfirm.TabIndex = 42
        Me.BtnPasswordConfirm.Text = "Confirm"
        '
        'BtnUsernameClear
        '
        Me.BtnUsernameClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnUsernameClear.Animated = True
        Me.BtnUsernameClear.AutoRoundedCorners = True
        Me.BtnUsernameClear.BackColor = System.Drawing.Color.Transparent
        Me.BtnUsernameClear.BorderRadius = 13
        Me.BtnUsernameClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUsernameClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUsernameClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUsernameClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUsernameClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUsernameClear.FillColor = System.Drawing.Color.DarkTurquoise
        Me.BtnUsernameClear.FillColor2 = System.Drawing.Color.LightSlateGray
        Me.BtnUsernameClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnUsernameClear.ForeColor = System.Drawing.Color.White
        Me.BtnUsernameClear.Location = New System.Drawing.Point(688, 618)
        Me.BtnUsernameClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUsernameClear.Name = "BtnUsernameClear"
        Me.BtnUsernameClear.Size = New System.Drawing.Size(81, 28)
        Me.BtnUsernameClear.TabIndex = 45
        Me.BtnUsernameClear.Text = "Clear"
        '
        'BtnUsernameConfirm
        '
        Me.BtnUsernameConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnUsernameConfirm.Animated = True
        Me.BtnUsernameConfirm.AutoRoundedCorners = True
        Me.BtnUsernameConfirm.BackColor = System.Drawing.Color.Transparent
        Me.BtnUsernameConfirm.BorderRadius = 16
        Me.BtnUsernameConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUsernameConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUsernameConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUsernameConfirm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUsernameConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUsernameConfirm.FillColor = System.Drawing.Color.Navy
        Me.BtnUsernameConfirm.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUsernameConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnUsernameConfirm.ForeColor = System.Drawing.Color.White
        Me.BtnUsernameConfirm.Location = New System.Drawing.Point(565, 618)
        Me.BtnUsernameConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUsernameConfirm.Name = "BtnUsernameConfirm"
        Me.BtnUsernameConfirm.Size = New System.Drawing.Size(99, 34)
        Me.BtnUsernameConfirm.TabIndex = 44
        Me.BtnUsernameConfirm.Text = "Confirm"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(643, 345)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(134, 27)
        Me.Guna2HtmlLabel1.TabIndex = 47
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
        Me.CheckBoxShow.Location = New System.Drawing.Point(603, 351)
        Me.CheckBoxShow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxShow.Name = "CheckBoxShow"
        Me.CheckBoxShow.Size = New System.Drawing.Size(35, 20)
        Me.CheckBoxShow.TabIndex = 46
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
        Me.PictureBox1.Location = New System.Drawing.Point(555, 345)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'TxtNewUsername
        '
        Me.TxtNewUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNewUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNewUsername.DefaultText = ""
        Me.TxtNewUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtNewUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtNewUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNewUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNewUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNewUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtNewUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNewUsername.IconLeft = Global.TopGift.My.Resources.Resources.icons8_user_64
        Me.TxtNewUsername.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtNewUsername.Location = New System.Drawing.Point(559, 494)
        Me.TxtNewUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNewUsername.Name = "TxtNewUsername"
        Me.TxtNewUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNewUsername.PlaceholderText = "Username"
        Me.TxtNewUsername.SelectedText = ""
        Me.TxtNewUsername.Size = New System.Drawing.Size(221, 30)
        Me.TxtNewUsername.TabIndex = 52
        '
        'LblUsernameNotifier1
        '
        Me.LblUsernameNotifier1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblUsernameNotifier1.BackColor = System.Drawing.Color.Transparent
        Me.LblUsernameNotifier1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsernameNotifier1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblUsernameNotifier1.Location = New System.Drawing.Point(588, 523)
        Me.LblUsernameNotifier1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblUsernameNotifier1.Name = "LblUsernameNotifier1"
        Me.LblUsernameNotifier1.Size = New System.Drawing.Size(164, 22)
        Me.LblUsernameNotifier1.TabIndex = 50
        Me.LblUsernameNotifier1.Text = "Username not available"
        Me.LblUsernameNotifier1.Visible = False
        '
        'UsernameWarningIcon1
        '
        Me.UsernameWarningIcon1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameWarningIcon1.BackColor = System.Drawing.Color.Transparent
        Me.UsernameWarningIcon1.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.UsernameWarningIcon1.Location = New System.Drawing.Point(560, 523)
        Me.UsernameWarningIcon1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UsernameWarningIcon1.Name = "UsernameWarningIcon1"
        Me.UsernameWarningIcon1.Size = New System.Drawing.Size(21, 20)
        Me.UsernameWarningIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UsernameWarningIcon1.TabIndex = 51
        Me.UsernameWarningIcon1.TabStop = False
        Me.UsernameWarningIcon1.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(399, 494)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 25)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "New Username"
        '
        'TxtConfirmNewUsername
        '
        Me.TxtConfirmNewUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtConfirmNewUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtConfirmNewUsername.DefaultText = ""
        Me.TxtConfirmNewUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtConfirmNewUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtConfirmNewUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtConfirmNewUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtConfirmNewUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtConfirmNewUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtConfirmNewUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtConfirmNewUsername.IconLeft = Global.TopGift.My.Resources.Resources.icons8_user_64
        Me.TxtConfirmNewUsername.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtConfirmNewUsername.Location = New System.Drawing.Point(559, 558)
        Me.TxtConfirmNewUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtConfirmNewUsername.Name = "TxtConfirmNewUsername"
        Me.TxtConfirmNewUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtConfirmNewUsername.PlaceholderText = "Confirm Username"
        Me.TxtConfirmNewUsername.SelectedText = ""
        Me.TxtConfirmNewUsername.Size = New System.Drawing.Size(221, 30)
        Me.TxtConfirmNewUsername.TabIndex = 56
        '
        'LblUsernameNotifier2
        '
        Me.LblUsernameNotifier2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblUsernameNotifier2.BackColor = System.Drawing.Color.Transparent
        Me.LblUsernameNotifier2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsernameNotifier2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblUsernameNotifier2.Location = New System.Drawing.Point(588, 588)
        Me.LblUsernameNotifier2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblUsernameNotifier2.Name = "LblUsernameNotifier2"
        Me.LblUsernameNotifier2.Size = New System.Drawing.Size(164, 22)
        Me.LblUsernameNotifier2.TabIndex = 54
        Me.LblUsernameNotifier2.Text = "Username not available"
        Me.LblUsernameNotifier2.Visible = False
        '
        'UsernameWarningIcon2
        '
        Me.UsernameWarningIcon2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameWarningIcon2.BackColor = System.Drawing.Color.Transparent
        Me.UsernameWarningIcon2.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.UsernameWarningIcon2.Location = New System.Drawing.Point(560, 588)
        Me.UsernameWarningIcon2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UsernameWarningIcon2.Name = "UsernameWarningIcon2"
        Me.UsernameWarningIcon2.Size = New System.Drawing.Size(21, 20)
        Me.UsernameWarningIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UsernameWarningIcon2.TabIndex = 55
        Me.UsernameWarningIcon2.TabStop = False
        Me.UsernameWarningIcon2.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(369, 558)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 25)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Confirm Username"
        '
        'TxtConfirmNewPassword
        '
        Me.TxtConfirmNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtConfirmNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtConfirmNewPassword.DefaultText = ""
        Me.TxtConfirmNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtConfirmNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtConfirmNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtConfirmNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtConfirmNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtConfirmNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtConfirmNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtConfirmNewPassword.IconLeft = Global.TopGift.My.Resources.Resources.icons8_password_501
        Me.TxtConfirmNewPassword.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtConfirmNewPassword.Location = New System.Drawing.Point(556, 274)
        Me.TxtConfirmNewPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtConfirmNewPassword.Name = "TxtConfirmNewPassword"
        Me.TxtConfirmNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtConfirmNewPassword.PlaceholderText = "Confirm Password"
        Me.TxtConfirmNewPassword.SelectedText = ""
        Me.TxtConfirmNewPassword.Size = New System.Drawing.Size(221, 30)
        Me.TxtConfirmNewPassword.TabIndex = 62
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNewPassword.DefaultText = ""
        Me.TxtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNewPassword.IconLeft = Global.TopGift.My.Resources.Resources.icons8_password_501
        Me.TxtNewPassword.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.TxtNewPassword.Location = New System.Drawing.Point(559, 206)
        Me.TxtNewPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNewPassword.PlaceholderText = "Password"
        Me.TxtNewPassword.SelectedText = ""
        Me.TxtNewPassword.Size = New System.Drawing.Size(221, 30)
        Me.TxtNewPassword.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(365, 274)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 25)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Confirm Password"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(399, 206)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 25)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "New Password"
        '
        'LblPasswordNotifier1
        '
        Me.LblPasswordNotifier1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblPasswordNotifier1.BackColor = System.Drawing.Color.Transparent
        Me.LblPasswordNotifier1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPasswordNotifier1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblPasswordNotifier1.Location = New System.Drawing.Point(588, 240)
        Me.LblPasswordNotifier1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblPasswordNotifier1.Name = "LblPasswordNotifier1"
        Me.LblPasswordNotifier1.Size = New System.Drawing.Size(271, 22)
        Me.LblPasswordNotifier1.TabIndex = 63
        Me.LblPasswordNotifier1.Text = "Both passwords don't match. Try again."
        Me.LblPasswordNotifier1.Visible = False
        '
        'PasswordWarningIcon1
        '
        Me.PasswordWarningIcon1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordWarningIcon1.BackColor = System.Drawing.Color.Transparent
        Me.PasswordWarningIcon1.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.PasswordWarningIcon1.Location = New System.Drawing.Point(560, 240)
        Me.PasswordWarningIcon1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PasswordWarningIcon1.Name = "PasswordWarningIcon1"
        Me.PasswordWarningIcon1.Size = New System.Drawing.Size(21, 20)
        Me.PasswordWarningIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PasswordWarningIcon1.TabIndex = 64
        Me.PasswordWarningIcon1.TabStop = False
        Me.PasswordWarningIcon1.Visible = False
        '
        'LblPasswordNotifier2
        '
        Me.LblPasswordNotifier2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblPasswordNotifier2.BackColor = System.Drawing.Color.Transparent
        Me.LblPasswordNotifier2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPasswordNotifier2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LblPasswordNotifier2.Location = New System.Drawing.Point(585, 309)
        Me.LblPasswordNotifier2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LblPasswordNotifier2.Name = "LblPasswordNotifier2"
        Me.LblPasswordNotifier2.Size = New System.Drawing.Size(271, 22)
        Me.LblPasswordNotifier2.TabIndex = 65
        Me.LblPasswordNotifier2.Text = "Both passwords don't match. Try again."
        Me.LblPasswordNotifier2.Visible = False
        '
        'PasswordWarningIcon2
        '
        Me.PasswordWarningIcon2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordWarningIcon2.BackColor = System.Drawing.Color.Transparent
        Me.PasswordWarningIcon2.Image = Global.TopGift.My.Resources.Resources.icons8_high_importance_48
        Me.PasswordWarningIcon2.Location = New System.Drawing.Point(557, 309)
        Me.PasswordWarningIcon2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PasswordWarningIcon2.Name = "PasswordWarningIcon2"
        Me.PasswordWarningIcon2.Size = New System.Drawing.Size(21, 20)
        Me.PasswordWarningIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PasswordWarningIcon2.TabIndex = 66
        Me.PasswordWarningIcon2.TabStop = False
        Me.PasswordWarningIcon2.Visible = False
        '
        'frmReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TopGift.My.Resources.Resources.Screenshot_2021_11_25_184636
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1195, 740)
        Me.Controls.Add(Me.LblPasswordNotifier2)
        Me.Controls.Add(Me.PasswordWarningIcon2)
        Me.Controls.Add(Me.LblPasswordNotifier1)
        Me.Controls.Add(Me.PasswordWarningIcon1)
        Me.Controls.Add(Me.TxtConfirmNewPassword)
        Me.Controls.Add(Me.TxtNewPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtConfirmNewUsername)
        Me.Controls.Add(Me.LblUsernameNotifier2)
        Me.Controls.Add(Me.UsernameWarningIcon2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNewUsername)
        Me.Controls.Add(Me.LblUsernameNotifier1)
        Me.Controls.Add(Me.UsernameWarningIcon1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.CheckBoxShow)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnUsernameClear)
        Me.Controls.Add(Me.BtnUsernameConfirm)
        Me.Controls.Add(Me.BtnPasswordClear)
        Me.Controls.Add(Me.BtnPasswordConfirm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblCurrentStaffEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1213, 787)
        Me.Name = "frmReset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernameWarningIcon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernameWarningIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordWarningIcon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordWarningIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblCurrentStaffEmail As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnPasswordClear As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnPasswordConfirm As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnUsernameClear As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnUsernameConfirm As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CheckBoxShow As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtNewUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblUsernameNotifier1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UsernameWarningIcon1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtConfirmNewUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblUsernameNotifier2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UsernameWarningIcon2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtConfirmNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblPasswordNotifier1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PasswordWarningIcon1 As PictureBox
    Friend WithEvents LblPasswordNotifier2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PasswordWarningIcon2 As PictureBox
End Class
