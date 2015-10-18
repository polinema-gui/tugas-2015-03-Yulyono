<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.hasilBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.barisString = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pola = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(368, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 19)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'hasilBox
        '
        Me.hasilBox.Location = New System.Drawing.Point(17, 112)
        Me.hasilBox.Multiline = True
        Me.hasilBox.Name = "hasilBox"
        Me.hasilBox.Size = New System.Drawing.Size(432, 275)
        Me.hasilBox.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Baris"
        '
        'barisString
        '
        Me.barisString.Location = New System.Drawing.Point(59, 75)
        Me.barisString.Name = "barisString"
        Me.barisString.Size = New System.Drawing.Size(288, 20)
        Me.barisString.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Pola"
        '
        'Pola
        '
        Me.Pola.FormattingEnabled = True
        Me.Pola.Items.AddRange(New Object() {"Piramyd", "Hollow Piramyd", "Inverted Piramyd", "Hollow Inverted Piramyd"})
        Me.Pola.Location = New System.Drawing.Point(59, 37)
        Me.Pola.Name = "Pola"
        Me.Pola.Size = New System.Drawing.Size(391, 21)
        Me.Pola.TabIndex = 12
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.hasilBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.barisString)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents hasilBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents barisString As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pola As System.Windows.Forms.ComboBox
End Class
