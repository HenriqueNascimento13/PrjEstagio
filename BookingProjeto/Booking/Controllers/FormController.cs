using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Booking.Models;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    public class FormController : Controller
    {
        public ActionResult _Layout()
        {
            return PartialView("Form");
        }

        //public IActionResult Form()
        //{
        //    //var cs = "Server=Ricki-PC; Database=Booking; Trusted_Connection=True;";
        //    var cs = "server=DESKTOP-IH74466; database=Booking; Trusted_Connection=True;";

        //    List<TipoQuarto> list = PreencheTipos(cs);

        //    //ViewModel model = new ViewModel(list2);

        //    ViewBag.List = list;

        //    return View();
        //}

        //public List<TipoQuarto> PreencheTipos(string cs)
        //{

        //    var list2 = new List<TipoQuarto>();
        //    var aux = new List<TipoQuarto>();

        //    using (var cn = new SqlConnection(cs))
        //    {
        //        cn.Open();

        //        string sql2 = "select tq.Descricao from TipoQuarto tq";

        //        using (var cm = new SqlCommand(sql2, cn))
        //        {
        //            var rd = cm.ExecuteReader();

        //            while (rd.Read())
        //            {
        //                TipoQuarto tipo = new TipoQuarto();

        //                tipo.Descricao = rd.GetString(rd.GetOrdinal("Descricao"));

        //                list2.Add(tipo);
        //            }

        //            aux = list2;

        //            rd.Close();
        //        }
        //        cn.Close();
        //    }

        //    for (int i = 0; i <= list2.Count() - 1; i++)
        //    {
        //        for (int y = 0; y <= aux.Count() - i - 1; y++)
        //        {
        //            if (i != y)
        //            {
        //                if (list2[i].Descricao.Equals(aux[y].Descricao))
        //                {
        //                    TipoQuarto outro = aux[y];

        //                    aux.Remove(outro);
        //                }
        //            }
        //        }
        //    }
        //    return aux;
        //}
    }
}