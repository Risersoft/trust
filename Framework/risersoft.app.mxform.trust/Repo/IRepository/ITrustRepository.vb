Imports System.IO
Imports System.Net
Imports klts.app.mxform.admin
Imports risersoft.shared.portable.Model
Imports risersoft.shared.portable.Models
Imports risersoft.shared.cloud.IRepository

Public Interface ITrustRepository
    Inherits IRepositoryBase(Of Boolean, RSCallerInfo, HttpStatusCode)

    Function GetCommitteeMembers(Code As String) As ResultInfo(Of List(Of CommitteeMemberInfo), HttpStatusCode)
    Function GetNonTeachingStaff(Code As String) As ResultInfo(Of List(Of PersonInfo), HttpStatusCode)
    Function GetEvents(Code As String, EventType As String) As ResultInfo(Of List(Of EventInfo), HttpStatusCode)
    Function GetCollegeInfo(Code As String) As ResultInfo(Of CollegeInfo, HttpStatusCode)
    Function GetEvent(Id As Integer) As ResultInfo(Of EventInfo, HttpStatusCode)
End Interface
