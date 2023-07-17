<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Member
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Member))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.profilepicbox = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnExit = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnaddpic = New Guna.UI.WinForms.GunaCircleButton()
        Me.lblAddmember = New System.Windows.Forms.Label()
        Me.lblMemberid = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblRegfee = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtmemberid = New Guna.UI.WinForms.GunaTextBox()
        Me.txtfullname = New Guna.UI.WinForms.GunaTextBox()
        Me.txtRegfee = New Guna.UI.WinForms.GunaTextBox()
        Me.txtWeight = New Guna.UI.WinForms.GunaTextBox()
        Me.txtHeight = New Guna.UI.WinForms.GunaTextBox()
        Me.txtDatepick = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.drpRole = New ns1.BunifuDropdown()
        Me.drpGender = New ns1.BunifuDropdown()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnBrowse = New Guna.UI.WinForms.GunaButton()
        Me.drpSports = New ns1.BunifuDropdown()
        Me.lblSports = New System.Windows.Forms.Label()
        CType(Me.profilepicbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 50
        Me.GunaElipse1.TargetControl = Me
        '
        'profilepicbox
        '
        Me.profilepicbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.profilepicbox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.profilepicbox.Location = New System.Drawing.Point(46, 61)
        Me.profilepicbox.Name = "profilepicbox"
        Me.profilepicbox.Size = New System.Drawing.Size(150, 150)
        Me.profilepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profilepicbox.TabIndex = 0
        Me.profilepicbox.TabStop = False
        Me.profilepicbox.UseTransfarantBackground = False
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
        Me.btnExit.Location = New System.Drawing.Point(634, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnExit.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnExit.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.OnHoverImage = Nothing
        Me.btnExit.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 7
        '
        'btnaddpic
        '
        Me.btnaddpic.AnimationHoverSpeed = 0.07!
        Me.btnaddpic.AnimationSpeed = 0.03!
        Me.btnaddpic.BackColor = System.Drawing.Color.Transparent
        Me.btnaddpic.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnaddpic.BorderColor = System.Drawing.Color.White
        Me.btnaddpic.BorderSize = 1
        Me.btnaddpic.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnaddpic.FocusedColor = System.Drawing.Color.Empty
        Me.btnaddpic.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnaddpic.ForeColor = System.Drawing.Color.White
        Me.btnaddpic.Image = Nothing
        Me.btnaddpic.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnaddpic.Location = New System.Drawing.Point(176, 191)
        Me.btnaddpic.Name = "btnaddpic"
        Me.btnaddpic.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnaddpic.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnaddpic.OnHoverForeColor = System.Drawing.Color.White
        Me.btnaddpic.OnHoverImage = Nothing
        Me.btnaddpic.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnaddpic.Size = New System.Drawing.Size(20, 20)
        Me.btnaddpic.TabIndex = 8
        Me.btnaddpic.Text = "+"
        '
        'lblAddmember
        '
        Me.lblAddmember.AutoSize = True
        Me.lblAddmember.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddmember.ForeColor = System.Drawing.Color.White
        Me.lblAddmember.Location = New System.Drawing.Point(256, 12)
        Me.lblAddmember.Name = "lblAddmember"
        Me.lblAddmember.Size = New System.Drawing.Size(173, 29)
        Me.lblAddmember.TabIndex = 9
        Me.lblAddmember.Text = "ADD MEMBER"
        '
        'lblMemberid
        '
        Me.lblMemberid.AutoSize = True
        Me.lblMemberid.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberid.ForeColor = System.Drawing.Color.White
        Me.lblMemberid.Location = New System.Drawing.Point(274, 61)
        Me.lblMemberid.Name = "lblMemberid"
        Me.lblMemberid.Size = New System.Drawing.Size(110, 28)
        Me.lblMemberid.TabIndex = 10
        Me.lblMemberid.Text = "Member ID"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.White
        Me.lblFullname.Location = New System.Drawing.Point(284, 98)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(100, 28)
        Me.lblFullname.TabIndex = 11
        Me.lblFullname.Text = "Full Name"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.White
        Me.lblGender.Location = New System.Drawing.Point(308, 135)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(76, 28)
        Me.lblGender.TabIndex = 12
        Me.lblGender.Text = "Gender"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDob.ForeColor = System.Drawing.Color.White
        Me.lblDob.Location = New System.Drawing.Point(259, 172)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(125, 28)
        Me.lblDob.TabIndex = 13
        Me.lblDob.Text = "Date Of Birth"
        '
        'lblRegfee
        '
        Me.lblRegfee.AutoSize = True
        Me.lblRegfee.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegfee.ForeColor = System.Drawing.Color.White
        Me.lblRegfee.Location = New System.Drawing.Point(232, 209)
        Me.lblRegfee.Name = "lblRegfee"
        Me.lblRegfee.Size = New System.Drawing.Size(152, 28)
        Me.lblRegfee.TabIndex = 14
        Me.lblRegfee.Text = "Registration Fee"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(334, 246)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(50, 28)
        Me.lblRole.TabIndex = 15
        Me.lblRole.Text = "Role"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.White
        Me.lblWeight.Location = New System.Drawing.Point(309, 283)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(75, 28)
        Me.lblWeight.TabIndex = 16
        Me.lblWeight.Text = "Weight"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.ForeColor = System.Drawing.Color.White
        Me.lblHeight.Location = New System.Drawing.Point(313, 320)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(71, 28)
        Me.lblHeight.TabIndex = 17
        Me.lblHeight.Text = "Height"
        '
        'txtmemberid
        '
        Me.txtmemberid.BackColor = System.Drawing.Color.Transparent
        Me.txtmemberid.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtmemberid.BorderColor = System.Drawing.Color.White
        Me.txtmemberid.BorderSize = 1
        Me.txtmemberid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmemberid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtmemberid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtmemberid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtmemberid.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtmemberid.Location = New System.Drawing.Point(390, 61)
        Me.txtmemberid.Name = "txtmemberid"
        Me.txtmemberid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemberid.Radius = 10
        Me.txtmemberid.SelectedText = ""
        Me.txtmemberid.Size = New System.Drawing.Size(239, 34)
        Me.txtmemberid.TabIndex = 18
        '
        'txtfullname
        '
        Me.txtfullname.BackColor = System.Drawing.Color.Transparent
        Me.txtfullname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtfullname.BorderColor = System.Drawing.Color.White
        Me.txtfullname.BorderSize = 1
        Me.txtfullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfullname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtfullname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtfullname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtfullname.Location = New System.Drawing.Point(390, 98)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfullname.Radius = 10
        Me.txtfullname.SelectedText = ""
        Me.txtfullname.Size = New System.Drawing.Size(239, 34)
        Me.txtfullname.TabIndex = 19
        '
        'txtRegfee
        '
        Me.txtRegfee.BackColor = System.Drawing.Color.Transparent
        Me.txtRegfee.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtRegfee.BorderColor = System.Drawing.Color.White
        Me.txtRegfee.BorderSize = 1
        Me.txtRegfee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegfee.FocusedBaseColor = System.Drawing.Color.White
        Me.txtRegfee.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtRegfee.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtRegfee.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtRegfee.Location = New System.Drawing.Point(390, 205)
        Me.txtRegfee.Name = "txtRegfee"
        Me.txtRegfee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegfee.Radius = 10
        Me.txtRegfee.SelectedText = ""
        Me.txtRegfee.Size = New System.Drawing.Size(239, 34)
        Me.txtRegfee.TabIndex = 20
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.Transparent
        Me.txtWeight.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtWeight.BorderColor = System.Drawing.Color.White
        Me.txtWeight.BorderSize = 1
        Me.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWeight.FocusedBaseColor = System.Drawing.Color.White
        Me.txtWeight.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtWeight.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtWeight.Location = New System.Drawing.Point(390, 279)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWeight.Radius = 10
        Me.txtWeight.SelectedText = ""
        Me.txtWeight.Size = New System.Drawing.Size(239, 34)
        Me.txtWeight.TabIndex = 22
        '
        'txtHeight
        '
        Me.txtHeight.BackColor = System.Drawing.Color.Transparent
        Me.txtHeight.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtHeight.BorderColor = System.Drawing.Color.White
        Me.txtHeight.BorderSize = 1
        Me.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeight.FocusedBaseColor = System.Drawing.Color.White
        Me.txtHeight.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtHeight.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtHeight.Location = New System.Drawing.Point(390, 316)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHeight.Radius = 10
        Me.txtHeight.SelectedText = ""
        Me.txtHeight.Size = New System.Drawing.Size(239, 34)
        Me.txtHeight.TabIndex = 23
        '
        'txtDatepick
        '
        Me.txtDatepick.BackColor = System.Drawing.Color.Transparent
        Me.txtDatepick.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDatepick.BorderColor = System.Drawing.Color.White
        Me.txtDatepick.BorderSize = 1
        Me.txtDatepick.CustomFormat = Nothing
        Me.txtDatepick.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtDatepick.FocusedColor = System.Drawing.Color.White
        Me.txtDatepick.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtDatepick.ForeColor = System.Drawing.Color.Black
        Me.txtDatepick.Location = New System.Drawing.Point(390, 172)
        Me.txtDatepick.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDatepick.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtDatepick.Name = "txtDatepick"
        Me.txtDatepick.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDatepick.OnHoverBorderColor = System.Drawing.Color.White
        Me.txtDatepick.OnHoverForeColor = System.Drawing.Color.Black
        Me.txtDatepick.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDatepick.Radius = 10
        Me.txtDatepick.Size = New System.Drawing.Size(239, 30)
        Me.txtDatepick.TabIndex = 25
        Me.txtDatepick.Text = "Saturday, July 15, 2023"
        Me.txtDatepick.Value = New Date(2023, 7, 15, 19, 23, 48, 573)
        '
        'drpRole
        '
        Me.drpRole.BackColor = System.Drawing.Color.Transparent
        Me.drpRole.BorderRadius = 20
        Me.drpRole.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpRole.ForeColor = System.Drawing.Color.Black
        Me.drpRole.Items = New String() {"Player", "Captain"}
        Me.drpRole.Location = New System.Drawing.Point(390, 242)
        Me.drpRole.Margin = New System.Windows.Forms.Padding(5)
        Me.drpRole.Name = "drpRole"
        Me.drpRole.NomalColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpRole.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpRole.selectedIndex = -1
        Me.drpRole.Size = New System.Drawing.Size(239, 34)
        Me.drpRole.TabIndex = 26
        '
        'drpGender
        '
        Me.drpGender.BackColor = System.Drawing.Color.Transparent
        Me.drpGender.BorderRadius = 20
        Me.drpGender.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpGender.ForeColor = System.Drawing.Color.Black
        Me.drpGender.Items = New String() {"Male", "Female"}
        Me.drpGender.Location = New System.Drawing.Point(390, 135)
        Me.drpGender.Margin = New System.Windows.Forms.Padding(5)
        Me.drpGender.Name = "drpGender"
        Me.drpGender.NomalColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpGender.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpGender.selectedIndex = -1
        Me.drpGender.Size = New System.Drawing.Size(239, 34)
        Me.drpGender.TabIndex = 27
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
        Me.btnAdd.Location = New System.Drawing.Point(27, 283)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Radius = 10
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnSave.Location = New System.Drawing.Point(138, 283)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnClear.Location = New System.Drawing.Point(27, 320)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Radius = 10
        Me.btnClear.Size = New System.Drawing.Size(105, 30)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnBrowse.Location = New System.Drawing.Point(138, 320)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverImage = Nothing
        Me.btnBrowse.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.Radius = 10
        Me.btnBrowse.Size = New System.Drawing.Size(105, 30)
        Me.btnBrowse.TabIndex = 31
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'drpSports
        '
        Me.drpSports.BackColor = System.Drawing.Color.Transparent
        Me.drpSports.BorderRadius = 20
        Me.drpSports.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpSports.ForeColor = System.Drawing.Color.Black
        Me.drpSports.Items = New String() {"swimming", "hockey", "lawn tennis", "volleyball", "basketball", "football", "baseball", "rugby", "chess", "draft"}
        Me.drpSports.Location = New System.Drawing.Point(390, 353)
        Me.drpSports.Margin = New System.Windows.Forms.Padding(5)
        Me.drpSports.Name = "drpSports"
        Me.drpSports.NomalColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpSports.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpSports.selectedIndex = -1
        Me.drpSports.Size = New System.Drawing.Size(239, 34)
        Me.drpSports.TabIndex = 33
        '
        'lblSports
        '
        Me.lblSports.AutoSize = True
        Me.lblSports.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSports.ForeColor = System.Drawing.Color.White
        Me.lblSports.Location = New System.Drawing.Point(303, 358)
        Me.lblSports.Name = "lblSports"
        Me.lblSports.Size = New System.Drawing.Size(81, 28)
        Me.lblSports.TabIndex = 34
        Me.lblSports.Text = "Sport(s)"
        '
        'Add_Member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 422)
        Me.Controls.Add(Me.lblSports)
        Me.Controls.Add(Me.drpSports)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.drpGender)
        Me.Controls.Add(Me.drpRole)
        Me.Controls.Add(Me.txtDatepick)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtRegfee)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.txtmemberid)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblRegfee)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.lblMemberid)
        Me.Controls.Add(Me.lblAddmember)
        Me.Controls.Add(Me.btnaddpic)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.profilepicbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Add_Member"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Member"
        CType(Me.profilepicbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents profilepicbox As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnExit As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnaddpic As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lblAddmember As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents lblRegfee As System.Windows.Forms.Label
    Friend WithEvents lblDob As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents lblMemberid As System.Windows.Forms.Label
    Friend WithEvents txtDatepick As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents txtHeight As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtWeight As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtRegfee As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtfullname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtmemberid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents drpRole As ns1.BunifuDropdown
    Friend WithEvents drpGender As ns1.BunifuDropdown
    Friend WithEvents btnBrowse As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblSports As System.Windows.Forms.Label
    Friend WithEvents drpSports As ns1.BunifuDropdown
End Class
