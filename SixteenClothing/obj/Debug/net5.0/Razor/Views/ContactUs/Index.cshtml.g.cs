#pragma checksum "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\ContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76f09d7e65f7b2add256974eb0bbe472d4fc6fc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactUs_Index), @"mvc.1.0.view", @"/Views/ContactUs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f09d7e65f7b2add256974eb0bbe472d4fc6fc7", @"/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2851285615f377e4971faae23e9d21f7829d1f99", @"/Views/_ViewImports.cshtml")]
    public class Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmContactUs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_bannerPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partnerPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n <!-- Page Content -->\r\n");
#nullable restore
#line 5 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\ContactUs\Index.cshtml"
  
    VmBannerPartion partion = new VmBannerPartion()
            {
                SubHeader = Model.settings.ContactUsSubHeader,
                Header = Model.settings.ContactUsHeader
            };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76f09d7e65f7b2add256974eb0bbe472d4fc6fc75647", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 13 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\ContactUs\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = partion;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


    <div class=""find-us"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-12"">
            <div class=""section-heading"">
              <h2>Our Location on Maps</h2>
            </div>
          </div>
          <div class=""col-md-8"">
<!-- How to change your own map point
	1. Go to Google Maps
	2. Click on your location point
	3. Click ""Share"" and choose ""Embed map"" tab
	4. Copy only URL and paste it within the src="""" field below
-->
            <div id=""map"">
              <iframe src=""https://maps.google.com/maps?q=Av.+L%C3%BAcio+Costa,+Rio+de+Janeiro+-+RJ,+Brazil&t=&z=13&ie=UTF8&iwloc=&output=embed"" width=""100%"" height=""330px"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
            </div>
          </div>
          <div class=""col-md-4"">
            <div class=""left-content"">
              <h4>About our office</h4>
              <p>");
#nullable restore
#line 38 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\ContactUs\Index.cshtml"
            Write(Model.settings.ContactUsContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              <ul class=\"social-icons\">\r\n");
#nullable restore
#line 40 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\ContactUs\Index.cshtml"
                   foreach (var item in Model.Sosials)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a href=\"#\"><i");
            BeginWriteAttribute("class", " class=\"", 1439, "\"", 1457, 1);
#nullable restore
#line 42 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 1447, item.Icon, 1447, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n");
#nullable restore
#line 43 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\ContactUs\Index.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              </ul>
            </div>
          </div>
        </div>
      </div>
    </div>

    
    <div class=""send-message"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-12"">
            <div class=""section-heading"">
              <h2>Send us a Message</h2>
            </div>
          </div>
          <div class=""col-md-8"">
            <div class=""contact-form"">
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76f09d7e65f7b2add256974eb0bbe472d4fc6fc79898", async() => {
                WriteLiteral("\r\n                <div class=\"row\">\r\n                  <div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n                    <fieldset>\r\n                      <input name=\"name\" type=\"text\" class=\"form-control\" id=\"name\" placeholder=\"Full Name\"");
                BeginWriteAttribute("required", " required=\"", 2222, "\"", 2233, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </fieldset>
                  </div>
                  <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <fieldset>
                      <input name=""email"" type=""text"" class=""form-control"" id=""email"" placeholder=""E-Mail Address""");
                BeginWriteAttribute("required", " required=\"", 2505, "\"", 2516, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </fieldset>
                  </div>
                  <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <fieldset>
                      <input name=""subject"" type=""text"" class=""form-control"" id=""subject"" placeholder=""Subject""");
                BeginWriteAttribute("required", " required=\"", 2785, "\"", 2796, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </fieldset>\r\n                  </div>\r\n                  <div class=\"col-lg-12\">\r\n                    <fieldset>\r\n                      <textarea name=\"message\" rows=\"6\" class=\"form-control\" id=\"message\" placeholder=\"Your Message\"");
                BeginWriteAttribute("required", " required=\"", 3050, "\"", 3061, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                    </fieldset>
                  </div>
                  <div class=""col-lg-12"">
                    <fieldset>
                      <button type=""submit"" id=""form-submit"" class=""filled-button"">Send Message</button>
                    </fieldset>
                  </div>
                </div>
              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
          </div>
          <div class=""col-md-4"">
            <ul class=""accordion"">
              <li>
                  <a>Accordion Title One</a>
                  <div class=""content"">
                      <p>Lorem ipsum dolor sit amet, consectetur adipisic elit. Sed voluptate nihil eumester consectetur similiqu consectetur.<br><br>Lorem ipsum dolor sit amet, consectetur adipisic elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti elite.</p>
                  </div>
              </li>
              <li>
                  <a>Second Title Here</a>
                  <div class=""content"">
                      <p>Lorem ipsum dolor sit amet, consectetur adipisic elit. Sed voluptate nihil eumester consectetur similiqu consectetur.<br><br>Lorem ipsum dolor sit amet, consectetur adipisic elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti elite.</p>
                  </div>
              </li>
              <li>
                  <a>Acc");
            WriteLiteral(@"ordion Title Three</a>
                  <div class=""content"">
                      <p>Lorem ipsum dolor sit amet, consectetur adipisic elit. Sed voluptate nihil eumester consectetur similiqu consectetur.<br><br>Lorem ipsum dolor sit amet, consectetur adipisic elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti elite.</p>
                  </div>
              </li>
              <li>
                  <a>Fourth Accordion Title</a>
                  <div class=""content"">
                      <p>Lorem ipsum dolor sit amet, consectetur adipisic elit. Sed voluptate nihil eumester consectetur similiqu consectetur.<br><br>Lorem ipsum dolor sit amet, consectetur adipisic elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti elite.</p>
                  </div>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>

    <div class=""happy-clients"">
      <div class=""container"">
        <div class=""row"">
          <div clas");
            WriteLiteral("s=\"col-md-12\">\r\n            <div class=\"section-heading\">\r\n              <h2>Our Happy Customers</h2>\r\n            </div>\r\n          </div>\r\n          <div class=\"col-md-12\">\r\n            <div class=\"owl-clients owl-carousel\">\r\n");
#nullable restore
#line 135 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\ContactUs\Index.cshtml"
                     for (var i = 0; i < 5; i++)
                    {
                        VmPartnerPartial partner = new VmPartnerPartial()
                            {
                                Logo = Model.partners[i].Logo
                            };


#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76f09d7e65f7b2add256974eb0bbe472d4fc6fc716477", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 142 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\ContactUs\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = partner;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 143 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\ContactUs\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmContactUs> Html { get; private set; }
    }
}
#pragma warning restore 1591
