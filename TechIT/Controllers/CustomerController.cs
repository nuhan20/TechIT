using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechIT.Models;

namespace TechIT.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Customer(string Name, string Email, int MobileNo, string Gender, string Address, int Cus_Id)
        {
            var db = new TechITEntities();
            var name = (from n in db.Customer
                        where n.Cus_Id == Cus_Id
                        select n).SingleOrDefault();
            ViewBag.name = name.Name;
            ViewBag.email = Email;
            ViewBag.mobileNo = MobileNo;
            ViewBag.gender = Gender;
            ViewBag.address = Address;
           
            if (Sort.Equals("All"))
            {
                var rq = (from r in db.Requests
                          where r.employee_id == id
                          select r).ToList();

                return View(rq);
            }
            return View();
        }
        [HttpGet]

        public ActionResult Customer(CustomerModel customer)
        {
            return View();
        }
    }
}