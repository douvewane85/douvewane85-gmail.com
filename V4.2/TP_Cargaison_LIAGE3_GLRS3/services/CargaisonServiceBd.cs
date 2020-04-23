using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Cargaison_LIAGE3_GLRS3.dao;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.services
{
    class CargaisonServiceBd:IService
    {
        private dao.bd.DaoCargaison daoCarg;
        private dao.bd.DaoMarchandise daoMar;
        private dao.bd.DaoUser daoUser;
        public CargaisonServiceBd()
        {
            daoCarg = new dao.bd.DaoCargaison();
            daoMar =  new dao.bd.DaoMarchandise();
            daoUser = new dao.bd.DaoUser();

        }

        public  bool AddCargaison(Cargaison cargaison)
        {
               return daoCarg.add(cargaison);           
                
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

        public User SeConnecter(string login,string pwd)
        {
            return daoUser.getUserByLoginAndPwd(login, pwd);
        }

        public void listerUser(DataGridView dtgUser)
        {
            dtgUser.DataSource = daoUser.getAllUsers();
        }
    }
}
