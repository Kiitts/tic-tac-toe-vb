<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.titlePicture = New System.Windows.Forms.PictureBox()
        Me.playButton = New System.Windows.Forms.Button()
        Me.computerPlay = New System.Windows.Forms.Button()
        CType(Me.titlePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titlePicture
        '
        Me.titlePicture.BackColor = System.Drawing.Color.Transparent
        Me.titlePicture.Image = Global.Tic_Tac_Toe.My.Resources.Resources.gametitle_mainmenu_export
        Me.titlePicture.Location = New System.Drawing.Point(59, 12)
        Me.titlePicture.Name = "titlePicture"
        Me.titlePicture.Size = New System.Drawing.Size(400, 200)
        Me.titlePicture.TabIndex = 0
        Me.titlePicture.TabStop = False
        '
        'playButton
        '
        Me.playButton.BackColor = System.Drawing.Color.Transparent
        Me.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.playButton.Image = Global.Tic_Tac_Toe.My.Resources.Resources.playbutton_mainmenu1
        Me.playButton.Location = New System.Drawing.Point(59, 254)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(400, 68)
        Me.playButton.TabIndex = 1
        Me.playButton.UseVisualStyleBackColor = False
        '
        'computerPlay
        '
        Me.computerPlay.BackColor = System.Drawing.Color.Transparent
        Me.computerPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.computerPlay.Image = Global.Tic_Tac_Toe.My.Resources.Resources.aiplay_mainmenu_export
        Me.computerPlay.Location = New System.Drawing.Point(59, 356)
        Me.computerPlay.Name = "computerPlay"
        Me.computerPlay.Size = New System.Drawing.Size(400, 68)
        Me.computerPlay.TabIndex = 2
        Me.computerPlay.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 508)
        Me.Controls.Add(Me.computerPlay)
        Me.Controls.Add(Me.playButton)
        Me.Controls.Add(Me.titlePicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(520, 508)
        Me.MinimumSize = New System.Drawing.Size(520, 508)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        CType(Me.titlePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents titlePicture As PictureBox
    Friend WithEvents playButton As Button
    Friend WithEvents computerPlay As Button
End Class
