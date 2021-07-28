Public Class ABancos
    Dim id_banco As Integer
    Dim nombre As String

    Public Sub New(id_banco As Integer, nombre As String)
        Me.id_banco = id_banco
        Me.nombre = nombre
    End Sub

    Public Property gId_banco As Integer
        Get
            Return id_banco
        End Get
        Set(value As Integer)
            id_banco = value
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
