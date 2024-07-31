<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Panel_Draw = New Guna.UI2.WinForms.Guna2Panel()
        Me.Cancel_btn = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Pass_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.User_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Ip_Add_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Login_btn = New Guna.UI.WinForms.GunaButton()
        Me.Login_BW = New System.ComponentModel.BackgroundWorker()
        Me.Panel_Draw.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel_Draw
        '
        Me.Panel_Draw.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Draw.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Draw.BorderRadius = 20
        Me.Panel_Draw.BorderThickness = 2
        Me.Panel_Draw.Controls.Add(Me.Cancel_btn)
        Me.Panel_Draw.Controls.Add(Me.GunaLabel3)
        Me.Panel_Draw.Controls.Add(Me.GunaLabel1)
        Me.Panel_Draw.Controls.Add(Me.GunaLabel2)
        Me.Panel_Draw.Controls.Add(Me.Pass_tb)
        Me.Panel_Draw.Controls.Add(Me.User_tb)
        Me.Panel_Draw.Controls.Add(Me.Ip_Add_tb)
        Me.Panel_Draw.Controls.Add(Me.Login_btn)
        Me.Panel_Draw.Location = New System.Drawing.Point(9, 10)
        Me.Panel_Draw.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel_Draw.Name = "Panel_Draw"
        Me.Panel_Draw.ShadowDecoration.Parent = Me.Panel_Draw
        Me.Panel_Draw.Size = New System.Drawing.Size(370, 197)
        Me.Panel_Draw.TabIndex = 50
        '
        'Cancel_btn
        '
        Me.Cancel_btn.Animated = True
        Me.Cancel_btn.AnimationHoverSpeed = 0.07!
        Me.Cancel_btn.AnimationSpeed = 0.03!
        Me.Cancel_btn.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_btn.BaseColor = System.Drawing.Color.Transparent
        Me.Cancel_btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cancel_btn.BorderSize = 3
        Me.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Cancel_btn.FocusedColor = System.Drawing.Color.Empty
        Me.Cancel_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Cancel_btn.ForeColor = System.Drawing.Color.Black
        Me.Cancel_btn.Image = Nothing
        Me.Cancel_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Cancel_btn.Location = New System.Drawing.Point(257, 143)
        Me.Cancel_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cancel_btn.Name = "Cancel_btn"
        Me.Cancel_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cancel_btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cancel_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Cancel_btn.OnHoverImage = Nothing
        Me.Cancel_btn.OnPressedColor = System.Drawing.Color.Black
        Me.Cancel_btn.Radius = 15
        Me.Cancel_btn.Size = New System.Drawing.Size(104, 46)
        Me.Cancel_btn.TabIndex = 4
        Me.Cancel_btn.Text = "Cancel"
        Me.Cancel_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(25, 107)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(90, 21)
        Me.GunaLabel3.TabIndex = 30
        Me.GunaLabel3.Text = "Password :"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(25, 61)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(98, 21)
        Me.GunaLabel1.TabIndex = 29
        Me.GunaLabel1.Text = "User Name:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(25, 15)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(93, 21)
        Me.GunaLabel2.TabIndex = 28
        Me.GunaLabel2.Text = "IP Address:"
        '
        'Pass_tb
        '
        Me.Pass_tb.Animated = True
        Me.Pass_tb.BackColor = System.Drawing.Color.Transparent
        Me.Pass_tb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pass_tb.BorderRadius = 15
        Me.Pass_tb.BorderThickness = 3
        Me.Pass_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Pass_tb.DefaultText = ""
        Me.Pass_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Pass_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Pass_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Pass_tb.DisabledState.Parent = Me.Pass_tb
        Me.Pass_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Pass_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pass_tb.FocusedState.Parent = Me.Pass_tb
        Me.Pass_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Pass_tb.ForeColor = System.Drawing.Color.Black
        Me.Pass_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pass_tb.HoverState.Parent = Me.Pass_tb
        Me.Pass_tb.Location = New System.Drawing.Point(124, 101)
        Me.Pass_tb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pass_tb.Name = "Pass_tb"
        Me.Pass_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pass_tb.PlaceholderForeColor = System.Drawing.Color.Red
        Me.Pass_tb.PlaceholderText = ""
        Me.Pass_tb.SelectedText = ""
        Me.Pass_tb.ShadowDecoration.Parent = Me.Pass_tb
        Me.Pass_tb.Size = New System.Drawing.Size(236, 36)
        Me.Pass_tb.TabIndex = 2
        '
        'User_tb
        '
        Me.User_tb.Animated = True
        Me.User_tb.BackColor = System.Drawing.Color.Transparent
        Me.User_tb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.User_tb.BorderRadius = 15
        Me.User_tb.BorderThickness = 3
        Me.User_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.User_tb.DefaultText = ""
        Me.User_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.User_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.User_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.User_tb.DisabledState.Parent = Me.User_tb
        Me.User_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.User_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.User_tb.FocusedState.Parent = Me.User_tb
        Me.User_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.User_tb.ForeColor = System.Drawing.Color.Black
        Me.User_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.User_tb.HoverState.Parent = Me.User_tb
        Me.User_tb.Location = New System.Drawing.Point(124, 57)
        Me.User_tb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.User_tb.Name = "User_tb"
        Me.User_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.User_tb.PlaceholderForeColor = System.Drawing.Color.Red
        Me.User_tb.PlaceholderText = ""
        Me.User_tb.SelectedText = ""
        Me.User_tb.ShadowDecoration.Parent = Me.User_tb
        Me.User_tb.Size = New System.Drawing.Size(236, 36)
        Me.User_tb.TabIndex = 1
        '
        'Ip_Add_tb
        '
        Me.Ip_Add_tb.Animated = True
        Me.Ip_Add_tb.BackColor = System.Drawing.Color.Transparent
        Me.Ip_Add_tb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ip_Add_tb.BorderRadius = 15
        Me.Ip_Add_tb.BorderThickness = 3
        Me.Ip_Add_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Ip_Add_tb.DefaultText = "192.168.1.240"
        Me.Ip_Add_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Ip_Add_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Ip_Add_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Ip_Add_tb.DisabledState.Parent = Me.Ip_Add_tb
        Me.Ip_Add_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Ip_Add_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ip_Add_tb.FocusedState.Parent = Me.Ip_Add_tb
        Me.Ip_Add_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Ip_Add_tb.ForeColor = System.Drawing.Color.Black
        Me.Ip_Add_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ip_Add_tb.HoverState.Parent = Me.Ip_Add_tb
        Me.Ip_Add_tb.Location = New System.Drawing.Point(124, 11)
        Me.Ip_Add_tb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ip_Add_tb.Name = "Ip_Add_tb"
        Me.Ip_Add_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Ip_Add_tb.PlaceholderForeColor = System.Drawing.Color.Red
        Me.Ip_Add_tb.PlaceholderText = ""
        Me.Ip_Add_tb.SelectedText = ""
        Me.Ip_Add_tb.SelectionStart = 13
        Me.Ip_Add_tb.ShadowDecoration.Parent = Me.Ip_Add_tb
        Me.Ip_Add_tb.Size = New System.Drawing.Size(236, 36)
        Me.Ip_Add_tb.TabIndex = 0
        '
        'Login_btn
        '
        Me.Login_btn.Animated = True
        Me.Login_btn.AnimationHoverSpeed = 0.07!
        Me.Login_btn.AnimationSpeed = 0.03!
        Me.Login_btn.BackColor = System.Drawing.Color.Transparent
        Me.Login_btn.BaseColor = System.Drawing.Color.Transparent
        Me.Login_btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Login_btn.BorderSize = 3
        Me.Login_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Login_btn.FocusedColor = System.Drawing.Color.Empty
        Me.Login_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Login_btn.ForeColor = System.Drawing.Color.Black
        Me.Login_btn.Image = Nothing
        Me.Login_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Login_btn.Location = New System.Drawing.Point(124, 143)
        Me.Login_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Login_btn.Name = "Login_btn"
        Me.Login_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Login_btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Login_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Login_btn.OnHoverImage = Nothing
        Me.Login_btn.OnPressedColor = System.Drawing.Color.Black
        Me.Login_btn.Radius = 15
        Me.Login_btn.Size = New System.Drawing.Size(104, 46)
        Me.Login_btn.TabIndex = 3
        Me.Login_btn.Text = "Login"
        Me.Login_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 219)
        Me.Controls.Add(Me.Panel_Draw)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel_Draw.ResumeLayout(False)
        Me.Panel_Draw.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Panel_Draw As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Login_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Ip_Add_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Pass_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents User_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Cancel_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Login_BW As System.ComponentModel.BackgroundWorker
End Class
