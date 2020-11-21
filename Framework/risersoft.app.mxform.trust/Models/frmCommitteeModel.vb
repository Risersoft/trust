Imports risersoft.app.mxengg
Imports risersoft.shared
Imports System.Runtime.Serialization

<DataContract>
Public Class frmCommitteeModel
    Inherits clsFormDataModel
    Dim Sql As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Member")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        Sql = "Select distinct Name from Committee where Name is Not Null"
        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
        Me.ValueLists.Add("Name", myContext.SQL.VListFromTable(dt))
        Me.AddLookupField("Name", "Name")

        Dim vlist2 As New clsValueList
        vlist2.Add(1, "1")
        vlist2.Add(2, "2")
        vlist2.Add(3, "3")
        vlist2.Add(4, "4")
        vlist2.Add(5, "5")
        vlist2.Add(6, "6")
        vlist2.Add(7, "7")
        vlist2.Add(8, "8")
        vlist2.Add(9, "9")
        vlist2.Add(10, "10")
        vlist2.Add(11, "11")
        vlist2.Add(12, "12")
        vlist2.Add(13, "13")
        vlist2.Add(14, "14")
        vlist2.Add(15, "15")
        vlist2.Add(16, "16")
        vlist2.Add(17, "17")
        vlist2.Add(18, "18")
        vlist2.Add(19, "19")
        vlist2.Add(20, "20")
        Me.ValueLists.Add("Rank", vlist2)
        Me.AddLookupField("Rank", "Rank")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "select * from Committee where CommitteeID = " & prepIDX
        Me.InitData(Sql, "Companyid", oView, prepMode, prepIDX, strXML)

        Sql = "Select CommitteeMemberID,CommitteeID,Occupation,Rank,PersonID,FullName,CommDesig,Sdate,Edate from ClgListCommitteeMemberView where CommitteeID = " & frmIDX & ""
        myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""Sdate"" CAPTION=""Start Date""/><COL KEY=""Edate"" CAPTION=""End Date""/>"
        myView.MainGrid.QuickConf(Sql, True, "1-1-1-1", True)
        str1 = "<BAND INDEX=""0"" TABLE=""CommitteeMember"" IDFIELD=""CommitteeMemberID""><COL NOEDIT=""True"" KEY=""PersonID "" LOOKUPSQL = ""Select PersonID, FullName from Persons"" CAPTION = ""Member Name""/>
                    <COL KEY=""CommDesig"" LOOKUPSQL = ""Select distinct CommDesig from CommitteeMember order by CommDesig"" CAPTION = ""Designation""/>
                    <COL KEY=""CommitteeID,Rank,Sdate,Edate""/></BAND>"
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        Dim str2 As String = myUtils.CombineWhere(True, myContext.AppModel.strFilterDBAppUser(myContext, Me.fRow, "CompanyID"))
        Sql = "Select Companyid, CompName from Company " & str2 & " Order by CompName"
        Me.AddLookupField("Companyid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Company").TableName)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("Name")).Trim.Length = 0 Then Me.AddError("Name", "Please Enter Committee Name")
        If myUtils.NullNot(myRow("CommitteeCode")) Then Me.AddError("CommitteeCode", "Please Select Committee Code")
        If Me.SelectedRow("CompanyID") Is Nothing Then Me.AddError("CompanyID", "Please Select Comapny")
        'If myView.MainGrid.myDS.Tables(0).Select.Length > 0 Then
        '    For Each r As DataRow In myView.MainGrid.myDS.Tables(0).Select()
        '        If myUtils.NullNot(r("Rank")) Then Me.AddError("Rank", "Please Select Rank")
        '        If myUtils.NullNot(r("PersonID")) Then Me.AddError("PersonID", "Please Select Member Name")
        '    Next

        'End If

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim CommitteeDescrip As String = myUtils.cStrTN(myRow("Name"))

            If myUtils.NullNot(myRow("NotListed")) Then
                myRow("NotListed") = False
            End If

            myRow("DescriptionHTML") = myFuncs.DecodeNormalizeHTML(myUtils.cStrTN(myRow("DescriptionHTML")))
            myRow("DescriptionText") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("DescriptionText")))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "CommitteeID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("CommitteeID")

                frmMode = EnumfrmMode.acEditM
                myView.MainGrid.SaveChanges(, "CommitteeID=" & frmIDX)
                myContext.Provider.dbConn.CommitTransaction(CommitteeDescrip, frmIDX)
                VSave = True
            Catch ex As Exception
                myContext.Provider.dbConn.RollBackTransaction(myContext.Provider.dbConn.CommitTransaction(CommitteeDescrip, frmIDX), ex.Message)
                Me.AddError("", ex.Message)
            End Try
        End If
        Return VSave
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing, sql As String
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "committeemember"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("PersonID not in (@PersonIDcsv)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""PersonID""/>", True, , "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

            End Select
        End If
        Return Model
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "committee"
                        Dim sql As String = "Select * from Committee Where CommitteeID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)

                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "delete from Committee where CommitteeID =" & ID
                            myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql1)
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

