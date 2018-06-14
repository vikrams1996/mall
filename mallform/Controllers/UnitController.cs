using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mallform.Models;
using mallform.ViewModel;
using System.Data.Entity;

namespace mallform.Controllers
{
    public class UnitController : Controller
    {
        private ApplicationDbContext _Context;

        public UnitController()
        {

            _Context = new ApplicationDbContext();
        }

        [HttpGet]
        public ActionResult Units()
        {

            var viewModel = new UnitsFormViewModel
            {
                Floors = _Context.Unit.ToList()
        };
        
            return View(viewModel);
    }
    

     

    }
}