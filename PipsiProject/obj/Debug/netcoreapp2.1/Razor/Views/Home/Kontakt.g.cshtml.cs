#pragma checksum "C:\Projects\PipsiProject\PipsiProject\Views\Home\Kontakt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f1b3a31afa0782e69b3bbd728f2778d7b6d1596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Kontakt), @"mvc.1.0.view", @"/Views/Home/Kontakt.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Kontakt.cshtml", typeof(AspNetCore.Views_Home_Kontakt))]
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
#line 1 "C:\Projects\PipsiProject\PipsiProject\Views\_ViewImports.cshtml"
using PipsiProject;

#line default
#line hidden
#line 2 "C:\Projects\PipsiProject\PipsiProject\Views\_ViewImports.cshtml"
using PipsiProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f1b3a31afa0782e69b3bbd728f2778d7b6d1596", @"/Views/Home/Kontakt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0a3f373269959918af47991aa49482e9e6ed43", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Kontakt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Kontakt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("foto2 img-responsive center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/logo.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:400px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\PipsiProject\PipsiProject\Views\Home\Kontakt.cshtml"
  
    ViewData["Title"] = "Kontakt";

#line default
#line hidden
            BeginContext(43, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(50, 33, false);
#line 5 "C:\Projects\PipsiProject\PipsiProject\Views\Home\Kontakt.cshtml"
Write(ViewData["Skontaktuj się z nami"]);

#line default
#line hidden
            EndContext();
            BeginContext(83, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 7 "C:\Projects\PipsiProject\PipsiProject\Views\Home\Kontakt.cshtml"
  
    ViewBag.Title = "Kontakt";

#line default
#line hidden
            BeginContext(131, 128, true);
            WriteLiteral("<h2> Wyślij do nas wiadomość: </h2>\r\n<br /> <br />\r\n       <div class=\"row\">\r\n           <div class=\"col-sm-6\">\r\n               ");
            EndContext();
            BeginContext(259, 1095, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8d5f1a8cb3146ff978000f20182c3bd", async() => {
                BeginContext(318, 1029, true);
                WriteLiteral(@"
                   
                       <span class=""form-control-static""> Adres odbiorcy: </span>
                       <input class=""form-control"" type=""email"" name=""receiver"" value=""pipsitestemail@gmail.com"" required /> <br />
                       <span class=""form-control-static""> Temat: </span>
                       <input class=""form-control"" type=""text"" name=""subject"" required /> <br />
                       <span class=""form-control-static""> Wiadomość: </span>
                       <textarea class=""form-control"" type=""text"" name=""message"" required rows=""5""> </textarea> <br />
                       <span class=""form-control-static"" placeholder=""mojadres@adres.com""> Twój adres email: </span>
                       <input class=""form-control"" type=""email"" name=""formSender"" required /> <br />

                       <input class=""btn form-control"" style=""margin:10px 0px; background-color:#3e3e3e; color:white "" type=""submit"" value=""Wyślij wiadomość"" />
                   
          ");
                WriteLiteral("     ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1354, 155, true);
            WriteLiteral("\r\n           </div>\r\n\r\n           <div class=\"col-sm-1\"></div>\r\n\r\n           <div class=\"\">\r\n               <div class=\"col-sm-5 row\">\r\n                   ");
            EndContext();
            BeginContext(1509, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29cb504ca7284f23bfce3db77df4c6d9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 35 "C:\Projects\PipsiProject\PipsiProject\Views\Home\Kontakt.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1633, 992, true);
            WriteLiteral(@"
               </div>
           </div>

           <div class=""row"">
               <div class=""col-sm-1""></div>
               <div class=""col-sm-3 col-sm-offset-1"">
                   <address>
                       <p><strong>Dane kontaktowe:</strong></p>
                       <br />

                       <h4>PIPSI Car Studio 2020</h4>
                       59-220 Legnica<br />
                       <abbr title=""Telefon"">Tel.:</abbr>
                       +48 666555444
                   </address>

                   <address>
                       <p>
                           <strong>Adres email:</strong>
                       </p>
                       <p>
                           <a href=""mailto:pipsitestemail@gmail.com"">pipsitestemail@gmail.com</a><br />
                       </p>
                   </address>
               </div>
               </div>
           </div>
       
           <div class=""col-sm-12 text-left"">
");
            EndContext();
#line 65 "C:\Projects\PipsiProject\PipsiProject\Views\Home\Kontakt.cshtml"
                if (ViewBag.Error != null)
               {

#line default
#line hidden
            BeginContext(2685, 5, true);
            WriteLiteral("<h2> ");
            EndContext();
            BeginContext(2691, 13, false);
#line 66 "C:\Projects\PipsiProject\PipsiProject\Views\Home\Kontakt.cshtml"
                Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(2704, 6, true);
            WriteLiteral(" </h2>");
            EndContext();
#line 66 "C:\Projects\PipsiProject\PipsiProject\Views\Home\Kontakt.cshtml"
                                         }

#line default
#line hidden
            BeginContext(2713, 30, true);
            WriteLiteral("\r\n\r\n           </div>\r\n       ");
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
