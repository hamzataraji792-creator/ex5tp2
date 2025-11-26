<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        n = New TextBox()
        Button1 = New Button()
        aff = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 28)
        Label1.TabIndex = 0
        Label1.Text = "nombre:"
        ' 
        ' n
        ' 
        n.Location = New Point(108, 85)
        n.Name = "n"
        n.Size = New Size(125, 27)
        n.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(51, 199)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 48)
        Button1.TabIndex = 2
        Button1.Text = "carré"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' aff
        ' 
        aff.AutoSize = True
        aff.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        aff.Location = New Point(61, 313)
        aff.Name = "aff"
        aff.Size = New Size(85, 28)
        aff.TabIndex = 3
        aff.Text = "resultat"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(280, 450)
        Controls.Add(aff)
        Controls.Add(Button1)
        Controls.Add(n)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents n As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents aff As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
