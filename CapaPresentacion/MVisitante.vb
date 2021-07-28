Public Class MVisitante
    Private Sub button16_Click(sender As Object, e As EventArgs) Handles button16.Click
        Me.Close()
        Dim frm1 As Menu = New Menu()
        frm1.Show()
    End Sub

    Private Sub button17_Click(sender As Object, e As EventArgs) Handles button17.Click
        Application.ExitThread()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Close()
        Dim frm1 As RegistrarVisitante = New RegistrarVisitante()
        frm1.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Close()
        Dim frm1 As ActualizarVisitante = New ActualizarVisitante()
        frm1.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.Close()
        Dim frm1 As EliminarVisitante = New EliminarVisitante()
        frm1.Show()
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        Me.Close()
        Dim frm1 As RegistrarParentesco = New RegistrarParentesco()
        frm1.Show()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Me.Close()
        Dim frm1 As ActualizarParentesco = New ActualizarParentesco()
        frm1.Show()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Close()
        Dim frm1 As EliminarParentesco = New EliminarParentesco()
        frm1.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Me.Close()
        Dim frm1 As RegistrarVisita = New RegistrarVisita()
        frm1.Show()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
        Dim frm1 As ActualizarVisita = New ActualizarVisita()
        frm1.Show()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Me.Close()
        Dim frm1 As EliminarVisita = New EliminarVisita()
        frm1.Show()
    End Sub
End Class