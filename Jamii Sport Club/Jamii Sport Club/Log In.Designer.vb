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
        Me.SuspendLayout()
        '
        'Lblusername
        '
        Me.Lblusername.AutoSize = True
        Me.Lblusername.BackColor = System.Drawing.Color.Transparent
        Me.Lblusername.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblusername.Location = New System.Drawing.Point(50, 86)
        Me.Lblusername.Name = "Lblusername"
        Me.Lblusername.Size = New System.Drawing.Size(104, 28)
        Me.Lblusername.TabIndex = 0
        Me.Lblusername.Text = "Username"
        '
        'Lblpassword
        '
        Me.Lblpassword.AutoSize = True
        Me.Lblpassword.BackColor = System.Drawing.Color.Transparent
        Me.Lblpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpassword.Location = New System.Drawing.Point(57, 141)
        Me.Lblpassword.Name = "Lblpassword"
        Me.Lblpassword.Size = New System.Drawing.Size(97, 28)
        Me.Lblpassword.TabIndex = 1
        Me.Lblpassword.Text = "Password"
        '
        'Txtusername
        '
        Me.Txtusername.BackColor = System.Drawing.Color.Transparent
        Me.Txtusername.BaseColor = System.Drawing.Color.White
        Me.Txtusername.BorderColor = System.Drawing.Color.Black
        Me.Txtusername.BorderSize = 1
        Me.Txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtusername.FocusedBaseColor = System.Drawing.Color.White
        Me.Txtusername.FocusedBorderColor = System.Drawing.Color.Black
        Me.Txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Txtusername.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Txtusername.Location = New System.Drawing.Point(160, 86)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txtusername.Radius = 10
        Me.Txtusername.SelectedText = ""
        Me.Txtusername.Size = New System.Drawing.Size(204, 37)
        Me.Txtusername.TabIndex = 2
        '
        'Txtpassword
        '
        Me.Txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.Txtpassword.BaseColor = System.Drawing.Color.White
        Me.Txtpassword.BorderColor = System.Drawing.Color.Black
        Me.Txtpassword.BorderSize = 1
        Me.Txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtpassword.FocusedBaseColor = System.Drawing.Color.White
        Me.Txtpassword.FocusedBorderColor = System.Drawing.Color.Black
        Me.Txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Txtpassword.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Txtpassword.Location = New System.Drawing.Point(160, 141)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Radius = 10
        Me.Txtpassword.SelectedText = ""
        Me.Txtpassword.Size = New System.Drawing.Size(204, 36)
        Me.Txtpassword.TabIndex = 3
        '
        'Btnlogin
        '
        Me.Btnlogin.AnimationHoverSpeed = 0.07!
        Me.Btnlogin.AnimationSpeed = 0.03!
        Me.Btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.Btnlogin.BaseColor = System.Drawing.Color.DodgerBlue
        Me.Btnlogin.BorderColor = System.Drawing.Color.Black
        Me.Btnlogin.BorderSize = 1
        Me.Btnlogin.CheckedBaseColor = System.Drawing.Color.DodgerBlue
        Me.Btnlogin.CheckedBorderColor = System.Drawing.Color.Black
        Me.Btnlogin.CheckedForeColor = System.Drawing.Color.White
        Me.Btnlogin.CheckedImage = Nothing
        Me.Btnlogin.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnlogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btnlogin.FocusedColor = System.Drawing.Color.Empty
        Me.Btnlogin.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Btnlogin.ForeColor = System.Drawing.Color.Black
        Me.Btnlogin.Image = Nothing
        Me.Btnlogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btnlogin.LineColor = System.Drawing.Color.Transparent
        Me.Btnlogin.Location = New System.Drawing.Point(160, 196)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.Btnlogin.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.Btnlogin.OnHoverForeColor = System.Drawing.Color.Black
        Me.Btnlogin.OnHoverImage = Nothing
        Me.Btnlogin.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.Btnlogin.OnPressedColor = System.Drawing.Color.Transparent
        Me.Btnlogin.Radius = 18
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
        Me.Lbllogin.Location = New System.Drawing.Point(161, 20)
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
        Me.Btncancel.BaseColor = System.Drawing.Color.Red
        Me.Btncancel.BorderColor = System.Drawing.Color.Black
        Me.Btncancel.BorderSize = 1
        Me.Btncancel.CheckedBaseColor = System.Drawing.Color.DodgerBlue
        Me.Btncancel.CheckedBorderColor = System.Drawing.Color.Black
        Me.Btncancel.CheckedForeColor = System.Drawing.Color.White
        Me.Btncancel.CheckedImage = Nothing
        Me.Btncancel.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btncancel.FocusedColor = System.Drawing.Color.Empty
        Me.Btncancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Btncancel.ForeColor = System.Drawing.Color.Black
        Me.Btncancel.Image = Nothing
        Me.Btncancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btncancel.LineColor = System.Drawing.Color.Transparent
        Me.Btncancel.Location = New System.Drawing.Point(252, 196)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.Btncancel.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.Btncancel.OnHoverForeColor = System.Drawing.Color.Black
        Me.Btncancel.OnHoverImage = Nothing
        Me.Btncancel.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.Btncancel.OnPressedColor = System.Drawing.Color.Transparent
        Me.Btncancel.Radius = 18
        Me.Btncancel.Size = New System.Drawing.Size(75, 40)
        Me.Btncancel.TabIndex = 6
        Me.Btncancel.Text = "Cancel"
        Me.Btncancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(415, 263)
        Me.Controls.Add(Me.Btncancel)
        Me.Controls.Add(Me.Lbllogin)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.Txtusername)
        Me.Controls.Add(Me.Lblpassword)
        Me.Controls.Add(Me.Lblusername)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblusername As System.Windows.Forms.Label
    Friend WithEvents Lblpassword As System.Windows.Forms.Label
    Friend WithEvents Txtusername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Txtpassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Btnlogin As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Lbllogin As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Btncancel As Guna.UI.WinForms.GunaAdvenceButton
End Class
