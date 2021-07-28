Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarSeguro
    Private Sub ActualizarSeguro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()

            Const cmd As String = "SELECT[id_aseguradora], CONVERT(varchar,[id_aseguradora])+', ' + CONVERT(varchar,[nombre]) as Datos From aseguradoras"
            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_aseguradora"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using

        End Using
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim id_aseguradora As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim funciones As New Operaciones2
        Dim log As New ASeguro
        log.gId_poliza = Me.textBox1.Text
        log.gNo_poliza = Me.textBox2.Text
        log.gMonto = Me.textBox3.Text
        log.gId_aseguradora = id_aseguradora

        If funciones.ActualizarSeguro(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""

    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones2
        Dim logica As New ASeguro
        logica.gId_poliza = Me.textBox1.Text
        If funciones.Buscar_Seguro(logica) Then
            Me.textBox2.Text = logica.gNo_poliza
            Me.textBox3.Text = logica.gMonto
            Me.comboBox1.Text = logica.gId_aseguradora


            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub
End Class