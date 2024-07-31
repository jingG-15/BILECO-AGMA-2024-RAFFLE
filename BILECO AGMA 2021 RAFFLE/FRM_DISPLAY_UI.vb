Imports MySql.Data.MySqlClient
Public Class FRM_DISPLAY_UI
    Public Scroll_Speed_1 As Integer = 30
    Public Scroll_Speed_2 As Integer = 30
    Public Scroll_Speed_3 As Integer = 30
    Public Scroll_Speed_4 As Integer = 30
    Public Scroll_Speed_5 As Integer = 30
    Public Scroll_Speed_6 As Integer = 30
    Public Digit_1_stop As Boolean = False
    Public Digit_2_stop As Boolean = False
    Public Digit_3_stop As Boolean = False
    Public Digit_4_stop As Boolean = False
    Public Digit_5_stop As Boolean = False
    Public Digit_6_stop As Boolean = False

    Dim Digit_1_stop2 As Boolean = False
    Dim Digit_2_stop2 As Boolean = False
    Dim Digit_3_stop2 As Boolean = False
    Dim Digit_4_stop2 As Boolean = False
    Dim Digit_5_stop2 As Boolean = False
    Dim Digit_6_stop2 As Boolean = False
    Dim anim_Steps As Integer = 0
    Dim Blick_effect As Boolean = True
    Delegate Sub SetRchText(ByVal txt As String)


    Private Sub FRM_DISPLAY_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\back.jpg")
        Me.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Top_1.Image = Image.FromFile(Application.StartupPath & "\top.png")
        Boarder_Top_1.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Top_2.Image = Image.FromFile(Application.StartupPath & "\top.png")
        Boarder_Top_2.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Top_3.Image = Image.FromFile(Application.StartupPath & "\top.png")
        Boarder_Top_3.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Top_4.Image = Image.FromFile(Application.StartupPath & "\top.png")
        Boarder_Top_4.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Top_5.Image = Image.FromFile(Application.StartupPath & "\top.png")
        Boarder_Top_5.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Top_6.Image = Image.FromFile(Application.StartupPath & "\top.png")
        Boarder_Top_6.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Bottom_1.Image = Image.FromFile(Application.StartupPath & "\bottom.png")
        Boarder_Bottom_1.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Bottom_2.Image = Image.FromFile(Application.StartupPath & "\bottom.png")
        Boarder_Bottom_2.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Bottom_3.Image = Image.FromFile(Application.StartupPath & "\bottom.png")
        Boarder_Bottom_3.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Bottom_4.Image = Image.FromFile(Application.StartupPath & "\bottom.png")
        Boarder_Bottom_4.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Bottom_5.Image = Image.FromFile(Application.StartupPath & "\bottom.png")
        Boarder_Bottom_5.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_Bottom_6.Image = Image.FromFile(Application.StartupPath & "\bottom.png")
        Boarder_Bottom_6.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_left_1.Image = Image.FromFile(Application.StartupPath & "\left.png")
        Boarder_left_1.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_left_2.Image = Image.FromFile(Application.StartupPath & "\left.png")
        Boarder_left_2.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_left_3.Image = Image.FromFile(Application.StartupPath & "\left.png")
        Boarder_left_3.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_left_4.Image = Image.FromFile(Application.StartupPath & "\left.png")
        Boarder_left_4.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_left_5.Image = Image.FromFile(Application.StartupPath & "\left.png")
        Boarder_left_5.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_left_6.Image = Image.FromFile(Application.StartupPath & "\left.png")
        Boarder_left_6.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_left_6.Image = Image.FromFile(Application.StartupPath & "\left.png")
        Boarder_left_6.BackgroundImageLayout = ImageLayout.Stretch
        
        Boarder_right_1.Image = Image.FromFile(Application.StartupPath & "\right.png")
        Boarder_right_1.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_right_2.Image = Image.FromFile(Application.StartupPath & "\right.png")
        Boarder_right_2.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_right_3.Image = Image.FromFile(Application.StartupPath & "\right.png")
        Boarder_right_3.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_right_4.Image = Image.FromFile(Application.StartupPath & "\right.png")
        Boarder_right_4.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_right_5.Image = Image.FromFile(Application.StartupPath & "\right.png")
        Boarder_right_5.BackgroundImageLayout = ImageLayout.Stretch

        Boarder_right_6.Image = Image.FromFile(Application.StartupPath & "\right.png")
        Boarder_right_6.BackgroundImageLayout = ImageLayout.Stretch

        Borderresize()


        Digit_1_1.Image = Image.FromFile(Application.StartupPath & "\T1.png")
        Digit_1_1.BackgroundImageLayout = ImageLayout.Stretch

        Digit_2_1.Image = Image.FromFile(Application.StartupPath & "\T2.png")
        Digit_2_1.BackgroundImageLayout = ImageLayout.Stretch

        Digit_3_1.Image = Image.FromFile(Application.StartupPath & "\T3.png")
        Digit_3_1.BackgroundImageLayout = ImageLayout.Stretch

        Digit_4_1.Image = Image.FromFile(Application.StartupPath & "\T4.png")
        Digit_4_1.BackgroundImageLayout = ImageLayout.Stretch

        Digit_5_1.Image = Image.FromFile(Application.StartupPath & "\T5.png")
        Digit_5_1.BackgroundImageLayout = ImageLayout.Stretch

        Digit_6_1.Image = Image.FromFile(Application.StartupPath & "\T6.png")
        Digit_6_1.BackgroundImageLayout = ImageLayout.Stretch

        Digit_1_2.Image = Image.FromFile(Application.StartupPath & "\Logo1.png")
        Digit_1_2.BackgroundImageLayout = ImageLayout.Stretch

        Digit_1_3.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_1_3.BackgroundImageLayout = ImageLayout.Stretch

        Digit_1_4.Image = Image.FromFile(Application.StartupPath & "\logo3.png")
        Digit_1_4.BackgroundImageLayout = ImageLayout.Stretch

        Digit_1_5.Image = Image.FromFile(Application.StartupPath & "\logo4.png")
        Digit_1_5.BackgroundImageLayout = ImageLayout.Stretch

        Digit_1_6.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_1_6.BackgroundImageLayout = ImageLayout.Stretch

        Digit_1_7.Image = Image.FromFile(Application.StartupPath & "\logo6.png")
        Digit_1_7.BackgroundImageLayout = ImageLayout.Stretch

        Digit_1_8.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_1_8.BackgroundImageLayout = ImageLayout.Stretch

        Digit_1_9.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_1_9.BackgroundImageLayout = ImageLayout.Stretch

        Digit_2_2.Image = Image.FromFile(Application.StartupPath & "\Logo1.png")
        Digit_2_2.BackgroundImageLayout = ImageLayout.Stretch

        Digit_2_3.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_2_3.BackgroundImageLayout = ImageLayout.Stretch

        Digit_2_4.Image = Image.FromFile(Application.StartupPath & "\logo3.png")
        Digit_2_4.BackgroundImageLayout = ImageLayout.Stretch

        Digit_2_5.Image = Image.FromFile(Application.StartupPath & "\logo4.png")
        Digit_2_5.BackgroundImageLayout = ImageLayout.Stretch

        Digit_2_6.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_2_6.BackgroundImageLayout = ImageLayout.Stretch

        Digit_2_7.Image = Image.FromFile(Application.StartupPath & "\logo6.png")
        Digit_2_7.BackgroundImageLayout = ImageLayout.Stretch

        Digit_2_8.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_2_8.BackgroundImageLayout = ImageLayout.Stretch

        Digit_2_9.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_2_9.BackgroundImageLayout = ImageLayout.Stretch

        Digit_3_2.Image = Image.FromFile(Application.StartupPath & "\Logo1.png")
        Digit_3_2.BackgroundImageLayout = ImageLayout.Stretch

        Digit_3_3.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_3_3.BackgroundImageLayout = ImageLayout.Stretch

        Digit_3_4.Image = Image.FromFile(Application.StartupPath & "\logo3.png")
        Digit_3_4.BackgroundImageLayout = ImageLayout.Stretch

        Digit_3_5.Image = Image.FromFile(Application.StartupPath & "\logo4.png")
        Digit_3_5.BackgroundImageLayout = ImageLayout.Stretch

        Digit_3_6.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_3_6.BackgroundImageLayout = ImageLayout.Stretch

        Digit_3_7.Image = Image.FromFile(Application.StartupPath & "\logo6.png")
        Digit_3_7.BackgroundImageLayout = ImageLayout.Stretch

        Digit_3_8.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_3_8.BackgroundImageLayout = ImageLayout.Stretch

        Digit_3_9.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_3_9.BackgroundImageLayout = ImageLayout.Stretch

        Digit_4_2.Image = Image.FromFile(Application.StartupPath & "\Logo1.png")
        Digit_4_2.BackgroundImageLayout = ImageLayout.Stretch

        Digit_4_3.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_4_3.BackgroundImageLayout = ImageLayout.Stretch

        Digit_4_4.Image = Image.FromFile(Application.StartupPath & "\logo3.png")
        Digit_4_4.BackgroundImageLayout = ImageLayout.Stretch

        Digit_4_5.Image = Image.FromFile(Application.StartupPath & "\logo4.png")
        Digit_4_5.BackgroundImageLayout = ImageLayout.Stretch

        Digit_4_6.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_4_6.BackgroundImageLayout = ImageLayout.Stretch

        Digit_4_7.Image = Image.FromFile(Application.StartupPath & "\logo6.png")
        Digit_4_7.BackgroundImageLayout = ImageLayout.Stretch

        Digit_4_8.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_4_8.BackgroundImageLayout = ImageLayout.Stretch

        Digit_4_9.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_4_9.BackgroundImageLayout = ImageLayout.Stretch

        Digit_5_2.Image = Image.FromFile(Application.StartupPath & "\Logo1.png")
        Digit_5_2.BackgroundImageLayout = ImageLayout.Stretch

        Digit_5_3.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_5_3.BackgroundImageLayout = ImageLayout.Stretch

        Digit_5_4.Image = Image.FromFile(Application.StartupPath & "\logo3.png")
        Digit_5_4.BackgroundImageLayout = ImageLayout.Stretch

        Digit_5_5.Image = Image.FromFile(Application.StartupPath & "\logo4.png")
        Digit_5_5.BackgroundImageLayout = ImageLayout.Stretch

        Digit_5_6.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_5_6.BackgroundImageLayout = ImageLayout.Stretch

        Digit_5_7.Image = Image.FromFile(Application.StartupPath & "\logo6.png")
        Digit_5_7.BackgroundImageLayout = ImageLayout.Stretch

        Digit_5_8.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_5_8.BackgroundImageLayout = ImageLayout.Stretch

        Digit_5_9.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_5_9.BackgroundImageLayout = ImageLayout.Stretch

        Digit_6_2.Image = Image.FromFile(Application.StartupPath & "\Logo1.png")
        Digit_6_2.BackgroundImageLayout = ImageLayout.Stretch

        Digit_6_3.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_6_3.BackgroundImageLayout = ImageLayout.Stretch

        Digit_6_4.Image = Image.FromFile(Application.StartupPath & "\logo3.png")
        Digit_6_4.BackgroundImageLayout = ImageLayout.Stretch

        Digit_6_5.Image = Image.FromFile(Application.StartupPath & "\logo4.png")
        Digit_6_5.BackgroundImageLayout = ImageLayout.Stretch

        Digit_6_6.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_6_6.BackgroundImageLayout = ImageLayout.Stretch

        Digit_6_7.Image = Image.FromFile(Application.StartupPath & "\logo6.png")
        Digit_6_7.BackgroundImageLayout = ImageLayout.Stretch

        Digit_6_8.Image = Image.FromFile(Application.StartupPath & "\logo2.png")
        Digit_6_8.BackgroundImageLayout = ImageLayout.Stretch

        Digit_6_9.Image = Image.FromFile(Application.StartupPath & "\logo5.png")
        Digit_6_9.BackgroundImageLayout = ImageLayout.Stretch

        Side_Panel.Size = New Size(Main_Panel.Width, Main_Panel.Height)
        Side_Panel.Location = New Point(0 - Side_Panel.Width, 0)
        Side_Panel.BringToFront()
        Side_Panel.BackColor = Drawing.Color.FromArgb(254, 236, 76)
        'rch_Stat.BackColor = Drawing.Color.FromArgb(56, 149, 211)18, 49, 70
        rch_Stat.BackColor = Drawing.Color.FromArgb(18, 49, 70)
        rch_Stat.ForeColor = Color.White
        Side_Pan_Lbl.Text = ""
        set_draw()
        Price_LBL.BringToFront()
        Clear_Side_Panel()

    End Sub

    Public Sub Borderresize()
        Boarder_Top_1.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height / 10)
        Boarder_left_1.Size = New Size(Digit_Panel_1.Width / 10, Digit_Panel_1.Height)
        Boarder_right_1.Size = New Size(Digit_Panel_1.Width / 20, Digit_Panel_1.Height)
        Boarder_Bottom_1.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height / 10)

        Boarder_Top_2.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height / 10)
        Boarder_left_2.Size = New Size(Digit_Panel_2.Width / 20, Digit_Panel_2.Height)
        Boarder_right_2.Size = New Size(Digit_Panel_2.Width / 20, Digit_Panel_2.Height)
        Boarder_Bottom_2.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height / 10)

        Boarder_Top_3.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height / 10)
        Boarder_left_3.Size = New Size(Digit_Panel_3.Width / 20, Digit_Panel_3.Height)
        Boarder_right_3.Size = New Size(Digit_Panel_3.Width / 20, Digit_Panel_3.Height)
        Boarder_Bottom_3.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height / 10)

        Boarder_Top_4.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height / 10)
        Boarder_left_4.Size = New Size(Digit_Panel_4.Width / 20, Digit_Panel_4.Height)
        Boarder_right_4.Size = New Size(Digit_Panel_4.Width / 20, Digit_Panel_4.Height)
        Boarder_Bottom_4.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height / 10)

        Boarder_Top_5.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height / 10)
        Boarder_left_5.Size = New Size(Digit_Panel_5.Width / 20, Digit_Panel_5.Height)
        Boarder_right_5.Size = New Size(Digit_Panel_5.Width / 20, Digit_Panel_5.Height)
        Boarder_Bottom_5.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height / 10)

        Boarder_Top_6.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height / 10)
        Boarder_left_6.Size = New Size(Digit_Panel_6.Width / 20, Digit_Panel_6.Height)
        Boarder_right_6.Size = New Size(Digit_Panel_6.Width / 10, Digit_Panel_6.Height)
        Boarder_Bottom_6.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height / 10)

    End Sub

    Public Sub Disp_Msg(ByVal Msg As String)
        If Me.rch_Stat.InvokeRequired Then 'Invoke if required...
            Dim d As New SetRchText(AddressOf Disp_Msg) 'Your delegate...
            Me.Invoke(d, New Object() {Msg})
        Else 'Otherwise, no invoke required...
            'Me.LstRaffleMembers.Items.Add(lstItem)
            Me.rch_Stat.Text = Me.rch_Stat.Text + Msg
            Me.rch_Stat.SelectionStart = Me.rch_Stat.Text.Length
            Me.rch_Stat.ScrollToCaret()
        End If
    End Sub

    Private Sub FRM_DISPLAY_UI_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Borderresize()
        Price_LBL.Size = New Size((Me.Width / 3), Me.Height / 4)
        Price_LBL.Font = New Font("Bebas Neue", (Main_Panel.Height / 5) \ 2, FontStyle.Bold)
        Price_LBL.Location = New Point((Me.Width / 2) - (Price_LBL.Width / 2), Main_Panel.Height / 64)

        Side_Panel_Title_Label.Size = New Size((Me.Width / 3) * 2, Me.Height / 4)
        Side_Panel_Title_Label.Font = New Font("Bebas Neue", (Main_Panel.Height / 6) \ 2)
        Side_Panel_Title_Label.Location = New Point((Me.Width / 2) - (Side_Panel_Title_Label.Width / 2), (Main_Panel.Height / 16) * 8)

        rch_Stat.Height = (Main_Panel.Height / 4) * 3
        rch_Stat.Font = New Font("Bebas Neue", (Main_Panel.Height / 12) \ 2, FontStyle.Bold)
        'rch_Stat.BackColor = Drawing.Color.FromArgb(56, 149, 211)18, 49, 70
        rch_Stat.BackColor = Drawing.Color.FromArgb(18, 49, 70)
        rch_Stat.ForeColor = Color.White
        rch_Stat.TextAlign = HorizontalAlignment.Left

        Side_Panel.Size = New Size(Main_Panel.Width, Main_Panel.Height)
        Side_Panel.Location = New Point(0 - Side_Panel.Width, 0)
        Side_Panel.BringToFront()
        Side_Panel.BackColor = Drawing.Color.FromArgb(254, 236, 76)
        'rch_Stat.BackColor = Drawing.Color.FromArgb(56, 149, 211)
        rch_Stat.BackColor = Drawing.Color.FromArgb(18, 49, 70)
        rch_Stat.ForeColor = Color.White

        'Side_Panel.BorderColor = Color.Blue
        'Side_Panel.BorderStyle = Drawing2D.DashStyle.Solid
        'Side_Panel.BorderThickness = 5
        Side_Panel.BringToFront()
        Side_Panel.Size = New Size(Main_Panel.Width, Main_Panel.Height)
        Side_Panel.Location = New Point(0 - Side_Panel.Width, 0)
        Side_Panel.BackColor = Drawing.Color.FromArgb(254, 236, 76)
        Side_Panel.BringToFront()
        Side_Pan_Lbl.Size = New Size(Side_Panel.Width, Side_Panel.Height / 5)
        Side_Pan_Lbl.Font = New Font("Bebas Neue", (Main_Panel.Height / 8) \ 2, FontStyle.Bold)
        Side_Pan_Lbl.Location = New Point((Side_Panel.Width / 2) - (Side_Pan_Lbl.Width / 2), Side_Panel.Height / 64)

        Digit_Panel_1.Size = New Size(Main_Panel.Width / 8, Main_Panel.Height / 3)
        Digit_Panel_1.Location = New Point((Main_Panel.Width / 8) * 1, Main_Panel.Height / 3)
        Digit_Panel_1.BringToFront()
        Digit_Panel_2.Size = New Size(Main_Panel.Width / 8, Main_Panel.Height / 3)
        Digit_Panel_2.Location = New Point((Main_Panel.Width / 8) * 2, Main_Panel.Height / 3)
        Digit_Panel_2.BringToFront()
        Digit_Panel_3.Size = New Size(Main_Panel.Width / 8, Main_Panel.Height / 3)
        Digit_Panel_3.Location = New Point((Main_Panel.Width / 8) * 3, Main_Panel.Height / 3)
        Digit_Panel_3.BringToFront()
        Digit_Panel_4.Size = New Size(Main_Panel.Width / 8, Main_Panel.Height / 3)
        Digit_Panel_4.Location = New Point((Main_Panel.Width / 8) * 4, Main_Panel.Height / 3)
        Digit_Panel_4.BringToFront()
        Digit_Panel_5.Size = New Size(Main_Panel.Width / 8, Main_Panel.Height / 3)
        Digit_Panel_5.Location = New Point((Main_Panel.Width / 8) * 5, Main_Panel.Height / 3)
        Digit_Panel_5.BringToFront()
        Digit_Panel_6.Size = New Size(Main_Panel.Width / 8, Main_Panel.Height / 3)
        Digit_Panel_6.Location = New Point((Main_Panel.Width / 8) * 6, Main_Panel.Height / 3)
        Digit_Panel_6.BringToFront()
        

        Digit_1_1.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height)
        Digit_1_2.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height)
        Digit_1_3.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height)
        Digit_1_4.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height)
        Digit_1_5.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height)
        Digit_1_6.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height)
        Digit_1_7.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height)
        Digit_1_8.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height)
        Digit_1_9.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height)
        Digit_1_10_Panel.Size = New Size(Digit_Panel_1.Width, Digit_Panel_1.Height)
        If Digit_1_10_Panel.Height > Digit_1_10_Lbl.Width Then
            Digit_1_10_Lbl.Size = New Size(Digit_1_10_Panel.Height, Digit_1_10_Panel.Height)
            Digit_1_10_Lbl.Font = New Font("Consolas", Digit_1_10_Panel.Width)
        Else
            Digit_1_10_Lbl.Size = New Size(Digit_1_10_Panel.Width, Digit_1_10_Panel.Width)
            Digit_1_10_Lbl.Font = New Font("Consolas", Digit_1_10_Panel.Width)
        End If
        Digit_1_10_Lbl.Location = New Point((Digit_1_10_Panel.Width / 2) - (Digit_1_10_Lbl.Width / 2) + (Digit_Panel_1.Width / 10), (Digit_1_10_Panel.Height / 2) - (Digit_1_10_Lbl.Height / 2))

        Digit_2_1.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height)
        Digit_2_2.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height)
        Digit_2_3.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height)
        Digit_2_4.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height)
        Digit_2_5.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height)
        Digit_2_6.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height)
        Digit_2_7.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height)
        Digit_2_8.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height)
        Digit_2_9.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height)
        Digit_2_10_Panel.Size = New Size(Digit_Panel_2.Width, Digit_Panel_2.Height)
        If Digit_2_10_Panel.Height > Digit_2_10_Lbl.Width Then
            Digit_2_10_Lbl.Size = New Size(Digit_2_10_Panel.Height, Digit_2_10_Panel.Height)
            Digit_2_10_Lbl.Font = New Font("Consolas", Digit_2_10_Panel.Width)
        Else
            Digit_2_10_Lbl.Size = New Size(Digit_2_10_Panel.Width, Digit_2_10_Panel.Width)
            Digit_2_10_Lbl.Font = New Font("Consolas", Digit_2_10_Panel.Width)
        End If
        Digit_2_10_Lbl.Location = New Point((Digit_2_10_Panel.Width / 2) - (Digit_2_10_Lbl.Width / 2) + (Digit_Panel_2.Width / 20), (Digit_2_10_Panel.Height / 2) - (Digit_2_10_Lbl.Height / 2))

        Digit_3_1.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height)
        Digit_3_2.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height)
        Digit_3_3.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height)
        Digit_3_4.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height)
        Digit_3_5.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height)
        Digit_3_6.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height)
        Digit_3_7.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height)
        Digit_3_8.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height)
        Digit_3_9.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height)
        Digit_3_10_Panel.Size = New Size(Digit_Panel_3.Width, Digit_Panel_3.Height)
        If Digit_3_10_Panel.Height > Digit_3_10_Lbl.Width Then
            Digit_3_10_Lbl.Size = New Size(Digit_3_10_Panel.Height, Digit_3_10_Panel.Height)
            Digit_3_10_Lbl.Font = New Font("Consolas", Digit_3_10_Panel.Width)
        Else
            Digit_3_10_Lbl.Size = New Size(Digit_3_10_Panel.Width, Digit_3_10_Panel.Width)
            Digit_3_10_Lbl.Font = New Font("Consolas", Digit_3_10_Panel.Width)
        End If
        Digit_3_10_Lbl.Location = New Point((Digit_3_10_Panel.Width / 2) - (Digit_3_10_Lbl.Width / 2) + (Digit_Panel_3.Width / 20), (Digit_3_10_Panel.Height / 2) - (Digit_3_10_Lbl.Height / 2))

        Digit_4_1.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height)
        Digit_4_2.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height)
        Digit_4_3.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height)
        Digit_4_4.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height)
        Digit_4_5.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height)
        Digit_4_6.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height)
        Digit_4_7.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height)
        Digit_4_8.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height)
        Digit_4_9.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height)
        Digit_4_10_Panel.Size = New Size(Digit_Panel_4.Width, Digit_Panel_4.Height)
        If Digit_4_10_Panel.Height > Digit_4_10_Lbl.Width Then
            Digit_4_10_Lbl.Size = New Size(Digit_4_10_Panel.Height, Digit_4_10_Panel.Height)
            Digit_4_10_Lbl.Font = New Font("Consolas", Digit_4_10_Panel.Width)
        Else
            Digit_4_10_Lbl.Size = New Size(Digit_4_10_Panel.Width, Digit_4_10_Panel.Width)
            Digit_4_10_Lbl.Font = New Font("Consolas", Digit_4_10_Panel.Width)
        End If
        Digit_4_10_Lbl.Location = New Point((Digit_4_10_Panel.Width / 2) - (Digit_4_10_Lbl.Width / 2) + (Digit_Panel_4.Width / 20), (Digit_4_10_Panel.Height / 2) - (Digit_4_10_Lbl.Height / 2))

        Digit_5_1.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height)
        Digit_5_2.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height)
        Digit_5_3.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height)
        Digit_5_4.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height)
        Digit_5_5.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height)
        Digit_5_6.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height)
        Digit_5_7.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height)
        Digit_5_8.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height)
        Digit_5_9.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height)
        Digit_5_10_Panel.Size = New Size(Digit_Panel_5.Width, Digit_Panel_5.Height)
        If Digit_5_10_Panel.Height > Digit_5_10_Lbl.Width Then
            Digit_5_10_Lbl.Size = New Size(Digit_5_10_Panel.Height, Digit_5_10_Panel.Height)
            Digit_5_10_Lbl.Font = New Font("Consolas", Digit_5_10_Panel.Width)
        Else
            Digit_5_10_Lbl.Size = New Size(Digit_5_10_Panel.Width, Digit_5_10_Panel.Width)
            Digit_5_10_Lbl.Font = New Font("Consolas", Digit_5_10_Panel.Width)
        End If
        Digit_5_10_Lbl.Location = New Point((Digit_5_10_Panel.Width / 2) - (Digit_5_10_Lbl.Width / 2) + (Digit_Panel_5.Width / 20), (Digit_5_10_Panel.Height / 2) - (Digit_5_10_Lbl.Height / 2))

        Digit_6_1.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height)
        Digit_6_2.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height)
        Digit_6_3.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height)
        Digit_6_4.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height)
        Digit_6_5.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height)
        Digit_6_6.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height)
        Digit_6_7.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height)
        Digit_6_8.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height)
        Digit_6_9.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height)
        Digit_6_10_Panel.Size = New Size(Digit_Panel_6.Width, Digit_Panel_6.Height)
        If Digit_6_10_Panel.Height > Digit_6_10_Lbl.Width Then
            Digit_6_10_Lbl.Size = New Size(Digit_6_10_Panel.Height, Digit_6_10_Panel.Height)
            Digit_6_10_Lbl.Font = New Font("Consolas", Digit_6_10_Panel.Width)
        Else
            Digit_6_10_Lbl.Size = New Size(Digit_6_10_Panel.Width, Digit_6_10_Panel.Width)
            Digit_6_10_Lbl.Font = New Font("Consolas", Digit_6_10_Panel.Width)
        End If
        Digit_6_10_Lbl.Location = New Point((Digit_6_10_Panel.Width / 2) - (Digit_6_10_Lbl.Width / 2) + (Digit_Panel_6.Width / 20), (Digit_6_10_Panel.Height / 2) - (Digit_6_10_Lbl.Height / 2))



    End Sub



    Public Sub start_draw()

        set_draw()
        anim_Steps = 0
        Tmr_start_anim.Enabled = True

    End Sub

    Public Sub set_draw()
        Digit_1_1.Location = New Point(0, 0)
        Digit_1_2.Location = New Point(0, -Digit_Panel_1.Height)
        Digit_1_3.Location = New Point(0, -Digit_Panel_1.Height)
        Digit_1_4.Location = New Point(0, -Digit_Panel_1.Height)
        Digit_1_5.Location = New Point(0, -Digit_Panel_1.Height)
        Digit_1_6.Location = New Point(0, -Digit_Panel_1.Height)
        Digit_1_7.Location = New Point(0, -Digit_Panel_1.Height)
        Digit_1_8.Location = New Point(0, -Digit_Panel_1.Height)
        Digit_1_9.Location = New Point(0, -Digit_Panel_1.Height)
        Digit_1_10_Panel.Location = New Point(0, -Digit_Panel_1.Height)
        Digit_1_10_Panel.Visible = True
        Digit_1_1.Visible = True
        Digit_1_2.Visible = True
        Digit_1_3.Visible = False
        Digit_1_4.Visible = False
        Digit_1_5.Visible = False
        Digit_1_6.Visible = False
        Digit_1_7.Visible = False
        Digit_1_8.Visible = False
        Digit_1_9.Visible = False
        Digit_1_10_Lbl.Visible = True

        Digit_2_1.Location = New Point(0, 0)
        Digit_2_2.Location = New Point(0, -Digit_Panel_2.Height)
        Digit_2_3.Location = New Point(0, -Digit_Panel_2.Height)
        Digit_2_4.Location = New Point(0, -Digit_Panel_2.Height)
        Digit_2_5.Location = New Point(0, -Digit_Panel_2.Height)
        Digit_2_6.Location = New Point(0, -Digit_Panel_2.Height)
        Digit_2_7.Location = New Point(0, -Digit_Panel_2.Height)
        Digit_2_8.Location = New Point(0, -Digit_Panel_2.Height)
        Digit_2_9.Location = New Point(0, -Digit_Panel_2.Height)
        Digit_2_1.Visible = True
        Digit_2_2.Visible = True
        Digit_2_3.Visible = False
        Digit_2_4.Visible = False
        Digit_2_5.Visible = False
        Digit_2_6.Visible = False
        Digit_2_7.Visible = False
        Digit_2_8.Visible = False
        Digit_2_9.Visible = False
        Digit_2_10_Lbl.Visible = True
        Digit_2_10_Panel.Location = New Point(0, -Digit_Panel_2.Height)
        Digit_2_10_Panel.Visible = True

        Digit_3_1.Location = New Point(0, 0)
        Digit_3_2.Location = New Point(0, -Digit_Panel_3.Height)
        Digit_3_3.Location = New Point(0, -Digit_Panel_3.Height)
        Digit_3_4.Location = New Point(0, -Digit_Panel_3.Height)
        Digit_3_5.Location = New Point(0, -Digit_Panel_3.Height)
        Digit_3_6.Location = New Point(0, -Digit_Panel_3.Height)
        Digit_3_7.Location = New Point(0, -Digit_Panel_3.Height)
        Digit_3_8.Location = New Point(0, -Digit_Panel_3.Height)
        Digit_3_9.Location = New Point(0, -Digit_Panel_3.Height)
        Digit_3_1.Visible = True
        Digit_3_2.Visible = True
        Digit_3_3.Visible = False
        Digit_3_4.Visible = False
        Digit_3_5.Visible = False
        Digit_3_6.Visible = False
        Digit_3_7.Visible = False
        Digit_3_8.Visible = False
        Digit_3_9.Visible = False
        Digit_3_10_Lbl.Visible = True
        Digit_3_10_Panel.Location = New Point(0, -Digit_Panel_3.Height)
        Digit_3_10_Panel.Visible = True

        Digit_4_1.Location = New Point(0, 0)
        Digit_4_2.Location = New Point(0, -Digit_Panel_4.Height)
        Digit_4_3.Location = New Point(0, -Digit_Panel_4.Height)
        Digit_4_4.Location = New Point(0, -Digit_Panel_4.Height)
        Digit_4_5.Location = New Point(0, -Digit_Panel_4.Height)
        Digit_4_6.Location = New Point(0, -Digit_Panel_4.Height)
        Digit_4_7.Location = New Point(0, -Digit_Panel_4.Height)
        Digit_4_8.Location = New Point(0, -Digit_Panel_4.Height)
        Digit_4_9.Location = New Point(0, -Digit_Panel_4.Height)
        Digit_4_1.Visible = True
        Digit_4_2.Visible = True
        Digit_4_3.Visible = False
        Digit_4_4.Visible = False
        Digit_4_5.Visible = False
        Digit_4_6.Visible = False
        Digit_4_7.Visible = False
        Digit_4_8.Visible = False
        Digit_4_9.Visible = False
        Digit_4_10_Lbl.Visible = True
        Digit_4_10_Panel.Location = New Point(0, -Digit_Panel_4.Height)
        Digit_4_10_Panel.Visible = True

        Digit_5_1.Location = New Point(0, 0)
        Digit_5_2.Location = New Point(0, -Digit_Panel_5.Height)
        Digit_5_3.Location = New Point(0, -Digit_Panel_5.Height)
        Digit_5_4.Location = New Point(0, -Digit_Panel_5.Height)
        Digit_5_5.Location = New Point(0, -Digit_Panel_5.Height)
        Digit_5_6.Location = New Point(0, -Digit_Panel_5.Height)
        Digit_5_7.Location = New Point(0, -Digit_Panel_5.Height)
        Digit_5_8.Location = New Point(0, -Digit_Panel_5.Height)
        Digit_5_9.Location = New Point(0, -Digit_Panel_5.Height)
        Digit_5_1.Visible = True
        Digit_5_2.Visible = True
        Digit_5_3.Visible = False
        Digit_5_4.Visible = False
        Digit_5_5.Visible = False
        Digit_5_6.Visible = False
        Digit_5_7.Visible = False
        Digit_5_8.Visible = False
        Digit_5_9.Visible = False
        Digit_5_10_Lbl.Visible = True
        Digit_5_10_Panel.Location = New Point(0, -Digit_Panel_5.Height)
        Digit_5_10_Panel.Visible = True

        Digit_6_1.Location = New Point(0, 0)
        Digit_6_2.Location = New Point(0, -Digit_Panel_6.Height)
        Digit_6_3.Location = New Point(0, -Digit_Panel_6.Height)
        Digit_6_4.Location = New Point(0, -Digit_Panel_6.Height)
        Digit_6_5.Location = New Point(0, -Digit_Panel_6.Height)
        Digit_6_6.Location = New Point(0, -Digit_Panel_6.Height)
        Digit_6_7.Location = New Point(0, -Digit_Panel_6.Height)
        Digit_6_8.Location = New Point(0, -Digit_Panel_6.Height)
        Digit_6_9.Location = New Point(0, -Digit_Panel_6.Height)
        Digit_6_1.Visible = True
        Digit_6_2.Visible = True
        Digit_6_3.Visible = False
        Digit_6_4.Visible = False
        Digit_6_5.Visible = False
        Digit_6_6.Visible = False
        Digit_6_7.Visible = False
        Digit_6_8.Visible = False
        Digit_6_9.Visible = False
        Digit_6_10_Lbl.Visible = True
        Digit_6_10_Panel.Location = New Point(0, -Digit_Panel_6.Height)
        Digit_6_10_Panel.Visible = True

    End Sub

    Private Sub tmr_Animator_Digit_1_Tick(sender As Object, e As EventArgs) Handles tmr_Animator_Digit_1.Tick
        If Digit_1_1.Visible = True And Digit_1_2.Visible = True Then
            If Digit_1_1.Location.Y > Digit_Panel_1.Height Then
                If Digit_1_stop = True Then
                    tmr_digit_display_1.Enabled = True
                End If
                Digit_1_1.Visible = False
                Digit_1_2.Visible = True
                Digit_1_3.Visible = True
                Digit_1_4.Visible = False
                Digit_1_5.Visible = False
                Digit_1_6.Visible = False
                Digit_1_7.Visible = False
                Digit_1_8.Visible = False
                Digit_1_9.Visible = False

                Digit_1_2.Location = New Point(0, 0)
                Digit_1_3.Location = New Point(0, Digit_1_2.Location.Y - Digit_1_3.Height)
            Else
                Digit_1_1.Location = New Point(0, Digit_1_1.Location.Y + Scroll_Speed_1)
                Digit_1_2.Location = New Point(0, Digit_1_1.Location.Y - Digit_1_1.Height)

            End If


        ElseIf Digit_1_2.Visible = True And Digit_1_3.Visible = True Then
            If Digit_1_2.Location.Y > Digit_Panel_1.Height Then
                If Digit_1_stop = True Then
                    tmr_digit_display_1.Enabled = True
                End If
                Digit_1_1.Visible = False
                Digit_1_2.Visible = False
                Digit_1_3.Visible = True
                Digit_1_4.Visible = True
                Digit_1_5.Visible = False
                Digit_1_6.Visible = False
                Digit_1_7.Visible = False
                Digit_1_8.Visible = False
                Digit_1_9.Visible = False

                Digit_1_3.Location = New Point(0, 0)
                Digit_1_4.Location = New Point(0, Digit_1_3.Location.Y - Digit_1_4.Height)

            Else
                Digit_1_2.Location = New Point(0, Digit_1_2.Location.Y + Scroll_Speed_1)
                Digit_1_3.Location = New Point(0, Digit_1_2.Location.Y - Digit_1_2.Height)

            End If

        ElseIf Digit_1_3.Visible = True And Digit_1_4.Visible = True Then
            If Digit_1_3.Location.Y > Digit_Panel_1.Height Then
                If Digit_1_stop = True Then
                    tmr_digit_display_1.Enabled = True
                End If
                Digit_1_1.Visible = False
                Digit_1_2.Visible = False
                Digit_1_3.Visible = False
                Digit_1_4.Visible = True
                Digit_1_5.Visible = True
                Digit_1_6.Visible = False
                Digit_1_7.Visible = False
                Digit_1_8.Visible = False
                Digit_1_9.Visible = False

                Digit_1_4.Location = New Point(0, 0)
                Digit_1_5.Location = New Point(0, Digit_1_4.Location.Y - Digit_1_5.Height)

            Else
                Digit_1_3.Location = New Point(0, Digit_1_3.Location.Y + Scroll_Speed_1)
                Digit_1_4.Location = New Point(0, Digit_1_3.Location.Y - Digit_1_3.Height)

            End If

        ElseIf Digit_1_4.Visible = True And Digit_1_5.Visible = True Then
            If Digit_1_4.Location.Y > Digit_Panel_1.Height Then
                If Digit_1_stop = True Then
                    tmr_digit_display_1.Enabled = True
                End If
                Digit_1_1.Visible = False
                Digit_1_2.Visible = False
                Digit_1_3.Visible = False
                Digit_1_4.Visible = False
                Digit_1_5.Visible = True
                Digit_1_6.Visible = True
                Digit_1_7.Visible = False
                Digit_1_8.Visible = False
                Digit_1_9.Visible = False

                Digit_1_5.Location = New Point(0, 0)
                Digit_1_6.Location = New Point(0, Digit_1_5.Location.Y - Digit_1_6.Height)

            Else
                Digit_1_4.Location = New Point(0, Digit_1_4.Location.Y + Scroll_Speed_1)
                Digit_1_5.Location = New Point(0, Digit_1_4.Location.Y - Digit_1_4.Height)

            End If

        ElseIf Digit_1_5.Visible = True And Digit_1_6.Visible = True Then
            If Digit_1_5.Location.Y > Digit_Panel_1.Height Then
                If Digit_1_stop = True Then
                    tmr_digit_display_1.Enabled = True
                End If
                Digit_1_1.Visible = False
                Digit_1_2.Visible = False
                Digit_1_3.Visible = False
                Digit_1_4.Visible = False
                Digit_1_5.Visible = False
                Digit_1_6.Visible = True
                Digit_1_7.Visible = True
                Digit_1_8.Visible = False
                Digit_1_9.Visible = False

                Digit_1_6.Location = New Point(0, 0)
                Digit_1_7.Location = New Point(0, Digit_1_6.Location.Y - Digit_1_7.Height)

            Else
                Digit_1_5.Location = New Point(0, Digit_1_5.Location.Y + Scroll_Speed_1)
                Digit_1_6.Location = New Point(0, Digit_1_5.Location.Y - Digit_1_5.Height)

            End If

        ElseIf Digit_1_6.Visible = True And Digit_1_7.Visible = True Then
            If Digit_1_6.Location.Y > Digit_Panel_1.Height Then
                If Digit_1_stop = True Then
                    tmr_digit_display_1.Enabled = True
                End If
                Digit_1_1.Visible = False
                Digit_1_2.Visible = False
                Digit_1_3.Visible = False
                Digit_1_4.Visible = False
                Digit_1_5.Visible = False
                Digit_1_6.Visible = False
                Digit_1_7.Visible = True
                Digit_1_8.Visible = True
                Digit_1_9.Visible = False

                Digit_1_7.Location = New Point(0, 0)
                Digit_1_8.Location = New Point(0, Digit_1_7.Location.Y - Digit_1_8.Height)

            Else
                Digit_1_6.Location = New Point(0, Digit_1_6.Location.Y + Scroll_Speed_1)
                Digit_1_7.Location = New Point(0, Digit_1_6.Location.Y - Digit_1_6.Height)

            End If

        ElseIf Digit_1_7.Visible = True And Digit_1_8.Visible = True Then
            If Digit_1_7.Location.Y > Digit_Panel_1.Height Then
                If Digit_1_stop = True Then
                    tmr_digit_display_1.Enabled = True
                End If
                Digit_1_1.Visible = False
                Digit_1_2.Visible = False
                Digit_1_3.Visible = False
                Digit_1_4.Visible = False
                Digit_1_5.Visible = False
                Digit_1_6.Visible = False
                Digit_1_7.Visible = False
                Digit_1_8.Visible = True
                Digit_1_9.Visible = True

                Digit_1_8.Location = New Point(0, 0)
                Digit_1_9.Location = New Point(0, Digit_1_8.Location.Y - Digit_1_9.Height)

            Else
                Digit_1_7.Location = New Point(0, Digit_1_7.Location.Y + Scroll_Speed_1)
                Digit_1_8.Location = New Point(0, Digit_1_7.Location.Y - Digit_1_7.Height)

            End If

        ElseIf Digit_1_8.Visible = True And Digit_1_9.Visible = True Then
            If Digit_1_8.Location.Y > Digit_Panel_1.Height Then
                If Digit_1_stop = True Then
                    tmr_digit_display_1.Enabled = True
                End If
                Digit_1_1.Visible = True
                Digit_1_2.Visible = False
                Digit_1_3.Visible = False
                Digit_1_4.Visible = False
                Digit_1_5.Visible = False
                Digit_1_6.Visible = False
                Digit_1_7.Visible = False
                Digit_1_8.Visible = False
                Digit_1_9.Visible = True

                Digit_1_9.Location = New Point(0, 0)
                Digit_1_1.Location = New Point(0, Digit_1_9.Location.Y - Digit_1_1.Height)

            Else
                Digit_1_8.Location = New Point(0, Digit_1_8.Location.Y + Scroll_Speed_1)
                Digit_1_9.Location = New Point(0, Digit_1_8.Location.Y - Digit_1_8.Height)

            End If

        ElseIf Digit_1_9.Visible = True And Digit_1_1.Visible = True Then
            If Digit_1_9.Location.Y > Digit_Panel_1.Height Then
                If Digit_1_stop = True Then
                    tmr_digit_display_1.Enabled = True
                End If
                Digit_1_1.Visible = True
                Digit_1_2.Visible = True
                Digit_1_3.Visible = False
                Digit_1_4.Visible = False
                Digit_1_5.Visible = False
                Digit_1_6.Visible = False
                Digit_1_7.Visible = False
                Digit_1_8.Visible = False
                Digit_1_9.Visible = False

                Digit_1_1.Location = New Point(0, 0)
                Digit_1_2.Location = New Point(0, Digit_1_1.Location.Y - Digit_1_2.Height)

            Else
                Digit_1_9.Location = New Point(0, Digit_1_9.Location.Y + Scroll_Speed_1)
                Digit_1_1.Location = New Point(0, Digit_1_9.Location.Y - Digit_1_9.Height)

            End If

        End If
    End Sub

    Private Sub tmr_Animator_Digit_2_Tick(sender As Object, e As EventArgs) Handles tmr_Animator_Digit_2.Tick
        If Digit_2_1.Visible = True And Digit_2_2.Visible = True Then
            If Digit_2_1.Location.Y > Digit_Panel_2.Height Then
                If Digit_2_stop = True Then
                    tmr_digit_display_2.Enabled = True
                End If
                Digit_2_1.Visible = False
                Digit_2_2.Visible = True
                Digit_2_3.Visible = True
                Digit_2_4.Visible = False
                Digit_2_5.Visible = False
                Digit_2_6.Visible = False
                Digit_2_7.Visible = False
                Digit_2_8.Visible = False
                Digit_2_9.Visible = False

                Digit_2_2.Location = New Point(0, 0)
                Digit_2_3.Location = New Point(0, Digit_2_2.Location.Y - Digit_2_3.Height)

            Else
                Digit_2_1.Location = New Point(0, Digit_2_1.Location.Y + Scroll_Speed_2)
                Digit_2_2.Location = New Point(0, Digit_2_1.Location.Y - Digit_2_1.Height)

            End If


        ElseIf Digit_2_2.Visible = True And Digit_2_3.Visible = True Then
            If Digit_2_2.Location.Y > Digit_Panel_2.Height Then
                If Digit_2_stop = True Then
                    tmr_digit_display_2.Enabled = True
                End If
                Digit_2_1.Visible = False
                Digit_2_2.Visible = False
                Digit_2_3.Visible = True
                Digit_2_4.Visible = True
                Digit_2_5.Visible = False
                Digit_2_6.Visible = False
                Digit_2_7.Visible = False
                Digit_2_8.Visible = False
                Digit_2_9.Visible = False

                Digit_2_3.Location = New Point(0, 0)
                Digit_2_4.Location = New Point(0, Digit_2_3.Location.Y - Digit_2_4.Height)

            Else
                Digit_2_2.Location = New Point(0, Digit_2_2.Location.Y + Scroll_Speed_2)
                Digit_2_3.Location = New Point(0, Digit_2_2.Location.Y - Digit_2_2.Height)

            End If

        ElseIf Digit_2_3.Visible = True And Digit_2_4.Visible = True Then
            If Digit_2_3.Location.Y > Digit_Panel_2.Height Then
                If Digit_2_stop = True Then
                    tmr_digit_display_2.Enabled = True
                End If
                Digit_2_1.Visible = False
                Digit_2_2.Visible = False
                Digit_2_3.Visible = False
                Digit_2_4.Visible = True
                Digit_2_5.Visible = True
                Digit_2_6.Visible = False
                Digit_2_7.Visible = False
                Digit_2_8.Visible = False
                Digit_2_9.Visible = False

                Digit_2_4.Location = New Point(0, 0)
                Digit_2_5.Location = New Point(0, Digit_2_4.Location.Y - Digit_2_5.Height)

            Else
                Digit_2_3.Location = New Point(0, Digit_2_3.Location.Y + Scroll_Speed_2)
                Digit_2_4.Location = New Point(0, Digit_2_3.Location.Y - Digit_2_3.Height)

            End If

        ElseIf Digit_2_4.Visible = True And Digit_2_5.Visible = True Then
            If Digit_2_4.Location.Y > Digit_Panel_2.Height Then
                If Digit_2_stop = True Then
                    tmr_digit_display_2.Enabled = True
                End If
                Digit_2_1.Visible = False
                Digit_2_2.Visible = False
                Digit_2_3.Visible = False
                Digit_2_4.Visible = False
                Digit_2_5.Visible = True
                Digit_2_6.Visible = True
                Digit_2_7.Visible = False
                Digit_2_8.Visible = False
                Digit_2_9.Visible = False

                Digit_2_5.Location = New Point(0, 0)
                Digit_2_6.Location = New Point(0, Digit_2_5.Location.Y - Digit_2_6.Height)

            Else
                Digit_2_4.Location = New Point(0, Digit_2_4.Location.Y + Scroll_Speed_2)
                Digit_2_5.Location = New Point(0, Digit_2_4.Location.Y - Digit_2_4.Height)

            End If

        ElseIf Digit_2_5.Visible = True And Digit_2_6.Visible = True Then
            If Digit_2_5.Location.Y > Digit_Panel_2.Height Then
                If Digit_2_stop = True Then
                    tmr_digit_display_2.Enabled = True
                End If
                Digit_2_1.Visible = False
                Digit_2_2.Visible = False
                Digit_2_3.Visible = False
                Digit_2_4.Visible = False
                Digit_2_5.Visible = False
                Digit_2_6.Visible = True
                Digit_2_7.Visible = True
                Digit_2_8.Visible = False
                Digit_2_9.Visible = False

                Digit_2_6.Location = New Point(0, 0)
                Digit_2_7.Location = New Point(0, Digit_2_6.Location.Y - Digit_2_7.Height)

            Else
                Digit_2_5.Location = New Point(0, Digit_2_5.Location.Y + Scroll_Speed_2)
                Digit_2_6.Location = New Point(0, Digit_2_5.Location.Y - Digit_2_5.Height)

            End If

        ElseIf Digit_2_6.Visible = True And Digit_2_7.Visible = True Then
            If Digit_2_6.Location.Y > Digit_Panel_2.Height Then
                If Digit_2_stop = True Then
                    tmr_digit_display_2.Enabled = True
                End If
                Digit_2_1.Visible = False
                Digit_2_2.Visible = False
                Digit_2_3.Visible = False
                Digit_2_4.Visible = False
                Digit_2_5.Visible = False
                Digit_2_6.Visible = False
                Digit_2_7.Visible = True
                Digit_2_8.Visible = True
                Digit_2_9.Visible = False

                Digit_2_7.Location = New Point(0, 0)
                Digit_2_8.Location = New Point(0, Digit_2_7.Location.Y - Digit_2_8.Height)

            Else
                Digit_2_6.Location = New Point(0, Digit_2_6.Location.Y + Scroll_Speed_2)
                Digit_2_7.Location = New Point(0, Digit_2_6.Location.Y - Digit_2_6.Height)

            End If

        ElseIf Digit_2_7.Visible = True And Digit_2_8.Visible = True Then
            If Digit_2_7.Location.Y > Digit_Panel_2.Height Then
                If Digit_2_stop = True Then
                    tmr_digit_display_2.Enabled = True
                End If
                Digit_2_1.Visible = False
                Digit_2_2.Visible = False
                Digit_2_3.Visible = False
                Digit_2_4.Visible = False
                Digit_2_5.Visible = False
                Digit_2_6.Visible = False
                Digit_2_7.Visible = False
                Digit_2_8.Visible = True
                Digit_2_9.Visible = True

                Digit_2_8.Location = New Point(0, 0)
                Digit_2_9.Location = New Point(0, Digit_2_8.Location.Y - Digit_2_9.Height)

            Else
                Digit_2_7.Location = New Point(0, Digit_2_7.Location.Y + Scroll_Speed_2)
                Digit_2_8.Location = New Point(0, Digit_2_7.Location.Y - Digit_2_7.Height)

            End If

        ElseIf Digit_2_8.Visible = True And Digit_2_9.Visible = True Then
            If Digit_2_8.Location.Y > Digit_Panel_2.Height Then
                If Digit_2_stop = True Then
                    tmr_digit_display_2.Enabled = True
                End If
                Digit_2_1.Visible = True
                Digit_2_2.Visible = False
                Digit_2_3.Visible = False
                Digit_2_4.Visible = False
                Digit_2_5.Visible = False
                Digit_2_6.Visible = False
                Digit_2_7.Visible = False
                Digit_2_8.Visible = False
                Digit_2_9.Visible = True

                Digit_2_9.Location = New Point(0, 0)
                Digit_2_1.Location = New Point(0, Digit_2_9.Location.Y - Digit_2_1.Height)

            Else
                Digit_2_8.Location = New Point(0, Digit_2_8.Location.Y + Scroll_Speed_2)
                Digit_2_9.Location = New Point(0, Digit_2_8.Location.Y - Digit_2_8.Height)

            End If

        ElseIf Digit_2_9.Visible = True And Digit_2_1.Visible = True Then
            If Digit_2_9.Location.Y > Digit_Panel_2.Height Then
                If Digit_2_stop = True Then
                    tmr_digit_display_2.Enabled = True
                End If
                Digit_2_1.Visible = True
                Digit_2_2.Visible = True
                Digit_2_3.Visible = False
                Digit_2_4.Visible = False
                Digit_2_5.Visible = False
                Digit_2_6.Visible = False
                Digit_2_7.Visible = False
                Digit_2_8.Visible = False
                Digit_2_9.Visible = False

                Digit_2_1.Location = New Point(0, 0)
                Digit_2_2.Location = New Point(0, Digit_2_1.Location.Y - Digit_2_2.Height)

            Else
                Digit_2_9.Location = New Point(0, Digit_2_9.Location.Y + Scroll_Speed_2)
                Digit_2_1.Location = New Point(0, Digit_2_9.Location.Y - Digit_2_9.Height)

            End If

        End If
    End Sub

    Private Sub tmr_Animator_Digit_3_Tick(sender As Object, e As EventArgs) Handles tmr_Animator_Digit_3.Tick
        If Digit_3_1.Visible = True And Digit_3_2.Visible = True Then
            If Digit_3_1.Location.Y > Digit_Panel_3.Height Then
                If Digit_3_stop = True Then
                    tmr_digit_display_3.Enabled = True
                End If
                Digit_3_1.Visible = False
                Digit_3_2.Visible = True
                Digit_3_3.Visible = True
                Digit_3_4.Visible = False
                Digit_3_5.Visible = False
                Digit_3_6.Visible = False
                Digit_3_7.Visible = False
                Digit_3_8.Visible = False
                Digit_3_9.Visible = False

                Digit_3_2.Location = New Point(0, 0)
                Digit_3_3.Location = New Point(0, Digit_3_2.Location.Y - Digit_3_3.Height)

            Else
                Digit_3_1.Location = New Point(0, Digit_3_1.Location.Y + Scroll_Speed_3)
                Digit_3_2.Location = New Point(0, Digit_3_1.Location.Y - Digit_3_1.Height)

            End If


        ElseIf Digit_3_2.Visible = True And Digit_3_3.Visible = True Then
            If Digit_3_2.Location.Y > Digit_Panel_3.Height Then
                If Digit_3_stop = True Then
                    tmr_digit_display_3.Enabled = True
                End If
                Digit_3_1.Visible = False
                Digit_3_2.Visible = False
                Digit_3_3.Visible = True
                Digit_3_4.Visible = True
                Digit_3_5.Visible = False
                Digit_3_6.Visible = False
                Digit_3_7.Visible = False
                Digit_3_8.Visible = False
                Digit_3_9.Visible = False

                Digit_3_3.Location = New Point(0, 0)
                Digit_3_4.Location = New Point(0, Digit_3_3.Location.Y - Digit_3_4.Height)

            Else
                Digit_3_2.Location = New Point(0, Digit_3_2.Location.Y + Scroll_Speed_3)
                Digit_3_3.Location = New Point(0, Digit_3_2.Location.Y - Digit_3_2.Height)

            End If

        ElseIf Digit_3_3.Visible = True And Digit_3_4.Visible = True Then
            If Digit_3_3.Location.Y > Digit_Panel_3.Height Then
                If Digit_3_stop = True Then
                    tmr_digit_display_3.Enabled = True
                End If
                Digit_3_1.Visible = False
                Digit_3_2.Visible = False
                Digit_3_3.Visible = False
                Digit_3_4.Visible = True
                Digit_3_5.Visible = True
                Digit_3_6.Visible = False
                Digit_3_7.Visible = False
                Digit_3_8.Visible = False
                Digit_3_9.Visible = False

                Digit_3_4.Location = New Point(0, 0)
                Digit_3_5.Location = New Point(0, Digit_3_4.Location.Y - Digit_3_5.Height)

            Else
                Digit_3_3.Location = New Point(0, Digit_3_3.Location.Y + Scroll_Speed_3)
                Digit_3_4.Location = New Point(0, Digit_3_3.Location.Y - Digit_3_3.Height)

            End If

        ElseIf Digit_3_4.Visible = True And Digit_3_5.Visible = True Then
            If Digit_3_4.Location.Y > Digit_Panel_3.Height Then
                If Digit_3_stop = True Then
                    tmr_digit_display_3.Enabled = True
                End If
                Digit_3_1.Visible = False
                Digit_3_2.Visible = False
                Digit_3_3.Visible = False
                Digit_3_4.Visible = False
                Digit_3_5.Visible = True
                Digit_3_6.Visible = True
                Digit_3_7.Visible = False
                Digit_3_8.Visible = False
                Digit_3_9.Visible = False

                Digit_3_5.Location = New Point(0, 0)
                Digit_3_6.Location = New Point(0, Digit_3_5.Location.Y - Digit_3_6.Height)

            Else
                Digit_3_4.Location = New Point(0, Digit_3_4.Location.Y + Scroll_Speed_3)
                Digit_3_5.Location = New Point(0, Digit_3_4.Location.Y - Digit_3_4.Height)

            End If

        ElseIf Digit_3_5.Visible = True And Digit_3_6.Visible = True Then
            If Digit_3_5.Location.Y > Digit_Panel_3.Height Then
                If Digit_3_stop = True Then
                    tmr_digit_display_3.Enabled = True
                End If
                Digit_3_1.Visible = False
                Digit_3_2.Visible = False
                Digit_3_3.Visible = False
                Digit_3_4.Visible = False
                Digit_3_5.Visible = False
                Digit_3_6.Visible = True
                Digit_3_7.Visible = True
                Digit_3_8.Visible = False
                Digit_3_9.Visible = False

                Digit_3_6.Location = New Point(0, 0)
                Digit_3_7.Location = New Point(0, Digit_3_6.Location.Y - Digit_3_7.Height)

            Else
                Digit_3_5.Location = New Point(0, Digit_3_5.Location.Y + Scroll_Speed_3)
                Digit_3_6.Location = New Point(0, Digit_3_5.Location.Y - Digit_3_5.Height)

            End If

        ElseIf Digit_3_6.Visible = True And Digit_3_7.Visible = True Then
            If Digit_3_6.Location.Y > Digit_Panel_3.Height Then
                If Digit_3_stop = True Then
                    tmr_digit_display_3.Enabled = True
                End If
                Digit_3_1.Visible = False
                Digit_3_2.Visible = False
                Digit_3_3.Visible = False
                Digit_3_4.Visible = False
                Digit_3_5.Visible = False
                Digit_3_6.Visible = False
                Digit_3_7.Visible = True
                Digit_3_8.Visible = True
                Digit_3_9.Visible = False

                Digit_3_7.Location = New Point(0, 0)
                Digit_3_8.Location = New Point(0, Digit_3_7.Location.Y - Digit_3_8.Height)

            Else
                Digit_3_6.Location = New Point(0, Digit_3_6.Location.Y + Scroll_Speed_3)
                Digit_3_7.Location = New Point(0, Digit_3_6.Location.Y - Digit_3_6.Height)

            End If

        ElseIf Digit_3_7.Visible = True And Digit_3_8.Visible = True Then
            If Digit_3_7.Location.Y > Digit_Panel_3.Height Then
                If Digit_3_stop = True Then
                    tmr_digit_display_3.Enabled = True
                End If
                Digit_3_1.Visible = False
                Digit_3_2.Visible = False
                Digit_3_3.Visible = False
                Digit_3_4.Visible = False
                Digit_3_5.Visible = False
                Digit_3_6.Visible = False
                Digit_3_7.Visible = False
                Digit_3_8.Visible = True
                Digit_3_9.Visible = True

                Digit_3_8.Location = New Point(0, 0)
                Digit_3_9.Location = New Point(0, Digit_3_8.Location.Y - Digit_3_9.Height)

            Else
                Digit_3_7.Location = New Point(0, Digit_3_7.Location.Y + Scroll_Speed_3)
                Digit_3_8.Location = New Point(0, Digit_3_7.Location.Y - Digit_3_7.Height)

            End If

        ElseIf Digit_3_8.Visible = True And Digit_3_9.Visible = True Then
            If Digit_3_8.Location.Y > Digit_Panel_3.Height Then
                If Digit_3_stop = True Then
                    tmr_digit_display_3.Enabled = True
                End If
                Digit_3_1.Visible = True
                Digit_3_2.Visible = False
                Digit_3_3.Visible = False
                Digit_3_4.Visible = False
                Digit_3_5.Visible = False
                Digit_3_6.Visible = False
                Digit_3_7.Visible = False
                Digit_3_8.Visible = False
                Digit_3_9.Visible = True

                Digit_3_9.Location = New Point(0, 0)
                Digit_3_1.Location = New Point(0, Digit_3_9.Location.Y - Digit_3_1.Height)

            Else
                Digit_3_8.Location = New Point(0, Digit_3_8.Location.Y + Scroll_Speed_3)
                Digit_3_9.Location = New Point(0, Digit_3_8.Location.Y - Digit_3_8.Height)

            End If

        ElseIf Digit_3_9.Visible = True And Digit_3_1.Visible = True Then
            If Digit_3_9.Location.Y > Digit_Panel_3.Height Then
                If Digit_3_stop = True Then
                    tmr_digit_display_3.Enabled = True
                End If
                Digit_3_1.Visible = True
                Digit_3_2.Visible = True
                Digit_3_3.Visible = False
                Digit_3_4.Visible = False
                Digit_3_5.Visible = False
                Digit_3_6.Visible = False
                Digit_3_7.Visible = False
                Digit_3_8.Visible = False
                Digit_3_9.Visible = False

                Digit_3_1.Location = New Point(0, 0)
                Digit_3_2.Location = New Point(0, Digit_3_1.Location.Y - Digit_3_2.Height)

            Else
                Digit_3_9.Location = New Point(0, Digit_3_9.Location.Y + Scroll_Speed_3)
                Digit_3_1.Location = New Point(0, Digit_3_9.Location.Y - Digit_3_9.Height)

            End If

        End If
    End Sub

    Private Sub tmr_Animator_Digit_4_Tick(sender As Object, e As EventArgs) Handles tmr_Animator_Digit_4.Tick
        If Digit_4_1.Visible = True And Digit_4_2.Visible = True Then
            If Digit_4_1.Location.Y > Digit_Panel_4.Height Then
                If Digit_4_stop = True Then
                    tmr_digit_display_4.Enabled = True
                End If
                Digit_4_1.Visible = False
                Digit_4_2.Visible = True
                Digit_4_3.Visible = True
                Digit_4_4.Visible = False
                Digit_4_5.Visible = False
                Digit_4_6.Visible = False
                Digit_4_7.Visible = False
                Digit_4_8.Visible = False
                Digit_4_9.Visible = False

                Digit_4_2.Location = New Point(0, 0)
                Digit_4_3.Location = New Point(0, Digit_4_2.Location.Y - Digit_4_3.Height)

            Else
                Digit_4_1.Location = New Point(0, Digit_4_1.Location.Y + Scroll_Speed_4)
                Digit_4_2.Location = New Point(0, Digit_4_1.Location.Y - Digit_4_1.Height)

            End If


        ElseIf Digit_4_2.Visible = True And Digit_4_3.Visible = True Then
            If Digit_4_2.Location.Y > Digit_Panel_4.Height Then
                If Digit_4_stop = True Then
                    tmr_digit_display_4.Enabled = True
                End If
                Digit_4_1.Visible = False
                Digit_4_2.Visible = False
                Digit_4_3.Visible = True
                Digit_4_4.Visible = True
                Digit_4_5.Visible = False
                Digit_4_6.Visible = False
                Digit_4_7.Visible = False
                Digit_4_8.Visible = False
                Digit_4_9.Visible = False

                Digit_4_3.Location = New Point(0, 0)
                Digit_4_4.Location = New Point(0, Digit_4_3.Location.Y - Digit_4_4.Height)

            Else
                Digit_4_2.Location = New Point(0, Digit_4_2.Location.Y + Scroll_Speed_4)
                Digit_4_3.Location = New Point(0, Digit_4_2.Location.Y - Digit_4_2.Height)

            End If

        ElseIf Digit_4_3.Visible = True And Digit_4_4.Visible = True Then
            If Digit_4_3.Location.Y > Digit_Panel_4.Height Then
                If Digit_4_stop = True Then
                    tmr_digit_display_4.Enabled = True
                End If
                Digit_4_1.Visible = False
                Digit_4_2.Visible = False
                Digit_4_3.Visible = False
                Digit_4_4.Visible = True
                Digit_4_5.Visible = True
                Digit_4_6.Visible = False
                Digit_4_7.Visible = False
                Digit_4_8.Visible = False
                Digit_4_9.Visible = False

                Digit_4_4.Location = New Point(0, 0)
                Digit_4_5.Location = New Point(0, Digit_4_4.Location.Y - Digit_4_5.Height)

            Else
                Digit_4_3.Location = New Point(0, Digit_4_3.Location.Y + Scroll_Speed_4)
                Digit_4_4.Location = New Point(0, Digit_4_3.Location.Y - Digit_4_3.Height)

            End If

        ElseIf Digit_4_4.Visible = True And Digit_4_5.Visible = True Then
            If Digit_4_4.Location.Y > Digit_Panel_4.Height Then
                If Digit_4_stop = True Then
                    tmr_digit_display_4.Enabled = True
                End If
                Digit_4_1.Visible = False
                Digit_4_2.Visible = False
                Digit_4_3.Visible = False
                Digit_4_4.Visible = False
                Digit_4_5.Visible = True
                Digit_4_6.Visible = True
                Digit_4_7.Visible = False
                Digit_4_8.Visible = False
                Digit_4_9.Visible = False

                Digit_4_5.Location = New Point(0, 0)
                Digit_4_6.Location = New Point(0, Digit_4_5.Location.Y - Digit_4_6.Height)

            Else
                Digit_4_4.Location = New Point(0, Digit_4_4.Location.Y + Scroll_Speed_4)
                Digit_4_5.Location = New Point(0, Digit_4_4.Location.Y - Digit_4_4.Height)

            End If

        ElseIf Digit_4_5.Visible = True And Digit_4_6.Visible = True Then
            If Digit_4_5.Location.Y > Digit_Panel_4.Height Then
                If Digit_4_stop = True Then
                    tmr_digit_display_4.Enabled = True
                End If
                Digit_4_1.Visible = False
                Digit_4_2.Visible = False
                Digit_4_3.Visible = False
                Digit_4_4.Visible = False
                Digit_4_5.Visible = False
                Digit_4_6.Visible = True
                Digit_4_7.Visible = True
                Digit_4_8.Visible = False
                Digit_4_9.Visible = False

                Digit_4_6.Location = New Point(0, 0)
                Digit_4_7.Location = New Point(0, Digit_4_6.Location.Y - Digit_4_7.Height)

            Else
                Digit_4_5.Location = New Point(0, Digit_4_5.Location.Y + Scroll_Speed_4)
                Digit_4_6.Location = New Point(0, Digit_4_5.Location.Y - Digit_4_5.Height)

            End If

        ElseIf Digit_4_6.Visible = True And Digit_4_7.Visible = True Then
            If Digit_4_6.Location.Y > Digit_Panel_4.Height Then
                If Digit_4_stop = True Then
                    tmr_digit_display_4.Enabled = True
                End If
                Digit_4_1.Visible = False
                Digit_4_2.Visible = False
                Digit_4_3.Visible = False
                Digit_4_4.Visible = False
                Digit_4_5.Visible = False
                Digit_4_6.Visible = False
                Digit_4_7.Visible = True
                Digit_4_8.Visible = True
                Digit_4_9.Visible = False

                Digit_4_7.Location = New Point(0, 0)
                Digit_4_8.Location = New Point(0, Digit_4_7.Location.Y - Digit_4_8.Height)

            Else
                Digit_4_6.Location = New Point(0, Digit_4_6.Location.Y + Scroll_Speed_4)
                Digit_4_7.Location = New Point(0, Digit_4_6.Location.Y - Digit_4_6.Height)

            End If

        ElseIf Digit_4_7.Visible = True And Digit_4_8.Visible = True Then
            If Digit_4_7.Location.Y > Digit_Panel_4.Height Then
                If Digit_4_stop = True Then
                    tmr_digit_display_4.Enabled = True
                End If
                Digit_4_1.Visible = False
                Digit_4_2.Visible = False
                Digit_4_3.Visible = False
                Digit_4_4.Visible = False
                Digit_4_5.Visible = False
                Digit_4_6.Visible = False
                Digit_4_7.Visible = False
                Digit_4_8.Visible = True
                Digit_4_9.Visible = True

                Digit_4_8.Location = New Point(0, 0)
                Digit_4_9.Location = New Point(0, Digit_4_8.Location.Y - Digit_4_9.Height)

            Else
                Digit_4_7.Location = New Point(0, Digit_4_7.Location.Y + Scroll_Speed_4)
                Digit_4_8.Location = New Point(0, Digit_4_7.Location.Y - Digit_4_7.Height)

            End If

        ElseIf Digit_4_8.Visible = True And Digit_4_9.Visible = True Then
            If Digit_4_8.Location.Y > Digit_Panel_4.Height Then
                If Digit_4_stop = True Then
                    tmr_digit_display_4.Enabled = True
                End If
                Digit_4_1.Visible = True
                Digit_4_2.Visible = False
                Digit_4_3.Visible = False
                Digit_4_4.Visible = False
                Digit_4_5.Visible = False
                Digit_4_6.Visible = False
                Digit_4_7.Visible = False
                Digit_4_8.Visible = False
                Digit_4_9.Visible = True

                Digit_4_9.Location = New Point(0, 0)
                Digit_4_1.Location = New Point(0, Digit_4_9.Location.Y - Digit_4_1.Height)

            Else
                Digit_4_8.Location = New Point(0, Digit_4_8.Location.Y + Scroll_Speed_4)
                Digit_4_9.Location = New Point(0, Digit_4_8.Location.Y - Digit_4_8.Height)

            End If

        ElseIf Digit_4_9.Visible = True And Digit_4_1.Visible = True Then
            If Digit_4_9.Location.Y > Digit_Panel_4.Height Then
                If Digit_4_stop = True Then
                    tmr_digit_display_4.Enabled = True
                End If
                Digit_4_1.Visible = True
                Digit_4_2.Visible = True
                Digit_4_3.Visible = False
                Digit_4_4.Visible = False
                Digit_4_5.Visible = False
                Digit_4_6.Visible = False
                Digit_4_7.Visible = False
                Digit_4_8.Visible = False
                Digit_4_9.Visible = False

                Digit_4_1.Location = New Point(0, 0)
                Digit_4_2.Location = New Point(0, Digit_4_1.Location.Y - Digit_4_2.Height)

            Else
                Digit_4_9.Location = New Point(0, Digit_4_9.Location.Y + Scroll_Speed_4)
                Digit_4_1.Location = New Point(0, Digit_4_9.Location.Y - Digit_4_9.Height)

            End If

        End If
    End Sub

    Private Sub tmr_Animator_Digit_5_Tick(sender As Object, e As EventArgs) Handles tmr_Animator_Digit_5.Tick
        If Digit_5_1.Visible = True And Digit_5_2.Visible = True Then
            If Digit_5_1.Location.Y > Digit_Panel_5.Height Then
                If Digit_5_stop = True Then
                    tmr_digit_display_5.Enabled = True
                End If
                Digit_5_1.Visible = False
                Digit_5_2.Visible = True
                Digit_5_3.Visible = True
                Digit_5_4.Visible = False
                Digit_5_5.Visible = False
                Digit_5_6.Visible = False
                Digit_5_7.Visible = False
                Digit_5_8.Visible = False
                Digit_5_9.Visible = False

                Digit_5_2.Location = New Point(0, 0)
                Digit_5_3.Location = New Point(0, Digit_5_2.Location.Y - Digit_5_3.Height)

            Else
                Digit_5_1.Location = New Point(0, Digit_5_1.Location.Y + Scroll_Speed_5)
                Digit_5_2.Location = New Point(0, Digit_5_1.Location.Y - Digit_5_1.Height)

            End If


        ElseIf Digit_5_2.Visible = True And Digit_5_3.Visible = True Then
            If Digit_5_2.Location.Y > Digit_Panel_5.Height Then
                If Digit_5_stop = True Then
                    tmr_digit_display_5.Enabled = True
                End If
                Digit_5_1.Visible = False
                Digit_5_2.Visible = False
                Digit_5_3.Visible = True
                Digit_5_4.Visible = True
                Digit_5_5.Visible = False
                Digit_5_6.Visible = False
                Digit_5_7.Visible = False
                Digit_5_8.Visible = False
                Digit_5_9.Visible = False

                Digit_5_3.Location = New Point(0, 0)
                Digit_5_4.Location = New Point(0, Digit_5_3.Location.Y - Digit_5_4.Height)

            Else
                Digit_5_2.Location = New Point(0, Digit_5_2.Location.Y + Scroll_Speed_5)
                Digit_5_3.Location = New Point(0, Digit_5_2.Location.Y - Digit_5_2.Height)

            End If

        ElseIf Digit_5_3.Visible = True And Digit_5_4.Visible = True Then
            If Digit_5_3.Location.Y > Digit_Panel_5.Height Then
                If Digit_5_stop = True Then
                    tmr_digit_display_5.Enabled = True
                End If
                Digit_5_1.Visible = False
                Digit_5_2.Visible = False
                Digit_5_3.Visible = False
                Digit_5_4.Visible = True
                Digit_5_5.Visible = True
                Digit_5_6.Visible = False
                Digit_5_7.Visible = False
                Digit_5_8.Visible = False
                Digit_5_9.Visible = False

                Digit_5_4.Location = New Point(0, 0)
                Digit_5_5.Location = New Point(0, Digit_5_4.Location.Y - Digit_5_5.Height)

            Else
                Digit_5_3.Location = New Point(0, Digit_5_3.Location.Y + Scroll_Speed_5)
                Digit_5_4.Location = New Point(0, Digit_5_3.Location.Y - Digit_5_3.Height)

            End If

        ElseIf Digit_5_4.Visible = True And Digit_5_5.Visible = True Then
            If Digit_5_4.Location.Y > Digit_Panel_5.Height Then
                If Digit_5_stop = True Then
                    tmr_digit_display_5.Enabled = True
                End If
                Digit_5_1.Visible = False
                Digit_5_2.Visible = False
                Digit_5_3.Visible = False
                Digit_5_4.Visible = False
                Digit_5_5.Visible = True
                Digit_5_6.Visible = True
                Digit_5_7.Visible = False
                Digit_5_8.Visible = False
                Digit_5_9.Visible = False

                Digit_5_5.Location = New Point(0, 0)
                Digit_5_6.Location = New Point(0, Digit_5_5.Location.Y - Digit_5_6.Height)

            Else
                Digit_5_4.Location = New Point(0, Digit_5_4.Location.Y + Scroll_Speed_5)
                Digit_5_5.Location = New Point(0, Digit_5_4.Location.Y - Digit_5_4.Height)

            End If

        ElseIf Digit_5_5.Visible = True And Digit_5_6.Visible = True Then
            If Digit_5_5.Location.Y > Digit_Panel_5.Height Then
                If Digit_5_stop = True Then
                    tmr_digit_display_5.Enabled = True
                End If
                Digit_5_1.Visible = False
                Digit_5_2.Visible = False
                Digit_5_3.Visible = False
                Digit_5_4.Visible = False
                Digit_5_5.Visible = False
                Digit_5_6.Visible = True
                Digit_5_7.Visible = True
                Digit_5_8.Visible = False
                Digit_5_9.Visible = False

                Digit_5_6.Location = New Point(0, 0)
                Digit_5_7.Location = New Point(0, Digit_5_6.Location.Y - Digit_5_7.Height)

            Else
                Digit_5_5.Location = New Point(0, Digit_5_5.Location.Y + Scroll_Speed_5)
                Digit_5_6.Location = New Point(0, Digit_5_5.Location.Y - Digit_5_5.Height)

            End If

        ElseIf Digit_5_6.Visible = True And Digit_5_7.Visible = True Then
            If Digit_5_6.Location.Y > Digit_Panel_5.Height Then
                If Digit_5_stop = True Then
                    tmr_digit_display_5.Enabled = True
                End If
                Digit_5_1.Visible = False
                Digit_5_2.Visible = False
                Digit_5_3.Visible = False
                Digit_5_4.Visible = False
                Digit_5_5.Visible = False
                Digit_5_6.Visible = False
                Digit_5_7.Visible = True
                Digit_5_8.Visible = True
                Digit_5_9.Visible = False

                Digit_5_7.Location = New Point(0, 0)
                Digit_5_8.Location = New Point(0, Digit_5_7.Location.Y - Digit_5_8.Height)

            Else
                Digit_5_6.Location = New Point(0, Digit_5_6.Location.Y + Scroll_Speed_5)
                Digit_5_7.Location = New Point(0, Digit_5_6.Location.Y - Digit_5_6.Height)

            End If

        ElseIf Digit_5_7.Visible = True And Digit_5_8.Visible = True Then
            If Digit_5_7.Location.Y > Digit_Panel_5.Height Then
                If Digit_5_stop = True Then
                    tmr_digit_display_5.Enabled = True
                End If
                Digit_5_1.Visible = False
                Digit_5_2.Visible = False
                Digit_5_3.Visible = False
                Digit_5_4.Visible = False
                Digit_5_5.Visible = False
                Digit_5_6.Visible = False
                Digit_5_7.Visible = False
                Digit_5_8.Visible = True
                Digit_5_9.Visible = True

                Digit_5_8.Location = New Point(0, 0)
                Digit_5_9.Location = New Point(0, Digit_5_8.Location.Y - Digit_5_9.Height)

            Else
                Digit_5_7.Location = New Point(0, Digit_5_7.Location.Y + Scroll_Speed_5)
                Digit_5_8.Location = New Point(0, Digit_5_7.Location.Y - Digit_5_7.Height)

            End If

        ElseIf Digit_5_8.Visible = True And Digit_5_9.Visible = True Then
            If Digit_5_8.Location.Y > Digit_Panel_5.Height Then
                If Digit_5_stop = True Then
                    tmr_digit_display_5.Enabled = True
                End If
                Digit_5_1.Visible = True
                Digit_5_2.Visible = False
                Digit_5_3.Visible = False
                Digit_5_4.Visible = False
                Digit_5_5.Visible = False
                Digit_5_6.Visible = False
                Digit_5_7.Visible = False
                Digit_5_8.Visible = False
                Digit_5_9.Visible = True

                Digit_5_9.Location = New Point(0, 0)
                Digit_5_1.Location = New Point(0, Digit_5_9.Location.Y - Digit_5_1.Height)

            Else
                Digit_5_8.Location = New Point(0, Digit_5_8.Location.Y + Scroll_Speed_5)
                Digit_5_9.Location = New Point(0, Digit_5_8.Location.Y - Digit_5_8.Height)

            End If

        ElseIf Digit_5_9.Visible = True And Digit_5_1.Visible = True Then
            If Digit_5_9.Location.Y > Digit_Panel_5.Height Then
                If Digit_5_stop = True Then
                    tmr_digit_display_5.Enabled = True
                End If
                Digit_5_1.Visible = True
                Digit_5_2.Visible = True
                Digit_5_3.Visible = False
                Digit_5_4.Visible = False
                Digit_5_5.Visible = False
                Digit_5_6.Visible = False
                Digit_5_7.Visible = False
                Digit_5_8.Visible = False
                Digit_5_9.Visible = False

                Digit_5_1.Location = New Point(0, 0)
                Digit_5_2.Location = New Point(0, Digit_5_1.Location.Y - Digit_5_2.Height)

            Else
                Digit_5_9.Location = New Point(0, Digit_5_9.Location.Y + Scroll_Speed_5)
                Digit_5_1.Location = New Point(0, Digit_5_9.Location.Y - Digit_5_9.Height)

            End If

        End If
    End Sub

    Private Sub tmr_Animator_Digit_6_Tick(sender As Object, e As EventArgs) Handles tmr_Animator_Digit_6.Tick
        If Digit_6_1.Visible = True And Digit_6_2.Visible = True Then
            If Digit_6_1.Location.Y > Digit_Panel_6.Height Then
                If Digit_6_stop = True Then
                    tmr_digit_display_6.Enabled = True
                End If
                Digit_6_1.Visible = False
                Digit_6_2.Visible = True
                Digit_6_3.Visible = True
                Digit_6_4.Visible = False
                Digit_6_5.Visible = False
                Digit_6_6.Visible = False
                Digit_6_7.Visible = False
                Digit_6_8.Visible = False
                Digit_6_9.Visible = False

                Digit_6_2.Location = New Point(0, 0)
                Digit_6_3.Location = New Point(0, Digit_6_2.Location.Y - Digit_6_3.Height)

            Else
                Digit_6_1.Location = New Point(0, Digit_6_1.Location.Y + Scroll_Speed_6)
                Digit_6_2.Location = New Point(0, Digit_6_1.Location.Y - Digit_6_1.Height)

            End If


        ElseIf Digit_6_2.Visible = True And Digit_6_3.Visible = True Then
            If Digit_6_2.Location.Y > Digit_Panel_6.Height Then
                If Digit_6_stop = True Then
                    tmr_digit_display_6.Enabled = True
                End If
                Digit_6_1.Visible = False
                Digit_6_2.Visible = False
                Digit_6_3.Visible = True
                Digit_6_4.Visible = True
                Digit_6_5.Visible = False
                Digit_6_6.Visible = False
                Digit_6_7.Visible = False
                Digit_6_8.Visible = False
                Digit_6_9.Visible = False

                Digit_6_3.Location = New Point(0, 0)
                Digit_6_4.Location = New Point(0, Digit_6_3.Location.Y - Digit_6_4.Height)

            Else
                Digit_6_2.Location = New Point(0, Digit_6_2.Location.Y + Scroll_Speed_6)
                Digit_6_3.Location = New Point(0, Digit_6_2.Location.Y - Digit_6_2.Height)

            End If

        ElseIf Digit_6_3.Visible = True And Digit_6_4.Visible = True Then
            If Digit_6_3.Location.Y > Digit_Panel_6.Height Then
                If Digit_6_stop = True Then
                    tmr_digit_display_6.Enabled = True
                End If
                Digit_6_1.Visible = False
                Digit_6_2.Visible = False
                Digit_6_3.Visible = False
                Digit_6_4.Visible = True
                Digit_6_5.Visible = True
                Digit_6_6.Visible = False
                Digit_6_7.Visible = False
                Digit_6_8.Visible = False
                Digit_6_9.Visible = False

                Digit_6_4.Location = New Point(0, 0)
                Digit_6_5.Location = New Point(0, Digit_6_4.Location.Y - Digit_6_5.Height)

            Else
                Digit_6_3.Location = New Point(0, Digit_6_3.Location.Y + Scroll_Speed_6)
                Digit_6_4.Location = New Point(0, Digit_6_3.Location.Y - Digit_6_3.Height)

            End If

        ElseIf Digit_6_4.Visible = True And Digit_6_5.Visible = True Then
            If Digit_6_4.Location.Y > Digit_Panel_6.Height Then
                If Digit_6_stop = True Then
                    tmr_digit_display_6.Enabled = True
                End If
                Digit_6_1.Visible = False
                Digit_6_2.Visible = False
                Digit_6_3.Visible = False
                Digit_6_4.Visible = False
                Digit_6_5.Visible = True
                Digit_6_6.Visible = True
                Digit_6_7.Visible = False
                Digit_6_8.Visible = False
                Digit_6_9.Visible = False

                Digit_6_5.Location = New Point(0, 0)
                Digit_6_6.Location = New Point(0, Digit_6_5.Location.Y - Digit_6_6.Height)

            Else
                Digit_6_4.Location = New Point(0, Digit_6_4.Location.Y + Scroll_Speed_6)
                Digit_6_5.Location = New Point(0, Digit_6_4.Location.Y - Digit_6_4.Height)

            End If

        ElseIf Digit_6_5.Visible = True And Digit_6_6.Visible = True Then
            If Digit_6_5.Location.Y > Digit_Panel_6.Height Then
                If Digit_6_stop = True Then
                    tmr_digit_display_6.Enabled = True
                End If
                Digit_6_1.Visible = False
                Digit_6_2.Visible = False
                Digit_6_3.Visible = False
                Digit_6_4.Visible = False
                Digit_6_5.Visible = False
                Digit_6_6.Visible = True
                Digit_6_7.Visible = True
                Digit_6_8.Visible = False
                Digit_6_9.Visible = False

                Digit_6_6.Location = New Point(0, 0)
                Digit_6_7.Location = New Point(0, Digit_6_6.Location.Y - Digit_6_7.Height)

            Else
                Digit_6_5.Location = New Point(0, Digit_6_5.Location.Y + Scroll_Speed_6)
                Digit_6_6.Location = New Point(0, Digit_6_5.Location.Y - Digit_6_5.Height)

            End If

        ElseIf Digit_6_6.Visible = True And Digit_6_7.Visible = True Then
            If Digit_6_6.Location.Y > Digit_Panel_6.Height Then
                If Digit_6_stop = True Then
                    tmr_digit_display_6.Enabled = True
                End If
                Digit_6_1.Visible = False
                Digit_6_2.Visible = False
                Digit_6_3.Visible = False
                Digit_6_4.Visible = False
                Digit_6_5.Visible = False
                Digit_6_6.Visible = False
                Digit_6_7.Visible = True
                Digit_6_8.Visible = True
                Digit_6_9.Visible = False

                Digit_6_7.Location = New Point(0, 0)
                Digit_6_8.Location = New Point(0, Digit_6_7.Location.Y - Digit_6_8.Height)

            Else
                Digit_6_6.Location = New Point(0, Digit_6_6.Location.Y + Scroll_Speed_6)
                Digit_6_7.Location = New Point(0, Digit_6_6.Location.Y - Digit_6_6.Height)

            End If

        ElseIf Digit_6_7.Visible = True And Digit_6_8.Visible = True Then
            If Digit_6_7.Location.Y > Digit_Panel_6.Height Then
                If Digit_6_stop = True Then
                    tmr_digit_display_6.Enabled = True
                End If
                Digit_6_1.Visible = False
                Digit_6_2.Visible = False
                Digit_6_3.Visible = False
                Digit_6_4.Visible = False
                Digit_6_5.Visible = False
                Digit_6_6.Visible = False
                Digit_6_7.Visible = False
                Digit_6_8.Visible = True
                Digit_6_9.Visible = True

                Digit_6_8.Location = New Point(0, 0)
                Digit_6_9.Location = New Point(0, Digit_6_8.Location.Y - Digit_6_9.Height)

            Else
                Digit_6_7.Location = New Point(0, Digit_6_7.Location.Y + Scroll_Speed_6)
                Digit_6_8.Location = New Point(0, Digit_6_7.Location.Y - Digit_6_7.Height)

            End If

        ElseIf Digit_6_8.Visible = True And Digit_6_9.Visible = True Then
            If Digit_6_8.Location.Y > Digit_Panel_6.Height Then
                If Digit_6_stop = True Then
                    tmr_digit_display_6.Enabled = True
                End If
                Digit_6_1.Visible = True
                Digit_6_2.Visible = False
                Digit_6_3.Visible = False
                Digit_6_4.Visible = False
                Digit_6_5.Visible = False
                Digit_6_6.Visible = False
                Digit_6_7.Visible = False
                Digit_6_8.Visible = False
                Digit_6_9.Visible = True

                Digit_6_9.Location = New Point(0, 0)
                Digit_6_1.Location = New Point(0, Digit_6_9.Location.Y - Digit_6_1.Height)

            Else
                Digit_6_8.Location = New Point(0, Digit_6_8.Location.Y + Scroll_Speed_6)
                Digit_6_9.Location = New Point(0, Digit_6_8.Location.Y - Digit_6_8.Height)

            End If

        ElseIf Digit_6_9.Visible = True And Digit_6_1.Visible = True Then
            If Digit_6_9.Location.Y > Digit_Panel_6.Height Then
                If Digit_6_stop = True Then
                    tmr_digit_display_6.Enabled = True
                End If
                Digit_6_1.Visible = True
                Digit_6_2.Visible = True
                Digit_6_3.Visible = False
                Digit_6_4.Visible = False
                Digit_6_5.Visible = False
                Digit_6_6.Visible = False
                Digit_6_7.Visible = False
                Digit_6_8.Visible = False
                Digit_6_9.Visible = False

                Digit_6_1.Location = New Point(0, 0)
                Digit_6_2.Location = New Point(0, Digit_6_1.Location.Y - Digit_6_2.Height)

            Else
                Digit_6_9.Location = New Point(0, Digit_6_9.Location.Y + Scroll_Speed_6)
                Digit_6_1.Location = New Point(0, Digit_6_9.Location.Y - Digit_6_9.Height)

            End If

        End If

    End Sub

    Private Sub tmr_digit_display_1_Tick(sender As Object, e As EventArgs) Handles tmr_digit_display_1.Tick
        Digit_1_1.SendToBack()
        Digit_1_2.SendToBack()
        Digit_1_3.SendToBack()
        Digit_1_4.SendToBack()
        Digit_1_5.SendToBack()
        Digit_1_6.SendToBack()
        Digit_1_7.SendToBack()
        Digit_1_8.SendToBack()
        Digit_1_9.SendToBack()

        If Digit_1_10_Panel.Location.Y > 0 Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\ShowNum.wav")
            tmr_Animator_Digit_1.Enabled = False
            tmr_digit_display_1.Enabled = False
            Digit_1_10_Panel.Location = New Point(0, 0)
            Digit_1_stop2 = True
            If Digit_1_stop2 = True And Digit_2_stop2 = True And Digit_3_stop2 = True And Digit_4_stop2 = True And Digit_5_stop2 = True And Digit_6_stop2 = True Then

                safe_data()

            End If

        Else
            Digit_1_10_Panel.Location = New Point(0, Digit_1_10_Panel.Location.Y + Scroll_Speed_1)
        End If

    End Sub

    Private Sub tmr_digit_display_2_Tick(sender As Object, e As EventArgs) Handles tmr_digit_display_2.Tick
        Digit_2_1.SendToBack()
        Digit_2_2.SendToBack()
        Digit_2_3.SendToBack()
        Digit_2_4.SendToBack()
        Digit_2_5.SendToBack()
        Digit_2_6.SendToBack()
        Digit_2_7.SendToBack()
        Digit_2_8.SendToBack()
        Digit_2_9.SendToBack()

        If Digit_2_10_Panel.Location.Y > 0 Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\ShowNum.wav")
            tmr_Animator_Digit_2.Enabled = False
            tmr_digit_display_2.Enabled = False
            Digit_2_10_Panel.Location = New Point(0, 0)
            Digit_2_stop2 = True
            If Digit_1_stop2 = True And Digit_2_stop2 = True And Digit_3_stop2 = True And Digit_4_stop2 = True And Digit_5_stop2 = True And Digit_6_stop2 = True Then

                safe_data()

            End If
        Else
            Digit_2_10_Panel.Location = New Point(0, Digit_2_10_Panel.Location.Y + Scroll_Speed_2)
        End If
    End Sub

    Private Sub tmr_digit_display_3_Tick(sender As Object, e As EventArgs) Handles tmr_digit_display_3.Tick
        Digit_3_1.SendToBack()
        Digit_3_2.SendToBack()
        Digit_3_3.SendToBack()
        Digit_3_4.SendToBack()
        Digit_3_5.SendToBack()
        Digit_3_6.SendToBack()
        Digit_3_7.SendToBack()
        Digit_3_8.SendToBack()
        Digit_3_9.SendToBack()

        If Digit_3_10_Panel.Location.Y > 0 Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\ShowNum.wav")
            tmr_Animator_Digit_3.Enabled = False
            tmr_digit_display_3.Enabled = False
            Digit_3_10_Panel.Location = New Point(0, 0)
            Digit_3_stop2 = True
            If Digit_1_stop2 = True And Digit_2_stop2 = True And Digit_3_stop2 = True And Digit_4_stop2 = True And Digit_5_stop2 = True And Digit_6_stop2 = True Then

                safe_data()

            End If
        Else
            Digit_3_10_Panel.Location = New Point(0, Digit_3_10_Panel.Location.Y + Scroll_Speed_3)
        End If
    End Sub

    Private Sub tmr_digit_display_4_Tick(sender As Object, e As EventArgs) Handles tmr_digit_display_4.Tick
        Digit_4_1.SendToBack()
        Digit_4_2.SendToBack()
        Digit_4_3.SendToBack()
        Digit_4_4.SendToBack()
        Digit_4_5.SendToBack()
        Digit_4_6.SendToBack()
        Digit_4_7.SendToBack()
        Digit_4_8.SendToBack()
        Digit_4_9.SendToBack()

        If Digit_4_10_Panel.Location.Y > 0 Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\ShowNum.wav")
            tmr_Animator_Digit_4.Enabled = False
            tmr_digit_display_4.Enabled = False
            Digit_4_10_Panel.Location = New Point(0, 0)
            Digit_4_stop2 = True
            If Digit_1_stop2 = True And Digit_2_stop2 = True And Digit_3_stop2 = True And Digit_4_stop2 = True And Digit_5_stop2 = True And Digit_6_stop2 = True Then

                safe_data()

            End If
        Else
            Digit_4_10_Panel.Location = New Point(0, Digit_4_10_Panel.Location.Y + Scroll_Speed_4)
        End If
    End Sub

    Private Sub tmr_digit_display_5_Tick(sender As Object, e As EventArgs) Handles tmr_digit_display_5.Tick
        Digit_5_1.SendToBack()
        Digit_5_2.SendToBack()
        Digit_5_3.SendToBack()
        Digit_5_4.SendToBack()
        Digit_5_5.SendToBack()
        Digit_5_6.SendToBack()
        Digit_5_7.SendToBack()
        Digit_5_8.SendToBack()
        Digit_5_9.SendToBack()

        If Digit_5_10_Panel.Location.Y > 0 Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\ShowNum.wav")
            tmr_Animator_Digit_5.Enabled = False
            tmr_digit_display_5.Enabled = False
            Digit_5_10_Panel.Location = New Point(0, 0)
            Digit_5_stop2 = True
            If Digit_1_stop2 = True And Digit_2_stop2 = True And Digit_3_stop2 = True And Digit_4_stop2 = True And Digit_5_stop2 = True And Digit_6_stop2 = True Then

                safe_data()

            End If
        Else
            Digit_5_10_Panel.Location = New Point(0, Digit_5_10_Panel.Location.Y + Scroll_Speed_5)
        End If
    End Sub

    Private Sub tmr_digit_display_6_Tick(sender As Object, e As EventArgs) Handles tmr_digit_display_6.Tick
        Digit_6_1.SendToBack()
        Digit_6_2.SendToBack()
        Digit_6_3.SendToBack()
        Digit_6_4.SendToBack()
        Digit_6_5.SendToBack()
        Digit_6_6.SendToBack()
        Digit_6_7.SendToBack()
        Digit_6_8.SendToBack()
        Digit_6_9.SendToBack()

        If Digit_6_10_Panel.Location.Y > 0 Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\ShowNum.wav")
            tmr_Animator_Digit_6.Enabled = False
            tmr_digit_display_6.Enabled = False
            Digit_6_10_Panel.Location = New Point(0, 0)
            Digit_6_stop2 = True
            If Digit_1_stop2 = True And Digit_2_stop2 = True And Digit_3_stop2 = True And Digit_4_stop2 = True And Digit_5_stop2 = True And Digit_6_stop2 = True Then

                safe_data()

            End If
        Else
            Digit_6_10_Panel.Location = New Point(0, Digit_6_10_Panel.Location.Y + Scroll_Speed_6)
        End If
    End Sub

    Sub safe_data()
        FRM_CTR_PANEL.Start_Raffle_btn.Enabled = True
        Digit_1_stop = False
        Digit_2_stop = False
        Digit_3_stop = False
        Digit_4_stop = False
        Digit_5_stop = False
        Digit_6_stop = False
        Digit_1_stop2 = False
        Digit_2_stop2 = False
        Digit_3_stop2 = False
        Digit_4_stop2 = False
        Digit_5_stop2 = False
        Digit_6_stop2 = False
        Side_Panel_Title_Label.Visible = True
        'Disp_Msg2(vbNewLine + FRM_CTR_PANEL.curr_winner_disp.ToString + "). " + Bil_Acct_Name_Array_win(FRM_CTR_PANEL.curr_winner_disp - 1).ToString)
        FRM_CTR_PANEL.Save_Winner_BW_DoWork()
    End Sub

    Private Sub Tmr_start_anim_Tick(sender As Object, e As EventArgs) Handles Tmr_start_anim.Tick

        If anim_Steps = 0 Then
            tmr_Animator_Digit_1.Enabled = True
        ElseIf anim_Steps = 1 Then
            tmr_Animator_Digit_2.Enabled = True
        ElseIf anim_Steps = 2 Then
            tmr_Animator_Digit_3.Enabled = True
        ElseIf anim_Steps = 3 Then
            tmr_Animator_Digit_4.Enabled = True
        ElseIf anim_Steps = 4 Then
            tmr_Animator_Digit_5.Enabled = True
        ElseIf anim_Steps = 5 Then
            tmr_Animator_Digit_6.Enabled = True
        Else
            Tmr_start_anim.Enabled = False
        End If
        anim_Steps += 1
    End Sub

    Private Sub Tmr_Side_Panel_Open_Tick(sender As Object, e As EventArgs) Handles Tmr_Side_Panel_Open.Tick

        If Side_Panel.Location.X > 0 Then
            Tmr_Side_Panel_Open.Enabled = False
            Side_Panel.Location = New Point(0, 0)
            FRM_CTR_PANEL.Side_Panel_Btn.Enabled = True
        Else
            Side_Panel.Location = New Point(Side_Panel.Location.X + 100, 0)
        End If
    End Sub

    Private Sub Tmr_Side_Panel_Close_Tick(sender As Object, e As EventArgs) Handles Tmr_Side_Panel_Close.Tick
        If Side_Panel.Location.X < 0 - Side_Panel.Width Then
            Tmr_Side_Panel_Close.Enabled = False
            Side_Panel.Location = New Point(0 - Side_Panel.Width, 0)
            Side_Panel.Visible = True
            FRM_CTR_PANEL.Side_Panel_Btn.Enabled = True
            Digit_Panel_1.Visible = True
            Digit_Panel_2.Visible = True
            Digit_Panel_3.Visible = True
            Digit_Panel_4.Visible = True
            Digit_Panel_5.Visible = True
            Digit_Panel_6.Visible = True
        Else
            Side_Panel.Location = New Point(Side_Panel.Location.X - 100, 0)
            Digit_Panel_1.Visible = False
            Digit_Panel_2.Visible = False
            Digit_Panel_3.Visible = False
            Digit_Panel_4.Visible = False
            Digit_Panel_5.Visible = False
            Digit_Panel_6.Visible = False

        End If
    End Sub

    Public Sub Clear_Side_Panel()
        GunaLabel1.Visible = False
        GunaLabel2.Visible = False
        GunaLabel3.Visible = False
        GunaLabel4.Visible = False
        GunaLabel5.Visible = False
        GunaLabel6.Visible = False
        GunaLabel6.Visible = False
        GunaLabel7.Visible = False
        GunaLabel8.Visible = False
        GunaLabel9.Visible = False
        GunaLabel10.Visible = False
        GunaLabel11.Visible = False
        GunaLabel12.Visible = False
        GunaLabel13.Visible = False
        GunaLabel14.Visible = False
        GunaLabel15.Visible = False
        GunaLabel16.Visible = False
        GunaLabel17.Visible = False
        GunaLabel18.Visible = False
        GunaLabel19.Visible = False
        GunaLabel20.Visible = False

    End Sub

    Private Sub Tmr_Blink_effect_Tick(sender As Object, e As EventArgs) Handles Tmr_Blink_effect.Tick
        If Blick_effect = False Then
            Price_LBL.Visible = True
            Blick_effect = True
        Else
            Price_LBL.Visible = False
            Blick_effect = False
        End If
    End Sub
End Class