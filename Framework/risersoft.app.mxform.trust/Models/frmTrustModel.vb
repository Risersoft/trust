Imports risersoft.shared
Imports risersoft.app.mxcollegedb
Imports System.Runtime.Serialization
Imports System.Text.RegularExpressions
Imports risersoft.app.mxform.college
Imports risersoft.app.mxengg

<DataContract>
Public Class frmTrustModel
    Inherits clsFormDataModel
    Dim Sql As String
    Dim dicSQL As New clsCollecString(Of String)

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim ds As DataSet = myContext.CommonData.GetDatasetLocode(False).Copy
        Me.AddLookupField("Country", myUtils.AddTable(Me.dsCombo, ds.Tables("CO"), "CO").TableName)
        Me.AddLookupField("State", myUtils.AddTable(Me.dsCombo, ds.Tables("SU"), "SU").TableName)

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        dicSQL.Add("company", "Select * from company where companyid  = %frmIDX%")
        dicSQL.Add("party", "Select * from partymain where mainpartyid in (select mainpartyid from company where companyid  = %frmIDX%)")
        Me.InitData(dicSQL, "", oView, prepMode, prepIDX, strXML)

        Sql = "Select PersonID, FullName from ClgListPersonsView where Desig = 'Principal' and CompanyID = " & frmIDX & " order by FullName"
        Me.AddLookupField("PrincipalPersonID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "PrincipalPerson").TableName)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("CompName")).Trim.Length = 0 Then Me.AddError("CompName", "Please Enter Name of the College")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim CollegeDescrip As String = myUtils.cStrTN(myRow("CompName"))

            myRow("PrincipalMessageHTML") = myFuncs.DecodeNormalizeHTML(myUtils.cStrTN(myRow("PrincipalMessageHTML")))
            myRow("PrincipalMessageText") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("PrincipalMessageText")))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "CompanyID", frmIDX)
                myRow("mpname") = myRow("compname")
                myRow("tcname") = myRow("compname")
                myRow("partytype") = "A"
                myContext.Data.SaveMulti(dicSQL, myRow.Row, frmIDX)
                frmIDX = myRow("CompanyID")

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(CollegeDescrip, frmIDX)
                VSave = True
            Catch ex As Exception
                myContext.Provider.dbConn.RollBackTransaction(CollegeDescrip, ex.Message)
                Me.AddError("", ex.Message)
            End Try
        End If
        Return VSave
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As New clsProcOutput
        oRet = myTrustFuncs.GenerateCommonOutput(myContext, dataKey, Params, "companyid")
        Return oRet
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "company"
                        Dim sql As String = "Select * from Company Where CompanyID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)

                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "delete from Company where CompanyID =" & ID
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
