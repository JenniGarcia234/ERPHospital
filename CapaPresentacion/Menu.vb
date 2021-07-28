Public Class Menu
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim frm1 As MPersonas = New MPersonas()
        frm1.Show()
        Me.Hide()

    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim f2 As New MLocalizacion
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim f2 As New MEmpleado
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Application.ExitThread()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Dim f2 As New MUsuario
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim frm1 As MPaciente = New MPaciente()
        frm1.Show()
        Me.Hide()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim frm1 As MVisitante = New MVisitante()
        frm1.Show()
        Me.Hide()
    End Sub
End Class