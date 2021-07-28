Public Class AHorario
    Dim id_horario As Integer
    Dim horario_entrada, horario_descanso, horario_salida As String

    Public Sub New(id_horario As Integer, horario_entrada As String, horario_descanso As String, horario_salida As String)
        Me.id_horario = id_horario
        Me.horario_entrada = horario_entrada
        Me.horario_descanso = horario_descanso
        Me.horario_salida = horario_salida
    End Sub

    Public Property gId_horario As Integer
        Get
            Return id_horario
        End Get
        Set(value As Integer)
            id_horario = value
        End Set
    End Property

    Public Property gHorario_entrada As String
        Get
            Return horario_entrada
        End Get
        Set(value As String)
            horario_entrada = value
        End Set
    End Property

    Public Property gHorario_descanso As String
        Get
            Return horario_descanso
        End Get
        Set(value As String)
            horario_descanso = value
        End Set
    End Property

    Public Property gHorario_salida As String
        Get
            Return horario_salida
        End Get
        Set(value As String)
            horario_salida = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
