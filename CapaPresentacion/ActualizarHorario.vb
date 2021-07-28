Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarHorario
    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Dim f2 As New MEmpleado
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
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
    End Sub
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim funciones As New Operaciones
        Dim log As New AHorario
        log.gId_horario = Me.textBox1.Text
        log.gHorario_entrada = Me.textBox2.Text
        log.gHorario_descanso = Me.textBox3.Text
        log.gHorario_salida = Me.textBox4.Text


        If funciones.ActualizarHorario(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones
        Dim logica As New AHorario
        logica.gId_horario = Me.textBox1.Text
        If funciones.BuscarHorario(logica) Then
            Me.textBox2.Text = logica.gHorario_entrada
            Me.textBox3.Text = logica.gHorario_descanso
            Me.textBox4.Text = logica.gHorario_salida


            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub
End Class