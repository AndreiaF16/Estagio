Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim passe As String
        passe = InputBox("Insira o código de registo")
        If passe = "registo123" Then
            registo.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim msg = "Tem a certeza que deseja sair?"
        Dim title = "Sair"
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(msg, style, title)

        If response = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'vefica se os campos do nome de utilizador ou palavra passe estao vazios 
        If txtpassword.Text = "" Or txtusername.Text = "" Then
            MessageBox.Show("Por favor preencha os campos..", "Erro de Autenticaçao", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\1.IMPORTANTE_ESTAGIO\1.funciona\incidente.accdb"

            Try
                Dim sql As String = "Select * FROM utilizadores WHERE nome='" & txtusername.Text & "' AND palavra_passe = '" & txtpassword.Text & "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                'Abrir conexao da Base de Dados
                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
                If sqlRead.Read() Then
                    formprincipal.Show()
                    Me.Hide()
                Else
                    ' Se o utilizador coloca mal o nome de utilizador e a palavra passe
                    ' Mostra MEnsagem de Erro
                    MessageBox.Show("Nome de Utilizador e Palavra Passe nao correspondem.", "Autenticaçao Falhou", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    'Limpar Todos os Campos
                    txtpassword.Text = ""
                    txtusername.Text = ""

                    'Focus on Username field
                    txtusername.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Falhou a conexão à Base de Dados.. Erro do Sistema: " & ex.Message, "Erro de conexão à base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

End Class