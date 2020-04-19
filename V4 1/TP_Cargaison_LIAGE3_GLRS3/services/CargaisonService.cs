using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Cargaison_LIAGE3_GLRS3.dao;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.services
{
    class CargaisonService : IService
    {
        private dao.liste.DaoCargaison daoCarg;
        private dao.liste.DaoMarchandise daoMar;

        public CargaisonService()
        {
            daoCarg = new dao.liste.DaoCargaison();
            daoMar =  new dao.liste.DaoMarchandise();

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
        public void AddMarchandiseInGargaison(Marchandise mar)
        {
            daoMar.add(mar);

        }

        public List<Marchandise> ListerMarchandiseDUneGargaison(Cargaison cargaison)
        {
           return daoMar.getMarchandiseByCargaison(cargaison);
        }


    }
}
