Imports System.Data.SqlClient
Imports DevExpress.Internal.WinApi.Windows.UI.Notifications
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraReports.UI


Public Class frmPatients
    Dim handler As New PatientsHandler()
    Private Sub frmPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcPatients.DataSource = handler.GetPatients()
        gvPatients.BestFitColumns()
    End Sub

    Private Sub tsDelete_Click(sender As Object, e As EventArgs) Handles tsDelete.Click
        Dim selectedRowsHandles As Integer() = gvPatients.GetSelectedRows()
        If selectedRowsHandles Is Nothing OrElse selectedRowsHandles.Length = 0 Then
            MessageBox.Show("გთხოვთ, აირჩიოთ ჩანაწერი.", "ყურადღება", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Dim Result As DialogResult = MessageBox.Show("გსურთ ჩანაწერის წაშლა?", "დადასტურება", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                Dim dtIdList As New DataTable()
                dtIdList.Columns.Add("ID", GetType(Integer))

                For Each rowHandle As Integer In selectedRowsHandles
                    If Not gvPatients.IsGroupRow(rowHandle) Then
                        Dim patientId As Object = gvPatients.GetRowCellValue(rowHandle, "ID")
                        If patientId IsNot Nothing AndAlso IsNumeric(patientId) Then
                            dtIdList.Rows.Add(CInt(patientId))
                        End If
                    End If
                Next

                If dtIdList.Rows.Count = 0 Then
                    MessageBox.Show("არ არის არჩეული ვალიდური ჩანაწერი.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim rowsAffected As Integer = handler.DeletePatientsList(dtIdList)

                If rowsAffected <> 0 And rowsAffected <> 1 Then     ' BUG
                    gcPatients.DataSource = handler.GetPatients()
                    MessageBox.Show("ჩანაწერი წარმატებით წაიშალა.", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("ჩანაწერი არ მოიძებნა ან წაშლა ვერ მოხერხდა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        Dim frm As New frmPatientAddEdit(patientId:=Nothing)
        frm.ShowDialog()
    End Sub

    Private Sub tsAdd_Click(sender As Object, e As EventArgs) Handles tsAdd.Click
        Dim frm As New frmPatientAddEdit(patientId:=Nothing)
        frm.ShowDialog()
    End Sub

End Class
