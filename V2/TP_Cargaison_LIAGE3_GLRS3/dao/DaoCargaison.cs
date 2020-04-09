using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.dao
{
  
    class DaoCargaison:ICargaison<Cargaison>
    {
        private static List<Cargaison> cargaisons=new List<Cargaison>();

        public DaoCargaison()
        {
            cargaisons.Add(new Aerienne()
            {
                Distance = 100000,
                PoidsTotal=0,
                VolumeTotal=0

            }
            );
            cargaisons.Add(new Aerienne()
            {
                Distance =70000 ,
                PoidsTotal = 0,
                VolumeTotal = 0

            }
            );

        }

        public static List<Cargaison> Cargaisons { get => cargaisons; set => cargaisons = value; }
        
        public  List<Cargaison> getAll()
        {
            return Cargaisons;
        }

        public bool add(Cargaison cargaison)
        {
            cargaisons.Add(cargaison);
            return true;
        }
        public Cargaison getById(int id)
        {
            return null;
        }
    }
}
