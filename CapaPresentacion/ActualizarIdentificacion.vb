Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarIdentificacion
    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim funciones As New Operaciones
        Dim log As New AIdentificacion
        log.gId_identificacion = Me.textBox1.Text
        log.gFolio = Me.textBox2.Text
        log.gId_tipo = Me.comboBox1.Text


        If funciones.ActualizarIdentificacion(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub
    Public Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub
End Class