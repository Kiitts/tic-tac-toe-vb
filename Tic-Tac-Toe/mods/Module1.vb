Module Module1
    ''' <summary>
    ''' load the form from the main panel of the form form
    ''' </summary>
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
