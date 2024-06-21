Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim viewForm As New ViewForm()
        viewForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim inputData As New CreateForm.InputData() With {
            .Name = "",
            .Email = "",
            .PhoneNo = "",
            .GithubRepoLink = "",
            .StopwatchTime = ""
        }

        Dim createForm As New CreateForm(inputData)
        createForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button1.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub

End Class
