Imports CapaDatos
Imports CapaNegocio

Public Class EliminarUsuario
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub btn_MP_Click(sender As Object, e As EventArgs) Handles btn_MP.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones
        Dim logica As New AUsuario
        logica.gId_usuario = Me.textBox1.Text
        If funciones.BuscarUsuario(logica) Then
            Me.comboBox1.Text = logica.gId_empleado
            Me.textBox2.Text = logica.gNombre_usuario
            Me.textBox3.Text = logica.gContraseña
            Me.comboBox2.Text = logica.gId_empleado

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub Btn_MS_Click(sender As Object, e As EventArgs) Handles Btn_MS.Click
        Me.Close()
        Dim frm1 As MUsuario = New MUsuario()
        frm1.Show()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""

    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim funciones As New Operaciones
        Dim log As New AUsuario
        log.gId_usuario = Me.textBox1.Text

        If funciones.EliminarUsuario(log) Then
            MsgBox("REGISTRO ELIMINADO")
            Limpiar()
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim frm1 As Usuario = New Usuario()
        frm1.Show()
    End Sub
End Class