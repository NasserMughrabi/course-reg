#pragma checksum "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c20f0b5fe6c3fadd7456cb4d4880fae9ea2b5d986c0614401848c50bd8d38dc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Assignment), @"mvc.1.0.view", @"/Views/Professor/Assignment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Professor/Assignment.cshtml", typeof(AspNetCore.Views_Professor_Assignment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c20f0b5fe6c3fadd7456cb4d4880fae9ea2b5d986c0614401848c50bd8d38dc3", @"/Views/Professor/Assignment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3629c37afbf004bcaf871b2c32b6c964131444b57f92dcfe61762b65de21a6a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Assignment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
  
    ViewData["Title"] = "Assignment";
    Layout = "~/Views/Shared/ProfessorLayout.cshtml";

#line default
#line hidden

            BeginContext(98, 9, true);
            WriteLiteral("\n\n<html>\n");
            EndContext();
            BeginContext(107, 888, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c20f0b5fe6c3fadd7456cb4d4880fae9ea2b5d986c0614401848c50bd8d38dc34186", async() => {
                BeginContext(113, 875, true);
                WriteLiteral(@"
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
  <style>
    body {
      font-family: ""Lato"", sans-serif;
    }

    .sidenav {
      /*width: 130px;
      height: 210px;
      position: fixed;
      z-index: 1;
      top: 80px;
      left: 10px;*/
      width: 130px;
      height: 210px;
      position: fixed;
      left: 0;
      right: 0;
      /*margin-left: auto;
      margin-right: auto;*/
      z-index: 1;
      top: 50px;
      background: #eee;
      overflow-x: hidden;
      padding: 8px 0;
    }

      .sidenav a {
        padding: 6px 8px 6px 16px;
        text-decoration: none;
        font-size: 18px;
        color: #2196F3;
        display: block;
      }

        .sidenav a:hover {
          color: #064579;
        }

    .main {
      margin-left: 140px;
      min-height: 200px;
      padding: 0px 10px;
    }
  </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(995, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(996, 607, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c20f0b5fe6c3fadd7456cb4d4880fae9ea2b5d986c0614401848c50bd8d38dc36249", async() => {
                BeginContext(1002, 32, true);
                WriteLiteral("\n\n  <div class=\"sidenav\">\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1034, "\'", 1157, 8);
                WriteAttributeValue("", 1041, "/Professor/Class?subject=", 1041, 25, true);
                WriteAttributeValue("", 1066, 
#line 59 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                       ViewData["subject"]

#line default
#line hidden
                , 1066, 20, false);
                WriteAttributeValue("", 1086, "&num=", 1086, 5, true);
                WriteAttributeValue("", 1091, 
#line 59 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                                                ViewData["num"]

#line default
#line hidden
                , 1091, 16, false);
                WriteAttributeValue("", 1107, "&season=", 1107, 8, true);
                WriteAttributeValue("", 1115, 
#line 59 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                                                                        ViewData["season"]

#line default
#line hidden
                , 1115, 19, false);
                WriteAttributeValue("", 1134, "&year=", 1134, 6, true);
                WriteAttributeValue("", 1140, 
#line 59 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                                                                                                 ViewData["year"]

#line default
#line hidden
                , 1140, 17, false);
                EndWriteAttribute();
                BeginContext(1158, 23, true);
                WriteLiteral(">Assignments</a>\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1181, "\'", 1307, 8);
                WriteAttributeValue("", 1188, "/Professor/Students?subject=", 1188, 28, true);
                WriteAttributeValue("", 1216, 
#line 60 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                          ViewData["subject"]

#line default
#line hidden
                , 1216, 20, false);
                WriteAttributeValue("", 1236, "&num=", 1236, 5, true);
                WriteAttributeValue("", 1241, 
#line 60 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                                                   ViewData["num"]

#line default
#line hidden
                , 1241, 16, false);
                WriteAttributeValue("", 1257, "&season=", 1257, 8, true);
                WriteAttributeValue("", 1265, 
#line 60 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                                                                           ViewData["season"]

#line default
#line hidden
                , 1265, 19, false);
                WriteAttributeValue("", 1284, "&year=", 1284, 6, true);
                WriteAttributeValue("", 1290, 
#line 60 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                                                                                                    ViewData["year"]

#line default
#line hidden
                , 1290, 17, false);
                EndWriteAttribute();
                BeginContext(1308, 20, true);
                WriteLiteral(">Students</a>\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1328, "\'", 1456, 8);
                WriteAttributeValue("", 1335, "/Professor/Categories?subject=", 1335, 30, true);
                WriteAttributeValue("", 1365, 
#line 61 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                            ViewData["subject"]

#line default
#line hidden
                , 1365, 20, false);
                WriteAttributeValue("", 1385, "&num=", 1385, 5, true);
                WriteAttributeValue("", 1390, 
#line 61 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                                                     ViewData["num"]

#line default
#line hidden
                , 1390, 16, false);
                WriteAttributeValue("", 1406, "&season=", 1406, 8, true);
                WriteAttributeValue("", 1414, 
#line 61 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                                                                             ViewData["season"]

#line default
#line hidden
                , 1414, 19, false);
                WriteAttributeValue("", 1433, "&year=", 1433, 6, true);
                WriteAttributeValue("", 1439, 
#line 61 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                                                                                                                      ViewData["year"]

#line default
#line hidden
                , 1439, 17, false);
                EndWriteAttribute();
                BeginContext(1457, 139, true);
                WriteLiteral(">Assignment Categories</a>\n  </div>\n\n\n  <div class=\"main\">\n    <h4 id=\"asgname\">Assignment</h4>\n    <div id=\"asgcontents\"></div>\n\n  </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1603, 14, true);
            WriteLiteral("\n</html>\n\n\n\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1637, 107, true);
                WriteLiteral("\n  <script type=\"text/javascript\">\n\n    LoadData();\n\n    function LoadData() {\n\n      asgname.innerText = \'");
                EndContext();
                BeginContext(1745, 17, false);
                Write(
#line 85 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                            ViewData["aname"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(1762, 55, true);
                WriteLiteral("\';\n\n      $.ajax({\n        type: \'POST\',\n        url: \'");
                EndContext();
                BeginContext(1818, 45, false);
                Write(
#line 89 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
               Url.Action("GetAssignmentContents", "Common")

#line default
#line hidden
                );
                EndContext();
                BeginContext(1863, 65, true);
                WriteLiteral("\',\n        dataType: \'text\',\n        data: {\n          subject: \'");
                EndContext();
                BeginContext(1929, 19, false);
                Write(
#line 92 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                     ViewData["subject"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(1948, 26, true);
                WriteLiteral("\',\n          num: Number(\'");
                EndContext();
                BeginContext(1975, 15, false);
                Write(
#line 93 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                        ViewData["num"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(1990, 23, true);
                WriteLiteral("\'),\n          season: \'");
                EndContext();
                BeginContext(2014, 18, false);
                Write(
#line 94 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                    ViewData["season"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(2032, 27, true);
                WriteLiteral("\',\n          year: Number(\'");
                EndContext();
                BeginContext(2060, 16, false);
                Write(
#line 95 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                         ViewData["year"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(2076, 25, true);
                WriteLiteral("\'),\n          category: \'");
                EndContext();
                BeginContext(2102, 15, false);
                Write(
#line 96 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                      ViewData["cat"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(2117, 23, true);
                WriteLiteral("\',\n          asgname: \'");
                EndContext();
                BeginContext(2141, 17, false);
                Write(
#line 97 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Professor/Assignment.cshtml"
                     ViewData["aname"]

#line default
#line hidden
                );
                EndContext();
                BeginContext(2158, 365, true);
                WriteLiteral(@"'},
        success: function (data, status) {
          //alert(data);

          var contentsdiv = document.getElementById(""asgcontents"");
          contentsdiv.innerHTML = data;
          
        },
          error: function (ex) {
              alert(""GetAssignmentContents controller did not return successfully"");
        }
        });


    }

  </script>

");
                EndContext();
            }
            );
            BeginContext(2525, 2, true);
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