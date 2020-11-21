<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRent
    Inherits frmMax
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call


        Me.InitForm()
    End Sub

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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_IsCurrent = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cmb_PartyID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_MonthlyRent = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_AmountRcd = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_PropertyID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.dt_Dated = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlRTFRent = New risersoft.[shared].win.ctlRTF()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDeleteRent = New Infragistics.Win.Misc.UltraButton()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_IsCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PartyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MonthlyRent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AmountRcd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PropertyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_Dated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Panel1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(548, 276)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_IsCurrent)
        Me.Panel1.Controls.Add(Me.cmb_PartyID)
        Me.Panel1.Controls.Add(Me.UltraLabel8)
        Me.Panel1.Controls.Add(Me.txt_MonthlyRent)
        Me.Panel1.Controls.Add(Me.UltraLabel7)
        Me.Panel1.Controls.Add(Me.txt_Remark)
        Me.Panel1.Controls.Add(Me.UltraLabel4)
        Me.Panel1.Controls.Add(Me.txt_AmountRcd)
        Me.Panel1.Controls.Add(Me.UltraLabel3)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.UltraLabel9)
        Me.Panel1.Controls.Add(Me.cmb_PropertyID)
        Me.Panel1.Controls.Add(Me.dt_Dated)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 276)
        Me.Panel1.TabIndex = 252
        '
        'cmb_IsCurrent
        '
        Me.cmb_IsCurrent.Location = New System.Drawing.Point(114, 81)
        Me.cmb_IsCurrent.Name = "cmb_IsCurrent"
        Me.cmb_IsCurrent.Size = New System.Drawing.Size(144, 21)
        Me.cmb_IsCurrent.TabIndex = 267
        '
        'cmb_PartyID
        '
        Me.cmb_PartyID.Location = New System.Drawing.Point(113, 48)
        Me.cmb_PartyID.Name = "cmb_PartyID"
        Me.cmb_PartyID.Size = New System.Drawing.Size(266, 22)
        Me.cmb_PartyID.TabIndex = 266
        Me.cmb_PartyID.Text = "UltraCombo4"
        '
        'UltraLabel8
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance1
        Me.UltraLabel8.Location = New System.Drawing.Point(34, 190)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(72, 21)
        Me.UltraLabel8.TabIndex = 265
        Me.UltraLabel8.Text = "Monthly Rent"
        '
        'txt_MonthlyRent
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.ItalicAsString = "False"
        Appearance2.FontData.Name = "Arial"
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.FontData.StrikeoutAsString = "False"
        Appearance2.FontData.UnderlineAsString = "False"
        Me.txt_MonthlyRent.Appearance = Appearance2
        Me.txt_MonthlyRent.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_MonthlyRent.Location = New System.Drawing.Point(114, 190)
        Me.txt_MonthlyRent.Name = "txt_MonthlyRent"
        Me.txt_MonthlyRent.Size = New System.Drawing.Size(118, 21)
        Me.txt_MonthlyRent.TabIndex = 264
        '
        'UltraLabel7
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance3
        Me.UltraLabel7.Location = New System.Drawing.Point(21, 229)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(84, 22)
        Me.UltraLabel7.TabIndex = 263
        Me.UltraLabel7.Text = "Remark"
        '
        'txt_Remark
        '
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.ItalicAsString = "False"
        Appearance4.FontData.Name = "Arial"
        Appearance4.FontData.SizeInPoints = 8.25!
        Appearance4.FontData.StrikeoutAsString = "False"
        Appearance4.FontData.UnderlineAsString = "False"
        Me.txt_Remark.Appearance = Appearance4
        Me.txt_Remark.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Remark.Location = New System.Drawing.Point(113, 229)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(312, 21)
        Me.txt_Remark.TabIndex = 262
        '
        'UltraLabel4
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance5
        Me.UltraLabel4.Location = New System.Drawing.Point(10, 152)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(95, 22)
        Me.UltraLabel4.TabIndex = 257
        Me.UltraLabel4.Text = "Amount Received"
        '
        'txt_AmountRcd
        '
        Appearance6.FontData.BoldAsString = "False"
        Appearance6.FontData.ItalicAsString = "False"
        Appearance6.FontData.Name = "Arial"
        Appearance6.FontData.SizeInPoints = 8.25!
        Appearance6.FontData.StrikeoutAsString = "False"
        Appearance6.FontData.UnderlineAsString = "False"
        Me.txt_AmountRcd.Appearance = Appearance6
        Me.txt_AmountRcd.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_AmountRcd.Location = New System.Drawing.Point(113, 152)
        Me.txt_AmountRcd.Name = "txt_AmountRcd"
        Me.txt_AmountRcd.Size = New System.Drawing.Size(119, 21)
        Me.txt_AmountRcd.TabIndex = 256
        '
        'UltraLabel3
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance7
        Me.UltraLabel3.Location = New System.Drawing.Point(42, 81)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(63, 22)
        Me.UltraLabel3.TabIndex = 255
        Me.UltraLabel3.Text = "Current"
        '
        'UltraLabel2
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance8
        Me.UltraLabel2.Location = New System.Drawing.Point(41, 117)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(63, 22)
        Me.UltraLabel2.TabIndex = 253
        Me.UltraLabel2.Text = "Dated"
        '
        'UltraLabel1
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.Location = New System.Drawing.Point(52, 15)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(55, 26)
        Me.UltraLabel1.TabIndex = 252
        Me.UltraLabel1.Text = "Property"
        '
        'UltraLabel9
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance10
        Me.UltraLabel9.Location = New System.Drawing.Point(58, 48)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(48, 22)
        Me.UltraLabel9.TabIndex = 251
        Me.UltraLabel9.Text = "Party"
        '
        'cmb_PropertyID
        '
        Me.cmb_PropertyID.Location = New System.Drawing.Point(113, 15)
        Me.cmb_PropertyID.Name = "cmb_PropertyID"
        Me.cmb_PropertyID.ReadOnly = True
        Me.cmb_PropertyID.Size = New System.Drawing.Size(266, 22)
        Me.cmb_PropertyID.TabIndex = 249
        Me.cmb_PropertyID.Text = "UltraCombo4"
        '
        'dt_Dated
        '
        Appearance11.FontData.BoldAsString = "False"
        Appearance11.FontData.ItalicAsString = "False"
        Appearance11.FontData.Name = "Arial"
        Appearance11.FontData.SizeInPoints = 8.25!
        Appearance11.FontData.StrikeoutAsString = "False"
        Appearance11.FontData.UnderlineAsString = "False"
        Me.dt_Dated.Appearance = Appearance11
        Me.dt_Dated.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_Dated.FormatString = "dd/MMM/yy HH:mm tt"
        Me.dt_Dated.Location = New System.Drawing.Point(113, 115)
        Me.dt_Dated.MaskInput = "{date} {time}"
        Me.dt_Dated.Name = "dt_Dated"
        Me.dt_Dated.NullText = "Not Defined"
        Me.dt_Dated.Size = New System.Drawing.Size(200, 21)
        Me.dt_Dated.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.dt_Dated.TabIndex = 247
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.CtlRTFRent)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(548, 276)
        '
        'CtlRTFRent
        '
        Me.CtlRTFRent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlRTFRent.EditEnabled = True
        Me.CtlRTFRent.HTMLText = ""
        Me.CtlRTFRent.LayoutType = "Continuous"
        Me.CtlRTFRent.Location = New System.Drawing.Point(0, 0)
        Me.CtlRTFRent.Name = "CtlRTFRent"
        Me.CtlRTFRent.PlainText = ""
        Me.CtlRTFRent.RTFText = ""
        Me.CtlRTFRent.Size = New System.Drawing.Size(548, 276)
        Me.CtlRTFRent.TabIndex = 267
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnDeleteRent)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 302)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(552, 52)
        Me.Panel4.TabIndex = 254
        '
        'btnDeleteRent
        '
        Appearance12.BackColor = System.Drawing.Color.LightCoral
        Appearance12.FontData.BoldAsString = "True"
        Me.btnDeleteRent.Appearance = Appearance12
        Me.btnDeleteRent.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteRent.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteRent.Name = "btnDeleteRent"
        Me.btnDeleteRent.Size = New System.Drawing.Size(88, 52)
        Me.btnDeleteRent.TabIndex = 13
        Me.btnDeleteRent.Text = "Delete"
        Me.btnDeleteRent.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnSave
        '
        Appearance13.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance13
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(288, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 52)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance14.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance14
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(376, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 52)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance15.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance15
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(464, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 52)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance16.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance16
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(552, 302)
        Me.UltraTabControl1.TabIndex = 255
        Me.UltraTabControl1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowAutoSize
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Details"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Rent"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab5})
        Me.UltraTabControl1.TabsPerRow = 5
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(548, 276)
        '
        'frmRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Rent"
        Me.ClientSize = New System.Drawing.Size(552, 354)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmRent"
        Me.Text = "Rent"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_IsCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PartyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MonthlyRent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AmountRcd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PropertyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_Dated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlRTFRent As ctlRTF
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents cmb_PartyID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_MonthlyRent As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_AmountRcd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_PropertyID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dt_Dated As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnDeleteRent As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_IsCurrent As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
