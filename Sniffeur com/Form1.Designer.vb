<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox_FenetrePrincipale = New System.Windows.Forms.TextBox()
        Me.ComboBox_PortCOM = New System.Windows.Forms.ComboBox()
        Me.Label_PortCOM = New System.Windows.Forms.Label()
        Me.Label_Baud = New System.Windows.Forms.Label()
        Me.ComboBox_Baud = New System.Windows.Forms.ComboBox()
        Me.Label_NombreBitsDonnée = New System.Windows.Forms.Label()
        Me.ComboBox_NombreBitsDonnee = New System.Windows.Forms.ComboBox()
        Me.Label_NombreBitsStop = New System.Windows.Forms.Label()
        Me.ComboBox_NombreBitsStop = New System.Windows.Forms.ComboBox()
        Me.Label_Parite = New System.Windows.Forms.Label()
        Me.ComboBox_Parite = New System.Windows.Forms.ComboBox()
        Me.Button_OuvreFermeCOM = New System.Windows.Forms.Button()
        Me.Button_EnvoieCOM = New System.Windows.Forms.Button()
        Me.TextBox_EnvoieCOM = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox_FenetrePrincipale
        '
        Me.TextBox_FenetrePrincipale.Location = New System.Drawing.Point(403, 12)
        Me.TextBox_FenetrePrincipale.Multiline = True
        Me.TextBox_FenetrePrincipale.Name = "TextBox_FenetrePrincipale"
        Me.TextBox_FenetrePrincipale.Size = New System.Drawing.Size(776, 476)
        Me.TextBox_FenetrePrincipale.TabIndex = 0
        '
        'ComboBox_PortCOM
        '
        Me.ComboBox_PortCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_PortCOM.FormattingEnabled = True
        Me.ComboBox_PortCOM.Location = New System.Drawing.Point(96, 26)
        Me.ComboBox_PortCOM.Name = "ComboBox_PortCOM"
        Me.ComboBox_PortCOM.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_PortCOM.TabIndex = 1
        '
        'Label_PortCOM
        '
        Me.Label_PortCOM.AutoSize = True
        Me.Label_PortCOM.Location = New System.Drawing.Point(12, 29)
        Me.Label_PortCOM.Name = "Label_PortCOM"
        Me.Label_PortCOM.Size = New System.Drawing.Size(55, 13)
        Me.Label_PortCOM.TabIndex = 2
        Me.Label_PortCOM.Text = "N° de port"
        '
        'Label_Baud
        '
        Me.Label_Baud.AutoSize = True
        Me.Label_Baud.Location = New System.Drawing.Point(12, 56)
        Me.Label_Baud.Name = "Label_Baud"
        Me.Label_Baud.Size = New System.Drawing.Size(32, 13)
        Me.Label_Baud.TabIndex = 4
        Me.Label_Baud.Text = "Baud"
        '
        'ComboBox_Baud
        '
        Me.ComboBox_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Baud.FormattingEnabled = True
        Me.ComboBox_Baud.Location = New System.Drawing.Point(96, 53)
        Me.ComboBox_Baud.Name = "ComboBox_Baud"
        Me.ComboBox_Baud.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Baud.TabIndex = 3
        '
        'Label_NombreBitsDonnée
        '
        Me.Label_NombreBitsDonnée.AutoSize = True
        Me.Label_NombreBitsDonnée.Location = New System.Drawing.Point(12, 110)
        Me.Label_NombreBitsDonnée.Name = "Label_NombreBitsDonnée"
        Me.Label_NombreBitsDonnée.Size = New System.Drawing.Size(78, 13)
        Me.Label_NombreBitsDonnée.TabIndex = 6
        Me.Label_NombreBitsDonnée.Text = "Bits de donnée"
        '
        'ComboBox_NombreBitsDonnee
        '
        Me.ComboBox_NombreBitsDonnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_NombreBitsDonnee.FormattingEnabled = True
        Me.ComboBox_NombreBitsDonnee.Location = New System.Drawing.Point(96, 107)
        Me.ComboBox_NombreBitsDonnee.Name = "ComboBox_NombreBitsDonnee"
        Me.ComboBox_NombreBitsDonnee.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_NombreBitsDonnee.TabIndex = 5
        '
        'Label_NombreBitsStop
        '
        Me.Label_NombreBitsStop.AutoSize = True
        Me.Label_NombreBitsStop.Location = New System.Drawing.Point(12, 137)
        Me.Label_NombreBitsStop.Name = "Label_NombreBitsStop"
        Me.Label_NombreBitsStop.Size = New System.Drawing.Size(62, 13)
        Me.Label_NombreBitsStop.TabIndex = 8
        Me.Label_NombreBitsStop.Text = "Bits de stop"
        '
        'ComboBox_NombreBitsStop
        '
        Me.ComboBox_NombreBitsStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_NombreBitsStop.FormattingEnabled = True
        Me.ComboBox_NombreBitsStop.Location = New System.Drawing.Point(96, 134)
        Me.ComboBox_NombreBitsStop.Name = "ComboBox_NombreBitsStop"
        Me.ComboBox_NombreBitsStop.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_NombreBitsStop.TabIndex = 7
        '
        'Label_Parite
        '
        Me.Label_Parite.AutoSize = True
        Me.Label_Parite.Location = New System.Drawing.Point(12, 83)
        Me.Label_Parite.Name = "Label_Parite"
        Me.Label_Parite.Size = New System.Drawing.Size(68, 13)
        Me.Label_Parite.TabIndex = 10
        Me.Label_Parite.Text = "Bits de parité"
        '
        'ComboBox_Parite
        '
        Me.ComboBox_Parite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Parite.FormattingEnabled = True
        Me.ComboBox_Parite.Location = New System.Drawing.Point(96, 80)
        Me.ComboBox_Parite.Name = "ComboBox_Parite"
        Me.ComboBox_Parite.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Parite.TabIndex = 9
        '
        'Button_OuvreFermeCOM
        '
        Me.Button_OuvreFermeCOM.Location = New System.Drawing.Point(96, 179)
        Me.Button_OuvreFermeCOM.Name = "Button_OuvreFermeCOM"
        Me.Button_OuvreFermeCOM.Size = New System.Drawing.Size(121, 33)
        Me.Button_OuvreFermeCOM.TabIndex = 11
        Me.Button_OuvreFermeCOM.Text = "Ouvrir"
        Me.Button_OuvreFermeCOM.UseVisualStyleBackColor = True
        '
        'Button_EnvoieCOM
        '
        Me.Button_EnvoieCOM.Location = New System.Drawing.Point(217, 268)
        Me.Button_EnvoieCOM.Name = "Button_EnvoieCOM"
        Me.Button_EnvoieCOM.Size = New System.Drawing.Size(121, 33)
        Me.Button_EnvoieCOM.TabIndex = 12
        Me.Button_EnvoieCOM.Text = "Envoie"
        Me.Button_EnvoieCOM.UseVisualStyleBackColor = True
        '
        'TextBox_EnvoieCOM
        '
        Me.TextBox_EnvoieCOM.Location = New System.Drawing.Point(82, 275)
        Me.TextBox_EnvoieCOM.Name = "TextBox_EnvoieCOM"
        Me.TextBox_EnvoieCOM.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_EnvoieCOM.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 500)
        Me.Controls.Add(Me.TextBox_EnvoieCOM)
        Me.Controls.Add(Me.Button_EnvoieCOM)
        Me.Controls.Add(Me.Button_OuvreFermeCOM)
        Me.Controls.Add(Me.Label_Parite)
        Me.Controls.Add(Me.ComboBox_Parite)
        Me.Controls.Add(Me.Label_NombreBitsStop)
        Me.Controls.Add(Me.ComboBox_NombreBitsStop)
        Me.Controls.Add(Me.Label_NombreBitsDonnée)
        Me.Controls.Add(Me.ComboBox_NombreBitsDonnee)
        Me.Controls.Add(Me.Label_Baud)
        Me.Controls.Add(Me.ComboBox_Baud)
        Me.Controls.Add(Me.Label_PortCOM)
        Me.Controls.Add(Me.ComboBox_PortCOM)
        Me.Controls.Add(Me.TextBox_FenetrePrincipale)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_FenetrePrincipale As TextBox
    Friend WithEvents ComboBox_PortCOM As ComboBox
    Friend WithEvents Label_PortCOM As Label
    Friend WithEvents Label_Baud As Label
    Friend WithEvents ComboBox_Baud As ComboBox
    Friend WithEvents Label_NombreBitsDonnée As Label
    Friend WithEvents ComboBox_NombreBitsDonnee As ComboBox
    Friend WithEvents Label_NombreBitsStop As Label
    Friend WithEvents ComboBox_NombreBitsStop As ComboBox
    Friend WithEvents Label_Parite As Label
    Friend WithEvents ComboBox_Parite As ComboBox
    Friend WithEvents Button_OuvreFermeCOM As Button
    Friend WithEvents Button_EnvoieCOM As Button
    Friend WithEvents TextBox_EnvoieCOM As TextBox
End Class
