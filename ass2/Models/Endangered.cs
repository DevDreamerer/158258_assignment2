using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ass2.Models
{
    public class Endangered
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The Endangerde Species cannot be blank")]
        [Display(Name = "Endangerde Species")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Survival quantity cannot be blank")]
        [Display(Name = "Survival quantity")]
        public decimal Number { get; set; }

        [Required(ErrorMessage = "The Causes of Endangerment cannot be blank")]
        [Display(Name = "Causes of Endangerment")]
        public string Description { get; set; }
        public int? ContinentID { get; set; }
        public virtual Continent Continent { get; set; }
    }
}