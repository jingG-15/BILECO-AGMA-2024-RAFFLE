Imports MySql.Data.MySqlClient
Public Class Login


    Private Sub Cancel_btn_Click(sender As Object, e As EventArgs) Handles Cancel_btn.Click
        Me.Close()
    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        If Ip_Add_tb.Text <> "" And User_tb.Text <> "" And Pass_tb.Text <> "" Then
            IPServer = Ip_Add_tb.Text
            Username = User_tb.Text
            Passwd = Pass_tb.Text

            Dim Flag As Boolean = False
            Dim MysqlConn As MySqlConnection
            'Dim cmd As New MySqlCommand
            'Dim drSQL As New MySqlDataReader
            Dim da As New MySqlDataAdapter
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + IPServer + "; userid=" + Username + "; password=" + Passwd + "; database= " + db_name
            Try

                MysqlConn.Open()
                'DevComponents.DotNetBar.MessageBoxEx.Show("Connected to server: " + IPServer, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Flag = True
            Catch ex As Exception
                DevComponents.DotNetBar.MessageBoxEx.Show("Access Denied", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MsgBox(ex.Message.ToString, , "Connection Prompt")
            End Try
            MysqlConn.Close()

            If Flag = True Then
                FRM_CTR_PANEL.Show()
                Me.Close()
            End If

        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("Please Fill up all fields", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    'Private Sub Pass_tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pass_tb.KeyPress
    '    Dim Flag As Boolean = False
    '    Dim MysqlConn As MySqlConnection
    '    Dim da As New MySqlDataAdapter
    '    MysqlConn = New MySqlConnection
    '    MysqlConn.ConnectionString = "server=" + IPServer + "; userid=" + Username + "; password=" + Passwd + "; database= " + db_name
    '    If Asc(e.KeyChar) = 13 Then
    '        IPServer = Ip_Add_tb.Text
    '        Username = User_tb.Text
    '        Passwd = Pass_tb.Text
    '        Try

    '            MysqlConn.Open()
    '            'DevComponents.DotNetBar.MessageBoxEx.Show("Connected to server: " + IPServer, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Flag = True
    '        Catch ex As Exception
    '            DevComponents.DotNetBar.MessageBoxEx.Show("Access Denied", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            'MsgBox(ex.Message.ToString, , "Connection Prompt")
    '        End Try
    '        MysqlConn.Close()

    '        If Flag = True Then
    '            FRM_CTR_PANEL.Show()
    '            Me.Close()
    '        End If
    '    End If
    'End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\login.png")
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Pass_tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pass_tb.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Login_btn.PerformClick()
        End If
    End Sub

    Private Sub User_tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles User_tb.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Login_btn.PerformClick()
        End If
    End Sub
End Class