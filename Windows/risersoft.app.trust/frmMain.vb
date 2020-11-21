Imports uwd = Infragistics.Win.UltraWinDock
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinToolbars
Imports Infragistics.Win.UltraWinDock
Imports System.ComponentModel
Imports System.Collections.Specialized
Imports System.Web
Imports System.Threading.Tasks
Imports risersoft.shared.portable
Imports risersoft.app.mxent
Imports System.Collections.Generic
Imports System.Linq

Public Class frmMain
    Inherits frmMax
    Protected Friend ctl As ctlViewContainer
    Dim fModel As clsAppBarFilterModel
    Dim dtComp As DataTable
    Public Sub New()
        Me.New(EnumViewMode.acNormalM)
    End Sub

    Public Sub New(ByVal vMode As EnumViewMode)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        initForm(vMode)
    End Sub
    Public Function initForm(ByVal vMode As EnumViewMode) As Boolean

        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)   'For ACAD 2016.
        ctl = New ctlViewContainer With {.fParent = Me}
        Me.Controls.Add(ctl)
        ctl.BringToFront()
        ctl.Dock = DockStyle.Fill
        Me.Text = Me.Controller.Vars("appname")
        Me.Controller.InitBar(Me.BarManager)
        ctl.InitContainer(vMode)
        Return True
    End Function
    Private Sub GenerateCompanyTable(forcefresh As Boolean)
        Dim dt1 = Me.Controller.CommonData.CompanyTable(forcefresh).Copy
        Dim str1 As String = Me.Controller.Data.GenColList(Me.Controller.Data.SelectCols(dt1, "companyid,PanNum,CompName"), "")
        dtComp = Me.Controller.Tables.SelectTable(dt1, Split(str1, ","))
    End Sub
    Protected Friend Async Function CheckAppBarValues() As Task(Of Boolean)
        Me.GenerateCompanyTable(False)

        If dtComp.Select.Length = 0 Then
            Await Me.SelectCompany(0)
        Else
            Await Me.SelectCompany(dtComp.Rows(0)("companyid"))
        End If
        Return True
    End Function
    Public Async Function SelectCompany(CompanyID As Integer) As Task(Of Boolean)
        Dim dic2 As New Dictionary(Of String, Object)(StringComparer.CurrentCultureIgnoreCase) From {{"CID", CompanyID}}
        fModel = Await Me.Controller.DataProvider.GenerateAppBarModel(Me.Controller.GetAppInfo, dic2)
        Me.Controller.GetAppInfo.AppBarValues = fModel.lst2
        myWinApp.Controller.GetAppInfo.AppBarValues = fModel.lst2
        Dim objComp = fModel.lst2.Where(Function(x) myUtils.IsInList(x.FieldName, "companyid")).FirstOrDefault
        If (objComp Is Nothing) OrElse (objComp.dicValues.Count = 0) Then
            Me.UltraFormattedLinkLabel1.Value = String.Format("<font size=""+3""><B>{0}</B></font>  <font size=""+1"">{1}</font>", "Please enter taxpayer master data", "")
        Else
            Me.UltraFormattedLinkLabel1.Value = String.Format("<font size=""+3""><B>{0}</B></font>  <font size=""+1"">{1}</font>", XMLUtils.ReplaceSpecialChars(objComp.dicValues("compname")), objComp.dicValues("pannum"))
        End If
        Return True
    End Function
    Private Async Function HandleToolKey(Optional ByVal strToolKey As String = "DEFAULT") As Task(Of Boolean)

        Dim cont = Await Me.CheckAppBarValues()
        ctl.Visible = False
        Dim result = Await ctl.HandleToolKey(strToolKey)
        ctl.Visible = True

        Return result
    End Function

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If Not myView.myMode = EnumViewMode.acSelectM Then
            If myWinApp.fmCount <= 1 Then
                If MsgBox("Are you sure", MsgBoxStyle.YesNo, Me.Controller.Vars("appname")) = MsgBoxResult.Yes Then
                    Me.Controller.ExitApp()
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not myView.myMode = EnumViewMode.acSelectM Then
            myWinApp.fmCount -= 1
        End If
        ctl.OnClosed()
    End Sub

    Private Async Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not myView.myMode = EnumViewMode.acSelectM Then
            If myView.myState = EnumViewState.acNoView Then
                Await Me.HandleToolKey()
            End If
        End If

    End Sub



    Private Async Sub UltraFormattedLinkLabel1_DoubleClick(sender As Object, e As EventArgs) Handles UltraFormattedLinkLabel1.DoubleClick
        Me.GenerateCompanyTable(True)
        Dim f As New frmGrid
        f.myView.mainGrid.BindView(dtComp.DataSet)
        f.myView.mainGrid.QuickConf("", True, "1-2")
        If f.ShowDialog = DialogResult.OK Then
            Dim CompanyID = myUtils.cValTN(f.myView.mainGrid.ActiveRow.CellValue("companyid"))
            If Await Me.SelectCompany(CompanyID) Then
                Await myView.Refresh(True)
            End If

        End If

    End Sub
End Class
