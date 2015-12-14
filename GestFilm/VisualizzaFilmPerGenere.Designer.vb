<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizzaFilmPerGenere
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddGenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmByGenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmByGenreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmDataSet = New GestFilm.FilmDataSet()
        Me.FilmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilmTableAdapter = New GestFilm.FilmDataSetTableAdapters.filmTableAdapter()
        Me.TableAdapterManager = New GestFilm.FilmDataSetTableAdapters.TableAdapterManager()
        Me.GenereTableAdapter = New GestFilm.FilmDataSetTableAdapters.genereTableAdapter()
        Me.FilmDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GenerefilmBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenereBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GenerefilmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenerefilmBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.GenereToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.GenereToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FilmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerefilmBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenereBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerefilmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerefilmBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(390, 24)
        Me.MenuStrip1.TabIndex = 11
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
        Me.FilmByGenreToolStripMenuItem.Enabled = False
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
        Me.TableAdapterManager.genereTableAdapter = Me.GenereTableAdapter
        Me.TableAdapterManager.registaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestFilm.FilmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GenereTableAdapter
        '
        Me.GenereTableAdapter.ClearBeforeFill = True
        '
        'FilmDataGridView
        '
        Me.FilmDataGridView.AutoGenerateColumns = False
        Me.FilmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FilmDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.FilmDataGridView.DataSource = Me.FilmBindingSource
        Me.FilmDataGridView.Location = New System.Drawing.Point(0, 52)
        Me.FilmDataGridView.Name = "FilmDataGridView"
        Me.FilmDataGridView.Size = New System.Drawing.Size(370, 250)
        Me.FilmDataGridView.TabIndex = 12
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
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FilmDataSet, "genere.Denominazione", True))
        Me.ComboBox1.DataSource = Me.GenerefilmBindingSource2
        Me.ComboBox1.DisplayMember = "genere"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(95, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.ValueMember = "genere"
        '
        'GenerefilmBindingSource2
        '
        Me.GenerefilmBindingSource2.DataMember = "generefilm"
        Me.GenerefilmBindingSource2.DataSource = Me.GenereBindingSource
        '
        'GenereBindingSource
        '
        Me.GenereBindingSource.DataMember = "genere"
        Me.GenereBindingSource.DataSource = Me.FilmDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Genre:"
        '
        'GenerefilmBindingSource
        '
        Me.GenerefilmBindingSource.DataMember = "generefilm"
        Me.GenerefilmBindingSource.DataSource = Me.GenereBindingSource
        '
        'GenerefilmBindingSource1
        '
        Me.GenerefilmBindingSource1.DataMember = "generefilm"
        Me.GenerefilmBindingSource1.DataSource = Me.GenereBindingSource
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenereToolStripLabel, Me.GenereToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(390, 25)
        Me.FillByToolStrip.TabIndex = 15
        Me.FillByToolStrip.Text = "FillByToolStrip"
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
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'VisualizzaFilmPerGenere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 300)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.FilmDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "VisualizzaFilmPerGenere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisualizzaFilmPerGenere"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.FilmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerefilmBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenereBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerefilmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerefilmBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEditDirectorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddGenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmByGenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmByGenreToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FilmDataSet As FilmDataSet
    Friend WithEvents FilmBindingSource As BindingSource
    Friend WithEvents FilmTableAdapter As FilmDataSetTableAdapters.filmTableAdapter
    Friend WithEvents TableAdapterManager As FilmDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FilmDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GenereTableAdapter As FilmDataSetTableAdapters.genereTableAdapter
    Friend WithEvents GenereBindingSource As BindingSource
    Friend WithEvents GenerefilmBindingSource As BindingSource
    Friend WithEvents GenerefilmBindingSource1 As BindingSource
    Friend WithEvents GenerefilmBindingSource2 As BindingSource
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents GenereToolStripLabel As ToolStripLabel
    Friend WithEvents GenereToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
End Class
