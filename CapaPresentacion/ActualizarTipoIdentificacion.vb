Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarTipoIdentificacion
    Private Sub ActualizarTipoIdentificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Dim f2 As New MPersonas
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
        Dim logica As New ATipoIdentificacion
        logica.gId_tipo = Me.textBox1.Text
        If funciones.BuscarTipoI(logica) Then
            Me.listBox1.Text = logica.gDescripcion



            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click

        Dim funciones As New Operaciones2
        Dim log As New ATipoIdentificacion
        log.gId_tipo = Me.textBox1.Text
        log.gDescripcion = Me.listBox1.Text


        If funciones.ActualizarTipoI(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Sub Limpiar()
        textBox1.Text = ""
    End Sub
End Class