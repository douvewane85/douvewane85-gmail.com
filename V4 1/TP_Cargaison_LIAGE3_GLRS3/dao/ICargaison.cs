using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Cargaison_LIAGE3_GLRS3.dao
{
    interface ICargaison<T>
    {
        List<T> getAll();
        bool add(T objet);
        T getById(int id);
    }
}
