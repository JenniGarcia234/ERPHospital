Public Class HabitacionesDisponibles
    Private Sub HabitacionesDisponibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Z2HospitalDataSet.HabitacionesDisponibles' Puede moverla o quitarla según sea necesario.
        Me.HabitacionesDisponiblesTableAdapter.Fill(Me.Z2HospitalDataSet.HabitacionesDisponibles)

    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub
End Class