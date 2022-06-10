Imports MySql.Data.MySqlClient
Public Class Main
    Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")
    Public k1 = 1, k2 = 2, k3 = 3, k4 = 4, k5 = 5, k6 = 6, k7 = 7, k8 = 8, k9 = 9, k0 = 0, screenmoney = "0"
    Public maincardnumber As String
    Private Sub BunifuGradientPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim time1, date1 As String
        date1 = Date.Now.ToString("MMM-dd-yyyy")


        time1 = Date.Now.ToString("hh:mm:ss tt")
        time.Text = time1
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        balancepanel.Visible = False
        accountpanel.Visible = False
    End Sub

    Private Sub key1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key1.Click
        money.Text = money.Text & k1
        screenmoney = money.Text
    End Sub

    Private Sub key2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key2.Click
        money.Text = money.Text & k2
    End Sub

    Private Sub key3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key3.Click
        money.Text = money.Text & k3
    End Sub

    Private Sub key4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key4.Click
        money.Text = money.Text & k4
    End Sub

    Private Sub key5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key5.Click
        money.Text = money.Text & k5
    End Sub

    Private Sub key6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key6.Click
        money.Text = money.Text & k6
    End Sub

    Private Sub key7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key7.Click
        money.Text = money.Text & k7
    End Sub

    Private Sub key8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key8.Click
        money.Text = money.Text & k8
    End Sub

    Private Sub key9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key9.Click
        money.Text = money.Text & k9
    End Sub

    Private Sub key0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key0.Click
        money.Text = money.Text & k0
    End Sub

   
    Private Sub withdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw.Click
        mode.Text = "Withdraw"
    End Sub

    Private Sub deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deposit.Click
        mode.Text = "Deposit"


    End Sub

    Private Sub balance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles balance.Click
        mode.Text = "Balance Inquiry"
        balancepanel.Visible = True
        accountpanel.Visible = False
        If balancepanel.Height = 0 Then
            balancepanel.Height = 79
        ElseIf balancepanel.Height = 79 Then
            balancepanel.Height = 0
        End If
        con.Open()

        Try
            Dim cmd As New MySqlCommand("select total_money,username from user where cardnumber ='" & maincardnumber & "' ", con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read()
                Dim baluser = dr.GetString("username")
                bal_user.Text = baluser
                Dim total = dr.GetString("total_money")
                total_bal.Text = total
            End While
            cmd.Dispose()
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

    End Sub

    

    Private Sub keydel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keydel.Click

        If money.Text.Length > 0 Then
            money.Text = money.Text.Substring(0, money.Text.Length - 1)
        End If

    End Sub
    Public needname As String = ""
    Private Sub BunifuFlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton4.Click
        Dim ans As DialogResult
        ans = MsgBox("Are you sure to logout?", MsgBoxStyle.YesNo)

        If ans = DialogResult.Yes Then
            
                con.Open()

                Login.Show()
                Me.Hide()
                Dim timeout As String = ""

                timeout = Date.Now.ToString("hh:mm:ss tt")
            Dim cmd As New MySqlCommand("update loghis set time_out='" & timeout & "' where log_name='" & needname & "'", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

            con.Close()
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub accountinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accountinfo.Click
        mode.Text = "Account Information"
        balancepanel.Visible = False
        accountpanel.Visible = True
        If accountpanel.Height = 0 Then
            accountpanel.Height = 85
        ElseIf accountpanel.Height = 85 Then
            accountpanel.Height = 0
        End If


        con.Open()
        Try
            Dim cmd As New MySqlCommand("select * from user where cardnumber='" & maincardnumber & "' ", con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim username1 = dr.GetString("username")
                username.Text = username1
                Dim cardnumber1 = dr.GetString("cardnumber")
                cardnumber.Text = cardnumber1
            End While
            dr.Close()
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()


        End Try
        con.Close()

    End Sub

    Private Sub keyok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keyok.Click

        If mode.Text = "Deposit" Then
            con.Open()
            Try
                Dim cmd As New MySqlCommand("select total_money from user where cardnumber = '" & maincardnumber & "' ", con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader
                dr.Read()
                Dim getmoney = dr.GetString("total_money")
                Dim add, getm As Double
                getm = getmoney
                add = money.Text
                Dim tmoney = getm + add
                cmd.Dispose()
                dr.Close()
                Dim cmd1 As New MySqlCommand("update user set total_money='" & tmoney & "' where cardnumber = '" & maincardnumber & "' ", con)
                cmd1.ExecuteNonQuery()
                MsgBox("Deposit Money Successfully")
                money.Text = ""

                cmd1.Dispose()

                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()

        ElseIf mode.Text = "Withdraw" Then
            con.Open()
            Try
                Dim cmd As New MySqlCommand("select total_money from user where cardnumber = '" & maincardnumber & "' ", con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader
                dr.Read()
                Dim getmoney = dr.GetString("total_money")
                Dim subm, getm As Double
                getm = getmoney
                subm = money.Text

                If getm < subm Then
                    MsgBox("You dont have enough balance!", MsgBoxStyle.Exclamation)


                Else
                    Dim tmoney = getm - subm
                    cmd.Dispose()
                    dr.Close()
                    Dim cmd1 As New MySqlCommand("update user set total_money='" & tmoney & "' where cardnumber = '" & maincardnumber & "' ", con)
                    cmd1.ExecuteNonQuery()
                    MsgBox("Withdraw Money Successfully")
                    money.Text = ""

                    cmd1.Dispose()
                    con.Close()
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()
        End If
    End Sub
End Class