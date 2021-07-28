Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class RegistrarPaciente
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim f2 As New RegistrarDatosComplementarios
        f2.Show()

    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim id_persona As Integer = Convert.ToInt32(comboBox1.SelectedValue)


        Dim funciones As New Operaciones2
        Dim log As New APaciente
        log.gId_paciente = Me.textBox1.Text
        log.gId_persona = id_persona
        log.gId_datosc = Me.textBox2.Text
        log.gId_tarjeta = Me.textBox3.Text
        log.gId_poliza = Me.textBox4.Text


        If funciones.InsertarPaciente(log) Then
            MsgBox("REGISTRO INSERTADO")
            Limpiar()
        End If

    End Sub


    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Dim f2 As New MPaciente
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Dim f2 As New Menu
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub RegistrarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_persona],CONVERT(varchar,[id_persona])+', '+persona.nombre+', '+persona.apellido_p+', '+persona.apellido_m as Datos from persona"

            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)

                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_persona"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using
        End Using

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim f2 As New RegistrarTarjeta
        f2.Show()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim f2 As New RegistrarSeguro
        f2.Show()

    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        Dim f2 As New Paciente
        f2.Show()
    End Sub
End Class