Public Class frmPatientAddEdit

    Private currentPatientId As Integer = 0

    Public Sub New(ByVal patientId As Integer)
        InitializeComponent()
        currentPatientId = patientId
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MyBase.DialogResult = DialogResult.Cancel
        MyBase.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class