<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateForm
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
        components = New ComponentModel.Container()
        LblTitle = New Label()
        LblName = New Label()
        LblEmail = New Label()
        LblPhone = New Label()
        LblGithub = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        LblStopwatch = New Label()
        BtnStopwatch = New Button()
        BtnSubmit = New Button()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        SuspendLayout()
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblTitle.Location = New Point(12, 18)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(794, 41)
        LblTitle.TabIndex = 0
        LblTitle.Text = "Naveen Sharma, Slidely AI Task 2 - Create Submissions"
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        LblName.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblName.Location = New Point(119, 76)
        LblName.Name = "LblName"
        LblName.Size = New Size(77, 31)
        LblName.TabIndex = 1
        LblName.Text = "Name"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        LblEmail.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblEmail.Location = New Point(119, 133)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(73, 31)
        LblEmail.TabIndex = 2
        LblEmail.Text = "Email"
        ' 
        ' LblPhone
        ' 
        LblPhone.AutoSize = True
        LblPhone.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        LblPhone.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPhone.Location = New Point(119, 188)
        LblPhone.Name = "LblPhone"
        LblPhone.Size = New Size(120, 31)
        LblPhone.TabIndex = 3
        LblPhone.Text = "Phone No"
        ' 
        ' LblGithub
        ' 
        LblGithub.AutoSize = True
        LblGithub.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        LblGithub.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblGithub.Location = New Point(119, 245)
        LblGithub.Name = "LblGithub"
        LblGithub.Size = New Size(200, 31)
        LblGithub.TabIndex = 4
        LblGithub.Text = "Github Repo Link"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(194, 75)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(479, 34)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F)
        TextBox2.Location = New Point(190, 132)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(483, 34)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F)
        TextBox3.Location = New Point(237, 187)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(436, 34)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 12F)
        TextBox4.Location = New Point(318, 243)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(355, 34)
        TextBox4.TabIndex = 8
        ' 
        ' LblStopwatch
        ' 
        LblStopwatch.AutoSize = True
        LblStopwatch.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblStopwatch.Location = New Point(509, 307)
        LblStopwatch.Name = "LblStopwatch"
        LblStopwatch.Size = New Size(128, 31)
        LblStopwatch.TabIndex = 9
        LblStopwatch.Text = "00 : 00 : 00"
        ' 
        ' BtnStopwatch
        ' 
        BtnStopwatch.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        BtnStopwatch.Font = New Font("Segoe UI", 15F)
        BtnStopwatch.Location = New Point(119, 302)
        BtnStopwatch.Name = "BtnStopwatch"
        BtnStopwatch.Size = New Size(347, 48)
        BtnStopwatch.TabIndex = 10
        BtnStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        BtnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BtnSubmit.Font = New Font("Segoe UI", 14F)
        BtnSubmit.Location = New Point(262, 390)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(308, 48)
        BtnSubmit.TabIndex = 11
        BtnSubmit.Text = "SUBMIT FORM (CTRL + S)"
        BtnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' CreateForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(817, 450)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnStopwatch)
        Controls.Add(LblStopwatch)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LblGithub)
        Controls.Add(LblPhone)
        Controls.Add(LblEmail)
        Controls.Add(LblName)
        Controls.Add(LblTitle)
        KeyPreview = True
        Name = "CreateForm"
        Text = "CreateForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblPhone As Label
    Friend WithEvents LblGithub As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LblStopwatch As Label
    Friend WithEvents BtnStopwatch As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
