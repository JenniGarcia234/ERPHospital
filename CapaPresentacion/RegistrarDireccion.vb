Imports CapaDatos
Imports CapaNegocio

Public Class RegistrarDireccion
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim funciones As New Operaciones2
        Dim log As New ADireccion
        log.gId_direccion = Me.textBox1.Text
        log.gCalle = Me.textBox2.Text
        log.gNo_interior = Me.textBox3.Text
        log.gNo_exterior = Me.textBox4.Text
        log.gColonia = Me.textBox5.Text
        log.gMunicipio = Me.textBox6.Text
        log.gEstado = Me.textBox7.Text
        log.gPais = Me.textBox8.Text

        If funciones.InsertarDireccion(log) Then
            MsgBox("REGISTRO ALMACENADO")
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
        textBox7.Text = ""
        textBox8.Text = ""
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub RegistrarDireccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class