Imports CapaDatos
Imports CapaNegocio

Public Class EliminarHabitacion
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim funciones As New Operaciones
        Dim log As New AHabitacion
        log.gId_piso = Me.textBox1.Text

        If funciones.EliminarHabitacion(log) Then
            MsgBox("REGISTRO ELIMINADO")
            Limpiar()
        End If
    End Sub

    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones
        Dim logica As New AHabitacion
        logica.gId_habitacion = Me.textBox1.Text
        If funciones.BuscarHabitacion(logica) Then
            Me.textBox2.Text = logica.gNo_habitacion
            Me.textBox3.Text = logica.gId_area
            Me.textBox4.Text = logica.gId_piso


            MsgBox("REGISTRO ENCONTRADO")
        End If
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