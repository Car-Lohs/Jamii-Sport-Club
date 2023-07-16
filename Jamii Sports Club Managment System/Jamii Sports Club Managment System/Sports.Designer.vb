<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sports))
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.txtCaptain = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPatron = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtgamename = New Guna.UI.WinForms.GunaTextBox()
        Me.txtgameid = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New Guna.UI.WinForms.GunaButton()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.GunaCircleButton3 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patron = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Captain = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Patron, Me.Captain})
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
        Me.GunaDataGridView1.Location = New System.Drawing.Point(119, 317)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidth = 40
        Me.GunaDataGridView1.RowTemplate.Height = 20
        Me.GunaDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(591, 294)
        Me.GunaDataGridView1.TabIndex = 16
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
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.txtCaptain)
        Me.GunaElipsePanel1.Controls.Add(Me.txtPatron)
        Me.GunaElipsePanel1.Controls.Add(Me.Label4)
        Me.GunaElipsePanel1.Controls.Add(Me.Label3)
        Me.GunaElipsePanel1.Controls.Add(Me.txtgamename)
        Me.GunaElipsePanel1.Controls.Add(Me.txtgameid)
        Me.GunaElipsePanel1.Controls.Add(Me.Label2)
        Me.GunaElipsePanel1.Controls.Add(Me.Label1)
        Me.GunaElipsePanel1.Controls.Add(Me.btnBrowse)
        Me.GunaElipsePanel1.Controls.Add(Me.btnClear)
        Me.GunaElipsePanel1.Controls.Add(Me.btnSave)
        Me.GunaElipsePanel1.Controls.Add(Me.btnAdd)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(37, 79)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 20
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(710, 214)
        Me.GunaElipsePanel1.TabIndex = 17
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
        Me.txtCaptain.Location = New System.Drawing.Point(421, 153)
        Me.txtCaptain.Name = "txtCaptain"
        Me.txtCaptain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCaptain.Radius = 10
        Me.txtCaptain.SelectedText = ""
        Me.txtCaptain.Size = New System.Drawing.Size(239, 34)
        Me.txtCaptain.TabIndex = 56
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
        Me.txtPatron.Location = New System.Drawing.Point(421, 114)
        Me.txtPatron.Name = "txtPatron"
        Me.txtPatron.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatron.Radius = 10
        Me.txtPatron.SelectedText = ""
        Me.txtPatron.Size = New System.Drawing.Size(239, 34)
        Me.txtPatron.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(345, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 28)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Captain"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(355, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 28)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Patron"
        '
        'txtgamename
        '
        Me.txtgamename.BackColor = System.Drawing.Color.Transparent
        Me.txtgamename.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtgamename.BorderColor = System.Drawing.Color.White
        Me.txtgamename.BorderSize = 1
        Me.txtgamename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtgamename.FocusedBaseColor = System.Drawing.Color.White
        Me.txtgamename.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtgamename.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtgamename.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtgamename.Location = New System.Drawing.Point(421, 75)
        Me.txtgamename.Name = "txtgamename"
        Me.txtgamename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtgamename.Radius = 10
        Me.txtgamename.SelectedText = ""
        Me.txtgamename.Size = New System.Drawing.Size(239, 34)
        Me.txtgamename.TabIndex = 52
        '
        'txtgameid
        '
        Me.txtgameid.BackColor = System.Drawing.Color.Transparent
        Me.txtgameid.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtgameid.BorderColor = System.Drawing.Color.White
        Me.txtgameid.BorderSize = 1
        Me.txtgameid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtgameid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtgameid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtgameid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtgameid.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtgameid.Location = New System.Drawing.Point(421, 36)
        Me.txtgameid.Name = "txtgameid"
        Me.txtgameid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtgameid.Radius = 10
        Me.txtgameid.SelectedText = ""
        Me.txtgameid.Size = New System.Drawing.Size(239, 34)
        Me.txtgameid.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(304, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 28)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Game Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(337, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 28)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Game ID"
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
        Me.btnBrowse.Location = New System.Drawing.Point(162, 118)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBrowse.OnHoverImage = Nothing
        Me.btnBrowse.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.Radius = 10
        Me.btnBrowse.Size = New System.Drawing.Size(105, 30)
        Me.btnBrowse.TabIndex = 48
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
        Me.btnClear.Location = New System.Drawing.Point(51, 118)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Radius = 10
        Me.btnClear.Size = New System.Drawing.Size(105, 30)
        Me.btnClear.TabIndex = 47
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
        Me.btnSave.Location = New System.Drawing.Point(162, 81)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 46
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
        Me.btnAdd.Location = New System.Drawing.Point(51, 81)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Radius = 10
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 45
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(336, 19)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(113, 29)
        Me.lblLogin.TabIndex = 57
        Me.lblLogin.Text = "SPORTS"
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
        Me.GunaCircleButton3.Location = New System.Drawing.Point(690, 19)
        Me.GunaCircleButton3.Name = "GunaCircleButton3"
        Me.GunaCircleButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaCircleButton3.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaCircleButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton3.OnHoverImage = Nothing
        Me.GunaCircleButton3.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaCircleButton3.Size = New System.Drawing.Size(20, 20)
        Me.GunaCircleButton3.TabIndex = 60
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.White
        Me.GunaCircleButton2.BorderSize = 1
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.Image = Nothing
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(720, 19)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GunaCircleButton2.Size = New System.Drawing.Size(20, 20)
        Me.GunaCircleButton2.TabIndex = 59
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.White
        Me.GunaCircleButton1.BorderSize = 1
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(750, 19)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Red
        Me.GunaCircleButton1.Size = New System.Drawing.Size(20, 20)
        Me.GunaCircleButton1.TabIndex = 58
        '
        'Column1
        '
        Me.Column1.HeaderText = "Game ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Game Name"
        Me.Column2.Name = "Column2"
        '
        'Patron
        '
        Me.Patron.HeaderText = "Patron"
        Me.Patron.Name = "Patron"
        '
        'Captain
        '
        Me.Captain.HeaderText = "Captain"
        Me.Captain.Name = "Captain"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 50
        Me.GunaElipse1.TargetControl = Me
        '
        'Sports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 651)
        Me.Controls.Add(Me.GunaCircleButton3)
        Me.Controls.Add(Me.GunaCircleButton2)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sports"
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents txtCaptain As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtPatron As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtgamename As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtgameid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents GunaCircleButton3 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Patron As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Captain As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
End Class
