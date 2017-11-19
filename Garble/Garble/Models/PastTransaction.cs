using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garble.Models
{
    public class PastTransaction
    {
        [Key]
        public int PastTransactionID { get; set; }
        public Customer Customer { get; set; }

        [DataType(DataType.Currency)]
        public decimal PickupPrice { get; set; }

        public bool IsPaid { get; set; }
    }
}