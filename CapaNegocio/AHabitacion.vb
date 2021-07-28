Public Class AHabitacion
    Dim id_habitacion, no_habitacion, id_area, id_piso As Integer

    Public Sub New(id_habitacion As Integer, no_habitacion As Integer, id_area As Integer, id_piso As Integer)
        Me.id_habitacion = id_habitacion
        Me.no_habitacion = no_habitacion
        Me.id_area = id_area
        Me.id_piso = id_piso
    End Sub

    Public Property gId_habitacion As Integer
        Get
            Return id_habitacion
        End Get
        Set(value As Integer)
            id_habitacion = value
        End Set
    End Property

    Public Property gNo_habitacion As Integer
        Get
            Return no_habitacion
        End Get
        Set(value As Integer)
            no_habitacion = value
        End Set
    End Property

    Public Property gId_area As Integer
        Get
            Return id_area
        End Get
        Set(value As Integer)
            id_area = value
        End Set
    End Property

    Public Property gId_piso As Integer
        Get
            Return id_piso
        End Get
        Set(value As Integer)
            id_piso = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
