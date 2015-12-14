Public Class Form1
    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub FilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmToolStripMenuItem.Click
        AggiungiFilm.Show()
        Me.Hide()
    End Sub

    Private Sub FilmByGenreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FilmByGenreToolStripMenuItem1.Click
        VisualizzaFilmPerGenerePerRegista.Show()
        Me.Hide()
    End Sub

    Private Sub AddEditDirectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEditDirectorToolStripMenuItem.Click
        AggiungiRegista.Show()
        Me.Hide()
    End Sub

    Private Sub FilmByGenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmByGenreToolStripMenuItem.Click
        VisualizzaFilmPerGenere.Show()
        Me.Hide()
    End Sub

    Private Sub AddGenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGenreToolStripMenuItem.Click
        AggiungiGenere.Show()
        Me.Hide()
    End Sub
End Class
