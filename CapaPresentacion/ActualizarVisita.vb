Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarVisita
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub ActualizarVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_paciente],CONVERT(varchar,[id_paciente]) as Datos from paciente"
            Const cmd2 As String = "SELECT [id_visitante],CONVERT(varchar,[id_visitante]) as Datos from visitante"

            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_paciente"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using

            Using sda1 As SqlDataAdapter = New SqlDataAdapter(cmd2, sc)
                Dim dt As DataTable = New DataTable()
                sda1.Fill(dt)
                comboBox2.ValueMember = "id_visitante"
                comboBox2.DisplayMember = "Datos"
                comboBox2.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim idpaciente As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim idvisitante As Integer = Convert.ToInt32(comboBox2.SelectedValue)

        Dim funciones As New Operaciones3
        Dim log As New AVisita
        log.gId_visita = Me.textBox1.Text
        log.gId_paciente = idpaciente
        log.gId_visitante = idvisitante
        log.gFecha = Me.textBox2.Text
        log.gIngreso = Me.textBox3.Text
        log.gEgreso = Me.TextBox4.Text

        If funciones.ActualizarVisita(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Me.Close()
        Dim frm1 As MVisitante = New MVisitante()
        frm1.Show()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones3
        Dim logica As New AVisita
        logica.gId_visita = Me.textBox1.Text
        If funciones.BuscarVisita(logica) Then
            Me.comboBox1.Text = logica.gId_paciente
            Me.comboBox2.Text = logica.gId_visitante
            Me.textBox2.Text = logica.gFecha
            Me.textBox3.Text = logica.gIngreso
            Me.TextBox4.Text = logica.gEgreso

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs)

    End Sub
End Class