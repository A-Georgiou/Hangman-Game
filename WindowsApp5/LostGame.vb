Public Class LostGame

    'Quits the application
    Private Sub QuitGame_Click(sender As Object, e As EventArgs) Handles QuitGame.Click
        Application.Exit()
    End Sub

    'Restarts the game so everything is re-initialised for a new game'
    Private Sub TryAgain_Click(sender As Object, e As EventArgs) Handles TryAgain.Click
        Application.Restart()
    End Sub

    'When Form is loaded gets the selected word from Form1'
    Private Sub LostGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WordWas.Text = "Word Was: " + Form1.selectedWord
    End Sub
End Class