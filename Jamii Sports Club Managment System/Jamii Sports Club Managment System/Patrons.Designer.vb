﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnBrowse = New Guna.UI.WinForms.GunaButton()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.drpGender = New ns1.BunifuDropdown()
        Me.drpRole = New ns1.BunifuDropdown()
        Me.GunaDateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.txtRegfee = New Guna.UI.WinForms.GunaTextBox()
        Me.txtfullname = New Guna.UI.WinForms.GunaTextBox()
        Me.txtmemberid = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaCircleButton3 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton4 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GunaElipsePanel1.Controls.Add(Me.btnBrowse)
        Me.GunaElipsePanel1.Controls.Add(Me.btnClear)
        Me.GunaElipsePanel1.Controls.Add(Me.btnSave)
        Me.GunaElipsePanel1.Controls.Add(Me.btnAdd)
        Me.GunaElipsePanel1.Controls.Add(Me.drpGender)
        Me.GunaElipsePanel1.Controls.Add(Me.drpRole)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaDateTimePicker1)
        Me.GunaElipsePanel1.Controls.Add(Me.txtRegfee)
        Me.GunaElipsePanel1.Controls.Add(Me.txtfullname)
        Me.GunaElipsePanel1.Controls.Add(Me.txtmemberid)
        Me.GunaElipsePanel1.Controls.Add(Me.Label6)
        Me.GunaElipsePanel1.Controls.Add(Me.Label5)
        Me.GunaElipsePanel1.Controls.Add(Me.Label4)
        Me.GunaElipsePanel1.Controls.Add(Me.Label3)
        Me.GunaElipsePanel1.Controls.Add(Me.Label2)
        Me.GunaElipsePanel1.Controls.Add(Me.Label1)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaCircleButton2)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(85, 54)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 20
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(668, 265)
        Me.GunaElipsePanel1.TabIndex = 0
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
        Me.btnBrowse.Location = New System.Drawing.Point(129, 228)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverImage = Nothing
        Me.btnBrowse.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.Radius = 10
        Me.btnBrowse.Size = New System.Drawing.Size(105, 30)
        Me.btnBrowse.TabIndex = 77
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
        Me.btnClear.Location = New System.Drawing.Point(18, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Radius = 10
        Me.btnClear.Size = New System.Drawing.Size(105, 30)
        Me.btnClear.TabIndex = 76
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
        Me.btnSave.Location = New System.Drawing.Point(129, 191)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 75
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
        Me.btnAdd.Location = New System.Drawing.Point(18, 191)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Radius = 10
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 74
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'drpGender
        '
        Me.drpGender.BackColor = System.Drawing.Color.Transparent
        Me.drpGender.BorderRadius = 20
        Me.drpGender.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpGender.ForeColor = System.Drawing.Color.Black
        Me.drpGender.Items = New String() {"Male", "Female"}
        Me.drpGender.Location = New System.Drawing.Point(403, 117)
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
        Me.drpRole.Location = New System.Drawing.Point(403, 224)
        Me.drpRole.Margin = New System.Windows.Forms.Padding(5)
        Me.drpRole.Name = "drpRole"
        Me.drpRole.NomalColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpRole.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpRole.selectedIndex = -1
        Me.drpRole.Size = New System.Drawing.Size(239, 34)
        Me.drpRole.TabIndex = 72
        '
        'GunaDateTimePicker1
        '
        Me.GunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.GunaDateTimePicker1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GunaDateTimePicker1.BorderColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.BorderSize = 1
        Me.GunaDateTimePicker1.CustomFormat = Nothing
        Me.GunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.GunaDateTimePicker1.FocusedColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.GunaDateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Location = New System.Drawing.Point(403, 154)
        Me.GunaDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.Name = "GunaDateTimePicker1"
        Me.GunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GunaDateTimePicker1.Radius = 10
        Me.GunaDateTimePicker1.Size = New System.Drawing.Size(239, 30)
        Me.GunaDateTimePicker1.TabIndex = 71
        Me.GunaDateTimePicker1.Text = "Saturday, July 15, 2023"
        Me.GunaDateTimePicker1.Value = New Date(2023, 7, 15, 19, 23, 48, 573)
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
        Me.txtRegfee.Location = New System.Drawing.Point(403, 187)
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
        Me.txtfullname.Location = New System.Drawing.Point(403, 80)
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
        Me.txtmemberid.Location = New System.Drawing.Point(403, 43)
        Me.txtmemberid.Name = "txtmemberid"
        Me.txtmemberid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemberid.Radius = 10
        Me.txtmemberid.SelectedText = ""
        Me.txtmemberid.Size = New System.Drawing.Size(239, 34)
        Me.txtmemberid.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(334, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 28)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Game"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(245, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 28)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Registration Fee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(272, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 28)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Date Of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(321, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 28)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(297, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 28)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(304, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 28)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Patron ID"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(360, 9)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(114, 29)
        Me.lblLogin.TabIndex = 61
        Me.lblLogin.Text = "PATRON"
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
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(52, 19)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 59
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
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
        Me.GunaDataGridView1.Location = New System.Drawing.Point(46, 325)
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
        'GunaCircleButton3
        '
        Me.GunaCircleButton3.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton3.AnimationSpeed = 0.03!
        Me.GunaCircleButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaCircleButton3.BorderColor = System.Drawing.Color.White
        Me.GunaCircleButton3.BorderSize = 1
        Me.GunaCircleButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaCircleButton3.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton3.Image = Nothing
        Me.GunaCircleButton3.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton3.Location = New System.Drawing.Point(730, 18)
        Me.GunaCircleButton3.Name = "GunaCircleButton3"
        Me.GunaCircleButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaCircleButton3.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaCircleButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton3.OnHoverImage = Nothing
        Me.GunaCircleButton3.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaCircleButton3.Size = New System.Drawing.Size(20, 20)
        Me.GunaCircleButton3.TabIndex = 80
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.White
        Me.GunaCircleButton1.BorderSize = 1
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(760, 18)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GunaCircleButton1.Size = New System.Drawing.Size(20, 20)
        Me.GunaCircleButton1.TabIndex = 79
        '
        'GunaCircleButton4
        '
        Me.GunaCircleButton4.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton4.AnimationSpeed = 0.03!
        Me.GunaCircleButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaCircleButton4.BorderColor = System.Drawing.Color.White
        Me.GunaCircleButton4.BorderSize = 1
        Me.GunaCircleButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaCircleButton4.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton4.Image = Nothing
        Me.GunaCircleButton4.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton4.Location = New System.Drawing.Point(790, 18)
        Me.GunaCircleButton4.Name = "GunaCircleButton4"
        Me.GunaCircleButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaCircleButton4.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaCircleButton4.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton4.OnHoverImage = Nothing
        Me.GunaCircleButton4.OnPressedColor = System.Drawing.Color.Red
        Me.GunaCircleButton4.Size = New System.Drawing.Size(20, 20)
        Me.GunaCircleButton4.TabIndex = 78
        '
        'Patrons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 677)
        Me.Controls.Add(Me.GunaCircleButton3)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.GunaCircleButton4)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.lblLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Patrons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patrons"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnBrowse As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents drpGender As ns1.BunifuDropdown
    Friend WithEvents drpRole As ns1.BunifuDropdown
    Friend WithEvents GunaDateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents txtRegfee As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtfullname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtmemberid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GunaCircleButton3 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton4 As Guna.UI.WinForms.GunaCircleButton
End Class