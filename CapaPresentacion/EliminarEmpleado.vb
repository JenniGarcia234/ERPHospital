Imports CapaDatos
Imports CapaNegocio

Public Class EliminarEmpleado
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
        Dim logica As New AEmpleado
        logica.gId_empleado = Me.textBox1.Text
        If funciones.BuscarEmpleado(logica) Then
            Me.textBox2.Text = logica.gId_persona
            Me.textBox3.Text = logica.gId_datos_c
            Me.textBox4.Text = logica.gRfc
            Me.textBox5.Text = logica.gCurp
            Me.textBox6.Text = logica.gId_grado
            Me.TextBox7.Text = logica.gId_puesto

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub EliminarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim funciones As New Operaciones
        Dim log As New AEmpleado
        log.gId_empleado = Me.textBox1.Text

        If funciones.EliminarEmpleado(log) Then
            MsgBox("REGISTRO ELIMINADO")
            Limpiar()
        End If

    End Sub


    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs)

    End Sub
End Class