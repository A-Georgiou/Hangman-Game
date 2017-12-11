<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LostGame
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
        Me.TryAgain = New System.Windows.Forms.Button()
        Me.QuitGame = New System.Windows.Forms.Button()
        Me.WordWas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GAME OVER"
        '
        'TryAgain
        '
        Me.TryAgain.BackColor = System.Drawing.Color.White
        Me.TryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TryAgain.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TryAgain.Location = New System.Drawing.Point(12, 131)
        Me.TryAgain.Name = "TryAgain"
        Me.TryAgain.Size = New System.Drawing.Size(133, 43)
        Me.TryAgain.TabIndex = 1
        Me.TryAgain.Text = "Try Again"
        Me.TryAgain.UseVisualStyleBackColor = False
        '
        'QuitGame
        '
        Me.QuitGame.BackColor = System.Drawing.Color.White
        Me.QuitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitGame.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitGame.Location = New System.Drawing.Point(229, 131)
        Me.QuitGame.Name = "QuitGame"
        Me.QuitGame.Size = New System.Drawing.Size(130, 43)
        Me.QuitGame.TabIndex = 2
        Me.QuitGame.Text = "Quit Game"
        Me.QuitGame.UseVisualStyleBackColor = False
        '
        'WordWas
        '
        Me.WordWas.AutoSize = True
        Me.WordWas.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordWas.ForeColor = System.Drawing.Color.Red
        Me.WordWas.Location = New System.Drawing.Point(88, 84)
        Me.WordWas.Name = "WordWas"
        Me.WordWas.Size = New System.Drawing.Size(100, 22)
        Me.WordWas.TabIndex = 3
        Me.WordWas.Text = "Word Was:"
        '
        'LostGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(372, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.WordWas)
        Me.Controls.Add(Me.QuitGame)
        Me.Controls.Add(Me.TryAgain)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LostGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Over"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TryAgain As Button
    Friend WithEvents QuitGame As Button
    Friend WithEvents WordWas As Label
End Class
