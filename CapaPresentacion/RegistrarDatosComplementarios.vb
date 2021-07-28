Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class RegistrarDatosComplementarios
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim frm1 As RegistrarDireccion = New RegistrarDireccion()
        frm1.Show()
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click

        Dim conexion As New SqlConnection("Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True")
        Dim command As New SqlCommand("Insertar_datos_c", conexion)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@id_datos_c", textBox1.Text)
        command.Parameters.AddWithValue("@id_direccion", textBox2.Text)
        command.Parameters.AddWithValue("@telefono_fijo", textBox3.Text)
        command.Parameters.AddWithValue("@telefono_movil", textBox4.Text)

        Try
            conexion.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Dispose()
            command.Dispose()
            MsgBox("REGISTRO ALMACENADO")
        End Try
    End Sub

    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub
End Class