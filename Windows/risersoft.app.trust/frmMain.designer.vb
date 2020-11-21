Imports Infragistics.Win.UltraWinDock
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits frmMax


#Region " Windows Form Designer generated code "



    'Form overrides dispose to clean up the component list.
    'Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    '    If disposing Then
    '        If Not (components Is Nothing) Then
    '            components.Dispose()
    '        End If
    '    End If
    '    MyBase.Dispose(disposing)
    'End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents _frmMain_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmMain_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmMain_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmMain_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("mnuMain")
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("mnuTool")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("File")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim PopupMenuTool2 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupMenuTool1")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("File")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.BarManager = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._frmMain_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmMain_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmMain_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frmMain_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.DockableWindow12 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraFormattedLinkLabel1 = New Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel()
        Me.UltraPictureBox1 = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarManager
        '
        Me.BarManager.AlphaBlendMode = Infragistics.Win.AlphaBlendMode.Disabled
        Me.BarManager.DesignerFlags = 1
        Me.BarManager.DockWithinContainer = Me
        Me.BarManager.DockWithinContainerBaseType = GetType(risersoft.[shared].win.frmMax)
        Me.BarManager.FormDisplayStyle = Infragistics.Win.UltraWinToolbars.FormDisplayStyle.RoundedSizable
        Me.BarManager.ShowFullMenusDelay = 500
        Me.BarManager.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.VisualStudio2005
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.Text = "mnuMain"
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 1
        UltraToolbar2.Text = "mnuTool"
        Me.BarManager.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1, UltraToolbar2})
        ButtonTool2.SharedPropsInternal.Caption = "File"
        ButtonTool2.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        ButtonTool5.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool6.SharedPropsInternal.Caption = "ButtonTool2"
        PopupMenuTool2.SharedPropsInternal.Caption = "PopupMenuTool1"
        PopupMenuTool2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool10, ButtonTool8, ButtonTool7})
        Me.BarManager.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool2, ButtonTool5, ButtonTool6, PopupMenuTool2})
        '
        '_frmMain_Toolbars_Dock_Area_Left
        '
        Me._frmMain_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMain_Toolbars_Dock_Area_Left.AlphaBlendMode = Infragistics.Win.AlphaBlendMode.Disabled
        Me._frmMain_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me._frmMain_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmMain_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMain_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 8
        Me._frmMain_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 74)
        Me._frmMain_Toolbars_Dock_Area_Left.Name = "_frmMain_Toolbars_Dock_Area_Left"
        Me._frmMain_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(8, 381)
        Me._frmMain_Toolbars_Dock_Area_Left.ToolbarsManager = Me.BarManager
        '
        '_frmMain_Toolbars_Dock_Area_Right
        '
        Me._frmMain_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMain_Toolbars_Dock_Area_Right.AlphaBlendMode = Infragistics.Win.AlphaBlendMode.Disabled
        Me._frmMain_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me._frmMain_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmMain_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMain_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 8
        Me._frmMain_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(711, 74)
        Me._frmMain_Toolbars_Dock_Area_Right.Name = "_frmMain_Toolbars_Dock_Area_Right"
        Me._frmMain_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(8, 381)
        Me._frmMain_Toolbars_Dock_Area_Right.ToolbarsManager = Me.BarManager
        '
        '_frmMain_Toolbars_Dock_Area_Top
        '
        Me._frmMain_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMain_Toolbars_Dock_Area_Top.AlphaBlendMode = Infragistics.Win.AlphaBlendMode.Disabled
        Me._frmMain_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me._frmMain_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmMain_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMain_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmMain_Toolbars_Dock_Area_Top.Name = "_frmMain_Toolbars_Dock_Area_Top"
        Me._frmMain_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(719, 74)
        Me._frmMain_Toolbars_Dock_Area_Top.ToolbarsManager = Me.BarManager
        '
        '_frmMain_Toolbars_Dock_Area_Bottom
        '
        Me._frmMain_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMain_Toolbars_Dock_Area_Bottom.AlphaBlendMode = Infragistics.Win.AlphaBlendMode.Disabled
        Me._frmMain_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(215, Byte), Integer))
        Me._frmMain_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmMain_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMain_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent = 8
        Me._frmMain_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 455)
        Me._frmMain_Toolbars_Dock_Area_Bottom.Name = "_frmMain_Toolbars_Dock_Area_Bottom"
        Me._frmMain_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(719, 8)
        Me._frmMain_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.BarManager
        '
        'DockableWindow12
        '
        Me.DockableWindow12.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow12.Name = "DockableWindow12"
        Me.DockableWindow12.Size = New System.Drawing.Size(0, 0)
        Me.DockableWindow12.TabIndex = 164
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraFormattedLinkLabel1)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraPictureBox1)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel1.Location = New System.Drawing.Point(8, 74)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(703, 38)
        Me.UltraPanel1.TabIndex = 169
        '
        'UltraFormattedLinkLabel1
        '
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraFormattedLinkLabel1.Appearance = Appearance1
        Me.UltraFormattedLinkLabel1.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraFormattedLinkLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraFormattedLinkLabel1.Location = New System.Drawing.Point(160, 0)
        Me.UltraFormattedLinkLabel1.Name = "UltraFormattedLinkLabel1"
        Me.UltraFormattedLinkLabel1.Size = New System.Drawing.Size(543, 38)
        Me.UltraFormattedLinkLabel1.TabIndex = 1
        Me.UltraFormattedLinkLabel1.TabStop = True
        Me.UltraFormattedLinkLabel1.Value = "Test Company Ltd. AAAXXJNUI"
        '
        'UltraPictureBox1
        '
        Me.UltraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraPictureBox1.Image = CType(resources.GetObject("UltraPictureBox1.Image"), Object)
        Me.UltraPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPictureBox1.Name = "UltraPictureBox1"
        Me.UltraPictureBox1.Size = New System.Drawing.Size(160, 38)
        Me.UltraPictureBox1.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "frmMain"
        Me.ClientSize = New System.Drawing.Size(719, 463)
        Me.Controls.Add(Me.UltraPanel1)
        Me.Controls.Add(Me.DockableWindow12)
        Me.Controls.Add(Me._frmMain_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmMain_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmMain_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._frmMain_Toolbars_Dock_Area_Top)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents DockableWindow12 As DockableWindow
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraFormattedLinkLabel1 As Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel
    Friend WithEvents UltraPictureBox1 As Infragistics.Win.UltraWinEditors.UltraPictureBox

#End Region
End Class

