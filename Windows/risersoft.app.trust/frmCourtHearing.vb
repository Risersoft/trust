Imports risersoft.app.mxform.trust
Public Class frmCourtHearing
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmCourtHearingModel = Me.InitData("frmCourtHearingModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then

            Me.CtlRTFCurrentSatus.HTMLText = myUtils.cStrTN(myRow("CurrentSatusHTML"))
            Me.CtlRTFNextHearingPurpose.HTMLText = myUtils.cStrTN(myRow("NextHearingPurposeHTML"))

        End If
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            Dim dt As DataTable = Me.Model.DatasetCollection("CC").Tables("CourtCase")
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                Me.txt_CaseNumber.Text = myUtils.cStrTN(dt.Rows(0)("CaseNumber"))
                Me.txt_CourtName.Text = myUtils.cStrTN(dt.Rows(0)("CourtName"))
            End If

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            myRow("CurrentSatusHTML") = Me.CtlRTFCurrentSatus.HTMLText
            myRow("CurrentSatusText") = Me.CtlRTFCurrentSatus.PlainText
            myRow("NextHearingPurposeHTML") = Me.CtlRTFNextHearingPurpose.HTMLText
            myRow("NextHearingPurposeText") = Me.CtlRTFNextHearingPurpose.PlainText
            If Me.CanSave() Then
                If Me.SaveModel() Then
                    Return True
                End If
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnDeleteCourtHearing_Click(sender As Object, e As EventArgs) Handles btnDeleteCourtHearing.Click
        Dim oRet = Me.DeleteEntity("courthearing", frmIDX, False)
        If oRet.ErrorCount > 0 Then
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        Else
            If MsgBox(oRet.Message, MsgBoxStyle.YesNo + MsgBoxStyle.Question, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                oRet = Me.DeleteEntity("courthearing", frmIDX, True)
                If oRet.Success Then WinFormUtils.ButtonAction(Me, "btnCancel")
            End If
        End If
    End Sub

End Class
