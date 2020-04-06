using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Cargaison_LIAGE3_GLRS3.models
{
    class Aerienne : Cargaison
    {
        public Aerienne()
        {
            type = "Aerienne";
        }

        public override double Cout()
        {
            int val;
            if (VolumeTotal < 80000)
            {
                val = 10;
            }
            else
            {

                val = 12;
            }
           return val * Distance * PoidsTotal ;
        }

        public override string ToString()
        {
            return base.ToString()+" Cout: "+ Cout();
        }
    }
}
