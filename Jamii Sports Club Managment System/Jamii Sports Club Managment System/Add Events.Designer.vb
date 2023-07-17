<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Events
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Events))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblAddevent = New System.Windows.Forms.Label()
        Me.txtCaptain = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPatron = New Guna.UI.WinForms.GunaTextBox()
        Me.lblCaptain = New System.Windows.Forms.Label()
        Me.lblPatron = New System.Windows.Forms.Label()
        Me.txtgame = New Guna.UI.WinForms.GunaTextBox()
        Me.txtEventid = New Guna.UI.WinForms.GunaTextBox()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.lblEventid = New System.Windows.Forms.Label()
        Me.btnExit = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnBrowse = New Guna.UI.WinForms.GunaButton()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblFacilitationee = New System.Windows.Forms.Label()
        Me.txtDate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.txtFacilitationfee = New Guna.UI.WinForms.GunaTextBox()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 50
        Me.GunaElipse1.TargetControl = Me
        '
        'lblAddevent
        '
        Me.lblAddevent.AutoSize = True
        Me.lblAddevent.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddevent.ForeColor = System.Drawing.Color.White
        Me.lblAddevent.Location = New System.Drawing.Point(252, 9)
        Me.lblAddevent.Name = "lblAddevent"
        Me.lblAddevent.Size = New System.Drawing.Size(165, 29)
        Me.lblAddevent.TabIndex = 59
        Me.lblAddevent.Text = "ADD EVENTS"
        '
        'txtCaptain
        '
        Me.txtCaptain.BackColor = System.Drawing.Color.Transparent
        Me.txtCaptain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtCaptain.BorderColor = System.Drawing.Color.White
        Me.txtCaptain.BorderSize = 1
        Me.txtCaptain.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCaptain.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCaptain.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtCaptain.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCaptain.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtCaptain.Location = New System.Drawing.Point(386, 193)
        Me.txtCaptain.Name = "txtCaptain"
        Me.txtCaptain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCaptain.Radius = 10
        Me.txtCaptain.SelectedText = ""
        Me.txtCaptain.Size = New System.Drawing.Size(239, 34)
        Me.txtCaptain.TabIndex = 58
        '
        'txtPatron
        '
        Me.txtPatron.BackColor = System.Drawing.Color.Transparent
        Me.txtPatron.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtPatron.BorderColor = System.Drawing.Color.White
        Me.txtPatron.BorderSize = 1
        Me.txtPatron.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPatron.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPatron.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPatron.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPatron.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtPatron.Location = New System.Drawing.Point(386, 153)
        Me.txtPatron.Name = "txtPatron"
        Me.txtPatron.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatron.Radius = 10
        Me.txtPatron.SelectedText = ""
        Me.txtPatron.Size = New System.Drawing.Size(239, 34)
        Me.txtPatron.TabIndex = 57
        '
        'lblCaptain
        '
        Me.lblCaptain.AutoSize = True
        Me.lblCaptain.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptain.ForeColor = System.Drawing.Color.White
        Me.lblCaptain.Location = New System.Drawing.Point(306, 199)
        Me.lblCaptain.Name = "lblCaptain"
        Me.lblCaptain.Size = New System.Drawing.Size(79, 28)
        Me.lblCaptain.TabIndex = 56
        Me.lblCaptain.Text = "Captain"
        '
        'lblPatron
        '
        Me.lblPatron.AutoSize = True
        Me.lblPatron.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatron.ForeColor = System.Drawing.Color.White
        Me.lblPatron.Location = New System.Drawing.Point(316, 159)
        Me.lblPatron.Name = "lblPatron"
        Me.lblPatron.Size = New System.Drawing.Size(69, 28)
        Me.lblPatron.TabIndex = 55
        Me.lblPatron.Text = "Patron"
        '
        'txtgame
        '
        Me.txtgame.BackColor = System.Drawing.Color.Transparent
        Me.txtgame.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtgame.BorderColor = System.Drawing.Color.White
        Me.txtgame.BorderSize = 1
        Me.txtgame.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtgame.FocusedBaseColor = System.Drawing.Color.White
        Me.txtgame.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtgame.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtgame.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtgame.Location = New System.Drawing.Point(385, 113)
        Me.txtgame.Name = "txtgame"
        Me.txtgame.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtgame.Radius = 10
        Me.txtgame.SelectedText = ""
        Me.txtgame.Size = New System.Drawing.Size(239, 34)
        Me.txtgame.TabIndex = 54
        '
        'txtEventid
        '
        Me.txtEventid.BackColor = System.Drawing.Color.Transparent
        Me.txtEventid.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtEventid.BorderColor = System.Drawing.Color.White
        Me.txtEventid.BorderSize = 1
        Me.txtEventid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEventid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEventid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtEventid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEventid.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtEventid.Location = New System.Drawing.Point(385, 73)
        Me.txtEventid.Name = "txtEventid"
        Me.txtEventid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEventid.Radius = 10
        Me.txtEventid.SelectedText = ""
        Me.txtEventid.Size = New System.Drawing.Size(239, 34)
        Me.txtEventid.TabIndex = 53
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.ForeColor = System.Drawing.Color.White
        Me.lblGame.Location = New System.Drawing.Point(322, 119)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(63, 28)
        Me.lblGame.TabIndex = 52
        Me.lblGame.Text = "Game"
        '
        'lblEventid
        '
        Me.lblEventid.AutoSize = True
        Me.lblEventid.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventid.ForeColor = System.Drawing.Color.White
        Me.lblEventid.Location = New System.Drawing.Point(301, 79)
        Me.lblEventid.Name = "lblEventid"
        Me.lblEventid.Size = New System.Drawing.Size(84, 28)
        Me.lblEventid.TabIndex = 51
        Me.lblEventid.Text = "Event ID"
        '
        'btnExit
        '
        Me.btnExit.AnimationHoverSpeed = 0.07!
        Me.btnExit.AnimationSpeed = 0.03!
        Me.btnExit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnExit.BorderColor = System.Drawing.Color.White
        Me.btnExit.BorderSize = 1
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExit.FocusedColor = System.Drawing.Color.Empty
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnExit.Location = New System.Drawing.Point(624, 24)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnExit.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnExit.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.OnHoverImage = Nothing
        Me.btnExit.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 50
        Me.btnExit.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'btnBrowse
        '
        Me.btnBrowse.AnimationHoverSpeed = 0.07!
        Me.btnBrowse.AnimationSpeed = 0.03!
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.BorderColor = System.Drawing.Color.White
        Me.btnBrowse.BorderSize = 1
        Me.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBrowse.FocusedColor = System.Drawing.Color.Empty
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Image = Nothing
        Me.btnBrowse.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBrowse.Location = New System.Drawing.Point(136, 218)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverImage = Nothing
        Me.btnBrowse.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.Radius = 10
        Me.btnBrowse.Size = New System.Drawing.Size(105, 30)
        Me.btnBrowse.TabIndex = 49
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.BorderColor = System.Drawing.Color.White
        Me.btnClear.BorderSize = 1
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Nothing
        Me.btnClear.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClear.Location = New System.Drawing.Point(25, 218)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Radius = 10
        Me.btnClear.Size = New System.Drawing.Size(105, 30)
        Me.btnClear.TabIndex = 48
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave
        '
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.BorderColor = System.Drawing.Color.White
        Me.btnSave.BorderSize = 1
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Nothing
        Me.btnSave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSave.Location = New System.Drawing.Point(136, 181)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 47
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
        Me.btnAdd.AnimationHoverSpeed = 0.07!
        Me.btnAdd.AnimationSpeed = 0.03!
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.BorderColor = System.Drawing.Color.White
        Me.btnAdd.BorderSize = 1
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdd.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Nothing
        Me.btnAdd.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAdd.Location = New System.Drawing.Point(25, 181)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Radius = 10
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 46
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(332, 235)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 28)
        Me.lblDate.TabIndex = 60
        Me.lblDate.Text = "Date"
        '
        'lblFacilitationee
        '
        Me.lblFacilitationee.AutoSize = True
        Me.lblFacilitationee.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacilitationee.ForeColor = System.Drawing.Color.White
        Me.lblFacilitationee.Location = New System.Drawing.Point(243, 275)
        Me.lblFacilitationee.Name = "lblFacilitationee"
        Me.lblFacilitationee.Size = New System.Drawing.Size(142, 28)
        Me.lblFacilitationee.TabIndex = 61
        Me.lblFacilitationee.Text = "Facilitation Fee"
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDate.BorderColor = System.Drawing.Color.White
        Me.txtDate.BorderSize = 1
        Me.txtDate.CustomFormat = Nothing
        Me.txtDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtDate.FocusedColor = System.Drawing.Color.White
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtDate.ForeColor = System.Drawing.Color.Black
        Me.txtDate.Location = New System.Drawing.Point(386, 233)
        Me.txtDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDate.OnHoverBorderColor = System.Drawing.Color.White
        Me.txtDate.OnHoverForeColor = System.Drawing.Color.Black
        Me.txtDate.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDate.Radius = 10
        Me.txtDate.Size = New System.Drawing.Size(239, 30)
        Me.txtDate.TabIndex = 62
        Me.txtDate.Text = "Saturday, July 15, 2023"
        Me.txtDate.Value = New Date(2023, 7, 15, 19, 23, 48, 573)
        '
        'txtFacilitationfee
        '
        Me.txtFacilitationfee.BackColor = System.Drawing.Color.Transparent
        Me.txtFacilitationfee.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtFacilitationfee.BorderColor = System.Drawing.Color.White
        Me.txtFacilitationfee.BorderSize = 1
        Me.txtFacilitationfee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFacilitationfee.FocusedBaseColor = System.Drawing.Color.White
        Me.txtFacilitationfee.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtFacilitationfee.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFacilitationfee.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtFacilitationfee.Location = New System.Drawing.Point(386, 269)
        Me.txtFacilitationfee.Name = "txtFacilitationfee"
        Me.txtFacilitationfee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFacilitationfee.Radius = 10
        Me.txtFacilitationfee.SelectedText = ""
        Me.txtFacilitationfee.Size = New System.Drawing.Size(239, 34)
        Me.txtFacilitationfee.TabIndex = 63
        '
        'Add_Events
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 338)
        Me.Controls.Add(Me.txtFacilitationfee)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblFacilitationee)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAddevent)
        Me.Controls.Add(Me.txtCaptain)
        Me.Controls.Add(Me.txtPatron)
        Me.Controls.Add(Me.lblCaptain)
        Me.Controls.Add(Me.lblPatron)
        Me.Controls.Add(Me.txtgame)
        Me.Controls.Add(Me.txtEventid)
        Me.Controls.Add(Me.lblGame)
        Me.Controls.Add(Me.lblEventid)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Add_Events"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Events"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblAddevent As System.Windows.Forms.Label
    Friend WithEvents txtCaptain As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtPatron As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblCaptain As System.Windows.Forms.Label
    Friend WithEvents lblPatron As System.Windows.Forms.Label
    Friend WithEvents txtgame As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtEventid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents lblEventid As System.Windows.Forms.Label
    Friend WithEvents btnExit As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnBrowse As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblFacilitationee As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtFacilitationfee As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtDate As Guna.UI.WinForms.GunaDateTimePicker
End Class
