<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.studid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.course = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MySqlDataAdapter1 = New MySql.Data.MySqlClient.MySqlDataAdapter()
        Me.btnadd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnclear = New Guna.UI2.WinForms.Guna2Button()
        Me.btndelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.loadbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studid
        '
        Me.studid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.studid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.studid.DefaultText = ""
        Me.studid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.studid.DisabledState.FillColor = System.Drawing.Color.White
        Me.studid.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.studid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.studid.Enabled = False
        Me.studid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studid.Font = New System.Drawing.Font("Montserrat", 15.0!)
        Me.studid.ForeColor = System.Drawing.Color.Black
        Me.studid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studid.Location = New System.Drawing.Point(12, 56)
        Me.studid.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.studid.Name = "studid"
        Me.studid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.studid.PlaceholderText = "Student ID"
        Me.studid.SelectedText = ""
        Me.studid.Size = New System.Drawing.Size(293, 55)
        Me.studid.TabIndex = 21
        '
        'fname
        '
        Me.fname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fname.DefaultText = ""
        Me.fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fname.Font = New System.Drawing.Font("Montserrat", 15.0!)
        Me.fname.ForeColor = System.Drawing.Color.Black
        Me.fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fname.Location = New System.Drawing.Point(12, 116)
        Me.fname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.fname.Name = "fname"
        Me.fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fname.PlaceholderText = "First Name"
        Me.fname.SelectedText = ""
        Me.fname.Size = New System.Drawing.Size(293, 55)
        Me.fname.TabIndex = 22
        '
        'lname
        '
        Me.lname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lname.DefaultText = ""
        Me.lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lname.Font = New System.Drawing.Font("Montserrat", 15.0!)
        Me.lname.ForeColor = System.Drawing.Color.Black
        Me.lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lname.Location = New System.Drawing.Point(12, 176)
        Me.lname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.lname.Name = "lname"
        Me.lname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lname.PlaceholderText = "Last Name"
        Me.lname.SelectedText = ""
        Me.lname.Size = New System.Drawing.Size(293, 55)
        Me.lname.TabIndex = 23
        '
        'course
        '
        Me.course.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.course.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.course.DefaultText = ""
        Me.course.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.course.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.course.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.course.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.course.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.course.Font = New System.Drawing.Font("Montserrat", 15.0!)
        Me.course.ForeColor = System.Drawing.Color.Black
        Me.course.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.course.Location = New System.Drawing.Point(12, 236)
        Me.course.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.course.Name = "course"
        Me.course.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.course.PlaceholderText = "Course"
        Me.course.SelectedText = ""
        Me.course.Size = New System.Drawing.Size(293, 55)
        Me.course.TabIndex = 24
        '
        'MySqlDataAdapter1
        '
        Me.MySqlDataAdapter1.DeleteCommand = Nothing
        Me.MySqlDataAdapter1.InsertCommand = Nothing
        Me.MySqlDataAdapter1.SelectCommand = Nothing
        Me.MySqlDataAdapter1.UpdateCommand = Nothing
        '
        'btnadd
        '
        Me.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnadd.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnadd.Font = New System.Drawing.Font("IBM Plex Sans", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(12, 300)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(143, 44)
        Me.btnadd.TabIndex = 26
        Me.btnadd.Text = "ADD"
        '
        'btnupdate
        '
        Me.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnupdate.Font = New System.Drawing.Font("IBM Plex Sans", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(162, 300)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(143, 44)
        Me.btnupdate.TabIndex = 28
        Me.btnupdate.Text = "UPDATE"
        '
        'btnclear
        '
        Me.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnclear.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnclear.Font = New System.Drawing.Font("IBM Plex Sans", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(12, 350)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(143, 44)
        Me.btnclear.TabIndex = 29
        Me.btnclear.Text = "CLEAR"
        '
        'btndelete
        '
        Me.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btndelete.Font = New System.Drawing.Font("IBM Plex Sans", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(162, 350)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(143, 44)
        Me.btndelete.TabIndex = 30
        Me.btndelete.Text = "DELETE"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("IBM Plex Sans", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(29, 12)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(261, 37)
        Me.Guna2HtmlLabel1.TabIndex = 31
        Me.Guna2HtmlLabel1.Text = "Student Information"
        '
        'loadbtn
        '
        Me.loadbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.loadbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.loadbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loadbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.loadbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.loadbtn.Font = New System.Drawing.Font("IBM Plex Sans", 15.0!, System.Drawing.FontStyle.Bold)
        Me.loadbtn.ForeColor = System.Drawing.Color.White
        Me.loadbtn.Location = New System.Drawing.Point(12, 400)
        Me.loadbtn.Name = "loadbtn"
        Me.loadbtn.Size = New System.Drawing.Size(293, 44)
        Me.loadbtn.TabIndex = 32
        Me.loadbtn.Text = "LOAD TABLE"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "course"
        Me.Column4.HeaderText = "COURSE"
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "fname"
        Me.Column2.HeaderText = "FIRST NAME"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "lname"
        Me.Column3.HeaderText = "LAST NAME"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "studid"
        Me.Column1.HeaderText = "STUDENT ID"
        Me.Column1.Name = "Column1"
        '
        'dgv1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.BackgroundColor = System.Drawing.Color.White
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("IBM Plex Sans", 15.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.ColumnHeadersHeight = 50
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.EnableHeadersVisualStyles = False
        Me.dgv1.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgv1.Location = New System.Drawing.Point(316, 12)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(633, 497)
        Me.dgv1.TabIndex = 25
        Me.dgv1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.dgv1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgv1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgv1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv1.ThemeStyle.HeaderStyle.Height = 50
        Me.dgv1.ThemeStyle.ReadOnly = False
        Me.dgv1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgv1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv1.ThemeStyle.RowsStyle.Height = 22
        Me.dgv1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.dgv1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("IBM Plex Sans", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 450)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(293, 60)
        Me.Guna2Button1.TabIndex = 33
        Me.Guna2Button1.Text = "SAVE/EXIT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 521)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.loadbtn)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.course)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.studid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam - Database Integration"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents studid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents course As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MySqlDataAdapter1 As MySql.Data.MySqlClient.MySqlDataAdapter
    Friend WithEvents btnadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents loadbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgv1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
