<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientAddEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbFullName = New System.Windows.Forms.Label()
        Me.lbPhone = New System.Windows.Forms.Label()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.lbDob = New System.Windows.Forms.Label()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.lbPersonalId = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtPersonalNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.dtpDob = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbFullName
        '
        Me.lbFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFullName.Location = New System.Drawing.Point(48, 32)
        Me.lbFullName.Name = "lbFullName"
        Me.lbFullName.Size = New System.Drawing.Size(161, 35)
        Me.lbFullName.TabIndex = 0
        Me.lbFullName.Text = "პაციენტი:"
        Me.lbFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPhone
        '
        Me.lbPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPhone.Location = New System.Drawing.Point(47, 358)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(162, 60)
        Me.lbPhone.TabIndex = 2
        Me.lbPhone.Text = "მობილური:"
        Me.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbGender
        '
        Me.lbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGender.Location = New System.Drawing.Point(49, 151)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(160, 60)
        Me.lbGender.TabIndex = 3
        Me.lbGender.Text = "სქესი:"
        Me.lbGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDob
        '
        Me.lbDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDob.Location = New System.Drawing.Point(47, 220)
        Me.lbDob.Name = "lbDob"
        Me.lbDob.Size = New System.Drawing.Size(162, 60)
        Me.lbDob.TabIndex = 4
        Me.lbDob.Text = "დაბ.თარიღი:"
        Me.lbDob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbAddress
        '
        Me.lbAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAddress.Location = New System.Drawing.Point(48, 280)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(161, 78)
        Me.lbAddress.TabIndex = 5
        Me.lbAddress.Text = "მისამართი:"
        Me.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPersonalId
        '
        Me.lbPersonalId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPersonalId.Location = New System.Drawing.Point(47, 82)
        Me.lbPersonalId.Name = "lbPersonalId"
        Me.lbPersonalId.Size = New System.Drawing.Size(162, 69)
        Me.lbPersonalId.TabIndex = 6
        Me.lbPersonalId.Text = "პირადი ნომერი:"
        Me.lbPersonalId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbEmail
        '
        Me.lbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.Location = New System.Drawing.Point(48, 418)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(161, 80)
        Me.lbEmail.TabIndex = 7
        Me.lbEmail.Text = "ელ. ფოსტა:"
        Me.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 487)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 97)
        Me.Panel1.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Image = Global.MedsoftPatient.My.Resources.Resources.aDelete
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(288, 20)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(231, 55)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "გაუქმება"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Image = Global.MedsoftPatient.My.Resources.Resources.aApply
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(53, 20)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(229, 55)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "შესრულება"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(219, 38)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(300, 26)
        Me.txtFullName.TabIndex = 9
        '
        'txtPersonalNumber
        '
        Me.txtPersonalNumber.Location = New System.Drawing.Point(219, 104)
        Me.txtPersonalNumber.Name = "txtPersonalNumber"
        Me.txtPersonalNumber.Size = New System.Drawing.Size(300, 26)
        Me.txtPersonalNumber.TabIndex = 10
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(219, 307)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(300, 26)
        Me.txtAddress.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(219, 439)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(300, 26)
        Me.txtEmail.TabIndex = 12
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(219, 376)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(300, 26)
        Me.txtPhone.TabIndex = 13
        '
        'cbGender
        '
        Me.cbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"მდედრობითი", "მამრობითი"})
        Me.cbGender.Location = New System.Drawing.Point(219, 164)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(300, 28)
        Me.cbGender.TabIndex = 14
        '
        'dtpDob
        '
        Me.dtpDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDob.Location = New System.Drawing.Point(219, 236)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(300, 26)
        Me.dtpDob.TabIndex = 15
        '
        'frmPatientAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 584)
        Me.Controls.Add(Me.dtpDob)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPersonalNumber)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbPersonalId)
        Me.Controls.Add(Me.lbAddress)
        Me.Controls.Add(Me.lbDob)
        Me.Controls.Add(Me.lbGender)
        Me.Controls.Add(Me.lbPhone)
        Me.Controls.Add(Me.lbFullName)
        Me.Name = "frmPatientAddEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "პაციენტის დამატება/რედაქტირება"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbFullName As Label
    Friend WithEvents lbPhone As Label
    Friend WithEvents lbGender As Label
    Friend WithEvents lbDob As Label
    Friend WithEvents lbAddress As Label
    Friend WithEvents lbPersonalId As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtPersonalNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents dtpDob As DateTimePicker
End Class
