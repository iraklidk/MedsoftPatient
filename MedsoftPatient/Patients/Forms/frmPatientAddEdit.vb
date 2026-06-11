Imports System.Text.RegularExpressions

Public Class frmPatientAddEdit
    Private ReadOnly patientHandler As New PatientsHandler()
    Private currentPatientId As Integer = 0

#Region "Properties"
    Public Property FullName() As String
        Get
            Return txtFullName.Text
        End Get
        Set(ByVal value As String)
            txtFullName.Text = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return txtPhone.Text
        End Get
        Set(ByVal value As String)
            txtPhone.Text = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return txtAddress.Text
        End Get
        Set(ByVal value As String)
            txtAddress.Text = value
        End Set
    End Property
    Public Property PersonalNumber() As String
        Get
            Return txtPersonalNumber.Text
        End Get
        Set(ByVal value As String)
            txtPersonalNumber.Text = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return txtEmail.Text
        End Get
        Set(ByVal value As String)
            txtEmail.Text = value
        End Set
    End Property
    Public Property GenderID() As Integer
        Get
            Return cbGender.SelectedValue
        End Get
        Set(ByVal value As Integer)
            cbGender.SelectedValue = value
        End Set
    End Property
    Public Property Dob() As DateTime
        Get
            Return dtpDob.Value
        End Get
        Set(ByVal value As DateTime)
            dtpDob.Value = value
        End Set
    End Property
#End Region

    Public Sub New(ByVal patientId As Integer)
        InitializeComponent()
        currentPatientId = patientId
    End Sub

    Private Sub frmPatientAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        patientHandler.FillGendersComboBox(cbGender, False) ' fill combobox
        patientHandler.FillInsuranceComboBox(cbInsurance)
        If currentPatientId > 0 Then
            LoadPatient(currentPatientId)
        End If
    End Sub

    Private Sub LoadPatient(PatientId As Integer)
        Dim mm = patientHandler.GetPatientByID(PatientId)

        Try
            FullName = mm.FullName
            Phone = mm.Phone
            GenderID = mm.GenderId
            Address = mm.Address
            cbInsurance.SelectedValue = mm.InsuranceId
            Dob = mm.Dob
            PersonalNumber = mm.PersonalNumber
            Email = mm.Email
        Catch ex As Exception
            MessageBox.Show($"პაციენტის მონაცემების ჩატვირთვის შეცდომა: {ex.Message}", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MyBase.DialogResult = DialogResult.Cancel
        MyBase.Close()
    End Sub

    Private Function CheckModel() As Boolean
        ' სახელი გვარის ვალიდაცია
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("პაციენტის სახელი და გვარი სავალდებულოა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Return False
        End If
        ' სქესის ვალიდაცია
        If cbGender.SelectedIndex = -1 Then
            MessageBox.Show("სქესი სავალდებულოა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbGender.Focus()
            Return False
        End If
        ' ტელეფონის ნომრის ვალიდაცია
        If Not String.IsNullOrWhiteSpace(txtPhone.Text) Then
            If Not Regex.IsMatch(txtPhone.Text, "^5\d{8}$") Then
                MessageBox.Show("ტელეფონის ნომერი უნდა იწყებოდეს 5-ით და შეიცავდეს 9 ციფრს.", "შეცდომა",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPhone.Focus()
                Return False
            End If
        End If
        'პირადი ნომრის ვალიდაცია
        If String.IsNullOrWhiteSpace(txtPersonalNumber.Text) Then
            MessageBox.Show("პაციენტის პირადი ნომერი სავალდებულოა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else

            If Not Regex.IsMatch(txtPersonalNumber.Text, "^\d{11}$") Then
                MessageBox.Show("პირადი ნომერი უნდა შეიცავდეს 11 ციფრს", "შეცდომა",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPersonalNumber.Focus()
                Return False
            End If
        End If
        If Not String.IsNullOrWhiteSpace(txtEmail.Text) Then
            If Not Regex.IsMatch(txtEmail.Text, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
                MessageBox.Show("ელ. ფოსტის მისამართი არასწორი ფორმატისაა.", "შეცდომა",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not CheckModel() Then
            Return
        End If

        Dim GenderId As Integer = -1
        Dim InsuranceId As Integer = -1

        If (cbGender.SelectedValue IsNot Nothing) Then
            GenderId = CInt(cbGender.SelectedValue)
        Else
            MessageBox.Show("სქესის არჩევისას მოხდა შეცდომა", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (cbInsurance.SelectedValue IsNot Nothing) Then
            InsuranceId = CInt(cbInsurance.SelectedValue)
        End If

        Dim patientData As New PatientsModel()
        patientData.ID = currentPatientId
        patientData.FullName = FullName
        patientData.Dob = Dob
        patientData.Email = Email
        patientData.InsuranceId = InsuranceId
        patientData.GenderId = GenderId
        patientData.Phone = Phone
        patientData.Address = Address
        patientData.PersonalNumber = PersonalNumber

        Dim saveResultCode As Integer = patientHandler.SavePatient(patientData)
        If saveResultCode = 1 Then
            MessageBox.Show("პაციენტი წარმატებით დაემატა", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        ElseIf saveResultCode = 2 Then
            MessageBox.Show("პაციენტი წარმატებით განახლდა", "წარმატება", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        ElseIf saveResultCode = 0 Then
            MessageBox.Show("პაციენტი ამ პირადი ნომრით უკვე რეგისტრირებულია.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPersonalNumber.Focus()
        ElseIf saveResultCode = -2 Then
            MessageBox.Show("პაციენტის ბაზაში შენახვა ვერ მოხერხდა უცნობი შეცდომის გამო.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class