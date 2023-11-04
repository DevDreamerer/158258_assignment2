using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ass2.Models
{
    public class Continent
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The continent name cannot be blank")]
        [Display(Name = "Continent Name")]
        public string Name { get; set; }
        public virtual ICollection<Endangered> Endangereds { get; set; }
    }
}