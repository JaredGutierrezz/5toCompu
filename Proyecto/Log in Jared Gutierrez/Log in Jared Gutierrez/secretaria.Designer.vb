<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class secretaria
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GDGV_A2 = New Guna.UI.WinForms.GunaDataGridView()
        Me.btn_mostrar = New Guna.UI.WinForms.GunaButton()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar = New Guna.UI.WinForms.GunaButton()
        Me.txt_usuario = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GDGV_A2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GDGV_A2
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.GDGV_A2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.GDGV_A2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GDGV_A2.BackgroundColor = System.Drawing.Color.White
        Me.GDGV_A2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GDGV_A2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDGV_A2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDGV_A2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.GDGV_A2.ColumnHeadersHeight = 4
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GDGV_A2.DefaultCellStyle = DataGridViewCellStyle9
        Me.GDGV_A2.EnableHeadersVisualStyles = False
        Me.GDGV_A2.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A2.Location = New System.Drawing.Point(244, 115)
        Me.GDGV_A2.Name = "GDGV_A2"
        Me.GDGV_A2.RowHeadersVisible = False
        Me.GDGV_A2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GDGV_A2.Size = New System.Drawing.Size(282, 224)
        Me.GDGV_A2.TabIndex = 43
        Me.GDGV_A2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GDGV_A2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GDGV_A2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GDGV_A2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GDGV_A2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GDGV_A2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GDGV_A2.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GDGV_A2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GDGV_A2.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GDGV_A2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GDGV_A2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDGV_A2.ThemeStyle.HeaderStyle.Height = 4
        Me.GDGV_A2.ThemeStyle.ReadOnly = False
        Me.GDGV_A2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GDGV_A2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDGV_A2.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GDGV_A2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDGV_A2.ThemeStyle.RowsStyle.Height = 22
        Me.GDGV_A2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btn_mostrar
        '
        Me.btn_mostrar.AnimationHoverSpeed = 0.07!
        Me.btn_mostrar.AnimationSpeed = 0.03!
        Me.btn_mostrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_mostrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_mostrar.BorderColor = System.Drawing.Color.Black
        Me.btn_mostrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_mostrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_mostrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_mostrar.ForeColor = System.Drawing.Color.White
        Me.btn_mostrar.Image = Nothing
        Me.btn_mostrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_mostrar.Location = New System.Drawing.Point(115, 293)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_mostrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_mostrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_mostrar.OnHoverImage = Nothing
        Me.btn_mostrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_mostrar.Radius = 10
        Me.btn_mostrar.Size = New System.Drawing.Size(97, 56)
        Me.btn_mostrar.TabIndex = 44
        Me.btn_mostrar.Text = "     Mostrar"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GunaLinePanel1.Controls.Add(Me.GunaPictureBox2)
        Me.GunaLinePanel1.Controls.Add(Me.Label5)
        Me.GunaLinePanel1.Controls.Add(Me.Label1)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(-6, -4)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(577, 99)
        Me.GunaLinePanel1.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(302, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 26)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Secretario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 26)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Guti Launcher"
        '
        'btn_buscar
        '
        Me.btn_buscar.AnimationHoverSpeed = 0.07!
        Me.btn_buscar.AnimationSpeed = 0.03!
        Me.btn_buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_buscar.BorderColor = System.Drawing.Color.Black
        Me.btn_buscar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_buscar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_buscar.ForeColor = System.Drawing.Color.White
        Me.btn_buscar.Image = Nothing
        Me.btn_buscar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_buscar.Location = New System.Drawing.Point(12, 293)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_buscar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_buscar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_buscar.OnHoverImage = Nothing
        Me.btn_buscar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_buscar.Radius = 10
        Me.btn_buscar.Size = New System.Drawing.Size(97, 56)
        Me.btn_buscar.TabIndex = 47
        Me.btn_buscar.Text = "     Buscar"
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.Transparent
        Me.txt_usuario.BaseColor = System.Drawing.Color.White
        Me.txt_usuario.BorderColor = System.Drawing.Color.Silver
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_usuario.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_usuario.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_usuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_usuario.Location = New System.Drawing.Point(114, 186)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.Radius = 10
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.Size = New System.Drawing.Size(98, 26)
        Me.txt_usuario.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Usuario :"
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.Usuarios.My.Resources.Resources.boton__1_
        Me.GunaPictureBox2.Location = New System.Drawing.Point(498, 16)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(48, 27)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 20
        Me.GunaPictureBox2.TabStop = False
        '
        'secretaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 373)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.GDGV_A2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "secretaria"
        Me.Text = "secretaria"
        CType(Me.GDGV_A2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GDGV_A2 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btn_mostrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txt_usuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
End Class
