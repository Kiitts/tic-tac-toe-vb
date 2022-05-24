Imports Tic_Tac_Toe.Module1
Public Class GameArea
    ''' <summary>
    ''' changes main panel form to MainMenu form
    ''' </summary>
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Module1.loadForm(MainMenu, Form1)
    End Sub
End Class