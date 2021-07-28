Imports System.Data.SqlClient
Public Class Conexion

    Protected cnn As SqlConnection

    Public Function FConectar()
        Try
            cnn = New SqlConnection("Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox("CONEXION NO ESTABLECIDA")
            Return False
        End Try
    End Function
    Public Function FDesconectar()
        Try
            If cnn.State = Data.ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR AL CERRAR LA CONEXIÓN")
            Return False
        End Try
    End Function
End Class
