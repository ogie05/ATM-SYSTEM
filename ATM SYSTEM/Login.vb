Imports MySql.Data.MySqlClient
Public Class Login

    Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")



    Private Sub password_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password.Enter
        password.text = ""
    End Sub

    Private Sub username_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.Enter
        username.text = ""
    End Sub

    Private Sub username_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.Leave
        If username.text = "" Then
            username.text = "Username"
        End If
    End Sub

    Private Sub password_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password.Leave
        If password.text = "" Then
            password.text = "Password"
        End If
    End Sub

    Private Sub usershow_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub passshow_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim ctr = 0
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        
        con.Open()
        If type.selectedIndex < 0 Or username.text = "Username" Or username.text = "" Then
            MsgBox("Please select the account type or type username first!", MsgBoxStyle.Information)
        Else
            If type.selectedValue = "System User" Then
                Dim logincmd As New MySqlCommand("select username from system where username=@username", con)
                logincmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.text
                Dim adapter As New MySqlDataAdapter(logincmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    forgotpasscode.username = username.text
                    forgotpasscode.type = type.selectedValue
                    forgotpasscode.Show()
                    Me.Hide()
                Else
                    MsgBox("There is no username in database!")
                End If

            ElseIf type.selectedValue = "Normal User" Then

                Dim logincmd As New MySqlCommand("select username from system where username=@username", con)
                logincmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.text
                Dim adapter As New MySqlDataAdapter(logincmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    forgotpasscode.username = username.text
                    forgotpasscode.type = type.selectedValue
                    forgotpasscode.Show()
                    Me.Hide()
                Else
                    MsgBox("There is no username in database!")
                End If

               
            End If

            End If
        con.Close()
    End Sub

    Private Sub BunifuGradientPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BunifuFormFadeTransition1.ShowAsyc(Me)
        switch.Value = True

    End Sub


    Private Sub switch_OnValueChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles switch.OnValueChange
        If switch.Value = False Then
            Me.Hide()
            Register.Show()
            switch.Value = True
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try

       
        If type.selectedIndex < 0 Then
            MsgBox("Please Input Credential", MsgBoxStyle.Exclamation)
        Else
            If type.selectedValue = "System User" Then
                Dim logincmd As New MySqlCommand("select username,password from system where username=@username and password=@password", con)
                logincmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.text
                logincmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.text
                Dim adapter As New MySqlDataAdapter(logincmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If username.text = Nothing Or password.text = Nothing Then
                    MsgBox("Input your username and password", MsgBoxStyle.Critical, "Error")
                Else
                    If table.Rows.Count > 0 Then
                            MsgBox("Login Successful!" & vbNewLine & "Login User: " & username.text, MsgBoxStyle.Information)

                            Adminmain.mode.Text = username.text
                            Dim timein As String = ""
                            Dim timeout As String = "0"
                            Dim date1 As String = ""
                            timein = Date.Now.ToString("hh:mm:ss tt")
                            date1 = Date.Now.ToString("MMM-dd-yyyy")



                            Dim cmd As New MySqlCommand("insert into loghis(log_name,time_in,time_out,date,type) values ('" & username.text & "','" & timein & "','" & timeout & "','" & date1 & "','System User')", con)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            Me.Hide()
                            Adminmain.Show()


                    Else
                        MsgBox("Wrong Username or Password", MsgBoxStyle.Exclamation)
                    End If
                End If
            ElseIf type.selectedValue = "Normal User" Then
                Dim logincmd As New MySqlCommand("select username,password from user where username=@username and password=@password", con)
                logincmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.text
                logincmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.text
                Dim adapter As New MySqlDataAdapter(logincmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If username.text = Nothing Or password.text = Nothing Then
                    MsgBox("Input your username and password", MsgBoxStyle.Critical, "Error")
                Else
                        If table.Rows.Count > 0 Then
                            MsgBox("Login Successful!" & vbNewLine & "Login User: " & username.text, MsgBoxStyle.Information)

                            Dim timein As String = ""
                            Dim timeout As String = "0"
                            Dim date1 As String = ""
                            timein = Date.Now.ToString("hh:mm:ss tt")
                            date1 = Date.Now.ToString("MMM-dd-yyyy")



                            Dim cmd As New MySqlCommand("insert into loghis(log_name,time_in,time_out,date,type) values ('" & username.text & "','" & timein & "','" & timeout & "','" & date1 & "','Normal User')", con)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()


                            normal_user_form.username = username.text
                            normal_user_form.Show()
                            Me.Hide()

                        Else
                            MsgBox("Wrong Username or Password", MsgBoxStyle.Exclamation)
                        End If
                End If
            End If
        End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuGradientPanel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BunifuGradientPanel2.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub
End Class
