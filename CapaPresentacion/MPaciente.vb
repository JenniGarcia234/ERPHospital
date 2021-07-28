Public Class MPaciente
    Private Sub button17_Click(sender As Object, e As EventArgs) Handles button17.Click
        Application.ExitThread()
    End Sub

    Private Sub button16_Click(sender As Object, e As EventArgs) Handles button16.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Close()
        Dim frm1 As RegistrarPaciente = New RegistrarPaciente()
        frm1.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Close()
        Dim frm1 As ActualizarPaciente = New ActualizarPaciente()
        frm1.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.Close()
        Dim frm1 As EliminarPaciente = New EliminarPaciente()
        frm1.Show()
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        Me.Close()
        Dim frm1 As RegistrarSituacion = New RegistrarSituacion()
        frm1.Show()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Me.Close()
        Dim frm1 As ActualizarSituacion = New ActualizarSituacion()
        frm1.Show()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Close()
        Dim frm1 As EliminarSituacion = New EliminarSituacion()
        frm1.Show()
    End Sub

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        Me.Close()
        Dim frm1 As RegistrarAseguradora = New RegistrarAseguradora()
        frm1.Show()
    End Sub

    Private Sub button14_Click(sender As Object, e As EventArgs) Handles button14.Click
        Me.Close()
        Dim frm1 As ActualizarAseguradora = New ActualizarAseguradora()
        frm1.Show()
    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        Me.Close()
        Dim frm1 As EliminarAseguradora = New EliminarAseguradora()
        frm1.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Me.Close()
        Dim frm1 As RegistrarTipoIngreso = New RegistrarTipoIngreso()
        frm1.Show()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
        Dim frm1 As ActualizarTipoIngreso = New ActualizarTipoIngreso()
        frm1.Show()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Me.Close()
        Dim frm1 As EliminarTipoIngreso = New EliminarTipoIngreso()
        frm1.Show()
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        Me.Close()
        Dim frm1 As RegistrarBanco = New RegistrarBanco()
        frm1.Show()
    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        Me.Close()
        Dim frm1 As ActualizarBanco = New ActualizarBanco()
        frm1.Show()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        Me.Close()
        Dim frm1 As EliminarBanco = New EliminarBanco()
        frm1.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Close()
        Dim frm1 As Ingresos = New Ingresos()
        frm1.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Close()
        Dim frm1 As Egresos = New Egresos()
        frm1.Show()
    End Sub
End Class