using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sandbox.Models
{
    public class Item
    {
        [Required]
        [Display(Name = "Item Name")]
        public string Name { get; set; }

    }
}