Public Class AEgreso
    Dim id_egreso, id_paciente As Integer
    Dim fecha_egreso As String

    Public Sub New(id_egreso As Integer, id_paciente As Integer, fecha_egreso As String)
        Me.id_egreso = id_egreso
        Me.id_paciente = id_paciente
        Me.fecha_egreso = fecha_egreso
    End Sub

    Public Property gId_egreso1 As Integer
        Get
            Return id_egreso
        End Get
        Set(value As Integer)
            id_egreso = value
        End Set
    End Property

    Public Property gId_paciente1 As Integer
        Get
            Return id_paciente
        End Get
        Set(value As Integer)
            id_paciente = value
        End Set
    End Property

    Public Property gFecha_egreso1 As String
        Get
            Return fecha_egreso
        End Get
        Set(value As String)
            fecha_egreso = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
