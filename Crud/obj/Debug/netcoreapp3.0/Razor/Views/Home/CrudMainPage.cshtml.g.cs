#pragma checksum "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Home\CrudMainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31b28e7e2e7b784a9a75f4cdee85d11d69cf2337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CrudMainPage), @"mvc.1.0.view", @"/Views/Home/CrudMainPage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\_ViewImports.cshtml"
using Crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\_ViewImports.cshtml"
using Crud.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\_ViewImports.cshtml"
using Crud.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b28e7e2e7b784a9a75f4cdee85d11d69cf2337", @"/Views/Home/CrudMainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bbd9a5d19f14dede8e4ee7492bcfc4938901832", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CrudMainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Home\CrudMainPage.cshtml"
  
    ViewData["Title"] = "CrudMainPage";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Latest compiled and minified CSS -->
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">

<!-- jQuery library -->
<script src=""//code.jquery.com/jquery-1.12.4.js""></script>

<!-- Latest compiled JavaScript -->
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>

<!-- add thids links for the error message-->
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/1.3.1/css/toastr.css"" />
<script src=""http://cdnjs.cloudflare.com/ajax/libs/toastr.js/1.3.1/js/toastr.js""></script>


<!--add this link for the datatable-->
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/1.10.16/css/dataTables.bootstrap.min.csss"" rel=""stylesheet"" />

