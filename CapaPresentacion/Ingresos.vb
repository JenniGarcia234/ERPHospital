Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class Ingresos
    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim idpersona As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim idparentesco As Integer = Convert.ToInt32(comboBox2.SelectedValue)

        Dim funciones As New Operaciones4
        Dim log As New AIngreso
        log.gId_ingreso1 = Me.textBox1.Text
        log.gId_paciente1 = idpersona
        log.gId_tipo_ingreso1 = idparentesco
        log.gFecha_ingreso1 = Me.textBox2.Text

        If funciones.InsertarIngreso(log) Then
            MsgBox("REGISTRO ALMACENADO")
            Limpiar()
        End If
    End Sub


    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub Ingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_paciente],CONVERT(varchar,[id_paciente]) as Datos from paciente"
            Const cmd2 As String = "SELECT[id_tipo_ingreso], CONVERT(varchar,[tipo]) as Datos From tipo_ingreso"

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
                comboBox2.ValueMember = "id_tipo_ingreso"
                comboBox2.DisplayMember = "Datos"
                comboBox2.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim idpersona As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim idparentesco As Integer = Convert.ToInt32(comboBox2.SelectedValue)

        Dim funciones As New Operaciones4
        Dim log As New AIngreso
        log.gId_ingreso1 = Me.textBox1.Text
        log.gId_paciente1 = idpersona
        log.gId_tipo_ingreso1 = idparentesco
        log.gFecha_ingreso1 = Me.textBox2.Text

        If funciones.ActualizarIngreso(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones4
        Dim logica As New AIngreso
        logica.gId_ingreso1 = Me.textBox1.Text
        If funciones.BuscarIngreso(logica) Then
            Me.comboBox1.Text = logica.gId_paciente1
            Me.comboBox2.Text = logica.gId_tipo_ingreso1
            Me.textBox2.Text = logica.gFecha_ingreso1


            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim funciones As New Operaciones4
        Dim log As New AIngreso
        log.gId_ingreso1 = Me.textBox1.Text

        If funciones.EliminarIngreso(log) Then
            MsgBox("REGISTRO ELIMINADO")
            Limpiar()
        End If
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Me.Close()
        Dim frm1 As MPaciente = New MPaciente()
        frm1.Show()
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click

    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click

    End Sub

    Private Sub comboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox2.SelectedIndexChanged

    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox1.SelectedIndexChanged

    End Sub

    Private Sub textBox2_TextChanged(sender As Object, e As EventArgs) Handles textBox2.TextChanged

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged

    End Sub

    Private Sub label5_Click(sender As Object, e As EventArgs) Handles label5.Click

    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click

    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click

    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click

    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub
End Class