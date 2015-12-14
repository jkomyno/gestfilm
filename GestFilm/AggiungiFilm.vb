Public Class AggiungiFilm
    Private Sub FilmBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FilmBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FilmDataSet)

    End Sub

    Private Sub AggiungiFilm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FilmDataSet.film'. È possibile spostarla o rimuoverla se necessario.
        Me.FilmTableAdapter.Fill(Me.FilmDataSet.film)

    End Sub

    Private Sub AddEditDirectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEditDirectorToolStripMenuItem.Click
        AggiungiRegista.Show()
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

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub FilmBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles FilmBindingNavigatorSaveItem.Click

    End Sub
End Class