''Se importa MySqlClient para hacer la conexion a la base de datos
Imports MySql.Data.MySqlClient

Public Class EmpresasClientes
    ''Declaracion de variables
    Dim con As Conectar = New Conectar()
    Dim comandos As MySqlCommand


    ''Boton que cerrara la ventana de Registro de cliente Empresa
    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        ''Hace la referencia de close (cerrar) ventana
        Me.Close()
    End Sub

    ''Region abre el codigo
#Region "Crear Empresa"
    ''Boton que registrara al cliente, reconociendo los campos correspondientes al de empresa
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Integer
        Try
            ''Se le llama a la clase y al metodo conector
            con.conector()
            ''Se reconoce la tabla y los campos que se registraran
            comandos = New MySqlCommand("insert into clienteempresa  (`ID`, `Ciudad`, `Nombre`, `Dirección`, `Rut`, `RazonSocial`, `Giro`)values('NULL','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", con.conexion)
            r = comandos.ExecuteNonQuery()

            ''Si la conexion y el registro es correcto se abrira una ventana con un mensaje
            If r > 0 Then
                ''Se abrira una ventana con el mensaje que el cliente se registro
                MsgBox("Cliente Registrado")

            End If

            ''Se abrira una ventana con el mensaje que el cliente no se pudo registrar
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        ''Al pulsar el boton de Registrar, los campos quedaran en blancos
        ''Clear, haciendo referencia a "limpiar" campos
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()


    End Sub
#End Region
End Class