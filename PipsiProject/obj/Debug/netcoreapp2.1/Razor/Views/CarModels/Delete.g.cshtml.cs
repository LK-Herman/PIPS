#pragma checksum "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc1974cbd8d337ef416f6e6c428b1c3e94894b8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarModels_Delete), @"mvc.1.0.view", @"/Views/CarModels/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CarModels/Delete.cshtml", typeof(AspNetCore.Views_CarModels_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc1974cbd8d337ef416f6e6c428b1c3e94894b8a", @"/Views/CarModels/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0a3f373269959918af47991aa49482e9e6ed43", @"/Views/_ViewImports.cshtml")]
    public class Views_CarModels_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PipsiProject.Models.CarModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("450"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("350"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group-vertical"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(81, 308, true);
            WriteLiteral(@"
<h2>Usuwanie samochodu z bazy</h2>

<h3 class=""alert-danger"" style=""padding:4%"">Czy jesteś pewien, że chcesz usunąć tą pozycję?</h3>
<div>
    
    <hr />
    <div class=""row col-lg-12 "">
        <div class=""col-lg-4 text-left"">
            <dl class="""">
                <dt>
                    ");
            EndContext();
            BeginContext(390, 38, false);
#line 17 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(428, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(496, 34, false);
#line 20 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(530, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(598, 41, false);
#line 23 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Marka));

#line default
#line hidden
            EndContext();
            BeginContext(639, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(707, 37, false);
#line 26 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Marka));

#line default
#line hidden
            EndContext();
            BeginContext(744, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(812, 41, false);
#line 29 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(853, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(921, 37, false);
#line 32 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(958, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1026, 41, false);
#line 35 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Klasa));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1135, 37, false);
#line 38 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Klasa));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1240, 46, false);
#line 41 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.PojSilnika));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1354, 42, false);
#line 44 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.PojSilnika));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1464, 44, false);
#line 47 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Przebieg));

#line default
#line hidden
            EndContext();
            BeginContext(1508, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1576, 40, false);
#line 50 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Przebieg));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1684, 43, false);
#line 53 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RokProd));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1795, 39, false);
#line 56 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.RokProd));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1902, 42, false);
#line 59 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Paliwo));

#line default
#line hidden
            EndContext();
            BeginContext(1944, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2012, 38, false);
#line 62 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Paliwo));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(2118, 41, false);
#line 65 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Kolor));

#line default
#line hidden
            EndContext();
            BeginContext(2159, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2227, 37, false);
#line 68 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Kolor));

#line default
#line hidden
            EndContext();
            BeginContext(2264, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(2332, 40, false);
#line 71 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(2372, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2440, 36, false);
#line 74 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(2476, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(2544, 40, false);
#line 77 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(2584, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2652, 36, false);
#line 80 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(2688, 125, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div class=\"col-lg-6\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(2813, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ddcf2d396684e7db8b64266b4cef7a3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 86 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
                                                  WriteLiteral("~/images/carimg/"+ Model.CarImage.ImageName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 86 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2960, 145, true);
            WriteLiteral("\r\n            </p>\r\n            \r\n            <p>\r\n                <dl class=\"dl-horizontal\">\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3106, 55, false);
#line 92 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => Model.CarImage.ImageTitle));

#line default
#line hidden
            EndContext();
            BeginContext(3161, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3241, 51, false);
#line 95 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
                   Write(Html.DisplayFor(model => Model.CarImage.ImageTitle));

#line default
#line hidden
            EndContext();
            BeginContext(3292, 162, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        Plik\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3455, 50, false);
#line 101 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
                   Write(Html.DisplayFor(model => Model.CarImage.ImageName));

#line default
#line hidden
            EndContext();
            BeginContext(3505, 135, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </p>\r\n\r\n        </div>\r\n        <div class=\"col-lg-2 \">\r\n\r\n            ");
            EndContext();
            BeginContext(3640, 308, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea7f9653d48247f38a8bf4ae00cf8003", async() => {
                BeginContext(3693, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3711, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a8fbef5eb45740309517348dc8b2ebcb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 110 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3747, 124, true);
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Usuń auto\" class=\"btn btn-danger\" />\r\n                <br />\r\n                ");
                EndContext();
                BeginContext(3871, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80460e7a0f0e49939f26a83b440edb0d", async() => {
                    BeginContext(3917, 6, true);
                    WriteLiteral("Powrót");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3927, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3948, 40, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PipsiProject.Models.CarModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
