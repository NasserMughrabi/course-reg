#pragma checksum "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Account/ForgotPasswordConfirmation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "69dae3ecc1f32ce722fe2930a1c9c1bd2ffefc3d4aa44ad0a57d804ec6bc2772"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ForgotPasswordConfirmation), @"mvc.1.0.view", @"/Views/Account/ForgotPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ForgotPasswordConfirmation.cshtml", typeof(AspNetCore.Views_Account_ForgotPasswordConfirmation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"69dae3ecc1f32ce722fe2930a1c9c1bd2ffefc3d4aa44ad0a57d804ec6bc2772", @"/Views/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3629c37afbf004bcaf871b2c32b6c964131444b57f92dcfe61762b65de21a6a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Account/ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";

#line default
#line hidden

            BeginContext(61, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(67, 17, false);
            Write(
#line 5 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Account/ForgotPasswordConfirmation.cshtml"
     ViewData["Title"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(84, 67, true);
            WriteLiteral("</h2>\n<p>\n    Please check your email to reset your password.\n</p>\n");
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
