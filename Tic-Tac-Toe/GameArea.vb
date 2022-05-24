Imports Tic_Tac_Toe.Module1 ' module for changing main panel forms


Public Class GameArea
    Public player1Turn As Boolean = True
    Public buttons() As Button

    ''' <summary>
    ''' Load the buttons in the array when GameArea form loads
    ''' </summary>
    Private Sub GameArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttons = {t11, t12, t13, t21, t22, t23, t31, t32, t33}
    End Sub
    ''' <summary>
    ''' Make a play on a tile, or put a x and o in tile depending on whos
    ''' turn it is
    ''' </summary>
    ''' <param name="but">button that is clicked</param>
    Public Sub Play(but As Button)
        ''' Check if btn has already an image
        If but.Image IsNot Nothing Then
            MessageBox.Show("The tile is used already.")
        Else
            ''' Check whos turn
            If player1Turn Then
                but.Image = My.Resources.xtile_gamearea1
                turnLabel.Text = "PLAYER 2 [O] Turn"
                player1Turn = Not player1Turn
            Else
                but.Image = My.Resources.otile_gamearea1
                turnLabel.Text = "PLAYER 1 [X] Turn"
                player1Turn = Not player1Turn
            End If
        End If
    End Sub

    ''' <summary>
    ''' changes main panel form to MainMenu form
    ''' </summary>
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        For i = 0 To 8
            If buttons(i).Image IsNot Nothing Then
                buttons(i).Image = Nothing
            End If
        Next
        player1Turn = True
        Module1.loadForm(MainMenu, Form1)
    End Sub

    ''' <summary>
    ''' This will trigger if any tile is clicked
    ''' When any play tile is clicked
    ''' </summary>
    Private Sub tiles_click(sender As Object, e As EventArgs) Handles t11.Click, t33.Click, t32.Click, t31.Click, t23.Click, t22.Click, t21.Click, t13.Click, t12.Click
        Play(DirectCast(sender, Button))
    End Sub


End Class