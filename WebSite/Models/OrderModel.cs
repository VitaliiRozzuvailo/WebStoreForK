using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    public class OrderModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}