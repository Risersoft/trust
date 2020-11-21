<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLandDetail
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
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_FavourOf = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_SaleDeedDetail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_PurchasedFrom = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Area = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_KhasraNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_CompanyID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.dt_SaleDeedDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDeleteLandDetail = New Infragistics.Win.Misc.UltraButton()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FavourOf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SaleDeedDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PurchasedFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Area, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_KhasraNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CompanyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_SaleDeedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraLabel7)
        Me.Panel1.Controls.Add(Me.txt_Remark)
        Me.Panel1.Controls.Add(Me.UltraLabel6)
        Me.Panel1.Controls.Add(Me.txt_FavourOf)
        Me.Panel1.Controls.Add(Me.UltraLabel5)
        Me.Panel1.Controls.Add(Me.txt_SaleDeedDetail)
        Me.Panel1.Controls.Add(Me.UltraLabel4)
        Me.Panel1.Controls.Add(Me.txt_PurchasedFrom)
        Me.Panel1.Controls.Add(Me.UltraLabel3)
        Me.Panel1.Controls.Add(Me.txt_Area)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.UltraLabel9)
        Me.Panel1.Controls.Add(Me.txt_KhasraNum)
        Me.Panel1.Controls.Add(Me.cmb_CompanyID)
        Me.Panel1.Controls.Add(Me.dt_SaleDeedDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 285)
        Me.Panel1.TabIndex = 249
        '
        'UltraLabel7
        '
        Appearance20.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance20
        Me.UltraLabel7.Location = New System.Drawing.Point(21, 243)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(84, 18)
        Me.UltraLabel7.TabIndex = 263
        Me.UltraLabel7.Text = "Remark"
        '
        'txt_Remark
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.ItalicAsString = "False"
        Appearance2.FontData.Name = "Arial"
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.FontData.StrikeoutAsString = "False"
        Appearance2.FontData.UnderlineAsString = "False"
        Me.txt_Remark.Appearance = Appearance2
        Me.txt_Remark.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Remark.Location = New System.Drawing.Point(111, 243)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(374, 21)
        Me.txt_Remark.TabIndex = 262
        '
        'UltraLabel6
        '
        Appearance21.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance21
        Me.UltraLabel6.Location = New System.Drawing.Point(22, 212)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(84, 18)
        Me.UltraLabel6.TabIndex = 261
        Me.UltraLabel6.Text = "Favour Of"
        '
        'txt_FavourOf
        '
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.ItalicAsString = "False"
        Appearance4.FontData.Name = "Arial"
        Appearance4.FontData.SizeInPoints = 8.25!
        Appearance4.FontData.StrikeoutAsString = "False"
        Appearance4.FontData.UnderlineAsString = "False"
        Me.txt_FavourOf.Appearance = Appearance4
        Me.txt_FavourOf.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_FavourOf.Location = New System.Drawing.Point(112, 212)
        Me.txt_FavourOf.Name = "txt_FavourOf"
        Me.txt_FavourOf.Size = New System.Drawing.Size(311, 21)
        Me.txt_FavourOf.TabIndex = 260
        '
        'UltraLabel5
        '
        Appearance22.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance22
        Me.UltraLabel5.Location = New System.Drawing.Point(12, 180)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(94, 18)
        Me.UltraLabel5.TabIndex = 259
        Me.UltraLabel5.Text = "SaleDeed Detail"
        '
        'txt_SaleDeedDetail
        '
        Appearance6.FontData.BoldAsString = "False"
        Appearance6.FontData.ItalicAsString = "False"
        Appearance6.FontData.Name = "Arial"
        Appearance6.FontData.SizeInPoints = 8.25!
        Appearance6.FontData.StrikeoutAsString = "False"
        Appearance6.FontData.UnderlineAsString = "False"
        Me.txt_SaleDeedDetail.Appearance = Appearance6
        Me.txt_SaleDeedDetail.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_SaleDeedDetail.Location = New System.Drawing.Point(112, 180)
        Me.txt_SaleDeedDetail.Name = "txt_SaleDeedDetail"
        Me.txt_SaleDeedDetail.Size = New System.Drawing.Size(311, 21)
        Me.txt_SaleDeedDetail.TabIndex = 258
        '
        'UltraLabel4
        '
        Appearance23.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance23
        Me.UltraLabel4.Location = New System.Drawing.Point(12, 146)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(94, 18)
        Me.UltraLabel4.TabIndex = 257
        Me.UltraLabel4.Text = "Purchased From"
        '
        'txt_PurchasedFrom
        '
        Appearance8.FontData.BoldAsString = "False"
        Appearance8.FontData.ItalicAsString = "False"
        Appearance8.FontData.Name = "Arial"
        Appearance8.FontData.SizeInPoints = 8.25!
        Appearance8.FontData.StrikeoutAsString = "False"
        Appearance8.FontData.UnderlineAsString = "False"
        Me.txt_PurchasedFrom.Appearance = Appearance8
        Me.txt_PurchasedFrom.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_PurchasedFrom.Location = New System.Drawing.Point(112, 146)
        Me.txt_PurchasedFrom.Name = "txt_PurchasedFrom"
        Me.txt_PurchasedFrom.Size = New System.Drawing.Size(311, 21)
        Me.txt_PurchasedFrom.TabIndex = 256
        '
        'UltraLabel3
        '
        Appearance24.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance24
        Me.UltraLabel3.Location = New System.Drawing.Point(36, 82)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(63, 18)
        Me.UltraLabel3.TabIndex = 255
        Me.UltraLabel3.Text = "Area"
        '
        'txt_Area
        '
        Appearance10.FontData.BoldAsString = "False"
        Appearance10.FontData.ItalicAsString = "False"
        Appearance10.FontData.Name = "Arial"
        Appearance10.FontData.SizeInPoints = 8.25!
        Appearance10.FontData.StrikeoutAsString = "False"
        Appearance10.FontData.UnderlineAsString = "False"
        Me.txt_Area.Appearance = Appearance10
        Me.txt_Area.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Area.Location = New System.Drawing.Point(111, 82)
        Me.txt_Area.Name = "txt_Area"
        Me.txt_Area.Size = New System.Drawing.Size(312, 21)
        Me.txt_Area.TabIndex = 254
        '
        'UltraLabel2
        '
        Appearance25.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance25
        Me.UltraLabel2.Location = New System.Drawing.Point(19, 115)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(81, 18)
        Me.UltraLabel2.TabIndex = 253
        Me.UltraLabel2.Text = "SaleDeed Date"
        '
        'UltraLabel1
        '
        Appearance26.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance26
        Me.UltraLabel1.Location = New System.Drawing.Point(36, 20)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(58, 22)
        Me.UltraLabel1.TabIndex = 252
        Me.UltraLabel1.Text = "Trust"
        '
        'UltraLabel9
        '
        Appearance27.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance27
        Me.UltraLabel9.Location = New System.Drawing.Point(22, 51)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(76, 18)
        Me.UltraLabel9.TabIndex = 251
        Me.UltraLabel9.Text = "Khasra Num"
        '
        'txt_KhasraNum
        '
        Appearance14.FontData.BoldAsString = "False"
        Appearance14.FontData.ItalicAsString = "False"
        Appearance14.FontData.Name = "Arial"
        Appearance14.FontData.SizeInPoints = 8.25!
        Appearance14.FontData.StrikeoutAsString = "False"
        Appearance14.FontData.UnderlineAsString = "False"
        Me.txt_KhasraNum.Appearance = Appearance14
        Me.txt_KhasraNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_KhasraNum.Location = New System.Drawing.Point(111, 51)
        Me.txt_KhasraNum.Name = "txt_KhasraNum"
        Me.txt_KhasraNum.Size = New System.Drawing.Size(196, 21)
        Me.txt_KhasraNum.TabIndex = 250
        '
        'cmb_CompanyID
        '
        Me.cmb_CompanyID.Location = New System.Drawing.Point(111, 18)
        Me.cmb_CompanyID.Name = "cmb_CompanyID"
        Me.cmb_CompanyID.ReadOnly = True
        Me.cmb_CompanyID.Size = New System.Drawing.Size(266, 22)
        Me.cmb_CompanyID.TabIndex = 249
        Me.cmb_CompanyID.Text = "UltraCombo4"
        '
        'dt_SaleDeedDate
        '
        Appearance28.FontData.BoldAsString = "False"
        Appearance28.FontData.ItalicAsString = "False"
        Appearance28.FontData.Name = "Arial"
        Appearance28.FontData.SizeInPoints = 8.25!
        Appearance28.FontData.StrikeoutAsString = "False"
        Appearance28.FontData.UnderlineAsString = "False"
        Me.dt_SaleDeedDate.Appearance = Appearance28
        Me.dt_SaleDeedDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_SaleDeedDate.FormatString = "dd/MMM/yy HH:mm tt"
        Me.dt_SaleDeedDate.Location = New System.Drawing.Point(112, 114)
        Me.dt_SaleDeedDate.MaskInput = "{date} {time}"
        Me.dt_SaleDeedDate.Name = "dt_SaleDeedDate"
        Me.dt_SaleDeedDate.NullText = "Not Defined"
        Me.dt_SaleDeedDate.Size = New System.Drawing.Size(200, 21)
        Me.dt_SaleDeedDate.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.dt_SaleDeedDate.TabIndex = 247
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnDeleteLandDetail)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 285)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(497, 46)
        Me.Panel4.TabIndex = 248
        '
        'btnDeleteLandDetail
        '
        Appearance29.BackColor = System.Drawing.Color.LightCoral
        Appearance29.FontData.BoldAsString = "True"
        Me.btnDeleteLandDetail.Appearance = Appearance29
        Me.btnDeleteLandDetail.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteLandDetail.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteLandDetail.Name = "btnDeleteLandDetail"
        Me.btnDeleteLandDetail.Size = New System.Drawing.Size(88, 46)
        Me.btnDeleteLandDetail.TabIndex = 13
        Me.btnDeleteLandDetail.Text = "Delete"
        Me.btnDeleteLandDetail.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnSave
        '
        Appearance30.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance30
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(233, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 46)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance31.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance31
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(321, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 46)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance32.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance32
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(409, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 46)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'frmLandDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Land Detail"
        Me.ClientSize = New System.Drawing.Size(497, 331)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmLandDetail"
        Me.Text = "Land Detail"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FavourOf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SaleDeedDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PurchasedFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Area, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_KhasraNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CompanyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_SaleDeedDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_KhasraNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_CompanyID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dt_SaleDeedDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Area As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PurchasedFrom As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_FavourOf As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_SaleDeedDetail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnDeleteLandDetail As Infragistics.Win.Misc.UltraButton
End Class
