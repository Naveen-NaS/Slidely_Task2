Imports Newtonsoft.Json.Linq
Imports System.IO
Imports Newtonsoft.Json
Imports SlidelyAI_task2_Naveen.CreateForm



Public Class ViewForm

    Private currentEntryIndex As Integer = 0
    Private jsonData As JArray


    Private Sub CreateForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            BtnPrevious.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            BtnNext.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.D Then
            BtnDelete.PerformClick()
        End If
    End Sub

    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = Path.Combine(Application.StartupPath, "data.json")

        If File.Exists(filePath) Then
            Dim jsonText = File.ReadAllText(filePath)
            Try
                jsonData = JArray.Parse(jsonText)
                DisplayEntry(currentEntryIndex)
            Catch ex As JsonException
                MessageBox.Show("Error reading JSON data.")
            End Try
        End If

        If jsonData Is Nothing OrElse jsonData.Count = 0 Then
            MessageBox.Show("No entries found in data.json.")
            DisableNavigationButtons()  ' Disable navigation if there are no entries
        End If
    End Sub

    Private Sub DisplayEntry(index As Integer)
        If jsonData IsNot Nothing AndAlso index >= 0 AndAlso index < jsonData.Count Then
            Dim currentEntry = jsonData(index)
            Label7.Text = currentEntry("Name").ToString()
            Label8.Text = currentEntry("Email").ToString()
            Label9.Text = currentEntry("PhoneNo").ToString()
            Label10.Text = currentEntry("GithubRepoLink").ToString()
        Else
            ClearEntryDisplay()  ' Clear labels if no valid entry is found
            MessageBox.Show("Invalid entry index or no data loaded.")
        End If
    End Sub


    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If jsonData IsNot Nothing AndAlso currentEntryIndex > 0 Then
            currentEntryIndex -= 1
            DisplayEntry(currentEntryIndex)
        Else
            MessageBox.Show("No previous entry.")
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If jsonData IsNot Nothing AndAlso currentEntryIndex < jsonData.Count - 1 Then
            currentEntryIndex += 1
            DisplayEntry(currentEntryIndex)
        Else
            MessageBox.Show("No next entry.")
        End If
    End Sub


    Private Sub DisableNavigationButtons()
        BtnPrevious.Enabled = False
        BtnNext.Enabled = False
    End Sub

    Private Sub ClearEntryDisplay()
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If currentEntryIndex >= 0 AndAlso currentEntryIndex < jsonData.Count Then
            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                jsonData.RemoveAt(currentEntryIndex)

                Dim filePath As String = Path.Combine(Application.StartupPath, "data.json")
                Dim json As String = JsonConvert.SerializeObject(jsonData, Formatting.Indented)
                File.WriteAllText(filePath, json)

                If currentEntryIndex >= jsonData.Count Then
                    currentEntryIndex -= 1
                End If

                DisplayEntry(currentEntryIndex)
            End If
        End If
    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If jsonData Is Nothing Then Exit Sub ' Exit if no JSON data loaded

        Dim editForm As New EditForm()
        editForm.CurrentEntry = jsonData(currentEntryIndex)

        If editForm.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = Path.Combine(Application.StartupPath, "data.json")
            File.WriteAllText(filePath, jsonData.ToString())

            DisplayEntry(currentEntryIndex)
        End If
    End Sub
End Class
