
Imports System.IO
Imports System.Reflection.Emit
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class CreateForm

    Dim ms As Integer
    Dim ss As Integer
    Dim mm As Integer
    Private stopwatchRunning As Boolean = False
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ms += 1
        LblStopwatch.Text = mm & " : " & ss & " : " & ms
        If ms = 100 Then
            ms = 0
            ss += 1
            If ss = 60 Then
                ss = 0
                mm += 1
                If ss = 60 Then
                    mm = 0
                    ms = 0
                    ss = 0
                    Timer1.Stop()

                End If
            End If
        End If
    End Sub


    Private Sub BtnStopwatch_Click(sender As Object, e As EventArgs) Handles BtnStopwatch.Click
        If Timer1.Enabled Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadState()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveState()
    End Sub

    Private Sub LoadState()
        Try
            If File.Exists("data.json") Then
                Dim jsonData = File.ReadAllText("data.json")

                If jsonData.Trim().StartsWith("[") Then
                    Dim data = JsonConvert.DeserializeObject(Of JArray)(jsonData)

                    Dim stopwatchObject = data.FirstOrDefault(Function(item) item.Type = JTokenType.Object AndAlso CType(item, JObject).ContainsKey("StopwatchTime"))
                    If stopwatchObject IsNot Nothing Then
                        LoadTimeFromObject(CType(stopwatchObject, JObject))
                    Else
                        MessageBox.Show("No object with StopwatchTime found in data.json.")
                    End If
                Else
                    Try
                        Dim data = JsonConvert.DeserializeObject(Of JObject)(jsonData)
                        LoadTimeFromObject(data)
                    Catch ex As Exception
                        MessageBox.Show("Error loading stopwatch state (invalid JSON format): " & ex.Message)
                    End Try
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading stopwatch state: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTimeFromObject(data As JObject)
        If data.ContainsKey("StopwatchTime") Then
            Dim stopwatchTimeString = data("StopwatchTime").ToString()

            If Not String.IsNullOrEmpty(stopwatchTimeString) Then
                Dim timeParts = stopwatchTimeString.Split(":")
                If timeParts.Length = 3 Then
                    If Integer.TryParse(timeParts(0), mm) AndAlso
                   Integer.TryParse(timeParts(1), ss) AndAlso
                   Integer.TryParse(timeParts(2), ms) Then

                        LblStopwatch.Text = mm & " : " & ss & " : " & ms

                    Else
                        MessageBox.Show("Invalid time format in data.json.")
                    End If

                Else
                    MessageBox.Show("Incorrect time format in data.json (should be mm:ss:ms).")
                End If

            Else
                MessageBox.Show("StopwatchTime is empty in data.json.")
            End If
        Else
            MessageBox.Show("StopwatchTime property not found in data.json.")
        End If
    End Sub

    Private Sub SaveState()
        Try
            If File.Exists("data.json") Then
                Dim jsonData = File.ReadAllText("data.json")
                Dim data = JsonConvert.DeserializeObject(Of JArray)(jsonData)

                Dim stopwatchObject = data.FirstOrDefault(Function(item) item.Type = JTokenType.Object AndAlso CType(item, JObject).ContainsKey("StopwatchTime"))
                If stopwatchObject IsNot Nothing Then
                    CType(stopwatchObject, JObject)("StopwatchTime") = mm & ":" & ss & ":" & ms
                Else
                    Dim newStopwatchObject = New JObject(New JProperty("StopwatchTime", mm & ":" & ss & ":" & ms))
                    data.Add(newStopwatchObject)
                End If

                File.WriteAllText("data.json", data.ToString())
            Else
                Dim stopwatchData = New JObject(New JProperty("StopwatchTime", mm & ":" & ss & ":" & ms))
                Dim data = New JArray(stopwatchData)
                File.WriteAllText("data.json", data.ToString())
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving stopwatch state: " & ex.Message)
        End Try
    End Sub


    Private Sub CreateForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            BtnStopwatch.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.S Then
            BtnSubmit.PerformClick()
        End If
    End Sub

    Public Sub New(data As InputData)
        InitializeComponent()
        TextBox1.Text = data.Name
        TextBox2.Text = data.Email
        TextBox3.Text = data.PhoneNo
        TextBox4.Text = data.GithubRepoLink

    End Sub

    Public Class InputData
        Public Property Name As String
        Public Property Email As String
        Public Property PhoneNo As String
        Public Property GithubRepoLink As String
        Public Property StopwatchTime As String
    End Class

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim inputData As New InputData() With {
        .Name = TextBox1.Text,
        .Email = TextBox2.Text,
        .PhoneNo = TextBox3.Text,
        .GithubRepoLink = TextBox4.Text,
        .StopwatchTime = LblStopwatch.Text
    }

        Dim filePath As String = Path.Combine(Application.StartupPath, "data.json")

        Dim existingData As JArray = New JArray()
        If File.Exists(filePath) Then
            Dim jsonText = File.ReadAllText(filePath)
            If Not String.IsNullOrEmpty(jsonText) Then
                Try
                    existingData = JArray.Parse(jsonText)
                Catch ex As JsonException
                End Try
            End If
        End If

        existingData.Add(JObject.FromObject(inputData))

        Dim json As String = JsonConvert.SerializeObject(existingData, Formatting.Indented)
        File.WriteAllText(filePath, json)

        MessageBox.Show("Data appended to " & filePath)
    End Sub

End Class
