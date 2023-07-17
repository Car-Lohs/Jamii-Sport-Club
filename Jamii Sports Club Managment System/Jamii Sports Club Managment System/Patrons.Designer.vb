<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patrons
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patrons))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.drpGender = New ns1.BunifuDropdown()
        Me.drpRole = New ns1.BunifuDropdown()
        Me.txtDateofbirth = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.txtRegfee = New Guna.UI.WinForms.GunaTextBox()
        Me.txtfullname = New Guna.UI.WinForms.GunaTextBox()
        Me.txtmemberid = New Guna.UI.WinForms.GunaTextBox()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.lblRegfee = New System.Windows.Forms.Label()
        Me.lblDateofbirth = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnFullname = New System.Windows.Forms.Label()
        Me.lblPatronId = New System.Windows.Forms.Label()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.profilePicbox = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblPatron = New System.Windows.Forms.Label()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMinimize = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnMaximize = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnExit = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnPrevious = New Guna.UI.WinForms.GunaButton()
        Me.btnNext = New Guna.UI.WinForms.GunaButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.profilePicbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 50
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.btnPrevious)
        Me.GunaElipsePanel1.Controls.Add(Me.btnNext)
        Me.GunaElipsePanel1.Controls.Add(Me.btnDelete)
        Me.GunaElipsePanel1.Controls.Add(Me.btnClear)
        Me.GunaElipsePanel1.Controls.Add(Me.btnSave)
        Me.GunaElipsePanel1.Controls.Add(Me.btnAdd)
        Me.GunaElipsePanel1.Controls.Add(Me.drpGender)
        Me.GunaElipsePanel1.Controls.Add(Me.drpRole)
        Me.GunaElipsePanel1.Controls.Add(Me.txtDateofbirth)
        Me.GunaElipsePanel1.Controls.Add(Me.txtRegfee)
        Me.GunaElipsePanel1.Controls.Add(Me.txtfullname)
        Me.GunaElipsePanel1.Controls.Add(Me.txtmemberid)
        Me.GunaElipsePanel1.Controls.Add(Me.lblGame)
        Me.GunaElipsePanel1.Controls.Add(Me.lblRegfee)
        Me.GunaElipsePanel1.Controls.Add(Me.lblDateofbirth)
        Me.GunaElipsePanel1.Controls.Add(Me.lblGender)
        Me.GunaElipsePanel1.Controls.Add(Me.btnFullname)
        Me.GunaElipsePanel1.Controls.Add(Me.lblPatronId)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaCircleButton2)
        Me.GunaElipsePanel1.Controls.Add(Me.profilePicbox)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(85, 54)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 20
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(668, 299)
        Me.GunaElipsePanel1.TabIndex = 0
        '
        'drpGender
        '
        Me.drpGender.BackColor = System.Drawing.Color.Transparent
        Me.drpGender.BorderRadius = 20
        Me.drpGender.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpGender.ForeColor = System.Drawing.Color.Black
        Me.drpGender.Items = New String() {"Male", "Female"}
        Me.drpGender.Location = New System.Drawing.Point(409, 84)
        Me.drpGender.Margin = New System.Windows.Forms.Padding(5)
        Me.drpGender.Name = "drpGender"
        Me.drpGender.NomalColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpGender.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpGender.selectedIndex = -1
        Me.drpGender.Size = New System.Drawing.Size(239, 34)
        Me.drpGender.TabIndex = 73
        '
        'drpRole
        '
        Me.drpRole.BackColor = System.Drawing.Color.Transparent
        Me.drpRole.BorderRadius = 20
        Me.drpRole.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpRole.ForeColor = System.Drawing.Color.Black
        Me.drpRole.Items = New String() {"Player", "Captain"}
        Me.drpRole.Location = New System.Drawing.Point(409, 191)
        Me.drpRole.Margin = New System.Windows.Forms.Padding(5)
        Me.drpRole.Name = "drpRole"
        Me.drpRole.NomalColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpRole.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpRole.selectedIndex = -1
        Me.drpRole.Size = New System.Drawing.Size(239, 34)
        Me.drpRole.TabIndex = 72
        '
        'txtDateofbirth
        '
        Me.txtDateofbirth.BackColor = System.Drawing.Color.Transparent
        Me.txtDateofbirth.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDateofbirth.BorderColor = System.Drawing.Color.White
        Me.txtDateofbirth.BorderSize = 1
        Me.txtDateofbirth.CustomFormat = Nothing
        Me.txtDateofbirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtDateofbirth.FocusedColor = System.Drawing.Color.White
        Me.txtDateofbirth.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtDateofbirth.ForeColor = System.Drawing.Color.Black
        Me.txtDateofbirth.Location = New System.Drawing.Point(409, 121)
        Me.txtDateofbirth.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDateofbirth.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtDateofbirth.Name = "txtDateofbirth"
        Me.txtDateofbirth.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDateofbirth.OnHoverBorderColor = System.Drawing.Color.White
        Me.txtDateofbirth.OnHoverForeColor = System.Drawing.Color.Black
        Me.txtDateofbirth.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDateofbirth.Radius = 10
        Me.txtDateofbirth.Size = New System.Drawing.Size(239, 30)
        Me.txtDateofbirth.TabIndex = 71
        Me.txtDateofbirth.Text = "Saturday, July 15, 2023"
        Me.txtDateofbirth.Value = New Date(2023, 7, 15, 19, 23, 48, 573)
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
        Me.txtRegfee.Location = New System.Drawing.Point(409, 154)
        Me.txtRegfee.Name = "txtRegfee"
        Me.txtRegfee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegfee.Radius = 10
        Me.txtRegfee.SelectedText = ""
        Me.txtRegfee.Size = New System.Drawing.Size(239, 34)
        Me.txtRegfee.TabIndex = 70
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
        Me.txtfullname.Location = New System.Drawing.Point(409, 47)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfullname.Radius = 10
        Me.txtfullname.SelectedText = ""
        Me.txtfullname.Size = New System.Drawing.Size(239, 34)
        Me.txtfullname.TabIndex = 69
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
        Me.txtmemberid.Location = New System.Drawing.Point(409, 10)
        Me.txtmemberid.Name = "txtmemberid"
        Me.txtmemberid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemberid.Radius = 10
        Me.txtmemberid.SelectedText = ""
        Me.txtmemberid.Size = New System.Drawing.Size(239, 34)
        Me.txtmemberid.TabIndex = 68
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.ForeColor = System.Drawing.Color.White
        Me.lblGame.Location = New System.Drawing.Point(340, 195)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(63, 28)
        Me.lblGame.TabIndex = 67
        Me.lblGame.Text = "Game"
        '
        'lblRegfee
        '
        Me.lblRegfee.AutoSize = True
        Me.lblRegfee.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegfee.ForeColor = System.Drawing.Color.White
        Me.lblRegfee.Location = New System.Drawing.Point(251, 158)
        Me.lblRegfee.Name = "lblRegfee"
        Me.lblRegfee.Size = New System.Drawing.Size(152, 28)
        Me.lblRegfee.TabIndex = 66
        Me.lblRegfee.Text = "Registration Fee"
        '
        'lblDateofbirth
        '
        Me.lblDateofbirth.AutoSize = True
        Me.lblDateofbirth.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateofbirth.ForeColor = System.Drawing.Color.White
        Me.lblDateofbirth.Location = New System.Drawing.Point(278, 121)
        Me.lblDateofbirth.Name = "lblDateofbirth"
        Me.lblDateofbirth.Size = New System.Drawing.Size(125, 28)
        Me.lblDateofbirth.TabIndex = 65
        Me.lblDateofbirth.Text = "Date Of Birth"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.White
        Me.lblGender.Location = New System.Drawing.Point(327, 84)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(76, 28)
        Me.lblGender.TabIndex = 64
        Me.lblGender.Text = "Gender"
        '
        'btnFullname
        '
        Me.btnFullname.AutoSize = True
        Me.btnFullname.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullname.ForeColor = System.Drawing.Color.White
        Me.btnFullname.Location = New System.Drawing.Point(303, 47)
        Me.btnFullname.Name = "btnFullname"
        Me.btnFullname.Size = New System.Drawing.Size(100, 28)
        Me.btnFullname.TabIndex = 63
        Me.btnFullname.Text = "Full Name"
        '
        'lblPatronId
        '
        Me.lblPatronId.AutoSize = True
        Me.lblPatronId.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatronId.ForeColor = System.Drawing.Color.White
        Me.lblPatronId.Location = New System.Drawing.Point(310, 10)
        Me.lblPatronId.Name = "lblPatronId"
        Me.lblPatronId.Size = New System.Drawing.Size(93, 28)
        Me.lblPatronId.TabIndex = 62
        Me.lblPatronId.Text = "Patron ID"
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.White
        Me.GunaCircleButton2.BorderSize = 1
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.Image = Nothing
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(182, 149)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton2.Size = New System.Drawing.Size(20, 20)
        Me.GunaCircleButton2.TabIndex = 60
        Me.GunaCircleButton2.Text = "+"
        '
        'profilePicbox
        '
        Me.profilePicbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.profilePicbox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.profilePicbox.Location = New System.Drawing.Point(52, 19)
        Me.profilePicbox.Name = "profilePicbox"
        Me.profilePicbox.Size = New System.Drawing.Size(150, 150)
        Me.profilePicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profilePicbox.TabIndex = 59
        Me.profilePicbox.TabStop = False
        Me.profilePicbox.UseTransfarantBackground = False
        '
        'lblPatron
        '
        Me.lblPatron.AutoSize = True
        Me.lblPatron.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatron.ForeColor = System.Drawing.Color.White
        Me.lblPatron.Location = New System.Drawing.Point(360, 9)
        Me.lblPatron.Name = "lblPatron"
        Me.lblPatron.Size = New System.Drawing.Size(114, 29)
        Me.lblPatron.TabIndex = 61
        Me.lblPatron.Text = "PATRON"
        '
        'GunaDataGridView1
        '
        Me.GunaDataGridView1.AllowUserToAddRows = False
        Me.GunaDataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 40
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(52, 379)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidth = 40
        Me.GunaDataGridView1.RowTemplate.Height = 20
        Me.GunaDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(743, 320)
        Me.GunaDataGridView1.TabIndex = 62
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Turquoise
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 20
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.HeaderText = "Patron ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Full Nmae"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Gender"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Date Of Birth"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Registration Fee"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Game"
        Me.Column6.Name = "Column6"
        '
        'btnMinimize
        '
        Me.btnMinimize.AnimationHoverSpeed = 0.07!
        Me.btnMinimize.AnimationSpeed = 0.03!
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMinimize.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnMinimize.BorderColor = System.Drawing.Color.White
        Me.btnMinimize.BorderSize = 1
        Me.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMinimize.FocusedColor = System.Drawing.Color.Empty
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnMinimize.Location = New System.Drawing.Point(730, 18)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnMinimize.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnMinimize.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMinimize.OnHoverImage = Nothing
        Me.btnMinimize.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnMinimize.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimize.TabIndex = 80
        '
        'btnMaximize
        '
        Me.btnMaximize.AnimationHoverSpeed = 0.07!
        Me.btnMaximize.AnimationSpeed = 0.03!
        Me.btnMaximize.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMaximize.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnMaximize.BorderColor = System.Drawing.Color.White
        Me.btnMaximize.BorderSize = 1
        Me.btnMaximize.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMaximize.FocusedColor = System.Drawing.Color.Empty
        Me.btnMaximize.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMaximize.ForeColor = System.Drawing.Color.White
        Me.btnMaximize.Image = Nothing
        Me.btnMaximize.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnMaximize.Location = New System.Drawing.Point(760, 18)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnMaximize.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnMaximize.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMaximize.OnHoverImage = Nothing
        Me.btnMaximize.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnMaximize.Size = New System.Drawing.Size(20, 20)
        Me.btnMaximize.TabIndex = 79
        '
        'btnExit
        '
        Me.btnExit.AnimationHoverSpeed = 0.07!
        Me.btnExit.AnimationSpeed = 0.03!
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnExit.BorderColor = System.Drawing.Color.White
        Me.btnExit.BorderSize = 1
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExit.FocusedColor = System.Drawing.Color.Empty
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnExit.Location = New System.Drawing.Point(790, 18)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnExit.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnExit.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.OnHoverImage = Nothing
        Me.btnExit.OnPressedColor = System.Drawing.Color.Red
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 78
        '
        'btnPrevious
        '
        Me.btnPrevious.AnimationHoverSpeed = 0.07!
        Me.btnPrevious.AnimationSpeed = 0.03!
        Me.btnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnPrevious.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrevious.BorderColor = System.Drawing.Color.White
        Me.btnPrevious.BorderSize = 1
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrevious.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Image = Nothing
        Me.btnPrevious.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPrevious.Location = New System.Drawing.Point(136, 248)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrevious.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnPrevious.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrevious.OnHoverImage = Nothing
        Me.btnPrevious.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrevious.Radius = 10
        Me.btnPrevious.Size = New System.Drawing.Size(105, 30)
        Me.btnPrevious.TabIndex = 98
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNext
        '
        Me.btnNext.AnimationHoverSpeed = 0.07!
        Me.btnNext.AnimationSpeed = 0.03!
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.BorderColor = System.Drawing.Color.White
        Me.btnNext.BorderSize = 1
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNext.FocusedColor = System.Drawing.Color.Empty
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Image = Nothing
        Me.btnNext.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnNext.Location = New System.Drawing.Point(25, 248)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnNext.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNext.OnHoverImage = Nothing
        Me.btnNext.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Radius = 10
        Me.btnNext.Size = New System.Drawing.Size(105, 30)
        Me.btnNext.TabIndex = 97
        Me.btnNext.Text = "Next"
        Me.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
        Me.btnDelete.AnimationHoverSpeed = 0.07!
        Me.btnDelete.AnimationSpeed = 0.03!
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.BorderColor = System.Drawing.Color.White
        Me.btnDelete.BorderSize = 1
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.FocusedColor = System.Drawing.Color.Empty
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Nothing
        Me.btnDelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDelete.Location = New System.Drawing.Point(136, 212)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.Radius = 10
        Me.btnDelete.Size = New System.Drawing.Size(105, 30)
        Me.btnDelete.TabIndex = 96
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnClear.Location = New System.Drawing.Point(25, 212)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Radius = 10
        Me.btnClear.Size = New System.Drawing.Size(105, 30)
        Me.btnClear.TabIndex = 95
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
        Me.btnSave.Location = New System.Drawing.Point(136, 175)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 94
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
        Me.btnAdd.Location = New System.Drawing.Point(25, 175)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Radius = 10
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 93
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Patrons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 737)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.lblPatron)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Patrons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patrons"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.profilePicbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents drpGender As ns1.BunifuDropdown
    Friend WithEvents drpRole As ns1.BunifuDropdown
    Friend WithEvents txtDateofbirth As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents txtRegfee As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtfullname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtmemberid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents lblRegfee As System.Windows.Forms.Label
    Friend WithEvents lblDateofbirth As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents btnFullname As System.Windows.Forms.Label
    Friend WithEvents lblPatronId As System.Windows.Forms.Label
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents profilePicbox As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblPatron As System.Windows.Forms.Label
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMinimize As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnMaximize As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnExit As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnPrevious As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnNext As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
End Class
