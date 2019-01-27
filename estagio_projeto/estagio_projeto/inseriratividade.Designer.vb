<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inseriratividade
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Cod_atividadeLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim Hora_inicioLabel As System.Windows.Forms.Label
        Dim Hora_fimLabel As System.Windows.Forms.Label
        Dim DuracaoLabel As System.Windows.Forms.Label
        Dim Duracao_deslocacao_Label As System.Windows.Forms.Label
        Dim ResponsavelLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim IncidenteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inseriratividade))
        Me.IncidenteDataSet = New estagio_projeto.incidenteDataSet()
        Me.AtividadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AtividadeTableAdapter = New estagio_projeto.incidenteDataSetTableAdapters.AtividadeTableAdapter()
        Me.TableAdapterManager = New estagio_projeto.incidenteDataSetTableAdapters.TableAdapterManager()
        Me.IncidenteTableAdapter = New estagio_projeto.incidenteDataSetTableAdapters.IncidenteTableAdapter()
        Me.AtividadeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.AtividadeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Cod_atividadeTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Hora_inicioTextBox = New System.Windows.Forms.TextBox()
        Me.Hora_fimTextBox = New System.Windows.Forms.TextBox()
        Me.DuracaoTextBox = New System.Windows.Forms.TextBox()
        Me.Duracao_deslocacao_TextBox = New System.Windows.Forms.TextBox()
        Me.ResponsavelTextBox = New System.Windows.Forms.TextBox()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.IncidenteComboBox = New System.Windows.Forms.ComboBox()
        Me.IncidenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Cod_atividadeLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        Hora_inicioLabel = New System.Windows.Forms.Label()
        Hora_fimLabel = New System.Windows.Forms.Label()
        DuracaoLabel = New System.Windows.Forms.Label()
        Duracao_deslocacao_Label = New System.Windows.Forms.Label()
        ResponsavelLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        IncidenteLabel = New System.Windows.Forms.Label()
        CType(Me.IncidenteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtividadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtividadeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AtividadeBindingNavigator.SuspendLayout()
        CType(Me.IncidenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_atividadeLabel
        '
        Cod_atividadeLabel.AutoSize = True
        Cod_atividadeLabel.Enabled = False
        Cod_atividadeLabel.Location = New System.Drawing.Point(41, 58)
        Cod_atividadeLabel.Name = "Cod_atividadeLabel"
        Cod_atividadeLabel.Size = New System.Drawing.Size(74, 13)
        Cod_atividadeLabel.TabIndex = 1
        Cod_atividadeLabel.Text = "cod atividade:"
        Cod_atividadeLabel.Visible = False
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(41, 85)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 3
        DataLabel.Text = "Data:"
        '
        'Hora_inicioLabel
        '
        Hora_inicioLabel.AutoSize = True
        Hora_inicioLabel.Location = New System.Drawing.Point(41, 110)
        Hora_inicioLabel.Name = "Hora_inicioLabel"
        Hora_inicioLabel.Size = New System.Drawing.Size(58, 13)
        Hora_inicioLabel.TabIndex = 5
        Hora_inicioLabel.Text = "hora inicio:"
        '
        'Hora_fimLabel
        '
        Hora_fimLabel.AutoSize = True
        Hora_fimLabel.Location = New System.Drawing.Point(41, 136)
        Hora_fimLabel.Name = "Hora_fimLabel"
        Hora_fimLabel.Size = New System.Drawing.Size(47, 13)
        Hora_fimLabel.TabIndex = 7
        Hora_fimLabel.Text = "hora fim:"
        '
        'DuracaoLabel
        '
        DuracaoLabel.AutoSize = True
        DuracaoLabel.Location = New System.Drawing.Point(41, 162)
        DuracaoLabel.Name = "DuracaoLabel"
        DuracaoLabel.Size = New System.Drawing.Size(49, 13)
        DuracaoLabel.TabIndex = 9
        DuracaoLabel.Text = "duracao:"
        '
        'Duracao_deslocacao_Label
        '
        Duracao_deslocacao_Label.AutoSize = True
        Duracao_deslocacao_Label.Location = New System.Drawing.Point(41, 188)
        Duracao_deslocacao_Label.Name = "Duracao_deslocacao_Label"
        Duracao_deslocacao_Label.Size = New System.Drawing.Size(110, 13)
        Duracao_deslocacao_Label.TabIndex = 11
        Duracao_deslocacao_Label.Text = "duracao(deslocacao):"
        '
        'ResponsavelLabel
        '
        ResponsavelLabel.AutoSize = True
        ResponsavelLabel.Location = New System.Drawing.Point(41, 214)
        ResponsavelLabel.Name = "ResponsavelLabel"
        ResponsavelLabel.Size = New System.Drawing.Size(72, 13)
        ResponsavelLabel.TabIndex = 13
        ResponsavelLabel.Text = "Responsavel:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(41, 240)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(58, 13)
        DescricaoLabel.TabIndex = 15
        DescricaoLabel.Text = "Descricao:"
        '
        'IncidenteLabel
        '
        IncidenteLabel.AutoSize = True
        IncidenteLabel.Location = New System.Drawing.Point(41, 266)
        IncidenteLabel.Name = "IncidenteLabel"
        IncidenteLabel.Size = New System.Drawing.Size(54, 13)
        IncidenteLabel.TabIndex = 17
        IncidenteLabel.Text = "Incidente:"
        '
        'IncidenteDataSet
        '
        Me.IncidenteDataSet.DataSetName = "incidenteDataSet"
        Me.IncidenteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AtividadeBindingSource
        '
        Me.AtividadeBindingSource.DataMember = "Atividade"
        Me.AtividadeBindingSource.DataSource = Me.IncidenteDataSet
        '
        'AtividadeTableAdapter
        '
        Me.AtividadeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AtividadeTableAdapter = Me.AtividadeTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.IncidenteTableAdapter = Me.IncidenteTableAdapter
        Me.TableAdapterManager.UpdateOrder = estagio_projeto.incidenteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilizadoresTableAdapter = Nothing
        '
        'IncidenteTableAdapter
        '
        Me.IncidenteTableAdapter.ClearBeforeFill = True
        '
        'AtividadeBindingNavigator
        '
        Me.AtividadeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AtividadeBindingNavigator.BindingSource = Me.AtividadeBindingSource
        Me.AtividadeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AtividadeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AtividadeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AtividadeBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.AtividadeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AtividadeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AtividadeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AtividadeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AtividadeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AtividadeBindingNavigator.Name = "AtividadeBindingNavigator"
        Me.AtividadeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AtividadeBindingNavigator.Size = New System.Drawing.Size(427, 25)
        Me.AtividadeBindingNavigator.TabIndex = 0
        Me.AtividadeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'AtividadeBindingNavigatorSaveItem
        '
        Me.AtividadeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AtividadeBindingNavigatorSaveItem.Image = CType(resources.GetObject("AtividadeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AtividadeBindingNavigatorSaveItem.Name = "AtividadeBindingNavigatorSaveItem"
        Me.AtividadeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AtividadeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackgroundImage = Global.estagio_projeto.My.Resources.Resources.voltar_atras
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackgroundImage = Global.estagio_projeto.My.Resources.Resources.gnome_panel_force_quit
        Me.ToolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'Cod_atividadeTextBox
        '
        Me.Cod_atividadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "cod_atividade", True))
        Me.Cod_atividadeTextBox.Enabled = False
        Me.Cod_atividadeTextBox.Location = New System.Drawing.Point(157, 55)
        Me.Cod_atividadeTextBox.Name = "Cod_atividadeTextBox"
        Me.Cod_atividadeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cod_atividadeTextBox.TabIndex = 2
        Me.Cod_atividadeTextBox.Visible = False
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AtividadeBindingSource, "Data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(157, 81)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 4
        '
        'Hora_inicioTextBox
        '
        Me.Hora_inicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "hora_inicio", True))
        Me.Hora_inicioTextBox.Location = New System.Drawing.Point(157, 107)
        Me.Hora_inicioTextBox.Name = "Hora_inicioTextBox"
        Me.Hora_inicioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Hora_inicioTextBox.TabIndex = 6
        '
        'Hora_fimTextBox
        '
        Me.Hora_fimTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "hora_fim", True))
        Me.Hora_fimTextBox.Location = New System.Drawing.Point(157, 133)
        Me.Hora_fimTextBox.Name = "Hora_fimTextBox"
        Me.Hora_fimTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Hora_fimTextBox.TabIndex = 8
        '
        'DuracaoTextBox
        '
        Me.DuracaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "duracao", True))
        Me.DuracaoTextBox.Location = New System.Drawing.Point(157, 159)
        Me.DuracaoTextBox.Name = "DuracaoTextBox"
        Me.DuracaoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DuracaoTextBox.TabIndex = 10
        '
        'Duracao_deslocacao_TextBox
        '
        Me.Duracao_deslocacao_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "duracao(deslocacao)", True))
        Me.Duracao_deslocacao_TextBox.Location = New System.Drawing.Point(157, 185)
        Me.Duracao_deslocacao_TextBox.Name = "Duracao_deslocacao_TextBox"
        Me.Duracao_deslocacao_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Duracao_deslocacao_TextBox.TabIndex = 12
        '
        'ResponsavelTextBox
        '
        Me.ResponsavelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "Responsavel", True))
        Me.ResponsavelTextBox.Location = New System.Drawing.Point(157, 211)
        Me.ResponsavelTextBox.Name = "ResponsavelTextBox"
        Me.ResponsavelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ResponsavelTextBox.TabIndex = 14
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(157, 237)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescricaoTextBox.TabIndex = 16
        '
        'IncidenteComboBox
        '
        Me.IncidenteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "Incidente", True))
        Me.IncidenteComboBox.DataSource = Me.IncidenteBindingSource
        Me.IncidenteComboBox.DisplayMember = "ID"
        Me.IncidenteComboBox.FormattingEnabled = True
        Me.IncidenteComboBox.Location = New System.Drawing.Point(157, 263)
        Me.IncidenteComboBox.Name = "IncidenteComboBox"
        Me.IncidenteComboBox.Size = New System.Drawing.Size(200, 21)
        Me.IncidenteComboBox.TabIndex = 18
        Me.IncidenteComboBox.ValueMember = "ID"
        '
        'IncidenteBindingSource
        '
        Me.IncidenteBindingSource.DataMember = "Incidente"
        Me.IncidenteBindingSource.DataSource = Me.IncidenteDataSet
        '
        'inseriratividade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 334)
        Me.Controls.Add(Cod_atividadeLabel)
        Me.Controls.Add(Me.Cod_atividadeTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(Hora_inicioLabel)
        Me.Controls.Add(Me.Hora_inicioTextBox)
        Me.Controls.Add(Hora_fimLabel)
        Me.Controls.Add(Me.Hora_fimTextBox)
        Me.Controls.Add(DuracaoLabel)
        Me.Controls.Add(Me.DuracaoTextBox)
        Me.Controls.Add(Duracao_deslocacao_Label)
        Me.Controls.Add(Me.Duracao_deslocacao_TextBox)
        Me.Controls.Add(ResponsavelLabel)
        Me.Controls.Add(Me.ResponsavelTextBox)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(IncidenteLabel)
        Me.Controls.Add(Me.IncidenteComboBox)
        Me.Controls.Add(Me.AtividadeBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inseriratividade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inseriratividade"
        CType(Me.IncidenteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtividadeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtividadeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AtividadeBindingNavigator.ResumeLayout(False)
        Me.AtividadeBindingNavigator.PerformLayout()
        CType(Me.IncidenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IncidenteDataSet As incidenteDataSet
    Friend WithEvents AtividadeBindingSource As BindingSource
    Friend WithEvents AtividadeTableAdapter As incidenteDataSetTableAdapters.AtividadeTableAdapter
    Friend WithEvents TableAdapterManager As incidenteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AtividadeBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents AtividadeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Cod_atividadeTextBox As TextBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents Hora_inicioTextBox As TextBox
    Friend WithEvents Hora_fimTextBox As TextBox
    Friend WithEvents DuracaoTextBox As TextBox
    Friend WithEvents Duracao_deslocacao_TextBox As TextBox
    Friend WithEvents ResponsavelTextBox As TextBox
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents IncidenteComboBox As ComboBox
    Friend WithEvents IncidenteTableAdapter As incidenteDataSetTableAdapters.IncidenteTableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents IncidenteBindingSource As BindingSource
End Class
