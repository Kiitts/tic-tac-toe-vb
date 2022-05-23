Public Class Form1
    Dim Pos As Point ''' to be used for drag and moving of form
    ''' <summary>
    ''' to make form to be dragged and move when using the top panel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub titlePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles titlePanel.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    ''' <summary>
    ''' to close all open forms when clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub
End Class
