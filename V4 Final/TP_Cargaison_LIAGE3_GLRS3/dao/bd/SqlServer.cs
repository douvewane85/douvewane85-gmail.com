using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Cargaison_LIAGE3_GLRS3.dao.bd
{
    class SqlServer
    {
        private SqlConnection con=new SqlConnection() ;
        //Executer les Requetes
        private SqlCommand cmd=new SqlCommand();
        //Convertir le Flux relationnel en un flux objet =>req Select
        private SqlDataAdapter da=new SqlDataAdapter();
        private DataSet ds=new DataSet();
        private DataTable dt;
        private string tableName;

        public string TableName { get => tableName; set => tableName = value; }

        public void GetConnexion()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = @"Initial Catalog= cargaison; Data Source= LAPTOP-B9KLTEJ1\SQLEXPRESS; Integrated Security= True ";
                con.Open();
            }
        }
        public void CloseConnexion()
        {
            if(con.State==ConnectionState.Open || con.State == ConnectionState.Connecting)
            {
                con.Close();
            }

        }
        public int ExecuteUpdate(string sql)
        {
            int nbreLigneModif = 0;
            //1)Connection
              GetConnexion();
            //2)BD dans laquelle on executera les requetes
             cmd.Connection = con;
            //3)On passe la requete à excuter
             cmd.CommandText = sql;
            //4)Execution de la requete
            nbreLigneModif = cmd.ExecuteNonQuery();
            //5)Fermer la connexion
             CloseConnexion();

            return nbreLigneModif;
        }
        public DataSet ExecuteSelect(string sql)
        {
            //1)Connection
            GetConnexion();
            //2)BD dans laquelle on executera les requetes
            cmd.Connection = con;
            //3)On passe la requete à excuter
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            //4)Execution de la requete
               if (ds.Tables[TableName ]!= null)
                {
                  ds.Tables[TableName].Clear();
                }
                da.Fill(ds, TableName);

            //5)Fermer la connexion
            CloseConnexion();
            return ds;
        }


    }
}
