Public Class MPersonas
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Close()
        Dim frm1 As RegistrarPersona = New RegistrarPersona()
        frm1.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Close()
        Dim frm1 As ActualizarPersona = New ActualizarPersona()
        frm1.Show()
    End Sub

    Private Sub button17_Click(sender As Object, e As EventArgs) Handles button17.Click
        Application.ExitThread()
    End Sub

    Private Sub button16_Click(sender As Object, e As EventArgs) Handles button16.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Me.Close()
        Dim frm1 As RegistrarTipoIdentificacion = New RegistrarTipoIdentificacion()
        frm1.Show()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
        Dim frm1 As ActualizarTipoIdentificacion = New ActualizarTipoIdentificacion()
        frm1.Show()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Me.Close()
        Dim frm1 As EliminarTipoIdentificacion = New EliminarTipoIdentificacion()
        frm1.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.Close()
        Dim frm1 As EliminarPersona = New EliminarPersona()
        frm1.Show()
    End Sub
End Class