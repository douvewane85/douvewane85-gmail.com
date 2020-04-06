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
        private DaoMarchandise daoMar;

        public CargaisonService()
        {
            daoCarg = new DaoCargaison();
            daoMar = new DaoMarchandise();

        }

        public bool AddCargaison(Cargaison cargaison)
        {
                daoCarg.add(cargaison);           
                return true;
        }

        public List<Cargaison> ListerCargaison()
        {
            return daoCarg.getAll();
             
        }
        public void AddMarchandiseInGargaison()
        {

        }

        public List<Marchandise> ListerMarchandiseDUneGargaison(Cargaison cargaison)
        {
           return daoMar.getMarchandiseByCargaison(cargaison);
        }


    }
}
