Public Class MEmpleado
    Private Sub MEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim f2 As New RegistrarEmpleado
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim f2 As New ActualizarEmpleado
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim f2 As New EliminarEmpleado
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button17_Click(sender As Object, e As EventArgs) Handles button17.Click
        Application.ExitThread()
    End Sub

    Private Sub button16_Click(sender As Object, e As EventArgs) Handles button16.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        Dim f2 As New RegistrarPuesto
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        Dim f2 As New ActualizarPuesto
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        Dim f2 As New EliminarPuesto
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Me.Close()
        Dim frm1 As RegistrarHorario = New RegistrarHorario()
        frm1.Show()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
        Dim frm1 As ActualizarHorario = New ActualizarHorario()
        frm1.Show()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Me.Close()
        Dim frm1 As EliminarHorario = New EliminarHorario()
        frm1.Show()
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        Me.Close()
        Dim frm1 As RegistrarSueldo = New RegistrarSueldo()
        frm1.Show()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Me.Close()
        Dim frm1 As ActualizarSueldo = New ActualizarSueldo()
        frm1.Show()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Close()
        Dim frm1 As EliminarSueldo = New EliminarSueldo()
        frm1.Show()
    End Sub

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        Me.Close()
        Dim frm1 As RegistrarGrado = New RegistrarGrado()
        frm1.Show()
    End Sub

    Private Sub button14_Click(sender As Object, e As EventArgs) Handles button14.Click
        Me.Close()
        Dim frm1 As ActualizarGrado = New ActualizarGrado()
        frm1.Show()
    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        Me.Close()
        Dim frm1 As EliminarGrado = New EliminarGrado()
        frm1.Show()
    End Sub
End Class