<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCourtHearing
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_NextHearingDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_CurrentDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_Dated = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlRTFCurrentSatus = New risersoft.[shared].win.ctlRTF()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlRTFNextHearingPurpose = New risersoft.[shared].win.ctlRTF()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDeleteCourtHearing = New Infragistics.Win.Misc.UltraButton()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_CaseNumber = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_CourtName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dt_NextHearingDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CurrentDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_Dated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.txt_CaseNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CourtName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(417, 200)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_CourtName)
        Me.Panel2.Controls.Add(Me.txt_CaseNumber)
        Me.Panel2.Controls.Add(Me.UltraLabel3)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Controls.Add(Me.dt_NextHearingDate)
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Controls.Add(Me.dt_CurrentDate)
        Me.Panel2.Controls.Add(Me.UltraLabel5)
        Me.Panel2.Controls.Add(Me.UltraLabel6)
        Me.Panel2.Controls.Add(Me.dt_Dated)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(417, 200)
        Me.Panel2.TabIndex = 248
        '
        'UltraLabel2
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.Location = New System.Drawing.Point(11, 155)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(114, 18)
        Me.UltraLabel2.TabIndex = 257
        Me.UltraLabel2.Text = "Next Hearing Date"
        '
        'dt_NextHearingDate
        '
        Appearance5.FontData.BoldAsString = "False"
        Appearance5.FontData.ItalicAsString = "False"
        Appearance5.FontData.Name = "Arial"
        Appearance5.FontData.SizeInPoints = 8.25!
        Appearance5.FontData.StrikeoutAsString = "False"
        Appearance5.FontData.UnderlineAsString = "False"
        Me.dt_NextHearingDate.Appearance = Appearance5
        Me.dt_NextHearingDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_NextHearingDate.FormatString = "dd/MMM/yy HH:mm tt"
        Me.dt_NextHearingDate.Location = New System.Drawing.Point(132, 155)
        Me.dt_NextHearingDate.MaskInput = "{date} {time}"
        Me.dt_NextHearingDate.Name = "dt_NextHearingDate"
        Me.dt_NextHearingDate.NullText = "Not Defined"
        Me.dt_NextHearingDate.Size = New System.Drawing.Size(201, 21)
        Me.dt_NextHearingDate.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.dt_NextHearingDate.TabIndex = 256
        '
        'UltraLabel1
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.Location = New System.Drawing.Point(44, 121)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(81, 18)
        Me.UltraLabel1.TabIndex = 255
        Me.UltraLabel1.Text = "Current Date"
        '
        'dt_CurrentDate
        '
        Appearance7.FontData.BoldAsString = "False"
        Appearance7.FontData.ItalicAsString = "False"
        Appearance7.FontData.Name = "Arial"
        Appearance7.FontData.SizeInPoints = 8.25!
        Appearance7.FontData.StrikeoutAsString = "False"
        Appearance7.FontData.UnderlineAsString = "False"
        Me.dt_CurrentDate.Appearance = Appearance7
        Me.dt_CurrentDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_CurrentDate.FormatString = "dd/MMM/yy HH:mm tt"
        Me.dt_CurrentDate.Location = New System.Drawing.Point(133, 121)
        Me.dt_CurrentDate.MaskInput = "{date} {time}"
        Me.dt_CurrentDate.Name = "dt_CurrentDate"
        Me.dt_CurrentDate.NullText = "Not Defined"
        Me.dt_CurrentDate.Size = New System.Drawing.Size(200, 21)
        Me.dt_CurrentDate.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.dt_CurrentDate.TabIndex = 254
        '
        'UltraLabel5
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance8
        Me.UltraLabel5.Location = New System.Drawing.Point(84, 90)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(43, 17)
        Me.UltraLabel5.TabIndex = 253
        Me.UltraLabel5.Text = "Dated"
        '
        'UltraLabel6
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance9
        Me.UltraLabel6.Location = New System.Drawing.Point(28, 57)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(97, 22)
        Me.UltraLabel6.TabIndex = 252
        Me.UltraLabel6.Text = "Court Name"
        '
        'dt_Dated
        '
        Appearance10.FontData.BoldAsString = "False"
        Appearance10.FontData.ItalicAsString = "False"
        Appearance10.FontData.Name = "Arial"
        Appearance10.FontData.SizeInPoints = 8.25!
        Appearance10.FontData.StrikeoutAsString = "False"
        Appearance10.FontData.UnderlineAsString = "False"
        Me.dt_Dated.Appearance = Appearance10
        Me.dt_Dated.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_Dated.FormatString = "dd/MMM/yy HH:mm tt"
        Me.dt_Dated.Location = New System.Drawing.Point(133, 89)
        Me.dt_Dated.MaskInput = "{date} {time}"
        Me.dt_Dated.Name = "dt_Dated"
        Me.dt_Dated.NullText = "Not Defined"
        Me.dt_Dated.Size = New System.Drawing.Size(200, 21)
        Me.dt_Dated.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.dt_Dated.TabIndex = 247
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.CtlRTFCurrentSatus)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(417, 200)
        '
        'CtlRTFCurrentSatus
        '
        Me.CtlRTFCurrentSatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlRTFCurrentSatus.EditEnabled = True
        Me.CtlRTFCurrentSatus.HTMLText = ""
        Me.CtlRTFCurrentSatus.LayoutType = "Continuous"
        Me.CtlRTFCurrentSatus.Location = New System.Drawing.Point(0, 0)
        Me.CtlRTFCurrentSatus.Name = "CtlRTFCurrentSatus"
        Me.CtlRTFCurrentSatus.PlainText = ""
        Me.CtlRTFCurrentSatus.RTFText = ""
        Me.CtlRTFCurrentSatus.Size = New System.Drawing.Size(417, 200)
        Me.CtlRTFCurrentSatus.TabIndex = 267
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.CtlRTFNextHearingPurpose)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(417, 200)
        '
        'CtlRTFNextHearingPurpose
        '
        Me.CtlRTFNextHearingPurpose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlRTFNextHearingPurpose.EditEnabled = True
        Me.CtlRTFNextHearingPurpose.HTMLText = ""
        Me.CtlRTFNextHearingPurpose.LayoutType = "Continuous"
        Me.CtlRTFNextHearingPurpose.Location = New System.Drawing.Point(0, 0)
        Me.CtlRTFNextHearingPurpose.Name = "CtlRTFNextHearingPurpose"
        Me.CtlRTFNextHearingPurpose.PlainText = ""
        Me.CtlRTFNextHearingPurpose.RTFText = ""
        Me.CtlRTFNextHearingPurpose.Size = New System.Drawing.Size(417, 200)
        Me.CtlRTFNextHearingPurpose.TabIndex = 268
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnDeleteCourtHearing)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 226)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(421, 43)
        Me.Panel4.TabIndex = 246
        '
        'btnDeleteCourtHearing
        '
        Appearance11.BackColor = System.Drawing.Color.LightCoral
        Appearance11.FontData.BoldAsString = "True"
        Me.btnDeleteCourtHearing.Appearance = Appearance11
        Me.btnDeleteCourtHearing.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteCourtHearing.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteCourtHearing.Name = "btnDeleteCourtHearing"
        Me.btnDeleteCourtHearing.Size = New System.Drawing.Size(88, 43)
        Me.btnDeleteCourtHearing.TabIndex = 16
        Me.btnDeleteCourtHearing.Text = "Delete"
        Me.btnDeleteCourtHearing.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnSave
        '
        Appearance12.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance12
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(157, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 43)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance13.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance13
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(245, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 43)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance14.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance14
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(333, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 43)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance15.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance15
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(421, 226)
        Me.UltraTabControl1.TabIndex = 256
        Me.UltraTabControl1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowAutoSize
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Details"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Current Status"
        UltraTab1.TabPage = Me.UltraTabPageControl2
        UltraTab1.Text = "Next Hearing Purpose"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab5, UltraTab1})
        Me.UltraTabControl1.TabsPerRow = 5
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(417, 200)
        '
        'UltraLabel3
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance3
        Me.UltraLabel3.Location = New System.Drawing.Point(29, 22)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(99, 22)
        Me.UltraLabel3.TabIndex = 259
        Me.UltraLabel3.Text = "Court Case No."
        '
        'txt_CaseNumber
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.ItalicAsString = "False"
        Appearance2.FontData.Name = "Arial"
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.FontData.StrikeoutAsString = "False"
        Appearance2.FontData.UnderlineAsString = "False"
        Me.txt_CaseNumber.Appearance = Appearance2
        Me.txt_CaseNumber.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_CaseNumber.Location = New System.Drawing.Point(133, 21)
        Me.txt_CaseNumber.Name = "txt_CaseNumber"
        Me.txt_CaseNumber.ReadOnly = True
        Me.txt_CaseNumber.Size = New System.Drawing.Size(199, 21)
        Me.txt_CaseNumber.TabIndex = 260
        '
        'txt_CourtName
        '
        Appearance1.FontData.BoldAsString = "False"
        Appearance1.FontData.ItalicAsString = "False"
        Appearance1.FontData.Name = "Arial"
        Appearance1.FontData.SizeInPoints = 8.25!
        Appearance1.FontData.StrikeoutAsString = "False"
        Appearance1.FontData.UnderlineAsString = "False"
        Me.txt_CourtName.Appearance = Appearance1
        Me.txt_CourtName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_CourtName.Location = New System.Drawing.Point(133, 55)
        Me.txt_CourtName.Name = "txt_CourtName"
        Me.txt_CourtName.ReadOnly = True
        Me.txt_CourtName.Size = New System.Drawing.Size(199, 21)
        Me.txt_CourtName.TabIndex = 261
        '
        'frmCourtHearing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Court Hearing"
        Me.ClientSize = New System.Drawing.Size(421, 269)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmCourtHearing"
        Me.Text = "Court Hearing"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dt_NextHearingDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CurrentDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_Dated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.txt_CaseNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CourtName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlRTFCurrentSatus As ctlRTF
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_Dated As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_CurrentDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_NextHearingDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlRTFNextHearingPurpose As ctlRTF
    Friend WithEvents btnDeleteCourtHearing As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_CourtName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_CaseNumber As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
