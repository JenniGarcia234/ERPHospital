Imports System.Data.SqlClient
Imports CapaNegocio

Public Class Operaciones2
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader


    'Registro datos complementarios'

    Public Function InsertarDatosC(ByVal dts As ADatos_c) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_datos_c")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_datos_c", dts.gId_datos_c)
            cmd.Parameters.AddWithValue("@id_direccion", dts.gId_direccion)
            cmd.Parameters.AddWithValue("@telefono_fijo", dts.gTelefono_fijo)
            cmd.Parameters.AddWithValue("@telefono_movil", dts.gTelefono_movil)
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



    Public Function BuscarDatosC(ByVal dts As ADatos_c) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_datos_c")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_datos_c", dts.gId_datos_c)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gId_direccion = dr(1).ToString.Trim
            dts.gTelefono_fijo = dr(2).ToString.Trim
            dts.gTelefono_movil = dr(2).ToString.Trim

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


    Public Function ActualizarDatosC(ByVal dts As ADatos_c) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_datos_c")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_datos_c", dts.gId_datos_c)
            cmd.Parameters.AddWithValue("@id_direccion", dts.gId_direccion)
            cmd.Parameters.AddWithValue("@telefono_fijo", dts.gTelefono_fijo)
            cmd.Parameters.AddWithValue("@telefono_movil", dts.gTelefono_movil)

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


    Public Function EliminarDatosC(ByVal dts As ADatos_c) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_datos_c")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_datos_c", dts.gId_datos_c)

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



    'Registro tipo de identificaciones'

    Public Function InsertarTipoI(ByVal dts As ATipoIdentificacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_identifcacion_c")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tipo", dts.gId_tipo)
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



    Public Function BuscarTipoI(ByVal dts As ATipoIdentificacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_identificacion_c")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tipo", dts.gId_tipo)
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


    Public Function ActualizarTipoI(ByVal dts As ATipoIdentificacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_identificacion_c")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tipo", dts.gId_tipo)
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


    Public Function EliminarTipoI(ByVal dts As ATipoIdentificacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_identificacion_c")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tipo", dts.gId_tipo)

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



    'Registro datos de direccion'

    Public Function InsertarDireccion(ByVal dts As ADireccion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_direccion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_direccion", dts.gId_direccion)
            cmd.Parameters.AddWithValue("@calle", dts.gCalle)
            cmd.Parameters.AddWithValue("@no_interior", dts.gNo_interior)
            cmd.Parameters.AddWithValue("@no_exterior", dts.gNo_exterior)
            cmd.Parameters.AddWithValue("@colonia", dts.gColonia)
            cmd.Parameters.AddWithValue("@municipio", dts.gMunicipio)
            cmd.Parameters.AddWithValue("@estado", dts.gEstado)
            cmd.Parameters.AddWithValue("@pais", dts.gPais)
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



    Public Function BuscarDireccion(ByVal dts As ADireccion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_direccion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_direccion", dts.gId_direccion)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gCalle = dr(1).ToString.Trim
            dts.gNo_interior = dr(2).ToString.Trim
            dts.gNo_exterior = dr(3).ToString.Trim
            dts.gColonia = dr(4).ToString.Trim
            dts.gMunicipio = dr(5).ToString.Trim
            dts.gEstado = dr(6).ToString.Trim
            dts.gPais = dr(7).ToString.Trim

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


    Public Function ActualizarDireccion(ByVal dts As ADireccion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_direccion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_direccion", dts.gId_direccion)
            cmd.Parameters.AddWithValue("@calle", dts.gCalle)
            cmd.Parameters.AddWithValue("@no_interior", dts.gNo_interior)
            cmd.Parameters.AddWithValue("@no_exterior", dts.gNo_exterior)
            cmd.Parameters.AddWithValue("@colonia", dts.gColonia)
            cmd.Parameters.AddWithValue("@municipio", dts.gMunicipio)
            cmd.Parameters.AddWithValue("@estado", dts.gEstado)
            cmd.Parameters.AddWithValue("@pais", dts.gPais)

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



    'Registro de Sueldos'

    Public Function InsertarSueldo(ByVal dts As ASueldo) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_Sueldo")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_sueldo", dts.gId_sueldo)
            cmd.Parameters.AddWithValue("@monto", dts.gMonto)

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



    Public Function BuscarSueldo(ByVal dts As ASueldo) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_Sueldo")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_sueldo", dts.gId_sueldo)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gMonto = dr(1).ToString.Trim

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


    Public Function ActualizarSueldo(ByVal dts As ASueldo) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_Sueldo")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_sueldo", dts.gId_sueldo)
            cmd.Parameters.AddWithValue("@monto", dts.gMonto)

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


    Public Function EliminarSueldo(ByVal dts As ASueldo) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_Sueldo")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_sueldo", dts.gId_sueldo)

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


    'Registro Paciente'

    Public Function InsertarPaciente(ByVal dts As APaciente) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_paciente")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_paciente", dts.gId_paciente)
            cmd.Parameters.AddWithValue("@id_persona", dts.gId_persona)
            cmd.Parameters.AddWithValue("@id_datos_c", dts.gId_datosc)
            cmd.Parameters.AddWithValue("@id_tarjeta", dts.gId_tarjeta)
            cmd.Parameters.AddWithValue("@id_poliza", dts.gId_poliza)
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



    Public Function BuscarPaciente(ByVal dts As APaciente) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_paciente")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_paciente", dts.gId_paciente)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gId_persona = dr(1).ToString.Trim
            dts.gId_datosc = dr(2).ToString.Trim
            dts.gId_tarjeta = dr(3).ToString.Trim
            dts.gId_poliza = dr(4).ToString.Trim
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


    Public Function ActualizarPaciente(ByVal dts As APaciente) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_paciente")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_paciente", dts.gId_paciente)
            cmd.Parameters.AddWithValue("@id_persona", dts.gId_persona)
            cmd.Parameters.AddWithValue("@id_datos_c", dts.gId_datosc)
            cmd.Parameters.AddWithValue("@id_tarjeta", dts.gId_tarjeta)
            cmd.Parameters.AddWithValue("@id_poliza", dts.gId_poliza)
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


    Public Function EliminarPaciente(ByVal dts As APaciente) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_paciente")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_paciente", dts.gId_paciente)

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



    'Registro Tarjeta de Credito '

    Public Function Insertartarjeta(ByVal dts As ATarjeta) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_tarjeta")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tarjeta", dts.gId_tarjeta)
            cmd.Parameters.AddWithValue("@no_tarjeta", dts.gNo_tarjeta)
            cmd.Parameters.AddWithValue("@codigo_seguridad", dts.gCodigo_seguridad)
            cmd.Parameters.AddWithValue("@fecha_vencimiento", dts.gFecha_vencimiento)
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



    Public Function Buscartarjeta(ByVal dts As ATarjeta) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_tarjeta")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tarjeta", dts.gId_tarjeta)
            dr = cmd.ExecuteReader
            dr.Read()

            dts.gNo_tarjeta = dr(1).ToString.Trim
            dts.gCodigo_seguridad = dr(2).ToString.Trim
            dts.gFecha_vencimiento = dr(3).ToString
            dts.gId_banco = dr(4).ToString.Trim

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


    Public Function ActualizarTarjeta(ByVal dts As ATarjeta) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_tarjeta1")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_tarjeta", dts.gId_tarjeta)
            cmd.Parameters.AddWithValue("@no_tarjeta", dts.gNo_tarjeta)
            cmd.Parameters.AddWithValue("@codigo_seguridad", dts.gCodigo_seguridad)
            cmd.Parameters.AddWithValue("@fecha_vencimiento", dts.gFecha_vencimiento)
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



    'tabla seguro'
    Public Function Insertar_Seguro(ByVal dts As ASeguro) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_seguro")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_poliza", dts.gId_poliza)
            cmd.Parameters.AddWithValue("@no_poliza", dts.gNo_poliza)
            cmd.Parameters.AddWithValue("@monto", dts.gMonto)
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



    Public Function Buscar_Seguro(ByVal dts As ASeguro) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_seguro")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_poliza", dts.gId_poliza)
            dr = cmd.ExecuteReader
            dr.Read()

            dts.gNo_poliza = dr(1).ToString.Trim
            dts.gMonto = dr(2).ToString.Trim
            dts.gId_aseguradora = dr(3).ToString.Trim
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



    Public Function ActualizarSeguro(ByVal dts As ASeguro) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_seguro")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_poliza", dts.gId_poliza)
            cmd.Parameters.AddWithValue("@no_poliza", dts.gNo_poliza)
            cmd.Parameters.AddWithValue("@monto", dts.gMonto)
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





End Class
