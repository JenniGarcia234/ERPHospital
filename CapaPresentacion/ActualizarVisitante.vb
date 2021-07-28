Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarVisitante
    Private Sub ActualizarVisitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
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
        Dim logica As New AVisitante
        logica.gId_visitante = Me.textBox1.Text
        If funciones.BuscarVisitante(logica) Then
            Me.comboBox1.Text = logica.gId_persona
            Me.textBox2.Text = logica.gId_datosc
            Me.comboBox2.Text = logica.gId_parentesco


            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim frm1 As ActualizarDatosComplementarios = New ActualizarDatosComplementarios()
        frm1.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim f2 As New Visitante
        f2.Show()
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim idpersona As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim idda As Integer = Convert.ToInt32(comboBox2.SelectedValue)
        Dim funciones As New Operaciones3
        Dim log As New AVisitante
        log.gId_visitante = Me.textBox1.Text
        log.gId_persona = idpersona
        log.gId_datosc = Me.textBox2.Text
        log.gId_parentesco = idda

        If funciones.ActualizarVisitante(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub
End Class