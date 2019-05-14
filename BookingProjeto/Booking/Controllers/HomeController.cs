using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
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
            var cs = "Server=Ricki-pc; Database=Booking; Trusted_Connection=True;";

            var list = new List<QuartosDisp>();
<<<<<<< HEAD

            var list2 = new List<EspecificacoesQuarto>();





            using (var cn = new SqlConnection(cs))
=======
            var list2 = new List<EspecificacoesQuarto>();
            
            using(var cn = new SqlConnection(cs))
>>>>>>> d50c838d9f47baa0a9738f092d3f9a131d5c088c
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
<<<<<<< HEAD
                string sql = "select tq.IdTipoQuarto, h.IdHotel, tq.Imagem, tq.Descricao, tq.Capacidade, h.NomeHotel, h.NumEstrelas, h.Morada, h.Localidade, h.CodPostal, h.Pais, p.Preco " +
                             "from TipoQuarto tq, Hoteis h, Precario p " +
                             "where tq.IDHotel = h.IDHotel and tq.IDTipoQuarto = p.IDTipoQuarto";
=======

                string sql = "select rs.CheckIn, rs.CheckOut,tq.Imagem, tq.Descricao, tq.Capacidade, h.NomeHotel, h.NumEstrelas, h.Morada, h.Localidade, h.CodPostal, h.Pais, p.Preco " +
                             "from TipoQuarto tq, Hoteis h, Precario p, Reservas rs " +
                             "where tq.IDHotel = h.IDHotel and tq.IDTipoQuarto = p.IDTipoQuarto and tq.IDTipoQuarto = rs.IDTipoQuarto ";
>>>>>>> d50c838d9f47baa0a9738f092d3f9a131d5c088c

                string sql2 = "select eq.IDEspecificacao, eq.IDTipoQuarto, eq.Descricao " +
                              "from EspecificacoesQuarto eq";

                using (var cm = new SqlCommand(sql, cn))
                {
                    var rd = cm.ExecuteReader();
<<<<<<< HEAD

=======
                
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

                        DateTime checkin = new DateTime();
                        DateTime checkout = new DateTime();

                        checkin = rd.GetDateTime(rd.GetOrdinal("CheckIn"));
                        checkout = rd.GetDateTime(rd.GetOrdinal("CheckOut"));

                        if (checkout == null || checkout.Date <= DateTime.UtcNow)
                        {

                            list.Add(quartos);

                        }
                        else
                        {

                        }
>>>>>>> d50c838d9f47baa0a9738f092d3f9a131d5c088c
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

<<<<<<< HEAD
                        DateTime checkin = new DateTime();
                        DateTime checkout = new DateTime();
=======
                        list.Add(quartos);
                    }
                }
            }
            return View(list);
        }


        //Para o if dos quartos

        //    quartos.Imagem = rd.GetString(rd.GetOrdinal("Imagem"));
        //    quartos.TipoQuarto = rd.GetString(rd.GetOrdinal("Descricao"));
        //    quartos.Capacidade = rd.GetByte(rd.GetOrdinal("Capacidade"));
        //    quartos.NomeHotel = rd.GetString(rd.GetOrdinal("NomeHotel"));
        //    quartos.NumEstrelas = rd.GetString(rd.GetOrdinal("NumEstrelas"));
        //    quartos.Morada = rd.GetString(rd.GetOrdinal("Morada"));
        //    quartos.Localidade = rd.GetString(rd.GetOrdinal("Localidade"));
        //    quartos.CodPostal = rd.GetString(rd.GetOrdinal("CodPostal"));
        //    quartos.Pais = rd.GetString(rd.GetOrdinal("Pais"));
        //    quartos.Preco = rd.GetDecimal(rd.GetOrdinal("Preco"));

>>>>>>> d50c838d9f47baa0a9738f092d3f9a131d5c088c

                        checkin = rd.GetDateTime(rd.GetOrdinal("CheckIn"));
                        checkout = rd.GetDateTime(rd.GetOrdinal("CheckOut"));

                        if (checkout == null || checkout.Date <= DateTime.UtcNow || checkout.Equals(""))
                        {
                            list.Add(quartos);
                        }
                        else
                        {

<<<<<<< HEAD
                        }
                    }
                }

=======
>>>>>>> d50c838d9f47baa0a9738f092d3f9a131d5c088c
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
            //return View(list);
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
<<<<<<< HEAD



        

=======


        //PARA AS ESTRELAS

        /*@if(@item.NumEstrelas.Equals("1"))
        {
            <p><i class="fa fa-star" style="font-size:24px;color:yellow"></i></p>
        }
        else
        if (@item.NumEstrelas.Equals("2"))
        {
            <i class="fa fa-star" style="font-size:24px;color:yellow"></i><i class="fa fa-star" style="font-size:24px;color:yellow"></i>
        }
        else
        if (@item.NumEstrelas.Equals("3"))
        {
            <p><i class="fa fa-star" style="font-size:24px;color:yellow"></i>
                <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
                <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
            </p>
        }
        else
        if (@item.NumEstrelas.Equals("4"))
        {
            <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
            <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
            <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
            <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
        }
        else
        if (@item.NumEstrelas.Equals("5"))
        {
            <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
            <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
            <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
            <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
            <i class="fa fa-star" style="font-size:24px;color:yellow"></i>
        }*/

>>>>>>> d50c838d9f47baa0a9738f092d3f9a131d5c088c
    }
}
