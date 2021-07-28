Public Class AEmpleado
    Dim id_empleado, id_persona, id_datos_c, id_grado, id_puesto As Integer
    Dim rfc, curp As String

    Public Sub New(id_empleado As Integer, id_persona As Integer, id_datos_c As Integer, id_grado As Integer, id_puesto As Integer, rfc As String, curp As String)
        Me.id_empleado = id_empleado
        Me.id_persona = id_persona
        Me.id_datos_c = id_datos_c
        Me.id_grado = id_grado
        Me.id_puesto = id_puesto
        Me.rfc = rfc
        Me.curp = curp
    End Sub

    Public Property gId_empleado As Integer
        Get
            Return id_empleado
        End Get
        Set(value As Integer)
            id_empleado = value
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

    Public Property gId_datos_c As Integer
        Get
            Return id_datos_c
        End Get
        Set(value As Integer)
            id_datos_c = value
        End Set
    End Property

    Public Property gId_grado As Integer
        Get
            Return id_grado
        End Get
        Set(value As Integer)
            id_grado = value
        End Set
    End Property

    Public Property gId_puesto As Integer
        Get
            Return id_puesto
        End Get
        Set(value As Integer)
            id_puesto = value
        End Set
    End Property

    Public Property gRfc As String
        Get
            Return rfc
        End Get
        Set(value As String)
            rfc = value
        End Set
    End Property

    Public Property gCurp As String
        Get
            Return curp
        End Get
        Set(value As String)
            curp = value
        End Set
    End Property


    Public Sub New()

    End Sub
End Class
