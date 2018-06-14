using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mallform.Models;

namespace mallform.ViewModel
{
    public class UnitsFormViewModel
    {

        public string Size { get; set; }

        public int Floor { get; set; }
      
        public IEnumerable<Unit> Floors { get; set; }


    }
}