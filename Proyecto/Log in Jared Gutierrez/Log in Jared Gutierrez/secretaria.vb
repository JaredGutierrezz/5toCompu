Imports System.Data.SqlClient

Public Class secretaria
    Dim con As New SqlConnection(My.Settings.Log_in)
    Dim mensaje, sentencia As String
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("select * from Usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GDGV_A2.Columns("Contraseña").Visible = False

            Me.GDGV_A2.DataSource = ds.Tables(0)
            Me.GDGV_A2.Columns("Contraseña").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GunaLinePanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaLinePanel1.Paint

    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub GDGV_A2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GDGV_A2.CellContentClick

    End Sub

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim da As New SqlDataAdapter("Select *from Usuario where Usuario = '" + txt_usuario.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.GDGV_A2.Columns("Contraseña").Visible = False
        Me.GDGV_A2.DataSource = ds.Tables(0)
        Me.GDGV_A2.Columns("Contraseña").Visible = False
    End Sub

End Class