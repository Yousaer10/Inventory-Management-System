<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnViewReminders = New System.Windows.Forms.Button()
        Me.BtnAdmin = New System.Windows.Forms.Button()
        Me.BtnViewRepairs = New System.Windows.Forms.Button()
        Me.BtnSetRepairs = New System.Windows.Forms.Button()
        Me.BtnInventory = New System.Windows.Forms.Button()
        Me.BtnReminders = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(308, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 38)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Inventory"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(308, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Reminders"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(291, 429)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 38)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Set Repairs"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(269, 558)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 38)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "View Repairs"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(320, 679)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 38)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Admin"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(236, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 38)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "View Reminders"
        '
        'BtnViewReminders
        '
        Me.BtnViewReminders.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnViewReminders.AutoSize = True
        Me.BtnViewReminders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnViewReminders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewReminders.Image = Global.TopGift.My.Resources.Resources.icons8_reminders_501
        Me.BtnViewReminders.Location = New System.Drawing.Point(492, 171)
        Me.BtnViewReminders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnViewReminders.Name = "BtnViewReminders"
        Me.BtnViewReminders.Size = New System.Drawing.Size(129, 70)
        Me.BtnViewReminders.TabIndex = 17
        Me.BtnViewReminders.UseVisualStyleBackColor = True
        '
        'BtnAdmin
        '
        Me.BtnAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdmin.AutoSize = True
        Me.BtnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmin.Image = Global.TopGift.My.Resources.Resources.icons8_admin_settings_male_641
        Me.BtnAdmin.Location = New System.Drawing.Point(492, 658)
        Me.BtnAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Size = New System.Drawing.Size(129, 86)
        Me.BtnAdmin.TabIndex = 16
        Me.BtnAdmin.UseVisualStyleBackColor = True
        '
        'BtnViewRepairs
        '
        Me.BtnViewRepairs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnViewRepairs.AutoSize = True
        Me.BtnViewRepairs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnViewRepairs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewRepairs.Image = Global.TopGift.My.Resources.Resources.icons8_repair_64__1_
        Me.BtnViewRepairs.Location = New System.Drawing.Point(492, 537)
        Me.BtnViewRepairs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnViewRepairs.Name = "BtnViewRepairs"
        Me.BtnViewRepairs.Size = New System.Drawing.Size(129, 86)
        Me.BtnViewRepairs.TabIndex = 15
        Me.BtnViewRepairs.UseVisualStyleBackColor = True
        '
        'BtnSetRepairs
        '
        Me.BtnSetRepairs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSetRepairs.AutoSize = True
        Me.BtnSetRepairs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSetRepairs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetRepairs.Image = Global.TopGift.My.Resources.Resources.icons8_repair_64
        Me.BtnSetRepairs.Location = New System.Drawing.Point(492, 408)
        Me.BtnSetRepairs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSetRepairs.Name = "BtnSetRepairs"
        Me.BtnSetRepairs.Size = New System.Drawing.Size(129, 86)
        Me.BtnSetRepairs.TabIndex = 14
        Me.BtnSetRepairs.UseVisualStyleBackColor = True
        '
        'BtnInventory
        '
        Me.BtnInventory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnInventory.AutoSize = True
        Me.BtnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventory.Image = Global.TopGift.My.Resources.Resources.icons8_inventory_64__1_1
        Me.BtnInventory.Location = New System.Drawing.Point(492, 277)
        Me.BtnInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnInventory.Name = "BtnInventory"
        Me.BtnInventory.Size = New System.Drawing.Size(129, 86)
        Me.BtnInventory.TabIndex = 5
        Me.BtnInventory.UseVisualStyleBackColor = True
        '
        'BtnReminders
        '
        Me.BtnReminders.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReminders.AutoSize = True
        Me.BtnReminders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReminders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReminders.Image = Global.TopGift.My.Resources.Resources.icons8_add_reminder_501
        Me.BtnReminders.Location = New System.Drawing.Point(492, 63)
        Me.BtnReminders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReminders.Name = "BtnReminders"
        Me.BtnReminders.Size = New System.Drawing.Size(129, 69)
        Me.BtnReminders.TabIndex = 4
        Me.BtnReminders.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(946, 797)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnViewReminders)
        Me.Controls.Add(Me.BtnAdmin)
        Me.Controls.Add(Me.BtnViewRepairs)
        Me.Controls.Add(Me.BtnSetRepairs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnInventory)
        Me.Controls.Add(Me.BtnReminders)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(839, 750)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnInventory As System.Windows.Forms.Button
    Friend WithEvents BtnReminders As System.Windows.Forms.Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSetRepairs As Button
    Friend WithEvents BtnViewRepairs As Button
    Friend WithEvents BtnAdmin As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnViewReminders As Button
End Class
