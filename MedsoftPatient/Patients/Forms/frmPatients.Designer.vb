<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsDelete = New System.Windows.Forms.ToolStripButton()
        Me.tsPrint = New System.Windows.Forms.ToolStripButton()
        Me.tsPrintDetail = New System.Windows.Forms.ToolStripButton()
        Me.tsExport = New System.Windows.Forms.ToolStripButton()
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
        Me.colInsurance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lblPersonalNumber = New System.Windows.Forms.Label()
        Me.txtPersonalNumber = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gcPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAdd, Me.tsEdit, Me.tsDelete, Me.tsPrint, Me.tsPrintDetail, Me.tsExport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1310, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsAdd
        '
        Me.tsAdd.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsAdd.Image = Global.MedsoftPatient.My.Resources.Resources.aAdd
        Me.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAdd.Name = "tsAdd"
        Me.tsAdd.Size = New System.Drawing.Size(105, 36)
        Me.tsAdd.Text = "დამატება"
        '
        'tsEdit
        '
        Me.tsEdit.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsEdit.Image = Global.MedsoftPatient.My.Resources.Resources.aEdit
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(131, 36)
        Me.tsEdit.Text = "რედაქტირება"
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.Image = Global.MedsoftPatient.My.Resources.Resources.aDelete
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(83, 36)
        Me.tsDelete.Text = "წაშლა"
        '
        'tsPrint
        '
        Me.tsPrint.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsPrint.Image = Global.MedsoftPatient.My.Resources.Resources.aPrint
        Me.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(91, 36)
        Me.tsPrint.Text = "ბეჭდვა"
        '
        'tsPrintDetail
        '
        Me.tsPrintDetail.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsPrintDetail.Image = Global.MedsoftPatient.My.Resources.Resources.aPrint
        Me.tsPrintDetail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrintDetail.Name = "tsPrintDetail"
        Me.tsPrintDetail.Size = New System.Drawing.Size(170, 36)
        Me.tsPrintDetail.Text = "დეტალური ბეჭდვა"
        '
        'tsExport
        '
        Me.tsExport.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsExport.Image = Global.MedsoftPatient.My.Resources.Resources.aExcel
        Me.tsExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsExport.Name = "tsExport"
        Me.tsExport.Size = New System.Drawing.Size(108, 36)
        Me.tsExport.Text = "ექსპორტი"
        '
        'gcPatients
        '
        Me.gcPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPatients.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcPatients.Location = New System.Drawing.Point(0, 219)
        Me.gcPatients.MainView = Me.gvPatients
        Me.gcPatients.Margin = New System.Windows.Forms.Padding(4)
        Me.gcPatients.Name = "gcPatients"
        Me.gcPatients.Size = New System.Drawing.Size(1310, 402)
        Me.gcPatients.TabIndex = 0
        Me.gcPatients.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPatients})
        '
        'gvPatients
        '
        Me.gvPatients.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gvPatients.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.gvPatients.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.gvPatients.Appearance.DetailTip.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.DetailTip.Options.UseFont = True
        Me.gvPatients.Appearance.Empty.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.Empty.Options.UseFont = True
        Me.gvPatients.Appearance.EvenRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.EvenRow.Options.UseFont = True
        Me.gvPatients.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FilterCloseButton.Options.UseFont = True
        Me.gvPatients.Appearance.FilterPanel.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FilterPanel.Options.UseFont = True
        Me.gvPatients.Appearance.FixedLine.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FixedLine.Options.UseFont = True
        Me.gvPatients.Appearance.FocusedCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FocusedCell.Options.UseFont = True
        Me.gvPatients.Appearance.FocusedRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FocusedRow.Options.UseFont = True
        Me.gvPatients.Appearance.FooterPanel.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FooterPanel.Options.UseFont = True
        Me.gvPatients.Appearance.GroupButton.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.GroupButton.Options.UseFont = True
        Me.gvPatients.Appearance.GroupFooter.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.GroupFooter.Options.UseFont = True
        Me.gvPatients.Appearance.GroupPanel.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.GroupPanel.Options.UseFont = True
        Me.gvPatients.Appearance.GroupRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.GroupRow.Options.UseFont = True
        Me.gvPatients.Appearance.HeaderPanel.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPatients.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gvPatients.Appearance.HorzLine.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.HorzLine.Options.UseFont = True
        Me.gvPatients.Appearance.HotTrackedRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.HotTrackedRow.Options.UseFont = True
        Me.gvPatients.Appearance.OddRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.OddRow.Options.UseFont = True
        Me.gvPatients.Appearance.Preview.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.Preview.Options.UseFont = True
        Me.gvPatients.Appearance.Row.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.Row.Options.UseFont = True
        Me.gvPatients.Appearance.RowSeparator.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.RowSeparator.Options.UseFont = True
        Me.gvPatients.Appearance.SelectedRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.SelectedRow.Options.UseFont = True
        Me.gvPatients.Appearance.TopNewRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.TopNewRow.Options.UseFont = True
        Me.gvPatients.Appearance.VertLine.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.VertLine.Options.UseFont = True
        Me.gvPatients.Appearance.ViewCaption.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.ViewCaption.Options.UseFont = True
        Me.gvPatients.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colFullname, Me.colDob, Me.colGender, Me.colPhone, Me.colAddress, Me.colPersonalNumber, Me.colMail, Me.colInsurance})
        Me.gvPatients.DetailHeight = 455
        Me.gvPatients.GridControl = Me.gcPatients
        Me.gvPatients.Name = "gvPatients"
        Me.gvPatients.OptionsSelection.MultiSelect = True
        Me.gvPatients.OptionsView.ShowGroupPanel = False
        Me.gvPatients.OptionsView.ShowIndicator = False
        Me.gvPatients.RowHeight = 65
        '
        'colId
        '
        Me.colId.Caption = "ID"
        Me.colId.FieldName = "ID"
        Me.colId.MinWidth = 40
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowEdit = False
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 151
        '
        'colFullname
        '
        Me.colFullname.Caption = "სახელი/გვარი"
        Me.colFullname.FieldName = "FullName"
        Me.colFullname.MinWidth = 40
        Me.colFullname.Name = "colFullname"
        Me.colFullname.OptionsColumn.AllowEdit = False
        Me.colFullname.Visible = True
        Me.colFullname.VisibleIndex = 1
        Me.colFullname.Width = 157
        '
        'colDob
        '
        Me.colDob.Caption = "დაბ. დღე"
        Me.colDob.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.colDob.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDob.FieldName = "Dob"
        Me.colDob.MinWidth = 40
        Me.colDob.Name = "colDob"
        Me.colDob.OptionsColumn.AllowEdit = False
        Me.colDob.Visible = True
        Me.colDob.VisibleIndex = 2
        Me.colDob.Width = 144
        '
        'colGender
        '
        Me.colGender.Caption = "სქესი"
        Me.colGender.FieldName = "GenderName"
        Me.colGender.MinWidth = 40
        Me.colGender.Name = "colGender"
        Me.colGender.OptionsColumn.AllowEdit = False
        Me.colGender.Visible = True
        Me.colGender.VisibleIndex = 3
        Me.colGender.Width = 149
        '
        'colPhone
        '
        Me.colPhone.Caption = "მობილური"
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.MinWidth = 40
        Me.colPhone.Name = "colPhone"
        Me.colPhone.OptionsColumn.AllowEdit = False
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 4
        Me.colPhone.Width = 149
        '
        'colAddress
        '
        Me.colAddress.Caption = "მისამართი"
        Me.colAddress.FieldName = "Address"
        Me.colAddress.MinWidth = 40
        Me.colAddress.Name = "colAddress"
        Me.colAddress.OptionsColumn.AllowEdit = False
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 5
        Me.colAddress.Width = 149
        '
        'colPersonalNumber
        '
        Me.colPersonalNumber.Caption = "პირადი ნომერი"
        Me.colPersonalNumber.FieldName = "PersonalNumber"
        Me.colPersonalNumber.MinWidth = 40
        Me.colPersonalNumber.Name = "colPersonalNumber"
        Me.colPersonalNumber.OptionsColumn.AllowEdit = False
        Me.colPersonalNumber.Visible = True
        Me.colPersonalNumber.VisibleIndex = 6
        Me.colPersonalNumber.Width = 149
        '
        'colMail
        '
        Me.colMail.Caption = "ელ.ფოსტა"
        Me.colMail.FieldName = "Email"
        Me.colMail.MinWidth = 40
        Me.colMail.Name = "colMail"
        Me.colMail.OptionsColumn.AllowEdit = False
        Me.colMail.Visible = True
        Me.colMail.VisibleIndex = 7
        Me.colMail.Width = 164
        '
        'colInsurance
        '
        Me.colInsurance.Caption = " სადაზღვეო"
        Me.colInsurance.FieldName = "InsuranceName"
        Me.colInsurance.MinWidth = 30
        Me.colInsurance.Name = "colInsurance"
        Me.colInsurance.Visible = True
        Me.colInsurance.VisibleIndex = 8
        Me.colInsurance.Width = 112
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(13, 12)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(99, 18)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "პაციენტის ID:"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.Location = New System.Drawing.Point(13, 91)
        Me.lblFullname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(105, 18)
        Me.lblFullname.TabIndex = 2
        Me.lblFullname.Text = "სახელი, გვარი:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(667, 91)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(82, 18)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "მისამართი:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(334, 12)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(70, 18)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "სტატუსი:"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = Global.MedsoftPatient.My.Resources.Resources.aSearch
        Me.btnSearch.Location = New System.Drawing.Point(1000, 65)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(108, 78)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.cbGender)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.cbStatus)
        Me.Panel1.Controls.Add(Me.lblPersonalNumber)
        Me.Panel1.Controls.Add(Me.txtPersonalNumber)
        Me.Panel1.Controls.Add(Me.txtFullname)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.lblFullname)
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1310, 180)
        Me.Panel1.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Image = Global.MedsoftPatient.My.Resources.Resources.aNew
        Me.btnClear.Location = New System.Drawing.Point(1131, 65)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 78)
        Me.btnClear.TabIndex = 14
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'cbGender
        '
        Me.cbGender.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Location = New System.Drawing.Point(672, 42)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(276, 26)
        Me.cbGender.TabIndex = 13
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(667, 12)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(47, 18)
        Me.lblGender.TabIndex = 12
        Me.lblGender.Text = "სქესი:"
        '
        'cbStatus
        '
        Me.cbStatus.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(339, 42)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(276, 26)
        Me.cbStatus.TabIndex = 11
        '
        'lblPersonalNumber
        '
        Me.lblPersonalNumber.AutoSize = True
        Me.lblPersonalNumber.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalNumber.Location = New System.Drawing.Point(334, 91)
        Me.lblPersonalNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPersonalNumber.Name = "lblPersonalNumber"
        Me.lblPersonalNumber.Size = New System.Drawing.Size(114, 18)
        Me.lblPersonalNumber.TabIndex = 10
        Me.lblPersonalNumber.Text = "პირადი ნომერი:"
        '
        'txtPersonalNumber
        '
        Me.txtPersonalNumber.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonalNumber.Location = New System.Drawing.Point(339, 121)
        Me.txtPersonalNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPersonalNumber.Name = "txtPersonalNumber"
        Me.txtPersonalNumber.Size = New System.Drawing.Size(276, 25)
        Me.txtPersonalNumber.TabIndex = 9
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(18, 121)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(276, 25)
        Me.txtFullname.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(672, 121)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(276, 25)
        Me.txtAddress.TabIndex = 7
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(13, 42)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(276, 25)
        Me.txtId.TabIndex = 6
        '
        'frmPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 621)
        Me.Controls.Add(Me.gcPatients)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1326, 56)
        Me.Name = "frmPatients"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "პაციენტების სია"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gcPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents tsPrintDetail As ToolStripButton
    Friend WithEvents tsExport As ToolStripButton
    Friend WithEvents lblId As Label
    Friend WithEvents lblFullname As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPersonalNumber As TextBox
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents lblPersonalNumber As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents colInsurance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsPrint As ToolStripButton
End Class
