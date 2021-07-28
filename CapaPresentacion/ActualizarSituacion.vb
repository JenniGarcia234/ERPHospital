Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarSituacion
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

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
    Sub Limpiar()
        textBox1.Text = ""
    End Sub
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()

    End Sub

    Private Sub ActualizarSituacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_ingreso],CONVERT(varchar,[id_ingreso])+', '+ CONVERT(varchar,[fecha_ingreso]) as Datos from ingreso"
            Const cmd2 As String = "SELECT [id_habitacion],CONVERT(varchar,[id_habitacion])+', '+ CONVERT(varchar,[no_habitacion]) as Datos from habitacion"
            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)

                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_ingreso"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using


            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd2, sc)

                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox2.ValueMember = "id_habitacion"
                comboBox2.DisplayMember = "Datos"
                comboBox2.DataSource = dt
            End Using
        End Using

    End Sub


    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones3
        Dim logica As New ASituacion
        logica.gId_situacion = Me.textBox1.Text
        If funciones.BuscarSituacion(logica) Then
            Me.comboBox1.Text = logica.gId_ingreso
            Me.comboBox2.Text = logica.gId_habitacion

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim idingreso As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim idlocalizacion As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim funciones As New Operaciones3
        Dim log As New ASituacion
        log.gId_situacion = Me.textBox1.Text
        log.gId_ingreso = idingreso
        log.gId_habitacion = idlocalizacion



        If funciones.ActualizarSituacion(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs)

    End Sub
End Class
