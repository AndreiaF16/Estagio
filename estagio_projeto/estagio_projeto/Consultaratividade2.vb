Imports System.Data.SqlClient
Public Class Consultaratividade2
    Private Sub AtividadeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AtividadeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IncidenteDataSet)

    End Sub

    Private Sub Consultaratividade2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IncidenteDataSet.Atividade' table. You can move, or remove it, as needed.
        Me.AtividadeTableAdapter.Fill(Me.IncidenteDataSet.Atividade)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim msg = "Tem a certeza que deseja terminar sessao?"
        Dim title = "Terminar Sessão"
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(msg, style, title)

        If response = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        formprincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Consultaratividade2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Validate()
        Me.AtividadeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IncidenteDataSet)
    End Sub

    Private Sub AtividadeBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles AtividadeBindingNavigator.RefreshItems

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label2.Text = "Insira o valor da Data abaixo"
        TextBox1.ResetText()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label2.Text = "Insira o Responsável abaixo"
        TextBox1.ResetText()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label2.Text = "Insira o Número do Incidente abaixo"
        TextBox1.ResetText()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim procura, instrucao As String
        procura = TextBox1.Text
        If RadioButton1.Checked = True Then
            instrucao = "select *from atividade where [Data] like '" & procura & "'"

        ElseIf RadioButton2.Checked = True Then
            instrucao = "select * from atividade where Responsavel like '" & procura & "'"
        Else
            instrucao = "select * from atividade where Incidente  = " & Val(procura)

        End If

        Me.AtividadeTableAdapter.Adapter.SelectCommand.CommandText = instrucao
        Me.AtividadeTableAdapter.Fill(Me.IncidenteDataSet.Atividade)
        Me.AtividadeTableAdapter.Fill(Me.IncidenteDataSet.Atividade)

    End Sub
End Class