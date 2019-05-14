using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Booking.Models;
using Microsoft.AspNetCore.Authorization;
using Booking.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;

namespace Booking.Controllers
{
    public class HomeController : Controller
    {
        BookingContext db = new BookingContext();
        //public IActionResult Index()
        //{
        //    return View();
        //}

        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        

        public IActionResult Privacy()
        {
            return View();
        }
        
        public ActionResult Index()
        {
            //var cs = "Server=Ricki-PC; Database=Booking; Trusted_Connection=True;";
            var cs = "server=DESKTOP-IH74466; database=Booking; Trusted_Connection=True;";

            var list = new List<QuartosDisp>();
            var list2 = new List<EspecificacoesQuarto>();

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                string sql = "select tq.IdTipoQuarto, h.IdHotel, tq.Imagem, tq.Descricao, tq.Capacidade, h.NomeHotel, h.NumEstrelas, h.Morada, h.Localidade, h.CodPostal, h.Pais, p.Preco " +
                             "from TipoQuarto tq, Hoteis h, Precario p " +
                             "where tq.IDHotel = h.IDHotel and tq.IDTipoQuarto = p.IDTipoQuarto";

                string sql2 = "select eq.IDEspecificacao, eq.IDTipoQuarto, eq.Descricao " +
                              "from EspecificacoesQuarto eq";

                using (var cm = new SqlCommand(sql, cn))
                {
                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        var quartos = new QuartosDisp();

                        quartos.IdTipoQuarto = rd.GetInt64(rd.GetOrdinal("IdTipoQuarto"));
                        quartos.IdHotel = rd.GetInt64(rd.GetOrdinal("IdHotel"));
                        quartos.Imagem = rd.GetString(rd.GetOrdinal("Imagem"));
                        quartos.TipoQuarto = rd.GetString(rd.GetOrdinal("Descricao"));
                        quartos.Capacidade = rd.GetByte(rd.GetOrdinal("Capacidade"));
                        quartos.NomeHotel = rd.GetString(rd.GetOrdinal("NomeHotel"));
                        quartos.NumEstrelas = rd.GetString(rd.GetOrdinal("NumEstrelas"));
                        quartos.Morada = rd.GetString(rd.GetOrdinal("Morada"));
                        quartos.Localidade = rd.GetString(rd.GetOrdinal("Localidade"));
                        quartos.CodPostal = rd.GetString(rd.GetOrdinal("CodPostal"));
                        quartos.Pais = rd.GetString(rd.GetOrdinal("Pais"));
                        quartos.Preco = rd.GetDecimal(rd.GetOrdinal("Preco"));

                        list.Add(quartos);
                    }
                    rd.Close();
                }

                using (var cm = new SqlCommand(sql2, cn))
                {
                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        var esp = new EspecificacoesQuarto();

                        esp.Idespecificacao = rd.GetInt16(rd.GetOrdinal("IdEspecificacao"));
                        esp.IdtipoQuarto = rd.GetInt64(rd.GetOrdinal("IdTipoQuarto"));
                        esp.Descricao = rd.GetString(rd.GetOrdinal("Descricao"));

                        list2.Add(esp);
                    }
                    rd.Close();
                }


