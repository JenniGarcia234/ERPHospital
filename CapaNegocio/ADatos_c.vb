Public Class ADatos_c
    Dim id_datos_c, id_direccion As Integer
    Dim telefono_fijo, telefono_movil As String


    Public Property gId_datos_c As Integer
        Get
            Return gId_datos_c
        End Get
        Set(value As Integer)
            id_datos_c = value
        End Set
    End Property

    Public Property gId_direccion As Integer
        Get
            Return id_direccion
        End Get
        Set(value As Integer)
            id_direccion = value
        End Set
    End Property

    Public Property gTelefono_fijo As String
        Get
            Return telefono_fijo

        End Get
        Set(value As String)
            telefono_fijo = value

        End Set
    End Property

    Public Property gTelefono_movil As String
        Get
            Return telefono_movil

        End Get
        Set(value As String)
            telefono_movil = value
        End Set
    End Property



    Public Sub New()

    End Sub

    Public Sub New(id_datos_c As Integer, id_direccion As Integer, telefono_fijo As String, telefono_movil As String)
        Me.id_datos_c = id_datos_c
        Me.id_direccion = id_direccion
        Me.telefono_fijo = telefono_fijo
        Me.telefono_movil = telefono_movil
    End Sub
End Class
