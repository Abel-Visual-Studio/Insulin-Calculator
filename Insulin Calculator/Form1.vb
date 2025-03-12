Imports Tulpep.NotificationWindow

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResultLabel.Hide()
        GlucoseFactorInput.Text = Convert.ToString(My.Settings.GlucoseFactor)
        GlucoseTargetInput.Text = Convert.ToString(My.Settings.GlucoseTarget)
        CarbFactorInput.Text = Convert.ToString(My.Settings.CarbFactor)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        'Define the numbers
        Dim BloodGlucose As Double
        Dim Carbohydrates As Double
        Dim GlucoseFactor As Double
        Dim GlucoseTarget As Double
        Dim CarbFactor As Double

        Dim CarbUnits As Double
        Dim CorrectionUnits As Double
        Dim TotalUnits As Double

        'Appoint the numbers
        BloodGlucose = Convert.ToDouble(MaterialTextBox1.Text)
        Carbohydrates = Convert.ToDouble(MaterialTextBox2.Text)
        GlucoseFactor = Convert.ToDouble(GlucoseFactorInput.Text)
        GlucoseTarget = Convert.ToDouble(GlucoseTargetInput.Text)
        CarbFactor = Convert.ToDouble(CarbFactorInput.Text)

        'Do the carbohydrate math
        CarbUnits = Carbohydrates / CarbFactor

        'Do the blood glucose correction math
        If BloodGlucose >= GlucoseTarget Then
            Dim glucoseDifference As Double = BloodGlucose - GlucoseTarget
            If GlucoseFactor > 0 Then
                CorrectionUnits = glucoseDifference / GlucoseFactor
            Else
                CorrectionUnits = 0 ' Prevent divide by zero error
            End If
        Else
            CorrectionUnits = 0
        End If

        'Get the total units (rounded up to avoid under-dosing)
        TotalUnits = Math.Ceiling(CarbUnits + CorrectionUnits)

        'Format the result label
        Dim formWidth As Integer = Me.ClientSize.Width
        Dim labelWidth As Integer = ResultLabel.Width
        ResultLabel.Left = (formWidth - labelWidth) \ 2
        ResultLabel.Text = TotalUnits.ToString() + " Units"
        ResultLabel.Show()
    End Sub

    Private Sub MaterialTextBox1_Enter(sender As Object, e As EventArgs) Handles MaterialTextBox1.Enter
        ResultLabel.Hide()
        MaterialTextBox1.Text = ""
    End Sub

    Private Sub MaterialTextBox2_Enter(sender As Object, e As EventArgs) Handles MaterialTextBox2.Enter
        ResultLabel.Hide()
        MaterialTextBox2.Text = ""
    End Sub

    Private Sub SaveSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSettingsToolStripMenuItem.Click
        My.Settings.CarbFactor = CarbFactorInput.Text
        My.Settings.GlucoseFactor = GlucoseFactorInput.Text
        My.Settings.GlucoseTarget = GlucoseTargetInput.Text
        My.Settings.Save()
        Dim popup As PopupNotifier = New PopupNotifier()
        popup.TitleText = "Settings Saved"
        popup.ContentText = "Your settings have been saved!"
        popup.Popup()
        MsgBox("Your settings have been saved!")
    End Sub
End Class