                cn.Close();
            }
            ViewModel model = new ViewModel(list, list2);

            return View(model);
        }

        public IActionResult Book(string hotel, string quarto, decimal preco)
        {

            ViewBag.Hotel = hotel;
            ViewBag.Quarto = quarto;
            ViewBag.Preco = preco;
            ViewBag.CheckIn = "Data de Entrada";
            ViewBag.CheckOut = "Data de Saída";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        //PARA MOSTRAR OS HOTEIS
        /*var list2 = new List<Hoteis>();
        //string sql2 = "select NomeHotel, NumEstrelas, Morada, Localidade, CodPostal, Pais, QuantidadeQuartos, Descricao, Imagem from Hoteis ";

         //using (var cm = new SqlCommand(sql2, cn))
                //{
                //    var rd = cm.ExecuteReader();

                //    while (rd.Read())
                //    {
                //        var hoteis = new Hoteis();
                        
                //        hoteis.NomeHotel = rd.GetString(rd.GetOrdinal("NomeHotel"));
                //        hoteis.NumEstrelas = rd.GetString(rd.GetOrdinal("NumEstrelas"));
                //        hoteis.Morada = rd.GetString(rd.GetOrdinal("Morada"));
                //        hoteis.Localidade = rd.GetString(rd.GetOrdinal("Localidade"));
                //        hoteis.CodPostal = rd.GetString(rd.GetOrdinal("CodPostal"));
                //        hoteis.Pais = rd.GetString(rd.GetOrdinal("Pais"));
                //        hoteis.QuantidadeQuartos = rd.GetInt16(rd.GetOrdinal("QuantidadeQuartos"));
                //        hoteis.Descricao = rd.GetString(rd.GetOrdinal("Descricao"));
                //        hoteis.Imagem = rd.GetString(rd.GetOrdinal("Imagem"));

                //        list2.Add(hoteis);
                //    }
                //    rd.Close();
                //}

        */

        //PARA AS ESTRELAS

        /*if (quartos.NumEstrelas.Equals("1"))
        {
            string html = "<p><i class='fa fa-star' style='font-size:24px; color:yellow'></i></p>";
        }
        else
        if (quartos.NumEstrelas.Equals("2"))
        {
            string html2 = "< i class='fa fa-star' style='font-size:24px; color:yellow'></i>" +
                "<i class='fa fa-star' style='font-size:24px; color:yellow'></i>";
        }
        else
        if (quartos.NumEstrelas.Equals("3"))
        {
            string html3 = "<p><i class='fa fa-star' style='font-size: 24px; color:yellow' ></i>" +
                "<i class='fa fa-star' style ='font -size:24px; color:yellow' ></i>" +
                "<i class='fa fa-star' style ='font -size:24px; color:yellow' ></i></p>";
        }
        else
        if (quartos.NumEstrelas.Equals("4"))
        {
            string html4 = "<i class='fa fa-star' style='font-size:24px; color:yellow'></i>" +
                            "<i class='fa fa-star' style ='font -size:24px; color:yellow' ></i>" +
                            "<i class='fa fa-star' style ='font -size:24px; color:yellow' ></i>" +
                            "<i class='fa fa-star' style ='font -size:24px; color:yellow' ></i>";
        }
        else
        if (quartos.NumEstrelas.Equals("5"))
        {
            string html5 = "<i class='fa fa-star' style='font-size:24px; color:yellow'></i>" +
                            "<i class='fa fa-star' style='font-size:24px; color:yellow'></i>" +
                            "<i class='fa fa-star' style='font-size:24px; color:yellow'></i>" +
                            "<i class='fa fa-star' style='font-size:24px; color:yellow'></i>" +
                            "<i class='fa fa-star' style='font-size:24px; color:yellow'></i>";
        } */


        //1 tabela
        /*string sql = "select r.CheckIn as FromDate, r.CheckOut as ToDate, h.NomeHotel as HotelName, tq.Descricao as RoomCategory, p.Preco as Price " +
                        "from Reservas r, Hoteis h, TipoQuarto tq, Precario p " +
                        "where r.IDHotel = h.IDHotel and r.IDTipoQuarto = tq.IDTipoQuarto and p.IDTipoQuarto = tq.IDTipoQuarto";

        using (var cm = new SqlCommand(sql, cn))
        {
            var rd = cm.ExecuteReader();
            while (rd.Read())
            {
                var o = new Ofertas();

                o.FromDate = rd.GetDateTime(rd.GetOrdinal("FromDate"));
                o.ToDate = rd.GetDateTime(rd.GetOrdinal("toDate"));
                o.HotelName = rd.GetString(rd.GetOrdinal("HotelName"));
                o.RoomCategory = rd.GetString(rd.GetOrdinal("RoomCategory"));
                o.Price = rd.GetDecimal(rd.GetOrdinal("Price"));

                list.Add(o);
            }
        }*/
        
    }
}
