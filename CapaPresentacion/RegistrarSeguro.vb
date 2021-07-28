Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class RegistrarSeguro
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""

    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub RegistrarSeguro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()

            Const cmd As String = "SELECT[id_aseguradora], CONVERT(varchar,[id_aseguradora])+', ' + CONVERT(varchar,[nombre]) as Datos From aseguradoras"
            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_aseguradora"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using

        End Using
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim id_aseguradora As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim conexion As New SqlConnection("Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True")
        Dim command As New SqlCommand("Insertar_seguro", conexion)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@id_poliza", textBox1.Text)
        command.Parameters.AddWithValue("@no_poliza", textBox2.Text)
        command.Parameters.AddWithValue("@monto", textBox3.Text)
        command.Parameters.AddWithValue("@id_aseguradora", id_aseguradora)

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

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged

    End Sub
End Class