using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mallform.Models
{
    public class Tenant
    {
        public int Id { get; set; }

        [StringLength(50)]
       
        public string shopName { get; set; }


        [StringLength(50)]
        public string brandName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

        public string mobileNo { get; set; }

        [StringLength(50)]


        public string panNo { get; set; }

        

    }
}