<script src=""https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.16/js/dataTables.bootstrap.min.js");
            WriteLiteral(@"""></script>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/4.4.0/bootbox.min.js"" integrity=""sha256-4F7e4JsAJyLUdpP7Q8Sah866jCOhv72zU5E8lIRER4w="" crossorigin=""anonymous""></script>






<div class=""col-md-12"">
<div class=""col-md-4""></div>
<div class=""col-md-4"">
    <div class=""col-md-12"">
        <label>Product Name :</label>
        <input class=""form-control required"" type=""text"" id=""txtName"" required />
    </div>
    <div class=""col-md-12"">
        <label>FatherName :</label>
        <textarea class=""form-control required"" id=""txtFatherName""></textarea>
    </div>    
    <div class=""col-md-12"">
        <label>CNIC :</label>
        <textarea class=""form-control required"" id=""txtCNIC""></textarea>
    </div>  
    <div class=""col-md-12"">
        <label>Location :</label>
        <textarea class=""form-control required"" id=""txtLocation""></textarea>
    </div> 

    <div class=""col-md-12"">
        <label>Age:</label>
        <input class=""form-control required"" i");
            WriteLiteral("d=\"txtAge\" type=\"text\" required />\r\n    </div>\r\n");
            WriteLiteral(@"    <div class=""col-md-12"">
        <br />
        <input id=""btnSave"" class=""btn btn-success"" type=""button"" value=""Save Product"" />
        <input id=""btnCancel"" class=""btn btn-danger"" type=""button"" value=""Cancel"" />

    </div>

</div>
<div class=""col-md-4""></div>
</div>

<div class=""col-md-12"">
    <table id=""tblProduct"" class=""table table-striped table-bordered"" width=""100%"">
        <thead>
            <tr>

                <th>ID</th>
                <th>Name</th>
                <th>Father Name</th>
                <th>Location</th>
                <th>Age</th>

            </tr>
        </thead>

    </table>
</div>
");
            WriteLiteral("<input type=\"hidden\" id=\"hdnPID\" value=\"0\" />\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
    $(document).ready(function () {
     windowResize();
        $(window).resize(function () {
            windowResize();
        });
        $('#toast-container').find('.toast-top-center').removeClass('.toast-top-center');
        toastr.options = {
            ""closeButton"": true,
            'autoWidth': false,
            ""debug"": false,
            ""newestOnTop"": true,
            ""progressBar"": true,
            ""positionClass"": ""toast-top-center"",
            ""preventDuplicates"": false,
            ""onclick"": null,
            ""showDuration"": ""300"",
            ""hideDuration"": ""1000"",
            ""timeOut"": ""3000"",
            ""extendedTimeOut"": ""1000"",
            ""showEasing"": ""swing"",
            ""hideEasing"": ""linear"",
            ""showMethod"": ""fadeIn"",
            ""hideMethod"": ""fadeOut""
        }

        $(""#btnSave"").click(function () {
            var PID = $(""#hdnPID"").val();
            var Name = $(""#txtName"").val();
    ");
                WriteLiteral(@"        var FatherName = $(""#txtFatherName"").val();
            var Age = $(""#txtAge"").val();
            var CNIC = $(""#txtCNIC"").val();
            var Location = $(""#txtLocation"").val();
            if (CheckRequiredFields()) {

                $('#dvLoader').show();
                $.ajax({
                    url: '");
#nullable restore
#line 139 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Home\CrudMainPage.cshtml"
                     Write(Url.Action("SaveAndUpdateProduct", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        type: 'POST',
                        data: JSON.stringify({ ""PID"": parseInt(PID), ""Name"": Name, ""FatherName"": FatherName,""Location"":Location,""CNIC"":CNIC, ""Age"": parseInt(Age) }),
                        dataType: ""json"",
                        contentType: ""application/json; charset=utf-8"",
                        success: function (result) {
                            $('#dvLoader').hide();

                            if (result.Status == ""True"") {
                                toastr.success(result.Message);
                                clear();
                                display();
                            }
                            else {
                                toastr.success(result.Message);
                                clear();
                                display();

                            }
                        }
                    });

                }

        });

        $(""#btnCancel"").click(function");
                WriteLiteral(@" () {
            clear();
        });

    });

        function clear() {
            $(""#txtName"").val("""");
            $(""#txtFatherName"").val("""");
            $(""#txtAge"").val("""");
            $(""#txtCNIC"").val("""");
            $(""#txtLocation"").val("""");
            $('#btnSave').val(""Save Product"");
            $(""#hdnPID"").val(0);

        }

    function CheckRequiredFields() {
            var isValid = true;
            $('.required').each(function () {
                if ($.trim($(this).val()) == '') {
                    isValid = false;
                    $(this).addClass('red_border');


                }
                else {
                    $(this).removeClass('red_border');

                }
            });
            return isValid;
        }
           function checkemail(valemail) {
            var forgetfilter = /^([\w-\.]+)");
                WriteLiteral(@"@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
            if (forgetfilter.test(valemail)) {
                return true;
            }
            else {
                return false;
            }
        }


  function display() {
            $('#dvLoader').show();
            Table = $('#tblProduct').DataTable({

                ""processing"": true,
                ""serverSide"": false,
                ""paging"": true,
                ""ordering"": true,
                ""info"": true,
                ""searching"": true,
                ""bFilter"": false,
                ""scrollX"": ""100%"",
                ""scrollY"": ($(window).height() - 500),
                ""sScrollXInner"": ""100%"",
                ""bScrollCollapse"": true,
                ""sAjaxSource"": '");
#nullable restore
#line 224 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Home\CrudMainPage.cshtml"
                           Write(Url.Action("GetProduct","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                ""bDestroy"": true,
                ""bLengthChange"": true,
                ""bPaginate"": true,
                ""sEmptyTable"": ""Loading data from server"",

                ""columns"": [
                     
                    {
                        ""sWidth"": ""5%"",
                        ""sClass"": ""TextCenter PID"",
                        ""render"": function (data, type, row) {
                            return row[0];
                        }
                    },
                    { ""sWidth"": ""5%"", ""sClass"": ""TextCenter Name"", ""render"": function (data, type, row ) { return (row[1]); } },
                    { ""sWidth"": ""5%"", ""sClass"": ""TextCenter Desc"", ""render"": function (data, type, row ) { return (row[2]); } },
                    { ""sWidth"": ""5%"", ""sClass"": ""TextCenter Price"", ""render"": function (data, type, row ) { return (row[3]); } },

                     {
                         ""bSortable"": false,
                         ""sClass"": ""TextCenter"",
     ");
                WriteLiteral(@"                    ""sWidth"": ""3%"",
                         ""render"": function (data, type, row) {
                             return '<center><a href=""javascript:void(0);""  onclick=deleteData(""' + row[0] + '""); return false;> <i class=""glyphicon glyphicon-trash""></i></a>&nbsp;&nbsp;<a href=""javascript:void(0);""  onclick=EditData(this); return false;> <i class=""glyphicon glyphicon-edit""></i></a></center>';
                         }, ""targets"": 0,
                     }

                ],
              
            });
            $('#dvLoader').hide();
        }

    function isNumberKey(evt) {
       var charcode = (evt.which) ? evt.which : evt.keycode
       if (charcode > 31 && (charcode < 48 || charcode > 58)
           && evt.keyCode != 35 && evt.keyCode != 36 && evt.keyCode != 37
           && evt.keyCode != 38 && evt.keyCode != 39 && evt.keyCode != 40
           && evt.keyCode != 46) {
           return false;
       }
       else {
           return true;
       }
        }");
                WriteLiteral(@"

        function deleteData(id) {
        var PID = parseInt(id);
        bootbox.confirm({
            title: 'Remove Customer',
            message: 'Are you sure want to delete this record?',
            buttons: {
                'cancel': {
                    label: 'No',
                    className: 'btn-default pull-right'
                },
                'confirm': {
                    label: 'Yes',
                    className: 'btn-primary margin-right-5'
                }
            },
            callback: function (result) {
                if (result) {
                    $('#dvLoader').show();
                    $.ajax({
                        url: '");
#nullable restore
#line 290 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Home\CrudMainPage.cshtml"
                         Write(Url.Action("DeleteProduct", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        type: 'POST',
                        data: JSON.stringify({ ""id"": id }),
                        contentType: 'application/json; charset=utf-8;',
                        success: function (result) {
                            windowResize();
                            $('#dvLoader').hide();

                            if (result.Status == ""True"") {
                                toastr.success(result.Message);
                                clear();
                            }
                            else {
                                toastr.success(result.Message);

                            }
                        }
                    });
                }
            }
        });
    }
    function EditData(row) {
        debugger
        var PID = $(row).closest('tr').find('.ID').html();
        $(""#hdnPID"").val(parseInt(PID));

        var Name = $(row).closest('tr').find('.Name').html();
        $('#txtName').val(Name);

    ");
                WriteLiteral(@"    var Desc = $(row).closest('tr').find('.FatherName').html();
        $('#txtFatherName').val(Desc);

        var Price = $(row).closest('tr').find('.Age').html();
        $('#txtAge').val(Price);

        $('#btnSave').val(""Update Product"");
    }
    function isNumberKey(evt) {
        var charcode = (evt.which) ? evt.which : evt.keycode
        if (charcode > 31 && (charcode < 48 || charcode > 58)
            && evt.keyCode != 35 && evt.keyCode != 36 && evt.keyCode != 37
            && evt.keyCode != 38 && evt.keyCode != 39 && evt.keyCode != 40
            && evt.keyCode != 46) {
            return false;
        }
        else {
            return true;
        }
    }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
