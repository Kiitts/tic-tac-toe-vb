<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.goToGameAreaTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'goToGameAreaTest
        '
        Me.goToGameAreaTest.Location = New System.Drawing.Point(137, 211)
        Me.goToGameAreaTest.Name = "goToGameAreaTest"
        Me.goToGameAreaTest.Size = New System.Drawing.Size(122, 23)
        Me.goToGameAreaTest.TabIndex = 0
        Me.goToGameAreaTest.Text = "Go To Game Area"
        Me.goToGameAreaTest.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 450)
        Me.Controls.Add(Me.goToGameAreaTest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents goToGameAreaTest As Button
End Class
