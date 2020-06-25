Imports MySql.Data.MySqlClient

Public Class Valorizacion
    Dim con As Conectar = New Conectar()
    Dim comandos As MySqlCommand



    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As Integer

        Try
            comandos = New MySqlCommand("insert into valorizacion  (`ID`, `Material`, `Dia`, `Mes`,`Año`, `Kilos`)values('NULL','" & Materialbox.SelectedItem & "','" & Diabox.SelectedItem & "','" & Mesbox.SelectedItem & "','" & Añotext.Text & "','" & Kilostext.Text & "')", con.conexion)
            r = comandos.ExecuteNonQuery()
            con.conector()

            If r > 0 Then

                MsgBox("Material Registrado")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub

    Private Sub Valorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.conector()

        Dim da As New MySqlDataAdapter("Select * from valorizacion ", con.conect)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub
End Class