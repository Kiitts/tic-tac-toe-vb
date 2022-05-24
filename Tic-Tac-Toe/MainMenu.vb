Imports Tic_Tac_Toe.Module1
Public Class MainMenu
    ''' <summary>
    ''' changes main panel form to GameArea form
    ''' </summary>
    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        Module1.loadForm(GameArea, Form1)
    End Sub
End Class