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
        TxtSaludar = New Button()
        TxtNombre = New TextBox()
        sasdsd = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' TxtSaludar
        ' 
        TxtSaludar.Location = New Point(590, 212)
        TxtSaludar.Name = "TxtSaludar"
        TxtSaludar.Size = New Size(75, 23)
        TxtSaludar.TabIndex = 0
        TxtSaludar.Text = "Enviar"
        TxtSaludar.UseVisualStyleBackColor = True
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(46, 212)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(524, 23)
        TxtNombre.TabIndex = 1
        ' 
        ' sasdsd
        ' 
        sasdsd.AutoSize = True
        sasdsd.ForeColor = Color.Cornsilk
        sasdsd.Location = New Point(251, 314)
        sasdsd.Name = "sasdsd"
        sasdsd.Size = New Size(0, 15)
        sasdsd.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Firebrick
        Label1.Location = New Point(257, 301)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(sasdsd)
        Controls.Add(TxtNombre)
        Controls.Add(TxtSaludar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtSaludar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents sasdsd As Label
    Friend WithEvents Label1 As Label
End Class
