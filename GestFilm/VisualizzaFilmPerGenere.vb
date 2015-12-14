Public Class VisualizzaFilmPerGenere
    Private Sub FilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmToolStripMenuItem.Click
        AggiungiFilm.Show()
        Me.Hide()
    End Sub

    Private Sub AddEditDirectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEditDirectorToolStripMenuItem.Click
        AggiungiRegista.Show()
        Me.Hide()
    End Sub

    Private Sub AddGenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGenreToolStripMenuItem.Click
        AggiungiGenere.Show()
        Me.Hide()
    End Sub

    Private Sub FilmBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FilmBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FilmDataSet)

    End Sub

    Private Sub VisualizzaFilmPerGenere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FilmDataSet.genere'. È possibile spostarla o rimuoverla se necessario.
        Me.GenereTableAdapter.Fill(Me.FilmDataSet.genere)
        'TODO: questa riga di codice carica i dati nella tabella 'FilmDataSet.film'. È possibile spostarla o rimuoverla se necessario.
        'Me.FilmTableAdapter.Fill(Me.FilmDataSet.film)


    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.FilmTableAdapter.FillByGenre(Me.FilmDataSet.film, New System.Nullable(Of Integer)(CType(GenereToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FilmByGenreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FilmByGenreToolStripMenuItem1.Click
        VisualizzaFilmPerGenerePerRegista.Show()
        Me.Hide()
    End Sub
End Class