<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizzaFilmPerGenerePerRegista
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
        Me.FilmDataSet = New GestFilm.FilmDataSet()
        Me.FilmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilmTableAdapter = New GestFilm.FilmDataSetTableAdapters.filmTableAdapter()
        Me.TableAdapterManager = New GestFilm.FilmDataSetTableAdapters.TableAdapterManager()
        Me.FilmDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddGenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmByGenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmByGenreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FillByGenreAndDirectorToolStrip = New System.Windows.Forms.ToolStrip()
        Me.GenereToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.GenereToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RegistaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.RegistaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByGenreAndDirectorToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.FilmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.FillByGenreAndDirectorToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilmDataSet
        '
        Me.FilmDataSet.DataSetName = "FilmDataSet"
        Me.FilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FilmBindingSource
        '
        Me.FilmBindingSource.DataMember = "film"
        Me.FilmBindingSource.DataSource = Me.FilmDataSet
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
        'FilmDataGridView
        '
        Me.FilmDataGridView.AutoGenerateColumns = False
        Me.FilmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FilmDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.FilmDataGridView.DataSource = Me.FilmBindingSource
        Me.FilmDataGridView.Location = New System.Drawing.Point(0, 56)
        Me.FilmDataGridView.Name = "FilmDataGridView"
        Me.FilmDataGridView.Size = New System.Drawing.Size(447, 250)
        Me.FilmDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Titolo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "genere"
        Me.DataGridViewTextBoxColumn3.HeaderText = "genere"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "regista"
        Me.DataGridViewTextBoxColumn4.HeaderText = "regista"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(447, 24)
        Me.MenuStrip1.TabIndex = 12
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
        Me.FilmByGenreToolStripMenuItem1.Enabled = False
        Me.FilmByGenreToolStripMenuItem1.Name = "FilmByGenreToolStripMenuItem1"
        Me.FilmByGenreToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
        Me.FilmByGenreToolStripMenuItem1.Text = "Film By Genre By Director"
        '
        'FillByGenreAndDirectorToolStrip
        '
        Me.FillByGenreAndDirectorToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenereToolStripLabel, Me.GenereToolStripTextBox, Me.RegistaToolStripLabel, Me.RegistaToolStripTextBox, Me.FillByGenreAndDirectorToolStripButton})
        Me.FillByGenreAndDirectorToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.FillByGenreAndDirectorToolStrip.Name = "FillByGenreAndDirectorToolStrip"
        Me.FillByGenreAndDirectorToolStrip.Size = New System.Drawing.Size(447, 25)
        Me.FillByGenreAndDirectorToolStrip.TabIndex = 13
        Me.FillByGenreAndDirectorToolStrip.Text = "FillByGenreAndDirectorToolStrip"
        '
        'GenereToolStripLabel
        '
        Me.GenereToolStripLabel.Name = "GenereToolStripLabel"
        Me.GenereToolStripLabel.Size = New System.Drawing.Size(46, 22)
        Me.GenereToolStripLabel.Text = "genere:"
        '
        'GenereToolStripTextBox
        '
        Me.GenereToolStripTextBox.Name = "GenereToolStripTextBox"
        Me.GenereToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'RegistaToolStripLabel
        '
        Me.RegistaToolStripLabel.Name = "RegistaToolStripLabel"
        Me.RegistaToolStripLabel.Size = New System.Drawing.Size(45, 22)
        Me.RegistaToolStripLabel.Text = "regista:"
        '
        'RegistaToolStripTextBox
        '
        Me.RegistaToolStripTextBox.Name = "RegistaToolStripTextBox"
        Me.RegistaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByGenreAndDirectorToolStripButton
        '
        Me.FillByGenreAndDirectorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByGenreAndDirectorToolStripButton.Name = "FillByGenreAndDirectorToolStripButton"
        Me.FillByGenreAndDirectorToolStripButton.Size = New System.Drawing.Size(134, 19)
        Me.FillByGenreAndDirectorToolStripButton.Text = "FillByGenreAndDirector"
        '
        'VisualizzaFilmPerGenerePerRegista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 307)
        Me.Controls.Add(Me.FillByGenreAndDirectorToolStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.FilmDataGridView)
        Me.Name = "VisualizzaFilmPerGenerePerRegista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisualizzaFilmPerGenerePerRegista"
        CType(Me.FilmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FillByGenreAndDirectorToolStrip.ResumeLayout(False)
        Me.FillByGenreAndDirectorToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FilmDataSet As FilmDataSet
    Friend WithEvents FilmBindingSource As BindingSource
    Friend WithEvents FilmTableAdapter As FilmDataSetTableAdapters.filmTableAdapter
    Friend WithEvents TableAdapterManager As FilmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FilmDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEditDirectorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddGenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmByGenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmByGenreToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FillByGenreAndDirectorToolStrip As ToolStrip
    Friend WithEvents GenereToolStripLabel As ToolStripLabel
    Friend WithEvents GenereToolStripTextBox As ToolStripTextBox
    Friend WithEvents RegistaToolStripLabel As ToolStripLabel
    Friend WithEvents RegistaToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByGenreAndDirectorToolStripButton As ToolStripButton
End Class
