using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.dao.bd
{
    class DaoMarchandise : ICargaison<Marchandise>
    {
        
        

        public DaoMarchandise()
        {
            
        }

        public bool add(Marchandise objet)
        {
           
            return true;
        }

        public List<Marchandise> getAll()
        {
            throw new NotImplementedException();
        }

        public Marchandise getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Marchandise> getMarchandiseByCargaison(Cargaison cargaison)
        {
            /* List<Marchandise> marchandisesUneCargaison = new List<Marchandise>();

             foreach(var mar in marchandises)
             {
                if(mar.Cargaison.Id== cargaison.Id)
                 {
                     marchandisesUneCargaison.Add(mar);
                     cargaison.PoidsTotal += mar.Poid;
                     cargaison.VolumeTotal+= mar.Volume;


                 }
        }*/

            return null;

        }


    }


}
