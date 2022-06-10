Imports MySql.Data.MySqlClient
Public Class forgotpasscode
    Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")
    Public username, type As String
    Private Sub CODE_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODE.Enter
        CODE.text = ""
    End Sub

    Private Sub CODE_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CODE.Leave
        If CODE.text = "" Then
            CODE.text = "Code"
        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click
        con.Open()

        If type = "System User" Then
            Dim dr As MySqlDataReader
            Dim cmd As New MySqlCommand("select code from system where username='" & username & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            Dim getcode = dr.GetString("code")
            If getcode = CODE.text Then
                forgotpass.Show()
                forgotpass.username = username
                forgotpass.type = type
                Me.Hide()
            Else
                MsgBox("Wrong Code!", MsgBoxStyle.Exclamation)
            End If
        ElseIf type = "Normal User" Then
            Dim cmd As New MySqlCommand("select code from user where username ='" & username & "'", con)
            Dim da As MySqlDataReader
            da = cmd.ExecuteReader
            da.Read()
            Dim getcode = da.GetString("code")
            If getcode = CODE.text Then
                forgotpass.Show()
                forgotpass.username = username
                forgotpass.type = type
                Me.Hide()
            Else
                MsgBox("Wrong Code!", MsgBoxStyle.Exclamation)
            End If
        End If
        con.Close()

    End Sub
End Class