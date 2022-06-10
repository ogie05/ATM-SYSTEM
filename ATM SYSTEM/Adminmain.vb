Imports MySql.Data.MySqlClient

Public Class Adminmain

    Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")

    Dim pd As Integer = 51
    Dim pd1 As Integer = 51
    Dim pd2 As Integer = 51

    Private Sub BunifuGradientPanel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BunifuGradientPanel2.Paint

    End Sub



    Private Sub modify_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pd > 173 Then
            Timer1.Stop()

        Else
            Me.panelmodify.Size = New Size(Me.panelmodify.Size.Width, pd)
            pd += 20
        End If


    End Sub

    Private Sub Adminmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        updateuser.Visible = False
    End Sub

    Private Sub modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub modify_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If pd1 > 173 Then
            Timer2.Stop()

        Else
            Me.panelview.Size = New Size(Me.panelview.Size.Width, pd1)
            pd1 += 20
        End If

    End Sub




    Private Sub BunifuFlatButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton3.Click
        datagridview.Visible = True
        panellog.Height = 51
        panelmodify.Height = 51
        pd = 51
        pd2 = 51
        Timer2.Start()

    End Sub

    Private Sub BunifuFlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton6.Click
        Timer1.Start()
        panellog.Height = 51
        panelview.Height = 51
        pd1 = 51
        pd2 = 51
    End Sub

    Private Sub BunifuFlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton4.Click
        off()
        updateuser.Visible = False

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")
        con.Open()
        Dim cmd As MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dataset As New DataSet
        cmd = New MySqlCommand("Select * from system", con)
        da.SelectCommand = cmd
        da.Fill(dataset, "system")
        datagridview.DataSource = dataset
        datagridview.DataMember = "system"
        con.Close()

    End Sub

    Private Sub BunifuFlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton5.Click
        off()
        updateuser.Visible = False

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")
        con.Open()
        Dim cmd As MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dataset As New DataSet
        cmd = New MySqlCommand("Select * from user", con)
        da.SelectCommand = cmd
        da.Fill(dataset, "user")
        datagridview.DataSource = dataset
        datagridview.DataMember = "user"
        con.Close()
    End Sub

    Public Sub off()
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()

        panelmodify.Height = 51
        pd = 51
        panelview.Height = 51
        pd1 = 51
        panellog.Height = 51
        pd2 = 51

    End Sub
    Private Sub BunifuGradientPanel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuGradientPanel2.Click
        off()
        datagridview.Visible = False
    End Sub
    Public ctr = 1
    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click
        off()
        ctr = 1
        pincode.Visible = False
        pin.Visible = False
        datagridview.Visible = False
        updateuser.Visible = True


    End Sub

    Private Sub BunifuFlatButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton7.Click
        con.Open()
        If ctr = 1 Then
            Try
                Dim cmd As New MySqlCommand("select * from system where system_id ='" & search.Text & "' ", con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read
                    Dim username = dr.GetString("username")
                    user.Text = username
                    Dim password = dr.GetString("password")
                    pass.Text = password
                    Dim code1 = dr.GetString("code")
                    code.Text = code1
                   
                End While
                dr.Close()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf ctr = 2 Then
            Try
                Dim cmd As New MySqlCommand("select * from user where user_id ='" & search.Text & "' ", con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader

                While dr.Read
                    Dim username = dr.GetString("username")
                    user.Text = username
                    Dim password = dr.GetString("password")
                    pass.Text = password
                    Dim code1 = dr.GetString("code")
                    code.Text = code1
                    Dim pin1 = dr.GetString("pincode")
                    pincode.Text = pin1
                End While
                dr.Close()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
       
        con.Close()


    End Sub

    Private Sub BunifuFlatButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton8.Click
        con.Open()

        If ctr = 1 Then
            Try
                Dim cmd As New MySqlCommand("update system set username='" & user.Text & "',password='" & pass.Text & "',code='" & code.Text & "' where system_id ='" & search.Text & "' ", con)
                cmd.ExecuteNonQuery()
                MsgBox("Admin Update Successfull!")
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

        ElseIf ctr = 2 Then
            Try
                Dim cmd As New MySqlCommand("update user set username='" & user.Text & "',password='" & pass.Text & "',code='" & code.Text & "',pincode='" & pincode.Text & "' where user_id ='" & search.Text & "' ", con)
                cmd.ExecuteNonQuery()
                MsgBox("User Update Successfull!")
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

        End If

       
        con.Close()

    End Sub

    Private Sub BunifuFlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton2.Click
        off()
        ctr = 2
        datagridview.Visible = False
        updateuser.Visible = True
        pincode.Visible = True
        pin.Visible = True
    End Sub

 
    Private Sub panellog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panellog1.Click
        datagridview.Visible = True
        updateuser.Visible = False

        panelview.Height = 51
        panelmodify.Height = 51
        pd = 51
        pd1 = 51
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If pd2 > 173 Then
            Timer3.Stop()

        Else
            Me.panellog.Size = New Size(Me.panellog.Size.Width, pd2)
            pd2 += 20
        End If
    End Sub

    Private Sub BunifuFlatButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton10.Click
        off()
        updateuser.Visible = False

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")
        con.Open()
        Dim cmd As MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dataset As New DataSet
        cmd = New MySqlCommand("Select * from loghis where type='System User'", con)
        da.SelectCommand = cmd
        da.Fill(dataset, "loghis")
        datagridview.DataSource = dataset
        datagridview.DataMember = "loghis"
        con.Close()
    End Sub

    Private Sub BunifuFlatButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton9.Click
        off()
        updateuser.Visible = False

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")
        con.Open()
        Dim cmd As MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dataset As New DataSet
        cmd = New MySqlCommand("Select * from loghis where type='Normal User'", con)
        da.SelectCommand = cmd
        da.Fill(dataset, "loghis")
        datagridview.DataSource = dataset
        datagridview.DataMember = "loghis"
        con.Close()
    End Sub

    Private Sub BunifuFlatButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton11.Click
        Dim ans As DialogResult
        ans = MsgBox("Are you sure to log out? ", MsgBoxStyle.YesNo)

        If ans = DialogResult.Yes Then
            con.Open()

            Login.Show()
            Me.Hide()
            Dim timeout As String = ""

            timeout = Date.Now.ToString("hh:mm:ss tt")
            Dim cmd As New MySqlCommand("update loghis set time_out='" & timeout & "' where log_name='" & mode.Text & "'", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            con.Close()



        End If
    End Sub
End Class