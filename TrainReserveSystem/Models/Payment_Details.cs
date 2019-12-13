using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainReserveSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public class Payment_Details
    {
        [Required]
        public string cardtype { get; set; }

        [Required]
        [StringLength(16)]
        public string name { get; set; }

        [Required]
        public long creditcardnumber { get; set; }

        [Required]
        public string expirydate { get; set; }

    }
}