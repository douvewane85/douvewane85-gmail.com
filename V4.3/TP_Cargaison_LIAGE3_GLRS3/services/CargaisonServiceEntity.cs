using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TP_Cargaison_LIAGE3_GLRS3.entity;


namespace TP_Cargaison_LIAGE3_GLRS3.services
{
    class CargaisonServiceBdEntity
    {
        ModelCargaison dao = new ModelCargaison();
        public CargaisonServiceBdEntity()
        {
            

        }

        public  bool AddCargaison(Cargaison cargaison)
        {
               return true;           
                
        }

        public List<Cargaison> ListerCargaison()
        {
            return dao.Cargaison.ToList();
             
        }
        public void AddMarchandiseInGargaison(Marchandise mar)
        {
            

        }

        public List<Marchandise> ListerMarchandiseDUneGargaison(Cargaison cargaison)
        {
            return dao.Marchandise.ToList().Where(mar => mar.Cargaison.Id == cargaison.Id).ToList();
        }

        public Utilisateur SeConnecter(string login,string pwd)
        {
           return dao.Utilisateur.ToList().Where(
                                 u=> u.Login.Trim().CompareTo(login)==0 &&
                                 u.Pwd.Trim().CompareTo(pwd) == 0

                        ).FirstOrDefault();
        }

        public void listerUser(DataGridView dtgUser)
        {
            dtgUser.DataSource=dao.Utilisateur.ToList();
        }

        public bool CreerUser(Utilisateur user)
        {
            dao.Utilisateur.Add(user);
            return dao.SaveChanges()!=0;   
        }

        public bool UpdateUser(Utilisateur user)
        {
           Utilisateur userUp= dao.Utilisateur.ToList().Where(u=> u.Id== user.Id).First();
            userUp.Login = user.Login;
            userUp.Pwd = user.Pwd;
            return dao.SaveChanges() != 0;
        }

        public bool DeleteUser(int id)
        {
            Utilisateur userUp = dao.Utilisateur.ToList().Where(u => u.Id == id).First();
            if (userUp != null)
            {
                dao.Utilisateur.Remove(userUp);
                return dao.SaveChanges() != 0;
            }

            return false;
            
        }


    }
}
