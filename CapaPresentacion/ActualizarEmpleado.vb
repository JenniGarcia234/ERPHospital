Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarEmpleado
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones
        Dim logica As New AEmpleado
        logica.gId_empleado = Me.textBox1.Text
        If funciones.BuscarEmpleado(logica) Then
            Me.comboBox1.Text = logica.gId_persona
            Me.textBox2.Text = logica.gId_datos_c
            Me.textBox3.Text = logica.gRfc
            Me.TextBox4.Text = logica.gCurp
            Me.comboBox2.Text = logica.gId_grado
            Me.comboBox3.Text = logica.gId_puesto

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim frm1 As ActualizarDatosComplementarios = New ActualizarDatosComplementarios()
        frm1.Show()
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Me.Close()
        Dim frm1 As MEmpleado = New MEmpleado()
        frm1.Show()
    End Sub

    Private Sub ActualizarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_persona],CONVERT(varchar,[id_persona])+', '+persona.nombre+', '+persona.apellido_p+', '+persona.apellido_m as Datos from persona"
            Const cmd2 As String = "SELECT[id_grado], CONVERT(varchar,[id_grado])+', ' + CONVERT(varchar,[nombre]) as Datos From grado"
            Const cmd3 As String = "SELECT[id_puesto], CONVERT(varchar,[id_puesto])+', ' + CONVERT(varchar,[nombre_puesto]) as Datos From puesto"
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
                comboBox2.ValueMember = "id_grado"
                comboBox2.DisplayMember = "Datos"
                comboBox2.DataSource = dt
            End Using

            Using sda1 As SqlDataAdapter = New SqlDataAdapter(cmd3, sc)
                Dim dt As DataTable = New DataTable()
                sda1.Fill(dt)
                comboBox3.ValueMember = "id_puesto"
                comboBox3.DisplayMember = "Datos"
                comboBox3.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim iddatosc As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim idgrado As Integer = Convert.ToInt32(comboBox2.SelectedValue)
        Dim idpuesto As Integer = Convert.ToInt32(comboBox2.SelectedValue)
        Dim funciones As New Operaciones
        Dim log As New AEmpleado
        log.gId_empleado = Me.textBox1.Text
        log.gId_persona = iddatosc
        log.gId_datos_c = Me.textBox2.Text
        log.gRfc = Me.textBox3.Text
        log.gCurp = Me.TextBox4.Text
        log.gId_grado = idgrado
        log.gId_puesto = idpuesto

        If funciones.ActualizarEmpleado(log) Then
            MsgBox("REGISTRO ALMACENADO")
            Limpiar()
        End If
    End Sub

    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
    End Sub
End Class