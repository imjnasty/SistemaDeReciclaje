Public Class GenerarHojaRuta
    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        TextBox6.Text = MaskedTextBox1.Text
    End Sub
End Class