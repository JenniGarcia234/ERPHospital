Imports CapaDatos
Imports CapaNegocio

Public Class EliminarPuesto
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
        Dim log As New APuesto
        log.gId_puesto = Me.textBox1.Text

        If funciones.EliminarPuesto(log) Then
            MsgBox("REGISTRO ELIMINADO")
            Limpiar()
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones
        Dim logica As New APuesto
        logica.gId_puesto = Me.textBox1.Text
        If funciones.BuscarPuesto(logica) Then
            Me.textBox2.Text = logica.gId_area
            Me.textBox3.Text = logica.gId_sueldo
            Me.textBox4.Text = logica.gId_horario
            Me.textBox5.Text = logica.gNombre_puesto


            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Me.Close()
        Dim frm1 As MEmpleado = New MEmpleado()
        frm1.Show()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub
End Class