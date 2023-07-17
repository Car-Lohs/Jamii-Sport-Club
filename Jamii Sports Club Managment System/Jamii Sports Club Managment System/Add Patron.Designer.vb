<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Patron
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Patron))
        Me.btnBrowse = New Guna.UI.WinForms.GunaButton()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.drpGender = New ns1.BunifuDropdown()
        Me.drpGame = New ns1.BunifuDropdown()
        Me.txtDatepic = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.txtRegfee = New Guna.UI.WinForms.GunaTextBox()
        Me.txtfullname = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPatronid = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAddpatron = New System.Windows.Forms.Label()
        Me.btnAddpic = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnExit = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.profilepicbox = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.profilepicbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnBrowse.Location = New System.Drawing.Point(125, 257)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverImage = Nothing
        Me.btnBrowse.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.Radius = 10
        Me.btnBrowse.Size = New System.Drawing.Size(105, 30)
        Me.btnBrowse.TabIndex = 58
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
        Me.btnClear.Location = New System.Drawing.Point(14, 257)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Radius = 10
        Me.btnClear.Size = New System.Drawing.Size(105, 30)
        Me.btnClear.TabIndex = 57
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
        Me.btnSave.Location = New System.Drawing.Point(125, 220)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 56
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
        Me.btnAdd.Location = New System.Drawing.Point(14, 220)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Radius = 10
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 55
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
        Me.drpGender.Location = New System.Drawing.Point(399, 146)
        Me.drpGender.Margin = New System.Windows.Forms.Padding(5)
        Me.drpGender.Name = "drpGender"
        Me.drpGender.NomalColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpGender.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpGender.selectedIndex = -1
        Me.drpGender.Size = New System.Drawing.Size(239, 34)
        Me.drpGender.TabIndex = 54
        '
        'drpGame
        '
        Me.drpGame.BackColor = System.Drawing.Color.Transparent
        Me.drpGame.BorderRadius = 20
        Me.drpGame.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpGame.ForeColor = System.Drawing.Color.Black
        Me.drpGame.Items = New String() {"Player", "Captain"}
        Me.drpGame.Location = New System.Drawing.Point(399, 253)
        Me.drpGame.Margin = New System.Windows.Forms.Padding(5)
        Me.drpGame.Name = "drpGame"
        Me.drpGame.NomalColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpGame.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.drpGame.selectedIndex = -1
        Me.drpGame.Size = New System.Drawing.Size(239, 34)
        Me.drpGame.TabIndex = 53
        '
        'txtDatepic
        '
        Me.txtDatepic.BackColor = System.Drawing.Color.Transparent
        Me.txtDatepic.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDatepic.BorderColor = System.Drawing.Color.White
        Me.txtDatepic.BorderSize = 1
        Me.txtDatepic.CustomFormat = Nothing
        Me.txtDatepic.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txtDatepic.FocusedColor = System.Drawing.Color.White
        Me.txtDatepic.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtDatepic.ForeColor = System.Drawing.Color.Black
        Me.txtDatepic.Location = New System.Drawing.Point(399, 183)
        Me.txtDatepic.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDatepic.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtDatepic.Name = "txtDatepic"
        Me.txtDatepic.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDatepic.OnHoverBorderColor = System.Drawing.Color.White
        Me.txtDatepic.OnHoverForeColor = System.Drawing.Color.Black
        Me.txtDatepic.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDatepic.Radius = 10
        Me.txtDatepic.Size = New System.Drawing.Size(239, 30)
        Me.txtDatepic.TabIndex = 52
        Me.txtDatepic.Text = "Saturday, July 15, 2023"
        Me.txtDatepic.Value = New Date(2023, 7, 15, 19, 23, 48, 573)
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
        Me.txtRegfee.Location = New System.Drawing.Point(399, 216)
        Me.txtRegfee.Name = "txtRegfee"
        Me.txtRegfee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegfee.Radius = 10
        Me.txtRegfee.SelectedText = ""
        Me.txtRegfee.Size = New System.Drawing.Size(239, 34)
        Me.txtRegfee.TabIndex = 49
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
        Me.txtfullname.Location = New System.Drawing.Point(399, 109)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfullname.Radius = 10
        Me.txtfullname.SelectedText = ""
        Me.txtfullname.Size = New System.Drawing.Size(239, 34)
        Me.txtfullname.TabIndex = 48
        '
        'txtPatronid
        '
        Me.txtPatronid.BackColor = System.Drawing.Color.Transparent
        Me.txtPatronid.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtPatronid.BorderColor = System.Drawing.Color.White
        Me.txtPatronid.BorderSize = 1
        Me.txtPatronid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPatronid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPatronid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPatronid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPatronid.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtPatronid.Location = New System.Drawing.Point(399, 72)
        Me.txtPatronid.Name = "txtPatronid"
        Me.txtPatronid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatronid.Radius = 10
        Me.txtPatronid.SelectedText = ""
        Me.txtPatronid.Size = New System.Drawing.Size(239, 34)
        Me.txtPatronid.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(330, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 28)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Game"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(241, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 28)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Registration Fee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(268, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 28)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Date Of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(317, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 28)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(293, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 28)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(300, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 28)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Patron ID"
        '
        'lblAddpatron
        '
        Me.lblAddpatron.AutoSize = True
        Me.lblAddpatron.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddpatron.ForeColor = System.Drawing.Color.White
        Me.lblAddpatron.Location = New System.Drawing.Point(250, 4)
        Me.lblAddpatron.Name = "lblAddpatron"
        Me.lblAddpatron.Size = New System.Drawing.Size(169, 29)
        Me.lblAddpatron.TabIndex = 38
        Me.lblAddpatron.Text = "ADD PATRON"
        '
        'btnAddpic
        '
        Me.btnAddpic.AnimationHoverSpeed = 0.07!
        Me.btnAddpic.AnimationSpeed = 0.03!
        Me.btnAddpic.BackColor = System.Drawing.Color.Transparent
        Me.btnAddpic.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddpic.BorderColor = System.Drawing.Color.White
        Me.btnAddpic.BorderSize = 1
        Me.btnAddpic.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddpic.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddpic.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddpic.ForeColor = System.Drawing.Color.White
        Me.btnAddpic.Image = Nothing
        Me.btnAddpic.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnAddpic.Location = New System.Drawing.Point(178, 178)
        Me.btnAddpic.Name = "btnAddpic"
        Me.btnAddpic.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddpic.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnAddpic.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddpic.OnHoverImage = Nothing
        Me.btnAddpic.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddpic.Size = New System.Drawing.Size(20, 20)
        Me.btnAddpic.TabIndex = 37
        Me.btnAddpic.Text = "+"
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
        Me.btnExit.Location = New System.Drawing.Point(618, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnExit.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnExit.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.OnHoverImage = Nothing
        Me.btnExit.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 36
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
        Me.profilepicbox.Location = New System.Drawing.Point(48, 48)
        Me.profilepicbox.Name = "profilepicbox"
        Me.profilepicbox.Size = New System.Drawing.Size(150, 150)
        Me.profilepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profilepicbox.TabIndex = 35
        Me.profilepicbox.TabStop = False
        Me.profilepicbox.UseTransfarantBackground = False
        '
        'Add_Patron
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 324)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.drpGender)
        Me.Controls.Add(Me.drpGame)
        Me.Controls.Add(Me.txtDatepic)
        Me.Controls.Add(Me.txtRegfee)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.txtPatronid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAddpatron)
        Me.Controls.Add(Me.btnAddpic)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.profilepicbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Add_Patron"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Patron"
        CType(Me.profilepicbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents drpGender As ns1.BunifuDropdown
    Friend WithEvents drpGame As ns1.BunifuDropdown
    Friend WithEvents txtDatepic As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents txtRegfee As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtfullname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtPatronid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAddpatron As System.Windows.Forms.Label
    Friend WithEvents btnAddpic As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnExit As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents profilepicbox As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
End Class
