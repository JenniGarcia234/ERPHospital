Public Class AFuncion
    Dim id_funcion As Integer
    Dim privilegio, descripcion As String

    Public Sub New(id_funcion As Integer, privilegio As String, descripcion As String)
        Me.id_funcion = id_funcion
        Me.privilegio = privilegio
        Me.descripcion = descripcion
    End Sub

    Public Property gId_funcion As Integer
        Get
            Return id_funcion
        End Get
        Set(value As Integer)
            id_funcion = value
        End Set
    End Property

    Public Property gPrivilegio As String
        Get
            Return privilegio
        End Get
        Set(value As String)
            privilegio = value
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
