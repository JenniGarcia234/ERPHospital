Public Class AAseguradora
    Dim id_aseguradora As Integer
    Dim nombre As String


    Public Property gId_aseguradora As Integer
        Get
            Return gId_aseguradora
        End Get
        Set(value As Integer)
            id_aseguradora = value
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



    Public Sub New(id_aseguradora As Integer, tipo As String)
        Me.id_aseguradora = id_aseguradora
        Me.nombre = tipo

    End Sub
    Public Sub New()

    End Sub
End Class
