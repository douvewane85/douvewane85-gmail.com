using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Cargaison_LIAGE3_GLRS3.dao;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.services
{
    class CargaisonService
    {
        private DaoCargaison daoCarg;

        public CargaisonService()
        {
            daoCarg = new DaoCargaison();
        }

        public bool addCargaison(Cargaison cargaison)
        {
                daoCarg.add(cargaison);           
                return true;
        }
        public List<Cargaison> listerCargaison()
        {
            return daoCarg.getAll();
             
        }

    }
}
