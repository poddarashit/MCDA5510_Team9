namespace TrainReserveSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Train_Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Train_Detail()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Train_Detail_ID { get; set; }

        public int Train_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Source { get; set; }

        [Required]
        [StringLength(50)]
        public string Destination { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_Of_Travel { get; set; }

        [StringLength(50)]
        public string Train_Name { get; set; }

        public double Fare { get; set; }

        public int? Total_Seats_Available { get; set; }

        public int? Vacant_Seats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
