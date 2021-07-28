Imports CapaDatos
Imports CapaNegocio

Public Class RegistrarSueldo
    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim funciones As New Operaciones2
        Dim log As New ASueldo
        log.gId_sueldo = Me.textBox1.Text
        log.gMonto = Me.textBox2.Text



        If funciones.InsertarSueldo(log) Then
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

    Private Sub RegistrarSueldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class