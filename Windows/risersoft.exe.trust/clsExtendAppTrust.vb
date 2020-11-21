Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports risersoft.app.mxent
Imports risersoft.app.mxform.trust
Imports risersoft.app2.shared
Imports risersoft.chrome.winforms
Imports risersoft.shared.cloud
Imports risersoft.shared.dal
Imports risersoft.shared.agent
Imports risersoft.app.mxform
Imports risersoft.shared
Imports risersoft.shared.portable.Models.Nav
Imports risersoft.shared.dotnetfx
Imports Microsoft.Extensions.Logging
Imports risersoft.app.config

Public Class clsExtendAppTrust
    Inherits clsExtendRsBase
    Protected Friend strApp As String = "", mFileProvider As ICloudFileProvider, mQueueProvider As IQueueProvider
    Dim dic As clsCollecString(Of Boolean), cts As CancellationTokenSource

    Public Overrides Function GetLicProductInfo() As LicProductInfo
        Return New LicProductInfo("nklt", 1.0, "TrustNirvana.Std")
    End Function
    Public Overrides Function IsFreeLicenseApp(oApp As clsCoreApp) As Boolean
        Return True
    End Function
    Public Overrides Function AboutBox() As risersoft.shared.IForm
        Return New frmAboutBox
    End Function

    Public Overrides Function FileServerRequired() As Boolean
        Return True
    End Function

    Public Overrides Function ProgramName() As String
        Return "TrustNirvana"
    End Function

    Public Overrides Function NewDBName() As String
        Return ""
    End Function

    Public Overrides Function MinDBVersion() As Decimal
        Return My.Settings.MinDBVersion
    End Function

    Public Overrides Function ProgramCode() As String
        Return "mxrent"
    End Function

    Public Overrides Function LinkLabel() As String
        Return "http://www.risersoft.com"
    End Function
    Public Overrides Function oSQLHelper(provider As IAppDataProvider) As ISQLHelper2
        Dim objSQLHelper = New clsSQLHelper2(provider)
        Return objSQLHelper
    End Function

    Public Overrides Function FileProviderClient(context As IProviderContext, ContainerName As String, ProviderCode As String) As clsFileProviderClientBase
        Dim provider As clsFileProviderClientBase
        Select Case ProviderCode.Trim.ToLower
            Case "blob"
                If mFileProvider Is Nothing Then mFileProvider = New clsBlobFileProvider(context)
                provider = New clsBlobFileClient(context, ContainerName, mFileProvider)
            Case Else
                provider = MyBase.FileProviderClient(context, ContainerName, ProviderCode)
        End Select
        Return provider
    End Function

    Public Overrides Function CreateDataProvider(context As clsAppController, cb As IAsyncWCFCallBack) As IAppDataProvider
        Dim Provider As IAppDataProvider = ProviderFactory.CreateDataProvider(context, cb)
        Return Provider
    End Function
    Public Overrides Function dicFormModelTypes() As clsCollecString(Of Type)
        If dicFormModel Is Nothing Then
            dicFormModel = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicFormModel, GetType(frmImportFileNewModel).Assembly, GetType(clsFormDataModel))
            Me.AddTypeAssembly(dicFormModel, GetType(frmCommitteeMeetingModel).Assembly, GetType(clsFormDataModel))

        End If
        Return dicFormModel
    End Function

    Public Overrides Sub UpdateSettings(s As risersoft.shared.myAppSettings)
        s.RequireAppModel = True
        s.CheckDLL = False
        s.RelateLoginPerson = False
    End Sub

    Public Overrides Function dicReportProviderTypes(myContext As clsAppController) As clsCollecString(Of Type)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function dicTaskProviderTypes() As clsCollecString(Of Type)
        If dicTaskProvider Is Nothing Then
            dicTaskProvider = New clsCollecString(Of Type)
            'Me.AddTypeAssembly(dicTaskProvider, GetType(Import_AdmissionTaskProvider).Assembly, GetType(clsTaskProviderBase))
        End If
        Return dicTaskProvider
    End Function

    Public Overrides Function QueueProvider(context As IProviderContext) As IQueueProvider
        If (mQueueProvider Is Nothing) Then mQueueProvider = New clsLocalQueueProvider(context)
        Return mQueueProvider
    End Function

    Public Overrides Function OnAppInit(oApp As clsCoreApp) As Boolean
        Dim q = New clsLocalQueueProvider(oApp.Controller)
        mQueueProvider = q
        cts = New CancellationTokenSource
        Dim ct = cts.Token
        q.ConfigureListener(ct, Async Function(dic As Dictionary(Of String, String)) As Task(Of clsProcOutput)
                                    Return Await Task.Run(Async Function()
                                                              Dim scheduler = New clsTaskScheduler(oApp, True)
                                                              Dim apitaskId = dic("apitaskid")
                                                              Dim oRet2 = Await scheduler.ExecuteLocalApiTask(apitaskId)
                                                              Return oRet2
                                                          End Function)
                                End Function)
        Return MyBase.OnAppInit(oApp)
    End Function

    Public Overrides Function OnAppClose(oApp As clsCoreApp) As Boolean
        cts.Cancel()
        ChromeHandler.Shutdown()
        Return MyBase.OnAppClose(oApp)
    End Function

    Public Overrides Function fBrowser() As IMxBrowser
        Dim fx As New BrowserForm
        fx.MakeDownLevel()
        Return fx
    End Function
    Public Overrides Function LoadAppData(context As IProviderContext, dataKey As String, Params As List(Of clsSQLParam), forcefresh As Boolean) As clsProcOutput
        Return myTrustFuncs.LoadAppData(context, dataKey, Params, forcefresh, Function()
                                                                                  Return MyBase.LoadAppData(context, dataKey, Params, forcefresh)
                                                                              End Function)
    End Function

    Public Overrides Function CreateLogger(context As IProviderContext) As ILogger
        Return myWinUtils2.CreateLogger(context)
    End Function

    Public Overrides Function AppBarFieldList() As IDictionary(Of String, String)
        Dim dic As New Dictionary(Of String, String)(StringComparer.InvariantCultureIgnoreCase)
        dic.Add("companyid", "cid")
        Return dic
    End Function
End Class