Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarDireccion
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
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

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones2
        Dim logica As New ADireccion
        logica.gId_direccion = Me.textBox1.Text
        If funciones.BuscarDireccion(logica) Then
            Me.textBox2.Text = logica.gCalle
            Me.textBox3.Text = logica.gNo_interior
            Me.textBox4.Text = logica.gNo_exterior
            Me.textBox5.Text = logica.gColonia
            Me.textBox6.Text = logica.gMunicipio
            Me.textBox7.Text = logica.gEstado
            Me.textBox8.Text = logica.gPais

            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
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

        If funciones.ActualizarDireccion(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub
End Class