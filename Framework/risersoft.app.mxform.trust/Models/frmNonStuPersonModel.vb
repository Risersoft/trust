Imports risersoft.app.mxform.trust
Imports risersoft.shared
Imports System.Runtime.Serialization

<DataContract>
Public Class frmNonStuPersonModel
    Inherits clsFormDataModel
    Dim Sql As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Education")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        Sql = "Select distinct Desig from Persons where Desig is Not Null"
        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
        Me.ValueLists.Add("Desig", myContext.SQL.VListFromTable(dt))
        Me.AddLookupField("Desig", "Desig")

        Dim vlist As New clsValueList
        vlist.Add(True, "Female")
        vlist.Add(False, "Male")
        Me.ValueLists.Add("IsFemale", vlist)
        Me.AddLookupField("IsFemale", "IsFemale")

        Dim vlist2 As New clsValueList
        vlist2.Add("Government Aided", "Government Aided")
        vlist2.Add("Self Financed", "Self Financed")
        Me.ValueLists.Add("Fmode", vlist2)
        Me.AddLookupField("Fmode", "Fmode")

        Dim vlist3 As New clsValueList
        vlist3.Add("3", "Third class")
        vlist3.Add("4", "Forth class")
        Me.ValueLists.Add("StaffMode", vlist3)
        Me.AddLookupField("StaffMode", "StaffMode")

        Dim vlist4 As New clsValueList
        vlist4.Add("Computer", "Computer")
        vlist4.Add("Library", "Library")
        vlist4.Add("Office", "Office")
        vlist4.Add("Support", "Support")
        Me.ValueLists.Add("StaffDept", vlist4)
        Me.AddLookupField("StaffDept", "StaffDept")

        Dim vlist5 As New clsValueList
        vlist5.Add(1, "1")
        vlist5.Add(2, "2")
        vlist5.Add(3, "3")
        vlist5.Add(4, "4")
        vlist5.Add(5, "5")
        Me.ValueLists.Add("Rank", vlist5)
        Me.AddLookupField("Rank", "Rank")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "select * from Persons where PersonID = " & prepIDX
        Me.InitData(Sql, "companyid", oView, prepMode, prepIDX, strXML)

        myView.MainGrid.QuickConf("Select perseduid,personid,Qualification,Institution,Board,YearQual,Marks,PerMarks from persedu where personid=" & frmIDX, True, "2-2-2-1-1.5-1", True)
        myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""YearQual"" CAPTION=""Passing Year""/><COL KEY=""Marks"" CAPTION=""Marks Obtained""/><COL KEY=""PerMarks"" CAPTION=""Percentage""/>"
        Dim str2 = "<BAND INDEX=""0"" TABLE=""persedu"" IDFIELD=""perseduid"" ><COL KEY=""Qualification,Institution,Board,YearQual,Marks,PerMarks,personid""/></BAND> "
        myView.MainGrid.PrepEdit(str2, EnumEditType.acCommandAndEdit)

        Dim str1 As String = myUtils.CombineWhere(True, myContext.AppModel.strFilterDBAppUser(myContext, Me.fRow, "CompanyID"))
        Sql = "Select Companyid, CompName from Company " & str1 & " union all select 0, '[None]' Order by CompName"
        Me.AddLookupField("Companyid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Company").TableName)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If (myUtils.cStrTN(myRow("FirstName")).Trim.Length = 0) AndAlso (myUtils.cStrTN(myRow("MidName")).Trim.Length = 0) AndAlso (myUtils.cStrTN(myRow("LastName")).Trim.Length = 0) Then Me.AddError("LastName", "Enter the name")
        If Me.SelectedItem("IsFemale") Is Nothing Then Me.AddError("IsFemale", "Select Gender")
        If myUtils.cStrTN(myRow("Desig")).Trim.Length = 0 Then Me.AddError("Desig", "Please Enter Designation")
        If myUtils.cStrTN(myRow("DeptID")).Trim.Length > 0 Then
            If Me.SelectedItem("Fmode") Is Nothing Then Me.AddError("Fmode", "Please Select Faculty Mode")
        End If
        If myUtils.cStrTN(myRow("StaffMode")).Trim.Length > 0 Then
            If Me.SelectedItem("StaffDept") Is Nothing Then Me.AddError("StaffDept", "Please Select Staff Department")
        End If

        Return Me.CanSave
    End Function


    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim PersonDescrip As String = myUtils.cStrTN(myRow("FullName"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PersonID", frmIDX)
                If myUtils.cValTN(myRow("companyid")) = 0 Then myRow("companyid") = DBNull.Value
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("PersonID")

                frmMode = EnumfrmMode.acEditM
                myView.MainGrid.SaveChanges(, "PersonID=" & frmIDX)
                myContext.Provider.dbConn.CommitTransaction(PersonDescrip, frmIDX)
                VSave = True
            Catch ex As Exception
                myContext.Provider.dbConn.RollBackTransaction(PersonDescrip, ex.Message)
                Me.AddError("", ex.Message)
            End Try
        End If
        Return VSave
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As New clsProcOutput
        oRet = myTrustFuncs.GenerateCommonOutput(myContext, dataKey, Params, "personId")
        Return oRet
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "persons"
                        Dim sql As String = "Select * from Persons Where PersonsID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)

                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "delete from Persons where PersonsID =" & ID
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

