Public Class ASueldo
    Dim id_sueldo As Integer
    Dim monto As Decimal

    Public Sub New(id_sueldo As Integer, monto As Decimal)
        Me.id_sueldo = id_sueldo
        Me.monto = monto
    End Sub

    Public Property gId_sueldo As Integer
        Get
            Return id_sueldo
        End Get
        Set(value As Integer)
            id_sueldo = value
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


    Public Sub New()

    End Sub
End Class
