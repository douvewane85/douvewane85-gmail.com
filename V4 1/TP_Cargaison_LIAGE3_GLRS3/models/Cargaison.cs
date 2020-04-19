using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Cargaison_LIAGE3_GLRS3.models
{
    abstract class Cargaison
    {
        private static int nbreCargaison;
        private  int id;
        private double distance;
        private double poidsTotal;
        private double volumeTotal;
        protected string type;

        public static int NbreCargaison { get => nbreCargaison; set => nbreCargaison = value; }
        public int Id { get => id; set => id = value; }
        public double Distance { get => distance; set => distance = value; }
        public double PoidsTotal { get => poidsTotal; set => poidsTotal = value; }
        public double VolumeTotal { get => volumeTotal; set => volumeTotal = value; }
        public string Type { get => type;  }

        public  Cargaison()
        {
            id = ++nbreCargaison;
           
        }

        public override string ToString()
        {
            return " Distance : " + Distance +" Type : "+Type;
        }

        public abstract double Cout();
    }
}
