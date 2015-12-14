<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AggiungiFilm
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim TitoloLabel As System.Windows.Forms.Label
        Dim GenereLabel As System.Windows.Forms.Label
        Dim RegistaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AggiungiFilm))
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FilmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilmDataSet = New GestFilm.FilmDataSet()
        Me.TitoloTextBox = New System.Windows.Forms.TextBox()
        Me.GenereTextBox = New System.Windows.Forms.TextBox()
        Me.RegistaTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddGenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmByGenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmByGenreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FilmBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FilmTableAdapter = New GestFilm.FilmDataSetTableAdapters.filmTableAdapter()
        Me.TableAdapterManager = New GestFilm.FilmDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        TitoloLabel = New System.Windows.Forms.Label()
        GenereLabel = New System.Windows.Forms.Label()
        RegistaLabel = New System.Windows.Forms.Label()
        CType(Me.FilmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FilmBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FilmBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(61, 71)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'TitoloLabel
        '
        TitoloLabel.AutoSize = True
        TitoloLabel.Location = New System.Drawing.Point(61, 97)
        TitoloLabel.Name = "TitoloLabel"
        TitoloLabel.Size = New System.Drawing.Size(36, 13)
        TitoloLabel.TabIndex = 3
        TitoloLabel.Text = "Titolo:"
        '
        'GenereLabel
        '
        GenereLabel.AutoSize = True
        GenereLabel.Location = New System.Drawing.Point(61, 123)
        GenereLabel.Name = "GenereLabel"
        GenereLabel.Size = New System.Drawing.Size(43, 13)
        GenereLabel.TabIndex = 5
        GenereLabel.Text = "genere:"
        '
        'RegistaLabel
        '
        RegistaLabel.AutoSize = True
        RegistaLabel.Location = New System.Drawing.Point(61, 149)
        RegistaLabel.Name = "RegistaLabel"
        RegistaLabel.Size = New System.Drawing.Size(41, 13)
        RegistaLabel.TabIndex = 7
        RegistaLabel.Text = "regista:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(110, 68)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'FilmBindingSource
        '
        Me.FilmBindingSource.DataMember = "film"
        Me.FilmBindingSource.DataSource = Me.FilmDataSet
        '
        'FilmDataSet
        '
        Me.FilmDataSet.DataSetName = "FilmDataSet"
        Me.FilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitoloTextBox
        '
        Me.TitoloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmBindingSource, "Titolo", True))
        Me.TitoloTextBox.Location = New System.Drawing.Point(110, 94)
        Me.TitoloTextBox.Name = "TitoloTextBox"
        Me.TitoloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitoloTextBox.TabIndex = 4
        '
        'GenereTextBox
        '
        Me.GenereTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmBindingSource, "genere", True))
        Me.GenereTextBox.Location = New System.Drawing.Point(110, 120)
        Me.GenereTextBox.Name = "GenereTextBox"
        Me.GenereTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenereTextBox.TabIndex = 6
        '
        'RegistaTextBox
        '
        Me.RegistaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FilmBindingSource, "regista", True))
        Me.RegistaTextBox.Location = New System.Drawing.Point(110, 146)
        Me.RegistaTextBox.Name = "RegistaTextBox"
        Me.RegistaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RegistaTextBox.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 9
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
        Me.FilmToolStripMenuItem.Enabled = False
        Me.FilmToolStripMenuItem.Name = "FilmToolStripMenuItem"
        Me.FilmToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.FilmToolStripMenuItem.Text = "Add/Edit Film"
        '
        'AddEditDirectorToolStripMenuItem
        '
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
        'FilmBindingNavigator
        '
        Me.FilmBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FilmBindingNavigator.BindingSource = Me.FilmBindingSource
        Me.FilmBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FilmBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FilmBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FilmBindingNavigatorSaveItem})
        Me.FilmBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.FilmBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FilmBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FilmBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FilmBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FilmBindingNavigator.Name = "FilmBindingNavigator"
        Me.FilmBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FilmBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.FilmBindingNavigator.TabIndex = 10
        Me.FilmBindingNavigator.Text = "BindingNavigator1"
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
        'FilmBindingNavigatorSaveItem
        '
        Me.FilmBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FilmBindingNavigatorSaveItem.Image = CType(resources.GetObject("FilmBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FilmBindingNavigatorSaveItem.Name = "FilmBindingNavigatorSaveItem"
        Me.FilmBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.FilmBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'FilmTableAdapter
        '
        Me.FilmTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.filmTableAdapter = Me.FilmTableAdapter
        Me.TableAdapterManager.genereTableAdapter = Nothing
        Me.TableAdapterManager.registaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestFilm.FilmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AggiungiFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.FilmBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(TitoloLabel)
        Me.Controls.Add(Me.TitoloTextBox)
        Me.Controls.Add(GenereLabel)
        Me.Controls.Add(Me.GenereTextBox)
        Me.Controls.Add(RegistaLabel)
        Me.Controls.Add(Me.RegistaTextBox)
        Me.Name = "AggiungiFilm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AggiungiFilm"
        CType(Me.FilmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.FilmBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FilmBindingNavigator.ResumeLayout(False)
        Me.FilmBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FilmDataSet As FilmDataSet
    Friend WithEvents FilmBindingSource As BindingSource
    Friend WithEvents FilmTableAdapter As FilmDataSetTableAdapters.filmTableAdapter
    Friend WithEvents TableAdapterManager As FilmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents TitoloTextBox As TextBox
    Friend WithEvents GenereTextBox As TextBox
    Friend WithEvents RegistaTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEditDirectorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddGenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmByGenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmByGenreToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FilmBindingNavigator As BindingNavigator
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
    Friend WithEvents FilmBindingNavigatorSaveItem As ToolStripButton
End Class
