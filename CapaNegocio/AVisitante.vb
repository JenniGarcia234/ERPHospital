Public Class AVisitante

    Dim id_visitante, id_persona, id_datosc, id_parentesco As Integer


    Public Property gId_visitante As Integer
        Get
            Return gId_visitante
        End Get
        Set(value As Integer)
            id_visitante = value
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
        Set(value As Integer)
            id_datosc = value

        End Set
    End Property

    Public Property gId_parentesco As Integer
        Get
            Return id_parentesco

        End Get
        Set(value As Integer)
            id_parentesco = value
        End Set
    End Property


    Public Sub New(id_visitante As Integer, id_persona As Integer, id_datosc As Integer, id_parentesco As Integer)
        Me.id_visitante = id_visitante
        Me.id_persona = id_persona
        Me.id_datosc = id_datosc
        Me.id_parentesco = id_parentesco

    End Sub
    Public Sub New()

    End Sub
End Class
