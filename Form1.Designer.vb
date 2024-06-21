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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button1.Font = New Font("Segoe UI", 14F)
        Button1.Location = New Point(120, 115)
        Button1.Name = "Button1"
        Button1.Size = New Size(453, 63)
        Button1.TabIndex = 0
        Button1.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button2.Font = New Font("Segoe UI", 14F)
        Button2.Location = New Point(120, 202)
        Button2.Name = "Button2"
        Button2.Size = New Size(453, 63)
        Button2.TabIndex = 1
        Button2.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(673, 41)
        Label1.TabIndex = 2
        Label1.Text = "Naveen Sharma, Slidely AI Task 2 - Main Form"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(697, 317)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        KeyPreview = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label

End Class
