Module ConsultaSql


    Public sumaIngresos As Decimal = 0.0
    Public sumaGastos As Decimal = 0.0
    Public diferencia As Decimal = 0.0

    Public Sub ActualizarSumaIngresos()
        Try
            Using conexion As New SqlClient.SqlConnection(Configuracion.ConexionString)
                conexion.Open()
                Dim query As String = "SELECT SUM(montoIngresos) FROM ingresos"
                Using cmd As New SqlClient.SqlCommand(query, conexion)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        sumaIngresos = Convert.ToDecimal(result)
                    Else
                        sumaIngresos = 0.0 ' Si no hay ingresos, establece el valor en cero
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al obtener la suma de ingresos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub ActualizarSumaGastos()
        Try
            Using conexion As New SqlClient.SqlConnection(Configuracion.ConexionString)
                conexion.Open()
                Dim query As String = "SELECT SUM(montoGastos) FROM gastos"
                Using cmd As New SqlClient.SqlCommand(query, conexion)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        sumaGastos = Convert.ToDecimal(result)
                    Else
                        sumaGastos = 0.0 ' Si no hay gastos, establece el valor en cero
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al obtener la suma de gastos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub ActualizarDiferencia()
        Try
            Using conexion As New SqlClient.SqlConnection(Configuracion.ConexionString)
                conexion.Open()
                Dim query As String = "SELECT (SELECT SUM(montoIngresos) FROM ingresos) - (SELECT SUM(montoGastos) FROM gastos) AS Diferencia"
                Using cmd As New SqlClient.SqlCommand(query, conexion)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        diferencia = Convert.ToDecimal(result)
                    Else
                        diferencia = sumaIngresos

                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al obtener la diferencia: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module


