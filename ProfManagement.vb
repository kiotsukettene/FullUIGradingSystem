Public Class ProfManagement
    Dim ClassOutStanding As Integer
    Dim FinalExam As Integer
    Dim Total As Integer
    Private Sub ProfManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GradePercentagePanel.Size = GradePercentagePanel.MinimumSize
        ClassOSBox.SelectedIndex = 5
        FinalExamBox.SelectedIndex = 3

        If ClassOSBox.SelectedIndex = 5 Then
            ClassOutStanding = 60
        End If
        If FinalExamBox.SelectedItem = "40%" Then
            FinalExam = 40
        End If
        TotalPercentageBox.Text = Total
        TotalPercentageBox.Text = ClassOutStanding + FinalExam

        ActivityBox.SelectedIndex = 1
        QuizBox.SelectedIndex = 1
        PerfBox.SelectedIndex = 1



    End Sub

    Private Sub Breakdown_Click(sender As Object, e As EventArgs) Handles Breakdown.Click
        GradePercentagePanel.Size = GradePercentagePanel.MaximumSize
        Up.Visible = True
    End Sub
    Private Sub Up_Click(sender As Object, e As EventArgs) Handles Up.Click
        GradePercentagePanel.Size = GradePercentagePanel.MinimumSize
        Up.Visible = False
    End Sub
End Class