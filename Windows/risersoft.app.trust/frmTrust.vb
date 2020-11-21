Imports risersoft.app.mxform.trust
Imports System.Configuration
Public Class frmTrust
    Inherits frmMax
    Dim ServerPath As String = "", LocalPath As String = ""
    Dim dvState As DataView

    Private Sub InitForm()
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
        Dim objModel As frmTrustModel = Me.InitData("frmTrustModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then

            InitUpLoad()
            Me.CtlRTFMessage.HTMLText = myUtils.cStrTN(myRow("PrincipalMessageHTML"))

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myWinSQL.AssignCmb(Me.dsCombo, "PrincipalPerson", "", Me.cmb_PrincipalPersonID)
            myWinSQL.AssignCmb(Me.dsCombo, "CO", "", Me.cmb_Country, "<STRWIDTH>0-0-1-3</STRWIDTH>")
            dvState = myWinSQL.AssignCmb(Me.dsCombo, "SU", "", Me.cmb_State, "<STRWIDTH>0-0-0-1-3</STRWIDTH>", 2)
            dvState.RowFilter = ""

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        myRow("PrincipalMessageHTML") = Me.CtlRTFMessage.HTMLText
        myRow("PrincipalMessageText") = Me.CtlRTFMessage.PlainText
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub cmb_Country_ValueChanged(sender As Object, e As EventArgs) Handles cmb_Country.ValueChanged
        If Me.FormPrepared Then
            Dim str1 As String = ""
            If Not Me.cmb_Country.SelectedRow Is Nothing Then str1 = Me.cmb_Country.SelectedRow.Cells("countrycode").Value
            dvState.RowFilter = "countrycode='" & str1 & "'"
        End If
    End Sub

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
                                                   'myRow("FileURL") = ServerPath
                                                   myRow("URL") = Me.CtlUpLoad2.FileName
                                               End Sub
        Return True
    End Function

End Class
