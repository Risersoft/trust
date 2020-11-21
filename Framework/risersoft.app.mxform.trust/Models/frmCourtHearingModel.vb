Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
Imports risersoft.app.mxengg

<DataContract>
Public Class frmCourtHearingModel
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
        Dim sql As String, dic As New clsCollecString(Of String)

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "select * from CourtHearing where CourtHearingID = " & prepIDX
        Me.InitData(sql, "CourtCaseID", oView, prepMode, prepIDX, strXML)

        dic.Add("CourtCase", "Select * from CourtCase where CourtCaseID=" & myRow("CourtCaseID"))
        Me.AddDataSet("CC", dic)

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("CourtCaseID")).Trim.Length = 0 Then Me.AddError("CourtCaseID", "Select Court Case Name")
        If myUtils.cStrTN(myRow("Dated")).Trim.Length = 0 Then Me.AddError("Dated", "Select Date")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim CourtHearingDt As String = " Dt. " & Format(myRow("Dated"), "dd-MMM-yyyy") & ""

            myRow("CurrentSatusHTML") = myFuncs.DecodeNormalizeHTML(myUtils.cStrTN(myRow("CurrentSatusHTML")))
            myRow("CurrentSatusText") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("CurrentSatusText")))

            myRow("NextHearingPurposeHTML") = myFuncs.DecodeNormalizeHTML(myUtils.cStrTN(myRow("NextHearingPurposeHTML")))
            myRow("NextHearingPurposeText") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("NextHearingPurposeText")))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "CourtHearingID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)

                frmMode = EnumfrmMode.acEditM
                frmIDX = myRow("CourtHearingID")
                myContext.Provider.dbConn.CommitTransaction(CourtHearingDt, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(CourtHearingDt, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "courthearing"
                        Dim sql As String = "Select * from CourtHearing Where CourtHearingID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)

                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "delete from CourtHearing where CourtHearingID =" & ID
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
