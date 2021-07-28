Public Class APaciente
    Dim id_paciente, id_persona, id_datosc, id_tarjeta, id_poliza As Integer


    Public Property gId_paciente As Integer
        Get
            Return gId_paciente
        End Get
        Set(value As Integer)
            id_paciente = value
        End Set
    End Property


    Public Property gId_persona As Integer
        Get
            Return id_persona
        End Get
        Set(value As Integer)
            id_persona = value
        End Set
    End Property

    Public Property gId_datosc As Integer
        Get
            Return id_datosc

        End Get
        Set(value As Integer
            )
            id_datosc = value

        End Set
    End Property

    Public Property gId_tarjeta As Integer
        Get
            Return id_tarjeta

        End Get
        Set(value As Integer)
            id_tarjeta = value
        End Set
    End Property


    Public Property gId_poliza As Integer
        Get
            Return id_poliza

        End Get
        Set(value As Integer)
            id_poliza = value
        End Set
    End Property





    Public Sub New()

    End Sub

    Public Sub New(id_paciente As Integer, id_persona As Integer, id_datosc As Integer, id_tarjeta As Integer, id_poliza As Integer)
        Me.id_paciente = id_paciente
        Me.id_persona = id_persona
        Me.id_datosc = id_datosc
        Me.id_tarjeta = id_tarjeta
        Me.id_poliza = id_poliza
    End Sub
End Class
