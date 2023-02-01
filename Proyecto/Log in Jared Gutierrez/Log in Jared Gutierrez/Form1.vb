Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class Form1
    Dim con As New SqlConnection(My.Settings.Log_in)
    Dim conexion As conexion = New conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub txt_contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_contraseña.TextChanged

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim usuario As String
        Dim contraseña As String
        usuario = txt_usuario.Text
        contraseña = txt_contraseña.Text
        Dim verificar As String = "Update Usuario set Usuario = Usuario where Usuario = '" + txt_usuario.Text + "' AND Contraseña = '" + txt_contraseña.Text + "' and Roll='Administrador'"
        If conexion.Verificacion(verificar) Then
            Me.Hide()
            MsgBox("Administrador")
            administrador.Show()
            txt_contraseña.Text = ""
            txt_usuario.Text = ""
        Else
            Dim verificar2 As String = "Update Usuario set Usuario=Usuario where Usuario = '" + txt_usuario.Text + "' AND Contraseña = '" + txt_contraseña.Text + "' and ROLL='Usuario'"
            If conexion.Verificacion(verificar2) Then
                Me.Hide()
                MsgBox("Usuario")
                Usu.Show()
                txt_contraseña.Text = ""
                txt_usuario.Text = ""

            Else

                Dim verificar3 As String = "Update Usuario set Usuario=Usuario where Usuario= '" + txt_usuario.Text + "' AND Contraseña = '" + txt_contraseña.Text + "' and ROLL='Secretario'"
                If conexion.Verificacion(verificar3) Then
                    Me.Hide()
                    MsgBox("Secretariado")
                    secretaria.Show()
                    txt_contraseña.Text = ""
                    txt_usuario.Text = ""
                Else
                    MsgBox("Los datos no coiciden")
                    txt_contraseña.Text = ""
                    txt_usuario.Text = ""
                End If
            End If

        End If
    End Sub

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Me.Close()
    End Sub
End Class
