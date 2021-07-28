Imports CapaDatos
Imports CapaNegocio

Public Class EliminarPiso
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
        Dim log As New APiso
        log.gId_piso = Me.textBox1.Text

        If funciones.EliminarPiso(log) Then
            MsgBox("REGISTRO ELIMINADO")
            Limpiar()
        End If
    End Sub

    Public Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Dim f2 As New MLocalizacion
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones
        Dim logica As New APiso
        logica.gId_piso = Me.textBox1.Text
        If funciones.BuscarPiso(logica) Then
            Me.textBox2.Text = logica.gNo_piso

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub
End Class