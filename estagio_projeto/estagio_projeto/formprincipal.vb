Public Class formprincipal
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim msg = "Tem a certeza que deseja terminar sessao?"
        Dim title = "Terminar Sessão"
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(msg, style, title)

        If response = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        inseriratividade.Show()
        Me.Hide()
    End Sub

    Private Sub btnregistar_Click(sender As Object, e As EventArgs) Handles btnregistar.Click
        Consultaratividade2.Show()
        Me.Hide()
    End Sub

    Private Sub formprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class