using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.services
{
    interface IService
    {
        bool AddCargaison(Cargaison cargaison);
        List<Cargaison> ListerCargaison();
        void AddMarchandiseInGargaison(Marchandise mar);
        List<Marchandise> ListerMarchandiseDUneGargaison(Cargaison cargaison);
    }
}
