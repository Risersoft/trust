Imports risersoft.app.mxengg
Imports risersoft.shared
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPropertyTenantModel
    Inherits clsFormDataModel
    Dim sql As String
    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        Sql = "Select PartyID, PartyName from Party order by PartyName"
        Me.AddLookupField("PartyID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Party").TableName)

        sql = "Select PropertyID, ShopNo from Property order by PropertyID"
        Me.AddLookupField("PropertyID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Property").TableName)

        Dim vlst1 As New clsValueList
        vlst1.Add(False, "No")
        vlst1.Add(True, "Yes")
        Me.ValueLists.Add("IsCurrent", vlst1)
        Me.AddLookupField("IsCurrent", "IsCurrent")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "select * from PropertyTenant where PropertyTenantID = " & prepIDX
        Me.InitData(sql, "PropertyID", oView, prepMode, prepIDX, strXML)

        If myUtils.cStrTN(myRow("isCurrent")).Trim.Length = 0 Then
            myRow("isCurrent") = True
        End If

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.SelectedRow("PropertyID") Is Nothing Then Me.AddError("PropertyID", "Please select Property")
        If Me.SelectedRow("PartyID") Is Nothing Then Me.AddError("PartyID", "Please select Party")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim PropertyTenantDescrip As String = myUtils.cValTN(myRow("PropertyID"))

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "PropertyTenantID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("PropertyTenantID")

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(PropertyTenantDescrip, frmIDX)
                VSave = True
            Catch ex As Exception
                myContext.Provider.dbConn.RollBackTransaction(myContext.Provider.dbConn.CommitTransaction(PropertyTenantDescrip, frmIDX), ex.Message)
                Me.AddError("", ex.Message)
            End Try
        End If
        Return VSave
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "propertytenant"
                        Dim sql As String = "Select * from PropertyTenant Where PropertyTenantID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)

                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "delete from PropertyTenant where PropertyTenantID =" & ID
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

