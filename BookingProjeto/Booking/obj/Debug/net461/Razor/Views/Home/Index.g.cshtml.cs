#pragma checksum "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16eb1795eb549495a855d872039461014cc6a5ce"
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
#line 1 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\_ViewImports.cshtml"
using Booking;

#line default
#line hidden
#line 2 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\_ViewImports.cshtml"
using Booking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16eb1795eb549495a855d872039461014cc6a5ce", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48cb8ea961cb0ab3563b2a23336f52fa904a03b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking.Models.ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    ViewBag.Title = "";

#line default
#line hidden
            BeginContext(105, 134, true);
            WriteLiteral("\r\n<link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\r\n\r\n\r\n\r\n<div class=\"container\" id=\"quartos\">\r\n");
            EndContext();
#line 13 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
     foreach (var item in Model.Quartos)
    {

#line default
#line hidden
            BeginContext(288, 90, true);
            WriteLiteral("        <div id=\"main\">\r\n            <div class=\"col-md-4\" id=\"img\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 378, "\"", 396, 1);
#line 17 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
WriteAttributeValue("", 384, item.Imagem, 384, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(397, 181, true);
            WriteLiteral(" id=\"imgReservas\" />\r\n            </div>\r\n\r\n            <div class=\"col-md-8\" id=\"text\" style=\"left: 0%;\">\r\n\r\n                <div class=\"col-md-9\">\r\n                    <h2>Quarto ");
            EndContext();
            BeginContext(579, 15, false);
#line 23 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                          Write(item.TipoQuarto);

#line default
#line hidden
            EndContext();
            BeginContext(594, 47, true);
            WriteLiteral(" </h2>\r\n                    <h4 class=\"hoteis\">");
            EndContext();
            BeginContext(642, 14, false);
#line 24 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                  Write(item.NomeHotel);

#line default
#line hidden
            EndContext();
            BeginContext(656, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(660, 16, false);
#line 24 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                                    Write(item.NumEstrelas);

#line default
#line hidden
            EndContext();
            BeginContext(676, 41, true);
            WriteLiteral(" Estrelas</h4>\r\n\r\n                    <p>");
            EndContext();
            BeginContext(718, 11, false);
#line 26 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                  Write(item.Morada);

#line default
#line hidden
            EndContext();
            BeginContext(729, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(732, 15, false);
#line 26 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                Write(item.Localidade);

#line default
#line hidden
            EndContext();
            BeginContext(747, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(750, 14, false);
#line 26 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                                  Write(item.CodPostal);

#line default
#line hidden
            EndContext();
            BeginContext(764, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(767, 9, false);
#line 26 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                                                   Write(item.Pais);

#line default
#line hidden
            EndContext();
            BeginContext(776, 59, true);
            WriteLiteral("</p>\r\n\r\n                    <br />\r\n                    <p>");
            EndContext();
            BeginContext(836, 15, false);
#line 29 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                  Write(item.Capacidade);

#line default
#line hidden
            EndContext();
            BeginContext(851, 209, true);
            WriteLiteral(" Pessoas</p>\r\n                </div>\r\n\r\n                <div class=\"col-md-3\" style=\"margin: 10% 0% 5% 0%; text-align: right\">\r\n                    <h6 id=\"desde\">Desde</h6>\r\n                    <p id=\"preco\">");
            EndContext();
            BeginContext(1061, 10, false);
#line 34 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                             Write(item.Preco);

#line default
#line hidden
            EndContext();
            BeginContext(1071, 31, true);
            WriteLiteral("€</p>\r\n\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1102, "\"", 1294, 1);
#line 36 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
WriteAttributeValue("", 1109, Url.Action("Book", "Home", new { hotel = item.NomeHotel, quarto = item.TipoQuarto, preco = item.Preco, CheckIn = item.CheckIn, CheckOut = item.CheckOut, capacidade = item.Capacidade }), 1109, 185, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1295, 110, true);
            WriteLiteral(" class=\"btn btn-info\" role=\"button\">Reservar</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 40 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1412, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking.Models.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
