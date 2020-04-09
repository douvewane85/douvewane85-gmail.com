using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Cargaison_LIAGE3_GLRS3.models
{
   

    class Marchandise
    {
        private static int nbreMarchandise;
        private  int numero;
        private double poid;
        private double volume;
        //ManyToOne=> attribut de navigation
        private Cargaison cargaison;

        public Marchandise()
        {
            numero = ++nbreMarchandise;
        }

        public int Numero { get => numero; set => numero = value; }
        public double Poid { get => poid; set => poid = value; }
        public double Volume { get => volume; set => volume = value; }
        public Cargaison Cargaison { get => cargaison; set => cargaison = value; }

        public override string ToString()
        {
            return   string.Format("Numero :{0} Poids : {1}",Numero,Poid);
        }
    }
}
