<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_usuario = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_contraseña = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseñas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuarios:"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GunaLinePanel1.Controls.Add(Me.GunaPictureBox2)
        Me.GunaLinePanel1.Controls.Add(Me.Label4)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(-8, -9)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(370, 77)
        Me.GunaLinePanel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 26)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Guti Launcher"
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
        Me.txt_usuario.Location = New System.Drawing.Point(118, 171)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.Radius = 10
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.Size = New System.Drawing.Size(139, 26)
        Me.txt_usuario.TabIndex = 14
        '
        'txt_contraseña
        '
        Me.txt_contraseña.BackColor = System.Drawing.Color.Transparent
        Me.txt_contraseña.BaseColor = System.Drawing.Color.White
        Me.txt_contraseña.BorderColor = System.Drawing.Color.Silver
        Me.txt_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_contraseña.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_contraseña.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_contraseña.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_contraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contraseña.Location = New System.Drawing.Point(118, 211)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contraseña.Radius = 10
        Me.txt_contraseña.SelectedText = ""
        Me.txt_contraseña.Size = New System.Drawing.Size(139, 26)
        Me.txt_contraseña.TabIndex = 15
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(146, 269)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 10
        Me.GunaButton1.Size = New System.Drawing.Size(59, 27)
        Me.GunaButton1.TabIndex = 17
        Me.GunaButton1.Text = "     Ir"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Usuarios.My.Resources.Resources.usuario_de_perfil
        Me.GunaPictureBox1.Location = New System.Drawing.Point(132, 74)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(89, 76)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 13
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.Usuarios.My.Resources.Resources.boton__1_
        Me.GunaPictureBox2.Location = New System.Drawing.Point(293, 21)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(48, 27)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 18
        Me.GunaPictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 333)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_contraseña As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_usuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
End Class
