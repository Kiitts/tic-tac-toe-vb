Imports Tic_Tac_Toe.Module1
Public Class MainMenu
    Public AiGame As Boolean = False
    ''' <summary>
    ''' changes main panel form to GameArea form
    ''' </summary>
    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        AiGame = False
        Module1.loadForm(GameArea, Form1)
    End Sub

    Private Sub computerPlay_Click(sender As Object, e As EventArgs) Handles computerPlay.Click
        AiGame = True
        GameArea.autoLoad.Start()
        Module1.loadForm(GameArea, Form1)
    End Sub
End Class