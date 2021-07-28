Public Class ASeguro
    Dim id_poliza, id_aseguradora, no_poliza As Integer

    Dim monto As Decimal


    Public Property gId_poliza As Integer
        Get
            Return gId_poliza
        End Get
        Set(value As Integer)
            id_poliza = value
        End Set
    End Property

    Public Property gNo_poliza As Integer
        Get
            Return no_poliza
        End Get
        Set(value As Integer)
            no_poliza = value
        End Set
    End Property
    Public Property gMonto As Decimal
        Get
            Return monto
        End Get
        Set(value As Decimal)
            monto = value
        End Set
    End Property


    Public Property gId_aseguradora As Integer
        Get
            Return gId_aseguradora
        End Get
        Set(value As Integer)
            id_aseguradora = value
        End Set
    End Property

    Public Sub New(id_poliza As Integer, no_poliza As Integer, monto As Decimal, id_aseguradora As Integer)
        Me.gId_poliza = id_poliza
        Me.no_poliza = no_poliza
        Me.monto = monto
        Me.gId_aseguradora = id_aseguradora

    End Sub

    Public Sub New()

    End Sub
End Class
