''Se importa MySqlClient para hacer la conexion a la base de datos
Imports MySql.Data.MySqlClient

Public Class ModificarClienteEmpresa
    ''Declaracion de variables
    Dim con As Conectar = New Conectar()
    Dim comandos As MySqlCommand


    ''Boton que cerrara la ventana de Registro de cliente Empresa
    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        ''Hace la referencia de close (cerrar) ventana
        Me.Close()
    End Sub


    ''Boton Modificar, se realiza el cambio que se quiere hacer dependiendo del cliente seleccionado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As Integer
        Dim actualizar As String
        Try
            ''Se le llama a la clase y al metodo conector
            con.conector()
            ''Se reconoce la tabla y los campos que se modificaran
            actualizar = " update clienteempresa set Ciudad='" & TextBox1.Text & "', Dirección ='" & TextBox2.Text & "',Nombre='" & TextBox3.Text & "',Rut= '" & TextBox4.Text & "', RazonSocial ='" & TextBox5.Text & "', Giro = '" & TextBox6.Text & "' WHERE id='" & TextBox7.Text & "'"
            comandos = New MySqlCommand(actualizar, con.conexion)
            r = comandos.ExecuteNonQuery()

            ''Si la conexion y el registro es correcto se abrira una ventana con un mensaje
            If r > 0 Then
                ''Se abrira una ventana con el mensaje que el cliente se registro
                MsgBox("cliente actualizado")

            End If

            ''Se abrira una ventana con el mensaje que el cliente no se pudo registrar
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        ''Al pulsar el boton de Modificar, los campos quedaran en blancos
        ''Clear, haciendo referencia a "limpiar" campos
        TextBox7.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub


    Private Sub ModificarClienteEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New MySqlDataAdapter("Select * from clienteempresa ", con.conect)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex

        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            TextBox7.Text = selectedRow.Cells(0).Value.ToString()
            TextBox1.Text = selectedRow.Cells(1).Value.ToString()
            TextBox2.Text = selectedRow.Cells(2).Value.ToString()
            TextBox3.Text = selectedRow.Cells(3).Value.ToString()
            TextBox4.Text = selectedRow.Cells(4).Value.ToString()
            TextBox5.Text = selectedRow.Cells(5).Value.ToString()
            TextBox6.Text = selectedRow.Cells(6).Value.ToString()
        Catch ex As Exception

        End Try







    End Sub


    ''Boton Eliminar, se realiza la eliminacion del cliente seleccionado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''Declaracion de variables
        Dim eliminar As String
        Dim coma As New MySqlCommand
        Dim si As Byte
        ''Se abre una ventana donde se pregunta si se quiere eliminar o no
        si = MsgBox("desea eliminar", vbYesNo, "Eliminar")

        If si = 6 Then
            con.conector()
            eliminar = "delete from clienteempresa where id='" & TextBox7.Text & "'"
            comandos = New MySqlCommand(eliminar, con.conexion)
            comandos.ExecuteNonQuery()

            ''Si se elimina al cliente se abrira una ventana con el mensaje
            MsgBox("eliminado")
            ''Cuando se elimine el cliente los campos se limpiaran/vaciaran
            TextBox7.Clear()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()


        End If
    End Sub


End Class