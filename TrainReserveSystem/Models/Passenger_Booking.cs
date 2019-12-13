namespace TrainReserveSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Passenger_Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PB_ID { get; set; }

        public int FK_Booking_ID { get; set; }

        public int FK_ID { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Passenger_Details Passenger_Details { get; set; }
    }
}
