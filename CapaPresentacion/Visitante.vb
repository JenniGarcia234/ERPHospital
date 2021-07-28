Public Class Visitante
    Private Sub Visitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZZ2HospitalDataSet.visitante' Puede moverla o quitarla según sea necesario.
        Me.VisitanteTableAdapter.Fill(Me.ZZ2HospitalDataSet.visitante)

    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub
End Class