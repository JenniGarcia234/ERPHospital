Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarSueldo
    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones2
        Dim logica As New ASueldo
        logica.gId_sueldo = Me.textBox1.Text
        If funciones.BuscarSueldo(logica) Then
            Me.textBox2.Text = logica.gMonto



            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim funciones As New Operaciones2
        Dim log As New ASueldo
        log.gId_sueldo = Me.textBox1.Text
        log.gMonto = Me.textBox2.Text

        If funciones.ActualizarSueldo(log) Then
            MsgBox("REGISTRO ALMACENADO")
            Limpiar()
        End If
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

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
End Class