Public Class AParentesco
    Dim id_parentesco As Integer
    Dim descripcion As String

    Public Sub New(id_parentesco As Integer, descripcion As String)
        Me.id_parentesco = id_parentesco
        Me.descripcion = descripcion
    End Sub

    Public Property gId_parentesco As Integer
        Get
            Return id_parentesco
        End Get
        Set(value As Integer)
            id_parentesco = value
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
