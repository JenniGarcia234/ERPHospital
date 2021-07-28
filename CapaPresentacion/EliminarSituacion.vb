Imports CapaDatos
Imports CapaNegocio

Public Class EliminarSituacion
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
    End Sub
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones3
        Dim logica As New ASituacion
        logica.gId_situacion = Me.textBox1.Text
        If funciones.BuscarSituacion(logica) Then
            Me.textBox2.Text = logica.gId_ingreso
            Me.textBox3.Text = logica.gId_habitacion

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim funciones As New Operaciones3
        Dim log As New ASituacion
        log.gId_situacion = Me.textBox1.Text

        If funciones.EliminarSituacion(log) Then
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
End Class