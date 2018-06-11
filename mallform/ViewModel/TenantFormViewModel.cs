using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mallform.Models;
using mallform.ViewModel;


namespace mallform.ViewModel
{
    public class TenantFormViewModel
    {
        public string shopName { get; set; }

        public string brandName { get; set; }

        public string Address { get; set; }

        public string mobileNo { get; set; }

        public string panNo { get; set; }

    
        public Tenant Tenant { get; set; }



    }
}