Public Class APuesto
    Dim id_puesto, id_area, id_sueldo, id_horario As Integer
    Dim nombre_puesto As String

    Public Sub New(id_puesto As Integer, id_area As Integer, id_sueldo As Integer, id_horario As Integer, nombre_puesto As String)
        Me.id_puesto = id_puesto
        Me.id_area = id_area
        Me.id_sueldo = id_sueldo
        Me.id_horario = id_horario
        Me.nombre_puesto = nombre_puesto
    End Sub

    Public Property gId_puesto As Integer
        Get
            Return id_puesto
        End Get
        Set(value As Integer)
            id_puesto = value
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

    Public Property gId_sueldo As Integer
        Get
            Return id_sueldo
        End Get
        Set(value As Integer)
            id_sueldo = value
        End Set
    End Property

    Public Property gId_horario As Integer
        Get
            Return id_horario
        End Get
        Set(value As Integer)
            id_horario = value
        End Set
    End Property

    Public Property gNombre_puesto As String
        Get
            Return nombre_puesto
        End Get
        Set(value As String)
            nombre_puesto = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
