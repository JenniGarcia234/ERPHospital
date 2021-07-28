Imports System.Data.SqlClient
Imports CapaNegocio
Public Class Operaciones3
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    'Registro Situacion del Paciente '

    Public Function InsertarSituacion(ByVal dts As ASituacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_SituacionPaciente")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_situacion", dts.gId_situacion)
            cmd.Parameters.AddWithValue("@id_ingreso", dts.gId_ingreso)
            cmd.Parameters.AddWithValue("@id_habitacion", dts.gId_habitacion)

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



    Public Function BuscarSituacion(ByVal dts As ASituacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_SituacionPaciente")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_situacion", dts.gId_situacion)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gId_ingreso = dr(1).ToString.Trim
            dts.gId_habitacion = dr(2).ToString.Trim


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


    Public Function ActualizarSituacion(ByVal dts As ASituacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_SituacionPaciente")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_situacion", dts.gId_situacion)
            cmd.Parameters.AddWithValue("@id_ingreso", dts.gId_ingreso)
            cmd.Parameters.AddWithValue("@id_habitacion", dts.gId_habitacion)

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


    Public Function EliminarSituacion(ByVal dts As ASituacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_SituacionPaciente")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_situacion", dts.gId_situacion)

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



    'Registro de Bancos '

    Public Function InsertarBanco(ByVal dts As ABancos) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_bancos")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_banco", dts.gId_banco)
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)

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



    Public Function BuscarBancos(ByVal dts As ABancos) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_bancos")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_banco", dts.gId_banco)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gNombre = dr(1).ToString.Trim



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


    Public Function ActualizarBanco(ByVal dts As ABancos) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_bancos")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_banco", dts.gId_banco)
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)

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


    Public Function EliminarBanco(ByVal dts As ABancos) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_bancos")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_banco", dts.gId_banco)

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



    'Registro de Aseguradoras '

    Public Function InsertarAseguradora(ByVal dts As AAseguradora) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_aseguradora")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_aseguradora", dts.gId_aseguradora)
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)

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



    Public Function BuscarAseguradora(ByVal dts As AAseguradora) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_aseguradora")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_aseguradora", dts.gId_aseguradora)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gNombre = dr(1).ToString.Trim



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


    Public Function ActualizarAseguradora(ByVal dts As AAseguradora) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_aseguradora")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_aseguradora", dts.gId_aseguradora)
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)

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


    Public Function EliminarAseguradora(ByVal dts As AAseguradora) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_aseguradora")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_aseguradora", dts.gId_aseguradora)

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




    'Registro de tipo de ingreso '

    Public Function InsertarTipoIngreso(ByVal dts As ATipoIngreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_tipo_ingreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tipo_ingreso", dts.gId_tipo_ingreso)
            cmd.Parameters.AddWithValue("@tipo", dts.gTipo)

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



    Public Function BuscarTipoIngreso(ByVal dts As ATipoIngreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_tipo_ingreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tipo_ingreso", dts.gId_tipo_ingreso)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gTipo = dr(1).ToString.Trim



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


    Public Function ActualizarTipoIngreso(ByVal dts As ATipoIngreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_tipo_ingreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tipo_ingreso", dts.gId_tipo_ingreso)
            cmd.Parameters.AddWithValue("@tipo", dts.gTipo)

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


    Public Function EliminarTipoIngreso(ByVal dts As ATipoIngreso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_tipo_ingreso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tipo_ingreso", dts.gId_tipo_ingreso)

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



    'Registro de parentesco'

    Public Function InsertarParentesco(ByVal dts As AParentesco) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_parentesco")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_parentesco", dts.gId_parentesco)
            cmd.Parameters.AddWithValue("@descripcion", dts.gDescripcion)

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



    Public Function BuscarParentesco(ByVal dts As AParentesco) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_parentesco")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_parentesco", dts.gId_parentesco)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gDescripcion = dr(1).ToString.Trim



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


    Public Function ActualizarParentesco(ByVal dts As AParentesco) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_parentesco")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_parentesco", dts.gId_parentesco)
            cmd.Parameters.AddWithValue("@descripcion", dts.gDescripcion)

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


    Public Function EliminarParentesco(ByVal dts As AParentesco) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_parentesco")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_parentesco", dts.gId_parentesco)

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


    'Registro Visitante'

    Public Function InsertarVisitante(ByVal dts As AVisitante) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_visitante")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_visitante", dts.gId_visitante)
            cmd.Parameters.AddWithValue("@id_persona", dts.gId_persona)
            cmd.Parameters.AddWithValue("@id_datos_c", dts.gId_datosc)
            cmd.Parameters.AddWithValue("@id_parentesco", dts.gId_parentesco)

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



    Public Function BuscarVisitante(ByVal dts As AVisitante) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_visitante")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_visitante", dts.gId_visitante)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gId_persona = dr(1).ToString.Trim
            dts.gId_datosc = dr(2).ToString.Trim
            dts.gId_parentesco = dr(3).ToString.Trim

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


    Public Function ActualizarVisitante(ByVal dts As AVisitante) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_visitante")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_visitante", dts.gId_visitante)
            cmd.Parameters.AddWithValue("@id_persona", dts.gId_persona)
            cmd.Parameters.AddWithValue("@id_datos_c", dts.gId_datosc)
            cmd.Parameters.AddWithValue("@id_parentesco", dts.gId_parentesco)
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


    Public Function EliminarVisitante(ByVal dts As AVisitante) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_visitante")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_visitante", dts.gId_visitante)

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






    'Registro Visita'

    Public Function InsertarVisita(ByVal dts As AVisita) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_visita")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_visita", dts.gId_visita)
            cmd.Parameters.AddWithValue("@id_paciente", dts.gId_paciente)
            cmd.Parameters.AddWithValue("@id_visitante", dts.gId_visitante)
            cmd.Parameters.AddWithValue("@fecha", dts.gFecha)
            cmd.Parameters.AddWithValue("@ingreso", dts.gIngreso)
            cmd.Parameters.AddWithValue("@egreso", dts.gEgreso)

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



    Public Function BuscarVisita(ByVal dts As AVisita) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_visita")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_visita", dts.gId_visita)
            dr = cmd.ExecuteReader
            dr.Read()

            dts.gId_paciente = dr(1).ToString.Trim
            dts.gId_visitante = dr(2).ToString.Trim
            dts.gFecha = dr(3).ToString.Trim
            dts.gIngreso = dr(4).ToString.Trim
            dts.gEgreso = dr(5).ToString.Trim

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


    Public Function ActualizarVisita(ByVal dts As AVisita) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_visita")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_visita", dts.gId_visita)
            cmd.Parameters.AddWithValue("@id_paciente", dts.gId_paciente)
            cmd.Parameters.AddWithValue("@id_visitante", dts.gId_visitante)
            cmd.Parameters.AddWithValue("@fecha", dts.gFecha)
            cmd.Parameters.AddWithValue("@ingreso", dts.gIngreso)
            cmd.Parameters.AddWithValue("@egreso", dts.gEgreso)
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


    Public Function EliminarVisita(ByVal dts As AVisita) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_visita")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_visita", dts.gId_visita)

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
