#pragma checksum "C:\Users\BT OGRETMEN\source\repos\aspnetcoreIleVeriTasima\aspnetcoreIleVeriTasima\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54853fbce41e3ff1a41320aba78ddcc2358c7e31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\BT OGRETMEN\source\repos\aspnetcoreIleVeriTasima\aspnetcoreIleVeriTasima\Views\_ViewImports.cshtml"
using aspnetcoreIleVeriTasima;

#line default
#line hidden
#line 2 "C:\Users\BT OGRETMEN\source\repos\aspnetcoreIleVeriTasima\aspnetcoreIleVeriTasima\Views\_ViewImports.cshtml"
using aspnetcoreIleVeriTasima.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54853fbce41e3ff1a41320aba78ddcc2358c7e31", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0770ca4f31486c5cd0bd135bd2a1cef69b89dd65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<personel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 39, true);
            WriteLiteral("aşağıdaki veriler model ile geldi\r\n<h1>");
            EndContext();
            BeginContext(57, 8, false);
#line 3 "C:\Users\BT OGRETMEN\source\repos\aspnetcoreIleVeriTasima\aspnetcoreIleVeriTasima\Views\Home\Index.cshtml"
Write(Model.ad);

#line default
#line hidden
            EndContext();
            BeginContext(65, 11, true);
            WriteLiteral("</h1>\r\n<h3>");
            EndContext();
            BeginContext(77, 9, false);
#line 4 "C:\Users\BT OGRETMEN\source\repos\aspnetcoreIleVeriTasima\aspnetcoreIleVeriTasima\Views\Home\Index.cshtml"
Write(Model.yas);

#line default
#line hidden
            EndContext();
            BeginContext(86, 7, true);
            WriteLiteral("</h3>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<personel> Html { get; private set; }
    }
}
#pragma warning restore 1591
