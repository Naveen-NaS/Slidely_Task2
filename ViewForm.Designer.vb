<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewForm
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
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        BtnNext = New Button()
        BtnPrevious = New Button()
        BtnDelete = New Button()
        BtnEdit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(39, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(772, 41)
        Label1.TabIndex = 0
        Label1.Text = "Naveen Sharma, Slidely AI Task 2 - View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(187, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 31)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(187, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 31)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(187, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 31)
        Label4.TabIndex = 3
        Label4.Text = "Phone No"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(187, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(200, 31)
        Label5.TabIndex = 4
        Label5.Text = "Github Repo Link"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(187, 303)
        Label6.Name = "Label6"
        Label6.Size = New Size(186, 31)
        Label6.TabIndex = 5
        Label6.Text = "Stopwatch Time"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ActiveBorder
        Label7.Font = New Font("Segoe UI", 14F)
        Label7.Location = New Point(264, 79)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 32)
        Label7.TabIndex = 6
        Label7.Text = "Label7"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ActiveBorder
        Label8.Font = New Font("Segoe UI", 14F)
        Label8.Location = New Point(259, 130)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 32)
        Label8.TabIndex = 7
        Label8.Text = "Label8"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ActiveBorder
        Label9.Font = New Font("Segoe UI", 14F)
        Label9.Location = New Point(304, 183)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 32)
        Label9.TabIndex = 8
        Label9.Text = "Label9"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ActiveBorder
        Label10.Font = New Font("Segoe UI", 14F)
        Label10.Location = New Point(386, 241)
        Label10.Name = "Label10"
        Label10.Size = New Size(96, 32)
        Label10.TabIndex = 9
        Label10.Text = "Label10"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.ActiveBorder
        Label11.Font = New Font("Segoe UI", 14F)
        Label11.Location = New Point(372, 303)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 32)
        Label11.TabIndex = 10
        Label11.Text = "Label11"
        ' 
        ' BtnNext
        ' 
        BtnNext.BackColor = SystemColors.ActiveCaption
        BtnNext.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnNext.Location = New Point(623, 364)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(209, 44)
        BtnNext.TabIndex = 11
        BtnNext.Text = "Next (CTRL + N)"
        BtnNext.UseVisualStyleBackColor = False
        ' 
        ' BtnPrevious
        ' 
        BtnPrevious.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        BtnPrevious.Font = New Font("Segoe UI", 14F)
        BtnPrevious.Location = New Point(26, 364)
        BtnPrevious.Name = "BtnPrevious"
        BtnPrevious.Size = New Size(234, 44)
        BtnPrevious.TabIndex = 12
        BtnPrevious.Text = "Previous (CTRL + P)"
        BtnPrevious.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        BtnDelete.Font = New Font("Segoe UI", 14F)
        BtnDelete.Location = New Point(337, 427)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(218, 44)
        BtnDelete.TabIndex = 13
        BtnDelete.Text = "Delete (CTRL + D)"
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' BtnEdit
        ' 
        BtnEdit.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        BtnEdit.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnEdit.Location = New Point(352, 364)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(184, 44)
        BtnEdit.TabIndex = 14
        BtnEdit.Text = "Edit (CTRL + E)"
        BtnEdit.UseVisualStyleBackColor = False
        ' 
        ' ViewForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(854, 487)
        Controls.Add(BtnEdit)
        Controls.Add(BtnDelete)
        Controls.Add(BtnPrevious)
        Controls.Add(BtnNext)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ViewForm"
        Text = "ViewForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
End Class
