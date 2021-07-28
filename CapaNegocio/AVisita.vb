Public Class AVisita

    Dim id_visita, id_paciente, id_visitante As Integer
    Dim fecha, ingreso, egreso As String


    Public Property gId_visita As Integer
        Get
            Return id_visita
        End Get
        Set(value As Integer)
            id_visita = value
        End Set
    End Property

    Public Property gId_paciente As Integer
        Get
            Return id_paciente
        End Get
        Set(value As Integer)
            id_paciente = value
        End Set
    End Property

    Public Property gId_visitante As Integer
        Get
            Return id_visitante

        End Get
        Set(value As Integer)
            id_visitante = value

        End Set
    End Property

    Public Property gFecha As String
        Get
            Return fecha

        End Get
        Set(value As String)
            fecha = value
        End Set
    End Property


    Public Property gIngreso As String
        Get
            Return ingreso

        End Get
        Set(value As String)
            ingreso = value
        End Set
    End Property

    Public Property gEgreso As String
        Get
            Return egreso

        End Get
        Set(value As String)
            egreso = value
        End Set
    End Property

    Public Sub New(id_visita As Integer, id_paciente As Integer, id_visitante As Integer, fecha As String, ingreso As String, egreso As String)
        Me.id_visita = id_visita
        Me.id_paciente = id_paciente
        Me.id_visitante = id_visitante
        Me.fecha = fecha
        Me.ingreso = ingreso
        Me.egreso = egreso
    End Sub
    Public Sub New()

    End Sub

End Class
