Public Class APersona
    Dim id_persona, id_identificacion As Integer
    Dim nombre, apellido_p, apellido_m As String

    Public Property gId_persona As Integer
        Get
            Return id_persona
        End Get
        Set(value As Integer)
            id_persona = value
        End Set
    End Property

    Public Property gId_identificacion As Integer
        Get
            Return id_identificacion
        End Get
        Set(value As Integer)
            id_identificacion = value
        End Set
    End Property

    Public Property gNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property gApellido_p As String
        Get
            Return apellido_p
        End Get
        Set(value As String)
            apellido_p = value
        End Set
    End Property

    Public Property gApellido_m As String
        Get
            Return apellido_m
        End Get
        Set(value As String)
            apellido_m = value
        End Set
    End Property

    Public Sub New(id_persona As Integer, id_identificacion As Integer, nombre As String, apellido_p As String, apellido_m As String)
        Me.id_persona = id_persona
        Me.id_identificacion = id_identificacion
        Me.nombre = nombre
        Me.apellido_p = apellido_p
        Me.apellido_m = apellido_m
    End Sub
    Public Sub New()

    End Sub
End Class
