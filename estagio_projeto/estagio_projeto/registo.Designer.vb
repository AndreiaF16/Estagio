<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registo))
        Dim Cod_utilizadoresLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Palavra_passeLabel As System.Windows.Forms.Label
        Me.IncidenteDataSet = New estagio_projeto.incidenteDataSet()
        Me.UtilizadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtilizadoresTableAdapter = New estagio_projeto.incidenteDataSetTableAdapters.UtilizadoresTableAdapter()
        Me.TableAdapterManager = New estagio_projeto.incidenteDataSetTableAdapters.TableAdapterManager()
        Me.UtilizadoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UtilizadoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cod_utilizadoresTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.Palavra_passeTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Cod_utilizadoresLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Palavra_passeLabel = New System.Windows.Forms.Label()
        CType(Me.IncidenteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizadoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UtilizadoresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IncidenteDataSet
        '
        Me.IncidenteDataSet.DataSetName = "incidenteDataSet"
        Me.IncidenteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilizadoresBindingSource
        '
        Me.UtilizadoresBindingSource.DataMember = "Utilizadores"
        Me.UtilizadoresBindingSource.DataSource = Me.IncidenteDataSet
        '
        'UtilizadoresTableAdapter
        '
        Me.UtilizadoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AtividadeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.IncidenteTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = estagio_projeto.incidenteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilizadoresTableAdapter = Me.UtilizadoresTableAdapter
        '
        'UtilizadoresBindingNavigator
        '
        Me.UtilizadoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UtilizadoresBindingNavigator.BindingSource = Me.UtilizadoresBindingSource
        Me.UtilizadoresBindingNavigator.CountItem = Nothing
        Me.UtilizadoresBindingNavigator.DeleteItem = Nothing
        Me.UtilizadoresBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.UtilizadoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.UtilizadoresBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.UtilizadoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UtilizadoresBindingNavigator.MoveFirstItem = Nothing
        Me.UtilizadoresBindingNavigator.MoveLastItem = Nothing
        Me.UtilizadoresBindingNavigator.MoveNextItem = Nothing
        Me.UtilizadoresBindingNavigator.MovePreviousItem = Nothing
        Me.UtilizadoresBindingNavigator.Name = "UtilizadoresBindingNavigator"
        Me.UtilizadoresBindingNavigator.PositionItem = Nothing
        Me.UtilizadoresBindingNavigator.Size = New System.Drawing.Size(255, 25)
        Me.UtilizadoresBindingNavigator.TabIndex = 0
        Me.UtilizadoresBindingNavigator.Text = "BindingNavigator1"
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
        'UtilizadoresBindingNavigatorSaveItem
        '
        Me.UtilizadoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UtilizadoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("UtilizadoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UtilizadoresBindingNavigatorSaveItem.Name = "UtilizadoresBindingNavigatorSaveItem"
        Me.UtilizadoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UtilizadoresBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Cod_utilizadoresLabel
        '
        Cod_utilizadoresLabel.AutoSize = True
        Cod_utilizadoresLabel.Location = New System.Drawing.Point(42, 87)
        Cod_utilizadoresLabel.Name = "Cod_utilizadoresLabel"
        Cod_utilizadoresLabel.Size = New System.Drawing.Size(83, 13)
        Cod_utilizadoresLabel.TabIndex = 1
        Cod_utilizadoresLabel.Text = "cod utilizadores:"
        '
        'Cod_utilizadoresTextBox
        '
        Me.Cod_utilizadoresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilizadoresBindingSource, "cod_utilizadores", True))
        Me.Cod_utilizadoresTextBox.Location = New System.Drawing.Point(131, 84)
        Me.Cod_utilizadoresTextBox.Name = "Cod_utilizadoresTextBox"
        Me.Cod_utilizadoresTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_utilizadoresTextBox.TabIndex = 2
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(42, 113)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(36, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "nome:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilizadoresBindingSource, "nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(131, 110)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'Palavra_passeLabel
        '
        Palavra_passeLabel.AutoSize = True
        Palavra_passeLabel.Location = New System.Drawing.Point(42, 139)
        Palavra_passeLabel.Name = "Palavra_passeLabel"
        Palavra_passeLabel.Size = New System.Drawing.Size(76, 13)
        Palavra_passeLabel.TabIndex = 5
        Palavra_passeLabel.Text = "palavra passe:"
        '
        'Palavra_passeTextBox
        '
        Me.Palavra_passeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilizadoresBindingSource, "palavra_passe", True))
        Me.Palavra_passeTextBox.Location = New System.Drawing.Point(131, 136)
        Me.Palavra_passeTextBox.Name = "Palavra_passeTextBox"
        Me.Palavra_passeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Palavra_passeTextBox.TabIndex = 6
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackgroundImage = Global.estagio_projeto.My.Resources.Resources.Login
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
        'registo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 208)
        Me.Controls.Add(Cod_utilizadoresLabel)
        Me.Controls.Add(Me.Cod_utilizadoresTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Palavra_passeLabel)
        Me.Controls.Add(Me.Palavra_passeTextBox)
        Me.Controls.Add(Me.UtilizadoresBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registo"
        CType(Me.IncidenteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizadoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UtilizadoresBindingNavigator.ResumeLayout(False)
        Me.UtilizadoresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IncidenteDataSet As incidenteDataSet
    Friend WithEvents UtilizadoresBindingSource As BindingSource
    Friend WithEvents UtilizadoresTableAdapter As incidenteDataSetTableAdapters.UtilizadoresTableAdapter
    Friend WithEvents TableAdapterManager As incidenteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UtilizadoresBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents UtilizadoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Cod_utilizadoresTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents Palavra_passeTextBox As TextBox
End Class
