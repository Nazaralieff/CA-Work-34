#pragma checksum "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_partnerPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd4a20aabf01373568f3b66fab29dfed4e5706b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__partnerPartial), @"mvc.1.0.view", @"/Views/Shared/_partnerPartial.cshtml")]
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
#line 1 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\_ViewImports.cshtml"
using SixteenClothing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\_ViewImports.cshtml"
using SixteenClothing.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\_ViewImports.cshtml"
using SixteenClothing.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4a20aabf01373568f3b66fab29dfed4e5706b1", @"/Views/Shared/_partnerPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2851285615f377e4971faae23e9d21f7829d1f99", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__partnerPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmPartnerPartial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"client-item\">\r\n      <img");
            BeginWriteAttribute("src", " src=\"", 66, "\"", 97, 2);
            WriteAttributeValue("", 72, "assets/images/", 72, 14, true);
#nullable restore
#line 5 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_partnerPartial.cshtml"
WriteAttributeValue("", 86, Model.Logo, 86, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"6\">\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmPartnerPartial> Html { get; private set; }
    }
}
#pragma warning restore 1591
