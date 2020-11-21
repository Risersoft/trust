Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Controllers
Imports klts.app.mxform.admin
Imports risersoft.app.mxform.college
Imports risersoft.app.mxform.trust
Imports risersoft.shared.web.Controllers
''' <summary>
''' ESS Controller
''' </summary>
''' <remarks></remarks>
<RoutePrefix("api/Data")>
Public Class DataController
    Inherits ServerApiController(Of Boolean, HttpStatusCode, ITrustRepository)

    Public Sub New(repository As ITrustRepository)
        MyBase.New(repository)
    End Sub
    Protected Overrides Sub Initialize(controllerContext As HttpControllerContext)
        MyBase.Initialize(controllerContext)
        Dim EssAppCode = "nklt"
        repository.WebController.CheckInitModel(New clsAppInfo With {.AppCode = EssAppCode},
                                                True)
    End Sub
    <Route("Committee")>
    Public Function GetCommitteeMembers(Code As String) As IHttpActionResult
        Dim result = repository.GetCommitteeMembers(Code)
        Return Ok(result)
    End Function
    <Route("NonTeachingStaff")>
    Public Function GetNonTeachingStaff(Code As String) As IHttpActionResult
        Dim result = repository.GetNonTeachingStaff(Code)
        Return Ok(result)
    End Function
    <Route("Events")>
    Public Function GetEvents(Code As String, EventType As String) As IHttpActionResult
        Dim result = repository.GetEvents(Code, EventType)
        Return Ok(result)
    End Function
    <Route("Event")>
    Public Function GetEvent(Id As Integer) As IHttpActionResult
        Dim result = repository.GetEvent(Id)
        Return Ok(result)
    End Function
    <Route("College")>
    Public Function GetCollegeInfo(Code As String) As IHttpActionResult
        Dim result = repository.GetCollegeInfo(Code)
        Return Ok(result)
    End Function


End Class
'http://stackoverflow.com/questions/24080018/download-file-from-an-asp-net-web-api-method-using-angularjs
