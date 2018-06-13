using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mallform.Models;
using mallform.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace mallform.ViewModel
{
    public class TenantFormViewModel
    {

        [Required]
       
        public string shopName { get; set; }
        
        [Required]
 
        public string brandName { get; set; }

        [Required]
       
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

        public string mobileNo { get; set; }

        [Required]
        public string panNo { get; set; }

    
        public Tenant Tenant { get; set; }



    }
}