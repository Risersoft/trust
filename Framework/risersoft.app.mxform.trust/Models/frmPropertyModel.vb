Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPropertyModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "select * from Property where PropertyID = " & prepIDX
        Me.InitData(sql, "Companyid", oView, prepMode, prepIDX, strXML)

        Dim str2 As String = myUtils.CombineWhere(True, myContext.AppModel.strFilterDBAppUser(myContext, Me.fRow, "CompanyID"))
        sql = "Select Companyid, CompName from Company " & str2 & " Order by CompName"
        Me.AddLookupField("Companyid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Company").TableName)

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ShopNo")).Trim.Length = 0 Then Me.AddError("ShopNo", "Please Enter Shop Number")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim PropertyDescrip As String = myUtils.cStrTN(myRow("ShopNo"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PropertyID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)

                frmMode = EnumfrmMode.acEditM
                frmIDX = myRow("PropertyID")
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
                    Case "property"
                        Dim sql As String = "Select * from Property where PropertyID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "delete from Property where PropertyID =" & ID
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

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As New clsProcOutput
        oRet = myTrustFuncs.GenerateCommonOutput(myContext, dataKey, Params, "propertyId")
        Return oRet
    End Function

End Class

