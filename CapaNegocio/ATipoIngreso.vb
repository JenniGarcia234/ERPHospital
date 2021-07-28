Public Class ATipoIngreso
    Dim id_tipo_ingreso As Integer
    Dim tipo As String

    Public Sub New(id_tipo_ingreso As Integer, tipo As String)
        Me.id_tipo_ingreso = id_tipo_ingreso
        Me.tipo = tipo
    End Sub

    Public Property gId_tipo_ingreso As Integer
        Get
            Return id_tipo_ingreso
        End Get
        Set(value As Integer)
            id_tipo_ingreso = value
        End Set
    End Property

    Public Property gTipo As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
