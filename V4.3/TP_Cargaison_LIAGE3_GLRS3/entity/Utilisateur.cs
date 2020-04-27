namespace TP_Cargaison_LIAGE3_GLRS3.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Utilisateur")]
    public partial class Utilisateur
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string FullName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string Login { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string Pwd { get; set; }

        [StringLength(100)]
        public string Profil { get; set; }
    }
}
