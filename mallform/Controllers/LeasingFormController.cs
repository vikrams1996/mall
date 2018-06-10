using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using mallform.Models;

namespace mallform.Controllers
{
    public class LeasingFormController : Controller
    {
        // GET: LeasingForm
        private ApplicationDbContext _context;

        public LeasingFormController()
        {

            _context = new ApplicationDbContext();
        }
        public ActionResult Form()
        {



            return View();
        }

        [HttpPost]
        public ActionResult Form(Tenant Form)
        {
            var tenant = new Tenant
            {
                shopName = Form.shopName,
                brandName = Form.brandName,
                Address = Form.Address,
                mobileNo = Form.mobileNo,
                panNo = Form.panNo

            };



            _context.Tenant.Add(tenant);


            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

      


    }
}



