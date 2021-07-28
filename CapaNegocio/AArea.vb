Public Class AArea
    Dim id_area As Integer
    Dim nombre_area As String

    Public Sub New(id_area As Integer, nombre_area As String)
        Me.id_area = id_area
        Me.nombre_area = nombre_area
    End Sub

    Public Property gId_area As Integer
        Get
            Return id_area
        End Get
        Set(value As Integer)
            id_area = value
        End Set
    End Property

    Public Property gNombre_area As String
        Get
            Return nombre_area
        End Get
        Set(value As String)
            nombre_area = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
