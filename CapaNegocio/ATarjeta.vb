Public Class ATarjeta
    Dim id_tarjeta, no_tarjeta, codigo_seguridad, id_banco As Integer
    Dim fecha_vencimiento As String

    Public Sub New(id_tarjeta As Integer, no_tarjeta As Integer, codigo_seguridad As Integer, id_banco As Integer, fecha_vencimiento As String)
        Me.id_tarjeta = id_tarjeta
        Me.no_tarjeta = no_tarjeta
        Me.codigo_seguridad = codigo_seguridad
        Me.id_banco = id_banco
        Me.fecha_vencimiento = fecha_vencimiento
    End Sub

    Public Property gId_tarjeta As Integer
        Get
            Return id_tarjeta
        End Get
        Set(value As Integer)
            id_tarjeta = value
        End Set
    End Property

    Public Property gNo_tarjeta As Integer
        Get
            Return no_tarjeta
        End Get
        Set(value As Integer)
            no_tarjeta = value
        End Set
    End Property

    Public Property gCodigo_seguridad As Integer
        Get
            Return codigo_seguridad
        End Get
        Set(value As Integer)
            codigo_seguridad = value
        End Set
    End Property

    Public Property gId_banco As Integer
        Get
            Return id_banco
        End Get
        Set(value As Integer)
            id_banco = value
        End Set
    End Property

    Public Property gFecha_vencimiento As String
        Get
            Return fecha_vencimiento
        End Get
        Set(value As String)
            fecha_vencimiento = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
