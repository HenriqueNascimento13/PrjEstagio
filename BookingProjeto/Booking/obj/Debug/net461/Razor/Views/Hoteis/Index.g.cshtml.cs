#pragma checksum "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c68e61a5825deab7d13f06516d157034ec2977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hoteis_Index), @"mvc.1.0.view", @"/Views/Hoteis/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Hoteis/Index.cshtml", typeof(AspNetCore.Views_Hoteis_Index))]
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
#line 1 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\_ViewImports.cshtml"
using Booking;

#line default
#line hidden
#line 2 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\_ViewImports.cshtml"
using Booking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c68e61a5825deab7d13f06516d157034ec2977", @"/Views/Hoteis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa6f5b8285282a88c4d48fe5a7459b9bac4f7cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Hoteis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Booking.Hoteis>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_LayoutBack";

#line default
#line hidden
            BeginContext(102, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32d6e2f09eaa4e3c86285c98548c23f4", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(251, 45, false);
#line 17 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeHotel));

#line default
#line hidden
            EndContext();
            BeginContext(296, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(349, 47, false);
#line 20 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumEstrelas));

#line default
#line hidden
            EndContext();
            BeginContext(396, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(449, 42, false);
#line 23 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Morada));

#line default
#line hidden
            EndContext();
            BeginContext(491, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(544, 46, false);
#line 26 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Localidade));

#line default
#line hidden
            EndContext();
            BeginContext(590, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(643, 45, false);
#line 29 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CodPostal));

#line default
#line hidden
            EndContext();
            BeginContext(688, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(741, 40, false);
#line 32 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pais));

#line default
#line hidden
            EndContext();
            BeginContext(781, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(834, 53, false);
#line 35 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantidadeQuartos));

#line default
#line hidden
            EndContext();
            BeginContext(887, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(940, 45, false);
#line 38 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(985, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1038, 42, false);
#line 41 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Imagem));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 47 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1191, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1238, 44, false);
#line 50 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeHotel));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1335, 46, false);
#line 53 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumEstrelas));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1434, 41, false);
#line 56 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Morada));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1528, 45, false);
#line 59 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Localidade));

#line default
#line hidden
            EndContext();
            BeginContext(1573, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1626, 44, false);
#line 62 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1670, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1723, 39, false);
#line 65 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pais));

#line default
#line hidden
            EndContext();
            BeginContext(1762, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1815, 52, false);
#line 68 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantidadeQuartos));

#line default
#line hidden
            EndContext();
            BeginContext(1867, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1920, 44, false);
#line 71 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1964, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2017, 41, false);
#line 74 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Imagem));

#line default
#line hidden
            EndContext();
            BeginContext(2058, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2110, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "800909e937c842daa1b509508971f23c", async() => {
                BeginContext(2160, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
                                       WriteLiteral(item.Idhotel);

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
            BeginContext(2168, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2187, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b817a7141be0452eb9a3173d3dd1b5a1", async() => {
                BeginContext(2240, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
                                          WriteLiteral(item.Idhotel);

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
            BeginContext(2251, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2270, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55625644f7474a399602500f4e015a95", async() => {
                BeginContext(2322, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
                                         WriteLiteral(item.Idhotel);

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
            BeginContext(2332, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 82 "C:\Users\Henrique\Desktop\PrjEstagio-master\BookingProjeto\Booking\Views\Hoteis\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2367, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Booking.Hoteis>> Html { get; private set; }
    }
}
#pragma warning restore 1591
