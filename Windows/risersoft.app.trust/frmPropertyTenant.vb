﻿Imports risersoft.app.mxform.trust
Imports risersoft.shared.dotnetfx

Public Class frmPropertyTenant
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPropertyTenantModel = Me.InitData("frmPropertyTenantModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            Me.cmb_IsCurrent.ValueList = Me.Model.ValueLists("IsCurrent").ComboList
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_PartyID)
            myWinSQL.AssignCmb(Me.dsCombo, "Property", "", Me.cmb_PropertyID)

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnDeleteProperty_Click(sender As Object, e As EventArgs) Handles btnDeleteProperty.Click
        Dim oRet = Me.DeleteEntity("hsn", frmIDX, False)
        If oRet.ErrorCount > 0 Then
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        Else
            If MsgBox(oRet.Message, MsgBoxStyle.YesNo + MsgBoxStyle.Question, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                oRet = Me.DeleteEntity("hsn", frmIDX, True)
                If oRet.Success Then WinFormUtils.ButtonAction(Me, "btnCancel")
            End If
        End If
    End Sub

End Class