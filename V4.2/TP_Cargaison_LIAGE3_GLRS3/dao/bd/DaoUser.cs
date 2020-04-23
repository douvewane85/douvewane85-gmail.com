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
    }
}
