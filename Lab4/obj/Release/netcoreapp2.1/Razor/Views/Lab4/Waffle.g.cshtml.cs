#pragma checksum "C:\Users\Eamon\Desktop\School\AppEngineering\Lab4\Lab4\Views\Lab4\Waffle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8949dc95cba36e78e7b622f86bfb4a1804c683ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lab4_Waffle), @"mvc.1.0.view", @"/Views/Lab4/Waffle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lab4/Waffle.cshtml", typeof(AspNetCore.Views_Lab4_Waffle))]
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
#line 1 "C:\Users\Eamon\Desktop\School\AppEngineering\Lab4\Lab4\Views\_ViewImports.cshtml"
using Lab4;

#line default
#line hidden
#line 2 "C:\Users\Eamon\Desktop\School\AppEngineering\Lab4\Lab4\Views\_ViewImports.cshtml"
using Lab4.Models;

#line default
#line hidden
#line 1 "C:\Users\Eamon\Desktop\School\AppEngineering\Lab4\Lab4\Views\Lab4\Waffle.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8949dc95cba36e78e7b622f86bfb4a1804c683ad", @"/Views/Lab4/Waffle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f7534b8557b9a1fc9f023eb2603558152a347ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Lab4_Waffle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Microsoft.AspNetCore.Html.HtmlString>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Eamon\Desktop\School\AppEngineering\Lab4\Lab4\Views\Lab4\Waffle.cshtml"
  
    ViewData["Title"] = "Waffle";


#line default
#line hidden
            BeginContext(126, 626, true);
            WriteLiteral(@"<main>
    <div class=""bg-primary"" style=""padding:25px; border-radius:25px"">
        <h1>Waffle Generator</h1>
    </div>
    <div class=""btn-group"" style=""padding-top:20px"" role=""group"" aria-label=""Basic example"">
        <button type=""button"" href=""/1"" class=""btn btn-success"">1</button>
        <button type=""button"" href=""/2"" class=""btn btn-success"">2</button>
        <button type=""button"" href=""/3"" class=""btn btn-success"">3</button>
        <button type=""button"" href=""/4"" class=""btn btn-success"">4</button>
        <button type=""button"" href=""/Lab4/Waffle/5"" class=""btn btn-success"">5</button>
    </div>

");
            EndContext();
            BeginContext(802, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(811, 5, false);
#line 22 "C:\Users\Eamon\Desktop\School\AppEngineering\Lab4\Lab4\Views\Lab4\Waffle.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(816, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(834, 7, true);
            WriteLiteral("</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Microsoft.AspNetCore.Html.HtmlString> Html { get; private set; }
    }
}
#pragma warning restore 1591