using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Garble.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        public DayOfWeek PickupDay { get; set; }

        public DateTime? VacationStartDate { get; set; }
        public DateTime? VacationEndDate { get; set; }

        public string Address { get; set; }

        public int? Zip { get; set; }

    }
}