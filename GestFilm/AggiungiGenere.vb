Public Class AggiungiGenere
    Private Sub GenereBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GenereBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FilmDataSet)

    End Sub

    Private Sub AggiungiGenere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FilmDataSet.genere'. È possibile spostarla o rimuoverla se necessario.
        Me.GenereTableAdapter.Fill(Me.FilmDataSet.genere)

    End Sub

    Private Sub FilmByGenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmByGenreToolStripMenuItem.Click
        VisualizzaFilmPerGenere.Show()
        Me.Hide()
    End Sub

    Private Sub FilmByGenreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FilmByGenreToolStripMenuItem1.Click
        VisualizzaFilmPerGenerePerRegista.Show()
        Me.Hide()
    End Sub

    Private Sub FilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmToolStripMenuItem.Click
        AggiungiFilm.Show()
        Me.Hide()
    End Sub

    Private Sub AddEditDirectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEditDirectorToolStripMenuItem.Click
        AggiungiRegista.Show()
        Me.Hide()
    End Sub
End Class