<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CTR_PANEL
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CTR_PANEL))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SideNav1 = New DevComponents.DotNetBar.Controls.SideNav()
        Me.Show_Display_Btn = New Guna.UI.WinForms.GunaButton()
        Me.ToggleFullScreen_sw = New Guna.UI.WinForms.GunaGoogleSwitch()
        Me.ToggleFullScreen_lbl = New Guna.UI.WinForms.GunaLabel()
        Me.FeaturePrize_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Update_btn = New Guna.UI.WinForms.GunaButton()
        Me.winner_list_btn = New Guna.UI.WinForms.GunaButton()
        Me.set_btn = New Guna.UI.WinForms.GunaButton()
        Me.Next_Raffle_Btn = New Guna.UI.WinForms.GunaButton()
        Me.Start_Raffle_btn = New Guna.UI.WinForms.GunaButton()
        Me.Random_Digit_stop_Btn = New Guna.UI.WinForms.GunaButton()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Side_notif_tmr_open = New System.Windows.Forms.Timer(Me.components)
        Me.Side_notif_tmr_close = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_Random_Stop = New System.Windows.Forms.Timer(Me.components)
        Me.Random_Speed_num = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.BW_Pre_Loader_Entries_to_Array = New System.ComponentModel.BackgroundWorker()
        Me.Panel_Draw = New Guna.UI2.WinForms.Guna2Panel()
        Me.Price_Type_ComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Multiple_Draw_RB = New Guna.UI.WinForms.GunaRadioButton()
        Me.Single_Draw_RB = New Guna.UI.WinForms.GunaRadioButton()
        Me.Numberofwinner_numeric = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Batch_no_Lbl = New Guna.UI.WinForms.GunaLabel()
        Me.Batch_win_count_LBL = New Guna.UI.WinForms.GunaLabel()
        Me.Show_Console_Btn = New Guna.UI.WinForms.GunaButton()
        Me.Tot_Part_Lbl = New Guna.UI.WinForms.GunaLabel()
        Me.rch_Stat = New System.Windows.Forms.TextBox()
        Me.BW_Fetch_Winners = New System.ComponentModel.BackgroundWorker()
        Me.Speed_Panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Digit_btn_6 = New Guna.UI.WinForms.GunaButton()
        Me.Digit_btn_5 = New Guna.UI.WinForms.GunaButton()
        Me.Digit_btn_4 = New Guna.UI.WinForms.GunaButton()
        Me.Digit_btn_3 = New Guna.UI.WinForms.GunaButton()
        Me.Digit_btn_2 = New Guna.UI.WinForms.GunaButton()
        Me.Digit_btn_1 = New Guna.UI.WinForms.GunaButton()
        Me.Speed_Digit_6 = New Guna.UI2.WinForms.Guna2VTrackBar()
        Me.Speed_Digit_5 = New Guna.UI2.WinForms.Guna2VTrackBar()
        Me.Speed_Digit_4 = New Guna.UI2.WinForms.Guna2VTrackBar()
        Me.Speed_Digit_3 = New Guna.UI2.WinForms.Guna2VTrackBar()
        Me.Speed_Digit_2 = New Guna.UI2.WinForms.Guna2VTrackBar()
        Me.Speed_Digit_1 = New Guna.UI2.WinForms.Guna2VTrackBar()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Speed_Digit_All = New Guna.UI2.WinForms.Guna2TrackBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Municipality_CB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Side_Panel_Btn = New Guna.UI.WinForms.GunaButton()
        Me.Save_Winner_BW = New System.ComponentModel.BackgroundWorker()
        Me.Rest_Winner_List = New Guna.UI.WinForms.GunaButton()
        Me.Wipe_Winner_BW = New System.ComponentModel.BackgroundWorker()
        Me.Side_Pan_Dis_CB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Soud_play_BW = New System.ComponentModel.BackgroundWorker()
        Me.Export_PDF_Btn = New Guna.UI.WinForms.GunaButton()
        Me.BW_Side_Pan_Load = New System.ComponentModel.BackgroundWorker()
        Me.Blink_Effect_Btn = New Guna.UI.WinForms.GunaButton()
        Me.Blink_Speed_num = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Cancel_Btn = New Guna.UI.WinForms.GunaButton()
        Me.Today_CB = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.BW_Update_batch_Number = New System.ComponentModel.BackgroundWorker()
        Me.tmr_winner_saver_trigger = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Random_Speed_num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Draw.SuspendLayout()
        CType(Me.Numberofwinner_numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Speed_Panel.SuspendLayout()
        CType(Me.Blink_Speed_num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(149, Byte), Integer)))
        '
        'SideNav1
        '
        Me.SideNav1.Location = New System.Drawing.Point(0, 0)
        Me.SideNav1.Name = "SideNav1"
        Me.SideNav1.Padding = New System.Windows.Forms.Padding(1)
        Me.SideNav1.Size = New System.Drawing.Size(0, 0)
        Me.SideNav1.TabIndex = 0
        '
        'Show_Display_Btn
        '
        Me.Show_Display_Btn.Animated = True
        Me.Show_Display_Btn.AnimationHoverSpeed = 0.07!
        Me.Show_Display_Btn.AnimationSpeed = 0.03!
        Me.Show_Display_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Show_Display_Btn.BaseColor = System.Drawing.Color.Transparent
        Me.Show_Display_Btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Show_Display_Btn.BorderSize = 2
        Me.Show_Display_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Show_Display_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Show_Display_Btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Show_Display_Btn.ForeColor = System.Drawing.Color.Black
        Me.Show_Display_Btn.Image = Nothing
        Me.Show_Display_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Show_Display_Btn.Location = New System.Drawing.Point(415, 516)
        Me.Show_Display_Btn.Name = "Show_Display_Btn"
        Me.Show_Display_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Show_Display_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Show_Display_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Show_Display_Btn.OnHoverImage = Nothing
        Me.Show_Display_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Show_Display_Btn.Radius = 26
        Me.Show_Display_Btn.Size = New System.Drawing.Size(211, 57)
        Me.Show_Display_Btn.TabIndex = 4
        Me.Show_Display_Btn.TabStop = False
        Me.Show_Display_Btn.Text = "Show Display Form"
        Me.Show_Display_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToggleFullScreen_sw
        '
        Me.ToggleFullScreen_sw.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ToggleFullScreen_sw.BaseColor = System.Drawing.SystemColors.Control
        Me.ToggleFullScreen_sw.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.ToggleFullScreen_sw.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToggleFullScreen_sw.FillColor = System.Drawing.Color.White
        Me.ToggleFullScreen_sw.Location = New System.Drawing.Point(593, 583)
        Me.ToggleFullScreen_sw.Name = "ToggleFullScreen_sw"
        Me.ToggleFullScreen_sw.Size = New System.Drawing.Size(38, 20)
        Me.ToggleFullScreen_sw.TabIndex = 8
        '
        'ToggleFullScreen_lbl
        '
        Me.ToggleFullScreen_lbl.AutoSize = True
        Me.ToggleFullScreen_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ToggleFullScreen_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleFullScreen_lbl.ForeColor = System.Drawing.Color.Black
        Me.ToggleFullScreen_lbl.Location = New System.Drawing.Point(393, 579)
        Me.ToggleFullScreen_lbl.Name = "ToggleFullScreen_lbl"
        Me.ToggleFullScreen_lbl.Size = New System.Drawing.Size(153, 21)
        Me.ToggleFullScreen_lbl.TabIndex = 9
        Me.ToggleFullScreen_lbl.Text = "Toggle FullScreen :"
        '
        'FeaturePrize_tb
        '
        Me.FeaturePrize_tb.Animated = True
        Me.FeaturePrize_tb.BackColor = System.Drawing.Color.Transparent
        Me.FeaturePrize_tb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FeaturePrize_tb.BorderRadius = 20
        Me.FeaturePrize_tb.BorderThickness = 3
        Me.FeaturePrize_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FeaturePrize_tb.DefaultText = "Prize Name"
        Me.FeaturePrize_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FeaturePrize_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FeaturePrize_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FeaturePrize_tb.DisabledState.Parent = Me.FeaturePrize_tb
        Me.FeaturePrize_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FeaturePrize_tb.Enabled = False
        Me.FeaturePrize_tb.FillColor = System.Drawing.Color.LightGray
        Me.FeaturePrize_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FeaturePrize_tb.FocusedState.Parent = Me.FeaturePrize_tb
        Me.FeaturePrize_tb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FeaturePrize_tb.ForeColor = System.Drawing.Color.Silver
        Me.FeaturePrize_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FeaturePrize_tb.HoverState.Parent = Me.FeaturePrize_tb
        Me.FeaturePrize_tb.Location = New System.Drawing.Point(13, 14)
        Me.FeaturePrize_tb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FeaturePrize_tb.Name = "FeaturePrize_tb"
        Me.FeaturePrize_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FeaturePrize_tb.PlaceholderForeColor = System.Drawing.Color.Red
        Me.FeaturePrize_tb.PlaceholderText = ""
        Me.FeaturePrize_tb.SelectedText = ""
        Me.FeaturePrize_tb.SelectionStart = 10
        Me.FeaturePrize_tb.ShadowDecoration.Parent = Me.FeaturePrize_tb
        Me.FeaturePrize_tb.Size = New System.Drawing.Size(378, 44)
        Me.FeaturePrize_tb.TabIndex = 10
        '
        'Update_btn
        '
        Me.Update_btn.Animated = True
        Me.Update_btn.AnimationHoverSpeed = 0.07!
        Me.Update_btn.AnimationSpeed = 0.03!
        Me.Update_btn.BackColor = System.Drawing.Color.Transparent
        Me.Update_btn.BaseColor = System.Drawing.Color.Transparent
        Me.Update_btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Update_btn.BorderSize = 2
        Me.Update_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Update_btn.FocusedColor = System.Drawing.Color.Empty
        Me.Update_btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Update_btn.ForeColor = System.Drawing.Color.Black
        Me.Update_btn.Image = Nothing
        Me.Update_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Update_btn.Location = New System.Drawing.Point(415, 12)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Update_btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Update_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Update_btn.OnHoverImage = Nothing
        Me.Update_btn.OnPressedColor = System.Drawing.Color.Black
        Me.Update_btn.Radius = 26
        Me.Update_btn.Size = New System.Drawing.Size(211, 57)
        Me.Update_btn.TabIndex = 4
        Me.Update_btn.Text = "Update Raffle Entries"
        Me.Update_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'winner_list_btn
        '
        Me.winner_list_btn.Animated = True
        Me.winner_list_btn.AnimationHoverSpeed = 0.07!
        Me.winner_list_btn.AnimationSpeed = 0.03!
        Me.winner_list_btn.BackColor = System.Drawing.Color.Transparent
        Me.winner_list_btn.BaseColor = System.Drawing.Color.Transparent
        Me.winner_list_btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.winner_list_btn.BorderSize = 2
        Me.winner_list_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.winner_list_btn.Enabled = False
        Me.winner_list_btn.FocusedColor = System.Drawing.Color.Empty
        Me.winner_list_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.winner_list_btn.ForeColor = System.Drawing.Color.Black
        Me.winner_list_btn.Image = Nothing
        Me.winner_list_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.winner_list_btn.Location = New System.Drawing.Point(415, 453)
        Me.winner_list_btn.Name = "winner_list_btn"
        Me.winner_list_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.winner_list_btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.winner_list_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.winner_list_btn.OnHoverImage = Nothing
        Me.winner_list_btn.OnPressedColor = System.Drawing.Color.Black
        Me.winner_list_btn.Radius = 26
        Me.winner_list_btn.Size = New System.Drawing.Size(211, 57)
        Me.winner_list_btn.TabIndex = 16
        Me.winner_list_btn.TabStop = False
        Me.winner_list_btn.Text = "Winner's List"
        Me.winner_list_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'set_btn
        '
        Me.set_btn.Animated = True
        Me.set_btn.AnimationHoverSpeed = 0.07!
        Me.set_btn.AnimationSpeed = 0.03!
        Me.set_btn.BackColor = System.Drawing.Color.Transparent
        Me.set_btn.BaseColor = System.Drawing.Color.Transparent
        Me.set_btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.set_btn.BorderSize = 2
        Me.set_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.set_btn.FocusedColor = System.Drawing.Color.Empty
        Me.set_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.set_btn.ForeColor = System.Drawing.Color.Black
        Me.set_btn.Image = Nothing
        Me.set_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.set_btn.Location = New System.Drawing.Point(221, 50)
        Me.set_btn.Name = "set_btn"
        Me.set_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.set_btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.set_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.set_btn.OnHoverImage = Nothing
        Me.set_btn.OnPressedColor = System.Drawing.Color.Black
        Me.set_btn.Radius = 26
        Me.set_btn.Size = New System.Drawing.Size(127, 57)
        Me.set_btn.TabIndex = 17
        Me.set_btn.Text = "Set"
        Me.set_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Next_Raffle_Btn
        '
        Me.Next_Raffle_Btn.Animated = True
        Me.Next_Raffle_Btn.AnimationHoverSpeed = 0.07!
        Me.Next_Raffle_Btn.AnimationSpeed = 0.03!
        Me.Next_Raffle_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Next_Raffle_Btn.BaseColor = System.Drawing.Color.Transparent
        Me.Next_Raffle_Btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Next_Raffle_Btn.BorderSize = 2
        Me.Next_Raffle_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Next_Raffle_Btn.Enabled = False
        Me.Next_Raffle_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Next_Raffle_Btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Next_Raffle_Btn.ForeColor = System.Drawing.Color.Black
        Me.Next_Raffle_Btn.Image = Nothing
        Me.Next_Raffle_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Next_Raffle_Btn.Location = New System.Drawing.Point(415, 345)
        Me.Next_Raffle_Btn.Name = "Next_Raffle_Btn"
        Me.Next_Raffle_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Next_Raffle_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Next_Raffle_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Next_Raffle_Btn.OnHoverImage = Nothing
        Me.Next_Raffle_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Next_Raffle_Btn.Radius = 26
        Me.Next_Raffle_Btn.Size = New System.Drawing.Size(211, 57)
        Me.Next_Raffle_Btn.TabIndex = 18
        Me.Next_Raffle_Btn.TabStop = False
        Me.Next_Raffle_Btn.Text = "Next Raffle / Reset"
        Me.Next_Raffle_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Start_Raffle_btn
        '
        Me.Start_Raffle_btn.Animated = True
        Me.Start_Raffle_btn.AnimationHoverSpeed = 0.07!
        Me.Start_Raffle_btn.AnimationSpeed = 0.03!
        Me.Start_Raffle_btn.BackColor = System.Drawing.Color.Transparent
        Me.Start_Raffle_btn.BaseColor = System.Drawing.Color.Transparent
        Me.Start_Raffle_btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Start_Raffle_btn.BorderSize = 2
        Me.Start_Raffle_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Start_Raffle_btn.Enabled = False
        Me.Start_Raffle_btn.FocusedColor = System.Drawing.Color.Empty
        Me.Start_Raffle_btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Start_Raffle_btn.ForeColor = System.Drawing.Color.Black
        Me.Start_Raffle_btn.Image = Nothing
        Me.Start_Raffle_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Start_Raffle_btn.Location = New System.Drawing.Point(1, 201)
        Me.Start_Raffle_btn.Name = "Start_Raffle_btn"
        Me.Start_Raffle_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Start_Raffle_btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Start_Raffle_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Start_Raffle_btn.OnHoverImage = Nothing
        Me.Start_Raffle_btn.OnPressedColor = System.Drawing.Color.Black
        Me.Start_Raffle_btn.Radius = 26
        Me.Start_Raffle_btn.Size = New System.Drawing.Size(191, 57)
        Me.Start_Raffle_btn.TabIndex = 19
        Me.Start_Raffle_btn.Text = "Start Raffle"
        Me.Start_Raffle_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Random_Digit_stop_Btn
        '
        Me.Random_Digit_stop_Btn.Animated = True
        Me.Random_Digit_stop_Btn.AnimationHoverSpeed = 0.07!
        Me.Random_Digit_stop_Btn.AnimationSpeed = 0.03!
        Me.Random_Digit_stop_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Random_Digit_stop_Btn.BaseColor = System.Drawing.Color.Transparent
        Me.Random_Digit_stop_Btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Random_Digit_stop_Btn.BorderSize = 2
        Me.Random_Digit_stop_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Random_Digit_stop_Btn.Enabled = False
        Me.Random_Digit_stop_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Random_Digit_stop_Btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Random_Digit_stop_Btn.ForeColor = System.Drawing.Color.Black
        Me.Random_Digit_stop_Btn.Image = Nothing
        Me.Random_Digit_stop_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Random_Digit_stop_Btn.Location = New System.Drawing.Point(200, 201)
        Me.Random_Digit_stop_Btn.Name = "Random_Digit_stop_Btn"
        Me.Random_Digit_stop_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Random_Digit_stop_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Random_Digit_stop_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Random_Digit_stop_Btn.OnHoverImage = Nothing
        Me.Random_Digit_stop_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Random_Digit_stop_Btn.Radius = 26
        Me.Random_Digit_stop_Btn.Size = New System.Drawing.Size(191, 57)
        Me.Random_Digit_stop_Btn.TabIndex = 20
        Me.Random_Digit_stop_Btn.Text = "Random Digit Stop"
        Me.Random_Digit_stop_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Random_Digit_stop_Btn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'Side_notif_tmr_open
        '
        Me.Side_notif_tmr_open.Interval = 1
        '
        'Side_notif_tmr_close
        '
        Me.Side_notif_tmr_close.Interval = 1
        '
        'tmr_Random_Stop
        '
        Me.tmr_Random_Stop.Interval = 1000
        '
        'Random_Speed_num
        '
        Me.Random_Speed_num.BackColor = System.Drawing.Color.Transparent
        Me.Random_Speed_num.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Random_Speed_num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Random_Speed_num.DecimalPlaces = 2
        Me.Random_Speed_num.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Random_Speed_num.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Random_Speed_num.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Random_Speed_num.DisabledState.Parent = Me.Random_Speed_num
        Me.Random_Speed_num.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Random_Speed_num.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Random_Speed_num.Enabled = False
        Me.Random_Speed_num.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Random_Speed_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Random_Speed_num.FocusedState.Parent = Me.Random_Speed_num
        Me.Random_Speed_num.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Random_Speed_num.ForeColor = System.Drawing.Color.Transparent
        Me.Random_Speed_num.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Random_Speed_num.Location = New System.Drawing.Point(526, 411)
        Me.Random_Speed_num.Name = "Random_Speed_num"
        Me.Random_Speed_num.ShadowDecoration.Parent = Me.Random_Speed_num
        Me.Random_Speed_num.Size = New System.Drawing.Size(100, 36)
        Me.Random_Speed_num.TabIndex = 44
        Me.Random_Speed_num.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(383, 421)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(137, 21)
        Me.GunaLabel3.TabIndex = 45
        Me.GunaLabel3.Text = "Random Speed : "
        '
        'BW_Pre_Loader_Entries_to_Array
        '
        Me.BW_Pre_Loader_Entries_to_Array.WorkerReportsProgress = True
        Me.BW_Pre_Loader_Entries_to_Array.WorkerSupportsCancellation = True
        '
        'Panel_Draw
        '
        Me.Panel_Draw.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Draw.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Draw.BorderRadius = 20
        Me.Panel_Draw.BorderThickness = 2
        Me.Panel_Draw.Controls.Add(Me.Price_Type_ComboBox)
        Me.Panel_Draw.Controls.Add(Me.Multiple_Draw_RB)
        Me.Panel_Draw.Controls.Add(Me.Single_Draw_RB)
        Me.Panel_Draw.Controls.Add(Me.Numberofwinner_numeric)
        Me.Panel_Draw.Controls.Add(Me.set_btn)
        Me.Panel_Draw.Enabled = False
        Me.Panel_Draw.Location = New System.Drawing.Point(14, 66)
        Me.Panel_Draw.Name = "Panel_Draw"
        Me.Panel_Draw.ShadowDecoration.Parent = Me.Panel_Draw
        Me.Panel_Draw.Size = New System.Drawing.Size(377, 121)
        Me.Panel_Draw.TabIndex = 49
        '
        'Price_Type_ComboBox
        '
        Me.Price_Type_ComboBox.Animated = True
        Me.Price_Type_ComboBox.BackColor = System.Drawing.Color.Transparent
        Me.Price_Type_ComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Price_Type_ComboBox.BorderRadius = 15
        Me.Price_Type_ComboBox.BorderThickness = 2
        Me.Price_Type_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Price_Type_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Price_Type_ComboBox.FillColor = System.Drawing.Color.LightGray
        Me.Price_Type_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Price_Type_ComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.Price_Type_ComboBox.FocusedState.Parent = Me.Price_Type_ComboBox
        Me.Price_Type_ComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Price_Type_ComboBox.ForeColor = System.Drawing.Color.Black
        Me.Price_Type_ComboBox.FormattingEnabled = True
        Me.Price_Type_ComboBox.HoverState.Parent = Me.Price_Type_ComboBox
        Me.Price_Type_ComboBox.ItemHeight = 30
        Me.Price_Type_ComboBox.Items.AddRange(New Object() {"Consolation Prize", "5th Grand Prize", "4th Grand Prize", "3rd Grand Prize", "2nd Grand Prize", "1st Grand Prize"})
        Me.Price_Type_ComboBox.ItemsAppearance.Parent = Me.Price_Type_ComboBox
        Me.Price_Type_ComboBox.Location = New System.Drawing.Point(154, 8)
        Me.Price_Type_ComboBox.Name = "Price_Type_ComboBox"
        Me.Price_Type_ComboBox.ShadowDecoration.Parent = Me.Price_Type_ComboBox
        Me.Price_Type_ComboBox.Size = New System.Drawing.Size(211, 36)
        Me.Price_Type_ComboBox.StartIndex = 0
        Me.Price_Type_ComboBox.TabIndex = 62
        '
        'Multiple_Draw_RB
        '
        Me.Multiple_Draw_RB.BaseColor = System.Drawing.SystemColors.Control
        Me.Multiple_Draw_RB.CheckedOffColor = System.Drawing.Color.Gray
        Me.Multiple_Draw_RB.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Multiple_Draw_RB.FillColor = System.Drawing.Color.Transparent
        Me.Multiple_Draw_RB.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Multiple_Draw_RB.Location = New System.Drawing.Point(9, 41)
        Me.Multiple_Draw_RB.Name = "Multiple_Draw_RB"
        Me.Multiple_Draw_RB.Size = New System.Drawing.Size(132, 23)
        Me.Multiple_Draw_RB.TabIndex = 51
        Me.Multiple_Draw_RB.Text = "Multiple Draw"
        '
        'Single_Draw_RB
        '
        Me.Single_Draw_RB.BaseColor = System.Drawing.SystemColors.Control
        Me.Single_Draw_RB.Checked = True
        Me.Single_Draw_RB.CheckedOffColor = System.Drawing.Color.Gray
        Me.Single_Draw_RB.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Single_Draw_RB.FillColor = System.Drawing.Color.Transparent
        Me.Single_Draw_RB.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Single_Draw_RB.Location = New System.Drawing.Point(9, 13)
        Me.Single_Draw_RB.Name = "Single_Draw_RB"
        Me.Single_Draw_RB.Size = New System.Drawing.Size(116, 23)
        Me.Single_Draw_RB.TabIndex = 50
        Me.Single_Draw_RB.Text = "Single Draw"
        '
        'Numberofwinner_numeric
        '
        Me.Numberofwinner_numeric.BackColor = System.Drawing.Color.Transparent
        Me.Numberofwinner_numeric.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Numberofwinner_numeric.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Numberofwinner_numeric.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Numberofwinner_numeric.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Numberofwinner_numeric.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Numberofwinner_numeric.DisabledState.Parent = Me.Numberofwinner_numeric
        Me.Numberofwinner_numeric.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Numberofwinner_numeric.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Numberofwinner_numeric.Enabled = False
        Me.Numberofwinner_numeric.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Numberofwinner_numeric.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Numberofwinner_numeric.FocusedState.Parent = Me.Numberofwinner_numeric
        Me.Numberofwinner_numeric.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numberofwinner_numeric.ForeColor = System.Drawing.Color.Transparent
        Me.Numberofwinner_numeric.Location = New System.Drawing.Point(28, 76)
        Me.Numberofwinner_numeric.Name = "Numberofwinner_numeric"
        Me.Numberofwinner_numeric.ShadowDecoration.Parent = Me.Numberofwinner_numeric
        Me.Numberofwinner_numeric.Size = New System.Drawing.Size(100, 36)
        Me.Numberofwinner_numeric.TabIndex = 49
        Me.Numberofwinner_numeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Batch_no_Lbl
        '
        Me.Batch_no_Lbl.AutoSize = True
        Me.Batch_no_Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Batch_no_Lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batch_no_Lbl.ForeColor = System.Drawing.Color.Black
        Me.Batch_no_Lbl.Location = New System.Drawing.Point(640, 478)
        Me.Batch_no_Lbl.Name = "Batch_no_Lbl"
        Me.Batch_no_Lbl.Size = New System.Drawing.Size(74, 21)
        Me.Batch_no_Lbl.TabIndex = 54
        Me.Batch_no_Lbl.Text = "Batch # :"
        '
        'Batch_win_count_LBL
        '
        Me.Batch_win_count_LBL.AutoSize = True
        Me.Batch_win_count_LBL.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Batch_win_count_LBL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batch_win_count_LBL.ForeColor = System.Drawing.Color.Black
        Me.Batch_win_count_LBL.Location = New System.Drawing.Point(640, 506)
        Me.Batch_win_count_LBL.Name = "Batch_win_count_LBL"
        Me.Batch_win_count_LBL.Size = New System.Drawing.Size(171, 21)
        Me.Batch_win_count_LBL.TabIndex = 55
        Me.Batch_win_count_LBL.Text = "Batch Winner Count :"
        '
        'Show_Console_Btn
        '
        Me.Show_Console_Btn.Animated = True
        Me.Show_Console_Btn.AnimationHoverSpeed = 0.07!
        Me.Show_Console_Btn.AnimationSpeed = 0.03!
        Me.Show_Console_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Show_Console_Btn.BaseColor = System.Drawing.Color.Transparent
        Me.Show_Console_Btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Show_Console_Btn.BorderSize = 2
        Me.Show_Console_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Show_Console_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Show_Console_Btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Show_Console_Btn.ForeColor = System.Drawing.Color.Black
        Me.Show_Console_Btn.Image = Nothing
        Me.Show_Console_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Show_Console_Btn.Location = New System.Drawing.Point(415, 607)
        Me.Show_Console_Btn.Name = "Show_Console_Btn"
        Me.Show_Console_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Show_Console_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Show_Console_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Show_Console_Btn.OnHoverImage = Nothing
        Me.Show_Console_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Show_Console_Btn.Radius = 26
        Me.Show_Console_Btn.Size = New System.Drawing.Size(211, 57)
        Me.Show_Console_Btn.TabIndex = 57
        Me.Show_Console_Btn.TabStop = False
        Me.Show_Console_Btn.Text = "Show Console"
        Me.Show_Console_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tot_Part_Lbl
        '
        Me.Tot_Part_Lbl.AutoSize = True
        Me.Tot_Part_Lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Tot_Part_Lbl.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tot_Part_Lbl.ForeColor = System.Drawing.Color.Black
        Me.Tot_Part_Lbl.Location = New System.Drawing.Point(641, 450)
        Me.Tot_Part_Lbl.Name = "Tot_Part_Lbl"
        Me.Tot_Part_Lbl.Size = New System.Drawing.Size(137, 19)
        Me.Tot_Part_Lbl.TabIndex = 58
        Me.Tot_Part_Lbl.Text = "Total Participants : "
        '
        'rch_Stat
        '
        Me.rch_Stat.BackColor = System.Drawing.Color.Black
        Me.rch_Stat.ForeColor = System.Drawing.Color.Black
        Me.rch_Stat.Location = New System.Drawing.Point(633, 12)
        Me.rch_Stat.Multiline = True
        Me.rch_Stat.Name = "rch_Stat"
        Me.rch_Stat.ReadOnly = True
        Me.rch_Stat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.rch_Stat.Size = New System.Drawing.Size(344, 435)
        Me.rch_Stat.TabIndex = 60
        Me.rch_Stat.WordWrap = False
        '
        'BW_Fetch_Winners
        '
        Me.BW_Fetch_Winners.WorkerReportsProgress = True
        Me.BW_Fetch_Winners.WorkerSupportsCancellation = True
        '
        'Speed_Panel
        '
        Me.Speed_Panel.BackColor = System.Drawing.Color.Transparent
        Me.Speed_Panel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Speed_Panel.BorderRadius = 20
        Me.Speed_Panel.BorderThickness = 2
        Me.Speed_Panel.Controls.Add(Me.Digit_btn_6)
        Me.Speed_Panel.Controls.Add(Me.Digit_btn_5)
        Me.Speed_Panel.Controls.Add(Me.Digit_btn_4)
        Me.Speed_Panel.Controls.Add(Me.Digit_btn_3)
        Me.Speed_Panel.Controls.Add(Me.Digit_btn_2)
        Me.Speed_Panel.Controls.Add(Me.Digit_btn_1)
        Me.Speed_Panel.Controls.Add(Me.Speed_Digit_6)
        Me.Speed_Panel.Controls.Add(Me.Speed_Digit_5)
        Me.Speed_Panel.Controls.Add(Me.Speed_Digit_4)
        Me.Speed_Panel.Controls.Add(Me.Speed_Digit_3)
        Me.Speed_Panel.Controls.Add(Me.Speed_Digit_2)
        Me.Speed_Panel.Controls.Add(Me.Speed_Digit_1)
        Me.Speed_Panel.Controls.Add(Me.GunaLabel2)
        Me.Speed_Panel.Controls.Add(Me.GunaLabel1)
        Me.Speed_Panel.Controls.Add(Me.Speed_Digit_All)
        Me.Speed_Panel.Enabled = False
        Me.Speed_Panel.Location = New System.Drawing.Point(14, 275)
        Me.Speed_Panel.Name = "Speed_Panel"
        Me.Speed_Panel.ShadowDecoration.Parent = Me.Speed_Panel
        Me.Speed_Panel.Size = New System.Drawing.Size(357, 381)
        Me.Speed_Panel.TabIndex = 52
        '
        'Digit_btn_6
        '
        Me.Digit_btn_6.Animated = True
        Me.Digit_btn_6.AnimationHoverSpeed = 0.07!
        Me.Digit_btn_6.AnimationSpeed = 0.03!
        Me.Digit_btn_6.BackColor = System.Drawing.Color.Transparent
        Me.Digit_btn_6.BaseColor = System.Drawing.Color.Transparent
        Me.Digit_btn_6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_6.BorderSize = 2
        Me.Digit_btn_6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Digit_btn_6.FocusedColor = System.Drawing.Color.Empty
        Me.Digit_btn_6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Digit_btn_6.ForeColor = System.Drawing.Color.Black
        Me.Digit_btn_6.Image = Nothing
        Me.Digit_btn_6.ImageSize = New System.Drawing.Size(20, 20)
        Me.Digit_btn_6.Location = New System.Drawing.Point(293, 32)
        Me.Digit_btn_6.Name = "Digit_btn_6"
        Me.Digit_btn_6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_6.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_6.OnHoverForeColor = System.Drawing.Color.White
        Me.Digit_btn_6.OnHoverImage = Nothing
        Me.Digit_btn_6.OnPressedColor = System.Drawing.Color.Black
        Me.Digit_btn_6.Radius = 26
        Me.Digit_btn_6.Size = New System.Drawing.Size(55, 57)
        Me.Digit_btn_6.TabIndex = 58
        Me.Digit_btn_6.Text = "6"
        Me.Digit_btn_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Digit_btn_5
        '
        Me.Digit_btn_5.Animated = True
        Me.Digit_btn_5.AnimationHoverSpeed = 0.07!
        Me.Digit_btn_5.AnimationSpeed = 0.03!
        Me.Digit_btn_5.BackColor = System.Drawing.Color.Transparent
        Me.Digit_btn_5.BaseColor = System.Drawing.Color.Transparent
        Me.Digit_btn_5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_5.BorderSize = 2
        Me.Digit_btn_5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Digit_btn_5.FocusedColor = System.Drawing.Color.Empty
        Me.Digit_btn_5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Digit_btn_5.ForeColor = System.Drawing.Color.Black
        Me.Digit_btn_5.Image = Nothing
        Me.Digit_btn_5.ImageSize = New System.Drawing.Size(20, 20)
        Me.Digit_btn_5.Location = New System.Drawing.Point(236, 32)
        Me.Digit_btn_5.Name = "Digit_btn_5"
        Me.Digit_btn_5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_5.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_5.OnHoverForeColor = System.Drawing.Color.White
        Me.Digit_btn_5.OnHoverImage = Nothing
        Me.Digit_btn_5.OnPressedColor = System.Drawing.Color.Black
        Me.Digit_btn_5.Radius = 26
        Me.Digit_btn_5.Size = New System.Drawing.Size(55, 57)
        Me.Digit_btn_5.TabIndex = 57
        Me.Digit_btn_5.Text = "5"
        Me.Digit_btn_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Digit_btn_4
        '
        Me.Digit_btn_4.Animated = True
        Me.Digit_btn_4.AnimationHoverSpeed = 0.07!
        Me.Digit_btn_4.AnimationSpeed = 0.03!
        Me.Digit_btn_4.BackColor = System.Drawing.Color.Transparent
        Me.Digit_btn_4.BaseColor = System.Drawing.Color.Transparent
        Me.Digit_btn_4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_4.BorderSize = 2
        Me.Digit_btn_4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Digit_btn_4.FocusedColor = System.Drawing.Color.Empty
        Me.Digit_btn_4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Digit_btn_4.ForeColor = System.Drawing.Color.Black
        Me.Digit_btn_4.Image = Nothing
        Me.Digit_btn_4.ImageSize = New System.Drawing.Size(20, 20)
        Me.Digit_btn_4.Location = New System.Drawing.Point(178, 32)
        Me.Digit_btn_4.Name = "Digit_btn_4"
        Me.Digit_btn_4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_4.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_4.OnHoverForeColor = System.Drawing.Color.White
        Me.Digit_btn_4.OnHoverImage = Nothing
        Me.Digit_btn_4.OnPressedColor = System.Drawing.Color.Black
        Me.Digit_btn_4.Radius = 26
        Me.Digit_btn_4.Size = New System.Drawing.Size(55, 57)
        Me.Digit_btn_4.TabIndex = 56
        Me.Digit_btn_4.Text = "4"
        Me.Digit_btn_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Digit_btn_3
        '
        Me.Digit_btn_3.Animated = True
        Me.Digit_btn_3.AnimationHoverSpeed = 0.07!
        Me.Digit_btn_3.AnimationSpeed = 0.03!
        Me.Digit_btn_3.BackColor = System.Drawing.Color.Transparent
        Me.Digit_btn_3.BaseColor = System.Drawing.Color.Transparent
        Me.Digit_btn_3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_3.BorderSize = 2
        Me.Digit_btn_3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Digit_btn_3.FocusedColor = System.Drawing.Color.Empty
        Me.Digit_btn_3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Digit_btn_3.ForeColor = System.Drawing.Color.Black
        Me.Digit_btn_3.Image = Nothing
        Me.Digit_btn_3.ImageSize = New System.Drawing.Size(20, 20)
        Me.Digit_btn_3.Location = New System.Drawing.Point(120, 32)
        Me.Digit_btn_3.Name = "Digit_btn_3"
        Me.Digit_btn_3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_3.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_3.OnHoverForeColor = System.Drawing.Color.White
        Me.Digit_btn_3.OnHoverImage = Nothing
        Me.Digit_btn_3.OnPressedColor = System.Drawing.Color.Black
        Me.Digit_btn_3.Radius = 26
        Me.Digit_btn_3.Size = New System.Drawing.Size(55, 57)
        Me.Digit_btn_3.TabIndex = 55
        Me.Digit_btn_3.Text = "3"
        Me.Digit_btn_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Digit_btn_2
        '
        Me.Digit_btn_2.Animated = True
        Me.Digit_btn_2.AnimationHoverSpeed = 0.07!
        Me.Digit_btn_2.AnimationSpeed = 0.03!
        Me.Digit_btn_2.BackColor = System.Drawing.Color.Transparent
        Me.Digit_btn_2.BaseColor = System.Drawing.Color.Transparent
        Me.Digit_btn_2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_2.BorderSize = 2
        Me.Digit_btn_2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Digit_btn_2.FocusedColor = System.Drawing.Color.Empty
        Me.Digit_btn_2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Digit_btn_2.ForeColor = System.Drawing.Color.Black
        Me.Digit_btn_2.Image = Nothing
        Me.Digit_btn_2.ImageSize = New System.Drawing.Size(20, 20)
        Me.Digit_btn_2.Location = New System.Drawing.Point(61, 32)
        Me.Digit_btn_2.Name = "Digit_btn_2"
        Me.Digit_btn_2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_2.OnHoverForeColor = System.Drawing.Color.White
        Me.Digit_btn_2.OnHoverImage = Nothing
        Me.Digit_btn_2.OnPressedColor = System.Drawing.Color.Black
        Me.Digit_btn_2.Radius = 26
        Me.Digit_btn_2.Size = New System.Drawing.Size(55, 57)
        Me.Digit_btn_2.TabIndex = 54
        Me.Digit_btn_2.Text = "2"
        Me.Digit_btn_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Digit_btn_1
        '
        Me.Digit_btn_1.Animated = True
        Me.Digit_btn_1.AnimationHoverSpeed = 0.07!
        Me.Digit_btn_1.AnimationSpeed = 0.03!
        Me.Digit_btn_1.BackColor = System.Drawing.Color.Transparent
        Me.Digit_btn_1.BaseColor = System.Drawing.Color.Transparent
        Me.Digit_btn_1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_1.BorderSize = 2
        Me.Digit_btn_1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Digit_btn_1.FocusedColor = System.Drawing.Color.Empty
        Me.Digit_btn_1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Digit_btn_1.ForeColor = System.Drawing.Color.Black
        Me.Digit_btn_1.Image = Nothing
        Me.Digit_btn_1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Digit_btn_1.Location = New System.Drawing.Point(2, 32)
        Me.Digit_btn_1.Name = "Digit_btn_1"
        Me.Digit_btn_1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Digit_btn_1.OnHoverForeColor = System.Drawing.Color.White
        Me.Digit_btn_1.OnHoverImage = Nothing
        Me.Digit_btn_1.OnPressedColor = System.Drawing.Color.Black
        Me.Digit_btn_1.Radius = 26
        Me.Digit_btn_1.Size = New System.Drawing.Size(55, 57)
        Me.Digit_btn_1.TabIndex = 53
        Me.Digit_btn_1.Text = "1"
        Me.Digit_btn_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Speed_Digit_6
        '
        Me.Speed_Digit_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Speed_Digit_6.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Speed_Digit_6.HoverState.Parent = Me.Speed_Digit_6
        Me.Speed_Digit_6.Location = New System.Drawing.Point(308, 95)
        Me.Speed_Digit_6.Minimum = 5
        Me.Speed_Digit_6.Name = "Speed_Digit_6"
        Me.Speed_Digit_6.Size = New System.Drawing.Size(23, 207)
        Me.Speed_Digit_6.TabIndex = 52
        Me.Speed_Digit_6.TabStop = False
        Me.Speed_Digit_6.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Speed_Digit_6.Value = 30
        '
        'Speed_Digit_5
        '
        Me.Speed_Digit_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Speed_Digit_5.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Speed_Digit_5.HoverState.Parent = Me.Speed_Digit_5
        Me.Speed_Digit_5.Location = New System.Drawing.Point(253, 95)
        Me.Speed_Digit_5.Minimum = 5
        Me.Speed_Digit_5.Name = "Speed_Digit_5"
        Me.Speed_Digit_5.Size = New System.Drawing.Size(23, 207)
        Me.Speed_Digit_5.TabIndex = 51
        Me.Speed_Digit_5.TabStop = False
        Me.Speed_Digit_5.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Speed_Digit_5.Value = 30
        '
        'Speed_Digit_4
        '
        Me.Speed_Digit_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Speed_Digit_4.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Speed_Digit_4.HoverState.Parent = Me.Speed_Digit_4
        Me.Speed_Digit_4.Location = New System.Drawing.Point(197, 95)
        Me.Speed_Digit_4.Minimum = 5
        Me.Speed_Digit_4.Name = "Speed_Digit_4"
        Me.Speed_Digit_4.Size = New System.Drawing.Size(23, 207)
        Me.Speed_Digit_4.TabIndex = 55
        Me.Speed_Digit_4.TabStop = False
        Me.Speed_Digit_4.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Speed_Digit_4.Value = 30
        '
        'Speed_Digit_3
        '
        Me.Speed_Digit_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Speed_Digit_3.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Speed_Digit_3.HoverState.Parent = Me.Speed_Digit_3
        Me.Speed_Digit_3.Location = New System.Drawing.Point(138, 95)
        Me.Speed_Digit_3.Minimum = 5
        Me.Speed_Digit_3.Name = "Speed_Digit_3"
        Me.Speed_Digit_3.Size = New System.Drawing.Size(23, 207)
        Me.Speed_Digit_3.TabIndex = 30
        Me.Speed_Digit_3.TabStop = False
        Me.Speed_Digit_3.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Speed_Digit_3.Value = 30
        '
        'Speed_Digit_2
        '
        Me.Speed_Digit_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Speed_Digit_2.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Speed_Digit_2.HoverState.Parent = Me.Speed_Digit_2
        Me.Speed_Digit_2.Location = New System.Drawing.Point(81, 95)
        Me.Speed_Digit_2.Minimum = 5
        Me.Speed_Digit_2.Name = "Speed_Digit_2"
        Me.Speed_Digit_2.Size = New System.Drawing.Size(23, 207)
        Me.Speed_Digit_2.TabIndex = 20
        Me.Speed_Digit_2.TabStop = False
        Me.Speed_Digit_2.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Speed_Digit_2.Value = 30
        '
        'Speed_Digit_1
        '
        Me.Speed_Digit_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Speed_Digit_1.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Speed_Digit_1.HoverState.Parent = Me.Speed_Digit_1
        Me.Speed_Digit_1.Location = New System.Drawing.Point(21, 95)
        Me.Speed_Digit_1.Minimum = 5
        Me.Speed_Digit_1.Name = "Speed_Digit_1"
        Me.Speed_Digit_1.Size = New System.Drawing.Size(23, 207)
        Me.Speed_Digit_1.TabIndex = 50
        Me.Speed_Digit_1.TabStop = False
        Me.Speed_Digit_1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Speed_Digit_1.Value = 30
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(3, 1)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(157, 21)
        Me.GunaLabel2.TabIndex = 46
        Me.GunaLabel2.Text = "Digit Manual Stop :"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GunaLabel1.Enabled = False
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 305)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(99, 21)
        Me.GunaLabel1.TabIndex = 45
        Me.GunaLabel1.Text = "Roll Speed :"
        '
        'Speed_Digit_All
        '
        Me.Speed_Digit_All.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Speed_Digit_All.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Speed_Digit_All.HoverState.Parent = Me.Speed_Digit_All
        Me.Speed_Digit_All.Location = New System.Drawing.Point(12, 347)
        Me.Speed_Digit_All.Minimum = 5
        Me.Speed_Digit_All.Name = "Speed_Digit_All"
        Me.Speed_Digit_All.Size = New System.Drawing.Size(333, 23)
        Me.Speed_Digit_All.TabIndex = 0
        Me.Speed_Digit_All.TabStop = False
        Me.Speed_Digit_All.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Speed_Digit_All.Value = 30
        '
        'Municipality_CB
        '
        Me.Municipality_CB.Animated = True
        Me.Municipality_CB.BackColor = System.Drawing.Color.Transparent
        Me.Municipality_CB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Municipality_CB.BorderRadius = 15
        Me.Municipality_CB.BorderThickness = 2
        Me.Municipality_CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Municipality_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Municipality_CB.FillColor = System.Drawing.Color.LightGray
        Me.Municipality_CB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Municipality_CB.FocusedColor = System.Drawing.Color.Empty
        Me.Municipality_CB.FocusedState.Parent = Me.Municipality_CB
        Me.Municipality_CB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Municipality_CB.ForeColor = System.Drawing.Color.Black
        Me.Municipality_CB.FormattingEnabled = True
        Me.Municipality_CB.HoverState.Parent = Me.Municipality_CB
        Me.Municipality_CB.ItemHeight = 30
        Me.Municipality_CB.Items.AddRange(New Object() {"All", "NAVAL", "BILIRAN", "CABUCGAYAN", "CAIBIRAN", "CULABA", "KAWAYAN", "ALMERIA"})
        Me.Municipality_CB.ItemsAppearance.Parent = Me.Municipality_CB
        Me.Municipality_CB.Location = New System.Drawing.Point(415, 75)
        Me.Municipality_CB.Name = "Municipality_CB"
        Me.Municipality_CB.ShadowDecoration.Parent = Me.Municipality_CB
        Me.Municipality_CB.Size = New System.Drawing.Size(211, 36)
        Me.Municipality_CB.StartIndex = 0
        Me.Municipality_CB.TabIndex = 61
        '
        'Side_Panel_Btn
        '
        Me.Side_Panel_Btn.Animated = True
        Me.Side_Panel_Btn.AnimationHoverSpeed = 0.07!
        Me.Side_Panel_Btn.AnimationSpeed = 0.03!
        Me.Side_Panel_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Side_Panel_Btn.BaseColor = System.Drawing.Color.Transparent
        Me.Side_Panel_Btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Side_Panel_Btn.BorderSize = 2
        Me.Side_Panel_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Side_Panel_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Side_Panel_Btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Side_Panel_Btn.ForeColor = System.Drawing.Color.Black
        Me.Side_Panel_Btn.Image = Nothing
        Me.Side_Panel_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Side_Panel_Btn.Location = New System.Drawing.Point(415, 234)
        Me.Side_Panel_Btn.Name = "Side_Panel_Btn"
        Me.Side_Panel_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Side_Panel_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Side_Panel_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Side_Panel_Btn.OnHoverImage = Nothing
        Me.Side_Panel_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Side_Panel_Btn.Radius = 26
        Me.Side_Panel_Btn.Size = New System.Drawing.Size(211, 57)
        Me.Side_Panel_Btn.TabIndex = 62
        Me.Side_Panel_Btn.TabStop = False
        Me.Side_Panel_Btn.Text = "Side Panel"
        Me.Side_Panel_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Save_Winner_BW
        '
        Me.Save_Winner_BW.WorkerReportsProgress = True
        Me.Save_Winner_BW.WorkerSupportsCancellation = True
        '
        'Rest_Winner_List
        '
        Me.Rest_Winner_List.Animated = True
        Me.Rest_Winner_List.AnimationHoverSpeed = 0.07!
        Me.Rest_Winner_List.AnimationSpeed = 0.03!
        Me.Rest_Winner_List.BackColor = System.Drawing.Color.Transparent
        Me.Rest_Winner_List.BaseColor = System.Drawing.Color.Transparent
        Me.Rest_Winner_List.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Rest_Winner_List.BorderSize = 2
        Me.Rest_Winner_List.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Rest_Winner_List.FocusedColor = System.Drawing.Color.Empty
        Me.Rest_Winner_List.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Rest_Winner_List.ForeColor = System.Drawing.Color.Black
        Me.Rest_Winner_List.Image = Nothing
        Me.Rest_Winner_List.ImageSize = New System.Drawing.Size(20, 20)
        Me.Rest_Winner_List.Location = New System.Drawing.Point(415, 171)
        Me.Rest_Winner_List.Name = "Rest_Winner_List"
        Me.Rest_Winner_List.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Rest_Winner_List.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Rest_Winner_List.OnHoverForeColor = System.Drawing.Color.White
        Me.Rest_Winner_List.OnHoverImage = Nothing
        Me.Rest_Winner_List.OnPressedColor = System.Drawing.Color.Black
        Me.Rest_Winner_List.Radius = 26
        Me.Rest_Winner_List.Size = New System.Drawing.Size(211, 57)
        Me.Rest_Winner_List.TabIndex = 63
        Me.Rest_Winner_List.TabStop = False
        Me.Rest_Winner_List.Text = "Reset Winner List"
        Me.Rest_Winner_List.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Wipe_Winner_BW
        '
        Me.Wipe_Winner_BW.WorkerReportsProgress = True
        Me.Wipe_Winner_BW.WorkerSupportsCancellation = True
        '
        'Side_Pan_Dis_CB
        '
        Me.Side_Pan_Dis_CB.Animated = True
        Me.Side_Pan_Dis_CB.BackColor = System.Drawing.Color.Transparent
        Me.Side_Pan_Dis_CB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Side_Pan_Dis_CB.BorderRadius = 15
        Me.Side_Pan_Dis_CB.BorderThickness = 2
        Me.Side_Pan_Dis_CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Side_Pan_Dis_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Side_Pan_Dis_CB.FillColor = System.Drawing.Color.LightGray
        Me.Side_Pan_Dis_CB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Side_Pan_Dis_CB.FocusedColor = System.Drawing.Color.Empty
        Me.Side_Pan_Dis_CB.FocusedState.Parent = Me.Side_Pan_Dis_CB
        Me.Side_Pan_Dis_CB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Side_Pan_Dis_CB.ForeColor = System.Drawing.Color.Black
        Me.Side_Pan_Dis_CB.FormattingEnabled = True
        Me.Side_Pan_Dis_CB.HoverState.Parent = Me.Side_Pan_Dis_CB
        Me.Side_Pan_Dis_CB.ItemHeight = 30
        Me.Side_Pan_Dis_CB.ItemsAppearance.Parent = Me.Side_Pan_Dis_CB
        Me.Side_Pan_Dis_CB.Location = New System.Drawing.Point(415, 297)
        Me.Side_Pan_Dis_CB.Name = "Side_Pan_Dis_CB"
        Me.Side_Pan_Dis_CB.ShadowDecoration.Parent = Me.Side_Pan_Dis_CB
        Me.Side_Pan_Dis_CB.Size = New System.Drawing.Size(211, 36)
        Me.Side_Pan_Dis_CB.TabIndex = 64
        '
        'Soud_play_BW
        '
        Me.Soud_play_BW.WorkerReportsProgress = True
        Me.Soud_play_BW.WorkerSupportsCancellation = True
        '
        'Export_PDF_Btn
        '
        Me.Export_PDF_Btn.Animated = True
        Me.Export_PDF_Btn.AnimationHoverSpeed = 0.07!
        Me.Export_PDF_Btn.AnimationSpeed = 0.03!
        Me.Export_PDF_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Export_PDF_Btn.BaseColor = System.Drawing.Color.Transparent
        Me.Export_PDF_Btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Export_PDF_Btn.BorderSize = 2
        Me.Export_PDF_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Export_PDF_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Export_PDF_Btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Export_PDF_Btn.ForeColor = System.Drawing.Color.Black
        Me.Export_PDF_Btn.Image = Nothing
        Me.Export_PDF_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Export_PDF_Btn.Location = New System.Drawing.Point(637, 607)
        Me.Export_PDF_Btn.Name = "Export_PDF_Btn"
        Me.Export_PDF_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Export_PDF_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Export_PDF_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Export_PDF_Btn.OnHoverImage = Nothing
        Me.Export_PDF_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Export_PDF_Btn.Radius = 26
        Me.Export_PDF_Btn.Size = New System.Drawing.Size(329, 57)
        Me.Export_PDF_Btn.TabIndex = 65
        Me.Export_PDF_Btn.TabStop = False
        Me.Export_PDF_Btn.Tag = ""
        Me.Export_PDF_Btn.Text = "Export PDF"
        Me.Export_PDF_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BW_Side_Pan_Load
        '
        Me.BW_Side_Pan_Load.WorkerReportsProgress = True
        Me.BW_Side_Pan_Load.WorkerSupportsCancellation = True
        '
        'Blink_Effect_Btn
        '
        Me.Blink_Effect_Btn.Animated = True
        Me.Blink_Effect_Btn.AnimationHoverSpeed = 0.07!
        Me.Blink_Effect_Btn.AnimationSpeed = 0.03!
        Me.Blink_Effect_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Blink_Effect_Btn.BaseColor = System.Drawing.Color.Transparent
        Me.Blink_Effect_Btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Blink_Effect_Btn.BorderSize = 2
        Me.Blink_Effect_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Blink_Effect_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Blink_Effect_Btn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Blink_Effect_Btn.ForeColor = System.Drawing.Color.Black
        Me.Blink_Effect_Btn.Image = Nothing
        Me.Blink_Effect_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Blink_Effect_Btn.Location = New System.Drawing.Point(637, 543)
        Me.Blink_Effect_Btn.Name = "Blink_Effect_Btn"
        Me.Blink_Effect_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Blink_Effect_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Blink_Effect_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Blink_Effect_Btn.OnHoverImage = Nothing
        Me.Blink_Effect_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Blink_Effect_Btn.Radius = 26
        Me.Blink_Effect_Btn.Size = New System.Drawing.Size(113, 57)
        Me.Blink_Effect_Btn.TabIndex = 66
        Me.Blink_Effect_Btn.TabStop = False
        Me.Blink_Effect_Btn.Tag = ""
        Me.Blink_Effect_Btn.Text = "Blink Effect"
        Me.Blink_Effect_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Blink_Speed_num
        '
        Me.Blink_Speed_num.BackColor = System.Drawing.Color.Transparent
        Me.Blink_Speed_num.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Blink_Speed_num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Blink_Speed_num.DecimalPlaces = 2
        Me.Blink_Speed_num.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Blink_Speed_num.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Blink_Speed_num.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Blink_Speed_num.DisabledState.Parent = Me.Blink_Speed_num
        Me.Blink_Speed_num.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Blink_Speed_num.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Blink_Speed_num.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Blink_Speed_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Blink_Speed_num.FocusedState.Parent = Me.Blink_Speed_num
        Me.Blink_Speed_num.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blink_Speed_num.ForeColor = System.Drawing.Color.Transparent
        Me.Blink_Speed_num.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Blink_Speed_num.Location = New System.Drawing.Point(752, 552)
        Me.Blink_Speed_num.Name = "Blink_Speed_num"
        Me.Blink_Speed_num.ShadowDecoration.Parent = Me.Blink_Speed_num
        Me.Blink_Speed_num.Size = New System.Drawing.Size(100, 36)
        Me.Blink_Speed_num.TabIndex = 67
        Me.Blink_Speed_num.Value = New Decimal(New Integer() {25, 0, 0, 65536})
        '
        'Cancel_Btn
        '
        Me.Cancel_Btn.Animated = True
        Me.Cancel_Btn.AnimationHoverSpeed = 0.07!
        Me.Cancel_Btn.AnimationSpeed = 0.03!
        Me.Cancel_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Btn.BaseColor = System.Drawing.Color.Transparent
        Me.Cancel_Btn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cancel_Btn.BorderSize = 2
        Me.Cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Cancel_Btn.Enabled = False
        Me.Cancel_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Cancel_Btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Cancel_Btn.ForeColor = System.Drawing.Color.Black
        Me.Cancel_Btn.Image = Nothing
        Me.Cancel_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Cancel_Btn.Location = New System.Drawing.Point(858, 543)
        Me.Cancel_Btn.Name = "Cancel_Btn"
        Me.Cancel_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cancel_Btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cancel_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Cancel_Btn.OnHoverImage = Nothing
        Me.Cancel_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Cancel_Btn.Radius = 26
        Me.Cancel_Btn.Size = New System.Drawing.Size(113, 57)
        Me.Cancel_Btn.TabIndex = 68
        Me.Cancel_Btn.TabStop = False
        Me.Cancel_Btn.Text = "Stop Music"
        Me.Cancel_Btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Today_CB
        '
        Me.Today_CB.AutoSize = True
        Me.Today_CB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Today_CB.CheckedState.BorderRadius = 2
        Me.Today_CB.CheckedState.BorderThickness = 0
        Me.Today_CB.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Today_CB.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Today_CB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Today_CB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Today_CB.Location = New System.Drawing.Point(428, 117)
        Me.Today_CB.Name = "Today_CB"
        Me.Today_CB.Size = New System.Drawing.Size(173, 25)
        Me.Today_CB.TabIndex = 70
        Me.Today_CB.Text = "Today's Registrants"
        Me.Today_CB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Today_CB.UncheckedState.BorderRadius = 2
        Me.Today_CB.UncheckedState.BorderThickness = 0
        Me.Today_CB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Today_CB.UseVisualStyleBackColor = True
        '
        'BW_Update_batch_Number
        '
        Me.BW_Update_batch_Number.WorkerReportsProgress = True
        Me.BW_Update_batch_Number.WorkerSupportsCancellation = True
        '
        'tmr_winner_saver_trigger
        '
        Me.tmr_winner_saver_trigger.Enabled = True
        Me.tmr_winner_saver_trigger.Interval = 1
        '
        'FRM_CTR_PANEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 668)
        Me.Controls.Add(Me.Today_CB)
        Me.Controls.Add(Me.Cancel_Btn)
        Me.Controls.Add(Me.Blink_Speed_num)
        Me.Controls.Add(Me.Blink_Effect_Btn)
        Me.Controls.Add(Me.Export_PDF_Btn)
        Me.Controls.Add(Me.Side_Pan_Dis_CB)
        Me.Controls.Add(Me.Rest_Winner_List)
        Me.Controls.Add(Me.Side_Panel_Btn)
        Me.Controls.Add(Me.Municipality_CB)
        Me.Controls.Add(Me.Speed_Panel)
        Me.Controls.Add(Me.rch_Stat)
        Me.Controls.Add(Me.Tot_Part_Lbl)
        Me.Controls.Add(Me.Show_Console_Btn)
        Me.Controls.Add(Me.Batch_win_count_LBL)
        Me.Controls.Add(Me.Batch_no_Lbl)
        Me.Controls.Add(Me.Panel_Draw)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.Random_Speed_num)
        Me.Controls.Add(Me.Random_Digit_stop_Btn)
        Me.Controls.Add(Me.Start_Raffle_btn)
        Me.Controls.Add(Me.Next_Raffle_Btn)
        Me.Controls.Add(Me.winner_list_btn)
        Me.Controls.Add(Me.FeaturePrize_tb)
        Me.Controls.Add(Me.ToggleFullScreen_lbl)
        Me.Controls.Add(Me.ToggleFullScreen_sw)
        Me.Controls.Add(Me.Update_btn)
        Me.Controls.Add(Me.Show_Display_Btn)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FRM_CTR_PANEL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "`"
        CType(Me.Random_Speed_num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Draw.ResumeLayout(False)
        Me.Panel_Draw.PerformLayout()
        CType(Me.Numberofwinner_numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Speed_Panel.ResumeLayout(False)
        Me.Speed_Panel.PerformLayout()
        CType(Me.Blink_Speed_num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SideNav1 As DevComponents.DotNetBar.Controls.SideNav
    Friend WithEvents Show_Display_Btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents ToggleFullScreen_sw As Guna.UI.WinForms.GunaGoogleSwitch
    Friend WithEvents ToggleFullScreen_lbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents FeaturePrize_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Update_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents winner_list_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents set_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Next_Raffle_Btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Start_Raffle_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Random_Digit_stop_Btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Side_notif_tmr_open As System.Windows.Forms.Timer
    Friend WithEvents Side_notif_tmr_close As System.Windows.Forms.Timer
    Friend WithEvents tmr_Random_Stop As System.Windows.Forms.Timer
    Friend WithEvents Random_Speed_num As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BW_Pre_Loader_Entries_to_Array As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel_Draw As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Multiple_Draw_RB As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Single_Draw_RB As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Numberofwinner_numeric As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Batch_no_Lbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Batch_win_count_LBL As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Show_Console_Btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Tot_Part_Lbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents rch_Stat As System.Windows.Forms.TextBox
    Friend WithEvents BW_Fetch_Winners As System.ComponentModel.BackgroundWorker
    Friend WithEvents Speed_Panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Digit_btn_6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Digit_btn_5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Digit_btn_4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Digit_btn_3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Digit_btn_2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Digit_btn_1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Speed_Digit_6 As Guna.UI2.WinForms.Guna2VTrackBar
    Friend WithEvents Speed_Digit_5 As Guna.UI2.WinForms.Guna2VTrackBar
    Friend WithEvents Speed_Digit_4 As Guna.UI2.WinForms.Guna2VTrackBar
    Friend WithEvents Speed_Digit_3 As Guna.UI2.WinForms.Guna2VTrackBar
    Friend WithEvents Speed_Digit_2 As Guna.UI2.WinForms.Guna2VTrackBar
    Friend WithEvents Speed_Digit_1 As Guna.UI2.WinForms.Guna2VTrackBar
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Speed_Digit_All As Guna.UI2.WinForms.Guna2TrackBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Municipality_CB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Price_Type_ComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Side_Panel_Btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Save_Winner_BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Rest_Winner_List As Guna.UI.WinForms.GunaButton
    Friend WithEvents Wipe_Winner_BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Side_Pan_Dis_CB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Soud_play_BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Export_PDF_Btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents BW_Side_Pan_Load As System.ComponentModel.BackgroundWorker
    Friend WithEvents Blink_Effect_Btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Blink_Speed_num As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Cancel_Btn As Guna.UI.WinForms.GunaButton
    Private WithEvents Today_CB As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents BW_Update_batch_Number As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmr_winner_saver_trigger As Timer
End Class
