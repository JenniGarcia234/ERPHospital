Public Class APiso
    Dim id_piso, no_piso As Integer

    Public Sub New(id_piso As Integer, no_piso As Integer)
        Me.id_piso = id_piso
        Me.no_piso = no_piso
    End Sub

    Public Property gId_piso As Integer
        Get
            Return id_piso
        End Get
        Set(value As Integer)
            id_piso = value
        End Set
    End Property

    Public Property gNo_piso As Integer
        Get
            Return no_piso
        End Get
        Set(value As Integer)
            no_piso = value
        End Set
    End Property


    Public Sub New()

    End Sub
End Class
