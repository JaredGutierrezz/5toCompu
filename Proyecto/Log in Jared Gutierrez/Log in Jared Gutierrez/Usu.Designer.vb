<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_mostrar = New Guna.UI.WinForms.GunaButton()
        Me.GDGV_A3 = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.GDGV_A3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GunaLinePanel1.Controls.Add(Me.GunaPictureBox2)
        Me.GunaLinePanel1.Controls.Add(Me.Label5)
        Me.GunaLinePanel1.Controls.Add(Me.Label1)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(-6, -2)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(595, 103)
        Me.GunaLinePanel1.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(302, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 26)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 26)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Guti Launcher"
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
        Me.btn_mostrar.Location = New System.Drawing.Point(50, 208)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_mostrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_mostrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_mostrar.OnHoverImage = Nothing
        Me.btn_mostrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_mostrar.Radius = 10
        Me.btn_mostrar.Size = New System.Drawing.Size(97, 56)
        Me.btn_mostrar.TabIndex = 51
        Me.btn_mostrar.Text = "     Mostrar"
        '
        'GDGV_A3
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.GDGV_A3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.GDGV_A3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GDGV_A3.BackgroundColor = System.Drawing.Color.White
        Me.GDGV_A3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GDGV_A3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDGV_A3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDGV_A3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.GDGV_A3.ColumnHeadersHeight = 4
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GDGV_A3.DefaultCellStyle = DataGridViewCellStyle9
        Me.GDGV_A3.EnableHeadersVisualStyles = False
        Me.GDGV_A3.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A3.Location = New System.Drawing.Point(207, 140)
        Me.GDGV_A3.Name = "GDGV_A3"
        Me.GDGV_A3.RowHeadersVisible = False
        Me.GDGV_A3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GDGV_A3.Size = New System.Drawing.Size(282, 224)
        Me.GDGV_A3.TabIndex = 50
        Me.GDGV_A3.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GDGV_A3.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GDGV_A3.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GDGV_A3.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GDGV_A3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GDGV_A3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GDGV_A3.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GDGV_A3.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A3.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A3.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GDGV_A3.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GDGV_A3.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GDGV_A3.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDGV_A3.ThemeStyle.HeaderStyle.Height = 4
        Me.GDGV_A3.ThemeStyle.ReadOnly = False
        Me.GDGV_A3.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GDGV_A3.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDGV_A3.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GDGV_A3.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDGV_A3.ThemeStyle.RowsStyle.Height = 22
        Me.GDGV_A3.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDGV_A3.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.Usuarios.My.Resources.Resources.boton__1_
        Me.GunaPictureBox2.Location = New System.Drawing.Point(527, 14)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(48, 27)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 53
        Me.GunaPictureBox2.TabStop = False
        '
        'Usu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 450)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.GDGV_A3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Usu"
        Me.Text = "Usu"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.GDGV_A3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_mostrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GDGV_A3 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
End Class
