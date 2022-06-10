Imports MySql.Data.MySqlClient
Public Class normal_user_form
    Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=atmsystem")
    Public username As String
    Private Sub generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generate.Click
        con.Open()

        Dim cmd As New MySqlCommand("select cardnumber,pincode from user where username='" & username & "'", con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        Dim card = dr.GetString("cardnumber")
        Dim pincode = dr.GetString("pincode")
        If card = cardnumber.text And pincode = cardpin.text Then
            MsgBox("Credit Card Verified!", MsgBoxStyle.Information)
            Main.maincardnumber = cardnumber.text
            Main.needname = username
            Main.Show()
            Me.Hide()

        Else
            MsgBox("Credit Card Denied!", MsgBoxStyle.Critical)
        End If
        con.Close()
        dr.Close()

    End Sub

    Private Sub cardnumber_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cardnumber.Enter
        cardnumber.text = ""
    End Sub

    Private Sub cardpin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cardpin.Enter
        cardpin.text = ""
    End Sub

    Private Sub cardnumber_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cardnumber.Leave
        If cardnumber.text = "" Then
            cardnumber.text = "Credit Card Number"
        End If
    End Sub

    Private Sub cardpin_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cardpin.Leave
        If cardpin.text = "" Then
            cardpin.text = "Pin"
        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class