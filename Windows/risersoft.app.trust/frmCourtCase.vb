Imports risersoft.app.mxform.trust

Public Class frmCourtCase
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmCourtCaseModel = Me.InitData("frmCourtCaseModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then

            Me.CtlRTFCourtCase.HTMLText = myUtils.cStrTN(myRow("CourtCaseHTML"))

        End If
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_PartyID)
            myWinSQL.AssignCmb(Me.dsCombo, "Property", "", Me.cmb_PropertyID)
            myWinSQL.AssignCmb(Me.dsCombo, "OurLawyer", "", Me.cmb_OurLawyerPersonID)
            myWinSQL.AssignCmb(Me.dsCombo, "OppositeLawyer", "", Me.cmb_OppositeLawyerPersonID)

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            myRow("CourtCaseHTML") = Me.CtlRTFCourtCase.HTMLText
            myRow("CourtCaseText") = Me.CtlRTFCourtCase.PlainText
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

    Private Sub btnDeleteCourtCase_Click(sender As Object, e As EventArgs) Handles btnDeleteCourtCase.Click
        Dim oRet = Me.DeleteEntity("courtcase", frmIDX, False)
        If oRet.ErrorCount > 0 Then
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        Else
            If MsgBox(oRet.Message, MsgBoxStyle.YesNo + MsgBoxStyle.Question, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                oRet = Me.DeleteEntity("courtcase", frmIDX, True)
                If oRet.Success Then WinFormUtils.ButtonAction(Me, "btnCancel")
            End If
        End If
    End Sub

End Class