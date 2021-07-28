Public Class Persona
    Private Sub Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZZHospitalDataSet.persona' Puede moverla o quitarla según sea necesario.
        Me.PersonaTableAdapter.Fill(Me.ZZHospitalDataSet.persona)

    End Sub
End Class