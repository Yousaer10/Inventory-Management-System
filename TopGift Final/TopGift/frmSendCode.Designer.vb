<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSendCode))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnBackToLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnVerify = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnSend = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TxtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtCodeVerify = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(300, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 23)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Verify Code:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(300, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 23)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Email code to:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.5!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(388, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(372, 44)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Send security code:"
        '
        'BtnBackToLogin
        '
        Me.BtnBackToLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnBackToLogin.Animated = True
        Me.BtnBackToLogin.AutoRoundedCorners = True
        Me.BtnBackToLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnBackToLogin.BorderRadius = 20
        Me.BtnBackToLogin.DefaultAutoSize = True
        Me.BtnBackToLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBackToLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBackToLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBackToLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBackToLogin.FillColor = System.Drawing.Color.Transparent
        Me.BtnBackToLogin.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBackToLogin.ForeColor = System.Drawing.Color.White
        Me.BtnBackToLogin.Image = Global.TopGift.My.Resources.Resources.RegisterIcon
        Me.BtnBackToLogin.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtnBackToLogin.Location = New System.Drawing.Point(432, 464)
        Me.BtnBackToLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBackToLogin.Name = "BtnBackToLogin"
        Me.BtnBackToLogin.Size = New System.Drawing.Size(229, 43)
        Me.BtnBackToLogin.TabIndex = 42
        Me.BtnBackToLogin.Text = "Back To Login"
        Me.BtnBackToLogin.UseTransparentBackground = True
        '
        'BtnVerify
        '
        Me.BtnVerify.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnVerify.Animated = True
        Me.BtnVerify.AutoRoundedCorners = True
        Me.BtnVerify.BackColor = System.Drawing.Color.Transparent
        Me.BtnVerify.BorderRadius = 16
        Me.BtnVerify.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnVerify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnVerify.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnVerify.FillColor = System.Drawing.Color.Navy
        Me.BtnVerify.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVerify.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnVerify.ForeColor = System.Drawing.Color.White
        Me.BtnVerify.Location = New System.Drawing.Point(709, 382)
        Me.BtnVerify.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnVerify.Name = "BtnVerify"
        Me.BtnVerify.Size = New System.Drawing.Size(99, 34)
        Me.BtnVerify.TabIndex = 43
        Me.BtnVerify.Text = "Verify"
        '
        'BtnSend
        '
        Me.BtnSend.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSend.Animated = True
        Me.BtnSend.AutoRoundedCorners = True
        Me.BtnSend.BackColor = System.Drawing.Color.Transparent
        Me.BtnSend.BorderRadius = 16
        Me.BtnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSend.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSend.FillColor = System.Drawing.Color.Navy
        Me.BtnSend.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSend.ForeColor = System.Drawing.Color.White
        Me.BtnSend.Location = New System.Drawing.Point(709, 318)
        Me.BtnSend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(99, 34)
        Me.BtnSend.TabIndex = 44
        Me.BtnSend.Text = "Send"
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
        Me.TxtEmail.IconLeft = Global.TopGift.My.Resources.Resources.icons8_email_641
        Me.TxtEmail.Location = New System.Drawing.Point(460, 322)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEmail.PlaceholderText = "Email"
        Me.TxtEmail.SelectedText = ""
        Me.TxtEmail.Size = New System.Drawing.Size(200, 30)
        Me.TxtEmail.TabIndex = 45
        '
        'TxtCodeVerify
        '
        Me.TxtCodeVerify.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCodeVerify.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodeVerify.DefaultText = ""
        Me.TxtCodeVerify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCodeVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCodeVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCodeVerify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCodeVerify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCodeVerify.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtCodeVerify.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCodeVerify.IconLeft = Global.TopGift.My.Resources.Resources.icons8_pin_code_50
        Me.TxtCodeVerify.Location = New System.Drawing.Point(460, 386)
        Me.TxtCodeVerify.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCodeVerify.Name = "TxtCodeVerify"
        Me.TxtCodeVerify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCodeVerify.PlaceholderText = "Code"
        Me.TxtCodeVerify.SelectedText = ""
        Me.TxtCodeVerify.Size = New System.Drawing.Size(144, 30)
        Me.TxtCodeVerify.TabIndex = 46
        '
        'frmSendCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TopGift.My.Resources.Resources.Screenshot_2021_11_25_184636
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1051, 642)
        Me.Controls.Add(Me.TxtCodeVerify)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.BtnVerify)
        Me.Controls.Add(Me.BtnBackToLogin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1069, 689)
        Me.Name = "frmSendCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verify Identity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnBackToLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnVerify As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnSend As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TxtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtCodeVerify As Guna.UI2.WinForms.Guna2TextBox
End Class
