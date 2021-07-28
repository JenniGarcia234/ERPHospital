Public Class HabitacionesOcupadas
    Private Sub HabitacionesOcupadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZHospitalDataSet.HabitacionesOcupadas' Puede moverla o quitarla según sea necesario.
        Me.HabitacionesOcupadasTableAdapter.Fill(Me.ZHospitalDataSet.HabitacionesOcupadas)

    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub
End Class