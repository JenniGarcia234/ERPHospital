Imports CapaDatos
Imports CapaNegocio

Public Class EliminarPersona
    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones
        Dim logica As New APersona
        logica.gId_persona = Me.textBox1.Text
        If funciones.BuscarPersona(logica) Then
            Me.textBox2.Text = logica.gNombre
            Me.textBox3.Text = logica.gApellido_p
            Me.textBox4.Text = logica.gApellido_m
            Me.textBox6.Text = logica.gId_identificacion

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim funciones As New Operaciones
        Dim log As New APersona
        log.gId_persona = Me.textBox1.Text

        If funciones.EliminarPersona(log) Then
            MsgBox("REGISTRO ELIMINADO")
            Limpiar()
        End If
    End Sub
    Public Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox6.Text = ""
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.ExitThread()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub btn_VerRegistros_Click(sender As Object, e As EventArgs) Handles btn_VerRegistros.Click
        Dim f2 As New Persona
        f2.Show()
    End Sub
End Class