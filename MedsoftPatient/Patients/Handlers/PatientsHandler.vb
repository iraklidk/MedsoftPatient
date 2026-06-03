Imports System.Data.SqlClient

Public Class PatientsHandler
    Private ReadOnly connString As SqlConnection = Database.GetConnectionString()
    Public Function GetPatientByID(PatientID As Integer) As PatientsModel
        Dim dt As New DataTable()
        Dim model As New PatientsModel

        Try
            Using Sa As New SqlDataAdapter("dbo.PatientGetById", connString)
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.SelectCommand.Parameters.AddWithValue("@PatientId", PatientID)
                Sa.Fill(dt)
            End Using

            If dt.Rows.Count > 0 Then
                model.ID = CInt(dt.Rows(0)("ID"))
                model.FullName = dt.Rows(0)("FullName").ToString()
                model.Dob = Convert.ToDateTime(dt.Rows(0)("Dob"))
                model.GenderId = CInt(dt.Rows(0)("GenderID"))
                model.Phone = dt.Rows(0)("Phone").ToString()
                model.Address = dt.Rows(0)("Address").ToString()
                model.PersonalNumber = dt.Rows(0)("PersonalNumber").ToString()
                model.Email = dt.Rows(0)("Email").ToString()
                model.InsuranceId = If(IsDBNull(dt.Rows(0)("InsuranceId")), 0, Convert.ToInt32(dt.Rows(0)("InsuranceId")))
            End If

        Catch ex As Exception
            MessageBox.Show($"შეცდომა პაციენტის წაკითხვის დროს: {ex.Message}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return model
    End Function

    Public Function GetPatientByIDPrint(PatientID As Integer) As dsPatientData
        Dim ds As New dsPatientData()
        Try
            Using Sa As New SqlDataAdapter("dbo.PatientGetByIdPrint", connString)
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.SelectCommand.Parameters.AddWithValue("@PatientId", PatientID)
                Sa.TableMappings.Add("Table", "PatientData")
                Sa.Fill(ds)
            End Using
        Catch ex As Exception
            MessageBox.Show($"შეცდომა პაციენტის წაკითხვის დროს: {ex.Message}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function

    Public Sub FillGendersComboBox(ComboboxGenders As ComboBox, flag As Boolean)
        Dim dt As New DataTable()
        Try
            Using Sa As New SqlDataAdapter("dbo.GetGenderList", connString)
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.Fill(dt)
                If (flag) Then
                    Dim row As DataRow = dt.NewRow()
                    row("GenderID") = 0
                    row("GenderName") = "ყველა"
                    dt.Rows.InsertAt(row, 0)
                End If

                ComboboxGenders.DataSource = dt
                ComboboxGenders.DisplayMember = "GenderName"
                ComboboxGenders.ValueMember = "GenderID"
            End Using

        Catch ex As Exception
            MessageBox.Show($"შეცდომა სქესების წაკითხვის დროს: {ex.Message}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub FillInsuranceComboBox(ComboboxInsurance As ComboBox)
        Dim dt As New DataTable()
        Try
            Using Sa As New SqlDataAdapter("dbo.GetInsuranceList", connString)
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.Fill(dt)
                ComboboxInsurance.DataSource = dt
                ComboboxInsurance.DisplayMember = "InsuranceName"
                ComboboxInsurance.ValueMember = "InsuranceID"
            End Using

        Catch ex As Exception
            MessageBox.Show($"შეცდომა სადაზღვეოს წაკითხვის დროს: {ex.Message}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetPatients(Optional patientID As Integer = 0, Optional activeStatus As Integer = 1,
                                Optional fullName As String = Nothing, Optional personalNumber As String = Nothing,
                                Optional address As String = Nothing, Optional genderId As Integer = 0) As DataTable
        Dim dt As New DataTable()
        Dim conn As SqlConnection = connString
        Try
            Using sa As New SqlDataAdapter("dbo.PatientListGet", connString)
                sa.SelectCommand.CommandType = CommandType.StoredProcedure
                sa.SelectCommand.Parameters.Add("@PatientID", SqlDbType.Int).Value = patientID
                sa.SelectCommand.Parameters.Add("@ActiveStatus", SqlDbType.Int).Value = activeStatus
                sa.SelectCommand.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = If(fullName, DBNull.Value)
                sa.SelectCommand.Parameters.Add("@PersonalNumber", SqlDbType.NVarChar).Value = If(personalNumber, DBNull.Value)
                sa.SelectCommand.Parameters.Add("@Address", SqlDbType.NVarChar).Value = If(address, DBNull.Value)
                sa.SelectCommand.Parameters.Add("@Gender", SqlDbType.Int).Value = genderId
                sa.Fill(dt)
            End Using

        Catch ex As Exception
            MessageBox.Show($"მონაცემების წაკითხვის შეცდომა: {ex.Message}", "შეცდომა",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Sub FillStatusComboBox(ComboboxStatus As ComboBox)

        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Status", GetType(String))

        dt.Rows.Add(1, "აქტიური")
        dt.Rows.Add(0, "არააქტიური")
        dt.Rows.Add(2, "ყველა")

        ComboboxStatus.DataSource = dt
        ComboboxStatus.ValueMember = "ID"
        ComboboxStatus.DisplayMember = "Status"

    End Sub

    Public Function SavePatient(ByVal model As PatientsModel) As Integer
        Try
            Using Sa As New SqlDataAdapter("dbo.UpdatePatient", connString)
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure

                Sa.SelectCommand.Parameters.AddWithValue("@ID", model.ID Or Nothing)
                Sa.SelectCommand.Parameters.AddWithValue("@FullName", model.FullName)
                Sa.SelectCommand.Parameters.AddWithValue("@Dob", model.Dob)
                Sa.SelectCommand.Parameters.AddWithValue("@GenderID", model.GenderId)
                Sa.SelectCommand.Parameters.AddWithValue("@Phone", model.Phone)
                Sa.SelectCommand.Parameters.AddWithValue("@Address", model.Address)
                Sa.SelectCommand.Parameters.AddWithValue("@PersonalNumber", model.PersonalNumber)
                Sa.SelectCommand.Parameters.AddWithValue("@Email", model.Email)
                Sa.SelectCommand.Parameters.AddWithValue("@InsuranceId", model.InsuranceId)

                Dim statusParam As New SqlParameter("@StatusCode", SqlDbType.Int)
                statusParam.Direction = ParameterDirection.Output
                Sa.SelectCommand.Parameters.Add(statusParam)

                Sa.SelectCommand.Connection.Open()
                Sa.SelectCommand.ExecuteNonQuery()
                Dim statusCode = Convert.ToInt32(Sa.SelectCommand.Parameters("@StatusCode").Value)
                Return statusCode
            End Using

        Catch ex As Exception
            MessageBox.Show("დაფიქსირდა შეცდომა: " & ex.Message)
            Return -1
        End Try
    End Function

    Public Sub GetStatus(ComboboxStatus As ComboBox)
        Try
            Dim dt As New DataTable()
            Using Sa As New SqlDataAdapter("dbo.PatientStatusGet", connString)
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.Fill(dt)

                ComboboxStatus.DataSource = dt
                ComboboxStatus.ValueMember = "ID"
                ComboboxStatus.DisplayMember = "StatusName"
            End Using

        Catch ex As Exception
        End Try
    End Sub

    Public Function DeletePatientsList(ByVal idList As DataTable) As Integer
        If idList Is Nothing OrElse idList.Rows.Count = 0 Then Return 0
        Try
            Using Sa As New SqlCommand("dbo.PatientDelete", connString)
                Sa.CommandType = CommandType.StoredProcedure

                Dim param As New SqlParameter()
                param.ParameterName = "@IDlist"
                param.SqlDbType = SqlDbType.Structured
                param.TypeName = "dbo.IDList"
                param.Value = idList
                Sa.Parameters.Add(param)

                If Sa.Connection.State = ConnectionState.Closed Then Sa.Connection.Open()
                Sa.ExecuteNonQuery()
                Return 1
            End Using

        Catch ex As Exception
            MessageBox.Show("მოხდა შეცდომა" & ex.Message)
            Return -1
        End Try
    End Function

End Class
