@imports risersoft.shared.web.Extensions
@imports risersoft.shared.web
@imports risersoft.shared.portable
@imports risersoft.shared.cloud.common
@Imports risersoft.shared
@imports System.Data
@imports risersoft.shared.cloud
@imports risersoft.shared.agent
@imports risersoft.shared.agent.auth

@Code
    Dim _user = AuthUtils.GetRSUser(Me.User)
    Dim mobile = myUtils.cValTN(Request.QueryString("mobile"))
    Dim ctx = CType(ViewContext.Controller, IHostedController).myWebController
    Dim dic = ctx.GetAppInfo.AppBarValues
    Dim objCmp = dic.Where(Function(x) myUtils.IsInList(x.FieldName, "companyid")).FirstOrDefault
    Dim dt1 = ctx.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, "select companyid,compname,pannum from company order by compname").Tables(0)
    Dim CompName = If((objCmp IsNot Nothing) AndAlso (objCmp.dicValues.ContainsKey("compname")), objCmp.dicValues("CompName"), ctx.DataProvider.GetSystemOption("compgroupname").Result)
    Dim PANNum = If((objCmp IsNot Nothing) AndAlso (objCmp.dicValues.ContainsKey("pannum")), objCmp.dicValues("PANNum"), "Group")
End Code

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title")</title>
    @Html.RenderJsCss(False, "modernizr", "jquery", "bootstrap", "angular", "ig", "rs")
    @RenderSection("scripts", required:=False)
    @Html.RenderScripts(True, True)
    <style>
        div.spinnerTarget.backdrop {
            width: 100%;
            min-height: 1500px;
            position: absolute;
            background-color: #f7f7f7;
            opacity: 0.8;
            z-index: 99999;
        }
    </style>
</head>
<body ng-app="rsApp">
    <div class="spinnerTarget" us-spinner="{top:'30%', radius:30, width:8, length: 16}" spinner-key="spinner-1" spinner-theme="smallBlue"></div>
    @If Not _user Is Nothing Then
        @<div Class="top-header-navigation">
            <div id="appbar" class="" style="top: 0px;border-color: #fff;">
                <div class="" style="margin-left: 47px;">
                    <div class="row" style="margin-right:0px">


                        <div class="col-md-2"></div>
                        <div class="col-md-5" style="margin-top: 15px;">
                            <h4 class="" style="text-decoration:none;margin-right: 4px;font-size:19px;color:#0091da;display: inline-block;" href="#" aria-expanded="false">
                                @CompName
                            </h4>
                            <h5 class="" style="text-decoration:none;display: inline-block;" href="#" aria-expanded="false">
                                @PANNum
                            </h5>
                            <a class="clscomp" href="#" aria-expanded="false">
                                Change
                            </a>
                        </div>
                        <div class="col-md-4">
                            <div class="navbar navbar-expand-md" style="float:right;margin-top: 8px;">
                                <a class="fa fa-user active chnt" data-toggle="dropdown" style="text-decoration:none;margin-top: 5px;" href="#" aria-expanded="false"> <span class="caret"></span></a>
                                <ul class="dropdown-menu dropdown-men" style="left:-115px;">
                                    <li> <a class="dropdown-item" href="/account/change">Manage</a></li>
                                    <li> <a class="dropdown-item" href="/account/Logout">Logout</a></li>
                                </ul>
                            </div>
                            <a Class="chnt" style="text-decoration:none;margin-top: 8px;" href="#" aria-expanded="false">
                                @_user.FullName
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    Else
        @<ul Class="header-item">
            <li>
                <a href="/Account/Login">Login</a>
            </li>
            <li>
                <a href="Account/signup">Signup</a>
            </li>
        </ul>
    End If

    @Html.Menu(ctx)

    <div class="clsmargn">
        @RenderBody()
        <div id="dialogFilter" title="Filter"></div>

        <div id="dialogcFilter">
            <input type="text" id="filter" class="form-control dispn" autocomplete="off" />
            <ul class="dropdown-menc dispn filtertable">
                @For Each r1 In dt1.Select
                    @Code
                        Dim str1 As String = "/App" & Html.QueryString("cid", r1("companyid")).ToHtmlString
                    End code
                    @<li> <a href="@str1">@r1("compname") - @r1("pannum")</a></li>
                Next
            </ul>
        </div>
        <footer class="fcls">
            <p>&copy; @DateTime.Now.Year - @ctx.Controller.CalcPublisher</p>
        </footer>
    </div>
    <ul id="id_context2" style="display: none;">
        <li data-command="action1">Fetching Data ...</li>
    </ul>
    @RenderSection("BotScripts", required:=False)

    <script type="text/javascript">
        $(document).ready(function () {

            $('.navbar-nav').removeClass('nav');
            $(window).bind('scroll', function () {
                if ($(window).scrollTop() > 31) {

                    $('.navbar-fixed-top').addClass('navbar-fixed-top-change');
                    $('.top-line-move').addClass('fixed');
                }
                else {

                    $('.navbar-fixed-top').removeClass('navbar-fixed-top-change');
                    $('.top-line-move').removeClass('fixed');
                }
            });
            $(window).bind('scroll', function () {
                if ($(window).scrollTop() > 50) {

                    $('.navbar-fixed-top').addClass('navbar-fixed-top-change');
                    $('.top-line-move').addClass('fixed');
                }
                else {

                    $('.navbar-fixed-top').removeClass('navbar-fixed-top-change');
                    $('.top-line-move').removeClass('fixed');
                }
            });




            $('.clscomp').on('click', function () {
                $("#dialogcFilter").dialog({
                    autoOpen: false,
                    modal: true,
                    width: 400,
                    hide: {
                        effect: "fade",
                        duration: 1000
                    }
                });

                $('.dropdown-menc').addClass('dispc');
                $('#filter').addClass('dispc');
                $("#dialogcFilter").dialog("open");
                return false;
            });
        });
        function tablehtml(table) {

            var thtml = "<tr>";
            for (var k in table[0]) {
                thtml += "<th>" + k + "</th>";
            }
            thtml += "</tr>";
            $.each(table, function (index, value) {
                var TableRow = "<tr>";
                $.each(value, function (key, val) {
                    TableRow += "<td>" + val + "</td>";
                });
                TableRow += "</tr>";
                thtml += TableRow;;
            });
            return thtml;
        }

    </script>
</body>
</html>
