#pragma checksum "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Simple\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cea86e04dd4b07d840b07e5a30b3f470a680602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Simple_Main), @"mvc.1.0.view", @"/Views/Simple/Main.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cea86e04dd4b07d840b07e5a30b3f470a680602", @"/Views/Simple/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bbd9a5d19f14dede8e4ee7492bcfc4938901832", @"/Views/_ViewImports.cshtml")]
    public class Views_Simple_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrudViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Simple\Main.cshtml"
  
    ViewData["Title"] = "Main";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered \">\r\n    <thead class=\"bg-primary\">\r\n        <tr>\r\n            <th colspan=\"4\">\r\n                <span>");
#nullable restore
#line 11 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Simple\Main.cshtml"
                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" [<a id=""addnewlink"" href=""/Simple/create"" data-caption=""Add New Neighbourhood Area""> Add New </a> ]</span>

            </th>
        </tr>
        <tr>
            <th class=""col-lg-3 col-md-3 col-sm-3  hidden-xs"">
                <span> Name</span>
            </th>
            <th class=""col-lg-5  col-md-5 col-sm-5 col-xs-8"">
                <span>Father Name</span>
                <span class=""pull-right"">
                    <input id=""searchtext"" type=""text"" class=""text-primary"" placeholder=""Search by father Name"" />
                </span>
            </th>
            <th class=""col-lg-4 col-md-4 col-sm-3 col-xs-4"">Actions</th>
        </tr>
    </thead>
    <tbody id=""tablebody"">
");
#nullable restore
#line 29 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Simple\Main.cshtml"
         foreach (var n in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"col-lg-5 col-md-5 col-sm-6 col-xs-8\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Simple\Main.cshtml"
               Write(n.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-lg-3 col-md-3 col-sm-3 hidden-xs\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Simple\Main.cshtml"
               Write(n.FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-lg-3 col-md-3 col-sm-3 col-xs-4\">\r\n\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1348, "\"", 1373, 2);
            WriteAttributeValue("", 1355, "/Simple/Edit/", 1355, 13, true);
#nullable restore
#line 40 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Simple\Main.cshtml"
WriteAttributeValue("", 1368, n.Id, 1368, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dg-btnedit btn btn-xs btn-warning\" data-caption=\"Edit Country\"><span class=\"glyphicon glyphicon-edit\"></span></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1519, "\"", 1546, 2);
            WriteAttributeValue("", 1526, "/Simple/Delete/", 1526, 15, true);
#nullable restore
#line 41 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Simple\Main.cshtml"
WriteAttributeValue("", 1541, n.Id, 1541, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dg-btndelete btn btn-xs btn-danger\" data-caption=\"Do you want to delete this record?\"><span class=\"glyphicon glyphicon-trash\"></span></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\IMR\Source\Repos\Crud ajax\Crud\Views\Simple\Main.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(""#addnewlink,.dg-btnedit,.dg-btndelete"").click(function (event) {
            event.preventDefault();
            var myurl = $(this).attr(""href"");
            var caption = $(this).data(""caption"");
            $.ajax(
                {
                    url: myurl
                }
            ).done(function (result) {
                $(""#mydialog-title"").html(caption);
                $(""#mydialog-body"").html(result);
                $(""#mydialog"").modal();
            });
        });
        $(""#searchtext"").keyup(function () {
            var keyword = $(this).val();
            $.ajax(
                {
                    url: ""/Simple/filter?key="" + keyword
                }
            ).done(function (result) {
                $(""#tablebody"").html(result);
            });
        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrudViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
