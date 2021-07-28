Public Class ATipoIdentificacion

    Dim id_tipo As Integer
    Dim descripcion As String

    Public Sub New(id_tipo As Integer, descripcion As String)
        Me.id_tipo = id_tipo
        Me.descripcion = descripcion
    End Sub

    Public Property gId_tipo As Integer
        Get
            Return id_tipo
        End Get
        Set(value As Integer)
            id_tipo = value
        End Set
    End Property

    Public Property gDescripcion As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
