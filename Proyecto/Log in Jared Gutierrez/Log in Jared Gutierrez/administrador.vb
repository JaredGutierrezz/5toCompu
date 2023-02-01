Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class administrador
    Dim con As New SqlConnection(My.Settings.Log_in)
    Dim mensaje, sentencia As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sentencia = "DELETE FROM Usuario WHERE Usuario = '" + txt_usuario.Text + "'"
        mensaje = "Datos eliminados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *from Usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GDGV_A.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("select * from Usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GDGV_A.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        sentencia = "Insert into Usuario values('" + txt_usuario.Text + "', '" + txt_contra.Text + "', '" + txt_rol.Text + "')"
        mensaje = "Datos ingresados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from Usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GDGV_A.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txt_contra.Text = ""
        txt_usuario.Text = ""
        txt_rol.Text = ""
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs)
        sentencia = "Update Usuario set Usuario = '" + txt_usuario.Text + "', Contraseña = '" + txt_contra.Text + "', Roll = '" + txt_rol.Text + "'"
        mensaje = "Datos actualizados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GDGV_A.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txt_contra.Text = ""
        txt_usuario.Text = ""
        txt_rol.Text = ""
    End Sub

    Private Sub administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Form1.Show()
        Me.Hide()



    End Sub

    Sub ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
