Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarTarjeta
    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones2
        Dim logica As New ATarjeta
        logica.gId_tarjeta = Me.textBox1.Text
        If funciones.Buscartarjeta(logica) Then
            Me.textBox2.Text = logica.gNo_tarjeta
            Me.textBox3.Text = logica.gCodigo_seguridad
            Me.textBox4.Text = logica.gFecha_vencimiento
            Me.comboBox1.Text = logica.gId_banco


            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
    End Sub
    Private Sub ActualizarTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()


            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()

            Const cmd As String = "SELECT[id_banco], CONVERT(varchar,[id_banco])+', ' + CONVERT(varchar,[nombre]) as Datos From bancos"
            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_banco"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using

        End Using
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim id_banco As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim funciones As New Operaciones2
        Dim log As New ATarjeta
        log.gId_tarjeta = Me.textBox1.Text
        log.gNo_tarjeta = Me.textBox2.Text
        log.gCodigo_seguridad = Me.textBox3.Text

        log.gFecha_vencimiento = Me.textBox4.Text

        log.gId_banco = id_banco

        If funciones.ActualizarTarjeta(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class