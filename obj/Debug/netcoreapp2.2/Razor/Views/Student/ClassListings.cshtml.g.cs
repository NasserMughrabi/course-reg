#pragma checksum "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bfce5f36c67dd6012b6d8f6051918ec2796c584804d3d84f4af54024699faa75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ClassListings), @"mvc.1.0.view", @"/Views/Student/ClassListings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/ClassListings.cshtml", typeof(AspNetCore.Views_Student_ClassListings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bfce5f36c67dd6012b6d8f6051918ec2796c584804d3d84f4af54024699faa75", @"/Views/Student/ClassListings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3629c37afbf004bcaf871b2c32b6c964131444b57f92dcfe61762b65de21a6a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_ClassListings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml"
  
    ViewData["Title"] = "ClassListings";
    Layout = "~/Views/Shared/StudentLayout.cshtml";

#line default
#line hidden

            BeginContext(99, 817, true);
            WriteLiteral(@"
<h4 id=""classname"">ClassListings</h4>

<div id=""departmentDiv"" class=""col-md-12"">
    <div class=""panel panel-primary"">
        <div class=""panel-heading"">
            <h3 class=""panel-title""></h3>
        </div>
        <div class=""panel-body"">
            <table id=""tblClasses"" class=""table table-bordered table-striped table-responsive table-hover"">
                <thead>
                    <tr>
                        <th align=""left"" class=""productth"">Semester</th>
                        <th align=""left"" class=""productth"">Location</th>
                        <th align=""left"" class=""productth"">Time</th>
                        <th align=""left"" class=""productth"">Instructor</th>
                        <th align=""left"" class=""productth"">Options</th>
                    </tr>
                </thead>
");
            EndContext();
            BeginContext(952, 57, true);
            WriteLiteral("            </table>\n        </div>\n    </div>\n</div>\n\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1029, 145, true);
                WriteLiteral("\n    <script type=\"text/javascript\">\n\n    LoadData();\n\n    function Enroll(_season, _year) {\n\n      $.ajax({\n        type: \'POST\',\n        url: \'");
                EndContext();
                BeginContext(1175, 31, false);
                Write(
#line 43 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml"
               Url.Action("Enroll", "Student")

#line default
#line hidden
                );
                EndContext();
                BeginContext(1206, 66, true);
                WriteLiteral("\',\n        dataType: \'json\',\n\n        data: {\n          subject: \'");
                EndContext();
                BeginContext(1273, 19, false);
                Write(
#line 47 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml"
                     ViewData["subject"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(1292, 26, true);
                WriteLiteral("\',\n          num: Number(\'");
                EndContext();
                BeginContext(1319, 15, false);
                Write(
#line 48 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml"
                        ViewData["num"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(1334, 70, true);
                WriteLiteral("\'),\n          season: _season,\n          year: _year,\n          uid: \'");
                EndContext();
                BeginContext(1405, 18, false);
                Write(
#line 51 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml"
                 User.Identity.Name

#line default
#line hidden
                );
                EndContext();
                BeginContext(1423, 1797, true);
                WriteLiteral(@"',
          },
        success: function (data, status) {
          //alert(JSON.stringify(data));
          if (data.success == undefined) {
            alert(""Unknown response from controller"");
          }
          else if (data.success == true) {
            alert(""Successfully enrolled in class"");
          }
          else{
            alert(""Unable to enroll in class"");
          }
        },
          error: function (ex) {
              alert(""Enroll controller did not return successfully"");
        }
        });

    }

    function PopulateTable(tbl, offerings) {
      var newBody = document.createElement(""tbody"");


      $.each(offerings, function (i, item) {
        var tr = document.createElement(""tr"");

        var td = document.createElement(""td"");
        td.appendChild(document.createTextNode(item.season + "" "" + item.year));
        tr.appendChild(td);

        var td = document.createElement(""td"");
        td.appendChild(document.createTextNode(item.location));
        tr.appendChild(td)");
                WriteLiteral(@";

        var td = document.createElement(""td"");
        td.appendChild(document.createTextNode(item.start + "" - "" + item.end));
        tr.appendChild(td);

        var td = document.createElement(""td"");
        td.appendChild(document.createTextNode(item.lname + "", "" + item.fname));
        tr.appendChild(td);

        var td = document.createElement(""td"");
        var a = document.createElement(""a"");
        a.setAttribute(""href"", ""javascript:Enroll('"" + item.season + ""', '"" + item.year + ""')"");
        a.appendChild(document.createTextNode(""enroll""));
        td.appendChild(a);
        tr.appendChild(td);


        newBody.appendChild(tr);
      });

      tbl.appendChild(newBody);

    }

    function LoadData() {

      classname.innerText = 'Offerings of ");
                EndContext();
                BeginContext(3221, 19, false);
                Write(
#line 112 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml"
                                           ViewData["subject"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(3240, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(3242, 15, false);
                Write(
#line 112 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml"
                                                                ViewData["num"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(3257, 111, true);
                WriteLiteral("\';\n\n      var tbl = document.getElementById(\"tblClasses\");\n\n      $.ajax({\n        type: \'POST\',\n        url: \'");
                EndContext();
                BeginContext(3369, 41, false);
                Write(
#line 118 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml"
               Url.Action("GetClassOfferings", "Common")

#line default
#line hidden
                );
                EndContext();
                BeginContext(3410, 55, true);
                WriteLiteral("\',\n        dataType: \'json\',\n        data: { subject: \'");
                EndContext();
                BeginContext(3466, 19, false);
                Write(
#line 120 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml"
                           ViewData["subject"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(3485, 19, true);
                WriteLiteral("\', number: Number(\'");
                EndContext();
                BeginContext(3505, 15, false);
                Write(
#line 120 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Student/ClassListings.cshtml"
                                                                  ViewData["num"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(3520, 297, true);
                WriteLiteral(@"') },
        success: function (data, status) {

          PopulateTable(tbl, data);

          //alert(JSON.stringify(data));

        },
          error: function (ex) {
              alert(""GetClassOfferings controller did not return successfully"");
        }
        });
    }

    </script>
");
                EndContext();
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
