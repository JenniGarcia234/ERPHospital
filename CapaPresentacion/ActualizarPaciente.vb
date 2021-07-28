Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarPaciente
    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Dim f2 As New MPaciente
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Dim f2 As New Menu
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click

        Limpiar()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones2
        Dim logica As New APaciente
        logica.gId_paciente = Me.textBox1.Text
        If funciones.BuscarPaciente(logica) Then
            Me.comboBox1.Text = logica.gId_persona
            Me.textBox2.Text = logica.gId_datosc
            Me.textBox3.Text = logica.gId_tarjeta
            Me.textBox4.Text = logica.gId_poliza

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim id_persona As Integer = Convert.ToInt32(comboBox1.SelectedValue)


        Dim funciones As New Operaciones2
        Dim log As New APaciente
        log.gId_paciente = Me.textBox1.Text
        log.gId_persona = id_persona
        log.gId_datosc = Me.textBox2.Text
        log.gId_tarjeta = Me.textBox3.Text
        log.gId_poliza = Me.textBox4.Text


        If funciones.ActualizarPaciente(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim f2 As New ActualizarDatosComplementarios
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim f2 As New ActualizarTarjeta
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim f2 As New ActualizarSeguro
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub ActualizarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class