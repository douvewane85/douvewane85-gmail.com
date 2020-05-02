using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Cargaison_LIAGE3_GLRS3.entity
{
    class Aerienne : Cargaison
    {
        public Aerienne()
        {
            Type = "Aerienne";
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

        
    }
}
