Imports System.Data.SqlClient
Imports CapaNegocio

Public Class Operaciones
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader


    'Registro personas'

    Public Function InsertarPersona(ByVal dts As APersona) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_persona")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_persona", dts.gId_persona)
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@apellido_p", dts.gApellido_p)
            cmd.Parameters.AddWithValue("@apellido_m", dts.gApellido_m)
            cmd.Parameters.AddWithValue("@id_identificacion", dts.gId_identificacion)
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



    Public Function BuscarPersona(ByVal dts As APersona) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_persona")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_persona", dts.gId_persona)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gNombre = dr(1).ToString.Trim
            dts.gApellido_p = dr(2).ToString.Trim
            dts.gApellido_m = dr(3).ToString.Trim
            dts.gId_identificacion = dr(4).ToString.Trim
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


    Public Function ActualizarPersona(ByVal dts As APersona) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_persona")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_persona", dts.gId_persona)
            cmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@apellido_p", dts.gApellido_p)
            cmd.Parameters.AddWithValue("@apellido_m", dts.gApellido_m)
            cmd.Parameters.AddWithValue("@id_identificacion", dts.gId_identificacion)
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


    Public Function EliminarPersona(ByVal dts As APersona) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_persona")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_persona", dts.gId_persona)

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


    'Registro identificacion'

    Public Function InsertarIdentificacion(ByVal dts As AIdentificacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_identificacion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_identificacion", dts.gId_identificacion)
            cmd.Parameters.AddWithValue("@folio", dts.gFolio)
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



    Public Function BuscarIdentificacion(ByVal dts As AIdentificacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_identificacion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_identificacion", dts.gId_identificacion)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gFolio = dr(1).ToString.Trim
            dts.gId_tipo = dr(2).ToString.Trim

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


    Public Function ActualizarIdentificacion(ByVal dts As AIdentificacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_identificacion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_identificacion", dts.gId_identificacion)
            cmd.Parameters.AddWithValue("@folio", dts.gFolio)
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





    'Registro piso'

    Public Function InsertarPiso(ByVal dts As APiso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_Piso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_piso", dts.gId_piso)
            cmd.Parameters.AddWithValue("@no_piso", dts.gNo_piso)

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



    Public Function BuscarPiso(ByVal dts As APiso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_Piso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_piso", dts.gId_piso)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gNo_piso = dr(1).ToString.Trim

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


    Public Function ActualizarPiso(ByVal dts As APiso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_Piso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_piso", dts.gId_piso)
            cmd.Parameters.AddWithValue("@no_piso", dts.gNo_piso)

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


    Public Function EliminarPiso(ByVal dts As APiso) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_Piso")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_piso", dts.gId_piso)

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



    'Registro Areas'

    Public Function InsertarArea(ByVal dts As AArea) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_Areas")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_area", dts.gId_area)
            cmd.Parameters.AddWithValue("@nombre_area", dts.gNombre_area)

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



    Public Function BuscarArea(ByVal dts As AArea) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_Areas")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_area", dts.gId_area)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gNombre_area = dr(1).ToString.Trim

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


    Public Function ActualizarArea(ByVal dts As AArea) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_Areas")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_area", dts.gId_area)
            cmd.Parameters.AddWithValue("@nombre_area", dts.gNombre_area)

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


    Public Function EliminarArea(ByVal dts As AArea) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_Areas")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_area", dts.gId_area)

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



    'Registro Habitacion'

    Public Function InsertarHabitacion(ByVal dts As AHabitacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_Habitacion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_habitacion", dts.gId_habitacion)
            cmd.Parameters.AddWithValue("@no_habitacion", dts.gNo_habitacion)
            cmd.Parameters.AddWithValue("@id_area", dts.gId_area)
            cmd.Parameters.AddWithValue("@id_piso", dts.gId_piso)

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



    Public Function BuscarHabitacion(ByVal dts As AHabitacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_Habitacion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_habitacion", dts.gId_habitacion)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gNo_habitacion = dr(1).ToString.Trim
            dts.gId_area = dr(2).ToString.Trim
            dts.gId_piso = dr(3).ToString.Trim

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


    Public Function ActualizarHabitacion(ByVal dts As AHabitacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_Habitacion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_habitacion", dts.gId_habitacion)
            cmd.Parameters.AddWithValue("@no_habitacion", dts.gNo_habitacion)
            cmd.Parameters.AddWithValue("@id_area", dts.gId_area)
            cmd.Parameters.AddWithValue("@id_piso", dts.gId_piso)

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


    Public Function EliminarHabitacion(ByVal dts As AHabitacion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_Habitacion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
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



    'Registro Empleado'

    Public Function InsertarEmpleado(ByVal dts As AEmpleado) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_Empleado")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_empleado", dts.gId_empleado)
            cmd.Parameters.AddWithValue("@id_persona", dts.gId_persona)
            cmd.Parameters.AddWithValue("@id_datos_c", dts.gId_datos_c)
            cmd.Parameters.AddWithValue("@rfc", dts.gRfc)
            cmd.Parameters.AddWithValue("@curp", dts.gCurp)
            cmd.Parameters.AddWithValue("@id_grado", dts.gId_grado)
            cmd.Parameters.AddWithValue("@id_puesto", dts.gId_puesto)

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



    Public Function BuscarEmpleado(ByVal dts As AEmpleado) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_Empleado")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_empleado", dts.gId_empleado)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gId_persona = dr(1).ToString.Trim
            dts.gId_datos_c = dr(2).ToString.Trim
            dts.gRfc = dr(3).ToString.Trim
            dts.gCurp = dr(4).ToString.Trim
            dts.gId_grado = dr(5).ToString.Trim
            dts.gId_puesto = dr(6).ToString.Trim

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


    Public Function ActualizarEmpleado(ByVal dts As AEmpleado) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_Empleado")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_empleado", dts.gId_empleado)
            cmd.Parameters.AddWithValue("@id_persona", dts.gId_persona)
            cmd.Parameters.AddWithValue("@id_datos_c", dts.gId_datos_c)
            cmd.Parameters.AddWithValue("@rfc", dts.gRfc)
            cmd.Parameters.AddWithValue("@curp", dts.gCurp)
            cmd.Parameters.AddWithValue("@id_grado", dts.gId_grado)
            cmd.Parameters.AddWithValue("@id_puesto", dts.gId_puesto)

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


    Public Function EliminarEmpleado(ByVal dts As AEmpleado) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_Empleado")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_empleado", dts.gId_empleado)

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




    'Registro de Puestos'

    Public Function InsertarPuesto(ByVal dts As APuesto) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_Puesto")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_puesto", dts.gId_puesto)
            cmd.Parameters.AddWithValue("@id_area", dts.gId_area)
            cmd.Parameters.AddWithValue("@id_sueldo", dts.gId_sueldo)
            cmd.Parameters.AddWithValue("@id_horario", dts.gId_horario)
            cmd.Parameters.AddWithValue("@nombre_puesto", dts.gId_puesto)


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



    Public Function BuscarPuesto(ByVal dts As APuesto) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_Puesto")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_puesto", dts.gId_puesto)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gId_area = dr(1).ToString.Trim
            dts.gId_sueldo = dr(2).ToString.Trim
            dts.gId_horario = dr(3).ToString.Trim
            dts.gNombre_puesto = dr(4).ToString.Trim


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


    Public Function ActualizarPuesto(ByVal dts As APuesto) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_Puesto")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_puesto", dts.gId_puesto)
            cmd.Parameters.AddWithValue("@id_area", dts.gId_area)
            cmd.Parameters.AddWithValue("@id_sueldo", dts.gId_sueldo)
            cmd.Parameters.AddWithValue("@id_horario", dts.gId_horario)
            cmd.Parameters.AddWithValue("@nombre_puesto", dts.gId_puesto)

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


    Public Function EliminarPuesto(ByVal dts As APuesto) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_Puesto")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_puesto", dts.gId_puesto)

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



    'Registro de Horarios'

    Public Function InsertarHorario(ByVal dts As AHorario) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_Horario")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_horario", dts.gId_horario)
            cmd.Parameters.AddWithValue("@horario_entrada", dts.gHorario_entrada)
            cmd.Parameters.AddWithValue("@horario_descanso", dts.gHorario_descanso)
            cmd.Parameters.AddWithValue("@horario_salida", dts.gHorario_salida)

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



    Public Function BuscarHorario(ByVal dts As AHorario) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_Horario")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_horario", dts.gId_horario)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gHorario_entrada = dr(1).ToString.Trim
            dts.gHorario_descanso = dr(2).ToString.Trim
            dts.gHorario_salida = dr(3).ToString.Trim


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


    Public Function ActualizarHorario(ByVal dts As AHorario) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_Horario")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_horario", dts.gId_horario)
            cmd.Parameters.AddWithValue("@horario_entrada", dts.gHorario_entrada)
            cmd.Parameters.AddWithValue("@horario_descanso", dts.gHorario_descanso)
            cmd.Parameters.AddWithValue("@horario_salida", dts.gHorario_salida)

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


    Public Function EliminarHorario(ByVal dts As AHorario) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_Horario")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_horario", dts.gId_horario)

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



    'Registro de Usuarios'

    Public Function InsertarUsuario(ByVal dts As AUsuario) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_Usuario")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", dts.gId_usuario)
            cmd.Parameters.AddWithValue("@id_empleado", dts.gId_empleado)
            cmd.Parameters.AddWithValue("@nombre_usuario", dts.gNombre_usuario)
            cmd.Parameters.AddWithValue("@contraseña", dts.gContraseña)
            cmd.Parameters.AddWithValue("@id_funcion", dts.gId_funcion)

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



    Public Function BuscarUsuario(ByVal dts As AUsuario) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_Usuario")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", dts.gId_usuario)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gId_empleado = dr(1).ToString.Trim
            dts.gNombre_usuario = dr(2).ToString.Trim
            dts.gContraseña = dr(3).ToString.Trim
            dts.gId_funcion = dr(4).ToString.Trim

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


    Public Function ActualizarUsuario(ByVal dts As AUsuario) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_Usuario")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", dts.gId_usuario)
            cmd.Parameters.AddWithValue("@id_empleado", dts.gId_empleado)
            cmd.Parameters.AddWithValue("@nombre_usuario", dts.gNombre_usuario)
            cmd.Parameters.AddWithValue("@contraseña", dts.gContraseña)
            cmd.Parameters.AddWithValue("@id_funcion", dts.gId_funcion)

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


    Public Function EliminarUsuario(ByVal dts As AUsuario) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_Usuario")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_usuario", dts.gId_usuario)

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

    'Registro de Grados'

    Public Function InsertarGrado(ByVal dts As AGrado) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_Grado")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_grado", dts.gId_grado)
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



    Public Function BuscarGrado(ByVal dts As AGrado) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_Grado")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_grado", dts.gId_grado)
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


    Public Function ActualizarGrado(ByVal dts As AGrado) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_Grado")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_grado", dts.gId_grado)
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


    Public Function EliminarGrado(ByVal dts As AGrado) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_Grado")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_grado", dts.gId_grado)

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



    'Registro de Funciones'

    Public Function InsertarFuncion(ByVal dts As AFuncion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Insertar_funcion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_funcion", dts.gId_funcion)
            cmd.Parameters.AddWithValue("@privilegio", dts.gPrivilegio)
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



    Public Function BuscarFuncion(ByVal dts As AFuncion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Consultar_funcion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_funcion", dts.gId_funcion)
            dr = cmd.ExecuteReader
            dr.Read()
            dts.gPrivilegio = dr(1).ToString.Trim
            dts.gDescripcion = dr(2).ToString.Trim

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


    Public Function ActualizarFuncion(ByVal dts As AFuncion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Actualizar_funcion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_funcion", dts.gId_funcion)
            cmd.Parameters.AddWithValue("@privilegio", dts.gPrivilegio)
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


    Public Function EliminarFuncion(ByVal dts As AFuncion) As Boolean
        Try
            FConectar()
            cmd = New SqlCommand("Eliminar_Funcion")
            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_funcion", dts.gId_funcion)

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