Public Class AIngreso
    Dim id_ingreso, id_paciente, id_tipo_ingreso As Integer
    Dim fecha_ingreso As String

    Public Sub New(id_ingreso As Integer, id_paciente As Integer, id_tipo_ingreso As Integer, fecha_ingreso As String)
        Me.id_ingreso = id_ingreso
        Me.id_paciente = id_paciente
        Me.id_tipo_ingreso = id_tipo_ingreso
        Me.fecha_ingreso = fecha_ingreso
    End Sub

    Public Property gId_ingreso1 As Integer
        Get
            Return id_ingreso
        End Get
        Set(value As Integer)
            id_ingreso = value
        End Set
    End Property

    Public Property gId_paciente1 As Integer
        Get
            Return id_paciente
        End Get
        Set(value As Integer)
            id_paciente = value
        End Set
    End Property

    Public Property gId_tipo_ingreso1 As Integer
        Get
            Return id_tipo_ingreso
        End Get
        Set(value As Integer)
            id_tipo_ingreso = value
        End Set
    End Property

    Public Property gFecha_ingreso1 As String
        Get
            Return fecha_ingreso
        End Get
        Set(value As String)
            fecha_ingreso = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
