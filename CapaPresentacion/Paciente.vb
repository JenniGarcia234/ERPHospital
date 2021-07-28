Public Class Paciente
    Private Sub Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZZ1HospitalDataSet.paciente' Puede moverla o quitarla según sea necesario.
        Me.PacienteTableAdapter.Fill(Me.ZZ1HospitalDataSet.paciente)

    End Sub
End Class