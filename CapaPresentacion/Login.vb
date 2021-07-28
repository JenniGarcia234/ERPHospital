Imports System.Data.SqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sc As SqlConnection = New SqlConnection()
            sc.ConnectionString = "Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True"
            sc.Open()
            Const cmd As String = "SELECT [id_funcion],CONVERT(varchar,[id_funcion])+', '+[privilegio] as Datos From funcion"

            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd, sc)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                comboBox1.ValueMember = "id_funcion"
                comboBox1.DisplayMember = "Datos"
                comboBox1.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim idfuncion As Integer = Convert.ToInt32(comboBox1.SelectedValue)
        Dim Conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-1PG2MA4\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("LOGEO1", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = textBox1.Text
        cmd.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = textBox2.Text
        cmd.Parameters.Add("@id_funcion", SqlDbType.Int).Value = idfuncion
        Conexion.Open()
        Dim cuenta As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        If cuenta = 0 Then
            MessageBox.Show("Datos incorrectos/Usuario no válido")
        Else
            MessageBox.Show("Bienvenido(a)")

            Dim frm1 As Menu = New Menu()
            frm1.Show()

        End If
    End Sub
End Class