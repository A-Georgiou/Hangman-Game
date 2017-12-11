Public Class WonGame

    Private Sub WonGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WordGuessed.Text = "Word Guessed: " + Form1.selectedWord
    End Sub

    'Restarts the game so everything is re-initialised for a new game'
    Private Sub PlayAgain_Click(sender As Object, e As EventArgs) Handles PlayAgain.Click
        Application.Restart()
    End Sub

    'Quits the application
    Private Sub QuitGame_Click(sender As Object, e As EventArgs) Handles QuitGame.Click
        Application.Exit()
    End Sub
End Class