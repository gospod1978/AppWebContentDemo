#pragma checksum "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/_CurrentYearPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c87922333f8a27cae02ffa771212dfe7a403136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__CurrentYearPartial), @"mvc.1.0.view", @"/Views/Home/_CurrentYearPartial.cshtml")]
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
#line 1 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/_ViewImports.cshtml"
using AppWebController;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/_ViewImports.cshtml"
using AppWebController.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c87922333f8a27cae02ffa771212dfe7a403136", @"/Views/Home/_CurrentYearPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca426e08a42aa38c17cdbc0b3179fc134669e266", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__CurrentYearPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-6\">Current year:</div>\n    <div class=\"col-md-6\">");
#nullable restore
#line 3 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/_CurrentYearPartial.cshtml"
                     Write(DateTime.UtcNow.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</div>");
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
