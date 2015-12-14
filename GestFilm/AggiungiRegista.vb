Public Class AggiungiRegista
    Private Sub RegistaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RegistaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FilmDataSet)

    End Sub

    Private Sub AggiungiRegista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FilmDataSet.regista'. È possibile spostarla o rimuoverla se necessario.
        Me.RegistaTableAdapter.Fill(Me.FilmDataSet.regista)

    End Sub

    Private Sub FilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmToolStripMenuItem.Click
        AggiungiFilm.Show()
        Me.Hide()
    End Sub

    Private Sub AddGenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGenreToolStripMenuItem.Click
        AggiungiGenere.Show()
        Me.Hide()
    End Sub

    Private Sub FilmByGenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmByGenreToolStripMenuItem.Click
        VisualizzaFilmPerGenere.Show()
        Me.Hide()
    End Sub

    Private Sub FilmByGenreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FilmByGenreToolStripMenuItem1.Click
        VisualizzaFilmPerGenerePerRegista.Show()
        Me.Hide()
    End Sub
End Class