Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarUsuario
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim idempleado As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim idfuncion As Integer = Convert.ToInt32(comboBox2.SelectedValue)
        Dim funciones As New Operaciones
        Dim log As New AUsuario
        log.gId_usuario = Me.textBox1.Text
        log.gId_empleado = idempleado
        log.gNombre_usuario = Me.textBox2.Text
        log.gContraseña = Me.textBox3.Text
        log.gId_funcion = idfuncion



        If funciones.ActualizarUsuario(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Me.Close()
        Dim frm1 As MUsuario = New MUsuario()
        frm1.Show()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones
        Dim logica As New AUsuario
        logica.gId_usuario = Me.textBox1.Text
        If funciones.BuscarUsuario(logica) Then
            Me.comboBox1.Text = logica.gId_empleado
            Me.textBox2.Text = logica.gNombre_usuario
            Me.textBox3.Text = logica.gContraseña
            Me.comboBox2.Text = logica.gId_empleado

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub ActualizarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = " SELECT empleado.id_empleado,persona.id_persona,CONVERT(varchar,persona.id_persona)+', '+persona.nombre+', '+persona.apellido_p+', '+persona.apellido_m as Datos From persona inner join  empleado ON empleado.id_persona = persona.id_persona  "
            Const cmd2 As String = " SELECT[id_funcion], CONVERT(varchar,[id_funcion])+', ' + CONVERT(varchar,[privilegio]) as Datos From funcion"
            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_empleado"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using

            Using sda1 As SqlDataAdapter = New SqlDataAdapter(cmd2, sc)
                Dim dt As DataTable = New DataTable()
                sda1.Fill(dt)
                comboBox2.ValueMember = "id_funcion"
                comboBox2.DisplayMember = "Datos"
                comboBox2.DataSource = dt
            End Using
        End Using
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""

    End Sub
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim frm1 As Usuario = New Usuario()
        frm1.Show()
    End Sub
End Class