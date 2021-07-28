Public Class MLocalizacion
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim f2 As New RegistrarArea
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        Dim f2 As New RegistrarHabitacion
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim f2 As New RegistrarPiso
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim f2 As New ActualizarPiso
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim f2 As New ActualizarArea
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim f2 As New EliminarArea
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Dim f2 As New ActualizarHabitacion
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Dim f2 As New EliminarHabitacion
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim f2 As New EliminarPiso
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button16_Click(sender As Object, e As EventArgs) Handles button16.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub button17_Click(sender As Object, e As EventArgs) Handles button17.Click
        Application.ExitThread()
    End Sub

    Private Sub label13_Click(sender As Object, e As EventArgs) Handles label13.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim f2 As New HabitacionesOcupadas
        f2.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Dim f2 As New HabitacionesOcupadas
        f2.Show()

    End Sub

    Private Sub MLocalizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        Dim f2 As New HabitacionesDisponibles
        f2.Show()
    End Sub
End Class