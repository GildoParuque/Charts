using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Charts.Models
{
    public class SalesOrder
    {
        [Key]
        public int id { get; set; }

        public int zone { get; set; }

        public double sale_amount { get; set; }
    }
}
