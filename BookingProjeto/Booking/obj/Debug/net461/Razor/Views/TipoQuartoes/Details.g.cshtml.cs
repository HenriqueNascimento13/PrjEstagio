#pragma checksum "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda0f98bc4bff39d3c9e01589ef6971cb7aab290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoQuartoes_Details), @"mvc.1.0.view", @"/Views/TipoQuartoes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TipoQuartoes/Details.cshtml", typeof(AspNetCore.Views_TipoQuartoes_Details))]
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
#line 1 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\_ViewImports.cshtml"
using Booking;

#line default
#line hidden
#line 2 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\_ViewImports.cshtml"
using Booking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda0f98bc4bff39d3c9e01589ef6971cb7aab290", @"/Views/TipoQuartoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48cb8ea961cb0ab3563b2a23336f52fa904a03b2", @"/Views/_ViewImports.cshtml")]
    public class Views_TipoQuartoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking.TipoQuarto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "_LayoutBack";

#line default
#line hidden
            BeginContext(101, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>TipoQuarto</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(226, 46, false);
#line 15 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Capacidade));

#line default
#line hidden
            EndContext();
            BeginContext(272, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(316, 42, false);
#line 18 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Capacidade));

#line default
#line hidden
            EndContext();
            BeginContext(358, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(402, 46, false);
#line 21 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventario));

#line default
#line hidden
            EndContext();
            BeginContext(448, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(492, 42, false);
#line 24 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Inventario));

#line default
#line hidden
            EndContext();
            BeginContext(534, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(578, 45, false);
#line 27 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(623, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(667, 41, false);
#line 30 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(708, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(752, 42, false);
#line 33 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Imagem));

#line default
#line hidden
            EndContext();
            BeginContext(794, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(838, 38, false);
#line 36 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Imagem));

#line default
#line hidden
            EndContext();
            BeginContext(876, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(920, 53, false);
#line 39 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdhotelNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(973, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1017, 59, false);
#line 42 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdhotelNavigation.CodPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1123, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda0f98bc4bff39d3c9e01589ef6971cb7aab2908502", async() => {
                BeginContext(1179, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Henrique\Desktop\prjestagio\BookingProjeto\Booking\Views\TipoQuartoes\Details.cshtml"
                           WriteLiteral(Model.IdtipoQuarto);

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
            BeginContext(1187, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1195, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda0f98bc4bff39d3c9e01589ef6971cb7aab29010847", async() => {
                BeginContext(1217, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1233, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking.TipoQuarto> Html { get; private set; }
    }
}
#pragma warning restore 1591
