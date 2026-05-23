Imports System.Data.SqlClient

Public Class PatientsHandler

    Public Function GetPatientByID(PatientID As Integer) As PatientsModel
        Dim dt As New DataTable()
        Dim model As New PatientsModel
        Try
            Using Sa As New SqlDataAdapter("dbo.PatientGet", Database.GetConnectionString())
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.SelectCommand.Parameters.AddWithValue("@ID", PatientID)
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
            End If

        Catch ex As Exception
            MessageBox.Show($"პაციენტის მონაცემების ჩატვირთვის შეცდომა: {ex.Message}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return model
    End Function

    Public Function GetPatients() As DataTable
        Dim dt As New DataTable()
        Dim conn As SqlConnection = Database.GetConnectionString()
        Try
            Using sa As New SqlDataAdapter("dbo.PatientListGet", Database.GetConnectionString())
                sa.SelectCommand.CommandType = CommandType.StoredProcedure
                sa.Fill(dt)
            End Using

        Catch ex As Exception
            MessageBox.Show($"მონაცემების წაკითხვის შეცდომა: {ex.Message}", "შეცდომა",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SavePatient(ByVal model As PatientsModel) As Integer
        Try
            Using Sa As New SqlDataAdapter("dbo.PatientSet", Database.GetConnectionString())
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure

                Sa.SelectCommand.Parameters.AddWithValue("@ID", model.ID Or Nothing)
                Sa.SelectCommand.Parameters.AddWithValue("@FullName", model.FullName)
                Sa.SelectCommand.Parameters.AddWithValue("@Dob", model.Dob)
                Sa.SelectCommand.Parameters.AddWithValue("@GenderID", model.GenderId)
                Sa.SelectCommand.Parameters.AddWithValue("@Phone", model.Phone)
                Sa.SelectCommand.Parameters.AddWithValue("@Address", model.Address)
                Sa.SelectCommand.Parameters.AddWithValue("@PersonalNumber", model.PersonalNumber)
                Sa.SelectCommand.Parameters.AddWithValue("@Email", model.Email)

                Dim statusParam As New SqlParameter("@Status", SqlDbType.Int)
                statusParam.Direction = ParameterDirection.Output
                Sa.SelectCommand.Parameters.Add(statusParam)

                Sa.SelectCommand.Connection.Open()
                Sa.SelectCommand.ExecuteNonQuery()
                Dim statusCode = Convert.ToInt32(Sa.SelectCommand.Parameters("@Status").Value)
                Return statusCode
            End Using
        Catch ex As Exception
            MessageBox.Show("დაფიქსირდა შეცდომა" & ex.Message)
            Return -1
        End Try
    End Function

    Public Sub GetStatus(ComboboxStatus As ComboBox)
        Try
            Dim dt As New DataTable()
            Using Sa As New SqlDataAdapter("dbo.PatientStatusGet", Database.GetConnectionString())
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
            Using Sa As New SqlCommand("dbo.PatientDelete", Database.GetConnectionString())
                Sa.CommandType = CommandType.StoredProcedure

                Dim param As New SqlParameter()
                param.ParameterName = "@IDlist"
                param.SqlDbType = SqlDbType.Structured
                param.TypeName = "dbo.IDList"
                param.Value = idList
                Sa.Parameters.Add(param)

                If Sa.Connection.State = ConnectionState.Closed Then Sa.Connection.Open()
                Sa.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("მოხდა შეცდომა" & ex.Message)
            Return 1
        End Try
    End Function

End Class
