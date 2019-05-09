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

        public IActionResult Book()
        {
            ViewData["Message"] = "Your book page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Index()
        {
            var cs = "Server=DESKTOP-IH74466; Database=Booking; Trusted_Connection=True;";

            var list = new List<QuartosDisp>();
            

            using(var cn = new SqlConnection(cs))
            {
                cn.Open();

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

                string sql = "select tq.Imagem, tq.Descricao, tq.Capacidade, h.NomeHotel, h.NumEstrelas, h.Morada, h.Localidade, h.CodPostal, h.Pais, p.Preco " +
                             "from TipoQuarto tq, Hoteis h, Precario p " +
                             "where tq.IDHotel = h.IDHotel and tq.IDTipoQuarto = p.IDTipoQuarto";

                using (var cm = new SqlCommand(sql, cn))
                {
                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        var quartos = new QuartosDisp();

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
                    
                }

            }
            return View(list);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
