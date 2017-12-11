<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WonGame
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WordGuessed = New System.Windows.Forms.Label()
        Me.PlayAgain = New System.Windows.Forms.Button()
        Me.QuitGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Consolas", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WINNER!"
        '
        'WordGuessed
        '
        Me.WordGuessed.AutoSize = True
        Me.WordGuessed.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordGuessed.ForeColor = System.Drawing.Color.Lime
        Me.WordGuessed.Location = New System.Drawing.Point(54, 84)
        Me.WordGuessed.Name = "WordGuessed"
        Me.WordGuessed.Size = New System.Drawing.Size(140, 22)
        Me.WordGuessed.TabIndex = 1
        Me.WordGuessed.Text = "Word Guessed:"
        '
        'PlayAgain
        '
        Me.PlayAgain.BackColor = System.Drawing.Color.White
        Me.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayAgain.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayAgain.Location = New System.Drawing.Point(12, 128)
        Me.PlayAgain.Name = "PlayAgain"
        Me.PlayAgain.Size = New System.Drawing.Size(131, 44)
        Me.PlayAgain.TabIndex = 2
        Me.PlayAgain.Text = "Play Again"
        Me.PlayAgain.UseVisualStyleBackColor = False
        '
        'QuitGame
        '
        Me.QuitGame.BackColor = System.Drawing.Color.White
        Me.QuitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitGame.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitGame.Location = New System.Drawing.Point(217, 128)
        Me.QuitGame.Name = "QuitGame"
        Me.QuitGame.Size = New System.Drawing.Size(131, 44)
        Me.QuitGame.TabIndex = 3
        Me.QuitGame.Text = "Quit Game"
        Me.QuitGame.UseVisualStyleBackColor = False
        '
        'WonGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(360, 184)
        Me.ControlBox = False
        Me.Controls.Add(Me.QuitGame)
        Me.Controls.Add(Me.PlayAgain)
        Me.Controls.Add(Me.WordGuessed)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WonGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WonGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents WordGuessed As Label
    Friend WithEvents PlayAgain As Button
    Friend WithEvents QuitGame As Button
End Class
