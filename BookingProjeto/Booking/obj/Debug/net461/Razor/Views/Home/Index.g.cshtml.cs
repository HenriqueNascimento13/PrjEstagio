#pragma checksum "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf3f1738c6c401693825c98a8af9cc13ef94ea0e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3f1738c6c401693825c98a8af9cc13ef94ea0e", @"/Views/Home/Index.cshtml")]
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
            BeginContext(105, 92, true);
            WriteLiteral("\r\n<link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\r\n\r\n");
            EndContext();
#line 10 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
 if (ViewBag.Aviso != null)
{

#line default
#line hidden
            BeginContext(229, 85, true);
            WriteLiteral("    <div class=\"container\" id=\"quartos\">\r\n        <div id=\"aviso\">\r\n            <h3> ");
            EndContext();
            BeginContext(315, 13, false);
#line 14 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
            Write(ViewBag.Aviso);

#line default
#line hidden
            EndContext();
            BeginContext(328, 86, true);
            WriteLiteral(" </h3>\r\n            <h5> * Mude o campo \'Quartos\' *</h5>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
}


#line default
#line hidden
            BeginContext(511, 44, true);
            WriteLiteral("\r\n    <div class=\"container\" id=\"quartos\">\r\n");
            EndContext();
#line 28 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
         foreach (var item in Model.Quartos)
        {

#line default
#line hidden
            BeginContext(612, 102, true);
            WriteLiteral("            <div id=\"main\">\r\n                <div class=\"col-md-4\" id=\"img\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 714, "\"", 732, 1);
#line 32 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
WriteAttributeValue("", 720, item.Imagem, 720, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(733, 197, true);
            WriteLiteral(" id=\"imgReservas\" />\r\n                </div>\r\n\r\n                <div class=\"col-md-8\" id=\"text\" style=\"left: 0%;\">\r\n\r\n                    <div class=\"col-md-9\">\r\n                        <h2>Quarto ");
            EndContext();
            BeginContext(931, 15, false);
#line 38 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                              Write(item.TipoQuarto);

#line default
#line hidden
            EndContext();
            BeginContext(946, 51, true);
            WriteLiteral(" </h2>\r\n                        <h4 class=\"hoteis\">");
            EndContext();
            BeginContext(998, 14, false);
#line 39 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                      Write(item.NomeHotel);

#line default
#line hidden
            EndContext();
            BeginContext(1012, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1016, 16, false);
#line 39 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                                        Write(item.NumEstrelas);

#line default
#line hidden
            EndContext();
            BeginContext(1032, 45, true);
            WriteLiteral(" Estrelas</h4>\r\n\r\n                        <p>");
            EndContext();
            BeginContext(1078, 11, false);
#line 41 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                      Write(item.Morada);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1092, 15, false);
#line 41 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                    Write(item.Localidade);

#line default
#line hidden
            EndContext();
            BeginContext(1107, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1110, 14, false);
#line 41 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                                      Write(item.CodPostal);

#line default
#line hidden
            EndContext();
            BeginContext(1124, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1127, 9, false);
#line 41 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                                                       Write(item.Pais);

#line default
#line hidden
            EndContext();
            BeginContext(1136, 67, true);
            WriteLiteral("</p>\r\n\r\n                        <br />\r\n                        <p>");
            EndContext();
            BeginContext(1204, 15, false);
#line 44 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                      Write(item.Capacidade);

#line default
#line hidden
            EndContext();
            BeginContext(1219, 225, true);
            WriteLiteral(" Pessoas</p>\r\n                    </div>\r\n\r\n                    <div class=\"col-md-3\" style=\"margin: 10% 0% 5% 0%; text-align: right\">\r\n                        <h6 id=\"desde\">Desde</h6>\r\n                        <p id=\"preco\">");
            EndContext();
            BeginContext(1445, 10, false);
#line 49 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
                                 Write(item.Preco);

#line default
#line hidden
            EndContext();
            BeginContext(1455, 35, true);
            WriteLiteral("€</p>\r\n\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1490, "\"", 1839, 1);
#line 51 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
WriteAttributeValue("", 1497, Url.Action("Book", "Home", new {hotel = item.NomeHotel, quarto = item.TipoQuarto, preco = item.Preco, CheckIn = item.CheckIn, CheckOut = item.CheckOut,
                                capacidade = item.Capacidade, regime = item.IdRegime, morada = @item.Morada, localidade = @item.Localidade, codPostal = @item.CodPostal, pais = @item.Pais}), 1497, 342, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1840, 122, true);
            WriteLiteral(" class=\"btn btn-info\" role=\"button\">Reservar</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 56 "C:\Temp\Git\Projeto\BookingProjeto\Booking\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1973, 12, true);
            WriteLiteral("    </div>\r\n");
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
