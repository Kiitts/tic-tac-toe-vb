''' <summary>
''' This module1 is created since this is needed for my application to change panel forms
''' </summary>
Module Module1
    ''' <summary>
    ''' load the form from the main panel of the form where main panel is located
    ''' </summary>
    ''' <param name="Form">what form we should show from the panel</param>
    ''' <param name="originalForm">what form that has mainPanel</param>
    Public Sub loadForm(Form As Form, originalForm As Form1)
        If (originalForm.mainPanel.Controls.Count > 0) Then
            originalForm.mainPanel.Controls.RemoveAt(0)
        End If
        Dim f As Form = Form
        f.TopLevel = False
        f.Dock = DockStyle.Fill
        originalForm.mainPanel.Controls.Add(f)
        originalForm.mainPanel.Tag = f
        f.Show()
    End Sub
End Module
