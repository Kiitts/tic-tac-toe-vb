<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameArea
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
        Me.tictactoePanel = New System.Windows.Forms.Panel()
        Me.t32 = New System.Windows.Forms.Button()
        Me.t22 = New System.Windows.Forms.Button()
        Me.t12 = New System.Windows.Forms.Button()
        Me.t23 = New System.Windows.Forms.Button()
        Me.t21 = New System.Windows.Forms.Button()
        Me.t33 = New System.Windows.Forms.Button()
        Me.t13 = New System.Windows.Forms.Button()
        Me.t31 = New System.Windows.Forms.Button()
        Me.t11 = New System.Windows.Forms.Button()
        Me.turnLabel = New System.Windows.Forms.Label()
        Me.player1ScoreLabel = New System.Windows.Forms.Label()
        Me.player2ScoreLabel = New System.Windows.Forms.Label()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.player1Score = New System.Windows.Forms.Label()
        Me.player2Score = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        Me.tictactoePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'tictactoePanel
        '
        Me.tictactoePanel.BackColor = System.Drawing.Color.Black
        Me.tictactoePanel.Controls.Add(Me.t32)
        Me.tictactoePanel.Controls.Add(Me.t22)
        Me.tictactoePanel.Controls.Add(Me.t12)
        Me.tictactoePanel.Controls.Add(Me.t23)
        Me.tictactoePanel.Controls.Add(Me.t21)
        Me.tictactoePanel.Controls.Add(Me.t33)
        Me.tictactoePanel.Controls.Add(Me.t13)
        Me.tictactoePanel.Controls.Add(Me.t31)
        Me.tictactoePanel.Controls.Add(Me.t11)
        Me.tictactoePanel.Location = New System.Drawing.Point(110, 80)
        Me.tictactoePanel.Name = "tictactoePanel"
        Me.tictactoePanel.Size = New System.Drawing.Size(296, 291)
        Me.tictactoePanel.TabIndex = 0
        '
        't32
        '
        Me.t32.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.t32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t32.Location = New System.Drawing.Point(104, 198)
        Me.t32.Name = "t32"
        Me.t32.Size = New System.Drawing.Size(90, 90)
        Me.t32.TabIndex = 8
        Me.t32.UseVisualStyleBackColor = False
        '
        't22
        '
        Me.t22.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.t22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t22.Location = New System.Drawing.Point(104, 99)
        Me.t22.Name = "t22"
        Me.t22.Size = New System.Drawing.Size(90, 90)
        Me.t22.TabIndex = 7
        Me.t22.UseVisualStyleBackColor = False
        '
        't12
        '
        Me.t12.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.t12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t12.Location = New System.Drawing.Point(104, 3)
        Me.t12.Name = "t12"
        Me.t12.Size = New System.Drawing.Size(90, 90)
        Me.t12.TabIndex = 6
        Me.t12.UseVisualStyleBackColor = False
        '
        't23
        '
        Me.t23.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.t23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t23.Location = New System.Drawing.Point(203, 99)
        Me.t23.Name = "t23"
        Me.t23.Size = New System.Drawing.Size(90, 90)
        Me.t23.TabIndex = 5
        Me.t23.UseVisualStyleBackColor = False
        '
        't21
        '
        Me.t21.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.t21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t21.Location = New System.Drawing.Point(3, 99)
        Me.t21.Name = "t21"
        Me.t21.Size = New System.Drawing.Size(90, 90)
        Me.t21.TabIndex = 4
        Me.t21.UseVisualStyleBackColor = False
        '
        't33
        '
        Me.t33.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.t33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t33.Location = New System.Drawing.Point(203, 198)
        Me.t33.Name = "t33"
        Me.t33.Size = New System.Drawing.Size(90, 90)
        Me.t33.TabIndex = 3
        Me.t33.UseVisualStyleBackColor = False
        '
        't13
        '
        Me.t13.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.t13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t13.Location = New System.Drawing.Point(203, 3)
        Me.t13.Name = "t13"
        Me.t13.Size = New System.Drawing.Size(90, 90)
        Me.t13.TabIndex = 2
        Me.t13.UseVisualStyleBackColor = False
        '
        't31
        '
        Me.t31.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.t31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t31.Location = New System.Drawing.Point(3, 198)
        Me.t31.Name = "t31"
        Me.t31.Size = New System.Drawing.Size(90, 90)
        Me.t31.TabIndex = 1
        Me.t31.UseVisualStyleBackColor = False
        '
        't11
        '
        Me.t11.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.t11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t11.ForeColor = System.Drawing.Color.Black
        Me.t11.Location = New System.Drawing.Point(3, 3)
        Me.t11.Name = "t11"
        Me.t11.Size = New System.Drawing.Size(90, 90)
        Me.t11.TabIndex = 0
        Me.t11.UseVisualStyleBackColor = False
        '
        'turnLabel
        '
        Me.turnLabel.AutoSize = True
        Me.turnLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.turnLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.turnLabel.Location = New System.Drawing.Point(164, 9)
        Me.turnLabel.Name = "turnLabel"
        Me.turnLabel.Size = New System.Drawing.Size(178, 18)
        Me.turnLabel.TabIndex = 1
        Me.turnLabel.Text = "PLAYER 1 [X] Turn"
        '
        'player1ScoreLabel
        '
        Me.player1ScoreLabel.AutoSize = True
        Me.player1ScoreLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.player1ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.player1ScoreLabel.Location = New System.Drawing.Point(115, 417)
        Me.player1ScoreLabel.Name = "player1ScoreLabel"
        Me.player1ScoreLabel.Size = New System.Drawing.Size(88, 18)
        Me.player1ScoreLabel.TabIndex = 2
        Me.player1ScoreLabel.Text = "PLAYER 1"
        '
        'player2ScoreLabel
        '
        Me.player2ScoreLabel.AutoSize = True
        Me.player2ScoreLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.player2ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.player2ScoreLabel.Location = New System.Drawing.Point(315, 417)
        Me.player2ScoreLabel.Name = "player2ScoreLabel"
        Me.player2ScoreLabel.Size = New System.Drawing.Size(88, 18)
        Me.player2ScoreLabel.TabIndex = 3
        Me.player2ScoreLabel.Text = "PLAYER 2"
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.scoreLabel.Location = New System.Drawing.Point(234, 391)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(58, 18)
        Me.scoreLabel.TabIndex = 4
        Me.scoreLabel.Text = "SCORE"
        '
        'player1Score
        '
        Me.player1Score.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.player1Score.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.player1Score.Location = New System.Drawing.Point(115, 454)
        Me.player1Score.Name = "player1Score"
        Me.player1Score.Size = New System.Drawing.Size(88, 18)
        Me.player1Score.TabIndex = 5
        Me.player1Score.Text = "0"
        '
        'player2Score
        '
        Me.player2Score.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.player2Score.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.player2Score.Location = New System.Drawing.Point(315, 454)
        Me.player2Score.Name = "player2Score"
        Me.player2Score.Size = New System.Drawing.Size(88, 18)
        Me.player2Score.TabIndex = 6
        Me.player2Score.Text = "0"
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.backButton.Location = New System.Drawing.Point(13, 9)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(75, 23)
        Me.backButton.TabIndex = 7
        Me.backButton.Text = "Go Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'GameArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 508)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.player2Score)
        Me.Controls.Add(Me.player1Score)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.player2ScoreLabel)
        Me.Controls.Add(Me.player1ScoreLabel)
        Me.Controls.Add(Me.turnLabel)
        Me.Controls.Add(Me.tictactoePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(520, 508)
        Me.MinimumSize = New System.Drawing.Size(520, 508)
        Me.Name = "GameArea"
        Me.Text = "GameArea"
        Me.tictactoePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tictactoePanel As Panel
    Friend WithEvents t32 As Button
    Friend WithEvents t22 As Button
    Friend WithEvents t12 As Button
    Friend WithEvents t23 As Button
    Friend WithEvents t21 As Button
    Friend WithEvents t33 As Button
    Friend WithEvents t13 As Button
    Friend WithEvents t31 As Button
    Friend WithEvents t11 As Button
    Friend WithEvents turnLabel As Label
    Friend WithEvents player1ScoreLabel As Label
    Friend WithEvents player2ScoreLabel As Label
    Friend WithEvents scoreLabel As Label
    Friend WithEvents player1Score As Label
    Friend WithEvents player2Score As Label
    Friend WithEvents backButton As Button
End Class
