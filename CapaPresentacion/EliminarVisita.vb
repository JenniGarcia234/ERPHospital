Imports CapaDatos
Imports CapaNegocio

Public Class EliminarVisita
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
    End Sub

    Private Sub EliminarVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones3
        Dim logica As New AVisita
        logica.gId_visita = Me.textBox1.Text
        If funciones.BuscarVisita(logica) Then
            Me.textBox1.Text = logica.gId_paciente
            Me.textBox2.Text = logica.gId_visitante
            Me.textBox3.Text = logica.gFecha
            Me.textBox4.Text = logica.gIngreso
            Me.textBox5.Text = logica.gEgreso

            MsgBox("REGISTRO ENCONTRADO")
        End If
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

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim funciones As New Operaciones3
        Dim log As New AVisita
        log.gId_visita = Me.textBox1.Text

        If funciones.EliminarVisita(log) Then
            MsgBox("REGISTRO ELIMINADO")
            Limpiar()
        End If
    End Sub
End Class