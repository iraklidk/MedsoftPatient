Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DevExpress.XtraReports.UI

Public Class frmPatients

    Dim handler As New PatientsHandler()

    Private Sub frmPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcPatients.DataSource = handler.GetPatients()
        gvPatients.BestFitColumns()
        handler.FillGendersComboBox(cbGender, True)
        handler.FillStatusComboBox(cbStatus)
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
                If rowsAffected > 0 Then     ' BUG
                    Dim patientId As Integer
                    If Not Integer.TryParse(txtId.Text, patientId) Then
                        patientId = 0
                    End If
                    gcPatients.DataSource = handler.GetPatients(patientId, cbStatus.SelectedValue, txtFullname.Text, txtPersonalNumber.Text, txtAddress.Text, cbGender.SelectedValue)
                    MessageBox.Show("ჩანაწერი წარმატებით წაიშალა.", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("ჩანაწერი არ მოიძებნა ან წაშლა ვერ მოხერხდა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        Dim currentId As Integer = gvPatients.GetFocusedRowCellValue(colId)
        If currentId > 0 Then
            Dim frm As New frmPatientAddEdit(currentId)
            frm.ShowDialog()
            gcPatients.DataSource = handler.GetPatients()
        Else
            MessageBox.Show("აირჩიეთ სწორი პაციენტი.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub tsAdd_Click(sender As Object, e As EventArgs) Handles tsAdd.Click
        Dim frm As New frmPatientAddEdit(patientId:=Nothing)
        If frm.ShowDialog() = DialogResult.OK Then
            gcPatients.DataSource = handler.GetPatients()
        End If
    End Sub

    Private Sub tsExport_Click(sender As Object, e As EventArgs) Handles tsExport.Click
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
            sfd.Title = "Save Patient List as Excel File"
            sfd.FileName = "Patient_List_Export.xlsx"

            If sfd.ShowDialog() = DialogResult.OK Then

                Try
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(gcPatients.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

                    view.ExportToXlsx(sfd.FileName)

                    MessageBox.Show($"პაციენტების ცხრილი წარმატებით დაექსპორტდა: {sfd.FileName}", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    System.Diagnostics.Process.Start(sfd.FileName)

                Catch ex As Exception
                    MessageBox.Show($"ექსპორტისას მოხდა შეცდომა: {ex.Message}", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim statusId = CInt(cbStatus.SelectedValue)

        Dim patientId As Integer

        Dim genderId = CInt(cbGender.SelectedValue)

        If Not Integer.TryParse(txtId.Text, patientId) Then
            patientId = 0
        End If

        gcPatients.DataSource = handler.GetPatients(patientId, statusId, txtFullname.Text, txtPersonalNumber.Text, txtAddress.Text, genderId)

        If gvPatients.RowCount = 0 Then
            MessageBox.Show("პაციენტები ვერ მოიძებნა", "შენიშვნა", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAddress.Clear()
        txtId.Clear()
        txtPersonalNumber.Clear()
        txtFullname.Clear()
        cbGender.SelectedValue = 0
        cbStatus.SelectedValue = 2
    End Sub

    Private Sub tsPrint_Click(sender As Object, e As EventArgs) Handles tsPrint.Click
        Dim selectedRowsHandles As Integer = gvPatients.GetFocusedRowCellValue(colId)
        Dim dt As dsPatientDataDetail = handler.GetPatientByIDPrint(selectedRowsHandles)
        Dim Report As New XtraPatientPrint()
        Report.DataSource = dt
        Report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub tsPrintDetail_Click(sender As Object, e As EventArgs) Handles tsPrintDetail.Click
        Dim selectedRowsHandles As Integer = gvPatients.GetFocusedRowCellValue(colId)
        Dim dt As dsPatientDataDetail = handler.GetPatientByIDPrint(selectedRowsHandles)
        Dim Report As New XtraPatientPrintDetail()
        Report.DataSource = dt
        Report.ShowRibbonPreviewDialog()
    End Sub
End Class
