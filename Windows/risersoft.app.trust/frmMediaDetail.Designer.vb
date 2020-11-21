<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMediaDetail
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOk = New Infragistics.Win.Misc.UltraButton()
        Me.CtlUpLoad2 = New risersoft.[shared].win.ctlUpLoad()
        Me.cmb_UploadType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel6.SuspendLayout()
        CType(Me.cmb_UploadType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnCancel)
        Me.Panel6.Controls.Add(Me.btnOk)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 188)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(530, 50)
        Me.Panel6.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(386, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 50)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOk.Location = New System.Drawing.Point(458, 0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(72, 50)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        '
        'CtlUpLoad2
        '
        Me.CtlUpLoad2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad2.Location = New System.Drawing.Point(17, 67)
        Me.CtlUpLoad2.Name = "CtlUpLoad2"
        Me.CtlUpLoad2.Size = New System.Drawing.Size(487, 102)
        Me.CtlUpLoad2.TabIndex = 227
        '
        'cmb_UploadType
        '
        Me.cmb_UploadType.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValueListItem1.DataValue = False
        ValueListItem1.DisplayText = "Normal"
        ValueListItem2.DataValue = True
        ValueListItem2.DisplayText = "Casual"
        Me.cmb_UploadType.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.cmb_UploadType.Location = New System.Drawing.Point(93, 24)
        Me.cmb_UploadType.Name = "cmb_UploadType"
        Me.cmb_UploadType.ReadOnly = True
        Me.cmb_UploadType.Size = New System.Drawing.Size(221, 21)
        Me.cmb_UploadType.TabIndex = 226
        Me.cmb_UploadType.Text = "UltraComboEditor9"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(24, 24)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel3.TabIndex = 225
        Me.UltraLabel3.Text = "Media Type"
        '
        'frmMediaDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 238)
        Me.Controls.Add(Me.CtlUpLoad2)
        Me.Controls.Add(Me.cmb_UploadType)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "frmMediaDetail"
        Me.Text = "Media Detail"
        Me.Panel6.ResumeLayout(False)
        CType(Me.cmb_UploadType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Windows.Forms.Panel
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOk As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CtlUpLoad2 As ctlUpLoad
    Friend WithEvents cmb_UploadType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
End Class
