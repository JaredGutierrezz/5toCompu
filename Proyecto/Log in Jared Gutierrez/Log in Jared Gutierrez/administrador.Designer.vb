<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrador
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.txt_usuario = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_contra = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_rol = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_eliminar = New Guna.UI.WinForms.GunaButton()
        Me.btn_mostrar = New Guna.UI.WinForms.GunaButton()
        Me.GDGV_A = New Guna.UI.WinForms.GunaDataGridView()
        Me.btn_Guardar = New Guna.UI.WinForms.GunaButton()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GDGV_A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Roll :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Contraseña :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Usuario :"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
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
        Me.txt_usuario.Location = New System.Drawing.Point(105, 132)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.Radius = 10
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.Size = New System.Drawing.Size(98, 26)
        Me.txt_usuario.TabIndex = 37
        '
        'txt_contra
        '
        Me.txt_contra.BackColor = System.Drawing.Color.Transparent
        Me.txt_contra.BaseColor = System.Drawing.Color.White
        Me.txt_contra.BorderColor = System.Drawing.Color.Silver
        Me.txt_contra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_contra.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_contra.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_contra.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_contra.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_contra.Location = New System.Drawing.Point(118, 180)
        Me.txt_contra.Name = "txt_contra"
        Me.txt_contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contra.Radius = 10
        Me.txt_contra.SelectedText = ""
        Me.txt_contra.Size = New System.Drawing.Size(98, 26)
        Me.txt_contra.TabIndex = 38
        '
        'txt_rol
        '
        Me.txt_rol.BackColor = System.Drawing.Color.Transparent
        Me.txt_rol.BaseColor = System.Drawing.Color.White
        Me.txt_rol.BorderColor = System.Drawing.Color.Silver
        Me.txt_rol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_rol.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_rol.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_rol.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_rol.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_rol.Location = New System.Drawing.Point(94, 224)
        Me.txt_rol.Name = "txt_rol"
        Me.txt_rol.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_rol.Radius = 10
        Me.txt_rol.SelectedText = ""
        Me.txt_rol.Size = New System.Drawing.Size(98, 26)
        Me.txt_rol.TabIndex = 39
        '
        'btn_eliminar
        '
        Me.btn_eliminar.AnimationHoverSpeed = 0.07!
        Me.btn_eliminar.AnimationSpeed = 0.03!
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_eliminar.BorderColor = System.Drawing.Color.Black
        Me.btn_eliminar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_eliminar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_eliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Image = Nothing
        Me.btn_eliminar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_eliminar.Location = New System.Drawing.Point(28, 275)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_eliminar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_eliminar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_eliminar.OnHoverImage = Nothing
        Me.btn_eliminar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_eliminar.Radius = 10
        Me.btn_eliminar.Size = New System.Drawing.Size(59, 27)
        Me.btn_eliminar.TabIndex = 40
        Me.btn_eliminar.Text = "Eliminar"
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
        Me.btn_mostrar.Location = New System.Drawing.Point(94, 296)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_mostrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_mostrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_mostrar.OnHoverImage = Nothing
        Me.btn_mostrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_mostrar.Radius = 10
        Me.btn_mostrar.Size = New System.Drawing.Size(59, 27)
        Me.btn_mostrar.TabIndex = 41
        Me.btn_mostrar.Text = "Mostrar"
        '
        'GDGV_A
        '
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.White
        Me.GDGV_A.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.GDGV_A.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GDGV_A.BackgroundColor = System.Drawing.Color.White
        Me.GDGV_A.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GDGV_A.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDGV_A.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDGV_A.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.GDGV_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GDGV_A.DefaultCellStyle = DataGridViewCellStyle24
        Me.GDGV_A.EnableHeadersVisualStyles = False
        Me.GDGV_A.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A.Location = New System.Drawing.Point(251, 108)
        Me.GDGV_A.Name = "GDGV_A"
        Me.GDGV_A.RowHeadersVisible = False
        Me.GDGV_A.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GDGV_A.Size = New System.Drawing.Size(281, 238)
        Me.GDGV_A.TabIndex = 42
        Me.GDGV_A.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GDGV_A.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GDGV_A.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GDGV_A.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GDGV_A.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GDGV_A.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GDGV_A.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GDGV_A.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GDGV_A.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GDGV_A.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GDGV_A.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GDGV_A.ThemeStyle.HeaderStyle.Height = 4
        Me.GDGV_A.ThemeStyle.ReadOnly = False
        Me.GDGV_A.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GDGV_A.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDGV_A.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GDGV_A.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDGV_A.ThemeStyle.RowsStyle.Height = 22
        Me.GDGV_A.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btn_Guardar
        '
        Me.btn_Guardar.AnimationHoverSpeed = 0.07!
        Me.btn_Guardar.AnimationSpeed = 0.03!
        Me.btn_Guardar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Guardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Guardar.BorderColor = System.Drawing.Color.Black
        Me.btn_Guardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Guardar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Guardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_Guardar.ForeColor = System.Drawing.Color.White
        Me.btn_Guardar.Image = Nothing
        Me.btn_Guardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Guardar.Location = New System.Drawing.Point(28, 319)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Guardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Guardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Guardar.OnHoverImage = Nothing
        Me.btn_Guardar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Guardar.Radius = 10
        Me.btn_Guardar.Size = New System.Drawing.Size(59, 27)
        Me.btn_Guardar.TabIndex = 43
        Me.btn_Guardar.Text = "Guardar"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GunaLinePanel1.Controls.Add(Me.GunaPictureBox2)
        Me.GunaLinePanel1.Controls.Add(Me.Label5)
        Me.GunaLinePanel1.Controls.Add(Me.Label1)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, -10)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(568, 99)
        Me.GunaLinePanel1.TabIndex = 45
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(302, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 26)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Administrador"
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.Usuarios.My.Resources.Resources.boton__1_
        Me.GunaPictureBox2.Location = New System.Drawing.Point(509, 22)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(48, 27)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 19
        Me.GunaPictureBox2.TabStop = False
        '
        'administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 376)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.GDGV_A)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.txt_rol)
        Me.Controls.Add(Me.txt_contra)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "administrador"
        Me.Text = "administrador"
        CType(Me.GDGV_A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents txt_usuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_rol As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_contra As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_mostrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_eliminar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_Guardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GDGV_A As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
End Class
