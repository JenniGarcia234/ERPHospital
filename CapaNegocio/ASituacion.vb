Public Class ASituacion
    Dim id_situacion, id_ingreso, id_habitacion As Integer

    Public Sub New(id_situacion As Integer, id_ingreso As Integer, id_habitacion As Integer)
        Me.id_situacion = id_situacion
        Me.id_ingreso = id_ingreso
        Me.id_habitacion = id_habitacion
    End Sub

    Public Property gId_situacion As Integer
        Get
            Return id_situacion
        End Get
        Set(value As Integer)
            id_situacion = value
        End Set
    End Property

    Public Property gId_ingreso As Integer
        Get
            Return id_ingreso
        End Get
        Set(value As Integer)
            id_ingreso = value
        End Set
    End Property

    Public Property gId_habitacion As Integer
        Get
            Return id_habitacion
        End Get
        Set(value As Integer)
            id_habitacion = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
