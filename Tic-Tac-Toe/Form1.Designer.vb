<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.titlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'titlePanel
        '
        Me.titlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.titlePanel.Controls.Add(Me.closeButton)
        Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlePanel.Location = New System.Drawing.Point(0, 0)
        Me.titlePanel.Name = "titlePanel"
        Me.titlePanel.Size = New System.Drawing.Size(438, 34)
        Me.titlePanel.TabIndex = 0
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.closeButton.ForeColor = System.Drawing.Color.Red
        Me.closeButton.Location = New System.Drawing.Point(403, 1)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(26, 30)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "x"
        Me.closeButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'mainPanel
        '
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 34)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(438, 469)
        Me.mainPanel.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 503)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.titlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(438, 503)
        Me.MinimumSize = New System.Drawing.Size(438, 503)
        Me.Name = "Form1"
        Me.Text = "Tic-Tac-Toe"
        Me.titlePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents titlePanel As Panel
    Friend WithEvents closeButton As Button
    Friend WithEvents mainPanel As Panel
End Class
