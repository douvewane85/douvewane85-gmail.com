namespace TP_Cargaison_LIAGE3_GLRS3.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marchandise")]
    public partial class Marchandise
    {
        public int Id { get; set; }

        public float Poids { get; set; }

        public float Volume { get; set; }

        public int Cargaison_id { get; set; }
        //virtual =>chargement Lazy(Paresseux)
        public virtual Cargaison Cargaison { get; set; }
    }
}
