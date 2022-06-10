<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class normal_user_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(normal_user_form))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.gtext = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.generate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cardpin = New Bunifu.Framework.UI.BunifuTextbox()
        Me.cardnumber = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.gtext)
        Me.BunifuGradientPanel1.Controls.Add(Me.generate)
        Me.BunifuGradientPanel1.Controls.Add(Me.cardpin)
        Me.BunifuGradientPanel1.Controls.Add(Me.cardnumber)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SlateBlue
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Linen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Fuchsia
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(339, 302)
        Me.BunifuGradientPanel1.TabIndex = 7
        '
        'gtext
        '
        Me.gtext.AutoSize = True
        Me.gtext.BackColor = System.Drawing.Color.Transparent
        Me.gtext.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtext.ForeColor = System.Drawing.Color.White
        Me.gtext.Location = New System.Drawing.Point(29, 78)
        Me.gtext.Name = "gtext"
        Me.gtext.Size = New System.Drawing.Size(289, 19)
        Me.gtext.TabIndex = 25
        Me.gtext.Text = "Please enter your Credit Card Information"
        '
        'generate
        '
        Me.generate.Activecolor = System.Drawing.Color.SkyBlue
        Me.generate.BackColor = System.Drawing.Color.SkyBlue
        Me.generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.generate.BorderRadius = 7
        Me.generate.ButtonText = "Enter"
        Me.generate.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.generate.Location = New System.Drawing.Point(154, 224)
        Me.generate.Name = "generate"
        Me.generate.Normalcolor = System.Drawing.Color.SkyBlue
        Me.generate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.generate.OnHoverTextColor = System.Drawing.Color.Black
        Me.generate.selected = False
        Me.generate.Size = New System.Drawing.Size(140, 36)
        Me.generate.TabIndex = 26
        Me.generate.Text = "Enter"
        Me.generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.generate.Textcolor = System.Drawing.Color.Black
        Me.generate.TextFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cardpin
        '
        Me.cardpin.BackColor = System.Drawing.Color.White
        Me.cardpin.BackgroundImage = CType(resources.GetObject("cardpin.BackgroundImage"), System.Drawing.Image)
        Me.cardpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cardpin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cardpin.Icon = CType(resources.GetObject("cardpin.Icon"), System.Drawing.Image)
        Me.cardpin.Location = New System.Drawing.Point(44, 164)
        Me.cardpin.Name = "cardpin"
        Me.cardpin.Size = New System.Drawing.Size(250, 42)
        Me.cardpin.TabIndex = 23
        Me.cardpin.text = "Pin"
        '
        'cardnumber
        '
        Me.cardnumber.BackColor = System.Drawing.Color.White
        Me.cardnumber.BackgroundImage = CType(resources.GetObject("cardnumber.BackgroundImage"), System.Drawing.Image)
        Me.cardnumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cardnumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cardnumber.Icon = CType(resources.GetObject("cardnumber.Icon"), System.Drawing.Image)
        Me.cardnumber.Location = New System.Drawing.Point(44, 106)
        Me.cardnumber.Name = "cardnumber"
        Me.cardnumber.Size = New System.Drawing.Size(250, 42)
        Me.cardnumber.TabIndex = 24
        Me.cardnumber.text = "Credit Card Number"
        '
        'normal_user_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 302)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "normal_user_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents gtext As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents generate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cardpin As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents cardnumber As Bunifu.Framework.UI.BunifuTextbox
End Class
