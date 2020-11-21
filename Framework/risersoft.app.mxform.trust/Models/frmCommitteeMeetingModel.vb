Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
Imports risersoft.app.mxengg

<DataContract>
Public Class frmCommitteeMeetingModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Persons")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String

        sql = "Select CommitteeID, Name from Committee order by CommitteeID"
        Me.AddLookupField("CommitteeID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Committee").TableName)

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String, dic As New clsCollecString(Of String)

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from CommitteeMeeting Where CommitteeMeetingID = " & prepIDX
        Me.InitData(sql, "CommitteeID", oView, prepMode, prepIDX, strXML)

        Dim PersonIDCSV = myUtils.cStrTN(myRow("personidcsv"))
        If String.IsNullOrEmpty(PersonIDCSV) Then PersonIDCSV = "0"

        'sql = "select Personid, FullName, Desig, Email, CellNum from clgListCommitteeMemberView where PersonID in (" & PersonIDCSV & ")"
        'myView.MainGrid.QuickConf(sql, True, "3-1-1-1", True, "Persons")
        'Me.myView.MainGrid.PrepEdit("", EnumEditType.acCommandOnly)

        sql = "select Personid, FullName, Desig, Email, CellNum from clgListCommitteeMemberView where PersonID in (" & PersonIDCSV & ")"
        myView.MainGrid.QuickConf(sql, True, "3-1-1-1", True, "Persons")
        Dim str1 As String = "<BAND INDEX=""0"" IDFIELD=""PersonID"" ></BAND> "
        Me.myView.MainGrid.PrepEdit(str1, EnumEditType.acEditOnly)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function
    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("CommitteeID")).Trim.Length = 0 Then Me.AddError("CommitteeID", "Please Select Committee.")
        If myUtils.cStrTN(myRow("Dated")).Trim.Length = 0 Then Me.AddError("Dated", "Please Select Committee.")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            If Me.CanSave Then
                Dim CommitteeMeeting As String = myUtils.cStrTN(Format(myRow("Dated"), "dd-mmm-yyyy"))

                myRow("AgendaHTML") = myFuncs.DecodeNormalizeHTML(myUtils.cStrTN(myRow("AgendaHTML")))
                myRow("AgendaText") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("AgendaText")))

                myRow("MinutesHTML") = myFuncs.DecodeNormalizeHTML(myUtils.cStrTN(myRow("MinutesHTML")))
                myRow("MinutesText") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("MinutesText")))

                Try
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "CommitteeMeetingID", frmIDX)
                    Dim str1 As String = myUtils.MakeCSV(myView.MainGrid.myDS.Tables(0).Select, "PersonID")
                    myRow("PersonIDCSV") = str1

                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                    myView.MainGrid.myDS.Tables(0).AcceptChanges()

                    frmMode = EnumfrmMode.acEditM
                    frmIDX = myRow("CommitteeMeetingID")
                    myContext.Provider.dbConn.CommitTransaction(CommitteeMeeting, frmIDX)
                    VSave = True
                Catch ex As Exception
                    myContext.Provider.dbConn.RollBackTransaction(CommitteeMeeting, ex.Message)
                    Me.AddError("", ex.Message)
                End Try

            End If
        End If
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower

                Case "persons"
                    Dim CommitteeID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@CommitteeID", Params))
                    Dim PersonIDcsv As String = myUtils.cValTN(myContext.SQL.ParamValue("@PersonIDcsv", Params))

                    Dim sql As String = myContext.SQL.PopulateSQLParams("select Personid, FullName, Desig, Email, CellNum from clgListCommitteeMemberView where PersonID not in (@PersonIDcsv) and committeeid=" & CommitteeID, Params)
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = True
                    Model.MainGrid.QuickConf(sql, True, "3-1-1-1",, "Select Persons")
                    Model.MainGrid.PrepEdit("", EnumEditType.acEditOnly)

            End Select
        End If
        Return Model
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "committeemeeting"
                        Dim sql As String = "Select * from CommitteeMeeting Where CommitteeMeetingID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)

                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "delete from CommitteeMeeting where CommitteeMeetingID =" & ID
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
