Imports CapaDatos
Imports CapaNegocio

Public Class EliminarPaciente
    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click

        Dim funciones As New Operaciones2
        Dim log As New APaciente
        log.gId_paciente = Me.textBox1.Text

        If funciones.EliminarPaciente(log) Then
            MsgBox("REGISTRO ELIMINADO")
            Limpiar()
        End If

    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Dim f2 As New MPaciente
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

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones2
        Dim logica As New APaciente
        logica.gId_paciente = Me.textBox1.Text
        If funciones.BuscarPaciente(logica) Then
            Me.textBox2.Text = logica.gId_persona
            Me.textBox3.Text = logica.gId_datosc
            Me.textBox4.Text = logica.gId_tarjeta
            Me.textBox5.Text = logica.gId_poliza

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
    End Sub
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        Dim f2 As New Paciente
        f2.Show()
    End Sub
End Class