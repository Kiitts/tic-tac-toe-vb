<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameArea
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.backButtonTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'backButtonTest
        '
        Me.backButtonTest.Location = New System.Drawing.Point(123, 195)
        Me.backButtonTest.Name = "backButtonTest"
        Me.backButtonTest.Size = New System.Drawing.Size(136, 23)
        Me.backButtonTest.TabIndex = 0
        Me.backButtonTest.Text = "Go back to main menu"
        Me.backButtonTest.UseVisualStyleBackColor = True
        '
        'GameArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 450)
        Me.Controls.Add(Me.backButtonTest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GameArea"
        Me.Text = "GameArea"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents backButtonTest As Button
End Class
