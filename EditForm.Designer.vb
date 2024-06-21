<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        BtnSave = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(177, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 31)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(177, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 31)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(177, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 31)
        Label3.TabIndex = 2
        Label3.Text = "PhoneNo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(177, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(200, 31)
        Label4.TabIndex = 3
        Label4.Text = "Github Repo Link"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(252, 81)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(414, 34)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F)
        TextBox2.Location = New Point(251, 131)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(415, 34)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F)
        TextBox3.Location = New Point(293, 174)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(373, 34)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 12F)
        TextBox4.Location = New Point(379, 221)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(287, 34)
        TextBox4.TabIndex = 7
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BtnSave.Font = New Font("Segoe UI", 14F)
        BtnSave.Location = New Point(293, 342)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(276, 53)
        BtnSave.TabIndex = 8
        BtnSave.Text = "SUBMIT (CTRL + S)"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(44, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(744, 41)
        Label5.TabIndex = 9
        Label5.Text = "Naveen Sharma, Slidely AI Task 2 - Edit Submission"
        ' 
        ' EditForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(BtnSave)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "EditForm"
        Text = "EditForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label5 As Label
End Class
