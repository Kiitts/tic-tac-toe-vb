Imports Tic_Tac_Toe.Module1 ' module for changing main panel forms


Public Class GameArea
    Public player1Turn As Boolean = True
    Public rnd = New Random()
    Public buttons() As Button
    Public player1Combinations As New List(Of Short)()
    Public player2Combinations As New List(Of Short)()
    Public winningCombination(,) As Short = {{11, 12, 13}, {21, 22, 23}, {31, 32, 33},
        {11, 21, 31}, {12, 22, 32}, {13, 23, 33}, {11, 22, 33}, {13, 22, 31}}

    ''' <summary>
    ''' Load the buttons in the array when GameArea form loads
    ''' </summary>
    Private Sub GameArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttons = {t11, t12, t13, t21, t22, t23, t31, t32, t33}
    End Sub

    ''' <summary>
    ''' Clear the images on tiles and clear the combinations made by the players
    ''' and reset score of players if with score is true
    ''' <param name="withScore">if this is true score will also reset</param>
    ''' </summary>
    Public Sub Reset(Optional withScore As Boolean = True)
        turnLabel.Text = "PLAYER 1 [X] Turn"
        For i = 0 To 8
            If buttons(i).Image IsNot Nothing Then
                buttons(i).Image = Nothing
            End If
        Next
        player1Turn = True
        player1Combinations.Clear()
        player2Combinations.Clear()
        If withScore Then
            player1Score.Text = 0
            player2Score.Text = 0
        End If
    End Sub
    ''' <summary>
    ''' changes main panel form to MainMenu form
    ''' </summary>
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Reset()
        Module1.loadForm(MainMenu, Form1)
    End Sub

    ''' <summary>
    ''' Make a play on a tile, or put a x and o in tile depending on whos
    ''' turn it is, and store the row and column as integer as their combinations
    ''' ex of row and column as short integer 
    ''' is row 1 column 1 is 11; row2column3 is 23
    ''' changes the text on the turn label
    ''' </summary>
    ''' <param name="but">button that is clicked</param>
    ''' <returns>Return true or false if the game continues or not</returns>
    Public Function Play(but As Button) As Boolean
        ''' Check if btn has already an image
        If but.Image IsNot Nothing Then
            If Not MainMenu.AiGame And player1Turn Then
                MessageBox.Show("The tile is used already.")
            End If
            Return False
        Else
            ''' Check whos turn
            If player1Turn Then
                but.Image = My.Resources.xtile_gamearea1
                ' this will remove the t in the name of button the name of button typicall is
                ' t[row][column] so if i press t33, it will save to their combination as 33
                player1Combinations.Add(CShort(but.Name.Replace("t", "")))
                If MainMenu.AiGame Then
                    turnLabel.Text = "AI TURN [O]"
                Else
                    turnLabel.Text = "PLAYER 2 [O] Turn"
                End If
            Else
                but.Image = My.Resources.otile_gamearea1
                ' this will remove the t in the name of button the name of button typicall is
                ' t[row][column] so if i press t33, it will save to their combination as 33
                player2Combinations.Add(CShort(but.Name.Replace("t", "")))
                turnLabel.Text = "PLAYER 1 [X] Turn"
            End If
        End If
        Return True
    End Function

    ''' <summary>
    ''' will check if the tiles is out and declare it's a draw then reset the game
    ''' </summary>
    ''' <returns>Return true or false if the game continues or not</returns>
    Public Function CheckForDraw() As Boolean
        Dim draw As Boolean = True
        For Each but As Button In buttons
            If but.Image Is Nothing Then
                draw = False
                Exit For
            End If
        Next
        If draw Then
            MessageBox.Show("Draw!")
            Reset(False)
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' check if someone has won
    ''' </summary>
    ''' <param name="player1Turn">if the move was from the player 1 or not</param>
    ''' <returns>Return true or false if there was a winning combination inside
    ''' player1Combinations and player2Combinations</returns>
    Public Function WinCheck(player1Turn) As Boolean
        Dim result As Boolean = True
        If player1Turn Then
            For i = 0 To 7
                For j = 0 To 2
                    If Not player1Combinations.Contains(winningCombination(i, j)) Then
                        result = False
                        Exit For
                    End If
                Next
                If result Then
                    Return result
                Else
                    result = True
                End If
            Next
        Else
            For i = 0 To 7
                For j = 0 To 2
                    If Not player2Combinations.Contains(winningCombination(i, j)) Then
                        result = False
                        Exit For
                    End If
                Next
                If result Then
                    Return result
                Else
                    result = True
                End If
            Next
        End If
        Return False
    End Function

    ''' <summary>
    ''' Congratulate winner through message box then increment the winner score
    ''' </summary>
    ''' <param name="player1Win">check if the player1 wins</param>
    Public Sub Winner(player1Win)
        If player1Win Then
            MessageBox.Show("Player 1 Wins!")
            player1Score.Text = (CShort(player1Score.Text) + 1).ToString()
            Reset(False)
        Else
            If MainMenu.AiGame Then
                MessageBox.Show("AI Wins!")
            Else
                MessageBox.Show("Player 2 Wins!")
            End If
            player2Score.Text = (CShort(player2Score.Text) + 1).ToString()
            Reset(False)
        End If
    End Sub

    ''' <summary>
    ''' enabling all buttons
    ''' ai will move and select random button for its move
    ''' </summary>
    Public Sub AiMove()
        For Each but In buttons
            but.Enabled = True
        Next
        buttons(rnd.Next(0, buttons.Count)).PerformClick()
    End Sub

    ''' <summary>
    ''' This will trigger if any tile is clicked
    ''' When any play tile is clicked
    ''' </summary>
    Private Sub tiles_click(sender As Object, e As EventArgs) Handles t11.Click, t33.Click, t32.Click, t31.Click, t23.Click, t22.Click, t21.Click, t13.Click, t12.Click
        Dim playContinue As Boolean = Play(DirectCast(sender, Button))
        If playContinue Then
            Dim someoneWin As Boolean = WinCheck(player1Turn)
            If someoneWin Then
                Winner(player1Turn)
            Else
                playContinue = CheckForDraw()
                If playContinue Then
                    player1Turn = Not player1Turn
                End If
            End If
        End If
        ''' starting the timer indicating that the ai is thinking
        ''' and disabling all buttons
        If MainMenu.AiGame And (Not player1Turn) Then
            For Each but In buttons
                but.Enabled = False
            Next
            aiTimer.Start()
        End If
    End Sub

    ''' <summary>
    ''' when the timer tick indicating the ai is done thinking it will now move
    ''' </summary>
    Private Sub aiTimer_Tick(sender As Object, e As EventArgs) Handles aiTimer.Tick
        aiTimer.Stop()
        AiMove()
    End Sub
End Class