Imports MySql.Data.MySqlClient

Public Class forgotpass
    Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")
    Public username, type As String
    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click
        con.Open()
        If password.text = password1.text Then
            If type = "System User" Then
                Dim cmd As New MySqlCommand("update system set password='" & password.text & "' where username='" & username & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Password Succesfully Updated")
                con.Close()
                cmd.Dispose()
            ElseIf type = "Normal User" Then
                Dim cmd As New MySqlCommand("update user set password='" & password.text & "' where username='" & username & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Password Succesfully Updated")
                con.Close()
                cmd.Dispose()
            End If
            

        Else
            MsgBox("Try Again, Password did'nt match")
        End If
        con.Close()

    End Sub

    Private Sub BunifuGradientPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class