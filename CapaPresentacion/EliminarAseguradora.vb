Imports CapaDatos
Imports CapaNegocio

Public Class EliminarAseguradora
    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones3
        Dim logica As New AAseguradora
        logica.gId_aseguradora = Me.textBox1.Text
        If funciones.BuscarAseguradora(logica) Then
            Me.textBox2.Text = logica.gNombre


            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()

    End Sub

    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
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