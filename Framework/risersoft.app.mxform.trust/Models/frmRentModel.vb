Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
Imports risersoft.app.mxengg

<DataContract>
Public Class frmRentModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String

        sql = "Select PartyID, PartyName from Party order by PartyName"
        Me.AddLookupField("PartyID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Party").TableName)

        Dim vlist As New clsValueList
        vlist.Add(True, "Yes")
        vlist.Add(False, "No")
        Me.ValueLists.Add("IsCurrent", vlist)
        Me.AddLookupField("IsCurrent", "IsCurrent")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "select * from Rent where RentID = " & prepIDX
        Me.InitData(sql, "PropertyID", oView, prepMode, prepIDX, strXML)

        If myUtils.cStrTN(myRow("isCurrent")).Trim.Length = 0 Then
            myRow("isCurrent") = True
        End If

        Dim str2 As String = myUtils.CombineWhere(True, myContext.AppModel.strFilterDBAppUser(myContext, Me.fRow, "CompanyID"))
        sql = "Select PropertyID, ShopNo from Property " & str2 & " order by PropertyID"
        Me.AddLookupField("PropertyID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Property").TableName)

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean

        Me.InitError()
        If myUtils.cStrTN(myRow("PropertyID")).Trim.Length = 0 Then Me.AddError("PropertyID", "Please select Property")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim PropertyDescrip As String = myUtils.cStrTN(myRow("RentText"))
            myRow("RentHTML") = myFuncs.DecodeNormalizeHTML(myUtils.cStrTN(myRow("RentHTML")))
            myRow("RentText") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("RentText")))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "RentID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)

                frmMode = EnumfrmMode.acEditM
                frmIDX = myRow("RentID")
                myContext.Provider.dbConn.CommitTransaction(PropertyDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(PropertyDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "rent"
                        Dim sql As String = "Select * from Rent where RentID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "delete from Rent where RentID =" & ID
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

