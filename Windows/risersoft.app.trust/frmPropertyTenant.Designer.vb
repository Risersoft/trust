<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPropertyTenant
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDeleteProperty = New Infragistics.Win.Misc.UltraButton()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_IsCurrent = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.Party = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_PartyID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_PropertyID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_IsCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PartyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PropertyID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnDeleteProperty)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 167)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(466, 54)
        Me.Panel4.TabIndex = 251
        '
        'btnDeleteProperty
        '
        Appearance1.BackColor = System.Drawing.Color.LightCoral
        Appearance1.FontData.BoldAsString = "True"
        Me.btnDeleteProperty.Appearance = Appearance1
        Me.btnDeleteProperty.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteProperty.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteProperty.Name = "btnDeleteProperty"
        Me.btnDeleteProperty.Size = New System.Drawing.Size(88, 54)
        Me.btnDeleteProperty.TabIndex = 13
        Me.btnDeleteProperty.Text = "Delete"
        Me.btnDeleteProperty.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnSave
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance2
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(202, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 54)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(290, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 54)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(378, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 54)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_IsCurrent)
        Me.Panel1.Controls.Add(Me.UltraLabel11)
        Me.Panel1.Controls.Add(Me.Party)
        Me.Panel1.Controls.Add(Me.cmb_PartyID)
        Me.Panel1.Controls.Add(Me.UltraLabel7)
        Me.Panel1.Controls.Add(Me.txt_Remark)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.cmb_PropertyID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 167)
        Me.Panel1.TabIndex = 253
        '
        'cmb_IsCurrent
        '
        Me.cmb_IsCurrent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_IsCurrent.Location = New System.Drawing.Point(132, 93)
        Me.cmb_IsCurrent.Name = "cmb_IsCurrent"
        Me.cmb_IsCurrent.Size = New System.Drawing.Size(105, 21)
        Me.cmb_IsCurrent.TabIndex = 267
        Me.cmb_IsCurrent.Text = "UltraComboEditor1"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(73, 95)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel11.TabIndex = 266
        Me.UltraLabel11.Text = "Current"
        '
        'Party
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.Party.Appearance = Appearance5
        Me.Party.Location = New System.Drawing.Point(56, 62)
        Me.Party.Name = "Party"
        Me.Party.Size = New System.Drawing.Size(60, 20)
        Me.Party.TabIndex = 265
        Me.Party.Text = "Party"
        '
        'cmb_PartyID
        '
        Me.cmb_PartyID.Location = New System.Drawing.Point(132, 59)
        Me.cmb_PartyID.Name = "cmb_PartyID"
        Me.cmb_PartyID.Size = New System.Drawing.Size(266, 22)
        Me.cmb_PartyID.TabIndex = 264
        Me.cmb_PartyID.Text = "UltraCombo4"
        '
        'UltraLabel7
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance6
        Me.UltraLabel7.Location = New System.Drawing.Point(56, 128)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(58, 20)
        Me.UltraLabel7.TabIndex = 263
        Me.UltraLabel7.Text = "Remark"
        '
        'txt_Remark
        '
        Appearance7.FontData.BoldAsString = "False"
        Appearance7.FontData.ItalicAsString = "False"
        Appearance7.FontData.Name = "Arial"
        Appearance7.FontData.SizeInPoints = 8.25!
        Appearance7.FontData.StrikeoutAsString = "False"
        Appearance7.FontData.UnderlineAsString = "False"
        Me.txt_Remark.Appearance = Appearance7
        Me.txt_Remark.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Remark.Location = New System.Drawing.Point(130, 128)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(312, 21)
        Me.txt_Remark.TabIndex = 262
        '
        'UltraLabel1
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance8
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 26)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(113, 20)
        Me.UltraLabel1.TabIndex = 252
        Me.UltraLabel1.Text = "Property Shop No."
        '
        'cmb_PropertyID
        '
        Me.cmb_PropertyID.Location = New System.Drawing.Point(131, 23)
        Me.cmb_PropertyID.Name = "cmb_PropertyID"
        Me.cmb_PropertyID.ReadOnly = True
        Me.cmb_PropertyID.Size = New System.Drawing.Size(266, 22)
        Me.cmb_PropertyID.TabIndex = 249
        Me.cmb_PropertyID.Text = "UltraCombo4"
        '
        'frmPropertyTenant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Property Tenant"
        Me.ClientSize = New System.Drawing.Size(466, 221)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmPropertyTenant"
        Me.Text = "Property Tenant"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_IsCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PartyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PropertyID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents btnDeleteProperty As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_PropertyID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Party As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_PartyID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_IsCurrent As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
