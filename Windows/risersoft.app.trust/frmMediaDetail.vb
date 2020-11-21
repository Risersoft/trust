Imports System.Configuration
Imports risersoft.shared.dotnetfx
Public Class frmMediaDetail
    Inherits frmMax
    Friend fMat As frmEvent
    Dim ServerPath As String = "", LocalPath As String = ""

    Private Sub InitForm()

    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        If Not fMat Is Nothing Then
            Me.cmb_UploadType.ValueList = fMat.Model.ValueLists("UploadType").ComboList
        End If

        If Me.GetSoftData(oView, prepMode, prepIdx) Then
            InitUpLoad()
            PrepForm = True
        End If

    End Function

    Private Function InitUpLoad()
        Dim str1 As String = ""
        str1 = "XLS File|*.xls|XLSX File|*.xlsx|Word Document(.doc)|*.doc|Word XML Document (.docx)|*.docx|Rich Text File (*.rtf)|*.rtf|Portable Document File(.pdf)|*.pdf"

        Me.CtlUpLoad2.InitFilter(EnumfrmMode.acEditM, "", Me.Controller.App.objAppExtender.FileServerPath, "", str1, ConfigurationManager.AppSettings("StorageContainerName"))
        AddHandler Me.CtlUpLoad2.FileSelected, Sub(SelectedFile As String)
                                                   LocalPath = SelectedFile
                                                   Dim UniqueFileId = System.Guid.NewGuid.ToString
                                                   Me.CtlUpLoad2.FileName = System.IO.Path.GetFileNameWithoutExtension(SelectedFile) & "-" & UniqueFileId & System.IO.Path.GetExtension(SelectedFile)
                                               End Sub
        AddHandler Me.CtlUpLoad2.FileUploaded, Sub(ByVal localFile As String, ServerPath As String)
                                                   Me.ServerPath = ServerPath
                                                   myRow("URL") = Me.CtlUpLoad2.FileName
                                               End Sub
        Return True
    End Function

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click, btnCancel.Click
        Me.InitError()
        If Me.CanSave Then
            cm.EndCurrentEdit()
            Me.SaveSoftData()
        End If
    End Sub

End Class
