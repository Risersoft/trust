Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
Imports risersoft.app.mxform.college
Imports risersoft.app.mxengg

<DataContract>
Public Class frmEventModel
    Inherits clsFormDataModel
    Dim Sql As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Media")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        Sql = myFuncs.CodeWordSQL("EventDetail", "EventType", "CodeWord in ('GA')")
        Me.AddLookupField("EventType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "EventType").TableName)

        Sql = "Select finyearid, Descrip from FinYears order by FinYearID"
        Me.AddLookupField("finyearid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "FinYear").TableName)

        Dim vlist2 As New clsValueList
        vlist2.Add("Image", "Image")
        vlist2.Add("Video", "Video")
        Me.ValueLists.Add("UploadType", vlist2)
        Me.AddLookupField("UploadType", "UploadType")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String, dic As New clsCollecString(Of String)

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "select * from EventDetail where EventID = " & prepIDX
        Me.InitData(Sql, "Companyid", oView, prepMode, prepIDX, strXML)

        myRow("EventType") = "GA"

        Sql = "Select MediaDetailID,EventID,UploadType,Url from MediaDetail where EventID = " & frmIDX & ""
        myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""UploadType"" CAPTION=""MediaType""/><COL KEY=""Url"" CAPTION=""File Name""/>"
        myView.MainGrid.QuickConf(Sql, True, "1-1", True)
        str1 = "<BAND INDEX=""0"" TABLE=""MediaDetail"" IDFIELD=""MediaDetailID""><COL KEY=""EventID,UploadType,Url""/></BAND>"
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        Dim str2 As String = myUtils.CombineWhere(True, myContext.AppModel.strFilterDBAppUser(myContext, Me.fRow, "CompanyID"))
        Sql = "Select Companyid, CompName from Company " & str2 & " Order by CompName"
        Me.AddLookupField("Companyid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Company").TableName)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("sdate")).Trim.Length = 0 Then Me.AddError("sdate", "Please select Start Date")
        Return Me.CanSave
    End Function


    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            myRow("DescriptionHTML") = myFuncs.DecodeNormalizeHTML(myUtils.cStrTN(myRow("DescriptionHTML")))
            myRow("DescriptionText") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("DescriptionText")))

            myRow("PurposeHTML") = myFuncs.DecodeNormalizeHTML(myUtils.cStrTN(myRow("PurposeHTML")))
            myRow("PurposeText") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("PurposeText")))

            Dim r1 As DataRow = myContext.CommonData.FinRow(myRow("SDate"))
            If Not myUtils.NullNot(r1) Then
                myRow("FinYearID") = r1("FinYearID")
            End If

            Dim EventDescrip As String = myUtils.cStrTN(myRow("EventName"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "EventID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("EventID")

                frmMode = EnumfrmMode.acEditM
                myView.MainGrid.SaveChanges(, "EventID=" & frmIDX)
                myContext.Provider.dbConn.CommitTransaction(EventDescrip, frmIDX)
                VSave = True
            Catch ex As Exception
                myContext.Provider.dbConn.RollBackTransaction(EventDescrip, ex.Message)
                Me.AddError("", ex.Message)
            End Try
        End If
        Return VSave
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As New clsProcOutput
        oRet = myTrustFuncs.GenerateCommonOutput(myContext, dataKey, Params, "eventId")
        Return oRet
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "event"
                        Dim sql As String = "Select * from EventDetail Where EventID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)

                        If dt.Rows.Count > 0 Then
                            Dim sqlM As String = "Select * from MediaDetail Where EventID =" & ID
                            Dim dtM As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sqlM).Tables(0)

                            If dtM.Rows.Count > 0 Then
                                Dim sql1 As String = "delete from MediaDetail where EventID =" & ID
                                myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql1)
                            End If

                            Dim sql2 As String = "delete from EventDetail where EventID =" & ID
                            myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql2)
                        End If

                End Select
            ElseIf oRet.WarningCount = 0 Then
                oRet.AddWarning("Are you sure ?")
            End If
        Catch ex As Exception
            oRet.AddException(ex)
        End Try
        Return oRet
    End Function


End Class
