var submitUri = null;
var bar = $('.progress-bar');
var percent = $('.percent');
var _fileName = "";
var fileSize = "";
var pFileId = "";
var iFileId = "";
var lstModifiedDateTime = "";

var msgHTML = '<div class="form-group" style="min-height: 75px;font-size: 10px;background-color: #efefef;" id="messagePanel">';
msgHTML += '<div class="col-md-12"><a href="#" class="delete" id="removeCurrentDiv">';
msgHTML += '<span class="fa fa-remove" style="color: #d83e3b;margin-right: 8px;"></span>';
msgHTML += '</a><div class="row" style="padding-top:5px;">';
msgHTML += '<div id="executedMsg" style="padding:5px;"></div>';
msgHTML += '<i class="fa fa-2x fa-link" style="color:green; display:none; padding: 5px;" id="downloadLink"></i>';
msgHTML += '</div></div></div>';

$scope.$watch('fileStatus', function (fileStatus) {
    if (fileStatus) {
        var valNew = fileStatus.split('===');
        var sSuccessMsg = valNew[0];
        var sFileName = valNew[1];
        if (sSuccessMsg) {
            $scope.IsInitializing = true;
            $scope.checkStatusInterval(sSuccessMsg, sFileName, sFileName.split('==')[3], sFileName.split('==')[6]);
        }
    }
});

$scope.checkStatusInterval = function (valMsg, flName, contnetUnit, fstatus) {
    if (contnetUnit == "true") {
        if (valMsg == "success") {
            if (fstatus == 'fileStatus') {
                //$('#spnMsg').html("<i class='fa fa-check-circle fa-2x' style='color: green'></i>  Your file has been uploaded successfully, if you want to upload another file so please continue with same process.");
                //$scope.isShowMsg = true;
                $scope.UploadFiles.push({ bloborgname: $('#attach_filename').val().split('\\')[2], blobname: flName.split("==")[0], filesize: (flName.split("==")[1] / 1024), lastmodified: new Date(flName.split("==")[2] * 1000).toGMTString(), blobUrl: flName.split("==")[4], UploadType: flName.split("==")[5], Url: $('#attach_filename').val().split('\\')[2], isDeleted: true });
            }
            else if (fstatus == 'academicCalender') {
                if (Array.isArray($scope.AcademicCalender) && $scope.AcademicCalender.length > 0) {
                    $scope.AcademicCalender = [];
                }
                $scope.AcademicCalender.push({ bloborgname: $('#filename').val().split('\\')[2], blobname: flName.split("==")[0], filesize: (flName.split("==")[1] / 1024), lastmodified: new Date(flName.split("==")[2] * 1000).toGMTString(), blobUrl: flName.split("==")[4], UploadType: flName.split("==")[5], Url: $('#filename').val().split('\\')[2] });
                //console.log($scope.AcademicCalender);
                $('#filename').val('');
            }
            else if (fstatus == 'brochureStatus') {
                if (Array.isArray($scope.BrochureFile) && $scope.BrochureFile.length > 0) {
                    $scope.BrochureFile = [];
                }
                $scope.BrochureFile.push({ bloborgname: $('#attach_brochure').val().split('\\')[2], blobname: flName.split("==")[0], filesize: (flName.split("==")[1] / 1024), lastmodified: new Date(flName.split("==")[2] * 1000).toGMTString(), blobUrl: flName.split("==")[4], UploadType: flName.split("==")[5], Url: $('#attach_brochure').val().split('\\')[2] });
                //console.log($scope.Brochure);
                $('#attach_brochure').val('');
            }
            else if (fstatus == "collegeProspectus") {
                if (Array.isArray($scope.UploadFiles) && $scope.UploadFiles.length > 0) {
                    $scope.UploadFiles = [];
                }
                $scope.UploadFiles.push({ bloborgname: $('#attach_filename').val().split('\\')[2], blobname: flName.split("==")[0], filesize: (flName.split("==")[1] / 1024), lastmodified: new Date(flName.split("==")[2] * 1000).toGMTString(), blobUrl: flName.split("==")[4], UploadType: flName.split("==")[5], Url: $('#attach_filename').val().split('\\')[2], isDeleted: true });
            }
            else if (fstatus == "studentPic") {
                if (Array.isArray($scope.UploadFiles) && $scope.UploadFiles.length > 0) {
                    $scope.UploadFiles = [];
                }
                $scope.UploadFiles.push({ bloborgname: $('#attach_filename').val().split('\\')[2], blobname: flName.split("==")[0], filesize: (flName.split("==")[1] / 1024), lastmodified: new Date(flName.split("==")[2] * 1000).toGMTString(), blobUrl: flName.split("==")[4], UploadType: flName.split("==")[5], Url: $('#attach_filename').val().split('\\')[2], isDeleted: true });
            }

            $('#attach_filename').val('');

            $("div.spinnerTarget").removeClass("backdrop");
            $("body").css("overflow", "auto");
            usSpinnerService.stop('spinner-1');
        }
    }
}

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#imgInp').attr('src', e.target.result);
        }
        reader.readAsDataURL(input.files[0]); // convert to base64 string
    }
}

$("#attach_filename").change(function () {
    readURL(this);
});

function toDataURL(url, callback) {
    var xhr = new XMLHttpRequest();
    xhr.onload = function () {
        var reader = new FileReader();
        reader.onloadend = function () {
            callback(reader.result);
        }
        reader.readAsDataURL(xhr.response);
    };
    xhr.open('GET', url);
    xhr.responseType = 'blob';
    xhr.send();
}

$scope.deleteRow = function (index) {
    $scope.UploadFiles.splice(index, 1);
}

$scope.stopFight = function (stop) {
    $interval.cancel(stop);
    console.log('stop');
    $scope.IsInitializing = false;
};
