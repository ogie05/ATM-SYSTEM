<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.type = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.switch = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.password = New Bunifu.Framework.UI.BunifuTextbox()
        Me.username = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.key8 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.key8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 2
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuGradientPanel1.Controls.Add(Me.type)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.switch)
        Me.BunifuGradientPanel1.Controls.Add(Me.LinkLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuFlatButton1)
        Me.BunifuGradientPanel1.Controls.Add(Me.password)
        Me.BunifuGradientPanel1.Controls.Add(Me.username)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SlateBlue
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Linen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Fuchsia
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(288, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(312, 500)
        Me.BunifuGradientPanel1.TabIndex = 12
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(13, 297)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(72, 19)
        Me.BunifuCustomLabel3.TabIndex = 25
        Me.BunifuCustomLabel3.Text = "Login As?"
        '
        'type
        '
        Me.type.BackColor = System.Drawing.Color.Transparent
        Me.type.BorderRadius = 3
        Me.type.DisabledColor = System.Drawing.Color.Gray
        Me.type.ForeColor = System.Drawing.Color.White
        Me.type.Items = New String() {"System User", "Normal User"}
        Me.type.Location = New System.Drawing.Point(48, 319)
        Me.type.Name = "type"
        Me.type.NomalColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.type.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.type.selectedIndex = -1
        Me.type.Size = New System.Drawing.Size(217, 35)
        Me.type.TabIndex = 24
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(13, 468)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(145, 19)
        Me.BunifuCustomLabel2.TabIndex = 23
        Me.BunifuCustomLabel2.Text = "Don't have Account?"
        '
        'switch
        '
        Me.switch.BackColor = System.Drawing.Color.Transparent
        Me.switch.BackgroundImage = CType(resources.GetObject("switch.BackgroundImage"), System.Drawing.Image)
        Me.switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switch.Location = New System.Drawing.Point(17, 445)
        Me.switch.Name = "switch"
        Me.switch.OffColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.switch.OnColor = System.Drawing.Color.Fuchsia
        Me.switch.Size = New System.Drawing.Size(35, 20)
        Me.switch.TabIndex = 22
        Me.switch.Value = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Fuchsia
        Me.LinkLabel1.Location = New System.Drawing.Point(61, 273)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(125, 16)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(27, 89)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(253, 26)
        Me.BunifuCustomLabel1.TabIndex = 16
        Me.BunifuCustomLabel1.Text = "Please Login to continue!"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.SkyBlue
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.SkyBlue
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Login"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(138, 396)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.SkyBlue
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(142, 41)
        Me.BunifuFlatButton1.TabIndex = 15
        Me.BunifuFlatButton1.Text = "Login"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.White
        Me.password.BackgroundImage = CType(resources.GetObject("password.BackgroundImage"), System.Drawing.Image)
        Me.password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.password.Icon = CType(resources.GetObject("password.Icon"), System.Drawing.Image)
        Me.password.Location = New System.Drawing.Point(30, 228)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(250, 42)
        Me.password.TabIndex = 10
        Me.password.text = "Password"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.White
        Me.username.BackgroundImage = CType(resources.GetObject("username.BackgroundImage"), System.Drawing.Image)
        Me.username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.username.Icon = CType(resources.GetObject("username.Icon"), System.Drawing.Image)
        Me.username.Location = New System.Drawing.Point(30, 164)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(250, 42)
        Me.username.TabIndex = 9
        Me.username.text = "Username"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.key8)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.DarkOrange
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Red
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(288, 500)
        Me.BunifuGradientPanel2.TabIndex = 11
        '
        'key8
        '
        Me.key8.BackColor = System.Drawing.Color.Transparent
        Me.key8.Image = Global.ATM_SYSTEM.My.Resources.Resources.atm_machine
        Me.key8.ImageActive = Nothing
        Me.key8.Location = New System.Drawing.Point(26, 127)
        Me.key8.Name = "key8"
        Me.key8.Size = New System.Drawing.Size(237, 209)
        Me.key8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.key8.TabIndex = 9
        Me.key8.TabStop = False
        Me.key8.Zoom = 10
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        CType(Me.key8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents username As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents password As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents switch As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents type As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents key8 As Bunifu.Framework.UI.BunifuImageButton

End Class
