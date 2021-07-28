Imports CapaDatos
Imports CapaNegocio

Public Class ActualizarDatosComplementarios
    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim funciones As New Operaciones2
        Dim log As New ADatos_c
        log.gId_datos_c = Me.textBox1.Text
        log.gId_direccion = Me.textBox2.Text
        log.gTelefono_fijo = Me.textBox3.Text
        log.gTelefono_movil = Me.textBox4.Text


        If funciones.ActualizarDatosC(log) Then
            MsgBox("REGISTRO ACTUALIZADO")
            Limpiar()
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim frm1 As ActualizarDireccion = New ActualizarDireccion()
        frm1.Show()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub
    Sub Limpiar()
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Limpiar()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim funciones As New Operaciones2
        Dim logica As New ADatos_c
        logica.gId_direccion = Me.textBox1.Text
        If funciones.BuscarDatosC(logica) Then
            Me.textBox2.Text = logica.gId_direccion
            Me.textBox3.Text = logica.gTelefono_fijo
            Me.textBox4.Text = logica.gTelefono_movil


            MsgBox("REGISTRO ENCONTRADO")
        End If
    End Sub
End Class