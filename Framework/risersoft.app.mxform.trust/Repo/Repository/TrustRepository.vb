Imports System.Net
Imports AutoMapper
Imports klts.app.mxform.admin
Imports Newtonsoft.Json
Imports risersoft.app.mxform.trust

''' <summary>
''' ESS Repository
''' </summary>
''' <remarks></remarks>
Public Class TrustRepository
    Inherits ServerRepositoryBase
    Implements ITrustRepository
    Dim mapper As IMapper
    ''' <summary>
    ''' Public constructor.
    ''' </summary>
    Public Sub New()
        Dim config = myTrustFuncs.InitializeMapper()
        mapper = config.CreateMapper()

    End Sub
    Public Function GetCommitteeMembers(TrustCode As String) As ResultInfo(Of List(Of CommitteeMemberInfo), HttpStatusCode) Implements ITrustRepository.GetCommitteeMembers
        Try
            Using _ctx = Me.GetServerEntity
                Dim _Trust = (From _c In _ctx.Company Where _c.CompCode.Equals(TrustCode)).FirstOrDefault
                Dim _lst = (From _c In _ctx.ClgListCommitteeMemberView Where (_c.CompanyId.Equals(_Trust.CompanyId))).ToList
                Dim result = mapper.Map(Of List(Of CommitteeMemberInfo))(_lst)
                For Each info In result
                    info.ImageUrl = myTrustFuncs.GetDownloadUri(Me.WebController, info.ImageUrl)
                Next
                Return Me.BuildResponse(result)
            End Using

        Catch ex As Exception
            Return BuildExceptionResponse(Of List(Of CommitteeMemberInfo))(ex)
        End Try
    End Function


    Public Function GetNonTeachingStaff(TrustCode As String) As ResultInfo(Of List(Of PersonInfo), HttpStatusCode) Implements ITrustRepository.GetNonTeachingStaff
        Try
            Using _ctx = Me.GetServerEntity
                Dim _Trust = (From _c In _ctx.Company Where _c.CompCode.Equals(TrustCode)).FirstOrDefault
                Dim _lst = (From _c In _ctx.ClgListPersonsView Where (_c.Companyid.Equals(_Trust.CompanyId) And _c.NonTeacStaff.Equals(True))).ToList


                Dim result = mapper.Map(Of List(Of PersonInfo))(_lst)
                For Each info In result
                    info.ImageUrl = myTrustFuncs.GetDownloadUri(Me.WebController, info.ImageUrl)
                Next
                Return Me.BuildResponse(result)



            End Using

        Catch ex As Exception
            Return BuildExceptionResponse(Of List(Of PersonInfo))(ex)
        End Try
    End Function

    Public Function GetEvents(TrustCode As String, EventType As String) As ResultInfo(Of List(Of EventInfo), HttpStatusCode) Implements ITrustRepository.GetEvents
        Try
            Using _ctx = Me.GetServerEntity
                Dim _lst = (From _c In _ctx.ClgListEventDetailView Where (_c.CompCode.Equals(TrustCode) And _c.EventType.Equals(EventType))).OrderByDescending(Function(x) x.Sdate).Take(100).ToList
                Dim EventIDs = _lst.Select(Function(x) x.EventID).ToList
                Dim _lst2 = (From _c In _ctx.ClgListMediaDetailView Where (_c.CompCode.Equals(TrustCode) And EventIDs.Contains(_c.EventId.Value))).ToList

                Dim result = mapper.Map(Of List(Of EventInfo))(_lst)
                For Each info In result

                    info.Media = mapper.Map(Of List(Of MediaInfo))(_lst2.Where(Function(x) x.EventId.Equals(info.EventID)).Take(5).ToList)
                    For Each infodata In info.Media
                        infodata.Url = myTrustFuncs.GetDownloadUri(Me.WebController, infodata.Url)
                    Next
                Next

                Return Me.BuildResponse(result)
            End Using

        Catch ex As Exception
            Return BuildExceptionResponse(Of List(Of EventInfo))(ex)
        End Try
    End Function

    Public Function GetEvent(Id As Integer) As ResultInfo(Of EventInfo, HttpStatusCode) Implements ITrustRepository.GetEvent
        Try
            Using _ctx = Me.GetServerEntity
                Dim _info = (From _c In _ctx.ClgListEventDetailView Where (_c.EventId.Equals(Id))).FirstOrDefault
                Dim _lst2 = (From _c In _ctx.ClgListMediaDetailView Where (_c.EventId.Equals(Id))).ToList

                Dim result = mapper.Map(Of EventInfo)(_info)
                result.Media = mapper.Map(Of List(Of MediaInfo))(_lst2)
                For Each infodata In result.Media
                    infodata.Url = myTrustFuncs.GetDownloadUri(Me.WebController, infodata.Url)
                Next

                Return Me.BuildResponse(result)
            End Using

        Catch ex As Exception
            Return BuildExceptionResponse(Of EventInfo)(ex)
        End Try
    End Function
    Public Function GetCollegeInfo(TrustCode As String) As ResultInfo(Of CollegeInfo, HttpStatusCode) Implements ITrustRepository.GetCollegeInfo
        Try
            Using _ctx = Me.GetServerEntity
                Dim _Trust = (From _c In _ctx.Company Where _c.CompCode.Equals(TrustCode)).FirstOrDefault
                Dim info = mapper.Map(Of CollegeInfo)(_Trust)
                info.CollegeProsURL = myTrustFuncs.GetDownloadUri(Me.WebController, info.CollegePros)
                info.AcademicCalendarURL = myTrustFuncs.GetDownloadUri(Me.WebController, info.AcademicCalender)
                Return Me.BuildResponse(info)
            End Using

        Catch ex As Exception
            Return BuildExceptionResponse(Of CollegeInfo)(ex)
        End Try
    End Function

End Class
