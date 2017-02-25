Public Class CadastroCliente
    Public _nome As String
    Public _telefone As String
    Public _email As String

    Public Sub setDados(ByVal nome As String, ByVal telefone As String, ByVal email As String)
        Me._nome = nome
        Me._telefone = telefone
        Me._email = email

    End Sub

End Class
