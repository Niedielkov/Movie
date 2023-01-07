#pragma checksum "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "179e32926d0c668e01aa6a5d10d4e2364ff1da87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_FilmDetails), @"mvc.1.0.view", @"/Views/Films/FilmDetails.cshtml")]
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
#line 1 "D:\Programming\WebApplications\Movies\Movies\Views\_ViewImports.cshtml"
using Movies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179e32926d0c668e01aa6a5d10d4e2364ff1da87", @"/Views/Films/FilmDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db56da32441a8036327b73374fd549f15ed2f919", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Films_FilmDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmDetailsSimilarModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Films", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FilmDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-mdb-ripple-color", new global::Microsoft.AspNetCore.Html.HtmlString("dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FilmsPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
  
    ViewData["Title"] = "Film details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"embed-responsive embed-responsive-16by9\">\r\n                <iframe class=\"embed-responsive-item\"");
            BeginWriteAttribute("src", " src=\"", 289, "\"", 320, 1);
#nullable restore
#line 11 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
WriteAttributeValue("", 295, Model.FilmModel.FilmLink, 295, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" allowfullscreen></iframe>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <h1 class=\"text-black-50\">");
#nullable restore
#line 17 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                         Write(Model.FilmModel.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n            <hr />\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p>Producer: <span class=\"text-info\">");
#nullable restore
#line 23 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                    Write(Model.FilmModel.Producer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p>Description: <span class=\"text-info\">");
#nullable restore
#line 29 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                       Write(Model.FilmModel.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p>Year: <span class=\"text-info\">");
#nullable restore
#line 34 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                Write(Model.FilmModel.Year.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p>Category: <span class=\"text-info\">");
#nullable restore
#line 39 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                    Write(Model.FilmModel.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p>Country: <span class=\"text-info\">");
#nullable restore
#line 44 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                   Write(Model.FilmModel.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                </div>
            </div>
        </div>
    </div>
    <hr />
    <div class=""row"">
        <div class=""col-md-12"">
           <h2>You would like also</h2>
        </div>
        <div class=""col-md-12"">
            <div class=""row"">
");
#nullable restore
#line 56 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                 if (Model.FilmModels.Count > 6)
                {
                    for (int i = 0; i < 6; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4 mt-2 mb-4\">\r\n                            <div class=\"card\">\r\n                                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2207, "\"", 2247, 1);
#nullable restore
#line 62 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
WriteAttributeValue("", 2213, Model.FilmModels[i].CoverImageUrl, 2213, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title\">");
#nullable restore
#line 64 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                      Write(Model.FilmModels[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 65 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                    Write(Model.FilmModels[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"d-flex justify-content-between align-items-center\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "179e32926d0c668e01aa6a5d10d4e2364ff1da8710758", async() => {
                WriteLiteral("Watch film");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                                                                                                      WriteLiteral(Model.FilmModels[i].Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                        <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 68 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                                                  Write(Model.FilmModels[i].Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 73 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                    }
                }
                else
                {
                    foreach (var film in Model.FilmModels)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4 mt-2 mb-4\">\r\n                            <div class=\"card\">\r\n                                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 3396, "\"", 3421, 1);
#nullable restore
#line 81 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
WriteAttributeValue("", 3402, film.CoverImageUrl, 3402, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title\">");
#nullable restore
#line 83 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                      Write(film.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 84 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                    Write(film.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"d-flex justify-content-between align-items-center\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "179e32926d0c668e01aa6a5d10d4e2364ff1da8715651", async() => {
                WriteLiteral("Watch film");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                                                                                                      WriteLiteral(film.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                        <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 87 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                                                                                  Write(film.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 92 "D:\Programming\WebApplications\Movies\Movies\Views\Films\FilmDetails.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12 text-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "179e32926d0c668e01aa6a5d10d4e2364ff1da8719131", async() => {
                WriteLiteral("Back to films page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmDetailsSimilarModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591