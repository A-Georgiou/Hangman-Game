<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.outputString = New System.Windows.Forms.Label()
        Me.selectLetter = New System.Windows.Forms.ComboBox()
        Me.submitVal = New System.Windows.Forms.Button()
        Me.attemptText = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.textbox = New System.Windows.Forms.TextBox()
        Me.usedLetters = New System.Windows.Forms.TextBox()
        Me.sharkPicture = New System.Windows.Forms.PictureBox()
        Me.manPicture = New System.Windows.Forms.PictureBox()
        CType(Me.sharkPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.manPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'outputString
        '
        Me.outputString.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.outputString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outputString.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputString.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.outputString.Location = New System.Drawing.Point(12, 159)
        Me.outputString.Name = "outputString"
        Me.outputString.Size = New System.Drawing.Size(505, 45)
        Me.outputString.TabIndex = 0
        Me.outputString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selectLetter
        '
        Me.selectLetter.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.selectLetter.DropDownHeight = 250
        Me.selectLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectLetter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.selectLetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectLetter.FormattingEnabled = True
        Me.selectLetter.IntegralHeight = False
        Me.selectLetter.ItemHeight = 20
        Me.selectLetter.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.selectLetter.Location = New System.Drawing.Point(295, 225)
        Me.selectLetter.Name = "selectLetter"
        Me.selectLetter.Size = New System.Drawing.Size(50, 28)
        Me.selectLetter.TabIndex = 1
        '
        'submitVal
        '
        Me.submitVal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitVal.Location = New System.Drawing.Point(351, 225)
        Me.submitVal.Name = "submitVal"
        Me.submitVal.Size = New System.Drawing.Size(166, 28)
        Me.submitVal.TabIndex = 2
        Me.submitVal.Text = "Submit Value"
        Me.submitVal.UseVisualStyleBackColor = True
        '
        'attemptText
        '
        Me.attemptText.AutoSize = True
        Me.attemptText.BackColor = System.Drawing.Color.LightSkyBlue
        Me.attemptText.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attemptText.Location = New System.Drawing.Point(322, 9)
        Me.attemptText.Name = "attemptText"
        Me.attemptText.Size = New System.Drawing.Size(195, 32)
        Me.attemptText.TabIndex = 3
        Me.attemptText.Text = "Attempts: 10"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(-3, -1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(538, 157)
        Me.TextBox1.TabIndex = 5
        '
        'textbox
        '
        Me.textbox.BackColor = System.Drawing.Color.SteelBlue
        Me.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textbox.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox.Location = New System.Drawing.Point(12, 211)
        Me.textbox.Multiline = True
        Me.textbox.Name = "textbox"
        Me.textbox.Size = New System.Drawing.Size(236, 20)
        Me.textbox.TabIndex = 7
        Me.textbox.Tag = ""
        Me.textbox.Text = "Used Letters:"
        '
        'usedLetters
        '
        Me.usedLetters.Location = New System.Drawing.Point(12, 225)
        Me.usedLetters.Multiline = True
        Me.usedLetters.Name = "usedLetters"
        Me.usedLetters.ReadOnly = True
        Me.usedLetters.Size = New System.Drawing.Size(277, 28)
        Me.usedLetters.TabIndex = 8
        '
        'sharkPicture
        '
        Me.sharkPicture.BackColor = System.Drawing.Color.LightSkyBlue
        Me.sharkPicture.Image = Global.WindowsApp5.My.Resources.Resources.ezgif_4_77d14b9211
        Me.sharkPicture.Location = New System.Drawing.Point(408, -1)
        Me.sharkPicture.Name = "sharkPicture"
        Me.sharkPicture.Size = New System.Drawing.Size(254, 144)
        Me.sharkPicture.TabIndex = 4
        Me.sharkPicture.TabStop = False
        '
        'manPicture
        '
        Me.manPicture.BackColor = System.Drawing.Color.LightSkyBlue
        Me.manPicture.Image = Global.WindowsApp5.My.Resources.Resources.drown_clipart_19
        Me.manPicture.Location = New System.Drawing.Point(12, 24)
        Me.manPicture.Name = "manPicture"
        Me.manPicture.Size = New System.Drawing.Size(142, 131)
        Me.manPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.manPicture.TabIndex = 6
        Me.manPicture.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(529, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.usedLetters)
        Me.Controls.Add(Me.textbox)
        Me.Controls.Add(Me.attemptText)
        Me.Controls.Add(Me.sharkPicture)
        Me.Controls.Add(Me.manPicture)
        Me.Controls.Add(Me.submitVal)
        Me.Controls.Add(Me.selectLetter)
        Me.Controls.Add(Me.outputString)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hangman"
        CType(Me.sharkPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.manPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents outputString As Label
    Friend WithEvents selectLetter As ComboBox
    Friend WithEvents submitVal As Button
    Friend WithEvents attemptText As Label
    Friend WithEvents sharkPicture As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents manPicture As PictureBox
    Friend WithEvents textbox As TextBox
    Friend WithEvents usedLetters As TextBox
End Class
