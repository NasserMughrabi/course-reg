#pragma checksum "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Manage/ShowRecoveryCodes.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d69cb3b40a9cfb4a6a7de71682c888570e8e40186cc43146a8a18d7d9ad8748b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ShowRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ShowRecoveryCodes.cshtml", typeof(AspNetCore.Views_Manage_ShowRecoveryCodes))]
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

    ;
#line 1 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Manage/_ViewImports.cshtml"
using LMS.Views.Manage

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d69cb3b40a9cfb4a6a7de71682c888570e8e40186cc43146a8a18d7d9ad8748b", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3629c37afbf004bcaf871b2c32b6c964131444b57f92dcfe61762b65de21a6a6", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"979883e0cedf1383eb10a122e25565a5e8af3b32a579faee5cee0b3cd6e3be21", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShowRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Manage/ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden

            BeginContext(149, 5, true);
            WriteLiteral("\n<h4>");
            EndContext();
            BeginContext(155, 17, false);
            Write(
#line 7 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Manage/ShowRecoveryCodes.cshtml"
     ViewData["Title"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(172, 365, true);
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
            EndContext();
#line 19 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Manage/ShowRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
        {

#line default
#line hidden

            BeginContext(618, 18, true);
            WriteLiteral("            <code>");
            EndContext();
            BeginContext(637, 24, false);
            Write(
#line 21 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Manage/ShowRecoveryCodes.cshtml"
                   Model.RecoveryCodes[row]

#line default
#line hidden
            );
            EndContext();
            BeginContext(661, 7, true);
            WriteLiteral("</code>");
            EndContext();
            BeginContext(674, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(687, 6, true);
            WriteLiteral("<code>");
            EndContext();
            BeginContext(694, 28, false);
            Write(
#line 21 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Manage/ShowRecoveryCodes.cshtml"
                                                                            Model.RecoveryCodes[row + 1]

#line default
#line hidden
            );
            EndContext();
            BeginContext(722, 14, true);
            WriteLiteral("</code><br />\n");
            EndContext();
#line 22 "/Users/nasser/Documents/projects/LMS_Project-master/LMS/Views/Manage/ShowRecoveryCodes.cshtml"
        }

#line default
#line hidden

            BeginContext(746, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
