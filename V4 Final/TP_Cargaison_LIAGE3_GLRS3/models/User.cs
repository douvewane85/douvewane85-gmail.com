using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Cargaison_LIAGE3_GLRS3.models
{
    public class User
    {
        private int id;
        private string fullName;
        private string login;
        private string pwd;
        private string profil;

        public User()
        {
        }

        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Login { get => login; set => login = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Profil { get => profil; set => profil = value; }
    }
}
