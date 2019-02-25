using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Warehouse.Models;


namespace Warehouse.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }


       public MembershipTypeDto MembershipType { get; set; }
       
        public byte MembershipTypeId { get; set; }
   //     [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}