Public Class MUsuario
    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Me.Close()
        Dim frm1 As RegistrarFuncion = New RegistrarFuncion()
        frm1.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Close()
        Dim frm1 As RegistrarUsuario = New RegistrarUsuario()
        frm1.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Close()
        Dim frm1 As ActualizarUsuario = New ActualizarUsuario()
        frm1.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.Close()
        Dim frm1 As EliminarUsuario = New EliminarUsuario()
        frm1.Show()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
        Dim frm1 As ActualizarFuncion = New ActualizarFuncion()
        frm1.Show()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Me.Close()
        Dim frm1 As EliminarFuncion = New EliminarFuncion()
        frm1.Show()
    End Sub

    Private Sub button16_Click(sender As Object, e As EventArgs) Handles button16.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub button17_Click(sender As Object, e As EventArgs) Handles button17.Click
        Application.ExitThread()
    End Sub
End Class