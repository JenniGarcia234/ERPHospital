Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class RegistrarHabitacion
    Private Sub RegistrarHabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_area],CONVERT(varchar,[id_area])+', '+[nombre_area] as Datos From areas"
            Const cmd2 As String = "SELECT[id_piso], CONVERT(varchar,[id_piso])+', ' + CONVERT(varchar,[no_piso]) as Datos From piso"
            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_area"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using

            Using sda1 As SqlDataAdapter = New SqlDataAdapter(cmd2, sc)
                Dim dt As DataTable = New DataTable()
                sda1.Fill(dt)
                comboBox2.ValueMember = "id_piso"
                comboBox2.DisplayMember = "Datos"
                comboBox2.DataSource = dt
            End Using
        End Using
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub
    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim funciones As New Operaciones
        Dim log As New AHabitacion
        Dim idarea As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim idpiso As Integer = Convert.ToInt32(comboBox2.SelectedValue)
        log.gId_habitacion = Me.textBox1.Text
        log.gNo_habitacion = Me.textBox2.Text
        log.gId_area = idarea
        log.gId_piso = idpiso


        If funciones.InsertarHabitacion(log) Then
            MsgBox("REGISTRO GUARDADO")
            Limpiar()
        End If
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Me.Close()
        Dim frm1 As MLocalizacion = New MLocalizacion()
        frm1.Show()
    End Sub
End Class