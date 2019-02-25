using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Warehouse.Models
{
    public class MembershipType
    {
        [Required]
        public String Name { get; set; }
        public byte Id { get; set; }

        public short SignUpFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }
        

    }
}