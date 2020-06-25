''Se importa MySqlClient para hacer la conexion a la base de datos
Imports MySql.Data.MySqlClient


''Se realiza la conexion a la base de datos "receecla2"
Public Class Conectar
    Public conect As String = ("server= localhost;port= 3306; userid=root;password=guerrero ;database= receecla2")
    Public conexion = New MySqlConnection(conect)
    Public Sub conector()
        Try
            ''Se abre la conexion
            conexion.Open()
            ''MsgBox("Conectado a la base de datos")
        Catch ex As Exception
            ''Menseje de error al conectar a la base de datos
            MsgBox("Error al conectar " & ex.Message)
        End Try
    End Sub
End Class
