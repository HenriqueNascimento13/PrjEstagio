using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    public class FormController : Controller
    {
        public ActionResult _Layout()
        {
            return PartialView("Form");
        }
    }
}