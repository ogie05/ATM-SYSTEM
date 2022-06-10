<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.switch = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.recovery = New Bunifu.Framework.UI.BunifuTextbox()
        Me.rpassword = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.type = New Bunifu.Framework.UI.BunifuDropdown()
        Me.username = New Bunifu.Framework.UI.BunifuTextbox()
        Me.password = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.gtext = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.generate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cardpin = New Bunifu.Framework.UI.BunifuTextbox()
        Me.cardnumber = New Bunifu.Framework.UI.BunifuTextbox()
        Me.key8 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.key8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 2
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel2.Controls.Add(Me.switch)
        Me.BunifuGradientPanel2.Controls.Add(Me.recovery)
        Me.BunifuGradientPanel2.Controls.Add(Me.rpassword)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuFlatButton1)
        Me.BunifuGradientPanel2.Controls.Add(Me.type)
        Me.BunifuGradientPanel2.Controls.Add(Me.username)
        Me.BunifuGradientPanel2.Controls.Add(Me.password)
        Me.BunifuTransition1.SetDecoration(Me.BunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.DarkOrange
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Red
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(288, 500)
        Me.BunifuGradientPanel2.TabIndex = 6
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(8, 473)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(161, 19)
        Me.BunifuCustomLabel2.TabIndex = 21
        Me.BunifuCustomLabel2.Text = "Already have Account?"
        '
        'switch
        '
        Me.switch.BackColor = System.Drawing.Color.Transparent
        Me.switch.BackgroundImage = CType(resources.GetObject("switch.BackgroundImage"), System.Drawing.Image)
        Me.switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.switch, BunifuAnimatorNS.DecorationType.None)
        Me.switch.Location = New System.Drawing.Point(12, 450)
        Me.switch.Name = "switch"
        Me.switch.OffColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.switch.OnColor = System.Drawing.Color.Fuchsia
        Me.switch.Size = New System.Drawing.Size(35, 20)
        Me.switch.TabIndex = 20
        Me.switch.Value = True
        '
        'recovery
        '
        Me.recovery.BackColor = System.Drawing.Color.White
        Me.recovery.BackgroundImage = CType(resources.GetObject("recovery.BackgroundImage"), System.Drawing.Image)
        Me.recovery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.recovery, BunifuAnimatorNS.DecorationType.None)
        Me.recovery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.recovery.Icon = CType(resources.GetObject("recovery.Icon"), System.Drawing.Image)
        Me.recovery.Location = New System.Drawing.Point(12, 291)
        Me.recovery.Name = "recovery"
        Me.recovery.Size = New System.Drawing.Size(250, 42)
        Me.recovery.TabIndex = 19
        Me.recovery.text = "Recovery Code"
        '
        'rpassword
        '
        Me.rpassword.BackColor = System.Drawing.Color.White
        Me.rpassword.BackgroundImage = CType(resources.GetObject("rpassword.BackgroundImage"), System.Drawing.Image)
        Me.rpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.rpassword, BunifuAnimatorNS.DecorationType.None)
        Me.rpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rpassword.Icon = CType(resources.GetObject("rpassword.Icon"), System.Drawing.Image)
        Me.rpassword.Location = New System.Drawing.Point(12, 231)
        Me.rpassword.Name = "rpassword"
        Me.rpassword.Size = New System.Drawing.Size(250, 42)
        Me.rpassword.TabIndex = 18
        Me.rpassword.text = "Retype Password"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(44, 53)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(190, 26)
        Me.BunifuCustomLabel1.TabIndex = 17
        Me.BunifuCustomLabel1.Text = "Fill up to Register!"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.SkyBlue
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.SkyBlue
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Register"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(128, 402)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.SkyBlue
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(138, 44)
        Me.BunifuFlatButton1.TabIndex = 14
        Me.BunifuFlatButton1.Text = "Register"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'type
        '
        Me.type.BackColor = System.Drawing.Color.Transparent
        Me.type.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.type, BunifuAnimatorNS.DecorationType.None)
        Me.type.DisabledColor = System.Drawing.Color.Gray
        Me.type.ForeColor = System.Drawing.Color.White
        Me.type.Items = New String() {"System User", "Normal User"}
        Me.type.Location = New System.Drawing.Point(30, 360)
        Me.type.Name = "type"
        Me.type.NomalColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.type.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.type.selectedIndex = -1
        Me.type.Size = New System.Drawing.Size(217, 35)
        Me.type.TabIndex = 13
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.White
        Me.username.BackgroundImage = CType(resources.GetObject("username.BackgroundImage"), System.Drawing.Image)
        Me.username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.username, BunifuAnimatorNS.DecorationType.None)
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.Icon = CType(resources.GetObject("username.Icon"), System.Drawing.Image)
        Me.username.Location = New System.Drawing.Point(12, 111)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(250, 42)
        Me.username.TabIndex = 11
        Me.username.text = "Username"
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.White
        Me.password.BackgroundImage = CType(resources.GetObject("password.BackgroundImage"), System.Drawing.Image)
        Me.password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.password, BunifuAnimatorNS.DecorationType.None)
        Me.password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.Icon = CType(resources.GetObject("password.Icon"), System.Drawing.Image)
        Me.password.Location = New System.Drawing.Point(12, 169)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(250, 42)
        Me.password.TabIndex = 12
        Me.password.text = "Password"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.key8)
        Me.BunifuGradientPanel1.Controls.Add(Me.gtext)
        Me.BunifuGradientPanel1.Controls.Add(Me.generate)
        Me.BunifuGradientPanel1.Controls.Add(Me.cardpin)
        Me.BunifuGradientPanel1.Controls.Add(Me.cardnumber)
        Me.BunifuTransition1.SetDecoration(Me.BunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SlateBlue
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Linen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Fuchsia
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(288, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(312, 500)
        Me.BunifuGradientPanel1.TabIndex = 5
        '
        'gtext
        '
        Me.gtext.AutoSize = True
        Me.gtext.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.gtext, BunifuAnimatorNS.DecorationType.None)
        Me.gtext.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtext.ForeColor = System.Drawing.Color.White
        Me.gtext.Location = New System.Drawing.Point(9, 83)
        Me.gtext.Name = "gtext"
        Me.gtext.Size = New System.Drawing.Size(244, 19)
        Me.gtext.TabIndex = 22
        Me.gtext.Text = "Generate your Credit Card Number"
        '
        'generate
        '
        Me.generate.Activecolor = System.Drawing.Color.SkyBlue
        Me.generate.BackColor = System.Drawing.Color.SkyBlue
        Me.generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.generate.BorderRadius = 7
        Me.generate.ButtonText = "Generate"
        Me.generate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.generate, BunifuAnimatorNS.DecorationType.None)
        Me.generate.DisabledColor = System.Drawing.Color.Gray
        Me.generate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.generate.Iconcolor = System.Drawing.Color.Transparent
        Me.generate.Iconimage = Nothing
        Me.generate.Iconimage_right = Nothing
        Me.generate.Iconimage_right_Selected = Nothing
        Me.generate.Iconimage_Selected = Nothing
        Me.generate.IconMarginLeft = 0
        Me.generate.IconMarginRight = 0
        Me.generate.IconRightVisible = True
        Me.generate.IconRightZoom = 0.0R
        Me.generate.IconVisible = True
        Me.generate.IconZoom = 90.0R
        Me.generate.IsTab = False
        Me.generate.Location = New System.Drawing.Point(134, 229)
        Me.generate.Name = "generate"
        Me.generate.Normalcolor = System.Drawing.Color.SkyBlue
        Me.generate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.generate.OnHoverTextColor = System.Drawing.Color.Black
        Me.generate.selected = False
        Me.generate.Size = New System.Drawing.Size(140, 36)
        Me.generate.TabIndex = 22
        Me.generate.Text = "Generate"
        Me.generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.generate.Textcolor = System.Drawing.Color.Black
        Me.generate.TextFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cardpin
        '
        Me.cardpin.BackColor = System.Drawing.Color.White
        Me.cardpin.BackgroundImage = CType(resources.GetObject("cardpin.BackgroundImage"), System.Drawing.Image)
        Me.cardpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.cardpin, BunifuAnimatorNS.DecorationType.None)
        Me.cardpin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cardpin.Icon = CType(resources.GetObject("cardpin.Icon"), System.Drawing.Image)
        Me.cardpin.Location = New System.Drawing.Point(39, 169)
        Me.cardpin.Name = "cardpin"
        Me.cardpin.Size = New System.Drawing.Size(250, 42)
        Me.cardpin.TabIndex = 22
        Me.cardpin.text = "Pin"
        '
        'cardnumber
        '
        Me.cardnumber.BackColor = System.Drawing.Color.White
        Me.cardnumber.BackgroundImage = CType(resources.GetObject("cardnumber.BackgroundImage"), System.Drawing.Image)
        Me.cardnumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.cardnumber, BunifuAnimatorNS.DecorationType.None)
        Me.cardnumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cardnumber.Icon = CType(resources.GetObject("cardnumber.Icon"), System.Drawing.Image)
        Me.cardnumber.Location = New System.Drawing.Point(39, 111)
        Me.cardnumber.Name = "cardnumber"
        Me.cardnumber.Size = New System.Drawing.Size(250, 42)
        Me.cardnumber.TabIndex = 22
        Me.cardnumber.text = "Credit Card Number"
        '
        'key8
        '
        Me.key8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.key8, BunifuAnimatorNS.DecorationType.None)
        Me.key8.Image = Global.ATM_SYSTEM.My.Resources.Resources.document
        Me.key8.ImageActive = Nothing
        Me.key8.Location = New System.Drawing.Point(57, 295)
        Me.key8.Name = "key8"
        Me.key8.Size = New System.Drawing.Size(205, 175)
        Me.key8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.key8.TabIndex = 23
        Me.key8.TabStop = False
        Me.key8.Zoom = 10
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.key8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents password As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents username As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents type As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents rpassword As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents recovery As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents switch As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents cardpin As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents cardnumber As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents gtext As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents generate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents key8 As Bunifu.Framework.UI.BunifuImageButton
End Class
