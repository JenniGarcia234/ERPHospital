Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarTipoIngreso
    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim funciones As New Operaciones3
        Dim log As New ATipoIngreso
        log.gId_tipo_ingreso = Me.textBox1.Text
        log.gTipo = Me.comboBox1.Text



        If funciones.ActualizarTipoIngreso(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Public Sub Limpiar()
        textBox1.Text = ""
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
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

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones3
        Dim logica As New ATipoIngreso
        logica.gId_tipo_ingreso = Me.textBox1.Text
        If funciones.BuscarTipoIngreso(logica) Then
            Me.comboBox1.Text = logica.gTipo


            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub
End Class