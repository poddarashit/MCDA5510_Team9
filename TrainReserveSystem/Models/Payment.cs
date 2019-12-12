namespace TrainReserveSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Payment_ID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? FK_Booking_ID { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
