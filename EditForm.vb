Imports Newtonsoft.Json.Linq

Public Class EditForm
    Public Property CurrentEntry As JToken

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CurrentEntry IsNot Nothing Then
            TextBox1.Text = CurrentEntry("Name").ToString()
            TextBox2.Text = CurrentEntry("Email").ToString()
            TextBox3.Text = CurrentEntry("PhoneNo").ToString()
            TextBox4.Text = CurrentEntry("GithubRepoLink").ToString()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CurrentEntry IsNot Nothing Then
            CurrentEntry("Name") = TextBox1.Text
            CurrentEntry("Email") = TextBox2.Text
            CurrentEntry("PhoneNo") = TextBox3.Text
            CurrentEntry("GithubRepoLink") = TextBox4.Text

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class