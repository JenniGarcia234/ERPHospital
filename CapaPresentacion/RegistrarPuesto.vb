Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class RegistrarPuesto
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim idarea As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim idsueldo As Integer = Convert.ToInt32(comboBox2.SelectedValue)
        Dim idhorario As Integer = Convert.ToInt32(comboBox1.SelectedValue)

        Dim funciones As New Operaciones
        Dim log As New APuesto
        log.gId_puesto = Me.textBox1.Text
        log.gId_area = idarea
        log.gId_sueldo = idsueldo
        log.gId_horario = idhorario
        log.gNombre_puesto = Me.textBox2.Text

        If funciones.InsertarPuesto(log) Then
            MsgBox("REGISTRO ALMACENADO")
            Limpiar()
        End If
    End Sub

    Private Sub RegistrarPuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_area],CONVERT(varchar,[id_area])+', '+[nombre_area] as Datos From areas"
            Const cmd2 As String = "SELECT[id_sueldo], CONVERT(varchar,[id_sueldo])+', ' +'MONTO:$'+ CONVERT(varchar,[monto]) as Datos From sueldos"
            Const cmd3 As String = "SELECT[id_horario], CONVERT(varchar,[id_horario]) as Datos From horarios"
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
                comboBox2.ValueMember = "id_sueldo"
                comboBox2.DisplayMember = "Datos"
                comboBox2.DataSource = dt

            End Using

            Using sda2 As SqlDataAdapter = New SqlDataAdapter(cmd3, sc)
                Dim dt As DataTable = New DataTable()
                sda2.Fill(dt)
                comboBox3.ValueMember = "id_horario"
                comboBox3.DisplayMember = "Datos"
                comboBox3.DataSource = dt

            End Using
        End Using
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Dim f2 As New MEmpleado
        f2.Show()
        Me.Hide()
    End Sub
End Class