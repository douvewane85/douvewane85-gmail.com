using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.dao
{
    class DaoMarchandise : ICargaison<Marchandise>
    {
        List<Marchandise> marchandises = new List<Marchandise>();
        

        public DaoMarchandise()
        {
            marchandises.Add(
                new Marchandise()
                {
                    Poid = 2000,
                    Volume = 5000,
                    Cargaison=DaoCargaison.Cargaisons[0]

                }
                );
            marchandises.Add(
                new Marchandise()
                {
                    Poid = 1000,
                    Volume = 6000,
                    Cargaison = DaoCargaison.Cargaisons[0]

                }
                );

            marchandises.Add(
                new Marchandise()
                {
                    Poid = 1500,
                    Volume = 2000,
                    Cargaison = DaoCargaison.Cargaisons[1]

                }
                );
        }

        public bool add(Marchandise objet)
        {
            marchandises.Add(objet);
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
            List<Marchandise> marchandisesUneCargaison = new List<Marchandise>();

            foreach(var mar in marchandises)
            {
               if(mar.Cargaison.Id== cargaison.Id)
                {
                    marchandisesUneCargaison.Add(mar);
                    cargaison.PoidsTotal += mar.Poid;
                    cargaison.VolumeTotal+= mar.Volume;
                }

            }
            
            return marchandisesUneCargaison;

        }


    }


}
