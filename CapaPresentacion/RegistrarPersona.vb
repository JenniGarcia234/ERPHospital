Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class RegistrarPersona
    Private Sub btn_Identificacion_Click(sender As Object, e As EventArgs) Handles btn_Identificacion.Click
        Dim f2 As New RegistrarIdentificacion
        f2.Show()

    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim ididentificacion As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim funciones As New Operaciones
        Dim log As New APersona
        log.gId_persona = Me.textBox1.Text
        log.gNombre = Me.textBox2.Text
        log.gApellido_p = Me.textBox3.Text
        log.gApellido_m = Me.textBox4.Text
        log.gId_identificacion = ididentificacion

        If funciones.InsertarPersona(log) Then
            MsgBox("REGISTRO ALMACENADO")
            Limpiar()
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
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub RegistrarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
