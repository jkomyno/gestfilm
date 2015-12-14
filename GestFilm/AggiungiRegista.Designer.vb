<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AggiungiRegista
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CodiceLabel As System.Windows.Forms.Label
        Dim CognomeLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AggiungiRegista))
        Me.FilmDataSet = New GestFilm.FilmDataSet()
        Me.RegistaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistaTableAdapter = New GestFilm.FilmDataSetTableAdapters.registaTableAdapter()
        Me.TableAdapterManager = New GestFilm.FilmDataSetTableAdapters.TableAdapterManager()
        Me.CodiceTextBox = New System.Windows.Forms.TextBox()
        Me.CognomeTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddGenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmByGenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmByGenreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CodiceLabel = New System.Windows.Forms.Label()
        CognomeLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.FilmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.RegistaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodiceLabel
        '
        CodiceLabel.AutoSize = True
        CodiceLabel.Location = New System.Drawing.Point(62, 77)
        CodiceLabel.Name = "CodiceLabel"
        CodiceLabel.Size = New System.Drawing.Size(42, 13)
        CodiceLabel.TabIndex = 1
        CodiceLabel.Text = "codice:"
        '
        'CognomeLabel
        '
        CognomeLabel.AutoSize = True
        CognomeLabel.Location = New System.Drawing.Point(62, 103)
        CognomeLabel.Name = "CognomeLabel"
        CognomeLabel.Size = New System.Drawing.Size(55, 13)
        CognomeLabel.TabIndex = 3
        CognomeLabel.Text = "Cognome:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(62, 129)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 5
        NomeLabel.Text = "Nome:"
        '
        'FilmDataSet
        '
        Me.FilmDataSet.DataSetName = "FilmDataSet"
        Me.FilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistaBindingSource
        '
        Me.RegistaBindingSource.DataMember = "regista"
        Me.RegistaBindingSource.DataSource = Me.FilmDataSet
        '
        'RegistaTableAdapter
        '
        Me.RegistaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.filmTableAdapter = Nothing
        Me.TableAdapterManager.genereTableAdapter = Nothing
        Me.TableAdapterManager.registaTableAdapter = Me.RegistaTableAdapter
        Me.TableAdapterManager.UpdateOrder = GestFilm.FilmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CodiceTextBox
        '
        Me.CodiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistaBindingSource, "codice", True))
        Me.CodiceTextBox.Location = New System.Drawing.Point(123, 74)
        Me.CodiceTextBox.Name = "CodiceTextBox"
        Me.CodiceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodiceTextBox.TabIndex = 2
        '
        'CognomeTextBox
        '
        Me.CognomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistaBindingSource, "Cognome", True))
        Me.CognomeTextBox.Location = New System.Drawing.Point(123, 100)
        Me.CognomeTextBox.Name = "CognomeTextBox"
        Me.CognomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CognomeTextBox.TabIndex = 4
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistaBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(123, 126)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomeTextBox.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilmToolStripMenuItem, Me.AddEditDirectorToolStripMenuItem, Me.AddGenreToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FilmToolStripMenuItem
        '
        Me.FilmToolStripMenuItem.Name = "FilmToolStripMenuItem"
        Me.FilmToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.FilmToolStripMenuItem.Text = "Add/Edit Film"
        '
        'AddEditDirectorToolStripMenuItem
        '
        Me.AddEditDirectorToolStripMenuItem.Enabled = False
        Me.AddEditDirectorToolStripMenuItem.Name = "AddEditDirectorToolStripMenuItem"
        Me.AddEditDirectorToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AddEditDirectorToolStripMenuItem.Text = "Add/Edit Director"
        '
        'AddGenreToolStripMenuItem
        '
        Me.AddGenreToolStripMenuItem.Name = "AddGenreToolStripMenuItem"
        Me.AddGenreToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AddGenreToolStripMenuItem.Text = "Add Genre"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilmByGenreToolStripMenuItem, Me.FilmByGenreToolStripMenuItem1})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'FilmByGenreToolStripMenuItem
        '
        Me.FilmByGenreToolStripMenuItem.Name = "FilmByGenreToolStripMenuItem"
        Me.FilmByGenreToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.FilmByGenreToolStripMenuItem.Text = "Film By Genre"
        '
        'FilmByGenreToolStripMenuItem1
        '
        Me.FilmByGenreToolStripMenuItem1.Name = "FilmByGenreToolStripMenuItem1"
        Me.FilmByGenreToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
        Me.FilmByGenreToolStripMenuItem1.Text = "Film By Genre By Director"
        '
        'RegistaBindingNavigator
        '
        Me.RegistaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegistaBindingNavigator.BindingSource = Me.RegistaBindingSource
        Me.RegistaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegistaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegistaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegistaBindingNavigatorSaveItem})
        Me.RegistaBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.RegistaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegistaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegistaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegistaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegistaBindingNavigator.Name = "RegistaBindingNavigator"
        Me.RegistaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegistaBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.RegistaBindingNavigator.TabIndex = 11
        Me.RegistaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Aggiungi nuovo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 22)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Sposta indietro"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RegistaBindingNavigatorSaveItem
        '
        Me.RegistaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegistaBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegistaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegistaBindingNavigatorSaveItem.Name = "RegistaBindingNavigatorSaveItem"
        Me.RegistaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RegistaBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'AggiungiRegista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.RegistaBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(CodiceLabel)
        Me.Controls.Add(Me.CodiceTextBox)
        Me.Controls.Add(CognomeLabel)
        Me.Controls.Add(Me.CognomeTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Name = "AggiungiRegista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AggiungiRegista"
        CType(Me.FilmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.RegistaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistaBindingNavigator.ResumeLayout(False)
        Me.RegistaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FilmDataSet As FilmDataSet
    Friend WithEvents RegistaBindingSource As BindingSource
    Friend WithEvents RegistaTableAdapter As FilmDataSetTableAdapters.registaTableAdapter
    Friend WithEvents TableAdapterManager As FilmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CodiceTextBox As TextBox
    Friend WithEvents CognomeTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEditDirectorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddGenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmByGenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmByGenreToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegistaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RegistaBindingNavigatorSaveItem As ToolStripButton
End Class
