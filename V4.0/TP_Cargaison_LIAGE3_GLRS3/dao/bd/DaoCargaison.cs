using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.dao.bd
{
  
    class DaoCargaison:SqlServer ,ICargaison<Cargaison>
    {
       
        public DaoCargaison()
        {
            TableName = "cargaison";
        }

        public List<Cargaison> getAll()
        {
            string sql = "select * from cargaison";
            List<Cargaison> cargaisons = new List<Cargaison>();
            DataSet ds=base.ExecuteSelect(sql);
            DataTable dt = ds.Tables[TableName];
            Cargaison cargaison =null;
            foreach(DataRow row in dt.Rows)
            {
                string type = row.ItemArray[2].ToString().Trim();
                if (type.CompareTo("Aerienne") == 0)
                {
                    cargaison = new Aerienne();
                }
                cargaison.Id = int.Parse(row.ItemArray[0].ToString());
                cargaison.Distance = double.Parse(row.ItemArray[1].ToString());
                cargaisons.Add(cargaison);

            }
            return cargaisons;
        }

        public bool add(Cargaison cargaison)
        {
            string sql =string.Format("insert into cargaison (distance,type) values({0},'{1}')",cargaison.Distance,cargaison.Type);
            return base.ExecuteUpdate(sql)!=0;
        }
        public Cargaison getById(int id)
        {
            string sql = string.Format("select * from cargaison where id={0}", id);
            DataSet ds= base.ExecuteSelect(sql);
            DataTable dt = ds.Tables[TableName];
            Cargaison cargaison=null;
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                string type = row.ItemArray[2].ToString().Trim();
                if (type.CompareTo("Aerienne") == 0)
                {
                    cargaison = new Aerienne();
                    cargaison.Id = int.Parse(row.ItemArray[0].ToString());
                    cargaison.Distance = double.Parse(row.ItemArray[1].ToString());
                }
               
              

            }
            return cargaison;
        }
    }
}
