Public Class AUsuario
    Dim id_usuario, id_empleado, id_funcion As Integer
    Dim nombre_usuario, contraseña As String

    Public Sub New(id_usuario As Integer, id_empleado As Integer, id_funcion As Integer, nombre_usuario As String, contraseña As String)
        Me.id_usuario = id_usuario
        Me.id_empleado = id_empleado
        Me.id_funcion = id_funcion
        Me.nombre_usuario = nombre_usuario
        Me.contraseña = contraseña
    End Sub

    Public Property gId_usuario As Integer
        Get
            Return id_usuario
        End Get
        Set(value As Integer)
            id_usuario = value
        End Set
    End Property

    Public Property gId_empleado As Integer
        Get
            Return id_empleado
        End Get
        Set(value As Integer)
            id_empleado = value
        End Set
    End Property

    Public Property gId_funcion As Integer
        Get
            Return id_funcion
        End Get
        Set(value As Integer)
            id_funcion = value
        End Set
    End Property

    Public Property gNombre_usuario As String
        Get
            Return nombre_usuario
        End Get
        Set(value As String)
            nombre_usuario = value
        End Set
    End Property

    Public Property gContraseña As String
        Get
            Return contraseña
        End Get
        Set(value As String)
            contraseña = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
