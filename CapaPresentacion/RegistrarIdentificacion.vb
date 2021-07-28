Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class RegistrarIdentificacion
    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim ididentificacion As Integer = Convert.ToInt32(comboBox1.SelectedValue)

        Dim funciones As New Operaciones
        Dim log As New AIdentificacion
        log.gId_identificacion = Me.textBox1.Text
        log.gFolio = Me.textBox2.Text
        log.gId_tipo = ididentificacion


        If funciones.InsertarIdentificacion(log) Then
            MsgBox("REGISTRO ALMACENADO")
            Limpiar()
        End If
    End Sub

    Private Sub RegistrarIdentificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()
            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_tipo],CONVERT(varchar,[id_tipo])+', '+[descripcion] as Datos From identificacion_c"

            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_tipo"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using
        End Using
    End Sub



    Public Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Dim f2 As New MPersonas
        f2.Show()
        Me.Hide()
    End Sub


    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Dim f2 As New MPersonas
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub
End Class