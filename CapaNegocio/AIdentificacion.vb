Public Class AIdentificacion
    Dim id_identificacion, id_tipo As Integer
    Dim folio As String



    Public Property gId_identificacion As Integer
        Get
            Return id_identificacion
        End Get
        Set(value As Integer)
            id_identificacion = value
        End Set
    End Property

    Public Property gId_tipo As Integer
        Get
            Return id_tipo
        End Get
        Set(value As Integer)
            id_tipo = value
        End Set
    End Property

    Public Property gFolio As String
        Get
            Return folio
        End Get
        Set(value As String)
            folio = value
        End Set
    End Property

    Public Sub New(id_identificacion As Integer, id_tipo As Integer, folio As String)
        Me.id_identificacion = id_identificacion
        Me.id_tipo = id_tipo
        Me.folio = folio
    End Sub

    Public Sub New()

    End Sub
End Class
