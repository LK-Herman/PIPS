#pragma checksum "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e3a3a608b91051bf27dc289526681672bff6645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarModels_Details), @"mvc.1.0.view", @"/Views/CarModels/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CarModels/Details.cshtml", typeof(AspNetCore.Views_CarModels_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3a3a608b91051bf27dc289526681672bff6645", @"/Views/CarModels/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0a3f373269959918af47991aa49482e9e6ed43", @"/Views/_ViewImports.cshtml")]
    public class Views_CarModels_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PipsiProject.Models.CarModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width=auto; height=auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-block "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:10px 0px; background-color:#3e3e3e; color:white "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:10px 0px; background-color:orange; color:white "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 271, true);
            WriteLiteral(@"


<div>
    
    <hr />
    <div class=""row col-lg-12 "">
        <div class=""jumbotron col-lg-12"" style=""background-color:#e2e2e2; box-shadow: rgba(0,0,0,0.4) 4px 4px 4px; "">
            <div class=""col-lg-11"">
                <h2>

                    <span>");
            EndContext();
            BeginContext(354, 37, false);
#line 17 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                     Write(Html.DisplayFor(model => model.Marka));

#line default
#line hidden
            EndContext();
            BeginContext(391, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(393, 37, false);
#line 17 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(430, 52, true);
            WriteLiteral("</span>\r\n\r\n\r\n                </h2>\r\n                ");
            EndContext();
            BeginContext(482, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef00f605f53e4141bbb960689adb7481", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 21 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                                                  WriteLiteral("~/images/carimg/"+ Model.CarImage.ImageName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(637, 172, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-1\" style=\"vertical-align:middle\">\r\n                <ul class=\"media-list btn-group-vertical\">\r\n                    <li>");
            EndContext();
            BeginContext(809, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc92b774e7d74240851eb9a90ea859e9", async() => {
                BeginContext(943, 6, true);
                WriteLiteral("Edytuj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                                                                                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(953, 31, true);
            WriteLiteral("</li>\r\n                    <li>");
            EndContext();
            BeginContext(984, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30acdff5c80648829d1e871dba6cfd3c", async() => {
                BeginContext(1121, 9, true);
                WriteLiteral("Szczegóły");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                                                                                                                                          WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1134, 31, true);
            WriteLiteral("</li>\r\n                    <li>");
            EndContext();
            BeginContext(1165, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1226ea167992485e90350d14ae0e6851", async() => {
                BeginContext(1300, 4, true);
                WriteLiteral("Usuń");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                                                                                                                                        WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1308, 68, true);
            WriteLiteral("</li>\r\n                    <li><br /></li>\r\n                    <li>");
            EndContext();
            BeginContext(1376, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13fd821f14da48898111192b07151745", async() => {
                BeginContext(1486, 6, true);
                WriteLiteral("Powrót");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1496, 253, true);
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"col-lg-12\" style=\"background-color:white; margin:1%; padding:2%\">\r\n\r\n                <h4>\r\n                    <span class=\"glyphicon glyphicon-book\"></span>\r\n                    ");
            EndContext();
            BeginContext(1750, 40, false);
#line 36 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 176, true);
            WriteLiteral("\r\n                </h4>\r\n                <hr />\r\n                <dl>\r\n                    <dt>\r\n\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1967, 36, false);
#line 44 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 441, true);
            WriteLiteral(@"
                    </dd>
                </dl>
            </div>
            <div class=""col-lg-6 text-left"" style=""background-color:white; margin:1%; padding:2%"">
                <h4>
                    <span class=""glyphicon glyphicon-wrench""></span>
                    <span>Parametry:</span>

                </h4>
                <hr />
                <dl class="""">

                    <dt>
                        ");
            EndContext();
            BeginContext(2445, 41, false);
#line 58 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Klasa));

#line default
#line hidden
            EndContext();
            BeginContext(2486, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2566, 37, false);
#line 61 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Klasa));

#line default
#line hidden
            EndContext();
            BeginContext(2603, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2683, 46, false);
#line 64 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.PojSilnika));

#line default
#line hidden
            EndContext();
            BeginContext(2729, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2809, 42, false);
#line 67 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PojSilnika));

#line default
#line hidden
            EndContext();
            BeginContext(2851, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2931, 44, false);
#line 70 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Przebieg));

#line default
#line hidden
            EndContext();
            BeginContext(2975, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3055, 40, false);
#line 73 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Przebieg));

#line default
#line hidden
            EndContext();
            BeginContext(3095, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3175, 43, false);
#line 76 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.RokProd));

#line default
#line hidden
            EndContext();
            BeginContext(3218, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3298, 39, false);
#line 79 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayFor(model => model.RokProd));

#line default
#line hidden
            EndContext();
            BeginContext(3337, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3417, 42, false);
#line 82 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Paliwo));

#line default
#line hidden
            EndContext();
            BeginContext(3459, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3539, 38, false);
#line 85 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Paliwo));

#line default
#line hidden
            EndContext();
            BeginContext(3577, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3657, 41, false);
#line 88 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Kolor));

#line default
#line hidden
            EndContext();
            BeginContext(3698, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3778, 37, false);
#line 91 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Kolor));

#line default
#line hidden
            EndContext();
            BeginContext(3815, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(3895, 40, false);
#line 94 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(3935, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4015, 36, false);
#line 97 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(4051, 128, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                </dl>\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
