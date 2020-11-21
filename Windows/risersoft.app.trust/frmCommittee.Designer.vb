<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommittee
    Inherits frmMax
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call


        Me.InitForm()
    End Sub

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
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridMember = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRenumber = New Infragistics.Win.Misc.UltraButton()
        Me.btnMoveDown = New Infragistics.Win.Misc.UltraButton()
        Me.btnMoveup = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddMember = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelMember = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlRTFDescrip = New risersoft.[shared].win.ctlRTF()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDeleteCommittee = New Infragistics.Win.Misc.UltraButton()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.cmb_CompanyID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.chk_NotListed = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_Name = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chk_IsManagement = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_CommEdate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_CommSdate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_CommitteeCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGridMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        CType(Me.cmb_CompanyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_NotListed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CommEdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CommSdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        CType(Me.txt_CommitteeCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGridMember)
        Me.UltraTabPageControl4.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(638, 297)
        '
        'UltraGridMember
        '
        Me.UltraGridMember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridMember.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridMember.Name = "UltraGridMember"
        Me.UltraGridMember.Size = New System.Drawing.Size(638, 257)
        Me.UltraGridMember.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnRenumber)
        Me.Panel3.Controls.Add(Me.btnMoveDown)
        Me.Panel3.Controls.Add(Me.btnMoveup)
        Me.Panel3.Controls.Add(Me.btnAddMember)
        Me.Panel3.Controls.Add(Me.btnDelMember)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 257)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(638, 40)
        Me.Panel3.TabIndex = 3
        '
        'btnRenumber
        '
        Me.btnRenumber.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRenumber.Location = New System.Drawing.Point(141, 0)
        Me.btnRenumber.Name = "btnRenumber"
        Me.btnRenumber.Size = New System.Drawing.Size(72, 40)
        Me.btnRenumber.TabIndex = 131
        Me.btnRenumber.Text = "ReNumber"
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMoveDown.Location = New System.Drawing.Point(67, 0)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(74, 40)
        Me.btnMoveDown.TabIndex = 10
        Me.btnMoveDown.Text = "Move Down"
        '
        'btnMoveup
        '
        Me.btnMoveup.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMoveup.Location = New System.Drawing.Point(0, 0)
        Me.btnMoveup.Name = "btnMoveup"
        Me.btnMoveup.Size = New System.Drawing.Size(67, 40)
        Me.btnMoveup.TabIndex = 9
        Me.btnMoveup.Text = "Move Up"
        '
        'btnAddMember
        '
        Me.btnAddMember.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddMember.Location = New System.Drawing.Point(451, 0)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(88, 40)
        Me.btnAddMember.TabIndex = 8
        Me.btnAddMember.Text = "Add Member"
        '
        'btnDelMember
        '
        Me.btnDelMember.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelMember.Location = New System.Drawing.Point(539, 0)
        Me.btnDelMember.Name = "btnDelMember"
        Me.btnDelMember.Size = New System.Drawing.Size(99, 40)
        Me.btnDelMember.TabIndex = 6
        Me.btnDelMember.Text = "Delete Member"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.CtlRTFDescrip)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(638, 282)
        '
        'CtlRTFDescrip
        '
        Me.CtlRTFDescrip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlRTFDescrip.EditEnabled = True
        Me.CtlRTFDescrip.HTMLText = ""
        Me.CtlRTFDescrip.LayoutType = "Continuous"
        Me.CtlRTFDescrip.Location = New System.Drawing.Point(0, 0)
        Me.CtlRTFDescrip.Name = "CtlRTFDescrip"
        Me.CtlRTFDescrip.PlainText = ""
        Me.CtlRTFDescrip.RTFText = ""
        Me.CtlRTFDescrip.Size = New System.Drawing.Size(638, 282)
        Me.CtlRTFDescrip.TabIndex = 266
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnDeleteCommittee)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 437)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(642, 48)
        Me.Panel4.TabIndex = 62
        '
        'btnDeleteCommittee
        '
        Appearance9.BackColor = System.Drawing.Color.LightCoral
        Appearance9.FontData.BoldAsString = "True"
        Me.btnDeleteCommittee.Appearance = Appearance9
        Me.btnDeleteCommittee.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteCommittee.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteCommittee.Name = "btnDeleteCommittee"
        Me.btnDeleteCommittee.Size = New System.Drawing.Size(88, 48)
        Me.btnDeleteCommittee.TabIndex = 14
        Me.btnDeleteCommittee.Text = "Delete"
        Me.btnDeleteCommittee.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnSave
        '
        Appearance10.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance10
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(378, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 48)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Appearance11.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance11
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(466, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 48)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance12.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance12
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(554, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 48)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        '
        'UltraPanel2
        '
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraLabel9)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.txt_CommitteeCode)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.cmb_CompanyID)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraLabel2)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.chk_NotListed)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.cmb_Name)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.chk_IsManagement)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraLabel1)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.dt_CommEdate)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraLabel4)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.dt_CommSdate)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraLabel11)
        Me.UltraPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel2.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(642, 114)
        Me.UltraPanel2.TabIndex = 63
        '
        'cmb_CompanyID
        '
        Me.cmb_CompanyID.Location = New System.Drawing.Point(114, 12)
        Me.cmb_CompanyID.Name = "cmb_CompanyID"
        Me.cmb_CompanyID.ReadOnly = True
        Me.cmb_CompanyID.Size = New System.Drawing.Size(242, 22)
        Me.cmb_CompanyID.TabIndex = 250
        Me.cmb_CompanyID.Text = "UltraCombo4"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(78, 16)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel2.TabIndex = 73
        Me.UltraLabel2.Text = "Trust"
        '
        'chk_NotListed
        '
        Me.chk_NotListed.Location = New System.Drawing.Point(362, 78)
        Me.chk_NotListed.Name = "chk_NotListed"
        Me.chk_NotListed.Size = New System.Drawing.Size(87, 24)
        Me.chk_NotListed.TabIndex = 72
        Me.chk_NotListed.Text = "Not Listed"
        '
        'cmb_Name
        '
        Me.cmb_Name.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValueListItem1.DataValue = False
        ValueListItem1.DisplayText = "Normal"
        ValueListItem2.DataValue = True
        ValueListItem2.DisplayText = "Casual"
        Me.cmb_Name.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.cmb_Name.Location = New System.Drawing.Point(114, 44)
        Me.cmb_Name.Name = "cmb_Name"
        Me.cmb_Name.Size = New System.Drawing.Size(242, 21)
        Me.cmb_Name.TabIndex = 71
        Me.cmb_Name.Text = "UltraComboEditor9"
        '
        'chk_IsManagement
        '
        Me.chk_IsManagement.Location = New System.Drawing.Point(466, 79)
        Me.chk_IsManagement.Name = "chk_IsManagement"
        Me.chk_IsManagement.Size = New System.Drawing.Size(159, 24)
        Me.chk_IsManagement.TabIndex = 70
        Me.chk_IsManagement.Text = "Management Committee"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(386, 49)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(106, 14)
        Me.UltraLabel1.TabIndex = 67
        Me.UltraLabel1.Text = "Commitee End Date"
        '
        'dt_CommEdate
        '
        Appearance14.FontData.BoldAsString = "False"
        Appearance14.FontData.ItalicAsString = "False"
        Appearance14.FontData.Name = "Arial"
        Appearance14.FontData.SizeInPoints = 8.25!
        Appearance14.FontData.StrikeoutAsString = "False"
        Appearance14.FontData.UnderlineAsString = "False"
        Me.dt_CommEdate.Appearance = Appearance14
        Me.dt_CommEdate.DateTime = New Date(2020, 5, 8, 0, 0, 0, 0)
        Me.dt_CommEdate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_CommEdate.FormatString = "dddd dd MMM yyyy"
        Me.dt_CommEdate.Location = New System.Drawing.Point(499, 49)
        Me.dt_CommEdate.Name = "dt_CommEdate"
        Me.dt_CommEdate.NullText = "Not Defined"
        Me.dt_CommEdate.Size = New System.Drawing.Size(120, 21)
        Me.dt_CommEdate.TabIndex = 66
        Me.dt_CommEdate.Value = New Date(2020, 5, 8, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(379, 16)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(113, 14)
        Me.UltraLabel4.TabIndex = 65
        Me.UltraLabel4.Text = "Committee Start Date"
        '
        'dt_CommSdate
        '
        Appearance15.FontData.BoldAsString = "False"
        Appearance15.FontData.ItalicAsString = "False"
        Appearance15.FontData.Name = "Arial"
        Appearance15.FontData.SizeInPoints = 8.25!
        Appearance15.FontData.StrikeoutAsString = "False"
        Appearance15.FontData.UnderlineAsString = "False"
        Me.dt_CommSdate.Appearance = Appearance15
        Me.dt_CommSdate.DateTime = New Date(2020, 5, 8, 0, 0, 0, 0)
        Me.dt_CommSdate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_CommSdate.FormatString = "dddd dd MMM yyyy"
        Me.dt_CommSdate.Location = New System.Drawing.Point(499, 16)
        Me.dt_CommSdate.Name = "dt_CommSdate"
        Me.dt_CommSdate.NullText = "Not Defined"
        Me.dt_CommSdate.Size = New System.Drawing.Size(120, 21)
        Me.dt_CommSdate.TabIndex = 64
        Me.dt_CommSdate.Value = New Date(2020, 5, 8, 0, 0, 0, 0)
        '
        'UltraLabel11
        '
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(16, 45)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabel11.TabIndex = 2
        Me.UltraLabel11.Text = "Committee Name"
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 114)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(642, 323)
        Me.UltraTabControl2.TabIndex = 64
        UltraTab5.Key = "Part"
        UltraTab5.TabPage = Me.UltraTabPageControl4
        UltraTab5.Text = "Member"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Description"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab1})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(638, 297)
        '
        'UltraLabel9
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance13
        Me.UltraLabel9.Location = New System.Drawing.Point(16, 75)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(92, 21)
        Me.UltraLabel9.TabIndex = 255
        Me.UltraLabel9.Text = "Committee Code"
        '
        'txt_CommitteeCode
        '
        Appearance6.FontData.BoldAsString = "False"
        Appearance6.FontData.ItalicAsString = "False"
        Appearance6.FontData.Name = "Arial"
        Appearance6.FontData.SizeInPoints = 8.25!
        Appearance6.FontData.StrikeoutAsString = "False"
        Appearance6.FontData.UnderlineAsString = "False"
        Me.txt_CommitteeCode.Appearance = Appearance6
        Me.txt_CommitteeCode.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_CommitteeCode.Location = New System.Drawing.Point(114, 75)
        Me.txt_CommitteeCode.Name = "txt_CommitteeCode"
        Me.txt_CommitteeCode.Size = New System.Drawing.Size(200, 21)
        Me.txt_CommitteeCode.TabIndex = 254
        '
        'frmCommittee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Committee"
        Me.ClientSize = New System.Drawing.Size(642, 485)
        Me.Controls.Add(Me.UltraTabControl2)
        Me.Controls.Add(Me.UltraPanel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmCommittee"
        Me.Text = "Committee"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGridMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ClientArea.PerformLayout()
        Me.UltraPanel2.ResumeLayout(False)
        CType(Me.cmb_CompanyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_NotListed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CommEdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CommSdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        CType(Me.txt_CommitteeCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents chk_IsManagement As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_CommEdate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_CommSdate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridMember As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents btnRenumber As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMoveDown As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMoveup As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddMember As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelMember As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlRTFDescrip As ctlRTF
    Friend WithEvents cmb_Name As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnDeleteCommittee As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_NotListed As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_CompanyID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_CommitteeCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
