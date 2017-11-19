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
        public PickupDay? DayofWeek { get; set; }

        public enum PickupDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }
        
    }
}