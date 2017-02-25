Public Class Form1
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        End
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtNome.Text = ""
        txtEmail.Text = ""
        txtTelefone.Text = ""
    End Sub

    Private Sub btnsSalvar_Click(sender As Object, e As EventArgs) Handles btnsSalvar.Click
        Dim classes As CadastroCliente
        classes = New CadastroCliente()

        classes.setDados(txtNome.Text, txtEmail.Text, txtTelefone.Text)

        Dim classes2 As BancodeDados
        classes2 = New BancodeDados()
        classes2.Funcao1(classes)

    End Sub
End Class
