Imports risersoft.app.mxent
Imports risersoft.shared
Imports klts.app.mxform.admin.Mxcollegedb
Imports System.Data.Common
Imports System.Data.SqlClient
Imports risersoft.shared.dal
Imports AutoMapper
Imports risersoft.shared.cloud
Imports System.IO
Imports Newtonsoft.Json
Imports klts.app.mxform.admin

Public Class myTrustFuncs
    Inherits myFuncsBase

    Public Sub ColorizeAttDayWise(ByVal oview As clsView, ByVal frmidx As String, ByVal e As clsRow)
        Dim gRow As clsRow = e
        If gRow.Columns.Contains("IsHoliday") Then
            If myUtils.cBoolTN(gRow.CellValue("IsHoliday")) Then
                gRow.BackColor = System.Drawing.Color.LightGray
            End If
        End If
    End Sub


    Public Shared Function rFinYear(context As IProviderContext, Dated As Date) As DataRow
        Dim r1 As DataRow = Nothing
        Dim Sql As String = "Select * from FinYears where StDate < = '" & Format(Dated, "yyyy-MMM-dd") & "' and EnDate > = '" & Format(Dated, "yyyy-MMM-dd") & "'"
        Dim dt As DataTable = context.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
        If dt.Rows.Count > 0 Then r1 = dt.Rows(0)

        Return r1
    End Function


    Public Shared Function rTask(context As IProviderContext, ActionType As String, ActionSubType As String) As DataRow
        Dim r1 As DataRow = Nothing
        Dim Sql As String = "Select * from DBSchedTask where ActionType = '" & myUtils.cStrTN(ActionType) & "' and ActionSubType = '" & myUtils.cStrTN(ActionSubType) & "'"
        Dim dt As DataTable = context.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
        If dt.Rows.Count > 0 Then r1 = dt.Rows(0)
        Return r1
    End Function
    Public Shared Function InitializeMapper() As IConfigurationProvider
        Dim config = New MapperConfiguration(Sub(cfg)
                                                 cfg.CreateMap(Of Committee, CommitteeInfo)()
                                                 cfg.CreateMap(Of ClgListCommitteeMemberView, CommitteeInfo)()
                                                 cfg.CreateMap(Of DegreeCourse, DegreeCourseInfo)()
                                                 cfg.CreateMap(Of ClgListDepartmentView, DepartmentInfo)()
                                                 cfg.CreateMap(Of ClgListEventDetailView, EventInfo)()
                                                 cfg.CreateMap(Of ClgListActivityView, ActivityInfo)()
                                                 cfg.CreateMap(Of Company, CollegeInfo)()
                                                 cfg.CreateMap(Of MediaDetail, MediaInfo)()
                                                 cfg.CreateMap(Of clgListNaaC, NAACInfo)()
                                                 cfg.CreateMap(Of ClgListPersonsView, PersonInfo)()
                                                 cfg.CreateMap(Of Subject, SubjectInfo)()
                                                 cfg.CreateMap(Of ClgListAlumniView, AlumniInfo)()
                                                 cfg.CreateMap(Of AlumniInfo, Alumni)()
                                                 cfg.CreateMap(Of Alumni, AlumniInfo)()
                                                 cfg.CreateMap(Of ClgListMediaDetailView, MediaInfo)()
                                                 cfg.CreateMap(Of ClgListCommitteeMemberView, CommitteeMemberInfo)()
                                                 cfg.CreateMap(Of FinYears, FinYearsInfo)()
                                                 cfg.CreateMap(Of NoticeBoard, NoticeBoardInfo)()
                                             End Sub)
        Return config
    End Function
    Public Shared Function LoadAppData(context As IProviderContext, dataKey As String, Params As List(Of clsSQLParam), forcefresh As Boolean, fncBase As Func(Of clsProcOutput)) As clsProcOutput
        Dim dic As New clsCollecString(Of String), oRet As New clsProcOutput, ds As New DataSet

        Try
            Select Case dataKey.Trim.ToLower
                Case "clsmasterdatahrp"
                    dic.Add("Inst", "select * from Company")
                    dic.Add("payp", "select * from payperiod")
                    dic.Add("atm", "select * from attendtagmaster")
                    dic.Add("shift", "select * from shift")
                Case "com1"
                    dic.Add("finyrs", "select * from finyears")
                    dic.Add("company", "select * from Company")
                Case "clsmasterdatafico"
                    dic.Add("postp", "select * from postperiod")
                Case "postperiodid"
                    Dim str1 As String = context.SQL.ParamValue("@vouchdate", Params)
                    Dim VouchDate As DateTime = If(String.IsNullOrEmpty(str1), Now.Date, DateTime.Parse(str1))
                    Dim oMaster As New clsMasterDataFICO(context)
                    Dim r1 As DataRow = oMaster.rPostPeriod(VouchDate, "HRStartDate")
                    If Not r1 Is Nothing Then oRet.ID = r1("PostPeriodId")
                Case Else
                    ds = fncBase().Data
            End Select
            If dic.Count > 0 AndAlso ds.Tables.Count = 0 Then
                'Pure SQL datasets
                ds = context.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            End If
        Catch ex As Exception
            Trace.WriteLine(ex.Message & " while executing " & dataKey)
        End Try
        oRet.Data = ds
        Return oRet
    End Function

    Public Shared Function GenerateCommonOutput(context As IProviderContext, DataKey As String, Params As List(Of clsSQLParam), IDField As String) As clsProcOutput
        Dim oRet As New clsProcOutput
        Dim serverPath As String = Uri.UnescapeDataString(context.SQL.ParamValue("@serverPath", Params))
        Dim _NewFileName As String = myUtils.cStrTN(context.SQL.ParamValue("@filename", Params))

        Select Case DataKey.Trim.ToLower
            Case "sas"
                'Dim frmid As String = myUtils.cStrTN(context.SQL.ParamValue($"@{IDField}", Params))
                '_NewFileName = Guid.NewGuid.ToString() + "_" + frmid + "" + Path.GetExtension(_NewFileName)

                Dim OrigFileName = Path.GetFileNameWithoutExtension(_NewFileName)
                _NewFileName = OrigFileName + "--" + Guid.NewGuid.ToString() + Path.GetExtension(_NewFileName)

                Dim provider As New clsBlobFileProvider(context)
                Dim container = myPathUtils.GetContainerName(context)
                Dim oRet2 = provider.CreateUploadUri(container, _NewFileName, "")
                If oRet2.Success Then
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message, .Data = oRet2.Result.Uri.ToString, .flName = _NewFileName}
                Else
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message} '"Unable to upload file."
                End If

            Case "download"
                Dim provider As New clsBlobFileProvider(context)
                Dim container = myPathUtils.GetContainerName(context)
                Dim oRet2 = provider.GetDownloadUri(container, myUtils.Coalesce(serverPath, _NewFileName))
                If oRet2.Success Then
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message, .Data = oRet2.Result.Uri.ToString}
                Else
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message} '"Unable to upload file."
                End If
        End Select
        Return oRet
    End Function
    Public Shared Function GetDownloadUri(context As IProviderContext, infoJson As String) As String
        If myUtils.StartsWith(infoJson, "[") Then
            Dim lst = JsonConvert.DeserializeObject(Of List(Of ClsBlobFileInfo))(infoJson)
            If lst.Count > 0 AndAlso Not String.IsNullOrEmpty(lst(0).Blobname) Then
                Return myTrustFuncs.GetDownloadUriBlob(context, lst(0).Blobname)
            End If
        Else
            'direct file name
            Return myTrustFuncs.GetDownloadUriBlob(context, infoJson)
        End If
    End Function
    Public Shared Function GetDownloadUriBlob(context As IProviderContext, BlobName As String) As String
        Dim provider As New clsBlobFileProvider(context)
        Dim container = myPathUtils.GetContainerName(context)
        Dim oRet2 = provider.GetDownloadUri(container, BlobName)
        If oRet2.Success Then
            Return oRet2.Result.ToString
        End If
    End Function
End Class