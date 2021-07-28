Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class Egresos
    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Me.Close()
        Dim frm1 As MPaciente = New MPaciente()
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

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Sub Limpiar()
        textBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim idpersona As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim funciones As New Operaciones4
        Dim log As New AEgreso
        log.gId_egreso1 = Me.textBox1.Text
        log.gId_paciente1 = idpersona
        log.gFecha_egreso1 = Me.TextBox2.Text

        If funciones.InsertarEgreso(log) Then
            MsgBox("REGISTRO ALMACENADO")
            Limpiar()
        End If
    End Sub

    Private Sub Egresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_paciente],CONVERT(varchar,[id_paciente]) as Datos from paciente"


            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_paciente"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using


        End Using
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim idpersona As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim funciones As New Operaciones4
        Dim log As New AEgreso
        log.gId_egreso1 = Me.textBox1.Text
        log.gId_paciente1 = idpersona
        log.gFecha_egreso1 = Me.TextBox2.Text

        If funciones.ActualizarEgreso(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones4
        Dim logica As New AEgreso
        logica.gId_egreso1 = Me.textBox1.Text
        If funciones.BuscarEgreso(logica) Then
            Me.comboBox1.Text = logica.gId_paciente1
            Me.TextBox2.Text = logica.gFecha_egreso1


            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim funciones As New Operaciones4
        Dim log As New AEgreso
        log.gId_egreso1 = Me.textBox1.Text

        If funciones.EliminarEgreso(log) Then
            MsgBox("REGISTRO ELIMINADO")
            Limpiar()
        End If
    End Sub
End Class