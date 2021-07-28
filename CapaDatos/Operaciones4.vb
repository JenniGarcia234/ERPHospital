Imports System.Data.SqlClient
Imports CapaNegocio

Public Class Operaciones4
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    'Registro Ingreso '

    Public Function InsertarIngreso(ByVal dts As AIngreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_ingreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_ingreso", dts.gId_ingreso1)
            cmd.Parameters.AddWithValue("@id_paciente", dts.gId_paciente1)
            cmd.Parameters.AddWithValue("@id_tipo_ingreso", dts.gId_tipo_ingreso1)
            cmd.Parameters.AddWithValue("@fecha_ingreso", dts.gFecha_ingreso1)

            If (cmd.ExecuteNonQuery) Then
                Return True

            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("ERROR" + ex.Message)
            Return False
        End Try
    End Function



    Public Function BuscarIngreso(ByVal dts As AIngreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_ingreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_ingreso", dts.gId_ingreso1)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gId_paciente1 = dr(1).ToString.Trim
            dts.gId_tipo_ingreso1 = dr(2).ToString.Trim
            dts.gFecha_ingreso1 = dr(3).ToString.Trim

            dr.Close()
            If (cmd.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR" + ex.Message)
            Return False
        End Try
    End Function


    Public Function ActualizarIngreso(ByVal dts As AIngreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_ingreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn



            cmd.Parameters.AddWithValue("@id_ingreso", dts.gId_ingreso1)
            cmd.Parameters.AddWithValue("@id_paciente", dts.gId_paciente1)
            cmd.Parameters.AddWithValue("@id_tipo_ingreso", dts.gId_tipo_ingreso1)
            cmd.Parameters.AddWithValue("@fecha_ingreso", dts.gFecha_ingreso1)

            If (cmd.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR" + ex.Message)
            Return False
        End Try
    End Function


    Public Function EliminarIngreso(ByVal dts As AIngreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_ingreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_ingreso", dts.gId_ingreso1)

            If (cmd.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR" + ex.Message)
            Return False
        End Try
    End Function



    'Registro egreso '

    Public Function InsertarEgreso(ByVal dts As AEgreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_egreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_egreso", dts.gId_egreso1)
            cmd.Parameters.AddWithValue("@id_paciente", dts.gId_paciente1)
            cmd.Parameters.AddWithValue("@fecha_egreso", dts.gFecha_egreso1)


            If (cmd.ExecuteNonQuery) Then
                Return True

            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("ERROR" + ex.Message)
            Return False
        End Try
    End Function



    Public Function BuscarEgreso(ByVal dts As AEgreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_egreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_egreso", dts.gId_egreso1)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gId_paciente1 = dr(1).ToString.Trim
            dts.gFecha_egreso1 = dr(2).ToString.Trim

            dr.Close()
            If (cmd.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR" + ex.Message)
            Return False
        End Try
    End Function


    Public Function ActualizarEgreso(ByVal dts As AEgreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_egreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_egreso", dts.gId_egreso1)
            cmd.Parameters.AddWithValue("@id_paciente", dts.gId_paciente1)
            cmd.Parameters.AddWithValue("@fecha_egreso", dts.gFecha_egreso1)


            If (cmd.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR" + ex.Message)
            Return False
        End Try
    End Function


    Public Function EliminarEgreso(ByVal dts As AEgreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_egreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_egreso", dts.gId_egreso1)

            If (cmd.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR" + ex.Message)
            Return False
        End Try
    End Function
End Class
