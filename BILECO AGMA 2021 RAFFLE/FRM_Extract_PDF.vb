Imports pdf1 = PdfSharp
Imports pdf2 = PdfSharp.Drawing
Imports pdf3 = PdfSharp.Pdf
Imports MySql.Data.MySqlClient


Public Class FRM_Extract_PDF
    Dim finalPath_Mstr_PDF As String
    Dim fileName_Mstr_PDF As String
    Dim filepath_Mstr_PDF As String
    Dim ItemNumber_Mstr_PDF As Integer = 1

    Dim finalPath_Mstr_Dist_PDF As String
    Dim fileName_Mstr_Dist_PDF As String
    Dim filepath_Mstr_Dist_PDF As String
    Dim ItemNumber_Mstr_Dist_PDF As Integer = 1

    Dim Prize_Cat As New ArrayList()
    Dim Prize_Name As New ArrayList()
    Dim Prize_Batch As New ArrayList()

    Dim Prize_Cat_temp As String
    Dim Prize_Name_temp As String
    Dim idxs As Integer = 0
    Dim selected_Batch As String

    Dim Logo_PNG As Image = Image.FromFile(My.Application.Info.DirectoryPath + "\Logo.png")
    Private Sub FRM_Extract_PDF_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FRM_CTR_PANEL.Enabled = True
    End Sub

    Private Sub FRM_Extract_PDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            sql = "SELECT Count(ID) from winners_tbl"
            cmd = New MySqlCommand(Sql, MysqlConn)
            Dim count As Int32 = System.Convert.ToInt32(cmd.ExecuteScalar())
            TotalRecordCount = count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
        End Try

        If TotalRecordCount = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("No Winners Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()

        Else
            Try

                MysqlConn.Open()

                sql = "SELECT DISTINCT Batch_no, Win_Code, Price_Type from winners_tbl "
                cmd = New MySqlCommand(sql, MysqlConn)
                drSQL = cmd.ExecuteReader()
                Do While drSQL.Read = True
                    Side_Pan_Dis_CB.Items.Add(drSQL("Batch_no").ToString)
                    Prize_Batch.Add(drSQL("Batch_no").ToString)
                    Prize_Cat.Add(drSQL("Win_Code").ToString)
                    Prize_Name.Add(drSQL("Price_Type").ToString)
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Close()
            End Try
        End If
    End Sub

    Private Sub Extract_Btn_Click(sender As Object, e As EventArgs) Handles Extract_Btn.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        selected_Batch = Side_Pan_Dis_CB.SelectedItem.ToString
        idxs = Prize_Batch.IndexOf(selected_Batch)
        Prize_Cat_temp = Prize_Cat(idxs)
        Prize_Name_temp = Prize_Name(idxs)
        Extract_PDF_Circ_Bar.BringToFront()
        Extract_PDF_Circ_Bar.Visible = True
        Try
            If f.ShowDialog() = DialogResult.OK Then
                fileName_Mstr_PDF = "\AGMA2024_Batch_no_" + selected_Batch.ToString
                filepath_Mstr_PDF = f.SelectedPath
                finalPath_Mstr_PDF = f.SelectedPath + fileName_Mstr_PDF
                ItemNumber_Mstr_PDF = 1
                Export_PDF_BW.RunWorkerAsync()
            End If
        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1055", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Export_PDF_BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Export_PDF_BW.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String = ""
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim MaxPage_PDF As Double
        Dim PageNum As Integer = 0

        Dim maxItems As Integer
        Dim currItem As Integer

        Dim Saver_Counter As Integer = 0
        Dim File_Counter As Integer = 0

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + IPServer + "; userid=" + Username + "; password=" + Passwd + "; database= " + db_name

        Try

            MysqlConn.Open()
            sql = "SELECT COUNT(ID_Winner) AS rollcount FROM winners_tbl Where Batch_no = " + selected_Batch
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            maxItems = count
            MaxPage_PDF = count / 15


            Dim TempVal As Integer = MaxPage_PDF
            If MaxPage_PDF > TempVal Then
                MaxPage_PDF += 1
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            Else
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            End If



        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1053", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()



        End Try

        'Dim currentDate As DateTime = DateTime.Now

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim CurrenPageItems As Integer = 0
        Dim TempStr As String = ""
        Dim TempLen As Integer = 0
        Dim WidthPic As Single = 100 / 1.745
        Dim HeigthPic As Single = 100



        Dim pdf As pdf3.PdfDocument = New pdf3.PdfDocument
        pdf.Info.Title = fileName_Mstr_PDF
        Dim pdfPage As pdf3.PdfPage = pdf.AddPage
        pdfPage.Size = PdfSharp.PageSize.Folio
        Dim Logo_TopLeft As pdf2.XImage
        Logo_TopLeft = Logo_PNG



        pdfPage.Width = 850
        pdfPage.Height = 1300
        pdfPage.TrimMargins.Top = 15
        pdfPage.TrimMargins.Right = 15
        pdfPage.TrimMargins.Bottom = 15
        pdfPage.TrimMargins.Left = 15


        Dim graph As pdf2.XGraphics = pdf2.XGraphics.FromPdfPage(pdfPage)
        
        graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

        graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.", _
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

        graph.DrawString("BILECO", _
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

        graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560", _
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

        graph.DrawString("www.bileco.net", _
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

        graph.DrawString("36th Annual General Membership Assembly | Batch no. : " + selected_Batch.ToString + " - " + Prize_Name_temp.ToString + " (" + Prize_Cat_temp + ")",
           New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

        graph.DrawString("Venue: Caraycaray, Naval, Biliran", _
           New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

        graph.DrawString("Date:   November 19, 2021", _
           New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)




        graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate), _
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

        graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString, _
           New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

        'graph.DrawString("User logged in: " + Logged_Username, _
        '   New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

        xPos += 30

        graph.DrawString("Item #", _
           New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 50

        graph.DrawString("Account #", _
           New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
        xPos += 100

        graph.DrawString("Account Name", _
          New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 215

        graph.DrawString("Address", _
          New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 190

        graph.DrawString("Stub #", _
          New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 110

        graph.DrawString("Signature", _
          New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos = 0

        yPos += 290

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + IPServer + "; userid=" + Username + "; password=" + Passwd + "; database= " + db_name

        sql = "SELECT Bil_Account_Number, Bil_Account_Name, Bil_Address, Stub_number FROM winners_tbl Where Batch_no = " + selected_Batch + " ORDER BY Bil_Account_Name ASC"

        Try
            MysqlConn.Open()
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True
                ' If (Val(drSQL("r_id").ToString) > Last_ID_PDF_OVR) And (currItem < 75) Then
                'Last_ID_PDF_OVR = Val(drSQL("r_id").ToString)

                currItem += 1
                Export_PDF_BW.ReportProgress((currItem / (maxItems + 5)) * 100)
                xPos = 0
                'xIndex = 1


                xPos += 30

                graph.DrawString(ItemNumber_Mstr_PDF.ToString, _
                     New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)


                xPos += 50

                graph.DrawString(drSQL("Bil_Account_Number").ToString, _
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 100
                TempStr = drSQL("Bil_Account_Name")
                TempLen = TempStr.Length
                If TempLen > 30 Then
                    TempStr = Mid(drSQL("Bil_Account_Name"), 1, 30)

                    graph.DrawString(TempStr, _
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Account_Name"), 31, TempLen)

                    graph.DrawString(TempStr, _
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Account_Name")

                    graph.DrawString(TempStr, _
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If



                xPos += 215
                TempStr = drSQL("Bil_Address")
                TempLen = TempStr.Length
                If TempLen > 30 Then
                    TempStr = Mid(drSQL("Bil_Address"), 1, 27)

                    graph.DrawString(TempStr, _
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Address"), 28, TempLen)

                    graph.DrawString(TempStr, _
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Address")

                    graph.DrawString(TempStr, _
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If

                'xPos += 230
                xPos += 190

                graph.DrawString(drSQL("Stub_Number").ToString, _
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 90
                xPos = 0
                yPos += 60
                ItemNumber_Mstr_PDF += 1
                CurrenPageItems += 1

                If CurrenPageItems > 14 Then

                    CurrenPageItems = 0
                    PageNum += 1

                    graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString, _
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

                    graph.DrawString("*This is an electronic-generated report. ", _
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

                    Saver_Counter += 1

                    If Saver_Counter >= 10 Then
                        Saver_Counter = 0
                        File_Counter += 1

                        pdf.Save(finalPath_Mstr_PDF + ".pdf")
                        pdf.Dispose()
                        graph.Graphics.Dispose()
                        graph.Internals.Graphics.Dispose()
                        graph.Dispose()


                        pdf = New pdf3.PdfDocument
                        pdf.Info.Title = fileName_Mstr_PDF


                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15
                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)

                    Else
                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15

                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)


                    End If




                    '---------------------------
                    yPos = 0

                    graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

                    graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.", _
                        New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

                    graph.DrawString("BILECO", _
                        New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

                    graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560", _
                        New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

                    graph.DrawString("www.bileco.net", _
                        New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

                    graph.DrawString("36th Annual General Membership Assembly | Batch no. : " + selected_Batch.ToString + " - " + Prize_Name_temp.ToString + " (" + Prize_Cat_temp + ")",
                       New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

                    graph.DrawString("Venue: Caraycaray, Naval, Biliran", _
                       New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

                    graph.DrawString("Date:   August __, 2024",
                       New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)

                    graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate), _
                        New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

                    graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString, _
                       New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

                    xPos += 30

                    graph.DrawString("Item #", _
                       New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 50

                    graph.DrawString("Account #", _
                       New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
                    xPos += 100

                    graph.DrawString("Account Name", _
                      New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 215

                    graph.DrawString("Address", _
                      New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 190

                    graph.DrawString("Stub #", _
                      New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 110

                    graph.DrawString("Signature", _
                      New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos = 0

                    yPos += 290


                End If


            Loop

        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1054", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        PageNum += 1
        graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString, _
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

        graph.DrawString("*This is an electronic-generated report. ", _
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

        If yPos < 1100 Then
            yPos += 30
        Else
            yPos -= 10
        End If



        graph.DrawString("Prepared by:", _
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Verified by:", _
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 300, yPos)

        graph.DrawString("Noted by:", _
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 550, yPos)


        yPos += 40

        graph.DrawString("______________________", _
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Ma. Leizyl Q. Garcia", _
          New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 300, yPos)

        graph.DrawString("Gerardo N. Oledan, REE", _
          New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 550, yPos)

        yPos += 15


        graph.DrawString("User", _
            New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("FSDM", _
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 300, yPos)


        graph.DrawString("General Manager", _
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, yPos)

        Dim Temp_Subtractor As Integer = ItemNumber_Mstr_PDF - (File_Counter * 150)
        Try
            pdf.Save(finalPath_Mstr_PDF + "(Items " + (ItemNumber_Mstr_PDF - Temp_Subtractor + 1).ToString + " to " + (ItemNumber_Mstr_PDF - 1).ToString + ").pdf")
            pdf.Dispose()
            graph.Dispose()
            currItem += 5
            Export_PDF_BW.ReportProgress((currItem / (maxItems + 5)) * 100)

            DevComponents.DotNetBar.MessageBoxEx.Show("PDF Export done.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(filepath_Mstr_PDF)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Export_PDF_BW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles Export_PDF_BW.ProgressChanged
        Extract_PDF_Circ_Bar.Value = e.ProgressPercentage
    End Sub

    Private Sub Export_PDF_BW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Export_PDF_BW.RunWorkerCompleted
        Extract_PDF_Circ_Bar.Visible = False
    End Sub
End Class