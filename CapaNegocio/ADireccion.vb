Public Class ADireccion
    Dim id_direccion As Integer
    Dim calle, no_interior, no_exterior, colonia, municipio, estado, pais As String

    Public Sub New(id_direccion As Integer, calle As String, no_interior As String, no_exterior As String, colonia As String, municipio As String, estado As String, pais As String)
        Me.id_direccion = id_direccion
        Me.calle = calle
        Me.no_interior = no_interior
        Me.no_exterior = no_exterior
        Me.colonia = colonia
        Me.municipio = municipio
        Me.estado = estado
        Me.pais = pais
    End Sub

    Public Property gId_direccion As Integer
        Get
            Return id_direccion
        End Get
        Set(value As Integer)
            id_direccion = value
        End Set
    End Property

    Public Property gCalle As String
        Get
            Return calle
        End Get
        Set(value As String)
            calle = value
        End Set
    End Property

    Public Property gNo_interior As String
        Get
            Return no_interior
        End Get
        Set(value As String)
            no_interior = value
        End Set
    End Property

    Public Property gNo_exterior As String
        Get
            Return no_exterior
        End Get
        Set(value As String)
            no_exterior = value
        End Set
    End Property

    Public Property gColonia As String
        Get
            Return colonia
        End Get
        Set(value As String)
            colonia = value
        End Set
    End Property

    Public Property gMunicipio As String
        Get
            Return municipio
        End Get
        Set(value As String)
            municipio = value
        End Set
    End Property

    Public Property gEstado As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    Public Property gPais As String
        Get
            Return pais
        End Get
        Set(value As String)
            pais = value
        End Set
    End Property


    Public Sub New()

    End Sub
End Class
