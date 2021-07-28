Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarPersona
    Private Sub btn_Identificacion_Click(sender As Object, e As EventArgs) Handles btn_Identificacion.Click
        Dim f2 As New ActualizarIdentificacion
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim ididentificacion As Integer = Convert.ToInt32(comboBox1.SelectedValue)

        Dim funciones As New Operaciones
        Dim log As New APersona
        log.gId_persona = Me.textBox1.Text
        log.gNombre = Me.textBox2.Text
        log.gApellido_p = Me.textBox3.Text
        log.gApellido_m = Me.textBox4.Text
        log.gId_identificacion = ididentificacion

        If funciones.ActualizarPersona(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones
        Dim logica As New APersona
        logica.gId_persona = Me.textBox1.Text
        If funciones.BuscarPersona(logica) Then
            Me.textBox2.Text = logica.gNombre
            Me.textBox3.Text = logica.gApellido_p
            Me.textBox4.Text = logica.gApellido_m
            Me.comboBox1.Text = logica.gId_identificacion

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Public Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""


    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Dim f2 As New MPersonas
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Dim f2 As New Menu
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_VerRegistros_Click(sender As Object, e As EventArgs) Handles btn_VerRegistros.Click
        Dim f2 As New Persona
        f2.Show()
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox1.SelectedIndexChanged

    End Sub

    Private Sub textBox4_TextChanged(sender As Object, e As EventArgs) Handles textBox4.TextChanged

    End Sub

    Private Sub textBox3_TextChanged(sender As Object, e As EventArgs) Handles textBox3.TextChanged

    End Sub

    Private Sub textBox2_TextChanged(sender As Object, e As EventArgs) Handles textBox2.TextChanged

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged

    End Sub

    Private Sub label8_Click(sender As Object, e As EventArgs) Handles label8.Click

    End Sub

    Private Sub label7_Click(sender As Object, e As EventArgs) Handles label7.Click

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

    Private Sub ActualizarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()
            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_identificacion],CONVERT(varchar,[id_identificacion])+', '+[folio] as Datos From identificacion"

            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_identificacion"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using
        End Using
    End Sub
End Class