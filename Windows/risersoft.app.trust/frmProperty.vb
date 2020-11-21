Imports risersoft.app.mxform.trust

Public Class frmProperty
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPropertyModel = Me.InitData("frmPropertyModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then

            myWinSQL.AssignCmb(Me.dsCombo, "Company", "", Me.cmb_CompanyID)

            'If frmMode = EnumfrmMode.acEditM Then
            '    If Not myUtils.NullNot(myRow("OwnerPhoto")) Then
            '        WinFormUtils.FillPB(Me.pic_Logo, myRow("OwnerPhoto"))
            '        Me.rePicsize(Me.pic_Logo, 0)
            '    End If
            'End If

            If frmMode = EnumfrmMode.acEditM Then
                If Not myUtils.NullNot(myRow("ShopPhoto")) Then
                    WinFormUtils.FillPB(Me.pic_Logo, myRow("ShopPhoto"))
                    pic_Logo.rePicsize(0)
                End If
            End If

        End If
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If hasNewImg Then
                'WinFormUtils.FillDSFromPB(myRow.Row, "OwnerPhoto", Me.pic_Logo)
                WinFormUtils.FillDSFromPB(myRow.Row, "ShopPhoto", Me.pic_Logo)
            End If
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

    Private Sub btnBrowsePic_Click(sender As Object, e As EventArgs) Handles btnBrowsePic.Click
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Me.pic_Logo.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog1.FileName)
            pic_Logo.rePicsize(0)
            hasNewImg = True
        End If
    End Sub

    Private Sub btnSavepic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavepic.Click
        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Me.pic_Logo.Image.Save(Me.SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnBrowseTP_Click(sender As Object, e As EventArgs) Handles btnBrowseTP.Click
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Me.pic_TPCert.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog1.FileName)
            pic_TPCert.rePicsize(0)
            hasNewImg = True
        End If
    End Sub

    Private Sub btnSaveTP_Click(sender As Object, e As EventArgs) Handles btnSaveTP.Click
        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Me.pic_TPCert.Image.Save(Me.SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnDeleteProperty_Click(sender As Object, e As EventArgs) Handles btnDeleteProperty.Click
        Dim oRet = Me.DeleteEntity("property", frmIDX, False)
        If oRet.ErrorCount > 0 Then
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        Else
            If MsgBox(oRet.Message, MsgBoxStyle.YesNo + MsgBoxStyle.Question, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                oRet = Me.DeleteEntity("property", frmIDX, True)
                If oRet.Success Then WinFormUtils.ButtonAction(Me, "btnCancel")
            End If
        End If
    End Sub

End Class
