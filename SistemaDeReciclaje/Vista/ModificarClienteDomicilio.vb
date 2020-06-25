''Se importa MySqlClient para hacer la conexion a la base de datos
Imports MySql.Data.MySqlClient
Public Class ModificarClienteDomicilio
    ''Declaracion de variables
    Dim con As Conectar = New Conectar()
    Dim comandos As MySqlCommand

    ''Boton que cerrara la ventana de Registro de cliente Empresa
    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    ''Boton Modificar, se realiza el cambio que se quiere hacer dependiendo del cliente seleccionado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class