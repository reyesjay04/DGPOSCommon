Imports SyncData
Public Class Form1

    Private Sub tsbTest_Click(sender As Object, e As EventArgs) Handles tsbTest.Click
        If rbSyncData.CheckAlign Then
            Dim frmSync As New SyncData.SyncData(txtLocalCon.Text, txtCloudConn.Text, txtStoreID.Text, txtUserID.Text)
            frmSync.Show()
            AddHandler frmSync.GetCatchLog, AddressOf WriteLog
            AddHandler frmSync.GetPrgbarVal, AddressOf PrgValChange
        End If
    End Sub

    Private Sub WriteLog(ByVal getLogs As String)
        rtbLogs.Text &= vbCrLf & getLogs
    End Sub
    Private Sub PrgValChange(ByVal prgVal As Integer)
        ProgressBar1.Value = prgVal
    End Sub
    Private Sub tsbFillTxt_Click(sender As Object, e As EventArgs) Handles tsbFillTxt.Click
        txtCloudConn.Text = "server=;user id=;password=;database=;port=;"
        txtLocalCon.Text = "server=localhost;user id=root;password=;database=pos;port=3306;"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

End Class
