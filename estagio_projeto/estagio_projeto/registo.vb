Public Class registo
    Private Sub UtilizadoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UtilizadoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtilizadoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IncidenteDataSet)

    End Sub

    Private Sub registo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IncidenteDataSet.Utilizadores' table. You can move, or remove it, as needed.
        Me.UtilizadoresTableAdapter.Fill(Me.IncidenteDataSet.Utilizadores)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.UtilizadoresBindingSource.EndEdit()
        Me.UtilizadoresTableAdapter.Fill(Me.IncidenteDataSet.Utilizadores)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        End
    End Sub
End Class