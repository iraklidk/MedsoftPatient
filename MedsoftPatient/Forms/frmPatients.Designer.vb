<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatients
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsDelete = New System.Windows.Forms.ToolStripButton()
        Me.gcPatients = New DevExpress.XtraGrid.GridControl()
        Me.gvPatients = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersonalNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gcPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAdd, Me.tsEdit, Me.tsDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(912, 41)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsAdd
        '
        Me.tsAdd.Image = Global.MedsoftPatient.My.Resources.Resources.aAdd
        Me.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAdd.Name = "tsAdd"
        Me.tsAdd.Size = New System.Drawing.Size(136, 36)
        Me.tsAdd.Text = "დამატება"
        '
        'tsEdit
        '
        Me.tsEdit.Image = Global.MedsoftPatient.My.Resources.Resources.aEdit
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(176, 36)
        Me.tsEdit.Text = "რედაქტირება"
        '
        'tsDelete
        '
        Me.tsDelete.Image = Global.MedsoftPatient.My.Resources.Resources.aDelete
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(108, 36)
        Me.tsDelete.Text = "წაშლა"
        '
        'gcPatients
        '
        Me.gcPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPatients.Location = New System.Drawing.Point(0, 41)
        Me.gcPatients.MainView = Me.gvPatients
        Me.gcPatients.Name = "gcPatients"
        Me.gcPatients.Size = New System.Drawing.Size(912, 511)
        Me.gcPatients.TabIndex = 1
        Me.gcPatients.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPatients})
        '
        'gvPatients
        '
        Me.gvPatients.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colFullname, Me.colDob, Me.colGender, Me.colPhone, Me.colAddress, Me.colPersonalNumber, Me.colMail})
        Me.gvPatients.GridControl = Me.gcPatients
        Me.gvPatients.Name = "gvPatients"
        Me.gvPatients.OptionsSelection.MultiSelect = True
        Me.gvPatients.OptionsView.ShowGroupPanel = False
        Me.gvPatients.OptionsView.ShowIndicator = False
        '
        'colId
        '
        Me.colId.Caption = "ID"
        Me.colId.FieldName = "ID"
        Me.colId.MinWidth = 30
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowEdit = False
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 112
        '
        'colFullname
        '
        Me.colFullname.Caption = "სახელი/გვარი"
        Me.colFullname.FieldName = "FullName"
        Me.colFullname.MinWidth = 30
        Me.colFullname.Name = "colFullname"
        Me.colFullname.OptionsColumn.AllowEdit = False
        Me.colFullname.Visible = True
        Me.colFullname.VisibleIndex = 1
        Me.colFullname.Width = 112
        '
        'colDob
        '
        Me.colDob.Caption = "დაბ. დღე"
        Me.colDob.FieldName = "Dob"
        Me.colDob.MinWidth = 30
        Me.colDob.Name = "colDob"
        Me.colDob.OptionsColumn.AllowEdit = False
        Me.colDob.Visible = True
        Me.colDob.VisibleIndex = 2
        Me.colDob.Width = 112
        '
        'colGender
        '
        Me.colGender.Caption = "სქესი"
        Me.colGender.FieldName = "GenderName"
        Me.colGender.MinWidth = 30
        Me.colGender.Name = "colGender"
        Me.colGender.OptionsColumn.AllowEdit = False
        Me.colGender.Visible = True
        Me.colGender.VisibleIndex = 3
        Me.colGender.Width = 112
        '
        'colPhone
        '
        Me.colPhone.Caption = "მობილური"
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.MinWidth = 30
        Me.colPhone.Name = "colPhone"
        Me.colPhone.OptionsColumn.AllowEdit = False
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 4
        Me.colPhone.Width = 112
        '
        'colAddress
        '
        Me.colAddress.Caption = "მისამართი"
        Me.colAddress.FieldName = "Address"
        Me.colAddress.MinWidth = 30
        Me.colAddress.Name = "colAddress"
        Me.colAddress.OptionsColumn.AllowEdit = False
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 5
        Me.colAddress.Width = 112
        '
        'colPersonalNumber
        '
        Me.colPersonalNumber.Caption = "პირადი ნომერი"
        Me.colPersonalNumber.FieldName = "PersonalNumber"
        Me.colPersonalNumber.MinWidth = 30
        Me.colPersonalNumber.Name = "colPersonalNumber"
        Me.colPersonalNumber.OptionsColumn.AllowEdit = False
        Me.colPersonalNumber.Visible = True
        Me.colPersonalNumber.VisibleIndex = 6
        Me.colPersonalNumber.Width = 112
        '
        'colMail
        '
        Me.colMail.Caption = "ელ.ფოსტა"
        Me.colMail.FieldName = "Email"
        Me.colMail.MinWidth = 30
        Me.colMail.Name = "colMail"
        Me.colMail.OptionsColumn.AllowEdit = False
        Me.colMail.Visible = True
        Me.colMail.VisibleIndex = 7
        Me.colMail.Width = 112
        '
        'frmPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 552)
        Me.Controls.Add(Me.gcPatients)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmPatients"
        Me.ShowIcon = False
        Me.Text = "პაციენტების სია"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gcPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsAdd As ToolStripButton
    Friend WithEvents gcPatients As DevExpress.XtraGrid.GridControl
    Friend WithEvents tsEdit As ToolStripButton
    Friend WithEvents tsDelete As ToolStripButton
    Friend WithEvents colFullname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvPatients As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPersonalNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGender As DevExpress.XtraGrid.Columns.GridColumn
End Class
