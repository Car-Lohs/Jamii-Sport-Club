<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SportEvents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SportEvents))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnMinimize = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnMaximize = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnExit = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnPrevious = New Guna.UI.WinForms.GunaButton()
        Me.txtfacilitationfee = New Guna.UI.WinForms.GunaTextBox()
        Me.btnNext = New Guna.UI.WinForms.GunaButton()
        Me.txtDatepic = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.lblFacilitationfee = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtCaptain = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPatron = New Guna.UI.WinForms.GunaTextBox()
        Me.lblCaptain = New System.Windows.Forms.Label()
        Me.lblPatron = New System.Windows.Forms.Label()
        Me.txtgame = New Guna.UI.WinForms.GunaTextBox()
        Me.EventidTextbox = New Guna.UI.WinForms.GunaTextBox()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.lblEventid = New System.Windows.Forms.Label()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.lblEvents = New System.Windows.Forms.Label()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Jamii_Sports_ClubDataSet = New Jamii_Sports_Club_Managment_System.Jamii_Sports_ClubDataSet()
        Me.EventsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventsTableAdapter = New Jamii_Sports_Club_Managment_System.Jamii_Sports_ClubDataSetTableAdapters.EventsTableAdapter()
        Me.EventIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatronDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaptainDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalFacilitationFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jamii_Sports_ClubDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jamii_Sports_ClubDataSet.Eevents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 50
        Me.GunaElipse1.TargetControl = Me
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
        Me.btnMinimize.Location = New System.Drawing.Point(765, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnMinimize.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnMinimize.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMinimize.OnHoverImage = Nothing
        Me.btnMinimize.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnMinimize.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimize.TabIndex = 16
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
        Me.btnMaximize.Location = New System.Drawing.Point(795, 12)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnMaximize.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnMaximize.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMaximize.OnHoverImage = Nothing
        Me.btnMaximize.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnMaximize.Size = New System.Drawing.Size(20, 20)
        Me.btnMaximize.TabIndex = 15
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
        Me.btnExit.Location = New System.Drawing.Point(825, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnExit.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnExit.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.OnHoverImage = Nothing
        Me.btnExit.OnPressedColor = System.Drawing.Color.Red
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 14
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.btnPrevious)
        Me.GunaElipsePanel1.Controls.Add(Me.txtfacilitationfee)
        Me.GunaElipsePanel1.Controls.Add(Me.btnNext)
        Me.GunaElipsePanel1.Controls.Add(Me.txtDatepic)
        Me.GunaElipsePanel1.Controls.Add(Me.btnDelete)
        Me.GunaElipsePanel1.Controls.Add(Me.lblFacilitationfee)
        Me.GunaElipsePanel1.Controls.Add(Me.lblDate)
        Me.GunaElipsePanel1.Controls.Add(Me.txtCaptain)
        Me.GunaElipsePanel1.Controls.Add(Me.txtPatron)
        Me.GunaElipsePanel1.Controls.Add(Me.lblCaptain)
        Me.GunaElipsePanel1.Controls.Add(Me.lblPatron)
        Me.GunaElipsePanel1.Controls.Add(Me.txtgame)
        Me.GunaElipsePanel1.Controls.Add(Me.EventidTextbox)
        Me.GunaElipsePanel1.Controls.Add(Me.lblGame)
        Me.GunaElipsePanel1.Controls.Add(Me.lblEventid)
        Me.GunaElipsePanel1.Controls.Add(Me.btnClear)
        Me.GunaElipsePanel1.Controls.Add(Me.btnSave)
        Me.GunaElipsePanel1.Controls.Add(Me.btnAdd)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(99, 45)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 20
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(668, 281)
        Me.GunaElipsePanel1.TabIndex = 17
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
        Me.btnPrevious.Location = New System.Drawing.Point(143, 146)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrevious.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnPrevious.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrevious.OnHoverImage = Nothing
        Me.btnPrevious.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrevious.Radius = 10
        Me.btnPrevious.Size = New System.Drawing.Size(105, 30)
        Me.btnPrevious.TabIndex = 92
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfacilitationfee
        '
        Me.txtfacilitationfee.BackColor = System.Drawing.Color.Transparent
        Me.txtfacilitationfee.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtfacilitationfee.BorderColor = System.Drawing.Color.White
        Me.txtfacilitationfee.BorderSize = 1
        Me.txtfacilitationfee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfacilitationfee.FocusedBaseColor = System.Drawing.Color.White
        Me.txtfacilitationfee.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtfacilitationfee.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtfacilitationfee.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtfacilitationfee.Location = New System.Drawing.Point(389, 216)
        Me.txtfacilitationfee.Name = "txtfacilitationfee"
        Me.txtfacilitationfee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfacilitationfee.Radius = 10
        Me.txtfacilitationfee.SelectedText = ""
        Me.txtfacilitationfee.Size = New System.Drawing.Size(239, 34)
        Me.txtfacilitationfee.TabIndex = 80
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
        Me.btnNext.Location = New System.Drawing.Point(32, 146)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnNext.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNext.OnHoverImage = Nothing
        Me.btnNext.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Radius = 10
        Me.btnNext.Size = New System.Drawing.Size(105, 30)
        Me.btnNext.TabIndex = 91
        Me.btnNext.Text = "Next"
        Me.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtDatepic.Location = New System.Drawing.Point(389, 180)
        Me.txtDatepic.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDatepic.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtDatepic.Name = "txtDatepic"
        Me.txtDatepic.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDatepic.OnHoverBorderColor = System.Drawing.Color.White
        Me.txtDatepic.OnHoverForeColor = System.Drawing.Color.Black
        Me.txtDatepic.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtDatepic.Radius = 10
        Me.txtDatepic.Size = New System.Drawing.Size(239, 30)
        Me.txtDatepic.TabIndex = 79
        Me.txtDatepic.Text = "Saturday, July 15, 2023"
        Me.txtDatepic.Value = New Date(2023, 7, 15, 19, 23, 48, 573)
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
        Me.btnDelete.Location = New System.Drawing.Point(143, 110)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.Radius = 10
        Me.btnDelete.Size = New System.Drawing.Size(105, 30)
        Me.btnDelete.TabIndex = 90
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFacilitationfee
        '
        Me.lblFacilitationfee.AutoSize = True
        Me.lblFacilitationfee.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacilitationfee.ForeColor = System.Drawing.Color.White
        Me.lblFacilitationfee.Location = New System.Drawing.Point(246, 222)
        Me.lblFacilitationfee.Name = "lblFacilitationfee"
        Me.lblFacilitationfee.Size = New System.Drawing.Size(142, 28)
        Me.lblFacilitationfee.TabIndex = 78
        Me.lblFacilitationfee.Text = "Facilitation Fee"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(335, 182)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 28)
        Me.lblDate.TabIndex = 77
        Me.lblDate.Text = "Date"
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
        Me.txtCaptain.Location = New System.Drawing.Point(389, 140)
        Me.txtCaptain.Name = "txtCaptain"
        Me.txtCaptain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCaptain.Radius = 10
        Me.txtCaptain.SelectedText = ""
        Me.txtCaptain.Size = New System.Drawing.Size(239, 34)
        Me.txtCaptain.TabIndex = 75
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
        Me.txtPatron.Location = New System.Drawing.Point(389, 100)
        Me.txtPatron.Name = "txtPatron"
        Me.txtPatron.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatron.Radius = 10
        Me.txtPatron.SelectedText = ""
        Me.txtPatron.Size = New System.Drawing.Size(239, 34)
        Me.txtPatron.TabIndex = 74
        '
        'lblCaptain
        '
        Me.lblCaptain.AutoSize = True
        Me.lblCaptain.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptain.ForeColor = System.Drawing.Color.White
        Me.lblCaptain.Location = New System.Drawing.Point(309, 146)
        Me.lblCaptain.Name = "lblCaptain"
        Me.lblCaptain.Size = New System.Drawing.Size(79, 28)
        Me.lblCaptain.TabIndex = 73
        Me.lblCaptain.Text = "Captain"
        '
        'lblPatron
        '
        Me.lblPatron.AutoSize = True
        Me.lblPatron.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatron.ForeColor = System.Drawing.Color.White
        Me.lblPatron.Location = New System.Drawing.Point(319, 106)
        Me.lblPatron.Name = "lblPatron"
        Me.lblPatron.Size = New System.Drawing.Size(69, 28)
        Me.lblPatron.TabIndex = 72
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
        Me.txtgame.Location = New System.Drawing.Point(388, 60)
        Me.txtgame.Name = "txtgame"
        Me.txtgame.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtgame.Radius = 10
        Me.txtgame.SelectedText = ""
        Me.txtgame.Size = New System.Drawing.Size(239, 34)
        Me.txtgame.TabIndex = 71
        '
        'EventidTextbox
        '
        Me.EventidTextbox.BackColor = System.Drawing.Color.Transparent
        Me.EventidTextbox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.EventidTextbox.BorderColor = System.Drawing.Color.White
        Me.EventidTextbox.BorderSize = 1
        Me.EventidTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EventidTextbox.FocusedBaseColor = System.Drawing.Color.White
        Me.EventidTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.EventidTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.EventidTextbox.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.EventidTextbox.Location = New System.Drawing.Point(388, 20)
        Me.EventidTextbox.Name = "EventidTextbox"
        Me.EventidTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EventidTextbox.Radius = 10
        Me.EventidTextbox.SelectedText = ""
        Me.EventidTextbox.Size = New System.Drawing.Size(239, 34)
        Me.EventidTextbox.TabIndex = 70
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.ForeColor = System.Drawing.Color.White
        Me.lblGame.Location = New System.Drawing.Point(325, 66)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(63, 28)
        Me.lblGame.TabIndex = 69
        Me.lblGame.Text = "Game"
        '
        'lblEventid
        '
        Me.lblEventid.AutoSize = True
        Me.lblEventid.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventid.ForeColor = System.Drawing.Color.White
        Me.lblEventid.Location = New System.Drawing.Point(304, 26)
        Me.lblEventid.Name = "lblEventid"
        Me.lblEventid.Size = New System.Drawing.Size(84, 28)
        Me.lblEventid.TabIndex = 68
        Me.lblEventid.Text = "Event ID"
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
        Me.btnClear.Location = New System.Drawing.Point(32, 110)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Radius = 10
        Me.btnClear.Size = New System.Drawing.Size(105, 30)
        Me.btnClear.TabIndex = 66
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
        Me.btnSave.Location = New System.Drawing.Point(143, 73)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(105, 30)
        Me.btnSave.TabIndex = 65
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
        Me.btnAdd.Location = New System.Drawing.Point(32, 73)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Radius = 10
        Me.btnAdd.Size = New System.Drawing.Size(105, 30)
        Me.btnAdd.TabIndex = 64
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEvents
        '
        Me.lblEvents.AutoSize = True
        Me.lblEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvents.ForeColor = System.Drawing.Color.White
        Me.lblEvents.Location = New System.Drawing.Point(378, 9)
        Me.lblEvents.Name = "lblEvents"
        Me.lblEvents.Size = New System.Drawing.Size(110, 29)
        Me.lblEvents.TabIndex = 76
        Me.lblEvents.Text = "EVENTS"
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoGenerateColumns = False
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
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventIDDataGridViewTextBoxColumn, Me.GameDataGridViewTextBoxColumn, Me.PatronDataGridViewTextBoxColumn, Me.CaptainDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TotalFacilitationFeeDataGridViewTextBoxColumn})
        Me.GunaDataGridView1.DataSource = Me.EventsBindingSource
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
        Me.GunaDataGridView1.Location = New System.Drawing.Point(60, 347)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidth = 40
        Me.GunaDataGridView1.RowTemplate.Height = 20
        Me.GunaDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(746, 279)
        Me.GunaDataGridView1.TabIndex = 77
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
        'Jamii_Sports_ClubDataSet
        '
        Me.Jamii_Sports_ClubDataSet.DataSetName = "Jamii_Sports_ClubDataSet"
        '
        '
        '
        Me.Jamii_Sports_ClubDataSet.Eevents.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"Event ID"}, True)})
        Me.Jamii_Sports_ClubDataSet.Eevents.TableName = "Events"
        Me.Jamii_Sports_ClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EventsBindingSource
        '
        Me.EventsBindingSource.DataMember = "Events"
        Me.EventsBindingSource.DataSource = Me.Jamii_Sports_ClubDataSet
        '
        'EventsTableAdapter
        '
        Me.EventsTableAdapter.ClearBeforeFill = True
        '
        'EventIDDataGridViewTextBoxColumn
        '
        Me.EventIDDataGridViewTextBoxColumn.DataPropertyName = "Event ID"
        Me.EventIDDataGridViewTextBoxColumn.HeaderText = "Event ID"
        Me.EventIDDataGridViewTextBoxColumn.Name = "EventIDDataGridViewTextBoxColumn"
        '
        'GameDataGridViewTextBoxColumn
        '
        Me.GameDataGridViewTextBoxColumn.DataPropertyName = "Game"
        Me.GameDataGridViewTextBoxColumn.HeaderText = "Game"
        Me.GameDataGridViewTextBoxColumn.Name = "GameDataGridViewTextBoxColumn"
        '
        'PatronDataGridViewTextBoxColumn
        '
        Me.PatronDataGridViewTextBoxColumn.DataPropertyName = "Patron"
        Me.PatronDataGridViewTextBoxColumn.HeaderText = "Patron"
        Me.PatronDataGridViewTextBoxColumn.Name = "PatronDataGridViewTextBoxColumn"
        '
        'CaptainDataGridViewTextBoxColumn
        '
        Me.CaptainDataGridViewTextBoxColumn.DataPropertyName = "Captain"
        Me.CaptainDataGridViewTextBoxColumn.HeaderText = "Captain"
        Me.CaptainDataGridViewTextBoxColumn.Name = "CaptainDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'TotalFacilitationFeeDataGridViewTextBoxColumn
        '
        Me.TotalFacilitationFeeDataGridViewTextBoxColumn.DataPropertyName = "Total Facilitation Fee"
        Me.TotalFacilitationFeeDataGridViewTextBoxColumn.HeaderText = "Total Facilitation Fee"
        Me.TotalFacilitationFeeDataGridViewTextBoxColumn.Name = "TotalFacilitationFeeDataGridViewTextBoxColumn"
        '
        'SportEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 657)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblEvents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SportEvents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Events"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jamii_Sports_ClubDataSet.Eevents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jamii_Sports_ClubDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnMinimize As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnMaximize As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnExit As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents txtfacilitationfee As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtDatepic As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents lblFacilitationfee As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtCaptain As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtPatron As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblCaptain As System.Windows.Forms.Label
    Friend WithEvents lblPatron As System.Windows.Forms.Label
    Friend WithEvents txtgame As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents EventidTextbox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents lblEventid As System.Windows.Forms.Label
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblEvents As System.Windows.Forms.Label
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnPrevious As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnNext As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents Jamii_Sports_ClubDataSet As Jamii_Sports_Club_Managment_System.Jamii_Sports_ClubDataSet
    Friend WithEvents EventsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EventsTableAdapter As Jamii_Sports_Club_Managment_System.Jamii_Sports_ClubDataSetTableAdapters.EventsTableAdapter
    Friend WithEvents EventIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatronDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaptainDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalFacilitationFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
