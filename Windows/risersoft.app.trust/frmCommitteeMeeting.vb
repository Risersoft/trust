Imports risersoft.app.mxform.trust
Imports System.Configuration
Public Class frmCommitteeMeeting
    Inherits frmMax
    Private Sub InitForm()
        myView.SetGrid(Me.UltraGridPerson)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmCommitteeMeetingModel = Me.InitData("frmCommitteeMeetingModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then

            myWinSQL.AssignCmb(Me.dsCombo, "Committee", "", Me.cmb_CommitteeID)

            Me.CtlRTFAgenda.HTMLText = myUtils.cStrTN(myRow("Agendahtml"))
            Me.CtlRTFMinutes.HTMLText = myUtils.cStrTN(myRow("Minuteshtml"))

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Persons"),, btnDeletePersons)

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            myRow("Agendahtml") = Me.CtlRTFAgenda.HTMLText
            myRow("Agendatext") = Me.CtlRTFAgenda.PlainText
            myRow("Minuteshtml") = Me.CtlRTFMinutes.HTMLText
            myRow("Minutestext") = Me.CtlRTFMinutes.PlainText
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnAddPersons_Click(sender As Object, e As EventArgs) Handles btnAddPersons.Click
        If Me.frmMode = EnumfrmMode.acEditM Then
            Dim Params As New List(Of clsSQLParam)
            Dim str1 As String = myUtils.MakeCSV(myView.mainGrid.myDS.Tables(0).Select, "PersonID")
            Params.Add(New clsSQLParam("@PersonIDcsv", str1, GetType(Integer), True))
            Params.Add(New clsSQLParam("@CommitteeID", myUtils.cValTN(Me.cmb_CommitteeID.Value), GetType(Integer), True))
            Dim rr() As DataRow = Me.AdvancedSelect("persons", Params)
            If Not IsNothing(rr) Then
                For Each r1 As DataRow In rr
                    Dim r2 As DataRow = myUtils.CopyOneRow(r1, myView.mainGrid.myDS.Tables(0))
                Next
            End If
        Else
            MsgBox("You need to save first before Add Persons...", MsgBoxStyle.Information, myWinApp.Vars("AppName"))
        End If
    End Sub

    Private Sub btnDeleteCommitteeMeet_Click(sender As Object, e As EventArgs) Handles btnDeleteCommitteeMeet.Click
        Dim oRet = Me.DeleteEntity("committeemeet", frmIDX, False)
        If oRet.ErrorCount > 0 Then
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        Else
            If MsgBox(oRet.Message, MsgBoxStyle.YesNo + MsgBoxStyle.Question, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                oRet = Me.DeleteEntity("committeemeet", frmIDX, True)
                If oRet.Success Then WinFormUtils.ButtonAction(Me, "btnCancel")
            End If
        End If
    End Sub

End Class