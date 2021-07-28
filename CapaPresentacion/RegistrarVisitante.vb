Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class RegistrarVisitante
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim frm1 As RegistrarDatosComplementarios = New RegistrarDatosComplementarios()
        frm1.Show()
    End Sub

    Private Sub RegistrarVisitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_persona],CONVERT(varchar,[id_persona])+', '+persona.nombre+', '+persona.apellido_p+', '+persona.apellido_m as Datos from persona"
            Const cmd2 As String = "SELECT[id_parentesco], CONVERT(varchar,[id_parentesco])+', ' + CONVERT(varchar,[descripcion]) as Datos From parentesco"

            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_persona"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using

            Using sda1 As SqlDataAdapter = New SqlDataAdapter(cmd2, sc)
                Dim dt As DataTable = New DataTable()
                sda1.Fill(dt)
                comboBox2.ValueMember = "id_parentesco"
                comboBox2.DisplayMember = "Datos"
                comboBox2.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim idpersona As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim idda As Integer = Convert.ToInt32(comboBox2.SelectedValue)

        Dim conexion As New SqlConnection("Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True")
        Dim command As New SqlCommand("Insertar_visitante", conexion)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@id_visitante", textBox1.Text)
        command.Parameters.AddWithValue("@id_persona", idpersona)
        command.Parameters.AddWithValue("@id_datos_c", textBox2.Text)
        command.Parameters.AddWithValue("@id_parentesco", idda)

        Try
            conexion.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Dispose()
            command.Dispose()
            MsgBox("REGISTRO ALMACENADO")
            Limpiar()
        End Try
    End Sub

    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Me.Close()
        Dim frm1 As MVisitante = New MVisitante()
        frm1.Show()
    End Sub
End Class