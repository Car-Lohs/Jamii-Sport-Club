<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogIn))
        Me.Lblusername = New System.Windows.Forms.Label()
        Me.Lblpassword = New System.Windows.Forms.Label()
        Me.Txtusername = New Guna.UI.WinForms.GunaTextBox()
        Me.Txtpassword = New Guna.UI.WinForms.GunaTextBox()
        Me.Btnlogin = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Lbllogin = New Guna.UI.WinForms.GunaLabel()
        Me.Btncancel = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lblusername
        '
        Me.Lblusername.AutoSize = True
        Me.Lblusername.BackColor = System.Drawing.Color.Transparent
        Me.Lblusername.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblusername.ForeColor = System.Drawing.Color.White
        Me.Lblusername.Location = New System.Drawing.Point(29, 214)
        Me.Lblusername.Name = "Lblusername"
        Me.Lblusername.Size = New System.Drawing.Size(99, 28)
        Me.Lblusername.TabIndex = 0
        Me.Lblusername.Text = "Username"
        '
        'Lblpassword
        '
        Me.Lblpassword.AutoSize = True
        Me.Lblpassword.BackColor = System.Drawing.Color.Transparent
        Me.Lblpassword.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpassword.ForeColor = System.Drawing.Color.White
        Me.Lblpassword.Location = New System.Drawing.Point(35, 269)
        Me.Lblpassword.Name = "Lblpassword"
        Me.Lblpassword.Size = New System.Drawing.Size(93, 28)
        Me.Lblpassword.TabIndex = 1
        Me.Lblpassword.Text = "Password"
        '
        'Txtusername
        '
        Me.Txtusername.BackColor = System.Drawing.Color.Transparent
        Me.Txtusername.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Txtusername.BorderColor = System.Drawing.Color.Black
        Me.Txtusername.BorderSize = 0
        Me.Txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtusername.FocusedBaseColor = System.Drawing.Color.White
        Me.Txtusername.FocusedBorderColor = System.Drawing.Color.Black
        Me.Txtusername.FocusedForeColor = System.Drawing.Color.Black
        Me.Txtusername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Txtusername.ForeColor = System.Drawing.Color.White
        Me.Txtusername.Location = New System.Drawing.Point(139, 214)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txtusername.SelectedText = ""
        Me.Txtusername.Size = New System.Drawing.Size(204, 37)
        Me.Txtusername.TabIndex = 2
        Me.Txtusername.Text = "username"
        '
        'Txtpassword
        '
        Me.Txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.Txtpassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Txtpassword.BorderColor = System.Drawing.Color.Black
        Me.Txtpassword.BorderSize = 0
        Me.Txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.Txtpassword.FocusedBorderColor = System.Drawing.Color.Black
        Me.Txtpassword.FocusedForeColor = System.Drawing.Color.Black
        Me.Txtpassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Txtpassword.ForeColor = System.Drawing.Color.White
        Me.Txtpassword.Location = New System.Drawing.Point(139, 269)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.SelectedText = ""
        Me.Txtpassword.Size = New System.Drawing.Size(204, 36)
        Me.Txtpassword.TabIndex = 3
        Me.Txtpassword.Text = "password"
        '
        'Btnlogin
        '
        Me.Btnlogin.AnimationHoverSpeed = 0.07!
        Me.Btnlogin.AnimationSpeed = 0.03!
        Me.Btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.Btnlogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnlogin.BorderColor = System.Drawing.Color.Black
        Me.Btnlogin.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnlogin.CheckedBorderColor = System.Drawing.Color.Black
        Me.Btnlogin.CheckedForeColor = System.Drawing.Color.White
        Me.Btnlogin.CheckedImage = Nothing
        Me.Btnlogin.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnlogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btnlogin.FocusedColor = System.Drawing.Color.Empty
        Me.Btnlogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btnlogin.ForeColor = System.Drawing.Color.White
        Me.Btnlogin.Image = Nothing
        Me.Btnlogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnlogin.LineColor = System.Drawing.Color.Transparent
        Me.Btnlogin.Location = New System.Drawing.Point(147, 323)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnlogin.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.Btnlogin.OnHoverForeColor = System.Drawing.Color.Black
        Me.Btnlogin.OnHoverImage = Nothing
        Me.Btnlogin.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.Btnlogin.OnPressedColor = System.Drawing.Color.Transparent
        Me.Btnlogin.Radius = 10
        Me.Btnlogin.Size = New System.Drawing.Size(75, 40)
        Me.Btnlogin.TabIndex = 4
        Me.Btnlogin.Text = "Log In"
        Me.Btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 20
        Me.GunaElipse1.TargetControl = Me
        '
        'Lbllogin
        '
        Me.Lbllogin.AutoSize = True
        Me.Lbllogin.BackColor = System.Drawing.Color.Transparent
        Me.Lbllogin.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbllogin.ForeColor = System.Drawing.Color.White
        Me.Lbllogin.Location = New System.Drawing.Point(140, 148)
        Me.Lbllogin.Name = "Lbllogin"
        Me.Lbllogin.Size = New System.Drawing.Size(93, 37)
        Me.Lbllogin.TabIndex = 5
        Me.Lbllogin.Text = "Log In"
        '
        'Btncancel
        '
        Me.Btncancel.AnimationHoverSpeed = 0.07!
        Me.Btncancel.AnimationSpeed = 0.03!
        Me.Btncancel.BackColor = System.Drawing.Color.Transparent
        Me.Btncancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancel.BorderColor = System.Drawing.Color.Black
        Me.Btncancel.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancel.CheckedBorderColor = System.Drawing.Color.Black
        Me.Btncancel.CheckedForeColor = System.Drawing.Color.White
        Me.Btncancel.CheckedImage = Nothing
        Me.Btncancel.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btncancel.FocusedColor = System.Drawing.Color.Empty
        Me.Btncancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btncancel.ForeColor = System.Drawing.Color.White
        Me.Btncancel.Image = Nothing
        Me.Btncancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btncancel.LineColor = System.Drawing.Color.Transparent
        Me.Btncancel.Location = New System.Drawing.Point(253, 323)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancel.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.Btncancel.OnHoverForeColor = System.Drawing.Color.Black
        Me.Btncancel.OnHoverImage = Nothing
        Me.Btncancel.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.Btncancel.OnPressedColor = System.Drawing.Color.Transparent
        Me.Btncancel.Radius = 10
        Me.Btncancel.Size = New System.Drawing.Size(75, 40)
        Me.Btncancel.TabIndex = 6
        Me.Btncancel.Text = "Cancel"
        Me.Btncancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.Jamii_Sport_Club.My.Resources.Resources.Asset_1
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(-20, -15)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(537, 576)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaTransfarantPictureBox1.TabIndex = 8
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.Btncancel)
        Me.GunaGroupBox1.Controls.Add(Me.Lblusername)
        Me.GunaGroupBox1.Controls.Add(Me.Lbllogin)
        Me.GunaGroupBox1.Controls.Add(Me.Lblpassword)
        Me.GunaGroupBox1.Controls.Add(Me.Btnlogin)
        Me.GunaGroupBox1.Controls.Add(Me.Txtusername)
        Me.GunaGroupBox1.Controls.Add(Me.Txtpassword)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.LineTop = 0
        Me.GunaGroupBox1.Location = New System.Drawing.Point(494, -1)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(373, 513)
        Me.GunaGroupBox1.TabIndex = 7
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'FormLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(865, 511)
        Me.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lblusername As System.Windows.Forms.Label
    Friend WithEvents Lblpassword As System.Windows.Forms.Label
    Friend WithEvents Txtusername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Txtpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Btnlogin As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Lbllogin As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Btncancel As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
End Class
