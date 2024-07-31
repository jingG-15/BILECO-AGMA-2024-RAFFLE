Imports System.Runtime.InteropServices

Module Globals
    Public ID_Array As New ArrayList()
    Public Bil_Num_Array As New ArrayList()
    Public Bil_Acct_Name_Array As New ArrayList()
    Public Bil_Add_Array As New ArrayList()
    Public Stub_Array As New ArrayList()
    Public Town_Array As New ArrayList()

    Public ID_Array_win As New ArrayList()
    Public Bil_Num_Array_win As New ArrayList()
    Public Bil_Acct_Name_Array_win As New ArrayList()
    Public Bil_Add_Array_win As New ArrayList()
    Public Stub_Array_win As New ArrayList()
    Public Idx_Array As New ArrayList()
    Public Town_Array_win As New ArrayList()

    Public Current_Prize_Title As String

    Public IPServer As String
    Public Username As String
    Public Passwd As String
    Public TotalRecordCount As Integer
    Public db_name As String = "agma_2024"

    Public Winner_count As Integer
    Public Draw_type As String
    Public Prize_type As String
    Public FeaturePrize As String

    Public Batch_no_temp As Integer = 0
    Public Batch_no_temp1 As Integer = 0

    Public Snds As New Dictionary(Of String, String)
    Public sndcnt As Integer = 0

    
End Module
