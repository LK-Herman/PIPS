#pragma checksum "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bff2af13e7abb26c1a13633ff1729069aa1ac5c9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff2af13e7abb26c1a13633ff1729069aa1ac5c9", @"/Views/CarModels/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0a3f373269959918af47991aa49482e9e6ed43", @"/Views/_ViewImports.cshtml")]
    public class Views_CarModels_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PipsiProject.Models.CarModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto; height:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-block "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:10px 0px; background-color:#3e3e3e; color:white "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:10px 0px; background-color:orange; color:white "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(82, 327, true);
            WriteLiteral(@"

    <hr />
    <div class=""col-sm-12"">
        <div class=""col-sm-1""></div>
        <div class=""col-sm-10"" style=""background-color:#f5f5f5; box-shadow: rgba(0,0,0,0.4) 4px 4px 4px; "">

            <div class=""col-sm-12"">
                <div class=""col-sm-4"">
                    <h2>
                        <span>");
            EndContext();
            BeginContext(410, 37, false);
#line 16 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Marka));

#line default
#line hidden
            EndContext();
            BeginContext(447, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(449, 37, false);
#line 16 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                                                                Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(486, 120, true);
            WriteLiteral("</span>\r\n                    </h2>\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(606, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dfc0c34a4bdd4f8ca1c684dbc7115e69", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 20 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                                                      WriteLiteral("~/images/carimg/"+ Model.CarImage.ImageName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
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
            BeginContext(761, 314, true);
            WriteLiteral(@"
                </div>

                <div class=""col-sm-3"" style=""text-align:center; vertical-align: middle;"">

                    <div class=""img-rounded img-rounded"" style=""background-color:#f2f2f2; padding:1em 2em;  "">

                        <h1 style=""color:orange; font-family:'Century Gothic'"">");
            EndContext();
            BeginContext(1076, 40, false);
#line 27 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => Model.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 296, true);
            WriteLiteral(@" </h1>
                        <h4 style=""color: dimgray"">PLN za dzień</h4>

                    </div>

                </div>
                <div class=""col-sm-1"" style=""vertical-align:middle"">
                    <ul class=""media-list btn-group-vertical"">
                        <li>");
            EndContext();
            BeginContext(1412, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e5919e149f04ab4b1c07ad1e6d99f24", async() => {
                BeginContext(1546, 6, true);
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
#line 35 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
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
            BeginContext(1556, 35, true);
            WriteLiteral("</li>\r\n                        <li>");
            EndContext();
            BeginContext(1591, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340cc189c4e6465daecb05d1466876fe", async() => {
                BeginContext(1726, 4, true);
                WriteLiteral("Usuń");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
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
            BeginContext(1734, 76, true);
            WriteLiteral("</li>\r\n                        <li><br /></li>\r\n                        <li>");
            EndContext();
            BeginContext(1810, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98716f4846d948a1acc017bf20b2995e", async() => {
                BeginContext(1919, 6, true);
                WriteLiteral("Powrót");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1929, 335, true);
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>


            <div class=""col-sm-12"" style=""background-color:white; margin:1%; padding:2%"">
                <div class=""col-sm-9"">
                    <h4>
                        <span class=""glyphicon glyphicon-book""></span>
                        ");
            EndContext();
            BeginContext(2265, 40, false);
#line 48 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(2305, 204, true);
            WriteLiteral("\r\n                    </h4>\r\n                    <hr />\r\n                    <dl>\r\n                        <dt>\r\n\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2510, 36, false);
#line 56 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(2546, 594, true);
            WriteLiteral(@"
                        </dd>
                    </dl>
                </div>


                
            </div>


            <div class="" col-sm-12 text-left"" style=""background-color:white; margin:1%; padding:2%"">

                <h4>
                    <span class=""glyphicon glyphicon-wrench""></span>
                    <span>Parametry:</span>

                </h4>

                <hr />
                <div class=""col-sm-1""></div>
                <div class=""col-sm-4"">

                    <dl>
                        <dt>
                            ");
            EndContext();
            BeginContext(3141, 41, false);
#line 80 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Klasa));

#line default
#line hidden
            EndContext();
            BeginContext(3182, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(3274, 37, false);
#line 83 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Klasa));

#line default
#line hidden
            EndContext();
            BeginContext(3311, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(3403, 46, false);
#line 86 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.PojSilnika));

#line default
#line hidden
            EndContext();
            BeginContext(3449, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(3541, 42, false);
#line 89 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayFor(model => model.PojSilnika));

#line default
#line hidden
            EndContext();
            BeginContext(3583, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(3675, 44, false);
#line 92 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Przebieg));

#line default
#line hidden
            EndContext();
            BeginContext(3719, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(3811, 40, false);
#line 95 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Przebieg));

#line default
#line hidden
            EndContext();
            BeginContext(3851, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(3943, 43, false);
#line 98 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.RokProd));

#line default
#line hidden
            EndContext();
            BeginContext(3986, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(4078, 39, false);
#line 101 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayFor(model => model.RokProd));

#line default
#line hidden
            EndContext();
            BeginContext(4117, 210, true);
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    <dl>\r\n\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(4328, 42, false);
#line 109 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Paliwo));

#line default
#line hidden
            EndContext();
            BeginContext(4370, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(4462, 38, false);
#line 112 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Paliwo));

#line default
#line hidden
            EndContext();
            BeginContext(4500, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(4592, 41, false);
#line 115 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Kolor));

#line default
#line hidden
            EndContext();
            BeginContext(4633, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(4725, 37, false);
#line 118 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Kolor));

#line default
#line hidden
            EndContext();
            BeginContext(4762, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(4854, 40, false);
#line 121 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(4894, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(4986, 36, false);
#line 124 "C:\Projects\PipsiProject\PipsiProject\Views\CarModels\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(5022, 226, true);
            WriteLiteral("\r\n                        </dd>\r\n\r\n                    </dl>\r\n                </div>\r\n                <div class=\"col-sm-1\"></div>\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n        <div class=\"col-sm-1\"></div>\r\n\r\n    </div>\r\n");
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
