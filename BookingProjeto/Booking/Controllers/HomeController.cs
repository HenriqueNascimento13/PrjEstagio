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

        
        public ActionResult Index(DateTime CheckIn, DateTime CheckOut, string tipoQuarto, int QuantQuartos)
        {
            //var cs = "Server=Ricki-PC; Database=Booking; Trusted_Connection=True;";
            var cs = "server=DESKTOP-IH74466; database=Booking; Trusted_Connection=True;";

            ViewModel model = new ViewModel();

            long IDTipoQuarto = BuscarIdtipoQuarto(tipoQuarto, cs);

            var list = MostrarQuartos(cs, true);

            List<string> list3 = PreencheTipos(cs);

            if (CheckIn.ToString().Equals("01-01-0001 00:00:00") && CheckOut.ToString().Equals("01-01-0001 00:00:00"))
            {
                model = new ViewModel(list);
            }
            else
            {
                var result = CheckAvailability(cs, CheckIn, CheckOut, tipoQuarto, QuantQuartos);

                var list2 = MostrarQuartos(cs, result,/* CheckIn, CheckOut,*/ IDTipoQuarto);

                model = new ViewModel(list2);
            }    
            ViewBag.List = list3;

            return View(model);
        }


        [HttpPost]
        public ActionResult Book(int capacidade, string checkOut, string checkIn, decimal preco, string tipo, string hotel, string nomeR, string sobrenomeR, int adultos, int criancas, int quant, string regime, string nome, string sobrenome, string email, string telefone, string endereco, string codPostal, string localidade, string cc, string dataNasc, string nomeTitular, string numCartao, string tipoCartao, string prazo, string cvv)
        {
            //var cs = "Server=Ricki-PC; Database=Booking; Trusted_Connection=True;";
            var cs = "server=DESKTOP-IH74466; database=Booking; Trusted_Connection=True;";

            AddCliente(cs, nome, sobrenome, email, telefone, endereco, codPostal, localidade, cc, dataNasc);

            AddPagamento(cs, nomeTitular, numCartao, tipoCartao, prazo, cvv);

            AddReserva(cs, nomeR, sobrenomeR, adultos, criancas, quant, regime, cc, numCartao, hotel, tipo, checkOut, checkIn, capacidade);


            return RedirectToAction("Index", "Home", new { message = "Reserva Efetuada com Sucesso!" });
        }

        public ActionResult Book(string hotel, string quarto, decimal preco, DateTime CheckIn, DateTime CheckOut, int capacidade)
        {
            //var cs = "Server=Ricki-PC; Database=Booking; Trusted_Connection=True;";
            var cs = "server=DESKTOP-IH74466; database=Booking; Trusted_Connection=True;";

            Dados dados = new Dados(hotel, quarto, preco, CheckIn, CheckOut, capacidade);

            List<string> list = PreencheRegimes(cs, hotel, quarto, capacidade);
            List<string> list2 = PreencheTipoPagamento(cs);
            List<int> quantQuartos = PreencheQuantQuartos(cs, hotel, quarto, capacidade/*, CheckIn, CheckOut*/);

            ViewModel model = new ViewModel(list, list2, dados, quantQuartos);

            return View(model);
        }



        public bool CheckAvailability(string cs, DateTime checkIn, DateTime checkOut, string TipoQuarto, int QuantQuartos)
        {
            bool result = false;
            int contaReservados = 0;
            List<CheckAvailability> list = new List<CheckAvailability>();
            List<Reservas> listReservas = new List<Reservas>();

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                string sql1 = "Select tq.Inventario, tq.IDHotel, tq.IDTipoQuarto from TipoQuarto tq where tq.Descricao = @tipoQuarto";  //Todos os inventarios do tipo de quarto selecionado

                using (var cm = new SqlCommand(sql1, cn))
                {
                    cm.Parameters.AddWithValue("@tipoQuarto", TipoQuarto);
                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        CheckAvailability check = new CheckAvailability
                        {
                            Inv = rd.GetInt32(rd.GetOrdinal("Inventario")),
                            Id = rd.GetInt64(rd.GetOrdinal("IDHotel")),
                            IdQuarto = rd.GetInt64(rd.GetOrdinal("IDTipoQuarto"))
                        };

                        list.Add(check);
                    }
                    rd.Close();
                }

                string sql2 = "select rs.IDReserva, rs.IDHotel, rs.IDTipoQuarto, rs.CheckIn, rs.CheckOut from Reservas rs, TipoQuarto tq where rs.IDTipoQuarto = tq.IDTipoQuarto and tq.Descricao = @tipoQuarto";   
                    //Todas as reservas
                using (var cm = new SqlCommand(sql2, cn))
                {
                    cm.Parameters.AddWithValue("@tipoQuarto", TipoQuarto);
                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        Reservas reserva = new Reservas
                        {
                            Idreserva = rd.GetInt64(rd.GetOrdinal("IDReserva")),
                            Idhotel = rd.GetInt64(rd.GetOrdinal("IDHotel")),
                            IdtipoQuarto = rd.GetInt64(rd.GetOrdinal("IDTipoQuarto")),
                            CheckIn = rd.GetDateTime(rd.GetOrdinal("CheckIn")),
                            CheckOut = rd.GetDateTime(rd.GetOrdinal("CheckOut"))
                        };

                        listReservas.Add(reserva);
                    }
                    rd.Close();
                }

                foreach (CheckAvailability item in list)
                {
                    for (DateTime i = checkIn; i <= checkOut; i = i.AddDays(1.0))
                    {
                        foreach (Reservas rs in listReservas)
                        {
                            if (checkOut <= rs.CheckIn || rs.CheckOut <= checkIn)
                            {
                                if (item.Inv - contaReservados >= QuantQuartos)  // quartos que nunca foram reservados
                                {
                                    result = true;
                                }
                                else
                                {
                                    result = false;
                                }
                            }
                            else
                            {
                                result = false;
                            }
                        }
                    }
                }

                cn.Close();
            }
            return result;
        }

        public List<string> PreencheTipos(string cs)
        {
            var list = new List<string>();
            var aux = new List<string>();

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                string sql = "select tq.Descricao from TipoQuarto tq";

                using (var cm = new SqlCommand(sql, cn))
                {
                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        string tipo = "";

                        tipo = rd.GetString(rd.GetOrdinal("Descricao"));

                        aux.Add(tipo);
                    }
                    
                    rd.Close();
                }
                cn.Close();
            }

            for (int i = 0; i <= aux.Count() - 1; i++)
            {
                string cat = aux[i];
                if (!list.Contains(cat))
                {
                    list.Add(cat);
                }
            }

            return list;
        }

        public List<QuartosDisp> MostrarQuartos(string cs, bool result)
        {
            var list = new List<QuartosDisp>();

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                string sql = "Select tq.IDTipoQuarto, h.IDHotel, tq.Imagem, tq.Descricao, tq.Capacidade, h.NomeHotel, h.NumEstrelas, h.Morada, h.Localidade, h.CodPostal, h.Pais, p.Preco " +
                             "From TipoQuarto tq, Hoteis h, Precario p, Regimes r " +
                             "Where tq.IDHotel = h.IDHotel and tq.IDTipoQuarto = p.IDTipoQuarto and r.IDRegime = p.IDRegime";

                if (result == true)
                {
                    using (var cm = new SqlCommand(sql, cn))
                    {
                        var rd = cm.ExecuteReader();

                        while (rd.Read())
                        {
                            var quartos = new QuartosDisp();

                            quartos.IdTipoQuarto = rd.GetInt64(rd.GetOrdinal("IDTipoQuarto"));
                            quartos.IdHotel = rd.GetInt64(rd.GetOrdinal("IDHotel"));
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
                }

                for (int i = 0; i <= list.Count() - 1; i++)
                {
                    for (int y = 0; y <= list.Count() - 1; y++)
                    {
                        if (i != y)
                        {
                            if (list[i].IdTipoQuarto == list[y].IdTipoQuarto && list[i].Capacidade == list[y].Capacidade)
                            {
                                if (list[i].Preco > list[y].Preco)
                                {
                                    list.Remove(list[i]);
                                    y--;
                                }
                            }
                        }
                    }
                }
                cn.Close();
            }
            return list;
        }

        public List<QuartosDisp> MostrarQuartos(string cs, bool result/*, DateTime ci, DateTime co*/, long TipoQuarto)
        {
            var list = new List<QuartosDisp>();
            string tipo = "";

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                if (result == true)
                {
                    string sql = "Select tq.Descricao from TipoQuarto tq where tq.IDTipoQuarto = @TipoQuarto";                                            

                    using (var cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.AddWithValue("@TipoQuarto", TipoQuarto);
                        var rd = cm.ExecuteReader();

                        if (rd.Read())
                        {
                            tipo = rd.GetString(rd.GetOrdinal("Descricao"));
                        }
                        rd.Close();
                    }

                    string sql2 = "Select tq.IDTipoQuarto, h.IDHotel, tq.Imagem, tq.Descricao, tq.Capacidade, h.NomeHotel, h.NumEstrelas, h.Morada, h.Localidade, h.CodPostal, h.Pais, p.Preco " +
                                    "From TipoQuarto tq, Hoteis h, Precario p, Regimes r " +
                                    "Where tq.IDHotel = h.IDHotel and tq.IDTipoQuarto = p.IDTipoQuarto and r.IDRegime = p.IDRegime and tq.Descricao = @tipo";

                    using (var cm = new SqlCommand(sql2, cn))
                    {
                        cm.Parameters.AddWithValue("@tipo", tipo);
                        var rd = cm.ExecuteReader();

                        while (rd.Read())
                        {
                            var quartos = new QuartosDisp();

                            quartos.IdTipoQuarto = rd.GetInt64(rd.GetOrdinal("IDTipoQuarto"));
                            quartos.IdHotel = rd.GetInt64(rd.GetOrdinal("IDHotel"));
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

                    for (int i = 0; i <= list.Count() - 1; i++)
                    {
                        for (int y = 0; y <= list.Count() - 1; y++)
                        {
                            if (i != y)
                            {
                                if (list[i].IdTipoQuarto == list[y].IdTipoQuarto && list[i].Capacidade == list[y].Capacidade)
                                {
                                    list.Remove(list[i]);
                                }
                            }
                        }
                    }                        
                }
                cn.Close();               
            }            
            return list;
        }

        public long BuscarIdtipoQuarto(string tipoQuarto, string cs)
        {
            long TipoQuarto = 0;

            if (tipoQuarto != null)
            {
                using (var cn = new SqlConnection(cs))
                {
                    cn.Open();

                    string sql = "select tq.IDTipoQuarto from TipoQuarto tq where tq.Descricao = @tipoQuarto";

                    using (var cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.AddWithValue("@tipoQuarto", tipoQuarto);
                        var rd = cm.ExecuteReader();

                        if (rd.Read())
                        {
                            TipoQuarto = rd.GetInt64(rd.GetOrdinal("IDTipoQuarto"));
                        }
                        rd.Close();
                    }
                    cn.Close();
                }
            }
            return TipoQuarto;
        }

        public void AddReserva(string cs, string nomeR, string sobrenomeR, int adultos, int criancas, int quant, string regime, string cc, string numCartao, string hotel, string tipoQuarto, string checkOut, string checkIn, int capacidade)
        {
            long idHotel = 0;
            long idCliente = 0;
            byte idRegime = 0;
            long idQuarto = 0;
            long codPag = 0;

            string sql = "Insert into Reservas values(@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11, @param12)";

            string sql2 = "select h.IDHotel, cl.IDCliente, rg.IDRegime, tq.IDTipoQuarto, p.CodPagamento from Hoteis h, Clientes cl, Regimes rg, TipoQuarto tq, Pagamento p " +
                "where h.IDHotel = rg.IDHotel and tq.IDHotel = h.IDHotel and h.NomeHotel = @hotel and " +
                "cl.CC = @cc and rg.TipoRegime = @regime and tq.Descricao = @tipoQuarto and p.NumCartao = @numCartao";

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                using (var cm = new SqlCommand(sql2, cn))
                {
                    cm.Parameters.AddWithValue("@hotel", hotel);
                    cm.Parameters.AddWithValue("@tipoQuarto", tipoQuarto);
                    cm.Parameters.AddWithValue("@regime", regime);
                    cm.Parameters.AddWithValue("@numCartao", numCartao);
                    cm.Parameters.AddWithValue("@cc", cc);
                    cm.Parameters.AddWithValue("@capacidade", capacidade);

                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        codPag = rd.GetInt64(rd.GetOrdinal("CodPagamento"));
                        idQuarto = rd.GetInt64(rd.GetOrdinal("IDTipoQuarto"));
                        idHotel = rd.GetInt64(rd.GetOrdinal("IDHotel"));
                        idRegime = rd.GetByte(rd.GetOrdinal("IDRegime"));
                        idCliente = rd.GetInt64(rd.GetOrdinal("IDCliente"));
                    }
                    rd.Close();
                }

                using (var cm = new SqlCommand(sql, cn))
                {
                    cm.Parameters.AddWithValue("@param1", idHotel);
                    cm.Parameters.AddWithValue("@param2", idCliente);
                    cm.Parameters.AddWithValue("@param3", idRegime);
                    cm.Parameters.AddWithValue("@param4", idQuarto);
                    cm.Parameters.AddWithValue("@param5", codPag);
                    cm.Parameters.AddWithValue("@param6", adultos);
                    cm.Parameters.AddWithValue("@param7", criancas);
                    cm.Parameters.AddWithValue("@param8", checkIn);
                    cm.Parameters.AddWithValue("@param9", checkOut);
                    cm.Parameters.AddWithValue("@param10", quant);
                    cm.Parameters.AddWithValue("@param11", nomeR);
                    cm.Parameters.AddWithValue("@param12", sobrenomeR);
                    cm.ExecuteNonQuery();
                }
                cn.Close();
            }
        }

        public void AddPagamento(string cs, string nomeTitular, string numCartao, string tipoCartao, string prazo, string cvv)
        {
            int id = 0;
            string sql = "Insert into Pagamento values(@param1, @param2, @param3, @param4, @param5)";
            string sql2 = "Select tp.IDTipoPagamento from TipoPagamento tp where tp.Designacao = @tipoCartao";

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                using (var cm = new SqlCommand(sql2, cn))
                {
                    cm.Parameters.AddWithValue("@tipoCartao", tipoCartao);
                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        id = rd.GetInt16(rd.GetOrdinal("IDTipoPagamento"));
                    }

                    rd.Close();
                }

                using (var cm = new SqlCommand(sql, cn))
                {
                    cm.Parameters.AddWithValue("@param1", id);
                    cm.Parameters.AddWithValue("@param2", nomeTitular);
                    cm.Parameters.AddWithValue("@param3", numCartao);
                    cm.Parameters.AddWithValue("@param4", prazo);
                    cm.Parameters.AddWithValue("@param5", cvv);
                    cm.ExecuteNonQuery();
                }
                cn.Close();
            }
        }


        public void AddCliente(string cs, string nome, string sobrenome, string email, string telefone, string endereco, string codPostal, string localidade, string cc, string dataNasc)
        {
            string sql = "Insert into Clientes values(@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9)";

            Clientes cl = new Clientes(nome, sobrenome, email, telefone, endereco, codPostal, localidade, cc, dataNasc);

            if (Existe(cl, cs) == false)
            {
                using (var cn = new SqlConnection(cs))
                {
                    cn.Open();

                    using (var cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.AddWithValue("@param1", nome);
                        cm.Parameters.AddWithValue("@param2", sobrenome);
                        cm.Parameters.AddWithValue("@param3", email);
                        cm.Parameters.AddWithValue("@param4", telefone);
                        cm.Parameters.AddWithValue("@param5", endereco);
                        cm.Parameters.AddWithValue("@param6", localidade);
                        cm.Parameters.AddWithValue("@param7", codPostal);
                        cm.Parameters.AddWithValue("@param8", cc);
                        cm.Parameters.AddWithValue("@param9", dataNasc);
                        cm.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
        }

        public bool Existe(Clientes cl, string cs)
        {
            List<Clientes> list = new List<Clientes>();
            bool result = false;

            string sql2 = "select Nome, Sobrenome, Contacto, Morada, Localidade, Cc, DataNasc from Clientes";

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                using (var cm = new SqlCommand(sql2, cn))
                {
                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        Clientes cl2 = new Clientes();

                        cl2.Nome = rd.GetString(rd.GetOrdinal("Nome"));
                        cl2.Sobrenome = rd.GetString(rd.GetOrdinal("Sobrenome"));
                        cl2.Contacto = rd.GetString(rd.GetOrdinal("Contacto"));
                        cl2.Morada = rd.GetString(rd.GetOrdinal("Morada"));
                        cl2.Localidade = rd.GetString(rd.GetOrdinal("Localidade"));
                        cl2.Cc = rd.GetString(rd.GetOrdinal("Cc"));
                        cl2.DataNasc = rd.GetString(rd.GetOrdinal("DataNasc"));

                        list.Add(cl2);
                    }
                    rd.Close();
                }

                for (int i = 0; i <= list.Count() -1; i++)
                {
                    if (list[i].Nome == cl.Nome && list[i].Sobrenome == cl.Sobrenome && list[i].Contacto == cl.Contacto && list[i].Morada == cl.Morada && list[i].Localidade == cl.Localidade && list[i].Cc == cl.Cc && list[i].DataNasc == cl.DataNasc)
                    {
                        return true;
                    }
                    if (list[i].Nome != cl.Nome || list[i].Sobrenome != cl.Sobrenome || list[i].Contacto != cl.Contacto || list[i].Morada != cl.Morada || list[i].Localidade != cl.Localidade || list[i].Cc != cl.Cc || list[i].DataNasc != cl.DataNasc)
                    {
                        result = false;
                    }
                }

                cn.Close();
            }
            return result;
        }

        public List<int> PreencheQuantQuartos(string cs, string hotel, string quarto, int capacidade/*, DateTime CheckIn, DateTime CheckOut*/)
        {
            int inventario = 0;
            long id = 0;
            int quantQuartos = 0;
            int total = 0;


            List<int> list = new List<int>();

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                string sql = "select tq.Inventario, tq.IDTipoQuarto from TipoQuarto tq, Hoteis h where tq.Descricao = @quarto and h.NomeHotel = @hotel and  tq.Capacidade = @capacidade";                

                using (var cm = new SqlCommand(sql, cn))
                {
                    cm.Parameters.AddWithValue("@quarto", quarto);
                    cm.Parameters.AddWithValue("@hotel", hotel);
                    cm.Parameters.AddWithValue("@capacidade", capacidade);
                    var rd = cm.ExecuteReader();

                    if (rd.Read())
                    {
                        inventario = rd.GetInt32(rd.GetOrdinal("Inventario"));
                        id = rd.GetInt64(rd.GetOrdinal("IDTipoQuarto"));
                    }
                    rd.Close();
                }

                string sql2 = "select rs.QuantQuartos from Reservas rs, TipoQuarto tq where rs.IDTipoQuarto = tq.IDTipoQuarto and tq.IDTipoQuarto = @id";

                using (var cm = new SqlCommand(sql2, cn))
                {
                    cm.Parameters.AddWithValue("@id", id);
                    var rd = cm.ExecuteReader();

                    if (rd.Read())
                    {
                        quantQuartos = rd.GetInt32(rd.GetOrdinal("QuantQuartos"));
                    }
                    rd.Close();
                }

                total = inventario - quantQuartos;

                for (int i = 1; i <= total; i++)
                {
                    list.Add(i);
                }

                cn.Close();
            }
            return list;
        }

        public List<string> PreencheTipoPagamento(string cs)
        {
            List<string> list = new List<string>();

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                string sql = "select tp.Designacao from TipoPagamento tp";

                using (var cm = new SqlCommand(sql, cn))
                {
                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        string tipo = "";

                        tipo = rd.GetString(rd.GetOrdinal("Designacao"));

                        list.Add(tipo);
                    }
                    rd.Close();
                }
                cn.Close();
            }

            return list;
        }

        public List<string> PreencheRegimes(string cs, string hotel, string quarto, int capacidade)
        {
            List<string> list = new List<string>();

            using (var cn = new SqlConnection(cs))
            {
                cn.Open();

                string sql = "select rg.TipoRegime from Regimes rg, Hoteis h, TipoQuarto tq " +
                             "where rg.IDHotel = h.IDHotel and h.IDHotel = tq.IDHotel and h.NomeHotel =  @hotel and tq.Descricao = @quarto and tq.Capacidade = @capacidade";

                using (var cm = new SqlCommand(sql, cn))
                {
                    cm.Parameters.AddWithValue("@hotel", hotel);
                    cm.Parameters.AddWithValue("@quarto", quarto);
                    cm.Parameters.AddWithValue("@capacidade", capacidade);
                    var rd = cm.ExecuteReader();

                    while (rd.Read())
                    {
                        string tipo = "";

                        tipo = rd.GetString(rd.GetOrdinal("TipoRegime"));

                        list.Add(tipo);
                    }
                    rd.Close();
                }
                cn.Close();
            }

            return list;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




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
