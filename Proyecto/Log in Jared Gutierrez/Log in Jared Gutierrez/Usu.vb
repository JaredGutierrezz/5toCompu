Imports System.Data.SqlClient

Public Class Usu
    Dim con As New SqlConnection(My.Settings.Log_in)
    Dim mensaje, sentencia As String

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("select * from Usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GDGV_A3.Columns("Contraseña").Visible = False

            Me.GDGV_A3.DataSource = ds.Tables(0)
            Me.GDGV_A3.Columns("Contraseña").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class