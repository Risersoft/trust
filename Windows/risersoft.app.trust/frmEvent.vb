Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports risersoft.app.mxform.trust
Imports System.Configuration
Public Class frmEvent
    Inherits frmMax
    Dim ServerPath As String = "", LocalPath As String = ""

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGridMedia)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.GetExtensionName()
    End Sub

    Public Function GetExtensionName()
        Dim FileExtCode = System.IO.Path.GetExtension(myUtils.cStrTN(Me.SaveFileDialog1.FileName))
        Dim FileExt = myWinFtp.FileExtText(FileExtCode)

        'myRow("FileType") = Me.Controller.FTP.FileExtText(FileExt)

        Dim strFilter As String = FileExt & " (*" & FileExtCode & ")|*" & FileExtCode
        Me.SaveFileDialog1.Filter = strFilter

    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmEventModel = Me.InitData("frmEventModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then

            InitUpLoad()
            Me.CtlRTFDescription.HTMLText = myUtils.cStrTN(myRow("DescriptionHTML"))
            Me.CtlRTFPurpose.HTMLText = myUtils.cStrTN(myRow("PurposeHTML"))

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "EventType", "", Me.cmb_EventType)
            myWinSQL.AssignCmb(Me.dsCombo, "Company", "", Me.cmb_CompanyID)
            myWinSQL.AssignCmb(Me.dsCombo, "FinYear", "", Me.cmb_FinYearID)
            myView.PrepEdit(Me.Model.GridViews("Media"))

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        myRow("DescriptionHTML") = Me.CtlRTFDescription.HTMLText
        myRow("DescriptionText") = Me.CtlRTFDescription.PlainText
        myRow("PurposeHTML") = Me.CtlRTFPurpose.HTMLText
        myRow("PurposeText") = Me.CtlRTFPurpose.PlainText
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnAddVideo_Click(sender As Object, e As EventArgs) Handles btnAddVideo.Click
        Dim f As New frmMediaDetail
        f.fMat = Me
        If f.PrepForm(myView, EnumfrmMode.acAddM, "", "") Then
            f.myRow("uploadtype") = "Video"
            f.ShowDialog()
        End If
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        Dim f As New frmMediaDetail
        f.fMat = Me
        If f.PrepForm(Me.myView, EnumfrmMode.acAddM, "") Then
            f.myRow("uploadtype") = "Image"
            f.ShowDialog()

        End If
    End Sub

    Private Function InitUpLoad()
        Dim str1 As String = ""
        str1 = "XLS File|*.xls|XLSX File|*.xlsx|Word Document(.doc)|*.doc|Word XML Document (.docx)|*.docx|Rich Text File (*.rtf)|*.rtf|Portable Document File(.pdf)|*.pdf|Joint Photographic Experts Group(.jpg)|*.jpg|All Files(*.*)|*.*"

        Me.CtlUpLoad2.InitFilter(EnumfrmMode.acEditM, "", Me.Controller.App.objAppExtender.FileServerPath, "", str1, ConfigurationManager.AppSettings("StorageContainerName"))
        AddHandler Me.CtlUpLoad2.FileSelected, Sub(SelectedFile As String)
                                                   LocalPath = SelectedFile
                                                   Dim UniqueFileId = System.Guid.NewGuid.ToString
                                                   Me.CtlUpLoad2.FileName = System.IO.Path.GetFileNameWithoutExtension(SelectedFile) & "-" & UniqueFileId & System.IO.Path.GetExtension(SelectedFile)
                                               End Sub
        AddHandler Me.CtlUpLoad2.FileUploaded, Sub(ByVal localFile As String, ServerPath As String)
                                                   Me.ServerPath = ServerPath
                                                   myRow("Brochure") = Me.CtlUpLoad2.FileName
                                               End Sub
        Return True
    End Function

End Class