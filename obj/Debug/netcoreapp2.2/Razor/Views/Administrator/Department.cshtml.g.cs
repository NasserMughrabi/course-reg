#pragma checksum "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Department.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e0f55e46c1b012b83d31a3fbf4e9ad4a7465b80b9c785bb855063bf174a5aafe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_Department), @"mvc.1.0.view", @"/Views/Administrator/Department.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrator/Department.cshtml", typeof(AspNetCore.Views_Administrator_Department))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e0f55e46c1b012b83d31a3fbf4e9ad4a7465b80b9c785bb855063bf174a5aafe", @"/Views/Administrator/Department.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3629c37afbf004bcaf871b2c32b6c964131444b57f92dcfe61762b65de21a6a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_Department : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Department.cshtml"
  
  ViewData["Title"] = "Department";
  Layout = "~/Views/Shared/AdministratorLayout.cshtml";

#line default
#line hidden

            BeginContext(98, 31, true);
            WriteLiteral("\n<h4 id=\"classname\">Courses in ");
            EndContext();
            BeginContext(130, 19, false);
            Write(
#line 7 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Department.cshtml"
                               ViewData["subject"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(149, 910, true);
            WriteLiteral(@"</h4>

<div id=""departmentDiv"" class=""col-md-12"">
  <div class=""panel panel-primary"">
    <div class=""panel-heading"">
      <h3 class=""panel-title""></h3>
    </div>
    <div class=""panel-body"">
      <table id=""tblCourses"" class=""table table-bordered table-striped table-responsive table-hover"">
        <thead>
          <tr>
            <th align=""left"" class=""productth"">Number</th>
            <th align=""left"" class=""productth"">Name</th>
          </tr>
        </thead>
        <tbody></tbody>
      </table>
    </div>
  </div>
</div>


<div class=""col-md-12"">
  <div class=""panel panel-primary"">
    <div class=""panel-heading"">
      <h3 class=""panel-title"">New Course</h3>
    </div>
    <div class=""panel-body"">
      <div class=""form-group col-md-5"">
        <label>Course Name</label>
        <input type=""text"" name=""CourseName"" id=""CourseName"" class=""form-control"" placeholder=""Enter course name""");
            EndContext();
            BeginWriteAttribute("required", " required=\"", 1059, "\"", 1070, 0);
            EndWriteAttribute();
            BeginContext(1071, 213, true);
            WriteLiteral(" />\n      </div>\n      <div class=\"form-group col-md-5\">\n        <label>Course Number</label>\n        <input type=\"text\" name=\"CourseNumber\" id=\"CourseNumber\" class=\"form-control\" placeholder=\"Enter course number\"");
            EndContext();
            BeginWriteAttribute("required", " required=\"", 1284, "\"", 1295, 0);
            EndWriteAttribute();
            BeginContext(1296, 297, true);
            WriteLiteral(@" />
      </div>

      <div class=""form-group col-md-1"">
        <div style=""float: right; display:inline-block;"">
          <input class=""btn btn-primary"" name=""submitButton"" id=""btnSave"" value=""Add"" type=""button"" onclick=""AddCourse()"">
        </div>
      </div>
    </div>
  </div>
</div>



");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1613, 231, true);
                WriteLiteral("\n    <script type=\"text/javascript\">\n\n    LoadData();\n\n    function AddCourse() {\n\n      var corName = $(\"#CourseName\").val();\n      var corNum = Number($(\"#CourseNumber\").val());\n      $.ajax({\n        type: \'POST\',\n        url: \'");
                EndContext();
                BeginContext(1845, 43, false);
                Write(
#line 67 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Department.cshtml"
               Url.Action("CreateCourse", "Administrator")

#line default
#line hidden
                );
                EndContext();
                BeginContext(1888, 65, true);
                WriteLiteral("\',\n        dataType: \'json\',\n        data: {\n          subject: \'");
                EndContext();
                BeginContext(1954, 19, false);
                Write(
#line 70 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Department.cshtml"
                     ViewData["subject"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(1973, 971, true);
                WriteLiteral(@"',
          number: corNum,
          name: corName},
        success: function (data, status) {
          //alert(JSON.stringify(data));
          if (!data.success) {
            alert(""Unable to add course"");
          }
          LoadData();
        },
          error: function (ex) {
            alert(""CreateCourse controller did not return successfully"");
        }
        });

    }

    function PopulateTable(tbl, offerings) {
      var newBody = document.createElement(""tbody"");

      offerings.sort(function (a, b) {
        return a.number - b.number;
      });

      $.each(offerings, function (i, item) {
        var tr = document.createElement(""tr"");

        var td = document.createElement(""td"");
        td.appendChild(document.createTextNode(item.number));
        tr.appendChild(td);

        var td = document.createElement(""td"");
        var a = document.createElement(""a"");
        a.setAttribute(""href"", ""/Administrator/Course/?subject="" + '");
                EndContext();
                BeginContext(2945, 19, false);
                Write(
#line 103 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Department.cshtml"
                                                                     ViewData["subject"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(2964, 445, true);
                WriteLiteral(@"' + ""&num="" + item.number);
        a.appendChild(document.createTextNode(item.name));
        td.appendChild(a);
        tr.appendChild(td);

        newBody.appendChild(tr);
      });

      tbl.appendChild(newBody);

    }

    function LoadData() {

      var tbl = document.getElementById(""tblCourses"");
      var body = tbl.getElementsByTagName(""tbody"")[0];
      tbl.removeChild(body);

      $.ajax({
        type: 'POST',
        url: '");
                EndContext();
                BeginContext(3410, 41, false);
                Write(
#line 123 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Department.cshtml"
               Url.Action("GetCourses", "Administrator")

#line default
#line hidden
                );
                EndContext();
                BeginContext(3451, 65, true);
                WriteLiteral("\',\n        dataType: \'json\',\n        data: {\n          subject: \'");
                EndContext();
                BeginContext(3517, 19, false);
                Write(
#line 126 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Administrator/Department.cshtml"
                     ViewData["subject"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(3536, 305, true);
                WriteLiteral(@"'
        },
          success: function (data, status) {
            //alert(JSON.stringify(data));
            PopulateTable(tbl, data);
          },
          error: function (ex) {
              alert(""GetCourses controller did not return successfully"");
          }
        });
    }

    </script>

");
                EndContext();
            }
            );
            BeginContext(3843, 2, true);
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
