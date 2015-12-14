Public Class VisualizzaFilmPerGenerePerRegista
    Private Sub FilmBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FilmBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FilmDataSet)

    End Sub

    Private Sub VisualizzaFilmPerGenerePerRegista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FilmDataSet.film'. È possibile spostarla o rimuoverla se necessario.
        'Me.FilmTableAdapter.Fill(Me.FilmDataSet.film)

    End Sub

    Private Sub FillByGenreAndDirectorToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.FilmTableAdapter.FillByGenreAndDirector(Me.FilmDataSet.film, New System.Nullable(Of Integer)(CType(GenereToolStripTextBox.Text, Integer)), RegistaToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FilmByGenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmByGenreToolStripMenuItem.Click
        VisualizzaFilmPerGenere.Show()
        Me.Hide()
    End Sub

    Private Sub AddEditDirectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEditDirectorToolStripMenuItem.Click
        AggiungiRegista.Show()
        Me.Hide()
    End Sub

    Private Sub FilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmToolStripMenuItem.Click
        AggiungiFilm.Show()
        Me.Hide()
    End Sub

    Private Sub AddGenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGenreToolStripMenuItem.Click
        AggiungiGenere.Show()
        Me.Hide()
    End Sub

End Class