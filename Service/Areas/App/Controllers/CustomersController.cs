using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Service.Areas.App.Controllers
{
    public class CustomersController : Controller
    {
        // GET: App/Customers
        public ActionResult Index()
        {
            return View();
        }
    }
}