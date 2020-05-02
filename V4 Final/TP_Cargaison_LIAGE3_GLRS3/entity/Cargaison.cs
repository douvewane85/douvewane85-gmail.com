namespace TP_Cargaison_LIAGE3_GLRS3.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cargaison")]
    public abstract partial class Cargaison
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cargaison()
        {
            Marchandise = new HashSet<Marchandise>();
        }

        public int Id { get; set; }

        public float Distance { get; set; }

        [Required]
        [StringLength(100)]
        public string Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Marchandise> Marchandise { get; set; }

        //---------------------------------

        private double poidsTotal;
        private double volumeTotal;
        [NotMapped]
        public double PoidsTotal { get => poidsTotal; set => poidsTotal = value; }
        [NotMapped]
        public double VolumeTotal { get => volumeTotal; set => volumeTotal = value; }

        public override string ToString()
        {
            return " Distance : " + Distance + " Type : " + Type;
        }

        public abstract double Cout();

    }
}
