Imports System.Data.SqlClient
Public Class inseriratividade
    Private Sub AtividadeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AtividadeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AtividadeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IncidenteDataSet)

    End Sub

    Private Sub inseriratividade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IncidenteDataSet.Incidente' table. You can move, or remove it, as needed.
        Me.IncidenteTableAdapter.Fill(Me.IncidenteDataSet.Incidente)
        'TODO: This line of code loads data into the 'IncidenteDataSet.Atividade' table. You can move, or remove it, as needed.
        Me.AtividadeTableAdapter.Fill(Me.IncidenteDataSet.Atividade)
        Me.BindingNavigatorDeleteItem.Enabled = True
        Me.BindingNavigatorAddNewItem.Enabled = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        formprincipal.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim msg = "Tem a certeza que deseja terminar sessao?"
        Dim title = "Terminar Sessao"
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(msg, style, title)

        If response = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.AtividadeBindingSource.EndEdit()
        Me.AtividadeTableAdapter.Fill(Me.IncidenteDataSet.Atividade)
    End Sub

    Private Sub inseriratividade_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Validate()
        Me.AtividadeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(IncidenteDataSet )
    End Sub
End Class