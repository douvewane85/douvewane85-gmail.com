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
            List<Cargaison> cargaisons=new List<Cargaison>();
            DataSet ds=ExecuteSelect("select * from cargaison");
            DataTable dt = ds.Tables[TableName];
            Cargaison carg=null;
            foreach(DataRow row in dt.Rows)
            {
                if (row.ItemArray[2].ToString().Trim().CompareTo("Aerienne") == 0)
                {
                    carg = new Aerienne();
                }
                if (carg != null)
                {
                    carg.Id = int.Parse(row.ItemArray[0].ToString().Trim());
                    carg.Distance = double.Parse(row.ItemArray[1].ToString().Trim());
                    cargaisons.Add(carg);
                }
               

            }


            return cargaisons;
        }

        public bool add(Cargaison cargaison)
        {
            string sql = string.Format("Insert into cargaison(distance,type) values({0},'{1}')",cargaison.Distance,cargaison.Type);
            return ExecuteUpdate(sql)!=0;
        }
        public Cargaison getById(int id)
        {
            return null;
        }
    }
}
