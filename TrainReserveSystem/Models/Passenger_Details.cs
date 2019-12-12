namespace TrainReserveSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Passenger_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passenger_Details()
        {
            Passenger_Booking = new HashSet<Passenger_Booking>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string FName { get; set; }

        [Required]
        [StringLength(50)]
        public string LName { get; set; }

        public int? Age { get; set; }

        [StringLength(255)]
        public string P_Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passenger_Booking> Passenger_Booking { get; set; }
    }
}
