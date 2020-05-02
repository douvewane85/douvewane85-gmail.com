using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.dao.bd
{
    class DaoUser : SqlServer, ICargaison<User>
    {
        public DaoUser()
        {
            TableName = "utilisateurs";
        }

        public bool add(User objet)
        {
            throw new NotImplementedException();
        }

        public List<User> getAll()
        {
            throw new NotImplementedException();
        }

        public DataTable getAllUsers()
        {
            string sql = string.Format("select * from utilisateur ");
            DataSet ds = base.ExecuteSelect(sql);
            DataTable dt = ds.Tables[TableName];
            return dt;
        }

        public User getById(int id)
        {
            throw new NotImplementedException();
        }

        public User getUserByLoginAndPwd(string login,string pwd)
        {
            string sql = string.Format("select * from utilisateur where login='{0}' and pwd='{1}'", login, pwd);
            DataSet ds=base.ExecuteSelect(sql);
            DataTable dt = ds.Tables[TableName];
            User user = null;
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                user = new User()
                {
                   Id=int.Parse(row.ItemArray[0].ToString()),
                   FullName=row.ItemArray[1].ToString(),
                   Login=row.ItemArray[2].ToString(),
                   Pwd=row.ItemArray[3].ToString(),
                };

            }
            return user;

        }

        public bool deleteUser(int id)
        {
            string sql = string.Format("delete from utilisateur where id={0}", id);
            return base.ExecuteUpdate(sql) != 0;       
                
        }

        public bool addUser(User user)
        {
            string sql = string.Format("insert into utilisateur(fullname,login,pwd,profil) values('{0}','{1}','{2}','{3}')", user.FullName,user.Login,user.Pwd,user.Profil);
            return base.ExecuteUpdate(sql) != 0;

        }

        public bool UpdateUser(User user)
        {
            string sql = string.Format("insert into utilisateur(fullname,login,pwd)", user.FullName, user.Login, user.Pwd);
            return base.ExecuteUpdate(sql) != 0;

        }
    }
}
