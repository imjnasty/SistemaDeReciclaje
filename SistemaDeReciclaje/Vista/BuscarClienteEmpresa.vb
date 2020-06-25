Imports MySql.Data.MySqlClient

Public Class BuscarClienteEmpresa
    Dim con As Conectar = New Conectar()
    Dim dat As DataSet
    Dim da As New MySqlDataAdapter

    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub



    Private Sub BuscarClienteEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New MySqlDataAdapter("Select * from clienteempresa ", con.conect)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub


    ''Se 
    '' Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    '' filciud()

    '' End Sub

    ''Private Sub filciud()
    'filtrociudad
    ''If Filtro(TextBox1.Text).Rows.Count > 0 Then
    ''DataGridView1.DataSource = Filtro(TextBox1.Text)
    ''End If
    ''End Sub

    ''Function Filtro(ByVal busqueda As String) As DataTable
    'funcion ciudad

    ''End Function

End Class