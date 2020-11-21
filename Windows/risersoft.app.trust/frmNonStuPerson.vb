Imports risersoft.shared.dotnetfx
Imports risersoft.app.mxform.trust

Public Class frmNonStuPerson
    Inherits frmMax
    Dim dvDept As DataView

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGridEducation)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmNonStuPersonModel = Me.InitData("frmNonStuPersonModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then

            If frmMode = EnumfrmMode.acEditM Then
                Me.Text = myRow("fullname")
                If Not (myUtils.NullNot(myRow("picperson"))) Then
                    WinFormUtils.FillPB(Me.pic_PicPerson, myRow("picperson"))
                    pic_PicPerson.rePicsize(Me.Width - Me.PanelPicSide.Width)
                End If
            End If

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Me.cmb_Desig.ValueList = Me.Model.ValueLists("Desig").ComboList
            Me.cmb_IsFemale.ValueList = Me.Model.ValueLists("IsFemale").ComboList
            Me.cmb_Fmode.ValueList = Me.Model.ValueLists("Fmode").ComboList
            Me.cmb_StaffMode.ValueList = Me.Model.ValueLists("StaffMode").ComboList
            Me.cmb_StaffDept.ValueList = Me.Model.ValueLists("StaffDept").ComboList
            Me.cmb_DeptRank.ValueList = Me.Model.ValueLists("Rank").ComboList
            Me.cmb_nontechstaffrank.ValueList = Me.Model.ValueLists("Rank").ComboList
            myWinSQL.AssignCmb(Me.dsCombo, "company", "", Me.cmb_CompanyID)
            myView.PrepEdit(Me.Model.GridViews("Education"), btnAddEdu, btnDelEdu)

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If hasNewImg Then WinFormUtils.FillDSFromPB(myRow.Row, "picperson", Me.pic_PicPerson)
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsePic.Click
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Me.pic_PicPerson.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog1.FileName)
            pic_PicPerson.rePicsize(Me.Width - Me.PanelPicSide.Width)
            hasNewImg = True
        End If
    End Sub

    Private Sub btnSavepic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavepic.Click
        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Me.pic_PicPerson.Image.Save(Me.SaveFileDialog1.FileName)
        End If
    End Sub


End Class