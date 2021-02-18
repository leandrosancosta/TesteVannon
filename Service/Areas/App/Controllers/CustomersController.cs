using Business.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Service.Areas.App.Controllers
{
    public class CustomersController : Controller
    {
        private CustomersBusiness cb;

        public CustomersController()
        {
            cb = new CustomersBusiness();
        }


        public ActionResult Index()
        {
            var customers = cb.GetCustomers();
            return View(customers);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}