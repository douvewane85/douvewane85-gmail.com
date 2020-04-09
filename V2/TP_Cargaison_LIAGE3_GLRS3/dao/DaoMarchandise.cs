using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.dao
{
    class DaoMarchandise : ICargaison<Marchandise>
    {
        private List<Marchandise> marchandises = new List<Marchandise>();
     
        public DaoMarchandise()
        {
           
            marchandises.Add(new Marchandise()
            {
                Poid = 100000,
                Volume = 0,
                Cargaison = DaoCargaison.Cargaisons[0]

            }
            );
            marchandises.Add(new Marchandise()
            {
                Poid = 1000,
                Volume = 100,
                Cargaison = DaoCargaison.Cargaisons[0]

            }
            );
            marchandises.Add(new Marchandise()
            {
                Poid = 20000,
                Volume = 3,
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
            List<Marchandise> marchand = new List<Marchandise>();
            foreach(var mar in this.marchandises)
            {
                MessageBox.Show(mar.Cargaison.Id.ToString() +"== " +cargaison.Id.ToString());
                if (mar.Cargaison.Id== cargaison.Id)
                {
                    
                    marchand.Add(mar);
                    cargaison.PoidsTotal += mar.Poid;
                    cargaison.VolumeTotal += mar.Volume;
                }
            }

            return marchand;
        }


    }


}
