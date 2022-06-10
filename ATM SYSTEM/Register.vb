Imports MySql.Data.MySqlClient
Public Class Register
    Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")
    Private Sub username_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.Enter
        username.text = ""
    End Sub

    Private Sub password_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password.Enter
        password.text = ""
    End Sub

    Private Sub password_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password.Leave
        If password.text = "" Then
            password.text = "Password"
        End If
    End Sub

    Private Sub username_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.Leave
        If username.text = "" Then
            username.text = "Username"
        End If
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'BunifuFormFadeTransition1.ShowAsyc(Me)
        'switch.Value = False
    End Sub

    Private Sub BunifuGradientPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub switch_OnValueChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles switch.OnValueChange
        If switch.Value = True Then
            Me.Hide()
            Login.Show()
            switch.Value = False
        Else

        End If
    End Sub

    Private Sub rpassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpassword.Enter
        rpassword.text = ""
    End Sub

    Private Sub rpassword_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpassword.Leave
        If rpassword.text = "" Then
            rpassword.text = "Retype Password"
        End If
    End Sub

    Private Sub recovery_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recovery.Enter
        recovery.text = ""
    End Sub

    Private Sub recovery_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recovery.Leave
        If recovery.text = "" Then
            recovery.text = "Recovery Code"
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click
        con.Open()
        Try

       
        If type.selectedIndex < 0 Then
            MsgBox("Please Select Account Type", MsgBoxStyle.Exclamation)
        Else

            If password.text = rpassword.text Then

                If type.selectedValue = "System User" Then

                    If username.text = "" Or password.text = "" Or recovery.text = "" Or rpassword.text = "" Then
                        MsgBox("Please fill up all credential", MsgBoxStyle.Exclamation)
                    Else
                        Dim cmd As New MySqlCommand("insert into system (username,password,code) values ('" & username.text & "','" & password.text & "','" & recovery.text & "')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Info Succesfully Registered!")
                        con.Close()
                    End If
                ElseIf type.selectedValue = "Normal User" Then
                    If username.text = "" Or password.text = "" Or recovery.text = "" Or rpassword.text = "" Or cardnumber.text = "" Or cardpin.text = "" Then
                        MsgBox("Please fill up all credential", MsgBoxStyle.Exclamation)
                        Else
                            Dim totalm = 0
                            Dim cmd As New MySqlCommand("insert into user (username,password,code,cardnumber,pincode,total_money) values ('" & username.text & "','" & password.text & "','" & recovery.text & "','" & cardnumber.text & "','" & cardpin.text & "','" & totalm & "') ", con)
                            cmd.ExecuteNonQuery()
                            MsgBox("Info Succesfully Registered!")
                            con.Close()

                    End If
                End If
            Else
                MsgBox("Your password didn't match!")
            End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub cardpin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cardpin.Enter
        cardpin.text = ""
    End Sub

    Private Sub cardpin_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cardpin.Leave
        If cardpin.text = "" Then
            cardpin.text = "Pin"
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generate.Click
        Try

       
        con.Open()
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand("select user_id from user order by user_id desc limit 1", con)
        dr = cmd.ExecuteReader
        dr.Read()
        Dim maxcode = dr.GetString("user_id")
        Dim cardnumber1 As String
        Dim date1 As String
        date1 = Date.Now.ToString("yyyy-MM-dd")
            maxcode = maxcode + 1
            cardnumber1 = date1 + maxcode
        cardnumber.text = cardnumber1
        con.Close()
        dr.Close()
        cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub type_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles type.onItemSelected
        If type.selectedValue = "System User" Then
            cardnumber.Visible = False
            cardpin.Visible = False
            generate.Visible = False
            gtext.Visible = False
        Else
            cardnumber.Visible = True
            cardpin.Visible = True
            generate.Visible = True
            gtext.Visible = True
        End If
    End Sub
End Class