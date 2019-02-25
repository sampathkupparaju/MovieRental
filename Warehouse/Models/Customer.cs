﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Warehouse.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
       

        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}