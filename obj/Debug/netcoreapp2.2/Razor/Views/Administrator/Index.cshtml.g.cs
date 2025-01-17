#pragma checksum "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "027c02fbd929b7952c2f9fc3bd4622d948965d7b71d68bd3a3fc1434601e6676"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_Index), @"mvc.1.0.view", @"/Views/Administrator/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrator/Index.cshtml", typeof(AspNetCore.Views_Administrator_Index))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

    ;
#line 2 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/_ViewImports.cshtml"
using LMS

    ;
#line 3 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/_ViewImports.cshtml"
using LMS.Models

    ;
#line 4 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/_ViewImports.cshtml"
using LMS.Models.AccountViewModels

    ;
#line 5 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/_ViewImports.cshtml"
using LMS.Models.ManageViewModels

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"027c02fbd929b7952c2f9fc3bd4622d948965d7b71d68bd3a3fc1434601e6676", @"/Views/Administrator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3629c37afbf004bcaf871b2c32b6c964131444b57f92dcfe61762b65de21a6a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdministratorLayout.cshtml";

#line default
#line hidden

            BeginContext(97, 59, true);
            WriteLiteral("\n<h2>Departments</h2>\n\n<ul id=\"lstDepartments\">\n</ul>\n\n\n\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(176, 786, true);
                WriteLiteral(@"
  <script type=""text/javascript"">

    LoadData();


    function PopulateList(lst, departments) {

      departments.sort(function (a, b) {
        return a.subject.localeCompare(b.subject);

      });

      $.each(departments, function (i, item) {
        var li = document.createElement(""li"");
        var td = document.createElement(""td"");
        var a = document.createElement(""a"");
          a.setAttribute(""href"", ""/Administrator/Department/?subject="" + item.subject);
        a.appendChild(document.createTextNode(item.subject));
        li.appendChild(a);
        lst.appendChild(li);
      });

      tbl.appendChild(newBody);

    }

    function LoadData() {

      var lst = document.getElementById(""lstDepartments"");

      $.ajax({
        type: 'POST',
        url: '");
                EndContext();
                BeginContext(963, 38, false);
                Write(
#line 50 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Index.cshtml"
               Url.Action("GetDepartments", "Common")

#line default
#line hidden
                );
                EndContext();
                BeginContext(1001, 324, true);
                WriteLiteral(@"',
        dataType: 'json',
        success: function (data, status) {

          PopulateList(lst, data);

          //alert(JSON.stringify(data));
          
        },
          error: function (ex) {
              alert(""GetDepartments controller did not return successfully"");
        }
        });
    }

  </script>
");
                EndContext();
            }
            );
            BeginContext(1327, 2, true);
            WriteLiteral("\n\n");
            EndContext();
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
