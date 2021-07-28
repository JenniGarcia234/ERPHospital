Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarArea
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Me.Close()
        Dim frm1 As MLocalizacion = New MLocalizacion()
        frm1.Show()
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim funciones As New Operaciones
        Dim log As New AArea
        log.gId_area = Me.textBox1.Text
        log.gNombre_area = Me.textBox2.Text


        If funciones.ActualizarArea(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub
    Public Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones
        Dim logica As New AArea
        logica.gId_area = Me.textBox1.Text
        If funciones.BuscarArea(logica) Then
            Me.textBox2.Text = logica.gNombre_area

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub
End Class