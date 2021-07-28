Public Class AGrado
    Dim id_grado As Integer
    Dim nombre As String

    Public Sub New(id_grado As Integer, nombre As String)
        Me.id_grado = id_grado
        Me.nombre = nombre
    End Sub

    Public Property gId_grado As Integer
        Get
            Return id_grado
        End Get
        Set(value As Integer)
            id_grado = value
        End Set
    End Property

    Public Property gNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
