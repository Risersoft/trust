Imports System.Net
Imports risersoft.shared.portable.Model
Imports risersoft.shared.web
Imports risersoft.shared.cloud
Imports risersoft.shared.cloud.Repository
Imports klts.app.mxform.admin
Imports klts.app.mxform.admin.Mxcollegedb
Imports risersoft.shared.agent

Public Class ServerRepositoryBase
    Inherits RepositoryBase(Of Boolean, RSCallerInfo, HttpStatusCode)

    Protected Overrides Function GetStatus(IsError As Boolean) As HttpStatusCode
        If IsError Then Return HttpStatusCode.InternalServerError Else Return HttpStatusCode.OK
    End Function

    Protected Function GetServerEntity() As MxcollegedbContext
        Dim strConn = AgentAuthProvider.CalculateConnectionString(Me.User, "mxCollegeDb", "Nirvana")
        Return New MxcollegedbContext(strConn.ConnectionString, Me.User)
    End Function
End Class
