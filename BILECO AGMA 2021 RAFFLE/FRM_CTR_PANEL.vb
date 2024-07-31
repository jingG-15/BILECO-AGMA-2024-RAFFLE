Imports MySql.Data.MySqlClient
Imports System
Imports System.IO.Ports
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Net
Imports System.Text.Encoding
Imports System.ComponentModel

Public Class FRM_CTR_PANEL
    Dim show_fl As Boolean = False
    Dim side_notif_open As Boolean = False
    Dim Ran_Stop_array As New ArrayList()
    Dim ran_index As Integer = 0
    Dim show_con_press As Boolean = False
    Delegate Sub SetRchText(ByVal txt As String)
    Dim town As String
    Dim tdy As String

    Dim side_panel_flag As Boolean = False
    Public curr_winner_disp As Integer = 0
    Dim Update_BW As Boolean = False
    Dim error_message As String
    Dim Price_Type_temp As String
    Dim Wipe_FL As Boolean = False

    Dim Side_Pan_Batch As String
    Dim Side_Display As String
    Dim side_Pan_load_FL As Boolean = False
    Dim side_count As Integer = 0
    Dim FeaturePrize2 As String = ""
    Dim Blink As Boolean = False
    Dim Winners_counter As Integer = 0
    Dim Music_Stop_start As Boolean = False

    Dim prize_type_for_saving As New ArrayList()
    Dim batch_no_for_saving As New ArrayList()
    Dim featured_prize_for_saving As New ArrayList()

    Dim ID_Array_win_for_saving As New ArrayList()
    Dim Bil_Num_Array_win_for_saving As New ArrayList()
    Dim Bil_Acct_Name_Array_win_for_saving As New ArrayList()
    Dim Bil_Add_Array_win_for_saving As New ArrayList()
    Dim Stub_Array_win_for_saving As New ArrayList()
    Dim Town_Array_win_for_saving As New ArrayList()



    Private Sub Show_Display_Btn_Click(sender As Object, e As EventArgs) Handles Show_Display_Btn.Click
        If show_fl = False Then
            If ToggleFullScreen_sw.Checked = True Then
                FRM_DISPLAY_UI.WindowState = FormWindowState.Maximized
            Else
                FRM_DISPLAY_UI.WindowState = FormWindowState.Normal
            End If
            show_fl = True
            FRM_DISPLAY_UI.Show()
        Else
            FRM_DISPLAY_UI.Hide()
            show_fl = False
        End If
    End Sub

    Private Sub ToggleFullScreen_sw_CheckedChanged(sender As Object, e As EventArgs) Handles ToggleFullScreen_sw.CheckedChanged
        If ToggleFullScreen_sw.Checked = True Then
            FRM_DISPLAY_UI.WindowState = FormWindowState.Maximized
        Else
            FRM_DISPLAY_UI.WindowState = FormWindowState.Normal
        End If
    End Sub

    ' Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
    '(ByVal lpstrCommand As String, ByVal lpstrReturnString As String,
    'ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private Sub Guna2TrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Speed_Digit_All.Scroll
        Speed_Digit_1.Value = Speed_Digit_All.Value
        Speed_Digit_2.Value = Speed_Digit_All.Value
        Speed_Digit_3.Value = Speed_Digit_All.Value
        Speed_Digit_4.Value = Speed_Digit_All.Value
        Speed_Digit_5.Value = Speed_Digit_All.Value
        Speed_Digit_6.Value = Speed_Digit_All.Value

        FRM_DISPLAY_UI.Scroll_Speed_1 = Speed_Digit_All.Value
        FRM_DISPLAY_UI.Scroll_Speed_2 = Speed_Digit_All.Value
        FRM_DISPLAY_UI.Scroll_Speed_3 = Speed_Digit_All.Value
        FRM_DISPLAY_UI.Scroll_Speed_4 = Speed_Digit_All.Value
        FRM_DISPLAY_UI.Scroll_Speed_5 = Speed_Digit_All.Value
        FRM_DISPLAY_UI.Scroll_Speed_6 = Speed_Digit_All.Value

    End Sub

    Private Sub Start_Raffle_btn_Click(sender As Object, e As EventArgs) Handles Start_Raffle_btn.Click
        Dim asasas As String
        Ran_Stop_array.Clear()
        tmr_Random_Stop.Enabled = False
        ran_index = 0
        Cancel_Btn.Enabled = True
        Music_Stop_start = False
        'mciSendString("seek myWAV to start", Nothing, 0, IntPtr.Zero)
        'mciSendString("play myWAV", Nothing, 0, 0)
        If Winners_counter > 1 Then

            FRM_DISPLAY_UI.Price_LBL.Text = Winners_counter.ToString + " WINNERS OF " + vbNewLine + FeaturePrize
        Else

            FRM_DISPLAY_UI.Price_LBL.Text = Winners_counter.ToString + " WINNER OF " + vbNewLine + FeaturePrize
        End If
        If curr_winner_disp < ID_Array_win.Count Then
            curr_winner_disp = curr_winner_disp + 1
            Batch_win_count_LBL.Text = "Batch Winner Count : " + curr_winner_disp.ToString
            asasas = ID_Array_win(curr_winner_disp - 1).ToString
            Price_Type_temp = Price_Type_ComboBox.SelectedItem.ToString
            Start_Raffle_btn.Enabled = False
            Random_Speed_num.Enabled = True
            Next_Raffle_Btn.Enabled = False
            Digit_btn_1.Enabled = True
            Digit_btn_2.Enabled = True
            Digit_btn_3.Enabled = True
            Digit_btn_4.Enabled = True
            Digit_btn_5.Enabled = True
            Digit_btn_6.Enabled = True
            Random_Digit_stop_Btn.Enabled = True
            FRM_DISPLAY_UI.Digit_1_10_Lbl.Text = Stub_Array_win(curr_winner_disp - 1).Substring(0, 1)
            FRM_DISPLAY_UI.Digit_2_10_Lbl.Text = Stub_Array_win(curr_winner_disp - 1).Substring(1, 1)
            FRM_DISPLAY_UI.Digit_3_10_Lbl.Text = Stub_Array_win(curr_winner_disp - 1).Substring(2, 1)
            FRM_DISPLAY_UI.Digit_4_10_Lbl.Text = Stub_Array_win(curr_winner_disp - 1).Substring(3, 1)
            FRM_DISPLAY_UI.Digit_5_10_Lbl.Text = Stub_Array_win(curr_winner_disp - 1).Substring(4, 1)
            FRM_DISPLAY_UI.Digit_6_10_Lbl.Text = Stub_Array_win(curr_winner_disp - 1).Substring(5, 1)
            FRM_DISPLAY_UI.Side_Panel_Title_Label.Visible = False
            FRM_DISPLAY_UI.Side_Panel_Title_Label.ForeColor = Drawing.Color.FromArgb(87, 10, 14)

            FRM_DISPLAY_UI.Side_Panel_Title_Label.Text = Bil_Acct_Name_Array_win(curr_winner_disp - 1) + vbNewLine + Bil_Add_Array_win(curr_winner_disp - 1)
            FRM_DISPLAY_UI.Side_Panel_Title_Label.TextAlign = ContentAlignment.TopCenter
            FRM_DISPLAY_UI.Side_Panel_Title_Label.Size = New Size((FRM_DISPLAY_UI.Main_Panel.Width / 4) * 2, FRM_DISPLAY_UI.Main_Panel.Height / 4)
            FRM_DISPLAY_UI.Side_Panel_Title_Label.Font = New Font("Bebas Neue", FRM_DISPLAY_UI.Digit_Panel_1.Width / 2.5)

            FRM_DISPLAY_UI.Side_Panel_Title_Label.Location = New Point((FRM_DISPLAY_UI.Main_Panel.Width / 2) - (FRM_DISPLAY_UI.Side_Panel_Title_Label.Width / 2), (FRM_DISPLAY_UI.Main_Panel.Height / 3) * 2)
            FRM_DISPLAY_UI.start_draw()
        End If


    End Sub

    Private Sub Random_Digit_stop_Btn_Click(sender As Object, e As EventArgs) Handles Random_Digit_stop_Btn.Click
        Dim rand As New Random()
        Dim idx As Integer
        Ran_Stop_array.Clear()
        ran_index = 0
        idx = rand.Next(1, 7)
        Ran_Stop_array.Add(idx)
        Digit_btn_1.Enabled = False
        Digit_btn_2.Enabled = False
        Digit_btn_3.Enabled = False
        Digit_btn_4.Enabled = False
        Digit_btn_5.Enabled = False
        Digit_btn_6.Enabled = False
        For z = 0 To 4 Step 1
            Do
                idx = rand.Next(1, 7)
                If Not Ran_Stop_array.Contains(idx) Then
                    Ran_Stop_array.Add(idx)
                    Exit Do
                End If
            Loop
        Next
        tmr_Random_Stop.Enabled = True
        Random_Digit_stop_Btn.Enabled = False
    End Sub

    Private Sub FRM_CTR_PANEL_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FRM_DISPLAY_UI.Close()
    End Sub

    Private Sub FRM_CTR_PANEL_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Oemtilde Then
            If Start_Raffle_btn.Enabled = True Then
                Start_Raffle_btn.PerformClick()
            End If
        ElseIf e.KeyCode = Keys.D1 Then
            If Digit_btn_1.Enabled = True Then
                Digit_btn_1.PerformClick()
            End If
        ElseIf e.KeyCode = Keys.D2 Then
            If Digit_btn_2.Enabled = True Then
                Digit_btn_2.PerformClick()
            End If
        ElseIf e.KeyCode = Keys.D3 Then
            If Digit_btn_3.Enabled = True Then
                Digit_btn_3.PerformClick()
            End If
        ElseIf e.KeyCode = Keys.D4 Then
            If Digit_btn_4.Enabled = True Then
                Digit_btn_4.PerformClick()
            End If
        ElseIf e.KeyCode = Keys.D5 Then
            If Digit_btn_5.Enabled = True Then
                Digit_btn_5.PerformClick()
            End If
        ElseIf e.KeyCode = Keys.D6 Then
            If Digit_btn_6.Enabled = True Then
                Digit_btn_6.PerformClick()
            End If
        End If
    End Sub

    Private Sub FRM_CTR_PANEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(645, 707)
        FRM_DISPLAY_UI.Tmr_Blink_effect.Interval = Blink_Speed_num.Value * 100
        Side_Load()
        'Try
        '    mciSendString("close myWAV", Nothing, 0, 0)

        '    Dim fileName1 As String = My.Application.Info.DirectoryPath + "\skiri2.wav"
        '    mciSendString("open " & ChrW(34) & fileName1 & ChrW(34) & " type mpegvideo alias myWAV", Nothing, 0, 0)


        '    Dim Volume As Integer = 1000 ' Sets it to use entire range of volume control
        '    mciSendString("setaudio myWAV volume to " & Volume.ToString, Nothing, 0, 0)

        'Catch ex As Exception
        '    Me.Text = ex.Message
        'End Try

        rch_Stat.ForeColor = Color.YellowGreen
        rch_Stat.BackColor = Color.Black



    End Sub

    Private Sub Side_Load()
        Side_Pan_Dis_CB.Items.Clear()

        Dim n As Integer = 0
        Dim rprt As Integer = 0
        Dim MysqlConn As MySqlConnection
        Dim cmd As New MySqlCommand
        Dim sql As String
        Dim drSQL As MySqlDataReader
        Dim B_Count As Integer = 0
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + IPServer + "; userid=" + Username + "; password=" + Passwd + "; database= " + db_name
        Try

            MysqlConn.Open()

            sql = "SELECT DISTINCT Batch_no FROM winners_tbl "
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True
                Side_Pan_Dis_CB.Items.Add(drSQL("Batch_no").ToString)
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
        End Try
        'Side_Pan_Dis_CB.SelectedIndex = 0
        Winners_counter -= 1
    End Sub

    Private Sub Next_Raffle_Btn_Click(sender As Object, e As EventArgs) Handles Next_Raffle_Btn.Click
        FRM_DISPLAY_UI.tmr_Animator_Digit_1.Enabled = False
        FRM_DISPLAY_UI.tmr_Animator_Digit_2.Enabled = False
        FRM_DISPLAY_UI.tmr_Animator_Digit_3.Enabled = False
        FRM_DISPLAY_UI.tmr_Animator_Digit_4.Enabled = False
        FRM_DISPLAY_UI.tmr_Animator_Digit_5.Enabled = False
        FRM_DISPLAY_UI.tmr_Animator_Digit_6.Enabled = False
        FRM_DISPLAY_UI.set_draw()
        Speed_Digit_1.Value = 30
        Speed_Digit_2.Value = 30
        Speed_Digit_3.Value = 30
        Speed_Digit_4.Value = 30
        Speed_Digit_5.Value = 30
        Speed_Digit_6.Value = 30
        Speed_Digit_All.Value = 30
        FRM_DISPLAY_UI.Digit_1_stop = False
        FRM_DISPLAY_UI.Digit_2_stop = False
        FRM_DISPLAY_UI.Digit_3_stop = False
        FRM_DISPLAY_UI.Digit_4_stop = False
        FRM_DISPLAY_UI.Digit_5_stop = False
        FRM_DISPLAY_UI.Digit_6_stop = False
        Digit_btn_1.Enabled = True
        Digit_btn_2.Enabled = True
        Digit_btn_3.Enabled = True
        Digit_btn_4.Enabled = True
        Digit_btn_5.Enabled = True
        Digit_btn_6.Enabled = True
        FRM_DISPLAY_UI.Side_Panel_Title_Label.Visible = False
        FRM_DISPLAY_UI.Price_LBL_Trans2.HideSync(FRM_DISPLAY_UI.Price_LBL)
    End Sub

    Private Sub Speed_Digit_1_Scroll(sender As Object, e As ScrollEventArgs) Handles Speed_Digit_1.Scroll
        FRM_DISPLAY_UI.Scroll_Speed_1 = Speed_Digit_1.Value
    End Sub

    Private Sub Speed_Digit_2_Scroll(sender As Object, e As ScrollEventArgs) Handles Speed_Digit_2.Scroll
        FRM_DISPLAY_UI.Scroll_Speed_2 = Speed_Digit_2.Value
    End Sub

    Private Sub Speed_Digit_3_Scroll(sender As Object, e As ScrollEventArgs) Handles Speed_Digit_3.Scroll
        FRM_DISPLAY_UI.Scroll_Speed_3 = Speed_Digit_3.Value
    End Sub

    Private Sub Speed_Digit_4_Scroll(sender As Object, e As ScrollEventArgs) Handles Speed_Digit_4.Scroll
        FRM_DISPLAY_UI.Scroll_Speed_4 = Speed_Digit_4.Value
    End Sub

    Private Sub Speed_Digit_5_Scroll(sender As Object, e As ScrollEventArgs) Handles Speed_Digit_5.Scroll
        FRM_DISPLAY_UI.Scroll_Speed_5 = Speed_Digit_5.Value
    End Sub

    Private Sub Speed_Digit_6_Scroll(sender As Object, e As ScrollEventArgs) Handles Speed_Digit_6.Scroll
        FRM_DISPLAY_UI.Scroll_Speed_6 = Speed_Digit_6.Value
    End Sub

    Private Sub winner_list_btn_Click(sender As Object, e As EventArgs) Handles winner_list_btn.Click

        If side_notif_open = False Then
            Side_notif_tmr_open.Enabled = True
            side_notif_open = True
        Else
            Side_notif_tmr_close.Enabled = True
            side_notif_open = False
        End If

    End Sub

    Private Sub Digit_btn_1_Click_1(sender As Object, e As EventArgs) Handles Digit_btn_1.Click
        Random_Digit_stop_Btn.Enabled = False
        FRM_DISPLAY_UI.Digit_1_stop = True
        Digit_btn_1.Enabled = False
    End Sub

    Private Sub Digit_btn_2_Click(sender As Object, e As EventArgs) Handles Digit_btn_2.Click
        Random_Digit_stop_Btn.Enabled = False
        FRM_DISPLAY_UI.Digit_2_stop = True
        Digit_btn_2.Enabled = False
    End Sub

    Private Sub Digit_btn_3_Click(sender As Object, e As EventArgs) Handles Digit_btn_3.Click
        Random_Digit_stop_Btn.Enabled = False
        FRM_DISPLAY_UI.Digit_3_stop = True
        Digit_btn_3.Enabled = False
    End Sub

    Private Sub Digit_btn_4_Click(sender As Object, e As EventArgs) Handles Digit_btn_4.Click
        Random_Digit_stop_Btn.Enabled = False
        FRM_DISPLAY_UI.Digit_4_stop = True
        Digit_btn_4.Enabled = False
    End Sub

    Private Sub Digit_btn_5_Click(sender As Object, e As EventArgs) Handles Digit_btn_5.Click
        Random_Digit_stop_Btn.Enabled = False
        FRM_DISPLAY_UI.Digit_5_stop = True
        Digit_btn_5.Enabled = False
    End Sub

    Private Sub Digit_btn_6_Click(sender As Object, e As EventArgs) Handles Digit_btn_6.Click
        Random_Digit_stop_Btn.Enabled = False
        FRM_DISPLAY_UI.Digit_6_stop = True
        Digit_btn_6.Enabled = False
    End Sub

    Private Sub tmr_Random_Stop_Tick(sender As Object, e As EventArgs) Handles tmr_Random_Stop.Tick
        If ran_index = 0 Then
            If Ran_Stop_array(ran_index) = 1 Then
                FRM_DISPLAY_UI.Digit_1_stop = True
                Digit_btn_1.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 2 Then
                FRM_DISPLAY_UI.Digit_2_stop = True
                Digit_btn_2.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 3 Then
                FRM_DISPLAY_UI.Digit_3_stop = True
                Digit_btn_3.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 4 Then
                FRM_DISPLAY_UI.Digit_4_stop = True
                Digit_btn_4.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 5 Then
                FRM_DISPLAY_UI.Digit_5_stop = True
                Digit_btn_5.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 6 Then
                FRM_DISPLAY_UI.Digit_6_stop = True
                Digit_btn_6.Enabled = False
            End If
        ElseIf ran_index = 1 Then
            If Ran_Stop_array(ran_index) = 1 Then
                FRM_DISPLAY_UI.Digit_1_stop = True
                Digit_btn_1.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 2 Then
                FRM_DISPLAY_UI.Digit_2_stop = True
                Digit_btn_2.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 3 Then
                FRM_DISPLAY_UI.Digit_3_stop = True
                Digit_btn_3.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 4 Then
                FRM_DISPLAY_UI.Digit_4_stop = True
                Digit_btn_4.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 5 Then
                FRM_DISPLAY_UI.Digit_5_stop = True
                Digit_btn_5.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 6 Then
                FRM_DISPLAY_UI.Digit_6_stop = True
                Digit_btn_6.Enabled = False
            End If

        ElseIf ran_index = 2 Then
            If Ran_Stop_array(ran_index) = 1 Then
                FRM_DISPLAY_UI.Digit_1_stop = True
                Digit_btn_1.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 2 Then
                FRM_DISPLAY_UI.Digit_2_stop = True
                Digit_btn_2.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 3 Then
                FRM_DISPLAY_UI.Digit_3_stop = True
                Digit_btn_3.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 4 Then
                FRM_DISPLAY_UI.Digit_4_stop = True
                Digit_btn_4.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 5 Then
                FRM_DISPLAY_UI.Digit_5_stop = True
                Digit_btn_5.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 6 Then
                FRM_DISPLAY_UI.Digit_6_stop = True
                Digit_btn_6.Enabled = False
            End If

        ElseIf ran_index = 3 Then
            If Ran_Stop_array(ran_index) = 1 Then
                FRM_DISPLAY_UI.Digit_1_stop = True
                Digit_btn_1.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 2 Then
                FRM_DISPLAY_UI.Digit_2_stop = True
                Digit_btn_2.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 3 Then
                FRM_DISPLAY_UI.Digit_3_stop = True
                Digit_btn_3.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 4 Then
                FRM_DISPLAY_UI.Digit_4_stop = True
                Digit_btn_4.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 5 Then
                FRM_DISPLAY_UI.Digit_5_stop = True
                Digit_btn_5.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 6 Then
                FRM_DISPLAY_UI.Digit_6_stop = True
                Digit_btn_6.Enabled = False
            End If
        ElseIf ran_index = 4 Then
            If Ran_Stop_array(ran_index) = 1 Then
                FRM_DISPLAY_UI.Digit_1_stop = True
                Digit_btn_1.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 2 Then
                FRM_DISPLAY_UI.Digit_2_stop = True
                Digit_btn_2.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 3 Then
                FRM_DISPLAY_UI.Digit_3_stop = True
                Digit_btn_3.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 4 Then
                FRM_DISPLAY_UI.Digit_4_stop = True
                Digit_btn_4.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 5 Then
                FRM_DISPLAY_UI.Digit_5_stop = True
                Digit_btn_5.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 6 Then
                FRM_DISPLAY_UI.Digit_6_stop = True
                Digit_btn_6.Enabled = False
            End If
        ElseIf ran_index = 5 Then
            If Ran_Stop_array(ran_index) = 1 Then
                FRM_DISPLAY_UI.Digit_1_stop = True
                Digit_btn_1.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 2 Then
                FRM_DISPLAY_UI.Digit_2_stop = True
                Digit_btn_2.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 3 Then
                FRM_DISPLAY_UI.Digit_3_stop = True
                Digit_btn_3.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 4 Then
                FRM_DISPLAY_UI.Digit_4_stop = True
                Digit_btn_4.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 5 Then
                FRM_DISPLAY_UI.Digit_5_stop = True
                Digit_btn_5.Enabled = False

            ElseIf Ran_Stop_array(ran_index) = 6 Then
                FRM_DISPLAY_UI.Digit_6_stop = True
                Digit_btn_6.Enabled = False
            End If
        Else
            tmr_Random_Stop.Enabled = False
        End If
        ran_index += 1
    End Sub

    Private Sub Random_Speed_num_ValueChanged(sender As Object, e As EventArgs) Handles Random_Speed_num.ValueChanged
        tmr_Random_Stop.Interval = Random_Speed_num.Value * 1000
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click


        FRM_DISPLAY_UI.Price_LBL_Trans2.HideSync(FRM_DISPLAY_UI.Price_LBL)
        FRM_DISPLAY_UI.rch_Stat.Clear()
        FRM_DISPLAY_UI.Side_Pan_Lbl.Text = ""
        Next_Raffle_Btn.PerformClick()
        Start_Raffle_btn.Enabled = False

        Dim todaydate As String = DateAndTime.Now.ToString("yyyy") + "-" + DateAndTime.Now.ToString("MM") + "-" + DateAndTime.Now.ToString("dd")
        If Municipality_CB.SelectedItem.ToString <> "All" Then
            town = " AND Town = '" + Municipality_CB.SelectedItem.ToString + "'"

        Else

            town = ""

        End If
        Update_btn.Enabled = False

        If Today_CB.Checked = True Then
            tdy = " AND Date(Date_Registered) = """ + todaydate + """"

        Else
            tdy = ""
        End If

        If Update_BW = False Then
            Update_BW = True



            rch_Stat.Text = "Pre-Loading Entries: 0%"
            BW_Pre_Loader_Entries_to_Array.RunWorkerAsync()
        End If


    End Sub

    Private Sub BW_Pre_Loader_Entries_to_Array_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Pre_Loader_Entries_to_Array.DoWork
        Dim n As Integer = 0

        Dim rprt As Integer = 0
        Dim MysqlConn As MySqlConnection
        Dim cmd As New MySqlCommand
        Dim sql As String
        Dim drSQL As MySqlDataReader
        Dim B_Count As Integer = 0
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + IPServer + "; userid=" + Username + "; password=" + Passwd + "; database= " + db_name

        curr_winner_disp = 0
        Batch_no_temp = 0
        Batch_no_temp1 = 0

        ID_Array.Clear()
        Bil_Num_Array.Clear()
        Bil_Acct_Name_Array.Clear()
        Bil_Add_Array.Clear()
        Stub_Array.Clear()
        Idx_Array.Clear()


        Try
            MysqlConn.Open()
            sql = "SELECT COUNT(Distinct Bil_Account_Name) AS rollcount FROM overall_reg WHERE Bil_Account_Name NOT IN " _
                & "(SELECT Bil_Account_Name FROM winners_tbl)" + town + tdy + "AND Bil_Class = 'RES' AND Raffle_Valid = 2 " _
                & "AND (SELECT Account_Sequence FROM accounts_list WHERE overall_reg.Bil_Account_Number = accounts_list.Account_Number) = '1.'"

            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = System.Convert.ToInt32(cmd.ExecuteScalar())
            TotalRecordCount = count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
        End Try

        If TotalRecordCount = 0 Then
            MessageBox.Show("cmd_No Raffle Entries Found")
            'MsgBox("No Raffle Entries found")
            Exit Sub
            'Return "cmd_No Raffle Entries Found"
            'ElseIf TotalRecordCount > 0 Then
            'ReDim IndexRange(TotalRecordCount - 1)

            'n = 0
        End If

        Try

            MysqlConn.Open()
            'sql = "SELECT * FROM registration WHERE Account_Class = 1 And Registrant_Type = 'Member' Group By accountname"
            'If chk_Today.Checked = True Then
            '    sql = "SELECT account_number, account_name, address, Raffle_Ticket, area FROM registration Where r_id > 9063 Group By accountname"
            'Else

            sql = "SELECT Bil_Account_Name, Bil_Account_Number, ID, Bil_Address, Stub_Number, town FROM overall_reg WHERE " _
                    & "Bil_Account_Name NOT IN (SELECT Bil_Account_Name FROM winners_tbl)" + town + tdy + " AND " _
                    & "Bil_Class = 'RES' AND Raffle_Valid = 2 AND (SELECT Account_Sequence FROM accounts_list " _
                    & "WHERE overall_reg.Bil_Account_Number = accounts_list.Account_Number) = '1.' GROUP BY Bil_Account_Name"
            'End If

            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True

                'IndexRange(n) = drSQL("r_id").ToString
                ID_Array.Add(drSQL("ID").ToString)
                Bil_Num_Array.Add(drSQL("Bil_Account_Number").ToString)
                Bil_Acct_Name_Array.Add(drSQL("Bil_Account_Name").ToString)
                Bil_Add_Array.Add(drSQL("Bil_Address").ToString)
                Stub_Array.Add(drSQL("Stub_Number").ToString)
                Town_Array.Add(drSQL("town").ToString)
                n = n + 1
                rprt = (n / (TotalRecordCount)) * 100
                BW_Pre_Loader_Entries_to_Array.ReportProgress(rprt)

            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MysqlConn.Close()
            'Return "cmd_SQL Query Failed " + ex.Message
        Finally
            MysqlConn.Close()
        End Try

        Try
            MysqlConn.Open()

            sql = "SELECT Count(ID_Winner) FROM winners_tbl"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = System.Convert.ToInt32(cmd.ExecuteScalar())
            B_Count = count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
        End Try


        If B_Count > 0 Then
            Try
                MysqlConn.Open()

                sql = "Select Batch_no from winners_tbl ORDER BY Batch_no DESC LIMIT 1"
                cmd = New MySqlCommand(sql, MysqlConn)
                drSQL = cmd.ExecuteReader()
                Do While drSQL.Read = True
                    Batch_no_temp = drSQL("Batch_no")
                Loop
            Catch ex As Exception
                MysqlConn.Close()
            Finally
                MysqlConn.Close()
            End Try
        End If


        Try
            MysqlConn.Open()

            sql = "SELECT Count(ID_Winner) FROM winners_tbl_hist"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = System.Convert.ToInt32(cmd.ExecuteScalar())
            B_Count = count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
        End Try


        If B_Count > 0 Then
            Try
                MysqlConn.Open()

                sql = "Select Batch_no from winners_tbl_hist ORDER BY Batch_no DESC LIMIT 1"
                cmd = New MySqlCommand(sql, MysqlConn)
                drSQL = cmd.ExecuteReader()
                Do While drSQL.Read = True
                    Batch_no_temp1 = drSQL("Batch_no")
                Loop
            Catch ex As Exception
                MysqlConn.Close()
            Finally
                MysqlConn.Close()
            End Try
        End If

        If Batch_no_temp1 > Batch_no_temp Then
            Batch_no_temp = Batch_no_temp1
        End If
        Batch_no_temp += 1
    End Sub

    Private Sub BW_Pre_Loader_Entries_to_Array_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Pre_Loader_Entries_to_Array.ProgressChanged
        rch_Stat.Text = "Pre-Loading Entries: " + e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_Pre_Loader_Entries_to_Array_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Pre_Loader_Entries_to_Array.RunWorkerCompleted
        Disp_Msg(vbNewLine + "Pre-Loaded Entries Count: " + TotalRecordCount.ToString + vbNewLine)
        If Today_CB.Checked = True Then
            Tot_Part_Lbl.Text = "Total Participants : " + TotalRecordCount.ToString + " - " + Municipality_CB.SelectedItem.ToString + " - Today"
        Else
            Tot_Part_Lbl.Text = "Total Participants : " + TotalRecordCount.ToString + " - " + Municipality_CB.SelectedItem.ToString
        End If
        FeaturePrize_tb.Enabled = True
        Panel_Draw.Enabled = True
        Update_btn.Enabled = True
        Update_BW = False
        Batch_no_Lbl.Text = "Batch # : " + Batch_no_temp.ToString

    End Sub

    Private Sub Single_Draw_RB_CheckedChanged(sender As Object, e As EventArgs) Handles Single_Draw_RB.CheckedChanged
        Numberofwinner_numeric.Enabled = False
        Numberofwinner_numeric.Value = 1
    End Sub

    Private Sub Multiple_Draw_RB_CheckedChanged(sender As Object, e As EventArgs) Handles Multiple_Draw_RB.CheckedChanged
        Numberofwinner_numeric.Enabled = True
    End Sub

    Private Sub set_btn_Click(sender As Object, e As EventArgs) Handles set_btn.Click
        If FeaturePrize_tb.Text = "Prize Name" Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Please Enter Prize Name", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Single_Draw_RB.Checked = True Then
                Draw_type = "Single"

            ElseIf Multiple_Draw_RB.Checked = True Then
                Draw_type = "Multiple"
            End If

            Prize_type = Price_Type_ComboBox.SelectedItem.ToString
            Winner_count = Numberofwinner_numeric.Value
            Winners_counter = Winner_count
            FeaturePrize = FeaturePrize_tb.Text
            Batch_win_count_LBL.Text = "Batch Winner Count : " + curr_winner_disp.ToString


            FRM_DISPLAY_UI.Side_Panel_Title_Label.Text = ""
            If ID_Array.Count < Winner_count Then
                DevComponents.DotNetBar.MessageBoxEx.Show("Not enough participants for the draw", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                FRM_DISPLAY_UI.Price_LBL.Visible = False
                If Winner_count > 1 Then
                    FRM_DISPLAY_UI.Price_LBL.Text = Winner_count.ToString + " WINNERS OF " + vbNewLine + FeaturePrize
                Else
                    FRM_DISPLAY_UI.Price_LBL.Text = Winner_count.ToString + " WINNER OF " + vbNewLine + FeaturePrize
                End If

                FRM_DISPLAY_UI.Side_Pan_Lbl.Text = ""
                FRM_DISPLAY_UI.rch_Stat.Clear()

                FRM_DISPLAY_UI.Price_LBL.ForeColor = Color.White
                FRM_DISPLAY_UI.Price_LBL.Location = New Point((FRM_DISPLAY_UI.Width / 2) - (FRM_DISPLAY_UI.Price_LBL.Width / 2), 0)
                FRM_DISPLAY_UI.Price_LBL_Trans.ShowSync(FRM_DISPLAY_UI.Price_LBL)
                Idx_Array.Clear()
                ID_Array_win.Clear()
                Bil_Num_Array_win.Clear()
                Bil_Acct_Name_Array_win.Clear()
                Bil_Add_Array_win.Clear()
                Stub_Array_win.Clear()
                Disp_Msg(vbNewLine + vbNewLine + vbNewLine + Winner_count.ToString + " Winner(s) of " + FeaturePrize + " - (" + Prize_type + ") " + vbNewLine + "Batch.no: " + Batch_no_temp.ToString + vbNewLine)
                FRM_DISPLAY_UI.rch_Stat.Clear()
                BW_Fetch_Winners.RunWorkerAsync()

            End If

        End If
    End Sub

    Private Sub FeaturePrize_tb_MouseClick(sender As Object, e As MouseEventArgs) Handles FeaturePrize_tb.MouseClick
        If FeaturePrize_tb.Text = "Prize Name" Then
            FeaturePrize_tb.Clear()
        End If
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

    Private Sub Show_Console_Btn_Click(sender As Object, e As EventArgs) Handles Show_Console_Btn.Click
        If show_con_press = False Then
            Me.Size = New Size(993, 707)
            show_con_press = True
        Else
            Me.Size = New Size(645, 707)
            show_con_press = False
        End If
    End Sub


    Private Sub BW_Fetch_Winners_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BW_Fetch_Winners.DoWork
        Dim rand As New Random()
        Idx_Array.Clear()
        Dim numb As Integer = 1
        Dim bill_act_temp As String
        Dim stb_temp As String
        For n As Integer = 0 To Winner_count - 1 Step 1

            Dim fetchs As Boolean = False

            Do Until fetchs = True
                Dim idx As Integer = rand.Next(0, ID_Array.Count)

                If Idx_Array.Contains(idx) = False Then
                    Idx_Array.Add(idx)
                    ID_Array_win.Add(ID_Array(idx))
                    Bil_Num_Array_win.Add(Bil_Num_Array(idx))
                    Bil_Acct_Name_Array_win.Add(Bil_Acct_Name_Array(idx))
                    Bil_Add_Array_win.Add(Bil_Add_Array(idx))
                    Town_Array_win.Add(Town_Array(idx))
                    Stub_Array_win.Add(Stub_Array(idx))
                    bill_act_temp = Bil_Acct_Name_Array(idx)
                    stb_temp = Stub_Array(idx)
                    Disp_Msg(vbNewLine + numb.ToString + ".) " + bill_act_temp.ToString + " ---> " + stb_temp.ToString)
                    numb += 1

                    fetchs = True
                End If
            Loop
        Next


    End Sub

    Private Sub BW_Fetch_Winners_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Fetch_Winners.RunWorkerCompleted

        Panel_Draw.Enabled = False
        Start_Raffle_btn.Enabled = True
        FeaturePrize_tb.Enabled = False
        curr_winner_disp = 0
        Speed_Panel.Enabled = True

    End Sub

    Private Sub Side_Panel_Btn_Click(sender As Object, e As EventArgs) Handles Side_Panel_Btn.Click
        If side_panel_flag = False And Side_Pan_Dis_CB.SelectedItem <> "" Then
            Side_Panel_Load()
            FRM_DISPLAY_UI.Side_Panel.BringToFront()
            Side_Panel_Btn.Enabled = False
            Side_Pan_Dis_CB.Enabled = False
            FRM_DISPLAY_UI.Tmr_Side_Panel_Open.Enabled = True
            side_panel_flag = True
        Else
            Side_Panel_Btn.Enabled = False
            FRM_DISPLAY_UI.Tmr_Side_Panel_Close.Enabled = True
            'FRM_DISPLAY_UI.Side_Panel.Location = New Point(0 - FRM_DISPLAY_UI.Side_Panel.Width, 0)
            'FRM_DISPLAY_UI.Side_Panel.Visible = True
            Side_Panel_Btn.Enabled = True
            side_panel_flag = False
        End If
        Side_Pan_Dis_CB.Enabled = True
    End Sub

    Private Sub Side_Panel_Load()
        If Side_Pan_Dis_CB.SelectedItem <> "" Then
            Side_Pan_Batch = Side_Pan_Dis_CB.SelectedItem.ToString
            Side_Display = ""
            side_count = 0
            FRM_DISPLAY_UI.rch_Stat.Clear()
            BW_Side_Pan_Load.RunWorkerAsync()
        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("Please Select Batch no.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub BW_Side_Pan_Load_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BW_Side_Pan_Load.DoWork
        Dim MysqlConn As MySqlConnection
        Dim cmd As New MySqlCommand
        Dim sql As String
        Dim drSQL As MySqlDataReader
        MysqlConn = New MySqlConnection

        MysqlConn.ConnectionString = "server=" + IPServer + "; userid=" + Username + "; password=" + Passwd + "; database= " + db_name
        Try

            MysqlConn.Open()

            sql = "SELECT Bil_Account_Name, Price_Type from winners_tbl Where Batch_no = " + Side_Pan_Batch
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True
                side_count += 1
                Side_Display += vbNewLine + "               " + side_count.ToString + ".) " + drSQL("Bil_Account_Name").ToString
                FeaturePrize2 = drSQL("Price_Type").ToString

            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
        End Try

    End Sub

    Private Sub BW_Side_Pan_Load_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Side_Pan_Load.RunWorkerCompleted
        FRM_DISPLAY_UI.rch_Stat.Clear()
        FRM_DISPLAY_UI.Disp_Msg(Side_Display)
        FRM_DISPLAY_UI.Side_Pan_Lbl.Visible = True
        If Side_Pan_Dis_CB.SelectedItem = "Current Draw" Then
            If Winner_count > 1 Then
                FRM_DISPLAY_UI.Side_Pan_Lbl.Text = Winner_count.ToString + " WINNERS OF " + vbNewLine + FeaturePrize
            ElseIf Winner_count = 1 Then
                FRM_DISPLAY_UI.Side_Pan_Lbl.Text = Winner_count.ToString + " WINNER OF " + vbNewLine + FeaturePrize
            Else
                FRM_DISPLAY_UI.Side_Pan_Lbl.Visible = False
            End If
        Else
            If side_count > 1 Then
                FRM_DISPLAY_UI.Side_Pan_Lbl.Text = side_count.ToString + " WINNERS OF " + vbNewLine + FeaturePrize2
            Else
                FRM_DISPLAY_UI.Side_Pan_Lbl.Text = side_count.ToString + " WINNER OF " + vbNewLine + FeaturePrize2

            End If
        End If
        FRM_DISPLAY_UI.Side_Pan_Lbl.Location = New Point((FRM_DISPLAY_UI.Side_Panel.Width / 2) - (FRM_DISPLAY_UI.Side_Pan_Lbl.Width / 2), FRM_DISPLAY_UI.Side_Panel.Height / 64)

    End Sub

    Public Sub Save_Winner_BW_DoWork()
        error_message = ""
        Dim idx_saving As Integer = curr_winner_disp - 1





        prize_type_for_saving.Add(Price_Type_temp)
        batch_no_for_saving.Add(Batch_no_temp)
        featured_prize_for_saving.Add(FeaturePrize)

        ID_Array_win_for_saving.Add(ID_Array_win(idx_saving))
        Bil_Num_Array_win_for_saving.Add(Bil_Num_Array_win(idx_saving))
        Bil_Acct_Name_Array_win_for_saving.Add(Bil_Acct_Name_Array_win(idx_saving))
        Bil_Add_Array_win_for_saving.Add(Bil_Add_Array_win(idx_saving))
        Stub_Array_win_for_saving.Add(Stub_Array_win(idx_saving))
        Town_Array_win_for_saving.Add(Town_Array_win(idx_saving))



        Dim idx_remove As Integer = ID_Array.IndexOf(ID_Array_win(idx_saving))
        ID_Array.RemoveAt(idx_remove)
        Bil_Num_Array.RemoveAt(idx_remove)
        Bil_Acct_Name_Array.RemoveAt(idx_remove)
        Bil_Add_Array.RemoveAt(idx_remove)
        Stub_Array.RemoveAt(idx_remove)
        Town_Array.RemoveAt(idx_remove)



        If curr_winner_disp = ID_Array_win.Count Then
            Start_Raffle_btn.Enabled = False
            Random_Digit_stop_Btn.Enabled = False
            Speed_Panel.Enabled = False
            Panel_Draw.Enabled = True
            FeaturePrize_tb.Enabled = True
            Next_Raffle_Btn.Enabled = True

            BW_Update_batch_Number.RunWorkerAsync()



        End If
        Side_Load()
        Cancel_Btn.Enabled = False

    End Sub

    Private Sub tmr_winner_saver_trigger_Tick(sender As Object, e As EventArgs) Handles tmr_winner_saver_trigger.Tick
        If ID_Array_win_for_saving.Count > 0 And Save_Winner_BW.IsBusy = False Then

            Save_Winner_BW.RunWorkerAsync()


        End If



    End Sub


    Private Sub Save_Winner_BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Save_Winner_BW.DoWork
        Dim n As Integer = 0
        Dim rprt As Integer = 0
        Dim MysqlConn As MySqlConnection
        Dim cmd As New MySqlCommand
        Dim sql As String
        Dim B_Count As Integer = 0




        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + IPServer + "; userid=" + Username + "; password=" + Passwd + "; database= " + db_name
        Try
            MysqlConn.Open()
            sql = "INSERT INTO Winners_tbl (ID, Bil_Account_Number, Bil_Account_Name, Bil_Address, Stub_Number, Win_Code, Batch_no, Price_Type, town) VALUES (" _
                & "" & ID_Array_win_for_saving(0) & "," _
                & "'" & Bil_Num_Array_win_for_saving(0) & "'," _
                & "'" & Bil_Acct_Name_Array_win_for_saving(0) & "'," _
                & "'" & Bil_Add_Array_win_for_saving(0) & "'," _
                & "'" & Stub_Array_win_for_saving(0) & "'," _
                & "'" & prize_type_for_saving(0) & "'," _
                & "" & batch_no_for_saving(0) & "," _
                & "'" & featured_prize_for_saving(0) & "'," _
                & "'" & Town_Array_win_for_saving(0) & "')"
            cmd.Connection = MysqlConn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            error_message = ex.ToString
        Finally
            MysqlConn.Close()
        End Try



        prize_type_for_saving.RemoveAt(0)
        batch_no_for_saving.RemoveAt(0)
        featured_prize_for_saving.RemoveAt(0)

        ID_Array_win_for_saving.RemoveAt(0)
        Bil_Num_Array_win_for_saving.RemoveAt(0)
        Bil_Acct_Name_Array_win_for_saving.RemoveAt(0)
        Bil_Add_Array_win_for_saving.RemoveAt(0)
        Stub_Array_win_for_saving.RemoveAt(0)
        Town_Array_win_for_saving.RemoveAt(0)
    End Sub


    Private Sub Save_Winner_BW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Save_Winner_BW.RunWorkerCompleted
        If error_message <> "" Then
            MessageBox.Show(error_message)
        End If


        Tot_Part_Lbl.Text = "Total Participants : " + ID_Array.Count.ToString + " - " + Municipality_CB.SelectedItem.ToString
        'mciSendString("stop myWAV", Nothing, 0, 0)

        'If Prize_type <> "Consolation Prize" Then

        '    My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\Winner5.wav")
        'Else
        '    Dim rand As New Random()
        '    Dim wavRad As Integer
        '    wavRad = rand.Next(1, 4)
        '    If wavRad = 1 Then
        '        My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\Winner3.wav")
        '    ElseIf wavRad = 2 Then
        '        My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\Winner4.wav")
        '    ElseIf wavRad = 3 Then
        '        My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\Winner5.wav")
        '    End If
        'End If

    End Sub

    Private Sub BW_Update_batch_Number_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BW_Update_batch_Number.DoWork
        Dim MysqlConn As MySqlConnection
        Dim cmd As New MySqlCommand
        Dim sql As String
        Dim drSQL As MySqlDataReader
        Dim B_Count As Integer = 0
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + IPServer + "; userid=" + Username + "; password=" + Passwd + "; database= " + db_name
        Try
            MysqlConn.Open()

            sql = "SELECT Count(ID_Winner) FROM winners_tbl"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = System.Convert.ToInt32(cmd.ExecuteScalar())
            B_Count = count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MysqlConn.Close()
        Finally
            MysqlConn.Close()
        End Try


        If B_Count > 0 Then
            Try
                MysqlConn.Open()

                sql = "Select Batch_no from winners_tbl ORDER BY Batch_no DESC LIMIT 1"
                cmd = New MySqlCommand(sql, MysqlConn)
                drSQL = cmd.ExecuteReader()
                Do While drSQL.Read = True
                    Batch_no_temp = drSQL("Batch_no")
                Loop
            Catch ex As Exception
                MysqlConn.Close()
            Finally
                MysqlConn.Close()
            End Try
        End If


        Try
            MysqlConn.Open()

            sql = "SELECT Count(ID_Winner) FROM winners_tbl_hist"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = System.Convert.ToInt32(cmd.ExecuteScalar())
            B_Count = count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
        End Try


        If B_Count > 0 Then
            Try
                MysqlConn.Open()

                sql = "Select Batch_no from winners_tbl_hist ORDER BY Batch_no DESC LIMIT 1"
                cmd = New MySqlCommand(sql, MysqlConn)
                drSQL = cmd.ExecuteReader()
                Do While drSQL.Read = True
                    Batch_no_temp1 = drSQL("Batch_no")
                Loop
            Catch ex As Exception
                MysqlConn.Close()
            Finally
                MysqlConn.Close()
            End Try
        End If


    End Sub

    Private Sub BW_Update_batch_Number_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_Update_batch_Number.ProgressChanged

    End Sub

    Private Sub BW_Update_batch_Number_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_Update_batch_Number.RunWorkerCompleted
        If Batch_no_temp1 > Batch_no_temp Then
            Batch_no_temp = Batch_no_temp1
        End If

        Batch_no_temp += 1
        Batch_no_Lbl.Text = "Batch # : " + Batch_no_temp.ToString
    End Sub

    Private Sub Rest_Winner_List_Click(sender As Object, e As EventArgs) Handles Rest_Winner_List.Click
        If DevComponents.DotNetBar.MessageBoxEx.Show("Wipe Winner List table. " + vbNewLine + "Are you sure?? ", "Attention!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            If Wipe_FL = False Then
                Side_Pan_Dis_CB.Items.Clear()
                Wipe_Winner_BW.RunWorkerAsync()
                Wipe_FL = True
            End If
        End If
    End Sub

    Private Sub Wipe_Winner_BW_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles Wipe_Winner_BW.DoWork
        Dim n As Integer = 0
        Dim rprt As Integer = 0
        Dim MysqlConn As MySqlConnection
        Dim cmd As New MySqlCommand
        Dim sql As String

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + IPServer + "; userid=" + Username + "; password=" + Passwd + "; database= " + db_name
        Try
            MysqlConn.Open()
            sql = "Insert into winners_tbl_hist (ID_Winner,ID, Bil_Account_Number, Bil_Account_Name, Bil_Address, Stub_Number, Win_Code, Batch_no, Price_Type, town, TimeStamp) select * from winners_tbl"
            cmd.Connection = MysqlConn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            error_message = ex.ToString
        Finally
            MysqlConn.Close()
        End Try

        Try
            MysqlConn.Open()
            sql = "Delete from winners_tbl"
            cmd.Connection = MysqlConn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            error_message = ex.ToString
        Finally
            MysqlConn.Close()
        End Try
    End Sub


    Private Sub Wipe_Winner_BW_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles Wipe_Winner_BW.RunWorkerCompleted
        Wipe_FL = False
        rch_Stat.Clear()
        Disp_Msg("Winners table successfully wiped!!")
    End Sub

    Private Sub Soud_play_BW_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles Soud_play_BW.DoWork
        'My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\skiri.wav")
    End Sub

    Private Sub Export_PDF_Btn_Click(sender As Object, e As EventArgs) Handles Export_PDF_Btn.Click
        Me.Enabled = False
        FRM_Extract_PDF.ShowDialog()
    End Sub


    Private Sub Blink_Effect_Btn_Click(sender As Object, e As EventArgs) Handles Blink_Effect_Btn.Click
        If Blink = False Then
            FRM_DISPLAY_UI.Tmr_Blink_effect.Enabled = True
            Blink = True
        Else
            FRM_DISPLAY_UI.Tmr_Blink_effect.Enabled = False
            Blink = False
        End If
    End Sub

    Private Sub Blink_Speed_num_ValueChanged(sender As Object, e As EventArgs) Handles Blink_Speed_num.ValueChanged
        FRM_DISPLAY_UI.Tmr_Blink_effect.Interval = Blink_Speed_num.Value * 100
    End Sub

    Private Sub Cancel_Btn_Click(sender As Object, e As EventArgs) Handles Cancel_Btn.Click
        'If Music_Stop_start = False Then
        '    mciSendString("stop myWAV", Nothing, 0, 0)
        '    Music_Stop_start = True
        'Else
        '    mciSendString("play myWAV", Nothing, 0, 0)
        '    Music_Stop_start = False
        'End If
    End Sub


End Class